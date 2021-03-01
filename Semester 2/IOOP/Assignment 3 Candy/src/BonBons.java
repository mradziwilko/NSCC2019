
public class BonBons  extends Candy{

	// Set Values for new Bonbons that extends Candy
	private String CandyType;
	private double Calories;
	
	
	
	// Create mutators and accessor's 
	public void setCandyType (String temp) { this.CandyType = temp; }
	public void setCalories  (double temp) { this.Calories = temp; }

	public String getCandyType() { return this.CandyType; }
	public double getCalories() { return this.Calories; }

	// Default Function for set values with Super
	public BonBons() {
		super();
		CandyType = "Chocolate";
		Calories = 0.00;

		
	}
	
	// How setting fo each values from previous form. add 2 new feilds and do math.
	public BonBons(String s1, String s2, double d1, double d2) {

		super(s1, d1);
		CandyType = s2;
		Calories = d2;
		this.price = 2.50*d1;
		

		
	}
	
	
	// Display Function
	public void Display() {

		super.Display();

		System.out.println("    Bonbon Type: " + CandyType);
		System.out.println("Bonbon Calories: " + Calories);

	}
	
}
