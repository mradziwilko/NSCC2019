import java.awt.Color;
import java.awt.Container;
import java.awt.Dimension;
import java.awt.FlowLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.BorderFactory;
import javax.swing.Box;
import javax.swing.SwingConstants;
import javax.swing.DefaultListModel;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.border.Border;
import javax.swing.JFrame;
import javax.swing.JScrollPane;
import javax.swing.JTextField;
import javax.swing.JLabel;
import javax.swing.JList;


public class Option2 extends JFrame implements ActionListener 
{
	int i=0;
	public static double  total = 0;
	private Container content = getContentPane();
	//Arrays
	private static String[] nameArray = {"Jeorge M","Markus T","Gil F","Trunks D","Goku D", "LeBron J", "Kobe B", "Kevin D", "James H", "Russel W"};
	private static double[] weightArray = {120.00, 160.58, 98.20, 99.12, 58.00, 67.11, 88.10, 98.10, 92.02, 100.10};
	private static int[] heightArray = {200, 210, 215, 216, 220, 240, 260, 205, 216, 202};
	private static int[] gamesPlayedArray = {10, 7, 70, 35, 60, 180, 190, 220, 190, 1010};
	private static double[] shotsMadeArray = {100, 70, 600, 70, 480, 450, 660, 680, 980, 7480};
	private static double[] shotsAttemptedArray = {100, 700, 78, 580, 780, 950, 760, 1080, 1080, 71480};
	
	//text fields
	private static JTextField txtPlayerName = new JTextField(5);
	private static JTextField txtHeight = new JTextField(5);
	private static JTextField txtWeight = new JTextField(5);
	private static JTextField txtGamesPlayed = new JTextField(5);
	private static JTextField txtShotsMade = new JTextField(5);
	private static JTextField txtShotsAttempted = new JTextField(5);

	//Labels fields 
	private JLabel name = new JLabel("Name: ");
	private JLabel cMs = new JLabel("CMs: ");
	private JLabel kGs = new JLabel("KGs: ");
	private JLabel gP = new JLabel("GP: ");
	private JLabel fG = new JLabel("FG: ");
	private JLabel fGa = new JLabel("FGA: ");
	private JLabel aV = new JLabel("Average: ");
	//Required Labels
	private static JLabel lblPlayerName = new JLabel("");
	private static JLabel lblHeight = new JLabel("");
	private static JLabel lblWeight = new JLabel("");
	private static JLabel lblGamesPlayed = new JLabel("");
	private static JLabel lblShotsMade = new JLabel("");
	private static JLabel lblShotsAttempted = new JLabel("");
	private static JLabel lblAverage = new JLabel("");
			
	//Buttons 
	private JButton bFirst = new JButton("|<");
	private JButton bLast = new JButton(">|");
	private JButton bNext = new JButton(">>");
	private JButton bPrevious = new JButton("<<");
	private JButton bPlayerName = new JButton("Name");
	private JButton bHeight = new JButton("CMs");
	private JButton bWeight = new JButton("KGs");
	private JButton bGamesPlayed = new JButton("GP");
	private JButton bShotsMade = new JButton("FG");
	private JButton bShotsAttempted = new JButton("FGA");
	
