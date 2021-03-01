import java.text.NumberFormat;

import javax.swing.JOptionPane;

public class Table {

	public static void main(String[] args) {
		// Number format for Currency Output.
        NumberFormat formatter = NumberFormat.getCurrencyInstance();
        
        // Store Variables
        int chosenType = 0;
        double pine = 100.00, oak = 225.00, mahogany = 310.00;
        

        // Display Menu if a invalid choice is made then display menu again until valid menu is visible.
        do{  
    		String strChosen = JOptionPane.showInputDialog(null, "Please Choose a Option:\n 1. Pine\n 2. Oak\n 3. Mahogany");
    		chosenType = Integer.parseInt(strChosen); 
        } while ((chosenType < 1) || (chosenType > 3 ));
        
        
        // if Chosen type is chosen, output cost.
        if(chosenType == 1) {
    		System.out.println("Chosen Table: Pine   \nCosts: "+ formatter.format(pine));
        }else if(chosenType == 2) {
    		System.out.println("Chosen Table: Oak   \nCosts: "+ formatter.format(oak));        	
        }else if(chosenType == 3) {
    		System.out.println("Chosen Table: Mahogany   \nCosts: "+ formatter.format(mahogany));
        	
        	
        }
	}

}
