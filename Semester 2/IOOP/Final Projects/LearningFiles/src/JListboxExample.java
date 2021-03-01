import java.awt.Color;
import java.awt.Container;
import java.awt.FlowLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.DefaultListModel;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JList;


public class JListboxExample extends JFrame implements ActionListener {

	private String[] itemChoices = {"Coffee","Bananas","Oranges", "Pears","Tuna","Bread", "Milk","Eggs","Butter","Sugar","Cereal","Java Manual"};
	private DefaultListModel listModel1 = new DefaultListModel();
	private JList list1 = new JList(listModel1);
	private DefaultListModel listModel2 = new DefaultListModel();
	private JList list2 = new JList(listModel2);
	private JButton b_move = new JButton(">>>>");
	private JButton b_clear = new JButton("Clear");
	private Container content = getContentPane();

	public JListboxExample() {
		setSize(500,500);
		content.setBackground(Color.white);
		content.setLayout(new FlowLayout());
		
		fillTheList();
		
		content.add(list1);
		content.add(b_move);
		b_move.addActionListener (this);
		
		content.add(list2);
		content.add(b_clear);
		b_clear.addActionListener (this);

		content.add(new JLabel("Select an item from the list on the left and hit >>>> to place it in the other list"));
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	}

	public void fillTheList() {
		for (int i=0; i<itemChoices.length; i++) {
			listModel1.add(i,  itemChoices[i]);
		}
	}
	
	public void actionPerformed(ActionEvent evt) {
		
		if (evt.getSource() == b_move) {
			listModel2.addElement(list1.getSelectedValue());
			listModel1.remove(list1.getSelectedIndex());
		}
		if (evt.getSource() == b_clear) {
			listModel2.removeAllElements();
		}
	}

	public static void main(String[] args) {
		JListboxExample myFrame = new JListboxExample();
		myFrame.setVisible(true);
	}

}
