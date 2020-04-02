<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeFile="MV-Matrix.aspx.cs" Inherits="_Home" MaintainScrollPositionOnPostback="true" %>

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
    <title>MV-Matrix</title>

    <!-- Bootstrap -->
    <link href="/css/bootstrap.min.css" rel="stylesheet">
    <link href="/css/style.css" rel="stylesheet">
    <link href="/css/responsive.css" rel="stylesheet">
    <link rel="stylesheet" href="../css/font-awesome.min.css">
    
    

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>ISP
      <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->

   <link href="https://cdn.syncfusion.com/16.1.0.37/js/web/flat-azure/ej.web.all.min.css" rel="stylesheet" />
    <script src='<%= Page.ResolveClientUrl("~/js/ej/jquery-1.11.3.min.js")%>' type="text/javascript"></script>
    <script src='<%= Page.ResolveClientUrl("https://code.jquery.com/jquery-1.11.3.min.js")%>' type="text/javascript"></script>
    <script src='<%= Page.ResolveClientUrl("https://cdn.syncfusion.com/js/assets/external/jsrender.min.js")%>' type="text/javascript"></script>
    <script src='<%= Page.ResolveClientUrl("https://cdn.syncfusion.com/16.1.0.37/js/web/ej.web.all.min.js")%>' type="text/javascript"></script>

    <style>
         .e-btn.e-txt.e-select, .e-tbtn.e-txt.e-select {
            background-color: #178bc6;
            color: white;
            width: 85px;
        }

         


    </style>

        <asp:Literal ID="RadioCss"  runat="server">       
          <style>
            input[type=checkbox] {
                display: none !important ;
            }
            input[type=checkbox] + *:before {
              content: "";
              display: inline-block;
              margin: 0 0.4em;
              /* Make some horizontal space. */
              width: .6em;
              height: .6em;
              border-radius: 0.6em;
              box-shadow: 0px 0px 0px .5px #888
              /* An outer circle. */
              ;
              /* No inner circle. */
              background-color: #ddd;
              /* Inner color. */
              margin-left: -18px;
            }
            input[type=checkbox]:checked + *:before {
              box-shadow: 0px 0px 0px .5px #888
              /* An outer circle. */
              , inset 0px 0px 0px .14em #ddd;
              /* An inner circle with above inner color.*/
              background-color: #444;
              /* The dot color */
            }
          </style>
        </asp:Literal>


    <script>

        function ISPCheck(element, id) {
             if (id == "chkISP10")
             {                 
                 document.getElementById('<%=chkISP10.ClientID%>').checked = true;
                 document.getElementById('<%=chkISP9.ClientID%>').checked = false;
             }
           else {               
               document.getElementById('<%=chkISP9.ClientID%>').checked = true;
               document.getElementById('<%=chkISP10.ClientID%>').checked = false;
            }
        }

        function ModalityCheck(element, id) {
            if (document.getElementById(id).checked == true) {
                document.getElementById('<%=chkCT.ClientID%>').checked = false;
               document.getElementById('<%=chkMR.ClientID%>').checked = false;
               document.getElementById('<%=chkMMV.ClientID%>').checked = false;
               document.getElementById('<%=chkNMSpect.ClientID%>').checked = false;
               document.getElementById('<%=chkNMPet.ClientID%>').checked = false;
               document.getElementById(id).checked = true;
           }
           else {
               document.getElementById('<%=chkCT.ClientID%>').checked = false;
               document.getElementById('<%=chkMR.ClientID%>').checked = false;
               document.getElementById('<%=chkMMV.ClientID%>').checked = false;
               document.getElementById('<%=chkNMSpect.ClientID%>').checked = false;
               document.getElementById('<%=chkNMPet.ClientID%>').checked = false;
            }
        }

        function VendorCheck(element, id) {
            if (document.getElementById(id).checked == true) {
                document.getElementById('<%=chkSiemens.ClientID%>').checked = false;
               document.getElementById('<%=chkGE.ClientID%>').checked = false;
               document.getElementById('<%=chkToshiba.ClientID%>').checked = false;
               document.getElementById('<%=chkOthers.ClientID%>').checked = false;
               document.getElementById('<%=chkSamsung.ClientID%>').checked = false;
               document.getElementById('<%=chkMediso.ClientID%>').checked = false;
               document.getElementById('<%=chkElscint.ClientID%>').checked = false;
               document.getElementById('<%=chkSegami.ClientID%>').checked = false;
               document.getElementById(id).checked = true;
           }
           else {
               document.getElementById('<%=chkSiemens.ClientID%>').checked = false;
               document.getElementById('<%=chkGE.ClientID%>').checked = false;
               document.getElementById('<%=chkToshiba.ClientID%>').checked = false;
               document.getElementById('<%=chkOthers.ClientID%>').checked = false;
               document.getElementById('<%=chkSamsung.ClientID%>').checked = false;
               document.getElementById('<%=chkMediso.ClientID%>').checked = false;
               document.getElementById('<%=chkElscint.ClientID%>').checked = false;
               document.getElementById('<%=chkSegami.ClientID%>').checked = false;;
            }
        }

        function ModelCheck(element) {

            var elementRef = document.getElementById('chkboxModel');
            var checkBoxArray = elementRef.getElementsByTagName('input');
            var id = element.firstChild.id;

            for (var i = 0; i < checkBoxArray.length; i++) {

                var checkBoxRef = checkBoxArray[i];
                var labelArray = checkBoxRef.parentNode.getElementsByTagName('label');
                var myCheckBox = document.getElementById(labelArray[0].htmlFor)
                myCheckBox.checked = false;
            }
            document.getElementById(id).checked = true;
        }

        function SoftwareCheck(element) {

            var elementRef = document.getElementById('chkboxSoftware');
            var checkBoxArray = elementRef.getElementsByTagName('input');
            var id = element.firstChild.id;

            for (var i = 0; i < checkBoxArray.length; i++) {

                var checkBoxRef = checkBoxArray[i];
                var labelArray = checkBoxRef.parentNode.getElementsByTagName('label');
                var myCheckBox = document.getElementById(labelArray[0].htmlFor)
                myCheckBox.checked = false;
            }
            document.getElementById(id).checked = true;
        }

        
        function DomainCheck(element) {

            var elementRef = document.getElementById('chkboxDomain');
            var checkBoxArray = elementRef.getElementsByTagName('input');
            var id = element.firstChild.id;

            for (var i = 0; i < checkBoxArray.length; i++) {

                var checkBoxRef = checkBoxArray[i];
                var labelArray = checkBoxRef.parentNode.getElementsByTagName('label');
                var myCheckBox = document.getElementById(labelArray[0].htmlFor)
                myCheckBox.checked = false;
            }
            document.getElementById(id).checked = true;
        }

        function ModuleCheck(element) {

            var elementRef = document.getElementById('chkboxModule');
            var checkBoxArray = elementRef.getElementsByTagName('input');
            var id = element.firstChild.id;

            for (var i = 0; i < checkBoxArray.length; i++) {

                var checkBoxRef = checkBoxArray[i];
                var labelArray = checkBoxRef.parentNode.getElementsByTagName('label');
                var myCheckBox = document.getElementById(labelArray[0].htmlFor)
                myCheckBox.checked = false;
            }
            document.getElementById(id).checked = true;
        }

        function DefinitionCheck(element) {

            var elementRef = document.getElementById('chkboxDefinition');
            var checkBoxArray = elementRef.getElementsByTagName('input');
            var id = element.firstChild.id;

            for (var i = 0; i < checkBoxArray.length; i++) {

                var checkBoxRef = checkBoxArray[i];
                var labelArray = checkBoxRef.parentNode.getElementsByTagName('label');
                var myCheckBox = document.getElementById(labelArray[0].htmlFor)
                myCheckBox.checked = false;
            }
            document.getElementById(id).checked = true;
        }

        
        function OnchkModule(args) {

            if (args.isChecked) {
                
                var elementRef = document.getElementById('chkboxModule');
                var checkBoxArray = elementRef.getElementsByTagName('input');
                
                for (var i = 0; i < checkBoxArray.length; i++) {                    
                    checkBoxArray[i].checked = true;
                }
                
            }
            else {

                var elementRef = document.getElementById('chkboxModule');
                var checkBoxArray = elementRef.getElementsByTagName('input');
                
                for (var i = 0; i < checkBoxArray.length; i++) {                    
                    checkBoxArray[i].checked = false;
                }


            }
        }

        

        function OnchkDefinition(args) {

            if (args.isChecked) {
                
                var elementRef = document.getElementById('chkboxDefinition');
                var checkBoxArray = elementRef.getElementsByTagName('input');
                
                for (var i = 0; i < checkBoxArray.length; i++) {                    
                    checkBoxArray[i].checked = true;
                }
                
            }
            else {

                var elementRef = document.getElementById('chkboxDefinition');
                var checkBoxArray = elementRef.getElementsByTagName('input');
                
                for (var i = 0; i < checkBoxArray.length; i++) {                    
                    checkBoxArray[i].checked = false;
                }


            }
        }

        function OnchkDomain(args) {

            if (args.isChecked) {
                
                var elementRef = document.getElementById('chkboxDomain');
                var checkBoxArray = elementRef.getElementsByTagName('input');
                
                for (var i = 0; i < checkBoxArray.length; i++) {                    
                    checkBoxArray[i].checked = true;
                }
                
            }
            else {

                var elementRef = document.getElementById('chkboxDomain');
                var checkBoxArray = elementRef.getElementsByTagName('input');
                
                for (var i = 0; i < checkBoxArray.length; i++) {                    
                    checkBoxArray[i].checked = false;
                }


            }
        }

        function OnchkSoftware(args) {

            if (args.isChecked) {
                
                var elementRef = document.getElementById('chkboxSoftware');
                var checkBoxArray = elementRef.getElementsByTagName('input');
                
                for (var i = 0; i < checkBoxArray.length; i++) {                    
                    checkBoxArray[i].checked = true;
                }
                
            }
            else {

                var elementRef = document.getElementById('chkboxSoftware');
                var checkBoxArray = elementRef.getElementsByTagName('input');
                
                for (var i = 0; i < checkBoxArray.length; i++) {                    
                    checkBoxArray[i].checked = false;
                }


            }
        }

        function OnchkModel(args) {

            if (args.isChecked) {
                
                var elementRef = document.getElementById('chkboxModel');
                var checkBoxArray = elementRef.getElementsByTagName('input');
                
                for (var i = 0; i < checkBoxArray.length; i++) {                    
                    checkBoxArray[i].checked = true;
                }
                
            }
            else {

                var elementRef = document.getElementById('chkboxModel');
                var checkBoxArray = elementRef.getElementsByTagName('input');
                
                for (var i = 0; i < checkBoxArray.length; i++) {                    
                    checkBoxArray[i].checked = false;
                }


            }
        }

        function OnchkVendor(args) {
            if (args.isChecked) {

                document.getElementById('<%=chkSiemens.ClientID%>').checked = true;
                document.getElementById('<%=chkGE.ClientID%>').checked = true;
                document.getElementById('<%=chkToshiba.ClientID%>').checked = true;
                document.getElementById('<%=chkOthers.ClientID%>').checked = true;
                document.getElementById('<%=chkSamsung.ClientID%>').checked = true;
                document.getElementById('<%=chkMediso.ClientID%>').checked = true;
                document.getElementById('<%=chkElscint.ClientID%>').checked = true;
                document.getElementById('<%=chkSegami.ClientID%>').checked = true;

            }
            else {

                document.getElementById('<%=chkSiemens.ClientID%>').checked = false;
                document.getElementById('<%=chkGE.ClientID%>').checked = false;
                document.getElementById('<%=chkToshiba.ClientID%>').checked = false;
                document.getElementById('<%=chkOthers.ClientID%>').checked = false;
                document.getElementById('<%=chkSamsung.ClientID%>').checked = false;
                document.getElementById('<%=chkMediso.ClientID%>').checked = false;
                document.getElementById('<%=chkElscint.ClientID%>').checked = false;
                document.getElementById('<%=chkSegami.ClientID%>').checked = false;

            }

            SetupModelBox();
            SetupSoftwareBox();
            SetupDomainBox();
        }

        function OnchkModality(args) {

            if (args.isChecked) {
                document.getElementById('<%=chkCT.ClientID%>').checked = true;
                document.getElementById('<%=chkMR.ClientID%>').checked = true;
                document.getElementById('<%=chkMMV.ClientID%>').checked = true;
                document.getElementById('<%=chkNMSpect.ClientID%>').checked = true;
                document.getElementById('<%=chkNMPet.ClientID%>').checked = true;
            }
            else {
               document.getElementById('<%=chkCT.ClientID%>').checked = false;
               document.getElementById('<%=chkMR.ClientID%>').checked = false;
               document.getElementById('<%=chkMMV.ClientID%>').checked = false;
               document.getElementById('<%=chkNMSpect.ClientID%>').checked = false;
               document.getElementById('<%=chkNMPet.ClientID%>').checked = false;
            }

            SetupModelBox();
            SetupSoftwareBox();
            SetupDomainBox();
            SetupModuleBox();



        }

    </script>


