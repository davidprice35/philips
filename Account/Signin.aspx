<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Signin.aspx.cs" Inherits="Account_Signin" %>

<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>Template</title>

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
					<div class="col-sm-12"><h2 class="text-top-heading">Sign in</h2>
			
			
				
			</div>
		</div>
	</div>
	</div>
	
	
	<div class="phillips-form-section">
		<div class="container">
			<div class="row">
			<div class="col-sm-12">
				<div class="alert alert-info fade in">					
					 <span><i class="fa fa-lock" aria-hidden="true"></i></span> Please sign in to view content.
				</div>
			</div>
			
			<div class="form-div">
			
				<div class="col-sm-12"><h3>Please select how you want to access the site:</h3></div>
				
				
					<div class="col-sm-6 border-right">
						
						   <h2>Philips employee</h2>
						   <div class="hide-section-click">
						     <button class="btn-primary" type="button" data-toggle="collapse" data-target="#collapseExample" aria-expanded="false" aria-controls="collapseExample">Sign in with Philips account</button>
						   </div>
							<div class="collapse" id="collapseExample">
							  <div class="well-1">
								
									<div class="row">
										<div class="col-sm-12 form-group">
                                            <asp:TextBox ID="txtUser" CssClass="form-control" runat="server" placeholder="Email address"></asp:TextBox>
											<%--<input class="form-control" type="email" placeholder="Email address" value="TestUser1@me.com">--%>
										</div>
										<div class="col-sm-12 form-group">
                                            <asp:TextBox ID="txtPassword" CssClass="form-control" type="password" runat="server" placeholder="Password"></asp:TextBox>

											<%--<input class="form-control" type="password" placeholder="Password" value="testuser">--%>
										</div>
										<div class="col-sm-7 form-group">
											<a href="" class="forgot-line">Forgot you password?</a>
										</div>
										<div class="col-sm-5 form-group">

                                            <asp:Button ID="cmdSubmitPhilips" CssClass="btn-primary submit" OnClick="cmdSubmitPhilips_Click" 
                                                
                                                style="
    background: #178bc6;
    border: 1px solid #178bc6;
    border-radius: 3px;
    padding: 5px 15px;
    font-size: 14px;
    font-weight: 600;
    font-family: 'CentraleSans';"


                                                runat="server" Text="Sign In" />
											
										</div>
										<div class="col-sm-6 form-group">
											<h5>Request access</h5>
											<a href="" class="forgot-line">Create account <span><i class="fa fa-angle-right" aria-hidden="true"></i></span></a>
										</div>
									</div>
								
							  </div>
							</div>
						</div>
					   <div class="col-sm-6 border-left">
					   <%--<h2>External Non Philips Employee</h2>
						<!-- <button class="btn-primary" type="button">Sign in with Philips account</button> -->
						<div class="hide-section-click1">
						     <button class="btn-primary" type="button" data-toggle="collapse" data-target="#ExternalPhilips" aria-expanded="false" aria-controls="ExternalPhilips">Sign in with Philips account</button>
						</div>--%>
						<div class="collapse" id="ExternalPhilips">
							  <div class="well-1">
								
									<div class="row">
										<div class="col-sm-12 form-group">
											<input class="form-control" type="email" placeholder="Email address" value="testuser@me.com">
										</div>
										<div class="col-sm-12 form-group">
											<input class="form-control" type="password" placeholder="Password" value="tester">
										</div>
										<div class="col-sm-7 form-group">
											<a href="" class="forgot-line">Forgot you password?</a>
										</div>
										<div class="col-sm-5 form-group">
											
                                              <asp:Button ID="Button1" CssClass="btn-primary submit" OnClick="cmdSubmitPhilips_Click" 
                                                
                                                style="
    background: #178bc6;
    border: 1px solid #178bc6;
    border-radius: 3px;
    padding: 5px 15px;
    font-size: 14px;
    font-weight: 600;
    font-family: 'CentraleSans';"


                                                runat="server" Text="Sign In" />

										</div>
										<%--<div class="col-sm-6 form-group">
											<h5>Request access</h5>
											<a href="" class="forgot-line">Create account <span><i class="fa fa-angle-right" aria-hidden="true"></i></span></a>
										</div>--%>
									</div>
								
							  </div>
							</div>
					</div>
				</div>
			</div>
		</div>
	</div>
	</form>
	<%--<div class="request-section">
		<div class="container">
			<div class="row">
			<div class="col-sm-12">
				<h3>Request access</h3>
				<h5>Register as a Non Philips Employee</h5>
				<button class="btn-primary">create account</button>
			</div>
			</div>
		</div>
	</div>--%>
	
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