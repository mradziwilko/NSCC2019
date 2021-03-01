package Main;

import java.awt.Image;

import javax.swing.ImageIcon;

import Properties.GameProperties;

// Player File
public class Player {

	// Set Variables
	private int tileX, tileY;	
	private Image player;
	private ImageIcon img;
	
	
	public Player() {
		// Set Player Image
		img = new ImageIcon(GameProperties.GAME_PATH +"/resources/Images/player1down.png");
		player = img.getImage();
		
		// Set Position of Player, Will always start at Tile 1 x 1
		tileX = 1;
		tileY = 1;
		
	}
	
	
	public Image getPlayer() {
		return player;		
	}
		
	public void SetPlayer(int direction) {
		
		// Change Image of player on Direction.
		
		// UP	
		if(direction == 1) {
		img = new ImageIcon(GameProperties.GAME_PATH +"/resources/Images/player1up.png");
		player = img.getImage();
		}
		// DOWN
		if(direction == 2) {
		img = new ImageIcon(GameProperties.GAME_PATH +"/resources/Images/player1down.png");
		player = img.getImage();
		}
		
		// LEFT
		if(direction == 3) {
		img = new ImageIcon(GameProperties.GAME_PATH +"/resources/Images/player1left.png");
		player = img.getImage();
		}
		
		// RIGHT
		if(direction == 4) {
		img = new ImageIcon(GameProperties.GAME_PATH +"/resources/Images/player1right.png");
		player = img.getImage();
		}
		
		
	}
	
	// Getters and Setters.
	public int getTileX() {
		return tileX;
	}

	
	public int getTileY() {
		return tileY;
	}

	
	public int setTileX(int x) {
		return tileX = x;
	}

	
	public int setTileY(int y) {
		return tileY = y;
	}


	// Move Player
	public void move(int dx, int dy) {
		tileX += dx;
		tileY += dy;		
	}
	
	public void restart() {		
		// Set player back to 1x1;
		tileX = 1;
		tileY = 1;		
	}

}
