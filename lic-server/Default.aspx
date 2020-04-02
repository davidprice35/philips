<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="competitive_info_Competitors" %>


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
                                    <li class="active"><a href="/">START NEW PROJECT</a></li>
                                    <li><a href="/lic-server/ViewExisting.aspx">VIEW EXISTING PROJECTS</a></li>
                                    
                                </ul>


                                <div class="tab-content toshiba-content " style="">
                                    <div id="home" class="tab-pane fade in active">                                        
                                        <div style="margin-top: 30px; height: 1060px;">                                                                                                                                                                          
                                            <div class="container">
                                               



                                            
    
<div class="table-responsive" style="margin-left: -16px;" >
<table class="table table-bordered">
  <thead>
    <tr>
        <th scope="col"  style="background-color: #0b1f65; border-right-color:#0b1f65;text-align: left; padding-left: 16px;width: 200px"> Project Name </th>      
          <th scope="col" style="background-color: #0b1f65;"></th> 
    </tr>
  </thead>
  <tbody>
    <tr>
     
      <td style="vertical-align: middle;"> Project Name* </td>
      <td><asp:TextBox ID="txtProjectName" CssClass="form-control" runat="server" style="margin-top: 3px;"></asp:TextBox></td>
    
    </tr>

       
  </tbody>
</table>
</div>




<div class="table-responsive" style="margin-left: -16px;" >
<table class="table table-bordered">
  <thead>
    <tr>
        <th scope="col"  style="background-color: #0b1f65; border-right-color:#0b1f65;text-align: left; padding-left: 16px;width:  200px">Customer</th>      
          <th scope="col" style="background-color: #0b1f65;"></th> 
    </tr>
  </thead>
  <tbody>
    <tr>
     
      <td style="vertical-align: middle;">Customer Name* </td>
      <td><asp:TextBox ID="txtCustomerName" CssClass="form-control" runat="server" style="margin-top: 3px;"></asp:TextBox></td>
    
    </tr>

      <tr>

          <td>Customer Address*</td> 
          <td>  <asp:TextBox ID="txtCustomerAddress" CssClass="form-control" runat="server" TextMode="MultiLine" style=""></asp:TextBox></td>

      </tr>


      <tr>

          <td>Country</td> 
          <td> <asp:DropDownList ID="txtCountry"  CssClass="form-control" runat="server">
                          
