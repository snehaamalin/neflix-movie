<%@ Page Title="" Language="C#" Debug="true" MasterPageFile="~/UserMasterPage.master" AutoEventWireup="true" CodeFile="UserVideoVisualDisplay.aspx.cs" Inherits="UserVideoVisualDisplay" %>

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
            <td>Language : <asp:Label ID="lbllng" runat="server" Text=""></asp:Label></td>
            <td>
                
            </td>
        </tr>
		 <tr>
            <td>Movie Name : <asp:Label ID="lblname" runat="server" Text=""></asp:Label></td>
            <td>
                
            </td>
        </tr>
		 <tr>
            <td>Release Date : <asp:Label ID="lblrdate" runat="server" Text=""></asp:Label></td>
            <td>
                
            </td>
        </tr>
		 <tr>
            <td>Duration : <asp:Label ID="lbllen" runat="server" Text=""></asp:Label></td>
            <td>
                
            </td>
        </tr>
		 <tr>
			 <td>
    <video width="720" height="440" autoplay="autoplay" id="video" runat="server"/>
		</td>
		 </tr>
		 </table>
</video>


</asp:Content>
      