import java.awt.Color;
import java.awt.Container;
import java.awt.FlowLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;


public class JButtonExample extends JFrame implements ActionListener {

    private JButton b_red = new JButton("red");
    private JButton b_white = new JButton("white");
    private JButton b_blue = new JButton("blue");
    private JLabel l1 = new JLabel("Hit a button to change the screen color");
    private Container content = getContentPane();

	public JButtonExample() {

        setSize(500,500);
        content.setBackground(Color.white);
        content.setLayout(new FlowLayout());
        
        content.add(b_red);
        content.add(b_white);
        content.add(b_blue);
        content.add(l1);
        
        b_red.addActionListener(this);
        b_white.addActionListener(this);
        b_blue.addActionListener(this);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

	}

	public void actionPerformed(ActionEvent evt) {

		if (evt.getSource()==b_red) {
            content.setBackground(Color.red);
        }
        if (evt.getSource()==b_white) {
            content.setBackground(Color.white);
        }
        if (evt.getSource()==b_blue) {
            content.setBackground(Color.blue);
        }
          
	}

	public static void main(String[] args) {
		JButtonExample myFrame = new JButtonExample();
		myFrame.setVisible(true);
	}

}
