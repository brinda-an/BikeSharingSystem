<%@ Page Title="" Language="C#" MasterPageFile="~/Customers/Customer.Master" AutoEventWireup="true" CodeBehind="_frmCustChangePassword.aspx.cs" Inherits="BikeSharingSystem.Customers._frmCustChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
<table style="width:100%;">
    <tr>
        <td colspan="3">
            <h1 style="text-align: center">
                <strong>Change Password</strong></h1>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label2" runat="server"></asp:Label>
        &nbsp;
            <asp:Image ID="Image1" runat="server" Height="45px" Width="45px" />
        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
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
            <b>Enter Old Password</b></td>
        <td>
            <asp:TextBox ID="txtOldPsw" runat="server" TextMode="Password"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="txtOldPsw" ErrorMessage="*" ForeColor="#FF3300" 
                ValidationGroup="a"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <b>Enter New Password</b></td>
        <td>
            <asp:TextBox ID="txtNewPsw" runat="server" TextMode="Password"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ControlToValidate="txtNewPsw" ErrorMessage="*" ForeColor="#FF3300" 
                ValidationGroup="a"></asp:RequiredFieldValidator>
        &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" 
                runat="server" ControlToValidate="txtNewPsw" 
                ErrorMessage="Only numeric allowed." ForeColor="#FF3300" 
                ValidationExpression="^[0-9]*$" ValidationGroup="a"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td>
            <b>Enter Confirm Password</b></td>
        <td>
            <asp:TextBox ID="txtCnfPsw" runat="server" TextMode="Password"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                ControlToValidate="txtCnfPsw" ErrorMessage="*" ForeColor="#FF3300" 
                ValidationGroup="a"></asp:RequiredFieldValidator>
&nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" 
                ControlToCompare="txtNewPsw" ControlToValidate="txtCnfPsw" 
                ErrorMessage="Mismatch Password." ForeColor="#FF3300" ValidationGroup="a"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            <asp:Button ID="Button1" runat="server" ForeColor="Blue" 
                onclick="Button1_Click" Text="ADD" ValidationGroup="a" />
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
    </tr>
</table>
</form>
</asp:Content>