	public Option2() 
	{
		
		super("Exam Option -2-");
		content.setLayout(new FlowLayout(FlowLayout.CENTER, 15,25));
		
		// Set Size to 600 x 500, and Do not Allow Resizing.
		setSize(500,500);
		setResizable(false);
		setLocationRelativeTo(null);
		
		//Add content 
		//Buttons on top
		content.add(Box.createRigidArea(new Dimension(90,0)));
		content.add(bFirst);
		content.add(bPrevious);
		content.add(bNext);
		content.add(bLast);
		content.add(Box.createRigidArea(new Dimension(90,0)));
		//Textboxes on middle
		content.add(Box.createRigidArea(new Dimension(5,0)));
		content.add(txtPlayerName);
		content.add(txtHeight);
		content.add(txtWeight);
		content.add(txtGamesPlayed);
		content.add(txtShotsMade);
		content.add(txtShotsAttempted);
		
		//Buttons on bottom part
		content.add(Box.createRigidArea(new Dimension(10,0)));
		content.add(bPlayerName);
		content.add(bHeight);
		content.add(bWeight);
		content.add(bGamesPlayed);
		content.add(bShotsMade);
		content.add(bShotsAttempted);
		
		//Labels Bottom part
		content.add(Box.createRigidArea(new Dimension(120,0)));
		content.add(name);
		content.add(lblPlayerName);
		content.add(Box.createRigidArea(new Dimension(120,0)));
		content.add(cMs);
		content.add(lblHeight);
		content.add(Box.createRigidArea(new Dimension(120,0)));
		content.add(kGs);
		content.add(lblWeight);
		content.add(Box.createRigidArea(new Dimension(120,0)));
		content.add(gP);
		content.add(lblGamesPlayed);
		content.add(Box.createRigidArea(new Dimension(120,0)));
		content.add(fG);
		content.add(lblShotsMade);
		content.add(Box.createRigidArea(new Dimension(120,0)));
		content.add(fGa);
		content.add(lblShotsAttempted);
		content.add(Box.createRigidArea(new Dimension(120,0)));
		content.add(aV);
		content.add(lblAverage);
		content.add(Box.createRigidArea(new Dimension(120,0)));
		
		//Action Listeners
		bFirst.addActionListener(this);
		bPrevious.addActionListener(this);
		bNext.addActionListener(this);
		bLast.addActionListener(this);
		bPlayerName.addActionListener(this);
		bHeight.addActionListener(this);
		bWeight.addActionListener(this);
		bGamesPlayed.addActionListener(this);
		bShotsMade.addActionListener(this);
		bShotsAttempted.addActionListener(this);
		txtPlayerName.addActionListener(this);
		txtHeight.addActionListener(this);
		txtWeight.addActionListener(this);
		txtGamesPlayed.addActionListener(this);
		txtShotsMade.addActionListener(this);
		txtShotsAttempted.addActionListener(this);

		// Style Coding.
		//Top Buttons
		bFirst.setMinimumSize(new Dimension(150, 25));
		bNext.setMinimumSize(new Dimension(150, 25));
		bPrevious.setMinimumSize(new Dimension(150, 25));
		bLast.setMinimumSize(new Dimension(150, 25));
		//Text Boxes
		txtPlayerName.setMinimumSize(new Dimension(100, 25));
		txtHeight.setMinimumSize(new Dimension(100, 25));
		txtWeight.setMinimumSize(new Dimension(100, 25));
		txtGamesPlayed.setMinimumSize(new Dimension(100, 25));
		txtShotsMade.setMinimumSize(new Dimension(100, 25));
		txtShotsAttempted.setMinimumSize(new Dimension(100, 25));
		//Bottom Buttons
		bPlayerName.setMinimumSize(new Dimension(100, 25));
		bHeight.setMinimumSize(new Dimension(100, 25));
		bWeight.setMinimumSize(new Dimension(100, 25));
		bGamesPlayed.setMinimumSize(new Dimension(100, 25));
		bShotsMade.setMinimumSize(new Dimension(100, 25));
		bShotsAttempted.setMinimumSize(new Dimension(100, 25));
		//Label 1º Line
		name.setMinimumSize(new Dimension(300, 25));
		lblPlayerName.setMinimumSize(new Dimension(300, 25));
		//Label 2º Line
		cMs.setMinimumSize(new Dimension(300, 25));
		lblHeight.setMinimumSize(new Dimension(300, 25));
		//Label 3º Line
		kGs.setMinimumSize(new Dimension(300, 25));
		lblWeight.setMinimumSize(new Dimension(300, 25));
		//Label 4º Line
		gP.setMinimumSize(new Dimension(300, 25));
		lblGamesPlayed.setMinimumSize(new Dimension(300, 25));
		//Label 5º Line
		fG.setMinimumSize(new Dimension(300, 25));
		lblShotsMade.setMinimumSize(new Dimension(300, 25));
		//Label 6º Line
		fGa.setMinimumSize(new Dimension(300, 25));
		lblShotsAttempted.setMinimumSize(new Dimension(300, 25));
		//Label 7º Line
		aV.setMinimumSize(new Dimension(300, 25));
		lblAverage.setMinimumSize(new Dimension(300, 25));		
	}
		
