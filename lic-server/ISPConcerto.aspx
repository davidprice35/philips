<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ISPConcerto.aspx.cs" Inherits="competitive_info_Competitors" %>


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

                        <div class="col-sm-3 col-md-3 col-lg-2 left-padding">
                            <div class="left-sidebar camparision-section">
                            </div>
                        </div>

                        <div class="col-lg-12 col-md-12 col-sm-9 right-padding">
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
                                                                 <label for="sdsdsd"><span>

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
                                                                                <ej:NumericTextBox ID="CONCURRENTENTERPRISEUSERS" Value="35" Name="CONCURRENTENTERPRISEUSERS" runat="server" Width="150px" />
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
                                                                                <asp:DropDownList ID="cmdApplication1" onchange="GetApplicationData(this)" CssClass="form-control" runat="server" style="width: 300px;">
                                                                                      
                                                                                    



                                                                                </asp:DropDownList>
                                                                                    
                                                                                    </td>
                                                                            <td>
                                                                                 <asp:TextBox ID="txtConcurrent1" CssClass="form-control" runat="server" Style="margin-top: 3px;" placeholder=""></asp:TextBox>
                                                                            </td>
                                                                            <td>
                                                                                <asp:DropDownList ID="cmdHospitalName1" CssClass="form-control" runat="server" style="width: 255px;">
                                                                                                                                                                   
                                                                                </asp:DropDownList>
                                                                            </td>

                                                                        </tr>

                                                                    </tbody>
                                                                </table>
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

                                                            <li class="nav-item active">                                                                
                                                                <a class="nav-link" id="DELIVERY-tab" data-toggle="tab" href="#DELIVERY" role="tab" aria-controls="DELIVERY" aria-selected="false" style="width: 158px;">Software Only</a>
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

          <asp:Button ID="Button3" runat="server" Text="No" style="color: white !important;cursor: default;background-color: #178bc6 !important;border: 1px solid #178bc6;border-bottom-color: transparent;font-weight: 600;height: 49px;width:100px;" />

      </td>
      <td style="width: 50px;">
          <asp:Button ID="Button5" runat="server" Text="Yes" style="color: black !important;cursor: default;background-color: #d2dee5 !important;border: 1px solid #d2dee5;border-bottom-color: transparent;font-weight: 600;height: 49px;width:100px;" /> 

      </td>

        <td></td>


        <td align="right">

            <span>
          <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server" Width="220px">
                    <asp:ListItem>InteliSpace Portal Engine</asp:ListItem>
           </asp:DropDownList>

            
      </span>

        </td>
        <td>

            <span>
        

            <asp:TextBox ID="TextBox3" CssClass="form-control" runat="server" Width="200px" placeholder=""></asp:TextBox>
      </span>

        </td>

    </tr>


       
  </tbody>
</table>

                                                                 <table class="table" style="margin-left: -15px;">
  
  <tbody>
    

      <tr>
           <td style="width: 254px;">ISP Software Only:</td>
           <td >
               <asp:Button ID="Button4" runat="server" Text="1" style="color: white !important;cursor: default;background-color: #178bc6 !important;border: 1px solid #178bc6;border-bottom-color: transparent;font-weight: 600;height: 49px;width:45px;" />
               <asp:Button ID="Button7" runat="server" Text="2" style="color: white !important;cursor: default;background-color: #178bc6 !important;border: 1px solid #178bc6;border-bottom-color: transparent;font-weight: 600;height: 49px;width:45px;" />
               <asp:Button ID="Button9" runat="server" Text="3" style="color: white !important;cursor: default;background-color: #178bc6 !important;border: 1px solid #178bc6;border-bottom-color: transparent;font-weight: 600;height: 49px;width:45px;" />
               <asp:Button ID="Button10" runat="server" Text="4" style="color: white !important;cursor: default;background-color: #178bc6 !important;border: 1px solid #178bc6;border-bottom-color: transparent;font-weight: 600;height: 49px;width:45px;" />
               <asp:Button ID="Button12" runat="server" Text="5" style="color: white !important;cursor: default;background-color: #178bc6 !important;border: 1px solid #178bc6;border-bottom-color: transparent;font-weight: 600;height: 49px;width:45px;" />
               <asp:Button ID="Button6" runat="server" Text="6" style="color: white !important;cursor: default;background-color: #178bc6 !important;border: 1px solid #178bc6;border-bottom-color: transparent;font-weight: 600;height: 49px;width:45px;" />
           </td>

           
    </tr>


       
  </tbody>
