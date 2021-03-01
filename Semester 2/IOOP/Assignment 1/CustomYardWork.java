import javax.swing.JOptionPane;

public class CustomYardWork {

    public static void main(String[] args) {
        
		// Define and Get input for Length and Width
		String strlength  = JOptionPane.showInputDialog(null, "Please Enter the Length:");
		String strwidth = JOptionPane.showInputDialog(null, "Please enter the Width:");
		// Convert Strings to Doubles
		double length = Double.parseDouble(strlength);
		double width = Double.parseDouble(strwidth);

		// Calculate Math
		double result = length*width;

		// Output Resault.
		System.out.println("You have "+result+" square feet to mow");

    }

}