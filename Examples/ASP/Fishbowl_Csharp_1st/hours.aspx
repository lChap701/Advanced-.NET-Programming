<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hours.aspx.cs" Inherits="Fishbowl_Csharp.hours" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>The Fishbowl Emporium</title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
        .auto-style2 {
            font-size: large;
            color: #FF0000;
        }
        .auto-style3 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style3">
    
        <span class="auto-style1"><em>Please stop in and see us during these hours:</em></span><br />
        <br />
        <span class="auto-style2"><strong>Monday - Friday 8am - 8pm</strong></span><strong><br class="auto-style2" />
        </strong><span class="auto-style2"><strong>Saturday 9am - 5pm</strong></span><strong><br class="auto-style2" />
        </strong><span class="auto-style2"><strong>Closed Sunday</strong></span><br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/default.aspx">Home Page</asp:HyperLink>
        <br /><br />
         <asp:Button ID="Home" runat="server" Text="Button" OnClick="Home_Click" />
    </div>      
    </form>
</body>
</html>
