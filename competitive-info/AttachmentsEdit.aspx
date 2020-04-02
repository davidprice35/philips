<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AttachmentsEdit.aspx.cs" Inherits="competitive_info_AttachmentsEdit" %>

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
    <title>Attachments Edit</title>

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
                                        <li><a href="/competitive-info/AttachmentsEdit.aspx">Edit</a></li>
                                        <li><a href="/competitive-info/AttachmentsPendingUpdates.aspx">Approve</a></li>
                                      
                                       

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
                                                            <asp:LinkButton ID="cmdLogout" CssClass="view_prfl" OnClientClick="Myclick();"  runat="server">Log out <span><i class="fa fa-angle-right" aria-hidden="true"></i></span></asp:LinkButton>
															
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
                    


                    <div class="userprofile-section">
		   <div class="container">
		       <div class="row">
			       <div class="user-profiles">
				      <div class="col-xs-12 col-sm-4 col-md-4 col-lg-4 total-title">
						 <h4>Edit Attachments</h4>
					  </div>
					  <div class="col-xs-12 col-sm-8 col-md-8 col-lg-8 add-section-block">
						 <div class="add-section">
							<ul class="list-inline text-right"> 
							   <li>
                                   

                                   <asp:LinkButton ID="cmdAdd" runat="server" OnClick="cmdAdd_Click"><i class="fa fa-plus"></i> <span style="color:black">Add New</span></asp:LinkButton>  

							   </li>
							</ul>
						 </div>
					  </div>

				   </div>
			      <div class="profile-grid">
				     <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12 profile-grid-table">
					     <div class="table-grid-attachments table-responsive">
						    <table width="100%" border="1" bordercolor="#ccc">
							   <thead>
							     <tr style="height: 42px;">
									 <th>Competitor</th>
									 <th>Type</th>
									 <th>Name</th>
                                     <th>Additional Comment</th>
									 <th width="150px" class="text-center">Add/Replace File</th>
									 
									 <th width="180px"></th>
								  </tr>
							   </thead>
							   <tbody>

                                  <asp:Panel ID="PanelNewRow" runat="server">                                                    
							        <tr class="edit-rows">
									<td>
									<div class="content-admin">
									      <div class="dropdown">
											  <asp:DropDownList ID="cboName1" runat="server"></asp:DropDownList>
											</div>
									   </div>
									   
									</td>
									<td>
									    <div class="content-admin">
									      <div class="dropdown">
											  <asp:DropDownList ID="cboType1" runat="server"></asp:DropDownList>
											</div>
									   </div>
									</td>
									<td><asp:TextBox ID="txtFileName1" Width="350" runat="server"></asp:TextBox></td>
                                        <td><asp:TextBox ID="txtComment1" Rows="1" Width="200"  TextMode="SingleLine"  runat="server"></asp:TextBox></td>
									<td align="center">
									   <div class="" style="width:65px;">
                                                <ej:UploadBox ID="Upload1" Height="23px" Width="61px" ClientSideOnSuccess="fileuploadSuccess" ClientSideOnError="fileerror" FileSize="50457280" MultipleFilesSelection="false" CssClass=""  runat="server" SaveUrl="saveFiles.ashx"   RemoveUrl="removeFiles.ashx"></ej:UploadBox>                                          									      
									    </div>
									</td>
									
									<td>
									   <div class="btn-ul-list">
									      <ul class="list-inline">
										    <li>
                                                
                                                <asp:Button ID="cmdSaveNew"  CssClass="btn-xs btn-primary" runat="server"  OnClick="cmdSaveNew_Click"  Text="Save" />

										    </li>
											<li>
                                                
                                                <asp:Button ID="cmdCancel" CssClass="btn-xs btn-primary" runat="server"  OnClick="cmdCancel_Click" Text="Cancel" />

											</li>
										  </ul>
									   </div>
									</td>
								  </tr>
								  </asp:Panel>
                                   
                                    <asp:Repeater ID="repDataGrid" runat="server"  OnItemCommand="repDataGrid_ItemCommand" OnItemDataBound="repDataGrid_ItemDataBound">                                                                                        
                                        <ItemTemplate>

                                            <asp:HiddenField ID="HF_ID" runat="server" />

                                             <tr>
									            <td>
									            <div class="content-admin">
									                  <div class="dropdown">
											             <asp:DropDownList ID="cboName" runat="server"></asp:DropDownList>
											            </div>
									               </div>
									   
									            </td>
									            <td>
									                <div class="content-admin">
									                  <div class="dropdown">
											              <asp:DropDownList ID="cboType" runat="server"></asp:DropDownList>
											            </div>
									               </div>
									            </td>
									            <td> <asp:TextBox ID="txtFileName" Width="350" runat="server"></asp:TextBox> </td>
									            <td><asp:TextBox ID="txtComment" Rows="1" Width="200"  TextMode="SingleLine"  runat="server"></asp:TextBox></td>
                                                 <td align="center">
									               <div class="" style="width:65px;">
                                                       <ej:UploadBox ID="Upload1" Height="23px" Width="61px" ClientSideOnSuccess="fileuploadSuccess" MultipleFilesSelection="false" CssClass=""  runat="server" SaveUrl="saveFiles.ashx"  RemoveUrl="removeFiles.ashx"></ej:UploadBox>                                          									      
									               </div>
									            </td>
									            
									            <td>
									               <div class="btn-ul-list">
									                  <ul class="list-inline">
										                <li>
                                                            
                                                            <asp:LinkButton ID="cmdSave" CommandName="Save"  runat="server" ><i class="fa fa-pencil-square-o"></i> <span style="color:black;">Save</span></asp:LinkButton>

										                </li>
											            <li>
                                                            
                                                            <asp:LinkButton ID="cmdDelete" CommandName="DeleteFile" CssClass="confirmation-callback"   runat="server" ><i class="fa fa-trash"></i> <span style="color:black;">Delete</span> </asp:LinkButton>

											            </li>
										              </ul>
									               </div>
									            </td>
								              </tr>
								        </ItemTemplate>
                                    </asp:Repeater> 

							   </tbody>
							</table>
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




