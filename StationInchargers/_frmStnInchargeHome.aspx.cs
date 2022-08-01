using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BikeSharingSystem.StationInchargers
{
    public partial class _frmStnInchargeHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                Label1.Text = "WELCOME " + Session["User"].ToString().ToUpper();
                Label1.ForeColor = System.Drawing.Color.Brown;
            }
        }
    }
}