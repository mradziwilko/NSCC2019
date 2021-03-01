import java.awt.Color;
import java.awt.Container;
import java.awt.FlowLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.ButtonGroup;
import javax.swing.JFrame;
import javax.swing.JRadioButton;


public class JRadioExample extends JFrame implements ActionListener {

    private JRadioButton aRed = new JRadioButton("Red");
    private JRadioButton bWhite = new JRadioButton("White");
    private JRadioButton cGreen = new JRadioButton("Green");
    private JRadioButton dBlue = new JRadioButton("Blue");
    private ButtonGroup btnGroup = new ButtonGroup();
    private Container content = getContentPane();

    public JRadioExample() {
        setSize(500,500);
        content.setBackground(Color.white);
        content.setLayout(new FlowLayout());
        
        btnGroup.add(aRed);
        btnGroup.add(bWhite);
        btnGroup.add(cGreen);
        btnGroup.add(dBlue);
        
        aRed.addActionListener(this);
        content.add(aRed);
        bWhite.addActionListener(this);
        content.add(bWhite);
        cGreen.addActionListener(this);
        content.add(cGreen);
        dBlue.addActionListener(this);
        content.add(dBlue);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	}

    public void actionPerformed(ActionEvent evt) {
        if (evt.getSource() == aRed) {
            content.setBackground(Color.red);
        }
        if (evt.getSource() == bWhite) {
            content.setBackground(Color.white);
        }
        if (evt.getSource() == cGreen) {
            content.setBackground(Color.green);
        }
        if (evt.getSource() == dBlue) {
            content.setBackground(Color.blue);
        }
    }

    public static void main(String[] args) {
		JRadioExample myFrame = new JRadioExample();
		myFrame.setVisible(true);
	}

}
