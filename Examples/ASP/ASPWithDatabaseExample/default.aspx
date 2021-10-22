<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ASPWithDatabaseExample._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="WidgetId" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="WidgetId" HeaderText="WidgetId" InsertVisible="False" ReadOnly="True" SortExpression="WidgetId" />
                    <asp:BoundField DataField="WidgetName" HeaderText="WidgetName" SortExpression="WidgetName" />
                    <asp:BoundField DataField="WidgetPrice" HeaderText="WidgetPrice" SortExpression="WidgetPrice" />
                    <asp:BoundField DataField="WidgetDept" HeaderText="WidgetDept" SortExpression="WidgetDept" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Spring2021ExampleConnectionString %>" 
                SelectCommand="SELECT * FROM [Widgets]" 
                DeleteCommand="DELETE FROM [Widgets] WHERE [WidgetId] = @WidgetId" 
                InsertCommand="INSERT INTO [Widgets] ([WidgetName], [WidgetPrice], [WidgetDept]) VALUES (@WidgetName, @WidgetPrice, @WidgetDept)" 
                UpdateCommand="UPDATE [Widgets] SET [WidgetName] = @WidgetName, [WidgetPrice] = @WidgetPrice, [WidgetDept] = @WidgetDept WHERE [WidgetId] = @WidgetId">
                <DeleteParameters>
                    <asp:Parameter Name="WidgetId" Type="Int32" />
                </DeleteParameters>                
                <UpdateParameters>
                    <asp:Parameter Name="WidgetName" Type="String" />
                    <asp:Parameter Name="WidgetPrice" Type="Decimal" />
                    <asp:Parameter Name="WidgetDept" Type="String" />
                    <asp:Parameter Name="WidgetId" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" />  
        </div>
    </form>
</body>
</html>
