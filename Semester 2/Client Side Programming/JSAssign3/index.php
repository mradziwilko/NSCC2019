<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
	<head>
		<meta charset="utf-8">
		<title>JQuerry Assignment #3</title>
	</head>
	<body>
		<div class="main" id="frmContent">
		</div>
	</body>
	<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>	
	<script>
		$( document ).ready(function() {
			
		$("<div></div>").html("<form action=\"#\" method=\"post\" enctype=\"application/x-www-form-urlencoded\" id=\"frmContact\"></form>").appendTo("#frmContent");
			
			
		$.ajax({
			type: "GET",
			url: "form.xml",
			dataType: "xml",
			success: function(xml){
			
				
					$(xml).find('Field').each(function(){
				
											
						
						var strLbl = $(this).find('Label').text();
						var strDT = $(this).find('DataType').text().toLowerCase();
						var strFN = $(this).find('FieldName').text().toLowerCase();
						var strIVal = $(this).find('InitialValue').text();
						
						
						$("<label for=\""+strFN+"\">"+strLbl+"</label>").html(strLbl).appendTo("#frmContact");
					
						if(strDT == "textarea") {
							$("<p></p>").html("<"+strDT+" name=\""+strFN+"\" placeholder=\""+strIVal+"\"  cols=\"50\" rows=\"10\"></"+strDT+"><br>").appendTo("#frmContact");
						}else if(strDT == "submit") {
							$("<p></p>").html("<input type=\""+strDT+"\" name=\""+strFN+"\" value=\""+strIVal+"\"  ><br>").appendTo("#frmContact");
						}else{
							$("<p></p>").html("<"+strDT+" type=\"text\" name=\""+strFN+"\" placeholder=\""+strIVal+"\"   ><br>").appendTo("#frmContact");
						}

					});
				},
					error: function() {
					alert("An error occurred while processing XML file.");
		  		}
				
				
				
				
			});
			
			
			
		});	
	</script>
</html>
