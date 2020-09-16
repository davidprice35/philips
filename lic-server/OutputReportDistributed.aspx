<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OutputReportDistributed.aspx.cs" Inherits="OutputReportDistributed" MaintainScrollPositionOnPostback="true" %>





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
                                    <li class="active"><a href="/">ORDERING INFORMATION</a></li>                                    
                                </ul>


                                <div class="tab-content toshiba-content " style="">
                                    <div id="home" class="tab-pane fade in active">
                                        <div style="margin-top: 30px; height: auto;">
                                            <div class="container">


                                               <%-- <asp:Button ID="Button1" runat="server" OnClick="Button1_Click"  Text="Download PDF" />--%>

                                                <div class="table-responsive" style="margin-left: -16px;">
                                                    <table class="table table-bordered">
                                                        <thead>
                                                            <tr>
                                                                <th scope="col" style="background-color: #0b1f65; border-right-color: #0b1f65; text-align: left; padding-left: 16px; width: 200px">Project Name </th>
                                                                <th scope="col" style="background-color: #0b1f65;"></th>
                                                            </tr>
                                                        </thead>
                                                        <tbody>
                                                            <tr>

                                                                <td style="vertical-align: middle;">Project Name* </td>
                                                                <td>
                                                                <%=m_project_name %>  
                                                                </td>

                                                            </tr>


                                                        </tbody>
                                                    </table>
                                                </div>



                                                 <div class="table-responsive" style="margin-left: -16px;">
                                                    <table class="table table-bordered">
                                                        <thead>
                                                            <tr>
                                                                <th scope="col" style="background-color: #0b1f65; border-right-color: #0b1f65; text-align: left; padding-left: 16px; width: 200px">Customer</th>
                                                                <th scope="col" style="background-color: #0b1f65;"></th>
                                                            </tr>
                                                        </thead>
                                                        <tbody>
                                                            <tr>

                                                                <td style="vertical-align: middle;">Customer Name* </td>
                                                                <td>
                                                                     <%=m_customer_name %>  
                                                                   </td>

                                                            </tr>

                                                            <tr>

                                                                <td>Customer Address*</td>
                                                                <td>
                                                                     <%=m_customer_address %>  
                                                                    </td>

                                                            </tr>


                                                            <tr>

                                                                <td>Country</td>
                                                                <td>
                                                                  <%=m_customer_country %>  


                                                                </td>

                                                            </tr>

                                                        </tbody>
                                                    </table>
                                                </div>



                                                   <div class="table-responsive" style="margin-left: -16px;">
                                                    <table class="table table-bordered">
                                                        <thead>
                                                            <tr>
                                                                <th scope="col" style="background-color: #0b1f65; border-right-color: #0b1f65; text-align: left; padding-left: 16px; width: 200px">Ordering Information </th>
                                                                <th scope="col" style="background-color: #0b1f65;"></th>
                                                            </tr>
                                                        </thead>
                                                        <tbody>
                                                            <tr>

                                                                <td style="vertical-align: middle;">PO Number*</td>
                                                                <td>
                                                                    <%=m_customer_po %></td>

                                                            </tr>


                                                        </tbody>
                                                    </table>
                                                </div>



                                                <div class="table-responsive" style="margin-left: -16px;">
                                                    <table class="table table-bordered" id="keydtable">
                                                        <thead>
                                                            <tr>
                                                                <th scope="col" style="background-color: #0b1f65; border-right-color: #0b1f65; text-align: left; padding-left: 16px; width: 640px">Project Manager </th>
                                                                <th scope="col" style="background-color: #0b1f65; border-right-color: #0b1f65; text-align: left; padding-left: 16px; width: 640px">First Name </th>
                                                                <th scope="col" style="background-color: #0b1f65; border-right-color: #0b1f65; text-align: left; padding-left: 16px; width: 640px">Last Name </th>
                                                                <th scope="col" style="background-color: #0b1f65; border-right-color: #0b1f65; text-align: left; padding-left: 16px; width: 640px">Email </th>

                                                            </tr>
                                                        </thead>
                                                        <tbody>
                                                            <tr>                                                               
                                                                    <td style="vertical-align: middle;">Key Account Manager</td>
                                                                    <td>
                                                                        <%=m_customer_key_account_first %>
                                                                    </td>
                                                                    <td>
                                                                       <%=m_customer_key_account_last %>
                                                                    </td>
                                                                    <td>
                                                                       <%=m_customer_key_account_email %>
                                                                    </td>
                                                                </tr>
                                                             <tr>
                                                                <td style="vertical-align: middle;">InteliSpace Portal Sales Specialist</td>
                                                                <td>
                                                                     <%=m_portalSales_first %>
                                                                    
                                                                </td>
                                                                <td>
                                                                     <%=m_portalSales_last %>

                                                                </td>
                                                                <td>
                                                                     <%=m_portalSales_email %>
                                                                </td>

                                                            </tr>

                                                            <tr>

                                                                <td style="vertical-align: middle;">Project core team*</td>
                                                                <td>
                                                                     <%=m_core_first %>
                                                                    
                                                                </td>
                                                                <td>
                                                                   <%=m_core_last %>
                                                                </td>
                                                                <td>
                                                                      <%=m_core_email %>
                                                                </td>
                                                            </tr>

                                                        </tbody>
                                                    </table>
                                                </div>

                                          
                                                  <div class="table-responsive" style="margin-left: -16px;">
                                                    <table class="table table-bordered" id="hospitaltable">
                                                        <thead>
                                                            <tr>
                                                                <th scope="col" style="background-color: #0b1f65; border-right-color: #0b1f65; text-align: left; padding-left: 16px; width: 640px">Hospital No </th>
                                                                <th scope="col" style="background-color: #0b1f65; border-right-color: #0b1f65; text-align: left; padding-left: 16px; width: 640px">Hospital Name </th>
                                                                <th scope="col" style="background-color: #0b1f65; border-right-color: #0b1f65; text-align: left; padding-left: 16px; width: 640px">Hospital Street</th>
                                                                <th scope="col" style="background-color: #0b1f65; border-right-color: #0b1f65; text-align: left; padding-left: 16px; width: 640px">Users </th>
                                                                <th scope="col" style="background-color: #0b1f65; border-right-color: #0b1f65; text-align: left; padding-left: 16px; width: 640px">Site </th>
                                                                <th scope="col" style="background-color: #0b1f65; border-right-color: #0b1f65; text-align: left; padding-left: 16px; width: 640px">Connectivity </th>

                                                            </tr>
                                                        </thead>
                                                        <tbody>
                                                            <%=m_hospital_name %>
                                                             

                                                            

                                                        </tbody>
                                                    </table>
                                                </div>



<div class="table-responsive" style="margin-left: -16px;">
 
   <table class="table table-bordered" style="width: 33%;">
      <thead>
         <tr>
            
            <th scope="col" style="background-color: #0b1f65;padding-bottom:10px;height: 41px;width: 18px;"><b>Enterprise Concurrent Users</b></th>
            <th scope="col" style="padding-bottom:10px; width: 15px;color:black;"><b><%=m_decentralised_concurrent_ent_users %> </b></th>
         </tr>
      </thead>
      <tbody>
         
      </tbody>
   </table>
</div>



                                                <%=m_OutputTableApplicationsTable %>


                                              
                                                <%=m_OutputTable %>

                                                   


                                                <div>
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
