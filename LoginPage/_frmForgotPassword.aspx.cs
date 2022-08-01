using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace BikeSharingSystem.LoginPage
{
    public partial class _frmForgotPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        BLL b = new BLL();

        protected void Button1_Click(object sender, EventArgs e)
        {
            //DataTable tab=b.getPassword(txtName.Text,txtDL.Text);
            //if (tab.Rows.Count > 0)
            //{
            //    Label1.Text = tab.ToString();
            //}
            //else
            //{
            //    Label2.Text = "User Name and Password inCorrect.";
            //}

            string psw=b.getPassword1(txtName.Text,txtDL.Text);
            if (psw != null)
            {
                Label1.Text = psw;
            }
            else
            {
                Label2.Text = "User Name and Password inCorrect.";
            }
        }
    }
}