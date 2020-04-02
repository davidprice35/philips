<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Enterprise.aspx.cs" Inherits="competitive_info_Competitors" %>

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
    <title>Enterprise</title>

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


      <form id="form1" runat="server">

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
							<img src="/images/EnterLogo.png"class="img-responsive">
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

                                          

                                         <% if (m_UserType == "Super Admin")
                                            {%>
                                        <li><a href="/competitive-info/Enterprise">Enterprise</a></li>                                        
                                         <li><asp:LinkButton ID="cmdEdit" OnClick="cmdEdit_Click"  runat="server">Edit</asp:LinkButton></li>

                                        <%}%>
                                        <li><a href="/competitive-info/EnterprisePendingUpdates.aspx">Approve</a></li>


                                        <!--<li><a href="/">MV Search</a></li>
										<li class="submenubar"><a href="/">Admin</a>
											<ul class="dropdown-menu">												
												<li><a href="/admin/EditGridData">Edit Data</a></li> 
												<li><a href="/admin/PendingUpdates">Pending Changes</a></li>												
											</ul>
										
										</li>-->					
                                        


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
															<%=ShowProfileMenu() %>
                                                            

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
			
			<script>

                function MenuDisplay() {
                    var x = document.getElementById("demo1");
                    if (x.style.display === "none") {
                        x.style.display = "block";
                    } else {
                        x.style.display = "none";
                    }
                }

			</script>
			
				<div class="body-section-design">					
					<div class="col-sm-3 col-md-3 col-lg-2 left-padding"> 
						<div class="left-sidebar camparision-section">

							<%--<button class="btn-primary submit show-hide-btn" onclick="MenuDisplay()" type="button"  >Show/Hide</button>	--%>
                             <button class="btn-primary submit show-hide-btn" type="button"  >Competitors</button>

							<div class="required-fields" id="demo1">
								<div class="checkbox-body-part">
									<ul>
										 <li>
											
											<div class="checkbox checkbox-primary">
												<input id="chkPhilips" type="checkbox" checked="">
												<label for="chkPhilips" class="philips">
													Philips
												</label>
											</div>
										</li> 
										<li>
											
											<div class="checkbox checkbox-primary">
												<input id="chkTera" type="checkbox" checked="">
												<label for="chkTera" class="teracon">
													TeraRecon
												</label>
											</div>
										</li>
										<li>
											
											<div class="checkbox checkbox-primary">
												<input id="chkSiemens" type="checkbox" checked="">
												<label for="chkSiemens" class="siemens">
													Siemens Medical
												</label>
											</div>
										</li>
										<li>
											
											<div class="checkbox checkbox-primary">
												<input id="chkGE" type="checkbox" checked="" >
												<label for="chkGE" class="health">
													GE Healthcare
												</label>
											</div>
										</li>
										<li>
											
											<div class="checkbox checkbox-primary">
												<input id="chkCanon" type="checkbox" checked="">
												<label for="chkCanon" class="canon">
													Canon/Toshiba/Vital
												</label>
											</div>
										</li>
										
									
										<li>
											
											<div class="checkbox checkbox-primary">
												<input id="chkAgfa" type="checkbox" checked="">
												<label for="chkAgfa" class="agfa">
													Agfa Healthcare
												</label>
											</div>
										</li>
										
									</ul>
								</div>
						
							 <button class="btn-primary submit show-hide-btn" type="button"  >Matrix Filters</button>
							
							<div class="checkbox-body-part">
									<ul>
										 <li>
											
											<div class="checkbox checkbox-primary">
												<input id="chkSolution1" type="checkbox" checked="">
												<label for="chkSolution1">
													Solution
												</label>
											</div>
										</li> 
										<li>
											
											<div class="checkbox checkbox-primary">
												<input id="chkProposition" type="checkbox" checked="">
												<label for="chkProposition">
													Value Proposition
												</label>
											</div>
										</li>
										<li>
											
											<div class="checkbox checkbox-primary">
												<input id="chkVendor" type="checkbox" checked="">
												<label for="chkVendor">
													Vendor Neutral
												</label>
											</div>
										</li>
										<li>
											
											<div class="checkbox checkbox-primary">
												<input id="chkConcurrent" type="checkbox" checked="" >
												<label for="chkConcurrent">
													Concurrent Users
												</label>
											</div>
										</li>
										<li>
											
											<div class="checkbox checkbox-primary">
												<input id="chkInteroperability" type="checkbox" checked="">
												<label for="chkInteroperability">
													System Interoperability
												</label>
											</div>
										</li>
										
									
										<li>
											
											<div class="checkbox checkbox-primary">
												<input id="chkIntegration" type="checkbox" checked="">
												<label for="chkIntegration">
													System Integration
												</label>
											</div>
										</li>
										
										<li>
											
											<div class="checkbox checkbox-primary">
												<input id="chkImaging" type="checkbox" checked="">
												<label for="chkImaging">
													Cloud Medical Imaging
												</label>
											</div>
										</li>



                                        <li>
											
											<div class="checkbox checkbox-primary">
												<input id="chkAI" type="checkbox" checked="">
												<label for="chkAI">
													Artificial Intelligence
												</label>
											</div>
										</li>


                                        <li>
											
											<div class="checkbox checkbox-primary">
												<input id="chkUniversal" type="checkbox" checked="">
												<label for="chkUniversal">
													Universal Viewer
												</label>
											</div>
										</li>

                                           <li>
											
											<div class="checkbox checkbox-primary">
												<input id="chkSingle" type="checkbox" checked="">
												<label for="chkSingle">
													Single sign-on
												</label>
											</div>
										</li>

                                           <li>
											
											<div class="checkbox checkbox-primary">
												<input id="chk3D" type="checkbox" checked="">
												<label for="chk3D">
													3D printing
												</label>
											</div>
										</li>

                                         <li>
											
											<div class="checkbox checkbox-primary">
												<input id="chkCinematic" type="checkbox" checked="">
												<label for="chkCinematic">
													Cinematic Rendering
												</label>
											</div>
										</li>

                                         <li>
											
											<div class="checkbox checkbox-primary">
												<input id="chkWorkflow" type="checkbox" checked="">
												<label for="chkWorkflow">
													Workflow Tools
												</label>
											</div>
										</li>

                                          <li>
											
											<div class="checkbox checkbox-primary">
												<input id="chkWeaknesses" type="checkbox" checked="">
												<label for="chkWeaknesses">
													Solution Weaknesses
												</label>
											</div>
										</li>

                                         <li>
											
											<div class="checkbox checkbox-primary">
												<input id="chkStrengths" type="checkbox" checked="">
												<label for="chkStrengths">
													Solution Strengths
												</label>
											</div>
										</li>
										
                                        <li>
											
											<div class="checkbox checkbox-primary">
												<input id="chkArgumentation" type="checkbox" checked="">
												<label for="chkArgumentation">
													Competitive Argumentation
												</label>
											</div>
										</li>

									</ul>
								</div>
							</div>
						</div>
					</div>
						<div class="col-lg-12 col-md-12 col-sm-9 right-padding">
							<div class="rightbar">
								<ul class="nav nav-tabs">
									  <li ><a href="Competitors.aspx">competitors</a></li>
									 <li><a href="Clinical.aspx">clinical</a></li>
									 
                                    <li class="active"><a  href="Enterprise.aspx">enterprise</a></li>
                                    <li ><a  href="Service.aspx">Services</a></li>
									   <li><a href="Attachments.aspx">attachments</a></li>
									  
								</ul>

								<div class="tab-content toshiba-content " style="display:inline-block;width:1400px;">
									<div id="home" class="tab-pane fade in active">
										
	
                                        <script type="text/javascript">
                                                                                       
                                              function refreshData() { 
                                                $('#<%=Grid1.ClientID %>').ejGrid("option", { editSettings: { allowEditing: true, allowAdding: false, allowDeleting: false }, toolbarSettings: { showToolbar: true, toolbarItems: [ej.Grid.ToolBarItems.Edit, ej.Grid.ToolBarItems.Update, ej.Grid.ToolBarItems.Cancel] } })                       
                                              } 

                                             $("#chkSolution1").change(function (e) {
                                                 var gridObj = $("#Grid1").ejGrid("instance"); 
                                                 if ($(this).is(":checked")) {
                                                     gridObj.getRowByIndex(0).show();
                                                 }
                                                 else
                                                 {
                                                     
                                                     gridObj.getRowByIndex(0).hide();
                                                 }
                                            });

                                             $("#chkProposition").change(function (e) {
                                                 var gridObj = $("#Grid1").ejGrid("instance"); 
                                                 if ($(this).is(":checked")) {
                                                     gridObj.getRowByIndex(1).show();
                                                 }
                                                 else
                                                 {
                                                     
                                                     gridObj.getRowByIndex(1).hide();
                                                 }
                                            });

                                             $("#chkVendor").change(function (e) {
                                                 var gridObj = $("#Grid1").ejGrid("instance"); 
                                                 if ($(this).is(":checked")) {
                                                     gridObj.getRowByIndex(2).show();
                                                 }
                                                 else
                                                 {
                                                     
                                                     gridObj.getRowByIndex(2).hide();
                                                 }
                                            });

                                            $("#chkConcurrent").change(function (e) {
                                                 var gridObj = $("#Grid1").ejGrid("instance"); 
                                                 if ($(this).is(":checked")) {
                                                     gridObj.getRowByIndex(3).show();
                                                 }
                                                 else
                                                 {
                                                     
                                                     gridObj.getRowByIndex(3).hide();
                                                 }
                                            });

                                            
                                            $("#chkInteroperability").change(function (e) {
                                                 var gridObj = $("#Grid1").ejGrid("instance"); 
                                                 if ($(this).is(":checked")) {
                                                     gridObj.getRowByIndex(4).show();
                                                 }
                                                 else
                                                 {
                                                     
                                                     gridObj.getRowByIndex(4).hide();
                                                 }
                                            });

                                             $("#chkIntegration").change(function (e) {
                                                 var gridObj = $("#Grid1").ejGrid("instance"); 
                                                 if ($(this).is(":checked")) {
                                                     gridObj.getRowByIndex(5).show();
                                                 }
                                                 else
                                                 {
                                                     
                                                     gridObj.getRowByIndex(5).hide();
                                                 }
                                            });

                                             $("#chkImaging").change(function (e) {
                                                 var gridObj = $("#Grid1").ejGrid("instance"); 
                                                 if ($(this).is(":checked")) {
                                                     gridObj.getRowByIndex(6).show();
                                                 }
                                                 else
                                                 {
                                                     
                                                     gridObj.getRowByIndex(6).hide();
                                                 }
                                            });

                                             $("#chkAI").change(function (e) {
                                                 var gridObj = $("#Grid1").ejGrid("instance"); 
                                                 if ($(this).is(":checked")) {
                                                     gridObj.getRowByIndex(7).show();
                                                 }
                                                 else
                                                 {
                                                     
                                                     gridObj.getRowByIndex(7).hide();
                                                 }
                                            });
                                             $("#chkUniversal").change(function (e) {
                                                 var gridObj = $("#Grid1").ejGrid("instance"); 
                                                 if ($(this).is(":checked")) {
                                                     gridObj.getRowByIndex(8).show();
                                                 }
                                                 else
                                                 {
                                                     
                                                     gridObj.getRowByIndex(8).hide();
                                                 }
                                            });
                                             $("#chkSingle").change(function (e) {
                                                 var gridObj = $("#Grid1").ejGrid("instance"); 
                                                 if ($(this).is(":checked")) {
                                                     gridObj.getRowByIndex(9).show();
                                                 }
                                                 else
                                                 {
                                                     
                                                     gridObj.getRowByIndex(9).hide();
                                                 }
                                            });
                                             $("#chk3D").change(function (e) {
                                                 var gridObj = $("#Grid1").ejGrid("instance"); 
                                                 if ($(this).is(":checked")) {
                                                     gridObj.getRowByIndex(10).show();
                                                 }
                                                 else
                                                 {
                                                     
                                                     gridObj.getRowByIndex(10).hide();
                                                 }
                                            });
                                             $("#chkCinematic").change(function (e) {
                                                 var gridObj = $("#Grid1").ejGrid("instance"); 
                                                 if ($(this).is(":checked")) {
                                                     gridObj.getRowByIndex(11).show();
                                                 }
                                                 else
                                                 {
                                                     
                                                     gridObj.getRowByIndex(11).hide();
                                                 }
                                            });
                                             $("#chkWorkflow").change(function (e) {
                                                 var gridObj = $("#Grid1").ejGrid("instance"); 
                                                 if ($(this).is(":checked")) {
                                                     gridObj.getRowByIndex(12).show();
                                                 }
                                                 else
                                                 {
                                                     
                                                     gridObj.getRowByIndex(12).hide();
                                                 }
                                            });
                                             $("#chkWeaknesses").change(function (e) {
                                                 var gridObj = $("#Grid1").ejGrid("instance"); 
                                                 if ($(this).is(":checked")) {
                                                     gridObj.getRowByIndex(13).show();
                                                 }
                                                 else
                                                 {
                                                     
                                                     gridObj.getRowByIndex(13).hide();
                                                 }
                                            });
                                             $("#chkStrengths").change(function (e) {
                                                 var gridObj = $("#Grid1").ejGrid("instance"); 
                                                 if ($(this).is(":checked")) {
                                                     gridObj.getRowByIndex(14).show();
                                                 }
                                                 else
                                                 {
                                                     
                                                     gridObj.getRowByIndex(14).hide();
                                                 }
                                            });
                                             $("#chkArgumentation").change(function (e) {
                                                 var gridObj = $("#Grid1").ejGrid("instance"); 
                                                 if ($(this).is(":checked")) {
                                                     gridObj.getRowByIndex(15).show();
                                                 }
                                                 else
                                                 {
                                                     
                                                     gridObj.getRowByIndex(15).hide();
                                                 }
                                            });

                                            $("#chkPhilips").change(function (e) {
                                                e = e || window.event;                                                                                               
                                                checkStatus = e.target.checked;                                                                                                
                                                showhide('Philips', checkStatus);
                                            });

                                             $("#chkTera").change(function (e) {
                                                e = e || window.event;                                                                                               
                                                checkStatus = e.target.checked;                                                                                                
                                                showhide('Tera', checkStatus);
                                            });

                                            $("#chkSiemens").change(function (e) {
                                                e = e || window.event;                                                                                               
                                                checkStatus = e.target.checked;                                                                                                
                                                showhide('Siemens', checkStatus);
                                            });

                                            $("#chkGE").change(function (e) {
                                                e = e || window.event;                                                                                               
                                                checkStatus = e.target.checked;                                                                                                
                                                showhide('GE', checkStatus);
                                            });

                                             $("#chkCanon").change(function (e) {
                                                e = e || window.event;                                                                                               
                                                checkStatus = e.target.checked;                                                                                                
                                                showhide('Cannon', checkStatus);
                                            });

                                             $("#chkAgfa").change(function (e) {
                                                e = e || window.event;                                                                                               
                                                checkStatus = e.target.checked;                                                                                                
                                                showhide('Agfa', checkStatus);
                                            });

                                            
                                            


                                            function showhide(colName,checkStatus) {

                                                var gridObj = $('#<%= Grid1.ClientID %>').data("ejGrid");

                                                if (checkStatus == false) {
                                                    if (gridObj.getVisibleColumnNames().length > 1) {
                                                        gridObj.hideColumns(colName);
                                                    }
                                                }
                                                else {
                                                    gridObj.showColumns(colName);
                                                }


                                            }


                                           

                                        </script>

									<div style="margin-top: 30px;height:660px;">
                                         <div id="scroll"></div>
                                       <ej:Grid ID="Grid1" runat='server' MinWidth="400" Width="1380" Height="580"  AllowScrolling="true" OnServerBatchEditRow="EditEvents_ServerEditRow" OnServerEditRow="EditEvents_ServerEditRow"  AllowTextWrap="true" AllowResizing="true" IsResponsive="false">
                                            <ScrollSettings Width="180"  FrozenColumns="3" />  
                                            <Columns>
                                                <ej:Column Field="DataID" IsPrimaryKey="true" Width="0"  HeaderText="DataID"     />
                                                <ej:Column Field="ColumnName" Width="180"  AllowEditing="false"  CssClass="solution" HeaderText="ColumnName"     />

                                                <ej:Column Field="Philips" Width="350" HeaderText="Philips" CssClass="Philips" HeaderTextAlign="center" DisableHtmlEncode="false"  HeaderTemplateID="#PhilipsHeader"   >                                                
                                                    <EditTemplate Create="create" Read="Philipsread" Write="Philipswrite" />
                                                </ej:Column>

                                                <ej:Column Field="Tera" Width="350" HeaderText="Tera" CssClass="Tera" HeaderTextAlign="center" HeaderTemplateID="#TeraHeader"  >                                                
                                                    <EditTemplate Create="create" Read="Teraread" Write="Terawrite" />
                                                </ej:Column>

                                                <ej:Column Field="Siemens" Width="350" HeaderText="Siemens" CssClass="Siemens" HeaderTextAlign="center" HeaderTemplateID="#SiemensHeader"  >                                                
                                                    <EditTemplate Create="create" Read="Siemensread" Write="Siemenswrite" />
                                                </ej:Column>

                                                <ej:Column Field="GE" Width="350" HeaderText="GE"  CssClass="GE" HeaderTextAlign="center" HeaderTemplateID="#GEHeader">                                                
                                                    <EditTemplate Create="create" Read="GEread" Write="GEwrite" />
                                                </ej:Column>
                                                <ej:Column Field="Cannon" Width="350" CssClass="Cannon"  HeaderText="Canon/Toshiba/Vital" HeaderTextAlign="center" HeaderTemplateID="#Cannon" >                                                
                                                    <EditTemplate Create="create" Read="Cannonread" Write="Cannonwrite" />
                                                </ej:Column>
                                                <ej:Column Field="Agfa" Width="350" CssClass="Agfa" HeaderText="Agfa Healthcare" HeaderTextAlign="center" HeaderTemplateID="#Agfa" >                                                
                                                    <EditTemplate Create="create" Read="Agfaread" Write="Agfawrite" />
                                                </ej:Column>
                                                
                                            </Columns>

                                             <ClientSideEvents  DataBound="createEvent" QueryCellInfo="onGridQueryCellInfoEvent" ActionComplete="complete" />
                                             <EditSettings AllowEditing="True"></EditSettings>
                                            <ToolbarSettings ShowToolbar="True" ToolbarItems="edit,update,cancel"></ToolbarSettings>
                                           
                                        </ej:Grid>

                                         <script type="text/javascript">    

                                              function complete(args)
                                            { 
                                                 if (args.requestType == "save") { 
                                                     args.data.Philipscheck = Philipsradioval; 
                                                     args.rowData.Philipscheck = Philipsradioval; 

                                                     args.data.Teracheck = Teraradioval; 
                                                     args.rowData.Teracheck =Teraradioval; 

                                                     args.data.Siemenscheck = Siemensradioval; 
                                                     args.rowData.Siemenscheck = Siemensradioval; 

                                                     args.data.GEcheck = GEradioval; 
                                                     args.rowData.GEcheck = GEradioval; 

                                                     args.data.Cannoncheck = Cannonradioval; 
                                                     args.rowData.Cannoncheck = Cannonradioval; 

                                                     args.data.Agfacheck = Agfaradioval; 
                                                     args.rowData.Agfacheck = Agfaradioval; 
                                                 } 
                                             } 

                                             function onGridQueryCellInfoEvent(args) {
                                                 if (args.column.field != "ColumnName" && args.rowData.ColumnName != "Solution") { //&& args.rowData.EmployeeID == 1) {

                                                     if (args.rowData.ColumnName == 'Competitive Argumentation') {
                                                       //  debugger;
                                                     }

                                                     if (args.rowData.TrafficLight!=null) {
                                                         var data = args.rowData.TrafficLight.split(';')


                                                         for (i = 0; i < data.length; i++) {
                                                             if (data[i].indexOf(args.column.field) >=0) {
                                                                 var ItemData = data[i].split(':')
                                                                 switch (ItemData[1]) {
                                                                     case "1":
                                                                         $(args.cell).css("vertical-align", "top");
                                                                         $(args.cell).addClass('redMarker');
                                                                         
                                                                         break;
                                                                     case "2":
                                                                         $(args.cell).css("vertical-align", "top");
                                                                         $(args.cell).addClass('greenMarker');
                                                                         break;
                                                                     case "3":
                                                                         $(args.cell).css("vertical-align", "top");
                                                                         $(args.cell).addClass('orangeMarker');                                                                         
                                                                         break;
                                                                 }
                                                             }
                                                         }
                                                     }


                                                     
                                                     
                                                     
                                                 }
                                             }


                                              function resize(args) {
                                                    scrollcheck(args);
                                            }



                                            function scrollcheck(args) {
                                                var width, height, maximum, viewportSize;
                                                var GridObj = $('#<%= Grid1.ClientID %>').ejGrid("instance");
                                                var scroller = GridObj.getScrollObject();
                                                width = viewportSize = GridObj.model.scrollSettings.width - scroller.model.scrollerSize;
                                                height = scroller.model.scrollerSize;
                                                if (GridObj.model.scrollSettings.frozenColumns > 0)
                                                    maximum = scroller.content().find(".e-movablecontent")[0]["scrollWidth"] + scroller.content().find(".e-frozencontentdiv")[0]["scrollWidth"];
                                                else
                                                    maximum = scroller.content()[0]["scrollWidth"];
                                                $("#scroll").ejScrollBar({
                                                    viewportSize: viewportSize,
                                                    width: width,
                                                    maximum: maximum - viewportSize,
                                                    scroll: ej.proxy(scroller._scrollChanged, scroller),
                                                    thumbEnd: ej.proxy(scroller._thumbEnd, scroller),
                                                    thumbStart: ej.proxy(scroller._thumbStart, scroller),
                                                    thumbMove: ej.proxy(scroller._thumbMove, scroller),
                                                });
                                                var scrollbar = $("#scroll").ejScrollBar("instance");
                                                if (scroller.model.enableRTL) {
                                                    scrollbar._scrollData.enableRTL = true;
                                                }
                                                GridObj.element.find(".e-gridheader").append($("#scroll"));
                                            }

                                            function createEvent(args) {                                               
                                                scrollcheck(args);
                                            }


                                             $(function () {
                                                 var GridObj = $('#<%= Grid1.ClientID %>').ejGrid("instance")
                                                 if (GridObj.model.scrollSettings.frozenColumns > 0)
                                                     var content = ".e-movablecontent"
                                                 else
                                                     var content = ".e-content";
                                                 $('#<%= Grid1.ClientID %>').find(content).scroll(function (args) {
                                                             var grid =  $('#<%= Grid1.ClientID %>').ejGrid("instance");
                                                             var scroller = grid.getScrollObject();
                                                             var scrollLeft = scroller._rtlScrollLeftValue;
                                                             var value = scroller.scrollLeft();
                                                             if (grid.model.enableRTL) {
                                                                  value = value - scrollLeft;
                                                             }
                                                             var scrollbar = $("#scroll").ejScrollBar("instance");
                                                                 scrollbar.scroll(value);
                                                              });
                                             });    

                                              function GetTrafficData( dataelem, comp )
                                            {
                                                try{
                                                    
                                                    if ( dataelem !=null)
                                                    {
                                                        if ( dataelem !="")
                                                        {
                                                            var dataItem = dataelem.slice(1);
        
                                                            var data = dataItem.split(';')


                                                            for (i = 0; i < data.length; i++) {
                                                                if (data[i].indexOf(comp)>=0) {
                                                                    var ItemData = data[i].split(':')
                                                                    switch (ItemData[1]) {
                                                                        case "1":
                                                                            return comp + "checkboxBetter";
                                                                            break;
                                                                        case "2":
                                                                            return comp + "checkboxWorse";
                                                                            break;
                                                                        case "3":
                                                                            return comp + "checkbox50";
                                                                            break;
                                                                        case "4"://NONE
                                                                            return comp + "checkboxNone";
                                                                            break;
                                                                        default:
                                                                            return comp + "checkboxNone";
                                                                            break;
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    
                                                    
                                                }
                                                catch(err) {
                                                    return "";
                                                }
                                            }




                                             var val;

                                             function GridActionBeginEvent(args) {
                                               
                                             }

                                            function create() {
                                                return $("<textarea class='e-field' rows=5 style='width: 100%;'></textarea>");
                                            }

                                            function Philipswrite(args) {
                                                args.element.val(args.rowdata["Philips"]);
                                                $(args.element.parents('td')[0]).append("<textarea id='PhilipsComments' type='text' rows=3 style='width: 100%;' name='PhilipsComments'></textarea>");
                                                //$(args.element.parents('td')[0]).append('<input type="radio" name="Philipscheck" id="PhilipscheckboxBetter" value="1"><label for="PhilipscheckboxBetter">Better than Philips</label><br/>');
                                                //$(args.element.parents('td')[0]).append('<input type="radio" name="Philipscheck" id="PhilipscheckboxWorse" value="2"><label for="PhilipscheckboxWorse">Worse than Philips</label><br/>');
                                                //$(args.element.parents('td')[0]).append('<input type="radio" name="Philipscheck" id="Philipscheckbox50" value="3"><label for="Philipscheckbox50">50/50 with Philips</label><br/>');
                                                //$(args.element.parents('td')[0]).append('<input type="radio" name="Philipscheck" id="PhilipscheckboxNone" value="4"><label for="PhilipscheckboxNone">None</label><br/>');
                                                args.rowdata["Comment"] != null ? $("#PhilipsComments").val(args.rowdata['Comment']) : $("#PhilipsComments").attr('placeholder', 'Additional Comments');
                                                
                                                var TrafficData= GetTrafficData( args.rowdata.TrafficLight , "Philips");
                                                if (TrafficData != null) {                                                    
                                                    //document.getElementById(TrafficData).checked= true;                                                                                                       
                                                }
                                            }

                                             function Terawrite(args) {
                                                 args.element.val(args.rowdata["Tera"]);

                                                 $(args.element.parents('td')[0]).append("<textarea id='TeraComments' type='text' rows=3 style='width: 100%;' name='TeraComments'></textarea>");
                                                 $(args.element.parents('td')[0]).append('<input type="radio" name="Teracheck" id="TeracheckboxBetter"  value="1"><label for="PhilipscheckboxBetter">Better than Philips</label><br/>');
                                                 $(args.element.parents('td')[0]).append('<input type="radio" name="Teracheck" id="TeracheckboxWorse"  value="2"><label for="PhilipscheckboxWorse">Worse than Philips</label><br/>');
                                                 $(args.element.parents('td')[0]).append('<input type="radio" name="Teracheck" id="Teracheckbox50"  value="3"><label for="Philipscheckbox50">50/50 with Philips</label><br/>');
                                                 $(args.element.parents('td')[0]).append('<input type="radio" name="Teracheck" id="TeracheckboxNone" value="4"><label for="TeracheckboxNone">None</label><br/>');

                                                 args.rowdata["Comment"] != null ? $("#TeraComments").val(args.rowdata['Comment']) : $("#TeraComments").attr('placeholder', 'Additional Comments');


                                                var TrafficData= GetTrafficData( args.rowdata.TrafficLight , "Tera");
                                                if (TrafficData != null) {                                                    
                                                    document.getElementById(TrafficData).checked= true;                                                                                                       
                                                }
                                            }

                                            function Siemenswrite(args) {
                                                 args.element.val(args.rowdata["Siemens"]);

                                                 $(args.element.parents('td')[0]).append("<textarea id='SiemensComments' type='text' rows=3 style='width: 100%;' name='SiemensComments'></textarea>");
                                                 args.rowdata["Comment"] != null ? $("#SiemensComments").val(args.rowdata['Comment']) : $("#SiemensComments").attr('placeholder', 'Additional Comments');
                                                 $(args.element.parents('td')[0]).append('<input type="radio" name="Siemenscheck" id="SiemenscheckboxBetter"  value="1"><label for="SiemenscheckboxBetter">Better than Philips</label><br/>');
                                                 $(args.element.parents('td')[0]).append('<input type="radio" name="Siemenscheck" id="SiemenscheckboxWorse"  value="2"><label for="SiemenscheckboxWorse">Worse than Philips</label><br/>');
                                                $(args.element.parents('td')[0]).append('<input type="radio" name="Siemenscheck" id="Siemenscheckbox50"  value="3"><label for="Siemenscheckbox50">50/50 with Philips</label><br/>');
                                                $(args.element.parents('td')[0]).append('<input type="radio" name="Siemenscheck" id="SiemenscheckboxNone" value="4"><label for="SiemenscheckboxNone">None</label><br/>');

                                                var TrafficData= GetTrafficData( args.rowdata.TrafficLight , "Siemens");
                                                if (TrafficData != null) {                                                    
                                                    document.getElementById(TrafficData).checked= true;                                                                                                       
                                                }
                                            }

                                            function GEwrite(args) {
                                                args.element.val(args.rowdata["GE"]);

                                                $(args.element.parents('td')[0]).append("<textarea id='GEComments' type='text' rows=3 style='width: 100%;' name='GEC    omments'></textarea>");
                                                args.rowdata["Comment"] != null ? $("#GEComments").val(args.rowdata['Comment']) : $("#GEComments").attr('placeholder', 'Additional Comments');
                                                $(args.element.parents('td')[0]).append('<input type="radio" name="GEcheck" id="GEcheckboxBetter"  value="1"><label for="GEcheckboxBetter">Better than Philips</label><br/>');
                                                 $(args.element.parents('td')[0]).append('<input type="radio" name="GEcheck" id="GEcheckboxWorse"  value="2"><label for="GEcheckboxWorse">Worse than Philips</label><br/>');
                                                 $(args.element.parents('td')[0]).append('<input type="radio" name="GEcheck" id="GEcheckbox50"  value="3"><label for="GEcheckbox50">50/50 with Philips</label><br/>');
                                                $(args.element.parents('td')[0]).append('<input type="radio" name="GEcheck" id="GEcheckboxNone" value="4"><label for="GEcheckboxNone">None</label><br/>');

                                                var TrafficData= GetTrafficData( args.rowdata.TrafficLight , "GE");
                                                if (TrafficData != null) {                                                    
                                                    document.getElementById(TrafficData).checked= true;                                                                                                       
                                                }
                                            }

                                            function Cannonwrite(args) {
                                                args.element.val(args.rowdata["Cannon"]);

                                                $(args.element.parents('td')[0]).append("<textarea id='CannonComments' type='text' rows=3 style='width: 100%;' name='CannonComments'></textarea>");
                                                args.rowdata["Comment"] != null ? $("#CannonComments").val(args.rowdata['Comment']) : $("#CannonComments").attr('placeholder', 'Additional Comments');
                                                $(args.element.parents('td')[0]).append('<input type="radio" name="Cannoncheck" id="CannoncheckboxBetter" value="1"><label for="CannoncheckboxBetter">Better than Philips</label><br/>');
                                                $(args.element.parents('td')[0]).append('<input type="radio" name="Cannoncheck" id="CannoncheckboxWorse" value="2"><label for="CannoncheckboxWorse">Worse than Philips</label><br/>');
                                                $(args.element.parents('td')[0]).append('<input type="radio" name="Cannoncheck" id="Cannoncheckbox50" value="3"><label for="Cannoncheckbox50">50/50 with Philips</label><br/>');
                                                $(args.element.parents('td')[0]).append('<input type="radio" name="Cannoncheck" id="CannoncheckboxNone" value="4"><label for="CannoncheckboxNone">None</label><br/>');

                                               var TrafficData= GetTrafficData( args.rowdata.TrafficLight , "Cannon");
                                                if (TrafficData != null) {                                                    
                                                    document.getElementById(TrafficData).checked= true;                                                                                                       
                                                }
                                            }

                                            function Agfawrite(args) {
                                                args.element.val(args.rowdata["Agfa"]);

                                                $(args.element.parents('td')[0]).append("<textarea id='AgfaComments' type='text' rows=3 style='width: 100%;' name='AgfaComments'></textarea>");
                                                args.rowdata["Comment"] != null ? $("#AgfaComments").val(args.rowdata['Comment']) : $("#AgfaComments").attr('placeholder', 'Additional Comments');
                                                $(args.element.parents('td')[0]).append('<input type="radio" name="Agfacheck" id="AgfacheckboxBetter" value="1"><label for="PhilipscheckboxBetter">Better than Philips</label><br/>');
                                                $(args.element.parents('td')[0]).append('<input type="radio" name="Agfacheck" id="AgfacheckboxWorse" value="2"><label for="PhilipscheckboxWorse">Worse than Philips</label><br/>');
                                                $(args.element.parents('td')[0]).append('<input type="radio" name="Agfacheck" id="Agfacheckbox50" value="3"><label for="Philipscheckbox50">50/50 with Philips</label><br/>');
                                                $(args.element.parents('td')[0]).append('<input type="radio" name="Agfacheck" id="AgfacheckboxNone" value="4"><label for="AgfacheckboxNone">None</label><br/>');

                                                var TrafficData= GetTrafficData( args.rowdata.TrafficLight , "Agfa");
                                                if (TrafficData != null) {                                                    
                                                    document.getElementById(TrafficData).checked= true;                                                                                                       
                                                }
                                            }

                                            function read(args) {
                                                return args.val();
                                             }

                                            function Philipsread(args) {                                                
                                                val = $("#PhilipsComments").val();
                                                Philipsradioval = $("input[type='radio'][name='Philipscheck']:checked").val();                                                 
                                                return args.val()
                                            }

                                             function Teraread(args) {
                                                 val = $("#TeraComments").val();
                                                 Teraradioval = $("input[type='radio'][name='Teracheck']:checked").val();   
                                                return args.val()
                                            }

                                            function Siemensread(args) {
                                                val = $("#SiemensComments").val();
                                                Siemensradioval = $("input[type='radio'][name='Siemenscheck']:checked").val();   
                                                return args.val()
                                            }

                                            function GEread(args) {
                                                val = $("#GEComments").val();
                                                GEradioval = $("input[type='radio'][name='GEcheck']:checked").val();   
                                                return args.val()
                                            }

                                            function Cannonread(args) {
                                                val = $("#CannonComments").val();
                                                Cannonradioval = $("input[type='radio'][name='Cannoncheck']:checked").val();   
                                                return args.val()
                                            }

                                            function Agfaread(args) {
                                                val = $("#AgfaComments").val();
                                                Agfaradioval = $("input[type='radio'][name='Agfacheck']:checked").val();   
                                                return args.val()
                                            }
                                        </script>

    <style type="text/css"> 
         .e-grid .e-rowcell{ 
            vertical-align:top; 
        } 

        .redMarker
        {
            background:url("images/redmarker.png") no-repeat;
        }

        .orangeMarker
        {
            background:url("images/orangemarker.png") no-repeat;
        }

        .greenMarker
        {
            background:url("images/greenmarker.png") no-repeat;
        }

        .e-grid .Philips.e-headercell{ 
            background-color:#0b5ed7; 
            color:#fff; 
        } 

        .e-grid .Tera.e-headercell{ 
            background-color:#6291cc; 
            color:#fff; 
        } 

        .e-grid .Siemens.e-headercell{ 
            background-color:#f7931e; 
            color:#fff; 
        } 

        .e-grid .GE.e-headercell{ 
            background-color:#0560ab; 
            color:#fff; 
        } 

        .e-grid .Cannon.e-headercell{ 
            background-color:#c1272d; 
            color:#fff; 
        } 

        .e-grid .Agfa.e-headercell{ 
            background-color:#6e6e6e; 
            color:#fff; 
        } 

</style>   

                                       
                                        
                                            <script id="PhilipsHeader" type="text/x-jsrender">
                                               <span style="background: #0b5ed7;color: #fff;text-align: center;font-weight: normal;font-size: 13px;display:  block; ">Philips</span>                                               
                                            </script>

                                            <script id="TeraHeader" type="text/x-jsrender">
                                               <span style="background: #6291cc;color: #fff;text-align: center;font-weight: normal;font-size: 13px;display:  block; ">TeraRecon</span>
                                            </script>

                                        <script id="SiemensHeader" type="text/x-jsrender">
                                                <span style="background: #f7931e;color: #fff;border-bottom: none;text-align: center;font-weight: normal;font-size: 13px;white-space: nowrap;display:block; ">Siemens Medical</span>
                                            </script>

                                        <script id="GEHeader" type="text/x-jsrender">
                                                <span style="background: #0560ab;color: #fff;border-bottom: none;text-align: center;font-weight: normal;font-size: 13px;white-space: nowrap;display:  block;">GE Healthcare</span>
                                            </script>

                                         <script id="Cannon" type="text/x-jsrender">
                                                <span style="background: #c1272d;color: #fff;border-bottom: none;text-align: center;font-weight: normal;font-size: 13px;white-space: nowrap;;display:  block;">Canon/Toshiba/Vital</span>
                                            </script>

                                         <script id="Agfa" type="text/x-jsrender">
                                                <span style="background: #6e6e6e;color: #fff;border-bottom: none;text-align: center;font-weight: normal;font-size: 13px;white-space: nowrap;display:  block;">Agfa Healthcare</span>
                                            </script>
                                        


                                        



										
									</div>
									
									</div>
																
									<div class="bottom-tab">
                                        <ul class="wros">
                                            <li class="col"><b>Legend:</b></li>
                                            <li class="col">
                                                                                                
                                                <div class="">                                                   
                                                    <label for="chkGreenFilter">
                                                        <img src="images/redmarker.png" />
                                                        <b>Better than Philips</b> 
                                                    </label>
                                                </div>

                                            </li>
                                            <li class="col">

                                                 <div class="">        
                                                    
                                                    <label for="chkYellowFilter">
                                                        <img src="images/greenmarker.png" />
                                                        <b>Worse than Philips</b>
                                                    </label>
                                                </div>
                                            </li>
                                            <li class="col">

                                                <div class="">        
                                                  
                                                    <label for="chkOrangeFilter">
                                                        <img src="images/orangemarker.png" />
                                                        <b>50/50 with Philips</b>
                                                    </label>
                                                </div>
                                            </li>
                                            
                                           
                                        </ul>
                                    </div>

								</div>
								
							</div>
						</div> 	
				</div>
			</div>
		</div>
	</div>
	
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

          </form>


    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>
	
	
	

  </body>
</html>