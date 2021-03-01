package Main;
import java.io.IOException;
import java.io.PrintWriter;
import java.net.Socket;
import java.util.Scanner;

import Database.InsertRecords;
import Database.SelectRecords;
import Database.Update;

public class MazeService implements Runnable {
	
	private Socket s;
	private Scanner in;
	private PrintWriter out;
	private Player plr;

	private Map m;
    SelectRecords selRec = new SelectRecords();
	InsertRecords insRec = new InsertRecords();  
	Update UpdRec = new Update();  
    
	public MazeService(Socket temp1, Player temp2) {
		s = temp1;		plr = temp2;
	}
	
	public void run() {
		
		try {
			in = new Scanner(s.getInputStream());
			out = new PrintWriter(s.getOutputStream());
			
			processRequest();
		} catch(IOException e) {
			e.printStackTrace();
		} finally {
			try {
				s.close();
			} catch(IOException e) {
				e.printStackTrace();
			}
		}
	}
	
	private void processRequest() throws IOException {
		while(true) {
			if ( !in.hasNext() ) { return; }
			String command = in.next();
			
			if(command.equals("QUIT")) { return; }
			executeCommand(command);
		}
	}
	
	private void executeCommand(String command)  throws IOException {

		 
		if (command.equals("STATUS")) {
			
			
			out.println("Status: Connected");	
			
		}
 
		if (command.equals("GETNAME")) {

			String Name = in.next();
			
			out.println("name Requested: " + Name);	
			
		}
		
		if (command.equals("ADDPLR")) {

			String Name = in.next();
			insRec.addUser(Name); 
			Integer newID = selRec.getUserId(Name);
			
			out.println(newID);	
			
		}
		

		 
		if (command.equals("TOPNAME")) {

			int id = in.nextInt();
			String name = selRec.getTopName(id);
			out.println(name);	
			
		}

		 
		if (command.equals("TOPWINCOUNT")) {

			int id = in.nextInt();
			int topWC = selRec.getTopWinCount(id);
			
			out.println(topWC);	
			
		}
		

		if (command.equals("MOVE")) {

			String DIRECTION = in.next();
			String TILECODE = in.next();
			int CLIENTID = in.nextInt();		
			int CHK = chkCode(TILECODE);
			String respString;

			
			out.println(CHK);		
	        
			LogSys(CHK, CLIENTID);

		}

		if (command.equals("DEATH")) {

			int plr = in.nextInt();

			// ADD DEATH TO PLAYER
			UpdRec.UpdateDeath(plr);
			int deaths = selRec.getDeaths(plr);
			out.println(deaths);	
			
		}


		if (command.equals("WIN")) {

			int plr = in.nextInt();
			
			
			// ADD DEATH TO PLAYER
			UpdRec.UpdateWin(plr);
			int wins = selRec.getWins(plr);
			out.println(wins);	
			
		}

		if (command.equals("TOPTEN")) {
			out.println(selRec.getTopTen());
		}
		
		
		out.flush();
	}
	
public void LogSys(int cHK, int cid) {
	String plrname = selRec.getName(cid);
	if(cHK == 0) {
		System.out.println(plrname +" Blocked by Wall");
		
	}else if(cHK == 1) {
		System.out.println(plrname +" Player Moved");
	}else if(cHK == 2) {
		System.out.println(plrname +" Player Finished");
	}else if(cHK == 3) {
		System.out.println(plrname +" Player Died");
	}
}
	// Check for next title, if it is a g F V X or C = Able to move on tiles, otherwise Block Movement. (Collision Detection)
public int chkCode(String chosen) {
		
		if(chosen.equals("g")) {
			return 1;
		}else if(chosen.equals("f")) {
			return 2;			
		}else if(chosen.equals("v")) {
			return 3;
		}else if(chosen.equals("x")) {
			return 1;
		}else if(chosen.equals("c")) {
			return 1;
		}else {
			return 0;
		}
	}
	

}
