
public class TestBonCandy {

	public static void main(String[] args) {
		
		// Candy Default Values
		System.out.println("===== Start Candy =====");
		Candy newCandy = new Candy();		
		newCandy.Display();		

		
		// Set New Value to Green and total of 5cm
		System.out.println("===== First Entry Candy =====");
		Candy newCandy2 = new Candy("Green", 5.0);
		newCandy2.Display();
		

		
		// Add Bonbons values (2 extra values at end into original Candy Sub)
		System.out.println("===== Start BonBons =====");
		BonBons b1 = new BonBons();
		
		b1.Display();

		
		// Set Values for all values
		System.out.println("===== First BonBons =====");
		BonBons b2 = new BonBons("Pink", "Elephants", 10.0, 510);
		
		b2.Display();

	}

}
