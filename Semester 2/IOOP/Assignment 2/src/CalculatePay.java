import java.text.NumberFormat;

import javax.swing.JOptionPane;

public class CalculatePay {

	public static void main(String[] args) {
		// Number format for Currency Output.
        NumberFormat formatter = NumberFormat.getCurrencyInstance();
        
        int worked;
        double rate = 0.00, subtotal = 0.00, wHolding = 0.00, total = 0.00;

		// Get Weight per Bags
		String strRate = JOptionPane.showInputDialog(null, "Please enter pay rate.");
		rate = Double.parseDouble(strRate);

		// Get Weight per Bags
		String strHours = JOptionPane.showInputDialog(null, "Please enter hours worked.");
		worked = Integer.parseInt(strHours);
		
		subtotal = rate * worked;
		
		// Calculate withholding Tax
		if(subtotal <= 300) {
			wHolding = subtotal * 0.10;
		}else {
			wHolding = subtotal * 0.12;
			
		}
		
		
		// Remove Withholding from Total
		total = subtotal - wHolding;
		

		// Display Results.
		System.out.println("  Total Payment: "+ formatter.format(subtotal));
		System.out.println("Withholding Tax: "+ formatter.format(wHolding));
		System.out.println("      Total Pay: "+ formatter.format(total));
        
	}

}
