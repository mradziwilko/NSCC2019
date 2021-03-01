package Main;

import Properties.GameProperties;
import java.util.List;

import Assets.BackgroundMusic;
import Database.Create;
import Database.CreateTable;
import Database.InsertRecords;
import Database.SelectRecords;

import Database.Update;

import java.awt.*;
import java.awt.event.*;
import java.io.*;
import java.net.Socket;
import java.net.SocketException;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;

import javax.imageio.ImageIO;
import javax.swing.*;
import javax.swing.border.EtchedBorder;
import javax.swing.table.DefaultTableCellRenderer;
import javax.swing.table.TableCellRenderer;

import java.awt.Image;
@SuppressWarnings("serial")
public class Title extends JFrame implements KeyListener, ActionListener{
	
	public static BackgroundMusic bm;
    public static JFrame content;
    public static String user="", pass="", name;
    public static Title myGame;
    public static String userName;
    public static String playerName = null;
    public static int playerSID = 0;
    public static String command;
    public static String ResString;
    public static Object data;
	static int SOCKET_PORT;
	static Socket s;
	public static boolean timerstop = false;
	public static OutputStream outstream;
	public static PrintWriter out;
	public static InputStream instream;
	public static Scanner in;
	public static String response;
	public static String TopName, TopScore;
    public static String[][] newPlrList = new String[10][2];
    public static List<String> list;
    
