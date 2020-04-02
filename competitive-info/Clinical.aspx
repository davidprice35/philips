<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Clinical.aspx.cs" Inherits="competitive_info_Clinical" %>

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
    <script src='<%= Page.ResolveClientUrl("https://code.jquery.com/jquery-1.11.3.min.js")%>' type="text/javascript"></script>
    <script src='<%= Page.ResolveClientUrl("https://cdn.syncfusion.com/js/assets/external/jsrender.min.js")%>' type="text/javascript"></script>
    <script src='<%= Page.ResolveClientUrl("https://cdn.syncfusion.com/16.1.0.37/js/web/ej.web.all.min.js")%>' type="text/javascript"></script>
    <script src='<%= Page.ResolveClientUrl("~/js/ej/ej.webform.min.js")%>' type="text/javascript"></script>

    <script src='<%= Page.ResolveClientUrl("~/js/multi-list.js")%>' type="text/javascript"></script>

    <style>

        .e-btn.e-txt.e-select, .e-tbtn.e-txt.e-select {
            background-color: #178bc6;
            color: white;
            width: 85px;
        }



         label.form-check-label {padding: 0 0 0 16px;}
        .form-check-label table td input[type="checkbox"] {   position: absolute;    left: -16px;    top: 0;}
        .form-check-label table td {  position: relative;     padding: 0 0 10px;}

        .ml-hide {
	        display: none !important;
        }
      </style>

