'----------------------------------------------------------------------------
'Program Info
'----------------------------------------------------------------------------
'Program: Interest Calculator
'Date: 9/25/2019
'Author: Marshall Radziwilko
'Operation: 
' Ask Questions 
' Do Calculations
' Output Results
' Exit Application
'
'-----------------------------------------------------------------------------
'Change Log
'-----------------------------------------------------------------------------
'Date Programmer Change 
'9/25/2019 - Added Comments
'-----------------------------------------------------------------------------
Module Module1


	Sub Main(args as String())
	
		' I do this to clear input of Console for Better Reading.
		Console.Clear()	
	
		' Declare Variables and Declare String Text
		Dim decLoanAmm as Decimal
		Dim decLoanRate as Decimal
		Dim intLoanTerm as Integer		
		Dim txtQLoan = "Enter the Loan Ammount"
		Dim txtQRate = "Enter the Annual Interest Rate"
		Dim txtQTerm = "Enter the Loan Period in Months"
		
		
		' Set Statements
		Dim txtLoanAmm = "Loan Ammount"
		Dim txtRate = "Interest Rate"
		Dim txtTerm = "Number of Months"
		Dim txtTotalCost = "Total cost of the Loan: "
		Dim txtTotalInterest = "Total Interest: "
		Dim txtSep = "------------------------------------------"
		
		
		'Ask Question Loan Amount
		Console.WriteLine(vbCrlf + txtQLoan)
		decLoanAmm = Console.ReadLine()
		
		
		'Ask Question Yearly Rate
		Console.WriteLine(vbCrlf + txtQRate)
		decLoanRate = Console.ReadLine()
		
		
		'Ask Question Term
		Console.WriteLine(vbCrlf + txtQTerm)
		intLoanTerm = Console.ReadLine()
		
		
		
		
		' Calculate Rate
		Dim rate = ((decLoanRate / 100) / 12)
		
		'Calculate Upper Ammount
		Dim Upper = rate * decLoanAmm
		
		'Calculate Lower Ammount
		Dim Lower = (1 - ((1+ rate) ^ (-1 * intLoanTerm)))
		
		'Devide Upper by Lower
		Dim Divide = Upper / Lower
		
		'Multiply by Loan term
		Dim Times = Divide * intLoanTerm		
	
		'Round Number to Whole Number with 2 Decimal Places
		Dim Shrink = Math.Round(Times, 2)	
		
		'Get Loan Rate Cost and Shrink
		Dim intrest = Math.Round(Shrink - decLoanAmm,2)
		
		
		
		
		'Output Loan Ammount
		Console.WriteLine(vbCrlf + txtLoanAmm)
		Console.WriteLine(txtSep)
		Console.WriteLine(decLoanAmm.ToString("C"))
		
		
		'Output Rate Yearly
		Console.WriteLine(vbCrlf + txtRate & " Yearly")
		Console.WriteLine(txtSep)
		Console.WriteLine(decLoanRate & "%")
		
		'Output Rate Monthly
		Console.WriteLine(vbCrlf + txtRate & " Monthly")
		Console.WriteLine(txtSep)
		Console.WriteLine(rate.ToString("p"))
		
		'Output Term
		Console.WriteLine(vbCrlf + txtTerm)
		Console.WriteLine(txtSep)
		Console.WriteLine(intLoanTerm)
		
		
		'Output Total Loan
		Console.WriteLine(vbCrlf + txtTotalCost & Shrink.ToString("C"))		
		
		'Output Total Interest
		Console.WriteLine(vbCrlf + txtTotalInterest & intrest.ToString("C"))
		
		
		
		'Output Notice and Exit Application
		Console.WriteLine(vbCrlf + "Press any key to continue.")
		Console.ReadKey(true)
		
	End Sub 


End Module