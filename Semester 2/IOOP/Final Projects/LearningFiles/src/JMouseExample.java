import java.awt.Color;
import java.awt.Container;
import java.awt.FlowLayout;
import java.awt.Graphics;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;

import javax.swing.JFrame;


public class JMouseExample extends JFrame implements MouseListener {

	private String coordinates="0,0";
	private int x=0, y=0;
	private Container content = getContentPane();

	public JMouseExample() {
		setSize(700,350);
		content.setLayout(new FlowLayout());
		content.addMouseListener(this);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	}

	public void paint (Graphics g) {
		super.paint(g);
		for (int i=0; i<=4; i++){
			g.setColor(new Color(63*i, 100, (255-(63*i))));
			g.fillRect((i-1)*100, 0, i*100, 80);
			g.setColor(Color.black);
			g.drawString(coordinates,x,y);
		}
	}
	
	public void mousePressed (MouseEvent evt) {
		coordinates="garbage";
		if (evt.getID()==MouseEvent.MOUSE_PRESSED) {
			coordinates=evt.getX()+","+evt.getY();
			x=evt.getX();
			y=evt.getY();
		}
		repaint();
	}
	
	public void mouseClicked (MouseEvent evt) { }
	public void mouseReleased (MouseEvent evt) { }
	public void mouseEntered (MouseEvent evt) { }
	public void mouseExited (MouseEvent evt) { }

	public static void main(String[] args) {
		JMouseExample myFrame = new JMouseExample();
		myFrame.setVisible(true);
	}

}
