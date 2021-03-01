import java.awt.Color;
import java.awt.Container;
import java.awt.GridLayout;

import javax.swing.JButton;
import javax.swing.JFrame;


public class JGridExample1 extends JFrame {

	private JButton nb = new JButton("1"),
			sb = new JButton("2"),
			eb = new JButton("3"),
			wb = new JButton("4"),
			cb = new JButton("5");
	private Container content = getContentPane();
	
	public JGridExample1() {
		setSize(500,500);
		content.setBackground(Color.white);
		content.setLayout(new GridLayout(2,3));
		content.add(nb);
		nb.setBackground(Color.red);
		content.add(sb);
		sb.setBackground(Color.blue);
		content.add(eb);
		eb.setBackground(Color.yellow);
		content.add(wb);
		wb.setBackground(Color.green);
		content.add(cb);
		cb.setBackground(Color.white);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	}

	public static void main(String[] args) {
		JGridExample1 myFrame = new JGridExample1();
		myFrame.setVisible(true);
	}

}
