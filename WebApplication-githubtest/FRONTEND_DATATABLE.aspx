<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FRONTEND_DATATABLE.aspx.cs" Inherits="WebApplication_githubtest.FRONTEND_DATATABLE" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>FRONT END DATA TABLE</title>
</head>
<body>  
    <form id="form1" runat="server">  
        <asp:Repeater ID="Repeater1" runat="server">  
            <ItemTemplate>  
                <div>  
                    <table>  
                        <tr>  
                            <th>Student<%#Eval("CCNO")%></th>   //    
                        </tr>  
                        <tr>  
                            <td>Student Name</td>  
                            <td><%#Eval("FINYEAR")%></td>  
                        </tr>  
                        <tr>  
                            <td>Registration Number</td>  
                            <td><%#Eval("PPONO")%></td>  
                        </tr>  
                        <tr>  
                            <td>Date Of Birth</td>  
                            <td><%#Eval("DOB")%></td>  
                        </tr>  
                        <tr>  
                            <td>Date Of Examination</td>  
                            <td><%#Eval("DOJ")%></td>  
                        </tr>  
                        <tr>  
                            <td>Department</td>  
                            <td><%#Eval("DOL")%></td>  
                        </tr>  
                    </table>  
                </div>  
            </ItemTemplate>  
        </asp:Repeater>  
    </form>  
</body>  
</html>
