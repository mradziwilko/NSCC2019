package Assets;

import java.awt.Graphics;
import java.awt.Image;
import javax.swing.JPanel;

import Properties.GameProperties;

@SuppressWarnings("serial")
public class Logo  extends JPanel
{
  Image image;
  public Logo()
  {
    try
    {
        image = javax.imageio.ImageIO.read(new java.net.URL(getClass().getResource("/Images/logo.png"), "logo.png"));
    }
    catch (Exception e) { /*handled in paintComponent()*/ }
  }
 
  @Override
  protected void paintComponent(Graphics g)
  {
    super.paintComponent(g);
    if (image != null)
      g.drawImage(image, 0,0,this.getWidth(),this.getHeight(),this);
  }
}