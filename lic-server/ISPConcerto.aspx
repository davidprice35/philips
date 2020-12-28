<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="false" CodeFile="ISPConcerto.aspx.cs" Inherits="competitive_info_Competitors" %>

<%--<%@ Register Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI" TagPrefix="asp" %>
<%@ Register Assembly="Syncfusion.EJ.Web, Version=16.3460.0.21, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89" Namespace="Syncfusion.JavaScript.Web" TagPrefix="ej" %>
<%@ Register Assembly="Syncfusion.EJ, Version=16.3460.0.21, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89" Namespace="Syncfusion.JavaScript.Models" TagPrefix="ej" %>--%>


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
    <!--[if lt IE 9]>remove
      <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->


  <%--  <link href="https://cdn.syncfusion.com/16.1.0.37/js/web/flat-azure/ej.web.all.min.css" rel="stylesheet" />
    <script src='<%= Page.ResolveClientUrl("~/js/ej/jquery-1.11.3.min.js")%>' type="text/javascript"></script>
    <script src='<%= Page.ResolveClientUrl("~/js/ej/jsrender.min.js")%>' type="text/javascript"></script>
    <script src='<%= Page.ResolveClientUrl("~/js/ej/ej.web.all.min.js")%>' type="text/javascript"></script>
    <script src='<%= Page.ResolveClientUrl("~/js/ej/ej.webform.min.js")%>' type="text/javascript"></script>--%>



    <link href="https://cdn.jsdelivr.net/npm/select2@4.0.13/dist/css/select2.min.css" rel="stylesheet" />




    


    <style>


        .select2-search--dropdown {
            padding:0px !important;
        }

        .select2-container {
            margin-top: 5px;
            height: 34px;
        }

        .HHAopt {
            color: black;
            cursor: default;
            background-color: #d2dee5;
            border: 1px solid #d2dee5;
            border-bottom-color: transparent;
        }

            .HHAopt.active {
                color: white !important;
                cursor: default;
                background-color: #178bc6;
                border: 1px solid #178bc6;
                border-bottom-color: transparent;
            }

        .HHAyesopt {
            color: black;
            cursor: default;
            background-color: #d2dee5;
            border: 1px solid #d2dee5;
            border-bottom-color: transparent;
        }

            .HHAyesopt.active {
                color: white !important;
                cursor: default;
                background-color: #178bc6;
                border: 1px solid #178bc6;
                border-bottom-color: transparent;
            }

        .HHNotPrem {
            color: black;
            cursor: default;
            background-color: #d2dee5;
            border: 1px solid #d2dee5;
            border-bottom-color: transparent;
        }

            .HHNotPrem.active {
                color: white !important;
                cursor: default;
                background-color: #178bc6;
                border: 1px solid #178bc6;
                border-bottom-color: transparent;
            }


        .ISPTestLicenseHW {
            color: black;
            cursor: default;
            background-color: #d2dee5;
            border: 1px solid #d2dee5;
            border-bottom-color: transparent;
        }

            .ISPTestLicenseHW.active {
                color: white !important;
                cursor: default;
                background-color: #178bc6;
                border: 1px solid #178bc6;
                border-bottom-color: transparent;
            }


        .AdditionalhostserverHW {
            color: black;
            cursor: default;
            background-color: #d2dee5;
            border: 1px solid #d2dee5;
            border-bottom-color: transparent;
        }

            .AdditionalhostserverHW.active {
                color: white !important;
                cursor: default;
                background-color: #178bc6;
                border: 1px solid #178bc6;
                border-bottom-color: transparent;
            }

        .AdditionalStorageRequiredHW {
            color: black;
            cursor: default;
            background-color: #d2dee5;
            border: 1px solid #d2dee5;
            border-bottom-color: transparent;
        }

            .AdditionalStorageRequiredHW.active {
                color: white !important;
                cursor: default;
                background-color: #178bc6;
                border: 1px solid #178bc6;
                border-bottom-color: transparent;
            }

        .Philipsprovidestorage {
            color: black;
            cursor: default;
            background-color: #d2dee5;
            border: 1px solid #d2dee5;
            border-bottom-color: transparent;
        }

            .Philipsprovidestorage.active {
                color: white !important;
                cursor: default;
                background-color: #178bc6;
                border: 1px solid #178bc6;
                border-bottom-color: transparent;
            }


        .ISPPremiumLicenseHW {
            color: black;
            cursor: default;
            background-color: #d2dee5;
            border: 1px solid #d2dee5;
            border-bottom-color: transparent;
        }

            .ISPPremiumLicenseHW.active {
                color: white !important;
                cursor: default;
                background-color: #178bc6;
                border: 1px solid #178bc6;
                border-bottom-color: transparent;
            }





        .STBAddStorage {
            color: black;
            cursor: default;
            background-color: #d2dee5;
            border: 1px solid #d2dee5;
            border-bottom-color: transparent;
        }

            .STBAddStorage.active {
                color: white !important;
                cursor: default;
                background-color: #178bc6;
                border: 1px solid #178bc6;
                border-bottom-color: transparent;
            }

        .ISPAdvancedlicense {
            color: black;
            cursor: default;
            background-color: #d2dee5;
            border: 1px solid #d2dee5;
            border-bottom-color: transparent;
        }

            .ISPAdvancedlicense.active {
                color: white !important;
                cursor: default;
                background-color: #178bc6;
                border: 1px solid #178bc6;
                border-bottom-color: transparent;
            }

        .ISPEnterprisetestlicense {
            color: black;
            cursor: default;
            background-color: #d2dee5;
            border: 1px solid #d2dee5;
            border-bottom-color: transparent;
        }

            .ISPEnterprisetestlicense.active {
                color: white !important;
                cursor: default;
                background-color: #178bc6;
                border: 1px solid #178bc6;
                border-bottom-color: transparent;
            }

        .ISPTextLicenseRequired {
            color: black;
            cursor: default;
            background-color: #d2dee5;
            border: 1px solid #d2dee5;
            border-bottom-color: transparent;
        }

            .ISPTextLicenseRequired.active {
                color: white !important;
                cursor: default;
                background-color: #178bc6;
                border: 1px solid #178bc6;
                border-bottom-color: transparent;
            }


        .HHA {
            color: black !important;
            cursor: default;
            background-color: #d2dee5 !important;
            border: 1px solid #d2dee5;
            border-bottom-color: transparent;
        }

            .HHA.active {
                color: white !important;
                cursor: default;
                background-color: #178bc6 !important;
                border: 1px solid #178bc6;
                border-bottom-color: transparent;
            }

        .ISPSoftwareButton {
            color: black !important;
            cursor: default;
            background-color: #d2dee5 !important;
            border: 1px solid #d2dee5;
            border-bottom-color: transparent;
            font-weight: 600;
            height: 49px;
            width: 100px;
        }

            .ISPSoftwareButton.active {
                color: white !important;
                cursor: default;
                background-color: #178bc6 !important;
                border: 1px solid #178bc6;
                border-bottom-color: transparent;
                font-weight: 600;
                height: 49px;
                width: 100px;
            }


        .ISPSoftwareOnly {
            color: black !important;
            cursor: default;
            background-color: #d2dee5 !important;
            border: 1px solid #d2dee5;
            border-bottom-color: transparent;
            font-weight: 600;
            height: 49px;
            width: 45px;
        }

            .ISPSoftwareOnly.active {
                color: white !important;
                cursor: default;
                background-color: #178bc6 !important;
                border: 1px solid #178bc6;
                border-bottom-color: transparent;
                font-weight: 600;
                height: 49px;
                width: 45px;
            }

            .softwareTable[readonly]
            {
                pointer-events:none;
            }

            .ISPSoftwareOnly[disabled] {
                color: grey !important;
               
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


                                     <ul class="nav navbar-nav icons-right" style="float: left;">
                                        <li class="icons"><a href="/lic-server/?id=<%=m_ID%>" >Project Profile</a></li>
                                         <li class="icons"><a href="/lic-server/ViewExisting.aspx" >Existing Project</a></li>
                                        
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
                                                <p style="font-weight: bolder;">
                                                    SITE INFORMATION 

                                                    <i class="fa fa-info-circle" data-container="body" data-toggle="popover" data-placement="bottom" data-content="Pop up msg" data-original-title="PopD" title="PopT"></i>


                                                </p>

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
                                                                <a class="nav-link active show" id="contact-tab" href="/lic-server/ISPDistributed.aspx?id=<%=m_ID %>" role="tab" aria-controls="contact" aria-selected="true" style="width: 158px;">Distributed</a>
                                                            </li>
                                                        </ul>
                                                        <div class="tab-content" id="myTabContent">
                                                            <div class="tab-pane active" id="Central" role="tabpanel" aria-labelledby="Central-tab">



                                                                
                                                <div class="row" style="margin-left: -24px;">
                                                    <div class="col-md-12">
                                                        <div class="row">
                                                            <div class="col-md-4">

                                                                <p style="color: black; margin-top: 20px;"><b>CONCURRENT ENTERPRISE USERS</b></p>
                                                                
                                                                <span id="CONCURRENTENTERPRISE_Error" style="display:none;">
                                                                    <div class='alert alert-warning' role='alert'>
                                                                     Concurrent users are not supported below 11
                                                                    </div>
                                                                </span>

                                                                <span id="CONCURRENTENTERPRISE_Error2" style="display:none;">
                                                                    <div class='alert alert-warning' role='alert'>
                                                                    Concurrent users can not exceed 50
                                                                    </div>
                                                                </span>

                                                                <table class="table table-bordered" style="margin-left: 0px; width: 63px;">
                                                                    <thead class="thead-light">
                                                                        <tr>
                                                                            <th scope="col" style="background-color: #0b1f65;">Concurrent Users.</th>

                                                                        </tr>
                                                                    </thead>
                                                                    <tbody>
                                                                        <tr>
                                                                            <td>
                                                                                <input type="number" id="CONCURRENTENTERPRISEUSERS" onchange="GetLicenceData();" value="<%=m_ConEnterpriseUsers %>" class="form-control" style="width: 100%;" name="CONCURRENTENTERPRISEUSERS" min="10" max="55">
                                                                                <%-- <ej:NumericTextBox ID="CONCURRENTENTERPRISEUSERS" MaxValue="50" MinValue="10" Value="35" Name="CONCURRENTENTERPRISEUSERS" runat="server" Width="100%" />--%>
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
                                           

               <div class="seperator" style="border-bottom-color: #cdcdcd; border-bottom-style: solid;    margin-left: -88px;  margin-bottom: 16px; max-width: 1561px;">
                                            </div>                                                   
                                          


                                                                <table class="table table-bordered" style="margin-left: -10px;">
                                                                    <thead class="thead-light">
                                                                        <tr>
                                                                            <th scope="col" style="background-color: #0b1f65;">No.</th>
                                                                            <th scope="col" style="background-color: #0b1f65;">Hospital Name</th>
                                                                            <th scope="col" style="background-color: #0b1f65;">Hospital Street</th>
                                                                            <th scope="col" style="background-color: #0b1f65;">Site</th>
                                                                            <th scope="col" style="background-color: #0b1f65;">Connectivity</th>
                                                                            <th scope="col" style="background-color: #0b1f65;">Remove</th>
                                                                        </tr>
                                                                    </thead>
                                                                    <tbody>
                                                                        <tr>
                                                                            <td align="center" style="vertical-align: middle;"><span style="align-items: center">1</span></td>
                                                                            <td>
                                                                                <asp:TextBox ID="txtHospitalName1" onblur="UpdateHospital(1);" CssClass="form-control " runat="server" Style="margin-top: 3px;" placeholder="Hospital Name"></asp:TextBox>
                                                                            </td>
                                                                            <td>
                                                                                <asp:TextBox ID="txtHospitalStreet1" CssClass="form-control" runat="server" Style="margin-top: 3px;" placeholder="Hospital Street"></asp:TextBox>
                                                                            </td>
                                                                            <td>
                                                                                <div class="form-check form-check-inline" style="text-align: center; margin-top: 6px;">
                                                                                    <input class="form-check-input" type="radio" name="HospitalSite1" id="HospitalSite1Main" value="Main" checked>
                                                                                    <label class="form-check-label" for="inlineRadio1">Main</label>



                                                                                </div>
                                                                            </td>
                                                                            <td>

                                                                                <div class="form-check form-check-inline" style="text-align: center; margin-top: 6px;">
                                                                                    <input class="form-check-input" type="radio" name="HospitalSiteConnectivity1" id="HospitalSite1ConnectivityHigh1" value="High" <%=m_connectH1 %>>
                                                                                    <label class="form-check-label" for="HospitalSiteConnectivity1">High</label>

                                                                                    <input class="form-check-input" type="radio" name="HospitalSiteConnectivity1" id="HospitalSite1ConnectivityMed1" value="Med"  <%=m_connectM1 %>>
                                                                                    <label class="form-check-label" for="HospitalSiteConnectivity1">Med</label>



                                                                                    <input class="form-check-input" type="radio" name="HospitalSiteConnectivity1" id="HospitalSite1ConnectivityLow1" value="Low"  <%=m_connectL1 %>>
                                                                                    <label class="form-check-label" for="HospitalSiteConnectivity1">Low</label>

                                                                                </div>

                                                                            </td>


                                                                            <td></td>
                                                                        </tr>

                                                                        <tr style="display: none; vertical-align: middle;" id="row2-central">
                                                                            <td align="center" style="vertical-align: middle;"><span style="align-items: center">2</span></td>
                                                                            <td>
                                                                                <asp:TextBox ID="txtHospitalName2" onblur="UpdateHospital(2);" CssClass="form-control" runat="server" Style="margin-top: 3px;" placeholder="Hospital Name"></asp:TextBox>
                                                                            </td>
                                                                            <td>
                                                                                <asp:TextBox ID="txtHospitalStreet2" CssClass="form-control" runat="server" Style="margin-top: 3px;" placeholder="Hospital Street"></asp:TextBox>
                                                                            </td>
                                                                            <td>
                                                                                <div class="form-check form-check-inline" style="text-align: center; margin-top: 6px;">

                                                                                    <input class="form-check-input" type="radio" name="HospitalSite2" id="HospitalSite2Remote" value="Remote" checked style="margin-left: 13px;">
                                                                                    <label class="form-check-label" for="HospitalSite2Remote">Remote</label>

                                                                                </div>
                                                                            </td>
                                                                            <td>

                                                                                <div class="form-check form-check-inline" style="text-align: center; margin-top: 6px;">
                                                                                    <input class="form-check-input" type="radio" name="HospitalSiteConnectivity2" id="HospitalSite1ConnectivityHigh2" value="High" <%=m_connectH2 %>>
                                                                                    <label class="form-check-label" for="HospitalSiteConnectivity2">High</label>

                                                                                    <input class="form-check-input" type="radio" name="HospitalSiteConnectivity2" id="HospitalSite1ConnectivityMed2" value="Med"  <%=m_connectM2 %>>
                                                                                    <label class="form-check-label" for="HospitalSiteConnectivity2">Med</label>                                                                                    

                                                                                    <input class="form-check-input" type="radio" name="HospitalSiteConnectivity2" id="HospitalSite1ConnectivityLow2" value="Low" <%=m_connectL2 %>>
                                                                                    <label class="form-check-label" for="HospitalSiteConnectivity2">Low</label>

                                                                                </div>

                                                                            </td>
                                                                            <td align="center">


                                                                                <span id="cmdHospitalDelete2" onclick="deleteHospital(this);">
                                                                                    <i class="fa fa-trash" aria-hidden="true" style="font-size: 22px; margin-top: 5px; color: #337ab7;"></i>
                                                                                </span>


                                                                            </td>
                                                                        </tr>

                                                                        <tr style="display: none; vertical-align: middle;" id="row3-central">
                                                                            <td align="center" style="vertical-align: middle;">3</td>
                                                                            <td>
                                                                                <asp:TextBox ID="txtHospitalName3" onblur="UpdateHospital(3);" CssClass="form-control" runat="server" Style="margin-top: 3px;" placeholder="Hospital Name"></asp:TextBox>
                                                                            </td>
                                                                            <td>
                                                                                <asp:TextBox ID="txtHospitalStreet3" CssClass="form-control" runat="server" Style="margin-top: 3px;" placeholder="Hospital Street"></asp:TextBox>
                                                                            </td>
                                                                            <td>
                                                                                <div class="form-check form-check-inline" style="text-align: center; margin-top: 6px;">


                                                                                    <input class="form-check-input" type="radio" name="HospitalSite3" id="HospitalSite3Remote" value="Remote" checked style="margin-left: 13px;">
                                                                                    <label class="form-check-label" for="HospitalSite2Remote">Remote</label>

                                                                                </div>


                                                                            </td>

                                                                            <td>

                                                                                <div class="form-check form-check-inline" style="text-align: center; margin-top: 6px;">
                                                                                    <input class="form-check-input" type="radio" name="HospitalSiteConnectivity3" id="HospitalSite1ConnectivityHigh3" value="High" <%=m_connectH3 %>>
                                                                                    <label class="form-check-label" for="inlineRadio3">High</label>

                                                                                    <input class="form-check-input" type="radio" name="HospitalSiteConnectivity3" id="HospitalSite1ConnectivityMed3" value="Med" <%=m_connectM3 %>>
                                                                                    <label class="form-check-label" for="inlineRadio4">Med</label>



                                                                                    <input class="form-check-input" type="radio" name="HospitalSiteConnectivity3" id="HospitalSite1ConnectivityLow3" value="Low" <%=m_connectL3 %>>
                                                                                    <label class="form-check-label" for="inlineRadio5">Low</label>

                                                                                </div>

                                                                            </td>
                                                                            <td align="center">

                                                                                <span id="cmdHospitalDelete3" onclick="deleteHospital(this);">
                                                                                    <i class="fa fa-trash" aria-hidden="true" style="font-size: 22px; margin-top: 5px;color: #337ab7;"></i>
                                                                                </span>


                                                                            </td>
                                                                        </tr>

                                                                        <tr style="display: none; vertical-align: middle;" id="row4-central">
                                                                            <td align="center" style="vertical-align: middle;">4</td>
                                                                            <td>
                                                                                <asp:TextBox ID="txtHospitalName4" onblur="UpdateHospital(4);" CssClass="form-control" runat="server" Style="margin-top: 3px;" placeholder="Hospital Name"></asp:TextBox>
                                                                            </td>
                                                                            <td>
                                                                                <asp:TextBox ID="txtHospitalStreet4" CssClass="form-control" runat="server" Style="margin-top: 3px;" placeholder="Hospital Street"></asp:TextBox>
                                                                            </td>
                                                                            <td>
                                                                                <div class="form-check form-check-inline" style="text-align: center; margin-top: 6px;">


                                                                                    <input class="form-check-input" type="radio" name="HospitalSite4" id="HospitalSite4Remote" value="Remote" checked style="margin-left: 13px;">
                                                                                    <label class="form-check-label" for="HospitalSite4Remote">Remote</label>

                                                                                </div>
                                                                            </td>
                                                                            <td>

                                                                                <div class="form-check form-check-inline" style="text-align: center; margin-top: 6px;">
                                                                                    <input class="form-check-input" type="radio" name="HospitalSiteConnectivity4" id="HospitalSite1ConnectivityHigh4" value="High" <%=m_connectH4 %>>
                                                                                    <label class="form-check-label" for="inlineRadio3">High</label>

                                                                                    <input class="form-check-input" type="radio" name="HospitalSiteConnectivity4" id="HospitalSite1ConnectivityMed4" value="Med" <%=m_connectM4 %>>
                                                                                    <label class="form-check-label" for="inlineRadio4">Med</label>



                                                                                    <input class="form-check-input" type="radio" name="HospitalSiteConnectivity4" id="HospitalSite1ConnectivityLow4" value="Low" <%=m_connectL4 %>>
                                                                                    <label class="form-check-label" for="inlineRadio5">Low</label>

                                                                                </div>

                                                                            </td>
                                                                            <td align="center">

                                                                                <span id="cmdHospitalDelete4" onclick="deleteHospital(this);">
                                                                                    <i class="fa fa-trash" aria-hidden="true" style="font-size: 22px; margin-top: 5px;color: #337ab7;"></i>
                                                                                </span>


                                                                            </td>
                                                                        </tr>


                                                                        <tr style="display: none; vertical-align: middle;" id="row5-central">
                                                                            <td align="center" style="vertical-align: middle;">5</td>
                                                                            <td>
                                                                                <asp:TextBox ID="txtHospitalName5" CssClass="form-control" onblur="UpdateHospital(5);" runat="server" Style="margin-top: 3px;" placeholder="Hospital Name"></asp:TextBox>
                                                                            </td>
                                                                            <td>
                                                                                <asp:TextBox ID="txtHospitalStreet5" CssClass="form-control" runat="server" Style="margin-top: 3px;" placeholder="Hospital Street"></asp:TextBox>
                                                                            </td>
                                                                            <td>
                                                                                <div class="form-check form-check-inline" style="text-align: center; margin-top: 6px;">


                                                                                    <input class="form-check-input" type="radio" name="HospitalSite5" id="HospitalSite5Remote" value="Remote" checked style="margin-left: 13px;" >
                                                                                    <label class="form-check-label" for="HospitalSite5Remote">Remote</label>

                                                                                </div>
                                                                            </td>
                                                                            <td>

                                                                                <div class="form-check form-check-inline" style="text-align: center; margin-top: 6px;">
                                                                                    <input class="form-check-input" type="radio" name="HospitalSiteConnectivity5" id="HospitalSite1ConnectivityHigh5" value="High"  <%=m_connectH5 %>>
                                                                                    <label class="form-check-label" for="inlineRadio3">High</label>

                                                                                    <input class="form-check-input" type="radio" name="HospitalSiteConnectivity5" id="HospitalSite1ConnectivityMed5" value="Med"  <%=m_connectM5 %>>
                                                                                    <label class="form-check-label" for="inlineRadio4">Med</label>



                                                                                    <input class="form-check-input" type="radio" name="HospitalSiteConnectivity5" id="HospitalSite1ConnectivityLow5" value="Low"  <%=m_connectL5 %>>
                                                                                    <label class="form-check-label" for="inlineRadio5">Low</label>

                                                                                </div>

                                                                            </td>
                                                                            <td align="center">

                                                                                <span id="cmdHospitalDelete5" onclick="deleteHospital(this);">
                                                                                    <i class="fa fa-trash" aria-hidden="true" style="font-size: 22px; margin-top: 5px;color: #337ab7;"></i>
                                                                                </span>


                                                                            </td>
                                                                        </tr>

                                                                        <tr style="display: none; vertical-align: middle;" id="row6-central">
                                                                            <td align="center" style="vertical-align: middle;">6</td>
                                                                            <td>
                                                                                <asp:TextBox ID="txtHospitalName6" CssClass="form-control" onblur="UpdateHospital(6);" runat="server" Style="margin-top: 3px;" placeholder="Hospital Name"></asp:TextBox>
                                                                            </td>
                                                                            <td>
                                                                                <asp:TextBox ID="txtHospitalStreet6" CssClass="form-control" runat="server" Style="margin-top: 3px;" placeholder="Hospital Street"></asp:TextBox>
                                                                            </td>
                                                                            <td>
                                                                                <div class="form-check form-check-inline" style="text-align: center; margin-top: 6px;">


                                                                                    <input class="form-check-input" type="radio" name="HospitalSite6" id="HospitalSit6Remote" value="Remote" style="margin-left: 13px;" checked>
                                                                                    <label class="form-check-label" for="inlineRadio2">Remote</label>

                                                                                </div>
                                                                            </td>
                                                                            <td>

                                                                                <div class="form-check form-check-inline" style="text-align: center; margin-top: 6px;">
                                                                                    <input class="form-check-input" type="radio" name="HospitalSiteConnectivity6" id="HospitalSite1ConnectivityHigh6" value="High"  <%=m_connectH6 %>>
                                                                                    <label class="form-check-label" for="inlineRadio3">High</label>

                                                                                    <input class="form-check-input" type="radio" name="HospitalSiteConnectivity6" id="HospitalSite1ConnectivityMed6" value="Med" <%=m_connectM6 %>>
                                                                                    <label class="form-check-label" for="inlineRadio4">Med</label>



                                                                                    <input class="form-check-input" type="radio" name="HospitalSiteConnectivity6" id="HospitalSite1ConnectivityLow6" value="Low"<%=m_connectL6 %>>
                                                                                    <label class="form-check-label" for="inlineRadio5">Low</label>

                                                                                </div>

                                                                            </td>
                                                                            <td align="center">

                                                                                <span id="cmdHospitalDelete6" onclick="deleteHospital(this);">
                                                                                    <i class="fa fa-trash" aria-hidden="true" style="font-size: 22px; margin-top: 5px;color: #337ab7;"></i>
                                                                                </span>


                                                                            </td>
                                                                        </tr>

                                                                        <tr style="display: none; vertical-align: middle;" id="row7-central">
                                                                            <td align="center" style="vertical-align: middle;">7</td>
                                                                            <td>
                                                                                <asp:TextBox ID="txtHospitalName7" CssClass="form-control" onblur="UpdateHospital(5);" runat="server" Style="margin-top: 3px;" placeholder="Hospital Name"></asp:TextBox>
                                                                            </td>
                                                                            <td>
                                                                                <asp:TextBox ID="txtHospitalStreet7" CssClass="form-control" runat="server" Style="margin-top: 3px;" placeholder="Hospital Street"></asp:TextBox>
                                                                            </td>
                                                                            <td>
                                                                                <div class="form-check form-check-inline" style="text-align: center; margin-top: 6px;">


                                                                                    <input class="form-check-input" type="radio" name="HospitalSite7" id="HospitalSit7Remote" value="Remote" checked style="margin-left: 13px;" checked>
                                                                                    <label class="form-check-label" for="inlineRadio2">Remote</label>

                                                                                </div>
                                                                            </td>
                                                                            <td>

                                                                                <div class="form-check form-check-inline" style="text-align: center; margin-top: 6px;">
                                                                                    <input class="form-check-input" type="radio" name="HospitalSiteConnectivity7" id="HospitalSite1ConnectivityHigh7" value="High" <%=m_connectH7 %>>
                                                                                    <label class="form-check-label" for="inlineRadio3">High</label>

                                                                                    <input class="form-check-input" type="radio" name="HospitalSiteConnectivity7" id="HospitalSite1ConnectivityMed7" value="Med" <%=m_connectM7 %>>
                                                                                    <label class="form-check-label" for="inlineRadio4">Med</label>



                                                                                    <input class="form-check-input" type="radio" name="HospitalSiteConnectivity7" id="HospitalSite1ConnectivityLow7" value="Low" <%=m_connectL7 %>>
                                                                                    <label class="form-check-label" for="inlineRadio5">Low</label>

                                                                                </div>

                                                                            </td>
                                                                            <td align="center">

                                                                                <span id="cmdHospitalDelete7" onclick="deleteHospital(this);">
                                                                                    <i class="fa fa-trash" aria-hidden="true" style="font-size: 22px; margin-top: 5px;color:#337ab7"></i>
                                                                                </span>


                                                                            </td>
                                                                        </tr>

                                                                        <tr style="display: none; vertical-align: middle;" id="row8-central">
                                                                            <td align="center" style="vertical-align: middle;">8</td>
                                                                            <td>
                                                                                <asp:TextBox ID="txtHospitalName8" CssClass="form-control" onblur="UpdateHospital(5);" runat="server" Style="margin-top: 3px;" placeholder="Hospital Name"></asp:TextBox>
                                                                            </td>
                                                                            <td>
                                                                                <asp:TextBox ID="txtHospitalStreet8" CssClass="form-control" runat="server" Style="margin-top: 3px;" placeholder="Hospital Street"></asp:TextBox>
                                                                            </td>
                                                                            <td>
                                                                                <div class="form-check form-check-inline" style="text-align: center; margin-top: 6px;">


                                                                                    <input class="form-check-input" type="radio" name="HospitalSite8" id="HospitalSit8Remote" value="Remote" style="margin-left: 13px;" checked>
                                                                                    <label class="form-check-label" for="inlineRadio2">Remote</label>

                                                                                </div>
                                                                            </td>
                                                                            <td>

                                                                                <div class="form-check form-check-inline" style="text-align: center; margin-top: 6px;">
                                                                                    <input class="form-check-input" type="radio" name="HospitalSiteConnectivity8" id="HospitalSite1ConnectivityHigh8" value="High" <%=m_connectH8 %>>
                                                                                    <label class="form-check-label" for="inlineRadio3">High</label>

                                                                                    <input class="form-check-input" type="radio" name="HospitalSiteConnectivity8" id="HospitalSite1ConnectivityMed8" value="Med" <%=m_connectM8 %>>
                                                                                    <label class="form-check-label" for="inlineRadio4">Med</label>



                                                                                    <input class="form-check-input" type="radio" name="HospitalSiteConnectivity8" id="HospitalSite1ConnectivityLow8" value="Low" <%=m_connectL8 %>>
                                                                                    <label class="form-check-label" for="inlineRadio5">Low</label>

                                                                                </div>

                                                                            </td>
                                                                            <td align="center">

                                                                                <span id="cmdHospitalDelete8" onclick="deleteHospital(this);">
                                                                                    <i class="fa fa-trash" aria-hidden="true" style="font-size: 22px; margin-top: 5px;color: #337ab7;"></i>
                                                                                </span>


                                                                            </td>
                                                                        </tr>

                                                                        <tr style="display: none; vertical-align: middle;" id="row9-central">
                                                                            <td align="center" style="vertical-align: middle;">9</td>
                                                                            <td>
                                                                                <asp:TextBox ID="txtHospitalName9" CssClass="form-control" onblur="UpdateHospital(5);" runat="server" Style="margin-top: 3px;" placeholder="Hospital Name"></asp:TextBox>
                                                                            </td>
                                                                            <td>
                                                                                <asp:TextBox ID="txtHospitalStreet9" CssClass="form-control" runat="server" Style="margin-top: 3px;" placeholder="Hospital Street"></asp:TextBox>
                                                                            </td>
                                                                            <td>
                                                                                <div class="form-check form-check-inline" style="text-align: center; margin-top: 6px;">


                                                                                    <input class="form-check-input" type="radio" name="HospitalSite9" id="HospitalSit9Remote" value="Remote" style="margin-left: 13px;" checked>
                                                                                    <label class="form-check-label" for="inlineRadio2">Remote</label>

                                                                                </div>
                                                                            </td>
                                                                            <td>

                                                                                <div class="form-check form-check-inline" style="text-align: center; margin-top: 6px;">
                                                                                    <input class="form-check-input" type="radio" name="HospitalSiteConnectivity9" id="HospitalSite1ConnectivityHigh9" value="High"  <%=m_connectH9 %>>
                                                                                    <label class="form-check-label" for="inlineRadio3">High</label>

                                                                                    <input class="form-check-input" type="radio" name="HospitalSiteConnectivity9" id="HospitalSite1ConnectivityMed9" value="Med" <%=m_connectM8 %>>
                                                                                    <label class="form-check-label" for="inlineRadio4">Med</label>
                                                                                                                                                                       
                                                                                    <input class="form-check-input" type="radio" name="HospitalSiteConnectivity9" id="HospitalSite1ConnectivityLow9" value="Low"  <%=m_connectL8 %>>
                                                                                    <label class="form-check-label" for="inlineRadio5">Low</label>

                                                                                </div>

                                                                            </td>
                                                                            <td align="center">

                                                                                <span id="cmdHospitalDelete9" onclick="deleteHospital(this);">
                                                                                    <i class="fa fa-trash" aria-hidden="true" style="font-size: 22px; margin-top: 5px;color: #337ab7;"></i>
                                                                                </span>


                                                                            </td>
                                                                        </tr>

                                                                        <tr style="display: none; vertical-align: middle;" id="row10-central">
                                                                            <td align="center" style="vertical-align: middle;">10</td>
                                                                            <td>
                                                                                <asp:TextBox ID="txtHospitalName10" CssClass="form-control" onblur="UpdateHospital(5);" runat="server" Style="margin-top: 3px;" placeholder="Hospital Name"></asp:TextBox>
                                                                            </td>
                                                                            <td>
                                                                                <asp:TextBox ID="txtHospitalStreet10" CssClass="form-control" runat="server" Style="margin-top: 3px;" placeholder="Hospital Street"></asp:TextBox>
                                                                            </td>
                                                                            <td>
                                                                                <div class="form-check form-check-inline" style="text-align: center; margin-top: 6px;">

                                                                                    <input class="form-check-input" type="radio" name="HospitalSite10" id="HospitalSite10Remote" value="Remote" style="margin-left: 13px;" checked>
                                                                                    <label class="form-check-label" for="inlineRadio2">Remote</label>

                                                                                </div>
                                                                            </td>
                                                                            <td>

                                                                                <div class="form-check form-check-inline" style="text-align: center; margin-top: 6px;">
                                                                                    <input class="form-check-input" type="radio" name="HospitalSiteConnectivity10" id="HospitalSite1ConnectivityHigh10" value="High"  <%=m_connectH10 %>>
                                                                                    <label class="form-check-label" for="inlineRadio3">High</label>

                                                                                    <input class="form-check-input" type="radio" name="HospitalSiteConnectivity10" id="HospitalSite1ConnectivityMed10" value="Med"  <%=m_connectM10 %>>
                                                                                    <label class="form-check-label" for="inlineRadio4">Med</label>



                                                                                    <input class="form-check-input" type="radio" name="HospitalSiteConnectivity10" id="HospitalSite1ConnectivityLow10" value="Low"  <%=m_connectL10 %>>
                                                                                    <label class="form-check-label" for="inlineRadio5">Low</label>

                                                                                </div>

                                                                            </td>
                                                                            <td align="center">

                                                                                <span id="cmdHospitalDelete10" onclick="deleteHospital(this);">
                                                                                    <i class="fa fa-trash" aria-hidden="true" style="font-size: 22px; margin-top: 5px;color: #337ab7;"></i>
                                                                                </span>


                                                                            </td>
                                                                        </tr>

                                                                    </tbody>


                                                                </table>
                                                                <asp:HiddenField ID="hidCentralSite" Value="1" runat="server" />


                                                                <div onclick="CentralAddSite(true);" style="cursor: pointer;">+ Add another site </div>
 

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
                                                                                <th scope="col" class="" style="width: 20px;background-color: #0b1f65;">No.</th>
                                                                                <th scope="col" class="" style="width: 450px;background-color: #0b1f65;">Applications</th>
                                                                                <th scope="col" class="" style="width: 3%; background-color: #0b1f65;">Concurrent Users</th>
                                                                                <th scope="col" class="" style="width: 10%; background-color: #0b1f65;">Description</th>
                                                                                <th scope="col" class="w-25" style="background-color: #0b1f65;">Hospital Name</th>
                                                                                <th scope="col" class="w-10" style="width: 20px;background-color: #0b1f65;">Remove</th>

                                                                            </tr>
                                                                        </thead>
                                                                        <tbody>
                                                                             <tr style="" vertical-align: middle;" id="row1-additional-apps">
                                                                                <td align="center">1</td>
                                                                                <td>
                                                                                    <asp:DropDownList ID="cmdApplication1"  onchange="GetApplicationData(this)" CssClass="form-control ApplicationDDL appddlselect" runat="server" Style="width: 100%; margin-top: 3px;">

                                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Pro - 1 User|No|1|NA">NICA439 - Mirada Viewer Pro </asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer  Premium |No|1|NA">NICA441 - Mirada Viewer  Premium </asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Pro - S.Lic|No|Enterprise|">NICA445 - Mirada Viewer Pro - S.Lic</asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Prem. ISP - S.Lic|No|Enterprise|">NICA447 - Mirada Viewer Prem. ISP - S.Lic</asp:ListItem>
                                                                                        <asp:ListItem Value="NM Processing App Suite|Yes|2|Up to max of Enterprise concurrent users">NICA436 - NM Processing App Suite</asp:ListItem>
                                                                                        <asp:ListItem Value="NM Astonish Recon Suite|No|Enterprise|">NICA438 - NM Astonish Recon Suite</asp:ListItem>
                                                                                        <asp:ListItem Value="NM NeuroQ PET |Yes|1|Up to max of Enterprise concurrent users|x">NICA356/FIC0085 - NM NeuroQ PET </asp:ListItem>
                                                                                        <asp:ListItem Value="NeuroQ SPECT Opt |Yes|1|Up to max of Enterprise concurrent users">NICA360 - NeuroQ SPECT Opt </asp:ListItem>
                                                                                        <asp:ListItem Value="NM Amyloid Analysis |Yes|1|Up to max of Enterprise concurrent users|x">NICA965/FIC0127 - NM Amyloid Analysis </asp:ListItem>
                                                                                        <asp:ListItem Value="NM EQual |Yes|1|Up to max of Enterprise concurrent users|x">NICA358/FIC0466 - NM EQual </asp:ListItem>
                                                                                        <asp:ListItem Value="NeuroQ DaTscan Opt |Yes|1|Up to max of Enterprise concurrent users|x">NICA367/FIC0466 - NeuroQ DaTscan Opt </asp:ListItem>
                                                                                        <asp:ListItem Value="Emory Cardiac ToolBox V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB352 - Emory Cardiac ToolBox V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB SPECT V4.x  |Yes|1|Up to max of Enterprise concurrent users|x">NICB355/FIC0222 - ECTB SPECT V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB PET V4.x  |Yes|1|Up to max of Enterprise concurrent users|x">NICB358/FIC0223 - ECTB PET V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB Heart Fusion V4.x  |Yes|1|Up to max of Enterprise concurrent users|x">NICB361/FIC0224 - ECTB Heart Fusion V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB SmartReport Option V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB364/FIC0252 - ECTB SmartReport Option V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB CFR MBF V4.x |Yes|1|Up to max of Enterprise concurrent users">NICB550/FIC0459 - ECTB CFR MBF V4.x </asp:ListItem>
                                                                                        <asp:ListItem Value="NM AutoQuant 2015.x  |Yes|1|Up to max of Enterprise concurrent users">FIC0264/FIC0264 - NM AutoQuant 2015.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="SPECT AutoQuant 2015.x  |Yes|1|Up to max of Enterprise concurrent users|x">FIC0266/FIC0266 - SPECT AutoQuant 2015.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="NM/CTA Cedars Fusion 2015.x |Yes|1|Up to max of Enterprise concurrent users">FIC0268 - NM/CTA Cedars Fusion 2015.x </asp:ListItem>
                                                                                        <asp:ListItem Value="Cedars MFSC 2015.x |Yes|1|Up to max of Enterprise concurrent users">FIC0270 - Cedars MFSC 2015.x </asp:ListItem>
                                                                                        <asp:ListItem Value="NM AutoQUANT 2017  |Yes|1|Up to max of Enterprise concurrent users">FIC0473/FIC0473 - NM AutoQUANT 2017  </asp:ListItem>
                                                                                        <asp:ListItem Value="SPECT AutoQUANT 2017  |Yes|1|Up to max of Enterprise concurrent users">FIC0474/FIC0474 - SPECT AutoQUANT 2017  </asp:ListItem>
                                                                                        <asp:ListItem Value="NM/CTA Cedars Fusion 2017 |Yes|1|Up to max of Enterprise concurrent users">FIC0475/FIC0475 - NM/CTA Cedars Fusion 2017 </asp:ListItem>
                                                                                        <asp:ListItem Value="Cedars MFSC 2017 |Yes|1|Up to max of Enterprise concurrent users">FIC0476/FIC0476 - Cedars MFSC 2017 </asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM SPECT 2016|No|Enterprise|">FIC0304 - Corridor4DM SPECT 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM NM 2016|No|Enterprise|">FIC0303 - Corridor4DM NM 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CT Opt 2016|No|Enterprise|">FIC0305 - Corridor4DM CT Opt 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor 4DM CFR MBF Opt 2016|No|Enterprise|">FIC0306 - Corridor 4DM CFR MBF Opt 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM NM 2018|No|Enterprise|">FIC0461 - Corridor4DM NM 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM SPECT 2018|No|Enterprise|">FIC0462 - Corridor4DM SPECT 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CT Opt 2018|No|Enterprise|">FIC0463 - Corridor4DM CT Opt 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CFR MBF Opt 2018|No|Enterprise|">FIC0464 - Corridor4DM CFR MBF Opt 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Zero FootPrint Viewer SW - 2 User|No|2|55|x">NICA168/FIC0439 - Zero FootPrint Viewer SW - 2 User</asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Prostate |Yes|1|Sum of FICO4329 and NICA283 and NICA282 and NICA288 should be max 4 and max 10 for hybrid &amp; distributed">NICA283/FIC0429 - DynaCAD Prostate </asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Breast |No|1|">NICA282/FIC0429 - DynaCAD Breast </asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Combo Package |No|1||x">NICA288/FIC0429 - DynaCAD Combo Package </asp:ListItem>
                                                                                        <asp:ListItem Value="NM JETPack App License - Add_Users|NULL||NULL">FIC0095 - NM JETPack App License - Add_Users</asp:ListItem>

                                                                                        <asp:ListItem Value="NeuroQ SPECT Opt - Add_Users|NULL||NULL">FIC0253 - NeuroQ SPECT Opt - Add_Users</asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB NM v4.x - Add_Users|NULL||NULL">FIC0221 - ECTB NM v4.x - Add_Users</asp:ListItem>

                                                                                      

                                                                                    </asp:DropDownList>

                                                                                </td>
                                                                                <td>
                                                                                    <asp:HiddenField ID="hidtxtConcurrent1" runat="server" />
                                                                                    <input type="number" id="txtConcurrent1" onblur="CheckConcurrentValue(this)" class="form-control" style="margin-top: 3px;" name="txtConcurrent1" min="1" max="55" value="<%=m_txtConcurrent1 %>" />
                                                                                    <div id="errortxtConcurrent1" style="color: red; padding-top: 2px; display: none;">Error with input</div>
                                                                                </td>

                                                                                <td align="center">
                                                                                    <i class="fa fa-info-circle" style="margin-top: 10px; font-size: 20px; color: #178bc6;" data-container="body" data-toggle="popover" data-placement="bottom" data-content="Pop up msg" data-original-title="PopD" title="PopT"></i>
                                                                                </td>

                                                                                <td>
                                                                                    <asp:DropDownList ID="cmdHospitalName1" CssClass="form-control" runat="server" Style="width: 100%; margin-top: 3px;">
                                                                                        <asp:ListItem></asp:ListItem>
                                                                                    </asp:DropDownList>
                                                                                </td>

                                                                                <td align="center">

                                                                                    <span id="cmdAddtionalAppDelete1" onclick="deleteAddtionalApp(this);">
                                                                                        <i class="fa fa-trash" aria-hidden="true" style="font-size: 22px; margin-top: 5px;color: #337ab7;"></i>
                                                                                    </span>


                                                                                </td>
                                                                            </tr>


                                                                            <tr style="<% if ( m_NoApp == "1" ){ %>  vertical-align: middle; <% } else { %> display: none; vertical-align: middle; <% } %>" id="row2-additional-apps">
                                                                                <td align="center">2</td>
                                                                                <td>
                                                                                    <asp:DropDownList ID="cmdApplication2" onchange="GetApplicationData(this)" CssClass="form-control ApplicationDDL" runat="server" Style="width: 100%;">

                                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Pro - 1 User|No|1|NA">NICA439 - Mirada Viewer Pro </asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer  Premium |No|1|NA">NICA441 - Mirada Viewer  Premium </asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Pro - S.Lic|No|Enterprise|">NICA445 - Mirada Viewer Pro - S.Lic</asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Prem. ISP - S.Lic|No|Enterprise|">NICA447 - Mirada Viewer Prem. ISP - S.Lic</asp:ListItem>
                                                                                        <asp:ListItem Value="NM Processing App Suite|Yes|2|Up to max of Enterprise concurrent users">NICA436 - NM Processing App Suite</asp:ListItem>
                                                                                        <asp:ListItem Value="NM Astonish Recon Suite|No|Enterprise|">NICA438 - NM Astonish Recon Suite</asp:ListItem>
                                                                                        <asp:ListItem Value="NM NeuroQ PET |Yes|1|Up to max of Enterprise concurrent users">NICA356/FIC0085 - NM NeuroQ PET </asp:ListItem>
                                                                                        <asp:ListItem Value="NeuroQ SPECT Opt |Yes|1|Up to max of Enterprise concurrent users">NICA360 - NeuroQ SPECT Opt </asp:ListItem>
                                                                                        <asp:ListItem Value="NM Amyloid Analysis |Yes|1|Up to max of Enterprise concurrent users">NICA965/FIC0127 - NM Amyloid Analysis </asp:ListItem>
                                                                                        <asp:ListItem Value="NM EQual |Yes|1|Up to max of Enterprise concurrent users">NICA358/FIC0466 - NM EQual </asp:ListItem>
                                                                                        <asp:ListItem Value="NeuroQ DaTscan Opt |Yes|1|Up to max of Enterprise concurrent users">NICA367/FIC0466 - NeuroQ DaTscan Opt </asp:ListItem>
                                                                                        <asp:ListItem Value="Emory Cardiac ToolBox V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB352 - Emory Cardiac ToolBox V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB SPECT V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB355/FIC0222 - ECTB SPECT V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB PET V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB358/FIC0223 - ECTB PET V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB Heart Fusion V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB361/FIC0224 - ECTB Heart Fusion V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB SmartReport Option V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB364/FIC0252 - ECTB SmartReport Option V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB CFR MBF V4.x |Yes|1|Up to max of Enterprise concurrent users">NICB550/FIC0459 - ECTB CFR MBF V4.x </asp:ListItem>
                                                                                        <asp:ListItem Value="NM AutoQuant 2015.x  |Yes|1|Up to max of Enterprise concurrent users">FIC0264/FIC0264 - NM AutoQuant 2015.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="SPECT AutoQuant 2015.x  |Yes|1|Up to max of Enterprise concurrent users">FIC0266/FIC0266 - SPECT AutoQuant 2015.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="NM/CTA Cedars Fusion 2015.x |Yes|1|Up to max of Enterprise concurrent users">FIC0268 - NM/CTA Cedars Fusion 2015.x </asp:ListItem>
                                                                                        <asp:ListItem Value="Cedars MFSC 2015.x |Yes|1|Up to max of Enterprise concurrent users">FIC0270 - Cedars MFSC 2015.x </asp:ListItem>
                                                                                        <asp:ListItem Value="NM AutoQUANT 2017  |Yes|1|Up to max of Enterprise concurrent users">FIC0473/FIC0473 - NM AutoQUANT 2017  </asp:ListItem>
                                                                                        <asp:ListItem Value="SPECT AutoQUANT 2017  |Yes|1|Up to max of Enterprise concurrent users">FIC0474/FIC0474 - SPECT AutoQUANT 2017  </asp:ListItem>
                                                                                        <asp:ListItem Value="NM/CTA Cedars Fusion 2017 |Yes|1|Up to max of Enterprise concurrent users">FIC0475/FIC0475 - NM/CTA Cedars Fusion 2017 </asp:ListItem>
                                                                                        <asp:ListItem Value="Cedars MFSC 2017 |Yes|1|Up to max of Enterprise concurrent users">FIC0476/FIC0476 - Cedars MFSC 2017 </asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM SPECT 2016|No|Enterprise|">FIC0304 - Corridor4DM SPECT 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM NM 2016|No|Enterprise|">FIC0303 - Corridor4DM NM 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CT Opt 2016|No|Enterprise|">FIC0305 - Corridor4DM CT Opt 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor 4DM CFR MBF Opt 2016|No|Enterprise|">FIC0306 - Corridor 4DM CFR MBF Opt 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM NM 2018|No|Enterprise|">FIC0461 - Corridor4DM NM 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM SPECT 2018|No|Enterprise|">FIC0462 - Corridor4DM SPECT 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CT Opt 2018|No|Enterprise|">FIC0463 - Corridor4DM CT Opt 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CFR MBF Opt 2018|No|Enterprise|">FIC0464 - Corridor4DM CFR MBF Opt 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Zero FootPrint Viewer SW - 2 User|No|2|55">NICA168/FIC0439 - Zero FootPrint Viewer SW - 2 User</asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Prostate |Yes|1|Sum of FICO4329 and NICA283 and NICA282 and NICA288 should be max 4 and max 10 for hybrid &amp; distributed">NICA283/FIC0429 - DynaCAD Prostate </asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Breast |No|1|">NICA282/FIC0429 - DynaCAD Breast </asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Combo Package |No|1|">NICA288/FIC0429 - DynaCAD Combo Package </asp:ListItem>
                                                                                        <asp:ListItem Value="NM JETPack App License - Add_Users|NULL||NULL">FIC0095 - NM JETPack App License - Add_Users</asp:ListItem>

                                                                                        <asp:ListItem Value="NeuroQ SPECT Opt - Add_Users|NULL||NULL">FIC0253 - NeuroQ SPECT Opt - Add_Users</asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB NM v4.x - Add_Users|NULL||NULL">FIC0221 - ECTB NM v4.x - Add_Users</asp:ListItem>

                                                                               


                                                                                    </asp:DropDownList>

                                                                                </td>
                                                                                <td>
                                                                                    <asp:HiddenField ID="hidtxtConcurrent2" runat="server" />
                                                                                    <input type="number" id="txtConcurrent2" onblur="CheckConcurrentValue(this)" class="form-control" style="margin-top: 3px;" name="txtConcurrent2" min="10" max="100" value="<%=m_txtConcurrent2 %>">
                                                                                    <div id="errortxtConcurrent2" class="errortxtConcurrent" style="color: red; padding-top: 2px; display: none;">Error with input</div>
                                                                                </td>

                                                                                <td align="center">
                                                                                    <i class="fa fa-info-circle" style="margin-top: 10px; font-size: 19px; color: #178bc6;" data-container="body" data-toggle="popover" data-placement="bottom" data-content="Pop up msg" data-original-title="PopD" title="PopT"></i>
                                                                                </td>

                                                                                <td>
                                                                                    <asp:DropDownList ID="cmdHospitalName2" CssClass="form-control" runat="server" Style="width: 100%;">
                                                                                       <asp:ListItem></asp:ListItem>
                                                                                    </asp:DropDownList>
                                                                                </td>
                                                                                <td align="center">

                                                                                    <span id="cmdAddtionalAppDelete2" onclick="deleteAddtionalApp(this);">
                                                                                        <i class="fa fa-trash" aria-hidden="true" style="font-size: 22px; margin-top: 5px;color: #337ab7;"></i>
                                                                                    </span>


                                                                                </td>
                                                                            </tr>

                                                                            <tr style="display: none; vertical-align: middle;" id="row3-additional-apps">
                                                                                <td align="center">3</td>
                                                                                <td>
                                                                                    <asp:DropDownList ID="cmdApplication3" onchange="GetApplicationData(this)" CssClass="form-control ApplicationDDL" runat="server" Style="width: 100%; margin-top: 3px;">
                                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Pro - 1 User|No|1|NA">NICA439 - Mirada Viewer Pro </asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer  Premium |No|1|NA">NICA441 - Mirada Viewer  Premium </asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Pro - S.Lic|No|Enterprise|">NICA445 - Mirada Viewer Pro - S.Lic</asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Prem. ISP - S.Lic|No|Enterprise|">NICA447 - Mirada Viewer Prem. ISP - S.Lic</asp:ListItem>
                                                                                        <asp:ListItem Value="NM Processing App Suite|Yes|2|Up to max of Enterprise concurrent users">NICA436 - NM Processing App Suite</asp:ListItem>
                                                                                        <asp:ListItem Value="NM Astonish Recon Suite|No|Enterprise|">NICA438 - NM Astonish Recon Suite</asp:ListItem>
                                                                                        <asp:ListItem Value="NM NeuroQ PET |Yes|1|Up to max of Enterprise concurrent users">NICA356/FIC0085 - NM NeuroQ PET </asp:ListItem>
                                                                                        <asp:ListItem Value="NeuroQ SPECT Opt |Yes|1|Up to max of Enterprise concurrent users">NICA360 - NeuroQ SPECT Opt </asp:ListItem>
                                                                                        <asp:ListItem Value="NM Amyloid Analysis |Yes|1|Up to max of Enterprise concurrent users">NICA965/FIC0127 - NM Amyloid Analysis </asp:ListItem>
                                                                                        <asp:ListItem Value="NM EQual |Yes|1|Up to max of Enterprise concurrent users">NICA358/FIC0466 - NM EQual </asp:ListItem>
                                                                                        <asp:ListItem Value="NeuroQ DaTscan Opt |Yes|1|Up to max of Enterprise concurrent users">NICA367/FIC0466 - NeuroQ DaTscan Opt </asp:ListItem>
                                                                                        <asp:ListItem Value="Emory Cardiac ToolBox V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB352 - Emory Cardiac ToolBox V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB SPECT V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB355/FIC0222 - ECTB SPECT V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB PET V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB358/FIC0223 - ECTB PET V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB Heart Fusion V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB361/FIC0224 - ECTB Heart Fusion V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB SmartReport Option V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB364/FIC0252 - ECTB SmartReport Option V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB CFR MBF V4.x |Yes|1|Up to max of Enterprise concurrent users">NICB550/FIC0459 - ECTB CFR MBF V4.x </asp:ListItem>
                                                                                        <asp:ListItem Value="NM AutoQuant 2015.x  |Yes|1|Up to max of Enterprise concurrent users">FIC0264/FIC0264 - NM AutoQuant 2015.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="SPECT AutoQuant 2015.x  |Yes|1|Up to max of Enterprise concurrent users">FIC0266/FIC0266 - SPECT AutoQuant 2015.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="NM/CTA Cedars Fusion 2015.x |Yes|1|Up to max of Enterprise concurrent users">FIC0268 - NM/CTA Cedars Fusion 2015.x </asp:ListItem>
                                                                                        <asp:ListItem Value="Cedars MFSC 2015.x |Yes|1|Up to max of Enterprise concurrent users">FIC0270 - Cedars MFSC 2015.x </asp:ListItem>
                                                                                        <asp:ListItem Value="NM AutoQUANT 2017  |Yes|1|Up to max of Enterprise concurrent users">FIC0473/FIC0473 - NM AutoQUANT 2017  </asp:ListItem>
                                                                                        <asp:ListItem Value="SPECT AutoQUANT 2017  |Yes|1|Up to max of Enterprise concurrent users">FIC0474/FIC0474 - SPECT AutoQUANT 2017  </asp:ListItem>
                                                                                        <asp:ListItem Value="NM/CTA Cedars Fusion 2017 |Yes|1|Up to max of Enterprise concurrent users">FIC0475/FIC0475 - NM/CTA Cedars Fusion 2017 </asp:ListItem>
                                                                                        <asp:ListItem Value="Cedars MFSC 2017 |Yes|1|Up to max of Enterprise concurrent users">FIC0476/FIC0476 - Cedars MFSC 2017 </asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM SPECT 2016|No|Enterprise|">FIC0304 - Corridor4DM SPECT 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM NM 2016|No|Enterprise|">FIC0303 - Corridor4DM NM 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CT Opt 2016|No|Enterprise|">FIC0305 - Corridor4DM CT Opt 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor 4DM CFR MBF Opt 2016|No|Enterprise|">FIC0306 - Corridor 4DM CFR MBF Opt 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM NM 2018|No|Enterprise|">FIC0461 - Corridor4DM NM 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM SPECT 2018|No|Enterprise|">FIC0462 - Corridor4DM SPECT 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CT Opt 2018|No|Enterprise|">FIC0463 - Corridor4DM CT Opt 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CFR MBF Opt 2018|No|Enterprise|">FIC0464 - Corridor4DM CFR MBF Opt 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Zero FootPrint Viewer SW - 2 User|No|2|55">NICA168/FIC0439 - Zero FootPrint Viewer SW - 2 User</asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Prostate |Yes|1|Sum of FICO4329 and NICA283 and NICA282 and NICA288 should be max 4 and max 10 for hybrid &amp; distributed">NICA283/FIC0429 - DynaCAD Prostate </asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Breast |No|1|">NICA282/FIC0429 - DynaCAD Breast </asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Combo Package |No|1|">NICA288/FIC0429 - DynaCAD Combo Package </asp:ListItem>
                                                                                        <asp:ListItem Value="NM JETPack App License - Add_Users|NULL||NULL">FIC0095 - NM JETPack App License - Add_Users</asp:ListItem>

                                                                                        <asp:ListItem Value="NeuroQ SPECT Opt - Add_Users|NULL||NULL">FIC0253 - NeuroQ SPECT Opt - Add_Users</asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB NM v4.x - Add_Users|NULL||NULL">FIC0221 - ECTB NM v4.x - Add_Users</asp:ListItem>
                                                                                    </asp:DropDownList>

                                                                                </td>
                                                                                <td>
                                                                                    <asp:HiddenField ID="hidtxtConcurrent3" runat="server" />
                                                                                    <input type="number" id="txtConcurrent3" onblur="CheckConcurrentValue(this)" class="form-control" style="margin-top: 3px;" name="txtConcurrent3" value="<%=m_txtConcurrent3 %>" min="0" max="100">
                                                                                    <div id="errortxtConcurrent3" class="errortxtConcurrent" style="color: red; padding-top: 2px; display: none;">Error with input</div>
                                                                                </td>

                                                                                <td align="center">
                                                                                    <i class="fa fa-info-circle" style="margin-top: 10px; font-size: 19px; color: #178bc6;" data-container="body" data-toggle="popover" data-placement="bottom" data-content="Pop up msg" data-original-title="PopD" title="PopT"></i>
                                                                                </td>

                                                                                <td>
                                                                                    <asp:DropDownList ID="cmdHospitalName3" CssClass="form-control" runat="server" Style="width: 100%; margin-top: 3px;">
                                                                                       <asp:ListItem></asp:ListItem>
                                                                                    </asp:DropDownList>
                                                                                </td>
                                                                                <td align="center">
                                                                                    <span id="cmdAddtionalAppDelete3" onclick="deleteAddtionalApp(this);">
                                                                                        <i class="fa fa-trash" aria-hidden="true" style="font-size: 22px; margin-top: 5px;color: #337ab7;"></i>
                                                                                    </span>
                                                                                </td>
                                                                            </tr>

                                                                            <tr style="display: none; vertical-align: middle;" id="row4-additional-apps">
                                                                                <td align="center">4</td>
                                                                                <td>
                                                                                    <asp:DropDownList ID="cmdApplication4" onchange="GetApplicationData(this)" CssClass="form-control ApplicationDDL" runat="server" Style="width: 100%; margin-top: 3px;">
                                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Pro - 1 User|No|1|NA">NICA439 - Mirada Viewer Pro </asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer  Premium |No|1|NA">NICA441 - Mirada Viewer  Premium </asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Pro - S.Lic|No|Enterprise|">NICA445 - Mirada Viewer Pro - S.Lic</asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Prem. ISP - S.Lic|No|Enterprise|">NICA447 - Mirada Viewer Prem. ISP - S.Lic</asp:ListItem>
                                                                                        <asp:ListItem Value="NM Processing App Suite|Yes|2|Up to max of Enterprise concurrent users">NICA436 - NM Processing App Suite</asp:ListItem>
                                                                                        <asp:ListItem Value="NM Astonish Recon Suite|No|Enterprise|">NICA438 - NM Astonish Recon Suite</asp:ListItem>
                                                                                        <asp:ListItem Value="NM NeuroQ PET |Yes|1|Up to max of Enterprise concurrent users">NICA356/FIC0085 - NM NeuroQ PET </asp:ListItem>
                                                                                        <asp:ListItem Value="NeuroQ SPECT Opt |Yes|1|Up to max of Enterprise concurrent users">NICA360 - NeuroQ SPECT Opt </asp:ListItem>
                                                                                        <asp:ListItem Value="NM Amyloid Analysis |Yes|1|Up to max of Enterprise concurrent users">NICA965/FIC0127 - NM Amyloid Analysis </asp:ListItem>
                                                                                        <asp:ListItem Value="NM EQual |Yes|1|Up to max of Enterprise concurrent users">NICA358/FIC0466 - NM EQual </asp:ListItem>
                                                                                        <asp:ListItem Value="NeuroQ DaTscan Opt |Yes|1|Up to max of Enterprise concurrent users">NICA367/FIC0466 - NeuroQ DaTscan Opt </asp:ListItem>
                                                                                        <asp:ListItem Value="Emory Cardiac ToolBox V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB352 - Emory Cardiac ToolBox V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB SPECT V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB355/FIC0222 - ECTB SPECT V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB PET V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB358/FIC0223 - ECTB PET V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB Heart Fusion V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB361/FIC0224 - ECTB Heart Fusion V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB SmartReport Option V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB364/FIC0252 - ECTB SmartReport Option V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB CFR MBF V4.x |Yes|1|Up to max of Enterprise concurrent users">NICB550/FIC0459 - ECTB CFR MBF V4.x </asp:ListItem>
                                                                                        <asp:ListItem Value="NM AutoQuant 2015.x  |Yes|1|Up to max of Enterprise concurrent users">FIC0264/FIC0264 - NM AutoQuant 2015.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="SPECT AutoQuant 2015.x  |Yes|1|Up to max of Enterprise concurrent users">FIC0266/FIC0266 - SPECT AutoQuant 2015.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="NM/CTA Cedars Fusion 2015.x |Yes|1|Up to max of Enterprise concurrent users">FIC0268 - NM/CTA Cedars Fusion 2015.x </asp:ListItem>
                                                                                        <asp:ListItem Value="Cedars MFSC 2015.x |Yes|1|Up to max of Enterprise concurrent users">FIC0270 - Cedars MFSC 2015.x </asp:ListItem>
                                                                                        <asp:ListItem Value="NM AutoQUANT 2017  |Yes|1|Up to max of Enterprise concurrent users">FIC0473/FIC0473 - NM AutoQUANT 2017  </asp:ListItem>
                                                                                        <asp:ListItem Value="SPECT AutoQUANT 2017  |Yes|1|Up to max of Enterprise concurrent users">FIC0474/FIC0474 - SPECT AutoQUANT 2017  </asp:ListItem>
                                                                                        <asp:ListItem Value="NM/CTA Cedars Fusion 2017 |Yes|1|Up to max of Enterprise concurrent users">FIC0475/FIC0475 - NM/CTA Cedars Fusion 2017 </asp:ListItem>
                                                                                        <asp:ListItem Value="Cedars MFSC 2017 |Yes|1|Up to max of Enterprise concurrent users">FIC0476/FIC0476 - Cedars MFSC 2017 </asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM SPECT 2016|No|Enterprise|">FIC0304 - Corridor4DM SPECT 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM NM 2016|No|Enterprise|">FIC0303 - Corridor4DM NM 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CT Opt 2016|No|Enterprise|">FIC0305 - Corridor4DM CT Opt 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor 4DM CFR MBF Opt 2016|No|Enterprise|">FIC0306 - Corridor 4DM CFR MBF Opt 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM NM 2018|No|Enterprise|">FIC0461 - Corridor4DM NM 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM SPECT 2018|No|Enterprise|">FIC0462 - Corridor4DM SPECT 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CT Opt 2018|No|Enterprise|">FIC0463 - Corridor4DM CT Opt 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CFR MBF Opt 2018|No|Enterprise|">FIC0464 - Corridor4DM CFR MBF Opt 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Zero FootPrint Viewer SW - 2 User|No|2|55">NICA168/FIC0439 - Zero FootPrint Viewer SW - 2 User</asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Prostate |Yes|1|Sum of FICO4329 and NICA283 and NICA282 and NICA288 should be max 4 and max 10 for hybrid &amp; distributed">NICA283/FIC0429 - DynaCAD Prostate </asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Breast |No|1|">NICA282/FIC0429 - DynaCAD Breast </asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Combo Package |No|1|">NICA288/FIC0429 - DynaCAD Combo Package </asp:ListItem>
                                                                                        <asp:ListItem Value="NM JETPack App License - Add_Users|NULL||NULL">FIC0095 - NM JETPack App License - Add_Users</asp:ListItem>

                                                                                        <asp:ListItem Value="NeuroQ SPECT Opt - Add_Users|NULL||NULL">FIC0253 - NeuroQ SPECT Opt - Add_Users</asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB NM v4.x - Add_Users|NULL||NULL">FIC0221 - ECTB NM v4.x - Add_Users</asp:ListItem>
                                                                                    </asp:DropDownList>

                                                                                </td>
                                                                                <td>
                                                                                    <asp:HiddenField ID="hidtxtConcurrent4" runat="server" />
                                                                                    <input type="number" id="txtConcurrent4" onblur="CheckConcurrentValue(this)" class="form-control" style="margin-top: 3px;" name="txtConcurrent4" min="0" max="100" value="<%=m_txtConcurrent4 %>">
                                                                                    <div id="errortxtConcurrent4" class="errortxtConcurrent" style="color: red; padding-top: 2px; display: none;">Error with input</div>
                                                                                </td>

                                                                                <td align="center">
                                                                                    <i class="fa fa-info-circle" style="margin-top: 10px; font-size: 19px; color: #178bc6;" data-container="body" data-toggle="popover" data-placement="bottom" data-content="Pop up msg" data-original-title="PopD" title="PopT"></i>
                                                                                </td>

                                                                                <td>
                                                                                    <asp:DropDownList ID="cmdHospitalName4" CssClass="form-control" runat="server" Style="width: 100%; margin-top: 3px;">
                                                                                        <asp:ListItem></asp:ListItem>
                                                                                    </asp:DropDownList>
                                                                                </td>
                                                                                <td align="center">
                                                                                    <span id="cmdAddtionalAppDelete4" onclick="deleteAddtionalApp(this);">
                                                                                        <i class="fa fa-trash" aria-hidden="true" style="font-size: 22px; margin-top: 5px;color: #337ab7;"></i>
                                                                                    </span>
                                                                                </td>
                                                                            </tr>

                                                                            <tr style="display: none; vertical-align: middle;" id="row5-additional-apps">
                                                                                <td align="center">5</td>
                                                                                <td>
                                                                                    <asp:DropDownList ID="cmdApplication5" onchange="GetApplicationData(this)" CssClass="form-control ApplicationDDL" runat="server" Style="width: 100%; margin-top: 3px;">
                                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Pro - 1 User|No|1|NA">NICA439 - Mirada Viewer Pro </asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer  Premium |No|1|NA">NICA441 - Mirada Viewer  Premium </asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Pro - S.Lic|No|Enterprise|">NICA445 - Mirada Viewer Pro - S.Lic</asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Prem. ISP - S.Lic|No|Enterprise|">NICA447 - Mirada Viewer Prem. ISP - S.Lic</asp:ListItem>
                                                                                        <asp:ListItem Value="NM Processing App Suite|Yes|2|Up to max of Enterprise concurrent users">NICA436 - NM Processing App Suite</asp:ListItem>
                                                                                        <asp:ListItem Value="NM Astonish Recon Suite|No|Enterprise|">NICA438 - NM Astonish Recon Suite</asp:ListItem>
                                                                                        <asp:ListItem Value="NM NeuroQ PET |Yes|1|Up to max of Enterprise concurrent users">NICA356/FIC0085 - NM NeuroQ PET </asp:ListItem>
                                                                                        <asp:ListItem Value="NeuroQ SPECT Opt |Yes|1|Up to max of Enterprise concurrent users">NICA360 - NeuroQ SPECT Opt </asp:ListItem>
                                                                                        <asp:ListItem Value="NM Amyloid Analysis |Yes|1|Up to max of Enterprise concurrent users">NICA965/FIC0127 - NM Amyloid Analysis </asp:ListItem>
                                                                                        <asp:ListItem Value="NM EQual |Yes|1|Up to max of Enterprise concurrent users">NICA358/FIC0466 - NM EQual </asp:ListItem>
                                                                                        <asp:ListItem Value="NeuroQ DaTscan Opt |Yes|1|Up to max of Enterprise concurrent users">NICA367/FIC0466 - NeuroQ DaTscan Opt </asp:ListItem>
                                                                                        <asp:ListItem Value="Emory Cardiac ToolBox V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB352 - Emory Cardiac ToolBox V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB SPECT V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB355/FIC0222 - ECTB SPECT V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB PET V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB358/FIC0223 - ECTB PET V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB Heart Fusion V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB361/FIC0224 - ECTB Heart Fusion V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB SmartReport Option V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB364/FIC0252 - ECTB SmartReport Option V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB CFR MBF V4.x |Yes|1|Up to max of Enterprise concurrent users">NICB550/FIC0459 - ECTB CFR MBF V4.x </asp:ListItem>
                                                                                        <asp:ListItem Value="NM AutoQuant 2015.x  |Yes|1|Up to max of Enterprise concurrent users">FIC0264/FIC0264 - NM AutoQuant 2015.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="SPECT AutoQuant 2015.x  |Yes|1|Up to max of Enterprise concurrent users">FIC0266/FIC0266 - SPECT AutoQuant 2015.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="NM/CTA Cedars Fusion 2015.x |Yes|1|Up to max of Enterprise concurrent users">FIC0268 - NM/CTA Cedars Fusion 2015.x </asp:ListItem>
                                                                                        <asp:ListItem Value="Cedars MFSC 2015.x |Yes|1|Up to max of Enterprise concurrent users">FIC0270 - Cedars MFSC 2015.x </asp:ListItem>
                                                                                        <asp:ListItem Value="NM AutoQUANT 2017  |Yes|1|Up to max of Enterprise concurrent users">FIC0473/FIC0473 - NM AutoQUANT 2017  </asp:ListItem>
                                                                                        <asp:ListItem Value="SPECT AutoQUANT 2017  |Yes|1|Up to max of Enterprise concurrent users">FIC0474/FIC0474 - SPECT AutoQUANT 2017  </asp:ListItem>
                                                                                        <asp:ListItem Value="NM/CTA Cedars Fusion 2017 |Yes|1|Up to max of Enterprise concurrent users">FIC0475/FIC0475 - NM/CTA Cedars Fusion 2017 </asp:ListItem>
                                                                                        <asp:ListItem Value="Cedars MFSC 2017 |Yes|1|Up to max of Enterprise concurrent users">FIC0476/FIC0476 - Cedars MFSC 2017 </asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM SPECT 2016|No|Enterprise|">FIC0304 - Corridor4DM SPECT 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM NM 2016|No|Enterprise|">FIC0303 - Corridor4DM NM 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CT Opt 2016|No|Enterprise|">FIC0305 - Corridor4DM CT Opt 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor 4DM CFR MBF Opt 2016|No|Enterprise|">FIC0306 - Corridor 4DM CFR MBF Opt 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM NM 2018|No|Enterprise|">FIC0461 - Corridor4DM NM 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM SPECT 2018|No|Enterprise|">FIC0462 - Corridor4DM SPECT 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CT Opt 2018|No|Enterprise|">FIC0463 - Corridor4DM CT Opt 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CFR MBF Opt 2018|No|Enterprise|">FIC0464 - Corridor4DM CFR MBF Opt 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Zero FootPrint Viewer SW - 2 User|No|2|55">NICA168/FIC0439 - Zero FootPrint Viewer SW - 2 User</asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Prostate |Yes|1|Sum of FICO4329 and NICA283 and NICA282 and NICA288 should be max 4 and max 10 for hybrid &amp; distributed">NICA283/FIC0429 - DynaCAD Prostate </asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Breast |No|1|">NICA282/FIC0429 - DynaCAD Breast </asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Combo Package |No|1|">NICA288/FIC0429 - DynaCAD Combo Package </asp:ListItem>
                                                                                        <asp:ListItem Value="NM JETPack App License - Add_Users|NULL||NULL">FIC0095 - NM JETPack App License - Add_Users</asp:ListItem>

                                                                                        <asp:ListItem Value="NeuroQ SPECT Opt - Add_Users|NULL||NULL">FIC0253 - NeuroQ SPECT Opt - Add_Users</asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB NM v4.x - Add_Users|NULL||NULL">FIC0221 - ECTB NM v4.x - Add_Users</asp:ListItem>
                                                                                    </asp:DropDownList>

                                                                                </td>
                                                                                <td>
                                                                                    <asp:HiddenField ID="hidtxtConcurrent5" runat="server" />
                                                                                    <input type="number" id="txtConcurrent5" onblur="CheckConcurrentValue(this)" class="form-control" style="margin-top: 3px;" name="txtConcurrent5" min="0" max="100" value="<%=m_txtConcurrent5 %>">
                                                                                    <div id="errortxtConcurrent5" class="errortxtConcurrent" style="color: red; padding-top: 2px; display: none;">Error with input</div>
                                                                                </td>

                                                                                <td align="center">
                                                                                    <i class="fa fa-info-circle" style="margin-top: 10px; font-size: 19px; color: #178bc6;" data-container="body" data-toggle="popover" data-placement="bottom" data-content="Pop up msg" data-original-title="PopD" title="PopT"></i>
                                                                                </td>

                                                                                <td>
                                                                                    <asp:DropDownList ID="cmdHospitalName5" CssClass="form-control" runat="server" Style="width: 100%; margin-top: 3px;">
                                                                                         <asp:ListItem></asp:ListItem>
                                                                                    </asp:DropDownList>
                                                                                </td>
                                                                                <td align="center">
                                                                                    <span id="cmdAddtionalAppDelete5" onclick="deleteAddtionalApp(this);">
                                                                                        <i class="fa fa-trash" aria-hidden="true" style="font-size: 22px; margin-top: 5px;color: #337ab7;"></i>
                                                                                    </span>
                                                                                </td>
                                                                            </tr>


                                                                            <tr style="display: none; vertical-align: middle;" id="row6-additional-apps">
                                                                                <td align="center">6</td>
                                                                                <td>
                                                                                    <asp:DropDownList ID="cmdApplication6" onchange="GetApplicationData(this)" CssClass="form-control ApplicationDDL" runat="server" Style="width: 100%; margin-top: 3px;">
                                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Pro - 1 User|No|1|NA">NICA439 - Mirada Viewer Pro </asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer  Premium |No|1|NA">NICA441 - Mirada Viewer  Premium </asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Pro - S.Lic|No|Enterprise|">NICA445 - Mirada Viewer Pro - S.Lic</asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Prem. ISP - S.Lic|No|Enterprise|">NICA447 - Mirada Viewer Prem. ISP - S.Lic</asp:ListItem>
                                                                                        <asp:ListItem Value="NM Processing App Suite|Yes|2|Up to max of Enterprise concurrent users">NICA436 - NM Processing App Suite</asp:ListItem>
                                                                                        <asp:ListItem Value="NM Astonish Recon Suite|No|Enterprise|">NICA438 - NM Astonish Recon Suite</asp:ListItem>
                                                                                        <asp:ListItem Value="NM NeuroQ PET |Yes|1|Up to max of Enterprise concurrent users">NICA356/FIC0085 - NM NeuroQ PET </asp:ListItem>
                                                                                        <asp:ListItem Value="NeuroQ SPECT Opt |Yes|1|Up to max of Enterprise concurrent users">NICA360 - NeuroQ SPECT Opt </asp:ListItem>
                                                                                        <asp:ListItem Value="NM Amyloid Analysis |Yes|1|Up to max of Enterprise concurrent users">NICA965/FIC0127 - NM Amyloid Analysis </asp:ListItem>
                                                                                        <asp:ListItem Value="NM EQual |Yes|1|Up to max of Enterprise concurrent users">NICA358/FIC0466 - NM EQual </asp:ListItem>
                                                                                        <asp:ListItem Value="NeuroQ DaTscan Opt |Yes|1|Up to max of Enterprise concurrent users">NICA367/FIC0466 - NeuroQ DaTscan Opt </asp:ListItem>
                                                                                        <asp:ListItem Value="Emory Cardiac ToolBox V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB352 - Emory Cardiac ToolBox V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB SPECT V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB355/FIC0222 - ECTB SPECT V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB PET V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB358/FIC0223 - ECTB PET V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB Heart Fusion V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB361/FIC0224 - ECTB Heart Fusion V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB SmartReport Option V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB364/FIC0252 - ECTB SmartReport Option V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB CFR MBF V4.x |Yes|1|Up to max of Enterprise concurrent users">NICB550/FIC0459 - ECTB CFR MBF V4.x </asp:ListItem>
                                                                                        <asp:ListItem Value="NM AutoQuant 2015.x  |Yes|1|Up to max of Enterprise concurrent users">FIC0264/FIC0264 - NM AutoQuant 2015.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="SPECT AutoQuant 2015.x  |Yes|1|Up to max of Enterprise concurrent users">FIC0266/FIC0266 - SPECT AutoQuant 2015.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="NM/CTA Cedars Fusion 2015.x |Yes|1|Up to max of Enterprise concurrent users">FIC0268 - NM/CTA Cedars Fusion 2015.x </asp:ListItem>
                                                                                        <asp:ListItem Value="Cedars MFSC 2015.x |Yes|1|Up to max of Enterprise concurrent users">FIC0270 - Cedars MFSC 2015.x </asp:ListItem>
                                                                                        <asp:ListItem Value="NM AutoQUANT 2017  |Yes|1|Up to max of Enterprise concurrent users">FIC0473/FIC0473 - NM AutoQUANT 2017  </asp:ListItem>
                                                                                        <asp:ListItem Value="SPECT AutoQUANT 2017  |Yes|1|Up to max of Enterprise concurrent users">FIC0474/FIC0474 - SPECT AutoQUANT 2017  </asp:ListItem>
                                                                                        <asp:ListItem Value="NM/CTA Cedars Fusion 2017 |Yes|1|Up to max of Enterprise concurrent users">FIC0475/FIC0475 - NM/CTA Cedars Fusion 2017 </asp:ListItem>
                                                                                        <asp:ListItem Value="Cedars MFSC 2017 |Yes|1|Up to max of Enterprise concurrent users">FIC0476/FIC0476 - Cedars MFSC 2017 </asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM SPECT 2016|No|Enterprise|">FIC0304 - Corridor4DM SPECT 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM NM 2016|No|Enterprise|">FIC0303 - Corridor4DM NM 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CT Opt 2016|No|Enterprise|">FIC0305 - Corridor4DM CT Opt 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor 4DM CFR MBF Opt 2016|No|Enterprise|">FIC0306 - Corridor 4DM CFR MBF Opt 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM NM 2018|No|Enterprise|">FIC0461 - Corridor4DM NM 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM SPECT 2018|No|Enterprise|">FIC0462 - Corridor4DM SPECT 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CT Opt 2018|No|Enterprise|">FIC0463 - Corridor4DM CT Opt 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CFR MBF Opt 2018|No|Enterprise|">FIC0464 - Corridor4DM CFR MBF Opt 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Zero FootPrint Viewer SW - 2 User|No|2|55">NICA168/FIC0439 - Zero FootPrint Viewer SW - 2 User</asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Prostate |Yes|1|Sum of FICO4329 and NICA283 and NICA282 and NICA288 should be max 4 and max 10 for hybrid &amp; distributed">NICA283/FIC0429 - DynaCAD Prostate </asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Breast |No|1|">NICA282/FIC0429 - DynaCAD Breast </asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Combo Package |No|1|">NICA288/FIC0429 - DynaCAD Combo Package </asp:ListItem>
                                                                                        <asp:ListItem Value="NM JETPack App License - Add_Users|NULL||NULL">FIC0095 - NM JETPack App License - Add_Users</asp:ListItem>

                                                                                        <asp:ListItem Value="NeuroQ SPECT Opt - Add_Users|NULL||NULL">FIC0253 - NeuroQ SPECT Opt - Add_Users</asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB NM v4.x - Add_Users|NULL||NULL">FIC0221 - ECTB NM v4.x - Add_Users</asp:ListItem>
                                                                                    </asp:DropDownList>

                                                                                </td>
                                                                                <td>
                                                                                    <asp:HiddenField ID="hidtxtConcurrent6" runat="server" />
                                                                                    <input type="number" id="txtConcurrent6" onblur="CheckConcurrentValue(this)" class="form-control" style="margin-top: 3px;" name="txtConcurrent6" min="0" max="100" value="<%=m_txtConcurrent6 %>">
                                                                                    <div id="errortxtConcurrent6" class="errortxtConcurrent" style="color: red; padding-top: 2px; display: none;">Error with input</div>
                                                                                </td>

                                                                                <td align="center">
                                                                                    <i class="fa fa-info-circle" style="margin-top: 10px; font-size: 19px; color: #178bc6;" data-container="body" data-toggle="popover" data-placement="bottom" data-content="Pop up msg" data-original-title="PopD" title="PopT"></i>
                                                                                </td>

                                                                                <td>
                                                                                    <asp:DropDownList ID="cmdHospitalName6" CssClass="form-control" runat="server" Style="width: 100%; margin-top: 3px;">
                                                                                         <asp:ListItem></asp:ListItem>
                                                                                    </asp:DropDownList>
                                                                                </td>
                                                                                <td align="center">
                                                                                    <span id="cmdAddtionalAppDelete6" onclick="deleteAddtionalApp(this);">
                                                                                        <i class="fa fa-trash" aria-hidden="true" style="font-size: 22px; margin-top: 5px;color: #337ab7;"></i>
                                                                                    </span>
                                                                                </td>
                                                                            </tr>


                                                                            <tr style="display: none; vertical-align: middle;" id="row7-additional-apps">
                                                                                <td align="center">7</td>
                                                                                <td>
                                                                                    <asp:DropDownList ID="cmdApplication7" onchange="GetApplicationData(this)" CssClass="form-control ApplicationDDL" runat="server" Style="width: 100%; margin-top: 3px;">
                                                                                          <asp:ListItem Value=""></asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Pro - 1 User|No|1|NA">NICA439 - Mirada Viewer Pro </asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer  Premium |No|1|NA">NICA441 - Mirada Viewer  Premium </asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Pro - S.Lic|No|Enterprise|">NICA445 - Mirada Viewer Pro - S.Lic</asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Prem. ISP - S.Lic|No|Enterprise|">NICA447 - Mirada Viewer Prem. ISP - S.Lic</asp:ListItem>
                                                                                        <asp:ListItem Value="NM Processing App Suite|Yes|2|Up to max of Enterprise concurrent users">NICA436 - NM Processing App Suite</asp:ListItem>
                                                                                        <asp:ListItem Value="NM Astonish Recon Suite|No|Enterprise|">NICA438 - NM Astonish Recon Suite</asp:ListItem>
                                                                                        <asp:ListItem Value="NM NeuroQ PET |Yes|1|Up to max of Enterprise concurrent users">NICA356/FIC0085 - NM NeuroQ PET </asp:ListItem>
                                                                                        <asp:ListItem Value="NeuroQ SPECT Opt |Yes|1|Up to max of Enterprise concurrent users">NICA360 - NeuroQ SPECT Opt </asp:ListItem>
                                                                                        <asp:ListItem Value="NM Amyloid Analysis |Yes|1|Up to max of Enterprise concurrent users">NICA965/FIC0127 - NM Amyloid Analysis </asp:ListItem>
                                                                                        <asp:ListItem Value="NM EQual |Yes|1|Up to max of Enterprise concurrent users">NICA358/FIC0466 - NM EQual </asp:ListItem>
                                                                                        <asp:ListItem Value="NeuroQ DaTscan Opt |Yes|1|Up to max of Enterprise concurrent users">NICA367/FIC0466 - NeuroQ DaTscan Opt </asp:ListItem>
                                                                                        <asp:ListItem Value="Emory Cardiac ToolBox V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB352 - Emory Cardiac ToolBox V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB SPECT V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB355/FIC0222 - ECTB SPECT V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB PET V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB358/FIC0223 - ECTB PET V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB Heart Fusion V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB361/FIC0224 - ECTB Heart Fusion V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB SmartReport Option V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB364/FIC0252 - ECTB SmartReport Option V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB CFR MBF V4.x |Yes|1|Up to max of Enterprise concurrent users">NICB550/FIC0459 - ECTB CFR MBF V4.x </asp:ListItem>
                                                                                        <asp:ListItem Value="NM AutoQuant 2015.x  |Yes|1|Up to max of Enterprise concurrent users">FIC0264/FIC0264 - NM AutoQuant 2015.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="SPECT AutoQuant 2015.x  |Yes|1|Up to max of Enterprise concurrent users">FIC0266/FIC0266 - SPECT AutoQuant 2015.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="NM/CTA Cedars Fusion 2015.x |Yes|1|Up to max of Enterprise concurrent users">FIC0268 - NM/CTA Cedars Fusion 2015.x </asp:ListItem>
                                                                                        <asp:ListItem Value="Cedars MFSC 2015.x |Yes|1|Up to max of Enterprise concurrent users">FIC0270 - Cedars MFSC 2015.x </asp:ListItem>
                                                                                        <asp:ListItem Value="NM AutoQUANT 2017  |Yes|1|Up to max of Enterprise concurrent users">FIC0473/FIC0473 - NM AutoQUANT 2017  </asp:ListItem>
                                                                                        <asp:ListItem Value="SPECT AutoQUANT 2017  |Yes|1|Up to max of Enterprise concurrent users">FIC0474/FIC0474 - SPECT AutoQUANT 2017  </asp:ListItem>
                                                                                        <asp:ListItem Value="NM/CTA Cedars Fusion 2017 |Yes|1|Up to max of Enterprise concurrent users">FIC0475/FIC0475 - NM/CTA Cedars Fusion 2017 </asp:ListItem>
                                                                                        <asp:ListItem Value="Cedars MFSC 2017 |Yes|1|Up to max of Enterprise concurrent users">FIC0476/FIC0476 - Cedars MFSC 2017 </asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM SPECT 2016|No|Enterprise|">FIC0304 - Corridor4DM SPECT 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM NM 2016|No|Enterprise|">FIC0303 - Corridor4DM NM 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CT Opt 2016|No|Enterprise|">FIC0305 - Corridor4DM CT Opt 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor 4DM CFR MBF Opt 2016|No|Enterprise|">FIC0306 - Corridor 4DM CFR MBF Opt 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM NM 2018|No|Enterprise|">FIC0461 - Corridor4DM NM 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM SPECT 2018|No|Enterprise|">FIC0462 - Corridor4DM SPECT 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CT Opt 2018|No|Enterprise|">FIC0463 - Corridor4DM CT Opt 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CFR MBF Opt 2018|No|Enterprise|">FIC0464 - Corridor4DM CFR MBF Opt 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Zero FootPrint Viewer SW - 2 User|No|2|55">NICA168/FIC0439 - Zero FootPrint Viewer SW - 2 User</asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Prostate |Yes|1|Sum of FICO4329 and NICA283 and NICA282 and NICA288 should be max 4 and max 10 for hybrid &amp; distributed">NICA283/FIC0429 - DynaCAD Prostate </asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Breast |No|1|">NICA282/FIC0429 - DynaCAD Breast </asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Combo Package |No|1|">NICA288/FIC0429 - DynaCAD Combo Package </asp:ListItem>
                                                                                        <asp:ListItem Value="NM JETPack App License - Add_Users|NULL||NULL">FIC0095 - NM JETPack App License - Add_Users</asp:ListItem>

                                                                                        <asp:ListItem Value="NeuroQ SPECT Opt - Add_Users|NULL||NULL">FIC0253 - NeuroQ SPECT Opt - Add_Users</asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB NM v4.x - Add_Users|NULL||NULL">FIC0221 - ECTB NM v4.x - Add_Users</asp:ListItem>
                                                                                    </asp:DropDownList>

                                                                                </td>
                                                                                <td>
                                                                                    <asp:HiddenField ID="hidtxtConcurrent7" runat="server" />
                                                                                    <input type="number" id="txtConcurrent7" onblur="CheckConcurrentValue(this)" class="form-control" style="margin-top: 3px;" name="txtConcurrent7" min="10" max="100" value="<%=m_txtConcurrent7 %>">
                                                                                    <div id="errortxtConcurrent7" class="errortxtConcurrent" style="color: red; padding-top: 2px; display: none;">Error with input</div>
                                                                                </td>

                                                                                <td align="center">
                                                                                    <i class="fa fa-info-circle" style="margin-top: 10px; font-size: 19px; color: #178bc6;" data-container="body" data-toggle="popover" data-placement="bottom" data-content="Pop up msg" data-original-title="PopD" title="PopT"></i>
                                                                                </td>

                                                                                <td>
                                                                                    <asp:DropDownList ID="cmdHospitalName7" CssClass="form-control" runat="server" Style="width: 100%; margin-top: 3px;">
                                                                                         <asp:ListItem></asp:ListItem>
                                                                                    </asp:DropDownList>
                                                                                </td>
                                                                                <td align="center">
                                                                                    <span id="cmdAddtionalAppDelete7" onclick="deleteAddtionalApp(this);">
                                                                                        <i class="fa fa-trash" aria-hidden="true" style="font-size: 22px; margin-top: 5px;color: #337ab7;"></i>
                                                                                    </span>
                                                                                </td>
                                                                            </tr>


                                                                            <tr style="display: none; vertical-align: middle;" id="row8-additional-apps">
                                                                                <td align="center">8</td>
                                                                                <td>
                                                                                    <asp:DropDownList ID="cmdApplication8" onchange="GetApplicationData(this)" CssClass="form-control ApplicationDDL" runat="server" Style="width: 100%; margin-top: 3px;">
                                                                                         <asp:ListItem Value=""></asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Pro - 1 User|No|1|NA">NICA439 - Mirada Viewer Pro </asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer  Premium |No|1|NA">NICA441 - Mirada Viewer  Premium </asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Pro - S.Lic|No|Enterprise|">NICA445 - Mirada Viewer Pro - S.Lic</asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Prem. ISP - S.Lic|No|Enterprise|">NICA447 - Mirada Viewer Prem. ISP - S.Lic</asp:ListItem>
                                                                                        <asp:ListItem Value="NM Processing App Suite|Yes|2|Up to max of Enterprise concurrent users">NICA436 - NM Processing App Suite</asp:ListItem>
                                                                                        <asp:ListItem Value="NM Astonish Recon Suite|No|Enterprise|">NICA438 - NM Astonish Recon Suite</asp:ListItem>
                                                                                        <asp:ListItem Value="NM NeuroQ PET |Yes|1|Up to max of Enterprise concurrent users">NICA356/FIC0085 - NM NeuroQ PET </asp:ListItem>
                                                                                        <asp:ListItem Value="NeuroQ SPECT Opt |Yes|1|Up to max of Enterprise concurrent users">NICA360 - NeuroQ SPECT Opt </asp:ListItem>
                                                                                        <asp:ListItem Value="NM Amyloid Analysis |Yes|1|Up to max of Enterprise concurrent users">NICA965/FIC0127 - NM Amyloid Analysis </asp:ListItem>
                                                                                        <asp:ListItem Value="NM EQual |Yes|1|Up to max of Enterprise concurrent users">NICA358/FIC0466 - NM EQual </asp:ListItem>
                                                                                        <asp:ListItem Value="NeuroQ DaTscan Opt |Yes|1|Up to max of Enterprise concurrent users">NICA367/FIC0466 - NeuroQ DaTscan Opt </asp:ListItem>
                                                                                        <asp:ListItem Value="Emory Cardiac ToolBox V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB352 - Emory Cardiac ToolBox V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB SPECT V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB355/FIC0222 - ECTB SPECT V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB PET V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB358/FIC0223 - ECTB PET V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB Heart Fusion V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB361/FIC0224 - ECTB Heart Fusion V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB SmartReport Option V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB364/FIC0252 - ECTB SmartReport Option V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB CFR MBF V4.x |Yes|1|Up to max of Enterprise concurrent users">NICB550/FIC0459 - ECTB CFR MBF V4.x </asp:ListItem>
                                                                                        <asp:ListItem Value="NM AutoQuant 2015.x  |Yes|1|Up to max of Enterprise concurrent users">FIC0264/FIC0264 - NM AutoQuant 2015.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="SPECT AutoQuant 2015.x  |Yes|1|Up to max of Enterprise concurrent users">FIC0266/FIC0266 - SPECT AutoQuant 2015.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="NM/CTA Cedars Fusion 2015.x |Yes|1|Up to max of Enterprise concurrent users">FIC0268 - NM/CTA Cedars Fusion 2015.x </asp:ListItem>
                                                                                        <asp:ListItem Value="Cedars MFSC 2015.x |Yes|1|Up to max of Enterprise concurrent users">FIC0270 - Cedars MFSC 2015.x </asp:ListItem>
                                                                                        <asp:ListItem Value="NM AutoQUANT 2017  |Yes|1|Up to max of Enterprise concurrent users">FIC0473/FIC0473 - NM AutoQUANT 2017  </asp:ListItem>
                                                                                        <asp:ListItem Value="SPECT AutoQUANT 2017  |Yes|1|Up to max of Enterprise concurrent users">FIC0474/FIC0474 - SPECT AutoQUANT 2017  </asp:ListItem>
                                                                                        <asp:ListItem Value="NM/CTA Cedars Fusion 2017 |Yes|1|Up to max of Enterprise concurrent users">FIC0475/FIC0475 - NM/CTA Cedars Fusion 2017 </asp:ListItem>
                                                                                        <asp:ListItem Value="Cedars MFSC 2017 |Yes|1|Up to max of Enterprise concurrent users">FIC0476/FIC0476 - Cedars MFSC 2017 </asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM SPECT 2016|No|Enterprise|">FIC0304 - Corridor4DM SPECT 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM NM 2016|No|Enterprise|">FIC0303 - Corridor4DM NM 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CT Opt 2016|No|Enterprise|">FIC0305 - Corridor4DM CT Opt 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor 4DM CFR MBF Opt 2016|No|Enterprise|">FIC0306 - Corridor 4DM CFR MBF Opt 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM NM 2018|No|Enterprise|">FIC0461 - Corridor4DM NM 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM SPECT 2018|No|Enterprise|">FIC0462 - Corridor4DM SPECT 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CT Opt 2018|No|Enterprise|">FIC0463 - Corridor4DM CT Opt 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CFR MBF Opt 2018|No|Enterprise|">FIC0464 - Corridor4DM CFR MBF Opt 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Zero FootPrint Viewer SW - 2 User|No|2|55">NICA168/FIC0439 - Zero FootPrint Viewer SW - 2 User</asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Prostate |Yes|1|Sum of FICO4329 and NICA283 and NICA282 and NICA288 should be max 4 and max 10 for hybrid &amp; distributed">NICA283/FIC0429 - DynaCAD Prostate </asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Breast |No|1|">NICA282/FIC0429 - DynaCAD Breast </asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Combo Package |No|1|">NICA288/FIC0429 - DynaCAD Combo Package </asp:ListItem>
                                                                                        <asp:ListItem Value="NM JETPack App License - Add_Users|NULL||NULL">FIC0095 - NM JETPack App License - Add_Users</asp:ListItem>

                                                                                        <asp:ListItem Value="NeuroQ SPECT Opt - Add_Users|NULL||NULL">FIC0253 - NeuroQ SPECT Opt - Add_Users</asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB NM v4.x - Add_Users|NULL||NULL">FIC0221 - ECTB NM v4.x - Add_Users</asp:ListItem>
                                                                                    </asp:DropDownList>

                                                                                </td>
                                                                                <td>
                                                                                    <asp:HiddenField ID="hidtxtConcurrent8" runat="server" />
                                                                                    <input type="number" id="txtConcurrent8" onblur="CheckConcurrentValue(this)" class="form-control" style="margin-top: 3px;" name="txtConcurrent8" min="10" max="100" value="<%=m_txtConcurrent8 %>">
                                                                                    <div id="errortxtConcurrent8" class="errortxtConcurrent" style="color: red; padding-top: 2px; display: none;">Error with input</div>
                                                                                </td>

                                                                                <td align="center">
                                                                                    <i class="fa fa-info-circle" style="margin-top: 10px; font-size: 19px; color: #178bc6;" data-container="body" data-toggle="popover" data-placement="bottom" data-content="Pop up msg" data-original-title="PopD" title="PopT"></i>
                                                                                </td>

                                                                                <td>
                                                                                    <asp:DropDownList ID="cmdHospitalName8" CssClass="form-control" runat="server" Style="width: 100%; margin-top: 3px;">
                                                                                        <asp:ListItem></asp:ListItem>
                                                                                    </asp:DropDownList>
                                                                                </td>
                                                                                <td align="center">
                                                                                    <span id="cmdAddtionalAppDelete8" onclick="deleteAddtionalApp(this);">
                                                                                        <i class="fa fa-trash" aria-hidden="true" style="font-size: 22px; margin-top: 5px;color: #337ab7;"></i>
                                                                                    </span>
                                                                                </td>
                                                                            </tr>

                                                                             <tr style="display: none; vertical-align: middle;" id="row9-additional-apps">
                                                                                <td align="center">9</td>
                                                                                <td>
                                                                                    <asp:DropDownList ID="cmdApplication9" onchange="GetApplicationData(this)" CssClass="form-control ApplicationDDL" runat="server" Style="width: 100%; margin-top: 3px;">
                                                                                         <asp:ListItem Value=""></asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Pro - 1 User|No|1|NA">NICA439 - Mirada Viewer Pro </asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer  Premium |No|1|NA">NICA441 - Mirada Viewer  Premium </asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Pro - S.Lic|No|Enterprise|">NICA445 - Mirada Viewer Pro - S.Lic</asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Prem. ISP - S.Lic|No|Enterprise|">NICA447 - Mirada Viewer Prem. ISP - S.Lic</asp:ListItem>
                                                                                        <asp:ListItem Value="NM Processing App Suite|Yes|2|Up to max of Enterprise concurrent users">NICA436 - NM Processing App Suite</asp:ListItem>
                                                                                        <asp:ListItem Value="NM Astonish Recon Suite|No|Enterprise|">NICA438 - NM Astonish Recon Suite</asp:ListItem>
                                                                                        <asp:ListItem Value="NM NeuroQ PET |Yes|1|Up to max of Enterprise concurrent users">NICA356/FIC0085 - NM NeuroQ PET </asp:ListItem>
                                                                                        <asp:ListItem Value="NeuroQ SPECT Opt |Yes|1|Up to max of Enterprise concurrent users">NICA360 - NeuroQ SPECT Opt </asp:ListItem>
                                                                                        <asp:ListItem Value="NM Amyloid Analysis |Yes|1|Up to max of Enterprise concurrent users">NICA965/FIC0127 - NM Amyloid Analysis </asp:ListItem>
                                                                                        <asp:ListItem Value="NM EQual |Yes|1|Up to max of Enterprise concurrent users">NICA358/FIC0466 - NM EQual </asp:ListItem>
                                                                                        <asp:ListItem Value="NeuroQ DaTscan Opt |Yes|1|Up to max of Enterprise concurrent users">NICA367/FIC0466 - NeuroQ DaTscan Opt </asp:ListItem>
                                                                                        <asp:ListItem Value="Emory Cardiac ToolBox V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB352 - Emory Cardiac ToolBox V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB SPECT V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB355/FIC0222 - ECTB SPECT V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB PET V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB358/FIC0223 - ECTB PET V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB Heart Fusion V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB361/FIC0224 - ECTB Heart Fusion V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB SmartReport Option V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB364/FIC0252 - ECTB SmartReport Option V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB CFR MBF V4.x |Yes|1|Up to max of Enterprise concurrent users">NICB550/FIC0459 - ECTB CFR MBF V4.x </asp:ListItem>
                                                                                        <asp:ListItem Value="NM AutoQuant 2015.x  |Yes|1|Up to max of Enterprise concurrent users">FIC0264/FIC0264 - NM AutoQuant 2015.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="SPECT AutoQuant 2015.x  |Yes|1|Up to max of Enterprise concurrent users">FIC0266/FIC0266 - SPECT AutoQuant 2015.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="NM/CTA Cedars Fusion 2015.x |Yes|1|Up to max of Enterprise concurrent users">FIC0268 - NM/CTA Cedars Fusion 2015.x </asp:ListItem>
                                                                                        <asp:ListItem Value="Cedars MFSC 2015.x |Yes|1|Up to max of Enterprise concurrent users">FIC0270 - Cedars MFSC 2015.x </asp:ListItem>
                                                                                        <asp:ListItem Value="NM AutoQUANT 2017  |Yes|1|Up to max of Enterprise concurrent users">FIC0473/FIC0473 - NM AutoQUANT 2017  </asp:ListItem>
                                                                                        <asp:ListItem Value="SPECT AutoQUANT 2017  |Yes|1|Up to max of Enterprise concurrent users">FIC0474/FIC0474 - SPECT AutoQUANT 2017  </asp:ListItem>
                                                                                        <asp:ListItem Value="NM/CTA Cedars Fusion 2017 |Yes|1|Up to max of Enterprise concurrent users">FIC0475/FIC0475 - NM/CTA Cedars Fusion 2017 </asp:ListItem>
                                                                                        <asp:ListItem Value="Cedars MFSC 2017 |Yes|1|Up to max of Enterprise concurrent users">FIC0476/FIC0476 - Cedars MFSC 2017 </asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM SPECT 2016|No|Enterprise|">FIC0304 - Corridor4DM SPECT 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM NM 2016|No|Enterprise|">FIC0303 - Corridor4DM NM 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CT Opt 2016|No|Enterprise|">FIC0305 - Corridor4DM CT Opt 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor 4DM CFR MBF Opt 2016|No|Enterprise|">FIC0306 - Corridor 4DM CFR MBF Opt 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM NM 2018|No|Enterprise|">FIC0461 - Corridor4DM NM 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM SPECT 2018|No|Enterprise|">FIC0462 - Corridor4DM SPECT 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CT Opt 2018|No|Enterprise|">FIC0463 - Corridor4DM CT Opt 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CFR MBF Opt 2018|No|Enterprise|">FIC0464 - Corridor4DM CFR MBF Opt 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Zero FootPrint Viewer SW - 2 User|No|2|55">NICA168/FIC0439 - Zero FootPrint Viewer SW - 2 User</asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Prostate |Yes|1|Sum of FICO4329 and NICA283 and NICA282 and NICA288 should be max 4 and max 10 for hybrid &amp; distributed">NICA283/FIC0429 - DynaCAD Prostate </asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Breast |No|1|">NICA282/FIC0429 - DynaCAD Breast </asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Combo Package |No|1|">NICA288/FIC0429 - DynaCAD Combo Package </asp:ListItem>
                                                                                        <asp:ListItem Value="NM JETPack App License - Add_Users|NULL||NULL">FIC0095 - NM JETPack App License - Add_Users</asp:ListItem>

                                                                                        <asp:ListItem Value="NeuroQ SPECT Opt - Add_Users|NULL||NULL">FIC0253 - NeuroQ SPECT Opt - Add_Users</asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB NM v4.x - Add_Users|NULL||NULL">FIC0221 - ECTB NM v4.x - Add_Users</asp:ListItem>
                                                                                    </asp:DropDownList>

                                                                                </td>
                                                                                <td>
                                                                                    <asp:HiddenField ID="hidtxtConcurrent9" runat="server" />
                                                                                    <input type="number" id="txtConcurrent9" onblur="CheckConcurrentValue(this)" class="form-control" style="margin-top: 3px;" name="txtConcurrent9" min="10" max="100" value="<%=m_txtConcurrent9 %>">
                                                                                    <div id="errortxtConcurrent9" class="errortxtConcurrent" style="color: red; padding-top: 2px; display: none;">Error with input</div>
                                                                                </td>

                                                                                <td align="center">
                                                                                    <i class="fa fa-info-circle" style="margin-top: 10px; font-size: 19px; color: #178bc6;" data-container="body" data-toggle="popover" data-placement="bottom" data-content="Pop up msg" data-original-title="PopD" title="PopT"></i>
                                                                                </td>

                                                                                <td>
                                                                                    <asp:DropDownList ID="cmdHospitalName9" CssClass="form-control" runat="server" Style="width: 100%; margin-top: 3px;">
                                                                                          <asp:ListItem></asp:ListItem>
                                                                                    </asp:DropDownList>
                                                                                </td>
                                                                                <td align="center">
                                                                                    <span id="cmdAddtionalAppDelete9" onclick="deleteAddtionalApp(this);">
                                                                                        <i class="fa fa-trash" aria-hidden="true" style="font-size: 22px; margin-top: 5px;color: #337ab7;"></i>
                                                                                    </span>
                                                                                </td>
                                                                            </tr>

                                                                             <tr style="display: none; vertical-align: middle;" id="row10-additional-apps">
                                                                                <td align="center">10</td>
                                                                                <td>
                                                                                    <asp:DropDownList ID="cmdApplication10" onchange="GetApplicationData(this)" CssClass="form-control ApplicationDDL" runat="server" Style="width: 100%; margin-top: 3px;">
                                                                                         <asp:ListItem Value=""></asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Pro - 1 User|No|1|NA">NICA439 - Mirada Viewer Pro </asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer  Premium |No|1|NA">NICA441 - Mirada Viewer  Premium </asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Pro - S.Lic|No|Enterprise|">NICA445 - Mirada Viewer Pro - S.Lic</asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Prem. ISP - S.Lic|No|Enterprise|">NICA447 - Mirada Viewer Prem. ISP - S.Lic</asp:ListItem>
                                                                                        <asp:ListItem Value="NM Processing App Suite|Yes|2|Up to max of Enterprise concurrent users">NICA436 - NM Processing App Suite</asp:ListItem>
                                                                                        <asp:ListItem Value="NM Astonish Recon Suite|No|Enterprise|">NICA438 - NM Astonish Recon Suite</asp:ListItem>
                                                                                        <asp:ListItem Value="NM NeuroQ PET |Yes|1|Up to max of Enterprise concurrent users">NICA356/FIC0085 - NM NeuroQ PET </asp:ListItem>
                                                                                        <asp:ListItem Value="NeuroQ SPECT Opt |Yes|1|Up to max of Enterprise concurrent users">NICA360 - NeuroQ SPECT Opt </asp:ListItem>
                                                                                        <asp:ListItem Value="NM Amyloid Analysis |Yes|1|Up to max of Enterprise concurrent users">NICA965/FIC0127 - NM Amyloid Analysis </asp:ListItem>
                                                                                        <asp:ListItem Value="NM EQual |Yes|1|Up to max of Enterprise concurrent users">NICA358/FIC0466 - NM EQual </asp:ListItem>
                                                                                        <asp:ListItem Value="NeuroQ DaTscan Opt |Yes|1|Up to max of Enterprise concurrent users">NICA367/FIC0466 - NeuroQ DaTscan Opt </asp:ListItem>
                                                                                        <asp:ListItem Value="Emory Cardiac ToolBox V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB352 - Emory Cardiac ToolBox V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB SPECT V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB355/FIC0222 - ECTB SPECT V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB PET V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB358/FIC0223 - ECTB PET V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB Heart Fusion V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB361/FIC0224 - ECTB Heart Fusion V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB SmartReport Option V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB364/FIC0252 - ECTB SmartReport Option V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB CFR MBF V4.x |Yes|1|Up to max of Enterprise concurrent users">NICB550/FIC0459 - ECTB CFR MBF V4.x </asp:ListItem>
                                                                                        <asp:ListItem Value="NM AutoQuant 2015.x  |Yes|1|Up to max of Enterprise concurrent users">FIC0264/FIC0264 - NM AutoQuant 2015.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="SPECT AutoQuant 2015.x  |Yes|1|Up to max of Enterprise concurrent users">FIC0266/FIC0266 - SPECT AutoQuant 2015.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="NM/CTA Cedars Fusion 2015.x |Yes|1|Up to max of Enterprise concurrent users">FIC0268 - NM/CTA Cedars Fusion 2015.x </asp:ListItem>
                                                                                        <asp:ListItem Value="Cedars MFSC 2015.x |Yes|1|Up to max of Enterprise concurrent users">FIC0270 - Cedars MFSC 2015.x </asp:ListItem>
                                                                                        <asp:ListItem Value="NM AutoQUANT 2017  |Yes|1|Up to max of Enterprise concurrent users">FIC0473/FIC0473 - NM AutoQUANT 2017  </asp:ListItem>
                                                                                        <asp:ListItem Value="SPECT AutoQUANT 2017  |Yes|1|Up to max of Enterprise concurrent users">FIC0474/FIC0474 - SPECT AutoQUANT 2017  </asp:ListItem>
                                                                                        <asp:ListItem Value="NM/CTA Cedars Fusion 2017 |Yes|1|Up to max of Enterprise concurrent users">FIC0475/FIC0475 - NM/CTA Cedars Fusion 2017 </asp:ListItem>
                                                                                        <asp:ListItem Value="Cedars MFSC 2017 |Yes|1|Up to max of Enterprise concurrent users">FIC0476/FIC0476 - Cedars MFSC 2017 </asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM SPECT 2016|No|Enterprise|">FIC0304 - Corridor4DM SPECT 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM NM 2016|No|Enterprise|">FIC0303 - Corridor4DM NM 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CT Opt 2016|No|Enterprise|">FIC0305 - Corridor4DM CT Opt 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor 4DM CFR MBF Opt 2016|No|Enterprise|">FIC0306 - Corridor 4DM CFR MBF Opt 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM NM 2018|No|Enterprise|">FIC0461 - Corridor4DM NM 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM SPECT 2018|No|Enterprise|">FIC0462 - Corridor4DM SPECT 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CT Opt 2018|No|Enterprise|">FIC0463 - Corridor4DM CT Opt 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CFR MBF Opt 2018|No|Enterprise|">FIC0464 - Corridor4DM CFR MBF Opt 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Zero FootPrint Viewer SW - 2 User|No|2|55">NICA168/FIC0439 - Zero FootPrint Viewer SW - 2 User</asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Prostate |Yes|1|Sum of FICO4329 and NICA283 and NICA282 and NICA288 should be max 4 and max 10 for hybrid &amp; distributed">NICA283/FIC0429 - DynaCAD Prostate </asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Breast |No|1|">NICA282/FIC0429 - DynaCAD Breast </asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Combo Package |No|1|">NICA288/FIC0429 - DynaCAD Combo Package </asp:ListItem>
                                                                                        <asp:ListItem Value="NM JETPack App License - Add_Users|NULL||NULL">FIC0095 - NM JETPack App License - Add_Users</asp:ListItem>

                                                                                        <asp:ListItem Value="NeuroQ SPECT Opt - Add_Users|NULL||NULL">FIC0253 - NeuroQ SPECT Opt - Add_Users</asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB NM v4.x - Add_Users|NULL||NULL">FIC0221 - ECTB NM v4.x - Add_Users</asp:ListItem>
                                                                                    </asp:DropDownList>

                                                                                </td>
                                                                                <td>
                                                                                    <asp:HiddenField ID="hidtxtConcurrent10" runat="server" />
                                                                                    <input type="number" id="txtConcurrent10" onblur="CheckConcurrentValue(this)" class="form-control" style="margin-top: 3px;" name="txtConcurrent10" min="10" max="100">
                                                                                    <div id="errortxtConcurrent10" class="errortxtConcurrent" style="color: red; padding-top: 2px; display: none;">Error with input</div>
                                                                                </td>

                                                                                <td align="center">
                                                                                    <i class="fa fa-info-circle" style="margin-top: 10px; font-size: 19px; color: #178bc6;" data-container="body" data-toggle="popover" data-placement="bottom" data-content="Pop up msg" data-original-title="PopD" title="PopT"></i>
                                                                                </td>

                                                                                <td>
                                                                                    <asp:DropDownList ID="cmdHospitalName10" CssClass="form-control" runat="server" Style="width: 100%; margin-top: 3px;">
                                                                                    </asp:DropDownList>
                                                                                </td>
                                                                                <td align="center">
                                                                                    
                                                                                    <span id="cmdAddtionalAppDelete10" onclick="deleteAddtionalApp(this);">
                                                                                        <i class="fa fa-trash" aria-hidden="true" style="font-size: 22px; margin-top: 5px;color: #337ab7;"></i>
                                                                                    </span>
                                                                                </td>
                                                                            </tr>

                                                                            <tr style="display: none; vertical-align: middle;" id="row11-additional-apps">
                                                                                <td align="center">11</td>
                                                                                <td>
                                                                                    <asp:DropDownList ID="cmdApplication11" onchange="GetApplicationData(this)" CssClass="form-control ApplicationDDL" runat="server" Style="width: 100%; margin-top: 3px;">
                                                                                         <asp:ListItem Value=""></asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Pro - 1 User|No|1|NA">NICA439 - Mirada Viewer Pro </asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer  Premium |No|1|NA">NICA441 - Mirada Viewer  Premium </asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Pro - S.Lic|No|Enterprise|">NICA445 - Mirada Viewer Pro - S.Lic</asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Prem. ISP - S.Lic|No|Enterprise|">NICA447 - Mirada Viewer Prem. ISP - S.Lic</asp:ListItem>
                                                                                        <asp:ListItem Value="NM Processing App Suite|Yes|2|Up to max of Enterprise concurrent users">NICA436 - NM Processing App Suite</asp:ListItem>
                                                                                        <asp:ListItem Value="NM Astonish Recon Suite|No|Enterprise|">NICA438 - NM Astonish Recon Suite</asp:ListItem>
                                                                                        <asp:ListItem Value="NM NeuroQ PET |Yes|1|Up to max of Enterprise concurrent users">NICA356/FIC0085 - NM NeuroQ PET </asp:ListItem>
                                                                                        <asp:ListItem Value="NeuroQ SPECT Opt |Yes|1|Up to max of Enterprise concurrent users">NICA360 - NeuroQ SPECT Opt </asp:ListItem>
                                                                                        <asp:ListItem Value="NM Amyloid Analysis |Yes|1|Up to max of Enterprise concurrent users">NICA965/FIC0127 - NM Amyloid Analysis </asp:ListItem>
                                                                                        <asp:ListItem Value="NM EQual |Yes|1|Up to max of Enterprise concurrent users">NICA358/FIC0466 - NM EQual </asp:ListItem>
                                                                                        <asp:ListItem Value="NeuroQ DaTscan Opt |Yes|1|Up to max of Enterprise concurrent users">NICA367/FIC0466 - NeuroQ DaTscan Opt </asp:ListItem>
                                                                                        <asp:ListItem Value="Emory Cardiac ToolBox V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB352 - Emory Cardiac ToolBox V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB SPECT V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB355/FIC0222 - ECTB SPECT V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB PET V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB358/FIC0223 - ECTB PET V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB Heart Fusion V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB361/FIC0224 - ECTB Heart Fusion V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB SmartReport Option V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB364/FIC0252 - ECTB SmartReport Option V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB CFR MBF V4.x |Yes|1|Up to max of Enterprise concurrent users">NICB550/FIC0459 - ECTB CFR MBF V4.x </asp:ListItem>
                                                                                        <asp:ListItem Value="NM AutoQuant 2015.x  |Yes|1|Up to max of Enterprise concurrent users">FIC0264/FIC0264 - NM AutoQuant 2015.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="SPECT AutoQuant 2015.x  |Yes|1|Up to max of Enterprise concurrent users">FIC0266/FIC0266 - SPECT AutoQuant 2015.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="NM/CTA Cedars Fusion 2015.x |Yes|1|Up to max of Enterprise concurrent users">FIC0268 - NM/CTA Cedars Fusion 2015.x </asp:ListItem>
                                                                                        <asp:ListItem Value="Cedars MFSC 2015.x |Yes|1|Up to max of Enterprise concurrent users">FIC0270 - Cedars MFSC 2015.x </asp:ListItem>
                                                                                        <asp:ListItem Value="NM AutoQUANT 2017  |Yes|1|Up to max of Enterprise concurrent users">FIC0473/FIC0473 - NM AutoQUANT 2017  </asp:ListItem>
                                                                                        <asp:ListItem Value="SPECT AutoQUANT 2017  |Yes|1|Up to max of Enterprise concurrent users">FIC0474/FIC0474 - SPECT AutoQUANT 2017  </asp:ListItem>
                                                                                        <asp:ListItem Value="NM/CTA Cedars Fusion 2017 |Yes|1|Up to max of Enterprise concurrent users">FIC0475/FIC0475 - NM/CTA Cedars Fusion 2017 </asp:ListItem>
                                                                                        <asp:ListItem Value="Cedars MFSC 2017 |Yes|1|Up to max of Enterprise concurrent users">FIC0476/FIC0476 - Cedars MFSC 2017 </asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM SPECT 2016|No|Enterprise|">FIC0304 - Corridor4DM SPECT 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM NM 2016|No|Enterprise|">FIC0303 - Corridor4DM NM 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CT Opt 2016|No|Enterprise|">FIC0305 - Corridor4DM CT Opt 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor 4DM CFR MBF Opt 2016|No|Enterprise|">FIC0306 - Corridor 4DM CFR MBF Opt 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM NM 2018|No|Enterprise|">FIC0461 - Corridor4DM NM 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM SPECT 2018|No|Enterprise|">FIC0462 - Corridor4DM SPECT 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CT Opt 2018|No|Enterprise|">FIC0463 - Corridor4DM CT Opt 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CFR MBF Opt 2018|No|Enterprise|">FIC0464 - Corridor4DM CFR MBF Opt 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Zero FootPrint Viewer SW - 2 User|No|2|55">NICA168/FIC0439 - Zero FootPrint Viewer SW - 2 User</asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Prostate |Yes|1|Sum of FICO4329 and NICA283 and NICA282 and NICA288 should be max 4 and max 10 for hybrid &amp; distributed">NICA283/FIC0429 - DynaCAD Prostate </asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Breast |No|1|">NICA282/FIC0429 - DynaCAD Breast </asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Combo Package |No|1|">NICA288/FIC0429 - DynaCAD Combo Package </asp:ListItem>
                                                                                        <asp:ListItem Value="NM JETPack App License - Add_Users|NULL||NULL">FIC0095 - NM JETPack App License - Add_Users</asp:ListItem>

                                                                                        <asp:ListItem Value="NeuroQ SPECT Opt - Add_Users|NULL||NULL">FIC0253 - NeuroQ SPECT Opt - Add_Users</asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB NM v4.x - Add_Users|NULL||NULL">FIC0221 - ECTB NM v4.x - Add_Users</asp:ListItem>
                                                                                    </asp:DropDownList>

                                                                                </td>
                                                                                <td>
                                                                                    <asp:HiddenField ID="hidtxtConcurrent11" runat="server" />
                                                                                    <input type="number" id="txtConcurrent11" onblur="CheckConcurrentValue(this)" class="form-control" style="margin-top: 3px;" name="txtConcurrent11" min="10" max="100">
                                                                                    <div id="errortxtConcurrent11" class="errortxtConcurrent" style="color: red; padding-top: 2px; display: none;">Error with input</div>
                                                                                </td>

                                                                                <td align="center">
                                                                                    <i class="fa fa-info-circle" style="margin-top: 10px; font-size: 19px; color: #178bc6;" data-container="body" data-toggle="popover" data-placement="bottom" data-content="Pop up msg" data-original-title="PopD" title="PopT"></i>
                                                                                </td>

                                                                                <td>
                                                                                    <asp:DropDownList ID="cmdHospitalName11" CssClass="form-control" runat="server" Style="width: 100%; margin-top: 3px;">
                                                                                    </asp:DropDownList>
                                                                                </td>
                                                                                <td align="center">
                                                                                    <span id="cmdAddtionalAppDelete11" onclick="deleteAddtionalApp(this);">
                                                                                        <i class="fa fa-trash" aria-hidden="true" style="font-size: 22px; margin-top: 5px;color: #337ab7;"></i>
                                                                                    </span>
                                                                                </td>
                                                                            </tr>

                                                                            <tr style="display: none; vertical-align: middle;" id="row12-additional-apps">
                                                                                <td align="center">12</td>
                                                                                <td>
                                                                                    <asp:DropDownList ID="cmdApplication12" onchange="GetApplicationData(this)" CssClass="form-control ApplicationDDL" runat="server" Style="width: 100%; margin-top: 3px;">
                                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Pro - 1 User|No|1|NA">NICA439 - Mirada Viewer Pro </asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer  Premium |No|1|NA">NICA441 - Mirada Viewer  Premium </asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Pro - S.Lic|No|Enterprise|">NICA445 - Mirada Viewer Pro - S.Lic</asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Prem. ISP - S.Lic|No|Enterprise|">NICA447 - Mirada Viewer Prem. ISP - S.Lic</asp:ListItem>
                                                                                        <asp:ListItem Value="NM Processing App Suite|Yes|2|Up to max of Enterprise concurrent users">NICA436 - NM Processing App Suite</asp:ListItem>
                                                                                        <asp:ListItem Value="NM Astonish Recon Suite|No|Enterprise|">NICA438 - NM Astonish Recon Suite</asp:ListItem>
                                                                                        <asp:ListItem Value="NM NeuroQ PET |Yes|1|Up to max of Enterprise concurrent users">NICA356/FIC0085 - NM NeuroQ PET </asp:ListItem>
                                                                                        <asp:ListItem Value="NeuroQ SPECT Opt |Yes|1|Up to max of Enterprise concurrent users">NICA360 - NeuroQ SPECT Opt </asp:ListItem>
                                                                                        <asp:ListItem Value="NM Amyloid Analysis |Yes|1|Up to max of Enterprise concurrent users">NICA965/FIC0127 - NM Amyloid Analysis </asp:ListItem>
                                                                                        <asp:ListItem Value="NM EQual |Yes|1|Up to max of Enterprise concurrent users">NICA358/FIC0466 - NM EQual </asp:ListItem>
                                                                                        <asp:ListItem Value="NeuroQ DaTscan Opt |Yes|1|Up to max of Enterprise concurrent users">NICA367/FIC0466 - NeuroQ DaTscan Opt </asp:ListItem>
                                                                                        <asp:ListItem Value="Emory Cardiac ToolBox V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB352 - Emory Cardiac ToolBox V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB SPECT V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB355/FIC0222 - ECTB SPECT V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB PET V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB358/FIC0223 - ECTB PET V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB Heart Fusion V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB361/FIC0224 - ECTB Heart Fusion V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB SmartReport Option V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB364/FIC0252 - ECTB SmartReport Option V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB CFR MBF V4.x |Yes|1|Up to max of Enterprise concurrent users">NICB550/FIC0459 - ECTB CFR MBF V4.x </asp:ListItem>
                                                                                        <asp:ListItem Value="NM AutoQuant 2015.x  |Yes|1|Up to max of Enterprise concurrent users">FIC0264/FIC0264 - NM AutoQuant 2015.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="SPECT AutoQuant 2015.x  |Yes|1|Up to max of Enterprise concurrent users">FIC0266/FIC0266 - SPECT AutoQuant 2015.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="NM/CTA Cedars Fusion 2015.x |Yes|1|Up to max of Enterprise concurrent users">FIC0268 - NM/CTA Cedars Fusion 2015.x </asp:ListItem>
                                                                                        <asp:ListItem Value="Cedars MFSC 2015.x |Yes|1|Up to max of Enterprise concurrent users">FIC0270 - Cedars MFSC 2015.x </asp:ListItem>
                                                                                        <asp:ListItem Value="NM AutoQUANT 2017  |Yes|1|Up to max of Enterprise concurrent users">FIC0473/FIC0473 - NM AutoQUANT 2017  </asp:ListItem>
                                                                                        <asp:ListItem Value="SPECT AutoQUANT 2017  |Yes|1|Up to max of Enterprise concurrent users">FIC0474/FIC0474 - SPECT AutoQUANT 2017  </asp:ListItem>
                                                                                        <asp:ListItem Value="NM/CTA Cedars Fusion 2017 |Yes|1|Up to max of Enterprise concurrent users">FIC0475/FIC0475 - NM/CTA Cedars Fusion 2017 </asp:ListItem>
                                                                                        <asp:ListItem Value="Cedars MFSC 2017 |Yes|1|Up to max of Enterprise concurrent users">FIC0476/FIC0476 - Cedars MFSC 2017 </asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM SPECT 2016|No|Enterprise|">FIC0304 - Corridor4DM SPECT 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM NM 2016|No|Enterprise|">FIC0303 - Corridor4DM NM 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CT Opt 2016|No|Enterprise|">FIC0305 - Corridor4DM CT Opt 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor 4DM CFR MBF Opt 2016|No|Enterprise|">FIC0306 - Corridor 4DM CFR MBF Opt 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM NM 2018|No|Enterprise|">FIC0461 - Corridor4DM NM 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM SPECT 2018|No|Enterprise|">FIC0462 - Corridor4DM SPECT 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CT Opt 2018|No|Enterprise|">FIC0463 - Corridor4DM CT Opt 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CFR MBF Opt 2018|No|Enterprise|">FIC0464 - Corridor4DM CFR MBF Opt 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Zero FootPrint Viewer SW - 2 User|No|2|55">NICA168/FIC0439 - Zero FootPrint Viewer SW - 2 User</asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Prostate |Yes|1|Sum of FICO4329 and NICA283 and NICA282 and NICA288 should be max 4 and max 10 for hybrid &amp; distributed">NICA283/FIC0429 - DynaCAD Prostate </asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Breast |No|1|">NICA282/FIC0429 - DynaCAD Breast </asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Combo Package |No|1|">NICA288/FIC0429 - DynaCAD Combo Package </asp:ListItem>
                                                                                        <asp:ListItem Value="NM JETPack App License - Add_Users|NULL||NULL">FIC0095 - NM JETPack App License - Add_Users</asp:ListItem>

                                                                                        <asp:ListItem Value="NeuroQ SPECT Opt - Add_Users|NULL||NULL">FIC0253 - NeuroQ SPECT Opt - Add_Users</asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB NM v4.x - Add_Users|NULL||NULL">FIC0221 - ECTB NM v4.x - Add_Users</asp:ListItem>
                                                                                    </asp:DropDownList>

                                                                                </td>
                                                                                <td>
                                                                                    <asp:HiddenField ID="hidtxtConcurrent12" runat="server" />
                                                                                    <input type="number" id="txtConcurrent12" onblur="CheckConcurrentValue(this)" class="form-control" style="margin-top: 3px;" name="txtConcurrent12" min="10" max="100">
                                                                                    <div id="errortxtConcurrent12" class="errortxtConcurrent" style="color: red; padding-top: 2px; display: none;">Error with input</div>
                                                                                </td>

                                                                                <td align="center">
                                                                                    <i class="fa fa-info-circle" style="margin-top: 10px; font-size: 19px; color: #178bc6;" data-container="body" data-toggle="popover" data-placement="bottom" data-content="Pop up msg" data-original-title="PopD" title="PopT"></i>
                                                                                </td>

                                                                                <td>
                                                                                    <asp:DropDownList ID="cmdHospitalName12" CssClass="form-control" runat="server" Style="width: 100%; margin-top: 3px;">
                                                                                         <asp:ListItem></asp:ListItem>
                                                                                    </asp:DropDownList>
                                                                                </td>
                                                                                <td align="center">
                                                                                    <span id="cmdAddtionalAppDelete12" onclick="deleteAddtionalApp(this);">
                                                                                        <i class="fa fa-trash" aria-hidden="true" style="font-size: 22px; margin-top: 5px;color: #337ab7;"></i>
                                                                                    </span>
                                                                                </td>
                                                                            </tr>

                                                                            <tr style="display: none; vertical-align: middle;" id="row13-additional-apps">
                                                                                <td align="center">13</td>
                                                                                <td>
                                                                                    <asp:DropDownList ID="cmdApplication13" onchange="GetApplicationData(this)" CssClass="form-control ApplicationDDL" runat="server" Style="width: 100%; margin-top: 3px;">
                                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Pro - 1 User|No|1|NA">NICA439 - Mirada Viewer Pro </asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer  Premium |No|1|NA">NICA441 - Mirada Viewer  Premium </asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Pro - S.Lic|No|Enterprise|">NICA445 - Mirada Viewer Pro - S.Lic</asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Prem. ISP - S.Lic|No|Enterprise|">NICA447 - Mirada Viewer Prem. ISP - S.Lic</asp:ListItem>
                                                                                        <asp:ListItem Value="NM Processing App Suite|Yes|2|Up to max of Enterprise concurrent users">NICA436 - NM Processing App Suite</asp:ListItem>
                                                                                        <asp:ListItem Value="NM Astonish Recon Suite|No|Enterprise|">NICA438 - NM Astonish Recon Suite</asp:ListItem>
                                                                                        <asp:ListItem Value="NM NeuroQ PET |Yes|1|Up to max of Enterprise concurrent users">NICA356/FIC0085 - NM NeuroQ PET </asp:ListItem>
                                                                                        <asp:ListItem Value="NeuroQ SPECT Opt |Yes|1|Up to max of Enterprise concurrent users">NICA360 - NeuroQ SPECT Opt </asp:ListItem>
                                                                                        <asp:ListItem Value="NM Amyloid Analysis |Yes|1|Up to max of Enterprise concurrent users">NICA965/FIC0127 - NM Amyloid Analysis </asp:ListItem>
                                                                                        <asp:ListItem Value="NM EQual |Yes|1|Up to max of Enterprise concurrent users">NICA358/FIC0466 - NM EQual </asp:ListItem>
                                                                                        <asp:ListItem Value="NeuroQ DaTscan Opt |Yes|1|Up to max of Enterprise concurrent users">NICA367/FIC0466 - NeuroQ DaTscan Opt </asp:ListItem>
                                                                                        <asp:ListItem Value="Emory Cardiac ToolBox V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB352 - Emory Cardiac ToolBox V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB SPECT V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB355/FIC0222 - ECTB SPECT V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB PET V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB358/FIC0223 - ECTB PET V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB Heart Fusion V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB361/FIC0224 - ECTB Heart Fusion V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB SmartReport Option V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB364/FIC0252 - ECTB SmartReport Option V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB CFR MBF V4.x |Yes|1|Up to max of Enterprise concurrent users">NICB550/FIC0459 - ECTB CFR MBF V4.x </asp:ListItem>
                                                                                        <asp:ListItem Value="NM AutoQuant 2015.x  |Yes|1|Up to max of Enterprise concurrent users">FIC0264/FIC0264 - NM AutoQuant 2015.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="SPECT AutoQuant 2015.x  |Yes|1|Up to max of Enterprise concurrent users">FIC0266/FIC0266 - SPECT AutoQuant 2015.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="NM/CTA Cedars Fusion 2015.x |Yes|1|Up to max of Enterprise concurrent users">FIC0268 - NM/CTA Cedars Fusion 2015.x </asp:ListItem>
                                                                                        <asp:ListItem Value="Cedars MFSC 2015.x |Yes|1|Up to max of Enterprise concurrent users">FIC0270 - Cedars MFSC 2015.x </asp:ListItem>
                                                                                        <asp:ListItem Value="NM AutoQUANT 2017  |Yes|1|Up to max of Enterprise concurrent users">FIC0473/FIC0473 - NM AutoQUANT 2017  </asp:ListItem>
                                                                                        <asp:ListItem Value="SPECT AutoQUANT 2017  |Yes|1|Up to max of Enterprise concurrent users">FIC0474/FIC0474 - SPECT AutoQUANT 2017  </asp:ListItem>
                                                                                        <asp:ListItem Value="NM/CTA Cedars Fusion 2017 |Yes|1|Up to max of Enterprise concurrent users">FIC0475/FIC0475 - NM/CTA Cedars Fusion 2017 </asp:ListItem>
                                                                                        <asp:ListItem Value="Cedars MFSC 2017 |Yes|1|Up to max of Enterprise concurrent users">FIC0476/FIC0476 - Cedars MFSC 2017 </asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM SPECT 2016|No|Enterprise|">FIC0304 - Corridor4DM SPECT 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM NM 2016|No|Enterprise|">FIC0303 - Corridor4DM NM 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CT Opt 2016|No|Enterprise|">FIC0305 - Corridor4DM CT Opt 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor 4DM CFR MBF Opt 2016|No|Enterprise|">FIC0306 - Corridor 4DM CFR MBF Opt 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM NM 2018|No|Enterprise|">FIC0461 - Corridor4DM NM 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM SPECT 2018|No|Enterprise|">FIC0462 - Corridor4DM SPECT 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CT Opt 2018|No|Enterprise|">FIC0463 - Corridor4DM CT Opt 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CFR MBF Opt 2018|No|Enterprise|">FIC0464 - Corridor4DM CFR MBF Opt 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Zero FootPrint Viewer SW - 2 User|No|2|55">NICA168/FIC0439 - Zero FootPrint Viewer SW - 2 User</asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Prostate |Yes|1|Sum of FICO4329 and NICA283 and NICA282 and NICA288 should be max 4 and max 10 for hybrid &amp; distributed">NICA283/FIC0429 - DynaCAD Prostate </asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Breast |No|1|">NICA282/FIC0429 - DynaCAD Breast </asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Combo Package |No|1|">NICA288/FIC0429 - DynaCAD Combo Package </asp:ListItem>
                                                                                        <asp:ListItem Value="NM JETPack App License - Add_Users|NULL||NULL">FIC0095 - NM JETPack App License - Add_Users</asp:ListItem>

                                                                                        <asp:ListItem Value="NeuroQ SPECT Opt - Add_Users|NULL||NULL">FIC0253 - NeuroQ SPECT Opt - Add_Users</asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB NM v4.x - Add_Users|NULL||NULL">FIC0221 - ECTB NM v4.x - Add_Users</asp:ListItem>
                                                                                    </asp:DropDownList>

                                                                                </td>
                                                                                <td>
                                                                                    <asp:HiddenField ID="hidtxtConcurrent13" runat="server" />
                                                                                    <input type="number" id="txtConcurrent13" onblur="CheckConcurrentValue(this)" class="form-control" style="margin-top: 3px;" name="txtConcurrent13" min="10" max="100">
                                                                                    <div id="errortxtConcurrent13"  class="errortxtConcurrent" style="color: red; padding-top: 2px; display: none;">Error with input</div>
                                                                                </td>

                                                                                <td align="center">
                                                                                    <i class="fa fa-info-circle" style="margin-top: 10px; font-size: 19px; color: #178bc6;" data-container="body" data-toggle="popover" data-placement="bottom" data-content="Pop up msg" data-original-title="PopD" title="PopT"></i>
                                                                                </td>

                                                                                <td>
                                                                                    <asp:DropDownList ID="cmdHospitalName13" CssClass="form-control" runat="server" Style="width: 100%; margin-top: 3px;">
                                                                                    </asp:DropDownList>
                                                                                </td>
                                                                                <td align="center">
                                                                                    <span id="cmdAddtionalAppDelete13" onclick="deleteAddtionalApp(this);">
                                                                                        <i class="fa fa-trash" aria-hidden="true" style="font-size: 22px; margin-top: 5px;color: #337ab7;"></i>
                                                                                    </span>
                                                                                </td>
                                                                            </tr>

                                                                            <tr style="display: none; vertical-align: middle;" id="row14-additional-apps">
                                                                                <td align="center">14</td>
                                                                                <td>
                                                                                    <asp:DropDownList ID="cmdApplication14" onchange="GetApplicationData(this)" CssClass="form-control ApplicationDDL" runat="server" Style="width: 100%; margin-top: 3px;">
                                                                                         <asp:ListItem Value=""></asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Pro - 1 User|No|1|NA">NICA439 - Mirada Viewer Pro </asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer  Premium |No|1|NA">NICA441 - Mirada Viewer  Premium </asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Pro - S.Lic|No|Enterprise|">NICA445 - Mirada Viewer Pro - S.Lic</asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Prem. ISP - S.Lic|No|Enterprise|">NICA447 - Mirada Viewer Prem. ISP - S.Lic</asp:ListItem>
                                                                                        <asp:ListItem Value="NM Processing App Suite|Yes|2|Up to max of Enterprise concurrent users">NICA436 - NM Processing App Suite</asp:ListItem>
                                                                                        <asp:ListItem Value="NM Astonish Recon Suite|No|Enterprise|">NICA438 - NM Astonish Recon Suite</asp:ListItem>
                                                                                        <asp:ListItem Value="NM NeuroQ PET |Yes|1|Up to max of Enterprise concurrent users">NICA356/FIC0085 - NM NeuroQ PET </asp:ListItem>
                                                                                        <asp:ListItem Value="NeuroQ SPECT Opt |Yes|1|Up to max of Enterprise concurrent users">NICA360 - NeuroQ SPECT Opt </asp:ListItem>
                                                                                        <asp:ListItem Value="NM Amyloid Analysis |Yes|1|Up to max of Enterprise concurrent users">NICA965/FIC0127 - NM Amyloid Analysis </asp:ListItem>
                                                                                        <asp:ListItem Value="NM EQual |Yes|1|Up to max of Enterprise concurrent users">NICA358/FIC0466 - NM EQual </asp:ListItem>
                                                                                        <asp:ListItem Value="NeuroQ DaTscan Opt |Yes|1|Up to max of Enterprise concurrent users">NICA367/FIC0466 - NeuroQ DaTscan Opt </asp:ListItem>
                                                                                        <asp:ListItem Value="Emory Cardiac ToolBox V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB352 - Emory Cardiac ToolBox V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB SPECT V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB355/FIC0222 - ECTB SPECT V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB PET V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB358/FIC0223 - ECTB PET V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB Heart Fusion V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB361/FIC0224 - ECTB Heart Fusion V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB SmartReport Option V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB364/FIC0252 - ECTB SmartReport Option V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB CFR MBF V4.x |Yes|1|Up to max of Enterprise concurrent users">NICB550/FIC0459 - ECTB CFR MBF V4.x </asp:ListItem>
                                                                                        <asp:ListItem Value="NM AutoQuant 2015.x  |Yes|1|Up to max of Enterprise concurrent users">FIC0264/FIC0264 - NM AutoQuant 2015.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="SPECT AutoQuant 2015.x  |Yes|1|Up to max of Enterprise concurrent users">FIC0266/FIC0266 - SPECT AutoQuant 2015.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="NM/CTA Cedars Fusion 2015.x |Yes|1|Up to max of Enterprise concurrent users">FIC0268 - NM/CTA Cedars Fusion 2015.x </asp:ListItem>
                                                                                        <asp:ListItem Value="Cedars MFSC 2015.x |Yes|1|Up to max of Enterprise concurrent users">FIC0270 - Cedars MFSC 2015.x </asp:ListItem>
                                                                                        <asp:ListItem Value="NM AutoQUANT 2017  |Yes|1|Up to max of Enterprise concurrent users">FIC0473/FIC0473 - NM AutoQUANT 2017  </asp:ListItem>
                                                                                        <asp:ListItem Value="SPECT AutoQUANT 2017  |Yes|1|Up to max of Enterprise concurrent users">FIC0474/FIC0474 - SPECT AutoQUANT 2017  </asp:ListItem>
                                                                                        <asp:ListItem Value="NM/CTA Cedars Fusion 2017 |Yes|1|Up to max of Enterprise concurrent users">FIC0475/FIC0475 - NM/CTA Cedars Fusion 2017 </asp:ListItem>
                                                                                        <asp:ListItem Value="Cedars MFSC 2017 |Yes|1|Up to max of Enterprise concurrent users">FIC0476/FIC0476 - Cedars MFSC 2017 </asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM SPECT 2016|No|Enterprise|">FIC0304 - Corridor4DM SPECT 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM NM 2016|No|Enterprise|">FIC0303 - Corridor4DM NM 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CT Opt 2016|No|Enterprise|">FIC0305 - Corridor4DM CT Opt 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor 4DM CFR MBF Opt 2016|No|Enterprise|">FIC0306 - Corridor 4DM CFR MBF Opt 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM NM 2018|No|Enterprise|">FIC0461 - Corridor4DM NM 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM SPECT 2018|No|Enterprise|">FIC0462 - Corridor4DM SPECT 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CT Opt 2018|No|Enterprise|">FIC0463 - Corridor4DM CT Opt 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CFR MBF Opt 2018|No|Enterprise|">FIC0464 - Corridor4DM CFR MBF Opt 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Zero FootPrint Viewer SW - 2 User|No|2|55">NICA168/FIC0439 - Zero FootPrint Viewer SW - 2 User</asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Prostate |Yes|1|Sum of FICO4329 and NICA283 and NICA282 and NICA288 should be max 4 and max 10 for hybrid &amp; distributed">NICA283/FIC0429 - DynaCAD Prostate </asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Breast |No|1|">NICA282/FIC0429 - DynaCAD Breast </asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Combo Package |No|1|">NICA288/FIC0429 - DynaCAD Combo Package </asp:ListItem>
                                                                                        <asp:ListItem Value="NM JETPack App License - Add_Users|NULL||NULL">FIC0095 - NM JETPack App License - Add_Users</asp:ListItem>

                                                                                        <asp:ListItem Value="NeuroQ SPECT Opt - Add_Users|NULL||NULL">FIC0253 - NeuroQ SPECT Opt - Add_Users</asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB NM v4.x - Add_Users|NULL||NULL">FIC0221 - ECTB NM v4.x - Add_Users</asp:ListItem>
                                                                                    </asp:DropDownList>

                                                                                </td>
                                                                                <td>
                                                                                    <asp:HiddenField ID="hidtxtConcurrent14" runat="server" />
                                                                                    <input type="number" id="txtConcurrent14" onblur="CheckConcurrentValue(this)" class="form-control" style="margin-top: 3px;" name="txtConcurrent14" min="10" max="100">
                                                                                    <div id="errortxtConcurrent14" class="errortxtConcurrent"  style="color: red; padding-top: 2px; display: none;">Error with input</div>
                                                                                </td>

                                                                                <td align="center">
                                                                                    <i class="fa fa-info-circle" style="margin-top: 10px; font-size: 19px; color: #178bc6;" data-container="body" data-toggle="popover" data-placement="bottom" data-content="Pop up msg" data-original-title="PopD" title="PopT"></i>
                                                                                </td>

                                                                                <td>
                                                                                    <asp:DropDownList ID="cmdHospitalName14" CssClass="form-control" runat="server" Style="width: 100%; margin-top: 3px;">
                                                                                    </asp:DropDownList>
                                                                                </td>
                                                                                <td align="center">
                                                                                    <span id="cmdAddtionalAppDelete14" onclick="deleteAddtionalApp(this);">
                                                                                        <i class="fa fa-trash" aria-hidden="true" style="font-size: 22px; margin-top: 5px;color: #337ab7;"></i>
                                                                                    </span>
                                                                                </td>
                                                                            </tr>

                                                                            <tr style="display: none; vertical-align: middle;" id="row15-additional-apps">
                                                                                <td align="center">15</td>
                                                                                <td>
                                                                                    <asp:DropDownList ID="cmdApplication15" onchange="GetApplicationData(this)" CssClass="form-control ApplicationDDL" runat="server" Style="width: 100%; margin-top: 3px;">
                                                                                         <asp:ListItem Value=""></asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Pro - 1 User|No|1|NA">NICA439 - Mirada Viewer Pro </asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer  Premium |No|1|NA">NICA441 - Mirada Viewer  Premium </asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Pro - S.Lic|No|Enterprise|">NICA445 - Mirada Viewer Pro - S.Lic</asp:ListItem>
                                                                                        <asp:ListItem Value="Mirada Viewer Prem. ISP - S.Lic|No|Enterprise|">NICA447 - Mirada Viewer Prem. ISP - S.Lic</asp:ListItem>
                                                                                        <asp:ListItem Value="NM Processing App Suite|Yes|2|Up to max of Enterprise concurrent users">NICA436 - NM Processing App Suite</asp:ListItem>
                                                                                        <asp:ListItem Value="NM Astonish Recon Suite|No|Enterprise|">NICA438 - NM Astonish Recon Suite</asp:ListItem>
                                                                                        <asp:ListItem Value="NM NeuroQ PET |Yes|1|Up to max of Enterprise concurrent users">NICA356/FIC0085 - NM NeuroQ PET </asp:ListItem>
                                                                                        <asp:ListItem Value="NeuroQ SPECT Opt |Yes|1|Up to max of Enterprise concurrent users">NICA360 - NeuroQ SPECT Opt </asp:ListItem>
                                                                                        <asp:ListItem Value="NM Amyloid Analysis |Yes|1|Up to max of Enterprise concurrent users">NICA965/FIC0127 - NM Amyloid Analysis </asp:ListItem>
                                                                                        <asp:ListItem Value="NM EQual |Yes|1|Up to max of Enterprise concurrent users">NICA358/FIC0466 - NM EQual </asp:ListItem>
                                                                                        <asp:ListItem Value="NeuroQ DaTscan Opt |Yes|1|Up to max of Enterprise concurrent users">NICA367/FIC0466 - NeuroQ DaTscan Opt </asp:ListItem>
                                                                                        <asp:ListItem Value="Emory Cardiac ToolBox V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB352 - Emory Cardiac ToolBox V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB SPECT V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB355/FIC0222 - ECTB SPECT V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB PET V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB358/FIC0223 - ECTB PET V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB Heart Fusion V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB361/FIC0224 - ECTB Heart Fusion V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB SmartReport Option V4.x  |Yes|1|Up to max of Enterprise concurrent users">NICB364/FIC0252 - ECTB SmartReport Option V4.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB CFR MBF V4.x |Yes|1|Up to max of Enterprise concurrent users">NICB550/FIC0459 - ECTB CFR MBF V4.x </asp:ListItem>
                                                                                        <asp:ListItem Value="NM AutoQuant 2015.x  |Yes|1|Up to max of Enterprise concurrent users">FIC0264/FIC0264 - NM AutoQuant 2015.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="SPECT AutoQuant 2015.x  |Yes|1|Up to max of Enterprise concurrent users">FIC0266/FIC0266 - SPECT AutoQuant 2015.x  </asp:ListItem>
                                                                                        <asp:ListItem Value="NM/CTA Cedars Fusion 2015.x |Yes|1|Up to max of Enterprise concurrent users">FIC0268 - NM/CTA Cedars Fusion 2015.x </asp:ListItem>
                                                                                        <asp:ListItem Value="Cedars MFSC 2015.x |Yes|1|Up to max of Enterprise concurrent users">FIC0270 - Cedars MFSC 2015.x </asp:ListItem>
                                                                                        <asp:ListItem Value="NM AutoQUANT 2017  |Yes|1|Up to max of Enterprise concurrent users">FIC0473/FIC0473 - NM AutoQUANT 2017  </asp:ListItem>
                                                                                        <asp:ListItem Value="SPECT AutoQUANT 2017  |Yes|1|Up to max of Enterprise concurrent users">FIC0474/FIC0474 - SPECT AutoQUANT 2017  </asp:ListItem>
                                                                                        <asp:ListItem Value="NM/CTA Cedars Fusion 2017 |Yes|1|Up to max of Enterprise concurrent users">FIC0475/FIC0475 - NM/CTA Cedars Fusion 2017 </asp:ListItem>
                                                                                        <asp:ListItem Value="Cedars MFSC 2017 |Yes|1|Up to max of Enterprise concurrent users">FIC0476/FIC0476 - Cedars MFSC 2017 </asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM SPECT 2016|No|Enterprise|">FIC0304 - Corridor4DM SPECT 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM NM 2016|No|Enterprise|">FIC0303 - Corridor4DM NM 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CT Opt 2016|No|Enterprise|">FIC0305 - Corridor4DM CT Opt 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor 4DM CFR MBF Opt 2016|No|Enterprise|">FIC0306 - Corridor 4DM CFR MBF Opt 2016</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM NM 2018|No|Enterprise|">FIC0461 - Corridor4DM NM 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM SPECT 2018|No|Enterprise|">FIC0462 - Corridor4DM SPECT 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CT Opt 2018|No|Enterprise|">FIC0463 - Corridor4DM CT Opt 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Corridor4DM CFR MBF Opt 2018|No|Enterprise|">FIC0464 - Corridor4DM CFR MBF Opt 2018</asp:ListItem>
                                                                                        <asp:ListItem Value="Zero FootPrint Viewer SW - 2 User|No|2|55">NICA168/FIC0439 - Zero FootPrint Viewer SW - 2 User</asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Prostate |Yes|1|Sum of FICO4329 and NICA283 and NICA282 and NICA288 should be max 4 and max 10 for hybrid &amp; distributed">NICA283/FIC0429 - DynaCAD Prostate </asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Breast |No|1|">NICA282/FIC0429 - DynaCAD Breast </asp:ListItem>
                                                                                        <asp:ListItem Value="DynaCAD Combo Package |No|1|">NICA288/FIC0429 - DynaCAD Combo Package </asp:ListItem>
                                                                                        <asp:ListItem Value="NM JETPack App License - Add_Users|NULL||NULL">FIC0095 - NM JETPack App License - Add_Users</asp:ListItem>

                                                                                        <asp:ListItem Value="NeuroQ SPECT Opt - Add_Users|NULL||NULL">FIC0253 - NeuroQ SPECT Opt - Add_Users</asp:ListItem>
                                                                                        <asp:ListItem Value="ECTB NM v4.x - Add_Users|NULL||NULL">FIC0221 - ECTB NM v4.x - Add_Users</asp:ListItem>
                                                                                    </asp:DropDownList>

                                                                                </td>
                                                                                <td>
                                                                                    <asp:HiddenField ID="hidtxtConcurrent15" runat="server" />
                                                                                    <input type="number" id="txtConcurrent15" onblur="CheckConcurrentValue(this)" class="form-control" style="margin-top: 3px;" name="txtConcurrent15" min="10" max="100">
                                                                                    <div id="errortxtConcurrent15"  class="errortxtConcurrent" style="color: red; padding-top: 2px; display: none;">Error with input</div>
                                                                                </td>

                                                                                <td align="center">
                                                                                    <i class="fa fa-info-circle" style="margin-top: 10px; font-size: 19px; color: #178bc6;" data-container="body" data-toggle="popover" data-placement="bottom" data-content="Pop up msg" data-original-title="PopD" title="PopT"></i>
                                                                                </td>

                                                                                <td>
                                                                                    <asp:DropDownList ID="cmdHospitalName15" CssClass="form-control" runat="server" Style="width: 100%; margin-top: 3px;">
                                                                                    </asp:DropDownList>
                                                                                </td>
                                                                                <td align="center">
                                                                                    <span id="cmdAddtionalAppDelete15" onclick="deleteAddtionalApp(this);">
                                                                                        <i class="fa fa-trash" aria-hidden="true" style="font-size: 22px; margin-top: 5px;color: #337ab7;"></i>
                                                                                    </span>
                                                                                </td>
                                                                            </tr>

                                                                        </tbody>
                                                                    </table>

                                                                    <asp:HiddenField ID="hidadditionalapps" Value="1" runat="server" />


                                                                    <div onclick="AdditionalAppsAddSite();" style="cursor: pointer;width: 180px;">+ Add another application </div>

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

                                                            <li class="nav-item active" id="Navsoftware-tab"> 
                                                                <a class="nav-link test" id="DELIVERY-tab" name="DELIVERY-tab" data-toggle="tab" href="#DELIVERY" role="tab" aria-controls="DELIVERY" aria-selected="true" style="width: 158px;">Software Only</a>
                                                            </li> 

                                                            <li class="nav-item" id="NavsoftwareHardware-tab">
                                                                <a class="nav-link" id="SOFTWARE-tab" name="SOFTWARE-tab" data-toggle="tab" href="#SOFTWARE" role="tab" aria-controls="SOFTWARE" aria-selected="false" onclick="selectButtons();" style="width: 220px;">Software & Hardware</a>
                                                            </li>

                                                        </ul>
                                                        <div class="tab-content" id="myTabContent1">

                                                            <div class="tab-pane active" id="DELIVERY" role="tabpanel" aria-labelledby="DELIVERY-tab">


                                                                <table class="table" style="margin-left: -15px;">

                                                                    <tbody>


                                                                        <tr>
                                                                            <td style="width: 254px;">ISP Software Only:</td>
                                                                            <td>


                                                                                <input id="cmdISPSoftwareOnly1" onclick="ISPSoftwareButton(this);" class="ISPSoftwareOnly active" type="button" value="1">
                                                                                <input id="cmdISPSoftwareOnly2" onclick="ISPSoftwareButton(this);" class="ISPSoftwareOnly" type="button" value="2">
                                                                                <input id="cmdISPSoftwareOnly3" onclick="ISPSoftwareButton(this);" class="ISPSoftwareOnly" type="button" value="3">
                                                                                <input id="cmdISPSoftwareOnly4" onclick="ISPSoftwareButton(this);" class="ISPSoftwareOnly" type="button" value="4">
                                                                                <input id="cmdISPSoftwareOnly5" onclick="ISPSoftwareButton(this);" class="ISPSoftwareOnly" type="button" value="5">
                                                                                <input id="cmdISPSoftwareOnly6" onclick="ISPSoftwareButton(this);" class="ISPSoftwareOnly" type="button" value="6">
                                                                                <input id="cmdISPSoftwareOnly7" onclick="ISPSoftwareButton(this);" class="ISPSoftwareOnly" type="button" value="7">
                                                                                <input id="cmdISPSoftwareOnly8" onclick="ISPSoftwareButton(this);" class="ISPSoftwareOnly" type="button" value="8">
                                                                                <input id="cmdISPSoftwareOnly9" onclick="ISPSoftwareButton(this);" class="ISPSoftwareOnly" type="button" value="9">
                                                                                <input id="cmdISPSoftwareOnly10" onclick="ISPSoftwareButton(this);" class="ISPSoftwareOnly" type="button" value="10">
                                                                                <input id="cmdISPSoftwareOnly11" onclick="ISPSoftwareButton(this);" class="ISPSoftwareOnly" type="button" value="11">


                                                                                <asp:HiddenField ID="hidISPSoftwareOnly" runat="server" />
                                                                                <asp:HiddenField ID="hidISPSoftwareHardwarePro" runat="server" />
                                                                                <asp:HiddenField ID="hidISPSoftwareHardwarePre" runat="server" />
                                                                            </td>


                                                                        </tr>



                                                                    </tbody>
                                                                </table>


                                                                <table class="table" style="margin-left: -15px;">

                                                                    <tbody>
                                                                        <tr>

                                                                            <td style="width: 274px">ISP Test Server Software Only? </td>

                                                                            <td style="width: 50px;">

                                                                                <input id="cmdISPSoftwareNo" class="ISPSoftwareButton active" onclick="ispSoftware('NO', this);" type="button" value="No">
                                                                            </td>
                                                                            <td style="width: 50px;">
                                                                                <input id="cmdISPSoftwareYes" class="ISPSoftwareButton" onclick="ispSoftware('YES', this);" type="button" value="Yes">
                                                                                <asp:HiddenField ID="hidISPSoftware" runat="server" />
                                                                            </td>

                                                                            <td></td>

                                                                            <td align="right"></td>


                                                                            <td></td>

                                                                        </tr>



                                                                    </tbody>
                                                                </table>

                                                                




                                                                <div class="row">
                                                                    <div class="col-md-12">
                                                                        <div class="table-responsive">
                                                                            <table class="table table-bordered" id="macTable" style="margin-left: -0px;">
                                                                                <thead class="thead-light">
                                                                                    <tr>
                                                                                        <th scope="col" class="w-25" style="background-color: #0b1f65;">No.</th>
                                                                                        <th scope="col" class="w-35" style="background-color: #0b1f65;">Menu</th>
                                                                                        <th scope="col" class="w-25" style="background-color: #0b1f65;">Mac address:</th>
                                                                                        <th scope="col" class="w-25" style="background-color: #0b1f65;">Remove:</th>


                                                                                    </tr>
                                                                                </thead>
                                                                                <tbody>
                                                                                </tbody>
                                                                            </table>
                                                                        </div>
                                                                    </div>

                                                                    <div onclick="MacAddLine();" style="cursor: pointer; margin-left: 14px;">+ Add another line </div>

                                                                </div>





                                                            </div>
                                                            <div class="tab-pane" id="SOFTWARE" role="tabpanel" aria-labelledby="SOFTWARE-tab">



                                                                <table class="">

                                                                    <tbody>
                                                                        <tr>

                                                                            <td>
                                                                                <input type="button" name="hhaNOT" class="HHA" onclick="hha('NO');" value="Hardware High Availiabllity NOT required" id="hhaNOT" style="font-weight: 600; height: 49px; margin-left: -10px;"></td>
                                                                            <td>
                                                                                <input type="button" name="hhaIS" onclick="hha('YES');" class="HHA" value="Hardware High Availiabllity IS required" id="hhaIS" style="font-weight: 600; height: 49px; margin-left: 10px;"></td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>
                                                                                <input type="button" name="HHNotPro" onclick="hha('Pro');" class="HHAopt" value="Pro" id="HHNotPro" style="font-weight: 600; height: 49px; width: 296px; margin-left: -10px; margin-top: 10px;"></td>
                                                                            <td>
                                                                                <input type="button" name="HHNotPrem" onclick="hha('Premium');" class="HHAopt" value="Premium" id="HHNotPrem" style="font-weight: 600; height: 49px; width: 279px; margin-left: 10px; margin-top: 10px;"></td>
                                                                        </tr>


                                                                        <tr>
                                                                            <td>
                                                                                <input type="button" name="HHYesPartial" class="HHAyesopt" onclick="hha('Partial');" value="Partial High Availability" id="HHYesPartial" style="font-weight: 600; height: 49px; width: 296px; margin-left: -10px; margin-top: 10px;"></td>
                                                                            <td>
                                                                                <input type="button" name="HHYesFull" class="HHAyesopt" onclick="hha('Full');" value="Full High Availability" id="HHYesFull" style="font-weight: 600; height: 49px; width: 279px; margin-left: 10px; margin-top: 10px;"></td>
                                                                        </tr>


                                                                    </tbody>

                                                                </table>





                                                                <br>
                                                                <br>

                                                                <div class="">
                                                                    <div class="row hr">
                                                                        <div class="col-md-6">
                                                                            <div class="heading">
                                                                                <h2 style="font-size: 16px; font-weight: bold; margin-left: -17px;">IntelliSpace Portal Enterprise Pro HW</h2>
                                                                                <p style="margin-left: -17px;">Max 30 concurrent users</p>
                                                                            </div>
                                                                            <div class="tab-pane active" id="" role="tabpanel" aria-labelledby="DELIVERY-tab">
                                                                                <table class="table" style="margin-left: -15px;">

                                                                                    <tbody>
                                                                                        <tr>

                                                                                            <td colspan="2" style="width: 274px" id="STBAddStorageLabel">5TB Additional Storage</td>

                                                                                            <td style="width: 50px;">

                                                                                                <input type="button" name="STBAddStorageNo" value="No" id="STBAddStorageNo" class="STBAddStorage" style="font-weight: 600; height: 49px; width: 100px;">
                                                                                            </td>
                                                                                            <td style="width: 50px;">
                                                                                                <input type="button" name="STBAddStorageYes" value="Yes" id="STBAddStorageYes" class="STBAddStorage" style="font-weight: 600; height: 49px; width: 100px;">
                                                                                            </td>

                                                                                        </tr>
                                                                                        <tr>

                                                                                            <td style="width: 210px" id="ISPAdvancedlicenseLabel">ISP Pro License</td>


                                                                                            <td colspan="3" align="right" style="width: 30px;">
                                                                                                <input type="button" name="ISPAdvancedlicense1" value="1" onclick="ISPSoftwareProButton(this);" id="ISPAdvancedlicense1" class="ISPAdvancedlicense" style="font-weight: 600; height: 49px; width: 60px; margin: 0 10px 0 0;">
                                                                                                <input type="button" name="ISPAdvancedlicense2" value="2" onclick="ISPSoftwareProButton(this);" id="ISPAdvancedlicense2" class="ISPAdvancedlicense" style="font-weight: 600; height: 49px; width: 60px; margin: 0 10px 0 0;">
                                                                                                <input type="button" name="ISPAdvancedlicense2" value="3" onclick="ISPSoftwareProButton(this);" id="ISPAdvancedlicense3" class="ISPAdvancedlicense" style="font-weight: 600; height: 49px; width: 60px; margin: 0 10px 0 0;">
                                                                                                <input type="button" name="ISPAdvancedlicense2" value="4" onclick="ISPSoftwareProButton(this);" id="ISPAdvancedlicense4" class="ISPAdvancedlicense" style="font-weight: 600; height: 49px; width: 60px; margin: 0 10px 0 0;">
                                                                                                <input type="button" name="ISPAdvancedlicense2" value="5" onclick="ISPSoftwareProButton(this);" id="ISPAdvancedlicense5" class="ISPAdvancedlicense" style="font-weight: 600; height: 49px; width: 60px">
                                                                                        </tr>

                                                                                        <tr>

                                                                                            <td colspan="2" style="width: 274px" id="ISPTextLicenseRequiredLabel">ISP Test Server Software Only?</td>

                                                                                            <td style="width: 50px;">

                                                                                                <input type="button" name="ISPTextLicenseRequiredNo" onclick="ispSoftwarePro('NO', this);" class="ISPTextLicenseRequired" value="No" id="ISPTextLicenseRequiredNo" style="font-weight: 600; height: 49px; width: 100px;">
                                                                                            </td>
                                                                                            <td style="width: 50px;">
                                                                                                <input type="button" name="ISPTextLicenseRequiredYes" onclick="ispSoftwarePro('YES', this);" class="ISPTextLicenseRequired" value="Yes" id="ISPTextLicenseRequiredYes" style="font-weight: 600; height: 49px; width: 100px;">
                                                                                            </td>
                                                                                        </tr>





                                                                                    </tbody>
                                                                                </table>
                                                                            </div>
                                                                        </div>
                                                                        <div class="col-md-6">
                                                                            <div class="heading">
                                                                                <h2 style="font-size: 16px; font-weight: bold; margin-left: -17px;">IntelliSpace Portal Enterprise Premium HW</h2>
                                                                                <p style="margin-left: -17px;">Max 50 concurrent users</p>
                                                                            </div>
                                                                            <div class="tab-pane active" id="" role="tabpanel" aria-labelledby="DELIVERY-tab">
                                                                                <table class="table" style="margin-left: -15px;">

                                                                                    <tbody>
                                                                                        <tr>

                                                                                            <td colspan="2" id="prelabel1" style="width: 274px">Do Your Customer requires Philips to provide storage?  (required-10TB) </td>

                                                                                            <td style="width: 50px;">

                                                                                                <input type="button" name="PhilipsprovidestorageNo" value="No" id="PhilipsprovidestorageNo" onclick="prePhilipsprovidestorage('NO');" class="Philipsprovidestorage" style="font-weight: 600; height: 49px; width: 100px;">
                                                                                            </td>
                                                                                            <td colspan="" style="width: 50px;">
                                                                                                <input type="button" name="PhilipsprovidestorageYes" value="Yes" id="PhilipsprovidestorageYes" onclick="prePhilipsprovidestorage('YES');" class="Philipsprovidestorage" style="font-weight: 600; height: 49px; width: 100px;">
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr id="premTotalStorageRequiredROW">

                                                                                            <td style="width: 274px;" id="prelabel2">Total Storage Required </td>

                                                                                            <td style="width: 50px;">

                                                                                                <input type="button" name="AdditionalStorageRequired10TB" value="10TB" id="AdditionalStorageRequired10TB" class="AdditionalStorageRequiredHW" style="font-weight: 600; height: 49px; width: 100px;">
                                                                                            </td>
                                                                                            <td style="width: 50px;">

                                                                                                <input type="button" name="AdditionalStorageRequired15TB" value="15TB" id="AdditionalStorageRequired15TB" class="AdditionalStorageRequiredHW" style="font-weight: 600; height: 49px; width: 100px;">
                                                                                            </td>
                                                                                            <td style="width: 50px;">

                                                                                                <input type="button" name="AdditionalStorageRequired20TB" value="20TB" id="AdditionalStorageRequired20TB" class="AdditionalStorageRequiredHW" style="font-weight: 600; height: 49px; width: 100px;">
                                                                                            </td>
                                                                                        </tr>

                                                                                        <tr>

                                                                                            <td style="width: 274px" id="prelabel3">Total Host servers required </td>

                                                                                            <td colspan="3" align="right">

                                                                                                <input type="button" name="Additionalhostserver1" value="1" id="Additionalhostserver1" disabled class="AdditionalhostserverHW" style="font-weight: 600; height: 49px; width: 49px; margin: 0 5px 0 0;">
                                                                                                <input type="button" name="Additionalhostserver2" value="2" id="Additionalhostserver2" disabled class="AdditionalhostserverHW" style="font-weight: 600; height: 49px; width: 49px; margin: 0 5px 0 0;">
                                                                                                <input type="button" name="Additionalhostserver3" value="3" id="Additionalhostserver3" disabled class="AdditionalhostserverHW" style="font-weight: 600; height: 49px; width: 49px; margin: 0 5px 0 0;">
                                                                                                <%--<input type="button" name="Additionalhostserver4" value="4" id="Additionalhostserver4" class="AdditionalhostserverHW" style="font-weight: 600; height: 49px; width: 49px; margin: 0 5px 0 0;">
                                                                                                <input type="button" name="Additionalhostserver5" value="5" id="Additionalhostserver5" class="AdditionalhostserverHW" style="font-weight: 600; height: 49px; width: 49px; margin: 0 5px 0 0;">--%>
                                                                                            </td>

                                                                                        </tr>


                                                                                      



                                                                                        <tr style="">

                                                                                            <td style="width: 274px" id="prelabel4">ISP Premium License</td>

                                                                                            <td colspan="3" align="right">
                                                                                                <input type="button" name="ISPPremiumLicense1" value="1" onclick="ISPSoftwarePreButton(this);" id="ISPPremiumLicense1" class="ISPPremiumLicenseHW" style="font-weight: 600; height: 49px; width: 49px; margin: 0 5px 0 0;">
                                                                                                <input type="button" name="ISPPremiumLicense2" value="2" onclick="ISPSoftwarePreButton(this);" id="ISPPremiumLicense2" class="ISPPremiumLicenseHW" style="font-weight: 600; height: 49px; width: 49px; margin: 0 5px 0 0;">
                                                                                                <input type="button" name="ISPPremiumLicense3" value="3" onclick="ISPSoftwarePreButton(this);" id="ISPPremiumLicense3" class="ISPPremiumLicenseHW" style="font-weight: 600; height: 49px; width: 49px; margin: 0 5px 0 0;">
                                                                                                <input type="button" name="ISPPremiumLicense4" value="4" onclick="ISPSoftwarePreButton(this);" id="ISPPremiumLicense4" class="ISPPremiumLicenseHW" style="font-weight: 600; height: 49px; width: 49px; margin: 0 5px 0 0;">
                                                                                                <input type="button" name="ISPPremiumLicense5" value="5" onclick="ISPSoftwarePreButton(this);" id="ISPPremiumLicense5" class="ISPPremiumLicenseHW" style="font-weight: 600; height: 49px; width: 49px; margin: 0 5px 0 0;"></td>




                                                                                        </tr>

                                                                                        <tr style="">

                                                                                            <td style="width: 274px; border-top: 0px" id="prelabel4"></td>

                                                                                            <td colspan="3" align="right" style="border-top: 0px">
                                                                                                <input type="button" name="ISPPremiumLicense6" value="6" onclick="ISPSoftwarePreButton(this);" id="ISPPremiumLicense6" class="ISPPremiumLicenseHW" style="font-weight: 600; height: 49px; width: 49px; margin: 0 5px 0 0;">
                                                                                                <input type="button" name="ISPPremiumLicense7" value="7" onclick="ISPSoftwarePreButton(this);" id="ISPPremiumLicense7" class="ISPPremiumLicenseHW" style="font-weight: 600; height: 49px; width: 49px; margin: 0 5px 0 0;">
                                                                                                <input type="button" name="ISPPremiumLicense8" value="8" onclick="ISPSoftwarePreButton(this);" id="ISPPremiumLicense8" class="ISPPremiumLicenseHW" style="font-weight: 600; height: 49px; width: 49px; margin: 0 5px 0 0;">
                                                                                                <input type="button" name="ISPPremiumLicense9" value="9" onclick="ISPSoftwarePreButton(this);" id="ISPPremiumLicense9" class="ISPPremiumLicenseHW" style="font-weight: 600; height: 49px; width: 49px; margin: 0 5px 0 0;">
                                                                                                <%--<input type="button" name="ISPPremiumLicense10" value="10" onclick="ISPSoftwarePreButton(this);" id="ISPPremiumLicense10" class="ISPPremiumLicenseHW" style="font-weight: 600; height: 49px; width: 49px; margin: 0 5px 0 0;"></td>--%>




                                                                                        </tr>




                                                                                        <tr>

                                                                                            <td colspan="2" style="width: 274px" id="prelabel5">ISP Test Server Software Only?</td>

                                                                                            <td style="width: 50px;">

                                                                                                <input type="button" name="ISPTestLicenseHWNo" value="No" id="ISPTestLicenseHWNo" onclick="ispSoftwarePre('NO', this);" class="ISPTestLicenseHW" style="font-weight: 600; height: 49px; width: 100px;">
                                                                                            </td>
                                                                                            <td style="width: 50px;">
                                                                                                <input type="button" name="ISPTestLicenseHWYes" value="Yes" id="ISPTestLicenseHWYes" onclick="ispSoftwarePre('YES', this);" class="ISPTestLicenseHW" style="font-weight: 600; height: 49px; width: 100px;">
                                                                                            </td>
                                                                                        </tr>



                                                                                    </tbody>
                                                                                </table>












                                                                            </div>
                                                                        </div>
                                                                    </div>




                                                                    <div class="row">
                                                                        <div class="row">
                                                                            <div class="col-md-12">
                                                                                <div class="table-responsive">
                                                                                    <table class="table table-bordered" id="macTableAdv" style="margin-left: -0px;">
                                                                                        <thead class="thead-light">
                                                                                            <tr>
                                                                                                <th scope="col" class="w-25" style="background-color: #0b1f65;">No.</th>
                                                                                                <th scope="col" class="w-35" style="background-color: #0b1f65;">Menu</th>
                                                                                                <th scope="col" class="w-25" style="background-color: #0b1f65;">Mac address:</th>
                                                                                                <th scope="col" class="w-25" style="background-color: #0b1f65;">Remove:</th>

                                                                                            </tr>
                                                                                        </thead>
                                                                                        <tbody>
                                                                                        </tbody>
                                                                                    </table>
                                                                                </div>
                                                                            </div>

                                                                            <div onclick="MacAddLinePro();" style="cursor: pointer; margin-left: 14px;">+ Add another line </div>

                                                                        </div>


                                                                    </div>
                                                                </div>


                                                            </div>

                                                        </div>

                                                    </div>

                                                </div>
                                            </div>


                                            <div class="seperator" style="border-bottom-color: #cdcdcd; border-bottom-style: solid;">
                                            </div>

                                            <div class="row">
                                                <div class="col-8 text-center">


                                                    <table class="table table-responsive text-center" style="margin-left: 40px; margin-right: 40px; width:80%">

                                                      <tbody>    
                                                        <tr>
                                                          <td> <asp:LinkButton ID="cmdConfig" OnClick="cmdConfig_Click" runat="server" Style="display: block; background: #178bc6; color: #ffff; margin: auto; width: 20%; border: none; padding: 15px;  text-align: center;"> Configuration </asp:LinkButton>
</td>
                                                          <td> <asp:LinkButton ID="cmdSave" OnClick="cmdSave_Click" OnClientClick="setupSave();" runat="server" Style="display: block; background: #178bc6; color: #ffff; margin: auto; width: 20%; border: none; padding: 15px;  text-align: center;"> Save </asp:LinkButton>
</td>
      
                                                        </tr>
                                                      </tbody>
                                                    </table>


                                                   
                                                   <asp:HiddenField ID="HiddenApplicationServer" Value="" runat="server" />

                                                    <asp:HiddenField ID="HiddenDeliveryModel" Value="" runat="server" />

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
        </div>



<!-- Modal -->
<div class="modal fade" id="FullHAModalCenter" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
  <div class="modal-dialog modal-dialog-centered" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLongTitle">Management</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
        Please contact your solution architect and product management
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
        <button type="button" class="btn btn-primary">Save changes</button>
      </div>
    </div>
  </div>
</div>



<!-- Modal -->
<div class="modal fade" id="ApplicationErrorModalCenter" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
  <div class="modal-dialog modal-dialog-centered" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLongTitle">Management</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
        Please add a main application 
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
        
      </div>
    </div>
  </div>
</div>



<!-- Modal -->
<div class="modal fade" id="ApplicationDupErrorModalCenter" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
  <div class="modal-dialog modal-dialog-centered" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLongTitle">Management</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
        Duplicate App
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
        
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


        <asp:HiddenField ID="hidLicenceData" runat="server" />
        <asp:HiddenField ID="hidApplicationData" runat="server" />
        <asp:HiddenField ID="hidMacTable" runat="server" Value="<%=m_hidMacTable %>" />
        <asp:HiddenField ID="hidManualISP" runat="server" />


        <asp:HiddenField ID="hidLicenceDataPro" runat="server" />
        <asp:HiddenField ID="hidLicenceDataPro2" runat="server" />
        <asp:HiddenField ID="hidApplicationDataPro" runat="server" />
        <asp:HiddenField ID="hidMacTablePro" runat="server" Value="" />
        <asp:HiddenField ID="hidManualISPPro" runat="server" />

        <asp:HiddenField ID="parial_ha" runat="server" />
        <asp:HiddenField ID="full_ha" runat="server" />
        <asp:HiddenField ID="server_ha_partial" runat="server" />
        <asp:HiddenField ID="server_ha_full" runat="server" />

        <asp:HiddenField ID="hidConcurrent_Default" runat="server" />
        <asp:HiddenField ID="hidConcurrent_Range" runat="server" />






    </form>

   


    <script
        src="https://code.jquery.com/jquery-3.4.1.min.js"
        integrity="sha256-CSXorXvZcTkaix6Yvo6HppcZGetbYMGWSFlBw8HfCJo="
        crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    
     <script src="../js/bootstrap.min.js"></script>



    <script src="https://cdn.jsdelivr.net/npm/select2@4.0.13/dist/js/select2.min.js"></script>

    <script>


        var isDev = false;

        var sapicheckapp = "";
        var sapidata = "";
        var sapidatahesoft = "";

        if (isDev == true) {
            sapicheckapp = "./apicheckapp";
            sapidata = "./apidata";
            sapidatahesoft = "./apidatahesoft";
        } else {
            sapicheckapp = "./apicheckapp.aspx";
            sapidata = "./apidata.aspx";
            sapidatahesoft = "./apidatahesoft.aspx";
        }

        var arrHead = new Array();
        arrHead = ['No', 'Menu', 'Mac','Remove']; // table headers.





        function CreateRowPro(NoRows, ApplicationUsed, IsTest, maclist, isPre) {

            //remove items

            var tableHeaderRowCount = 1;
            var table = document.getElementById('macTableAdv');
            var rowCount = table.rows.length;
            for (var i = tableHeaderRowCount; i < rowCount; i++) {                        
                table.deleteRow(tableHeaderRowCount);            
            }

          

            //remove items
            NoRows++;

            for (var r = 0; r < NoRows; r++) {
                addRowPro(r + 1, ApplicationUsed, NoRows, IsTest, maclist, isPre);
            }

        }

        function CreateRow(NoRows, ApplicationUsed, IsTest, maclist) {

            //remove items

            var tableHeaderRowCount = 1;
            var table = document.getElementById('macTable');
            var rowCount = table.rows.length;
            for (var i = tableHeaderRowCount; i < rowCount; i++) {                      
                table.deleteRow(tableHeaderRowCount);           
            }

            if (IsTest == true) {
                  NoRows++;
            }

            
            NoRows++;                      

            for (var r = 0; r < NoRows; r++) {
                addRow(r + 1, ApplicationUsed, NoRows, IsTest, maclist);
            }

        }

        function storeCurrentMacPro() {

            var macTable = document.getElementById('macTableAdv');
            var rowCnt = macTable.rows.length - 1;

            var MacList = "";


            for (var i = 1; i <= rowCnt; i++) {
                var myMac = '';
                if ($("#MacSoftwareOnlyPro" + i).length > 0) {
                    myMac = $("#MacSoftwareOnlyPro" + i)[0].value;
                }
                

                if ($("#ApplicationSoftwareOnly" + i)[0] != undefined) {                    
                    MacList += $("#ApplicationSoftwareOnly" + i)[0].value + ":" +myMac + ",";
                }
                
            }

            if (MacList != "") {
                MacList = MacList.substr(0, MacList.length - 1);
            }

            $('#hidMacTable')[0].value = MacList;



            //hidMacTable
           // let a = "";

        }

        function storeCurrentMac() {

            var macTable = document.getElementById('macTable');
            var rowCnt = macTable.rows.length - 1;

            var MacList = "";

            

            for (var i = 1; i <= rowCnt; i++) {
                var myMac = '';
                if ($("#MacSoftwareOnly" + i).length > 0) {
                    myMac = $("#MacSoftwareOnly" + i)[0].value;
                }

                MacList += $("#ApplicationSoftwareOnly" + i)[0].value + ":" +myMac + ",";
            }

            if (MacList != "") {
                MacList = MacList.substr(0, MacList.length - 1);
            }

            $('#hidMacTable')[0].value = MacList;



            //hidMacTable
            //let a = "";

        }

        function addRowPro(idx, ApplicationUsed, NoRows, IsTest, maclist, isPre) {

            var datalicence = parseInt($('#hidLicenceDataPro2')[0].value) + 1;

            var empTab = document.getElementById('macTableAdv');
            var rowCnt = empTab.rows.length;    // get the number of rows.
            var tr = empTab.insertRow(rowCnt); // table row.
            tr.id = ApplicationUsed;
            //tr = empTab.insertRow(rowCnt);


            for (var c = 0; c < arrHead.length; c++) {
                var td = document.createElement('td');
                td = tr.insertCell(c);
                td.align = "center";

                switch (c) {

                    case 0:

                        var closeSpan = document.createElement("span");
                        closeSpan.setAttribute("class", "text-center");
                        closeSpan.textContent = idx;
                        td.appendChild(closeSpan);
                        break;
                    case 1:
                        var select = document.createElement('select');
                        select.name = "ApplicationSoftwareHardWare" + idx;
                        select.id = "ApplicationSoftwareHardWare" + idx;
                        select.setAttribute("onchange", "storeCurrentMacPro();");

                        if (idx > datalicence) {

                        } else {
                            select.setAttribute("readonly", "readonly");

                        }
                                                                                         
                        var option;
                        var inputdata = "NICB021 - Advanced Extended Storage 5TB||FIC0139 - Concerto remote sites||NICB020 - Ent Prem. HW Solution engine||NICB023 - Ent Prem. HW Solution storage||NICB006 - Enterprise Engine SW||FIC0455 ISP Advanced  SW License||FIC0456 ISP Premium  SW License||FICO248 - ISP Server - Software only||NICB052 - Premium Add. Second Engine||NICB053 - Premium Add. Third Engine||NICA963 - ISP Test Server - Software Only";
                        var split = inputdata.split('||');

                        select.setAttribute("class", "form-control");
                        inputdata.split('||').forEach(function (item) {

                            option = document.createElement('option');

                            option.value = option.textContent = item;

                            select.appendChild(option);
                        });

                        td.appendChild(select);

                        if (idx == 1) {
                            $("#ApplicationSoftwareHardWare" + idx).val('NICB006 - Enterprise Engine SW').change();
                        } else {
                            if (isPre == 1) {
                                $("#ApplicationSoftwareHardWare" + idx).val('FIC0456 ISP Premium  SW License').change();
                            } else {
                                $("#ApplicationSoftwareHardWare" + idx).val('FIC0455 ISP Advanced  SW License').change();
                            }
                        }


                       
                        if (maclist != "" & maclist != null) {

                            var n = maclist.includes(",");
                            if (n == true) {
                                res = maclist.split(",");

                                for (i = 0; i < res.length; i++) {
                                    if (idx == (i + 1)) {
                                        if (res[i] != ":") {
                                             myMacres = res[i].split(":");                                            
                                            $("#ApplicationSoftwareHardWare" + idx).val('NICA963 - ISP Test Server - Software Only').change();
                                        }
                                    }
                                }
                            }

                        }



                        if (IsTest == true) {
                            if (NoRows == idx) {
                                 $("#ApplicationSoftwareHardWare" + idx).val('NICA963 - ISP Test Server - Software Only').change();
                                //$("#ApplicationSoftwareHardWare" + idx)[0].options[10].selected = 'selected'; //Test 
                                $("#ApplicationSoftwareHardWare" + idx).attr("readonly", "readonly");
                            }
                        }

                        break;
                    case 2:

                        var ele = document.createElement('input');
                        ele.setAttribute('type', 'text');
                        ele.setAttribute('value', '');
                        ele.setAttribute('name', "MacSoftwareOnlyPro" + idx);
                        ele.setAttribute("class", "form-control");
                        td.appendChild(ele);


                                               
                        if (maclist != "" & maclist != null) {

                            var n = maclist.includes(",");
                            if (n == true) {
                                res = maclist.split(",");

                                for (i = 0; i < res.length; i++) {
                                    if (idx == (i + 1)) {
                                        if (res[i] != ":") {
                                            myMacres = res[i].split(":");     
                                             $("#MacSoftwareOnlyPro" + idx)[0].value = myMacres[1];
                                            
                                        }
                                    }
                                }
                            }

                        }

                        break;
                    case 3:
                        
                                              


                        if (idx > datalicence) {

                            var ele = document.createElement('span');
                            ele.setAttribute('id', 'cmdLicenceProDelete' + idx);
                            ele.setAttribute('onclick', 'deleteLicencePro(this);');
                            td.appendChild(ele);

                            if ($("#ApplicationSoftwareHardWare" + idx)[0].value == "NICA963 - ISP Test Server - Software Only") {
                            }
                            else {
                                document.getElementById('cmdLicenceProDelete' + idx).innerHTML = '<i class="fa fa-trash" aria-hidden="true" style="font-size: 22px; margin-top: 5px;color: #337ab7;"></i>';
                            }
                            


                        } else {



                            

                        }

                        break;
                }


            }
        }

        function addRow(idx, ApplicationUsed, NoRows, IsTest, maclist) {

            var datalicence = parseInt($('#hidLicenceData')[0].value) + 1;

            var empTab = document.getElementById('macTable');
            var rowCnt = empTab.rows.length;    // get the number of rows.
            var tr = empTab.insertRow(rowCnt); // table row.
            tr.id = ApplicationUsed;
            //tr = empTab.insertRow(rowCnt);


            for (var c = 0; c < arrHead.length; c++) {
                var td = document.createElement('td');
                td = tr.insertCell(c);
                td.align = "center";

                switch (c) {

                    case 0:

                        var closeSpan = document.createElement("span");
                        closeSpan.setAttribute("class", "text-center");
                        closeSpan.textContent = idx;
                        td.appendChild(closeSpan);
                        break;
                    case 1:
                        var select = document.createElement('select');
                        select.name = "ApplicationSoftwareOnly" + idx;
                        select.id = "ApplicationSoftwareOnly" + idx;
                        select.setAttribute("onchange", "storeCurrentMac();");

                        if (idx > datalicence) {

                        } else {
                            select.setAttribute("readonly", "readonly");

                        }







                        var option;
                        var inputdata = "NICB021 - Advanced Extended Storage 5TB||FIC0139 - Concerto remote sites||NICB020 - Ent Prem. HW Solution engine||NICB023 - Ent Prem. HW Solution storage||NICB006 - Enterprise Engine SW||ISP Advanced  SW License||ISP Premium  SW License||FICO248 - ISP Server - Software only||NICB052 - Premium Add. Second Engine||NICB053 - Premium Add. Third Engine||NICA963 - ISP Test Server - Software Only";
                        var split = inputdata.split('||');

                        select.setAttribute("class", "form-control softwareTable");
                        inputdata.split('||').forEach(function (item) {

                            option = document.createElement('option');

                            option.value = option.textContent = item;

                            select.appendChild(option);
                        });

                        td.appendChild(select);

                        if (idx == 1) {
                            $("#ApplicationSoftwareOnly" + idx).val('NICB006 - Enterprise Engine SW').change();
                        } else {
                            $("#ApplicationSoftwareOnly" + idx).val('FICO248 - ISP Server - Software only').change();
                        }



                        if (maclist != "" & maclist != null) {

                            var n = maclist.includes(",");
                            if (n == true) {
                                res = maclist.split(",");

                                for (i = 0; i < res.length; i++) {
                                    if (idx == (i + 1)) {
                                        if (res[i] != ":") {

                                              myMacres = res[i].split(":");
                                            
                                            $("#ApplicationSoftwareOnly" + idx).val(myMacres[0]).change();
                                        }
                                    }
                                }
                            }

                        }



                        if (IsTest == true) {
                            if (NoRows == idx) {
                                $("#ApplicationSoftwareOnly" + idx)[0].options[10].selected = 'selected'; //Test 
                                $("#ApplicationSoftwareOnly" + idx).attr("readonly", "readonly");
                            }
                        }

                        break;
                    case 2:
                        

                        var ele = document.createElement('input');
                        ele.setAttribute('type', 'text');
                        ele.setAttribute('value', '');
                        ele.setAttribute('name', "MacSoftwareOnly" + idx);
                        ele.setAttribute('id', "MacSoftwareOnly" + idx);
                        ele.setAttribute("class", "form-control");
                        td.appendChild(ele);



                        if (maclist != "" & maclist != null) {

                            var n = maclist.includes(",");
                            if (n == true) {
                                res = maclist.split(",");

                                for (i = 0; i < res.length; i++) {
                                    if (idx == (i + 1)) {
                                        if (res[i] != ":") {

                                            myMacres = res[i].split(":");
                                            $("#MacSoftwareOnly" + idx)[0].value = myMacres[1];
                                           
                                        }
                                    }
                                }
                            }

                        }



                        break;


                    case 3:
                        
                        //    <span id="cmdAddtionalAppDelete1" onclick="deleteAddtionalApp(this);">
                        //        <i class="fa fa-trash" aria-hidden="true" style="font-size: 22px; margin-top: 5px;"></i>
                        //    </span>                            


                        if (idx > datalicence) {

                            var ele = document.createElement('span');
                            ele.setAttribute('id', 'cmdLicenceDelete' + idx);
                            ele.setAttribute('onclick', 'deleteLicence(this);');
                            td.appendChild(ele);

                            if ($("#ApplicationSoftwareOnly" + idx)[0].value == "NICA963 - ISP Test Server - Software Only")
                            {
                               // document.getElementById('cmdLicenceDelete' + idx).innerHTML = '<i class="fa fa-trash" aria-hidden="true" style="font-size: 22px; margin-top: 5px;color: #337ab7;"></i>';
                            } else
                            {
                                document.getElementById('cmdLicenceDelete' + idx).innerHTML = '<i class="fa fa-trash" aria-hidden="true" style="font-size: 22px; margin-top: 5px;color: #337ab7;"></i>';
                            }


                        } else {



                            

                        }

                        break;
                }


            }
        }


        function CheckConcurrentValue(TextBoxItem) {

          //  let myCONCURRENTENTERPRISEUSERS = parseInt($("#CONCURRENTENTERPRISEUSERS")[0].value);
            let myvalue = parseInt($(TextBoxItem)[0].value);

            let CurrentIDX = TextBoxItem.id.replace('txtConcurrent', '');
          
            if ( myvalue > $(TextBoxItem)[0].max) {
                $("#errortxtConcurrent" + CurrentIDX).show();
                $(TextBoxItem)[0].value = $(TextBoxItem)[0].max;
                $("#errortxtConcurrent" + CurrentIDX)[0].innerHTML = "max range is " + $(TextBoxItem)[0].max;

            } else {
                $("#errortxtConcurrent" + CurrentIDX).hide();
            }


            GetLicenceData();

        }


       

        $('.STBAddStorage').click(function () {
            $('.STBAddStorage.active').removeClass("active");
            $(this).addClass("active");

        });

        $('.ISPAdvancedlicense').click(function () {
            $('.ISPAdvancedlicense.active').removeClass("active");
            $(this).addClass("active");

        });

        $('.ISPEnterprisetestlicense').click(function () {
            $('.ISPEnterprisetestlicense.active').removeClass("active");
            $(this).addClass("active");

        });

        $('.ISPTextLicenseRequired').click(function () {
            $('.ISPTextLicenseRequired.active').removeClass("active");
            $(this).addClass("active");

        });


        $('.ISPTestLicenseHW').click(function () {
            $('.ISPTestLicenseHW.active').removeClass("active");
            $(this).addClass("active");

        });
        $('.AdditionalhostserverHW').click(function () {
            $('.AdditionalhostserverHW.active').removeClass("active");
            $(this).addClass("active");

        });
        $('.AdditionalStorageRequiredHW').click(function () {
            $('.AdditionalStorageRequiredHW.active').removeClass("active");
            $(this).addClass("active");

        });
        $('.Philipsprovidestorage').click(function () {
            $('.Philipsprovidestorage.active').removeClass("active");
            $(this).addClass("active");

        });
        $('.ISPPremiumLicenseHW').click(function () {
            $('.ISPPremiumLicenseHW.active').removeClass("active");
            $(this).addClass("active");

        });

        $('.HHAyesopt').click(function () {
            $('.HHAyesopt.active').removeClass("active");
            $(this).addClass("active");
        });

        $('.HHAopt').click(function () {
            $('.HHAopt.active').removeClass("active");
            $(this).addClass("active");
        });

        $('.HHA').click(function () {
            $('.HHA.active').removeClass("active");
            $(this).addClass("active");

        });

        $('.ISPSoftwareOnly').click(function () {
            $('.ISPSoftwareOnly.active').removeClass("active");
            $(this).addClass("active");

            $('#hidISPSoftwareOnly')[0].value = $(this)[0].value;


        });




        $('.ISPSoftwareButton').click(function () {
            $('.ISPSoftwareButton.active').removeClass("active");
            $(this).addClass("active");
            if ($(this)[0].id == "cmdISPSoftwareYes") {
                $('#hidISPSoftware')[0].value = 1;
            } else {
                $('#hidISPSoftware')[0].value = 0;
            }

        });


        async  function CheckApplicationsValidation (appName,ddlbox)
        {

            var AppArray = [];

            let selectedapplication1 = $("#cmdApplication1")[0].value ;
            let selectedapplication2 = $("#cmdApplication2")[0].value ;
            let selectedapplication3 = $("#cmdApplication3")[0].value ;
            let selectedapplication4 = $("#cmdApplication4")[0].value ;
            let selectedapplication5 = $("#cmdApplication5")[0].value;
            let selectedapplication6 = $("#cmdApplication6")[0].value;
            let selectedapplication7 = $("#cmdApplication7")[0].value;
            let selectedapplication8 = $("#cmdApplication8")[0].value;
            let selectedapplication9 = $("#cmdApplication9")[0].value;
            let selectedapplication10 = $("#cmdApplication10")[0].value;
            let selectedapplication11 = $("#cmdApplication11")[0].value;
            let selectedapplication12 = $("#cmdApplication12")[0].value;
            let selectedapplication13 = $("#cmdApplication13")[0].value;
            let selectedapplication14 = $("#cmdApplication14")[0].value;
            let selectedapplication15 = $("#cmdApplication15")[0].value;


            AppArray.push(selectedapplication1);
            AppArray.push(selectedapplication2);
            AppArray.push(selectedapplication3);
            AppArray.push(selectedapplication4);
            AppArray.push(selectedapplication5);
            AppArray.push(selectedapplication6);
            AppArray.push(selectedapplication7);
            AppArray.push(selectedapplication8);
            AppArray.push(selectedapplication9);
            AppArray.push(selectedapplication10);
            AppArray.push(selectedapplication11);
            AppArray.push(selectedapplication12);
            AppArray.push(selectedapplication13);
            AppArray.push(selectedapplication14);
            AppArray.push(selectedapplication15);



             var myKeyVals = { appName: appName, AppArray: AppArray.toString() }

             $.ajax(sapicheckapp, 
                {
                    type: 'POST',
                    data: myKeyVals,
                    dataType: 'json', 
                  
                    success: function (data, status, xhr) {   // success callback function


                        
                        console.log("data.data:" + data.data);

                        //if (data.data == "0") {
                            
                        //    $("#" + ddlbox.id).val('').change();                                                                                                                                     
                        //    $("#txtConcurrent" + ddlbox.id.replace("cmdApplication", ""))[0].value = "";
                        //    $("#hidtxtConcurrent"+ ddlbox.id.replace("cmdApplication",""))[0].value ="";

                           

                        //   // $("#ApplicationErrorModalCenter").modal();
                        //    return false;
                        //}


                        if (data.data == "3") {
                            
                            $("#" + ddlbox.id).val('').change();                                                                                                                                     
                            $("#txtConcurrent" + ddlbox.id.replace("cmdApplication", ""))[0].value = "";
                            $("#hidtxtConcurrent"+ ddlbox.id.replace("cmdApplication",""))[0].value ="";
                            $("#ApplicationDupErrorModalCenter").modal();                              
                            return false;
                        }


                        GetApplicationDataitem(ddlbox);

                        return true;

                    },
                    error: function (jqXhr, textStatus, errorMessage) { // error callback                     
                        alert(errorMessage);
                    }
                });



            


        }



        function GetApplicationData(ddlbox) {

            if (ddlbox.value != "")
            {
                var array = ddlbox.value.split("|");

                let isValid = CheckApplicationsValidation(array[0], ddlbox);
            }

        }


        function GetApplicationDataitem(ddlbox) {
                       

            var array = ddlbox.value.split("|");

            if (array.length > 1) {


                let CurrentIDX = 0;
                CurrentIDX = ddlbox.id.replace('cmdApplication', '');
                
                    if (array[2] == "Enterprise") {

                        $("#txtConcurrent" + CurrentIDX )[0].value = $("#CONCURRENTENTERPRISEUSERS")[0].value;
                        $("#hidtxtConcurrent" + CurrentIDX )[0].value = $("#CONCURRENTENTERPRISEUSERS")[0].value;


                    } else {
                        let CONCURRENTENTERPRISEUSERS = $("#CONCURRENTENTERPRISEUSERS")[0].value;

                        if (array[2] == "1") {
                            if (!array[0].includes("Add_Users")) {
                                if (array[3] == "Up to max of Enterprise concurrent users") {

                                } else {
                                    $("#txtConcurrent" + CurrentIDX)[0].readOnly = true;
                                }

                            } else {
                                $("#txtConcurrent" + CurrentIDX)[0].readOnly = false;
                            }
                        }

                        if (!array[0].includes("Add_Users")) {

                            if ($("#txtConcurrent" + CurrentIDX)[0].value == "") {

                                $("#txtConcurrent" + CurrentIDX)[0].value = array[2];
                                $("#hidtxtConcurrent" + CurrentIDX)[0].value = array[2];

                            }

                            switch (array[3])
                            {
                                case "Up to max of Enterprise concurrent users":

                                    $("#txtConcurrent" + CurrentIDX)[0].max = CONCURRENTENTERPRISEUSERS;
                                    break;

                                default:
                                    $("#txtConcurrent" + CurrentIDX)[0].max = array[3];
                                    break;
                            }                            
                            
                        }

                        if (array[0].includes("Add_Users")) {

                            CONCURRENTENTERPRISEUSERS = CONCURRENTENTERPRISEUSERS - 1;


                            switch (array[0]) {
                                case "DynaCAD Enterprise - Add_Users":
                                    let usageCount = 0;

                                    var i;
                                    for (i = 1; i <= 15; i++) {
                                        if ($("#cmdApplication" + i)[0].value.includes("DynaCAD Prostate - 1 User") | $("#cmdApplication" + i)[0].value.includes("DynaCAD Breast - 1 User") | $("#cmdApplication" + i)[0].value.includes("DynaCAD Combo Package - 1 User")) {

                                            usageCount++;
                                        }
                                    }

                                    $("#txtConcurrent" + CurrentIDX)[0].min = 1;
                                    $("#txtConcurrent" + CurrentIDX)[0].max = (4 - usageCount);
                                    //if ($("#txtConcurrent" + CurrentIDX)[0].value == "") {
                                    //    $("#txtConcurrent" + CurrentIDX)[0].value = (4 - usageCount);
                                    //}
                                    
                                    break;
                                case "Zero FootPrint Viewer SW - Add_Users":
                                    $("#txtConcurrent" + CurrentIDX)[0].min = 1;
                                    $("#txtConcurrent" + CurrentIDX)[0].max = 53;
                                    break;
                                default:
                                    $("#txtConcurrent" + CurrentIDX)[0].min = 1;
                                    $("#txtConcurrent" + CurrentIDX)[0].max = CONCURRENTENTERPRISEUSERS;
                                    //$("#txtConcurrent" + CurrentIDX)[0].value = CONCURRENTENTERPRISEUSERS;
                                    break;
                            }


                        }

                    


                }


                //checkallDynacad
                var i;
                var dycAddUserLocation = 0;
                var dyncadcnt = 0;
                for (i = 0; i < 16; i++) {
                    if ($("#cmdApplication" + i)[0] != undefined && $("#cmdApplication" + i)[0].value !="" ) {
                        let appitem = $("#cmdApplication" + i)[0].value;
                        if (appitem != "") {                            
                            var arrayloop = $("#cmdApplication" + i)[0].value.split("|");


                            switch (arrayloop[0])
                            {
                                case "DynaCAD Prostate - 1 User":
                                    dyncadcnt++;
                                    break;
                                case "DynaCAD Breast - 1 User":
                                    dyncadcnt++;
                                    break;
                                case "DynaCAD Combo Package - 1 User":
                                    dyncadcnt++;
                                    break;
                            }

                            if (arrayloop[0] == "DynaCAD Enterprise - Add_Users") {
                                //$("#txtConcurrent" + i)[0].value = enterpriseuser;
                                //$("#hidtxtConcurrent" + i)[0].value = enterpriseuser;
                                dycAddUserLocation = i;
                            }
                        }
                    }
                }

                if (dyncadcnt > 0) {
                    if (dycAddUserLocation > 0) {
                        if ($("#txtConcurrent" + dycAddUserLocation)[0].value != "") {
                            dyncadcnt = 4 - dyncadcnt;
                            $("#txtConcurrent" + dycAddUserLocation)[0].value = dyncadcnt;
                            $("#hidtxtConcurrent" + dycAddUserLocation)[0].value = dyncadcnt;
                            $("#txtConcurrent" + dycAddUserLocation)[0].max = dyncadcnt;                            
                        }
                    }
                }


                //checkallDynacad



                if (array[3] != "55") {
                    //Concurrent_Users
                    if (array[1] == "No") {

                        $("#txtConcurrent" + CurrentIDX)[0].disabled = true;
                    } else {
                        $("#txtConcurrent" + CurrentIDX)[0].disabled = false;
                    }
                }

                //Concurrent_Range - Max
                if (array[3] != "") {

                    if (Number.isInteger(array[3]) == true) {
                        $("#txtConcurrent" + CurrentIDX)[0].max = array[3];
                        $("#hidtxtConcurrent" + CurrentIDX)[0].max = array[3];
                    }

                }
                //txtConcurrent1

                // alert(array[0]);
                //alert(array[1]);

                GetLicenceData();
            }
        }

        function UpdateHospital(itemidx) {

            
            AddHospitalItem($("#txtHospitalName" + itemidx)[0].value, $("#txtHospitalName" + itemidx)[0].value)


            //txtHospitalName1

        }
        function AddHospitalItem(Text, Value) {

            var i;
            for (i = 1; i < 10; i++) {
                var optVal = document.createElement("option");
               
                document.getElementById("cmdHospitalName" + i).options.add(optVal);
                optVal.text = Text;
                optVal.value = Value;
            }

           

        }

        function AdditionalAppsAddSite() {
            let hidv = $("#hidadditionalapps")[0].value;

            $(".errortxtConcurrent").hide()

            hidv++;
            $("#hidadditionalapps")[0].value = hidv;

            $("#cmdApplication" + hidv).val('1');            
            $("#cmdApplication" + hidv).trigger('change');    

            switch (hidv) {
                  case 1:
                    $("#row1-additional-apps").show();                    
                     $("#txtConcurrent1")[0].readOnly = false;
                    break;
                case 2:
                    $("#row2-additional-apps").show();                    
                     $("#txtConcurrent2")[0].readOnly = false;
                    break;
                case 3:
                    $("#row2-additional-apps").show();
                    $("#row3-additional-apps").show();
                   
                    $("#txtConcurrent3")[0].readOnly = false;
                    break;
                case 4:
                    $("#row2-additional-apps").show();
                    $("#row3-additional-apps").show();
                    $("#row4-additional-apps").show();                   
                    $("#txtConcurrent4")[0].readOnly = false;
                    break;
                 case 5:
                    $("#row2-additional-apps").show();
                    $("#row3-additional-apps").show();
                    $("#row4-additional-apps").show();
                    $("#row5-additional-apps").show();
                    
                    $("#txtConcurrent5")[0].readOnly = false;

                    break;
                  case 6:
                    $("#row2-additional-apps").show();
                    $("#row3-additional-apps").show();
                    $("#row4-additional-apps").show();
                    $("#row5-additional-apps").show();
                    $("#row6-additional-apps").show();

             
                    $("#txtConcurrent6")[0].readOnly = false;

                    break;
                 case 7:
                    $("#row2-additional-apps").show();
                    $("#row3-additional-apps").show();
                    $("#row4-additional-apps").show();
                    $("#row5-additional-apps").show();
                    $("#row6-additional-apps").show();
                    $("#row7-additional-apps").show();

                     $("#txtConcurrent7")[0].readOnly = false;
                    break;
                 case 8:
                    $("#row2-additional-apps").show();
                    $("#row3-additional-apps").show();
                    $("#row4-additional-apps").show();
                    $("#row5-additional-apps").show();
                    $("#row6-additional-apps").show();
                    $("#row7-additional-apps").show();
                    $("#row8-additional-apps").show();
                     $("#txtConcurrent8")[0].readOnly = false;
                    break;
                 case 9:
                    $("#row2-additional-apps").show();
                    $("#row3-additional-apps").show();
                    $("#row4-additional-apps").show();
                    $("#row5-additional-apps").show();
                    $("#row6-additional-apps").show();
                    $("#row7-additional-apps").show();
                    $("#row8-additional-apps").show();
                    $("#row9-additional-apps").show();

                    $("#txtConcurrent9")[0].readOnly = false;

                    break;
                 case 10:
                    $("#row2-additional-apps").show();
                    $("#row3-additional-apps").show();
                    $("#row4-additional-apps").show();
                    $("#row5-additional-apps").show();
                    $("#row6-additional-apps").show();
                    $("#row7-additional-apps").show();
                    $("#row8-additional-apps").show();
                    $("#row9-additional-apps").show();
                    $("#row10-additional-apps").show();

                    $("#txtConcurrent10")[0].readOnly = false;

                    break;
                case 11:
                    $("#row2-additional-apps").show();
                    $("#row3-additional-apps").show();
                    $("#row4-additional-apps").show();
                    $("#row5-additional-apps").show();
                    $("#row6-additional-apps").show();
                    $("#row7-additional-apps").show();
                    $("#row8-additional-apps").show();
                    $("#row9-additional-apps").show();
                    $("#row10-additional-apps").show();
                    $("#row11-additional-apps").show();

                     $("#txtConcurrent11")[0].readOnly = false;

                    break;
                case 12:
                    $("#row2-additional-apps").show();
                    $("#row3-additional-apps").show();
                    $("#row4-additional-apps").show();
                    $("#row5-additional-apps").show();
                    $("#row6-additional-apps").show();
                    $("#row7-additional-apps").show();
                    $("#row8-additional-apps").show();
                    $("#row9-additional-apps").show();
                    $("#row10-additional-apps").show();
                    $("#row11-additional-apps").show();
                    $("#row12-additional-apps").show();

                     $("#txtConcurrent12")[0].readOnly = false;

                    break;
                case 13:
                    $("#row2-additional-apps").show();
                    $("#row3-additional-apps").show();
                    $("#row4-additional-apps").show();
                    $("#row5-additional-apps").show();
                    $("#row6-additional-apps").show();
                    $("#row7-additional-apps").show();
                    $("#row8-additional-apps").show();
                    $("#row9-additional-apps").show();
                    $("#row10-additional-apps").show();
                    $("#row11-additional-apps").show();
                    $("#row12-additional-apps").show();
                    $("#row13-additional-apps").show();

                    $("#txtConcurrent13")[0].readOnly = false;
                    break;
                case 14:
                    $("#row2-additional-apps").show();
                    $("#row3-additional-apps").show();
                    $("#row4-additional-apps").show();
                    $("#row5-additional-apps").show();
                    $("#row6-additional-apps").show();
                    $("#row7-additional-apps").show();
                    $("#row8-additional-apps").show();
                    $("#row9-additional-apps").show();
                    $("#row10-additional-apps").show();
                    $("#row11-additional-apps").show();
                    $("#row12-additional-apps").show();
                    $("#row13-additional-apps").show();
                    $("#row14-additional-apps").show();

                    $("#txtConcurrent14")[0].readOnly = false;

                    break;
                case 15:
                    $("#row2-additional-apps").show();
                    $("#row3-additional-apps").show();
                    $("#row4-additional-apps").show();
                    $("#row5-additional-apps").show();
                    $("#row6-additional-apps").show();
                    $("#row7-additional-apps").show();
                    $("#row8-additional-apps").show();
                    $("#row9-additional-apps").show();
                    $("#row10-additional-apps").show();
                    $("#row11-additional-apps").show();
                    $("#row12-additional-apps").show();
                    $("#row13-additional-apps").show();
                    $("#row14-additional-apps").show();
                    $("#row15-additional-apps").show();

                    $("#txtConcurrent15")[0].readOnly = false;

                    break;

            }

             GetLicenceData();
        }


        function deleteLicence(thisItem) {


            let currentValue = parseInt($('.ISPSoftwareOnly.active')[0].value);
            let HasTestServer = $("#cmdISPSoftwareYes").hasClass('active');
            currentValue = currentValue - 1;

            if (currentValue < 12) {

                $('.ISPSoftwareOnly.active').removeClass("active");
                $("#cmdISPSoftwareOnly" + currentValue).addClass("active");


                if (HasTestServer == true) {
                    // currentValue = currentValue - 1;
                    CreateRow(currentValue, $('#hidApplicationData').value, true, $('#hidMacTable')[0].value);
                } else {
                    CreateRow(currentValue, $('#hidApplicationData').value, false, $('#hidMacTable')[0].value);
                }

            } else {
                //alert('Maximum lines reached');
            }

        }

         function deleteLicencePro(thisItem) {



             let isPro = $("#HHNotPro").hasClass('active');
            let currentValue = 0;
            if (isPro == true) {
                currentValue = parseInt($('.ISPAdvancedlicense.active')[0].value);
            } else {
                currentValue = parseInt($('.ISPPremiumLicenseHW.active')[0].value);
            }



            let HasTestServer = $("#ISPTextLicenseRequiredYes").hasClass('active');
            currentValue = currentValue - 1;

            if (currentValue < 11) {
               
                if (isPro == false) {

                    
                    
                    $('.ISPPremiumLicenseHW.active').removeClass("active");
                    $("#ISPPremiumLicense" + currentValue).addClass("active");

                    if (HasTestServer == true) {
                          currentValue = currentValue - 1;
                        CreateRowPro(currentValue, $('#hidApplicationDataPro').value, true, $('#hidMacTablePro')[0].value, 1);
                    } else {
                        CreateRowPro(currentValue, $('#hidApplicationDataPro').value, false, $('#hidMacTablePro')[0].value, 1);
                    }

                    SetPremiumServers(currentValue);

                } else {


                    $('.ISPAdvancedlicense.active').removeClass("active");
                    $("#ISPAdvancedlicense" + currentValue).addClass("active");

                    if (HasTestServer == true) {
                          currentValue = currentValue - 1;
                        CreateRowPro(currentValue, $('#hidApplicationDataPro').value, true, $('#hidMacTablePro')[0].value, 0);
                    } else {
                        CreateRowPro(currentValue, $('#hidApplicationDataPro').value, false, $('#hidMacTablePro')[0].value, 0);
                    }


                    //SetPremiumServers(currentValue);

                }

            } else {
                alert('Maximum lines reached');
            }


        }


     

        function deleteAddtionalApp(thisItem) {

            let hidv = $("#hidadditionalapps")[0].value;
            hidv--;
            $("#hidadditionalapps")[0].value = hidv;
                        
            hidv = thisItem.id;
            hidv = parseInt(hidv.replace("cmdAddtionalAppDelete", ""));

            $("#cmdApplication"+hidv+"").val('1');
            //$("#cmdApplication"+hidv+"").trigger('change');            
            $("#txtConcurrent"+hidv+"")[0].value=""
            $("#row"+hidv+"-additional-apps").hide();
            $("#errortxtConcurrent"+hidv).hide();


            //reorder

            var i;
            var arrlist = [];
            for (i = 1; i <= 15; i++) {
                if (i <= 14) {
                    if ($("#cmdApplication" + i)[0].value != "") {

                        let itemline = i;
                        itemline += ":";
                        itemline += $("#cmdApplication" + (i))[0].value;
                        itemline += ":";
                        itemline += $("#txtConcurrent" + (i))[0].value;
                        itemline += ":";
                        itemline += $("#cmdHospitalName" + (i))[0].value;
                        arrlist.push(itemline);


                    }
                }
            }

            //blank all boxes

            for (var i = 1; i <= arrlist.length+1; i++) {

                $("#cmdApplication" + (i)).val("");
                $("#txtConcurrent" + (i))[0].value = "";
                $("#hidtxtConcurrent" + (i))[0].value = "";
                $("#cmdHospitalName" + (i))[0].value = "";
               // $("#cmdApplication" + (i)).trigger('change');
                $("#row" + i + "-additional-apps").hide();
                $("#txtConcurrent" + (i))[0].readOnly = false;
            }





            //rebuild

            for (var i = 0; i <= arrlist.length-1; i++) {
             
                    var res = arrlist[i].split(":");

                    $("#cmdApplication" + (i+1)).val(res[1]);
                    $("#txtConcurrent" + (i + 1))[0].value = res[2];
                    $("#hidtxtConcurrent" + (i + 1))[0].value = res[2];                
                    $("#cmdHospitalName" + (i+1))[0].value = res[3]
                    
                    if (!$("#cmdApplication" + (i + 1))[0].value.includes("Add_Users")) {

                        if ($("#cmdApplication" + (i + 1))[0].value.includes("Up to max of Enterprise concurrent users"))
                        {
                            $("#txtConcurrent" + (i + 1))[0].readOnly = false;
                        } else {
                            $("#txtConcurrent" + (i + 1))[0].readOnly = true;
                        }
                       
                    } else {
                        $("#txtConcurrent" + (i+1))[0].readOnly = false;
                    }

                    $("#row" + (i + 1) + "-additional-apps").show();

                    $("#cmdApplication" + (i + 1)).trigger('change');

            }

            $("#hidadditionalapps")[0].value = arrlist.length;
       

           // GetLicenceData();
        }


        function deleteHospital(thisItem) {

            let hidv = $("#hidCentralSite")[0].value;
            hidv--;
            $("#hidCentralSite")[0].value = hidv;


            hidv = thisItem.id;
            hidv = parseInt(hidv.replace("cmdHospitalDelete", ""));

            $("#row"+hidv+"-central").hide();


            $("#txtHospitalName" + hidv)[0].value = "";
            $("#txtHospitalStreet" + hidv)[0].value = "";

            
            //Save Order
            var i;
            var arrlist = [];
            for (i = 1; i <= 10; i++) {
                if (i <= 10) {
                    if ($("#txtHospitalName" + i)[0].value != "") {

                        let itemline = i;
                        itemline += ":";
                        itemline += $("#txtHospitalName" + (i))[0].value;
                        itemline += ":";
                        itemline += $("#txtHospitalStreet" + (i))[0].value;
                        itemline += ":";

                        if ($("#HospitalSite1ConnectivityHigh" + (i))[0].checked) {
                            itemline += "H";
                        }

                        if ($("#HospitalSite1ConnectivityMed" + (i))[0].checked) {
                            itemline += "M";
                        }

                        if ($("#HospitalSite1ConnectivityLow" + (i))[0].checked) {
                            itemline += "L";
                        }

                        arrlist.push(itemline);

                        
                    }
                }
            }                                                         
            //Save Order


            //blank all boxes

            for (var i = 1; i <= arrlist.length + 1; i++) {
                $("#txtHospitalName" + (i)).val("");
                $("#txtHospitalStreet" + (i))[0].value = "";
                $("#HospitalSite1ConnectivityHigh" + (i))[0].checked = true;         
                $("#row" + i + "-central").hide();
            }





            //rebuild

            for (var i = 0; i <= arrlist.length - 1; i++) {

                var res = arrlist[i].split(":");

                $("#txtHospitalName" + (i + 1)).val(res[1]);
                $("#txtHospitalStreet" + (i + 1))[0].value = res[2];

                if (res[3]=="H") {
                    $("#HospitalSite1ConnectivityHigh" + (i + 1) )[0].checked = true;
                }

                if (res[3] == "M") {
                    $("#HospitalSite1ConnectivityMed" + (i + 1))[0].checked = true;
                }

                if (res[3] == "L") {
                    $("#HospitalSite1ConnectivityLow" + (i + 1))[0].checked = true;
                }


                $("#row" + (i+1) + "-central").show();
                $("#hidCentralSite")[0].value = i;
        

            }

           
        }

        function CentralAddSite(skipincrement = false) {

            let hidv = $("#hidCentralSite")[0].value;
            if (skipincrement == true) {
                hidv++;
            }

            $("#hidCentralSite")[0].value = hidv;

            switch (parseInt(hidv)) {
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
                case 6:
                    $("#row2-central").show();
                    $("#row3-central").show();
                    $("#row4-central").show();
                    $("#row5-central").show();
                    $("#row6-central").show();
                    break;
                case 7:
                    $("#row2-central").show();
                    $("#row3-central").show();
                    $("#row4-central").show();
                    $("#row5-central").show();
                    $("#row6-central").show();
                    $("#row7-central").show();
                    break;
                case 8:
                    $("#row2-central").show();
                    $("#row3-central").show();
                    $("#row4-central").show();
                    $("#row5-central").show();
                    $("#row6-central").show();
                    $("#row7-central").show();
                    $("#row8-central").show();
                    break;
                case 9:
                    $("#row2-central").show();
                    $("#row3-central").show();
                    $("#row4-central").show();
                    $("#row5-central").show();
                    $("#row6-central").show();
                    $("#row7-central").show();
                    $("#row8-central").show();
                    $("#row9-central").show();
                    break;
                case 10:
                    $("#row2-central").show();
                    $("#row3-central").show();
                    $("#row4-central").show();
                    $("#row5-central").show();
                    $("#row6-central").show();
                    $("#row7-central").show();
                    $("#row8-central").show();
                    $("#row9-central").show();
                    $("#row10-central").show();
                    break;
            }
        }



        function GetLicenceData() {

            let enterpriseuser = $("#CONCURRENTENTERPRISEUSERS")[0].value;

            

            if (enterpriseuser > 50) {
                //alert("Concurrent users can not exceed 50");
                $("#CONCURRENTENTERPRISEUSERS")[0].value = 50;
                
                $("#CONCURRENTENTERPRISE_Error2").show();
            } else {
                 $("#CONCURRENTENTERPRISE_Error2").hide();
            }


            if (enterpriseuser < 11) {
                //alert("Concurrent users are not supported below 11");
                $("#CONCURRENTENTERPRISEUSERS")[0].value = 11;
                $("#CONCURRENTENTERPRISE_Error").show();
            } else {
                 $("#CONCURRENTENTERPRISE_Error").hide();
            }



            //update enterprise

            var i;
            for (i = 0; i < 10; i++) {
                if ($("#cmdApplication" + i)[0] != undefined && $("#cmdApplication" + i)[0].value !="" ) {
                    let appitem = $("#cmdApplication" + i)[0].value;
                    var array = $("#cmdApplication" + i)[0].value.split("|");
                    if (array[3] == "Up to max of Enterprise concurrent users") {
                        if ($("#txtConcurrent" + i)[0].value != "") {

                            $("#txtConcurrent" + i)[0].max = enterpriseuser;

                            if (parseInt($("#txtConcurrent" + i)[0].value) > parseInt(enterpriseuser)) {
                                $("#txtConcurrent" + i)[0].value = enterpriseuser;
                                $("#hidtxtConcurrent" + i)[0].value = enterpriseuser;
                            }

                            if (parseInt(enterpriseuser) < parseInt($("#txtConcurrent" + i)[0].max)) {
                               // $("#txtConcurrent" + i)[0].value = enterpriseuser;
                               // $("#hidtxtConcurrent" + i)[0].value = enterpriseuser;
                                $("#txtConcurrent" + i)[0].max = enterpriseuser;

                                if ($("#hidtxtConcurrent" + i)[0].value > enterpriseuser) {
                                    $("#txtConcurrent" + i)[0].value = enterpriseuser;
                                    $("#hidtxtConcurrent" + i)[0].value = enterpriseuser;
                                }

                            }


                        }
                    } else {

                        if ($("#txtConcurrent" + i)[0].value != "") {
                            if (array[2] == "") {
                                if (array[0].includes("Add_Users")) {


                                    switch (array[0]) {
                                        case "DynaCAD Enterprise - Add_Users":
                                            let usageCount = 0;

                                            var ix;
                                            for (ix = 1; ix <= 15; ix++) {
                                                if ($("#cmdApplication" + ix)[0].value.includes("DynaCAD Prostate - 1 User") | $("#cmdApplication" + ix)[0].value.includes("DynaCAD Breast - 1 User") | $("#cmdApplication" + ix)[0].value.includes("DynaCAD Combo Package - 1 User")) {

                                                    usageCount++;
                                                }
                                            }

                                            $("#txtConcurrent" + i)[0].min = 1;
                                            $("#txtConcurrent" + i)[0].max = (4 - usageCount);

                                            if ((4 - usageCount) > $("#txtConcurrent" + i)[0].value) {
                                                $("#txtConcurrent" + i)[0].value = (4 - usageCount);
                                                $("#hidtxtConcurrent" + i)[0].value = (4 - usageCount);
                                            }

                                            break;
                                        case "Zero FootPrint Viewer SW - Add_Users":
                                            $("#txtConcurrent" + i)[0].min = 1;
                                            $("#txtConcurrent" + i)[0].max = 53;
                                            break;
                                        default:
                                            $("#txtConcurrent" + i)[0].max = enterpriseuser - 1;
                                            if (enterpriseuser - 1 < $("#txtConcurrent" + i)[0].value) {
                                                $("#txtConcurrent" + i)[0].value = enterpriseuser - 1;
                                                $("#hidtxtConcurrent" + i)[0].value = enterpriseuser - 1;
                                            }
                                            break;
                                    }

                                }
                            } else {
                                if (array[2] == "Enterprise") {

                                    $("#txtConcurrent" + i)[0].max = enterpriseuser;

                                    if (parseInt(enterpriseuser) <= parseInt($("#txtConcurrent" + i)[0].max)) {
                                        $("#txtConcurrent" + i)[0].value = enterpriseuser;
                                        $("#hidtxtConcurrent" + i)[0].value = enterpriseuser;
                                        $("#txtConcurrent" + i)[0].max = enterpriseuser;
                                    }
                                }
                            }

                        }
                    }
                }
            }






            let IsTest = false;

            let selectedapplication = "";
            let selectedapplication1 = $("#cmdApplication1")[0].value + "?" + $("#txtConcurrent1")[0].value;
            let selectedapplication2 = $("#cmdApplication2")[0].value + "?" + $("#txtConcurrent2")[0].value;
            let selectedapplication3 = $("#cmdApplication3")[0].value + "?" + $("#txtConcurrent3")[0].value;
            let selectedapplication4 = $("#cmdApplication4")[0].value + "?" + $("#txtConcurrent4")[0].value;
            let selectedapplication5 = $("#cmdApplication5")[0].value + "?" + $("#txtConcurrent5")[0].value;
            let selectedapplication6 = $("#cmdApplication6")[0].value + "?" + $("#txtConcurrent6")[0].value;
            let selectedapplication7 = $("#cmdApplication7")[0].value + "?" + $("#txtConcurrent7")[0].value;
            let selectedapplication8 = $("#cmdApplication8")[0].value + "?" + $("#txtConcurrent8")[0].value;
            let selectedapplication9 = $("#cmdApplication9")[0].value + "?" + $("#txtConcurrent9")[0].value;
            let selectedapplication10 = $("#cmdApplication10")[0].value + "?" + $("#txtConcurrent10")[0].value;
            let selectedapplication11 = $("#cmdApplication11")[0].value + "?" + $("#txtConcurrent11")[0].value;
            let selectedapplication12 = $("#cmdApplication12")[0].value + "?" + $("#txtConcurrent12")[0].value;
            let selectedapplication13 = $("#cmdApplication13")[0].value + "?" + $("#txtConcurrent13")[0].value;
            let selectedapplication14 = $("#cmdApplication14")[0].value + "?" + $("#txtConcurrent14")[0].value;
            let selectedapplication15 = $("#cmdApplication15")[0].value + "?" + $("#txtConcurrent15")[0].value;


            //if (selectedapplication1 != "?") {

            selectedapplication = selectedapplication1 + "~" + selectedapplication2 + "~" + selectedapplication3 + "~" + selectedapplication4 + "~" + selectedapplication5 + "~" + selectedapplication6 + "~" + selectedapplication7 + "~" + selectedapplication8 + "~" + selectedapplication9 + "~" + selectedapplication10 + "~" + selectedapplication11 + "~" + selectedapplication12 + "~" + selectedapplication13 + "~" + selectedapplication14 + "~" + selectedapplication15;

            var myKeyVals = { enterpriseuser: enterpriseuser, selectedapplication: selectedapplication, enterpriseuser: enterpriseuser }

            //$.ajax('./apidata',
            $.ajax(sapidata,
                {
                    type: 'POST',
                    data: myKeyVals,
                    dataType: 'json', // type of response data
                    //timeout: 5000,     // timeout milliseconds
                    success: function (data, status, xhr) {   // success callback function

                        $('#hidLicenceData')[0].value = data.licence;
                        $('#hidApplicationData')[0].value = data.application;

                        $('#hidConcurrent_Default')[0].value = data.Concurrent_Default;
                        $('#hidConcurrent_Range')[0].value = data.Concurrent_Range;
                        


                        console.log("data.licence:" + data.licence);
                        console.log("data.Name:" + data.application);

                        if ($("#cmdISPSoftwareYes").hasClass('active')) {
                            //data.licence = parseInt(data.licence) + 1;
                            IsTest = true;
                        }

                        let maclist = $('#hidMacTable')[0].value;

                        $("#cmdISPSoftwareOnly11").prop('disabled', false);
                        $("#cmdISPSoftwareOnly10").prop('disabled', false);
                        $("#cmdISPSoftwareOnly9").prop('disabled', false);
                        $("#cmdISPSoftwareOnly8").prop('disabled', false);
                        $("#cmdISPSoftwareOnly7").prop('disabled', false);
                        $("#cmdISPSoftwareOnly6").prop('disabled', false);
                        $("#cmdISPSoftwareOnly5").prop('disabled', false);
                        $("#cmdISPSoftwareOnly4").prop('disabled', false);
                        $("#cmdISPSoftwareOnly3").prop('disabled', false);
                        $("#cmdISPSoftwareOnly2").prop('disabled', false);
                        $("#cmdISPSoftwareOnly1").prop('disabled', false);


                        switch (data.licence.toString()) {
                            case "1":
                                $('.ISPSoftwareOnly.active').removeClass("active");

                                $("#cmdISPSoftwareOnly1").addClass("active");

                                CreateRow(data.licence, data.application, IsTest, maclist)
                                break;
                            case "2":
                                $('.ISPSoftwareOnly.active').removeClass("active");

                                $("#cmdISPSoftwareOnly2").addClass("active");
                                $("#cmdISPSoftwareOnly1").prop('disabled', true);

                                CreateRow(data.licence, data.application, IsTest, maclist)
                                break;
                            case "3":
                                $('.ISPSoftwareOnly.active').removeClass("active");

                                $("#cmdISPSoftwareOnly3").addClass("active");

                                $("#cmdISPSoftwareOnly2").prop('disabled', true);
                                $("#cmdISPSoftwareOnly1").prop('disabled', true);

                                CreateRow(data.licence, data.application, IsTest, maclist)
                                break;
                            case "4":
                                $('.ISPSoftwareOnly.active').removeClass("active");

                                $("#cmdISPSoftwareOnly4").addClass("active");

                                $("#cmdISPSoftwareOnly3").prop('disabled', true);
                                $("#cmdISPSoftwareOnly2").prop('disabled', true);
                                $("#cmdISPSoftwareOnly1").prop('disabled', true);

                                CreateRow(data.licence, data.application, IsTest, maclist)
                                break;
                            case "5":
                                $('.ISPSoftwareOnly.active').removeClass("active");
                                $("#cmdISPSoftwareOnly5").addClass("active");

                                $("#cmdISPSoftwareOnly4").prop('disabled', true);
                                $("#cmdISPSoftwareOnly3").prop('disabled', true);
                                $("#cmdISPSoftwareOnly2").prop('disabled', true);
                                $("#cmdISPSoftwareOnly1").prop('disabled', true);

                                CreateRow(data.licence, data.application, IsTest, maclist)
                                break;
                            case "6":
                                $('.ISPSoftwareOnly.active').removeClass("active");
                                $("#cmdISPSoftwareOnly6").addClass("active");
                                $("#cmdISPSoftwareOnly5").prop('disabled', true);
                                $("#cmdISPSoftwareOnly4").prop('disabled', true);
                                $("#cmdISPSoftwareOnly3").prop('disabled', true);
                                $("#cmdISPSoftwareOnly2").prop('disabled', true);
                                $("#cmdISPSoftwareOnly1").prop('disabled', true);

                                CreateRow(data.licence, data.application, IsTest, maclist)
                                break;
                            case "7":
                                $('.ISPSoftwareOnly.active').removeClass("active");

                                $("#cmdISPSoftwareOnly7").addClass("active");

                                $("#cmdISPSoftwareOnly6").prop('disabled', true);
                                $("#cmdISPSoftwareOnly5").prop('disabled', true);
                                $("#cmdISPSoftwareOnly4").prop('disabled', true);
                                $("#cmdISPSoftwareOnly3").prop('disabled', true);
                                $("#cmdISPSoftwareOnly2").prop('disabled', true);
                                $("#cmdISPSoftwareOnly1").prop('disabled', true);

                                CreateRow(data.licence, data.application, IsTest, maclist)
                                break;
                            case "8":
                                $('.ISPSoftwareOnly.active').removeClass("active");

                                $("#cmdISPSoftwareOnly8").addClass("active");

                                $("#cmdISPSoftwareOnly7").prop('disabled', true);
                                $("#cmdISPSoftwareOnly6").prop('disabled', true);
                                $("#cmdISPSoftwareOnly5").prop('disabled', true);
                                $("#cmdISPSoftwareOnly4").prop('disabled', true);
                                $("#cmdISPSoftwareOnly3").prop('disabled', true);
                                $("#cmdISPSoftwareOnly2").prop('disabled', true);
                                $("#cmdISPSoftwareOnly1").prop('disabled', true);

                                CreateRow(data.licence, data.application, IsTest, maclist)
                                break;
                            case "9":
                                $('.ISPSoftwareOnly.active').removeClass("active");

                                $("#cmdISPSoftwareOnly9").addClass("active");

                                $("#cmdISPSoftwareOnly8").prop('disabled', true);
                                $("#cmdISPSoftwareOnly7").prop('disabled', true);
                                $("#cmdISPSoftwareOnly6").prop('disabled', true);
                                $("#cmdISPSoftwareOnly5").prop('disabled', true);
                                $("#cmdISPSoftwareOnly4").prop('disabled', true);
                                $("#cmdISPSoftwareOnly3").prop('disabled', true);
                                $("#cmdISPSoftwareOnly2").prop('disabled', true);
                                $("#cmdISPSoftwareOnly1").prop('disabled', true);

                                CreateRow(data.licence, data.application, IsTest, maclist)
                                break;
                            case "10":
                                $('.ISPSoftwareOnly.active').removeClass("active");

                                $("#cmdISPSoftwareOnly10").addClass("active");


                                $("#cmdISPSoftwareOnly9").prop('disabled', true);
                                $("#cmdISPSoftwareOnly8").prop('disabled', true);
                                $("#cmdISPSoftwareOnly7").prop('disabled', true);
                                $("#cmdISPSoftwareOnly6").prop('disabled', true);
                                $("#cmdISPSoftwareOnly5").prop('disabled', true);
                                $("#cmdISPSoftwareOnly4").prop('disabled', true);
                                $("#cmdISPSoftwareOnly3").prop('disabled', true);
                                $("#cmdISPSoftwareOnly2").prop('disabled', true);
                                $("#cmdISPSoftwareOnly1").prop('disabled', true);

                                CreateRow(data.licence, data.application, IsTest, maclist)
                                break;
                            case "11":
                                $('.ISPSoftwareOnly.active').removeClass("active");

                                $("#cmdISPSoftwareOnly11").addClass("active");

                                $("#cmdISPSoftwareOnly10").prop('disabled', true);
                                $("#cmdISPSoftwareOnly9").prop('disabled', true);
                                $("#cmdISPSoftwareOnly8").prop('disabled', true);
                                $("#cmdISPSoftwareOnly7").prop('disabled', true);
                                $("#cmdISPSoftwareOnly6").prop('disabled', true);
                                $("#cmdISPSoftwareOnly5").prop('disabled', true);
                                $("#cmdISPSoftwareOnly4").prop('disabled', true);
                                $("#cmdISPSoftwareOnly3").prop('disabled', true);
                                $("#cmdISPSoftwareOnly2").prop('disabled', true);
                                $("#cmdISPSoftwareOnly1").prop('disabled', true);

                                CreateRow(data.licence, data.application, IsTest, maclist)
                                break;
                        }

                        $('#hidISPSoftwareOnly')[0].value = data.licence;


                        storeCurrentMac();
                         GetProData();

                    },
                    error: function (jqXhr, textStatus, errorMessage) { // error callback                     
                        alert(errorMessage);
                    }
                });


            //}




           

        }
        function ispSoftwarePre(typeButton, currentButton) {


            //$('.hidLicenceData').value = data.licence;
            //$('.hidApplicationData').value = data.application;
            let abort = true;


            if (typeButton == "NO") {
                if (typeButton == "NO" & $("#ISPTestLicenseHWNo").hasClass('active') == true) {
                    abort = true;
                } else {
                    abort = false;
                }
            }


            if (typeButton == "YES") {
                if (typeButton == "YES" & $("#ISPTestLicenseHWYes").hasClass('active') == true) {
                    abort = true;
                } else {
                    abort = false;
                }
            }


            if (abort == false) {
                let currentValue = parseInt($('.ISPPremiumLicenseHW.active')[0].value);
               // $('.ISPPremiumLicenseHW.active').removeClass("active");

                if (typeButton == "YES") {

                    currentValue = currentValue + 1;
                    //$("#ISPPremiumLicense" + currentValue).addClass("active");

                    CreateRowPro(currentValue, $('#hidLicenceDataPro2').value, true, $('#hidMacTablePro')[0].value)


                } else {

                   // currentValue = currentValue - 1;
                   // $("#ISPPremiumLicense" + currentValue).addClass("active");
                    CreateRowPro(currentValue, $('#hidLicenceDataPro2').value, false, $('#hidMacTablePro')[0].value)
                }

            }

        }
        function ispSoftwarePro(typeButton, currentButton) {


            //$('.hidLicenceData').value = data.licence;
            //$('.hidApplicationData').value = data.application;
            let abort = true;


            if (typeButton == "NO") {
                if (typeButton == "NO" & $("#ISPTextLicenseRequiredNo").hasClass('active') == true) {
                    abort = true;
                } else {
                    abort = false;
                }
            }


            if (typeButton == "YES") {
                if (typeButton == "YES" & $("#ISPTextLicenseRequiredYes").hasClass('active') == true) {
                    abort = true;
                } else {
                    abort = false;
                }
            }


            if (abort == false) {
                let currentValue = parseInt($('.ISPAdvancedlicense.active')[0].value);
               // $('.ISPAdvancedlicense.active').removeClass("active");

                if (typeButton == "YES") {

                    currentValue = currentValue + 1;
                    //$("#ISPAdvancedlicense" + currentValue).addClass("active");

                    CreateRowPro(currentValue, $('#hidApplicationDataPro').value, true, $('#hidMacTablePro')[0].value)


                } else {

                    //currentValue = currentValue - 1;
                    //$("#ISPAdvancedlicense" + currentValue).addClass("active");
                    CreateRowPro(currentValue, $('#hidApplicationDataPro').value, false, $('#hidMacTablePro')[0].value)
                }

            }

        }
        function ispSoftware(typeButton, currentButton) {


            //$('.hidLicenceData').value = data.licence;
            //$('.hidApplicationData').value = data.application;
            let abort = true;


            if (typeButton == "NO") {
                if (typeButton == "NO" & $("#cmdISPSoftwareNo").hasClass('active') == true) {
                    abort = true;
                } else {
                    abort = false;
                }
            }


            if (typeButton == "YES") {
                if (typeButton == "YES" & $("#cmdISPSoftwareYes").hasClass('active') == true) {
                    abort = true;
                } else {
                    abort = false;
                }
            }


            if (abort == false) {
                let currentValue = parseInt($('.ISPSoftwareOnly.active')[0].value);
                // $('.ISPSoftwareOnly.active').removeClass("active");

                if (typeButton == "YES") {

                   // currentValue = currentValue + 1;
                    // $("#cmdISPSoftwareOnly" + currentValue).addClass("active");

                    CreateRow(currentValue, $('#hidApplicationData').value, true, $('#hidMacTable')[0].value)


                } else {

                    //currentValue = currentValue - 1;
                    // $("#cmdISPSoftwareOnly" + currentValue).addClass("active");
                    CreateRow(currentValue, $('#hidApplicationData').value, false, $('#hidMacTable')[0].value)
                }

            }

        }


        function SHPreDisplay(isShow) {

            if (isShow == 1) {
                $(".STBAddStorage").removeClass("active");
                $(".ISPTextLicenseRequired").removeClass("active");
                $(".ISPEnterprisetestlicense").removeClass("active");
                $(".ISPAdvancedlicense").removeClass("active");







                $("#STBAddStorageNo").prop('disabled', true);
                $("#STBAddStorageNo").css('color', 'grey');


                $("#STBAddStorageLabel").css('color', '#d2dee5');

                $("#STBAddStorageYes").prop('disabled', true);
                $("#STBAddStorageYes").css('color', 'grey');

                $("#ISPTextLicenseRequiredNo").prop('disabled', true);
                $("#ISPTextLicenseRequiredNo").css('color', 'grey');

                $("#ISPTextLicenseRequiredYes").prop('disabled', true);
                $("#ISPTextLicenseRequiredYes").css('color', 'grey');

                $("#ISPEnterprisetestlicenseNo").prop('disabled', true);
                $("#ISPEnterprisetestlicenseNo").css('color', 'grey');

                $("#ISPEnterprisetestlicenseYes").prop('disabled', true);
                $("#ISPEnterprisetestlicenseYes").css('color', 'grey');

                $("#ISPAdvancedlicense1").prop('disabled', true);
                $("#ISPAdvancedlicense1").css('color', 'grey');

                $("#ISPAdvancedlicense2").prop('disabled', true);
                $("#ISPAdvancedlicense2").css('color', 'grey');

                $("#ISPAdvancedlicense3").prop('disabled', true);
                $("#ISPAdvancedlicense3").css('color', 'grey');

                $("#ISPAdvancedlicense4").prop('disabled', true);
                $("#ISPAdvancedlicense4").css('color', 'grey');

                $("#ISPAdvancedlicense5").prop('disabled', true);
                $("#ISPAdvancedlicense5").css('color', 'grey');





                $("#ISPTextLicenseRequiredLabel").css('color', '#d2dee5');
                $("#ISPEnterprisetestlicenseLabel").css('color', '#d2dee5');
                $("#ISPAdvancedlicenseLabel").css('color', '#d2dee5');

                $('.Philipsprovidestorage.active').removeClass("active");
                $("#PhilipsprovidestorageNo").addClass("active");
                $("#premTotalStorageRequiredROW").hide();

                $("#ISPTestLicenseHWNo").addClass("active");

                $('.HHAopt.active').removeClass("active");
                $("#HHNotPrem").addClass("active");

                
                //pro licences
                currentValue = $('#hidLicenceDataPro2')[0].value;
                $('.ISPPremiumLicenseHW.active').removeClass("active");
                $("#ISPPremiumLicense" + currentValue).addClass("active");


               //licence table
                $("#hidManualISPPro")[0].value = currentValue;
                let HasTestServer = $("#ISPTextLicenseRequiredYes").hasClass('active');

                if (HasTestServer == true) {
                    currentValue++;
                }

                if (HasTestServer == true) {
                    CreateRowPro(currentValue, $('#hidApplicationDataPro').value, true, $('#hidMacTablePro')[0].value,1);
                } else {
                    CreateRowPro(currentValue, $('#hidApplicationDataPro').value, false, $('#hidMacTablePro')[0].value,1);
                }


                //servers              
                let maclist = $('#hidMacTablePro')[0].value;
                 $('.AdditionalhostserverHW.active').removeClass("active");
                SetUpPrelicences2(currentValue, HasTestServer, maclist);



            } else {


                $("#STBAddStorageNo").prop('disabled', false);
                $("#STBAddStorageNo").css('color', 'black');

                $("#ISPTextLicenseRequiredNo").prop('disabled', false);
                $("#ISPTextLicenseRequiredNo").css('color', 'black');

                $("#ISPTextLicenseRequiredYes").prop('disabled', false);
                $("#ISPTextLicenseRequiredYes").css('color', 'black');


                $("#STBAddStorageYes").prop('disabled', false);
                $("#STBAddStorageYes").css('color', 'black');

                $('#STBAddStorageLabel').css('color', '#333');
                $("#ISPTextLicenseRequiredLabel").css('color', '#333');
                $("#ISPEnterprisetestlicenseLabel").css('color', '#333');
                $("#ISPAdvancedlicenseLabel").css('color', '#333');

                $("#ISPEnterprisetestlicenseNo").prop('disabled', false);
                $("#ISPEnterprisetestlicenseNo").css('color', 'black');

                $("#ISPEnterprisetestlicenseYes").prop('disabled', false);
                $("#ISPEnterprisetestlicenseYes").css('color', 'black');


                $("#ISPAdvancedlicense1").prop('disabled', false);
                $("#ISPAdvancedlicense1").css('color', 'black');

                $("#ISPAdvancedlicense2").prop('disabled', false);
                $("#ISPAdvancedlicense2").css('color', 'black');

                $("#ISPAdvancedlicense3").prop('disabled', false);
                $("#ISPAdvancedlicense3").css('color', 'black');

                $("#ISPAdvancedlicense4").prop('disabled', false);
                $("#ISPAdvancedlicense4").css('color', 'black');

                $("#ISPAdvancedlicense5").prop('disabled', false);
                $("#ISPAdvancedlicense5").css('color', 'black');
                $('.Philipsprovidestorage.active').removeClass("active");

                $('.ISPTestLicenseHW.active').removeClass("active");

            }

        }



        function SHFullPreDisplay(isShow) {

            if (isShow == 1) {
                $(".STBAddStorage").removeClass("active");
                $(".ISPTextLicenseRequired").removeClass("active");
                $(".ISPEnterprisetestlicense").removeClass("active");
                $(".ISPAdvancedlicense").removeClass("active");

                                                                      
                $("#STBAddStorageNo").prop('disabled', true);
                $("#STBAddStorageNo").css('color', 'grey');


                $("#STBAddStorageLabel").css('color', '#d2dee5');

                $("#STBAddStorageYes").prop('disabled', true);
                $("#STBAddStorageYes").css('color', 'grey');

                $("#ISPTextLicenseRequiredNo").prop('disabled', true);
                $("#ISPTextLicenseRequiredNo").css('color', 'grey');

                $("#ISPTextLicenseRequiredYes").prop('disabled', true);
                $("#ISPTextLicenseRequiredYes").css('color', 'grey');

                $("#ISPEnterprisetestlicenseNo").prop('disabled', true);
                $("#ISPEnterprisetestlicenseNo").css('color', 'grey');

                $("#ISPEnterprisetestlicenseYes").prop('disabled', true);
                $("#ISPEnterprisetestlicenseYes").css('color', 'grey');

                $("#ISPAdvancedlicense1").prop('disabled', true);
                $("#ISPAdvancedlicense1").css('color', 'grey');

                $("#ISPAdvancedlicense2").prop('disabled', true);
                $("#ISPAdvancedlicense2").css('color', 'grey');

                $("#ISPAdvancedlicense3").prop('disabled', true);
                $("#ISPAdvancedlicense3").css('color', 'grey');

                $("#ISPAdvancedlicense4").prop('disabled', true);
                $("#ISPAdvancedlicense4").css('color', 'grey');

                $("#ISPAdvancedlicense5").prop('disabled', true);
                $("#ISPAdvancedlicense5").css('color', 'grey');


                //reset
                $(".Philipsprovidestorage").prop('disabled', false);
                $(".Philipsprovidestorage").css('color', 'black');

                $(".AdditionalStorageRequiredHW").prop('disabled', false);
                $(".AdditionalStorageRequiredHW").css('color', 'black');

               // $(".AdditionalhostserverHW").prop('disabled', false);
                $(".AdditionalhostserverHW").css('color', 'black');

                $(".ISPPremiumLicenseHW").prop('disabled', false);
                $(".ISPPremiumLicenseHW").css('color', 'black');

                $(".ISPTestLicenseHW").prop('disabled', false);
                $(".ISPTestLicenseHW").css('color', 'black');

                $("#prelabel1").css('color', '#333');
                $("#prelabel2").css('color', '#333');
                $("#prelabel3").css('color', '#333');
                $("#prelabel4").css('color', '#333');
                $("#prelabel5").css('color', '#333');
                //


                $("#ISPTextLicenseRequiredLabel").css('color', '#d2dee5');
                $("#ISPEnterprisetestlicenseLabel").css('color', '#d2dee5');
                $("#ISPAdvancedlicenseLabel").css('color', '#d2dee5');


               


                $("#ISPTextLicenseRequiredLabel").css('color', '#d2dee5');
                $("#ISPEnterprisetestlicenseLabel").css('color', '#d2dee5');
                $("#ISPAdvancedlicenseLabel").css('color', '#d2dee5');

                $('.Philipsprovidestorage.active').removeClass("active");
                $("#PhilipsprovidestorageNo").addClass("active");
                $("#premTotalStorageRequiredROW").hide();

                $("#ISPTestLicenseHWNo").addClass("active");



                 //SHFullPartalDisplay
                        //$('#parial_ha')[0].value = data.parial_ha;
                        //$('#full_ha')[0].value = data.full_ha;
                        //$('#server_ha_partial')[0].value = data.server_ha_partial;
                        //$('#server_ha_full')[0].value = data.server_ha_full;


                
                //pro licences
                currentValue = $('#hidLicenceDataPro2')[0].value;
                $('.ISPPremiumLicenseHW.active').removeClass("active");
                $("#ISPPremiumLicense" + currentValue).addClass("active");


               //licence table
                $("#hidManualISPPro")[0].value = currentValue;
                let HasTestServer = $("#ISPTestLicenseHWYes").hasClass('active');

                if (HasTestServer == true) {
                    currentValue++;
                }

                if (HasTestServer == true) {
                    CreateRowPro(currentValue, $('#hidApplicationDataPro').value, true, $('#hidMacTablePro')[0].value);
                } else {
                    CreateRowPro(currentValue, $('#hidApplicationDataPro').value, false, $('#hidMacTablePro')[0].value);
                }


                //servers              
                //let maclist = $('#hidMacTablePro')[0].value;
                $('.AdditionalhostserverHW.active').removeClass("active");
                $("#Additionalhostserver" + $('#server_ha_full')[0].value).addClass("active");
               // SetUpPrelicences2(currentValue, HasTestServer, maclist);



            } else {


                $("#STBAddStorageNo").prop('disabled', false);
                $("#STBAddStorageNo").css('color', 'black');

                $("#ISPTextLicenseRequiredNo").prop('disabled', false);
                $("#ISPTextLicenseRequiredNo").css('color', 'black');

                $("#ISPTextLicenseRequiredYes").prop('disabled', false);
                $("#ISPTextLicenseRequiredYes").css('color', 'black');


                $("#STBAddStorageYes").prop('disabled', false);
                $("#STBAddStorageYes").css('color', 'black');

                $('#STBAddStorageLabel').css('color', '#333');
                $("#ISPTextLicenseRequiredLabel").css('color', '#333');
                $("#ISPEnterprisetestlicenseLabel").css('color', '#333');
                $("#ISPAdvancedlicenseLabel").css('color', '#333');

                $("#ISPEnterprisetestlicenseNo").prop('disabled', false);
                $("#ISPEnterprisetestlicenseNo").css('color', 'black');

                $("#ISPEnterprisetestlicenseYes").prop('disabled', false);
                $("#ISPEnterprisetestlicenseYes").css('color', 'black');


                $("#ISPAdvancedlicense1").prop('disabled', false);
                $("#ISPAdvancedlicense1").css('color', 'black');

                $("#ISPAdvancedlicense2").prop('disabled', false);
                $("#ISPAdvancedlicense2").css('color', 'black');

                $("#ISPAdvancedlicense3").prop('disabled', false);
                $("#ISPAdvancedlicense3").css('color', 'black');

                $("#ISPAdvancedlicense4").prop('disabled', false);
                $("#ISPAdvancedlicense4").css('color', 'black');

                $("#ISPAdvancedlicense5").prop('disabled', false);
                $("#ISPAdvancedlicense5").css('color', 'black');
                $('.Philipsprovidestorage.active').removeClass("active");

                $('.ISPTestLicenseHW.active').removeClass("active");

            }

        }

        //partial
        function SHFullPartalDisplay(isShow) {

            if (isShow == 1) {
                $(".STBAddStorage").removeClass("active");
                $(".ISPTextLicenseRequired").removeClass("active");
                $(".ISPEnterprisetestlicense").removeClass("active");
                $(".ISPAdvancedlicense").removeClass("active");




                 $("#STBAddStorageNo").prop('disabled', true);
                $("#STBAddStorageNo").css('color', 'grey');


                $("#STBAddStorageLabel").css('color', '#d2dee5');

                $("#STBAddStorageYes").prop('disabled', true);
                $("#STBAddStorageYes").css('color', 'grey');

                $("#ISPTextLicenseRequiredNo").prop('disabled', true);
                $("#ISPTextLicenseRequiredNo").css('color', 'grey');

                $("#ISPTextLicenseRequiredYes").prop('disabled', true);
                $("#ISPTextLicenseRequiredYes").css('color', 'grey');

                $("#ISPEnterprisetestlicenseNo").prop('disabled', true);
                $("#ISPEnterprisetestlicenseNo").css('color', 'grey');

                $("#ISPEnterprisetestlicenseYes").prop('disabled', true);
                $("#ISPEnterprisetestlicenseYes").css('color', 'grey');

                $("#ISPAdvancedlicense1").prop('disabled', true);
                $("#ISPAdvancedlicense1").css('color', 'grey');

                $("#ISPAdvancedlicense2").prop('disabled', true);
                $("#ISPAdvancedlicense2").css('color', 'grey');

                $("#ISPAdvancedlicense3").prop('disabled', true);
                $("#ISPAdvancedlicense3").css('color', 'grey');

                $("#ISPAdvancedlicense4").prop('disabled', true);
                $("#ISPAdvancedlicense4").css('color', 'grey');

                $("#ISPAdvancedlicense5").prop('disabled', true);
                $("#ISPAdvancedlicense5").css('color', 'grey');





                $("#ISPTextLicenseRequiredLabel").css('color', '#d2dee5');
                $("#ISPEnterprisetestlicenseLabel").css('color', '#d2dee5');
                $("#ISPAdvancedlicenseLabel").css('color', '#d2dee5');

                $('.Philipsprovidestorage.active').removeClass("active");
                $("#PhilipsprovidestorageNo").addClass("active");
                $("#premTotalStorageRequiredROW").hide();

                $("#ISPTestLicenseHWNo").addClass("active");



                 //SHFullPartalDisplay
                        //$('#parial_ha')[0].value = data.parial_ha;
                        //$('#full_ha')[0].value = data.full_ha;
                        //$('#server_ha_partial')[0].value = data.server_ha_partial;
                        //$('#server_ha_full')[0].value = data.server_ha_full;


                
                //pro licences
                currentValue = $('#hidLicenceDataPro2')[0].value;
                $('.ISPPremiumLicenseHW.active').removeClass("active");
                $("#ISPPremiumLicense" + currentValue).addClass("active");


               //licence table
                $("#hidManualISPPro")[0].value = currentValue;
                let HasTestServer = $("#ISPTestLicenseHWYes").hasClass('active');

                if (HasTestServer == true) {
                    currentValue++;
                }

                if (HasTestServer == true) {
                    CreateRowPro(currentValue, $('#hidApplicationDataPro').value, true, $('#hidMacTablePro')[0].value,1);
                } else {
                    CreateRowPro(currentValue, $('#hidApplicationDataPro').value, false, $('#hidMacTablePro')[0].value,1);
                }


                //servers              
                //let maclist = $('#hidMacTablePro')[0].value;
                $('.AdditionalhostserverHW.active').removeClass("active");
                $("#Additionalhostserver" + $('#server_ha_partial')[0].value).addClass("active");
               // SetUpPrelicences2(currentValue, HasTestServer, maclist);



            } else {


                $("#STBAddStorageNo").prop('disabled', false);
                $("#STBAddStorageNo").css('color', 'black');

                $("#ISPTextLicenseRequiredNo").prop('disabled', false);
                $("#ISPTextLicenseRequiredNo").css('color', 'black');

                $("#ISPTextLicenseRequiredYes").prop('disabled', false);
                $("#ISPTextLicenseRequiredYes").css('color', 'black');


                $("#STBAddStorageYes").prop('disabled', false);
                $("#STBAddStorageYes").css('color', 'black');

                $('#STBAddStorageLabel').css('color', '#333');
                $("#ISPTextLicenseRequiredLabel").css('color', '#333');
                $("#ISPEnterprisetestlicenseLabel").css('color', '#333');
                $("#ISPAdvancedlicenseLabel").css('color', '#333');

                $("#ISPEnterprisetestlicenseNo").prop('disabled', false);
                $("#ISPEnterprisetestlicenseNo").css('color', 'black');

                $("#ISPEnterprisetestlicenseYes").prop('disabled', false);
                $("#ISPEnterprisetestlicenseYes").css('color', 'black');


                $("#ISPAdvancedlicense1").prop('disabled', false);
                $("#ISPAdvancedlicense1").css('color', 'black');

                $("#ISPAdvancedlicense2").prop('disabled', false);
                $("#ISPAdvancedlicense2").css('color', 'black');

                $("#ISPAdvancedlicense3").prop('disabled', false);
                $("#ISPAdvancedlicense3").css('color', 'black');

                $("#ISPAdvancedlicense4").prop('disabled', false);
                $("#ISPAdvancedlicense4").css('color', 'black');

                $("#ISPAdvancedlicense5").prop('disabled', false);
                $("#ISPAdvancedlicense5").css('color', 'black');
                $('.Philipsprovidestorage.active').removeClass("active");

                $('.ISPTestLicenseHW.active').removeClass("active");

            }
           

        }





        function SHProDisplay(isShow) {

            if (isShow == 1) {
                $(".Philipsprovidestorage").removeClass("active");
                $(".AdditionalStorageRequiredHW").removeClass("active");
                $(".AdditionalhostserverHW").removeClass("active");
                $(".ISPPremiumLicenseHW").removeClass("active");
                $(".ISPTestLicenseHW").removeClass("active");


                $(".Philipsprovidestorage").prop('disabled', true);
                $(".Philipsprovidestorage").css('color', 'grey');

                $(".AdditionalStorageRequiredHW").prop('disabled', true);
                $(".AdditionalStorageRequiredHW").css('color', 'grey');

               // $(".AdditionalhostserverHW").prop('disabled', true);
                $(".AdditionalhostserverHW").css('color', 'grey');

                $(".ISPPremiumLicenseHW").prop('disabled', true);
                $(".ISPPremiumLicenseHW").css('color', 'grey');

                $(".ISPTestLicenseHW").prop('disabled', true);
                $(".ISPTestLicenseHW").css('color', 'grey');

                $("#prelabel1").css('color', '#d2dee5');
                $("#prelabel2").css('color', '#d2dee5');
                $("#prelabel3").css('color', '#d2dee5');
                $("#prelabel4").css('color', '#d2dee5');
                $("#prelabel5").css('color', '#d2dee5');



                $('.HHAopt.active').removeClass("active");
                $("#HHNotPro").addClass("active");



                $('.Philipsprovidestorage.active').removeClass("active");

                $("#ISPTextLicenseRequiredNo").addClass("active");

                $("#STBAddStorageNo").addClass("active");

                

                //pro licences
                currentValue = $('#hidLicenceDataPro')[0].value;
                $('.ISPAdvancedlicense.active').removeClass("active");
                $("#ISPAdvancedlicense" + currentValue).addClass("active");


               //licence table
                $("#hidManualISPPro")[0].value = currentValue;
                let HasTestServer = $("#ISPTextLicenseRequiredYes").hasClass('active');

                if (HasTestServer == true) {
                    currentValue++;
                }

                if (HasTestServer == true) {
                    CreateRowPro(currentValue, $('#hidApplicationDataPro').value, true, $('#hidMacTablePro')[0].value,0);
                } else {
                    CreateRowPro(currentValue, $('#hidApplicationDataPro').value, false, $('#hidMacTablePro')[0].value,0);
                }




            } else {

                $(".Philipsprovidestorage").prop('disabled', false);
                $(".Philipsprovidestorage").css('color', 'black');

                $(".AdditionalStorageRequiredHW").prop('disabled', false);
                $(".AdditionalStorageRequiredHW").css('color', 'black');

               // $(".AdditionalhostserverHW").prop('disabled', false);
                $(".AdditionalhostserverHW").css('color', 'black');

                $(".ISPPremiumLicenseHW").prop('disabled', false);
                $(".ISPPremiumLicenseHW").css('color', 'black');

                $(".ISPTestLicenseHW").prop('disabled', false);
                $(".ISPTestLicenseHW").css('color', 'black');

                $("#prelabel1").css('color', '#333');
                $("#prelabel2").css('color', '#333');
                $("#prelabel3").css('color', '#333');
                $("#prelabel4").css('color', '#333');
                $("#prelabel5").css('color', '#333');
                $('.Philipsprovidestorage.active').removeClass("active");

                //$("#ISPTextLicenseRequiredNo").addClass("active");

            }

        }


        function selectButtons() {
            $('.HHA.active').removeClass("active");

            $("#HHYesPartial").hide();
            $("#HHYesFull").hide();

            $("#HHNotPro").show();
            $("#HHNotPrem").show();

            $('.HHAyesopt.active').removeClass("active");
            $('.HHAopt.active').removeClass("active");

            $("#HHNotPro").addClass("active");
            $("#hhaNOT").addClass("active");

           // SHPreDisplay(0);
            //SHProDisplay(1);            
            GetProData();

            //Pro
            if ($('#hidLicenceDataPro')[0].value != 0) {

                SHProDisplay(1);
                SHPreDisplay(0);

            } else {
                SHPreDisplay(1);
                SHProDisplay(0);
            }

            //Pre
            //$('#hidLicenceDataPro2')[0].value
            



        }

        function SetUpProlicences(data, IsTest, maclist) {
            switch (data.licence.toString()) {
                case "1":
                    $('.ISPAdvancedlicense.active').removeClass("active");

                    $("#ISPAdvancedlicense1").addClass("active");

                    CreateRowPro(data.licence, data.application, IsTest, maclist, 0)
                    break;
                case "2":
                    $('.ISPAdvancedlicense.active').removeClass("active");

                    $("#ISPAdvancedlicense2").addClass("active");
                    $("#ISPAdvancedlicense1").prop('disabled', true);

                    CreateRowPro(data.licence, data.application, IsTest, maclist, 0)






                    break;
                case "3":
                    $('.ISPAdvancedlicense.active').removeClass("active");

                    $("#ISPAdvancedlicense3").addClass("active");

                    $("#ISPAdvancedlicense2").prop('disabled', true);
                    $("#ISPAdvancedlicense1").prop('disabled', true);

                    CreateRowPro(data.licence, data.application, IsTest, maclist, 0)




                    break;
                case "4":
                    $('.ISPAdvancedlicense.active').removeClass("active");

                    $("#ISPAdvancedlicense4").addClass("active");

                    $("#ISPAdvancedlicense3").prop('disabled', true);
                    $("#ISPAdvancedlicense2").prop('disabled', true);
                    $("#ISPAdvancedlicense1").prop('disabled', true);

                    CreateRowPro(data.licence, data.application, IsTest, maclist, 0)



                    break;
                case "5":
                    $('.ISPAdvancedlicense.active').removeClass("active");
                    $("#ISPAdvancedlicense5").addClass("active");

                    $("#ISPAdvancedlicense4").prop('disabled', true);
                    $("#ISPAdvancedlicense3").prop('disabled', true);
                    $("#ISPAdvancedlicense2").prop('disabled', true);
                    $("#ISPAdvancedlicense1").prop('disabled', true);

                    CreateRowPro(data.licence, data.application, IsTest, maclist, 0)


                    break;

            }
        }

        function SetUpPrelicences(data, IsTest, maclist) {
            switch (data.prelicence.toString()) {
                case "1":
                    $('.ISPPremiumLicenseHW.active').removeClass("active");

                    $("#ISPPremiumLicense1").addClass("active");

                    CreateRowPro(data.prelicence, data.application, IsTest, maclist, 1)


                    $("#Additionalhostserver1").addClass("active");


                    break;
                case "2":
                    $('.ISPPremiumLicenseHW.active').removeClass("active");

                    $("#ISPPremiumLicense2").addClass("active");
                    $("#ISPPremiumLicense1").prop('disabled', true);

                    CreateRowPro(data.prelicence, data.application, IsTest, maclist, 1)

                    $("#Additionalhostserver1").addClass("active");
                    break;
                case "3":
                    $('.ISPPremiumLicenseHW.active').removeClass("active");

                    $("#ISPPremiumLicense3").addClass("active");

                    $("#ISPPremiumLicense2").prop('disabled', true);
                    $("#ISPPremiumLicense1").prop('disabled', true);

                    CreateRowPro(data.prelicence, data.application, IsTest, maclist, 1)

                    $("#Additionalhostserver1").addClass("active");
                    break;
                case "4":
                    $('.ISPPremiumLicenseHW.active').removeClass("active");

                    $("#ISPPremiumLicense4").addClass("active");

                    $("#ISPPremiumLicense3").prop('disabled', true);
                    $("#ISPPremiumLicense2").prop('disabled', true);
                    $("#ISPPremiumLicense1").prop('disabled', true);

                    CreateRowPro(data.prelicence, data.application, IsTest, maclist, 1)

                    $("#Additionalhostserver2").addClass("active");
                    $("#Additionalhostserver1").prop('disabled', true);

                    break;
                case "5":
                    $('.ISPPremiumLicenseHW.active').removeClass("active");
                    $("#ISPPremiumLicense5").addClass("active");

                    $("#ISPPremiumLicense4").prop('disabled', true);
                    $("#ISPPremiumLicense3").prop('disabled', true);
                    $("#ISPPremiumLicense2").prop('disabled', true);
                    $("#ISPPremiumLicense1").prop('disabled', true);

                    CreateRowPro(data.prelicence, data.application, IsTest, maclist, 1)
                    $("#Additionalhostserver1").prop('disabled', true);
                    $("#Additionalhostserver2").addClass("active");


                    break;
                case "6":
                    $('.ISPPremiumLicenseHW.active').removeClass("active");
                    $("#ISPPremiumLicense6").addClass("active");

                    $("#ISPPremiumLicense5").prop('disabled', true);
                    $("#ISPPremiumLicense4").prop('disabled', true);
                    $("#ISPPremiumLicense3").prop('disabled', true);
                    $("#ISPPremiumLicense2").prop('disabled', true);
                    $("#ISPPremiumLicense1").prop('disabled', true);

                    CreateRowPro(data.prelicence, data.application, IsTest, maclist, 1)
                    $("#Additionalhostserver1").prop('disabled', true);
                    $("#Additionalhostserver2").addClass("active");


                    break;
                case "7":
                    $('.ISPPremiumLicenseHW.active').removeClass("active");
                    $("#ISPPremiumLicense7").addClass("active");

                    $("#ISPPremiumLicense6").prop('disabled', true);
                    $("#ISPPremiumLicense5").prop('disabled', true);
                    $("#ISPPremiumLicense4").prop('disabled', true);
                    $("#ISPPremiumLicense3").prop('disabled', true);
                    $("#ISPPremiumLicense2").prop('disabled', true);
                    $("#ISPPremiumLicense1").prop('disabled', true);

                    CreateRowPro(data.prelicence, data.application, IsTest, maclist, 1)
                    $("#Additionalhostserver1").prop('disabled', true);

                    $("#Additionalhostserver3").addClass("active");


                    break;
                case "8":
                    $('.ISPPremiumLicenseHW.active').removeClass("active");
                    $("#ISPPremiumLicense8").addClass("active");

                    $("#ISPPremiumLicense7").prop('disabled', true);
                    $("#ISPPremiumLicense6").prop('disabled', true);
                    $("#ISPPremiumLicense5").prop('disabled', true);
                    $("#ISPPremiumLicense4").prop('disabled', true);
                    $("#ISPPremiumLicense3").prop('disabled', true);
                    $("#ISPPremiumLicense2").prop('disabled', true);
                    $("#ISPPremiumLicense1").prop('disabled', true);

                    CreateRowPro(data.prelicence, data.application, IsTest, maclist, 1)
                    $("#Additionalhostserver1").prop('disabled', true);
                    // $("#Additionalhostserver2").addClass("active"); 
                    $("#Additionalhostserver3").addClass("active");

                    break;
                case "9":
                    $('.ISPPremiumLicenseHW.active').removeClass("active");
                    $("#ISPPremiumLicense9").addClass("active");

                    $("#ISPPremiumLicense8").prop('disabled', true);
                    $("#ISPPremiumLicense7").prop('disabled', true);
                    $("#ISPPremiumLicense6").prop('disabled', true);
                    $("#ISPPremiumLicense5").prop('disabled', true);
                    $("#ISPPremiumLicense4").prop('disabled', true);
                    $("#ISPPremiumLicense3").prop('disabled', true);
                    $("#ISPPremiumLicense2").prop('disabled', true);
                    $("#ISPPremiumLicense1").prop('disabled', true);

                    CreateRowPro(data.prelicence, data.application, IsTest, maclist, 1)
                    $("#Additionalhostserver1").prop('disabled', true);
                    // $("#Additionalhostserver2").addClass("active"); 
                    $("#Additionalhostserver3").addClass("active");

                    break;
                case "10":
                    $('.ISPPremiumLicenseHW.active').removeClass("active");
                    $("#ISPPremiumLicense10").addClass("active");

                    $("#ISPPremiumLicense9").prop('disabled', true);
                    $("#ISPPremiumLicense8").prop('disabled', true);
                    $("#ISPPremiumLicense7").prop('disabled', true);
                    $("#ISPPremiumLicense6").prop('disabled', true);
                    $("#ISPPremiumLicense5").prop('disabled', true);
                    $("#ISPPremiumLicense4").prop('disabled', true);
                    $("#ISPPremiumLicense3").prop('disabled', true);
                    $("#ISPPremiumLicense2").prop('disabled', true);
                    $("#ISPPremiumLicense1").prop('disabled', true);

                    CreateRowPro(data.prelicence, data.application, IsTest, maclist, 1)
                    //$("#Additionalhostserver1").prop('disabled', true);
                    $("#Additionalhostserver4").addClass("active");


                    break;

            }
        }

         function SetUpPrelicences2(data, IsTest, maclist) {

             switch (data.toString()) {
                case "1":
                    $('.ISPPremiumLicenseHW.active').removeClass("active");

                    $("#ISPPremiumLicense1").addClass("active");

                   // CreateRowPro(data.prelicence, data.application, IsTest, maclist, 1)


                    $("#Additionalhostserver1").addClass("active");


                    break;
                case "2":
                    $('.ISPPremiumLicenseHW.active').removeClass("active");

                    $("#ISPPremiumLicense2").addClass("active");
                    $("#ISPPremiumLicense1").prop('disabled', true);

                   // CreateRowPro(data.prelicence, data.application, IsTest, maclist, 1)

                    $("#Additionalhostserver1").addClass("active");
                    break;
                case "3":
                    $('.ISPPremiumLicenseHW.active').removeClass("active");

                    $("#ISPPremiumLicense3").addClass("active");

                    $("#ISPPremiumLicense2").prop('disabled', true);
                    $("#ISPPremiumLicense1").prop('disabled', true);

                   // CreateRowPro(data.prelicence, data.application, IsTest, maclist, 1)

                    $("#Additionalhostserver1").addClass("active");
                    break;
                case "4":
                    $('.ISPPremiumLicenseHW.active').removeClass("active");

                    $("#ISPPremiumLicense4").addClass("active");

                    $("#ISPPremiumLicense3").prop('disabled', true);
                    $("#ISPPremiumLicense2").prop('disabled', true);
                    $("#ISPPremiumLicense1").prop('disabled', true);

                    //CreateRowPro(data.prelicence, data.application, IsTest, maclist, 1)

                    $("#Additionalhostserver2").addClass("active");
                    $("#Additionalhostserver1").prop('disabled', true);

                    break;
                case "5":
                    $('.ISPPremiumLicenseHW.active').removeClass("active");
                    $("#ISPPremiumLicense5").addClass("active");

                    $("#ISPPremiumLicense4").prop('disabled', true);
                    $("#ISPPremiumLicense3").prop('disabled', true);
                    $("#ISPPremiumLicense2").prop('disabled', true);
                    $("#ISPPremiumLicense1").prop('disabled', true);

                  //  CreateRowPro(data.prelicence, data.application, IsTest, maclist, 1)
                    $("#Additionalhostserver1").prop('disabled', true);
                    $("#Additionalhostserver2").addClass("active");


                    break;
                case "6":
                    $('.ISPPremiumLicenseHW.active').removeClass("active");
                    $("#ISPPremiumLicense6").addClass("active");

                    $("#ISPPremiumLicense5").prop('disabled', true);
                    $("#ISPPremiumLicense4").prop('disabled', true);
                    $("#ISPPremiumLicense3").prop('disabled', true);
                    $("#ISPPremiumLicense2").prop('disabled', true);
                    $("#ISPPremiumLicense1").prop('disabled', true);

                   // CreateRowPro(data.prelicence, data.application, IsTest, maclist, 1)
                    $("#Additionalhostserver1").prop('disabled', true);
                    $("#Additionalhostserver2").addClass("active");


                    break;
                case "7":
                    $('.ISPPremiumLicenseHW.active').removeClass("active");
                    $("#ISPPremiumLicense7").addClass("active");

                    $("#ISPPremiumLicense6").prop('disabled', true);
                    $("#ISPPremiumLicense5").prop('disabled', true);
                    $("#ISPPremiumLicense4").prop('disabled', true);
                    $("#ISPPremiumLicense3").prop('disabled', true);
                    $("#ISPPremiumLicense2").prop('disabled', true);
                    $("#ISPPremiumLicense1").prop('disabled', true);

                   // CreateRowPro(data.prelicence, data.application, IsTest, maclist, 1)
                    $("#Additionalhostserver1").prop('disabled', true);

                    $("#Additionalhostserver3").addClass("active");


                    break;
                case "8":
                    $('.ISPPremiumLicenseHW.active').removeClass("active");
                    $("#ISPPremiumLicense8").addClass("active");

                    $("#ISPPremiumLicense7").prop('disabled', true);
                    $("#ISPPremiumLicense6").prop('disabled', true);
                    $("#ISPPremiumLicense5").prop('disabled', true);
                    $("#ISPPremiumLicense4").prop('disabled', true);
                    $("#ISPPremiumLicense3").prop('disabled', true);
                    $("#ISPPremiumLicense2").prop('disabled', true);
                    $("#ISPPremiumLicense1").prop('disabled', true);

                   // CreateRowPro(data.prelicence, data.application, IsTest, maclist, 1)
                    $("#Additionalhostserver1").prop('disabled', true);
                    // $("#Additionalhostserver2").addClass("active"); 
                    $("#Additionalhostserver3").addClass("active");

                    break;
                case "9":
                    $('.ISPPremiumLicenseHW.active').removeClass("active");
                    $("#ISPPremiumLicense9").addClass("active");

                    $("#ISPPremiumLicense8").prop('disabled', true);
                    $("#ISPPremiumLicense7").prop('disabled', true);
                    $("#ISPPremiumLicense6").prop('disabled', true);
                    $("#ISPPremiumLicense5").prop('disabled', true);
                    $("#ISPPremiumLicense4").prop('disabled', true);
                    $("#ISPPremiumLicense3").prop('disabled', true);
                    $("#ISPPremiumLicense2").prop('disabled', true);
                    $("#ISPPremiumLicense1").prop('disabled', true);

                   // CreateRowPro(data.prelicence, data.application, IsTest, maclist, 1)
                    $("#Additionalhostserver1").prop('disabled', true);
                    // $("#Additionalhostserver2").addClass("active"); 
                    $("#Additionalhostserver3").addClass("active");

                    break;
                case "10":
                    $('.ISPPremiumLicenseHW.active').removeClass("active");
                    $("#ISPPremiumLicense10").addClass("active");

                    $("#ISPPremiumLicense9").prop('disabled', true);
                    $("#ISPPremiumLicense8").prop('disabled', true);
                    $("#ISPPremiumLicense7").prop('disabled', true);
                    $("#ISPPremiumLicense6").prop('disabled', true);
                    $("#ISPPremiumLicense5").prop('disabled', true);
                    $("#ISPPremiumLicense4").prop('disabled', true);
                    $("#ISPPremiumLicense3").prop('disabled', true);
                    $("#ISPPremiumLicense2").prop('disabled', true);
                    $("#ISPPremiumLicense1").prop('disabled', true);

                   // CreateRowPro(data.prelicence, data.application, IsTest, maclist, 1)
                    //$("#Additionalhostserver1").prop('disabled', true);
                    $("#Additionalhostserver4").addClass("active");


                    break;

            }
        }

        function GetProData() {

            let enterpriseuser = $("#CONCURRENTENTERPRISEUSERS")[0].value;

            if (enterpriseuser > 50) {
                alert("Concurrent users can not exceed 50");
                $("#CONCURRENTENTERPRISEUSERS")[0].value = 50;
            }


            let IsTest = false;

            let selectedapplication = "";
            let selectedapplication1 = $("#cmdApplication1")[0].value + "?" + $("#txtConcurrent1")[0].value;
            let selectedapplication2 = $("#cmdApplication2")[0].value + "?" + $("#txtConcurrent2")[0].value;
            let selectedapplication3 = $("#cmdApplication3")[0].value + "?" + $("#txtConcurrent3")[0].value;
            let selectedapplication4 = $("#cmdApplication4")[0].value + "?" + $("#txtConcurrent4")[0].value;
            let selectedapplication5 = $("#cmdApplication5")[0].value + "?" + $("#txtConcurrent5")[0].value;
            let selectedapplication6 = $("#cmdApplication6")[0].value + "?" + $("#txtConcurrent6")[0].value;
            let selectedapplication7 = $("#cmdApplication7")[0].value + "?" + $("#txtConcurrent7")[0].value;
            let selectedapplication8 = $("#cmdApplication8")[0].value + "?" + $("#txtConcurrent8")[0].value;
            let selectedapplication9 = $("#cmdApplication9")[0].value + "?" + $("#txtConcurrent9")[0].value;
            let selectedapplication10 = $("#cmdApplication10")[0].value + "?" + $("#txtConcurrent10")[0].value;


            selectedapplication = selectedapplication1 + "~" + selectedapplication2 + "~" + selectedapplication3 + "~" + selectedapplication4 + "~" + selectedapplication5 + "~" + selectedapplication6 + "~" + selectedapplication7 + "~" + selectedapplication8 + "~" + selectedapplication9 + "~" + selectedapplication10;

            var myKeyVals = { enterpriseuser: enterpriseuser, selectedapplication: selectedapplication, enterpriseuser: enterpriseuser }

             //$.ajax('./apidatahesoft',
            $.ajax(sapidatahesoft,
                {
                    type: 'POST',
                    data: myKeyVals,
                    dataType: 'json', // type of response data
                    //timeout: 5000,     // timeout milliseconds
                    success: function (data, status, xhr) {   // success callback function

                        $('#hidLicenceDataPro')[0].value = data.licence;
                        $('#hidLicenceDataPro2')[0].value = data.prelicence;
                        $('#hidApplicationDataPro')[0].value = data.application;
                        $('#parial_ha')[0].value = data.parial_ha;
                        $('#full_ha')[0].value = data.full_ha;
                        $('#server_ha_partial')[0].value = data.server_ha_partial;
                        $('#server_ha_full')[0].value = data.server_ha_full;

                        console.log("data.licence2:" + data.licence);
                        console.log("data.prelicence2:" + data.prelicence);
                        console.log("data.Name2:" + data.application);

                        console.log("data.parial_ha:" + data.parial_ha);
                        console.log("data.full_ha:" + data.full_ha);

                        console.log("data.server_ha_partial:" + data.server_ha_partial);
                        console.log("data.server_ha_full:" + data.server_ha_full);


                        if ($("#hhaNOT").hasClass('active')) {
                            hha('NO');
                        }


                        if ($("#hhaIS").hasClass('active')) {
                            hha('YES');

                        }
                        

                      
                        //if ($("#ISPTextLicenseRequiredYes").hasClass('active')) {
                        //    data.licence = parseInt(data.licence) + 1;
                        //    IsTest = true;
                        //}

                       // let maclist = $('#hidMacTablePro')[0].value;

                        //$("#ISPAdvancedlicense5").prop('disabled', false);
                        //$("#ISPAdvancedlicense4").prop('disabled', false);
                        //$("#ISPAdvancedlicense3").prop('disabled', false);
                        //$("#ISPAdvancedlicense2").prop('disabled', false);
                        //$("#ISPAdvancedlicense1").prop('disabled', false);

                        //$('.AdditionalhostserverHW.active').removeClass("active");


                        //$premButton = $("#HHNotPrem").hasClass('active');

                        //if ($premButton == true & data.prelicence > 0) {
                        //    data.licence = "0";
                        //}


                        //if (data.licence.toString() != "0") {

                        //    SHPreDisplay(0);
                        //    SHProDisplay(1);

                        //    //  $('.HHAopt.active').removeClass("active");                         
                        //    // $("#HHNotPro").addClass("active");  
                        //    // $("#HHNotPro").prop('disabled', false);

                        //    SetUpProlicences(data, IsTest, maclist);

                        //} else {
                        //    SHProDisplay(0);
                        //    SHPreDisplay(1);

                        //    SetUpPrelicences(data, IsTest, maclist);

                        //    $('.HHAopt.active').removeClass("active");
                        //    $("#HHNotPrem").addClass("active");
                        //    //$("#HHNotPro").prop('disabled', true);
                        //    //$("#HHNotPro").css('color', 'grey');


                        //}




                        //$('#hidISPSoftwareHardwarePro')[0].value = data.licence;
                        //$('#hidISPSoftwareHardwarePre')[0].value = data.licence;


                        //storeCurrentMacPro();

                    },
                    error: function (jqXhr, textStatus, errorMessage) { // error callback                     
                        alert(errorMessage);
                    }
                });

        }




        function hha(typeButton) {
            let noServer = 0;

            switch (typeButton) {
                case "Partial":
                    SHFullPartalDisplay(1)

                    //$("#HHYesPartial").prop('disabled', true);
                    $('.HHAyesopt.active').removeClass("active");
                    $("#HHYesFull").addClass("active");

                    $('.ISPPremiumLicenseHW.active').removeClass("active");

                    $("#ISPPremiumLicense" + $('#hidLicenceDataPro2')[0].value).addClass("active");

                    //Math.ceil((parseInt($('#hidLicenceDataPro2')[0].value) / 3)) +

                    noServer = parseInt($('#server_ha_partial')[0].value);
                    noServer = parseInt(noServer);

                    $('.AdditionalhostserverHW.active').removeClass("active");
                    $("#Additionalhostserver" + noServer).addClass("active");
                    break;
                case "Full":
                  //  SHProDisplay(0);
//                    SHPreDisplay(1);

                    //$("#HHYesPartial").prop('disabled', true);
                    $('.HHAyesopt.active').removeClass("active");
                    $("#HHYesFull").addClass("active");

                    $('.ISPPremiumLicenseHW.active').removeClass("active");

                    //$("#ISPPremiumLicense" + $('#hidLicenceDataPro2')[0].value).addClass("active");

                    //noServer = parseInt($('#server_ha_full')[0].value);
                    //noServer = parseInt(noServer);

                    //$('.AdditionalhostserverHW.active').removeClass("active");
                    //$("#Additionalhostserver" + noServer).addClass("active");

                    SHFullPreDisplay(1);
                   // SHFullPartalDisplay(0);
                    


                    break;
                case "YES":

                    $('.AdditionalhostserverHW.active').removeClass("active");

                    $('.HHAopt.active').removeClass("active");
                    $("#HHYesPartial").addClass("active");

                    $("#HHNotPro").hide();
                    $("#HHNotPrem").hide();

                    $("#HHYesPartial").show();
                    $("#HHYesFull").show();

                    let maclist = $('#hidMacTablePro')[0].value;
                    let IsTest = false;


                     
                    $('.ISPPremiumLicenseHW.active').removeClass("active");
                    $('.Philipsprovidestorage.active').removeClass("active");
                    $("#PhilipsprovidestorageNo").addClass("active");

                    //SHFullPartalDisplay
                        //$('#parial_ha')[0].value = data.parial_ha;
                        //$('#full_ha')[0].value = data.full_ha;
                        //$('#server_ha_partial')[0].value = data.server_ha_partial;
                        //$('#server_ha_full')[0].value = data.server_ha_full;


                    if ($('#parial_ha')[0].value == 1) {
                        $('.HHAyesopt.active').removeClass("active");                         
                        $("#HHYesPartial").addClass("active");
                        $("#HHYesPartial").prop('disabled', false);
                        $("#HHYesPartial").css('color', 'black');
                        SHFullPartalDisplay(1);//partal
                       // SHFullPreDisplay(0);
                       

                    } else {

                        SHFullPreDisplay(1);
                        //SHFullPartalDisplay(0);

                        $('.HHAyesopt.active').removeClass("active");
                        $("#HHYesFull").addClass("active");

                        if ($('#parial_ha')[0].value == 0) {
                            $("#HHYesPartial").prop('disabled', true);   



                            $("#HHYesPartial").css('color', 'grey');
                            //

                        }
                        
                    }




                    //GetProData();
                   // SHProDisplay(0);
                    //SHPreDisplay(1);

                    //$('.HHAyesopt.active').removeClass("active");

                    //$('.ISPPremiumLicenseHW.active').removeClass("active");
                    //$("#ISPPremiumLicense" + $('#hidLicenceDataPro2')[0].value).addClass("active");



                    //if ($('#server_ha_partial')[0].value > 0) {
                    //    $("#HHYesPartial").addClass("active");

                    //    noServer = parseInt($('#server_ha_partial')[0].value);
                    //    noServer = parseInt(noServer);

                    //    $("#Additionalhostserver" + noServer).addClass("active");


                    //} else {
                    //    $("#HHYesFull").addClass("active");

                    //    noServer = parseInt($('#server_ha_full')[0].value);
                    //    noServer = parseInt(noServer);

                    //    $("#Additionalhostserver" + noServer).addClass("active");
                    //}

                    //if ($('#server_ha_partial')[0].value == 0) {
                    //    $("#HHYesPartial").prop('disabled', true);
                    //}


                    //if ($('#full_ha')[0].value == 3)
                    //{
                    //    $("#HHYesFull").prop('disabled', true); 
                    //    $("#FullHAModalCenter").modal();
                        
                    //}


                    break;
                case "NO":
                    $("#HHYesPartial").hide();
                    $("#HHYesFull").hide();
                    $("#HHNotPro").show();
                    $("#HHNotPrem").show();
                    $('.HHAyesopt.active').removeClass("active");
                    $('.HHAopt.active').removeClass("active");
                    $("#HHNotPro").addClass("active");
                   // GetProData();


                    if ($('#hidLicenceDataPro')[0].value == 0) {
                        SHPreDisplay(1);
                        SHProDisplay(0);


                         $("#HHNotPro").prop('disabled', true);   
                         $("#HHNotPro").css('color', 'grey');


                    } else {
                        SHPreDisplay(0);
                        SHProDisplay(1);

                         $("#HHNotPro").prop('disabled', false);   
                         $("#HHNotPro").css('color', 'black');
                    }


                  

                    break;
                case "Pro":
                   //GetProData();
                    SHPreDisplay(0);
                    SHProDisplay(1);

                    break;
                case "Premium":
                    //GetProData();
                    SHProDisplay(0);
                    SHPreDisplay(1);

                    break;
            }





        }


        function ISPSoftwareButton(currentButton) {


            let mybut = currentButton.value;
            $("#hidManualISP")[0].value = mybut;
            let HasTestServer = $("#cmdISPSoftwareYes").hasClass('active');

            console.log("button", mybut);

            console.log("HasTestServer", HasTestServer);

            if (HasTestServer == true) {
               // mybut++;
            }
            

            if (HasTestServer == true) {
                CreateRow(mybut, $('#hidApplicationData').value, true, $('#hidMacTable')[0].value);
            } else {
                CreateRow(mybut, $('#hidApplicationData').value, false, $('#hidMacTable')[0].value);
            }

        }


        function ISPSoftwareProButton(currentButton) {


            let mybut = currentButton.value;
            $("#hidManualISPPro")[0].value = mybut;
            let HasTestServer = $("#ISPTextLicenseRequiredYes").hasClass('active');

            if (HasTestServer == true) {
                mybut++;
            }

            if (HasTestServer == true) {
                CreateRowPro(mybut, $('#hidApplicationDataPro').value, true, $('#hidMacTablePro')[0].value);
            } else {
                CreateRowPro(mybut, $('#hidApplicationDataPro').value, false, $('#hidMacTablePro')[0].value);
            }

        }

        function SetPremiumServers(currentButtonNumber) {

            let mybut = currentButtonNumber;
            $("#hidManualISPPro")[0].value = mybut;
            let HasTestServer = $("#ISPTestLicenseHWYes").hasClass('active');


            let HostServers = 0;

            if ($("#Additionalhostserver1").hasClass('active') == true) {
                HostServers = 1;
            }

            if ($("#Additionalhostserver2").hasClass('active') == true) {
                HostServers = 2;
            }

            if ($("#Additionalhostserver3").hasClass('active') == true) {
                HostServers = 3;
            }

            let noServers = Math.ceil((parseInt(mybut) / 3));

            
            $('.AdditionalhostserverHW.active').removeClass("active");
            $("#Additionalhostserver" + noServers).addClass("active");                        

        }


        function ISPSoftwarePreButton(currentButton) {


            let mybut = currentButton.value;
            $("#hidManualISPPro")[0].value = mybut;
            let HasTestServer = $("#ISPTestLicenseHWYes").hasClass('active');

            SetPremiumServers(mybut);
                                       

            if (HasTestServer == true) {
                CreateRowPro(mybut, $('#hidApplicationDataPro').value, true, $('#hidMacTablePro')[0].value);
            } else {
                CreateRowPro(mybut, $('#hidApplicationDataPro').value, false, $('#hidMacTablePro')[0].value);
            }

        }

        function MacAddLine() {

            storeCurrentMac();

            let currentValue = parseInt($('.ISPSoftwareOnly.active')[0].value);
            let HasTestServer = $("#cmdISPSoftwareYes").hasClass('active');
            currentValue = currentValue + 1;

            if (currentValue < 12) {

                $('.ISPSoftwareOnly.active').removeClass("active");
                $("#cmdISPSoftwareOnly" + currentValue).addClass("active");


                if (HasTestServer == true) {
                   //  currentValue = currentValue + 1;
                    CreateRow(currentValue, $('#hidApplicationData').value, true, $('#hidMacTable')[0].value);
                } else {
                    CreateRow(currentValue, $('#hidApplicationData').value, false, $('#hidMacTable')[0].value);
                }

            } else {
                alert('Maximum lines reached');
            }


        }


        function MacAddLinePro() {

            storeCurrentMacPro();

            let isPro = $("#HHNotPro").hasClass('active');
            let currentValue = 0;
            if (isPro == true) {
                currentValue = parseInt($('.ISPAdvancedlicense.active')[0].value);
            } else {
                currentValue = parseInt($('.ISPPremiumLicenseHW.active')[0].value);
            }



            let HasTestServer = $("#ISPTextLicenseRequiredYes").hasClass('active');
            currentValue = currentValue + 1;

            if (currentValue < 11) {
               
                if (isPro == false) {

                    
                    
                    $('.ISPPremiumLicenseHW.active').removeClass("active");
                    $("#ISPPremiumLicense" + currentValue).addClass("active");

                    if (HasTestServer == true) {
                          currentValue = currentValue + 1;
                        CreateRowPro(currentValue, $('#hidApplicationDataPro').value, true, $('#hidMacTablePro')[0].value, 1);
                    } else {
                        CreateRowPro(currentValue, $('#hidApplicationDataPro').value, false, $('#hidMacTablePro')[0].value, 1);
                    }

                    SetPremiumServers(currentValue);

                } else {


                    $('.ISPAdvancedlicense.active').removeClass("active");
                    $("#ISPAdvancedlicense" + currentValue).addClass("active");

                    if (HasTestServer == true) {
                          currentValue = currentValue + 1;
                        CreateRowPro(currentValue, $('#hidApplicationDataPro').value, true, $('#hidMacTablePro')[0].value, 0);
                    } else {
                        CreateRowPro(currentValue, $('#hidApplicationDataPro').value, false, $('#hidMacTablePro')[0].value, 0);
                    }


                    SetPremiumServers(currentValue);

                }

            } else {
                alert('Maximum lines reached');
            }


        }



        function prePhilipsprovidestorage(elm) {

            if (elm == "NO") {

                $("#premTotalStorageRequiredROW").hide();

            } else {
                $("#premTotalStorageRequiredROW").show();
                $('.AdditionalStorageRequiredHW.active').removeClass("active");
                $("#AdditionalStorageRequired10TB").addClass("active");

            }

        }


        function setupSave() {
            ///denDeliveryModel
             
            let isSoftwareOnly = $("#Navsoftware-tab").hasClass('active');
            let isSoftwareHardWare = $("#NavsoftwareHardware-tab").hasClass('active');

            if (isSoftwareOnly != "") {
                $("#HiddenDeliveryModel")[0].value = "SoftwareOnly";
            }

            if (isSoftwareHardWare != "") {
                $("#HiddenDeliveryModel")[0].value = "SoftwareHardWare";
            }
                       
        }

        $(document).ready(function () {
            GetLicenceData();
            CentralAddSite(false);

            $('.ApplicationDDL').select2();            
             $('.ToggleDropdown').click(function () {
                $('.drop-down').addClass('OpenDropdown');
             });


            for (i = 1; i < 10; i++)
            {
                if ($("#txtHospitalName" + i)[0].value != "") {
                    UpdateHospital(i);
                }
               
                if ($("#cmdApplication" + i)[0].value != "") {

                    $("#row" + i + "-additional-apps").show();

                    GetApplicationData($("#cmdApplication" + i)[0]);
                }
            }


        });





    </script >

            <style>
                .Tab-info .nav-tabs > li > a {
                    border - radius: 0;
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
                    border - radius: 0;
                background: #d2dee5;
                color: black;
                width: 224px !important;
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
                width: 224px !important;
                text-align: center;
                font-size: 14px;
            }
    </style>

</body >
</html >

