<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Test2.aspx.cs" Inherits="Test2" %>


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

    
    <link href="/css/bootstrap.min.css" rel="stylesheet">
    <link href="/css/style.css" rel="stylesheet">
    <link href="/css/responsive.css" rel="stylesheet">
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
  
		<div class="main-section">			
			<div class="container">
				<div class="row">
						
			        <div style="margin-top:100px">

                        <div id="customScrollbar" style="overflow-x:scroll;" onscroll="scollPos(event);">
                            <div id="customDivScrollbar" style="height:1px;"></div>
                        </div>

                        <ej:TreeGrid runat="server" ID="TreeGridControlDefault" ChildMapping="SubTasks" AllowColumnResize="true" TreeColumnIndex="1" IsResponsive="true">
                            <Columns>
                                <ej:TreeGridColumn HeaderText="Task Id" Field="TaskID" Width="200" />
                                <ej:TreeGridColumn HeaderText="Task Name" Field="TaskName" Width="300" />
                                <ej:TreeGridColumn HeaderText="Task Name" Field="TaskName" Width="300" />
                                <ej:TreeGridColumn HeaderText="Task Name" Field="TaskName" Width="400" />
                                <ej:TreeGridColumn HeaderText="Task Name" Field="TaskName" Width="200" />
                                <ej:TreeGridColumn HeaderText="Task Name" Field="TaskName" Width="200" />
                                <ej:TreeGridColumn HeaderText="Start Date" Field="StartDate" />
                                <ej:TreeGridColumn HeaderText="End Date" Field="EndDate" />
                                <ej:TreeGridColumn HeaderText="Duration" Field="Duration" />
                                <ej:TreeGridColumn HeaderText="Progress" Field="Progress" />
                            </Columns>
                            <SizeSettings Width="100%" Height="450px" />
                        </ej:TreeGrid>
			
			        </div>

                     <script type="text/javascript">
        $(function () {
            var dateFormat = "{0:" + ej.preferredCulture()["calendars"]["standard"]["patterns"]["d"] + "}";
            $("#TreeGridContainer").ejTreeGrid({
                dataSource: sampleData,
                childMapping: "subtasks",
                treeColumnIndex: 1,
                allowColumnResize:true,
                isResponsive: true,
                create: function (args) {
                    
                    var proxy = this;
                    if ($("#"+proxy._id).find(".e-hscrollbar").length) {
                        var width = $("#"+proxy._id).width();
                        $("#customDivScrollbar").css("width", $("#"+proxy._id+"e-table").width() +20);
                        $("#customScrollbar").css("width", width);
                    }
                    else {
                        $("#customScrollbar").hide();
                        $("#customDivScrollbar").hide();
                    }
                },
                columnResized: function (args) {
                    
                    var proxy = this;
                    setTimeout(function () {
                        if ($("#" + proxy._id).find(".e-hscrollbar").find(".e-hscroll").length) {
                            $("#customScrollbar").show();
                            $("#customDivScrollbar").show();
                            $("#customDivScrollbar").css("width", $("#" + proxy._id + "e-table").width() + 20);
                        }
                        else {
                            $("#customScrollbar").hide();
                            $("#customDivScrollbar").hide();
                        }

                    }, 50);
                },
                columns: [
                    { field: "taskID", headerText: "Task Id", editType: "numericedit", width: window.theme == "material" ? 90 : 60 },
                    { field: "taskName", headerText: "Task Name", editType: "stringedit" },
                    { field: "startDate", headerText: "Start Date", editType: "datepicker", format: dateFormat },
                    { field: "endDate", headerText: "End Date", editType: "datepicker", format: dateFormat },
                    { field: "duration", headerText: "Duration", editType: "numericedit" },
                    { field: "progress", headerText: "Progress", editType: "numericedit" }
                ],
                
            });
        });
        function scollPos(e) {
           var treeObj = $("#TreeGridContainer").data("ejTreeGrid");
           var scrollObj = treeObj.getScrollElement().data("ejScroller");
            scrollObj.option("scrollLeft", $(e.target).scrollLeft())
           }
        $(window).on('resize', function () {
           
            setTimeout(function () {
                var treeObj = $("#TreeGridContainer").data("ejTreeGrid");
            if ($("#TreeGridContainer").find(".e-hscrollbar").length) {
                var width = $("#TreeGridContainer").width();
                $("#customScrollbar").show();
                $("#customDivScrollbar").show();
                $("#customDivScrollbar").css("width", $("#"+treeObj._id+"e-table").width() + 20);
                $("#customScrollbar").css("width", width);
            }
            else {
                $("#customScrollbar").hide();
                $("#customDivScrollbar").hide();
            }
           }, 50);
        });
    </script>



				
			</div>
		</div>
	</div>
	


	<footer class="footer">
		<div class="container">
			<div class="row">
				<img src="images/footer-logo.png"class="img-responsive">
				
			</div>
		</div>
	</footer>
          </form>

        <script src="js/bootstrap.min.js"></script>         
</body>
     
</html>
