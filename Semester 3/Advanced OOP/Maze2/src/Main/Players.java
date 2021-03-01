package Main;

public class Players {
			
	
	private static String name;
	private static int wins;
	
	public Players(String name, int wins) {
		
		this.name = name;
		this.wins = wins;
	}
	

	public String getName() { return this.name; };
	public int getWins() { return this.wins; };
	

	public void setName(String tmp) { this.name = tmp; }

	public void setWins(int tmp) { this.wins = tmp; }
	
	
	public void status() {
		System.out.println("Name" + getName());
		System.out.println("Score" + getWins());
	}
	
	
	
	
	
}
