<%@ Page Language="C#" AutoEventWireup="true"  enableEventValidation="false" CodeFile="ISPConcerto.aspx.cs" Inherits="competitive_info_Competitors" %>

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
    <link href="../competitive-info/css/bootstrap.min.css" rel="stylesheet">
    <link href="./css/style.css" rel="stylesheet">
    <link href="../competitive-info/css/responsive.css" rel="stylesheet">
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

    <script>
        $(document).ready(function () {

            $('.ToggleDropdown').click(function () {

                $('.drop-down').addClass('OpenDropdown');

            });

        });
    </script>


    <style>
          

.ISPSoftwareButton {
    color: black !important;cursor: default;background-color: #d2dee5 !important;border: 1px solid #d2dee5;border-bottom-color: transparent;font-weight: 600;height: 49px;width:100px;
}

.ISPSoftwareButton.active {
    color: white !important;cursor: default;background-color: #178bc6 !important;border: 1px solid #178bc6;border-bottom-color: transparent;font-weight: 600;height: 49px;width:100px;
}


.ISPSoftwareOnly {
    color: black !important;cursor: default;background-color: #d2dee5 !important;border: 1px solid #d2dee5;border-bottom-color: transparent;font-weight: 600;height: 49px;width:45px;
}

.ISPSoftwareOnly.active {
    color: white !important;cursor: default;background-color: #178bc6 !important;border: 1px solid #178bc6;border-bottom-color: transparent;font-weight: 600;height: 49px;width:45px;
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
                                <img src="/images/CompetitorLogo.png" class="img-responsive">
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

                                    <ul class="nav navbar-nav icons-right" style="float: right;">
                                       <li class="icons"><a href="<%= Helper.GetUserGuide() %>" target="_blank">User Guide</a></li>
                                        <li class="user-dropdown ">

                                            <div class="drop-down">
                                                <button class="btn btn-primary ToggleDropdown" type="button">
                                                    Hello <%=m_UserName %><span class=""></span></button>
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


                                                        <asp:Panel ID="PanSwitchUser" Style="margin-top: 15px;" runat="server">

                                                            <span>Switch User Level</span>

                                                            <asp:DropDownList ID="ddlSwitchUser" OnSelectedIndexChanged="ddlSwitchUser_SelectedIndexChanged" AutoPostBack="True" runat="server">
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

                        <!-- <div class="col-sm-3 col-md-3 col-lg-2 left-padding"> -->
                            <!-- <div class="left-sidebar camparision-section"> -->
                            <!-- </div> -->
                        <!-- </div> -->

                        <div class="col-lg-12 col-md-12 col-sm-12">
                            <div class="rightbar">
                                <ul class="nav nav-tabs">
                                    <li class="active"><a href="/">NEW ENTERPRISE CUSTOMER</a></li>
                                    <li><a href="#">UPGRADE ENTERPRISE</a></li>
                                    <li><a href="#">UPGRADE FROM PORTAL TO ENTERPRISE</a></li>
                                </ul>


                                <div class="tab-content toshiba-content " style="">
                                    <div id="home" class="tab-pane fade in active">
                                        <div style="margin-top: 30px; height: auto;">
                                            <div class="container">
                                                <p style="font-weight: bolder;">SITE INFORMATION</p>

                                                <div class="Tab-info">
                                                    <div class="tab-regular" style="margin-top: 10px;">
                                                        <ul class="nav nav-tabs " id="myTab" role="tablist">
                                                            <li class="nav-item active">
                                                                <a class="nav-link" id="Central-tab" data-toggle="tab" href="#Central" role="tab" aria-controls="home" aria-selected="false" style="width: 158px;">Centralised</a>
                                                            </li>
                                                            <li class="nav-item">
                                                                <a class="nav-link" id="profile-tab" href="#profile" role="tab" aria-controls="profile" aria-selected="false" style="width: 158px;">Hybrid</a>
                                                            </li>
                                                            <li class="nav-item" disabled>
                                                                <a class="nav-link active show" id="contact-tab" href="#contact" role="tab" aria-controls="contact" aria-selected="true" style="width: 158px;">Distributed</a>
                                                            </li>
                                                        </ul>
                                                        <div class="tab-content" id="myTabContent">
                                                            <div class="tab-pane active" id="Central" role="tabpanel" aria-labelledby="Central-tab">



                                                                <table class="table table-bordered" style="margin-left: -10px;">
                                                                    <thead class="thead-light">
                                                                        <tr>
                                                                            <th scope="col" style="background-color: #0b1f65;">No.</th>
                                                                            <th scope="col" style="background-color: #0b1f65;">Hospital Name</th>
                                                                            <th scope="col" style="background-color: #0b1f65;">Hospital Street</th>
                                                                            <th scope="col" style="background-color: #0b1f65;">Site</th>
                                                                            <th scope="col" style="background-color: #0b1f65;">Connectivity</th>
                                                                        </tr>
                                                                    </thead>
                                                                    <tbody>
                                                                        <tr >
                                                                            <td align="center" style="vertical-align: middle;" ><span style="align-items:center">1</span></td>
                                                                            <td>
                                                                                <asp:TextBox ID="txtHospitalName1"  onblur="UpdateHospital(1);"  CssClass="form-control " runat="server" Style="margin-top: 3px;" placeholder="Hospital Name"></asp:TextBox>
                                                                            </td>
                                                                            <td>
                                                                                <asp:TextBox ID="txtHospitalStreet1" CssClass="form-control" runat="server" Style="margin-top: 3px;" placeholder="Hospital Street"></asp:TextBox>
                                                                            </td>
                                                                            <td>
                                                                                <div class="form-check form-check-inline">
                                                                                    <input class="form-check-input" type="radio" name="inlineRadioSite" id="inlineRadio1" value="Main">
                                                                                    <label class="form-check-label" for="inlineRadio1">Main</label>

                                                                                    <input class="form-check-input" type="radio" name="inlineRadioSite" id="inlineRadio2" value="Remote" style="margin-left: 13px;">
                                                                                    <label class="form-check-label" for="inlineRadio2">Remote</label>

                                                                                </div>
                                                                            </td>
                                                                            <td>

                                                                                <div class="form-check form-check-inline">
                                                                                    <input class="form-check-input" type="radio" name="inlineRadioConnectivity" id="inlineRadio3" value="High">
                                                                                    <label class="form-check-label" for="inlineRadio3">High</label>

                                                                                    <input class="form-check-input" type="radio" name="inlineRadioConnectivity" id="inlineRadio4" value="Med">
                                                                                    <label class="form-check-label" for="inlineRadio4">Med</label>



                                                                                    <input class="form-check-input" type="radio" name="inlineRadioConnectivity" id="inlineRadio5" value="Low">
                                                                                    <label class="form-check-label" for="inlineRadio5">Low</label>

                                                                                </div>

                                                                            </td>
                                                                        </tr>

                                                                         <tr style="display:none;vertical-align: middle;" id="row2-central">
                                                                             <td align="center" style="vertical-align: middle;" ><span style="align-items:center">2</span></td>
                                                                            <td>
                                                                                <asp:TextBox ID="txtHospitalName2" CssClass="form-control" runat="server" Style="margin-top: 3px;" placeholder="Hospital Name"></asp:TextBox>
                                                                            </td>
                                                                            <td>
                                                                                <asp:TextBox ID="txtHospitalStreet2" CssClass="form-control" runat="server" Style="margin-top: 3px;" placeholder="Hospital Street"></asp:TextBox>
                                                                            </td>
                                                                            <td>
                                                                                <div class="form-check form-check-inline">
                                                                                    <input class="form-check-input" type="radio" name="inlineRadioSite" id="inlineRadio1" value="Main">
                                                                                    <label class="form-check-label" for="inlineRadio1">Main</label>

                                                                                    <input class="form-check-input" type="radio" name="inlineRadioSite" id="inlineRadio2" value="Remote" style="margin-left: 13px;">
                                                                                    <label class="form-check-label" for="inlineRadio2">Remote</label>

                                                                                </div>
                                                                            </td>
                                                                            <td>

                                                                                <div class="form-check form-check-inline">
                                                                                    <input class="form-check-input" type="radio" name="inlineRadioConnectivity" id="inlineRadio3" value="High">
                                                                                    <label class="form-check-label" for="inlineRadio3">High</label>

                                                                                    <input class="form-check-input" type="radio" name="inlineRadioConnectivity" id="inlineRadio4" value="Med">
                                                                                    <label class="form-check-label" for="inlineRadio4">Med</label>



                                                                                    <input class="form-check-input" type="radio" name="inlineRadioConnectivity" id="inlineRadio5" value="Low">
                                                                                    <label class="form-check-label" for="inlineRadio5">Low</label>

                                                                                </div>

                                                                            </td>
                                                                        </tr>

                                                                             <tr style="display:none;vertical-align: middle;" id="row3-central">
                                                                            <td align="center" style="vertical-align: middle;" >3</td>
                                                                            <td >
                                                                                <asp:TextBox ID="txtHospitalName3" CssClass="form-control" runat="server" Style="margin-top: 3px;" placeholder="Hospital Name"></asp:TextBox>
                                                                            </td>
                                                                            <td>
                                                                                <asp:TextBox ID="txtHospitalStreet3" CssClass="form-control" runat="server" Style="margin-top: 3px;" placeholder="Hospital Street"></asp:TextBox>
                                                                            </td>
                                                                            <td>
                                                                                <div class="form-check form-check-inline">
                                                                                    <input class="form-check-input" type="radio" name="inlineRadioSite" id="inlineRadio1" value="Main">
                                                                                    <label class="form-check-label" for="inlineRadio1">Main</label>

                                                                                    <input class="form-check-input" type="radio" name="inlineRadioSite" id="inlineRadio2" value="Remote" style="margin-left: 13px;">
                                                                                    <label class="form-check-label" for="inlineRadio2">Remote</label>

                                                                                </div>
                                                                            </td>
                                                                            <td>

                                                                                <div class="form-check form-check-inline">
                                                                                    <input class="form-check-input" type="radio" name="inlineRadioConnectivity" id="inlineRadio3" value="High">
                                                                                    <label class="form-check-label" for="inlineRadio3">High</label>

                                                                                    <input class="form-check-input" type="radio" name="inlineRadioConnectivity" id="inlineRadio4" value="Med">
                                                                                    <label class="form-check-label" for="inlineRadio4">Med</label>



                                                                                    <input class="form-check-input" type="radio" name="inlineRadioConnectivity" id="inlineRadio5" value="Low">
                                                                                    <label class="form-check-label" for="inlineRadio5">Low</label>

                                                                                </div>

                                                                            </td>
                                                                        </tr>

                                                                         <tr style="display:none;vertical-align: middle;" id="row4-central">
                                                                            <td align="center" style="vertical-align: middle;" >4</td>
                                                                            <td >
                                                                                <asp:TextBox ID="txtHospitalName4" CssClass="form-control" runat="server" Style="margin-top: 3px;" placeholder="Hospital Name"></asp:TextBox>
                                                                            </td>
                                                                            <td>
                                                                                <asp:TextBox ID="txtHospitalStreet4" CssClass="form-control" runat="server" Style="margin-top: 3px;" placeholder="Hospital Street"></asp:TextBox>
                                                                            </td>
                                                                            <td>
                                                                                <div class="form-check form-check-inline">
                                                                                    <input class="form-check-input" type="radio" name="inlineRadioSite" id="inlineRadio1" value="Main">
                                                                                    <label class="form-check-label" for="inlineRadio1">Main</label>

                                                                                    <input class="form-check-input" type="radio" name="inlineRadioSite" id="inlineRadio2" value="Remote" style="margin-left: 13px;">
                                                                                    <label class="form-check-label" for="inlineRadio2">Remote</label>

                                                                                </div>
                                                                            </td>
                                                                            <td>

                                                                                <div class="form-check form-check-inline">
                                                                                    <input class="form-check-input" type="radio" name="inlineRadioConnectivity" id="inlineRadio3" value="High">
                                                                                    <label class="form-check-label" for="inlineRadio3">High</label>

                                                                                    <input class="form-check-input" type="radio" name="inlineRadioConnectivity" id="inlineRadio4" value="Med">
                                                                                    <label class="form-check-label" for="inlineRadio4">Med</label>



                                                                                    <input class="form-check-input" type="radio" name="inlineRadioConnectivity" id="inlineRadio5" value="Low">
                                                                                    <label class="form-check-label" for="inlineRadio5">Low</label>

                                                                                </div>

                                                                            </td>
                                                                        </tr>


                                                                         <tr style="display:none;vertical-align: middle;" id="row5-central">
                                                                            <td align="center" style="vertical-align: middle;" >5</td>
                                                                            <td >
                                                                                <asp:TextBox ID="txtHospitalName5" CssClass="form-control" runat="server" Style="margin-top: 3px;" placeholder="Hospital Name"></asp:TextBox>
                                                                            </td>
                                                                            <td>
                                                                                <asp:TextBox ID="txtHospitalStreet5" CssClass="form-control" runat="server" Style="margin-top: 3px;" placeholder="Hospital Street"></asp:TextBox>
                                                                            </td>
                                                                            <td>
                                                                                <div class="form-check form-check-inline">
                                                                                    <input class="form-check-input" type="radio" name="inlineRadioSite" id="inlineRadio1" value="Main">
                                                                                    <label class="form-check-label" for="inlineRadio1">Main</label>

                                                                                    <input class="form-check-input" type="radio" name="inlineRadioSite" id="inlineRadio2" value="Remote" style="margin-left: 13px;">
                                                                                    <label class="form-check-label" for="inlineRadio2">Remote</label>

                                                                                </div>
                                                                            </td>
                                                                            <td>

                                                                                <div class="form-check form-check-inline">
                                                                                    <input class="form-check-input" type="radio" name="inlineRadioConnectivity" id="inlineRadio3" value="High">
                                                                                    <label class="form-check-label" for="inlineRadio3">High</label>

                                                                                    <input class="form-check-input" type="radio" name="inlineRadioConnectivity" id="inlineRadio4" value="Med">
                                                                                    <label class="form-check-label" for="inlineRadio4">Med</label>



                                                                                    <input class="form-check-input" type="radio" name="inlineRadioConnectivity" id="inlineRadio5" value="Low">
                                                                                    <label class="form-check-label" for="inlineRadio5">Low</label>

                                                                                </div>

                                                                            </td>
                                                                        </tr>

                                                                    </tbody>
                                                                   

                                                                </table>
                                                                <asp:HiddenField ID="hidCentralSite" Value="1" runat="server" />
                                                               

                                                                     <div onclick="CentralAddSite();" style="cursor: pointer;"> + Add another site </div>
                                                                        

                                                            </div>

                                                        </div>
                                                    </div>
                                                </div>


                                            </div>





                                            <div class="seperator" style="border-bottom-color: #cdcdcd; border-bottom-style: solid;">
                                            </div>


                                            <div class="container">
                                                <div class="row">
                                                    <div class="col-md-12">
                                                        <div class="row">
                                                            <div class="col-md-4">

                                                                <p style="color: black; margin-top: 20px;"><b>CONCURRENT ENTERPRISE USERS</b></p>

                                                                <table class="table table-bordered" style="margin-left: 0px; width: 63px;">
                                                                    <thead class="thead-light">
                                                                        <tr>
                                                                            <th scope="col" style="background-color: #0b1f65;">Concurrent Users.</th>

                                                                        </tr>
                                                                    </thead>
                                                                    <tbody>
                                                                        <tr>
                                                                            <td>
                                                                               <ej:NumericTextBox ID="CONCURRENTENTERPRISEUSERS" MaxValue="50" MinValue="10" Value="35" Name="CONCURRENTENTERPRISEUSERS" runat="server" Width="100%" />
                                                                            </td>


                                                                        </tr>

                                                                    </tbody>
                                                                </table>

                                                            </div>
                                                            <div class="col-md-4">
                                                            </div>
                                                            <div class="col-md-4">
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>


                                            <div class="seperator" style="border-bottom-color: #cdcdcd; border-bottom-style: solid;">
                                            </div>



                                            <div class="container">
                                                <div class="row">
                                                    <div class="col-md-12">
                                                        <div class="row">
                                                            <div class="col-md-12">
                                                                <p style="color: black; margin-top: 20px;"><b>ADDITIONAL APPLICATIONS</b></p>
                                                                <div class="table-responsive">
                                                                <table class="table table-bordered" style="margin-left: -0px;">
                                                                    <thead class="thead-light">
                                                                        <tr>
                                                                            <th scope="col" class="w-25" style="background-color: #0b1f65;">No.</th>
                                                                            <th scope="col" class="w-35" style="background-color: #0b1f65;">Applications</th>
                                                                            <th scope="col" class="w-25" style="background-color: #0b1f65;">Concurrent Users</th>
                                                                            <th scope="col" class="w-25" style="background-color: #0b1f65;">Hostpital Name</th>

                                                                        </tr>
                                                                    </thead>
                                                                    <tbody>
                                                                        <tr>
                                                                            <td align="center">1</td>
                                                                            <td>
                                                                                <asp:DropDownList ID="cmdApplication1" onchange="GetApplicationData(this)" CssClass="form-control" runat="server" style="width: 100%;">
                                                                                      
                                                                                    



                                                                                </asp:DropDownList>
                                                                                    
                                                                                    </td>
                                                                            <td>

                                                                                <input type="number" id="txtConcurrent1" onblur="CheckConcurrentValue(this)" class="form-control" style="margin-top: 3px;" name="txtConcurrent1" min="1" max="55">                                                                                                                                                                
                                                                                <div id="errortxtConcurrent1" style="color:red;padding-top: 2px;display:none;"> Error with input</div>
                                                                            </td>
                                                                            <td>
                                                                                <asp:DropDownList ID="cmdHospitalName1" CssClass="form-control" runat="server" style="width: 100%;">
                                                                                                                                                                   
                                                                                </asp:DropDownList>
                                                                            </td>

                                                                        </tr>


                                                                          <tr style="display:none;vertical-align: middle;" id="row2-additional-apps">
                                                                            <td align="center">2</td>
                                                                            <td>
                                                                                <asp:DropDownList ID="cmdApplication2" onchange="GetApplicationData(this)" CssClass="form-control" runat="server" style="width: 100%;">
                                                                                      
                                                                                    
                                                                                </asp:DropDownList>
                                                                                    
                                                                                    </td>
                                                                            <td>
                                                                                <input type="number" id="txtConcurrent2" class="form-control" style="margin-top: 3px;" name="txtConcurrent2" min="10" max="100">
                                                                                 
                                                                            </td>
                                                                            <td>
                                                                                <asp:DropDownList ID="cmdHospitalName2" CssClass="form-control" runat="server" style="width: 100%;">
                                                                                                                                                                   
                                                                                </asp:DropDownList>
                                                                            </td>

                                                                        </tr>

                                                                           <tr style="display:none;vertical-align: middle;" id="row3-additional-apps">
                                                                            <td align="center">3</td>
                                                                            <td>
                                                                                <asp:DropDownList ID="cmdApplication3" onchange="GetApplicationData(this)" CssClass="form-control" runat="server" style="width: 100%;">
                                                                                      
                                                                                    
                                                                                </asp:DropDownList>
                                                                                    
                                                                                    </td>
                                                                            <td>
                                                                                <input type="number" id="txtConcurrent3" class="form-control" style="margin-top: 3px;" name="txtConcurrent3" min="10" max="100">
                                                                                 
                                                                            </td>
                                                                            <td>
                                                                                <asp:DropDownList ID="cmdHospitalName3" CssClass="form-control" runat="server" style="width: 100%;">
                                                                                                                                                                   
                                                                                </asp:DropDownList>
                                                                            </td>

                                                                        </tr>

                                                                         <tr style="display:none;vertical-align: middle;" id="row4-additional-apps">
                                                                            <td align="center">4</td>
                                                                            <td>
                                                                                <asp:DropDownList ID="cmdApplication4" onchange="GetApplicationData(this)" CssClass="form-control" runat="server" style="width: 100%;">
                                                                                      
                                                                                    
                                                                                </asp:DropDownList>
                                                                                    
                                                                                    </td>
                                                                            <td>
                                                                                <input type="number" id="txtConcurrent4" class="form-control" style="margin-top: 3px;" name="txtConcurrent4" min="10" max="100">
                                                                                 
                                                                            </td>
                                                                            <td>
                                                                                <asp:DropDownList ID="cmdHospitalName4" CssClass="form-control" runat="server" style="width: 100%;">
                                                                                                                                                                   
                                                                                </asp:DropDownList>
                                                                            </td>

                                                                        </tr>

                                                                    </tbody>
                                                                </table>

                                                                     <asp:HiddenField ID="hidadditionalapps" Value="1" runat="server" />
                                                               

                                                                     <div onclick="AdditionalAppsAddSite();" style="cursor: pointer;"> + Add another application </div>
                                                                        
                                                                    <br />

                                                                </div>
                                                            </div>
                                                            
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>




                                            <div class="seperator" style="border-bottom-color: #cdcdcd; border-bottom-style: solid;">
                                            </div>



                                            <div class="container">
                                                <p style="font-weight: bolder; margin-top: 20px;">DELIVERY MODEL</p>



                                                                                                          


                                                <div class="DELIVERY-info">
                                                    <div class="tab-regular" style="margin-top: 10px;">
                                                        <ul class="nav nav-tabs " id="myTab1" role="tablist">

                                                            <li class="nav-item">                                                                
                                                                <a class="nav-link active" id="DELIVERY-tab" data-toggle="tab" href="#DELIVERY" role="tab" aria-controls="DELIVERY" aria-selected="true" style="width: 158px;">Software Only</a>
                                                            </li>

                                                            <li class="nav-item">
                                                                <a class="nav-link" id="SOFTWARE-tab" data-toggle="tab" href="#SOFTWARE" role="tab" aria-controls="SOFTWARE" aria-selected="false" style="width: 220px;">Software & Hardware</a>
                                                            </li>

                                                        </ul>
                                                        <div class="tab-content" id="myTabContent1">

                                                            <div class="tab-pane active" id="DELIVERY" role="tabpanel" aria-labelledby="DELIVERY-tab">
                                                                <table class="table" style="margin-left: -15px;">
  
  <tbody>
    <tr>
      
      <td style="width: 274px"> ISP Software only test server included: </td>
      
      <td style="width: 50px;">

          <input id="cmdISPSoftwareNo" class="ISPSoftwareButton active" type="button" value="No" >
          

      </td>
      <td style="width: 50px;">
          <input id="cmdISPSoftwareYes" class="ISPSoftwareButton" type="button" value="Yes" >          
          <asp:HiddenField ID="hidISPSoftware" runat="server" />
      </td>

        <td></td>

        <td align="right">           
        </td>


        <td>            
        </td>

    </tr>


       
  </tbody>
</table>

                                                                 <table class="table" style="margin-left: -15px;">
  
  <tbody>
    

      <tr>
           <td style="width: 254px;">ISP Software Only:</td>
           <td >


               <input id="cmdISPSoftwareOnly1" class="ISPSoftwareOnly active" type="button" value="1" >
               <input id="cmdISPSoftwareOnly2" class="ISPSoftwareOnly" type="button" value="2" >
               <input id="cmdISPSoftwareOnly3" class="ISPSoftwareOnly" type="button" value="3" >
               <input id="cmdISPSoftwareOnly4" class="ISPSoftwareOnly" type="button" value="4" >
               <input id="cmdISPSoftwareOnly5" class="ISPSoftwareOnly" type="button" value="5" >
               <input id="cmdISPSoftwareOnly6" class="ISPSoftwareOnly" type="button" value="6" >
               <input id="cmdISPSoftwareOnly7" class="ISPSoftwareOnly" type="button" value="7" >
               <input id="cmdISPSoftwareOnly8" class="ISPSoftwareOnly" type="button" value="8" >
               <input id="cmdISPSoftwareOnly9" class="ISPSoftwareOnly" type="button" value="9" >
               <input id="cmdISPSoftwareOnly10" class="ISPSoftwareOnly" type="button" value="10" >
               <input id="cmdISPSoftwareOnly11" class="ISPSoftwareOnly" type="button" value="11" >


               <asp:HiddenField ID="hidISPSoftwareOnly" runat="server" />
           </td>

           
    </tr>


       
  </tbody>
</table>



                                                               
                                                                <div class="row">
                                                                    <div class="col-md-12">
                                                                        <div class="table-responsive">
                                                                         <table class="table table-bordered" id="empTable" style="margin-left: -0px;">
                                                                    <thead class="thead-light">
                                                                        <tr>
                                                                            <th scope="col" class="w-25" style="background-color: #0b1f65;">No.</th>
                                                                            <th scope="col" class="w-35" style="background-color: #0b1f65;">Menu</th>
                                                                            <th scope="col" class="w-25" style="background-color: #0b1f65;">Mac address:</th>
                                                                            

                                                                        </tr>
                                                                    </thead>
                                                                    <tbody>

                                                                                                                                               
                                                                         

                                                                    </tbody>
                                                                </table>
                                                                        </div>
                                                                    </div>
                                                                    
    
                                                                  </div>





                                                            </div>
                                                            <div class="tab-pane" id="SOFTWARE" role="tabpanel" aria-labelledby="SOFTWARE-tab">
                                                           


<table class="">

    <tbody>
    <tr>
     
      <td> <input type="button" name="Button1" value="Hardware High Availiabllity NOT required" id="Button1" style="color: white !important;cursor: default;background-color: #178bc6 !important;border: 1px solid #178bc6;border-bottom-color: transparent;font-weight: 600;height: 49px;margin-left: 217px;width:300px;">                                    </td>
     
    </tr>
    <tr>
      
      <td><input type="button" name="Button2" value="Hardware High Availiabllity IS required" id="Button2" style="color: black !important;cursor: default;background-color: #d2dee5 !important;border: 1px solid #d2dee5;border-bottom-color: transparent;font-weight: 600;height: 49px;margin-left: 217px;width:300px;margin-top: 10px;"></td>
      <td><input type="button" name="Button2" value="Hardware High Availiabllity IS required" id="Button2" style="color: black !important;cursor: default;background-color: #d2dee5 !important;border: 1px solid #d2dee5;border-bottom-color: transparent;font-weight: 600;height: 49px;margin-left: 10px;width:300px;margin-top: 10px;"></td>
      <td><input type="button" name="Button2" value="Hardware High Availiabllity IS required" id="Button2" style="color: black !important;cursor: default;background-color: #d2dee5 !important;border: 1px solid #d2dee5;border-bottom-color: transparent;font-weight: 600;height: 49px;margin-left: 10px;width:300px;margin-top: 10px;"></td>
    </tr>
    
  </tbody>

                                                                </table>




                                                               
                                                                <br> <br>
                                                                
																<div class="">
																   <div class="row hr">
    <div class="col-md-6">
	   <div class="heading">
	        <h2 style="font-size: 16px;font-weight: bold;margin-left: -17px;">IntelliSpace Portal Enterprise Pro HW</h2>
			<p style="margin-left: -17px;">Max 30 concurrent users</p>
	   </div>
	<div class="tab-pane active" id="" role="tabpanel" aria-labelledby="DELIVERY-tab">
        <table class="table" style="margin-left: -15px;">
  
  <tbody>
    <tr>
      
      <td colspan="2" style="width: 274px">STB Additional Storage</td>
      
      <td style="width: 50px;">

          <input type="submit" name="Button3" value="No" id="Button3" style="color: white !important;cursor: default;background-color: #178bc6 !important;border: 1px solid #178bc6;border-bottom-color: transparent;font-weight: 600;height: 49px;width:100px;">

      </td>
      <td style="width: 50px;">
          <input type="submit" name="Button5" value="Yes" id="Button5" style="color: black !important;cursor: default;background-color: #d2dee5 !important;border: 1px solid #d2dee5;border-bottom-color: transparent;font-weight: 600;height: 49px;width:100px;"> 

      </td>

    </tr>
	
	    <tr>
      
      <td colspan="2" style="width: 274px">ISP Text License Required</td>
      
      <td style="width: 50px;">

          <input type="submit" name="Button3" value="No" id="Button3" style="color: white !important;cursor: default;background-color: #178bc6 !important;border: 1px solid #178bc6;border-bottom-color: transparent;font-weight: 600;height: 49px;width:100px;">

      </td>
      <td style="width: 50px;">
          <input type="submit" name="Button5" value="Yes" id="Button5" style="color: black !important;cursor: default;background-color: #d2dee5 !important;border: 1px solid #d2dee5;border-bottom-color: transparent;font-weight: 600;height: 49px;width:100px;"> 

      </td>
    </tr>
	
		    <tr>
      
      <td colspan="2" style="width: 274px">ISP Enterprise test license</td>
      
      <td style="width: 50px;">

          <input type="submit" name="Button3" value="No" id="Button3" style="color: white !important;cursor: default;background-color: #178bc6 !important;border: 1px solid #178bc6;border-bottom-color: transparent;font-weight: 600;height: 49px;width:100px;">

      </td>
      <td style="width: 50px;">
          <input type="submit" name="Button5" value="Yes" id="Button5" style="color: black !important;cursor: default;background-color: #d2dee5 !important;border: 1px solid #d2dee5;border-bottom-color: transparent;font-weight: 600;height: 49px;width:100px;"> 

      </td>
    </tr>
	
<tr>
      
      <td style="width: 274px">ISP Advanced license</td>
      
      
      <td colspan="3" align="right" style="width: 30px;">
          <input type="submit" name="Button5" value="Yes" id="Button5" style="color: black !important;cursor: default;background-color: #d2dee5 !important;border: 1px solid #d2dee5;border-bottom-color: transparent;font-weight: 600;height: 49px;width:60px;margin: 0 10px 0 0;"> 

      <input type="submit" name="Button3" value="No" id="Button3" style="color: white !important;cursor: default;background-color: #178bc6 !important;border: 1px solid #178bc6;border-bottom-color: transparent;font-weight: 600;height: 49px;width:60px;margin: 0 10px 0 0;">
<input type="submit" name="Button5" value="Yes" id="Button5" style="color: black !important;cursor: default;background-color: #d2dee5 !important;border: 1px solid #d2dee5;border-bottom-color: transparent;font-weight: 600;height: 49px;width:60px;"></td>
      
      
    </tr>


       
  </tbody>
</table>
  </div></div>
    <div class="col-md-6">
		   <div class="heading">
	        <h2 style="font-size: 16px;font-weight: bold;margin-left: -17px;">IntelliSpace Portal Enterprise Premium HW</h2>
			<p style="margin-left: -17px;">50 concurrent users</p>
	   </div>
<div class="tab-pane active" id="" role="tabpanel" aria-labelledby="DELIVERY-tab">
                                                                <table class="table" style="margin-left: -15px;">
  
  <tbody>
    <tr>
      
      <td colspan="2" style="width: 274px"> Do Your Customer requires Philips to provide storage?  (required-10TB) </td>
      
      <td style="width: 50px;">

          <input type="submit" name="Button3" value="No" id="Button3" style="color: white !important;cursor: default;background-color: #178bc6 !important;border: 1px solid #178bc6;border-bottom-color: transparent;font-weight: 600;height: 49px;width:100px;">

      </td>
      <td colspan="" style="width: 50px;">
          <input type="submit" name="Button5" value="Yes" id="Button5" style="color: black !important;cursor: default;background-color: #d2dee5 !important;border: 1px solid #d2dee5;border-bottom-color: transparent;font-weight: 600;height: 49px;width:100px;"> 

      </td>
    </tr>
<tr>
      
      <td style="width: 274px; color:#d2dee5;">Additional Storage Required </td>
      
      <td style="width: 50px;">

          <input type="submit" name="Button3" value="10TB" id="Button3" style="color: white !important;cursor: default;background-color: #d2dee5 !important;border: 1px solid;border-bottom-color: transparent;font-weight: 600;height: 49px;width:100px;">

      </td>
      <td style="width: 50px;">

          <input type="submit" name="Button3" value="10TB" id="Button3" style="color: white !important;cursor: default;background-color: #d2dee5 !important;border: 1px solid;border-bottom-color: transparent;font-weight: 600;height: 49px;width:100px;">

      </td>
	    <td style="width: 50px;">

          <input type="submit" name="Button3" value="10TB" id="Button3" style="color: white !important;cursor: default;background-color: #d2dee5 !important;border: 1px solid ;border-bottom-color: transparent;font-weight: 600;height: 49px;width:100px;">

      </td>
    </tr>
		
	    <tr>
      
      <td style="width: 274px">Additional host server required </td>
           <td style="width: 50px;">
          <input type="submit" name="Button5" value="No" id="Button5" style="color: black !important;cursor: default;background-color: #d2dee5 !important;border: 1px solid #d2dee5;border-bottom-color: transparent;font-weight: 600;height: 49px;width:100px;"> 

      </td>
      <td style="width: 50px;">

          <input type="submit" name="Button3" value="1" id="Button3" style="color: white !important;cursor: default;background-color: #178bc6 !important;border: 1px solid #178bc6;border-bottom-color: transparent;font-weight: 600;height: 49px;width:100px;">

      </td>
      <td style="width: 50px;">
          <input type="submit" name="Button5" value="2" id="Button5" style="color: black !important;cursor: default;background-color: #d2dee5 !important;border: 1px solid #d2dee5;border-bottom-color: transparent;font-weight: 600;height: 49px;width:100px;"> 

      </td>
    </tr>
	
		    <tr style="
">
      
      <td style="width: 274px">ISP Premium License</td>
      
      <td colspan="3" align="right">
          <input type="submit" name="Button5" value="1" id="Button5" style="color: black !important;cursor: default;background-color: #d2dee5 !important;border: 1px solid #d2dee5;border-bottom-color: transparent;font-weight: 600;height: 49px;width: 49px;margin: 0 5px 0 0;"> 

      <input type="submit" name="Button5" value="2" id="Button5" style="color: black !important;cursor: default;background-color: #d2dee5 !important;border: 1px solid #d2dee5;border-bottom-color: transparent;font-weight: 600;height: 49px;width: 49px;margin: 0 5px 0 0;"><input type="submit" name="Button5" value="3" id="Button5" style="color: black !important;cursor: default;background-color: #d2dee5 !important;border: 1px solid #d2dee5;border-bottom-color: transparent;font-weight: 600;height: 49px;width: 49px;margin: 0 5px 0 0;"><input type="submit" name="Button5" value="4" id="Button5" style="color: black !important;cursor: default;background-color: #d2dee5 !important;border: 1px solid #d2dee5;border-bottom-color: transparent;font-weight: 600;height: 49px;width: 49px;margin: 0 5px 0 0;"><input type="submit" name="Button5" value="5" id="Button5" style="color: black !important;cursor: default;background-color: #d2dee5 !important;border: 1px solid #d2dee5;border-bottom-color: transparent;font-weight: 600;height: 49px;width: 49px;margin: 0 5px 0 0;"></td>
	        
	        
	        
	        
    </tr>
		
		    <tr>
      
      <td colspan="2" style="width: 274px">ISP Test License required?</td>
      
      <td style="width: 50px;">

          <input type="submit" name="Button3" value="No" id="Button3" style="color: white !important;cursor: default;background-color: #178bc6 !important;border: 1px solid #178bc6;border-bottom-color: transparent;font-weight: 600;height: 49px;width:100px;">

      </td>
      <td style="width: 50px;">
          <input type="submit" name="Button5" value="Yes" id="Button5" style="color: black !important;cursor: default;background-color: #d2dee5 !important;border: 1px solid #d2dee5;border-bottom-color: transparent;font-weight: 600;height: 49px;width:100px;"> 

      </td>
    </tr>


       
  </tbody>
</table>

                                                                 



                                                               
                                                                





                                                            </div>
</div>
</div>


<div class="row">
<div class="col-md-6"><button class="text-align:center;" style="    display: block;
    background: #d2dee5;
    color: #000;
    margin: auto;
    width: 50%;
    border: none;
    padding: 15px;margin-bottom:20px;">Configuration</button></div>
<div class="col-md-6"><button class="text-align:center;" style="    display: block;
    background: #d2dee5;
    color: #000;
    margin: auto;
    width: 50%;
    border: none;
    padding: 15px;margin-bottom:20px;">Configuration</button></div>
</div>
																</div>
																
																
																</div>

                                                        </div>
                                                    
                                                    </div>

                                                </div>
                                            </div>


                                            <div class="seperator" style="border-bottom-color: #cdcdcd; border-bottom-style: solid;">
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


        <footer class="footer">
            <div class="container">
                <div class="row">
                    <img src="../images/footer-logo.png" class="img-responsive">
                    <h5><span>Privacy notice  |  Terms of use</span>
                        <br>
                        © Koninklijke Philips N.V., 2004 - 2020. All rights reserved. </h5>
                </div>
            </div>
        </footer>

    </form>




<script
  src="https://code.jquery.com/jquery-3.4.1.min.js"
  integrity="sha256-CSXorXvZcTkaix6Yvo6HppcZGetbYMGWSFlBw8HfCJo="
  crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>

    <script>

        var arrHead = new Array();
    arrHead = ['No', 'Menu', 'Mac']; // table headers.


        function CreateRow(NoRows) {

            for (var r = 0; r < NoRows; r++) {
                addRow(r);
            }

        }



        function addRow(idx) {
        var empTab = document.getElementById('empTable');

        var rowCnt = empTab.rows.length;    // get the number of rows.
        var tr = empTab.insertRow(rowCnt); // table row.
        tr = empTab.insertRow(rowCnt);

        for (var c = 0; c < arrHead.length; c++) {
            var td = document.createElement('td');            
            td = tr.insertCell(c);
            td.align = "center";


            switch (c) {

                case 0:

                    var closeSpan = document.createElement("span");
                    closeSpan.setAttribute("class","text-center");
                    closeSpan.textContent = idx + 1;
                    td.appendChild(closeSpan);
                    break;
                case 1:
                        var select = document.createElement('select');
                        var option;
                        var inputdata = "Advanced Extended Storage 5TB||Concerto remote sites||Concerto Usr Lic Above 50||Concerto Usr Lic Btw 10-15||Concerto Usr Lic Btw 16-20||Concerto Usr Lic Btw 21-30||Concerto Usr Lic Btw 31-40||Concerto Usr Lic Btw 41-50||Ent Prem. HW Solution engine||Ent Prem. HW Solution storage||Enterprise Adv.HW Solution||Enterprise Engine SW||ISP Advanced  SW License||ISP Premium  SW License||ISP Server - Software only||Number of Concurrent Users||Number of Concurrent Users NA||Premium Add. Second Engine||Premium Add. Third Engine||Premium Extended Storage 5TB";
                        var split = inputdata.split('||');

                        select.setAttribute("class","form-control");
                        inputdata.split('||').forEach(function (item) {

                            option = document.createElement( 'option' );

                            option.value = option.textContent = item;

                            select.appendChild( option );
                        });
                
                        td.appendChild(select);
                    break;
                case 2:
                    
                    var ele = document.createElement('input');
                    ele.setAttribute('type', 'text');
                    ele.setAttribute('value', '');
                    ele.setAttribute("class","form-control");
                    td.appendChild(ele);

                    break;
            }
           

            //https://www.encodedna.com/javascript/dynamically-add-remove-rows-to-html-table-using-javascript-and-save-data.htm



            //<input type='text' id='lname' name='lname' Class="form-control" style="margin-top: 3px;">

                                                                              //<select id='cars'>
                                                                              //    <option value='volvo'>Volvo</option>
                                                                              //    <option value='saab'>Saab</option>
                                                                              //    <option value='mercedes'>Mercedes</option>
                                                                              //    <option value='audi'>Audi</option>
                                                                              //  </select>

            if (c == 0) {   // if its the first column of the table.
                // add a button control.
                //var button = document.createElement('input');

                // set the attributes.
               // button.setAttribute('type', 'button');
                //button.setAttribute('value', 'Remove');

                // add button's "onclick" event.
                //button.setAttribute('onclick', 'removeRow(this)');

                //td.appendChild(button);
            }
            else {
                // the 2nd, 3rd and 4th column, will have textbox.
                //var ele = document.createElement('input');
                //ele.setAttribute('type', 'text');
                //ele.setAttribute('value', '');

                //td.appendChild(ele);
            }
        }
        }


        function CheckConcurrentValue(TextBoxItem) {

            if ($(TextBoxItem)[0].value > $(TextBoxItem)[0].max) {
                $("#errortxtConcurrent" + TextBoxItem.id.substr(TextBoxItem.id.length - 1, 2)).show();
                $(TextBoxItem)[0].value = $(TextBoxItem)[0].max;
                $("#errortxtConcurrent" + TextBoxItem.id.substr(TextBoxItem.id.length - 1, 2))[0].innerHTML = "max range is " + $(TextBoxItem)[0].max;

            } else {
                $("#errortxtConcurrent" + TextBoxItem.id.substr(TextBoxItem.id.length - 1, 2)).hide();
            }


            GetLicenceData(TextBoxItem);

        }
        

         $('.ISPSoftwareOnly').click(function() {
            $('.ISPSoftwareOnly.active').removeClass("active");             
            $(this).addClass("active");    
            
            $('#hidISPSoftwareOnly')[0].value = $(this)[0].value;
            
            
        });

        $('.ISPSoftwareButton').click(function() {
            $('.ISPSoftwareButton.active').removeClass("active");             
            $(this).addClass("active");    
            if ($(this)[0].id == "cmdISPSoftwareYes" ) {
                 $('#hidISPSoftware')[0].value = 1;
            } else {
                $('#hidISPSoftware')[0].value = 0;
            }
            
        });

        function GetApplicationData(ddlbox) {
           
            var array = ddlbox.value.split("|");

            if (array[2] == "Enterprise") {
                
                $("#txtConcurrent" + ddlbox.id.substr( ddlbox.id.length-1,2))[0].value = $("#CONCURRENTENTERPRISEUSERS")[0].value;
            } else {
                $("#txtConcurrent" + ddlbox.id.substr( ddlbox.id.length-1,2))[0].value = array[2];
            }

            //Concurrent_Users
            if (array[1] == "No") {

                $("#txtConcurrent" + ddlbox.id.substr(ddlbox.id.length - 1, 2))[0].disabled = true;
            } else {
                 $("#txtConcurrent" + ddlbox.id.substr(ddlbox.id.length - 1, 2))[0].disabled = false;
            }

            //Concurrent_Range - Max
            if (array[3] != "") {

                if (Number.isInteger(array[3]) == true) {
                    $("#txtConcurrent" + ddlbox.id.substr(ddlbox.id.length - 1, 2))[0].max = array[3];
                }

            }
            //txtConcurrent1
            
           // alert(array[0]);
            //alert(array[1]);

        }

        function UpdateHospital(itemidx) {

            
            AddHospitalItem($("#txtHospitalName" + itemidx )[0].value,$("#txtHospitalName" + itemidx )[0].value)

            //txtHospitalName1

        }
    function AddHospitalItem(Text,Value)
    {
          
        var optVal= document.createElement("option");
        document.getElementById("cmdHospitalName1").options.add(optVal);
        optVal.text = Text;
        optVal.value = Value;

    }

        function AdditionalAppsAddSite() {
            let hidv = $("#hidadditionalapps")[0].value;
            hidv++;
            $("#hidadditionalapps")[0].value = hidv;
            switch (hidv) {
                case 2:
                    $("#row2-additional-apps").show();
                    break;
                 case 3:
                    $("#row2-additional-apps").show();
                     $("#row3-additional-apps").show();
                    break;
                 case 4:
                    $("#row2-additional-apps").show();
                    $("#row3-additional-apps").show();
                    $("#row4-additional-apps").show();
                    break;
                 
            }
        }

        function CentralAddSite() {
            
            let hidv = $("#hidCentralSite")[0].value;
            hidv++;
            $("#hidCentralSite")[0].value = hidv;

            switch (hidv) {               
                case 2:
                    $("#row2-central").show();
                    break;
                case 3:
                    $("#row2-central").show();
                    $("#row3-central").show();
                    break;
                case 4:
                    $("#row2-central").show();
                    $("#row3-central").show();
                    $("#row4-central").show();
                    break;
                  case 5:
                    $("#row2-central").show();
                    $("#row3-central").show();
                    $("#row4-central").show();
                    $("#row5-central").show();
                    break;
            }
        }



        function GetLicenceData(TextBoxItem) {

            let enterpriseuser = $("#CONCURRENTENTERPRISEUSERS")[0].value;
            let concurentusers = $(TextBoxItem)[0].value;
            let selectedapplication =  $("#cmdApplication" + TextBoxItem.id.substr(TextBoxItem.id.length - 1, 2) )[0].value;


            var myKeyVals = { enterpriseuser: enterpriseuser, concurentusers: concurentusers, selectedapplication: selectedapplication }

            $.ajax('./apidata', 
                {
                    type: 'POST',
                     data: myKeyVals,
                dataType: 'json', // type of response data
                //timeout: 5000,     // timeout milliseconds
                success: function (data,status,xhr) {   // success callback function
                   
                    


                    switch (data.licence) {
                        case "5":
                            $('.ISPSoftwareOnly.active').removeClass("active");                              
                            $("#cmdISPSoftwareOnly5").addClass("active");    

                            CreateRow( data.licence )
                            break;
                    }

                    $('#hidISPSoftwareOnly')[0].value = data.licence;

                },
                error: function (jqXhr, textStatus, errorMessage) { // error callback                     
                     alert(errorMessage);
                }
            });

        }

    </script>

    <style>
        .Tab-info .nav-tabs > li > a {
            border-radius: 0;
            /*background: #178bc6;*/
            background: #d2dee5;
            color: black;
            width: 330px;
            text-align: center;
            font-size: 14px;
            text-transform: uppercase;
        }


        .Tab-info .nav-tabs > li.active > a, .Tab-info .nav-tabs > li.active > a:focus, .Tab-info .nav-tabs > li.active > a:hover {
            color: white !important;
            cursor: default;
            background-color: #178bc6 !important;
            border: 1px solid #178bc6;
            border-bottom-color: transparent;
            font-weight: 600;
        }



.DELIVERY-info .nav.nav-tabs .nav-link {
            border-radius: 0;          
            background: #d2dee5;
            color: black;
            width: 224px!important;
            text-align: center;
            font-size: 14px;
            text-transform: uppercase;
}


.DELIVERY-info .nav-tabs .nav-link.active {
    color: white !important;
    cursor: default;
    background-color: #178bc6 !important;
    border: 1px solid #178bc6;
    border-bottom-color: transparent;
    font-weight: 600;
   
    width: 224px!important;
    text-align: center;
    font-size: 14px;
}



        
        
        
    
    </style>

</body>
</html>

