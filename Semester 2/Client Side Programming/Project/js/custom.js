

var video = document.getElementById("myVideo");		
		function myFunction(vidVar) {			
			if(vidVar == "play") {
				video.play();
			} else {
				video.pause();
			}
		}

$('#product2').on('show.bs.modal', function () {
	$(this).find('.modal-body').css({
    	width:'auto', //probably not needed
    	height:'auto', //probably not needed 
        'max-height':'100%'
	});
});
	
		
$('.carousel').carousel({ 
	interval: false
}); 

// Part of the Products for Images
$(document).ready(function() {
	$("button").each(function(index) {
		var image = $(this).data("image");
		var image2 = $(this).data("image2");	  
		$(this).find(".modal-image").attr("src", $(this).data("image"));
	});
   	$(this).find(".modal-image2").attr("src", $(this).data("image"));
});

// Modal for Products, Replaces content from data-* in link to proper sections.
$("#products").on("show.bs.modal", function(event) {
	var button = $(event.relatedTarget);
	var modal = $(this);
	modal.find(".modal-title").text(button.data("title"));    
	modal.find(".modal-img1").attr("src", button.data("img1"));
	modal.find(".modal-img2").attr("src", button.data("img2"));
	modal.find(".modal-img3").attr("src", button.data("img3"));
	modal.find(".modal-img4").attr("src", button.data("img4"));	  	  
	modal.find(".modal-thumb1").attr("src", button.data("thumb1"));
	modal.find(".modal-thumb2").attr("src", button.data("thumb2"));
	modal.find(".modal-thumb3").attr("src", button.data("thumb3"));
	modal.find(".modal-thumb4").attr("src", button.data("thumb4"));	  
	modal.find(".modal-material").text(button.data("mat"));   
	modal.find(".modal-dimentions").text(button.data("dim"));   
	modal.find(".modal-price").text(button.data("price")); 
	modal.find(".modal-description").html(button.data("info")); 
});


$(document).ready(function() { 
  
  $(".fancybox-single").fancybox({    
	  afterShow: function() {
      	this.content.find('video').trigger('play')
      	this.content.find('video').on('ended', function() {
        $.fancybox.close();
      	});
	  }      
  });
});

(function ($) {
	'use strict';
	
    var form = $('.contact-form'), message = $('.contact__msg'), form_data;

    // Success function
    function done_func(response) {
        message.fadeIn().removeClass('alert-danger').addClass('alert-success');
        message.text(response);
        setTimeout(function () {
            message.fadeOut();
        }, 2000);
        form.find('input:not([type="submit"]), textarea').val('');
    }

    // fail function
    function fail_func(data) {
        message.fadeIn().removeClass('alert-success').addClass('alert-success');
        message.text(data.responseText);
        setTimeout(function () {
            message.fadeOut();
        }, 2000);
    }
    
    form.submit(function (e) {
        e.preventDefault();
        form_data = $(this).serialize();
        $.ajax({
            type: 'POST',
            url: form.attr('action'),
            data: form_data
        })
        .done(done_func)
        .fail(fail_func);
    });
    
})(jQuery);

