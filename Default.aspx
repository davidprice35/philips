<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>Template</title>

    <!-- Bootstrap -->
    <link href="/css/bootstrap.min.css" rel="stylesheet">
	<link href="/css/style.css" rel="stylesheet">
	<link href="/css/responsive.css" rel="stylesheet">
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">
	<link rel="stylesheet" href="css/jquery.mCustomScrollbar.min.css">
	<link rel="stylesheet" href="css/jquery.mCustomScrollbar.css">

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
  </head>
  <body>
  
       <form id="form1" runat="server">
           
  <div class="top-tabs-link">
	<div class="nav nav-pills">
		<li class="col-sm-2 col-xs-2 width"><a href="#"></a></li>
		<li class="col-sm-2 col-xs-2 width"><a href="/MV-Matrix/">MV MATRIX</a></li>
		<li class="col-sm-2 col-xs-2 width"><a href="#"></a></li>
		<li class="col-sm-2 col-xs-2 width"><a href="#"></a></li>
		<li class="col-sm-2 col-xs-2 width"><a href="/competitive-info/Competitors">COMPETITIVE INFO</a></li>
		<li class="col-sm-2 col-xs-2 width"><a href="#"></a></li>
  
  </div>
  </div>
		<div class="main-section avtar">			
			<div class="container">
				<div class="row">
						<div class="top-header">
						<div class="col-sm-12 col-xs-12 col-md-2 col-lg-2">
                            <a href="../">
							<img src="images/logo.png"class="img-responsive">
                                </a>
						</div>
						
						<div class="col-sm-12 col-md-10 col-lg-10 navbar_div">
							<nav class="navbar navbar-inverse">
								<div class="navbar-header">
									<button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#myNavbar">
										<span class="icon-bar"></span>
										<span class="icon-bar"></span>
										<span class="icon-bar"></span> 
									</button>
									  
								</div>

<div class="collapse navbar-collapse" id="myNavbar">
									<ul class="nav navbar-nav navbar-left">

                                       
                                       


									</ul>
									<ul class="nav navbar-nav icons-right" style="float: right;">
											<li class="user-dropdown ">
											
												<div class="drop-down">
												  <button class="btn btn-primary dropdown-toggle" type="button" data-toggle="dropdown">
												  Hello <%=m_UserName %> <span class=""></span></button>
												  <ul class="dropdown-menu objects">
														<div class="media">
															<div class="media-left">
																
															</div>
															<div class="media-body">
																<h4 class="media-heading">Hello</h4>
																<p>David</p>
															</div>
														</div>
														
														<div class="view_box">
															<a href="" class="view_prfl">View profile <span><i class="fa fa-angle-right" aria-hidden="true"></i></span></a>
                                                            

                                                            <script>

                                                                function Myclick()
                                                                {                                                                   
                                                                    window.location.replace("/Account/Signin?Type=LogOut");
                                                                }

                                                            </script>
                                                            <asp:LinkButton ID="cmdLogout" CssClass="view_prfl" OnClick="cmdLogout_Click" OnClientClick="Myclick();"  runat="server">Log out <span><i class="fa fa-angle-right" aria-hidden="true"></i></span></asp:LinkButton>
															
														</div>
												  </ul>
												</div>
																						
											</li>
											<li class="icons"><a href="#"><i class="fa fa-search" aria-hidden="true"></i></a></li>
										</ul>
									
									 
								</div>
                                
							</nav>
						</div>
					</div>
			
			
			
				<div class="body-section-design">					
					
			</div>
		</div>
	</div>
	</div>
	
	<div class="multivendor-page">
		<div class="container">
			<div class="row">
				<div class="col-sm-12"><h3>Please select the tool you want to access:</h3></div>
				
					<div class="col-sm-6 col-lg-3 col-xs-6 wdth">
						<a href="/MV-Matrix.aspx"class="infomation-txt">
							<h3>Multi-vendor <br>Compatibility<br> Information</h3>
							<span><i class="fa fa-chevron-right" aria-hidden="true"></i></span>
						</a>
					</div>
					<%--<div class="col-sm-6 col-lg-3 col-xs-6 wdth">
						<a href=""class="infomation-txt">
							<h3>Submit Exam <br>for Multi-vendor <br>Compatibility testing</h3>
							<span><i class="fa fa-chevron-right" aria-hidden="true"></i></span>
						</a>
					</div>
					<div class="col-sm-6 col-lg-3 col-xs-6 wdth">
						<a href=""class="infomation-txt">
							<h3>PACS-EMR-OTHER <br>Compatibility <br>Information</h3>
							<span><i class="fa fa-chevron-right" aria-hidden="true"></i></span>
						</a>
					</div>--%>
					<div class="col-sm-6 col-lg-3 col-xs-6 wdth">
						
                            <a href="/competitive-info/Competitors" class="infomation-txt">
							<h3> Competitive <br>Information</h3>
							<span><i class="fa fa-chevron-right" aria-hidden="true"></i></span>
						</a>
					</div>
				
			</div>
		</div>
	</div>



	 <footer class="footer aaff">
		<div class="container">
			<div class="row">
				<img src="images/logo-white.png"class="img-responsive">
				<h5><span>Privacy notice  |  Terms of use</span>
				<br>
