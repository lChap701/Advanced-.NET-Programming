<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheapLoans.aspx.cs" Inherits="CheapLoansProject.CheapLoans" UnobtrusiveValidationMode="None" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cheap Loans</title>
    <link href="/css/Styles.css" rel="stylesheet" />
    <style>
        #cheapLoansForm {
            width: 50%;
        }

            #cheapLoansForm #Reset {
                background: #59b300;
                border-color: #408000;
            }

                #cheapLoansForm #Reset:hover,
                #cheapLoansForm #Reset:focus {
                    background: #7400e6;
                    border-color: #5a00b3;
                }

        .error-msg-container {
            position: relative;
        }

        #RegularExpressionValidatorCustName,
        #RangeValidatorLoanAmt,
        #RangeValidatorAnnualIntRate,
        #RangeValidatorNumPayments {
            position: absolute;
            left: 0;
        }

        #Submit {
            background: #00b300;
            border-color: #008000;
        }

            #Submit:hover,
            #Submit:focus {
                background: #800080;
                border-color: #340034;
            }
    </style>
</head>
<body>
    <form id="cheapLoansForm" runat="server">
        <h2>Cheap Loans</h2>

        <div class="container">
            <div class="col">
                <asp:Label ID="CustNameLabel" runat="server" Text="Customer Name" Font-Bold="true"></asp:Label>
                <asp:TextBox ID="CustName" runat="server" ToolTip="First and last name is required" BorderStyle="Solid" BorderWidth="1px" Width="100%"></asp:TextBox>
                <div class="error-msg-container">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorCustName" runat="server" ErrorMessage="Required" ControlToValidate="CustName" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidatorCustName" runat="server" ErrorMessage="A full name (first and last) is required" ControlToValidate="CustName" ValidationExpression="[A-Z|a-z]+[ ](([A-Z|a-z][.]|[A-Z|a-z]+){1}[ ])?[A-Z|a-z]+" ForeColor="Red"></asp:RegularExpressionValidator>
                </div>
            </div>

            <div class="col">
                <asp:Label ID="LoanAmtLabel" runat="server" Text="Loan Amount" Font-Bold="true"></asp:Label>
                <span class="dollar">$<asp:TextBox ID="LoanAmt" runat="server" TextMode="Number" step="0.01" ToolTip="A value between $0.01 and $99,999.99 is required" BorderStyle="None" Width="98%" CssClass="dollar-content"></asp:TextBox>
                </span>
                <div class="error-msg-container">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorLoanAmt" runat="server" ErrorMessage="Required" ControlToValidate="LoanAmt" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidatorLoanAmt" runat="server" ErrorMessage="Should be between $0.01 to $99,999.99" ControlToValidate="LoanAmt" Type="Currency" MinimumValue="0.01" MaximumValue="99999.99" ForeColor="Red" />
                </div>
            </div>

            <div class="col">
                <asp:Label ID="AnnualIntRateLabel" runat="server" Text="Annual Interest Rate" Font-Bold="true"></asp:Label>
                <span class="apr">
                    <asp:TextBox ID="AnnualIntRate" runat="server" TextMode="Number" step="0.1" ToolTip="A value between 0.1% and 99.9% is required" BorderStyle="None" Width="96.5%" CssClass="apr-content"></asp:TextBox>
                    %
                </span>
                <div class="error-msg-container">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorAnnualIntRate" runat="server" ErrorMessage="Required" ControlToValidate="AnnualIntRate" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidatorAnnualIntRate" runat="server" ErrorMessage="Should be between 0.1% and 99.9%" ControlToValidate="AnnualIntRate" Type="Currency" MinimumValue="0.1" MaximumValue="99.9" ForeColor="Red" />
                </div>
            </div>

            <div class="col">
                <asp:Label ID="NumPaymentsLabel" runat="server" Text="Number of Payments" Font-Bold="true"></asp:Label>
                <asp:TextBox ID="NumPayments" runat="server" TextMode="Number" ToolTip="A value between 1 and 999 is required" BorderStyle="Solid" BorderWidth="1px" Width="100%"></asp:TextBox>
                <div class="error-msg-container">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorNumPayments" runat="server" ErrorMessage="Required" ControlToValidate="NumPayments" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidatorNumPayments" runat="server" ErrorMessage="Should be between 1 and 999" ControlToValidate="NumPayments" Type="Currency" MinimumValue="1" MaximumValue="999" ForeColor="Red" />
                </div>
            </div>

            <div class="col">
                <asp:Label ID="MonPaymentLabel" runat="server" Text="Monthly Payments" Font-Bold="true"></asp:Label>
                <span class="dollar">$<asp:TextBox ID="MonPayment" runat="server" BorderStyle="None" Width="98%" CssClass="dollar-content" ReadOnly="true"></asp:TextBox>
                </span>
            </div>

            <div class="button-container">
                <asp:Button ID="Submit" runat="server" Text="Calculate" ForeColor="White" Font-Bold="true" BorderWidth="1px" BorderStyle="Solid" OnClick="Submit_Click" OnClientClick="alert('Calculating the monthly payment...');" />
                <asp:Button ID="Reset" runat="server" Text="Clear" UseSubmitBehavior="false" CausesValidation="false" ForeColor="White" Font-Bold="true" BorderWidth="1px" BorderStyle="Solid" OnClick="Reset_Click" OnClientClick="alert('The Cheap Loans form has been cleared!');" />
                <asp:Button ID="Save" runat="server" Text="Save Loan" ForeColor="White" Font-Bold="true" BorderWidth="1px" BorderStyle="Solid" OnClick="Save_Click" OnClientClick="alert('Saving loan...');" />
                <asp:Button ID="Display" runat="server" Text="Display Loans" UseSubmitBehavior="false" CausesValidation="false" ForeColor="White" Font-Bold="true" BorderWidth="1px" BorderStyle="Solid" PostBackUrl="~/DisplayLoans.aspx" />
                <asp:SqlDataSource ID="SqlDataSourceCheapLoans" runat="server" ConnectionString="<%$ ConnectionStrings:CheapLoansConnectionString %>" SelectCommand="SELECT * FROM [Loans]" InsertCommand="InsertProcedure" InsertCommandType="StoredProcedure" OnInserting="SqlDataSourceCheapLoans_Inserting" OnInserted="SqlDataSourceCheapLoans_Inserted">
                    <InsertParameters>
                        <asp:ControlParameter Name="CustName" Type="String" ControlID="CustName" PropertyName="Text" Size="50" />
                        <asp:ControlParameter Name="LoanAmount" Type="Decimal" ControlID="LoanAmt" PropertyName="Text" />
                        <asp:ControlParameter Name="AnnualIntRate" Type="Decimal" ControlID="AnnualIntRate" PropertyName="Text" />
                        <asp:ControlParameter Name="NumPayments" Type="Int32" ControlID="NumPayments" PropertyName="Text" />
                    </InsertParameters>
                </asp:SqlDataSource>
            </div>

        </div>
    </form>
</body>
</html>
