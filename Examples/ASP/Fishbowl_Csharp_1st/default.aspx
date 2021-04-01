<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Fishbowl_Csharp._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>The Fishbowl Emporium</title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <h1 class="auto-style1">The Fishbowl Emporium</h1>
        <div class="auto-style1">
            <br />
        </div>
        <h2 class="auto-style1">150 Jefferson Street<br />
            Chico, CA 95926<br />
            (111) 555-5555</h2>
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/hours.aspx">Store Hours</asp:HyperLink>
        <br />
        <br />
        <asp:Image ID="Image1" runat="server" BorderColor="#009900" BorderStyle="Dotted" BorderWidth="10px" Height="175px" ImageUrl="~/FishInBowl.png" Width="255px" />
    
    </div>
    </form>
</body>
</html>
