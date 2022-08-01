<%@ Page Title="" Language="C#" MasterPageFile="~/Customers/Customer.Master" AutoEventWireup="true" CodeBehind="_frmBrowseBike.aspx.cs" Inherits="BikeSharingSystem.Customers._frmBrowseBike" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <table style="width:100%;">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <h2>
                    <strong>Browse Bikes</strong></h2>
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
                <asp:Label ID="Label4" runat="server"></asp:Label>
            &nbsp;
                <asp:Image ID="Image3" runat="server" Height="45px" Width="45px" />
            </td>
        </tr>
        <tr>
            <td>
                <strong>City</strong></td>
            <td>
                <asp:DropDownList ID="ddlCity" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="ddlCity_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <b>Station </b></td>
            <td>
                <asp:DropDownList ID="ddlStnName" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="ddlStnName_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <b>Bike Model</b></td>
            <td>
                <asp:DropDownList ID="ddlModel" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="ddlModel_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;
                &nbsp;</td>
            <td>
                <asp:Label ID="Label6" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:DataList ID="DataList1" runat="server" RepeatColumns="4" Width="628px">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("Bik_Name") %>'></asp:Label>
                        <br />
                        <asp:Image ID="Image1" runat="server" Height="41px" 
                            ImageUrl='<%# Eval("Bik_Photo") %>' Width="122px" />
                        <br />
                        <asp:Image ID="Image2" runat="server" Height="19px" 
                            ImageUrl="~/images/rupe.jpg" />
                        &nbsp;
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("Trip_Amount") %>'></asp:Label>
                        /hr<br />
                        <asp:Label ID="Label3" runat="server" Visible="false" Text='<%# Eval("Bik_Id") %>'></asp:Label>
                        <%--<asp:Label ID="Label5" runat="server" Visible="false" Text='<%# Eval("Stn_Id") %>'></asp:Label>--%>
                        <br />
                        <asp:Button ID="Button1" runat="server" ForeColor="#FF9900" 
                            onclick="Book_Click" Text="Book" />
                    </ItemTemplate>
                </asp:DataList>
            </td>
        </tr>
        <tr>
            <td colspan="3">
                &nbsp;</td>
        </tr>
    </table>
    </form>
</asp:Content>
