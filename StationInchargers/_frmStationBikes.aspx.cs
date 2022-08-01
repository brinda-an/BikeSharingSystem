using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace BikeSharingSystem.StationInchargers
{
    public partial class _frmStationBikes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                ViewGv();
                Label1.Text = "WELCOME " + Session["User"].ToString().ToUpper();
                Label1.ForeColor = System.Drawing.Color.Brown;
            }
        }

        BLL b = new BLL();

        private void ViewGv()
        {
            string usr = Session["User"].ToString();
            int cstId = b.GetIncId1(usr);
            DataTable tab=b.getList(cstId);
            if(tab.Rows.Count>0)
            {
                GridView1.DataSource = tab;
                GridView1.DataBind();
            }
            else
            {
                Label2.Text="No Bikes Available..";
                Label2.ForeColor=System.Drawing.Color.Red;
            }
        }
    }
}