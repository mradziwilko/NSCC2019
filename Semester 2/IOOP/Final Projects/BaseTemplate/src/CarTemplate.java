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
import javax.swing.SwingConstants;
import javax.swing.border.Border;



public class CarTemplate   extends JFrame implements ActionListener {

	private Container content = getContentPane();

	//private static cars varCar = new cars();

	private static String[] arrMan = {"Ferrari","Dodge","Volvo","Ford","Honda"};
	private static String[] arrFer = {"Ferrari 1","Ferraro 2","Ferrari 3","Ferrari 4","Ferrari 5"}; 
	private static String[] arrDod = {"Dodge 1","Dodge 2","Dodge 3","Dodge 4","Dodge 5"};
	private static String[] arrVol = {"Volvo 1","Volvo 2","Volvo 3","Volvo 4","Volvo 5"};
	private static String[] arrFor = {"Ford 1","Ford 2","Ford 3","Ford 4","Ford 5"};
	private static String[] arrHon = {"Honda 1","Honda 2","Honda 3","Honda 4","Honda 5"};

	private JLabel lblArr1 = new JLabel("Array #1");
	private JLabel lblArr2 = new JLabel("Array #2");
	private JLabel lblArr3 = new JLabel("Array #3");
	private JLabel lblArr4 = new JLabel("Array #4");
	private JLabel lblArr5 = new JLabel("Array #5");
	
	private JButton btnR1L = new JButton("«");
	private JLabel lblR1 = new JLabel("");
	private JButton btnR1R = new JButton("»");

	private JButton btnR2L = new JButton("«");
	private JLabel lblR2 = new JLabel("");
	private JButton btnR2R = new JButton("»");

	private JButton btnR3L = new JButton("«");
	private JLabel lblR3 = new JLabel("");
	private JButton btnR3R = new JButton("»");

	private JButton btnR4L = new JButton("«");
	private JLabel lblR4 = new JLabel("");
	private JButton btnR4R = new JButton("»");

	private JButton btnR5L = new JButton("«");
	private JLabel lblR5 = new JLabel("");
	private JButton btnR5R = new JButton("»");
	
