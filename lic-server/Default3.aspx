﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="competitive_info_Competitors" %>


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
                                        <div style="margin-top: 30px; height: 1060px;">                                                                                                                                                                          
                                            <div class="container">
                                                <p style="font-weight:bolder;">SITE INFORMATION</p>     
                                                
                                                <div class="Tab-info">
                                                    <div class="tab-regular" style="margin-top:10px;">
                                                        <ul class="nav nav-tabs " id="myTab" role="tablist">
                                                            <li class="nav-item active">
                                                                <a class="nav-link" id="Central-tab" data-toggle="tab" href="#Central" role="tab" aria-controls="home" aria-selected="false" style="width:158px;">Centralised</a>
                                                            </li>
                                                            <li class="nav-item">
                                                                <a class="nav-link" id="profile-tab" data-toggle="tab" href="#profile" role="tab" aria-controls="profile" aria-selected="false" style="width:158px;">Hybrid</a>
                                                            </li>
                                                            <li class="nav-item">
                                                                <a class="nav-link active show" id="contact-tab" data-toggle="tab" href="#contact" role="tab" aria-controls="contact" aria-selected="true" style="width:158px;">Distributed</a>
                                                            </li>
                                                        </ul>
                                                        <div class="tab-content" id="myTabContent">
                                                            <div class="tab-pane active" id="Central" role="tabpanel" aria-labelledby="Central-tab">
                   
                    

                                                                <table class="table table-bordered" style="    margin-left: -10px;">
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
                                                                    <tr>
                                                                      <th scope="row">1</th>
                                                                      <td>Mark</td>
                                                                      <td>Otto</td>
                                                                      <td>@mdo</td>
                                                                        <td>@mdo</td>
                                                                    </tr>
                                                                    <tr>
                                                                      <th scope="row">2</th>
                                                                      <td>Jacob</td>
                                                                      <td>Thornton</td>
                                                                      <td>@fat</td>
                                                                        <td>@mdo</td>
                                                                    </tr>
                                                                    <tr>
                                                                      <th scope="row">3</th>
                                                                      <td>Larry</td>
                                                                      <td>the Bird</td>
                                                                      <td>@twitter</td>
                                                                        <td>@mdo</td>
                                                                    </tr>
                                                                  </tbody>
                                                                </table>


                                                            </div>
                                                            <div class="tab-pane fade" id="profile" role="tabpanel" aria-labelledby="profile-tab">
                                                                <h3>Tab Content Heading</h3>



                                                                
                                                            </div>
                                                            <div class="tab-pane fade" id="contact" role="tabpanel" aria-labelledby="contact-tab">
                                                                <h3>Tab Heading Content </h3>
                                                                <p>Vivamus pellentesque vestibulum lectus vitae auctor. Maecenas eu sodales arcu. Fusce lobortis, libero ac cursus feugiat, nibh ex ultricies tortor, id dictum massa nisl ac nisi. Fusce a eros pellentesque, ultricies urna nec, consectetur dolor. Nam dapibus scelerisque risus, a commodo mi tempus eu.</p>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>

    
                                            </div>

                                        
                                       


                                            <div class="seperator" style="border-bottom-color:#cdcdcd;border-bottom-style:solid;" >
                                            </div>

                                            
 <div class="container">
    <div class="row">
        <div class="col-md-12">
            <div class="row">
                <div class="col-md-4"> 

                    <p style="color:black;margin-top:20px;"><b>CONCURRENT ENTERPRISE USERS</b></p>

                     <table class="table table-bordered" style="margin-left: 0px;width: 63px;">
                      <thead class="thead-light">
                        <tr>
                          <th scope="col" style="background-color: #0b1f65;">Concurrent Users.</th>
                          
                        </tr>
                      </thead>
                      <tbody>
                        <tr>
                          <td>
                              <input type="text" />
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
    

                                               <div class="seperator" style="border-bottom-color:#cdcdcd;border-bottom-style:solid;" >
                                            </div>



                                             <div class="container">
    <div class="row">
        <div class="col-md-12">
            <div class="row">
                <div class="col-md-4"> 
                      <p style="color:black;margin-top:20px;"><b>ADDITIONAL APPLICATIONS</b></p>

                                              <table class="table table-bordered" style="    margin-left: -0px;">
                                                                  <thead class="thead-light">
                                                                    <tr>
                                                                      <th scope="col" style="background-color: #0b1f65;">No.</th>
                                                                      <th scope="col" style="background-color: #0b1f65;">Applications</th>
                                                                      <th scope="col" style="background-color: #0b1f65;">Concurrent Users</th>
                                                                      <th scope="col" style="background-color: #0b1f65;">Hostpital Name</th>
                                                                        
                                                                    </tr>
                                                                  </thead>
                                                                  <tbody>
                                                                    <tr>
                                                                      <th scope="row">1</th>
                                                                      <td>Mark</td>
                                                                      <td>Otto</td>
                                                                      <td>@mdo</td>
                                                                      
                                                                    </tr>
                                                                    <tr>
                                                                      <th scope="row">2</th>
                                                                      <td>Jacob</td>
                                                                      <td>Thornton</td>
                                                                      <td>@fat</td>
                                                                       
                                                                    </tr>
                                                                    <tr>
                                                                      <th scope="row">3</th>
                                                                      <td>Larry</td>
                                                                      <td>the Bird</td>
                                                                      <td>@twitter</td>
                                                                      
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



                                            
                                               <div class="seperator" style="border-bottom-color:#cdcdcd;border-bottom-style:solid;" >
                                            </div>



                                            <div class="container">
                                                <p style="font-weight:bolder;margin-top:20px;">DELIVERY MODEL</p>     
                                                
                                                <div class="DELIVERY-info">
                                                    <div class="tab-regular" style="margin-top:10px;">
                                                        <ul class="nav nav-tabs " id="myTab1" role="tablist">
                                                            
                                                            <li class="nav-item active">
                                                                <a class="nav-link" id="DELIVERY-tab" data-toggle="tab" href="#DELIVERY" role="tab" aria-controls="home" aria-selected="false" style="width:158px;">Software Only</a>
                                                            </li>

                                                            <li class="nav-item">
                                                                <a class="nav-link" id="SODTWARE-tab" data-toggle="tab" href="#SODTWARE" role="tab" aria-controls="profile" aria-selected="false" style="width:220px;">Software & Hardware</a>
                                                            </li>
                                                            
                                                        </ul>
                                                        <div class="tab-content" id="myTabContent1">
                                                            <div class="tab-pane active" id="DELIVERY" role="tabpanel" aria-labelledby="DELIVERY-tab">                                                                                                                                                             

                                                            </div>
                                                            <div class="tab-pane fade" id="SODTWARE" role="tabpanel" aria-labelledby="SODTWARE-tab">
                                                               
                                                               <button type="button" class="btn btn-primary btn-lg">Hardware High Availiabllity NOT required</button>
                                                                <br />
                                                               <button type="button" class="btn btn-primary btn-lg">Hardware High Availiabllity IS required</button>


                                                                
                                                            </div>
                                                            
                                                        </div>
                                                    </div>
                                                </div>

    
                                            </div>


                                            <div class="seperator" style="border-bottom-color:#cdcdcd;border-bottom-style:solid;" >
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