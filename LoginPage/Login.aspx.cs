using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BikeSharingSystem.LoginPage
{
    public partial class Login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        BLL b = new BLL();

        protected void Button1_Click(object sender, EventArgs e)
        {
            string type = ddlType.SelectedItem.Text;
            if (b.IsValid(type, txtName.Text, txtPassword.Text))
            {
                Session["User"] = txtName.Text;
                Session["Pswd"] = txtPassword.Text;
                if (type == "Admin")
                    Response.Redirect("~/Admin/_frmAdminHome.aspx");
                else
                    if(type == "Station Incharge")
                    Response.Redirect("~/StationInchargers/_frmStnInchargeHome.aspx");
                    else
                        if(type == "Customer")
                            Response.Redirect("~/Customers/_frmCustomerHome.aspx");
            }
            else
                Label1.Text = "Invalied User / Password";
                Label1.ForeColor = System.Drawing.Color.Red;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string type = ddlType.SelectedItem.Text;
            if (type == "Customer")
            {
                Response.Redirect("~/LoginPage/_frmForgotPassword.aspx");
            }
            else
            {
                Label2.Text = "Only for Customer.";
                Label2.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}