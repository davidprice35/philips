<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MVMatrix-CopyData.aspx.cs" Inherits="Admin_MVMatrix_Edit" %>





<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>Attachments Edit</title>

    <!-- Bootstrap -->
    <link href="/css/bootstrap.min.css" rel="stylesheet">
    <link href="../competitive-info/css/style.css" rel="stylesheet">
    <link href="/css/responsive.css" rel="stylesheet">
    <link rel="stylesheet" href="../css/font-awesome.min.css">
     <script src='<%= Page.ResolveClientUrl("~/js/ej/jquery-1.11.3.min.js")%>' type="text/javascript"></script>
        <script src="/js/bootstrap.min.js"></script>
    <script src="/js/bootstrap-confirmation.min.js"></script>


    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->


</head>
<body>

    <form runat="server">
        
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
                                        <li class="user-dropdown ">

                                            <div class="drop-down">
                                                <button class="btn btn-primary dropdown-toggle" type="button" data-toggle="dropdown">
                                                    Hello <%=m_UserName %> <span class=""></span>
                                                </button>
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


                                                        <a href='/Admin/UserProfile' class='view_prfl'>View profile <span><i class='fa fa-angle-right' aria-hidden='true'></i></span></a>
            <a href='/Admin/UsageTracking' class='view_prfl'>View tracking <span><i class='fa fa-angle-right' aria-hidden='true'></i></span></a>

                                                        


                                                        <script>

                                                            function Myclick() {
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



                        <div class="userprofile-section" style="width: 70% !important;">
                            <div class="container">
                                <div class="row">
                                    <div class="user-profiles">
                                        <div class="col-xs-12 col-sm-4 col-md-4 col-lg-4 total-title">
                                            <h4>MV Matrix </h4>
                                        </div>
                                        <div class="col-xs-12 col-sm-8 col-md-8 col-lg-8 add-section-block">
                                            <div class="add-section">
                                                <ul class="list-inline text-right">
                                                    <li>

                                                       

                                                    </li>

                                                    <li>


                                                        

                                                    </li>
                                                </ul>
                                            </div>
                                        </div>

                                    </div>


                                    

                                    <div class="profile-grid">


                                        <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12 profile-grid-table">

                                           
                                           

  <ul class="nav nav-tabs">
    <li class="active"><a data-toggle="tab" href="#home">Copy</a></li>
    <li><a data-toggle="tab" href="#menu1">Delete</a></li>
    <li><a data-toggle="tab" href="#menu2">Approve Copy Matrix</a></li>
  </ul>

  <div class="tab-content">
    <div id="home" class="tab-pane fade in active">
      <div class="table-grid-attachments table-responsive">




          
              <ContentTemplate>

        <table width="100%" height="100px" border="1" >
            <thead>
                <tr style="height: 42px; background-color:#012663;">
                    <th style="color:white;background:#012663 !important;">ISP From</th>                                                            
                    <th style="color:white;background:#012663 !important;">ISP New</th>                                                            
                    <th style="color:white;background:#012663 !important;" width="150px" class="text-center">Add/Replace File</th>
                                                                                                                        
                </tr>
            </thead>
            <tbody>

                                                       
                <tr>
                                                                    
                                                                   
                            <td>
                                    <asp:DropDownList ID="cmdEditItem"  Width="250" runat="server">
                                    <asp:ListItem>9.0</asp:ListItem>
                                    <asp:ListItem>10.0</asp:ListItem>                                                           
                                    </asp:DropDownList>
                            </td>

                            <td>
                                <asp:TextBox ID="txtNewISP" Width="250" runat="server"></asp:TextBox>
                            </td>

                                                                   

                            <td>
                                <div class="btn-ul-list">
                                    <ul class="list-inline">
                                        <li>

                                                                                    

                                        </li>
                                        <li>




                                            <asp:LinkButton ID="cmdCopy" OnClientClick="ShowProgressBar();"  OnClick="cmdCopy_Click" CssClass="confirmation-callback12" data-placement="top" style="z-index:auto;" runat="server"> <i class="fa fa-pencil-square-o"></i><span style="color:#012663;">Copy</span> </asp:LinkButton>
                                            
                                            
                                        </li>
                                    </ul>
                                </div>
                            </td>
                        </tr>
                
            </tbody>
        </table>


                  <style>

                      .progress-bar {
    width: calc(100% - 6px);
    height: 5px;
    background: #e0e0e0;
    padding: 3px;
    border-radius: 3px;
    box-shadow: inset 0 1px 3px rgba(0, 0, 0, .2);
}

.progress-bar-fill {
    display: block;
    height: 5px;
    background: #659cef;
    border-radius: 3px;
    /*transition: width 250ms ease-in-out;*/
    transition: width 200s ease-in-out;
}

                  </style>

            
          <p>Please allow 2 mins to copy data</p>

                  <div class="progress-bar">
    <span class="progress-bar-fill" style="width: 10%"></span>
</div>

<script>
    HideProgressBar();
    function HideProgressBar() {        
        document.getElementsByClassName('progress-bar')[0].style.display  = 'none';
    }

    function ShowProgressBar() {
        document.getElementsByClassName('progress-bar')[0].style.display = 'block';
        document.getElementById('lblCopy').style.display = 'none';
    }

    $('.progress-bar-fill').delay(5000).queue(function () {
        $(this).css('width', '100%')
        document.getElementById('lblCopy').style.display = 'block';
    });

</script>
          
          <asp:Label ID="lblCopy" runat="server" ></asp:Label>
                
              
          

        
                              
          
          <br />
          <br/>
                                            <br/>
                                            <br/>

           



      </div>
    </div>
    <div id="menu1" class="tab-pane fade">
       <div class="table-grid-attachments table-responsive">
        <table width="100%" height="100px" border="1" >
            <thead>
                <tr style="height: 42px; background-color:#012663;">
                    <th style="color:white;background:#012663 !important;">ISP</th>                                                                                
                    <th style="color:white;background:#012663 !important;" width="150px" class="text-center">Delete</th>
                                                                                                                        
                </tr>
            </thead>
            <tbody>

                                                       
                <tr>
                                                                    
                                                                   
                            <td>
                                    <asp:DropDownList ID="cmdISP"  Width="250" runat="server">
                                                                                           
                                    </asp:DropDownList>
                            </td>

                                                                                            

                            <td>
                                <div class="btn-ul-list">
                                    <ul class="list-inline">
                                        <li>

                                                                                    

                                        </li>
                                        <li>

                                            <asp:LinkButton ID="cmdDelete"  OnClick="cmdDelete_Click" CssClass="confirmation-callback1234" data-placement="top" style="z-index:auto;" runat="server"> <i class="fa fa-pencil-square-o"></i><span style="color:#012663;">Delete</span> </asp:LinkButton>

                                        </li>
                                    </ul>
                                </div>
                            </td>
                        </tr>

            </tbody>
        </table>                                                                                                
      </div>
    </div>

       <div id="menu2" class="tab-pane fade">
       <div class="table-grid-attachments table-responsive">
        <table width="100%" height="100px" border="1" >
            <thead>
                <tr style="height: 42px; background-color:#012663;">
                    <th style="color:white;background:#012663 !important;">Approve Copy Matrix</th>                                                                                
                    <th style="color:white;background:#012663 !important;" width="150px" class="text-center">Approve</th>
                                                                                                                        
                </tr>
            </thead>
            <tbody>

                                                       
                <tr>
                                                                    
                                                                   
                            <td>
                                    <asp:DropDownList ID="cmdApproveList"  Width="250" runat="server">
                                                                                           
                                    </asp:DropDownList>
                            </td>

                                                                                            

                            <td>
                                <div class="btn-ul-list">
                                    <ul class="list-inline">
                                        <li>

                                                                                    

                                        </li>
                                        <li>

                                            <asp:LinkButton ID="cmdApproveLink"  OnClick="cmdApproveLink_Click" CssClass="confirmation-callback1234" data-placement="top" style="z-index:auto;" runat="server"> <i class="fa fa-pencil-square-o"></i><span style="color:#012663;">Approve</span> </asp:LinkButton>

                                        </li>
                                    </ul>
                                </div>
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
        </div>
    </form>




    <footer class="footer blue-backround">
        <div class="container">
            <div class="row">
                <img src="images/white-logo.png" class="img-responsive">
                <h5><span>Privacy notice  |  Terms of use</span>
                    <br>
                    © Koninklijke Philips N.V., 2004 - 2019. All rights reserved. </h5>
            </div>
        </div>
    </footer>


   
    <script>
        $(document).on('show', '.accordion', function (e) {
            //$('.accordion-heading i').toggleClass(' ');
            $(e.target).prev('.accordion-heading').addClass('accordion-opened');
        });

        $(document).on('hide', '.accordion', function (e) {
            $(this).find('.accordion-heading').not($(e.target)).removeClass('accordion-opened');
            //$('.accordion-heading i').toggleClass('fa-chevron-right fa-chevron-down');
        });
    </script>




</body>

</html>