</head>
<body>

    <form id="form1" runat="server">

        <asp:HiddenField ID="hidViewer" runat="server" />

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
                <div class="row" style="padding-bottom: 100px;">
                    <div class="top-header">
                        <div class="col-sm-12 col-xs-12 col-md-2 col-lg-2">
                            <a href="../">
                                <img src="/images/logo.png" class="img-responsive">
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
                                        <li class="icons"><a href="<%= Helper.GetUserGuide() %>" target="_blank" >User Guide</a></li>
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

                                                        <asp:Panel ID="PanSwitchUser" style="margin-top: 15px;" runat="server">

                                                            <span>Switch User Level</span>

                                                            <asp:DropDownList ID="ddlSwitchUser" OnSelectedIndexChanged="ddlSwitchUser_SelectedIndexChanged" AutoPostBack="True"  runat="server">
                                                                  <asp:ListItem>Super Admin</asp:ListItem>
                                                                  <asp:ListItem>Super Viewer</asp:ListItem>
                                                                  <asp:ListItem>Content Admin</asp:ListItem>
                                                                  <asp:ListItem>Editor</asp:ListItem>
                                                                  <asp:ListItem>Viewer</asp:ListItem>
                                                            </asp:DropDownList>
                                                        </asp:Panel>


                                                        <script>

                                                            function Myclick() {
                                                                window.location.replace("/Account/Signin?Type=LogOut");
                                                            }

                                                        </script>
                                                        <%--<asp:LinkButton ID="cmdLogout" CssClass="view_prfl" OnClick="cmdLogout_Click" OnClientClick="Myclick();" runat="server">Log out <span><i class="fa fa-angle-right" aria-hidden="true"></i></span></asp:LinkButton>--%>

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

                                <asp:Button ID="cmdSubmit" Style="background: #002662; border: 1px solid #002662; width: 100%; height: 40px; line-height: 40px; text-transform: capitalize; font-size: 16px; margin-bottom: 4px; border-radius: 2px; font-weight: normal; color: #fff;"
                                    runat="server" Text="submit" OnClick="cmdSubmit_Click" />

                                <div class="panel-group" id="accordion">
                                    <div class="panel panel-default">
                                        <div class="panel-heading" data-toggle="collapse" data-parent="#accordion" href="#collapseOne">
                                            <h4 class="panel-title">
                                                <a class="accordion-toggle">ISP Release*
                                                </a>
                                            </h4>
                                        </div>
                                        <div id="collapseOne" class="panel-collapse collapse ">
                                           
                                            
                                            <asp:Panel ID="PanISP" runat="server">
                                                <script type="text/javascript">

                                                     function chkISP8JS(obj) {

                                                        if (obj.checked == true) {
                                                             $("#chkISP10").prop('checked', false);
                                                            $("#chkISP9").prop('checked', false);
                                                            $("#chkISP8").prop('checked', true);
                                                              $("#chkISP11").prop('checked', false);
                                                            
                                                        } else {
                                                            $("#chkISP10").prop('checked', true);
                                                            $("#chkISP9").prop('checked', false);
                                                            $("#chkISP8").prop('checked', false);
                                                              $("#chkISP11").prop('checked', false);

                                                        }                                                                                                                 
                                                    }

                                                    function chkISP9JS(obj) {

                                                        if (obj.checked == true) {
                                                             $("#chkISP10").prop('checked', false);
                                                            $("#chkISP9").prop('checked', true);
                                                              $("#chkISP11").prop('checked', false);
                                                            
                                                        } else {
                                                            $("#chkISP10").prop('checked', true);
                                                            $("#chkISP9").prop('checked', false);
                                                              $("#chkISP11").prop('checked', false);

                                                        }                                                                                                                 
                                                    }

                                                    function chkISP10JS(obj) {

                                                        if (obj.checked == true) {
                                                             $("#chkISP9").prop('checked', false);
                                                            $("#chkISP10").prop('checked', true);
                                                              $("#chkISP11").prop('checked', false);
                                                            
                                                        } else {
                                                            $("#chkISP9").prop('checked', true);
                                                            $("#chkISP10").prop('checked', false);
                                                              $("#chkISP11").prop('checked', false);

                                                        }                                                                                                                 
                                                    }          

                                                     function chkISP11JS(obj) {

                                                        if (obj.checked == true) {
                                                             $("#chkISP9").prop('checked', false);
                                                            $("#chkISP10").prop('checked', false);
                                                            $("#chkISP11").prop('checked',true );
                                                            
                                                        } else {
                                                            $("#chkISP9").prop('checked', false);
                                                            $("#chkISP10").prop('checked', false);
                                                             $("#chkISP10").prop('checked', false);

                                                        }                                                                                                                 
                                                    }    

                                                </script>
                                            </asp:Panel>

                                            <asp:Panel ID="PanISPNormal" runat="server">
                                                <script type="text/javascript">


                                                    function chkISP9JS(obj) {

                                                                                                                                                                    
                                                    }

                                                    function chkISP10JS(obj) {
                                                                                                             
                                                    }                                                      

                                                </script>
                                            </asp:Panel>
                                            
                                            

                                             <div class="checkbox-body-part" style="margin-left: 19px;width: 90%;">
									<ul>
                                        <li>
											
											<div class="checkbox checkbox-primary">

                                                
												<asp:CheckBox ID="chkISP5" onclick="javascript:chkISP5JS(this)" runat="server" />                                                                                               

												<label for="chkISP5" class="philips">
													5.0
												</label>
											</div>
										</li> 
                                        <li>
											
											<div class="checkbox checkbox-primary">

                                                
												<asp:CheckBox ID="chkISP6" onclick="javascript:chkISP6JS(this)" runat="server" />                                                                                               

												<label for="chkISP6" class="philips">
													6.0
												</label>
											</div>
										</li> 
                                        <li>
											
											<div class="checkbox checkbox-primary">

                                                
												<asp:CheckBox ID="chkISP7" onclick="javascript:chkISP7JS(this)" runat="server" />                                                                                               

												<label for="chkISP7" class="philips">
													7.0
												</label>
											</div>
										</li> 
                                        <li>
											
											<div class="checkbox checkbox-primary">

                                                
												<asp:CheckBox ID="chkISP8" onclick="javascript:chkISP8JS(this)" runat="server" />                                                                                               

												<label for="chkISP8" class="philips">
													8.0
												</label>
											</div>
										</li> 

										 <li>
											
											<div class="checkbox checkbox-primary">

                                                
												<asp:CheckBox ID="chkISP9" onclick="javascript:chkISP9JS(this)" runat="server" />                                                                                               

												<label for="chkISP9" class="philips">
													9.0
												</label>
											</div>
										</li> 
										<li>
											
											<div class="checkbox checkbox-primary">
                                               
												<asp:CheckBox ID="chkISP10" onclick="javascript:chkISP10JS(this)"  runat="server" />
                                                

												<label for="chkISP10" class="teracon">
													10.0
												</label>
											</div>
										</li>
										
										<li>
											
											<div class="checkbox checkbox-primary">
                                               
												<asp:CheckBox ID="chkISP11" onclick="javascript:chkISP11JS(this)"  runat="server" />
                                                

												<label for="chkISP11" class="teracon">
													11.0
												</label>
											</div>
										</li>
									
										
										
									</ul>
								</div>

                                            
                                        </div>
                                    </div>
                                    <div class="panel panel-default">
                                        <div class="panel-heading" data-toggle="collapse" data-parent="#accordion" href="#collapseTwo">
                                            <h4 class="panel-title">
                                                <a class="accordion-toggle">Modality*
                                                </a>
                                            </h4>
                                        </div>
                                        <div id="collapseTwo" class="panel-collapse collapse">

                                            <div style="padding-top: 10px;padding-left: 32px;">
                                                <ej:ToggleButton runat="server" ID="btnchkModality" DefaultText="Check All" ActiveText="Uncheck All" CssClass="checkstyle" ClientSideOnChange="OnchkModality"></ej:ToggleButton>
                                            </div>

                                            <div class="checkbox-body-part" style="margin-left: 19px;width: 90%;">
									<ul>
										 <li>
											
											<div class="checkbox checkbox-primary">
												 <asp:CheckBox ID="chkCT"  runat="server" />
												<label for="chkCT" class="philips">
													CT
												</label>
											</div>
										</li> 
										<li>
											
											<div class="checkbox checkbox-primary">
												<asp:CheckBox ID="chkMR"  runat="server" />

												<label for="chkMR" class="teracon">
													MR
												</label>
											</div>
										</li>
										<li>
											
											<div class="checkbox checkbox-primary">
												 <asp:CheckBox ID="chkMMV"  runat="server" />
												<label for="chkMMV" class="MMV">
													US
												</label>
											</div>
										</li>
										<li>
											
											<div class="checkbox checkbox-primary">
												 <asp:CheckBox ID="chkNMSpect"  runat="server" />
												<label for="chkNMSpect" class="health">
													NM-SPECT
												</label>
											</div>
										</li>
										<li>
											
											<div class="checkbox checkbox-primary">
												<asp:CheckBox ID="chkNMPet"  runat="server" />
												<label for="chkNMPet" class="canon">
													NM-PET
												</label>
											</div>
										</li>
										
									
										
										
									</ul>
								</div>





                                            
                                        </div>
                                    </div>
                                    <div class="panel panel-default">
                                        <div class="panel-heading" data-toggle="collapse" data-parent="#accordion" href="#collapseThree">
                                            <h4 class="panel-title">
                                                <a class="accordion-toggle">Vendor*
                                                </a>
                                            </h4>
                                        </div>
                                        <div id="collapseThree" class="panel-collapse collapse">

                                            <div style="padding-top: 10px;padding-left: 32px;">
                                                <ej:ToggleButton runat="server" ID="btnchkVendor" DefaultText="Check All" ActiveText="Uncheck All" CssClass="checkstyle" ClientSideOnChange="OnchkVendor"></ej:ToggleButton>
                                            </div>

                                            <div class="checkbox-body-part" style="margin-left:19px;width:90%">
									            <ul>

                                                    <li>											
											            <div class="checkbox checkbox-primary">
												                <asp:CheckBox ID="chkElscint" runat="server" />
												            <label for="chkElscint" class="philips">
													            Elscint
												            </label>
											            </div>
										            </li> 

                                                     <li>											
											            <div class="checkbox checkbox-primary">
												              <asp:CheckBox ID="chkGE" runat="server" />
												            <label for="chkGE" class="philips">
													            GE
												            </label>
											            </div>
										            </li> 

                                                     <li>											
											            <div class="checkbox checkbox-primary">
												                <asp:CheckBox ID="chkMediso" runat="server" />
												            <label for="chkMediso" class="philips">
													            Mediso
												            </label>
											            </div>
										            </li> 

                                                     <li>											
											            <div class="checkbox checkbox-primary">
												               <asp:CheckBox ID="chkOthers" runat="server" />
												            <label for="chkOthers" class="philips">
													            Others
												            </label>
											            </div>
										            </li> 

                                                     <li>											
											            <div class="checkbox checkbox-primary">
												                <asp:CheckBox ID="chkSamsung" runat="server" />
												            <label for="chkSamsung" class="philips">
													            Samsung
												            </label>
											            </div>
										            </li> 

                                                     <li>											
											            <div class="checkbox checkbox-primary">
												                <asp:CheckBox ID="chkSegami" runat="server" />
												            <label for="chkSegami" class="philips">
													            Segami
												            </label>
											            </div>
										            </li> 

										             <li>											
											            <div class="checkbox checkbox-primary">
												              <asp:CheckBox ID="chkSiemens" runat="server" />
												            <label for="chkSiemens" class="philips">
													            Siemens
												            </label>
											            </div>
										            </li> 
										
                                                    

                                                      <li>											
											            <div class="checkbox checkbox-primary">
												              <asp:CheckBox ID="chkToshiba" runat="server" />
												            <label for="chkToshiba" class="philips">
													            Toshiba
												            </label>
											            </div>
										            </li> 

                                                    
									
                                                    

                                                    

                                                     

                                                    
										
										
									            </ul>
								            </div>

                                            
                                        </div>
                                    </div>
                                    <div class="panel panel-default">
                                        <div class="panel-heading" data-toggle="collapse" data-parent="#accordion" href="#collapsefour">
                                            <h4 class="panel-title">
                                                <a class="accordion-toggle">Model <%=GetModelRequired() %>
                                                </a>
                                            </h4>
                                        </div>
                                        <div id="collapsefour" class="panel-collapse collapse">


                                            <div style="padding-top: 10px;padding-left: 17px;">
                                                <ej:ToggleButton runat="server" ID="chkboxModelToggle" DefaultText="Check All" ActiveText="Uncheck All" CssClass="checkstyle" ClientSideOnChange="OnchkModel"></ej:ToggleButton>
                                            </div>
                                            
                                             <div class="checkbox-body-part">
                                                <ul>
                                                    <li>

                                                        <div class="checkbox checkbox-primary">
                                                            <asp:CheckBoxList  CssClass="checkboxlist" runat="server" ID="chkboxModel"></asp:CheckBoxList>
                                                        </div>
                                                    </li>
                                                </ul>
                                            </div>

                                           
                                            

                                        </div>
                                    </div>
                                    <div class="panel panel-default">
                                        <div class="panel-heading" data-toggle="collapse" data-parent="#accordion" href="#collapsefive">
                                            <h4 class="panel-title">
                                                <a class="accordion-toggle">Software <%=GetModelRequired() %>
                                                </a>
                                            </h4>
                                        </div>
                                        <div id="collapsefive" class="panel-collapse collapse">


                                            <div style="padding-top: 10px;padding-left: 17px;">
                                                <ej:ToggleButton runat="server" ID="chkboxSoftwareToggle" DefaultText="Check All" ActiveText="Uncheck All" CssClass="checkstyle" ClientSideOnChange="OnchkSoftware"></ej:ToggleButton>
                                            </div>

                                            <div class="checkbox-body-part" style="width: 210px;">
                                                <ul>
                                                    <li>

                                                        <div class="checkbox checkbox-primary">
                                                            <asp:CheckBoxList runat="server" CssClass="checkboxlist"   ID="chkboxSoftware"></asp:CheckBoxList>
                                                        </div>
                                                    </li>
                                                </ul>
                                            </div>


                                           
                                        </div>
                                    </div>
                                    <div class="panel panel-default">
                                        <div class="panel-heading" data-toggle="collapse" data-parent="#accordion" href="#collapsesix">
                                            <h4 class="panel-title">
                                                <a class="accordion-toggle">Domain
                                                </a>
                                            </h4>
                                        </div>
                                        <div id="collapsesix" class="panel-collapse collapse">

                                            <div style="padding-top: 10px;padding-left: 30px;">
                                                <ej:ToggleButton runat="server" ID="chkboxDomainToggle" DefaultText="Check All" ActiveText="Uncheck All" CssClass="checkstyle" ClientSideOnChange="OnchkDomain"></ej:ToggleButton>
                                            </div>

                                             <div class="checkbox-body-part" style="margin-left:18px;width:90%;">
                                                <ul>
                                                    <li>

                                                        <div class="checkbox checkbox-primary" id="Domain">
                                                            <asp:CheckBoxList runat="server" ID="chkboxDomain"></asp:CheckBoxList>
                                                        </div>
                                                    </li>
                                                </ul>
                                            </div>


                                           
                                        </div>
                                    </div>
                                    <div class="panel panel-default">
                                        <div class="panel-heading" data-toggle="collapse" data-parent="#accordion" href="#collapseseven">
                                            <h4 class="panel-title">
                                                <a class="accordion-toggle">Module
                                                </a>
                                            </h4>
                                        </div>
                                        <div id="collapseseven" class="panel-collapse collapse">

                                            <div style="padding-top: 10px;padding-left: 10px;">
                                                <ej:ToggleButton runat="server" ID="OnchkModuleToggle" DefaultText="Check All" ActiveText="Uncheck All" CssClass="checkstyle" ClientSideOnChange="OnchkModule"></ej:ToggleButton>
                                            </div>

                                            <div class="checkbox-body-part">
                                                <ul>
                                                    <li>

                                                        <div class="checkbox checkbox-primary" id="Module">
                                                            <asp:CheckBoxList runat="server" ID="chkboxModule"></asp:CheckBoxList>
                                                        </div>
                                                    </li>
                                                </ul>
                                            </div>

                                           
                                        </div>
                                    </div>

                                    <asp:Panel ID="PanelDataDef2" runat="server" style="margin-top: 2px;">
                                        <div class="panel panel-default">
                                            <div class="panel-heading" data-toggle="collapse" data-parent="#accordion" href="#collapsenine">
                                                <h4 class="panel-title">
                                                    <a class="accordion-toggle">Data Set Definition
                                                    </a>
                                                </h4>
                                            </div>
                                            <div id="collapsenine" class="panel-collapse collapse">
                                                
                                                
                                                 <div style="padding-top: 10px;padding-left: 10px;">
                                                    <ej:ToggleButton runat="server" ID="OnchkDefinitionToggle" DefaultText="Check All" ActiveText="Uncheck All" CssClass="checkstyle" ClientSideOnChange="OnchkDefinition"></ej:ToggleButton>
                                                 </div>

                                                <div class="checkbox-body-part">
                                                <ul>
                                                    <li>

                                                        <div class="checkbox checkbox-primary">
                                                           <asp:CheckBoxList runat="server" ID="chkboxDefinition"></asp:CheckBoxList>
                                                        </div>
                                                    </li>
                                                </ul>
                                            </div>

                                                
                                            </div>
                                        </div>
                                    </asp:Panel>
                                </div>

                                <div class="required-fields">
                                    <h5>*required fields</h5>


                                     <button class="btn-primary submit show-hide-btn" type="button"  >Matrix Filters</button>

                                    <div class="checkbox-body-part" style="padding-left:27px;" id="MatrixFilters">
                                        <ul>
                                            <li>

                                                <div class="checkbox checkbox-primary" >
                                                    <asp:CheckBox ID="chkISP" runat="server" />
                                                    <label for="chkISP">
                                                        ISP
                                                    </label>
                                                </div>
                                            </li>
                                            <li>

                                                <div class="checkbox checkbox-primary">
                                                    <asp:CheckBox ID="chkColVendor" runat="server" />
                                                    <label for="chkColVendor">
                                                        Vendor
                                                    </label>
                                                </div>
                                            </li>
                                            <li>

                                                <div class="checkbox checkbox-primary">
                                                    <asp:CheckBox ID="chkColModel" runat="server" />
                                                    <label for="chkColModel">
                                                        Model
                                                    </label>
                                                </div>
                                            </li>



                                            <li>

                                               <div class="checkbox checkbox-primary">
                                                    <asp:CheckBox ID="chkColSoftware" runat="server" />
                                                    <label for="chkColSoftware">
                                                        Software
                                                    </label>
                                                </div>
                                            </li>
                                            <li>

                                                <div class="checkbox checkbox-primary">
                                                    <asp:CheckBox ID="chkColModality" runat="server" />
                                                    <label for="chkColModality">
                                                        Modality
                                                    </label>
                                                </div>
                                            </li>



                                            <li>

                                               <div class="checkbox checkbox-primary">
                                                    <asp:CheckBox ID="chkColDomain" runat="server" />
                                                    <label for="chkColDomain">
                                                        Domain
                                                    </label>
                                                </div>
                                            </li>
                                            <li>

                                               <div class="checkbox checkbox-primary">
                                                    <asp:CheckBox ID="chkColModule" runat="server" />
                                                    <label for="chkColModule">
                                                        Module
                                                    </label>
                                                </div>
                                            </li>
                                            <asp:Panel ID="PanelDataDef1" runat="server">
                                                <li>

                                                    <div class="checkbox checkbox-primary">
                                                        <asp:CheckBox ID="chkColDefinition" runat="server" />
                                                        <label for="chkColDefinition">
                                                            Data Def.
                                                        </label>
                                                    </div>
                                                </li>
                                            </asp:Panel>

                                        </ul>
                                    </div>

                                </div>

                                <asp:Button ID="Button1" Style="background: #002662; border: 1px solid #002662; width: 100%; height: 40px; line-height: 40px; text-transform: capitalize; font-size: 16px; margin-bottom: 4px; border-radius: 2px; font-weight: normal; color: #fff;"
                                    runat="server" Text="submit" OnClick="cmdSubmit_Click" />

                            </div>
                        </div>

                        <asp:Panel ID="panFeedBack" runat="server">
                            <div class="col-lg-9 col-md-9 col-sm-9 right-padding">
                                <div class="alert alert-success">
                                    <strong>Error!</strong>
                                    <asp:Label ID="lblFeedBack" runat="server" Text=""></asp:Label>
                                </div>
                            </div>
                        </asp:Panel>



                        <div class="col-lg-9 col-md-9 col-sm-9 right-padding">
                            <div class="rightbar">
                                <ul class="nav nav-tabs">
                                    <li class="active"><a data-toggle="tab" href="#home">MV Matrix</a></li>

                                </ul>

                                <div class="tab-content ">
                                    <div id="home" class="tab-pane fade in active">

                                        <div class="multi-vendor-title">
                                            <h3>ISP Multi-Vendor Compatability
											  

                                               <div class="remove_right">
                                                   <div class="save-search"><b><%=m_FilterLabel %></b></div>
                                                   <ul class=" agree-btn_b">


                                                       <asp:Panel ID="PanRemoveFav" runat="server">

                                                           <li>

                                                               <%--<div> <%=m_FilterLabel %></div> --%>

                                                               <div class="dropdown ">

                                                                   <span class=" dropdown-toggle" type="button" id="dropdownMenuButton" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                                                       <i class="fa fa-star" aria-hidden="true"></i><b>  Remove</b>
                                                                   </span>
                                                                   <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">

                                                                       <div class="phillips-acc sure-page">
                                                                           <h3>Are you sure?</h3>

                                                                           <div class="send-top_btn">


                                                                               <asp:LinkButton ID="lnkFavRemoveYes" CssClass="send form-control" OnClick="lnkFavRemoveYes_Click" runat="server">Yes</asp:LinkButton>
                                                                               <asp:LinkButton ID="lnkFavRemoveCancel" CssClass="send form-control" runat="server">Cancel</asp:LinkButton>

                                                                           </div>
                                                                       </div>
                                                                   </div>
                                                               </div>
                                                           </li>


                                                       </asp:Panel>

                                                       
                                                       <asp:Panel ID="PanAddFav" runat="server">
                                                           <li>
                                                               <div class="dropdown ">
                                                                   <span class=" dropdown-toggle" type="button" id="dropdownMenuButton" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                                                       <i class="fa fa-star-o" aria-hidden="true"></i><b>  Add</b>
                                                                   </span>
                                                                   <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
                                                                       <div class="footer-fixed">
                                                                           <button type="button" aria-hidden="true" class="close" data-notify="dismiss">
                                                                               <img src="/images/notif_close_1.png"/>
                                                                           </button>
                                                                       </div>
                                                                       <div class="phillips-acc">

                                                                           <div class="form-group">
                                                                               <asp:TextBox ID="txtFavLabel" CssClass="form-control" runat="server" MaxLength="20" placeholder="Enter favorite name"></asp:TextBox>
                                                                           </div>

                                                                           <div class="form-group">
                                                                               <asp:LinkButton CssClass="send form-control" ID="lnkFavSave" Text=" Add to favorites" OnClick="lnkFavSave_Click" runat="server"></asp:LinkButton>
                                                                           </div>

                                                                       </div>
                                                                   </div>
                                                               </div>
                                                           </li>
                                                       </asp:Panel>



                                                       <li>
                                                           <div class="dropdown ">


                                                               <span class=" dropdown-toggle" type="button" id="dropdownMenuButton" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                                                   <i class="fa fa-list-ul" aria-hidden="true"></i><b>  Favorites List</b>
                                                               </span>
                                                               <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
                                                                   <div class="footer-fixed">
                                                                       <button type="button" aria-hidden="true" class="close" data-notify="dismiss">
                                                                           <img src="images/notif_close_1.png"></button></div>
                                                                   <div class="phillips-acc favoritelink">
                                                                       <ul>


                                                                           <asp:Repeater ID="repFavList" runat="server">
                                                                               <ItemTemplate>
                                                                                   <li><a href="/Home?FavListID=<%#  Eval("FilterID") %>"><span style="line-height: 20px;"><%#  Eval("OrderID") %>. <b><%#  Eval("FilterLabel") %></b>
                                                                                       <br />
                                                                                       Created on <%# FormatFavDate(Eval("JSONFilterDateTime")) %></span></a>
                                                                                   </li>
                                                                               </ItemTemplate>
                                                                           </asp:Repeater>

                                                                       </ul>
                                                                   </div>
                                                               </div>
                                                           </div>
                                                       </li>
                                                   </ul>

                                               </div>
                                                

                                            </h3>
                                        </div>


                                        <style> 

                                            
                                            .e-treegrid .e-gridcontent{ 
                                                box-sizing: content-box !important 
                                            } 


                                           .c-class1.e-treegrid .e-gridheader { 
                                                background-color: #f2f2f2 !important; 
                                            } 

                                           .DataElementBG { 
                                                
                                                background-color: #f2f2f2  !important; 
                                            } 



                                             .customcolorm1 {         
                                            background-color: #FF0000 !important; 
                                            left: 202px; 
                                            top: 10px;   
              
                                           } 

                                            .customcolor1 {         
                                            background-color: #c65911 !important; 
                                            left: 202px; 
                                            top: 10px;   
              
                                           } 
                                          
                                           .customcolor4 {         
                                            background-color: #ffcc00 !important; 
                                            left: 202px; 
                                            top: 10px;             
                                           } 

                                           .customcolor5 {         
                                            background-color: #009245 !important; 
                                            left: 202px; 
                                            top: 10px;             
                                           } 

                                            
                                           .customcolor0 {         
                                            background-color: #FFFFFF !important; 
                                            left: 202px; 
                                            top: 10px;             
                                           } 

                                            .customcolorNoColour {         
                                            background-color: #f2f2f2 !important; 
                                            left: 202px; 
                                            top: 10px;             
                                           } 

                                            
                                            
                                          .ganttcolorCell { 
                                           
                                            margin-left: 15px; 
                                            height: 20px !important; 
                                            width: 50px !important;                 
                                           } 
                                         </style> 


                                       <script type="text/x-jsrender" id="colorBox"> 
                                                <div class="ganttcolorCell"></div> 
                                       </script> 

                                       <div class="table_content-div">


                                           <asp:Panel ID="mainPanel" runat="server">

                                               <div style="font-size: 22px;font-weight:bold;">Choose your selection using the dropdown filter lists on the left <br />and when you are ready click submit to populate the table</div>

                                           </asp:Panel>

                                           <div id="customScrollbar" style="overflow-x:scroll;" onscroll="scollPos(event);">
                                                <div id="customDivScrollbar" style="height:1px;"></div>
                                            </div>


                                         

                                            <ej:TreeGrid ID="TreeGrid" Height="10px" AllowPaging="false" CssClass="c-class1" AllowColumnResize="true" ShowColumnChooser="true" ColumnResized="ColumnResized"  Create="create" ChildMapping="Children" AllowTextWrap="true" QueryCellInfo="queryCellInfo"  TreeColumnIndex="4" Style="height: 10px;" runat="server">
                                                
                                                <SizeSettings Width="100%" Height="550px" />
                                                <EditSettings AllowEditing="false" AllowAdding="false" AllowDeleting="true"></EditSettings>
                                                <ToolbarSettings ShowToolbar="false" ToolbarItems="pdfExport,excelExport,print" />
                                            </ej:TreeGrid>




                                           <asp:Literal ID="RadioJS" runat="server">

                                                <script> 

                                                                                                     

                                                var els = document.querySelectorAll('.checkbox')
                                                    for (var i = 0; i < els.length; i++) {
                                                        if (els[i].parentNode.parentNode.parentNode.parentNode.className == "required-fields" | els[i].id == "Module" | els[i].id == "Domain" ) {
                                                            
                                                        } else {
                                                            els[i].classList.remove('checkbox')
                                                        }
                                                }

                                                var els = document.querySelectorAll('.checkbox-primary')
                                                for (var i = 0; i < els.length; i++) {                                               
                                                    if (els[i].parentNode.parentNode.parentNode.parentNode.className == "required-fields" | els[i].id == "Module" | els[i].id == "Domain" ) {

                                                    } else {
                                                        els[i].classList.remove('checkbox-primary');
                                                    }                                               
                                                }

                                                </script>
                                           </asp:Literal>
         
        

                                           
                                           

                                        <script> 
             

                                            function create(args) {

                                                var proxy = this;
                                                if ($("#" + proxy._id).find(".e-hscrollbar").length) {
                                                    var width = $("#" + proxy._id).width();
                                                    $("#customDivScrollbar").css("width", $("#" + proxy._id + "e-table").width() + 20);
                                                    $("#customScrollbar").css("width", width);
                                                }
                                                else {
                                                    $("#customScrollbar").hide();
                                                    $("#customDivScrollbar").hide();
                                                }
                                                if (args.model.columns.length == 10) {
                                                    var treeObj = $("#TreeGrid").data("ejTreeGrid");
                                                    treeObj.hideColumn("Progress") //Passing column name 
                                                }
                                            }

                                            function ColumnResized(args) {

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
                                            }
        
                                            function scollPos(e) {
                                                var treeObj = $("#TreeGrid").data("ejTreeGrid");
                                                var scrollObj = treeObj.getScrollElement().data("ejScroller");
                                                scrollObj.option("scrollLeft", $(e.target).scrollLeft())
                                            }

                                            $(window).on('resize', function () {
                                                setTimeout(function () {
                                                    var treeObj = $("#TreeGrid").data("ejTreeGrid");
                                                    if ($("#TreeGrid").find(".e-hscrollbar").length) {
                                                        var width = $("#TreeGrid").width();
                                                        $("#customScrollbar").show();
                                                        $("#customDivScrollbar").show();
                                                        $("#customDivScrollbar").css("width", $("#" + treeObj._id + "e-table").width() + 20);
                                                        $("#customScrollbar").css("width", width);
                                                    }
                                                    else {
                                                        $("#customScrollbar").hide();
                                                        $("#customDivScrollbar").hide();
                                                    }
                                                }, 50);
                                            });

                                            $(document).ready(function () {

                                                    //$("#chkColDefinition").trigger("click");        
                                                    //HideDataSetDef();




                                                    
                                                    var WhiteparentItemcollection = [];
                                                    $("#chkWhiteFilter").change(function (e) { 

                                                        e = e || window.event;
                                                        var targetEle = e.target,
                                                            checkStatus = $(targetEle).is(':checked');
                                                        var removeRecords = [],
                                                            treeObj = $("#TreeGrid").data("ejTreeGrid"),
                                                            flatRecords = treeObj.model.flatRecords;
                                                        if (checkStatus==true) {
                                                            treeObj.option("dataSource", WhiteparentItemcollection);
                                                            WhiteparentItemcollection = [];
                                                        }
                                                        if (checkStatus==false) {
                                                            for (i = 0; i < treeObj.model.parentRecords.length; i++) {
                                                                WhiteparentItemcollection.push($.extend(true, {}, treeObj.model.parentRecords[i].item));
                                                            }
                                                            removeRecords = flatRecords.filter(function (record) {
                                                                return record.DataElement == 0
                                                            });
                                                            for (j = 0; j < removeRecords.length; j++) {
                                                                var args = [];
                                                                args.requestType = ej.TreeGrid.Actions.Delete;
                                                                args.data = removeRecords[j];
                                                                treeObj._removeRecords(args); //Method to remove the row
                                                            }
                                                            treeObj._ensureDataSource(args);
                                                            treeObj.updateHeight();
                                                        }                       
                                                    });

                                                    var GreenparentItemcollection = [];
                                                    $("#chkGreenFilter").change(function (e) {
                                                        e = e || window.event;
                                                        var targetEle = e.target,
                                                            checkStatus = $(targetEle).is(':checked');
                                                        var removeRecords = [],
                                                            treeObj = $("#TreeGrid").data("ejTreeGrid"),
                                                            flatRecords = treeObj.model.flatRecords;
                                                        if (checkStatus==true) {
                                                            treeObj.option("dataSource", GreenparentItemcollection);
                                                            GreenparentItemcollection = [];
                                                        }
                                                        if (checkStatus==false) {
                                                            for (i = 0; i < treeObj.model.parentRecords.length; i++) {
                                                                GreenparentItemcollection.push($.extend(true, {}, treeObj.model.parentRecords[i].item));
                                                            }
                                                            removeRecords = flatRecords.filter(function (record) {
                                                                return record.DataElement >= 5
                                                            });
                                                            for (j = 0; j < removeRecords.length; j++) {
                                                                var args = [];
                                                                args.requestType = ej.TreeGrid.Actions.Delete;
                                                                args.data = removeRecords[j];
                                                                treeObj._removeRecords(args); //Method to remove the row
                                                            }
                                                            treeObj._ensureDataSource(args);
                                                            treeObj.updateHeight();
                                                        }  
                                                    });

                                                    var YellowparentItemcollection = [];
                                                    $("#chkYellowFilter").change(function (e) {
                        
                                                       e = e || window.event;
                                                        var targetEle = e.target,
                                                            checkStatus = $(targetEle).is(':checked');
                                                        var removeRecords = [],
                                                            treeObj = $("#TreeGrid").data("ejTreeGrid"),
                                                            flatRecords = treeObj.model.flatRecords;
                                                        if (checkStatus==true) {
                                                            treeObj.option("dataSource", YellowparentItemcollection);
                                                            YellowparentItemcollection = [];
                                                        }
                                                        if (checkStatus==false) {
                                                            for (i = 0; i < treeObj.model.parentRecords.length; i++) {
                                                                YellowparentItemcollection.push($.extend(true, {}, treeObj.model.parentRecords[i].item));
                                                            }
                                                            removeRecords = flatRecords.filter(function (record) {
                                                                return record.DataElement > 1 && record.DataElement < 5
                                                            });
                                                            for (j = 0; j < removeRecords.length; j++) {
                                                                var args = [];
                                                                args.requestType = ej.TreeGrid.Actions.Delete;
                                                                args.data = removeRecords[j];
                                                                treeObj._removeRecords(args); //Method to remove the row
                                                            }
                                                            treeObj._ensureDataSource(args);
                                                            treeObj.updateHeight();
                                                        }  
                                                    });
        
                                                    var RedparentItemcollection = [];
                                                    $("#chkRedFilter").change(function (e) {
            
                                                        e = e || window.event;
                                                        var targetEle = e.target,
                                                            checkStatus = $(targetEle).is(':checked');
                                                        var removeRecords = [],
                                                            treeObj = $("#TreeGrid").data("ejTreeGrid"),
                                                            flatRecords = treeObj.model.flatRecords;
                                                        if (checkStatus==true) {
                                                            treeObj.option("dataSource", RedparentItemcollection);
                                                            RedparentItemcollection = [];
                                                        }
                                                        if (checkStatus==false) {
                                                            for (i = 0; i < treeObj.model.parentRecords.length; i++) {
                                                                RedparentItemcollection.push($.extend(true, {}, treeObj.model.parentRecords[i].item));
                                                            }
                                                            removeRecords = flatRecords.filter(function (record) {
                                                                return record.DataElement == 0
                                                            });
                                                            for (j = 0; j < removeRecords.length; j++) {
                                                                var args = [];
                                                                args.requestType = ej.TreeGrid.Actions.Delete;
                                                                args.data = removeRecords[j];
                                                                treeObj._removeRecords(args); //Method to remove the row
                                                            }
                                                            treeObj._ensureDataSource(args);
                                                            treeObj.updateHeight();
                                                        }  
                                                    });

                                                    var OrangeparentItemcollection = [];
                                                    $("#chkOrangeFilter").change(function (e) {
            
                                                        e = e || window.event;
                                                        var targetEle = e.target,
                                                            checkStatus = $(targetEle).is(':checked');
                                                        var removeRecords = [],
                                                            treeObj = $("#TreeGrid").data("ejTreeGrid"),
                                                            flatRecords = treeObj.model.flatRecords;
                                                        if (checkStatus==true) {
                                                            treeObj.option("dataSource", OrangeparentItemcollection);
                                                            OrangeparentItemcollection = [];
                                                        }
                                                        if (checkStatus==false) {
                                                            for (i = 0; i < treeObj.model.parentRecords.length; i++) {
                                                                OrangeparentItemcollection.push($.extend(true, {}, treeObj.model.parentRecords[i].item));
                                                            }
                                                            removeRecords = flatRecords.filter(function (record) {
                                                                return record.DataElement == 1
                                                            });
                                                            for (j = 0; j < removeRecords.length; j++) {
                                                                var args = [];
                                                                args.requestType = ej.TreeGrid.Actions.Delete;
                                                                args.data = removeRecords[j];
                                                                treeObj._removeRecords(args); //Method to remove the row
                                                            }
                                                            treeObj._ensureDataSource(args);
                                                            treeObj.updateHeight();
                                                        }  
                                                    });

                                                })


                                                function HideDataSetDef() {

                                                   

                                                        e = window.event;
                                                        var targetEle = e.target,
                                                            treeObj = $("#TreeGrid").data("ejTreeGrid"),
                                                            checkStatus = $(targetEle).is(':checked');

                                                        treeObj.hideColumn("Data Set Definition"); //passing the header text to hide the column                                                                                                                                                                   

                                                }

                                                function queryCellInfo(args) {


                                                    try {

                                                        if ($("#chkColDefinition")[0].checked == false) {
                                                            var treeObj = $("#TreeGrid").data("ejTreeGrid");
                                                            treeObj.hideColumn("Data Set Definition");
                                                        }

                                                    }
                                                    catch(err){

                                                        var treeObj = $("#TreeGrid").data("ejTreeGrid");
                                                            treeObj.hideColumn("Data Set Definition");
                                                    }


                                                    if (args.column.headerText == "ISP 5"| args.column.headerText == "ISP 6"| args.column.headerText == "ISP 7" | args.column.headerText == "ISP 8" | args.column.headerText == "ISP 9" | args.column.headerText == "ISP 10"  | args.column.headerText == "ISP 11") { 


                                                        switch (args.data.DataElement) {

                                                             case "0":
                                                                $(args.cellElement).find("div").addClass("customcolor0"); 
                                                                $(args.cellElement).addClass("DataElementBG");    
                                                                break;

                                                             case "-1":
                                                                $(args.cellElement).find("div").addClass("customcolorm1"); 
                                                                $(args.cellElement).addClass("DataElementBG");    
                                                                break;

                                                            case "1":
                                                                $(args.cellElement).find("div").addClass("customcolor1"); 
                                                                $(args.cellElement).addClass("DataElementBG");    
                                                                break;

                                                            case "2":
                                                            case "3":
                                                            case "4":
                                                                $(args.cellElement).find("div").addClass("customcolor4"); 
                                                                $(args.cellElement).addClass("DataElementBG");    
                                                                break;

                                                            case "5":
                                                            case "6":
                                                            case "7":
                                                            case "8":
                                                            case "9":
                                                                $(args.cellElement).find("div").addClass("customcolor5"); 
                                                                $(args.cellElement).addClass("DataElementBG");    
                                                                break;

                                                            default:
                                                                $(args.cellElement).find("div").addClass("customcolorNoColour"); 
                                                                $(args.cellElement).addClass("DataElementBG");                                                                                                                               

                                                                break;
                                                        }

                                                                                                                  
                                                        
                                                            
                                                    } 
                                                } 




                                             
                                        </script> 


                                        </div>

                                    </div>

                                    <div class="bottom-tab">
                                        <ul class="wros">
                                            <li class="col"><b>Filter by:</b></li>
                                            <li class="col">


                                                


                                                <div class="checkbox checkbox-primary green-color">
                                                    <asp:CheckBox ID="chkGreenFilter" runat="server" />
                                                    <label for="chkGreenFilter">
                                                        <b>Compatible</b> >=5 cases available
                                                    </label>
                                                </div>
                                            </li>
                                            <li class="col">

                                                <div class="checkbox checkbox-primary yellow_color">
                                                    <asp:CheckBox ID="chkYellowFilter" runat="server" />
                                                    <label for="chkYellowFilter">
                                                        2-4 cases available
                                                    </label>
                                                </div>
                                            </li>
                                            <li class="col">

                                                <div class="checkbox checkbox-primary orange-color">
                                                    <asp:CheckBox ID="chkOrangeFilter" runat="server" />
                                                    <label for="chkOrangeFilter">
                                                        1 case available
                                                    </label>
                                                </div>
                                            </li>
                                            <li class="col">

                                                <div class="checkbox checkbox-primary red-color">
                                                    <asp:CheckBox ID="chkRedFilter" runat="server" />
                                                    <label for="chkRedFilter">
                                                        <b>Not Compatible</b>
                                                    </label>
                                                </div>
                                            </li>
                                            <li class="col">

                                                <div class="checkbox checkbox-primary white-color">
                                                    <asp:CheckBox ID="chkWhiteFilter" runat="server" />
                                                    <label for="chkWhiteFilter">
                                                        <b>Not Data</b>
                                                    </label>
                                                </div>
                                            </li>
                                        </ul>
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
				<img src="images/footer-logo.png"class="img-responsive">
				<h5><span>Privacy notice  |  Terms of use</span>
				<br>
© Koninklijke Philips N.V., 2004 - 2020. All rights reserved. </h5>
			</div>
		</div>
	</footer>
    <script src="/js/custom.js"></script>        
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="/js/bootstrap.min.js"></script>
    
    
   
</body>
         

</html>
