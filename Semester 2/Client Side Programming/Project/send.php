<?php
    if ($_SERVER["REQUEST_METHOD"] == "POST") {
		
		
		
		/* Configuration  */
        $mail_to = "mradziwilko@msn.com";
		
		
				
		/* Do Not Edit Below - or Marshall Will Get you :) */
		
		
		/* Trim All unwanted chars from Subject, and Name, make sure Email is properly formated.  */
        $subject = trim($_POST["subject"]);        
		$name = str_replace(array("\r","\n"),array(" "," ") , strip_tags(trim($_POST["name"])));
        $email = filter_var(trim($_POST["email"]), FILTER_SANITIZE_EMAIL);
        $phone = trim($_POST["phone"]);
        $message = trim($_POST["message"]);
        
		
		
		// Check for Errors if so throw Error Code.
        if ( empty($name) OR !filter_var($email, FILTER_VALIDATE_EMAIL) OR empty($phone) OR empty($subject) OR empty($message)) {
            # Set a 400 (bad request) response code and exit.
            http_response_code(400);
            echo "Please complete the form and try again.";
            exit;
        }
        
		
		
		/* Format Email Content */
        $content = "Name: $name\n";
        $content .= "Email: $email\n\n";
        $content .= "Phone: $phone\n";
        $content .= "Message:\n$message\n";
        $headers = "From: $name <$email>";
        $success = mail($mail_to, $subject, $content, $headers);
		
		
		/* if emailw as sent, set response, else set error message */
        if ($success) {
            http_response_code(200);
            echo "Thank You! Your message has been sent.";
        } else {
            http_response_code(500);
            echo "Oops! Something went wrong, we couldn't send your message.";
        }

    } else {
		
		/* If everything fails, Its Teachers Fault. */
        http_response_code(403);
        echo "There was a problem with your submission, please try again.";
    }

?>
