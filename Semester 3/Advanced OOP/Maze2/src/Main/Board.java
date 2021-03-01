package Main;
import Assets.*;
import Database.Update;
import Properties.GameProperties;
import Database.*;

import java.awt.*;
import java.awt.event.*;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.io.PrintWriter;
import java.net.Socket;
import java.net.SocketException;
import java.util.Random;
import java.util.Scanner;

import javax.imageio.ImageIO;
import javax.swing.*;

@SuppressWarnings("serial")
public class Board extends JPanel implements ActionListener {
	
	// Set Variables 
	@SuppressWarnings("unused")
	private Timer timer;
	private Map m;
	private Player p;
	private Font font = new Font("Serif",Font.BOLD, 35);	
	private int deathCount = 0;
	private boolean win = false;
	private boolean disable = false;	
	BackgroundMusic bm;
	DeadMusic bmdead;
	WinMusic bmwin;

	static int SOCKET_PORT;
	static Socket s;

    public static String ResString;
	public static boolean connError;
	public static OutputStream outstream;
	public static PrintWriter out;
	public static InputStream instream;
	public static Scanner in;
	public static String command;
	public static String response;
	public int MapID;

    String playerName;
    public static int playerID;
    SelectRecords records;
    
	public Board()  throws IOException{
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
		//initialize an output stream
	    outstream = s.getOutputStream();
		out = new PrintWriter(outstream);
		
		//initialize an input stream to receive data back from the server
		instream = s.getInputStream();
		in = new Scanner(instream);
		

		 }
		 

		records = new SelectRecords();
        playerName = records.selectName();
        playerID = records.selectSID();
        
        
        bmdead = new DeadMusic(GameProperties.GAME_PATH +"/resources/Music/dead.mp3");
        bmwin = new WinMusic(GameProperties.GAME_PATH + "/resources/Music/win.mp3");
        bm = new BackgroundMusic(GameProperties.GAME_PATH + "/resources/Music/bg2.mp3");

        bm.stop();

        if(!bmwin.equals(null)) {
        bmwin.stop();
        }

        if(!bmdead.equals(null)) {
        	bmdead.stop();
        }

       // bm.start();
        
        MapID = genMapID();
        m = new Map(MapID);
		p = new Player();
		
		
		addKeyListener(new AL());
		setFocusable(true);
			
		timer = new Timer(25,this);
		
		
	}

