<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SingleSession.aspx.cs" Inherits="WebApplication_githubtest.SingleSession" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>  
    <form id="form1" runat="server">  
    <h1>  
        Login</h1>  
    <table id="tblLogin" runat="server" width="40%" border="0" cellpadding="0" cellspacing="4"  
        style="background-color: #cecece;" align="center">  
        <tbody>  
            <tr>  
                <td align="center" colspan="2">  
                    <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>  
                    <%--<asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">  
                    </asp:ToolkitScriptManager>--%>  
                </td>  
            </tr>  
            <tr>  
                <td width="30%" align="right">  
                    User ID :  
                </td>  
                <td width="70%">  
                    <asp:TextBox ID="txtLogin" runat="server" Width="175px" MaxLength="20" AutoCompleteType="Disabled"></asp:TextBox>  
                    <asp:RequiredFieldValidator ID="req_txtLogin" runat="server" ErrorMessage="Enter Login ID."  
                        ToolTip="Enter Login ID." ControlToValidate="txtLogin" Text="*" Display="Static"  
                        ForeColor="Red" ValidationGroup="vldLogin"></asp:RequiredFieldValidator>  
                    <%--<asp:FilteredTextBoxExtender ID="fltr_txtLogin" runat="server" FilterType="UppercaseLetters,LowercaseLetters,Numbers"  
                        TargetControlID="txtLogin">  
                    </asp:FilteredTextBoxExtender>--%>  
                </td>  
            </tr>  
            <tr>  
                <td align="right">  
                    Password :  
                </td>  
                <td>  
                    <asp:TextBox ID="txtPassword" runat="server" Width="175px" MaxLength="20" AutoCompleteType="Disabled"  
                        TextMode="Password"></asp:TextBox>  
                    <asp:RequiredFieldValidator ID="req_txtPassword" runat="server" ErrorMessage="Enter Password."  
                        ToolTip="Enter Password." ControlToValidate="txtPassword" Text="*" Display="Static"  
                        ForeColor="Red" ValidationGroup="vldLogin"></asp:RequiredFieldValidator>  
                    <%--<asp:FilteredTextBoxExtender ID="fltr_txtPassword" runat="server" FilterType="Numbers, LowercaseLetters, UppercaseLetters, Custom"  
                        TargetControlID="txtPassword" ValidChars="@!_%$#">  
                    </asp:FilteredTextBoxExtender>--%>  
                </td>  
            </tr>  
            <tr>  
                <td>  
                </td>  
                <td colspan="2" align="left">  
                    <div>  
                        <%--<asp:UpdatePanel ID="UpdatePanel1" runat="server">  
                            <ContentTemplate>  
                                <asp:Image ImageUrl="ghCaptcha.ashx" runat="server" ID="imgCaptcha" />  
                                <asp:ImageButton ID="btnRefresh" runat="server" Width="10px" Height="10px" ImageUrl="~/refresh.jpg"  
                                    OnClick="btnRefresh_Click" />  
                            </ContentTemplate>  
                        </asp:UpdatePanel>--%>  
                    </div>  
                </td>  
            </tr>  
            <tr>  
               <%-- <td align="right">  
                    Enter Code :  
                </td> --%> 
                <td>  
                    <%--<asp:TextBox ID="txtCode" runat="server" Width="175px" MaxLength="5" AutoCompleteType="Disabled"></asp:TextBox>--%>  
                    <%--<asp:RequiredFieldValidator ID="req_txtCode" runat="server" ErrorMessage="Enter captcha code."  
                        ToolTip="Enter captcha code." ControlToValidate="txtCode" Text="*" Display="Static"  
                        ForeColor="Red" ValidationGroup="vldLogin"></asp:RequiredFieldValidator>--%>  
                    <%--<asp:FilteredTextBoxExtender ID="fltr_txtCode" runat="server" FilterType="Numbers"  
                        TargetControlID="txtCode">  
                    </asp:FilteredTextBoxExtender>--%>  
                </td>  
            </tr>  
            <tr>  
                <td colspan="2" align="center">  
                    <asp:Button ID="btnLogin" runat="server" Text="Login" ValidationGroup="vldLogin"  
                        OnClick="btnLogin_Click" />  
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="vldLogin"  
                        ShowSummary="false" ShowMessageBox="true" HeaderText="You have received following errors." />  
                </td>  
            </tr>  
        </tbody>  
    </table>  
    <table id="tblAlert" runat="server" width="40%" border="0" cellpadding="0" cellspacing="4"  
        style="background-color: #cecece;" align="center" visible="false">  
        <tr>  
            <td align="center">  
                This user is already logged in. Do you want to terminate other active session.  
            </td>  
        </tr>  
        <tr>  
            <td align="center">  
               <%-- <asp:Button ID="btnOk" runat="server" Text="OK" OnClick="btnOk_Click" />  
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />  --%>
            </td>  
        </tr>  
    </table>  
    </form>  
</body> 
</html>
