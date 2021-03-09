<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayLoans.aspx.cs" Inherits="CheapLoansProject.DisplayLoans" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Display Loans</title>
    <link href="/css/Styles.css" rel="stylesheet" />
    <style>
        #displayLoansForm {
            width: 90%;
        }

        :disabled {
            opacity: 0.8;
        }

        #scroll {
            height: 421px;
            overflow-y: scroll;
            box-shadow: rgba(0, 0, 0, 0.1) 1px 1px 6px 1px;
        }

        th a {
            text-decoration: none;
        }

        td:nth-child(6n+1) {
            text-align: center;
        }

        a:not(#CheapLoansHyperLink) {
            color: #0080ff;
        }

            a:not(#CheapLoansHyperLink):hover,
            a:not(#CheapLoansHyperLink):focus {
                color: #ff6a00;
            }

        a:visited {
            color: inherit;
        }
    </style>
</head>
<body>
    <form id="displayLoansForm" runat="server">
        <asp:SqlDataSource ID="SqlDataSourceCheapLoans" runat="server" ConnectionString="<%$ ConnectionStrings:CheapLoansConnectionString %>" SelectCommand="SELECT * FROM [Loans]"></asp:SqlDataSource>

        <h2>Display Loans</h2>

        <div class="container">
            <div class="col">
                <asp:GridView ID="GridViewLoans" runat="server" BorderColor="#dddddd" Width="100%" CellPadding="10" EmptyDataText="No data to display" AllowSorting="true" AutoGenerateColumns="False" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridViewLoans_SelectedIndexChanged" OnSorted="GridViewLoans_Sorted" DataKeyNames="LoanNum" DataSourceID="SqlDataSourceCheapLoans">
                    <Columns>
                        <asp:BoundField DataField="LoanNum" HeaderText="Loan Number" InsertVisible="False" ReadOnly="True" SortExpression="LoanNum" DataFormatString="{0:D9}" />
                        <asp:BoundField DataField="CustName" HeaderText="Customer Name" ReadOnly="True" SortExpression="CustName" />
                        <asp:BoundField DataField="LoanAmount" HeaderText="Loan Amount" ReadOnly="True" SortExpression="LoanAmount" DataFormatString="{0:C}" />
                        <asp:BoundField DataField="AnnualIntRate" HeaderText="Annual Interest Rate" ReadOnly="True" SortExpression="AnnualIntRate" DataFormatString="{0:P1}" />
                        <asp:BoundField DataField="NumPayments" HeaderText="Number of Payments" ReadOnly="True" SortExpression="NumPayments" DataFormatString="{0:D}" />
                    </Columns>

                    <EmptyDataRowStyle Font-Bold="True" Font-Size="Large" />

                    <RowStyle CssClass="Row" />
                    <SelectedRowStyle BackColor="WhiteSmoke" CssClass="Selected"></SelectedRowStyle>
                    <SortedAscendingHeaderStyle CssClass="Asc" />
                    <SortedDescendingHeaderStyle CssClass="Desc" />
                </asp:GridView>
            </div>

            <div class="col">
                <asp:Label ID="TotalLabel" runat="server" Font-Bold="true" Text="Total Loan Amount"></asp:Label>
                <span class="dollar">$<asp:TextBox ID="Total" runat="server" BorderStyle="None" Width="98%" CssClass="dollar-content" ReadOnly="true"></asp:TextBox>
                </span>
            </div>

            <div class="button-container">
                <asp:HyperLink ID="CheapLoansHyperLink" runat="server" NavigateUrl="~/CheapLoans.aspx" ToolTip="Return to Cheap Loans" Text="Return" ForeColor="White" BorderStyle="Solid" BorderWidth="1px" Font-Bold="true" Font-Underline="false"></asp:HyperLink>
                <asp:Button ID="Reset" runat="server" Text="Reset" ForeColor="White" Font-Bold="true" BorderWidth="1px" BorderStyle="Solid" Enabled="false" OnClick="Reset_Click" OnClientClick="alert('The Display Loans form has been resetted!')" />
            </div>
        </div>
    </form>
</body>
</html>