</table>



                                                               
                                                                <div class="row">
                                                                    <div class="col-md-6">
                                                                        <div class="table-responsive">
                                                                         <table class="table table-bordered" style="margin-left: -0px;">
                                                                    <thead class="thead-light">
                                                                        <tr>
                                                                            <th scope="col" class="w-25" style="background-color: #0b1f65;">No.</th>
                                                                            <th scope="col" class="w-35" style="background-color: #0b1f65;">Menu</th>
                                                                            <th scope="col" class="w-25" style="background-color: #0b1f65;">Mac address:</th>
                                                                            

                                                                        </tr>
                                                                    </thead>
                                                                    <tbody>
                                                                        <tr>
                                                                            <td align="center">1</td>
                                                                            <td>
                                                                                <asp:DropDownList ID="DropDownList2" CssClass="form-control" runat="server" style="width: 200px;">                                                                                     
                                                                                </asp:DropDownList>
                                                                                    
                                                                                    </td>
                                                                            <td>
                                                                                 <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server" Style="margin-top: 3px;" placeholder=""></asp:TextBox>
                                                                            </td>
                                                                            
                                                                        </tr>

                                                                    </tbody>
                                                                </table>
                                                                        </div>
                                                                    </div>
                                                                    
    
                                                                  </div>





                                                            </div>
                                                            <div class="tab-pane " id="SOFTWARE" role="tabpanel" aria-labelledby="SOFTWARE-tab">
                                                           
                                                                <asp:Button ID="Button1" runat="server" Text="Hardware High Availiabllity NOT required" style="color: white !important;cursor: default;background-color: #178bc6 !important;border: 1px solid #178bc6;border-bottom-color: transparent;font-weight: 600;height: 49px;margin-left: 149px;width:300px;" />                                    
                                                                <br /> <br />
                                                                <asp:Button ID="Button2" runat="server" Text="Hardware High Availiabllity IS required" style="color: black !important;cursor: default;background-color: #d2dee5 !important;border: 1px solid #d2dee5;border-bottom-color: transparent;font-weight: 600;height: 49px;margin-left: 149px;width:300px;" />                                                            


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





    <script src="../competitive-info/js/bootstrap.min.js"></script>


    <script>


        function GetApplicationData(ddl1) {
           
            var array = ddl1.value.split("|");

            if (array[2] == "Enterprise") {
                
                $("#txtConcurrent1")[0].value = $("#CONCURRENTENTERPRISEUSERS")[0].value;
            } else {
                $("#txtConcurrent1")[0].value = array[2];
            }

            
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


        .DELIVERY-info .nav-tabs > li.active > a, .DELIVERY-info .nav-tabs > li.active > a:focus, .DELIVERY-info .nav-tabs > li.active > a:hover {
            color: white !important;
            cursor: default;
            background-color: #178bc6 !important;
            border: 1px solid #178bc6;
            border-bottom-color: transparent;
            font-weight: 600;
        }

        .DELIVERY-info .nav-tabs > li > a {
            border-radius: 0;
            /*background: #178bc6;*/
            background: #d2dee5;
            color: black;
            width: 330px;
            text-align: center;
            font-size: 14px;
            text-transform: uppercase;
        }
    </style>

</body>
</html>

