import java.awt.Color;
import java.awt.Container;
import java.awt.FlowLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;


public class JFrameExample extends JFrame implements ActionListener {

	private JFrame window = new JFrame("This is the Frames's Title Bar!");
	private JButton b_frame = new JButton("Create a new frame");
	private Container content = getContentPane();

	public JFrameExample() {

		setSize(500,500);
		content.setLayout(new FlowLayout());
		
		content.add(new JLabel("Hit this button to"));
		content.add(b_frame);
		b_frame.addActionListener(this);
		content.add(new JLabel("."));
		
		content.add(new JLabel("The new Frame is independant of the applet."));
		content.add(new JLabel("You can maximize and minimize it by using "));
		content.add(new JLabel("the buttons on the top right."));
		content.add(new JLabel("You can close it using the applet's button."));
		content.add(new JLabel("In order to handle Frame events you need to "));
		content.add(new JLabel("create a separate class for it."));
		
		window.setLayout(new FlowLayout());
		window.add(new JLabel("This is the frame"));
		window.add(new JLabel("You can resize it, move it "));
		window.add(new JLabel("and perform other Windows operations"));
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	}

	public void actionPerformed(ActionEvent evt) {
		
		if (b_frame.getText() == "Create a new frame") {
			content.setBackground(Color.red);
			b_frame.setText("Destroy the Frame");
			window.setSize(300,200);
			window.setVisible(true);
		} else {
			content.setBackground(Color.blue);
			b_frame.setText("Create a new frame");
			window.setVisible(false);
		}

	}

	public static void main(String[] args) {
		JFrameExample myFrame = new JFrameExample();
		myFrame.setVisible(true);
	}

}
