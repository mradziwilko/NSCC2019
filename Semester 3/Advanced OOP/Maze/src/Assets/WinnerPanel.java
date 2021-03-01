package Assets;

import java.awt.Graphics;
import java.awt.Image;
import javax.swing.JPanel;

import Properties.GameProperties;

@SuppressWarnings("serial")
public class WinnerPanel  extends JPanel
{
  Image image;
  public WinnerPanel()
  {
    try
    {
      image = javax.imageio.ImageIO.read(new java.net.URL(getClass().getResource("/resources/Images/winner.jpg"), "winner.jpg"));
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