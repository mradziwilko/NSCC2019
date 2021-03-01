
public class BankAccount{

private int accNumber;
private String Name;
private double balance = 8;

public void setAccNumber(int temp) {this.accNumber = temp; }

public void setName(String temp) {this.Name = temp; }

public void setAccBalance(double Balance) {
	double getCurrBalance = this.getBalance();	
	double CalcBalance = Balance + getCurrBalance;
	balance = CalcBalance;	
}

public int getAccNumber() {return accNumber;}
public String getName() {return Name;}
public double getBalance() {return balance;}

public BankAccount()
{
    accNumber = 2; 
    Name="";
    balance = 2.0;
}

public BankAccount(int i1,String s1, String s2, String s3, double d1)
{
	accNumber = i1; 
	Name=s1;
	balance = d1;
}


public BankAccount(int inpAcc, double inpTrans, String inpName) {
	accNumber = inpAcc; 
	Name = inpName;	
    balance = inpTrans;
}


public void Display()
{
    System.out.println("Acc Number:" + accNumber);
    System.out.println("First Name:" + Name);
    System.out.println("Balance:" + balance);
}


}