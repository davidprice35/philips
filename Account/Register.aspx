<%@ Page Title="Register" Language="C#"  AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Account_Register" %>


<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>Request Access</title>

    <!-- Bootstrap -->
    <link href="../css/bootstrap.min.css" rel="stylesheet">
	<link href="../css/style.css" rel="stylesheet">
	<link href="../css/responsive.css" rel="stylesheet">
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
  </head>
  <body>

      <form id="form1" runat="server">

		<div class="main-section phillips-matrix">			
			<div class="container">
				<div class="row">
					<div class="top-header">
						<div class="col-sm-12 col-xs-12 col-md-2 col-lg-2">
							<img src="../images/logo.png"class="img-responsive">
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
									
									
									
									 
								</div>
								
							</nav>
						</div>
					</div>
					<div class="col-sm-12"><h2 class="text-top-heading">Request Access</h2>
			
			
				
			</div>
		</div>
	</div>
	</div>
	
	
	<div class="phillips-form-section">
		<div class="container">
			<div class="row">
			<div class="col-sm-12">
				<div class="alert alert-info fade in">					
					 <span><i class="fa fa-lock" aria-hidden="true"></i></span> Please fill in the form below to request access .
				</div>
			</div>
			
			<div class="form-div">
			
				<%--<div class="col-sm-12"><h3>Please select how you want to access the site:</h3></div>--%>
				
				
					<div class="col-sm-6 border-right">
						
						 <%--  <h2>Philips employee</h2>
						   <div class="hide-section-click">
						     <button class="btn-primary" type="button" data-toggle="collapse" data-target="#collapseExample" aria-expanded="false" aria-controls="collapseExample">Sign in with Philips account</button>
						   </div>--%>
							<div class="collapse11" id="collapseExample111">
							  <div class="well-1">
								
									<div class="row">
										<div class="col-sm-12 form-group">
                                            <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server" placeholder="Email address"></asp:TextBox>											
										</div>
										<div class="col-sm-12 form-group">
                                            <asp:TextBox ID="txtName" CssClass="form-control" runat="server" placeholder="Name"></asp:TextBox>											
										</div>
										<div class="col-sm-7 form-group">	
                                            <asp:Label ID="lblFeedback" runat="server" Text=""></asp:Label>
										</div>
										<div class="col-sm-5 form-group">

                                            <asp:Button ID="cmdRequest" CssClass="btn-primary submit"  OnClick="cmdRequest_Click"
                                                
                                                style="
    background: #178bc6;
    border: 1px solid #178bc6;
    border-radius: 3px;
    padding: 5px 15px;
    font-size: 14px;
    font-weight: 600;
    font-family: 'CentraleSans';"


                                                runat="server" Text="Request Access" />
											
                                            



										</div>
										
									</div>
								
							  </div>
							</div>
						</div>
					  
					</div>
				</div>
			</div>
		</div>
	
	</form>
	
	
	<footer class="footer phillips">
		<div class="container">
			<div class="row">
				<img src="../images/logo-white.png"class="img-responsive">
				<h5><span>Privacy notice  |  Terms of use</span>
				<br>
© Koninklijke Philips N.V., 2004 - 2019. All rights reserved. </h5>
			</div>
		</div>
	</footer>

    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="../js/bootstrap.min.js"></script>
	

	
	<script>
	
	  $('.hide-section-click button').on('click', function (e) {
		 $('.hide-section-click').toggleClass("hidden");
	  });
	  $('.hide-section-click1 button').on('click', function (e) {
		 $('.hide-section-click1').toggleClass("hidden");
	  });
	
	</script>
	
  </body>
</html>