<asp:ListItem >Algeria</asp:ListItem>
<asp:ListItem >Angola</asp:ListItem>
<asp:ListItem >Benin</asp:ListItem>
<asp:ListItem >Botswana</asp:ListItem>
<asp:ListItem >Burkina Faso</asp:ListItem>
<asp:ListItem >Burundi</asp:ListItem>
<asp:ListItem >Cameroon</asp:ListItem>
<asp:ListItem >Cape Verde</asp:ListItem>
<asp:ListItem >Central Africa</asp:ListItem>
<asp:ListItem >Chad</asp:ListItem>
<asp:ListItem >Congo</asp:ListItem>
<asp:ListItem >Congo, Democrat</asp:ListItem>
<asp:ListItem >Djibouti</asp:ListItem>
<asp:ListItem >Egypt</asp:ListItem>
<asp:ListItem >Equatorial Guinea</asp:ListItem>
<asp:ListItem >Eritrea</asp:ListItem>
<asp:ListItem >Ethiopia</asp:ListItem>
<asp:ListItem >Gabon</asp:ListItem>
<asp:ListItem >Gambia</asp:ListItem>
<asp:ListItem >Ghana</asp:ListItem>
<asp:ListItem >Guinea-Bissau</asp:ListItem>
<asp:ListItem >Guinee</asp:ListItem>
<asp:ListItem >Ivory Coast</asp:ListItem>
<asp:ListItem >Kenya</asp:ListItem>
<asp:ListItem >Liberia</asp:ListItem>
<asp:ListItem >Libya</asp:ListItem>
<asp:ListItem >Madagascar</asp:ListItem>
<asp:ListItem >Malawi</asp:ListItem>
<asp:ListItem >Mali</asp:ListItem>
<asp:ListItem >Mauretania</asp:ListItem>
<asp:ListItem >Mauritius</asp:ListItem>
<asp:ListItem >Morocco</asp:ListItem>
<asp:ListItem >Mozambique</asp:ListItem>
<asp:ListItem >Namibia</asp:ListItem>
<asp:ListItem >Niger</asp:ListItem>
<asp:ListItem >Nigeria</asp:ListItem>
<asp:ListItem >Rwanda</asp:ListItem>
<asp:ListItem >Senegal</asp:ListItem>
<asp:ListItem >Seychelles</asp:ListItem>
<asp:ListItem >Siera Leone</asp:ListItem>
<asp:ListItem >Somalia</asp:ListItem>
<asp:ListItem >South Africa</asp:ListItem>
<asp:ListItem >Sudan</asp:ListItem>
<asp:ListItem >Swaziland</asp:ListItem>
<asp:ListItem >Tanzania</asp:ListItem>
<asp:ListItem >Togo</asp:ListItem>
<asp:ListItem >Tunesia</asp:ListItem>
<asp:ListItem >Uganda</asp:ListItem>
<asp:ListItem >Western Sahara</asp:ListItem>
<asp:ListItem >Zambia</asp:ListItem>
<asp:ListItem >Zimbabwe</asp:ListItem>
<asp:ListItem >Austria</asp:ListItem>
<asp:ListItem >Switzerland</asp:ListItem>
<asp:ListItem >Cambodia</asp:ListItem>
<asp:ListItem >Indonesia</asp:ListItem>
<asp:ListItem >Laos</asp:ListItem>
<asp:ListItem >Malaysia</asp:ListItem>
<asp:ListItem >Philippines</asp:ListItem>
<asp:ListItem >Singapore</asp:ListItem>
<asp:ListItem >Thailand</asp:ListItem>
<asp:ListItem >Brunei</asp:ListItem>
<asp:ListItem >Vietnam</asp:ListItem>
<asp:ListItem >Australia</asp:ListItem>
<asp:ListItem >New Zealand</asp:ListItem>
<asp:ListItem >Belgium</asp:ListItem>
<asp:ListItem >Luxembourg</asp:ListItem>
<asp:ListItem >Netherlands</asp:ListItem>
<asp:ListItem >Albania</asp:ListItem>
<asp:ListItem >Armenia</asp:ListItem>
<asp:ListItem >Belarus</asp:ListItem>
<asp:ListItem >Bosnia</asp:ListItem>
<asp:ListItem >Bulgaria</asp:ListItem>
<asp:ListItem >Canary Islands</asp:ListItem>
<asp:ListItem >Croatia</asp:ListItem>
<asp:ListItem >Cyprus</asp:ListItem>
<asp:ListItem >Czech Republic</asp:ListItem>
<asp:ListItem >Estonia</asp:ListItem>
<asp:ListItem >French Guiana</asp:ListItem>
<asp:ListItem >French Polynesia</asp:ListItem>
<asp:ListItem >French S. Teriit.</asp:ListItem>
<asp:ListItem >Georgia</asp:ListItem>
<asp:ListItem >Guadaloupe</asp:ListItem>
<asp:ListItem >Hungary</asp:ListItem>
<asp:ListItem >Latvia</asp:ListItem>
<asp:ListItem >Liechtenstein</asp:ListItem>
<asp:ListItem >Lithuania</asp:ListItem>
<asp:ListItem >Macedonia</asp:ListItem>
<asp:ListItem >Moldova</asp:ListItem>
<asp:ListItem >Montenegro</asp:ListItem>
<asp:ListItem >Poland</asp:ListItem>
<asp:ListItem >Romania</asp:ListItem>
<asp:ListItem >Serbia</asp:ListItem>
<asp:ListItem >Slovakia</asp:ListItem>
<asp:ListItem >Slovenia</asp:ListItem>
<asp:ListItem >Yugoslavia</asp:ListItem>
<asp:ListItem >China</asp:ListItem>
<asp:ListItem >Hong Kong</asp:ListItem>
<asp:ListItem >Taiwan</asp:ListItem>
<asp:ListItem >France</asp:ListItem>
<asp:ListItem >Monaco</asp:ListItem>
<asp:ListItem >Germany</asp:ListItem>
<asp:ListItem >Portugal</asp:ListItem>
<asp:ListItem >Spain</asp:ListItem>
<asp:ListItem >Greece</asp:ListItem>
<asp:ListItem >Israel</asp:ListItem>
<asp:ListItem >Italy</asp:ListItem>
<asp:ListItem >Malta</asp:ListItem>
<asp:ListItem >Afganistan</asp:ListItem>
<asp:ListItem >BanglaDesh</asp:ListItem>
<asp:ListItem >India</asp:ListItem>
<asp:ListItem >Myanmar</asp:ListItem>
<asp:ListItem >Nepal</asp:ListItem>
<asp:ListItem >Pakistan</asp:ListItem>
<asp:ListItem >Sri Lanka</asp:ListItem>
<asp:ListItem >Japan</asp:ListItem>
<asp:ListItem >South Korea</asp:ListItem>
<asp:ListItem >American Viigin Isl</asp:ListItem>
<asp:ListItem >Argentina</asp:ListItem>
<asp:ListItem >Aruba</asp:ListItem>
<asp:ListItem >Bahamas</asp:ListItem>
<asp:ListItem >Barbados</asp:ListItem>
<asp:ListItem >Belize</asp:ListItem>
<asp:ListItem >Bermuda</asp:ListItem>
<asp:ListItem >Bolivia</asp:ListItem>
<asp:ListItem >Brazil</asp:ListItem>
<asp:ListItem >British Virgin Isl</asp:ListItem>
<asp:ListItem >Cayman Islands</asp:ListItem>
<asp:ListItem >Chile</asp:ListItem>
<asp:ListItem >Colombia</asp:ListItem>
<asp:ListItem >Costa Rica</asp:ListItem>
<asp:ListItem >Dominican Rep.</asp:ListItem>
<asp:ListItem >Dutch Antilles</asp:ListItem>
<asp:ListItem >Ecuador</asp:ListItem>
<asp:ListItem >El Salvador</asp:ListItem>
<asp:ListItem >Guatemala</asp:ListItem>
<asp:ListItem >Guyana</asp:ListItem>
<asp:ListItem >Haiti</asp:ListItem>
<asp:ListItem >Honduras</asp:ListItem>
<asp:ListItem >Jamaica</asp:ListItem>
<asp:ListItem >Mexico</asp:ListItem>
<asp:ListItem >Nicaragua</asp:ListItem>
<asp:ListItem >Panama</asp:ListItem>
<asp:ListItem >Paraguay</asp:ListItem>
<asp:ListItem >Peru</asp:ListItem>
<asp:ListItem >Puerto Rico</asp:ListItem>
<asp:ListItem >Suriname</asp:ListItem>
<asp:ListItem >Trinidad & Tobago</asp:ListItem>
<asp:ListItem >Uruguay</asp:ListItem>
<asp:ListItem >Venezuela</asp:ListItem>
<asp:ListItem >Bharain</asp:ListItem>
<asp:ListItem >Iran</asp:ListItem>
<asp:ListItem >Iraq</asp:ListItem>
<asp:ListItem >Jordan</asp:ListItem>
<asp:ListItem >Kuwait</asp:ListItem>
<asp:ListItem >Lebanon</asp:ListItem>
<asp:ListItem >Oman</asp:ListItem>
<asp:ListItem >Palestine</asp:ListItem>
<asp:ListItem >Qatar</asp:ListItem>
<asp:ListItem >Saudi Arabia</asp:ListItem>
<asp:ListItem >Syria</asp:ListItem>
<asp:ListItem >Turkey</asp:ListItem>
<asp:ListItem >United Arab Em.</asp:ListItem>
<asp:ListItem >Yemen</asp:ListItem>
<asp:ListItem >Denmark</asp:ListItem>
<asp:ListItem >Finland</asp:ListItem>
<asp:ListItem >Iceland</asp:ListItem>
<asp:ListItem >Norway</asp:ListItem>
<asp:ListItem >Sweden</asp:ListItem>
<asp:ListItem >Canada</asp:ListItem>
<asp:ListItem >USA</asp:ListItem>
<asp:ListItem >Azerbaijan</asp:ListItem>
<asp:ListItem >Kazakstan</asp:ListItem>
<asp:ListItem >Kyrgyztan</asp:ListItem>
<asp:ListItem >Mongolia</asp:ListItem>
<asp:ListItem >Russian Fed</asp:ListItem>
<asp:ListItem >Tajikistan</asp:ListItem>
<asp:ListItem >Turkmenistan</asp:ListItem>
<asp:ListItem >Ukraine</asp:ListItem>
<asp:ListItem >Uzbekistan</asp:ListItem>
<asp:ListItem >Ireland</asp:ListItem>
<asp:ListItem >United Kingdom</asp:ListItem>
<asp:ListItem >Great Britain</asp:ListItem>
<asp:ListItem >Cuba</asp:ListItem>
<asp:ListItem >Korea, North</asp:ListItem>
<asp:ListItem >American Samoa</asp:ListItem>
<asp:ListItem >Andorra</asp:ListItem>
<asp:ListItem >Anguilla</asp:ListItem>
<asp:ListItem >Antarctica</asp:ListItem>
<asp:ListItem >Antigua and Barbuda</asp:ListItem>
<asp:ListItem >Bhutan</asp:ListItem>
<asp:ListItem >British Indian Ocean Territory</asp:ListItem>
<asp:ListItem >Christmas Island</asp:ListItem>
<asp:ListItem >Cocos (Keeling) Islands</asp:ListItem>
<asp:ListItem >Comoros</asp:ListItem>
<asp:ListItem >Cook Islands</asp:ListItem>
<asp:ListItem >Dominica</asp:ListItem>
<asp:ListItem >Falkland Islands</asp:ListItem>
<asp:ListItem >Faroe Islands</asp:ListItem>
<asp:ListItem >Fiji</asp:ListItem>
<asp:ListItem >Gibraltar</asp:ListItem>
<asp:ListItem >Greenland</asp:ListItem>
<asp:ListItem >Grenada</asp:ListItem>
<asp:ListItem >Guam</asp:ListItem>
<asp:ListItem >Holy See (Vatican City)</asp:ListItem>
<asp:ListItem >Isle of Man</asp:ListItem>
<asp:ListItem >Jersey</asp:ListItem>
<asp:ListItem >Kiribati</asp:ListItem>
<asp:ListItem >Lesotho</asp:ListItem>
<asp:ListItem >Macau</asp:ListItem>
<asp:ListItem >Maldives</asp:ListItem>
<asp:ListItem >Marshall Islands</asp:ListItem>
<asp:ListItem >Mayotte</asp:ListItem>
<asp:ListItem >Micronesia</asp:ListItem>
<asp:ListItem >Montserrat</asp:ListItem>
<asp:ListItem >Nauru</asp:ListItem>
<asp:ListItem >New Caledonia</asp:ListItem>
<asp:ListItem >Niue</asp:ListItem>
<asp:ListItem >Northern Mariana Islands</asp:ListItem>
<asp:ListItem >Palau</asp:ListItem>
<asp:ListItem >Papua New Guinea</asp:ListItem>
<asp:ListItem >Pitcairn Islands</asp:ListItem>
<asp:ListItem >Saint Barthelemy</asp:ListItem>
<asp:ListItem >Saint Helena</asp:ListItem>
<asp:ListItem >Saint Kitts and Nevis</asp:ListItem>
<asp:ListItem >Saint Lucia</asp:ListItem>
<asp:ListItem >Saint Martin</asp:ListItem>
<asp:ListItem >Saint Pierre and Miquelon</asp:ListItem>
<asp:ListItem >Saint Vincent and the Grenadines</asp:ListItem>
<asp:ListItem >Samoa</asp:ListItem>
<asp:ListItem >San Marino</asp:ListItem>
<asp:ListItem >Sao Tome and Principe</asp:ListItem>
<asp:ListItem >Solomon Islands</asp:ListItem>
<asp:ListItem >Svalbard</asp:ListItem>
<asp:ListItem >Timor-Leste</asp:ListItem>
<asp:ListItem >Tokelau</asp:ListItem>
<asp:ListItem >Tonga</asp:ListItem>
<asp:ListItem >Turks and Caicos Islands</asp:ListItem>
<asp:ListItem >Tuvalu</asp:ListItem>
<asp:ListItem >Vanuatu</asp:ListItem>
<asp:ListItem >Wallis and Futuna</asp:ListItem>
<asp:ListItem >Curacao</asp:ListItem>
<asp:ListItem >Guernsey</asp:ListItem>
<asp:ListItem >Kosovo</asp:ListItem>
<asp:ListItem >Reunion</asp:ListItem>
<asp:ListItem >Sint Maarten</asp:ListItem>
<asp:ListItem >South Sudan</asp:ListItem>
<asp:ListItem >Martinique</asp:ListItem>




               </asp:DropDownList>

    
          </td>

      </tr>
   
  </tbody>
