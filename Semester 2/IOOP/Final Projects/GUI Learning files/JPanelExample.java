import java.awt.Color;
import java.awt.Container;
import java.awt.Graphics;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;


public class JPanelExample extends JFrame implements ActionListener {

	private JPanel values;
	private JTextField redText = new JTextField(5),
					   greenText = new JTextField(5),
					   blueText = new JTextField(5);
	private JPanel mixture;
	private Container content = getContentPane();

	public JPanelExample() {
		setSize(500,500);
		content.setLayout(new GridLayout(1,2,10,10));
		redText.setText("0");
		greenText.setText("0");
		blueText.setText("0");
		
		values = new JPanel();
		values.setLayout(new GridLayout(3,2,10,10));
		values.add(new JLabel("Red Value: "));
		values.add(redText);
		redText.addActionListener(this);
		values.add(new JLabel("Green Value: "));
		values.add(greenText);
		greenText.addActionListener(this);
		values.add(new JLabel("Blue Value: "));
		values.add(blueText);
		blueText.addActionListener(this);
		content.add(values);
		
		mixture = new JPanel();
		mixture.setBackground(new Color(0,0,0));
		content.add(mixture);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	}

	public void actionPerformed(ActionEvent evt) {
		if (evt.getSource() instanceof JTextField) {
			setColor();
		}
	}
		
	public void paint (Graphics g) {
		super.paint(g);
	}
		
	public void setColor() {
		String r = redText.getText();
		String g = greenText.getText();
		String b = blueText.getText();
		Color c = new Color(Integer.parseInt(r), Integer.parseInt(g), Integer.parseInt(b));
		mixture.setBackground(c);
		mixture.repaint();
	}

	public static void main(String[] args) {
		JPanelExample myFrame = new JPanelExample();
		myFrame.setVisible(true);
	}

}
