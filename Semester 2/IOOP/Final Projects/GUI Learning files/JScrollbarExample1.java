import java.awt.Color;
import java.awt.Container;
import java.awt.FlowLayout;
import java.awt.Graphics;
import java.awt.Scrollbar;
import java.awt.event.AdjustmentEvent;
import java.awt.event.AdjustmentListener;

import javax.swing.JFrame;
import javax.swing.JLabel;


public class JScrollbarExample1 extends JFrame implements AdjustmentListener {

	private Scrollbar colorScroll = new Scrollbar(Scrollbar.VERTICAL, 0, 0, 0, 255);
	private int redValue = 175;
	private JLabel scrollValue = new JLabel (String.valueOf(redValue));
	private Container content = getContentPane();

	public JScrollbarExample1() {
		setSize(500,500);
		content.setLayout(new FlowLayout());
		content.add(new JLabel("Scroll to change the color of the box"));
		content.add(colorScroll);
		colorScroll.addAdjustmentListener(this);
		colorScroll.setBlockIncrement(50);
		colorScroll.setValue(175);
		content.add(new JLabel("Value of the scrollbar = "));
		content.add(scrollValue);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	}

	public void adjustmentValueChanged (AdjustmentEvent evt) {
		redValue = colorScroll.getValue();
		scrollValue.setText(String.valueOf(redValue));
		repaint();
	}
	
	
	public void paint (Graphics g) {
		super.paint(g);
		g.setColor(new Color(redValue,0,0));
		g.fillRect(90, 90, 100, 100);
	}

	public static void main(String[] args) {
		JScrollbarExample1 myFrame = new JScrollbarExample1();
		myFrame.setVisible(true);
	}

}
