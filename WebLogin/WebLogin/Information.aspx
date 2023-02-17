<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Information.aspx.cs" Inherits="WebLogin.Information" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style3 {
            height: 21px;
        }
        .auto-style1 {
            width: 108px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:Label ID="Label1" runat="server" Text="Welcome"></asp:Label>
        &nbsp;to CRUD operation using ASP.Net web application:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <table style="width: 100%; margin-left: 0px;">
            <tr>
                <td class="auto-style3">
                    <br />
                    <asp:Label ID="Label3" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                    <br />
                    <br />
                    <br />
                    Username</td>
                <td class="auto-style3">
                    <br />
                    <asp:Label ID="Label7" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                    <br />
                    <br />
                    <br />
                    <asp:TextBox ID="Txtlogusername" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Password</td>
                <td>
                    <br />
                    <asp:TextBox ID="Txtlogpassword" runat="server" TextMode="Password"></asp:TextBox>
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    <br />
                    <asp:Button ID="ButtonLogin" runat="server" Font-Bold="True" OnClick="ButtonLogin_Click" style="margin-left: 13px" Text="Login" Width="104px" />
                </td>
            </tr>
        </table>
        <br />
        <br />
        <asp:Label ID="Label8" runat="server" Text="Edit and press update"></asp:Label>
        <br />
        <br />
&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Username :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
    
    </div>
        <asp:TextBox ID="Txtusername" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
&nbsp;
        <asp:Label ID="Label6" runat="server" Text="Mobilenumber :"></asp:Label>
        <p>
            <asp:TextBox ID="Txtmobilenum" runat="server" TextMode="Phone" ToolTip="+91(000-000-0000)"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="buttonupdate" runat="server" OnClick="buttonupdate_Click" Text="Update" />
        </p>
        <p>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Text="Email :"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TxtmailID" runat="server" TextMode="Email" ToolTip="@gmail.com"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Buttondlt" runat="server" OnClick="Buttondlt_Click" Text="Delete all" />
        </p>
        <p>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label5" runat="server" Text="Password :"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="Txtpassword" runat="server"></asp:TextBox>
        </p>
    </form>
</body>
</html>