	public CarTemplate() {

		super("Exam Template");
		content.setLayout(new FlowLayout(FlowLayout.LEFT));
		
		// Set Size to 250 x 450, and Do not Allow Resizing of Form also set Form to center screen.
		setSize(300,500);
		setResizable(false);
		setLocationRelativeTo(null);
		
		

		content.add(lblArr1);
		content.add(btnR1L);
		content.add(lblR1);
		content.add(btnR1R);		

		content.add(lblArr2);
		content.add(btnR2L);
		content.add(lblR2);
		content.add(btnR2R);		

		content.add(lblArr3);
		content.add(btnR3L);
		content.add(lblR3);
		content.add(btnR3R);		

		content.add(lblArr4);
		content.add(btnR4L);
		content.add(lblR4);
		content.add(btnR4R);		

		content.add(lblArr5);
		content.add(btnR5L);
		content.add(lblR5);
		content.add(btnR5R);
		
		
		

		
		// Style Coding, For width, and Color and Height.
		btnR1L.setMinimumSize(new Dimension(50, 25));
		btnR1L.setPreferredSize(new Dimension(50, 25));
		btnR1L.setMaximumSize(new Dimension(50, 25));
		lblR1.setMinimumSize(new Dimension(165, 25));
		lblR1.setPreferredSize(new Dimension(165, 25));
		lblR1.setMaximumSize(new Dimension(165, 25));
		btnR1R.setMinimumSize(new Dimension(50, 25));
		btnR1R.setPreferredSize(new Dimension(50, 25));
		btnR1R.setMaximumSize(new Dimension(50, 25));
		

		btnR2L.setMinimumSize(new Dimension(50, 25));
		btnR2L.setPreferredSize(new Dimension(50, 25));
		btnR2L.setMaximumSize(new Dimension(50, 25));
		lblR2.setMinimumSize(new Dimension(165, 25));
		lblR2.setPreferredSize(new Dimension(165, 25));
		lblR2.setMaximumSize(new Dimension(165, 25));
		btnR2R.setMinimumSize(new Dimension(50, 25));
		btnR2R.setPreferredSize(new Dimension(50, 25));
		btnR2R.setMaximumSize(new Dimension(50, 25));
		

		btnR3L.setMinimumSize(new Dimension(50, 25));
		btnR3L.setPreferredSize(new Dimension(50, 25));
		btnR3L.setMaximumSize(new Dimension(50, 25));
		lblR3.setMinimumSize(new Dimension(165, 25));
		lblR3.setPreferredSize(new Dimension(165, 25));
		lblR3.setMaximumSize(new Dimension(165, 25));
		btnR3R.setMinimumSize(new Dimension(50, 25));
		btnR3R.setPreferredSize(new Dimension(50, 25));
		btnR3R.setMaximumSize(new Dimension(50, 25));
		

		btnR4L.setMinimumSize(new Dimension(50, 25));
		btnR4L.setPreferredSize(new Dimension(50, 25));
		btnR4L.setMaximumSize(new Dimension(50, 25));
		lblR4.setMinimumSize(new Dimension(165, 25));
		lblR4.setPreferredSize(new Dimension(165, 25));
		lblR4.setMaximumSize(new Dimension(165, 25));
		btnR4R.setMinimumSize(new Dimension(50, 25));
		btnR4R.setPreferredSize(new Dimension(50, 25));
		btnR4R.setMaximumSize(new Dimension(50, 25));
		

		btnR5L.setMinimumSize(new Dimension(50, 25));
		btnR5L.setPreferredSize(new Dimension(50, 25));
		btnR5L.setMaximumSize(new Dimension(50, 25));
		lblR5.setMinimumSize(new Dimension(165, 25));
		lblR5.setPreferredSize(new Dimension(165, 25));
		lblR5.setMaximumSize(new Dimension(165, 25));
		btnR5R.setMinimumSize(new Dimension(50, 25));
		btnR5R.setPreferredSize(new Dimension(50, 25));
		btnR5R.setMaximumSize(new Dimension(50, 25));
		

		lblArr1.setMinimumSize(new Dimension(290, 30));
		lblArr1.setPreferredSize(new Dimension(290, 30));
		lblArr1.setMaximumSize(new Dimension(290, 30));
		lblArr2.setMinimumSize(new Dimension(290, 30));
		lblArr2.setPreferredSize(new Dimension(290, 30));
		lblArr2.setMaximumSize(new Dimension(290, 30));
		lblArr3.setMinimumSize(new Dimension(290, 30));
		lblArr3.setPreferredSize(new Dimension(290, 30));
		lblArr3.setMaximumSize(new Dimension(290, 30));
		lblArr4.setMinimumSize(new Dimension(290, 30));
		lblArr4.setPreferredSize(new Dimension(290, 30));
		lblArr4.setMaximumSize(new Dimension(290, 30));
		lblArr5.setMinimumSize(new Dimension(290, 30));
		lblArr5.setPreferredSize(new Dimension(290, 30));
		lblArr5.setMaximumSize(new Dimension(290, 30));

		btnR1L.addActionListener(this);
		btnR1R.addActionListener(this);
		btnR2L.addActionListener(this);
		btnR2R.addActionListener(this);
		btnR3L.addActionListener(this);
		btnR3R.addActionListener(this);
		btnR4L.addActionListener(this);
		btnR4R.addActionListener(this);
		btnR5L.addActionListener(this);
		btnR5R.addActionListener(this);
	}
	
	

	public static void main(String[] args) {

		CarTemplate2 myFrame = new CarTemplate2();
		myFrame.setVisible(true);
		
		
		

	}



