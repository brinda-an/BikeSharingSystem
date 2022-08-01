using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BikeSharingSystem.Admin
{
    public partial class _frmViewFeedbaks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "WECOME " + Session["User"].ToString().ToUpper();
            if (!IsPostBack)
            {
                ViewGridViewData();
            }
        }

        BLL b = new BLL();

        private void ViewGridViewData()
        {
            GridView1.DataSource = b.GetFeedBack();
            GridView1.DataBind();
        }
    }
}