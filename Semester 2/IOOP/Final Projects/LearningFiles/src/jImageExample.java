import java.awt.Container;
import java.awt.FlowLayout;
import java.io.IOException;

import javax.imageio.ImageIO;
import javax.swing.ImageIcon;
import javax.swing.JFrame;
import javax.swing.JLabel;


public class jImageExample extends JFrame {

	private Container content = getContentPane();
	private ImageIcon image;
	private JLabel imageLabel;

	public jImageExample() {
		setSize(500,500);
		try {
			image = new ImageIcon(ImageIO.read(getClass().getResource("./background.jpg"))); 
		} catch (IOException e) {				
		}
		imageLabel = new JLabel(image);

		content.setLayout(new FlowLayout());
		content.add(imageLabel);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	}

	public static void main(String[] args) {
		jImageExample myFrame = new jImageExample();
		myFrame.setVisible(true);
	}

}
