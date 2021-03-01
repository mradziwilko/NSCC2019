import java.awt.Container;
import java.awt.FlowLayout;

import javax.swing.JFrame;
import javax.swing.JLabel;


public class JLabelExample extends JFrame {

	private JLabel firstLabel = new JLabel("Labels exist simply");
	private JLabel secondLabel = new JLabel("to place text on the screen.");
	private JLabel thirdLabel = new JLabel("They can be aligned left, right, or center.");
	private Container content = getContentPane();

	public JLabelExample() {
		setSize(500,500);
		content.setLayout(new FlowLayout());
		content.add(firstLabel);
		content.add(secondLabel);
		content.add(thirdLabel);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	}

	public static void main(String[] args) {
		JLabelExample myFrame = new JLabelExample();
		myFrame.setVisible(true);
	}

}
