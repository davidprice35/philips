<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AttachmentsDelete.aspx.cs" Inherits="competitive_info_AttachmentsEdit" %>

<%@ Register Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI" TagPrefix="asp" %>
<%@ Register Assembly="Syncfusion.EJ.Web, Version=16.3460.0.21, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89" Namespace="Syncfusion.JavaScript.Web" TagPrefix="ej" %>
<%@ Register Assembly="Syncfusion.EJ, Version=16.3460.0.21, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89" Namespace="Syncfusion.JavaScript.Models" TagPrefix="ej" %>


<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>Attachments Delete File</title>

    <!-- Bootstrap -->
    <link href="css/bootstrap.min.css" rel="stylesheet">
	<link href="css/style.css" rel="stylesheet">
	<link href="css/responsive.css" rel="stylesheet">
	<link rel="stylesheet" href="../css/font-awesome.min.css">
	
	
	

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->


     <link href="https://cdn.syncfusion.com/16.1.0.37/js/web/flat-azure/ej.web.all.min.css" rel="stylesheet" />
    <script src='<%= Page.ResolveClientUrl("~/js/ej/jquery-1.11.3.min.js")%>' type="text/javascript"></script>
    <script src='<%= Page.ResolveClientUrl("~/js/ej/jsrender.min.js")%>' type="text/javascript"></script>
    <script src='<%= Page.ResolveClientUrl("~/js/ej/ej.web.all.min.js")%>' type="text/javascript"></script>
    <script src='<%= Page.ResolveClientUrl("~/js/ej/ej.webform.min.js")%>' type="text/javascript"></script>

  </head>
<body>

     <form runat="server">
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
		<div class="main-section">			
			<div class="container">
				<div class="row">
						<div class="top-header">
						<div class="col-sm-12 col-xs-12 col-md-2 col-lg-2">
                             <a href="/">
							<img src="/images/attachmentLogo.png"class="img-responsive">
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
                                        <li><a href="/competitive-info/Attachments">Attachments</a></li>
                                       

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
																<h4 class="media-heading">Hello <%=m_UserName %></h4>
																<p></p>
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
                                                            <%--<asp:LinkButton ID="cmdLogout" CssClass="view_prfl" OnClientClick="Myclick();"  runat="server">Log out <span><i class="fa fa-angle-right" aria-hidden="true"></i></span></asp:LinkButton>--%>
															
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
					<div class="col-lg-2 col-sm-3 col-md-3 left-padding"> 
						<div class="left-sidebar camparision-section">
													
							
						</div>
					</div>
						<div class="col-lg-10 col-sm-9 col-md-9 right-padding competitors-right">
							<div class="rightbar">
                                <ul class="nav nav-tabs">
                                    <li><a href="Competitors.aspx">competitors</a></li>
                                    <li><a href="Clinical.aspx">clinical</a></li>
                               
                                    <li><a  href="Enterprise.aspx">enterprise</a></li>
                                    <li class="active"><a href="Attachments.aspx">attachment Edit</a></li>
                                </ul>

								<div class="tab-content toshiba-content ">
									
								
									
									<div id="menu4" class="tab-pane fade in active">
										<div class="clinical-preview">
											<div class="col-sm-12 col-md-12">
												<!----accordion start---->
                                                <div style="padding-bottom:30px;">

                                                   
                                                
                                                    </div>
                                                                                               

                                                <p><b>You are about to delete. Please click on Confirm Delete.</b> </p>
                                                <p>
                                                    <asp:Button ID="cmdDelete" runat="server" Text="Confirm Delete" OnClick="cmdDelete_Click" />  <asp:Button ID="cmdCancel" runat="server" Text="Cancel" OnClick="cmdCancel_Click" /></p>
                                                <p>
                                                   </p>
                                                
												
                                                                                                    
												<!----accordion end---->
											</div>
                                               
                                           

                                            <style>
                                                .upload
                                                {
                                                    margin-left: 20px;
                                                    margin-top: 20px;
                                                }        

                                                .control
                                                {
                                                   
                                                    margin-left: 15px;
                                                }
                                                .frame {
                                                    width: 500px;
                                                    height: 100px;
                                                    margin-top: 10%;
                                                }

                                                .control {
                                                     padding-top: 43px;
                                                    width: 100%;
                                                    height: 100%;
                                                }
                                            </style>
                                             <div class="frame">
                                                <div class="control">
                                                     
                                                    <div class="posupload">
                                                        
                                                    </div>
                                                </div>
                                            </div>


											
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





	<footer class="footer">
		<div class="container">
			<div class="row">
				<img src="images/footer-logo.png"class="img-responsive">
				<h5><span>Privacy notice  |  Terms of use</span>
				<br>
© Koninklijke Philips N.V., 2004 - 2019. All rights reserved. </h5>
			</div>
		</div>
	</footer>
        <script src="js/bootstrap.min.js"></script>
    



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


            

</body>
     
</html>
