package Main;

public class Player {

	private PlayerAccount[ ] accounts;
	
	public Player(int size) {
		accounts = new PlayerAccount[size];
		for( int i=0; i < size; i++) {
			accounts[i] = new PlayerAccount();
		}
	}
	
	public void deposit(int accNo, double amt) {
		accounts[accNo].deposit(amt);
	}

	public void withdraw(int accNo, double amt) {
		accounts[accNo].withdraw(amt);
	}

	public double getBalance(int accNo) {
		return accounts[accNo].getBalance();
	}


	public String getName(String accNo) {
		//return accounts[accNo].getName();
		return "1";
	}

}
