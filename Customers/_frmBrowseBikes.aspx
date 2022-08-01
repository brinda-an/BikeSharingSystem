<%@ Page Title="" Language="C#" MasterPageFile="~/Customers/Customer.Master" AutoEventWireup="true" CodeBehind="_frmBrowseBikes.aspx.cs" Inherits="BikeSharingSystem.Customers._frmCustomerHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <table style="width:100%;">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                <asp:Label ID="Label6" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <strong>Station Name</strong></td>
            <td>
                <asp:DropDownList ID="ddlStnName" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="ddlStnName_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td>
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToValidate="ddlStnName" ErrorMessage="Select Station Name." 
                    ForeColor="#FF3300" Operator="NotEqual" ValueToCompare="Select"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td>
                <strong>Bike Model</strong></td>
            <td>
                <asp:DropDownList ID="ddlModel" runat="server" 
                    onselectedindexchanged="ddlModel_SelectedIndexChanged" AutoPostBack="True">
                </asp:DropDownList>
            </td>
            <td>
                <asp:CompareValidator ID="CompareValidator2" runat="server" 
                    ControlToValidate="ddlModel" ErrorMessage="Select Bike Model." 
                    ForeColor="#FF3300" Operator="NotEqual" ValueToCompare="Select"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Label ID="Label5" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Label ID="lblBikeName" runat="server" Text='<%# Eval("Bik_Name") %>' ></asp:Label>
                                <br />
                                <asp:Image ID="Image2" runat="server" Height="44px" Width="110px" ImageUrl='<%# Eval("Bik_Photo") %>'/>
                                <br />
                                <asp:Label ID="lblPrice" runat="server" Text='<%# Eval("Trip_Amount") %>'></asp:Label>
                                <br />
                                <asp:Label ID="lblBikeId" runat="server" Text='<%# Eval("Bik_Id") %>' 
                                    Visible="False" ></asp:Label>
                                <br />
                                <%--<asp:Label ID="Label6" runat="server" Text='<%# Eval("Bik_CC") %>'></asp:Label>
                                <br />--%>
                                <asp:Button ID="Button2" runat="server" Text="Accept" 
                                    CommandArgument='<%# Eval("Bik_Id") %>' ForeColor="#FF9900" 
                                    onclick="Accept_Click" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
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
            <td>
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
    </table>
    </form>
</asp:Content>
