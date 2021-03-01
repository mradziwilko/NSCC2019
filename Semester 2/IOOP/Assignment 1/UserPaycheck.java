import javax.swing.JOptionPane;
import java.text.NumberFormat;
public class UserPaycheck {

    public static void main(String[] args) {
        // Number Formatter
        NumberFormat formatter = NumberFormat.getCurrencyInstance();
        // Define Rate and Ask for Input.
		String strRate  = JOptionPane.showInputDialog(null, "Enter Hourly Pay Rate:");
        // Define Hours and Ask for Input
        String strHours = JOptionPane.showInputDialog(null, "Enter Hours Worked:");
        // Convert String to Double
        double rate = Double.parseDouble(strRate);
        // Convert String to Integer
        int hours = Integer.parseInt(strHours);
        
        // Do Math
        double worked = hours * rate;
        double deduction = worked * 0.10;
        double result = worked - deduction;

        // Output Resaults.
		System.out.println("Hours Worked: "+hours);
		System.out.println("Hourly Pay: "+formatter.format(rate)+" /h");
		System.out.println("Withholding: "+formatter.format(deduction));
		System.out.println("Total Payed Amount witholding Tax: "+formatter.format(result));

    }

}