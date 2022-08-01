<%@ Page Title="" Language="C#" MasterPageFile="~/LoginPage/Login.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BikeSharingSystem.LoginPage.Login1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
<table style="width:70%; margin-left:15%">
    <tr>
        <td colspan="3">
            <h2 style="text-align: center">
                <strong>LOGIN</strong></h2>
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
        <td colspan="3" style="margin-left:20%">
        <%--<fieldset style="width:80%;">
        <legend style="color:Black"><span><b>LOGIN</b></span></legend>--%>
            <table style="width:100%;">
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
                        <b>&nbsp; User Type</b></td>
                    <td>
            <asp:DropDownList ID="ddlType" runat="server">
                <asp:ListItem>Select</asp:ListItem>
                <asp:ListItem>Admin</asp:ListItem>
                <asp:ListItem>Station Incharge</asp:ListItem>
                <asp:ListItem>Customer</asp:ListItem>
            </asp:DropDownList>
                    </td>
                    <td>
            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                ControlToValidate="ddlType" ErrorMessage="*" 
                ForeColor="#FF3300" Operator="NotEqual" ValidationGroup="a" 
                ValueToCompare="Select"></asp:CompareValidator>
                        <asp:CompareValidator ID="CompareValidator2" runat="server" 
                            ControlToValidate="ddlType" ErrorMessage="*" ForeColor="#FF3300" 
                            Operator="NotEqual" ValidationGroup="b" ValueToCompare="Select"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>&nbsp; User Name</b></td>
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
                        <b>&nbsp; Password</b></td>
                    <td>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="txtPassword" ErrorMessage="*" 
                ForeColor="#FF3300" ValidationGroup="a"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
            <asp:Button ID="Button1" runat="server" Text="Submit" ValidationGroup="a" 
                onclick="Button1_Click" ForeColor="#0000CC" />
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
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
            New user click here for
            <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="#CC6600" 
                NavigateUrl="~/LoginPage/_frmCustomerRegister.aspx">Register.</asp:HyperLink>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:LinkButton ID="LinkButton1" runat="server" ForeColor="#FF3399" 
                            onclick="LinkButton1_Click" ValidationGroup="b">Forgot Password.</asp:LinkButton>
                    &nbsp;<asp:Label ID="Label2" runat="server"></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        <%--</fieldset>--%>
            &nbsp;</td>
    </tr>
</table>
</form>
</asp:Content>
