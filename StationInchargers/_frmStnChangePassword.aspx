<%@ Page Title="" Language="C#" MasterPageFile="~/StationInchargers/StnIncharge.Master" AutoEventWireup="true" CodeBehind="_frmStnChangePassword.aspx.cs" Inherits="BikeSharingSystem.StationInchargers._frmStnChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
<table style="width:100%;">
    <tr>
        <td colspan="3" style="color: #009933; text-align: center">
            <h3>
                <strong>CHANGE PASSWORD</strong></h3>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server"></asp:Label>
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
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
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
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
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
            <b>Confirm New Password</b></td>
        <td>
            <asp:TextBox ID="txtConfNewPsw" runat="server" TextMode="Password"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ControlToValidate="txtConfNewPsw" ErrorMessage="*" ForeColor="#FF3300" 
                ValidationGroup="a"></asp:RequiredFieldValidator>
&nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" 
                ControlToCompare="txtNewPsw" ControlToValidate="txtConfNewPsw" 
                ErrorMessage="Password Mismatch" ForeColor="#FF3300" ValidationGroup="a"></asp:CompareValidator>
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
