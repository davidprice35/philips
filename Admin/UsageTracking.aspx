<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UsageTracking.aspx.cs" Inherits="Admin_UsageTracking" %>

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
	<link href="css/style.css" rel="stylesheet">
	<link href="css/responsive.css" rel="stylesheet">
	<link rel="stylesheet" href="../css/font-awesome.min.css">
	<link rel="stylesheet" href="../css/jquery.mCustomScrollbar.min.css">

    <script src='<%= Page.ResolveClientUrl("~/js/ej/jquery-1.11.3.min.js")%>' type="text/javascript"></script>
    <script src='<%= Page.ResolveClientUrl("~/js/ej/jsrender.min.js")%>' type="text/javascript"></script>
    <script src='<%= Page.ResolveClientUrl("~/js/ej/ej.web.all.min.js")%>' type="text/javascript"></script>
    <script src='<%= Page.ResolveClientUrl("~/js/ej/ej.webform.min.js")%>' type="text/javascript"></script>


    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
  </head>
  <body>
  <div class="top-tabs-link">
	<div class="nav nav-pills">
<li class="col-sm-2 col-xs-2 width"><a href="#"></a></li>
		<li class="col-sm-2 col-xs-2 width"><a href="#"></a></li>
		<li class="col-sm-2 col-xs-2 width"><a href="/MV-Matrix/">MV MATRIX</a></li>
		<li class="col-sm-2 col-xs-2 width"><a href="#"></a></li>
		<li class="col-sm-2 col-xs-2 width"><a href="#"></a></li>
		<li class="col-sm-2 col-xs-2 width"><a href="../competitive-info/Competitors.aspx">COMPETITIVE INFO</a></li>
		
  
  </div>
  </div>

       <form id="form1" runat="server">
		<div class="main-section">			
			<div class="container">
				<div class="row">
						<div class="top-header">
						<div class="col-sm-12 col-xs-12 col-md-2 col-lg-2">
							<img src="/images/logo.png"class="img-responsive">
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

                                        <li><a href="/">MV Search</a></li>
										<li class="submenubar"><a href="/">Admin</a>
											<ul class="dropdown-menu">												
												<li><a href="/admin/EditGridData">Edit Data</a></li> 
												<li><a href="/admin/PendingUpdates">Pending Changes</a></li>												
											</ul>
										
										</li>					
                                        


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
																<p><%=m_UserName %></p>
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
			
			
			
				<div class="body-section-design">					
					<div class="col-sm-3 col-lg-2 col-md-3 left-padding"> 
						<div class="left-sidebar camparision-section">
							<div class="white-area-box-left">
							   <div class="total-box checkbox-body-part">
							      <ul>
								     <li>
									    <div class="checkbox checkbox-primary">
										  <input id="Total" type="checkbox" checked="">
										  <label for="Total">Total</label>
										</div>
									</li>
									<li>
									    <div class="checkbox checkbox-primary">
										  <input id="Visitor" type="checkbox" checked="">
										  <label for="Visitor">Visitor time</label>
										</div>
									</li>
									<li>
									    <div class="checkbox checkbox-primary">
										  <input id="Department" type="checkbox" checked="">
										  <label for="Department">Department</label>
										</div>
									</li>
									<li>
									    <div class="checkbox checkbox-primary">
										  <input id="Location" type="checkbox" checked="">
										  <label for="Location">Location</label>
										</div>
									</li>
									<li>
									    <div class="checkbox checkbox-primary">
										  <input id="Exit" type="checkbox" checked="">
										  <label for="Exit">Exit page</label>
										</div>
									</li>

								  </ul>
							   </div>
							</div>
						</div>
					</div>
						<div class="col-sm-9 col-lg-10 col-md-9 right-padding competitors-right">
							<div class="rightbar total-box-30">
								<div class="white-area-box">
								   <div class="total-section-top" id="TotalID">
								      <div class="total-border-bm">
									     <div class="row">
										     <div class="col-xs-12 col-sm-4 col-md-4 col-lg-4 total-title">
												<h4>Total</h4>
											 </div>
											 <div class="col-xs-12 col-sm-8 col-md-8 col-lg-8 date-block">
												<div class="date-section">
												   <ul class="list-inline text-right"> 
													  <li class="date-list">
														  <span class="datePicker"><i class="fa fa-calendar"></i> <strong>From</strong> <asp:TextBox ID="datepickerFrom" Width="86px" Text="" runat="server"></asp:TextBox></span>
                                                          <input type="hidden" id="my_hidden_input_from">
													  </li>
													  <li class="date-list">
														  <span class="datePicker"><i class="fa fa-calendar"></i> <strong>To</strong> <asp:TextBox ID="datepickerTo" Width="86px" Text="" runat="server"></asp:TextBox> </span>
													  </li>

                                                       <asp:LinkButton ID="cmdSearch" runat="server" OnClick="cmdSearch_Click">Search</asp:LinkButton>

												   </ul>
												</div>
											 </div>
										 </div>
									  </div>
									  
									  <div class="total-table-grid">
									     <div class="table-responsive">
										    <table width="100%" border="1" bordercolor="#ccc">
												<thead>
												   <tr>
													  <th class="white-th"></th>
													  <th>ALL</th>
													  <th>MV Matrix</th>
													  <th>Competitors</th>
													  <th>Clinical</th>
													  <th>Enterprise</th>
                                                       <th>Services</th>
													  <th>Attachments</th>
												   </tr>
												</thead>
												<tbody>
												   <tr>
												      <td>Total Visits</td>
													  <td><%=m_TotalVisits %></td>
													  <td><%=m_TotalMVMatrix %></td>
													  <td><%=m_TotalCompetitors %></td>
													  <td><%=m_TotalClinical %></td>
													  <td><%=m_TotalEnterprise %></td>
                                                       <td><%=m_TotalServices %></td>
													  <td><%=m_TotalAttachments %></td>
												   </tr>
												   <%--<tr>
												      <td>Total Unique Visits</td>
													  <td><%=m_TotalUniqueVisits %></td>
													  <td><%=m_TotalUniqueMVMatrix %></td>
													  <td><%=m_TotalUniqueCompetitors %></td>
													  <td><%=m_TotalUniqueClinical %></td>
													  <td><%=m_TotalUniqueEnterprise %></td>
                                                       <td><%=m_TotalUniqueServices %></td>
													  <td><%=m_TotalUniqueAttachments %></td>
												   </tr>--%>
												<%--   <tr>
												      <td>Average length of session</td>
													  <td></td>
													  <td></td>
													  <td></td>
													  <td></td>
													  <td></td>
                                                       <td></td>
													  <td></td>
												   </tr>
												   <tr>
												      <td>% new visitors</td>
													  <td></td>
													  <td></td>
													  <td></td>
													  <td></td>
                                                       <td></td>
													  <td></td>
													  <td></td>
												   </tr>--%>
												 <%--  <tr>
												      <td>Bounce rate</td>
													  <td></td>
													  <td></td>
													  <td></td>
													  <td></td>
                                                       <td></td>
													  <td></td>
													  <td></td>
												   </tr>
												   <tr>
												      <td><strong>Total time</strong></td>
													  <td></td>
													  <td></td>
													  <td></td>
                                                       <td></td>
													  <td></td>
													  <td></td>
													  <td></td>
												   </tr>--%>
												</tbody>
											 </table>
										 </div>
									  </div>
									  
								   </div>
								   
								   <div class="total-section-top" id="VisitorID">
								      <div class="total-border-bm">
									     <div class="row">
										     <div class="col-xs-12 col-sm-4 col-md-4 col-lg-4 total-title">
												<h4>Visitor time</h4>
											 </div>
											<%-- <div class="col-xs-12 col-sm-8 col-md-8 col-lg-8 date-block">
												<div class="date-section">
												   <ul class="list-inline text-right"> 
													  <li class="date-list">
														  <span class="datePicker"><i class="fa fa-calendar"></i> <strong>From</strong> 25th July, 2018</span>
													  </li>
													  <li class="date-list">
														  <span class="datePicker"><i class="fa fa-calendar"></i> <strong>To</strong> 25th July, 2018</span>
													  </li>
												   </ul>
												</div>
											 </div>--%>
										 </div>
									  </div>
									  
									  <div class="total-table-grid">
									     <div class="table-responsive">
										    <table width="100%" border="1" bordercolor="#ccc">
												<thead>
												   <tr>
													  <th class="white-th"></th>
													  <th>ALL</th>
													  <th>MV Matrix</th>
													  <th>Competitors</th>
													  <th>Clinical</th>
													  <th>Enterprise</th>
                                                       <th>Services</th>
													  <th>Attachments</th>
												   </tr>
												</thead>
												<tbody>
												   <%=GetVistitorTime() %>
												   

												   <%--<tr>
												      <td><strong>Total time</strong></td>
													  <td></td>
													  <td></td>
													  <td></td>
													  <td></td>
													  <td></td>
													  <td></td>
												   </tr>--%>
												</tbody>
											 </table>
										 </div>
									  </div>
								   </div>
								   
								   <div class="total-section-top" id="DepartmentID">
								      <div class="total-border-bm">
									     <div class="row">
										     <div class="col-xs-12 col-sm-4 col-md-4 col-lg-4 total-title">
												<h4>Department</h4>
											 </div>
											<%-- <div class="col-xs-12 col-sm-8 col-md-8 col-lg-8 date-block">
												<div class="date-section">
												   <ul class="list-inline text-right"> 
													  <li class="date-list">
														  <span class="datePicker"><i class="fa fa-calendar"></i> <strong>From</strong> 25th July, 2018</span>
													  </li>
													  <li class="date-list">
														  <span class="datePicker"><i class="fa fa-calendar"></i> <strong>To</strong> 25th July, 2018</span>
													  </li>
												   </ul>
												</div>
											 </div>--%>
										 </div>
									  </div>
									  
									  <div class="total-table-grid">
									     <div class="table-responsive">
										    <table width="100%" border="1" bordercolor="#ccc">
												<thead>
												   <tr>
													  <th class="white-th"></th>
													  <th>ALL</th>
													  <th>MV Matrix</th>
													  <th>Competitors</th>
													  <th>Clinical</th>
													  <th>Enterprise</th>
                                                      <th>Services</th>
													  <th>Attachments</th>
												   </tr>
												</thead>
												<tbody>
												   <%=GetDepartmentTime() %>
												</tbody>
											 </table>
										 </div>
									  </div>
								   </div>
								   
								   <div class="total-section-top" id="LocationID">
								      <div class="total-border-bm">
									     <div class="row">
										     <div class="col-xs-12 col-sm-4 col-md-4 col-lg-4 total-title">
												<h4>Location</h4>
											 </div>
											 <%--<div class="col-xs-12 col-sm-8 col-md-8 col-lg-8 date-block">
												<div class="date-section">
												   <ul class="list-inline text-right"> 
													  <li class="date-list">
														  <span class="datePicker"><i class="fa fa-calendar"></i> <strong>From</strong> 25th July, 2018</span>
													  </li>
													  <li class="date-list">
														  <span class="datePicker"><i class="fa fa-calendar"></i> <strong>To</strong> 25th July, 2018</span>
													  </li>
												   </ul>
												</div>
											 </div>--%>
										 </div>
									  </div>
									  
									  <div class="total-table-grid">
									     <div class="table-responsive">
										    <table width="100%" border="1" bordercolor="#ccc">
												<thead>
												   <tr>
													  <th class="white-th"></th>
													  <th>ALL</th>
													  <th>MV Matrix</th>
													  <th>Competitors</th>
													  <th>Clinical</th>
													  <th>Enterprise</th>
                                                      <th>Services</th>
													  <th>Attachments</th>
												   </tr>
												</thead>
												<tbody>
												  <%=GetLocationTime() %>
												</tbody>
											 </table>
										 </div>
									  </div>
								   </div>
								   
								   <%--<div class="total-section-top" id="ExitID">
								      <div class="total-border-bm">
									     <div class="row">
										     <div class="col-xs-12 col-sm-4 col-md-4 col-lg-4 total-title">
												<h4>Exit Page</h4>
											 </div>
											 <div class="col-xs-12 col-sm-8 col-md-8 col-lg-8 date-block">
												<div class="date-section">
												   <ul class="list-inline text-right"> 
													  <li class="date-list">
														  <span class="datePicker"><i class="fa fa-calendar"></i> <strong>From</strong> 25th July, 2018</span>
													  </li>
													  <li class="date-list">
														  <span class="datePicker"><i class="fa fa-calendar"></i> <strong>To</strong> 25th July, 2018</span>
													  </li>
												   </ul>
												</div>
											 </div>
										 </div>
									  </div>
									  
									  <div class="total-table-grid">
									     <div class="table-responsive">
										    <table width="100%" border="1" bordercolor="#ccc">
												<thead>
												   <tr>
													  <th class="white-th"></th>
													  <th>ALL</th>
													  <th>MV Matrix</th>
													  <th>Competitors</th>
													  <th>Clinical</th>
													  <th>Enterprise</th>
													  <th>Attachments</th>
												   </tr>
												</thead>
												<tbody>
												   <tr>
												      <td>MV Matrix</td>
													  <td></td>
													  <td></td>
													  <td></td>
													  <td></td>
													  <td></td>
													  <td></td>
												   </tr>
												   <tr>
												      <td>Clinical</td>
													  <td></td>
													  <td></td>
													  <td></td>
													  <td></td>
													  <td></td>
													  <td></td>
												   </tr>
												   <tr>
												      <td>Enterprise</td>
													  <td></td>
													  <td></td>
													  <td></td>
													  <td></td>
													  <td></td>
													  <td></td>
												   </tr>
												   <tr>
												      <td>Attachments</td>
													  <td></td>
													  <td></td>
													  <td></td>
													  <td></td>
													  <td></td>
													  <td></td>
												   </tr>
												</tbody>
											 </table>
										 </div>
									  </div>
								   </div>--%>
								   
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
				<img src="/images/footer-logo.png"class="img-responsive">
				<h5><span>Privacy notice  |  Terms of use</span>
				<br>
