<!doctype html>
<html>
<head>
	<meta charset="utf-8">
	<title>JQuerry Assignment #2</title>	
	<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
	<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.0.8/css/all.css">
	<link rel="stylesheet" href="css/bootstrap-select-country.min.css" />
</head>

<body>
	<article class="card-body mx-auto" style="max-width: 400px;">   
	<h4 class="card-title mt-3 text-center">Create Account</h4>
	
	<div class="form-group input-group">
		<div class="input-group-prepend">
		    <span class="input-group-text" id="titleIco"> <i class="fa fa-feather-alt"></i> </span>
		 </div>
		
		<select class="form-control selectpicker" name="title" id="title">
			<option value="blankName" selected>Please Select</option>
			<option value="mr">Mr.</option>
			<option value="mrs">Mrs.</option>
			<option value="ms">Ms.</option>
			<option value="miss">Miss.</option>
		</select>
    </div> 
	<div class="form-group input-group">
		<div class="input-group-prepend">
		    <span class="input-group-text" id="nameIco"> <i class="fa fa-user"></i> </span>
		 </div>
        <input name="name" id="name" data-toggle="tooltip" data-placement="top"  class="form-control" placeholder="Full name" type="text">
    </div> 
    <div class="form-group input-group">
    	<div class="input-group-prepend">
		    <span class="input-group-text" id="emlIco"> <i class="fa fa-envelope"></i> </span>
		 </div>
        <input name="email" id="email" class="form-control" placeholder="Email address" type="email">
    </div> 
    <div class="form-group input-group">
    	<div class="input-group-prepend">
		    <span class="input-group-text" id="telIco"> <i class="fa fa-phone"></i> </span>
		</div>
        <input name="area" id="area" class="form-control" placeholder="***" type="tel" maxlength="3" style="max-width: 75px; text-align: center">
    	<input name="number" id="number" class="form-control" placeholder="Phone number" type="text">
    </div> 
    <div class="form-group input-group">
    	<div class="input-group-prepend">
		    <span class="input-group-text" id="cntIco"> <i class="fa fa-building"></i> </span>
		</div>
		<select class="form-control selectpicker countrypicker" id="country" id="country" data-flag="true"></select>

	</div> 
    <div class="form-group input-group">    	 
		<div class="d-block w-100">
        <div class="progress">
            <div class="progress-bar bg-danger" role="progressbar" id="passLoad"  aria-valuenow="0" aria-valuemin="0" aria-valuemax="100" style="width: 0%;"></div>
        </div>
    </div>
    </div>
    <div class="form-group input-group">
    	<div class="input-group-prepend">
		    <span class="input-group-text" id="passIco"> <i class="fa fa-lock"></i> </span>
		</div>
        <input class="form-control" name="password" id="password" placeholder="Create password" onKeyUp="CheckPass()" type="password">
    </div> 
    <div class="form-group input-group">
    	<div class="input-group-prepend">
		    <span class="input-group-text" id="pass2Ico"> <i class="fa fa-lock"></i> </span>
		</div>
        <input class="form-control" name="password2" id="password2" placeholder="Repeat password" type="password">
    </div>    
    <div class="form-group">
        <button type="submit"  class="btn btn-primary btn-block" onClick="formOutput()" > Create Account  </button>
    </div>
	<div class="alert alert-danger" role="alert" id="errDiv" style="display: none; "></div> 
	<div class="alert alert-success" role="alert"id="sucDiv" style="display: none; "></div>
