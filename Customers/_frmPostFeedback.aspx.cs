using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BikeSharingSystem.Customers
{
    public partial class _frmPostFeedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usr=Session["User"].ToString();
            if (!IsPostBack)
            {
                getPick();
                Label2.Text = Session["User"].ToString();
                ViewGridViewData();
            }
        }

        BLL b = new BLL();
        static string Usr;

        private void getPick()
        {
            Image1.ImageUrl = b.get_Pick(Usr);
        }

        private void ViewGridViewData()
        {
            string Nam = Session["User"].ToString();
            //string ps = Session["Pswd"].ToString();
            int Cid = b.Get_UserId(Nam);
            GridView1.DataSource = b.View_FeedBack(Cid);
            GridView1.DataBind();
            txtFeedback.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string Nam = Session["User"].ToString();
            //string ps = Session["Pswd"].ToString();
            int Cid = b.Get_UserId(Nam);
            //int bid = b.GetBid(Cid);
            if (b.checkFeebback(Cid))
            {
                Label1.Text = "Feedback Already Posted..";
            }
            else
            {
                if (b.Post_Feedback(txtFeedback.Text, date, Cid))
                {
                    Label1.Text = "Feedback Added Sucessfully.";
                }
                else
                {
                    Label1.Text = "Error in Adding.";
                }
            }
            ViewGridViewData();
        }
    }
}