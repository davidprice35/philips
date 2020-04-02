<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserProfile.aspx.cs" Inherits="Admin_UserProfile" %>

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
		<li class="col-sm-2 col-xs-2 width"><a href="/MV-Matrix/">MV MATRIX</a></li>
        <li class="col-sm-2 col-xs-2 width"><a href="../competitive-info/Competitors.aspx">COMPETITIVE INFO</a></li>
		<li class="col-sm-2 col-xs-2 width"><a href="#"></a></li>
		<li class="col-sm-2 col-xs-2 width"><a href="#"></a></li>
		
		<li class="col-sm-2 col-xs-2 width"><a href="#"></a></li>
  
  </div>
  </div>


      <form id="form1" runat="server">
		<div class="main-section">			
			<div class="container">
				<div class="row">
						<div class="top-header">
						<div class="col-sm-12 col-xs-12 col-md-2 col-lg-2">
                            <a href="../MV-Matrix.aspx">
							    <img src="/images/logo.png"class="img-responsive">
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
									<%--<ul class="nav navbar-nav navbar-left">

                                        <li><a href="/">MV Search</a></li>
										<li class="submenubar"><a href="/">Admin</a>
											<ul class="dropdown-menu">												
												<li><a href="/admin/EditGridData">Edit Data</a></li> 
												<li><a href="/admin/PendingUpdates">Pending Changes</a></li>												
											</ul>
										
										</li>					
                                        


									</ul>--%>
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
														
                                                       <script>

                                                                function Myclick()
                                                                {                                                                   
                                                                    window.location.replace("/Account/Signin?Type=LogOut");
                                                                }

                                                            </script>

														<div class="view_box">
															<%=ShowProfileMenu() %>
                                                            

                                                           
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
			
			
			
				
			</div>
		</div>
	</div>
	

	<div class="body-section-design">					
		<div class="userprofile-section">
		   <div class="container">
		       <div class="row">
			       <div class="user-profiles">
				      <div class="col-xs-12 col-sm-4 col-md-4 col-lg-4 total-title">
						 <h4>User Profiles</h4>
					  </div>
					  <div class="col-xs-12 col-sm-8 col-md-8 col-lg-8 add-section-block">
						 <div class="add-section">
							<ul class="list-inline text-right"> 
							   <li><asp:LinkButton ID="cmdAdd"  OnClick="cmdAdd_Click" runat="server"><i class="fa fa-plus"></i> Add</asp:LinkButton></li>
							   <li><asp:LinkButton ID="cmdSave"  OnClick="cmdSave_Click" runat="server"><i class="fa fa-save"></i> Save</asp:LinkButton></li>
							   <li><i class="fa fa-trash"></i><asp:LinkButton ID="cmdDeleteItems" OnClick="cmdDeleteItems_Click"   runat="server">Delete</asp:LinkButton></li>
							</ul>
						 </div>
					  </div>

				   </div>
			      <div class="profile-grid">
				     <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12 profile-grid-table">
					     <div class="table-grid-userprofile">
						    <table width="100%" border="1" bordercolor="#ccc">
							   <thead>
							     <tr>
								     <th></th>
                                     <th>Grant Access</th>
									 <th>User Name</th>
									 <th style="width:125px;">Name</th>
									 <th>Email address</th>
									 <th>Department</th>
									 <th>Location/Region</th>
									 <th>MV Matrix</th>
									 <th>Competitors</th>
                                     <th>Clinical</th>
                                     <th>Enterprise</th>
									 <th>Services</th>
                                     <th>Attachments</th>
                                     <th>Approved By</th>
								  </tr>
							   </thead>
							   <tbody>


                                <asp:Panel ID="PanelNewRow" Visible="false" runat="server">   
                                    <tr>
								    
                                        <td class="white-td">
									   
									    </td>
									

                                        <td><asp:DropDownList ID="cboGrantAccess1" runat="server">
                                                  
                                                  <asp:ListItem>No Access</asp:ListItem>
                                                  <asp:ListItem>Granted Access</asp:ListItem>
                                                 <asp:ListItem>Pending</asp:ListItem>
                                                 
                                                  

                                              </asp:DropDownList></td>
                                    <td> <asp:TextBox ID="txtUserName1" runat="server"></asp:TextBox></td>
									<td>
                                        <asp:TextBox ID="txtName1"  Width="125px" runat="server"></asp:TextBox></td>
									<td>
                                        <asp:TextBox ID="txtEmail1" runat="server"></asp:TextBox></td>
									<td>
                                        <asp:TextBox ID="txtDepartment1" runat="server"></asp:TextBox></td>
									<td ><asp:TextBox ID="txtLocation1" runat="server"></asp:TextBox></td>




									<td class="white-td">
									   <div class="content-admin">
									      <div class="dropdown">
											 

                                              <asp:DropDownList ID="cmdMVMatrix1" runat="server">
                                                  <asp:ListItem>Super Admin</asp:ListItem>
                                                  <asp:ListItem>Super Viewer</asp:ListItem>
                                                  <asp:ListItem>Content Admin</asp:ListItem>
                                                  <asp:ListItem>Editor</asp:ListItem>
                                                  <asp:ListItem>Viewer</asp:ListItem>
                                                  <asp:ListItem Selected="True">None</asp:ListItem>

                                              </asp:DropDownList>

											 
											</div>
									   </div>
									</td>
									<td  class="white-td">
									   <div class="content-admin">
									      <div class="dropdown">
                                              <asp:DropDownList ID="cmdCompetitors1" runat="server">
                                                  <asp:ListItem>Super Admin</asp:ListItem>
                                                  <asp:ListItem>Super Viewer</asp:ListItem>
                                                  <asp:ListItem>Content Admin</asp:ListItem>
                                                  <asp:ListItem>Editor</asp:ListItem>
                                                  <asp:ListItem>Viewer</asp:ListItem>
                                                  <asp:ListItem Selected="True">None</asp:ListItem>

                                              </asp:DropDownList>											
											</div>
									   </div>
									</td>
									<td   class="white-td">
									   <div class="content-admin">
									      <div class="dropdown">											 
                                              <asp:DropDownList ID="cmdClinical1" runat="server">
                                                  <asp:ListItem>Super Admin</asp:ListItem>
                                                  <asp:ListItem>Super Viewer</asp:ListItem>
                                                  <asp:ListItem>Content Admin</asp:ListItem>
                                                  <asp:ListItem>Editor</asp:ListItem>
                                                  <asp:ListItem>Viewer</asp:ListItem>
                                                  <asp:ListItem Selected="True">None</asp:ListItem>
                                              </asp:DropDownList>
											</div>
									   </div>
									</td>
                                                <td class="white-td">
									   <div class="content-admin">
									      <div class="dropdown">
											 

                                              <asp:DropDownList ID="cmdEnterprise1" runat="server">
                                                  <asp:ListItem>Super Admin</asp:ListItem>
                                                  <asp:ListItem>Super Viewer</asp:ListItem>
                                                  <asp:ListItem>Content Admin</asp:ListItem>
                                                  <asp:ListItem>Editor</asp:ListItem>
                                                  <asp:ListItem>Viewer</asp:ListItem>
                                                  <asp:ListItem Selected="True">None</asp:ListItem>

                                              </asp:DropDownList>

											 
											</div>
									   </div>
									</td>
                                                <td class="white-td">
									   <div class="content-admin">
									      <div class="dropdown">
											 

                                              <asp:DropDownList ID="cmdServices1" runat="server">
                                                  <asp:ListItem>Super Admin</asp:ListItem>
                                                  <asp:ListItem>Super Viewer</asp:ListItem>
                                                  <asp:ListItem>Content Admin</asp:ListItem>
                                                  <asp:ListItem>Editor</asp:ListItem>
                                                  <asp:ListItem>Viewer</asp:ListItem>
                                                  <asp:ListItem Selected="True">None</asp:ListItem>

                                              </asp:DropDownList>

											 
											</div>
									   </div>
									</td>
                                                <td class="white-td">
									   <div class="content-admin">
									      <div class="dropdown">
											 

                                              <asp:DropDownList ID="cmdAttachments1" runat="server">
                                                  <asp:ListItem>Super Admin</asp:ListItem>
                                                  <asp:ListItem>Super Viewer</asp:ListItem>
                                                  <asp:ListItem>Content Admin</asp:ListItem>
                                                  <asp:ListItem>Editor</asp:ListItem>
                                                  <asp:ListItem>Viewer</asp:ListItem>
                                                  <asp:ListItem Selected="True">None</asp:ListItem>

                                              </asp:DropDownList>

											 
											</div>
									   </div>
									</td>
								  </tr>
                                </asp:Panel>


                                <asp:Repeater ID="repDataGrid" runat="server" OnItemDataBound="repDataGrid_ItemDataBound" >                                                                                        
                                    <ItemTemplate>
                                        <asp:HiddenField ID="HF_DataID" runat="server" />
							             
                                            <tr>
								    <td class="white-td">
									   <div class="checkbox-body-part">
									      <ul><li><asp:CheckBox ID="cboSelect" OnClick="CountDeleteItems(this.checked);" runat="server" />
											    <div class="checkbox checkbox-primary"></div>
											 </li>
										  </ul>
									   </div>
									</td>
									
                                                 <td> 

                                             <asp:DropDownList ID="cboGrantAccess" runat="server">
                                                  
                                                  <asp:ListItem>No Access</asp:ListItem>
                                                  <asp:ListItem>Granted Access</asp:ListItem>
                                                 <asp:ListItem>Pending</asp:ListItem>
                                                 
                                                  

                                              </asp:DropDownList>

                                                 </td>

                                    <td> <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></td>
									<td>
                                        <asp:TextBox ID="txtName" Width="125px" runat="server"></asp:TextBox></td>
									<td>
                                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
									<td>
                                        <asp:TextBox ID="txtDepartment" runat="server"></asp:TextBox></td>
									<td ><asp:TextBox ID="txtLocation" runat="server"></asp:TextBox></td>




									<td class="white-td">
									   <div class="content-admin">
									      <div class="dropdown">
											 

                                              <asp:DropDownList ID="cmdMVMatrix" runat="server">
                                                  <asp:ListItem>Super Admin</asp:ListItem>
                                                  <asp:ListItem>Super Viewer</asp:ListItem>
                                                  <asp:ListItem>Content Admin</asp:ListItem>
                                                  <asp:ListItem>Editor</asp:ListItem>
                                                  <asp:ListItem>Viewer</asp:ListItem>
                                                  <asp:ListItem>None</asp:ListItem>

                                              </asp:DropDownList>

											 
											</div>
									   </div>
									</td>
									<td  class="white-td">
									   <div class="content-admin">
									      <div class="dropdown">
                                              <asp:DropDownList ID="cmdCompetitors" runat="server">
                                                  <asp:ListItem>Super Admin</asp:ListItem>
                                                  <asp:ListItem>Super Viewer</asp:ListItem>
                                                  <asp:ListItem>Content Admin</asp:ListItem>
                                                  <asp:ListItem>Editor</asp:ListItem>
                                                  <asp:ListItem>Viewer</asp:ListItem>
                                                  <asp:ListItem>None</asp:ListItem>

                                              </asp:DropDownList>											
											</div>
									   </div>
									</td>
									<td   class="white-td">
									   <div class="content-admin">
									      <div class="dropdown">											 
                                              <asp:DropDownList ID="cmdClinical" runat="server">
                                                  <asp:ListItem>Super Admin</asp:ListItem>
                                                  <asp:ListItem>Super Viewer</asp:ListItem>
                                                  <asp:ListItem>Content Admin</asp:ListItem>
                                                  <asp:ListItem>Editor</asp:ListItem>
                                                  <asp:ListItem>Viewer</asp:ListItem>
                                                  <asp:ListItem>None</asp:ListItem>
                                              </asp:DropDownList>
											</div>
									   </div>
									</td>
                                                <td class="white-td">
									   <div class="content-admin">
									      <div class="dropdown">
											 

                                              <asp:DropDownList ID="cmdEnterprise" runat="server">
                                                  <asp:ListItem>Super Admin</asp:ListItem>
                                                  <asp:ListItem>Super Viewer</asp:ListItem>
                                                  <asp:ListItem>Content Admin</asp:ListItem>
                                                  <asp:ListItem>Editor</asp:ListItem>
                                                  <asp:ListItem>Viewer</asp:ListItem>
                                                  <asp:ListItem>None</asp:ListItem>

                                              </asp:DropDownList>

											 
											</div>
									   </div>
									</td>
                                                <td class="white-td">
									   <div class="content-admin">
									      <div class="dropdown">
											 

                                              <asp:DropDownList ID="cmdServices" runat="server">
                                                  <asp:ListItem>Super Admin</asp:ListItem>
                                                  <asp:ListItem>Super Viewer</asp:ListItem>
                                                  <asp:ListItem>Content Admin</asp:ListItem>
                                                  <asp:ListItem>Editor</asp:ListItem>
                                                  <asp:ListItem>Viewer</asp:ListItem>
                                                  <asp:ListItem>None</asp:ListItem>

                                              </asp:DropDownList>

											 
											</div>
									   </div>
									</td>
                                                <td class="white-td">
									   <div class="content-admin">
									      <div class="dropdown">
											 

                                              <asp:DropDownList ID="cmdAttachments" runat="server">
                                                  <asp:ListItem>Super Admin</asp:ListItem>
                                                  <asp:ListItem>Super Viewer</asp:ListItem>
                                                  <asp:ListItem>Content Admin</asp:ListItem>
                                                  <asp:ListItem>Editor</asp:ListItem>
                                                  <asp:ListItem>Viewer</asp:ListItem>
                                                  <asp:ListItem>None</asp:ListItem>

                                              </asp:DropDownList>

											 
											</div>
									   </div>
									</td>

                                                <td >
									   
											 

                                              <asp:TextBox ID="txtApprovedBy" Width="125px" Enabled="false" runat="server"></asp:TextBox>

											 
										
									</td>

								  </tr>

                                   </ItemTemplate>
                                </asp:Repeater>


                                    <script>

                                            function CountDeleteItems (MyItem)
                                            {
                                                var Delbutton = document.getElementById("cmdDeleteItems");
                                                var MyDeltest = Delbutton.innerText.replace('Delete ', '');
                                                var MyDeltest = MyDeltest.replace('items', '').trim();
                                                MyDeltest = MyDeltest.replace('item', '').trim();


                                                if (isNaN(MyDeltest))
                                                {
                                                    MyDeltest = 0;
                                                }

                                                if (MyItem == true)
                                                {
                                                    MyDeltest++;
                                                } else
                                                {
                                                    MyDeltest--;
                                                }

                                                if (MyDeltest > 1) {
                                                    document.getElementById("cmdDeleteItems").innerText = 'Delete ' + MyDeltest + ' items';

                                                } else {
                                                    document.getElementById("cmdDeleteItems").innerText = 'Delete ' + MyDeltest + ' item';
                                                }

                                                CountApproveItems(MyItem);
                                            }

                                            function CountApproveItems(MyItem) {
                                                var Delbutton = document.getElementById("cmdApproveItems");
                                                //var Savebutton = document.getElementById("cmdSaveItems");
                                                var MyDeltest = Delbutton.innerText.replace('Approve ', '');
                                                var MyDeltest = MyDeltest.replace('items', '').trim();
                                                MyDeltest = MyDeltest.replace('item', '').trim();


                                                if (isNaN(MyDeltest)) {
                                                    MyDeltest = 0;
                                                }

                                                if (MyItem == true) {
                                                    MyDeltest++;
                                                } else {
                                                    MyDeltest--;
                                                }

                                                if (MyDeltest > 1) {
                                                    document.getElementById("cmdApproveItems").innerText = 'Approve ' + MyDeltest + ' items';
                                                   //  document.getElementById("cmdSaveItems").innerText = 'Save ' + MyDeltest + ' items';

                                                } else {
                                                    document.getElementById("cmdApproveItems").innerText = 'Approve ' + MyDeltest + ' item';
                                                   //  document.getElementById("cmdSaveItems").innerText = 'Save ' + MyDeltest + ' items';
                                                }

                                            }

                                        </script>

							   </tbody>
							</table>
						 </div>
					 </div>
				  </div>
			   </div>
		   </div>
		</div>				
	</div>
	</form>
	
	<footer class="footer blue-backround">
		<div class="container">
			<div class="row">
				<img src="/images/logo-white.png"class="img-responsive">
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
            format: 'mm/dd/yyyy'
        })
        .on('changeDate', function(e) {
            // Revalidate the date field
            $('#eventForm').formValidation('revalidateField', 'date');
        });
		
		 

    //$('#eventForm').formValidation({
    //    framework: 'bootstrap',
    //    icon: {
    //        valid: 'glyphicon glyphicon-ok',
    //        invalid: 'glyphicon glyphicon-remove',
    //        validating: 'glyphicon glyphicon-refresh'
    //    },
    //    fields: {
    //        name: {
    //            validators: {
    //                notEmpty: {
    //                    message: 'The name is required'
    //                }
    //            }
    //        },
    //        date: {
    //            validators: {
    //                notEmpty: {
    //                    message: 'The date is required'
    //                },
    //                date: {
    //                    format: 'MM/DD/YYYY',
    //                    message: 'The date is not a valid'
    //                }
    //            }
    //        }
    //    }
    //});
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