</head>
<body>


    <form id="form1" runat="server">

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
                                <img src="/images/ClinicalLogo.png" class="img-responsive">
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


                                        <li><a href="/competitive-info/Clinical">Clinical</a></li>
                                        <% if (m_UserType == "Super Admin")
                                            {%>

                                        <li><a href="javascript:refreshData();">Edit</a></li>
                                        <li><a href="/competitive-info/ClinicalPendingUpdates.aspx">Approve</a></li>
                                          <%} %>
                                        <!--<li><a href="/">MV Search</a></li>
										<li class="submenubar"><a href="/">Admin</a>
											<ul class="dropdown-menu">												
												<li><a href="/admin/EditGridData">Edit Data</a></li> 
												<li><a href="/admin/PendingUpdates">Pending Changes</a></li>												
											</ul>
										
										</li>-->



                                    </ul>
                                    <ul class="nav navbar-nav icons-right" style="float: right;">
                                        <li class="icons"><a href="<%= Helper.GetUserGuide() %>" target="_blank" >User Guide</a></li>
                                        <li class="user-dropdown ">

                                            <div class="drop-down">
                                                <button class="btn btn-primary dropdown-toggle" type="button" data-toggle="dropdown">
                                                    Hello <%=m_UserName %><span class="">
                                                        </span></button>
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
                                                        <asp:LinkButton ID="cmdLogout" CssClass="view_prfl" OnClientClick="Myclick();" runat="server">Log out <span><i class="fa fa-angle-right" aria-hidden="true"></i></span></asp:LinkButton>

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
                        <div class="col-sm-3 col-md-3 col-lg-2 left-padding">
                            <div class="left-sidebar camparision-section ">

                                <asp:Button ID="cmdSubmit" Style="background: #002662; border: 1px solid #002662; width: 100%; height: 40px; line-height: 40px; text-transform: capitalize; font-size: 16px; margin-bottom: 4px; border-radius: 2px; font-weight: normal; color: #fff;"
                                    runat="server" Text="Submit Search" OnClick="cmdSubmit_Click" />




                                <div class="panel-group" id="accordion">

                                    <div class="panel panel-default">
                                        <div class="panel-heading" data-toggle="collapse" data-parent="#accordion" href="#collapseTwo">
                                            <h4 class="panel-title">
                                                <a class="accordion-toggle">Competitors
                                                </a>
                                            </h4>
                                        </div>
                                        <div id="collapseTwo" class="panel-collapse collapse">

                                            <div class="checkbox-body-part">
                                                <ul>
                                                    <li>

                                                        <div class="checkbox checkbox-primary">
                                                            <asp:CheckBoxList runat="server" ID="chkboxComp" onclick="FilterClinicalList();" ></asp:CheckBoxList>
                                                        </div>
                                                    </li>
                                                </ul>
                                            </div>


                                        </div>
                                    </div>


                                    <div class="panel panel-default">
                                        <div class="panel-heading" data-toggle="collapse" data-parent="#accordion" href="#collapseClinical">
                                            <h4 class="panel-title">
                                                <a class="accordion-toggle">Clinical
                                                </a>
                                            </h4>
                                        </div>
                                        <div id="collapseClinical" class="panel-collapse collapse">



                                            <div class="checkbox-body-part">
                                                <ul>
                                                    <li>

                                                        <div class="checkbox checkbox-primary">
                                                            <asp:CheckBoxList runat="server" ID="chkClinical"></asp:CheckBoxList>
                                                        </div>
                                                    </li>
                                                </ul>
                                            </div>



                                        </div>
                                    </div>


                                    <div class="panel panel-default">
                                        <div class="panel-heading" data-toggle="collapse" data-parent="#accordion" href="#collapseModality">
                                            <h4 class="panel-title">
                                                <a class="accordion-toggle">Modality
                                                </a>
                                            </h4>
                                        </div>
                                        <div id="collapseModality" class="panel-collapse collapse">


                                            <div class="checkbox-body-part">
                                                <ul>
                                                    <li>

                                                        <div class="checkbox checkbox-primary">
                                                            <asp:CheckBoxList runat="server" ID="chkModality"></asp:CheckBoxList>
                                                        </div>
                                                    </li>
                                                </ul>
                                            </div>


                                        </div>
                                    </div>




                                    <div class="panel panel-default">
                                        <div class="panel-heading" data-toggle="collapse" data-parent="#accordion" href="#collapseApplications">
                                            <h4 class="panel-title">
                                                <a class="accordion-toggle">Clinical Applications
                                                </a>
                                            </h4>
                                        </div>
                                        <div id="collapseApplications" class="panel-collapse collapse">


                                            <div class="panel-body">
                                                <div class="form-check">
                                                    <div class="checkbox-body-part" style="padding: 0px">
                                                        <div class="checkbox checkbox-primary">
                                                            
                                                            <asp:CheckBox ID="chkwithCompMatch" runat="server" />                                                            
                                                            <label for="chkwithCompMatch">App with comparison match</label>

                                                            <asp:CheckBox ID="chkwithNOCompMatch" runat="server" />
                                                            <label for="chkwithNOCompMatch">App with no comparison match</label>

                                                        </div>
                                                    </div>


                                                    <br />
                                                    <div style="">

                                                        <ej:ToggleButton runat="server"  ID="ToggleButton1" DefaultText="Select All" ActiveText="Uncheck All" ClientSideOnChange="onCheckUncheckAll" CssClass="checkstyle"></ej:ToggleButton>

                                                    </div>
                                                    <br />



                                                    <div class="list_container">
                                                        
                                                        <ul id="list" class="checkbox checkbox-primary" style="margin-left:-39px;">

                                                            <%=GetClinicalData() %>
                                                        </ul>
                                                        
                                                    </div>



                                                    <asp:HiddenField ID="selected_elements" runat="server" />




                                                    


                                                </div>


                                            </div>
                                        </div>
                                    </div>
                                    <style>


		                                .ml-input-filter{
                                            margin-bottom:10px;
		                                }
                                        .ml-li {
                                            border-bottom: 1px solid #D0DBE0;
                                            /*//padding: 10px 10px 7px 10px;*/
                                            /*margin-right: 10px;*/
                                            padding: 0;
                                            list-style-type: none;
                                            
                                        }
			
		                            </style>


                                    <script>




 $("#chkModality_0").change(function (e) {

   // FilterClinicalGeneric("CT","#chkModality_0");
     FilterClinicalList();
    
 });




 $("#chkModality_1").change(function (e) {

   // FilterClinicalGeneric("MR","#chkModality_1");
     FilterClinicalList();
    
 });

 $("#chkModality_1").change(function (e) {

    //FilterClinicalGeneric("MM","#chkModality_2");
     FilterClinicalList();
    
 });

 $("#chkModality_3").change(function (e) {

    //FilterClinicalGeneric("MN_MI","#chkModality_3");
     FilterClinicalList();
    
 });

 $("#chkModality_4").change(function (e) {

    //FilterClinicalGeneric("PET","#chkModality_3");
     FilterClinicalList();
    
 });

 $("#chkModality_5").change(function (e) {

    //FilterClinicalGeneric("US","#chkModality_3");
     FilterClinicalList();
    
 });

