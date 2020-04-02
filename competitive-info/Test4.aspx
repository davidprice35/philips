<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Test4.aspx.cs" Inherits="competitive_info_Clinical" %>

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
    <title>Clinical</title>

    <!-- Bootstrap -->
    <link href="css/bootstrap.min.css" rel="stylesheet">
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

	
                                        <script type="text/javascript">                                            
                                            //Edit menu button
                                            function refreshData() { 
                                                $('#<%=Grid1.ClientID %>').ejGrid("option", { editSettings: { allowEditing: true, allowAdding: false, allowDeleting: false }, toolbarSettings: { showToolbar: true, toolbarItems: [ej.Grid.ToolBarItems.Edit, ej.Grid.ToolBarItems.Update, ej.Grid.ToolBarItems.Cancel] } })                       
                                            } 

                                                function GridQueryCellInfoEvent(args) { 
          
                                                    if (args.column.field == "ColumnName") {
                                                       // $(args.cell).css('font-weight', 'bold');
                                                        $(args.cell).css("backgroundColor", "#012761").css("color", "#fff"); 
                                                    }

                                                    if (args.column.field == "ItemNo") {
                                                        $(args.cell).css('width', '5px');
                                                    } else {
                                                        $(args.cell).css('width', '600');
                                                    }

                                                    if (args.data.ColumnName == "Application") {

                                                        if (args.cell.innerText == "Philips") {                                                            
                                                            $(args.cell).css("backgroundColor", "#0b5ed7").css("color", "#fff"); 
                                                        }

                                                        if (args.cell.innerText == "GE") {                                                            
                                                            $(args.cell).css("backgroundColor", "#0560ab").css("color", "#fff"); 
                                                        }

                                                        if (args.cell.innerText == "TeraRecon") {                                                            
                                                            $(args.cell).css("backgroundColor", "#6291cc").css("color", "#fff"); 
                                                        }

                                                        if (args.cell.innerText == "Siemens") {                                                            
                                                            $(args.cell).css("backgroundColor", "#f7931e").css("color", "#fff"); 
                                                        }
                                                        
                                                        
                                                    }
                                                                                                        
         
                                               } 



                                            function createEvent(args) {

                                                var gridObj = $('#<%= Grid1.ClientID %>').ejGrid("instance"); 
                                                args.model.columns[0]['visible'] = false; 
                                                args.model.columns[0]['isPrimaryKey'] = true;                                                                                                 
                                                gridObj.columns(args.model.columns) 

                                                var width, height, maximum, viewportSize;
                                                var scroller = this.getScrollObject();
                                                width = viewportSize = this.model.scrollSettings.width - scroller.model.scrollerSize;
                                                height = scroller.model.scrollerSize;
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
                                                this.element.find(".e-gridheader").append($("#scroll"));
                                            }


                                             $(function () {
                                                $('#<%= Grid1.ClientID %>').find(".e-content").scroll(function (args) {
                                                    var grid = $("#Grid1").ejGrid("instance");
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
                                           
                                        </script>

									

                                        
                                        		<div style="height: 580px;" >							
                                               <div style="margin-top: 30px;"min-height: 580px; >
                                        									
                                              <div id="scroll"></div>
                                             <ej:Grid ID="Grid1"  Width="1200" runat="server" AllowTextWrap="true" AllowResizing="true"  AllowScrolling="true"  >   
                                                       <ScrollSettings Width="180"  FrozenColumns="2" />  
                                                <EditSettings AllowEditing="True"></EditSettings>
                                                <ToolbarSettings ShowToolbar="True" ToolbarItems="edit,update,cancel"></ToolbarSettings>
                                                <ClientSideEvents DataBound="createEvent" QueryCellInfo="GridQueryCellInfoEvent"  /> 
                                            </ej:Grid> 

                                        </div>

                                        </div>


              
          </form>


    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>
	
	
     

	

  </body>
</html>