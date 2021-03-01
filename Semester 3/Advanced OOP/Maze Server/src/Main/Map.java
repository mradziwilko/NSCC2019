package Main;

import java.awt.Image;
import java.io.File;
import java.io.FileNotFoundException;
import java.util.*;

import javax.swing.ImageIcon;

import Properties.GameProperties;

public class Map {
	
	
	// Set Variables
	private Scanner m;
	private String Map[] = new String[61];
	private Image grass, wall0, wall1, wall2, wall3, wall4, wall5, wall6, wall7, wall8, wall9, wall10, wall11, wall12, wall13, wall14, wall15, finish, death, start;
	
	// Draw MAP on UI
	public Map(int map) {

		ImageIcon img = new ImageIcon(GameProperties.GAME_PATH +"/resources/Images/grass.png");
		
		// GRASS
		grass = img.getImage();
		
		// DEATH same as Grass 
		death = img.getImage();

		// WALL TEXTURES
		img = new ImageIcon(GameProperties.GAME_PATH +"/resources/Images/walls/wall0.png");
		wall0 = img.getImage();	

		img = new ImageIcon(GameProperties.GAME_PATH +"/resources/Images/walls/wall1.png");
		wall1 = img.getImage();	

		img = new ImageIcon(GameProperties.GAME_PATH +"/resources/Images/walls/wall2.png");
		wall2 = img.getImage();		

		img = new ImageIcon(GameProperties.GAME_PATH +"/resources/Images/walls/wall3.png");
		wall3 = img.getImage();		

		img = new ImageIcon(GameProperties.GAME_PATH +"/resources/Images/walls/wall4.png");
		wall4 = img.getImage();		

		img = new ImageIcon(GameProperties.GAME_PATH +"/resources/Images/walls/wall5.png");
		wall5 = img.getImage();		

		img = new ImageIcon(GameProperties.GAME_PATH +"/resources/Images/walls/wall6.png");
		wall6 = img.getImage();		

		img = new ImageIcon(GameProperties.GAME_PATH +"/resources/Images/walls/wall7.png");
		wall7 = img.getImage();		

		img = new ImageIcon(GameProperties.GAME_PATH +"/resources/Images/walls/wall8.png");
		wall8 = img.getImage();		

		img = new ImageIcon(GameProperties.GAME_PATH +"/resources/Images/walls/wall9.png");
		wall9 = img.getImage();		

		img = new ImageIcon(GameProperties.GAME_PATH +"/resources/Images/walls/wall10.png");
		wall10 = img.getImage();		

		img = new ImageIcon(GameProperties.GAME_PATH +"/resources/Images/walls/wall11.png");
		wall11 = img.getImage();		

		img = new ImageIcon(GameProperties.GAME_PATH +"/resources/Images/walls/wall12.png");
		wall12 = img.getImage();		

		img = new ImageIcon(GameProperties.GAME_PATH +"/resources/Images/walls/wall13.png");
		wall13 = img.getImage();

		img = new ImageIcon(GameProperties.GAME_PATH +"/resources/Images/walls/wall14.png");
		wall14 = img.getImage();

		img = new ImageIcon(GameProperties.GAME_PATH +"/resources/Images/walls/wall15.png");
		wall15 = img.getImage();

		
		// Draw Finish
		img = new ImageIcon(GameProperties.GAME_PATH +"/resources/Images/finish.png");
		finish = img.getImage();
		
		// Draw Start Line
		img = new ImageIcon(GameProperties.GAME_PATH +"/resources/Images/sl.png");
		start = img.getImage();
		
		
		openFile(map);
		readFile();
		closeFile();
	}

	public Image getGrass() {
		return grass;
	}
	public Image getDeath() {
		return death;
	}
	public Image getWall0() {
		return wall0;
	}
	public Image getWall1() {
		return wall1;
	}
	public Image getWall2() {
		return wall2;
	}
	public Image getWall3() {
		return wall3;
	}
	public Image getWall4() {
		return wall4;
	}
	public Image getWall5() {
		return wall5;
	}
	public Image getWall6() {
		return wall6;
	}
	public Image getWall7() {
		return wall7;
	}
	public Image getWall8() {
		return wall8;
	}
	public Image getWall9() {
		return wall9;
	}
	public Image getWall10() {
		return wall10;
	}
	public Image getWall11() {
		return wall11;
	}
	public Image getWall12() {
		return wall12;
	}
	public Image getWall13() {
		return wall13;
	}
	public Image getWall14() {
		return wall14;
	}
	public Image getWall15() {
		return wall15;
	}
	public Image getFinish() {
		return finish;
	}
	public Image getStart() {
		return start;
	}
	public String getMap(int x, int y) {
		String index = Map[y].substring(x, x+1);
		return index;
	}
	
	// Open Maps File, Randomizes Maps 
	public void openFile(int map) {

		
		// Random Number for Map
		     
		try {
			
			String mapFile = GameProperties.GAME_PATH +"/resources/Maps/Map"+map+".txt";
			m = new Scanner(new File(mapFile));
			
		} catch (FileNotFoundException e) {
			e.printStackTrace();
			System.out.println("Error Loading Map.");
			
		}
	}
	
	// Reads File
	public void readFile() {
		while(m.hasNext()) {
			for(int i = 0; i< 59; i++) {
				Map[i] = m.next();
			}
		}
		
		
	}
	
	// Closes File
	public void closeFile() {
		m.close();
	}
	

}