© Koninklijke Philips N.V., 2004 - 2019. All rights reserved. </h5>
			</div>
		</div>
	</footer> 

    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>
	
	
	<script>
        $(document).ready(function () {
            $("#checkbox1").is(":checked") ? $(".isp").show() : $(".isp").hide();
            $("#checkbox2").is(":checked") ? $(".modality").show() : $(".modality").hide();
            $("#checkbox3").is(":checked") ? $(".vendor").show() : $(".vendor").hide();
            $("#checkbox4").is(":checked") ? $(".model").show() : $(".model").hide();
            $("#checkbox5").is(":checked") ? $(".version").show() : $(".version").hide();
            $("#checkbox6").is(":checked") ? $(".detector").show() : $(".detector").hide();
            $("#checkbox7").is(":checked") ? $(".domain").show() : $(".domain").hide();
            $("#checkbox8").is(":checked") ? $(".module").show() : $(".module").hide();
            $("#checkbox9").is(":checked") ? $(".subApp").show() : $(".subApp").hide();
            $("#checkbox10").is(":checked") ? $(".dataSetDef").show() : $(".dataSetDef").hide();
            $("#checkbox11").is(":checked") ? $(".g").parent().show() : $(".g").parent().hide();
            $("#checkbox12").is(":checked") ? $(".yellow").parent().show() : $(".yellow").parent().hide();
            $("#checkbox13").is(":checked") ? $(".red").parent().show() : $(".red").parent().hide();
            $("#checkbox14").is(":checked") ? $(".orange").parent().show() : $(".orange").parent().hide();
        })

        $("#checkbox1").change(function () {
            this.checked ? $(".isp").show() : $(".isp").hide();
        });
        $("#checkbox2").change(function () {
            this.checked ? $(".modality").show() : $(".modality").hide();
        });
        $("#checkbox3").change(function () {
            this.checked ? $(".vendor").show() : $(".vendor").hide();
        });
        $("#checkbox4").change(function () {
            this.checked ? $(".model").show() : $(".model").hide();
        });
        $("#checkbox5").change(function () {
            this.checked ? $(".version").show() : $(".version").hide();
        });
        $("#checkbox6").change(function () {
            this.checked ? $(".detector").show() : $(".detector").hide();
        });
        $("#checkbox7").change(function () {
            this.checked ? $(".domain").show() : $(".domain").hide();
        });
        $("#checkbox8").change(function () {
            this.checked ? $(".module").show() : $(".module").hide();
        });
        $("#checkbox9").change(function () {
            this.checked ? $(".subApp").show() : $(".subApp").hide();
        });
        $("#checkbox10").change(function () {
            this.checked ? $(".dataSetDef").show() : $(".dataSetDef").hide();
        });
        $("#checkbox11").change(function () {
            this.checked ? $(".g").parent().show() : $(".g").parent().hide();
        });
        $("#checkbox12").change(function () {
            this.checked ? $(".yellow").parent().show() : $(".yellow").parent().hide();
        });
        $("#checkbox13").change(function () {
            this.checked ? $(".red").parent().show() : $(".red").parent().hide();
        });
        $("#checkbox14").change(function () {
            this.checked ? $(".orange").parent().show() : $(".orange").parent().hide();
        });
    </script>
	
	<script>
		$(document).on('show','.accordion', function (e) {
			 //$('.accordion-heading i').toggleClass(' ');
			 $(e.target).prev('.accordion-heading').addClass('accordion-opened');
		});
		
		$(document).on('hide','.accordion', function (e) {
			$(this).find('.accordion-heading').not($(e.target)).removeClass('accordion-opened');
			//$('.accordion-heading i').toggleClass('fa-chevron-right fa-chevron-down');
		});
	</script>
	
	<script>
	
		
		$('.close').on('click', function (e) {
    $('.footer-fixed').toggleClass("close-footer");
});
		
		
		
$('.multi-vendor-title').on('click', function (e) {
			$('.agree-btn').toggleClass("visible-btn");
		});
		
		
		
		
		$('#Agree-btn li').on('click', function(){
    $('#Agree-btn li.open').removeClass('open');
    $(this).addClass('open');
});
		
		
	</script>
	<script>
		(function($){
			$(window).on("load",function(){
				
				$("a[rel='load-content']").click(function(e){
					e.preventDefault();
					var url=$(this).attr("href");
					$.get(url,function(data){
						$(".content .mCSB_container").append(data); //load new content inside .mCSB_container
						//scroll-to appended content 
						$(".content").mCustomScrollbar("scrollTo","h2:last");
					});
				});
				
				$(".content").delegate("a[href='top']","click",function(e){
					e.preventDefault();
					$(".content").mCustomScrollbar("scrollTo",$(this).attr("href"));
				});
				
			});
		})(jQuery);
	</script>
	
	
	
	<script src="js/jquery.mCustomScrollbar.concat.min.js"></script>
	<script src="js/jquery.mCustomScrollbar.js"></script>
	<script>
		(function($){
			$(window).on("load",function(){
				
				$("#content-1").mCustomScrollbar({
					autoHideScrollbar:true,
					theme:"rounded"
				});
				
			});
		})(jQuery);
	</script>
	</form>

  </body>
</html>