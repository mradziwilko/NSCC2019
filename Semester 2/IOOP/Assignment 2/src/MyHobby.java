import javax.swing.JOptionPane;

public class MyHobby {

	public static void main(String[] args) {


		// Assign Variables 
		double right = 0.00, wrong = 0.00;
		int q1Answer, q2Answer, q3Answer, q4Answer, q5Answer;
		double subtotal = 0.00, total = 0.00;

		


		// Title
		System.out.println("Hockey Questions: ");
		
		

		// Ask QUestion and Store Number
		String strQuestion1 = JOptionPane.showInputDialog(null, "How many periods does a hockey game have?");
		q1Answer = Integer.parseInt(strQuestion1);

		

		// If Correct Answers Add points, if Incorrect Add to Incorrect points and print out Responses
		if(q1Answer== 3) {
			System.out.println("How many periods does a hockey game have? "+q1Answer+"   Answer Correct");		
			right++;
		}else {
			wrong++;
			System.out.println("Correct Answer is: 3");			
		}
		

		// Ask QUestion and Store Number
		String strQuestion2 = JOptionPane.showInputDialog(null, "What is Wayne Gretzky Player Number?");
		q2Answer = Integer.parseInt(strQuestion2);

		// If Correct Answers Add points, if Incorrect Add to Incorrect points and print out Responses
		if(q2Answer== 99) {
			System.out.println("What is Wayne Gretzky Player Number? "+ q2Answer +"   Answer Correct");		
			right++;
		}else {
			wrong++;
			System.out.println("Correct Answer is: 99");			
		}
		
		

		// Ask QUestion and Store Number
		String strQuestion3 = JOptionPane.showInputDialog(null, "What is the current points of the Edmonton Oilers?");
		q3Answer = Integer.parseInt(strQuestion3);

		// If Correct Answers Add points, if Incorrect Add to Incorrect points and print out Responses
		if(q3Answer== 62) {
			System.out.println("What is the current points of the Edmonton Oilers? "+ q3Answer +"   Answer Correct");		
			right++;
		}else {
			wrong++;
			System.out.println("Correct Answer is: 62");			
		}
		
		

		// Ask QUestion and Store Number
		String strQuestion4 = JOptionPane.showInputDialog(null, "How many goals in the last game against calgary did edmonton score?");
		q4Answer = Integer.parseInt(strQuestion4);

		// If Correct Answers Add points, if Incorrect Add to Incorrect points and print out Responses
		if(q4Answer== 8) {
			System.out.println("How many goals in the last game against calgary did Edmonton score? "+ q4Answer+"   Answer Correct");	
			right++;
		}else {
			wrong++;
			System.out.println("Correct Answer is: 8");			
		}
		
		

		// Ask QUestion and Store Number
		String strQuestion5 = JOptionPane.showInputDialog(null, "How much did Calgary Lose by?");
		q5Answer = Integer.parseInt(strQuestion5);

		// If Correct Answers Add points, if Incorrect Add to Incorrect points and print out Responses
		if(q5Answer== 5) {
			System.out.println("How much did Calgary Lose by? "+ q5Answer +"   Answer Correct");	
			right++;
		}else {
			wrong++;
			System.out.println("Correct Answer is: 5");			
		}
		
		
		// Output Correct/Incorrect Numbers

		System.out.println("\n ================================================= \n");	
		
		System.out.println("Correct Answers: "+  Math.round(right));
		System.out.println("Wrong Answers: "+  Math.round(wrong));
		
		
		// Get Percent Total
		subtotal = right / 5;
		total = subtotal * 100;
		

		// Output Percent.
		System.out.println("Grade Percent: "+ Math.round(total)+"%");
		

	}

}
