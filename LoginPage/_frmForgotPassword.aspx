<%@ Page Title="" Language="C#" MasterPageFile="~/LoginPage/Login.Master" AutoEventWireup="true" CodeBehind="_frmForgotPassword.aspx.cs" Inherits="BikeSharingSystem.LoginPage._frmForgotPassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <table style="width:100%;">
        <tr>
            <td colspan="3" style="text-align: center">
                <h3>
                    <strong>Forgot Password</strong></h3>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <b>&nbsp;&nbsp; User Name&nbsp;</b></td>
            <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtName" ErrorMessage="*" ForeColor="#FF3300" 
                    ValidationGroup="a"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <b>&nbsp;&nbsp; DL_Number</b></td>
            <td>
                <asp:TextBox ID="txtDL" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtDL" ErrorMessage="*" ForeColor="#FF3300" 
                    ValidationGroup="a"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" BackColor="#FF99FF" 
                    BorderColor="#333300" onclick="Button1_Click" Text="GetPassword" 
                    ValidationGroup="a" />
            </td>
            <td>
                <asp:Label ID="Label1" runat="server" ForeColor="#669900"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </form>
</asp:Content>
