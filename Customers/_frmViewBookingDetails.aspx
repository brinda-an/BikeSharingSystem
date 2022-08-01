<%@ Page Title="" Language="C#" MasterPageFile="~/Customers/Customer.Master" AutoEventWireup="true" CodeBehind="_frmViewBookingDetails.aspx.cs" Inherits="BikeSharingSystem.Customers._frmViewBookingDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <table style="width:100%;">
        <tr>
            <td colspan="3">
                <h2 style="text-align: center">
                View Booking Details</h2>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td style="width: 446px">
                &nbsp;</td>
            <td>
                <asp:Label ID="Label1" runat="server"></asp:Label>
            &nbsp;
                <asp:Image ID="Image1" runat="server" Height="45px" Width="45px" />
            </td>
        </tr>
        <tr>
            <td colspan="3">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                &nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server"></asp:Label>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="3" style="color:Black" align="center">
                <asp:GridView ID="GridView1" runat="server" BackColor="White" 
                    BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" ForeColor="#003399" />
                    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SortedAscendingCellStyle BackColor="#EDF6F6" />
                    <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                    <SortedDescendingCellStyle BackColor="#D6DFDF" />
                    <SortedDescendingHeaderStyle BackColor="#002876" />
                </asp:GridView>
            </td>
        </tr>
    </table>
    </form>
</asp:Content>
