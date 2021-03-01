import java.awt.Container;
import java.awt.FlowLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JTextField;


public class JTextFieldExample extends JFrame implements ActionListener {

	private JTextField plainText = new JTextField(20);
	private JTextField hiddenText = new JTextField(10);
	private JLabel plainTextValue = new JLabel("-----------------");
	private JLabel hiddenTextValue = new JLabel("-----------------");
	private JButton b_enter = new JButton("Enter Both Fields");
	private Container content = getContentPane();		

	public JTextFieldExample() {

		setSize(500,500);
		content.setLayout(new FlowLayout());
		content.add(new JLabel("Type text in either text box and hit the enter key"));
		content.add(plainText);
		content.add(hiddenText);
		content.add(new JLabel("Or hit this button to"));
		content.add(b_enter);
		content.add(new JLabel("at once."));
		content.add(new JLabel("In the plain box you typed "));
		content.add(plainTextValue);
		content.add(new JLabel("In the hidden box you typed "));
		content.add(hiddenTextValue);	

		plainText.addActionListener(this);
		hiddenText.addActionListener(this);
		b_enter.addActionListener(this);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	}

	public void actionPerformed(ActionEvent evt) {
		if (evt.getSource() == plainText) {
			plainTextValue.setText(plainText.getText());
		}
		if (evt.getSource() == hiddenText) {
			hiddenTextValue.setText(hiddenText.getText());
		}
		if (evt.getSource() == b_enter) {
			plainTextValue.setText(plainText.getText());
			hiddenTextValue.setText(hiddenText.getText());
		}		
	}

	public static void main(String[] args) {
		JTextFieldExample myFrame = new JTextFieldExample();
		myFrame.setVisible(true);
	}

}