function FilterClinicalGeneric( sItem , sCheckBoxName)
{    

   // var CompList= FilterClinicalCompetitor();

    var sFilter='';  
    var ul = document.getElementById("list");
    var items = ul.getElementsByTagName("li");
    for (var i = 0; i < items.length; ++i) {
      
        var sitem=items[i].children[0].id;
        var n = sitem.indexOf(sItem);
        //var comp = sitem.includes(CompList);

        if ( n>0 )
        {
            sFilter=sFilter + "'" + sitem.replace("list_checkbox_","") + "'" + ",";        
        }        
    
    }

    if ( sFilter !="")
    {
        sFilter = sFilter.slice(0, -1);

        var array = (new Function("return [" + sFilter + "];")());

        if ( $(sCheckBoxName).is(":checked") ==true)
        {
            $('#list').multiList('show',array); 
        }
        else
        {
            $('#list').multiList('hide',array); 

        }            
    }

}

function FilterClinicalList() {
    $('#list').multiList('showAll');

    var mod = false;
    var comp = false;
    var CompList = GetCheckedCompetitor();
    var Modality = GetCheckedModality();

    var sFilter = '';
    var ul = document.getElementById("list");
    var items = ul.getElementsByTagName("li");
    for (var i = 0; i < items.length; ++i) {

        var sitem = items[i].children[0].id;

        //Modality
        if (Modality.indexOf(",") > 0) {
            var ModArray = Modality.split(",");
            for (im = 0; im < ModArray.length; im++) {
                var resmod = sitem.indexOf(ModArray[im]);
                if (resmod > 0) {
                    mod = true;
                }
            }

        } else {
            mod = sitem.indexOf(Modality);
        }
        //

        //Competitor
        if (CompList.indexOf(",") > 0) {
            var CompArray = CompList.split(",");
            for (ic = 0; ic < CompArray.length; ic++) {

                if (CompArray[ic].trim() == "Siemens Medical") {
                    CompArray[ic] = "Siemens";
                }
                if (CompArray[ic].trim() == "GE Healthcare") {
                    CompArray[ic] = "GE";
                }

                var rescomp = sitem.indexOf(CompArray[ic]);
                if (rescomp > 0) {
                    comp = 2;
                    break;
                } else {
                    comp = -1;
                }
            }

        } else {

            if (CompList == "Siemens Medical") {
                CompList = "Siemens";
            }

            if (CompList == "GE Healthcare") {
                CompList = "GE";
            }

            comp = sitem.indexOf(CompList);
        }
        //


        // var mod = sitem.includes(Modality);
        //var comp = sitem.includes(CompList);




        if (mod < 0 || comp < 0) {
            sFilter = sFilter + "'" + sitem.replace("list_checkbox_", "") + "'" + ",";
        }

    }

    if (sFilter != "") {
        sFilter = sFilter.slice(0, -1);

        var array = (new Function("return [" + sFilter + "];")());

        //if ( $(sCheckBoxName).is(":checked") ==true)
        //{
        //    $('#list').multiList('show',array); 
        //}
        //else
        //{

        $('#list').multiList('hide', array);

        ////}            
    }

}
function GetCheckedCompetitor() {
    var elementRef = document.getElementById('chkboxComp');
    var checkBoxArray = elementRef.getElementsByTagName('input');
    var checkedValues = '';
    
    for (var i = 0; i < checkBoxArray.length; i++) {
        var checkBoxRef = checkBoxArray[i];

        if (checkBoxRef.checked == true) {


            var labelArray = checkBoxRef.parentNode.getElementsByTagName('label');

            if (labelArray.length > 0) {

                if (checkedValues.length > 0) {
                    checkedValues += ', ';
                }                
                checkedValues += labelArray[0].innerHTML;
            }
        }
    }


    if (checkedValues != "") {
       // FilterClinicalListforCompetitor(checkedValues);
    }


   return checkedValues;
}

