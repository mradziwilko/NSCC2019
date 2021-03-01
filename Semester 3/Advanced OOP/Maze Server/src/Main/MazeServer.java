package Main;
import java.io.File;
import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;

import Database.Create;
import Database.CreateTable;
import Database.InsertRecords;
import Properties.GameProperties;


public class MazeServer {

	static int numberAccounts;
	static Player plr;
	static int SERVER_PORT;

	
	public static void main(String[] args) throws IOException {
		File file = new File (GameProperties.GAME_PATH +"/MazeServer.db");
		InsertRecords app = new InsertRecords();
		
		if(!file.exists()){
			  Create.createNewDatabase(GameProperties.GAME_PATH +"/MazeServer.db");		       
		       CreateTable.createNewTable();

			
		}
		
		
		
		numberAccounts = 1;
		plr = new Player(numberAccounts);
		
		SERVER_PORT = 5556;
		

		//set up a server to listen for connections on a socket
		ServerSocket server = new ServerSocket(SERVER_PORT);
		System.out.println("Waiting for the client to connect...");
		
		//set up an infinite loop to listen for connections
		while(true) {
			//when request comes in
				//pass the request to a service to process the command
			Socket s = server.accept();
			System.out.println("Client connected...");
			System.out.println("The Service...");
			
			MazeService myService = new MazeService(s, plr);
			Thread t = new Thread(myService);
			t.start();
		}


	}

}
