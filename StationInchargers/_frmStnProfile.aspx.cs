using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace BikeSharingSystem.StationInchargers
{
    public partial class _frmStnProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            usr=Session["User"].ToString();
            Label2.Text = "WELCOME " + Session["User"].ToString().ToUpper();
            Label2.ForeColor = System.Drawing.Color.Violet;
            if (!this.IsPostBack)
            {
                View_Profile();
            }
        }

        BLL b = new BLL();
        static string usr;
        static DataTable tab = new DataTable();

        private void View_Profile()
        {
            MultiView1.SetActiveView(View1);
            tab = b.getStnProfile(usr);
            lblName.Text = tab.Rows[0][0].ToString();
            lblContNo.Text = tab.Rows[0][1].ToString();
            lblAddr.Text = tab.Rows[0][2].ToString();
            lbleMail.Text = tab.Rows[0][3].ToString();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(View2);
            txtName.Text = tab.Rows[0][0].ToString();
            txtName.ReadOnly = true;
            txtContNo.Text = tab.Rows[0][1].ToString();
            txtAddr.Text = tab.Rows[0][2].ToString();
            txteMail.Text = tab.Rows[0][3].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (b.updateStnProfile(txtName.Text, txtContNo.Text, txtAddr.Text, txteMail.Text, txtName.Text))
            {
                Label1.Text = "Update Sucessfull..";
            }
            else
            {
                Label1.Text = "Error in Updating..";
            }
            reset();
        }

        private void reset()
        {
            txtName.Text = "";
            txtContNo.Text = "";
            txtAddr.Text = "";
            txteMail.Text = "";
        }
    }
}