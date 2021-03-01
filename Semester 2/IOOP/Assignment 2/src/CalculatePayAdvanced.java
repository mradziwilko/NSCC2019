import java.text.NumberFormat;

import javax.swing.JOptionPane;

public class CalculatePayAdvanced {

	public static void main(String[] args) {
		// Number format for Currency Output.
        NumberFormat formatter = NumberFormat.getCurrencyInstance();
        
        int txtHolding = 0, worked;
        double rate = 0.00, subtotal = 0.00,  wHolding = 0.00, total = 0.00;

		// Get Weight per Bags
		String strRate = JOptionPane.showInputDialog(null, "Please enter pay rate.");
		rate = Double.parseDouble(strRate);

		// Get Weight per Bags
		String strHours = JOptionPane.showInputDialog(null, "Please enter hours worked.");
		worked = Integer.parseInt(strHours);
		
		subtotal = rate * worked;
		
		// If between numbers, calculate withholding tax.
		if(subtotal <= 300.00) {
			txtHolding = 10;
			wHolding = subtotal * 0.10;
		}else if(subtotal >= 300.01 && subtotal <= 400.00 ) {
			txtHolding = 12;
			wHolding = subtotal * 0.12;
		}else if(subtotal >= 400.01 && subtotal <= 500.00 ) {
			txtHolding = 15;
			wHolding = subtotal * 0.15;
		}else if(subtotal >= 500.01 ) {
			txtHolding = 20;
			wHolding = subtotal * 0.20;
			
		}
		
		total = subtotal - wHolding;
		
		// Output 
		System.out.println("        Total Payment: "+ formatter.format(subtotal));
		System.out.println("Withholding Tax ("+txtHolding+"%): "+ formatter.format(wHolding));
		System.out.println("            Total Pay: "+ formatter.format(total));
        
	}

}
