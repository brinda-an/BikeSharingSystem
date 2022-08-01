using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BikeSharingSystem.Customers
{
    public partial class _frmViewBookingDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            usr=Session["User"].ToString();
            if (!IsPostBack)
            {
                BindGridViewData();
                Label1.Text ="Welcome "+ Session["User"].ToString();
                getPick();
            }
        }

        BLL b = new BLL();
        static string usr;

        private void getPick()
        {
            Image1.ImageUrl = b.get_Pick(usr);
        }

        private void BindGridViewData()
        {
            string Nam = Session["User"].ToString();
            //string ps = Session["Pswd"].ToString();
            int Cid = b.Get_UserId(Nam);
            GridView1.DataSource = b.GetCustBookedDetails(Cid);
            GridView1.DataBind();
            int c = GridView1.Rows.Count;
            if (c == 0)
            {
                Label2.Text = "No Records Found..";
            }
        }
    }
}