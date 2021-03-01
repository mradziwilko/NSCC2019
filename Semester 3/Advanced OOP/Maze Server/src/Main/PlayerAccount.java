package Main;

public class PlayerAccount {
	private double balance;
	
	public PlayerAccount() { balance = 0.00; }
	public PlayerAccount(double temp) { balance = temp; }
	
	public void deposit(double amount) { this.balance += amount; }
	public void withdraw(double amount) { this.balance -= amount; }
	public double getBalance() { return this.balance; }
}