</article>


	

	<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>	
	<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
	<script src="js/bootstrap-select-country.min.js"></script>
	<script src="https://kit.fontawesome.com/d94f2e67b9.js" crossorigin="anonymous"></script>
 
	
	
	
	<script>
		
		// Cear Borders of Form, to prevent errors being false.
		function setBorderNone() { 
			
			document.getElementById("title").style.border="1px solid #ced4da"; 
			document.getElementById("name").style.border="1px solid #ced4da"; 
			document.getElementById("email").style.border="1px solid #ced4da"; 
			document.getElementById("area").style.border="1px solid #ced4da"; 
			document.getElementById("country").style.border="1px solid #ced4da"; 
			document.getElementById("number").style.border="1px solid #ced4da"; 
			document.getElementById("password").style.border="1px solid #ced4da"; 
			document.getElementById("password2").style.border="1px solid #ced4da"; 
			document.getElementById("titleIco").style.border="1px solid #ced4da"; 
			document.getElementById("nameIco").style.border="1px solid #ced4da"; 
			document.getElementById("emlIco").style.border="1px solid #ced4da"; 
			document.getElementById("telIco").style.border="1px solid #ced4da"; 
			document.getElementById("passIco").style.border="1px solid #ced4da"; 
			document.getElementById("pass2Ico").style.border="1px solid #ced4da"; 
			
		}

		// ** Section:  Show/Hide Error and Success Div's **//
		function hideError() {
			
			var errDiv = document.getElementById('errDiv');
				errDiv.innerHTML = '';
				errDiv.style.display="none";
				errDiv.style.visibility="hidden";
		}		
		
		function showError() {
				var errDiv = document.getElementById('errDiv');
			
				errDiv.style.display="block";
				errDiv.style.visibility="visible";
		}
		
		function hideSucc() {
			
			var sucDiv = document.getElementById('sucDiv');
				sucDiv.innerHTML = '';
				sucDiv.style.display="none";
				sucDiv.style.visibility="hidden";
		}		
		
		function showSucc() {
			var sucDiv = document.getElementById('sucDiv');
			
				sucDiv.style.display="block";
				sucDiv.style.visibility="visible";
		}
		//** End Section **//
		
		
		
		// ** Section: Validate Email Format, Phone Format, Password Complexity, and Password Match 
		function ValidateEmail() {
			
			var idEml = document.getElementById("email").value;
			
			 if (/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/.test(idEml)){
				return (true)
			  }else{
				return (false)
			}
		}	
		
		function ValidatePhone(){
			var idAre = document.getElementById("area").value;
			var idNum = document.getElementById("number").value;
			
			var fullNum = idAre + "-" + idNum;
  			var phoneno = /^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$/;
			
			if(fullNum.match(phoneno)){
			   return true;
			   } else {
			   return false;
			}
		}	
		
		function ValidatePassword() {
			var idPW = document.getElementById("password").value;
			var idPW2 = document.getElementById("password2").value;
			
			if(idPW == idPW2) {
				return true;
			}else{
				return false;
			}
		}
		
		function passStr() {
			    var strongRegex = new RegExp("^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#\$%\^&\*])(?=.{8,})");
                var mediumRegex = new RegExp("^(((?=.*[a-z])(?=.*[A-Z]))|((?=.*[a-z])(?=.*[0-9]))|((?=.*[A-Z])(?=.*[0-9])))(?=.{6,})");
				var idPW = document.getElementById("password").value;
                if(strongRegex.test(idPW)) {
					return "great";
				} else if(mediumRegex.test(idPW)) {
                	return "normal";
				} else {
                	return "error";
                }
		}		
		
		// ** End Section ** //
		
		
		// ** Section: Set Error for Design, Red border is Showing error ** //
		function setTitleError() {
			var iconTitle = document.getElementById('titleIco');
			var feildTitle = document.getElementById('title');
				iconTitle.style.border="1px solid #FF0000"; 
				feildTitle.style.border="1px solid #FF0000"; 
			
		}
		
		function setNameError() {
			var iconName = document.getElementById('nameIco');
			var feildName = document.getElementById('name');
				iconName.style.border="1px solid #FF0000"; 
				feildName.style.border="1px solid #FF0000"; 
			
		}
		
		function setEmailError() {
			var iconEmail = document.getElementById('emlIco');
			var feildEmail = document.getElementById('email');
				iconEmail.style.border="1px solid #FF0000"; 
				feildEmail.style.border="1px solid #FF0000"; 
			
		}
		
		function setPhoneError() {
			var iconPhone = document.getElementById('telIco');
			var feildPhone = document.getElementById('number');
			var feildArea = document.getElementById('area');
				iconPhone.style.border="1px solid #FF0000"; 
				feildPhone.style.border="1px solid #FF0000"; 
				feildArea.style.border="1px solid #FF0000"; 
			
		}
		
		function setPass1Error() {
			var iconPass1 = document.getElementById('passIco');
			var feildPass1 = document.getElementById('password');
				iconPass1.style.border="1px solid #FF0000"; 
				feildPass1.style.border="1px solid #FF0000"; 
			
		}
		
		function setPass2Error() {
			var iconPass2 = document.getElementById('pass2Ico');
			var feildPass2 = document.getElementById('password2');
			
				iconPass2.style.border="1px solid #FF0000"; 
				feildPass2.style.border="1px solid #FF0000";  
		}
		
		// ** End Section ** //
		
		function CheckPass() {			
			
			if(passStr() == "error") {
				passLoad.style.width="5%"; 
				passLoad.classList.remove("bg-success");
				passLoad.classList.remove("bg-warning");
				passLoad.classList.add("bg-danger");
				 
				
			}
			if(passStr() == "normal") {
				passLoad.style.width="50%"; 
				passLoad.style.backgroundColor=" background-color: rgb(255, 255, 0);"; 
				passLoad.classList.remove("bg-danger");
				passLoad.classList.remove("bg-success");
				passLoad.classList.add("bg-warning");
				
			}
			if(passStr() == "great") {
				passLoad.style.width="100%"; 
				passLoad.style.backgroundColor=" background-color: rgb(0, 255, 0);"; 
				passLoad.classList.remove("bg-danger");
				passLoad.classList.remove("bg-warning");
				passLoad.classList.add("bg-success");
			}
		}
		
		
		// ** Section: Main Function to check if Form is Valid, if so Send to sendMail function if Valid. ** //
		function formOutput() {
			setBorderNone();
			hideError();
			var varTitle = document.getElementById("title");
			var strTitle = varTitle.options[varTitle.selectedIndex].value;
			var idNme = document.getElementById("name").value;
			var idEml = document.getElementById("email").value;
			var idAre = document.getElementById("area").value;
			var idNum = document.getElementById("number").value;
			var varCountry = document.getElementById("country");
			var strCountry = varCountry.options[varCountry.selectedIndex].value;
			var idPW = document.getElementById("password").value;
			var idPW2 = document.getElementById("password2").value;
			var error = false;
			var errDiv = document.getElementById('errDiv');
			var passLoad = document.getElementById("passLoad");
			passLoad.style.width="0%"; 
			passLoad.style.backgroundColor=" background-color: rgb(255, 225, 255);"; 
			
			if(strTitle == "blankName") {
				setTitleError();
				showError();
				errDiv.innerHTML += 'Error: Title Not Selected.</br>';

				error = true;
			}
			if(idNme.isNaN || idNme == "" ) {
				setNameError();
				showError();
				errDiv.innerHTML += 'Error: Name Feild Empty.</br>';
				error = true;
			}
			if(idEml.isNaN || idEml == "" ) {
				setEmailError();
				showError();
				errDiv.innerHTML += 'Error: Email Feild Empty.</br>';
				error = true;
			}
			if(idAre.isNaN || idAre == "" ) { 
				setPhoneError();
				showError();
				errDiv.innerHTML += 'Error: Area Code Feild Empty.</br>';
				error = true;
			}
			if(idNum.isNaN || idNum == "" ) {
				setPhoneError();
				showError();
				errDiv.innerHTML += 'Error: Number Feild Empty.</br>';
				error = true;
			}
			if(idPW.isNaN || idPW == "" ) {
				setPass1Error();
				showError();
				errDiv.innerHTML += 'Error:  Password Empty.</br>';
				error = true;
			}
			if(idPW2.isNaN || idPW2 == "" ) {
				setPass2Error();
				showError();
				errDiv.innerHTML += 'Error: Repeat Password Empty.</br>';
				error = true;
			}
			
			if(ValidateEmail() == false) {
				
				document.getElementById("email").style.border="1px solid #FF0000"; 
				showError();
				errDiv.innerHTML += 'Error: Invalid E-Mail.</br>';
				error = true;
			}
			if(ValidatePhone() == false) {
				
				
				setPhoneError();
				showError();
				errDiv.innerHTML += 'Error: Invalid Phone Number.</br>';
				error = true;
			}
			
			if(passStr() == "error") {
				setPass1Error();
				setPass2Error();
				showError();
				errDiv.innerHTML += 'Error: Password to Weak.</br>';
				error = true;
			}
			
			
			if(ValidatePassword() == false) {
				
				setPass1Error();
				setPass2Error();
				showError();
				errDiv.innerHTML += "Error: Password don't match.</br>";
				error = true; 
				
			}
			
			if(error == true) {
				
			}else{
				sendMail();
			}
			   
			
	}
		
		function sendMail() {
			
			hideSucc();
			var errDiv = document.getElementById('errDiv');
			var sucDiv = document.getElementById('sucDiv');
			var varTitle = document.getElementById("title");
			var strNme = document.getElementById("name").value;
			var strEml = document.getElementById("email").value;
			var strAre = document.getElementById("area").value;
			var strNum = document.getElementById("number").value;
			var varCountry = document.getElementById("country");
			var strPW = document.getElementById("password").value;

			
			var strCountry = varCountry.options[varCountry.selectedIndex].value;
			var strTitle = varTitle.options[varTitle.selectedIndex].value;
			sucDiv.innerHTML = '';
			
			
			
			
			$.ajax({
            	type: "POST",
				url: "send.php",
				data: {
					title: strTitle,
					name: strNme,
					email: strEml,
					area: strAre,
					number: strNum,
					country: strCountry,
					password: strPW
				},
				success: function( result ) {
				  loginCheckResponse(result);
			  }
			});
		}
	
		function loginCheckResponse(response){
		
		if (response == 1) {

					hideError();
					showSucc();
					sucDiv.innerHTML += 'Success: Email has been sent.</br>';
					clearForm();
		} else {
					hideSucc();
					showError();
					errDiv.innerHTML += 'Error: Something went wrong, please contact the Administrator. ';
		}
	

		}
		
		// ** End Section ** //
		
		// ** Clear Form Function ** //
		function clearForm() {
			document.getElementById("title").selectedIndex = "0";
			document.getElementById("country").selectedIndex = "0";
			document.getElementById("name").value = "";
			document.getElementById("email").value = "";
			document.getElementById("area").value = "";
			document.getElementById("number").value = "";
			document.getElementById("password").value = "";
			document.getElementById("password2").value = "";
			
			setBorderNone();
		}
	
		// ** End Section ** //
	</script>
</body>
</html>