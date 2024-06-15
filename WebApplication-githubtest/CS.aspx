<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CS.aspx.cs" Inherits="CS" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body
        {
            font-family: Arial;
            font-size: 10pt;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td>
                <asp:DropDownList ID="ddlLength" runat="server">
                    <asp:ListItem Text="5" Value="5" />
                    <asp:ListItem Text="8" Value="8" />
                    <asp:ListItem Text="10" Value="10" />
                </asp:DropDownList>
            </td>
            <td>
                <asp:RadioButtonList ID="rbType" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Text="Alphanumeric" Value="1" Selected="True" />
                    <asp:ListItem Text="Numeric" Value="2" />
                </asp:RadioButtonList>
            </td>
            <td>
                <asp:Button ID="btnGenerate" Text="Generate ID" runat="server" OnClick="GenerateID" />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Label ID="lblID" runat="server" />
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