<footer class="footer blue-backround">
		<div class="container">
			<div class="row">
				<img src="images/white-logo.png"class="img-responsive">
				<h5><span>Privacy notice  |  Terms of use</span>
				<br>
© Koninklijke Philips N.V., 2004 - 2019. All rights reserved. </h5>
			</div>
		</div>
	</footer>
        <script src="/js/bootstrap.min.js"></script>
    	<script src="/js/bootstrap-confirmation.min.js"></script>
	
	 <script>

         function fileerror(e) {
             alert(e.error);
         }


         function fileuploadSuccess(e) {
            //jQuery.addEventLog("Upload of " + e.files.name + " is <span class='eventTitle'> success </span>.");
            // debugger;
            var myID = e.model.clientId;
            myID = myID.replace("repDataGrid_Upload1_", "");

             if (myID != "Upload1") {
                 var input = document.getElementById("repDataGrid_txtFileName_" + myID);
                 input.defaultValue = e.files.name;
                 document.getElementById("repDataGrid_cmdSave_" + myID).click();
             } else {

                 var input = document.getElementById(myID);                 
                 input.defaultValue = e.files.name;

                 document.getElementById("cmdSaveNew").click();
                                                                             
             }
                
         }


    $(function() {
        $('body').confirmation({
            selector: '[data-toggle="confirmation"]'
        });

        $('.confirmation-callback').confirmation({
            onConfirm: function (event, element) {
                //debugger;

                var MyID = element.context.id;

                MyID = MyID.replace("repDataGrid_cmdDelete_", "") + MyID;

                //alert(MyID)

                document.getElementById(MyID).click();
                //repDataGrid_cmdDelete_0


            },
            onCancel: function (event, element) { //alert('No') 
            }
        });
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


            

</body>
     
</html>
