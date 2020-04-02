<%@ Page Title="Log in" Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Account_Login" Async="true" %>

<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>


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
							<img src="images/logo.png"class="img-responsive">
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
									<ul class="nav navbar-nav">
										<li class="dropdown  submenubar"><a href="#" class="dropdown-toggle" data-toggle="dropdown" aria-expanded="true">Admin</a>
											<ul class="dropdown-menu">
												<li><a href="#">User permissions</a></li> 
												<li><a href="#">Reports</a></li>
												<li><a href="#">Case study admin</a></li> 
												<li><a href="#">Data add/edits admin</a></li>
												<li><a href="#">Feedback admin</a></li> 										
											</ul>
										
										</li>
										<li><a href="#">Submit a case study</a></li>
										<li><a href="#">Send feedback</a></li> 
										<li><a href="#">Track case study submission</a></li> 
										<li><a href="#">Favorites</a></li> 
										<li><a href="#">User guide</a></li>
									
										
										<ul class="nav navbar-nav icons-right">
											<li class="user-dropdown icons">
											
												<div class="drop-down">
												  <button class="btn btn-primary dropdown-toggle" type="button" data-toggle="dropdown">
												  Hello <span class=""><i class="fa fa-user" aria-hidden="true"></i></span></button>
												  <ul class="dropdown-menu objects">
													<div class="phillips-acc">
														<h5>Login with Philips account</h5>
														
														<div class="form-group">
														<input class="form-control"type="email"placeholder="User name">
														</div>
														
														<div class="form-group">
														<input class="form-control"type="password"placeholder="Password">
														</div>
														
														<div class="form-group checkbox checkbox-primary">
															<input id="checkbox1" type="checkbox" >
															<label for="checkbox1">
																Remember me
															</label>
														</div>
														<div class="form-group"><button class="btn-primary send">Login</button></div>
													</div>
													<div class="bottom_div">
														<p>Forgot username or password? Request access for this site</p>
													</div>
												  </ul>
												</div>
																						
											</li>
											<li class="icons"><a href="#"><i class="fa fa-search" aria-hidden="true"></i></a></li>
										</ul>
									</ul>
									
									 
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
				
				
					<div class="col-sm-6">
						<h2>Philips employee</h2>
						<button class="btn-primary">Sign in with Philips account</button>
					</div>
					<div class="col-sm-6 border-left">
						<h2>External Non Philips Employee</h2>
						<form class="form">
							<div class="row">
								<div class="col-sm-12 form-group">
									<input class="form-control"type="email"placeholder="Email address...">
								</div>
								<div class="col-sm-12 form-group">
									<input class="form-control"type="password"placeholder="Password...">
								</div>
								<div class="col-sm-7 form-group">
									<a href=""class="forgot-line">Forgot you password?</a>
								</div>
								<div class="col-sm-5 form-group">
									<button class="btn-primary submit">submit</button>
								</div>
								<div class="col-sm-6 form-group">
									<h5>Request access</h5>
									<a href=""class="forgot-line">Create account <span><i class="fa fa-angle-right" aria-hidden="true"></i></span></a>
								</div>
							</div>
						</form>
					</div>
				</div>
			</div>
		</div>
	</div>
	
	<div class="request-section">
		<div class="container">
			<div class="row">
			<div class="col-sm-12">
				<h3>Request access</h3>
				<h5>Register as a Non Philips Employee</h5>
				<button class="btn-primary">create account</button>
			</div>
			</div>
		</div>
	</div>
	
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
    <script src="j../s/bootstrap.min.js"></script>
	<script src="../js/custom.js"></script>













<div class="form-horizontal">
                    <h4>Use a local account to log in.</h4>
                    <hr />
                    <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                        <p class="text-danger">
                            <asp:Literal runat="server" ID="FailureText" />
                        </p>
                    </asp:PlaceHolder>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="UserName" CssClass="col-md-2 control-label">User name</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="UserName" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="UserName"
                                CssClass="text-danger" ErrorMessage="The user name field is required." />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="Password" CssClass="col-md-2 control-label">Password</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Password" CssClass="text-danger" ErrorMessage="The password field is required." />
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <div class="checkbox">
                                <asp:CheckBox runat="server" ID="RememberMe" />
                                <asp:Label runat="server" AssociatedControlID="RememberMe">Remember me?</asp:Label>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Button runat="server" OnClick="LogIn" Text="Log in" CssClass="btn btn-default" />
                        </div>
                    </div>
                </div>
                <p>
                    <asp:HyperLink runat="server" ID="RegisterHyperLink" ViewStateMode="Disabled">Register</asp:HyperLink>
                    if you don't have a local account.
                </p>
            </section>
        </div>











      </form>

	
  </body>
</html>