function GetCheckedModality() {
    var elementRef = document.getElementById('chkModality');
    var checkBoxArray = elementRef.getElementsByTagName('input');
    var checkedValues = '';

    for (var i = 0; i < checkBoxArray.length; i++) {
        var checkBoxRef = checkBoxArray[i];

        if (checkBoxRef.checked == true) {


            var labelArray = checkBoxRef.parentNode.getElementsByTagName('label');

            if (labelArray.length > 0) {

                if (checkedValues.length > 0) {
                    checkedValues += ', ';
                }
                checkedValues += labelArray[0].innerHTML;
            }
        }
    }
    return checkedValues;
}

function FilterClinicalListforCompetitor(CompList) {
    var sFilter = '';
    var ul = document.getElementById("list");
    var items = ul.getElementsByTagName("li");
    for (var i = 0; i < items.length; ++i) {

        var sitem = items[i].children[0].id;
        var n = sitem.indexOf(CompList);

        if (n >0) {
            sFilter = sFilter + "'" + sitem.replace("list_checkbox_", "") + "'" + ",";
        }

    }

    if (sFilter != "") {
        sFilter = sFilter.slice(0, -1);

        var array = (new Function("return [" + sFilter + "];")());

        //if ( $(sCheckBoxName).is(":checked") ==true)
        //{
            $('#list').multiList('show',array); 
        //}
        //else
        //{
        //$('#list').multiList('hide',array); 

        //}            
    }

}


			$(document).ready(function() {

				$("#list").multiList();


				// elementChecked
				// "value" (the "value" attr from the li items) and "text (the full text)
				$("#list").on("multiList.elementChecked", function(event, value, text) {
					set_li();
				});

				// elementUnchecked
				// "value" (the "value" attr from the li items) and "text (the full text)
				$("#list").on("multiList.elementUnchecked", function(event, value, text) {
					set_li();
				});

				$("#list").trigger("multiList.elementChecked");
                FilterClinicalList();       


                <%=m_JavascriptClinical %>    
       
			});

        function set_li() {
            var selected_text = "";
            var selected_elements = $("#list").multiList("getSelectedFull");
            if (selected_elements.length > 0) {
                for (var i = 0; i < selected_elements.length; i++) {
                    selected_text += selected_elements[i][0];
                    if (i < selected_elements.length - 1) selected_text += ", ";
                }
            }
            $("#selected_elements").html(selected_text);


            $("#<%= selected_elements.ClientID %>").val(selected_text);



            var unselected_text = "";
            var unselected_elements = $("#list").multiList("getUnselected");
            if (unselected_elements.length > 0) {
                for (var i = 0; i < unselected_elements.length; i++) {
                    unselected_text += "<i>" + unselected_elements[i] + "</i>";
                    if (i < unselected_elements.length - 1) unselected_text += ", ";
                }
            }
            $("#unselected_elements").html(unselected_text);
        }


        function onCheckUncheckAll(args) {
            if (args.isChecked) {               
                    $('#list').multiList('selectAll');
            }
            else
                $('#list').multiList('unselectAll');
        }

                                    </script>

                                </div>

                                <br />
                                <button class="btn-primary submit show-hide-btn" type="button">Matrix Filters</button>



                                <div class="checkbox-body-part" style="margin-bottom:-1px;">
                                    <ul>
                                        <li>

                                            <div class="checkbox checkbox-primary">
                                                <input id="cboCompetitor" type="checkbox" checked="">
                                                <label for="cboCompetitor">
                                                    Competitor
                                                </label>
                                            </div>
                                        </li>
                                        <li>

                                            <div class="checkbox checkbox-primary">
                                                <input id="cboApplication" type="checkbox" checked="">
                                                <label for="cboApplication">
                                                    Application
                                                </label>
                                            </div>
                                        </li>
                                        <li>

                                            <div class="checkbox checkbox-primary">
                                                <input id="cboMatching" type="checkbox" checked="">
                                                <label for="cboMatching">
                                                    Philips matching app
                                                </label>
                                            </div>
                                        </li>
                                        <li>

                                            <div class="checkbox checkbox-primary">
                                                <input id="cboClinical" type="checkbox" checked="">
                                                <label for="cboClinical">
                                                    Clinical domain
                                                </label>
                                            </div>
                                        </li>



                                        <li>

                                            <div class="checkbox checkbox-primary">
                                                <input id="cboModality" type="checkbox" checked="">
                                                <label for="cboModality">
                                                    Modality
                                                </label>
                                            </div>
                                        </li>
                                        <li>

                                            <div class="checkbox checkbox-primary">
                                                <input id="cbo510" type="checkbox" checked="">
                                                <label for="cbo510">
                                                    510K
                                                </label>
                                            </div>
                                        </li>



                                        <li>

                                            <div class="checkbox checkbox-primary">
                                                <input id="cboOverview" type="checkbox" checked="">
                                                <label for="cboOverview">
                                                    Intend to Use
                                                </label>
                                            </div>
                                        </li>


                                         <li>

                                            <div class="checkbox checkbox-primary">
                                                <input id="cboFeatures" type="checkbox" checked="">
                                                <label for="cboFeatures">
                                                    Features and Capabilities
                                                </label>
                                            </div>
                                        </li>


                                        <li>

                                            <div class="checkbox checkbox-primary">
                                                <input id="cboweaknesses" type="checkbox" checked="">
                                                <label for="cboweaknesses">
                                                    Application weaknesses
                                                </label>
                                            </div>
                                        </li>
                                        <li>

                                            <div class="checkbox checkbox-primary">
                                                <input id="cbostrengths" type="checkbox" checked="">
                                                <label for="cbostrengths">
                                                    Application strengths
                                                </label>
                                            </div>
                                        </li>
                                        <li>

                                            <div class="checkbox checkbox-primary">
                                                <input id="cboArgumentation" type="checkbox" checked="">
                                                <label for="cboArgumentation">
                                                    Competitive Argumentation
                                                </label>
                                            </div>
                                        </li>
                                    </ul>
                                </div>





                                <asp:Button ID="Button1" Style="background: #002662; border: 1px solid #002662; width: 100%; height: 40px; line-height: 40px; text-transform: capitalize; font-size: 16px; margin-bottom: 4px; border-radius: 2px; font-weight: normal; color: #fff;"
                                    runat="server" Text="Reset All Filters" />


                            </div>
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-9 right-padding">
                            <div class="rightbar">
                                <ul class="nav nav-tabs">
                                    <li><a href="Competitors.aspx">competitors</a></li>
                                    <li class="active"><a href="Clinical.aspx">clinical</a></li>
                                    <li><a href="Enterprise.aspx">enterprise</a></li>
                                    <li><a href="Service.aspx">Services</a></li>
                                    <li><a href="Attachments.aspx">attachments</a></li>

                                </ul>


                                <div class="tab-content toshiba-content " style="display: inline-block; width: 1380px; height: 1118px;">
                                    <div id="home" class="tab-pane fade in active">


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

                                                    if (args.data.ColumnName == "Competitor") {

                                                        if (args.cell.innerText == "Philips") {                                                            
                                                            $(args.cell).css("backgroundColor", "#0b5ed7").css("color", "#fff"); 
                                                        }

                                                        //if (args.cell.innerText == "GE") {                                                            
                                                        //    $(args.cell).css("backgroundColor", "#0560ab").css("color", "#fff"); 
                                                        //}

                                                        //if (args.cell.innerText == "TeraRecon") {                                                            
                                                        //    $(args.cell).css("backgroundColor", "#6291cc").css("color", "#fff"); 
                                                        //}

                                                        //if (args.cell.innerText == "Siemens") {                                                            
                                                        //    $(args.cell).css("backgroundColor", "#f7931e").css("color", "#fff"); 
                                                        //}
                                                        
                                                        
                                                    }
                                                                                                        
         
                                               } 


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
                                                var gridObj = $('#<%= Grid1.ClientID %>').ejGrid("instance");
                                                args.model.columns[0]['visible'] = false;
                                                args.model.columns[0]['isPrimaryKey'] = true;
                                                gridObj.columns(args.model.columns);

                                                //Column lengths
                                                var idx = args.model.columns.length;
                                                for (i = 2; i < idx; i++) { 
                                                    args.model.columns[i].width= 350; 
                                                }                                                
                                                gridObj.columns(args.model.columns); 
                                                //Column lengths

                                                

                                                this.model.columns[1].allowEditing = false; 

                                                var idxEX = args.model.columns.length;
                                                for (i = 2; i < idxEX; i++) { 
                                                    this.model.columns[i].editTemplate = { create: "create", write: "write", read: "read" };
                                                } 
                                                 
                                                this.columns(this.model.columns);

                                                scrollcheck(args);
                                            }


                                                 function create() { 
                                                    return "<textarea rows='8' style='resize:none; width:100%'></textarea>"; 
                                                } 
 
                                                function write(args) { 
                                                    var colname = args.element.attr("name").split("."); 
                                                    $(args.element).val(args.rowdata[colname[0]][colname[1]]); 
                                                } 
 
                                                function read(args) { 
                                                    return args.val(); 
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

                                           
                                        </script>

                                        <div class="table_content-div">


                                            <div style="margin-top: 30px;">
                                                <%=AppCount() %>
                                                <div id="scroll"></div>
                                                <ej:Grid ID="Grid1" MinWidth="1200" Width="1360" runat="server" OnServerEditRow="EditEvents_ServerEditRow" AllowTextWrap="true" AllowResizing="true" AllowScrolling="true">
                                                    <ScrollSettings Width="180" FrozenColumns="2" />
                                                    <EditSettings AllowEditing="True"></EditSettings>
                                                    <ToolbarSettings ShowToolbar="True" ToolbarItems="edit,update,cancel"></ToolbarSettings>
                                                    <ClientSideEvents DataBound="createEvent" QueryCellInfo="GridQueryCellInfoEvent" />
                                                </ej:Grid>

                                            </div>


                                            <style type="text/css"> 
 
                                                .e-grid .e-rowcell{ 
                                                    vertical-align:top; 
                                                } 
                                                 .e-headercontent { 
                                                     /*display: none !important;*/ 
                                                     height:0px;
                                                } 
 
                                    </style>

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
                <div class="row">
                    <img src="images/footer-logo.png" class="img-responsive">
                    <h5><span>Privacy notice  |  Terms of use</span>
                        <br>
                        © Koninklijke Philips N.V., 2004 - 2019. All rights reserved. </h5>
                </div>
            </div>
        </footer>

    </form>


    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->

    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>


    <script>

         $("#cboCompetitor").change(function (e) {
                var gridObj = $("#Grid1").ejGrid("instance"); 
                if ($(this).is(":checked")) {
                    gridObj.getRowByIndex(0).show();
                }
                else
                {
                                                     
                    gridObj.getRowByIndex(0).hide();
                }
          });


          $("#cboApplication").change(function (e) {
                var gridObj = $("#Grid1").ejGrid("instance"); 
                if ($(this).is(":checked")) {
                    gridObj.getRowByIndex(1).show();
                }
                else
                {
                                                     
                    gridObj.getRowByIndex(1).hide();
                }
          });


          $("#cboMatching").change(function (e) {
                var gridObj = $("#Grid1").ejGrid("instance"); 
                if ($(this).is(":checked")) {
                    gridObj.getRowByIndex(2).show();
                }
                else
                {
                                                     
                    gridObj.getRowByIndex(2).hide();
                }
          });
          $("#cboClinical").change(function (e) {
                var gridObj = $("#Grid1").ejGrid("instance"); 
                if ($(this).is(":checked")) {
                    gridObj.getRowByIndex(3).show();
                }
                else
                {
                                                     
                    gridObj.getRowByIndex(3).hide();
                }
        });

        $("#cboModality").change(function (e) {
                var gridObj = $("#Grid1").ejGrid("instance"); 
                if ($(this).is(":checked")) {
                    gridObj.getRowByIndex(4).show();
                }
                else
                {
                                                     
                    gridObj.getRowByIndex(4).hide();
                }
        });

        


          $("#cbo510").change(function (e) {
                var gridObj = $("#Grid1").ejGrid("instance"); 
                if ($(this).is(":checked")) {
                    gridObj.getRowByIndex(5).show();
                }
                else
                {
                                                     
                    gridObj.getRowByIndex(5).hide();
                }
          });
          $("#cboOverview").change(function (e) {
                var gridObj = $("#Grid1").ejGrid("instance"); 
                if ($(this).is(":checked")) {
                    gridObj.getRowByIndex(6).show();
                }
                else
                {
                                                     
                    gridObj.getRowByIndex(6).hide();
                }
          });

         $("#cboFeatures").change(function (e) {
                var gridObj = $("#Grid1").ejGrid("instance"); 
                if ($(this).is(":checked")) {
                    gridObj.getRowByIndex(7).show();
                }
                else
                {
                                                     
                    gridObj.getRowByIndex(7).hide();
                }
        });

          $("#cboweaknesses").change(function (e) {
                var gridObj = $("#Grid1").ejGrid("instance"); 
                if ($(this).is(":checked")) {
                    gridObj.getRowByIndex(8).show();
                }
                else
                {
                                                     
                    gridObj.getRowByIndex(8).hide();
                }
          });

          $("#cbostrengths").change(function (e) {
                var gridObj = $("#Grid1").ejGrid("instance"); 
                if ($(this).is(":checked")) {
                    gridObj.getRowByIndex(9).show();
                }
                else
                {
                                                     
                    gridObj.getRowByIndex(9).hide();
                }
          });



          $("#cboArgumentation").change(function (e) {
                var gridObj = $("#Grid1").ejGrid("instance"); 
                if ($(this).is(":checked")) {
                    gridObj.getRowByIndex(10).show();
                }
                else
                {
                                                     
                    gridObj.getRowByIndex(10).hide();
                }
           });

          if ($("#cboApplication")[0].checked == false) {
                var gridObj = $("#Grid1").ejGrid("instance"); 
            gridObj.getRowByIndex(0).hide();
          }

          if ($("#cboMatching")[0].checked == false) {
                var gridObj = $("#Grid1").ejGrid("instance"); 
            gridObj.getRowByIndex(1).hide();
          }

          if ($("#cboClinical")[0].checked == false) {
                var gridObj = $("#Grid1").ejGrid("instance"); 
            gridObj.getRowByIndex(2).hide();
          }

        if ($("#cboModality")[0].checked == false) {
                var gridObj = $("#Grid1").ejGrid("instance"); 
            gridObj.getRowByIndex(3).hide();
        }

        if ($("#cbo510")[0].checked == false) {
                var gridObj = $("#Grid1").ejGrid("instance"); 
            gridObj.getRowByIndex(4).hide();
        }


          if ($("#cboOverview")[0].checked == false) {
                var gridObj = $("#Grid1").ejGrid("instance"); 
            gridObj.getRowByIndex(5).hide();
          }

          if ($("#cboweaknesses")[0].checked == false) {
                var gridObj = $("#Grid1").ejGrid("instance"); 
            gridObj.getRowByIndex(6).hide();
        }
         

        if ($("#cbostrengths")[0].checked == false) {
                var gridObj = $("#Grid1").ejGrid("instance"); 
            gridObj.getRowByIndex(7).hide();
        }
          
        if ($("#cboArgumentation")[0].checked == false) {
                var gridObj = $("#Grid1").ejGrid("instance"); 
            gridObj.getRowByIndex(8).hide();
        }          

    </script>



</body>
</html>