<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditGridData.aspx.cs" Inherits="Admin_EditGridData" %>


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
    <title>Template</title>

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


  <link href="https://cdn.syncfusion.com/16.1.0.37/js/web/flat-azure/ej.web.all.min.css" rel="stylesheet" />
    <link href="https://cdn.syncfusion.com/16.1.0.37/js/web/flat-azure/ej.web.all.min.css" rel="stylesheet" />
    <script src='<%= Page.ResolveClientUrl("https://code.jquery.com/jquery-1.11.3.min.js")%>' type="text/javascript"></script>
    <script src='<%= Page.ResolveClientUrl("https://cdn.syncfusion.com/js/assets/external/jsrender.min.js")%>' type="text/javascript"></script>
    <script src='<%= Page.ResolveClientUrl("https://cdn.syncfusion.com/16.1.0.37/js/web/ej.web.all.min.js")%>' type="text/javascript"></script>

    <script src='<%= Page.ResolveClientUrl("~/js/ej/ej.webform.min.js")%>' type="text/javascript"></script>


          
    
    


      <style>

          .multi-vendor-title .e-treegrid .e-table th, .multi-vendor-title .e-treegrid .e-table td {
    min-width: 150px;
    white-space: normal;
}

          #myTable_paginate{
              float: right;
          }

          .dataTables_filter{
               display:none;
          }

          .dataTables_length{
              display:none;
          }


      </style>



     

  </head>
  <body>
      



      <form id="form1" runat="server">


          <script>


            var allowEditing; 
            function toolbarClick(args) { 
                if (args.itemName == "Edit") 
                    allowEditing = true; 
            } 
            function beginEdit(args) { 
                if (!allowEditing) 
                    args.cancel = true; 
                allowEditing = false; 
            } 


              function EndEdit(args) {

                  //debugger;
                  //var items = '';
                  

                  if (args.requestType == "update")
                  {

                      var data = args.currentValue;

                          $.ajax({
                              type: "POST",
                              url: '/Admin/UpdateData/UpdateAllData',
                              contentType: "application/json; charset=utf-8",
                      
                              data: JSON.stringify(data),
                          
                              dataType: "json",
                              success: function (result) {}
                          }) 

                  }


                  //var data = args.data.item; // affected record when edit 
                  
                  //$.ajax({
                  //    type: "POST",
                  //    url: '/Admin/UpdateData/UpdateAllData',
                  //    contentType: "application/json; charset=utf-8",
                      
                  //    data: JSON.stringify(data),
                          
                  //    dataType: "json",
                  //    success: function (result) {

                  //    }
                  //}) 

              }


              function ActionComplete(args) {

                  //alert(args.requestType);
              }
