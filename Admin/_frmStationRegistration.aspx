<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="_frmStationRegistration.aspx.cs" Inherits="BikeSharingSystem.Admin._frmAddStationRegistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <table style="width:100%;">
        <tr>
            <td colspan="3">
                <h2 style="text-align: center;">
                    <strong>STATION REGISTRATION</strong></h2>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
                <asp:Label ID="Label3" runat="server"></asp:Label>
                &nbsp;</td>
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
                <b>&nbsp; Station Name</b></td>
            <td>
                <asp:TextBox ID="txtStnName" runat="server" placeholder="Station Name"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtStnName" ErrorMessage="*" 
                    ForeColor="#FF3300" ValidationGroup="a"></asp:RequiredFieldValidator>
            &nbsp;
                <asp:Label ID="Label2" runat="server" ForeColor="#FF3300"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <b>&nbsp; Address</b></td>
            <td>
                <asp:TextBox ID="txtAddress" runat="server" placeholder="Address"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtAddress" ErrorMessage="Enter Address." 
                    ForeColor="#FF3300" ValidationGroup="a"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <b>&nbsp; Contact Number</b></td>
            <td>
                <asp:TextBox ID="txtContactNo" runat="server" placeholder="Contact Number"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="txtContactNo" ErrorMessage="*" 
                    ForeColor="#FF3300" ValidationGroup="a"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="txtContactNo" ErrorMessage="Enter Ten Digits." 
                    ForeColor="#FF3300" ValidationExpression="\d{10}" ValidationGroup="a"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                <b>&nbsp; City Name</b></td>
            <td>
                <asp:DropDownList ID="ddlCityName" runat="server">
                </asp:DropDownList>
            </td>
            <td>
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToValidate="ddlCityName" ErrorMessage="Select City Name." 
                    ForeColor="#FF3300" Operator="NotEqual" ValidationGroup="a" 
                    ValueToCompare="Select"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" ForeColor="#FF9900" Text="ADD" 
                    ValidationGroup="a" onclick="Button1_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" ForeColor="#CC9900" Height="26px" 
                    onclick="Button2_Click" Text="Update" />
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
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" 
                    CellPadding="3" CellSpacing="2" HorizontalAlign="Center">
                    <Columns>
                        <asp:BoundField DataField="Stn_Id" HeaderText="Station Id" />
                        <asp:BoundField DataField="Stn_Name" HeaderText="Station Name" />
                        <asp:BoundField DataField="Address" HeaderText="Address" />
                        <asp:BoundField DataField="Contact_No" HeaderText="Contact Number" 
                            ItemStyle-HorizontalAlign="Center">
<ItemStyle HorizontalAlign="Center"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="City" HeaderText="City" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="LB_Edit" runat="server"
                                CommandArgument='<%# Eval("Stn_id") %>' onclick="LB_Edit_Click">Edit</asp:LinkButton>
                                <asp:LinkButton ID="LB_Delete" runat="server"
                                CommandArgument='<%# Eval("Stn_id") %>' onclick="LB_Delete_Click"
                                OnClientClick="return confirm('Are you sureyou want to delete this record?');">Delete</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FFF1D4" />
                    <SortedAscendingHeaderStyle BackColor="#B95C30" />
                    <SortedDescendingCellStyle BackColor="#F1E5CE" />
                    <SortedDescendingHeaderStyle BackColor="#93451F" />
                </asp:GridView>
            </td>
        </tr>
    </table>
    </form>
</asp:Content>
