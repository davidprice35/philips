<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Attachments.aspx.cs" Inherits="competitive_info_Attachments" %>

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
    <title>Attachments</title>

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


    <link href="https://cdn.syncfusion.com/16.1.0.24/js/web/flat-azure/ej.web.all.min.css" rel="stylesheet" />
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
        <li class="col-sm-2 col-xs-2 width"><a href="/competitive-info/Competitors">COMPETITIVE INFO</a></li>
		<li class="col-sm-2 col-xs-2 width"><a href="#"></a></li>
        <li class="col-sm-2 col-xs-2 width"><a href="#"></a></li>
		
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
                                        <li><a href="/competitive-info/Attachments.aspx">Attachments</a></li> 
                                        <% if (m_UserType == "Super Admin")
                                            {%>
                                        <li><a href="/competitive-info/AttachmentsEdit.aspx">Edit</a></li>
                                        <li><a href="/competitive-info/AttachmentsPendingUpdates.aspx">Approve</a></li>

                                        <%} %>
                                      
                                       

									</ul>
									<ul class="nav navbar-nav icons-right" style="float: right;">
                                        <li class="icons"><a href="<%= Helper.GetUserGuide() %>" target="_blank" >User Guide</a></li>
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
															<%--<a href="" class="view_prfl">View profile <span><i class="fa fa-angle-right" aria-hidden="true"></i></span></a>--%>
                                                            

                                                            <script>

                                                                function Myclick() {
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
						<div class="col-lg-12 col-md-12 col-sm-9 right-padding">
							<div class="rightbar">
                                <ul class="nav nav-tabs">
                                    <li><a href="Competitors.aspx">competitors</a></li>
                                    <li><a href="Clinical.aspx">clinical</a></li>
                                    <%--<li><a href="AAFF-camparision2.html">clinical</a></li>
                                    <li ><a href="AAFF-camparision3.html">enterprise</a></li>--%>
                                    <li><a  href="Enterprise.aspx">enterprise</a></li>
                                    <li ><a  href="Service.aspx">Services</a></li>
                                    <li class="active"><a href="Attachments.aspx">attachments</a></li>
                                </ul>

								<div class="tab-content toshiba-content ">
																										
									<div id="menu4" class="tab-pane fade in active">
										<div class="clinical-preview">
											<div class="col-sm-12 col-md-12">
												<!----accordion start---->
												   
												<div class="panel-group" id="accordion" role="tablist" aria-multiselectable="true">


													<div class="panel panel-default">
														<div class="panel-heading blue-collapse-bg" role="tab" id="headingOne">
															<h4 class="panel-title">
																<a class="collapsed" role="button" data-toggle="collapse" data-parent="#Philipsaccordion1" href="#PhilipscollapseOne" aria-expanded="false" aria-controls="PhilipscollapseOne">
																	
																	Philips
																</a>
															</h4>
														</div>
														<div id="PhilipscollapseOne" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingOne" aria-expanded="false">
															<div class="panel-body inner-body-content">
																<!-- panel-group -->

																	<div class="panel-group" id="accordion211">
																		<div class="panel">
																			<a class="panel-col collapsed" data-toggle="collapse" data-parent="#Philipsaccordion1" href="#PhilipscollapseTwoOne">Clinical
																			</a>
																			<div id="PhilipscollapseTwoOne" class="panel-collapse collapse">
																				<div class="panel-body">
																                    <ul>		

                                                                                        <asp:Repeater ID="repPhillips_Clinical" runat="server">
                                                                                            <ItemTemplate>
                                                                                                <li><%# Eval("FileDisplayName") %><span class="text-right pull-right"><i class="fa fa-eye"></i><a target="_blank" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">View</a> <i class="fa fa-download"></i> <a target="_blank" download="<%#  GetFileDownload( Eval("FileLocation") ) %>" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">Download</a></span></li>
                                                                                            </ItemTemplate>
                                                                                        </asp:Repeater>
                                                                                                                                                                                
																                    </ul>
															                    </div>

																			</div>
                                                                           
																		</div>
																		<div class="panel ">
																			<a class="panel-col collapsed" data-toggle="collapse" data-parent="#accordion21" href="#collapseTwoTwo">Enterprise</a>
																			<div id="collapseTwoTwo" class="panel-collapse collapse">
																				<div class="panel-body"><ul>		

                                                                                        <asp:Repeater ID="repPhillips_Enterprise" runat="server">
                                                                                            <ItemTemplate>
                                                                                                <li><%# Eval("FileDisplayName") %><span class="text-right pull-right"><i class="fa fa-eye"></i><a target="_blank" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">View</a> <i class="fa fa-download"></i> <a target="_blank" download="<%#  GetFileDownload( Eval("FileLocation") ) %>" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">Download</a></span></li>
                                                                                            </ItemTemplate>
                                                                                        </asp:Repeater>
                                                                                                                                                                                
																                    </ul></div>
																			</div>
																		</div>
																		<div class="panel ">
																			<a class="panel-col collapsed" data-toggle="collapse" data-parent="#accordion21" href="#collapseTwoThree">Service</a>
																			<div id="collapseTwoThree" class="panel-collapse collapse">
																				<div class="panel-body"><ul>		

                                                                                        <asp:Repeater ID="repPhillips_Service" runat="server">
                                                                                            <ItemTemplate>
                                                                                                <li><%# Eval("FileDisplayName") %><span class="text-right pull-right"><i class="fa fa-eye"></i><a target="_blank" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">View</a> <i class="fa fa-download"></i> <a target="_blank" download="<%#  GetFileDownload( Eval("FileLocation") ) %>" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">Download</a></span></li>
                                                                                            </ItemTemplate>
                                                                                        </asp:Repeater>
                                                                                                                                                                                
																                    </ul></div>
																			</div>
																		</div>
																	</div>
																<!-- panel-group -->
															</div>
														</div>
													</div>

													<div class="panel panel-default">
														<div class="panel-heading lightblue-collapse-bg" role="tab" id="headingTwo">
															<h4 class="panel-title">
																<a class="collapsed" role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseTwo" aria-expanded="false" aria-controls="collapseOne">
																	
																	TeraRecon
																</a>
															</h4>
														</div>
														<div id="collapseTwo" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingTwo" aria-expanded="false">
															<div class="panel-body inner-body-content">
																<!-- panel-group -->

																	<div class="panel-group" id="Teraaccordion21">
																		<div class="panel">
																			<a class="panel-col collapsed"  data-toggle="collapse" data-parent="#Teraaccordion21" href="#TeraReconcollapseTwoOne">Clinical
																			</a>
																			<div id="TeraReconcollapseTwoOne" class="panel-collapse collapse">
																				<div class="panel-body">
																                    <ul>		

                                                                                        <asp:Repeater ID="repTeraClinical" runat="server">
                                                                                            <ItemTemplate>
                                                                                                <li><%# Eval("FileDisplayName") %><span class="text-right pull-right"><i class="fa fa-eye"></i><a target="_blank" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">View</a> <i class="fa fa-download"></i> <a target="_blank" download="<%#  GetFileDownload( Eval("FileLocation") ) %>" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">Download</a></span></li>
                                                                                            </ItemTemplate>
                                                                                        </asp:Repeater>
                                                                                                                                                                                
																                    </ul>
															                    </div>

																			</div>
                                                                           
																		</div>
																		<div class="panel ">
																			<a class="panel-col collapsed" data-toggle="collapse" data-parent="#accordion21" href="#TeraReconcollapseTwoTwo">Enterprise
																			</a>
																			<div id="TeraReconcollapseTwoTwo" class="panel-collapse collapse">
																				<div class="panel-body"><ul>		

                                                                                        <asp:Repeater ID="repTera_Enterprise" runat="server">
                                                                                            <ItemTemplate>
                                                                                                <li><%# Eval("FileDisplayName") %><span class="text-right pull-right"><i class="fa fa-eye"></i><a target="_blank" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">View</a> <i class="fa fa-download"></i> <a target="_blank" download="<%#  GetFileDownload( Eval("FileLocation") ) %>" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">Download</a></span></li>
                                                                                            </ItemTemplate>
                                                                                        </asp:Repeater>
                                                                                                                                                                                
																                    </ul></div>
																			</div>
																		</div>
																		<div class="panel ">
																			<a class="panel-col collapsed" data-toggle="collapse" data-parent="#accordion21" href="#TeraReconcollapseTwoThree">Service
																			</a>
																			<div id="TeraReconcollapseTwoThree" class="panel-collapse collapse">
																				<div class="panel-body"><ul>		

                                                                                        <asp:Repeater ID="repTera_Service" runat="server">
                                                                                            <ItemTemplate>
                                                                                                <li><%# Eval("FileDisplayName") %><span class="text-right pull-right"><i class="fa fa-eye"></i><a target="_blank" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">View</a> <i class="fa fa-download"></i> <a target="_blank" download="<%#  GetFileDownload( Eval("FileLocation") ) %>" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">Download</a></span></li>
                                                                                            </ItemTemplate>
                                                                                        </asp:Repeater>
                                                                                                                                                                                
																                    </ul></div>
																			</div>
																		</div>
																	</div>
																<!-- panel-group -->
															</div>
														</div>
													</div>

													
                                                    <div class="panel panel-default">
														<div class="panel-heading orange-collapse-bg" role="tab" id="SiemensheadingTwo">
															<h4 class="panel-title">
																<a class="collapsed" role="button" data-toggle="collapse" data-parent="#Siemensaccordion1" href="#SiemenscollapseOne" aria-expanded="false" aria-controls="SiemenscollapseOne">
																	Siemens Medical
																</a>
															</h4>
														</div>
														<div id="SiemenscollapseOne" class="panel-collapse collapse" role="tabpanel" aria-labelledby="SiemensheadingTwo" aria-expanded="false">
															<div class="panel-body inner-body-content">
																<!-- panel-group -->

																	<div class="panel-group" id="accordion21">
																		<div class="panel">
																			<a class="panel-col collapsed" data-toggle="collapse" data-parent="#Siemensaccordion1" href="#SiemenscollapseTwoOne">Clinical</a>
																			<div id="SiemenscollapseTwoOne" class="panel-collapse collapse">
																				<div class="panel-body">
																                    <ul>		

                                                                                        <asp:Repeater ID="repSiemensClinical" runat="server">
                                                                                            <ItemTemplate>
                                                                                                <li><%# Eval("FileDisplayName") %><span class="text-right pull-right"><i class="fa fa-eye"></i><a target="_blank" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">View</a> <i class="fa fa-download"></i> <a target="_blank" download="<%#  GetFileDownload( Eval("FileLocation") ) %>" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">Download</a></span></li>
                                                                                            </ItemTemplate>
                                                                                        </asp:Repeater>
                                                                                                                                                                                
																                    </ul>
															                    </div>

																			</div>
                                                                           
																		</div>
																		<div class="panel ">
																			<a class="panel-col collapsed" data-toggle="collapse" data-parent="#accordion21" href="#SiemenscollapseTwoTwo">Enterprise</a>
																			<div id="SiemenscollapseTwoTwo" class="panel-collapse collapse">
																				<div class="panel-body"><ul>		

                                                                                        <asp:Repeater ID="repSiemensEnterprise" runat="server">
                                                                                            <ItemTemplate>
                                                                                                <li><%# Eval("FileDisplayName") %><span class="text-right pull-right"><i class="fa fa-eye"></i><a target="_blank" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">View</a> <i class="fa fa-download"></i> <a target="_blank" download="<%#  GetFileDownload( Eval("FileLocation") ) %>" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">Download</a></span></li>
                                                                                            </ItemTemplate>
                                                                                        </asp:Repeater>
                                                                                                                                                                                
																                    </ul></div>
																			</div>
																		</div>
																		<div class="panel ">
																			<a class="panel-col collapsed" data-toggle="collapse" data-parent="#accordion21" href="#SiemenscollapseTwoThree">Service</a>
																			<div id="SiemenscollapseTwoThree" class="panel-collapse collapse">
																				<div class="panel-body"><ul>		

                                                                                        <asp:Repeater ID="repSiemensService" runat="server">
                                                                                            <ItemTemplate>
                                                                                                <li><%# Eval("FileDisplayName") %><span class="text-right pull-right"><i class="fa fa-eye"></i><a target="_blank" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">View</a> <i class="fa fa-download"></i> <a target="_blank" download="<%#  GetFileDownload( Eval("FileLocation") ) %>" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">Download</a></span></li>
                                                                                            </ItemTemplate>
                                                                                        </asp:Repeater>
                                                                                                                                                                                
																                    </ul></div>
																			</div>
																		</div>
																	</div>
																<!-- panel-group -->
															</div>
														</div>
													</div>

                                                     <div class="panel panel-default">
														<div class="panel-heading GE-collapse-bg" role="tab" id="GEheadingTwo">
															<h4 class="panel-title">
																<a class="collapsed" role="button" data-toggle="collapse" data-parent="#accordion" href="#GEcollapseTwo" aria-expanded="false" aria-controls="collapseOne">
																	GE Healthcare
																</a>
															</h4>
														</div>
														<div id="GEcollapseTwo" class="panel-collapse collapse" role="tabpanel" aria-labelledby="GEheadingTwo" aria-expanded="false">
															<div class="panel-body inner-body-content">
																<!-- panel-group -->

																	<div class="panel-group" id="accordion21">
																		<div class="panel">
																			<a class="panel-col collapsed" data-toggle="collapse" data-parent="#accordion21" href="#GEcollapseTwoOne">Clinical</a>
																			<div id="GEcollapseTwoOne" class="panel-collapse collapse">
																				<div class="panel-body">
																                    <ul>		

                                                                                        <asp:Repeater ID="repGEClinical" runat="server">
                                                                                            <ItemTemplate>
                                                                                                <li><%# Eval("FileDisplayName") %><span class="text-right pull-right"><i class="fa fa-eye"></i> <a target="_blank" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">View</a> <i class="fa fa-download"></i> <a target="_blank" download="<%#  GetFileDownload( Eval("FileLocation") ) %>" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">Download</a></span></li>
                                                                                            </ItemTemplate>
                                                                                        </asp:Repeater>
                                                                                                                                                                                
																                    </ul>
															                    </div>

																			</div>
                                                                           
																		</div>
																		<div class="panel ">
																			<a class="panel-col collapsed" data-toggle="collapse" data-parent="#accordion21" href="#GEcollapseTwoTwo">Enterprise</a>
																			<div id="GEcollapseTwoTwo" class="panel-collapse collapse">
																				<div class="panel-body"><ul>		

                                                                                        <asp:Repeater ID="repGEEnterprise" runat="server">
                                                                                            <ItemTemplate>
                                                                                                <li><%# Eval("FileDisplayName") %><span class="text-right pull-right"><i class="fa fa-eye"></i><a target="_blank" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">View</a> <i class="fa fa-download"></i> <a target="_blank" download="<%#  GetFileDownload( Eval("FileLocation") ) %>" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">Download</a></span></li>
                                                                                            </ItemTemplate>
                                                                                        </asp:Repeater>
                                                                                                                                                                                
																                    </ul></div>
																			</div>
																		</div>
																		<div class="panel ">
																			<a class="panel-col collapsed" data-toggle="collapse" data-parent="#accordion21" href="#GEcollapseTwoThree">Service</a>
																			<div id="GEcollapseTwoThree" class="panel-collapse collapse">
																				<div class="panel-body"><ul>		

                                                                                        <asp:Repeater ID="repGEService" runat="server">
                                                                                            <ItemTemplate>
                                                                                                <li><%# Eval("FileDisplayName") %><span class="text-right pull-right"><i class="fa fa-eye"></i><a target="_blank" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">View</a> <i class="fa fa-download"></i> <a target="_blank" download="<%#  GetFileDownload( Eval("FileLocation") ) %>" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">Download</a></span></li>
                                                                                            </ItemTemplate>
                                                                                        </asp:Repeater>
                                                                                                                                                                                
																                    </ul></div>
																			</div>
																		</div>
																	</div>
																<!-- panel-group -->
															</div>
														</div>
													</div>
													

                                                    <div class="panel panel-default">
														<div class="panel-heading cannon-collapse-bg" role="tab" id="CannonheadingTwo">
															<h4 class="panel-title">
																<a class="collapsed" role="button" data-toggle="collapse" data-parent="#accordion" href="#CannoncollapseTwo" aria-expanded="false" aria-controls="collapseOne">
																	Canon/Toshiba/Vital
																</a>
															</h4>
														</div>
														<div id="CannoncollapseTwo" class="panel-collapse collapse" role="tabpanel" aria-labelledby="CannonheadingTwo" aria-expanded="false">
															<div class="panel-body inner-body-content">
																<!-- panel-group -->

																	<div class="panel-group" id="accordion21">
																		<div class="panel">
																			<a class="panel-col collapsed" data-toggle="collapse" data-parent="#accordion21" href="#CannoncollapseTwoOne">Clinical</a>
																			<div id="CannoncollapseTwoOne" class="panel-collapse collapse">
																				<div class="panel-body">
																                    <ul>		

                                                                                        <asp:Repeater ID="repCannonClinical" runat="server">
                                                                                            <ItemTemplate>
                                                                                                <li><%# Eval("FileDisplayName") %><span class="text-right pull-right"><i class="fa fa-eye"></i><a target="_blank" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">View</a> <i class="fa fa-download"></i> <a target="_blank" download="<%#  GetFileDownload( Eval("FileLocation") ) %>" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">Download</a></span></li>
                                                                                            </ItemTemplate>
                                                                                        </asp:Repeater>
                                                                                                                                                                                
																                    </ul>
															                    </div>

																			</div>
                                                                           
																		</div>
																		<div class="panel ">
																			<a class="panel-col collapsed" data-toggle="collapse" data-parent="#accordion21" href="#CannoncollapseTwoTwo">Enterprise</a>
																			<div id="CannoncollapseTwoTwo" class="panel-collapse collapse">
																				<div class="panel-body"><ul>		

                                                                                        <asp:Repeater ID="repCannonEnterprise" runat="server">
                                                                                            <ItemTemplate>
                                                                                                <li><%# Eval("FileDisplayName") %><span class="text-right pull-right"><i class="fa fa-eye"></i><a target="_blank" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">View</a> <i class="fa fa-download"></i> <a target="_blank" download="<%#  GetFileDownload( Eval("FileLocation") ) %>" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">Download</a></span></li>
                                                                                            </ItemTemplate>
                                                                                        </asp:Repeater>
                                                                                                                                                                                
																                    </ul></div>
																			</div>
																		</div>
																		<div class="panel ">
																			<a class="panel-col collapsed" data-toggle="collapse" data-parent="#accordion21" href="#CannoncollapseTwoThree">Service</a>
																			<div id="CannoncollapseTwoThree" class="panel-collapse collapse">
																				<div class="panel-body"><ul>		

                                                                                    <asp:Repeater ID="repCannonService" runat="server">
                                                                                            <ItemTemplate>
                                                                                                <li><%# Eval("FileDisplayName") %><span class="text-right pull-right"><i class="fa fa-eye"></i><a target="_blank" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">View</a> <i class="fa fa-download"></i> <a target="_blank" download="<%#  GetFileDownload( Eval("FileLocation") ) %>" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">Download</a></span></li>
                                                                                            </ItemTemplate>
                                                                                        </asp:Repeater>
                                                                                        
                                                                                                                                                                                
																                    </ul></div>
																			</div>
																		</div>
																	</div>
																<!-- panel-group -->
															</div>
														</div>
													</div>
													                                                                                                      

                                                    <div class="panel panel-default">
														<div class="panel-heading agfa-collapse-bg" role="tab" id="AgfaheadingTwo">
															<h4 class="panel-title">
																<a class="collapsed" role="button" data-toggle="collapse" data-parent="#accordion" href="#AgfacollapseTwo" aria-expanded="false" aria-controls="collapseOne">
																	Agfa Healthcare
																</a>
															</h4>
														</div>
														<div id="AgfacollapseTwo" class="panel-collapse collapse" role="tabpanel" aria-labelledby="AgfaheadingTwo" aria-expanded="false">
															<div class="panel-body inner-body-content">
																<!-- panel-group -->

																	<div class="panel-group" id="accordion21">
																		<div class="panel">
																			<a class="panel-col collapsed" data-toggle="collapse" data-parent="#accordion21" href="#AgfacollapseTwoOne">Clinical</a>
																			<div id="AgfacollapseTwoOne" class="panel-collapse collapse">
																				<div class="panel-body">
																                    <ul>		

                                                                                        <asp:Repeater ID="repAgfaClinical" runat="server">
                                                                                            <ItemTemplate>
                                                                                                <li><%# Eval("FileDisplayName") %><span class="text-right pull-right"><i class="fa fa-eye"></i><a target="_blank" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">View</a> <i class="fa fa-download"></i> <a target="_blank" download="<%#  GetFileDownload( Eval("FileLocation") ) %>" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">Download</a></span></li>
                                                                                            </ItemTemplate>
                                                                                        </asp:Repeater>
                                                                                                                                                                                
																                    </ul>
															                    </div>

																			</div>
                                                                           
																		</div>
																		<div class="panel ">
																			<a class="panel-col collapsed" data-toggle="collapse" data-parent="#accordion21" href="#AgfacollapseTwoTwo">Enterprise</a>
																			<div id="AgfacollapseTwoTwo" class="panel-collapse collapse">
																				<div class="panel-body"><ul>		

                                                                                        <asp:Repeater ID="repAgfaEnterprise" runat="server">
                                                                                            <ItemTemplate>
                                                                                                <li><%# Eval("FileDisplayName") %><span class="text-right pull-right"><i class="fa fa-eye"></i><a target="_blank" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">View</a> <i class="fa fa-download"></i> <a target="_blank" download="<%#  GetFileDownload( Eval("FileLocation") ) %>" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">Download</a></span></li>
                                                                                            </ItemTemplate>
                                                                                        </asp:Repeater>
                                                                                                                                                                                
																                    </ul></div>
																			</div>
																		</div>
																		<div class="panel ">
																			<a class="panel-col collapsed" data-toggle="collapse" data-parent="#accordion21" href="#AgfacollapseTwoThree">Service</a>
																			<div id="AgfacollapseTwoThree" class="panel-collapse collapse">
																				<div class="panel-body"><ul>		

                                                                                        <asp:Repeater ID="repAgfaService" runat="server">
                                                                                            <ItemTemplate>
                                                                                                <li><%# Eval("FileDisplayName") %><span class="text-right pull-right"><i class="fa fa-eye"></i><a target="_blank" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">View</a> <i class="fa fa-download"></i> <a target="_blank" download="<%#  GetFileDownload( Eval("FileLocation") ) %>" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">Download</a></span></li>
                                                                                            </ItemTemplate>
                                                                                        </asp:Repeater>
                                                                                                                                                                                
																                    </ul></div>
																			</div>
																		</div>
																	</div>
																<!-- panel-group -->
															</div>
														</div>
													</div>


                                                    <div class="panel panel-default">
														<div class="panel-heading others-collapse-bg" role="tab" id="OthersheadingTwo">
															<h4 class="panel-title">
																<a class="collapsed" role="button" data-toggle="collapse" data-parent="#accordion" href="#OtherscollapseTwo" aria-expanded="false" aria-controls="collapseOne">
																	Others
																</a>
															</h4>
														</div>
														<div id="OtherscollapseTwo" class="panel-collapse collapse" role="tabpanel" aria-labelledby="OthersheadingTwo" aria-expanded="false">
															<div class="panel-body inner-body-content">
																<!-- panel-group -->

																	<div class="panel-group" id="accordion21">
																		<div class="panel">
																			<a class="panel-col collapsed" data-toggle="collapse" data-parent="#accordion21" href="#OtherscollapseTwoOne">Clinical</a>
																			<div id="OtherscollapseTwoOne" class="panel-collapse collapse">
																				<div class="panel-body">
																                    <ul>		

                                                                                        <asp:Repeater ID="repOtherClinical" runat="server">
                                                                                            <ItemTemplate>
                                                                                                <li><%# Eval("FileDisplayName") %><span class="text-right pull-right"><i class="fa fa-eye"></i><a target="_blank" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">View</a> <i class="fa fa-download"></i> <a target="_blank" download="<%#  GetFileDownload( Eval("FileLocation") ) %>" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">Download</a></span></li>
                                                                                            </ItemTemplate>
                                                                                        </asp:Repeater>
                                                                                                                                                                                
																                    </ul>
															                    </div>

																			</div>
                                                                           
																		</div>
																		<div class="panel ">
																			<a class="panel-col collapsed" data-toggle="collapse" data-parent="#accordion21" href="#OtherscollapseTwoTwo">Enterprise</a>
																			<div id="OtherscollapseTwoTwo" class="panel-collapse collapse">
																				<div class="panel-body"><ul>		

                                                                                        <asp:Repeater ID="repOtherEnterprise" runat="server">
                                                                                            <ItemTemplate>
                                                                                                <li><%# Eval("FileDisplayName") %><span class="text-right pull-right"><i class="fa fa-eye"></i><a target="_blank" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">View</a> <i class="fa fa-download"></i> <a target="_blank" download="<%#  GetFileDownload( Eval("FileLocation") ) %>" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">Download</a></span></li>
                                                                                            </ItemTemplate>
                                                                                        </asp:Repeater>
                                                                                                                                                                                
																                    </ul></div>
																			</div>
																		</div>
																		<div class="panel ">
																			<a class="panel-col collapsed" data-toggle="collapse" data-parent="#accordion21" href="#OtherscollapseTwoThree">Service</a>
																			<div id="OtherscollapseTwoThree" class="panel-collapse collapse">
																				<div class="panel-body"><ul>		

                                                                                        <asp:Repeater ID="repOtherService" runat="server">
                                                                                            <ItemTemplate>
                                                                                                <li><%# Eval("FileDisplayName") %><span class="text-right pull-right"><i class="fa fa-eye"></i><a target="_blank" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">View</a> <i class="fa fa-download"></i> <a target="_blank" download="<%#  GetFileDownload( Eval("FileLocation") ) %>" href="<%#  GetFileDownload( Eval("FileLocation") ) %>">Download</a></span></li>
                                                                                            </ItemTemplate>
                                                                                        </asp:Repeater>
                                                                                                                                                                                
																                    </ul></div>
																			</div>
																		</div>
																	</div>
																<!-- panel-group -->
															</div>
														</div>
													</div>

													</div><!-- panel-group -->
    
												<!----accordion end---->
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
    


         
   
    

        

</body>
     
</html>
