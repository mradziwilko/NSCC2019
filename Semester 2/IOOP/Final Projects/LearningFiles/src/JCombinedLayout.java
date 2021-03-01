import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Container;
import java.awt.FlowLayout;
import java.awt.GridLayout;

import javax.swing.DefaultListModel;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JList;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.ListSelectionModel;


public class JCombinedLayout extends JFrame {

    private JPanel pNorth = new JPanel(),
     	   pWest = new JPanel(),
     	   pCenter = new JPanel();
    private JButton b1 = new JButton("1 Scoop"),
             b2 = new JButton("2 Scoops"),
             b3 = new JButton("3 Scoops"),
             b4 = new JButton("4 Scoops"),
             bCup = new JButton("Ice Cream"),
             bWaffel = new JButton("Waffel");
	private JList list;
	private DefaultListModel listModel;
	private JLabel l = new JLabel("My Ice Cream Selection For Today");
	private Container content = getContentPane();

	public JCombinedLayout() {

		setSize(500,500);
        listModel = new DefaultListModel();
        listModel.addElement("Jane Doe");
        listModel.addElement("John Smith");
        listModel.addElement("Kathy Green");
        list = new JList(listModel);
        list.setSelectionMode(ListSelectionModel.SINGLE_SELECTION);
        list.setSelectedIndex(0);
        list.setVisibleRowCount(5);
        JScrollPane listScrollPane = new JScrollPane(list);
        
        content.setBackground(Color.white);
        content.setLayout(new BorderLayout());
        
        content.add(BorderLayout.NORTH,pNorth);
        content.add(BorderLayout.WEST,pWest);
        content.add(BorderLayout.CENTER,pCenter);
        
        pNorth.setLayout(new FlowLayout());
        pNorth.setBackground(Color.blue);
        bCup.setBackground(Color.yellow);
        pNorth.add(bCup);
        bWaffel.setBackground(Color.yellow);
        pNorth.add(bWaffel);
        
        pCenter.setLayout(new BorderLayout());
        pCenter.setBackground(Color.red);
        pCenter.add(BorderLayout.NORTH, l);
        pCenter.add(BorderLayout.CENTER, list);
        
        pWest.setLayout(new GridLayout(4,1));
        pWest.setBackground(Color.white);
        pWest.add(b1);
        pWest.add(b2);
        pWest.add(b3);
        pWest.add(b4);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	}

	public static void main(String[] args) {
		JCombinedLayout myFrame = new JCombinedLayout();
		myFrame.setVisible(true);
	}

}
