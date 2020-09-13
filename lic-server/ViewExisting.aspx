<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewExisting.aspx.cs" Inherits="ViewExisting" %>



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


    <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/1.10.21/css/jquery.dataTables.css">
  
  <script
  src="https://code.jquery.com/jquery-3.5.1.js"
  integrity="sha256-QWo7LDvxbWT2tbbQ97B53yJnYU3WhH/C8ycbRAkjPDc="
  crossorigin="anonymous"></script>


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
                                    <li ><a href="/lic-server/">START NEW PROJECT</a></li>
                                    <li class="active"><a href="#">VIEW EXISTING PROJECTS</a></li>
                                    
                                </ul>


                                <div class="tab-content toshiba-content " style="">
                                    <div id="home" class="tab-pane fade in active">                                        
                                        <div style="margin-top: 30px; height: 1060px;">                                                                                                                                                                          
                                            <div class="container">
                                               
                                                
                                                      <table class="table table-bordered" id="existingprojects" style="margin-left: -10px;">
                                                                  <thead class="thead-light">
                                                                    <tr>
                                                                      <th scope="col" style="background-color: #0b1f65;">No.</th>
                                                                      <th scope="col" style="background-color: #0b1f65;">Project Name</th>
                                                                      <th scope="col" style="background-color: #0b1f65;">Last Edit Date</th>
                                                                     <%-- <th scope="col" style="background-color: #0b1f65;">Edit by</th>
                                                                        <th scope="col" style="background-color: #0b1f65;">Downloaded</th>--%>
                                                                    </tr>
                                                                  </thead>
                                                                  <tbody>
                                                                    
                                                                   <%=m_TableData %>


                                                                  </tbody>
                                                                </table>
                                                
                                               

    
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



        <script type="text/javascript" charset="utf8" src="https://cdn.datatables.net/1.10.21/js/jquery.dataTables.js"></script>




    <script>


        $(document).ready( function () {
    $('#existingprojects').DataTable( {
        "order": [[0, "desc"]],
          "pageLength": 50
    } );
} );

    </script>

    <style>

        .dataTables_filter{
            margin-right: 12px;
        }

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