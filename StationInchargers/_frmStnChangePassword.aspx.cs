using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BikeSharingSystem.StationInchargers
{
    public partial class _frmStnChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Text = "WELCOME " + Session["User"].ToString().ToUpper();
            Label2.ForeColor = System.Drawing.Color.Violet;
        }

        BLL b = new BLL();

        protected void Button1_Click(object sender, EventArgs e)
        {
            int psw = b.getOldPswd_Stn(Session["User"].ToString());
            if (psw == int.Parse(txtOldPsw.Text))
            {
                if (b.updatePsw_Stn(txtNewPsw.Text, Session["User"].ToString()))
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
            txtConfNewPsw.Text = "";
        }
    }
}