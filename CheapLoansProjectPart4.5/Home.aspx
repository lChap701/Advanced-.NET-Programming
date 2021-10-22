<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="CheapLoansProjectPart4._5.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <link href="css/Styles.css" rel="stylesheet" />
</head>
<body>
    <form id="home" runat="server">
        <asp:Menu runat="server" ID="NavMenu" Orientation="Horizontal">
            <StaticMenuItemStyle HorizontalPadding="8" />
            <StaticHoverStyle ForeColor="#dddddd" />

            <Items>
                <asp:MenuItem Text="Home" ToolTip="Home" NavigateUrl="~/Home.aspx" />
                <asp:MenuItem Text="Loans" ToolTip="Loans" NavigateUrl="~/Loans.aspx" />
                <asp:MenuItem Text="Loans By Customer" ToolTip="Loans By Customer" NavigateUrl="~/LoansByCustomer.aspx" />
            </Items>
        </asp:Menu>

        <h1>Welcome to Cheap Loans' Loan Tracker!</h1>
        <div class="container">
            <div class="col">
                <h3>What is this website for?</h3>
                <p>You can use this website to:</p>
                <asp:BulletedList ID="List" runat="server">
                    <asp:ListItem Text="View all customers' loans by visiting the Loans page" />
                    <asp:ListItem Text="Search for loans using the names of customers by visiting the Loans By Customer page" />
                </asp:BulletedList>
            </div>

            <div class="col">
                <h3>Loan Information</h3>
                <b>
                    <asp:Literal ID="Indicator" runat="server" />
                </b><br />
                <br />
                <i>Note: The number of loans available is always changing! So this number may change at any time!</i>
                <p><b>Last Checked: </b>
                    <asp:Literal ID="Date" runat="server" /></p>
            </div>
        </div>
    </form>
</body>
</html>
