import java.awt.Color;
import java.awt.Container;
import java.awt.Dimension;
import java.awt.FlowLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.BorderFactory;
import javax.swing.DefaultListModel;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JList;
import javax.swing.JScrollPane;
import javax.swing.border.Border;


public class pizzeria  extends JFrame implements ActionListener {

	private static final long serialVersionUID = 1L;
	
	double total = 0;

	
	
	private JScrollPane scrollPizza = new JScrollPane();
	private JScrollPane scrollToppings = new JScrollPane();

	// Frameless JList Border
	private Border emptyBorder = BorderFactory.createEmptyBorder();

	
	// Pizza Sizes
	private DefaultListModel<String> lstdefPizza = new DefaultListModel<String>();
	private JList<String> lstPizza = new JList<String>(lstdefPizza);	
	private String[] pSize = {"Small","Medium","Large", "X-Large"};
    private JComboBox<?> pizzas = new JComboBox<Object>(pSize);
	
	
	// Pizza Tops
	private DefaultListModel<String> deflstToppings = new DefaultListModel<String>();
	private JList<String> lstToppings = new JList<String>(deflstToppings);	
	private String[] PizzaToppings = {"Cheese","Pepparoni","Bacon","Meat", "Anchovies"};	
    private JComboBox<?> toppings = new JComboBox<Object>(PizzaToppings);
	
	
	private JButton btnPSelect = new JButton("Select");
	private JButton btnTSelect = new JButton("Select");
	private JButton btnClear = new JButton("New Order");


	private JLabel ResultLabel = new JLabel("Total: $");
	private JLabel Resault = new JLabel("");
	

	private Container content = getContentPane();

	public pizzeria() 
	{
		super("Pizza Hut - Takeout");
		setSize(250,500);
		setResizable(false);
		setLocationRelativeTo(null);

		
		
		content.setBackground(Color.white);
		content.setLayout(new FlowLayout(FlowLayout.LEFT));
		content.add(pizzas);
		content.add(btnPSelect);		
		content.add(toppings);		
		content.add(btnTSelect);
		content.add(lstPizza);	
        content.add(scrollPizza);
		content.add(lstToppings);	
        content.add(scrollToppings);
		content.add(ResultLabel);
		content.add(Resault);
		content.add(btnClear);		

		scrollPizza.setViewportView(lstPizza);
		scrollPizza.setBorder(emptyBorder);	
		scrollToppings.setViewportView(lstToppings);
		scrollToppings.setBorder(emptyBorder);
		
		// Style Coding, For width, and Color and Height.
		pizzas.setMinimumSize(new Dimension(150, 25));
		pizzas.setPreferredSize(new Dimension(150, 25));		
		btnPSelect.setMinimumSize(new Dimension(72, 25));
		btnPSelect.setPreferredSize(new Dimension(72, 25));
		btnPSelect.setMaximumSize(new Dimension(72, 25));		
		toppings.setMinimumSize(new Dimension(150, 25));
		toppings.setPreferredSize(new Dimension(150, 25));
		toppings.setMaximumSize(new Dimension(150, 25));		
		btnPSelect.setMinimumSize(new Dimension(72, 25));
		btnPSelect.setPreferredSize(new Dimension(72, 25));
		btnPSelect.setMaximumSize(new Dimension(72, 25));		
		lstPizza.setMinimumSize(new Dimension(200, 150));
		lstPizza.setPreferredSize(new Dimension(200, 150));
		lstPizza.setMaximumSize(new Dimension(200, 150));		
		lstToppings.setMinimumSize(new Dimension(200, 150));
		lstToppings.setPreferredSize(new Dimension(200, 150));
		lstToppings.setMaximumSize(new Dimension(200, 150));		
		btnClear.setMinimumSize(new Dimension(222, 50));
		btnClear.setPreferredSize(new Dimension(222, 50));
		btnClear.setMaximumSize(new Dimension(222, 50));	
		
		btnPSelect.addActionListener (this);
		btnClear.addActionListener (this);
		btnTSelect.addActionListener (this);
		
		
		
		
		
		
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	}

	
	
	public void actionPerformed(ActionEvent evt) 	{         
		double tempTotal = 0.0;
		if (evt.getSource() == btnClear) {
			lstdefPizza.removeAllElements();
			deflstToppings.removeAllElements();
			Resault.setText("");
		}
		
		if (evt.getSource() == btnPSelect){
			String x = String.valueOf(pizzas.getSelectedItem());
			lstdefPizza.addElement(x);  

			switch ( pizzas.getSelectedIndex())
			{
			case 0:
				tempTotal +=  7;
				break;
			case 1:
				tempTotal += 9;
				break;	
			case 2:
				tempTotal += 11;
				break;
			case 3:
				tempTotal += 14;
				break;	
			}	
			

			total += tempTotal;
			Resault.setText(Double.toString(total));
			
		}


		if (evt.getSource() == btnTSelect){
			String x = String.valueOf(toppings.getSelectedItem());
			deflstToppings.addElement(x);  
			switch (toppings.getSelectedIndex()){
			case 0:			
				break;
			case 1:

				tempTotal +=  1;
				break;	
			case 2:

				tempTotal +=  1;
				break;
			case 3:

				tempTotal +=  1;
				break;
			case 4:
				tempTotal +=  1;				
				break;	
			}

			total += tempTotal;
			Resault.setText(Double.toString(total));
		}
		
		
		
	}

	
	public static void main(String[] args) 
	{
		pizzeria myFrame = new pizzeria();
		myFrame.setVisible(true);
	}

}
