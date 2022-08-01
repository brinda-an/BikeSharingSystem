<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="_frmManageBikes.aspx.cs" Inherits="BikeSharingSystem.Admin._frmManageBikes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
<table style="width:100%;">
    <tr>
        <td colspan="3">
            <h2 style="text-align: center;">
                <strong>MANAGE BIKES</strong></h2>
        </td>
    </tr>
    <tr>
        <td style="width: 162px">
            &nbsp;
            <asp:Label ID="Label3" runat="server"></asp:Label>
            &nbsp;</td>
        <td style="width: 335px">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 162px">
            &nbsp;</td>
        <td style="width: 335px">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 162px">
            <b>&nbsp; Bike Name</b></td>
        <td style="width: 335px">
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="txtName" ErrorMessage="Enter Bike Name." ForeColor="#FF3300" 
                ValidationGroup="a"></asp:RequiredFieldValidator>
        </td>
    </tr>
    
    <tr>
        <td style="width: 162px">
            <b>&nbsp; Bike Model</b></td>
        <td style="width: 335px">
            <asp:TextBox ID="txtModel" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ErrorMessage="Enter Bike Model." ForeColor="#FF3300" ValidationGroup="a" 
                ControlToValidate="txtModel"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td style="width: 162px">
            <b>&nbsp; Bike CC</b></td>
        <td style="width: 335px">
            <asp:TextBox ID="txtCC" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ControlToValidate="txtCC" ErrorMessage="Enter Bike CC." ForeColor="#FF3300" 
                ValidationGroup="a"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td style="width: 162px">
            <b>&nbsp; Trip Amount</b></td>
        <td style="width: 335px">
            <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                ControlToValidate="txtAmount" ErrorMessage="Enter Trip Amount." 
                ForeColor="#FF3300" ValidationGroup="a"></asp:RequiredFieldValidator>
        </td>
    </tr>
   <%-- <tr>
        <td style="width: 162px">
            &nbsp; <strong>City&nbsp;</strong></td>
        <td style="width: 335px">
            <asp:DropDownList ID="ddlCity" runat="server" AutoPostBack="True" 
                onselectedindexchanged="ddlCity_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
        <td>
            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                ControlToValidate="ddlCity" ErrorMessage="Select City." ForeColor="#FF3300" 
                Operator="NotEqual" ValidationGroup="a" ValueToCompare="Select"></asp:CompareValidator>
        </td>
    </tr>--%>
    <tr>
        <td style="width: 162px">
            <strong>&nbsp; Station </strong></td>
        <td style="width: 335px">
            <asp:DropDownList ID="ddlStnId" runat="server">
            </asp:DropDownList>
        </td>
        <td>
            <asp:CompareValidator ID="CompareValidator2" runat="server" 
                ControlToValidate="ddlStnId" ErrorMessage="Select Station." ForeColor="#FF3300" 
                Operator="NotEqual" ValidationGroup="a" ValueToCompare="Select"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td style="width: 162px">
            <b>&nbsp; Bike Photo</b></td>
        <td style="width: 335px">
            <asp:FileUpload ID="FileUpload1" runat="server" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                ControlToValidate="FileUpload1" ErrorMessage="Attach a File." 
                ForeColor="#FF3300" ValidationGroup="a"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td style="width: 162px">
            &nbsp;</td>
        <td style="width: 335px">
            <asp:Button ID="Button1" runat="server" ForeColor="#FF9900" 
                onclick="Button1_Click" Text="ADD" ValidationGroup="a" />
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 162px">
            &nbsp;</td>
        <td style="width: 335px">
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 162px">
            &nbsp;</td>
        <td style="width: 335px">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" 
                CellPadding="3" CellSpacing="2" AllowPaging="True" 
                HorizontalAlign="Center" onpageindexchanging="GridView1_PageIndexChanging" 
                PageSize="5">
                <Columns>
                    <%--<asp:ImageField DataImageUrlField="Bik_Photo" HeaderText="Bike Photo">
                    </asp:ImageField>--%>
                    <asp:BoundField DataField="Bik_Id" HeaderText="Bike Id" Visible="False" />
                    <asp:BoundField DataField="Bik_Name" HeaderText="Bike Name" />
                    <asp:BoundField DataField="Bik_Model" HeaderText="Bike Model" />
                    <asp:BoundField DataField="Bik_CC" HeaderText="Bike CC" />
                    <asp:BoundField DataField="Trip_Amount" HeaderText="Trip Amount" 
                        ItemStyle-HorizontalAlign="Center">
<ItemStyle HorizontalAlign="Center"></ItemStyle>
                    </asp:BoundField>
                    <asp:TemplateField HeaderText="Bike Photo">
                        <ItemTemplate>
                            <asp:Image ID="Image1" runat="server" Height="55px" 
                                ImageUrl='<%# Eval("Bik_Photo") %>' Width="85px" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Stn_Name" HeaderText="Stn_Name" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="LB_Edit" runat="server" onclick="LB_Edit_Click" CommandArgument='<%# Eval("Bik_Id") %>' 
                             >Edit</asp:LinkButton>
                            <asp:LinkButton ID="LB_Delete" runat="server" onclick="LB_Delete_Click" 
                                CommandArgument='<%# Eval("Bik_Id") %>'
                                OnClientClick="returnconfirm('Are You sure you want to delete this record?');">Delete</asp:LinkButton>
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
    <tr>
        <td colspan="3">
            &nbsp;</td>
    </tr>
</table>
</form>
</asp:Content>
