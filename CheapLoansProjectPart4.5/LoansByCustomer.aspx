<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoansByCustomer.aspx.cs" Inherits="CheapLoansProjectPart4._5.LoansByCustomer" UnobtrusiveValidationMode="None" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Loans By Customer</title>
    <link href="css/Styles.css" rel="stylesheet" />
</head>
<body>
    <form id="customer" runat="server">
        <asp:Menu runat="server" ID="NavMenu" Orientation="Horizontal">
            <StaticMenuItemStyle HorizontalPadding="8" />
            <StaticHoverStyle ForeColor="#dddddd" />

            <Items>
                <asp:MenuItem Text="Home" ToolTip="Home" NavigateUrl="~/Home.aspx" />
                <asp:MenuItem Text="Loans" ToolTip="Loans" NavigateUrl="~/Loans.aspx" />
                <asp:MenuItem Text="Loans By Customer" ToolTip="Loans By Customer" NavigateUrl="~/LoansByCustomer.aspx" />
            </Items>
        </asp:Menu>

        <h1>Welcome to the Loans By Customer Form!</h1>
        <div class="container">
            <h2>Loans By Customer Form</h2>

            <div class="col">
                <asp:Label ID="HelpMsg" runat="server" Font-Bold="true"
                    Text="Click 'Find Loans' after filling out the form to display related loans"></asp:Label>

                <asp:Label ID="Msg" runat="server" Font-Bold="true" Font-Size="Large" ForeColor="Red"
                    Visible="false"></asp:Label>

                <asp:GridView ID="LoansGridView" runat="server" CellPadding="10" AllowSorting="true"
                    AutoGenerateColumns="false" AutoGenerateSelectButton="true" DataKeyNames="LoanNum"
                    OnSorting="LoansGridView_Sorting" OnSelectedIndexChanged="LoansGridView_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="LoanNum" HeaderText="Loan Number" InsertVisible="false" 
                            ReadOnly="True" SortExpression="LoanNum" DataFormatString="{0:D11}" 
                            ItemStyle-HorizontalAlign="Center" />
                        <asp:BoundField DataField="CustName" HeaderText="Customer Name" ReadOnly="true" 
                            SortExpression="CustName" ItemStyle-HorizontalAlign="Center" />
                        <asp:BoundField DataField="LoanAmount" HeaderText="Loan Amount" ReadOnly="true" 
                            SortExpression="LoanAmount" DataFormatString="{0:C}" />
                        <asp:BoundField DataField="AnnualIntRate" HeaderText="Annual Interest Rate" 
                            ReadOnly="True" SortExpression="AnnualIntRate" DataFormatString="{0:P1}"
                            ItemStyle-HorizontalAlign="Right" />
                        <asp:BoundField DataField="NumPayments" HeaderText="Number of Payments" 
                            ReadOnly="True" SortExpression="NumPayments" DataFormatString="{0:D}"
                            ItemStyle-HorizontalAlign="Right" />
                    </Columns>

                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Font-Bold="true" />
                    <RowStyle CssClass="row" />
                    <SelectedRowStyle BackColor="#f5f5f5" CssClass="selected" />
                    <SortedAscendingHeaderStyle CssClass="asc" />
                    <SortedDescendingHeaderStyle CssClass="desc" />
                </asp:GridView>
            </div>

            <div class="col-small">
                <asp:Label ID="CustNameLabel" runat="server" Text="Customer Name" Font-Bold="true" />
                <asp:TextBox ID="CustName" runat="server" 
                    ToolTip="At least one letter (uppercase or lowercase) or one period (.) is required" />

                <div class="error-msg-container">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorCustName" runat="server" 
                        ErrorMessage="Required" ControlToValidate="CustName" ForeColor="Red" />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidatorCustName" runat="server"
                        ErrorMessage="Only letters (uppercase or lowercase), periods (.), and spaces are allowed"
                        ControlToValidate="CustName" ValidationExpression="[a-zA-Z. ]+" ForeColor="Red"
                        />
                </div>
            </div>

            <div class="col">
                <div class="btn-container">
                    <asp:Button ID="ViewData" runat="server" Text="Find Loans" CausesValidation="true"
                        OnClientClick="alert('Loading data...')" OnClick="ViewData_Click" />
                    <asp:Button ID="Reset" runat="server" Text="Clear Sort" CausesValidation="false"
                        UseSubmitBehavior="false" OnClientClick="alert('The form has been resetted')"
                        OnClick="Reset_Click" Enabled="false" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
