import javax.swing.JOptionPane;

public class MyHobby2 {

	public static void main(String[] args) {
		

		// Assign Variables and Answers
		double right = 0.00, wrong = 0.00;
		int q1Input, q2Input, q3Input, q4Input, q5Input;
		int q1Answer = 3, q2Answer = 99, q3Answer = 62, q4Answer = 8, q5Answer = 5;
		double subtotal = 0.00, total = 0.00;
		

		// Title
		System.out.println("Hockey Questions: ");

		

		// Do While loop, Each question is asked untill the right answer is asnswered, if it is answered, add to total.
		do{
			String strQuestion1 = JOptionPane.showInputDialog(null, "How many periods does a hockey game have?");
			q1Input = Integer.parseInt(strQuestion1);
			if(q1Input == q1Answer) {
				System.out.println("How many periods does a hockey game have? "+q1Input+"   Answer Correct");	
				right++;
			}
		}while(q1Input != q1Answer);
		
		
		
		


		do{
			String strQuestion2 = JOptionPane.showInputDialog(null, "What is Wayne Gretzky Player Number?");
			q2Input = Integer.parseInt(strQuestion2);
			if(q2Input == q2Answer) {
				System.out.println("What is Wayne Gretzky Player Number? "+ q2Input +"   Answer Correct");		
				right++;
			}
		}while(q2Input != q2Answer);
		
		
		
		


		do{
			String strQuestion3 = JOptionPane.showInputDialog(null, "What is the current points of the Edmonton Oilers?");
			q3Input = Integer.parseInt(strQuestion3);
			if(q3Input == q3Answer) {
				System.out.println("What is the current points of the Edmonton Oilers? "+ q3Input +"   Answer Correct");		
				right++;
			}		
		}while(q3Input != q3Answer);
		
		
		
		


		do{
			String strQuestion4 = JOptionPane.showInputDialog(null, "How many goals in the last game against calgary did Edmonton score?");
			q4Input = Integer.parseInt(strQuestion4);
			if(q4Input == q4Answer) {
				System.out.println("How many goals in the last game against calgary did Edmonton score? "+ q4Input+"   Answer Correct");	
				right++;
			}	
		}while(q4Input != q4Answer);
		
		
		
		


		do{
			String strQuestion5 = JOptionPane.showInputDialog(null, "How much did Calgary Lose by?");
			q5Input = Integer.parseInt(strQuestion5);
			if(q5Input == q5Answer) {
				System.out.println("How much did Calgary Lose by? "+ q5Input +"   Answer Correct");	
				right++;
			}		
		}while(q5Input != q5Answer);
		
		
		

		//  Print Inputs Correct / Incorrect
		System.out.println("\n ================================================= \n");	
		
		System.out.println("Correct Answers: "+  Math.round(right));
		System.out.println("Wrong Answers: "+  Math.round(wrong));
		
		

		// Do Math to find out Math Grade
		subtotal = right / 5;
		total = subtotal * 100;
		

		// Output Percent.
		System.out.println("Grade Percent: "+ Math.round(total)+"%");
		

	}

}