	@Override
	public void actionPerformed(ActionEvent evt) {
		int index = -1;
		int newindex = 0;
		String lblTxt1 = String.valueOf(lblR1.getText());
		String lblTxt2 = String.valueOf(lblR2.getText());
		String lblTxt3 = String.valueOf(lblR3.getText());
		String lblTxt4 = String.valueOf(lblR4.getText());
		String lblTxt5 = String.valueOf(lblR5.getText());

		if (evt.getSource() == btnR1L){			
			if(!lblTxt1.isEmpty()) {
			for (int i=0;i<arrMan.length;i++) {
			    if (arrMan[i].equals(lblTxt1)) {
			        index = i;
			        newindex = i - 1;
			        if(index >= 1) {     	
			        	
						System.out.print(newindex);
						lblR1.setText(arrMan[newindex]);
			        }
			        break;
			    }
			}
			}
			
		}
		if (evt.getSource() == btnR1R){
			
			if(!lblTxt1.isEmpty()) {
				for (int i=0;i<arrMan.length;i++) {
				    if (arrMan[i].equals(lblTxt1)) {
				        index = i;
						System.out.print(index);
				        if(index == 4) {  	
				        }else {

					        newindex = i + 1;
							lblR1.setText(arrMan[newindex]);
				        }
				        break;
				    }
				}
				}else {

					lblR1.setText(arrMan[0]);
				}
		}

		
		
		if (evt.getSource() == btnR2L){
			for (int i=0;i<arrFer.length;i++) {
			    if (arrFer[i].equals(lblTxt2)) {
			        index = i;
			        newindex = i - 1;
			        if(index >= 1) {     	
						lblR2.setText(arrFer[newindex]);
			        }
			        break;
			    }
			}
			
		}
		
		if (evt.getSource() == btnR2R){
			
			if(!lblTxt2.isEmpty()) {
				for (int i=0;i<arrFer.length;i++) {
				    if (arrFer[i].equals(lblTxt2)) {
				        index = i;
				        if(index == 4) {  	
				        }else {

					        newindex = i + 1;
							lblR2.setText(arrFer[newindex]);
				        }
				        break;
				    }
				}
				}else {

					lblR2.setText(arrFer[0]);
				}
			
			
		}

		if (evt.getSource() == btnR3L){
			for (int i=0;i<arrVol.length;i++) {
			    if (arrVol[i].equals(lblTxt1)) {
			        index = i;
			        newindex = i - 1;
			        if(index >= 1) {     	
						lblR3.setText(arrVol[newindex]);
			        }
			        break;
			    }
			}
			
		}
		if (evt.getSource() == btnR3R){
			
			if(!lblTxt3.isEmpty()) {
				for (int i=0;i<arrVol.length;i++) {
				    if (arrVol[i].equals(lblTxt3)) {
				        index = i;
				        if(index == 4) {  	
				        }else {

					        newindex = i + 1;
							lblR3.setText(arrVol[newindex]);
				        }
				        break;
				    }
				}
				}else {

					lblR3.setText(arrVol[0]);
				}
			
			
		}

		if (evt.getSource() == btnR4L){
			for (int i=0;i<arrFor.length;i++) {
			    if (arrFor[i].equals(lblTxt4)) {
			        index = i;
			        newindex = i - 1;
			        if(index >= 1) {     	
						lblR4.setText(arrFor[newindex]);
			        }
			        break;
			    }
			}
			
		}
		if (evt.getSource() == btnR4R){
			
			if(!lblTxt4.isEmpty()) {
				for (int i=0;i<arrFor.length;i++) {
				    if (arrFor[i].equals(lblTxt4)) {
				        index = i;
				        if(index == 4) {  	
				        }else {
					        newindex = i + 1;
							lblR4.setText(arrFor[newindex]);
				        }
				        break;
				    }
				}
				}else {

					lblR4.setText(arrFor[0]);
				}
			
			
		}

		if (evt.getSource() == btnR5L){
			
			for (int i=0;i<arrHon.length;i++) {
			    if (arrMan[i].equals(lblTxt5)) {
			        index = i;
			        newindex = i - 1;
			        if(index >= 1) {  	
			        	
						lblR5.setText(arrHon[newindex]);
			        }
			        break;
			    }
			}
		}
		if (evt.getSource() == btnR5R){
			
			if(!lblTxt5.isEmpty()) {
				for (int i=0;i<arrHon.length;i++) {
				    if (arrHon[i].equals(lblTxt5)) {
				        index = i;
				        if(index == 4) {  	
				        }else {
					        newindex = i + 1;
							lblR5.setText(arrHon[newindex]);
				        }
				        break;
				    }
				}
			}else {

				lblR5.setText(arrHon[0]);
			}
			
			
		}
		
		
		
		
		
	}
	
	

	
	
	

}
