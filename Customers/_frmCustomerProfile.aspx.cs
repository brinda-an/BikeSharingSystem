using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace BikeSharingSystem.Customers
{
    public partial class _frmCustomerProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            usr = Session["User"].ToString();
            Label2.Text = "Welcome " + Session["User"].ToString();
            Label2.ForeColor = System.Drawing.Color.Violet;
            if (!this.IsPostBack)
            {
                View_Profile();
                getPick();
            }
        }

        BLL b = new BLL();
        static string usr;
        static DataTable tab = new DataTable();

        private void View_Profile()
        {
            MultiView1.SetActiveView(View1);
            tab = b.getCustomerProfile(usr);
            lblName.Text = tab.Rows[0][0].ToString();
            lblAdrs.Text = tab.Rows[0][1].ToString();
            lblCont.Text = tab.Rows[0][2].ToString();
            lbleMail.Text = tab.Rows[0][3].ToString();
        }

        private void getPick()
        {
            Image1.ImageUrl = b.get_Pick(usr);
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(View2);
            txtName.Text = tab.Rows[0][0].ToString();
            txtName.ReadOnly = true;
            txtCont.Text = tab.Rows[0][2].ToString();
            txtAddr.Text = tab.Rows[0][1].ToString();
            txteMail.Text = tab.Rows[0][3].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (b.updateProfile_Customer(txtName.Text, txtAddr.Text, txtCont.Text, txteMail.Text,usr))
            {
                Label1.Text = "Profile Updated..";
                Label1.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                Label1.Text = "Error in Updating..";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            reset();
        }

        private void reset()
        {
            txtName.Text = "";
            txtCont.Text = "";
            txtAddr.Text = "";
            txteMail.Text = "";
        }
    }
}