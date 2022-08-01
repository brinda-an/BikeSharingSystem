<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="_frmViewCustomers.aspx.cs" Inherits="BikeSharingSystem.Admin._frmViewCustomers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
<table style="width:100%;">
    <tr>
        <td style="height: 22px" colspan="3">
            <h2 style="text-align: center;">
                <strong>VIEW CUSTOMER</strong></h2>
        </td>
    </tr>
    <tr>
        <td style="width: 120px">
            &nbsp;
            <asp:Label ID="Label2" runat="server"></asp:Label>
            &nbsp;</td>
        <td style="width: 37px">
            &nbsp;</td>
        <td>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 120px">
            &nbsp; <strong>Select City</strong></td>
        <td style="width: 37px">
            <asp:DropDownList ID="ddlCity" runat="server" AutoPostBack="True" 
                onselectedindexchanged="ddlCity_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 120px">
            &nbsp;</td>
        <td style="width: 37px">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" 
                CellPadding="4" CellSpacing="2" ForeColor="Black" HorizontalAlign="Center">
                <Columns>
                    <asp:BoundField DataField="Cus_Id" HeaderText="Customer Id" Visible="False" />
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:BoundField DataField="Gender" HeaderText="Gender" />
                    <asp:BoundField DataField="Address" HeaderText="Address" />
                    <asp:BoundField DataField="Contact_No" HeaderText="Contact Number" />
                    <asp:BoundField DataField="eMail" HeaderText="eMail" />
                    <asp:BoundField DataField="DL_Number" HeaderText="DL_Number" />
                    <asp:BoundField DataField="Password" HeaderText="Password" Visible="False" />
                    <asp:TemplateField HeaderText="Photo">
                        <ItemTemplate>
                            <asp:Image ID="Image1" runat="server" Height="40px" 
                                ImageUrl='<%# Eval("Photo") %>' Width="50px" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                <RowStyle BackColor="White" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
        </td>
    </tr>
</table>
</form>
</asp:Content>