</script>



            <div class="top-tabs-link">
	<div class="nav nav-pills">
		<li class="col-sm-2 col-xs-2 width"><a href="#"></a></li>
		<li class="col-sm-2 col-xs-2 width"><a href="/MV-Matrix.aspx">MV MATRIX</a></li>
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
									  <div class="panel-body">
										
										
										 
                                         
                                            <asp:CheckBoxList  runat="server" id="chkISPVersion"  ></asp:CheckBoxList>                                                                                    
									    

										
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
									  <li class="active"><a data-toggle="tab" href="/MV-Matrix.aspx">MV Matrix</a></li>
									  
								</ul>

								<div class="tab-content ">
									<div id="home" class="tab-pane fade in active">
										
										<div class="multi-vendor-title table-responsive">
										   
                                            <asp:Button ID="cmdAddNew" runat="server" Text="Add New" OnClick="cmdAddNew_Click" />

                                            <asp:Panel ID="PanAddNew" runat="server" Visible="false">
                                                <table class="table table-striped">
                                                      <thead>
                                                        <tr>
                                                          <th scope="col">Vendor</th>
                                                          <th scope="col">Model</th>
                                                          <th scope="col">Software</th>
                                                          <th scope="col">DataItem</th>
                                                          <th scope="col">Notes</th>
                                                          <th scope="col">ISP</th>
                                                          <th scope="col">Modality</th>
                                                          <th scope="col">Domain</th>
                                                          <th scope="col">Module</th>
                                                          <th scope="col">DataSet Def.</th>
                                                          <th scope="col">Additional Comments</th>
                                                          <th scope="col">Save</th>
                                                        </tr>                                                         
                                                      </thead>
                                                      <tbody>
                                                            <tr>

                                                        
                                                         <td>
                                                             <asp:DropDownList ID="tbnVendor" runat="server"></asp:DropDownList>
                                                         </td>
                                                         <td><asp:DropDownList ID="tbnModel" runat="server"></asp:DropDownList> </td>   
                                                         <td><asp:DropDownList Width="200px" ID="tbnSoftware" runat="server"></asp:DropDownList>  </td>
                                                         <td><asp:DropDownList ID="tbnDataElement" runat="server"></asp:DropDownList>  </td>
                                                         <td><asp:TextBox ID="tbnNotes" runat="server"></asp:TextBox></td>
                                                         <td><asp:DropDownList ID="tbnISP" runat="server"></asp:DropDownList>   </td>
                                                         <td><asp:DropDownList ID="tbnAppType" runat="server"></asp:DropDownList></td>
                                                         <td><asp:DropDownList ID="tbnDomain" runat="server"></asp:DropDownList></td>
                                                         <td><asp:DropDownList ID="tbnModule" runat="server"></asp:DropDownList> </td>
                                                         <td><asp:TextBox ID="tbnDataSet" runat="server"></asp:TextBox></td>
                                                         <td><asp:TextBox ID="tbnAddComments" runat="server"></asp:TextBox></td>
                                                         <td><asp:Button ID="SaveButton" runat="server" Text="Save"  OnClick="SaveButton_Click" /> </td>   
                                                                </tr>
                                                        </tbody>
                                                        </table>                
                                            </asp:Panel>


                                            <asp:Repeater ID="repData" runat="server" OnItemDataBound="repData_ItemDataBound">

                                                <HeaderTemplate>                                                    
                                                    <table class="table table-striped" id="myTable">
                                                      <thead>
                                                        <tr>
                                                          <th scope="col">Vendor</th>
                                                          <th scope="col">Model</th>
                                                          <th scope="col">Software</th>
                                                          <th scope="col">DataItem</th>
                                                          <th scope="col">Notes</th>
                                                          <th scope="col">ISP</th>
                                                          <th scope="col">Modality</th>
                                                          <th scope="col">Domain</th>
                                                          <th scope="col">Module</th>
                                                          <th scope="col">DataSet Def.</th>
                                                          <th scope="col">Additional Comments</th>
                                                          <th scope="col">Update</th>
                                                        </tr>                                                         
                                                      </thead>
                                                      <tbody>
                                                </HeaderTemplate>

                                                <ItemTemplate>

                                                    
                                                    
 
    <asp:Repeater ID="repDataItem" runat="server" OnItemDataBound="repDataItem_ItemDataBound" >         
             <ItemTemplate>
                 
                 <tr>

                     <asp:HiddenField ID="tbPhilipsID" runat="server" />
                     <asp:HiddenField ID="tbPhilipsMatrixDataID" runat="server" />

                     <td> <asp:DropDownList ID="tbVendor" runat="server"></asp:DropDownList></td>
                     <td> <asp:DropDownList ID="tbModel" runat="server"></asp:DropDownList> </td>   
                     <td> <asp:DropDownList Width="200px" ID="tbSoftware" runat="server"></asp:DropDownList> </td>
                     <td> <asp:DropDownList ID="tbDataElement" runat="server"></asp:DropDownList> </td>
                     <td> <asp:TextBox ID="tbNotes" runat="server"></asp:TextBox></td>
                     <td> <asp:DropDownList ID="tbISP" runat="server"></asp:DropDownList>  </td>
                     <td> <asp:DropDownList ID="tbAppType" runat="server"></asp:DropDownList> </td>
                     <td> <asp:DropDownList ID="tbDomain" runat="server"></asp:DropDownList></td>
                     <td><asp:DropDownList ID="tbModule" runat="server"></asp:DropDownList> </td>
                     <td><asp:TextBox ID="tbDataSet" runat="server"></asp:TextBox></td>
                     <td><asp:TextBox ID="tbAddComments" runat="server"></asp:TextBox></td>
                     <td><asp:Button ID="updateButton" runat="server" Text="Update" OnClick="GetValue" /> </td>         
           

                </tr> 
             </ItemTemplate>         
         </asp:Repeater>
                                                   



    


                                             

                                                    </ItemTemplate>


                                                <FooterTemplate>
                                                      </tbody>
                                                        </table>
                                                </FooterTemplate>

                                            </asp:Repeater>




										</div>
	
									
									
									</div>
								<div class="force-overflow"></div>
									
									
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



              <script src="https://cdnjs.cloudflare.com/ajax/libs/datatables/1.10.12/js/jquery.dataTables.min.js"></script>
<script src="https://cdn.datatables.net/1.10.19/js/dataTables.bootstrap4.min.js"></script>

       <script>

          $(document).ready( function () {
              $('#myTable').DataTable();



        } );


      </script>


	<script src="../js/jquery.mCustomScrollbar.concat.min.js"></script>
	<script  src="../js/colResizable-1.6.min.js"></script>
    <script src="../js/custom.js"></script>



                 

  </body>
</html>