© Koninklijke Philips N.V., 2004 - 2019. All rights reserved. </h5>
			</div>
		</div>
	</footer>

    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->

    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="../js/bootstrap.min.js"></script>
	<script src="../js/bootstrap-datepicker.js"></script>
	
	<script>
		$(document).ready(function() {


            $('.datePicker')
                .datepicker({
                    format: 'dd/mm/yyyy',
                    autoclose: true,
                    todayHighlight: true,
                    todayBtn: true
           })
                .on('changeDate', function (e) {

                    $( "#datepicker" ).datepicker( "option", "dateFormat", $( this ).val() );

               //$('#my_hidden_input_from').val(
               //     $('#datepicker').datepicker('getFormattedDate')
               // );


            });






		 

//    $('#eventForm').formValidation({
//        framework: 'bootstrap',
//        icon: {
//            valid: 'glyphicon glyphicon-ok',
//            invalid: 'glyphicon glyphicon-remove',
//            validating: 'glyphicon glyphicon-refresh'
//        },
//        fields: {
//            name: {
//                validators: {
//                    notEmpty: {
//                        message: 'The name is required'
//                    }
//                }
//            },
//            date: {
//                validators: {
//                    notEmpty: {
//                        message: 'The date is required'
//                    },
//                    date: {
//                        format: 'MM/DD/YYYY',
//                        message: 'The date is not a valid'
//                    }
//                }
//            }
//        }
//    });
});

$("#TotalID").show();
$(".total-box ul li input#Total").click(function() {
    if($(this).is(":checked")) {
        $("#TotalID").show();
    } else {
        $("#TotalID").hide();
    }
});

$("#VisitorID").show();
$(".total-box ul li input#Visitor").click(function() {
    if($(this).is(":checked")) {
        $("#VisitorID").show();
    } else {
        $("#VisitorID").hide();
    }
});

$("#DepartmentID").show();
$(".total-box ul li input#Department").click(function() {
    if($(this).is(":checked")) {
        $("#DepartmentID").show();
    } else {
        $("#DepartmentID").hide();
    }
});

$("#LocationID").show();
$(".total-box ul li input#Location").click(function() {
    if($(this).is(":checked")) {
        $("#LocationID").show();
    } else {
        $("#LocationID").hide();
    }
});

$("#ExitID").show();
$(".total-box ul li input#Exit").click(function() {
    if($(this).is(":checked")) {
        $("#ExitID").show();
    } else {
        $("#ExitID").hide();
    }
});


	</script>
  </body>
</html>

