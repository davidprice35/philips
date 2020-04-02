<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Test.aspx.cs" Inherits="competitive_info_Test" %>

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

          <ej:Grid ID="Grid1" MinWidth="1200"  Width="1200" runat="server" AllowTextWrap="true" AllowResizing="true"  AllowScrolling="true"  >   
               <ScrollSettings Width="180"  FrozenColumns="2" />               
                <EditSettings AllowEditing="True"></EditSettings>
                <ToolbarSettings ShowToolbar="True" ToolbarItems="edit,update,cancel"></ToolbarSettings>
                <ClientSideEvents Create="GridCreateEvent" QueryCellInfo="GridQueryCellInfoEvent"  /> 
          </ej:Grid> 
            

          <script type="text/javascript">



                                          
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

                                                    if (args.data.ColumnName == "Competitor") {

                                                        if (args.cell.innerText == "PHILIPS") {                                                            
                                                            $(args.cell).css("backgroundColor", "#0b5ed7").css("color", "#fff"); 
                                                        }

                                                        if (args.cell.innerText == "GE") {                                                            
                                                            $(args.cell).css("backgroundColor", "#0560ab").css("color", "#fff"); 
                                                        }

                                                        if (args.cell.innerText == "TERARECON") {                                                            
                                                            $(args.cell).css("backgroundColor", "#6291cc").css("color", "#fff"); 
                                                        }

                                                        if (args.cell.innerText == "SIEMENS") {                                                            
                                                            $(args.cell).css("backgroundColor", "#f7931e").css("color", "#fff"); 
                                                        }
                                                        
                                                        
                                                    }
                                                                                                        
         
                                               } 



                                            function GridCreateEvent(args) { 
       
                                               var gridObj = $('#<%= Grid1.ClientID %>').ejGrid("instance"); 
                                               args.model.columns[0]['visible'] = false; 
                                               args.model.columns[0]['isPrimaryKey'] = true; 

                                                
                                                

                                               gridObj.columns(args.model.columns) 

                                                this.element.find("tr:last").closest("tr").hide();
                                                


                                          } 

                                        </script>
	
	

          </form>


    
	
	

  </body>
</html>