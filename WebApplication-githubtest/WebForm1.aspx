<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication_githubtest.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 25%;
        }

        table {
            text-align: center
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td width="15%" height="35" colspan="1">A</td>
                    <td width="15%" height="35" colspan="3">B</td>
                </tr>
                <tr>
                    <td rowspan="4" width="15%">seat no</td>
                </tr>
                <tr>
                    <td width="15%" height="50">Long Case One</td>
                    <td width="15%" height="50" >Short Cases</td>
                    <td height="50" class="auto-style1">Total </td>

                </tr>
                <tr>
                    <td width="15%" height="50">(i)</td>
                    <td width="15%" height="50" rowspan="1">(ii) |&nbsp; (II)</td>
                    <td height="50" class="auto-style1">(ii) </td>

                </tr>
                <tr>
                    <td width="15%" height="50">80</td>
                    <td width="15%" height="50">80|30</td>
                    <td width="15%" height="50">40</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
