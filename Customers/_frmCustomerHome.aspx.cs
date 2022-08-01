using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BikeSharingSystem.Customers
{
    public partial class _frmCustomerHome1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            usr = Session["User"].ToString();
            if (!this.IsPostBack)
            {
                getPick();
                Label1.Text = Session["User"].ToString();
            }
        }

        BLL b = new BLL();
        static string usr;

        private void getPick()
        {
            Image1.ImageUrl = b.get_Pick(usr);
        }
    }
}