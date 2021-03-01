
public class Candy {

	
	// Default Variables
	private double length;
	protected double price, cost;
	private String color;
	
	// mutators and accessor's
	public void setLength (double temp) { this.length = temp; }
	public void setColor (String temp) { this.color = temp; }

	public double getPrice() { return this.price; }

	public double getLength() { return this.length; }
	public String getColor() { return this.color; }
	
	
	
	// Default Values
	public Candy() {
		price = 1.50;
		length = 2.00;
		color = "black";
	}


	// First Mutator sets String and Double, also does math with setPrice() function
	public Candy(String s1, double d1) {
		length = d1;
		color = s1;
		cost = 0.75;
		price = setPrice(d1, cost);
	}
	
	// Set Price simple math, Multiply the length by cost
	public double setPrice(double d1, double cost) { return d1*cost; }
	
	
	// Display Function
 	public void Display() {
		System.out.println("Length: " + length);
		System.out.println(" Color: " + color);
		System.out.println(" Price: " + price);
	}
 	
}

