<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeFile="AdminAddFun.aspx.cs" Inherits="AdminAddFun" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Language</td>
            <td>
                <asp:DropDownList ID="ddlpgm" runat="server">
                    <asp:ListItem Value="1">Hindi</asp:ListItem>
                    <asp:ListItem Value="2">Malayalam</asp:ListItem>
					<asp:ListItem Value="3">Tamil</asp:ListItem>
					<asp:ListItem Value="4">English</asp:ListItem>
					<asp:ListItem Value="5">Spanish</asp:ListItem>
					<asp:ListItem Value="6">Korean</asp:ListItem>
					<asp:ListItem Value="8">Japanese</asp:ListItem>
					<asp:ListItem Value="9">Chinese</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Movie Name</td>
            <td>
                <asp:TextBox ID="txtpgm" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Length</td>
            <td>
                <asp:DropDownList ID="ddlhour" runat="server">
                </asp:DropDownList>
                <asp:DropDownList ID="ddlmin" runat="server">
                </asp:DropDownList>
                <asp:DropDownList ID="ddlsec" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
		 <tr>
            <td>Movie Release Date</td>
            <td>
                <asp:TextBox ID="txtrdate" runat="server"></asp:TextBox>
            </td>
        </tr>


        <tr>
            <td>Attach File</td>
            <td>
               
                <asp:FileUpLoad id="FileUpLoad1" runat="server" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Submit</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

