import javax.swing.JOptionPane;

public class FourToGo {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int q=0;
		do{

			// Get Weight per Bags
			String strQuestion = JOptionPane.showInputDialog(null, "Please type 1 2 3 or 4 (4 to End).");
			q = Integer.parseInt(strQuestion);
			if(q == 4) {

	             System.out.println("Error: Exiting Application.");
	             break;
			}else if(q <= 0 || q > 4) {
	             System.out.println("Invalid Choice, please try again.");
			
			}else {

	             System.out.println("Thank You");

			}
			
		}while(q <= 3 || q >= 1);
	}

}
