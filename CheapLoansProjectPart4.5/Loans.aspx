<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Loans.aspx.cs" Inherits="CheapLoansProjectPart4._5.Loans" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Loans</title>
    <link href="css/Styles.css" rel="stylesheet" />
</head>
<body>
    <form id="loans" runat="server">
        <asp:Menu runat="server" ID="NavMenu" Orientation="Horizontal">
            <StaticMenuItemStyle HorizontalPadding="8" />
            <StaticHoverStyle ForeColor="#dddddd" />

            <Items>
                <asp:MenuItem Text="Home" ToolTip="Home" NavigateUrl="~/Home.aspx" />
                <asp:MenuItem Text="Loans" ToolTip="Loans" NavigateUrl="~/Loans.aspx" />
                <asp:MenuItem Text="Loans By Customer" ToolTip="Loans By Customer" NavigateUrl="~/LoansByCustomer.aspx" />
            </Items>
        </asp:Menu>

        <h1>Welcome to the Loans Form!</h1>
        <div class="container">
            <h2>Loans Form</h2>

            <div class="col">
                <asp:Label ID="HelpMsg" runat="server" Font-Bold="true"
                    Text="Click 'View Loans' to display all of our customer's loans" />

                <asp:Label ID="Msg" runat="server" Font-Bold="true" Font-Size="Large" ForeColor="Red" Visible="false" />

                <asp:GridView ID="LoansGridView" runat="server" CellPadding="10" AllowSorting="true" 
                    AutoGenerateColumns="false" AutoGenerateSelectButton="true" DataKeyNames="LoanNum"
                    OnSorting="LoansGridView_Sorting" OnSelectedIndexChanged="LoansGridView_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="LoanNum" HeaderText="Loan Number" InsertVisible="false" 
                            ReadOnly="true" SortExpression="LoanNum" DataFormatString="{0:D11}" />
                        <asp:BoundField DataField="CustName" HeaderText="Customer Name" ReadOnly="true" 
                            SortExpression="CustName" />
                        <asp:BoundField DataField="LoanAmount" HeaderText="Loan Amount" ReadOnly="true" 
                            SortExpression="LoanAmount" DataFormatString="{0:C}" />
                        <asp:BoundField DataField="AnnualIntRate" HeaderText="Annual Interest Rate" 
                            ReadOnly="true" SortExpression="AnnualIntRate" DataFormatString="{0:P1}"
                            ItemStyle-HorizontalAlign="Right" />
                        <asp:BoundField DataField="NumPayments" HeaderText="Number of Payments" 
                            ReadOnly="true" SortExpression="NumPayments" DataFormatString="{0:D}"
                            ItemStyle-HorizontalAlign="Right" />
                    </Columns>

                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Font-Bold="true" />
                    <RowStyle CssClass="row" />
                    <SelectedRowStyle BackColor="#f5f5f5" CssClass="selected" />
                    <SortedAscendingHeaderStyle CssClass="asc" />
                    <SortedDescendingHeaderStyle CssClass="desc" />
                </asp:GridView>
            </div>

            <div class="col">
                <div class="btn-container">
                    <asp:Button ID="ViewData" runat="server" Text="View Loans" CausesValidation="false"
                        UseSubmitBehavior="false" OnClientClick="alert('Loading data...')" OnClick="ViewData_Click" />
                    <asp:Button ID="Reset" runat="server" Text="Clear Sort" CausesValidation="false"
                        UseSubmitBehavior="false" OnClientClick="alert('The form has been resetted')"
                        OnClick="Reset_Click" Enabled="false" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
