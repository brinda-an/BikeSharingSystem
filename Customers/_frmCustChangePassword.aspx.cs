using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BikeSharingSystem.Customers
{
    public partial class _frmCustChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            usr=Session["User"].ToString();
            Label2.Text = "Welcome " + Session["User"].ToString();
            Label2.ForeColor = System.Drawing.Color.Violet;
            getPick();
        }

        BLL b = new BLL();
        static string usr;

        private void getPick()
        {
            Image1.ImageUrl = b.get_Pick(usr);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int psw = b.getOldPswd_Cust(Session["User"].ToString());
            if (psw == int.Parse(txtOldPsw.Text))
            {
                if (b.updatePsw_Cust(txtNewPsw.Text, Session["User"].ToString()))
                {
                    Label1.Text = "Pasword Updated Sucessfully..";
                    Label1.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    Label1.Text = "Error in Pasword Updating..";
                    Label1.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                Label1.Text = "Wrong Password..";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            reset();
        }

        private void reset()
        {
            txtOldPsw.Text = "";
            txtNewPsw.Text = "";
            txtCnfPsw.Text = "";
        }
    }
}