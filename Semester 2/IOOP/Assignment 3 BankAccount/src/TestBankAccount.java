
public class TestBankAccount extends BankAccount {

	public static void main(String[] args) {
		
		BankAccount ba1 = new BankAccount();

		System.out.println("===== Default Bank Acc =====");
		// To set each one manual use:
		ba1.Display();
		

		System.out.println("===== John Doe Bank Acc =====");
		ba1.setAccNumber(12354);
		ba1.setFirstName("John");
		ba1.setLastName("Doe");
		ba1.setaddress("1 Washington Lane");
		ba1.setbalance(1000000.00);
		ba1.Display();
		

		System.out.println("===== Peter Randle Bank Acc =====");
		// Use Mutator to set all values.
		BankAccount ba2 = new BankAccount(423, "Peter", "Randle", "7 Antibies Dr", 54025513254.00);
		
		ba2.Display();
		

		System.out.println("===== Darren Andrews Bank Acc =====");
		// Set Mutator 3 to only set strings.
		BankAccount ba3 = new BankAccount("Darren", "Andrews", "44 Ronald St");
		ba3.Display();
		
		
	}

}
