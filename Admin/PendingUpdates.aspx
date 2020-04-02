<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PendingUpdates.aspx.cs" Inherits="Admin_EditGridData" %>


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
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">
	<link rel="stylesheet" href="../css/jquery.mCustomScrollbar.min.css">
    

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>ISP
      <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->


<link href="../css/ej/web/ej.widgets.core.min.css" rel="stylesheet" />
<script src='<%= Page.ResolveClientUrl("~/js/ej/jquery-1.11.3.min.js")%>' type="text/javascript"></script>
<script src='<%= Page.ResolveClientUrl("~/js/ej/jsrender.min.js")%>' type="text/javascript"></script>
<script src='<%= Page.ResolveClientUrl("~/js/ej/ej.web.all.min.js")%>' type="text/javascript"></script>
<script src='<%= Page.ResolveClientUrl("~/js/ej/ej.webform.min.js")%>' type="text/javascript"></script>

      <style>

          .multi-vendor-title .e-treegrid .e-table th, .multi-vendor-title .e-treegrid .e-table td {
    min-width: 150px;
    white-space: normal;
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
							    <img src="../images/logo.png"class="img-responsive">
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
																<h4 class="media-heading">Hello</h4>
																<p><%=m_UserName %></p>
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
					<div class="col-lg-3 col-md-3 col-sm-3 left-padding"> 
						<div class="left-sidebar">
							
                            <asp:Button ID="cmdSubmit"  style="
                            background: #002662;
                            border: 1px solid #002662;
                            width: 100%;
                            height: 40px;
                            line-height: 40px;
                            text-transform: capitalize;
                            font-size: 16px;
                            margin-bottom: 4px;
                            border-radius: 2px;
                            font-weight: normal;
                            color: #fff;
                        " runat="server" Text="submit" OnClick="cmdSubmit_Click" />

							<div class="panel-group" id="accordion">
								<div class="panel panel-default">
									<div class="panel-heading" data-toggle="collapse" data-parent="#accordion" href="#collapseOne">
									  <h4 class="panel-title">
										<a class="accordion-toggle" >
										  ISP Release*
										</a>
									  </h4>
									</div>
									<div id="collapseOne" class="panel-collapse collapse ">
									  <div class="panel-body scroll-body">
										
										<div class="form-check">
										  <label class="form-check-label">
											<input class="form-check-input" type="radio" name="exampleRadios" id="exampleRadios1" value="option1" checked>
											9.0
										  </label>
										</div>
									  </div>
									</div>
								</div>
								<div class="panel panel-default">
									<div class="panel-heading"data-toggle="collapse" data-parent="#accordion" href="#collapseTwo">
									  <h4 class="panel-title">
										<a class="accordion-toggle" >
										  Modality*
										</a>
									  </h4>
									</div>
									<div id="collapseTwo" class="panel-collapse collapse">
									  <div class="panel-body">
										
										<div class="form-check">
										  <label class="form-check-label">
											<asp:CheckBox ID="chkCT" CssClass="form-check-input position-static" runat="server" />											
											CT
										  </label>
										</div>

                                          <div class="form-check">    
										  <label class="form-check-label">
                                              <asp:CheckBox ID="chkMR" CssClass="form-check-input position-static" runat="server" />
											
											MR
										  </label>
                                         </div>

                                           <div class="form-check">  
                                             <label class="form-check-label">
                                              <asp:CheckBox ID="chkMMV" CssClass="form-check-input position-static" runat="server" />
											
											MMV
										  </label>
                                               </div>

                                                <div class="form-check">  
                                            <label class="form-check-label">
                                              <asp:CheckBox ID="chkNMSpect" CssClass="form-check-input position-static" runat="server" />
											
											NM-SPECT
										  </label>
                                                    </div>

                                                <div class="form-check">  
                                            <label class="form-check-label">
                                              <asp:CheckBox ID="chkNMPet" CssClass="form-check-input position-static" runat="server" />
											
											NM-PET
										  </label>
                                               </div>

									  </div>
									</div>
								</div>
								<div class="panel panel-default">
									<div class="panel-heading"data-toggle="collapse" data-parent="#accordion" href="#collapseThree">
									  <h4 class="panel-title">
										<a class="accordion-toggle" >
										  Vendor*
										</a>
									  </h4>
									</div>
									<div id="collapseThree" class="panel-collapse collapse">
									  <div class="panel-body">
										<div class="form-check">
										  <label class="form-check-label">
											 <asp:CheckBox ID="chkSiemens" runat="server" />
											Siemens
										  </label>
										</div>
										<div class="form-check">
										  <label class="form-check-label">
											<asp:CheckBox ID="chkGE" runat="server" />
                                              GE
										  </label>
										</div>
										<div class="form-check">
										  <label class="form-check-label">
											<asp:CheckBox ID="chkToshiba"  runat="server" />
											Toshiba
										  </label>
										</div>
                                         <div class="form-check">
										  <label class="form-check-label">
											<asp:CheckBox ID="chkOthers" runat="server" />
											Others
										  </label>
										</div>

                                          <div class="form-check">
										  <label class="form-check-label">
											<asp:CheckBox ID="chkSamsung" runat="server" />
											Samsung
										  </label>
										</div>

                                          <div class="form-check">
										  <label class="form-check-label">
											<asp:CheckBox ID="chkMediso" runat="server" />
											Mediso
										  </label>
										</div>

                                           <div class="form-check">
										  <label class="form-check-label">
											<asp:CheckBox ID="chkElscint" runat="server" />
											Elscint
										  </label>
										</div>

                                           <div class="form-check">
										  <label class="form-check-label">
											<asp:CheckBox ID="chkSegami" runat="server" />
											Segami
										  </label>
										</div>

                                          
                                          

                                          
									  </div>
									</div>
								</div>
								<div class="panel panel-default">
									<div class="panel-heading" data-toggle="collapse" data-parent="#accordion" href="#collapsefour">
									  <h4 class="panel-title">
										<a class="accordion-toggle">
										  Model 
										</a>
									  </h4>
									</div>
									<div id="collapsefour" class="panel-collapse collapse">
									  <div class="panel-body">										
                                            <asp:CheckBoxList  runat="server" id="chkboxModel"  ></asp:CheckBoxList>                                                                                    
									  </div>
									</div>
								</div>
								<div class="panel panel-default">
									<div class="panel-heading"data-toggle="collapse" data-parent="#accordion" href="#collapsefive">
									  <h4 class="panel-title">
										<a class="accordion-toggle" >
										  Software
										</a>
									  </h4>
									</div>
									<div id="collapsefive" class="panel-collapse collapse">
									  <div class="panel-body">
										
                                          <asp:CheckBoxList  runat="server" id="chkboxSoftware"  ></asp:CheckBoxList>
									  </div>
									</div>
								</div>
								<div class="panel panel-default">
									<div class="panel-heading"data-toggle="collapse" data-parent="#accordion" href="#collapsesix">
									  <h4 class="panel-title">
										<a class="accordion-toggle" >
										  Domain
										</a>
									  </h4>
									</div>
									<div id="collapsesix" class="panel-collapse collapse">
									  <div class="panel-body">
										
                                          <asp:CheckBoxList  runat="server" id="chkboxDomain"  ></asp:CheckBoxList>
									  </div>
									</div>
								</div>
								<div class="panel panel-default">
									<div class="panel-heading"data-toggle="collapse" data-parent="#accordion" href="#collapseseven">
									  <h4 class="panel-title">
										<a class="accordion-toggle" >
										  Module
										</a>
									  </h4>
									</div>
									<div id="collapseseven" class="panel-collapse collapse">
									  <div class="panel-body">
										
                                          <asp:CheckBoxList  runat="server" id="chkboxModule"  ></asp:CheckBoxList>
									  </div>
									</div>
								</div>
								
								<div class="panel panel-default">
									<div class="panel-heading"data-toggle="collapse" data-parent="#accordion" href="#collapsenine">
									  <h4 class="panel-title">
										<a class="accordion-toggle" >
										  Data Set Def.
										</a>
									  </h4>
									</div>
									<div id="collapsenine" class="panel-collapse collapse">
									  <div class="panel-body">
										
                                          <asp:CheckBoxList  runat="server" id="chkboxDefinition"  ></asp:CheckBoxList>
									  </div>
									</div>
								</div>
							</div>
						
							<div class="required-fields">
								<h5>*required fields</h5>
							
								<div class="checkbox-body-part">
									<ul>
										 <li>
											
											<div class="checkbox-primary">
												<asp:CheckBox ID="chkISP" runat="server" />
												<label for="checkbox1">
													ISP
												</label>
											</div>
										</li> 
										<li>
											
											<div class="checkbox-primary">
												<asp:CheckBox ID="chkColVendor" runat="server" />
												<label for="checkbox2">
													Vendor
												</label>
											</div>
										</li>
										<li>
											
											<div class="checkbox-primary">
												<asp:CheckBox ID="chkColModel" runat="server" />
												<label for="checkbox3">
													Model
												</label>
											</div>
										</li>



										<li>
											
											<div class="checkbox-primary">
												<asp:CheckBox ID="chkColSoftware" runat="server" />
												<label for="checkbox4">
													Software
												</label>
											</div>
										</li>
										<li>
											
											<div class="checkbox-primary">
												<asp:CheckBox ID="chkColModality" runat="server" />
												<label for="checkbox5">
													Modality
												</label>
											</div>
										</li>
										
										
									
										<li>
											
											<div class="checkbox-primary">
												<asp:CheckBox ID="chkColDomain" runat="server" />
												<label for="checkbox6">
													Domain
												</label>
											</div>
										</li>
										<li>
											
											<div class="checkbox-primary">
												<asp:CheckBox ID="chkColModule" runat="server" />
												<label for="checkbox7">
													Module
												</label>
											</div>
										</li>
										<li>
											
											<div class="checkbox-primary">
												<asp:CheckBox ID="chkColDefinition" runat="server" />
												<label for="checkbox8">
													Data Set Def.
												</label>
											</div>
										</li>
										
									</ul>
								</div>

							</div>
							
                            <asp:Button ID="Button1"  style="
                            background: #002662;
                            border: 1px solid #002662;
                            width: 100%;
                            height: 40px;
                            line-height: 40px;
                            text-transform: capitalize;
                            font-size: 16px;
                            margin-bottom: 4px;
                            border-radius: 2px;
                            font-weight: normal;
                            color: #fff;
                        " runat="server" Text="submit" OnClick="cmdSubmit_Click" />

						</div>
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
									  <li class="active"><a data-toggle="tab" href="#home">MV Matrix</a></li>
									  
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
                                                    <asp:DropDownList  ID="cmdSortList" style="color: gray;" runat="server">
                                                        <asp:ListItem>Date</asp:ListItem>
                                                        <asp:ListItem>Author</asp:ListItem>
                                                    </asp:DropDownList>
													
												</li>
												<li class="sort-date">
                                                    <asp:LinkButton ID="cmdDeleteItems" Style="background: red;" CssClass="btn approved red-color" OnClick="cmdDeleteItems_Click" runat="server"></asp:LinkButton>                                                    

												</li>
												<li class="sort-date">
                                                    
                                                    <asp:LinkButton ID="cmdApproveItems"  Style="background: green;" CssClass="btn approved green-color" OnClick="cmdApproveItems_Click" runat="server"></asp:LinkButton>  


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

                                                } else {
                                                    document.getElementById("cmdApproveItems").innerText = 'Approve ' + MyDeltest + ' item';
                                                }

                                            }

                                        </script>


                                        <asp:Repeater ID="repDataGrid" runat="server" OnItemDataBound="repDataGrid_ItemDataBound">
                                                                                        
                                            <ItemTemplate>
                                                                                              
												
                                                <table width='1170px'class='table1' cellpadding='0'cellspacing='0'>
                                                    <tr>
                                                    <th class='icon_div'>
                                                    <div class='form-checkbox-div'>

                                                        <asp:HiddenField ID="HF_PhilipsMatrixDataID" runat="server" />
                                                        <asp:HiddenField ID="HF_PhilipsPendingID" runat="server" />
                                                         <asp:CheckBox ID="chkIsSelected" OnClick = "CountDeleteItems(this.checked);"  runat="server" />

                                                    <div class='checkbox checkbox-primary'>
                                                 

                                                    </div>
                                                    </div>
                                                    </th>
                                                    <th class='vendor'>Vendor</th>
                                                    <th class=''>Model</th>
                                                    <th class=''>SW </th>
                                                    
                                                    <th class=''><i class='fa fa-check' aria-hidden='true'></i></th>
                                                    <th></th>
                                                    <th class=''>Notes</th>
                                                    <th class=''>ISP</th>
                                                    <th class=''>Modality</th>
                                                    <th class=''>Domain</th>
                                                    <th class=''>Module</th>
                                                    
                                                    <th class=''>Data Set Def.</th>
                                                    </tr>

                                                    <%--Current Item--%>
                                                    <tr>
                                                    <td style='border-top:1px solid #ddd;' class='icon_div'>Current</td>

                                                    <td class=''><asp:Label ID="lblVendor" runat="server" ></asp:Label></td>
                                                    <td class=''><asp:Label ID="lblModel" runat="server" ></asp:Label></td>
                                                    <td class=''><asp:Label ID="lblSoftware" runat="server" ></asp:Label></td>                                

                                                    <td class=''style='border-top:1px solid #ddd;'><asp:Label ID="lblDataElement" runat="server" ></asp:Label></td>
                                                    <td style='border-top:1px solid #ddd;' ></td>
                                                    <td class=''style='border-top:1px solid #ddd;'><asp:Label ID="lblNotes" runat="server" ></asp:Label></td>
                                                    <td class=''style='border-top:1px solid #ddd;'><asp:Label ID="lblISP" runat="server" ></asp:Label></td>
                                                    <td class=''style='border-top:1px solid #ddd;'><asp:Label ID="lblAppType" runat="server" ></asp:Label></td>
                                                    <td class=''style='border-top:1px solid #ddd;'><asp:Label ID="lblDomain" runat="server" ></asp:Label></td>
                                                    <td class=''style='border-top:1px solid #ddd;'><asp:Label ID="lblModule" runat="server" ></asp:Label></td>                
                                                    <td class=''style='border-top:1px solid #ddd;'><asp:Label ID="lblDefinition" runat="server" ></asp:Label></td>



                                                    </tr>

                                                    
                                                    <%--New Item--%>
                                                    <tr>
                                                    <td style='border-top:1px solid #ddd;' class=''><b>New</b></td>
                                                    <td class=''>
                                                        
                                                        <asp:TextBox ID="txtVendor" runat="server" Text=""></asp:TextBox>

                                                    </td>
                                                    <td class=''><asp:TextBox ID="txtModel" runat="server"></asp:TextBox></td>
                                                    <td class=''><asp:TextBox ID="txtSW" runat="server" Text=""></asp:TextBox></td>           
                                                    <td class=''><asp:TextBox ID="txtDataElement" runat="server" Text=""></asp:TextBox></td>
                                                    <td style='border-top:1px solid #ddd;'></td>
                                                    <td class=''style='border-top:1px solid #ddd;'> <asp:TextBox ID="txtNotes" runat="server" Text=""></asp:TextBox> </td>
                                                    <td class=''style='border-top:1px solid #ddd;'> <asp:TextBox ID="txtISP" runat="server" Text=""></asp:TextBox> </td>
                                                    <td class=''style='border-top:1px solid #ddd;'> <asp:TextBox ID="txtModality" runat="server" Text=""></asp:TextBox> </td>
                                                    <td class=''style='border-top:1px solid #ddd;'><asp:TextBox ID="txtDomain" runat="server" Text=""></asp:TextBox></td>
                                                    <td class=''style='border-top:1px solid #ddd;'><asp:TextBox ID="txtModule" runat="server" Text=""></asp:TextBox></td>
           
                                                    <td class=''style='border-top:1px solid #ddd;'><asp:TextBox ID="txtDefinition" runat="server" Text=""></asp:TextBox></td>
                                                    </tr>
                                                    </table>

                                                    <div class='table-bottom-content'>
                                                    <p><strong>Edited by</strong> <%#Eval("UserName")  %> on <%# FormatTimeDate( Eval("UpdateTime") ) %> </p>
                                                    <p><strong>Additional comments:</strong> <asp:TextBox ID="txtComment" Style="width: 500px;" runat="server" TextMode="MultiLine"> </asp:TextBox></p>

                                                    </div>





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
	  </form>

	<footer class="footer">
		<div class="container">
			<div class="row">
				<img src="../images/footer-logo.png"class="img-responsive">
				<h5><span>Privacy notice  |  Terms of use</span>
				<br>
© Philips N.V., 2004 - 2019. All rights reserved. </h5>
			</div>
		</div>
	</footer>

    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="../js/bootstrap.min.js"></script>
	<script src="../js/jquery.mCustomScrollbar.concat.min.js"></script>
	<script  src="../js/colResizable-1.6.min.js"></script>
<script src="../js/custom.js"></script>
  </body>
</html>