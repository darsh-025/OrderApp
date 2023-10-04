<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebServiceConsumerApp.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order Status</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" OnRowDataBound="GridView1_RowDataBound">

                <Columns>
                    <asp:BoundField DataField="OrderID" HeaderText="OrderID" />
                    <asp:BoundField DataField="CustomerName" HeaderText="Customer Name" />
                    <asp:BoundField DataField="Qty" HeaderText="Qty" />
                    <asp:BoundField DataField="Amount" HeaderText="Amount" />
                    <asp:BoundField DataField="Status" HeaderText="Status" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
                            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
