
public class Card {
	
	
	private int cardValue;
	private String cardType, cardImg;

	public void setCardValue(int temp){ this.cardValue = temp; }
	public void setCardType(String temp){ this.cardType = temp; }
	public void setCardImg(String temp){ this.cardImg = temp; }

	public int getCardValue() { return this.cardValue; }
	public String getCardType() { return this.cardType; }
	public String getCardImg() { return this.cardImg; }
	
	

	public void Card() {
		
		cardValue = 1;
		cardType = "";
		cardImg = "";
	}
	
	
	public void setCard(int CNum) {
		
		
		if(CNum >= 1 && CNum <= 52) {
			
			
			switch (CNum) {
			
			case 1:
				cardValue = 1;
				cardType = "Ace of Hearts";
				cardImg = "ace_of_hearts.jpg";				
				break;
			case 2:
				cardValue = 2;
				cardType = "Two of Hearts";
				cardImg = "two_of_hearts.jpg";				
				break;
			case 3:
				cardValue = 3;
				cardType = "Three of Hearts";
				cardImg = "three_of_hearts.jpg";				
				break;
			case 4:
				cardValue = 4;
				cardType = "Four of Hearts";
				cardImg = "four_of_hearts.jpg";				
				break;
			case 5:
				cardValue = 5;
				cardType = "Five of Hearts";
				cardImg = "five_of_hearts.jpg";				
				break;
			case 6:
				cardValue = 6;
				cardType = "Six of Hearts";
				cardImg = "six_of_hearts.jpg";				
				break;
			case 7:
				cardValue = 7;
				cardType = "Seven of Hearts";
				cardImg = "seven_of_hearts.jpg";				
				break;
			case 8:
				cardValue = 8;
				cardType = "Eight of Hearts";
				cardImg = "eight_of_hearts.jpg";
				
				break;
			case 9:
				cardValue = 9;
				cardType = "Nine of Hearts";
				cardImg = "nine_of_hearts.jpg";				
				break;
			case 10:
				cardValue = 10;
				cardType = "Ten of Hearts";
				cardImg = "ten_of_hearts.jpg";				
				break;
			case 11:
				cardValue = 11;
				cardType = "Jack of Hearts";
				cardImg = "jack_of_hearts.jpg";				
				break;
			case 12:
				cardValue = 11;
				cardType = "Queen of Hearts";
				cardImg = "queen_of_hearts.jpg";				
				break;
			case 13:
				cardValue = 11;
				cardType = "King of Hearts";
				cardImg = "king_of_hearts.jpg";				
				break;	
			case 14:
				cardValue = 1;
				cardType = "Ace of Diamonds";
				cardImg = "ace_of_diamonds.jpg";				
				break;
			case 15:
				cardValue = 2;
				cardType = "Two of Diamonds";
				cardImg = "two_of_diamonds.jpg";				
				break;
			case 16:
				cardValue = 3;
				cardType = "Three of Diamonds";
				cardImg = "three_of_diamonds.jpg";				
				break;
			case 17:
				cardValue = 4;
				cardType = "Four of Diamonds";
				cardImg = "four_of_diamonds.jpg";				
				break;
			case 18:
				cardValue = 5;
				cardType = "Five of Diamonds";
				cardImg = "five_of_diamonds.jpg";				
				break;
			case 19:
				cardValue = 6;
				cardType = "Six of Diamonds";
				cardImg = "six_of_diamonds.jpg";				
				break;
			case 20:
				cardValue = 7;
				cardType = "Seven of Diamonds";
				cardImg = "seven_of_diamonds.jpg";				
				break;
			case 21:
				cardValue = 8;
				cardType = "Eight of Diamonds";
				cardImg = "eight_of_diamonds.jpg";
				
				break;
			case 22:
				cardValue = 9;
				cardType = "Nine of Diamonds";
				cardImg = "nine_of_diamonds.jpg";				
				break;
			case 23:
				cardValue = 10;
				cardType = "Ten of Diamonds";
				cardImg = "ten_of_diamonds.jpg";				
				break;
			case 24:
				cardValue = 11;
				cardType = "Jack of Diamonds";
				cardImg = "jack_of_diamonds.jpg";				
				break;
			case 25:
				cardValue = 11;
				cardType = "Queen of Diamonds";
				cardImg = "queen_of_diamonds.jpg";				
				break;
			case 26:
				cardValue = 11;
				cardType = "King of Diamonds";
				cardImg = "king_of_diamonds.jpg";				
				break;	
			case 27:
				cardValue = 1;
				cardType = "Ace of Clubs";
				cardImg = "ace_of_clubs.jpg";				
				break;
			case 28:
				cardValue = 2;
				cardType = "Two of Clubs";
				cardImg = "two_of_clubs.jpg";				
				break;
			case 29:
				cardValue = 3;
				cardType = "Three of Clubs";
				cardImg = "three_of_clubs.jpg";				
				break;
			case 30:
				cardValue = 4;
				cardType = "Four of Clubs";
				cardImg = "four_of_clubs.jpg";				
				break;
			case 31:
				cardValue = 5;
				cardType = "Five of Clubs";
				cardImg = "five_of_clubs.jpg";				
				break;
			case 32:
				cardValue = 6;
				cardType = "Six of Clubs";
				cardImg = "six_of_clubs.jpg";				
				break;
			case 33:
				cardValue = 7;
				cardType = "Seven of Clubs";
				cardImg = "seven_of_clubs.jpg";				
				break;
			case 34:
				cardValue = 8;
				cardType = "Eight of Clubs";
				cardImg = "eight_of_clubs.jpg";
				break;
			case 35:
				cardValue = 9;
				cardType = "Nine of Clubs";
				cardImg = "nine_of_clubs.jpg";				
				break;
			case 36:
				cardValue = 10;
				cardType = "Ten of Clubs";
				cardImg = "ten_of_clubs.jpg";				
				break;
			case 37:
				cardValue = 11;
				cardType = "Jack of Clubs";
				cardImg = "jack_of_clubs.jpg";				
				break;
			case 38:
				cardValue = 11;
				cardType = "Queen of Clubs";
				cardImg = "queen_of_clubs.jpg";				
				break;
			case 39:
				cardValue = 11;
				cardType = "King of Clubs";
				cardImg = "king_of_clubs.jpg";				
				break;	
			case 40:
				cardValue = 1;
				cardType = "Ace of Spades";
				cardImg = "ace_of_spades.jpg";				
				break;
			case 41:
				cardValue = 2;
				cardType = "Two of Spades";
				cardImg = "two_of_spades.jpg";				
				break;
			case 42:
				cardValue = 3;
				cardType = "Three of Spades";
				cardImg = "three_of_spades.jpg";				
				break;
			case 43:
				cardValue = 4;
				cardType = "Four of Spades";
				cardImg = "four_of_spades.jpg";				
				break;
			case 44:
				cardValue = 5;
				cardType = "Five of Spades";
				cardImg = "five_of_spades.jpg";				
				break;
			case 45:
				cardValue = 6;
				cardType = "Six of Spades";
				cardImg = "six_of_spades.jpg";				
				break;
			case 46:
				cardValue = 7;
				cardType = "Seven of Spades";
				cardImg = "seven_of_spades.jpg";				
				break;
			case 47:
				cardValue = 8;
				cardType = "Eight of Spades";
				cardImg = "eight_of_spades.jpg";
				
				break;
			case 48:
				cardValue = 9;
				cardType = "Nine of Spades";
				cardImg = "nine_of_spades.jpg";				
				break;
			case 49:
				cardValue = 10;
				cardType = "Ten of Spades";
				cardImg = "ten_of_spades.jpg";				
				break;
			case 50:
				cardValue = 11;
				cardType = "Jack of Spades";
				cardImg = "jack_of_spades.jpg";				
				break;
			case 51:
				cardValue = 11;
				cardType = "Queen of Spades";
				cardImg = "queen_of_spades.jpg";				
				break;
			case 52:
				cardValue = 11;
				cardType = "King of Spades";
				cardImg = "king_of_spades.jpg";				
				break;
			
			}
			
			
			
			
			
			
			
			
			
			
		}else {
			System.out.print("Number out of bounce.");
		}
	}
	

	public void setCard(String cName, String CType) {

		if(CType == "H" || CType == "h") {


			boolean isFound = cName.indexOf("Ace") !=-1? true: false;
		
			if(isFound == true) {
				cardValue = 11;
			}
			
		}
		
	}
	public void Display() {
		
		System.out.println("       Card: " + cardType);
		System.out.println(" Card Image: " + cardImg);
		System.out.println(" Card Value: " + cardValue);

	}
	
	
}

