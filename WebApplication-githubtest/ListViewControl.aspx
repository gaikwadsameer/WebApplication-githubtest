<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListViewControl.aspx.cs" Inherits="WebApplication_githubtest.ListViewControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
                    <Columns>
                        <asp:TemplateField HeaderText="Name" ItemStyle-Width="80">
                            <ItemTemplate>
                                <asp:TextBox ID="txtName" runat="server" Text='<%# Eval("DESCRIPTON") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
