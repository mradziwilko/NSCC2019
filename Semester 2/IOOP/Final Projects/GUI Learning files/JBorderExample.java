import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Container;
import javax.swing.JButton;
import javax.swing.JFrame;

public class JBorderExample extends JFrame {

	private JButton nb = new JButton("North"),
            sb = new JButton("South"),
            eb = new JButton("East"),
            wb = new JButton("West"),
            cb = new JButton("Center");
	private Container content = getContentPane();

	public JBorderExample() {
		setSize(500,500);
		content.setBackground(Color.white);
		content.setLayout(new BorderLayout());
		content.add(BorderLayout.NORTH,nb);
		nb.setBackground(Color.red);
		content.add(BorderLayout.SOUTH,sb);
		sb.setBackground(Color.blue);
		content.add(BorderLayout.EAST,eb);
		eb.setBackground(Color.yellow);
		content.add(BorderLayout.WEST,wb);
		wb.setBackground(Color.green);
		content.add(BorderLayout.CENTER,cb);
		cb.setBackground(Color.white);		
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	}
	
	public static void main(String[] args) {
		JBorderExample myFrame = new JBorderExample();
		myFrame.setVisible(true);

	}

}
