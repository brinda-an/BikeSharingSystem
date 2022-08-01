<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="_frmCities.aspx.cs" Inherits="BikeSharingSystem.Admin._frmCities" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
    <table style="width:100%;">
        <tr>
            <td>
                <h2 style="text-align: center;">
                    <strong>CREATE CITIES</strong></h2>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;&nbsp;
                <asp:Label ID="Label3" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="3" style="color:Black">
            <table style="width:70%; margin-left:15%">
            <tr><td>
            <%--<fieldset style="width:100%;">
            <legend><b>CITY</b></legend>--%>
                <table style="width:100%">
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
                            <strong>City Name</strong></td>
                        <td>
                            <asp:TextBox ID="txtCity" runat="server" placeholder="City Name"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ControlToValidate="txtCity" ErrorMessage="*" ForeColor="#FF3300" 
                                ValidationGroup="a"></asp:RequiredFieldValidator>
                            &nbsp;
                            <asp:Label ID="Label2" runat="server" ForeColor="#FF3300"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            <asp:Button ID="Button1" runat="server" ForeColor="#CC6600" 
                                onclick="Button1_Click" Text="ADD" ValidationGroup="a" />
                            &nbsp;&nbsp;
                            <asp:Button ID="Button2" runat="server" ForeColor="#FF9900" 
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
                </table>
            <%--</fieldset>--%>
            </td></tr>
            </table>
            
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
            <td colspan="3" style="color:Black" align="center">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" 
                    CellPadding="3" CellSpacing="2" AllowPaging="True" 
                    onpageindexchanging="GridView1_PageIndexChanging" PageSize="5">
                    <Columns>
                        <asp:BoundField DataField="City_Id" HeaderText="City_Id" />
                        <asp:BoundField DataField="City" HeaderText="City" />
                        <asp:TemplateField>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:LinkButton ID="LB_Edit" runat="server"
                                CommandArgument='<%# Eval("City_Id") %>' onclick="LB_Edit_Click">Edit</asp:LinkButton>
                                <asp:LinkButton ID="LB_Delete" runat="server"
                                CommandArgument='<%# Eval("City_Id") %>' onclick="LB_Delete_Click" OnClientClick="return confirm('Are you sure you want to delete this record?');">Delete</asp:LinkButton>
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
    </ContentTemplate>
    </asp:UpdatePanel>
    </form>
</asp:Content>
