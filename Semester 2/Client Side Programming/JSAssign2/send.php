<?php

// Get Data from Post

			$strTitle = $_POST['title'];
			$strNme = $_POST['name'];
			$strEml = $_POST['email'];
			$strAre = $_POST['area'];
			$strNum = $_POST['number'];
			$strCountry = $_POST['country'];
			$strPW = $_POST['password'];
			$strPhone = "(".$strAre.")".$strNum;

		// CHANGE ME SECTION TO YOUR EMAIL! //
			$to = "w0256451@nscc.ca";
			$subject = "Account Creation";
		// ** End Section ** //


		// ** Format Message ** //
			$message = "
			<html>
				<head>
					<title>Account Created Response</title>
				</head>
				<body>
					<p>Account Created Response for: ".$strNme." Account Created</p>
					<table>
						<tr>
							<th>Title</th>
							<th>".$strTitle."</th>
						</tr>
						<tr>
							<th>Name</th>
							<th>".$strNme."</th>
						</tr>
						<tr>
							<th>Email</th>
							<th>".$strEml."</th>
						</tr>
						<tr>
							<th>Phone Number</th>
							<th>".$strPhone."</th>
						</tr>
						<tr>
							<th>Location</th>
							<th>".$strCountry."</th>
						</tr>
						<tr>
							<th>Password</th>
							<th>".$strPW."</th>
						</tr>
					</table>
				</body>
			</html>
			";

		// ** End Section ** //


		// ** Set Headers ** //
		$headers = "MIME-Version: 1.0" . "\r\n";
		$headers .= "Content-type:text/html;charset=UTF-8" . "\r\n";
		$headers .= "From: <".$strEml.">" . "\r\n";
		// ** End Section ** //

		// ** Send Email, Return 1 for sent, 0 for error ** //
			if (mail($to,$subject,$message,$headers)) {
			   echo("1");
			} else {
			   echo("0");
			}
		// ** End Section ** //
?>


