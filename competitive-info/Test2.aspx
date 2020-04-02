<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Test2.aspx.cs" Inherits="competitive_info_Test" %>

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


    <link href="https://cdn.syncfusion.com/16.1.0.37/js/web/flat-azure/ej.web.all.min.css" rel="stylesheet" />
      <link href="../css/ej/web/responsive-css/ejgrid.responsive.css" rel="stylesheet" />
    <script src='<%= Page.ResolveClientUrl("~/js/ej/jquery-1.11.3.min.js")%>' type="text/javascript"></script>
    <script src='<%= Page.ResolveClientUrl("~/js/ej/jsrender.min.js")%>' type="text/javascript"></script>
    <script src='<%= Page.ResolveClientUrl("~/js/ej/ej.web.all.min.js")%>' type="text/javascript"></script>
    <script src='<%= Page.ResolveClientUrl("~/js/ej/ej.webform.min.js")%>' type="text/javascript"></script>



      <style>

          

      </style>

  </head>
  <body>


      <form id="form1" runat="server">

  <div class="top-tabs-link">
	<div class="nav nav-pills">
		  
  </div>
  </div>
		<div class="main-section">			
			<div class="container">
				<div class="row">
						<div class="top-header">
						<div class="col-sm-12 col-xs-12 col-md-2 col-lg-2">
                             <a href="/">
							
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
                                        
                                       		
                                        


									</ul>
									<ul class="nav navbar-nav icons-right" style="float: right;">
											<li class="user-dropdown ">
											
												<div class="drop-down">
												  <button class="btn btn-primary dropdown-toggle" type="button" data-toggle="dropdown">
												  Hello Jonny <span class=""></span></button>
												  <ul class="dropdown-menu objects">
														<div class="media">
															<div class="media-left">
																
															</div>
															<div class="media-body">
																<h4 class="media-heading">Hello</h4>
																
															</div>
														</div>
														
														<div class="view_box">
															
                                                            

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
					
						<div class="col-lg-10 col-md-9 col-sm-9 right-padding competitors-right">
							<div class="rightbar">
								


								<div class="tab-content toshiba-content " style="display:inline-block;width:1400px;">
									<div id="home" class="tab-pane fade in active">
										
	
                                        <script type="text/javascript">
                                            
                                                                                      


                                            function refreshData() { 
                                                $('#<%= Grid1.ClientID %>').ejGrid("option", { editSettings: { allowEditing: true, allowAdding: false, allowDeleting: false }, toolbarSettings: { showToolbar: true, toolbarItems: [ej.Grid.ToolBarItems.Edit, ej.Grid.ToolBarItems.Update, ej.Grid.ToolBarItems.Cancel] } })                       
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

                                             $("#chkMarket").change(function (e) {
                                                 var gridObj = $("#Grid1").ejGrid("instance"); 
                                                 if ($(this).is(":checked")) {
                                                     gridObj.getRowByIndex(2).show();
                                                 }
                                                 else
                                                 {
                                                     
                                                     gridObj.getRowByIndex(2).hide();
                                                 }
                                            });

                                            $("#chkBusiness").change(function (e) {
                                                 var gridObj = $("#Grid1").ejGrid("instance"); 
                                                 if ($(this).is(":checked")) {
                                                     gridObj.getRowByIndex(3).show();
                                                 }
                                                 else
                                                 {
                                                     
                                                     gridObj.getRowByIndex(3).hide();
                                                 }
                                            });

                                            
                                            $("#chkSolution").change(function (e) {
                                                 var gridObj = $("#Grid1").ejGrid("instance"); 
                                                 if ($(this).is(":checked")) {
                                                     gridObj.getRowByIndex(4).show();
                                                 }
                                                 else
                                                 {
                                                     
                                                     gridObj.getRowByIndex(4).hide();
                                                 }
                                            });

                                             $("#chkStrengths").change(function (e) {
                                                 var gridObj = $("#Grid1").ejGrid("instance"); 
                                                 if ($(this).is(":checked")) {
                                                     gridObj.getRowByIndex(5).show();
                                                 }
                                                 else
                                                 {
                                                     
                                                     gridObj.getRowByIndex(5).hide();
                                                 }
                                            });

                                             $("#chkArgumentation").change(function (e) {
                                                 var gridObj = $("#Grid1").ejGrid("instance"); 
                                                 if ($(this).is(":checked")) {
                                                     gridObj.getRowByIndex(6).show();
                                                 }
                                                 else
                                                 {
                                                     
                                                     gridObj.getRowByIndex(6).hide();
                                                 }
                                            });

                                            $("#chkPhilips").change(function (e) {
                                                e = e || window.event;                                                                                               
                                                checkStatus = e.target.checked;                                                                                                
                                                showhide('Philips', checkStatus);
                                            });

                                             $("#chkPhilipsFreeze").change(function (e) {
                                                e = e || window.event;                                                                                               
                                                checkStatus = e.target.checked;                                                                                                
                                                 onClickFreeze(checkStatus);
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





                                             function onClickFreeze(checkStatus) {
                                                var scrolling = {};


                                                 if (checkStatus == false)
                                                 {
                                                    scrolling = { frozenRows: 0, frozenColumns: 0, height: 500,width: 1700 };                                                
                                                    $('#<%= Grid1.ClientID %>').ejGrid("model.scrollSettings", scrolling);
                                                 }
                                                 else
                                                 {
                                                    scrolling = { frozenRows: 0, frozenColumns: 2, height: 500,width: 1700 };                                                
                                                    $('#<%= Grid1.ClientID %>').ejGrid("model.scrollSettings", scrolling);
                                                 }
                                                 
                                                   
                                            }
                                            

                                           


                                        </script>
      
      
									<div style="margin-top: 30px;height:660px;">
                                                         <div id="scroll"></div>
                                        <ej:Grid ID="Grid1" runat='server' MinWidth="400" Width="1380" Height="580" AllowSelection="true" AllowScrolling="true" AllowTextWrap="true" AllowResizing="true" IsResponsive="false">
                                            <ScrollSettings Width="180"  FrozenColumns="2" />  
                                            <Columns>
                                               
                                                <ej:Column Field="OrderID" Width="180" AllowEditing="false"   CssClass="solution" HeaderText="ColumnName"    />

                                                <ej:Column Field="CustomerID" Width="350" HeaderText="CustomerID" CssClass="Philips" HeaderTextAlign="center" DisableHtmlEncode="false"  HeaderTemplateID="#PhilipsHeader"  >                                                
                                                    <EditTemplate Create="create" Read="Philipsread" Write="Philipswrite" />
                                                </ej:Column>


                                                 <ej:Column Field="EmployeeID" Width="350" HeaderText="EmployeeID" CssClass="Tera" HeaderTextAlign="center" DisableHtmlEncode="false" HeaderTemplateID="#TeraHeader"   >                                                
                                                    <EditTemplate Create="create" Read="Teraread" Write="Terawrite" />
                                                </ej:Column>

                                                <ej:Column Field="Freight" Width="350" HeaderText="Freight" CssClass="Siemens" HeaderTextAlign="center" DisableHtmlEncode="false" HeaderTemplateID="#SiemensHeader"   >                                                
                                                    <EditTemplate Create="create" Read="Siemensread" Write="Siemenswrite" />
                                                </ej:Column>

                                               
                                                <ej:Column Field="OrderID" IsPrimaryKey="true" Width="0"  HeaderText="OrderID"      />                                                
                                                    
                                                  
                                            </Columns>

                                            <ClientSideEvents  DataBound="createEvent" />
                                            <EditSettings AllowEditing="True" ></EditSettings>
                                            <ToolbarSettings ShowToolbar="True" ToolbarItems="edit,update,cancel"></ToolbarSettings>
                                        </ej:Grid>


                                        <script type="text/javascript">     


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



                                            var val;

                                            function GridActionBeginEvent(args) {

                                                
                                                //if (args.requestType == "save")
                                                //    args.rowData['Comments'] = val;
                                            }

                                            function create() {
                                                return $("<textarea class='e-field' rows=5 style='width: 100%;'></textarea>");
                                            }

                                            function Philipswrite(args) {
                                                args.element.val(args.rowdata["Freight"]);                                                
                                                $(args.element.parents('td')[0]).append("<textarea id='PhilipsComments' type='text' rows=3 style='width: 100%;' name='PhilipsComments'></textarea>");
                                                args.rowdata["Comment"] != null ? $("#PhilipsComments").val(args.rowdata['Comment']) : $("#PhilipsComments").attr('placeholder', 'Additional Comments');
                                            }

                                             function Terawrite(args) {
                                                 args.element.val(args.rowdata["ShipCity"]);

                                                  $(args.element.parents('td')[0]).append("<textarea id='TeraComments' type='text' rows=3 style='width: 100%;' name='TeraComments'></textarea>");
                                                args.rowdata["Comment"] != null ? $("#TeraComments").val(args.rowdata['Comment']) : $("#TeraComments").attr('placeholder', 'Additional Comments');
                                            }

                                            function Siemenswrite(args) {
                                                args.element.val(args.rowdata["Siemens"]);

                                                 $(args.element.parents('td')[0]).append("<textarea id='SiemensComments' type='text' rows=3 style='width: 100%;' name='SiemensComments'></textarea>");
                                                args.rowdata["Comment"] != null ? $("#SiemensComments").val(args.rowdata['Comment']) : $("#SiemensComments").attr('placeholder', 'Additional Comments');
                                            }

                                            function GEwrite(args) {
                                                args.element.val(args.rowdata["GE"]);

                                                 $(args.element.parents('td')[0]).append("<textarea id='GEComments' type='text' rows=3 style='width: 100%;' name='GEComments'></textarea>");
                                                args.rowdata["Comment"] != null ? $("#GEComments").val(args.rowdata['Comment']) : $("#GEComments").attr('placeholder', 'Additional Comments');
                                            }

                                            function Cannonwrite(args) {
                                                args.element.val(args.rowdata["Cannon"]);

                                                 $(args.element.parents('td')[0]).append("<textarea id='CannonComments' type='text' rows=3 style='width: 100%;' name='CannonComments'></textarea>");
                                                args.rowdata["Comment"] != null ? $("#CannonComments").val(args.rowdata['Comment']) : $("#CannonComments").attr('placeholder', 'Additional Comments');
                                            }

                                            function Agfawrite(args) {
                                                args.element.val(args.rowdata["Agfa"]);

                                                 $(args.element.parents('td')[0]).append("<textarea id='AgfaComments' type='text' rows=3 style='width: 100%;' name='AgfaComments'></textarea>");
                                                args.rowdata["Comment"] != null ? $("#AgfaComments").val(args.rowdata['Comment']) : $("#AgfaComments").attr('placeholder', 'Additional Comments');
                                            }

                                            function read(args) {
                                                val = $("#Comments").val();
                                                return args.val();
                                            }

                                            function Philipsread(args) {                                                
                                                val = $("#PhilipsComments").val();
                                                return args.val()
                                            }

                                             function Teraread(args) {
                                                val = $("#TeraComments").val();
                                                return args.val()
                                            }

                                            function Siemensread(args) {
                                                val = $("#SiemensComments").val();
                                                return args.val()
                                            }

                                            function GEread(args) {
                                               val = $("#GEComments").val();
                                                return args.val()
                                            }

                                            function Cannonread(args) {
                                                val = $("#CannonComments").val();
                                                return args.val()
                                            }

                                            function Agfaread(args) {
                                                val = $("#AgfaComments").val();
                                                return args.val()
                                            }
                                        </script>

    <style type="text/css"> 
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
																
									
								</div>
								
							</div>
						</div> 	
				</div>
			</div>
		</div>
	</div>
	
	<footer class="footer">
		<div class="container">

		</div>
	</footer>

          </form>


    
	
	
	

  </body>
</html>