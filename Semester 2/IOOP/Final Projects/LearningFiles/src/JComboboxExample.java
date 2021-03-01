import java.awt.Color;
import java.awt.Container;
import java.awt.FlowLayout;
import java.awt.Graphics;
import java.awt.event.ItemEvent;
import java.awt.event.ItemListener;

import javax.swing.JComboBox;
import javax.swing.JFrame;
import javax.swing.JLabel;


public class JComboboxExample extends JFrame implements ItemListener {

    private String[] itemChoices = {"Red", "Green","Blue", "White", "Cyan", "Yellow"};
    private JComboBox theOptions = new JComboBox(itemChoices);
    private String currentColor = "grey";
    private Container content = getContentPane();

	public JComboboxExample() {

		setSize(500,500);
        content.setBackground(Color.white);
        content.setLayout(new FlowLayout());
        content.add(new JLabel("The Choice box allows easy selection"));
        content.add(new JLabel("of otems and conserves space."));
        content.add(new JLabel("You can make the choices blend with labels"));
        content.add(new JLabel("and produce smooth flowing interaction"));
        content.add(new JLabel("Like the one below this label."));
        content.add(new JLabel("I want the screen color to be:"));
        content.add(theOptions);
        theOptions.addItemListener(this);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	}

    public void itemStateChanged(ItemEvent evt) {
        if (evt.getSource() == theOptions) {
            currentColor=(String)theOptions.getSelectedItem() ;
        }
        repaint();
    }
    
    public void paint (Graphics g) {
        super.paint(g);
        if (currentColor=="Red") { content.setBackground(Color.red); }
        if (currentColor=="White") { content.setBackground(Color.white); }
        if (currentColor=="Blue") { content.setBackground(Color.blue); }
        if (currentColor=="Green") { content.setBackground(Color.green); }
        if (currentColor=="Cyan") { content.setBackground(Color.cyan); }
        if (currentColor=="Yellow") { content.setBackground(Color.yellow); }
    }

    public static void main(String[] args) {
		JComboboxExample myFrame = new JComboboxExample();
		myFrame.setVisible(true);
	}

}
