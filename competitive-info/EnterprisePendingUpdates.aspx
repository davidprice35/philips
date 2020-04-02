<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EnterprisePendingUpdates.aspx.cs" Inherits="Admin_EditGridData" ValidateRequest="false" %>

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
    <title>Pending Update</title>

    <!-- Bootstrap -->
    <link href="../css/bootstrap.min.css" rel="stylesheet">
	<link href="../css/style.css" rel="stylesheet">
	<link href="../css/responsive.css" rel="stylesheet">
	<link rel="stylesheet" href="../css/font-awesome.min.css">
	<link rel="stylesheet" href="../css/jquery.mCustomScrollbar.min.css">
    

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>ISP
      <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->


        <link href="https://cdn.syncfusion.com/16.1.0.37/js/web/flat-azure/ej.web.all.min.css" rel="stylesheet" />
        <script src='<%= Page.ResolveClientUrl("~/js/ej/jquery-1.11.3.min.js")%>' type="text/javascript"></script>
        <script src='<%= Page.ResolveClientUrl("~/js/ej/jsrender.min.js")%>' type="text/javascript"></script>
        <script src='<%= Page.ResolveClientUrl("~/js/ej/ej.web.all.min.js")%>' type="text/javascript"></script>
        <script src='<%= Page.ResolveClientUrl("~/js/ej/ej.webform.min.js")%>' type="text/javascript"></script>

      <style>

          .multi-vendor-title .e-treegrid .e-table th, .multi-vendor-title .e-treegrid .e-table td {
    min-width: 150px;
    white-space: normal;
}


          ul.list-inline.sortt select option {
    color: #333;
}

      </style>


  </head>
  <body>
      



      <form id="form1" runat="server">
         
            <div class="top-tabs-link">
	<div class="nav nav-pills">
		<li class="col-sm-2 col-xs-2 width"><a href="#"></a></li>
		<li class="col-sm-2 col-xs-2 width"><a href="/MV-Matrix.aspx">MV MATRIX</a></li>
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
                            <a href="../">
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
										
                                        <%=ShowMenu() %>      
										
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
					<div class="col-lg-3 col-md-3 col-sm-3 left-padding"> 
						
					</div>

                    <asp:Panel ID="panFeedBack" runat="server">
                        <div class="col-lg-9 col-md-9 col-sm-9 right-padding">
                            <div class="alert alert-success">
                              <strong>Error!</strong> <asp:Label ID="lblFeedBack" runat="server" Text=""></asp:Label>
                            </div>
                        </div>
                    </asp:Panel>
                    


						<div class="col-lg-9 col-md-9 col-sm-9 right-padding">
							<div class="rightbar">
								<ul class="nav nav-tabs">
									  <li class="active"><a data-toggle="tab" href="#home">Enterprise</a></li>
									  
								</ul>

								<div class="tab-content pending-changes" >
									<div id="home" class="tab-pane fade in active">
										<div  class="multi-vendor-title">
										   <h3>Pending Changes</h3>
										</div>
										
										<div  class="sortby-section">
											<ul class="list-inline sortt">
												<li class="sort-date">
													<p>sort by</p>
                                                    <asp:DropDownList  ID="cmdSortList"  runat="server">
                                                        <asp:ListItem>Date</asp:ListItem>
                                                        <asp:ListItem>Author</asp:ListItem>
                                                    </asp:DropDownList>
													
												</li>
												<li class="sort-date">
                                                    
                                                    
                                                    <asp:LinkButton ID="cmdShowDelete" Style="background: red;" CssClass="btn approved red-color" data-toggle="modal" data-target="#DeleteModal"  runat="server"></asp:LinkButton>

                                                    <div style="display:none;">
                                                        <asp:LinkButton ID="cmdDeleteItems" Style="background: red;" CssClass="btn approved red-color" OnClick="cmdDeleteItems_Click" runat="server"></asp:LinkButton>                                                    
                                                    </div>

												</li>
												<li class="sort-date">
                                                    
                                                    <asp:LinkButton ID="cmdApproveItems"  Style="background: green;" CssClass="btn approved green-color" OnClick="cmdApproveItems_Click" runat="server"></asp:LinkButton>  


												</li>
                                                <li class="sort-date">                                                    
                                                    <asp:LinkButton ID="cmdSaveItems"  Style="background: #178bc6;" CssClass="btn approved green-color" Text="Save" runat="server" OnClick="cmdSaveItems_Click"></asp:LinkButton>  
												</li>
												<%--<li class="sort-date">
													<span>Single</span>
													<label class="switch">
													  <input type="checkbox" checked>
													  <span class="slider round"></span>
													</label>
													<span>Multiselect</span>
												</li>--%>
												<%--<li><a href="" class="btn approved pdf-img"><span><img src="../images/pdf-img.png"></span><span class="hidden-sm hidden-xs">Export to PDF</span></a></li></li>
												<li><a href="" class="btn approved print"><span><img src="../images/print.png"></span><span class="hidden-sm hidden-xs">Print</span></a></li></li>--%>
											</ul>
										</div>
	
									<div class="table-pending-section">

                                        <script>

                                            function CountDeleteItems (MyItem)
                                            {
                                                var Delbutton = document.getElementById("cmdShowDelete");
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
                                                    document.getElementById("cmdShowDelete").innerText = 'Delete ' + MyDeltest + ' items';

                                                } else {
                                                    document.getElementById("cmdShowDelete").innerText = 'Delete ' + MyDeltest + ' item';
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
                                                   // document.getElementById("cmdSaveItems").innerText = 'Save ' + MyDeltest + ' items';

                                                } else {
                                                    document.getElementById("cmdApproveItems").innerText = 'Approve ' + MyDeltest + ' item';
                                                   // document.getElementById("cmdSaveItems").innerText = 'Save ' + MyDeltest + ' items';
                                                }

                                            }

                                        </script>


                                        <asp:Repeater ID="repDataGrid" runat="server" OnItemDataBound="repDataGrid_ItemDataBound">
                                                                                        
                                            <ItemTemplate>
                                                                                                                
                                                <table width='1170px' border="1" cellpadding='0' cellspacing='0' class='table1'>

                                                    <asp:HiddenField ID="HF_PhilipsAnalysisEnterpriseDataPendingUpdatesID" runat="server" />
                                                    <asp:HiddenField ID="HF_PhilipsPendingID" runat="server" />

                                                    <th width="64" class=''></th>
                                                    <th width="252" class=''>New</th>
                                                    <th width="211" class=''>Current</th>
                                                    <th width="641" class=''><strong>
                                                        <asp:Label ID="lblcolumnName" runat="server" Text="Label"></asp:Label></strong></th>
                                                    <tr>
                                                        <td> <asp:CheckBox ID="chkIsSelected" OnClick="CountDeleteItems(this.checked);"  runat="server" /> </td>
                                                        <td> <asp:TextBox ID="txtNew" Height="104" Width="240" runat="server" TextMode="MultiLine"></asp:TextBox> </td>
                                                        <td> <asp:TextBox ID="txtCurrent" Height="104" Width="240" TextMode="MultiLine" runat="server"></asp:TextBox> </td>
                                                        <td>                                                              
                                                          <p><strong>Author:</strong> <%#Eval("UserName")  %> &nbsp;&nbsp;&nbsp;&nbsp;       <strong>Date Edited</strong>: <%# FormatTimeDate( Eval("UpdateTime") ) %></p>
                                                          <p>Additional Comment</p>
                                                          <p>
                                                            <asp:TextBox ID="txtNotes" Height="53" Width="374" runat="server" TextMode="MultiLine"></asp:TextBox>                                                            
                                                          </p>
                                                        </td>
                                                    </tr>

                                                </table>
                                                                                             

                                            </ItemTemplate>
                                        </asp:Repeater>  

										
																				
									</div>
									
									</div>
							
									
									
									
								</div>
								<div class="bottom-tab">
									
								</div>
							</div>
						</div> 	
				</div>
			</div>
		</div>
	</div>


          <!-- Modal -->
<div class="modal fade" id="DeleteModal" tabindex="-1" role="dialog" aria-labelledby="DeleteModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="DeleteModalLabel">Are you sure you want to delete ?</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-dismiss="modal">No</button>
        <button type="button" id="SaveButton" data-dismiss="modal" class="btn btn-primary">Save changes</button>
      </div>
    </div>
  </div>
</div>


          <script>
                
              $('#SaveButton').on('click', function (e) {

                  document.getElementById("cmdDeleteItems").click();

              });
        </script>


	  </form>

	<footer class="footer">
		<div class="container">
			<div class="row">
				<img src="../images/footer-logo.png"class="img-responsive">
				<h5><span>Privacy notice  |  Terms of use</span>
				<br>
© Philips N.V., © Philips N.V., 2004 - 2019. All rights reserved.</h5>
			</div>
		</div>
	</footer>

    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="../js/bootstrap.min.js"></script>
	<script src="../js/jquery.mCustomScrollbar.concat.min.js"></script>
	<script  src="../js/colResizable-1.6.min.js"></script>
<%--<script src="../js/custom.js"></script>--%>
  </body>
</html>