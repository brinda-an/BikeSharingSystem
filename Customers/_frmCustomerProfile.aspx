<%@ Page Title="" Language="C#" MasterPageFile="~/Customers/Customer.Master" AutoEventWireup="true" CodeBehind="_frmCustomerProfile.aspx.cs" Inherits="BikeSharingSystem.Customers._frmCustomerProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
<table style="width:100%;">
    <tr>
        <td colspan="3">
            <h1 style="color: #009933; text-align: center">
                <strong>Profile</strong></h1>
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
        <td colspan="3">
            <asp:MultiView ID="MultiView1" runat="server">
                <asp:View ID="View1" runat="server">
                    <table style="width:100%;">
                        <tr>
                            <td style="width: 146px">
                                <b>Name</b></td>
                            <td>
                                <asp:Label ID="lblName" runat="server"></asp:Label>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 146px">
                                <b>Address</b></td>
                            <td>
                                <asp:Label ID="lblAdrs" runat="server"></asp:Label>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 146px">
                                <b>Contact Number</b></td>
                            <td>
                                <asp:Label ID="lblCont" runat="server"></asp:Label>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 146px">
                                <b>eMail_Id</b></td>
                            <td>
                                <asp:Label ID="lbleMail" runat="server"></asp:Label>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 146px">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="3">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Click here to
                                <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Update</asp:LinkButton>
                                &nbsp; your profile.</td>
                        </tr>
                    </table>
                </asp:View>
                <asp:View ID="View2" runat="server">
                    <table style="width:100%;">
                        <tr>
                            <td style="width: 183px">
                                <b>Name</b></td>
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
                            <td style="width: 183px">
                                <b>Address</b></td>
                            <td>
                                <asp:TextBox ID="txtAddr" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                    ControlToValidate="txtAddr" ErrorMessage="*" ForeColor="#FF3300" 
                                    ValidationGroup="a"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 183px">
                                <b>Contact Number</b></td>
                            <td>
                                <asp:TextBox ID="txtCont" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                    ControlToValidate="txtCont" ErrorMessage="*" ForeColor="#FF3300" 
                                    ValidationExpression="\d{10}" ValidationGroup="a"></asp:RegularExpressionValidator>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 183px">
                                <b>eMail_Id</b></td>
                            <td>
                                <asp:TextBox ID="txteMail" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                                    ControlToValidate="txteMail" ErrorMessage="Enter eMail." ForeColor="#FF3300" 
                                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                                    ValidationGroup="a"></asp:RegularExpressionValidator>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 183px">
                                &nbsp;</td>
                            <td>
                                <asp:Button ID="Button1" runat="server" ForeColor="Blue" 
                                    onclick="Button1_Click" Text="Update" ValidationGroup="a" />
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 183px">
                                &nbsp;</td>
                            <td>
                                <asp:Label ID="Label1" runat="server"></asp:Label>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                </asp:View>
            </asp:MultiView>
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
</table>
</form>
</asp:Content>
