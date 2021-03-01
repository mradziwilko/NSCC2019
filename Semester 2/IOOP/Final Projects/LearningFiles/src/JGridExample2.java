import java.awt.Color;
import java.awt.Container;
import java.awt.GridLayout;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JPanel;


public class JGridExample2 extends JFrame {

	private JButton nb = new JButton("1"),
			sb = new JButton("2"),
			eb = new JButton("3"),
			wb = new JButton("4"),
			cb = new JButton("5");
	private Container content = getContentPane();
	private JPanel blankPanel1 = new JPanel(),
				   blankPanel2 = new JPanel(),
	               blankPanel3 = new JPanel();

	public JGridExample2() {
		setSize(500,500);
		content.setBackground(Color.white);
		content.setLayout(new GridLayout(2,3));
		content.add(nb);
		nb.setBackground(Color.red);
		content.add(blankPanel1);
		content.add(sb);
		sb.setBackground(Color.blue);
		content.add(blankPanel2);
		content.add(eb);
		eb.setBackground(Color.yellow);
		content.add(blankPanel3);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	}

	public static void main(String[] args) {
		JGridExample2 myFrame = new JGridExample2();
		myFrame.setVisible(true);
	}

}
