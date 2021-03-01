
public class BankAccount {

	
	// Variables
	private int AccNumber;
	private String firstName, lastName, address;
	private double balance;

	
	// Set mutators and accessor's
	public void setAccNumber (int temp) { this.AccNumber = temp; }
	public void setFirstName (String temp) { this.firstName = temp; }
	public void setLastName (String temp) { this.lastName = temp; }
	public void setaddress (String temp) { this.address = temp; }	
	public void setbalance (double temp) { this.balance = temp; }

	public int getAccNumber() { return this.AccNumber; }
	public String getFirstName() { return this.firstName; }
	public String getLastName() { return this.lastName; }
	public String getaddress() { return this.address; }
	public double getbalance() { return this.balance; }


	
	// Set default variables
	public BankAccount() {
		AccNumber = 2;
		firstName = "";
		lastName = "";
		address = "";
		balance = 2.00;
	}
	
	
	// Set first mutators 
	public BankAccount(int i1, String s1, String s2, String s3, double d1) {
		AccNumber = i1;
		firstName = s1;
		lastName = s2;
		address = s3;
		balance = d1;	
	}
	
	
	
	// Set second mutators 
	public BankAccount(String s1, String s2, String s3) {
		AccNumber = 2;
		firstName = s1;
		lastName = s2;
		address = s3;
		balance = 2.0;
	}

	
	// Display Function
	public void Display() {
		
		System.out.println(" Account #: " + AccNumber);
		System.out.println("First Name: " + firstName);
		System.out.println(" Last Name: " + lastName);
		System.out.println("   Address: " + address);
		System.out.println("   Balance: " + balance);
	}
	

}
