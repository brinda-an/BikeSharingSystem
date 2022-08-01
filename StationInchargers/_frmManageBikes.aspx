<%@ Page Title="" Language="C#" MasterPageFile="~/StationInchargers/StnIncharge.Master" AutoEventWireup="true" CodeBehind="_frmManageBikes.aspx.cs" Inherits="BikeSharingSystem.StationInchargers._frmManageBikes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <table style="width:100%;">
        <tr>
            <td colspan="3">
                <h2 style="text-align: center">
                    <strong>MANAGE BIKES</strong></h2>
            </td>
        </tr>
        <tr>
            <td style="width: 117px">
                &nbsp;&nbsp;
                <asp:Label ID="Label4" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 117px">
                &nbsp;</td>
            <td>
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label5" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 117px; height: 22px;">
                <b>&nbsp;Select City&nbsp;</b></td>
            <td style="height: 22px">
                <asp:DropDownList ID="ddlCity" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="ddlCity_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td style="height: 22px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 117px; height: 22px;">
                <b>&nbsp;Select Station&nbsp;</b></td>
            <td style="height: 22px">
                <asp:DropDownList ID="ddlStation" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="ddlStation_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td style="height: 22px">
                </td>
        </tr>
        <tr>
            <td style="width: 117px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" 
                    CellPadding="4">
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:CheckBox ID="CheckBox3" runat="server" Text='<%# Eval("StnInc_Id") %>' 
                                    oncheckedchanged="CheckBox3_CheckedChanged" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="Date" HeaderText="Date" />
                        <asp:TemplateField HeaderText="StnInc_Id">
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("StnInc_Id") %>' 
                                    ToolTip='<%# Eval("StnInc_Id") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("StnInc_Id") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="Departure" HeaderText="Departure" />
                        <asp:BoundField DataField="Arrival" HeaderText="Arrival" />
                        <asp:TemplateField HeaderText="Cus_Photo">
                            <ItemTemplate>
                                <asp:Image ID="Image1" runat="server" Height="52px" 
                                    ImageUrl='<%# Eval("Photo") %>' Width="67px" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Bik_Id">
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("Bik_Id") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Bik_Id") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="Bik_Name" HeaderText="Bik_Name" />
                        <asp:BoundField DataField="Status" HeaderText="Status" />
                        <asp:BoundField DataField="Msi_Id" HeaderText="Msi_Id" Visible="False" />
                        <asp:BoundField DataField="Stn_Id" HeaderText="Stn_Id" Visible="False" />
                        <asp:BoundField DataField="StnBik_Id" HeaderText="StnBik_Id" Visible="False" />
                    </Columns>
                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                    <PagerStyle ForeColor="#003399" HorizontalAlign="Left" BackColor="#99CCCC" />
                    <RowStyle BackColor="White" ForeColor="#003399" />
                    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SortedAscendingCellStyle BackColor="#EDF6F6" />
                    <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                    <SortedDescendingCellStyle BackColor="#D6DFDF" />
                    <SortedDescendingHeaderStyle BackColor="#002876" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td style="width: 117px">
                &nbsp;
                <asp:Button ID="Button3" runat="server" ForeColor="Blue" Height="27px" 
                    Text="Approve" onclick="Button3_Click" Width="68px" />
            </td>
            <td>
                <asp:Button ID="Button5" runat="server" ForeColor="Blue" 
                    onclick="Button5_Click" Text="Recived" Height="27px" Width="68px" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </form>
</asp:Content>
