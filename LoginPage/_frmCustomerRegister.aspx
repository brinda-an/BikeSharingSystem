<%@ Page Title="" Language="C#" MasterPageFile="~/LoginPage/Login.Master" AutoEventWireup="true" CodeBehind="_frmCustomerRegister.aspx.cs" Inherits="BikeSharingSystem.LoginPage._frmCustomerRegister" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <table style="width:100%;">
        <tr>
            <td colspan="3">
                <h2 style="text-align: center;">
                    <strong>Customer Registration</strong></h2>
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
            <td colspan="3">
            <%--<fieldset style="width:100%">
            <legend style="color:Black"><b>FORM</b></legend>--%>
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
                            <b>&nbsp;&nbsp; Name&nbsp;</b></td>
                        <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                        &nbsp;
                            <asp:Label ID="Label2" runat="server" ForeColor="#FF3300"></asp:Label>
                        </td>
                        <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtName" ErrorMessage="Enter Name." ForeColor="#FF3300" 
                    ValidationGroup="a"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <b>&nbsp;&nbsp; Gender</b></td>
                        <td>
                <asp:DropDownList ID="ddlGender" runat="server">
                    <asp:ListItem>Select</asp:ListItem>
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:DropDownList>
                        </td>
                        <td>
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToValidate="ddlGender" ErrorMessage="Select Gender." ForeColor="#FF3300" 
                    Operator="NotEqual" ValidationGroup="a" ValueToCompare="Select"></asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <b>&nbsp;&nbsp; Address</b></td>
                        <td>
                <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                        </td>
                        <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtAddress" ErrorMessage="Enter Address." 
                    ForeColor="#FF3300" ValidationGroup="a"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <b>&nbsp;&nbsp; Contact Number&nbsp;</b></td>
                        <td>
                <asp:TextBox ID="txtContactNo" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                                ControlToValidate="txtContactNo" ErrorMessage="*" ForeColor="#FF3300" 
                                ValidationGroup="a"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                    ControlToValidate="txtContactNo" ErrorMessage="Enter Ten Digits." 
                    ForeColor="#FF3300" ValidationExpression="\d{10}" ValidationGroup="a"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <b>&nbsp;&nbsp; eMail</b></td>
                        <td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                                ControlToValidate="txtEmail" ErrorMessage="*" ForeColor="#FF3300" 
                                ValidationGroup="a"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="txtEmail" ErrorMessage="Enter Valied eMail." 
                    ForeColor="#FF3300" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                    ValidationGroup="a"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <b>&nbsp;&nbsp; DL_Number</b></td>
                        <td>
                <asp:TextBox ID="txtDlNo" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                                ControlToValidate="txtDlNo" ErrorMessage="*" ForeColor="#FF3300" 
                                ValidationGroup="a"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
                                ControlToValidate="txtDlNo" ErrorMessage="Only numeric allowed." 
                                ForeColor="#FF3300" ValidationExpression="^[0-9]*$" ValidationGroup="a"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <b>&nbsp;&nbsp; Password</b></td>
                        <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                                ControlToValidate="txtPassword" ErrorMessage="*" ForeColor="#FF3300" 
                                ValidationGroup="a"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                                ControlToValidate="txtPassword" ErrorMessage="Only numeric allowed." 
                                ForeColor="#FF3300" ValidationExpression="^[0-9]*$" ValidationGroup="a"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;&nbsp; <strong>Confirm Password&nbsp;</strong></td>
                        <td>
                            <asp:TextBox ID="txtConfirm" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                                ControlToValidate="txtConfirm" ErrorMessage="*" ForeColor="#FF3300" 
                                ValidationGroup="a"></asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="CompareValidator2" runat="server" 
                                ControlToCompare="txtPassword" ControlToValidate="txtConfirm" 
                                ErrorMessage="Not Matching." ForeColor="#FF3300" ValidationGroup="a"></asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <b>&nbsp;&nbsp; Photo</b></td>
                        <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />
                        </td>
                        <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                    ControlToValidate="FileUpload1" ErrorMessage="Upload photo." 
                    ForeColor="#FF3300" ValidationGroup="a"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                <asp:Button ID="Button1" runat="server" ForeColor="#FF9900" 
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
           <%-- </fieldset>--%>
                &nbsp; </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </form>
</asp:Content>
