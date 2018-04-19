<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lbltitle" runat="server" Text="REGISTRATION"></asp:Label>
                </td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Adhar No</td>
                <td>
                    <asp:TextBox ID="txtadhar" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
            <td>&nbsp;</td>
            <td>
               
               <%-- <asp:Button id="UploadBtn" Text="Upload File" OnClick="UploadBtn_Click" runat="server" Width="105px" />--%>
                </td>
        </tr>
            <tr>
                <td>Name</td>
                <td>
                    <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Username</td>
                <td>
                    <asp:TextBox ID="txtuser" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Password</td>
                <td>
                    <asp:TextBox ID="txtpwd" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Address</td>
                <td>
                    <asp:TextBox ID="txtadd" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>District</td>
                <td>
                    <asp:TextBox ID="txtdist" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Pin</td>
                <td>
                    <asp:TextBox ID="txtpin" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Phone</td>
                <td>
                    <asp:TextBox ID="txtph" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Email</td>
                <td>
                    <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
                </td>
            </tr>
           
        
        
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btnreg" runat="server" Text="Register" OnClick="btnreg_Click" />
                </td>
            </tr>
        </table>
    <div>
    
    </div>
    </form>
</body>
</html>
