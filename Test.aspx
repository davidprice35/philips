<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Test.aspx.cs" Inherits="Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="text1" runat="server"></asp:TextBox>


            <asp:Button ID="cmdSet1" runat="server" Text="Button1" OnClick="cmdSet1_Click" />
            <asp:Button ID="cmdSet2" runat="server" Text="Button2" OnClick="cmdSet2_Click" />
            <asp:Button ID="cmdSet3" runat="server" Text="Button3" OnClick="cmdSet3_Click" />
        </div>
    </form>


    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>    
    <script src="js/bootstrap.min.js"></script>	
	<script  src="js/colResizable-1.6.min.js"></script>
    <script src="js/custom.js"></script>

</body>
</html>
