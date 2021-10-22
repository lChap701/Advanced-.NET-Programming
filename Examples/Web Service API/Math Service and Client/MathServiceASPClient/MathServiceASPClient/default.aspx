<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="MathServiceASPClient._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter first number: "></asp:Label>
            <asp:TextBox ID="txtNum1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Enter second number: "></asp:Label>
            <asp:TextBox ID="txtNum2" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Addition: "></asp:Label>
            <asp:TextBox ID="txtAdd" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Subtraction: "></asp:Label>
            <asp:TextBox ID="txtSub" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Multiplication: "></asp:Label>
            <asp:TextBox ID="txtMult" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            <asp:Label ID="Label6" runat="server" Text="Division: "></asp:Label>
            <asp:TextBox ID="txtDiv" runat="server" ReadOnly="True"></asp:TextBox>
            <br /><br />
            <asp:Button ID="btnCalc" runat="server" Text="Calc" OnClick="btnCalc_Click" />
        </div>
    </form>
</body>
</html>