	public static void main(String[] args) 
	{
		Option2 myFrame = new Option2();
		myFrame.setVisible(true);
		//Populate the first values on the Labels
		lblPlayerName.setText(nameArray[0]);	
		lblWeight.setText(Double.toString(weightArray[0]));	
		lblHeight.setText(Integer.toString(heightArray[0]));	
		lblGamesPlayed.setText(Integer.toString(gamesPlayedArray[0]));	
		lblShotsMade.setText(Double.toString(shotsMadeArray[0]));	
		lblShotsAttempted.setText(Double.toString(shotsAttemptedArray[0]));	
		//Populate the First values on the TextBoxes
		txtPlayerName.setText(nameArray[0]);	
		txtHeight.setText(Double.toString(weightArray[0]));	
		txtWeight.setText(Integer.toString(heightArray[0]));	
		txtGamesPlayed.setText(Integer.toString(gamesPlayedArray[0]));	
		txtShotsMade.setText(Double.toString(shotsMadeArray[0]));	
		txtShotsAttempted.setText(Double.toString(shotsAttemptedArray[0]));	
		total = shotsMadeArray[0] / shotsAttemptedArray[0];
		lblAverage.setText(Double.toString(total));	
	}
	
	
	
	public void actionPerformed(ActionEvent evt) 
	{
		
		// If button |< clicked
		if (evt.getSource() == bFirst )
		{
			i=0;
			lblPlayerName.setText(nameArray[i]);
			lblPlayerName.setText(nameArray[i]);	
			lblWeight.setText(Double.toString(weightArray[i]));	
			lblHeight.setText(Integer.toString(heightArray[i]));	
			lblGamesPlayed.setText(Integer.toString(gamesPlayedArray[i]));	
			lblShotsMade.setText(Double.toString(shotsMadeArray[i]));	
			lblShotsAttempted.setText(Double.toString(shotsMadeArray[i]));
			txtPlayerName.setText(nameArray[i]);	
			txtHeight.setText(Double.toString(weightArray[i]));	
			txtWeight.setText(Integer.toString(heightArray[i]));	
			txtGamesPlayed.setText(Integer.toString(gamesPlayedArray[i]));	
			txtShotsMade.setText(Double.toString(shotsMadeArray[i]));	
			txtShotsAttempted.setText(Double.toString(shotsAttemptedArray[i]));	
			total = shotsMadeArray[i] / shotsAttemptedArray[i];
			lblAverage.setText(Double.toString(total));	
			
		
					
		}
		// If button >| clicked
		if (evt.getSource() == bLast )
		{
			i=9;
		
			lblPlayerName.setText(nameArray[i]);
			lblPlayerName.setText(nameArray[i]);	
			lblWeight.setText(Double.toString(weightArray[i]));	
			lblHeight.setText(Integer.toString(heightArray[i]));	
			lblGamesPlayed.setText(Integer.toString(gamesPlayedArray[i]));	
			lblShotsMade.setText(Double.toString(shotsMadeArray[i]));	
			lblShotsAttempted.setText(Double.toString(shotsMadeArray[i]));
			txtPlayerName.setText(nameArray[i]);	
			txtHeight.setText(Double.toString(weightArray[i]));	
			txtWeight.setText(Integer.toString(heightArray[i]));	
			txtGamesPlayed.setText(Integer.toString(gamesPlayedArray[i]));	
			txtShotsMade.setText(Double.toString(shotsMadeArray[i]));	
			txtShotsAttempted.setText(Double.toString(shotsAttemptedArray[i]));	
			total = shotsMadeArray[i] / shotsAttemptedArray[i];
			lblAverage.setText(Double.toString(total));			
		}
		// If button Next clicked
		if (evt.getSource() == bNext)
		{
			if (i == 9)
			{
				
				lblPlayerName.setText(nameArray[i]);	
				lblWeight.setText(Double.toString(weightArray[i]));	
				lblHeight.setText(Integer.toString(heightArray[i]));	
				lblGamesPlayed.setText(Integer.toString(gamesPlayedArray[i]));	
				lblShotsMade.setText(Double.toString(shotsMadeArray[i]));	
				lblShotsAttempted.setText(Double.toString(shotsMadeArray[i]));
				txtPlayerName.setText(nameArray[i]);	
				txtHeight.setText(Double.toString(weightArray[i]));	
				txtWeight.setText(Integer.toString(heightArray[i]));	
				txtGamesPlayed.setText(Integer.toString(gamesPlayedArray[i]));	
				txtShotsMade.setText(Double.toString(shotsMadeArray[i]));	
				txtShotsAttempted.setText(Double.toString(shotsAttemptedArray[i]));	
				total = shotsMadeArray[i] / shotsAttemptedArray[i];
				lblAverage.setText(Double.toString(total));	
			}
			else		
			{
				i++;
				
				lblPlayerName.setText(nameArray[i]);
				lblPlayerName.setText(nameArray[i]);	
				lblWeight.setText(Double.toString(weightArray[i]));	
				lblHeight.setText(Integer.toString(heightArray[i]));	
				lblGamesPlayed.setText(Integer.toString(gamesPlayedArray[i]));	
				lblShotsMade.setText(Double.toString(shotsMadeArray[i]));	
				lblShotsAttempted.setText(Double.toString(shotsMadeArray[i]));
				txtPlayerName.setText(nameArray[i]);	
				txtHeight.setText(Double.toString(weightArray[i]));	
				txtWeight.setText(Integer.toString(heightArray[i]));	
				txtGamesPlayed.setText(Integer.toString(gamesPlayedArray[i]));	
				txtShotsMade.setText(Double.toString(shotsMadeArray[i]));	
				txtShotsAttempted.setText(Double.toString(shotsAttemptedArray[i]));	
				total = shotsMadeArray[i] / shotsAttemptedArray[i];
				lblAverage.setText(Double.toString(total));	
			}
		}
				
		// If button Previous clicked	
		if (evt.getSource() == bPrevious)
		{
			if (i==0)
			{
			
				lblPlayerName.setText(nameArray[i]);	
				lblWeight.setText(Double.toString(weightArray[i]));	
				lblHeight.setText(Integer.toString(heightArray[i]));	
				lblGamesPlayed.setText(Integer.toString(gamesPlayedArray[i]));	
				lblShotsMade.setText(Double.toString(shotsMadeArray[i]));	
				lblShotsAttempted.setText(Double.toString(shotsMadeArray[i]));	
				txtPlayerName.setText(nameArray[i]);	
				txtHeight.setText(Double.toString(weightArray[i]));	
				txtWeight.setText(Integer.toString(heightArray[i]));	
				txtGamesPlayed.setText(Integer.toString(gamesPlayedArray[i]));	
				txtShotsMade.setText(Double.toString(shotsMadeArray[i]));	
				txtShotsAttempted.setText(Double.toString(shotsAttemptedArray[i]));	
				total = shotsMadeArray[i] / shotsAttemptedArray[i];
				lblAverage.setText(Double.toString(total));	
			}
			else
			{
				i--;
				lblPlayerName.setText(nameArray[i]);
				lblPlayerName.setText(nameArray[i]);	
				lblWeight.setText(Double.toString(weightArray[i]));	
				lblHeight.setText(Integer.toString(heightArray[i]));	
				lblGamesPlayed.setText(Integer.toString(gamesPlayedArray[i]));	
				lblShotsMade.setText(Double.toString(shotsMadeArray[i]));	
				lblShotsAttempted.setText(Double.toString(shotsMadeArray[i]));
				txtPlayerName.setText(nameArray[i]);	
				txtHeight.setText(Double.toString(weightArray[i]));	
				txtWeight.setText(Integer.toString(heightArray[i]));	
				txtGamesPlayed.setText(Integer.toString(gamesPlayedArray[i]));	
				txtShotsMade.setText(Double.toString(shotsMadeArray[i]));	
				txtShotsAttempted.setText(Double.toString(shotsAttemptedArray[i]));	
				total = shotsMadeArray[i] / shotsAttemptedArray[i];
				lblAverage.setText(Double.toString(total));	
			}
		}
		
}
		
		
		
		
	
}