    public static Timer timer;
	public static File file;
	public static Update upp;
	public static InsertRecords app;
	public static SelectRecords records;
    // Display Main Title
	public static boolean connError;
	public JTable table;
	public Title() throws IOException  {
		super(GameProperties.TITLE);
		
		setSize(GameProperties.SCREEN_WIDTH, GameProperties.SCREEN_HEIGHT);

        getContentPane().setLayout(null);
        setDefaultCloseOperation(EXIT_ON_CLOSE);        
        setResizable(false);
        setLocationRelativeTo(null);
        setIconImage(getIconImage());
                
        // get Player name from Database
        //playerName = records.selectName();
        
        // Background Music Start
        //bm.start();


        // Actions for buttons
		AbstractAction StartMaze = new AbstractAction() {
			@Override
	        public void actionPerformed(ActionEvent e) {
	            try {
	            	timerstop = true;
					new Maze();
				} catch (IOException e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
	            setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
	            dispose();
	        }
			
		};
		
		
	    AbstractAction ExitProgram = new AbstractAction() {
	    	@Override
	        public void actionPerformed(ActionEvent e) {
	    		//bm.stop();
	            dispose();
	        }
	    };
	    AbstractAction ResetDb = new AbstractAction() {
	    	@Override
	        public void actionPerformed(ActionEvent e) {

	    		Update.ClearUser();
	    	}
	    };


	    
	    // UI Items
	    JButton quit =new JButton();
	    JButton Start = new JButton();
	    JButton reset = new JButton();
	    JLabel logo = new JLabel();
        JLabel wallpaper = new JLabel();
        JLabel lblServerStatus = new JLabel("");
	        
	    // Start Button
		Start.setBorderPainted(false);
		Start.setIcon(new ImageIcon(GameProperties.GAME_PATH +"/resources/Images/start.png"));
		Start.setForeground(new Color(50, 50, 255));
		Start.setBounds(10, 676, 200, 73);

		Start.setBorderPainted(false); 
		Start.setContentAreaFilled(false); 
		Start.setBorderPainted(false); 
		Start.setContentAreaFilled(false); 
		Start.setFocusPainted(false); 
		Start.setOpaque(false);
			        
		// Quit Button
		quit.setBorder(null);
		quit.setIcon(new ImageIcon(GameProperties.GAME_PATH +"/resources/Images/quit.png"));
		quit.setBounds(430,674,200,75);
		quit.setForeground(new Color(50,50,255));
		quit.addActionListener(ExitProgram);
		quit.setContentAreaFilled(false); 
		quit.setBorderPainted(false); 
		quit.setContentAreaFilled(false); 
		quit.setFocusPainted(false); 
		quit.setOpaque(false);

	    // Reset Button
		reset.setBorder(null);
		reset.setIcon(new ImageIcon(GameProperties.GAME_PATH +"/resources/Images/reset.png"));
		reset.setBounds(220,674,200,75);
		reset.setForeground(new Color(50,50,255));


		
		reset.setContentAreaFilled(false); 
		reset.setBorderPainted(false); 
		reset.setContentAreaFilled(false); 
		reset.setFocusPainted(false); 
		reset.setOpaque(false);


        lblServerStatus.setForeground(Color.WHITE);
        lblServerStatus.setFont(new Font("Tahoma", Font.PLAIN, 18));
        lblServerStatus.setBounds(26, 633, 620, 30);

        
		// Logo
        logo.setHorizontalAlignment(SwingConstants.CENTER);
        logo.setBounds(10,37,760,92);
        ImageIcon imgLogo= new ImageIcon(GameProperties.GAME_PATH +"/resources/Images/logo.png");
        Icon iconoLogo = new ImageIcon(imgLogo.getImage().getScaledInstance(logo.getWidth(),logo.getHeight(), Image.SCALE_DEFAULT));
        logo.setIcon(iconoLogo);

        
        // Background
        ImageIcon img = new ImageIcon(GameProperties.GAME_PATH +"/resources/Images/bg.jpg");
        Icon background = new ImageIcon(img.getImage().getScaledInstance(this.getWidth(),this.getHeight(), Image.SCALE_DEFAULT));
        
        
        // Get Images for each Button's Hover and Normal Mouse over
        try {
        	Image imgstart = ImageIO.read(getClass().getResource("/resources/Images/start.png")); 
			Image imagestartHover = ImageIO.read(getClass().getResource("/resources/Images/starthover.png"));
			Image imgquit = ImageIO.read(getClass().getResource("/resources/Images/quit.png")); 
			Image imagequitHover = ImageIO.read(getClass().getResource("/resources/Images/quithover.png"));
			Image imgreset = ImageIO.read(getClass().getResource("/resources/Images/reset.png")); 
			Image imageresetHover = ImageIO.read(getClass().getResource("/resources/Images/resethover.png"));
			Start.setIcon(new ImageIcon(imgstart));
			Start.setRolloverIcon(new ImageIcon(imagestartHover));
			quit.setIcon(new ImageIcon(imgquit));
			quit.setRolloverIcon(new ImageIcon(imagequitHover));
			reset.setIcon(new ImageIcon(imgreset));
			reset.setRolloverIcon(new ImageIcon(imageresetHover));
        } catch (Exception ex) {
        	System.out.println(ex);
        }
        

        wallpaper.setBounds(0,0,794, 800);
        wallpaper.setIcon(background);
        
        

        if(connError == false) {
        	Start.addActionListener(StartMaze);
        	Start.setVisible(true);
        	reset.addActionListener(ResetDb);
        	reset.setVisible(true);
            lblServerStatus.setText(ResString);
            
            
        }else {
        	Start.setVisible(false);
        	reset.setVisible(false);
            lblServerStatus.setText("Server Status: Offline.");	
        }
        //headers for the table
        String[] columns = new String[] {
            "Name", "Score"
        };

        //create table with data
        table = new JTable(newPlrList, columns){
            private static final long serialVersionUID = 1L;

            public boolean isCellEditable(int row, int column) {                
                    return false;               
            };
            protected void paintComponent(Graphics g)
            {
                g.setColor( new Color(255, 0, 0, 0) );
                g.fillRect(0, 0, getWidth(), getHeight());
                super.paintComponent(g);
            }
            @Override
            public Component prepareRenderer(TableCellRenderer renderer, int row,
                int col) {
              Component comp = super.prepareRenderer(renderer, row, col);
              ((JLabel) comp).setHorizontalAlignment(JLabel.CENTER);
              return comp;
            }
        };
        table.setEnabled(false);
        table.setBorder(BorderFactory.createEmptyBorder());
        table.setSelectionBackground(null);
        table.setRowSelectionAllowed(false);
        table.setColumnSelectionAllowed(false);
        table.setCellSelectionEnabled(false);
        table.setShowVerticalLines(false);
        table.setShowHorizontalLines(false);
        table.setBorder(null);
        table.setBounds(10, 158, 448, 464);
        table.setSelectionBackground(null);
        table.setBackground(null);
        table.setShowGrid(false);
        table.setOpaque(false);
 table.setForeground(null);

 table.getTableHeader().setOpaque(false);
        
        JScrollPane scrollpane = new JScrollPane(table);
        DefaultTableCellRenderer centerRenderer = new DefaultTableCellRenderer();
        centerRenderer.setHorizontalAlignment( SwingConstants.CENTER );
        table.setDefaultRenderer(String.class, centerRenderer);
        table.setDefaultRenderer(int.class, centerRenderer);
        scrollpane.setEnabled(false);
        scrollpane.setHorizontalScrollBarPolicy(ScrollPaneConstants.HORIZONTAL_SCROLLBAR_NEVER);
        scrollpane.setVerticalScrollBarPolicy(ScrollPaneConstants.VERTICAL_SCROLLBAR_NEVER);
        scrollpane.setViewportBorder(null);
        scrollpane.setLocation(26, 178);
        scrollpane.setSize(229, 295);
        scrollpane.setBackground(null);
        scrollpane.setForeground(null);
        scrollpane.setOpaque(false);
        scrollpane.setOpaque(false);
        scrollpane.getViewport().setOpaque(false);
        scrollpane.setBorder(BorderFactory.createEmptyBorder());    

        table.getTableHeader().setReorderingAllowed(false); // not allow re-ordering of columns
        table.getTableHeader().setResizingAllowed(false);
        getContentPane().add(scrollpane);
        
        
        
        
        
        
        
        
        
        
        
        
        getContentPane().add(lblServerStatus);
        getContentPane().add(reset);
        getContentPane().add(quit);
        getContentPane().add(logo);
        getContentPane().add(Start);
        getContentPane().add(wallpaper);


        // Updates UI Ever Half Second. Updates Player Deaths, Wins, and Names if changed. When New Player is clicked, checks for Blank name.
		int delay = 2000; //milliseconds
	    ActionListener taskPerformer = new ActionListener() {
	    	public void actionPerformed(ActionEvent evt) {
	    		
		       if(timerstop == false) {

		    		getTopTen();	    		
					chkPlrName();
					 table.repaint(); 
		       }else {
		    	   
		       }
	    	}

	    };	    
	    new Timer(delay, taskPerformer).start();
	
	    setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setVisible(true);
	}

	public static void main(String[] args) throws IOException {
		SOCKET_PORT = 5556;
		connError = false;
		 try {
		s = new Socket("127.0.0.1", SOCKET_PORT);
		   } catch (SocketException exception) {
	            // Output expected SocketExceptions.
	            System.out.println(exception);
	            connError = true;
	        } catch (IOException exception) {
	            // Output unexpected IOExceptions.
	        	connError = true;
	            System.out.println(exception);
	        }
		
		 if(connError == false) {
			 
			 outstream = s.getOutputStream();
			 out = new PrintWriter(outstream);
			 instream = s.getInputStream();
			 in = new Scanner(instream);
		
			 getTopTen();
		
		
		
		command = "STATUS\n";
		out.print(command);
		out.flush();		
		response = in.nextLine();
		ResString = response;

		
		// CHECK IF FILE EXISTS Database
				file = new File (GameProperties.GAME_PATH +"/themaze.db");
				app = new InsertRecords();
				upp = new Update();  
				// If Database Exists Load Items from Database, If not, Create new Database
				if(file.exists()){
					
					
					  records = new SelectRecords();					 
					  playerName = records.selectName();			 
					  playerSID = records.selectSID();
					  
				       while (playerName == null || playerName == ""){
							playerName = JOptionPane.showInputDialog("Please enter your name: ");
							command = "ADDPLR "+ playerName +" \n";
							out.print(command);
							out.flush();		
							response = in.nextLine();
							System.out.println(response);
							playerSID = Integer.valueOf(response);

						       // Insert Default User, As this is Single Player it only requires 1.
							Update.UpdateName(playerName);
							Update.UpdateSID(playerSID);
				       }
				     }
				     else{
				    	 

				       Create.createNewDatabase(GameProperties.GAME_PATH +"/themaze.db");		       
				       CreateTable.createNewTable();

				       
				       while (playerName == null){
							playerName = JOptionPane.showInputDialog("Please enter your name: ");
				        	
				       }
				       

						command = "ADDPLR "+ playerName +" \n";
						out.print(command);
						out.flush();		
						response = in.nextLine();
						System.out.println(response);
						playerSID = Integer.valueOf(response);
				       
				       // Insert Default User, As this is Single Player it only requires 1.
				    app.insert(1, playerSID, playerName);  
				    	
				     }

				
				
		
		
		
		 }
		// Creates UI
		myGame = new Title();        
		myGame.setVisible(true);
		myGame.setResizable(false);
		//close the socket
	}
	
	
	
	private static void getTopTen() {


		list = new ArrayList<String>();
        
		command = "TOPTEN\n";
		out.print(command);
		out.flush();		
		response = in.nextLine();
		String[] topten = response.split(",");
		Collections.addAll(list, topten);

		for(int i=0;i<list.size();i++){
		  //  System.out.println(list.get(i));

			command = "TOPNAME "+ list.get(i) +"\n";
			out.print(command);
			out.flush();		
			response = in.nextLine();
			TopName = response;
			
			command = "TOPWINCOUNT "+ list.get(i) +" \n";
			out.print(command);
			out.flush();		
			response = in.nextLine();
			TopScore = response;
			TopName = TopName.replace("null","");
			TopScore = TopScore.replace("null","");

			newPlrList[i][0] = TopName;
			newPlrList[i][1] = TopScore;

			
		} 

		System.out.println("Updated "+ playerName +" Scores");
	}

	public void chkPlrName() {
		// TODO Auto-generated method stub
		while (playerName == null || playerName == ""){
			playerName = JOptionPane.showInputDialog("Please enter your name: ");
			command = "ADDPLR "+ playerName +" \n";
			out.print(command);
			out.flush();		
			response = in.nextLine();
			playerSID = Integer.valueOf(response);
			Update.UpdateName(playerName);
			Update.UpdateSID(playerSID);
       }
	}

	// ================== NOT USED =============================
	@Override
	public void actionPerformed(ActionEvent e) {

		
	}
	@Override
	public void keyTyped(KeyEvent e) {

		
	}
	@Override
	public void keyPressed(KeyEvent e) {

		
	}
	@Override
	public void keyReleased(KeyEvent e) {

		
	}
}

