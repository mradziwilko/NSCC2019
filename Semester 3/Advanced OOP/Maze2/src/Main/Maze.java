package Main;


// Main Maze file, if you launch it, it will launch TITLE.JAVA!!!

import java.io.IOException;

import javax.swing.JFrame;

import Properties.GameProperties;

public class Maze {

	public static void main(String[] args) {
		try {
			new Title();
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
	
	
	public Maze() throws IOException {


		// Set Title / Board
		JFrame f = new JFrame();
		f.setTitle(GameProperties.TITLE);
		f.add(new Board());		
		f.setSize(990,982);
		f.setResizable(false);
		f.setLocationRelativeTo(null);
		f.setVisible(true);
		f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		
		
		
	}
	
	
	
}

