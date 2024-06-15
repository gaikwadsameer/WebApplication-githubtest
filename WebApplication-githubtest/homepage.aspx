<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="WebApplication_githubtest.homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>test-pass</title>
</head>
<body bgcolor="#ffff99">
    <form id="form1" runat="server">

                             
                                <div class="form-group">
                                    <asp:Label ID="Label4" runat="server" CssClass="text-info" Text="Username"></asp:Label><br />
                                    <asp:TextBox CssClass="form-control" AutoCompleteType="Disabled" ID="txt_username" runat="server" 
                                        BorderWidth="1px"  MaxLength="20"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                        ControlToValidate="txt_username" ErrorMessage="Enter your Username" Display="Dynamic"></asp:RequiredFieldValidator>
                            </div>
                         <%--   <div class="form-group">
                                <asp:Label ID="lblpass" runat="server" CssClass="text-info" Text="Password"></asp:Label>
                                 <asp:TextBox CssClass="form-control" ID="txt_password" runat="server"  TextMode="Password" MaxLength="20"></asp:TextBox>
                                <asp:Label CssClass="text-capitalize" ID="Label2" runat="server" Text="Note : Please Enter Employee-Portal User ID &amp; Password" />
                     <br />
                     <asp:RequiredFieldValidator  ID="RequiredFieldValidator2" runat="server" 
                         ControlToValidate="txt_password" ErrorMessage="Enter your Password" 
                         Display="Dynamic"></asp:RequiredFieldValidator>
                            </div>--%>
                            <div class="form-group">
                                  <asp:Button class="btn btn-info btn-md" ID="btn_login" runat="server" Font-Bold="True" Text="Sign In" 
                          onclick="btn_login_Click" />
                                
                           <br />
                                <br />
                                 <asp:Label CssClass="text-danger" ID="lblErrMessage" runat="server" Font-Bold="True"                                    ></asp:Label>
                            </div>
                            






        <%--<div>
            <p>
                <strong style="font-size: xx-large">Hello Everyone! Welcome to my Page.  
  
                </strong>
            </p>
        </div>
        <asp:Image ID="Image1" runat="server" Height="335px"
            ImageUrl="~/2.jpg" Width="817px" />
        <p>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Height="47px" OnClick="Button1_Click"
                Text="Logout" Width="92px" />
        </p>--%>
    </form>
</body>
</html>