public int genMapID() {
	Random rand = new Random();
	int upperbound = GameProperties.CURR_MAPS;
	int int_random = rand.nextInt(upperbound);	 
	return int_random;
}


	@Override
	public void actionPerformed(ActionEvent e) {
		repaint();	
	}


	
	public void paint(Graphics g) {
		super.paint(g);


			// This is for the tiles on screen, each letter represents a letter and image graphic
		
		
		// LIST USED:
		//     - g = Grass
		//     - f = Finish
		//     - v = Death Trap
		//     - q,w,e,r,t,y,u,i,o,p,a,s,d,h,j,k = Walls
		
		
		// IF Win Flag is Not Set, Draw Board, if Win is Set Draw Win UI
		if(!win) {	
		
			for(int y = 0; y < 59; y++){
				for( int x = 0; x < 61; x++) {
					
					// Place Grass if G
					if(m.getMap(x, y).equals("g")) {
						g.drawImage(m.getGrass(), x*16, y*16, null);
					}
					
					
					// FINISH LINE
					if(m.getMap(x, y).equals("f")) {
						g.drawImage(m.getFinish(), x*16, y*16, null);
					}
					
					// WALLS: 
					if(m.getMap(x, y).equals("q")) {
						g.drawImage(m.getWall0(), x*16, y*16, null);
					}
	
					if(m.getMap(x, y).equals("w")) {
						g.drawImage(m.getWall1(), x*16, y*16, null);
					}
	
					if(m.getMap(x, y).equals("e")) {
						g.drawImage(m.getWall2(), x*16, y*16, null);
					}
	
					if(m.getMap(x, y).equals("r")) {
						g.drawImage(m.getWall3(), x*16, y*16, null);
					}
	
					if(m.getMap(x, y).equals("t")) {
						g.drawImage(m.getWall4(), x*16, y*16, null);
					}
	
					if(m.getMap(x, y).equals("y")) {
						g.drawImage(m.getWall5(), x*16, y*16, null);
					}
	
					if(m.getMap(x, y).equals("u")) {
						g.drawImage(m.getWall6(), x*16, y*16, null);
					}
	
					if(m.getMap(x, y).equals("i")) {
						g.drawImage(m.getWall7(), x*16, y*16, null);
					}
	
					if(m.getMap(x, y).equals("o")) {
						g.drawImage(m.getWall8(), x*16, y*16, null);
					}
	
					if(m.getMap(x, y).equals("p")) {
						g.drawImage(m.getWall9(), x*16, y*16, null);
					}
	
					if(m.getMap(x, y).equals("a")) {
						g.drawImage(m.getWall10(), x*16, y*16, null);
					}
	
					if(m.getMap(x, y).equals("s")) {
						g.drawImage(m.getWall11(), x*16, y*16, null);
					}
	
					if(m.getMap(x, y).equals("d")) {
						g.drawImage(m.getWall12(), x*16, y*16, null);
					}
	
					if(m.getMap(x, y).equals("h")) {
						g.drawImage(m.getWall13(), x*16, y*16, null);
					}
	
					if(m.getMap(x, y).equals("j")) {
						g.drawImage(m.getWall14(), x*16, y*16, null);
					}
	
					if(m.getMap(x, y).equals("k")) {
						g.drawImage(m.getWall15(), x*16, y*16, null);
					}
	
	
					if(m.getMap(x, y).equals("v")) {
						g.drawImage(m.getDeath(), x*16, y*16, null);
					}
	
					if(m.getMap(x, y).equals("c")) {
						g.drawImage(m.getStart(), x*16, y*16, null);
					}
	
									
				}
			}
		
			// Draw Player on board
			g.drawImage(p.getPlayer(), p.getTileX() * 16, p.getTileY() * 16, null);
			// Set Font and Color and Set String (Database Death Count)
			g.setFont(font);
			g.setColor(Color.red);
			g.drawString("Deaths: " + String.valueOf(deathCount), 26, 920);
		
		}else {


			// 1 = BM, 2 = WIN, 3 == Dead  Music Stop
   		 	StopMusic(1);
   		 	StopMusic(3);

   		 	
		    // Draw Winner Panel
			JFrame frame = (JFrame) SwingUtilities.getWindowAncestor(this);
			WinnerPanel winner = new WinnerPanel();
			JButton retry = new JButton();
			JButton title = new JButton();
			
			
			// UI Buttons
			AbstractAction RetryMaze = new AbstractAction() {
		            @Override
		            public void actionPerformed(ActionEvent e) {

		    			// 1 = BM, 2 = WIN, 3 == Dead  Music Stop
		       		 	StopMusic(2);
		       		 	StopMusic(3);
		       		 	bm.play();
		            	try {
							new Maze();
						} catch (IOException e1) {
							// TODO Auto-generated catch block
							e1.printStackTrace();
						}
		            	//getTopLevelAncestor().setVisible(false);
		            	frame.dispose();
		            }
		        };
		    AbstractAction TitleProgram = new AbstractAction() {
		            @Override
		            public void actionPerformed(ActionEvent e) {
		            	// 1 = BM, 2 = WIN, 3 == Dead  Music Stop
						StopMusic(2);
						StopMusic(3);

						try {

			            	Title.timerstop = false;
							new Title();
							frame.dispose();
						} catch (IOException e1) {
							e1.printStackTrace();
						}
						  
		            }
		        };
		    
		    g.drawImage(p.getPlayer(), p.getTileX() * 16, p.getTileY() * 16, null);
		        
		        
			
			try {
			    Image imgtitle = ImageIO.read(getClass().getResource("/resources/Images/back.png")); 
			    Image imagetitletHover = ImageIO.read(getClass().getResource("/resources/Images/backhover.png"));
			    Image imgretry = ImageIO.read(getClass().getResource("/resources/Images/retry.png")); 
			    Image imageretryHover = ImageIO.read(getClass().getResource("/resources/Images/retryhover.png"));
			    title.setIcon(new ImageIcon(imgtitle));
				title.setRolloverIcon(new ImageIcon(imagetitletHover));
				retry.setIcon(new ImageIcon(imgretry));
			    retry.setRolloverIcon(new ImageIcon(imageretryHover));
		  } catch (Exception ex) {
		    System.out.println(ex);
		  }
			
			// Retry button
			retry.setOpaque(false);
			retry.setContentAreaFilled(false);
			retry.setBorderPainted(false);
			retry.setLocation(600,500);
			retry.setSize(200,65);
			retry.addActionListener(RetryMaze);

			
			// Back to Title Button
			title.setOpaque(false);
			title.setContentAreaFilled(false);
			title.setBorderPainted(false);
			title.setLocation(150,500);
			title.setSize(200,65);
			title.addActionListener(TitleProgram);
			
			
			// Winner Location
			winner.setLocation(0,0);
			winner.setSize(990,982);
			
			// Add items to ui
			this.add(retry);
			this.add(title);
			this.add(winner);

		
			
		}

		
		repaint();	
		
	}
	
	
	// Stop Music on UI
	public void StopMusic(int id) {
		
		if(id == 1) {
        if(!bm.equals(null)) {

         	bm.stop();
        }
		}else if(id == 2) {
		
        if(!bmwin.equals(null)) {
        bmwin.stop();
        }
		}else if(id == 3) {

        if(!bmdead.equals(null)) {
        	bmdead.stop();
        }
		}
        
	}
	
	
	public class AL extends KeyAdapter {
		
		public void keyPressed(KeyEvent e) {
		
				String Direction = null, chkCode = null;
				boolean sendcomm = false; 
				int PosY = 0, PosX = 0;
				int plrID = records.selectSID();
			
				int keycode = e.getKeyCode();
				if (keycode == KeyEvent.VK_W || keycode == KeyEvent.VK_UP) {
					PosY = p.getTileY()-1;
					PosX = p.getTileX();
					Direction = "UP";
					chkCode = m.getMap(PosX, PosY);	
					sendcomm = true;
				}else if (keycode == KeyEvent.VK_S || keycode == KeyEvent.VK_DOWN) {
					PosY = p.getTileY()+1;
					PosX = p.getTileX();
					Direction = "DOWN";
					chkCode = m.getMap(PosX, PosY);		
					sendcomm = true;


				}else if (keycode == KeyEvent.VK_A || keycode == KeyEvent.VK_LEFT) {
					PosY = p.getTileY();
					PosX = p.getTileX()-1;	
					Direction = "LEFT";	
					chkCode = m.getMap(PosX, PosY);		
					sendcomm = true;		


				}else if (keycode == KeyEvent.VK_D || keycode == KeyEvent.VK_RIGHT) {
					PosY = p.getTileY();
					PosX = p.getTileX()+1;
					Direction = "RIGHT";
					chkCode = m.getMap(PosX, PosY);		
					sendcomm = true;
					
					

				}
				
				
				
				if(	 sendcomm == true ) {
				command = "MOVE "+ Direction + " " + chkCode + " " + plrID + " \n";
				out.print(command);
				out.flush();
				response = in.nextLine();			
				
				movePlr(PosX, PosY, response, Direction);
				
				// Finished
				if(response.equals("2")) {

					command = "WIN "+ playerID + " 1 \n";
					out.print(command);
					out.flush();
					response = in.nextLine();	
					System.out.println(response);
					win = true;
					// Play (Stop first) Win Music
					if(!disable == true) {
						bmwin.stop();
			        	bmwin.start();
					}
		         	disable = true;
				} 
				
				// Died
				if(response.equals("3")) {
					

					command = "DEATH "+ playerID + " 1 \n";
					out.print(command);
					out.flush();
					response = in.nextLine();	
					System.out.println(response);
					deathCount += 1;
					p.restart();
					
					}
				}
		}
		
		public void movePlr(int moveX, int moveY, String code , String Direction  ) {
			

			if(code.equals("0")) {
				// Unknown Dont do nothing.
			}else if(code.equals("1")) {
				// GOOD MOVE PLAYER

				if(Direction.equals("UP")) {
					// Point Character Up
					p.SetPlayer(1);		
					p.move(0, -1);
				}else if(Direction.equals("DOWN")) {
					// Point Character Down
					p.SetPlayer(2);
					p.move(0, 1);
				}else if(Direction.equals("LEFT")) {
					// Point Character Left
					p.SetPlayer(3);	
					p.move(-1, 0);			
				}else if(Direction.equals("RIGHT")) {
					// Point Character Right
					p.SetPlayer(4);
					p.move(1, 0);
				}
			
			

			}else if(code.equals("2")) {
				// FINISHED
			}else if(code.equals("3")) {
				// DEAD
			}
			
		}
		
		// NOT USED.
		public void keyReleased(KeyEvent e) {
		
		}
		
		public void keyTyped(KeyEvent e) {
			
		}
		
	}

}

