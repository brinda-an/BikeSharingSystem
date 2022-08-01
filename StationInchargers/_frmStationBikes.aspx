<%@ Page Title="" Language="C#" MasterPageFile="~/StationInchargers/StnIncharge.Master" AutoEventWireup="true" CodeBehind="_frmStationBikes.aspx.cs" Inherits="BikeSharingSystem.StationInchargers._frmStationBikes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <table style="width:100%;">
        <tr>
            <td colspan="3">
                <h3 style="text-align: center">
                    <strong>BIKE LIST</strong></h3>
            </td>
        </tr>
        <tr>
            <td>
&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
            <td style="width: 292px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td style="width: 292px">
                &nbsp;</td>
            <td>
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="3" style="color:Black" align="center">
                <asp:GridView ID="GridView1" runat="server" BackColor="White" 
                    BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
                    AutoGenerateColumns="False" HorizontalAlign="Center">
                    <RowStyle HorizontalAlign="Center" />
                    <AlternatingRowStyle HorizontalAlign="Center" />
                    <Columns>
                        <asp:BoundField DataField="Bik_Id" HeaderText="Bik_Id" Visible="False" />
                        <asp:BoundField DataField="Bik_Name" HeaderText="Bik_Name" />
                        <asp:TemplateField HeaderText="BiKe_Photo">
                            <ItemTemplate>
                                <asp:Image ID="Image1" runat="server" Height="56px" 
                                    ImageUrl='<%# Eval("Bik_Photo") %>' Width="56px" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="Bik_Model" HeaderText="Bik_Model" />
                        <asp:BoundField DataField="BiK_CC" HeaderText="BiK_CC" />
                        <asp:BoundField DataField="Trip_Amount" HeaderText="Trip_Amount" />
                        <asp:BoundField DataField="Stn_Id" HeaderText="Stn_Id" Visible="False" />
                    </Columns>
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
