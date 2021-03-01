import java.awt.Color;
import java.awt.Container;
import java.awt.FlowLayout;

import javax.swing.JButton;
import javax.swing.JFrame;


public class JFlowLayoutExample extends JFrame {

    private JButton nb = new JButton("1"),
            sb = new JButton("2"),
            eb = new JButton("3"),
            wb = new JButton("4"),
            cb = new JButton("5");
    private Container content = getContentPane();
	
    public JFlowLayoutExample() {
    	setSize(500,500);
        
        content.setBackground(Color.white);
        content.setLayout(new FlowLayout());
        
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
		JFlowLayoutExample myFrame = new JFlowLayoutExample();
		myFrame.setVisible(true);
	}

}
