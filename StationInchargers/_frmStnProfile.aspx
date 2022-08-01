<%@ Page Title="" Language="C#" MasterPageFile="~/StationInchargers/StnIncharge.Master" AutoEventWireup="true" CodeBehind="_frmStnProfile.aspx.cs" Inherits="BikeSharingSystem.StationInchargers._frmStnProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
<table style="width: 100%;">
    <tr>
        <td colspan="3" style="text-align: center; color: #009933">
            <h3>
                <strong>UPDATE PROFILE</strong></h3>
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
                    <table style="width: 100%;">
                        <tr>
                            <td style="width: 121px">
                                <b>Name</b></td>
                            <td>
                                <asp:Label ID="lblName" runat="server"></asp:Label>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 121px">
                                <b>Contact Number</b></td>
                            <td>
                                <asp:Label ID="lblContNo" runat="server"></asp:Label>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 121px">
                                <b>Address</b></td>
                            <td>
                                <asp:Label ID="lblAddr" runat="server"></asp:Label>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 121px">
                                <b>eMail_Id</b></td>
                            <td>
                                <asp:Label ID="lbleMail" runat="server"></asp:Label>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 121px">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="3">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Click Here to
                                <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Update</asp:LinkButton>
                                &nbsp;your profile.</td>
                        </tr>
                    </table>
                </asp:View>
                <asp:View ID="View2" runat="server">
                    <table style="width: 100%;">
                        <tr>
                            <td style="width: 149px">
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
                            <td style="width: 149px">
                                <b>Contact Number</b></td>
                            <td>
                                <asp:TextBox ID="txtContNo" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                    ControlToValidate="txtContNo" ErrorMessage="Enter 10 Digits." 
                                    ForeColor="#FF3300" ValidationExpression="\d{10}" ValidationGroup="a"></asp:RegularExpressionValidator>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 149px">
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
                            <td style="width: 149px">
                                <b>eMail_Id</b></td>
                            <td>
                                <asp:TextBox ID="txteMail" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                                    ControlToValidate="txteMail" ErrorMessage="*" ForeColor="#FF3300" 
                                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                                    ValidationGroup="a"></asp:RegularExpressionValidator>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 149px">
                                &nbsp;</td>
                            <td>
                                <asp:Button ID="Button1" runat="server" ForeColor="#0066FF" Text="Update" 
                                    ValidationGroup="a" onclick="Button1_Click" />
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 149px">
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
