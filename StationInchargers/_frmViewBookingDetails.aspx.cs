using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BikeSharingSystem.StationInchargers
{
    public partial class _frmViewBookingDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewGridViewData();
                Label1.Text ="WELCOME "+ Session["User"].ToString().ToUpper();
                Label1.ForeColor = System.Drawing.Color.Brown;
            }
        }

        BLL b = new BLL();

        private void ViewGridViewData()
        {
            string name = Session["User"].ToString();
            //string psw = Session["Pswd"].ToString();
            int StId = b.GetStnId(name);
            GridView2.DataSource = b.GetBookDetails(StId);
            GridView2.DataBind();
            int c = GridView2.Rows.Count;
            if (c == 0)
            {
                Label2.Text = "No Records Found..";
                Label2.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}