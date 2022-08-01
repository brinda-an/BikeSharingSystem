<%@ Page Title="" Language="C#" MasterPageFile="~/Customers/Customer.Master" AutoEventWireup="true" CodeBehind="_frmPostFeedback.aspx.cs" Inherits="BikeSharingSystem.Customers._frmPostFeedback" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <head>
    <title></title>
   <%-- <script type="text/javascript" language="javascript">
        function Count(x) {

            document.getElementById("Label3").innerHTML = document.getElementById("txtFeedback").value.length;
        }
    </script>--%>
     <script type="text/javascript" language="javascript">
         function CountCharacters() {
             var maxSize = 50;
             if (document.getElementById('<%= txtFeedback.ClientID %>')) {
                 var ctrl = document.getElementById('<%= txtFeedback.ClientID %>');
                 var len = document.getElementById('<%= txtFeedback.ClientID %>').value.length;
                 if (len <= maxSize) {
                     var diff = parseInt(maxSize) - parseInt(len);

                     if (document.getElementById('<%= Label3.ClientID %>')) {
                         document.getElementById('<%= Label3.ClientID %>').innerHTML = "Characters remaining: " + diff;
                     }
                 }
                 else {
                     ctrl.value = ctrl.value.substring(0, maxSize);
                 }
             }

             return false;
         }
    </script>
    </head>
    <form id="form1" runat="server">
    <table style="width:100%;">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <h2>
                    <strong>Post Feedback</strong></h2>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server"></asp:Label>
            &nbsp;
                <asp:Image ID="Image1" runat="server" Height="45px" Width="45px" />
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <strong>Enter Feedback</strong></td>
            <td>
                <asp:TextBox ID="txtFeedback" runat="server" TextMode="MultiLine" MaxLength="50"
                    onkeyup="CountCharacters()" Height="52px" Width="286px"></asp:TextBox>
            &nbsp;<br />
                <asp:Label ID="Label3" runat="server">Characters remaining: 50</asp:Label>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtFeedback" ErrorMessage="Enter Feedback." 
                    ForeColor="#FF3300" ValidationGroup="a"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" ForeColor="#FF9900" 
                    onclick="Button1_Click" Text="Submit" ValidationGroup="a" />
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
                    CellPadding="3" CellSpacing="2" style="margin-left:20%">
                    <Columns>
                        <asp:BoundField DataField="FeedBak" HeaderText="FeedBak" />
                        <asp:BoundField DataField="Date" HeaderText="Date" />
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
