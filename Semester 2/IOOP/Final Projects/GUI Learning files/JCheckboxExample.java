import java.awt.Color;
import java.awt.Container;
import java.awt.FlowLayout;
import java.awt.Font;
import java.awt.Graphics;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JCheckBox;
import javax.swing.JFrame;


public class JCheckboxExample extends JFrame implements ActionListener {

    private JCheckBox apples = new JCheckBox("Apples", null, false);
    private JCheckBox bananas = new JCheckBox("Bananas", null, false);
    private JCheckBox grapes = new JCheckBox("Grapes", null, false);
    private JCheckBox peaches = new JCheckBox("Peaches", null, false);
    private JButton b_done = new JButton("Done");
    private Font f = new Font("TimesRoman", Font.ITALIC, 14);
    private Container content = getContentPane();

    public JCheckboxExample() {

    	setSize(500,500);   
        content.setBackground(Color.white);
        content.setLayout(new FlowLayout());
        content.add(apples);
        content.add(bananas);
        content.add(grapes);
        content.add(peaches);
        content.add(b_done);
        b_done.addActionListener(this);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

    }

    public void actionPerformed(ActionEvent evt) {
        if (evt.getSource() instanceof JButton) {
            repaint();
        }
    }
    public void paint (Graphics g) {
        super.paint(g);
        g.setFont(f);
        g.setColor(Color.blue);
        if (apples.isSelected()) { g.drawString("Apples", 50, 60);}
        if (bananas.isSelected()) { g.drawString("Bananas", 50, 80);}
        if (grapes.isSelected()) { g.drawString("Grapes", 50, 100);}
        if (peaches.isSelected()) { g.drawString("Peaches", 50, 120);}
        
    }

    public static void main(String[] args) {
		JCheckboxExample myFrame = new JCheckboxExample();
		myFrame.setVisible(true);
	}

}
