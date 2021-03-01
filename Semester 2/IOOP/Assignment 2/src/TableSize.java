import java.text.NumberFormat;

import javax.swing.JOptionPane;

public class TableSize {

	public static void main(String[] args) {
		// Number format for Currency Output.
        NumberFormat formatter = NumberFormat.getCurrencyInstance();
        

        int chosenType = 0,chosenSize = 0;
        double pine = 100.00, oak = 225.00, mahogany = 310.00, total = 0.00, lrgTable = 35.00, finalTotal = 0.00;
        

        // Display Menu if a invalid choice is made then display menu again until valid menu is visible.
        do{  
    		String strChosenTable = JOptionPane.showInputDialog(null, "Please Choose a Option:\n 1. Pine\n 2. Oak\n 3. Mahogany");
    		chosenType = Integer.parseInt(strChosenTable); 
        } while ((chosenType < 1) || (chosenType > 3 ));

        // Display Menu if a invalid choice is made then display menu again until valid menu is visible.
        do{  
    		String strChosenSize = JOptionPane.showInputDialog(null, "Please Choose a Option:\n 1. Small Table\n 2. Large Table");
    		chosenSize = Integer.parseInt(strChosenSize); 
        } while ((chosenSize < 1) || (chosenSize > 2 ));

        
        // Display Chosen, and add cost to total.
        if(chosenType == 1) {
    		System.out.println("Chosen Table: Pine");
    		total = pine;
        }else if(chosenType == 2) {
    		System.out.println("Chosen Table: Oak"); 
    		total = oak;       	
        }else if(chosenType == 3) {
    		System.out.println("Chosen Table: Mahogany");   
    		total = mahogany;     	
        	
        }


        // If Large is chosen, add to 35$ to total
        if(chosenSize == 1) {
    		System.out.println("Chosen Size: Small Table \nCosts: "+ formatter.format(total)); 

        
        }else if(chosenSize == 2) {
        	System.out.println("Chosen Size: Large Table"); 
        	System.out.println("Extra Cost: "+ formatter.format(lrgTable)); 
        	finalTotal = total + lrgTable;
        	System.out.println("Total: "+ formatter.format(finalTotal)); 
    		

        }
	}

}