</table>
</div>

    

<div class="table-responsive" style="margin-left: -16px;" >
<table class="table table-bordered">
  <thead>
    <tr>
        <th scope="col"  style="background-color: #0b1f65; border-right-color:#0b1f65;text-align: left; padding-left: 16px;width: 200px"> Ordering Information </th>      
          <th scope="col" style="background-color: #0b1f65;"></th> 
    </tr>
  </thead>
  <tbody>
    <tr>
     
      <td style="vertical-align: middle;">  PO Number*</td>
      <td><asp:TextBox ID="txtPONumber" CssClass="form-control" runat="server" style="margin-top: 3px;"></asp:TextBox></td>
    
    </tr>

       
  </tbody>
</table>
</div>



<div class="table-responsive" style="margin-left: -16px;" >
<table class="table table-bordered">
  <thead>
    <tr>
        <th scope="col"  colspan="4"  style="background-color: #0b1f65; border-right-color:#0b1f65;text-align: left; padding-left: 16px;width: 640px"> Project Manager </th>      
          
    </tr>
  </thead>
  <tbody>
    <tr>
     
      <td style="vertical-align: middle;">InteliSpace Portal Sales Specialist</td>
        <td>
            <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server" style="margin-top: 3px;"></asp:TextBox>
            <label for="sdsdsd"><span> + Add new member </span></label>
        </td>
        <td>            
            <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server" style="margin-top: 3px;"></asp:TextBox>
        </td>
        <td>            
            <asp:TextBox ID="TextBox3" CssClass="form-control" runat="server" style="margin-top: 3px;"></asp:TextBox>
        </td>    
    </tr>
      <tr>
     
      <td style="vertical-align: middle;">Key Account Manager</td>
        <td>
            <asp:TextBox ID="TextBox4" CssClass="form-control" runat="server" style="margin-top: 3px;"></asp:TextBox>
            <label for="sdsdsd"><span> + Add new member </span></label>
        </td>
        <td>            
            <asp:TextBox ID="TextBox5" CssClass="form-control" runat="server" style="margin-top: 3px;"></asp:TextBox>
        </td>
        <td>            
            <asp:TextBox ID="TextBox6" CssClass="form-control" runat="server" style="margin-top: 3px;"></asp:TextBox>
        </td>    
    </tr>
        <tr>
     
      <td style="vertical-align: middle;">Project core team*</td>
        <td>
            <asp:TextBox ID="TextBox7" CssClass="form-control" runat="server" style="margin-top: 3px;"></asp:TextBox>
            <label for="sdsdsd"><span> + Add new member </span></label>
        </td>
        <td>            
            <asp:TextBox ID="TextBox8" CssClass="form-control" runat="server" style="margin-top: 3px;"></asp:TextBox>
        </td>
        <td>            
            <asp:TextBox ID="TextBox9" CssClass="form-control" runat="server" style="margin-top: 3px;"></asp:TextBox>
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