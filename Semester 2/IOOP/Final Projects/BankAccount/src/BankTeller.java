import java.awt.Color;
import java.awt.Container;
import java.awt.Dimension;
import java.awt.FlowLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JTextField;


public class BankTeller extends JFrame  implements ActionListener {

	// Form kept making me see yellow lines removed here.
	private static final long serialVersionUID = 1L;

	// Container
	private Container content = getContentPane();

	private BankAccount BankCHK = new BankAccount();
	
	// Labels for Fields
	private JLabel nameLBL = new JLabel("Name");
	private JLabel accLBL = new JLabel("Account");
	private JLabel transLBL = new JLabel("Transaction");
	private JLabel blankLine = new JLabel(" ");
	private JLabel CName = new JLabel("     Name:");
	private JLabel CAcc = new JLabel("Account:");
	private JLabel CBal = new JLabel("Balance:");	
	private JLabel cIName = new JLabel("");
	private JLabel cIAcc = new JLabel("");
	private JLabel cIBal = new JLabel("");
	
	
	// Input Fields
	private JTextField nameIF = new JTextField(20);
	private JTextField accIF = new JTextField(20);
	private JTextField transIF = new JTextField(20);
	
	// Buttons
	private JButton submitBTN = new JButton("Submit");
      
	
	
	public BankTeller() {
		super("TD Canada Trust - Bank Teller");
		content.setLayout(new FlowLayout(FlowLayout.LEFT));
		
		// Set Size to 250 x 450, and Do not Allow Resizing of Form also set Form to center screen.
		setSize(250,300);
		setResizable(false);
		setLocationRelativeTo(null);
	    
	    // Add Each Label to form.
		content.add(nameLBL);
		content.add(nameIF);
		content.add(accLBL);
		content.add(accIF);
		content.add(transLBL);
		content.add(transIF);
		content.add(submitBTN);
		content.add(blankLine);			
		content.add(CName);
		content.add(cIName);
		content.add(CAcc);	
		content.add(cIAcc);
		content.add(CBal);
		content.add(cIBal);
		
		
		// Style Coding, For width, and Color and Height.
		submitBTN.setMinimumSize(new Dimension(222, 25));
		submitBTN.setPreferredSize(new Dimension(222, 25));
		submitBTN.setMaximumSize(new Dimension(222, 25));
		blankLine.setMinimumSize(new Dimension(220, 2));
		blankLine.setPreferredSize(new Dimension(220, 2));
		blankLine.setMaximumSize(new Dimension(220, 2));
		CName.setMinimumSize(new Dimension(55, 20));
		CName.setPreferredSize(new Dimension(55, 20));
		CName.setMaximumSize(new Dimension(55, 20));
		cIName.setMinimumSize(new Dimension(150, 20));
		cIName.setPreferredSize(new Dimension(150, 20));
		cIName.setMaximumSize(new Dimension(150, 20));
		CAcc.setMinimumSize(new Dimension(55, 20));
		CAcc.setPreferredSize(new Dimension(55, 20));
		CAcc.setMaximumSize(new Dimension(55, 20));	
		cIAcc.setMinimumSize(new Dimension(150, 20));
		cIAcc.setPreferredSize(new Dimension(150, 20));
		cIAcc.setMaximumSize(new Dimension(150, 20));	
		CBal.setMinimumSize(new Dimension(55, 20));
		CBal.setPreferredSize(new Dimension(55, 20));
		CBal.setMaximumSize(new Dimension(55, 20));
		cIBal.setMinimumSize(new Dimension(150, 20));
		cIBal.setPreferredSize(new Dimension(150, 20));
		cIBal.setMaximumSize(new Dimension(150, 20));
		blankLine.setOpaque(true);
		blankLine.setBackground(Color.BLACK);
		
		
		
		// Listeners for Buttons.
		nameIF.addActionListener(this);
		accIF.addActionListener(this);
		transIF.addActionListener(this);
		submitBTN.addActionListener(this);
		
		
		// Close Operation
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	}

	
	
	public static void main(String[] args) {
		BankTeller myFrame = new BankTeller();
		myFrame.setVisible(true);
	}
	
	

	public void actionPerformed(ActionEvent e) 
	{

		int inpAcc = 0;
 		String inpName = "Nulled";
		double inpTrans = 0;
		
		String error1 = "true";
		String error2 = "true";
		String error3 = "true";

		if (!nameIF.getText().isEmpty()) 
		{
			inpName = nameIF.getText();
			error1 = "false";
		}
		if (!accIF.getText().isEmpty()) 
		{
			inpAcc = Integer.parseInt(accIF.getText());
			error2 = "false";
		}
		if (!transIF.getText().isEmpty())  
		{
			inpTrans = Double.parseDouble(transIF.getText());
			error3 = "false";
		}
		
		


		if(error1 == "false" && error2 == "false" && error3 == "false"  ) {

			// Set Account Name and Account ID
			BankCHK.setName(inpName);
			BankCHK.setAccNumber(inpAcc);
			// Set Account New Balance
			BankCHK.setAccBalance(inpTrans);
			
			
			
			// Get Stored Data
			String storName = BankCHK.getName(); 			
			String storAcc = Integer.toString(BankCHK.getAccNumber());			
			String storeBal = Double.toString(BankCHK.getBalance());	
			
			
			// Replace Labels with Stored Data.
			cIName.setText(storName);
			cIAcc.setText(storAcc);
			cIBal.setText(storeBal);
		}else {			
			cIName.setText("");
			cIAcc.setText("");
			cIBal.setText("");
			
		}
		
		
	}
	
	

}
