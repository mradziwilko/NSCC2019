import java.util.Random;

public class TestCard {

	public static void main(String[] args) {
		
		// This is for #3 Random Card, every time you run the program, it will generate a Random Card.
		Random r = new Random();
	    int randomNum = r.nextInt((52 - 1) + 1) + 1;
	    
	    
	    // Show Blank Card Values
		System.out.println("===== Blank Card =====");
		Card newCard = new Card();
		newCard.Display();
		
		
		// Print out Static Generated Card (Values between 1 - 52)
		System.out.println("===== Next Card =====");
		newCard.setCard(2);
		newCard.setCard(newCard.getCardType(), "h");
		newCard.Display();

		
		// Random Card Values Returned.
		System.out.println("===== Random Card =====");
		newCard.setCard(randomNum);
		newCard.setCard(newCard.getCardType(), "H");
		newCard.Display();

		
		// Loop though 1 - 52 and show each card.
		System.out.println("===== Cards 1 - 52 Loop =====");
		int count = 1;
		while(true) {

			newCard.setCard(count);
			newCard.setCard(newCard.getCardType(), "H");
			newCard.Display();
			count++;
		   if(count == 53) {
		       break;
		   }
		}
	}

}
