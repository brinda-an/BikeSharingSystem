using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BikeSharingSystem.Customers
{
    public partial class _frmCustomerHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                GetStansName();
                //GetBikemodel();
                ddlModel.Enabled = false;
                GridView1.Enabled = false;
                Label6.Text = Session["User"].ToString();
            }
        }

        BLL b = new BLL();
        static int bid = 0;

        private void GetStansName()
        {
            ddlStnName.DataSource = b.GetStName();
            ddlStnName.DataTextField = "Stn_Name";
            ddlStnName.DataValueField = "Stn_Id";
            ddlStnName.DataBind();
            ListItem lis = new ListItem("Select", "-1");
            ddlStnName.Items.Insert(0, "Select");
        }

        private void GetBikemodel()
        {
            ddlModel.Items.Clear();
            string stId = ddlStnName.SelectedItem.Value;
            ddlModel.DataSource = b.GetBikeModel(stId);
            ddlModel.DataTextField = "Bik_Model";
            ddlModel.DataValueField = "Bik_Model";
            ddlModel.DataBind();
            ListItem lis = new ListItem("Select", "-1");
            ddlModel.Items.Insert(0, "Select");
        }
        protected void ddlModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string stId = ddlStnName.SelectedItem.Value;
            string mod = ddlModel.SelectedItem.Text;
            if (ddlModel.SelectedIndex != 0)
            {
                GridView1.Enabled = true;
                //string mod = ddlModel.SelectedItem.Text;
                GridView1.DataSource = b.GetBikeNamImgCc(mod, stId);
                GridView1.DataBind();
                int c = GridView1.Rows.Count;
                if (c == 0)
                {
                    Label5.Text = "No Records Found..";
                }
            }
        }

        protected void Accept_Click(object sender, EventArgs e)
        {
            GridViewRow row = (GridViewRow)((Button)sender).Parent.Parent;
            bid = int.Parse(((Button)sender).CommandArgument);
            var dateAsString = DateTime.Now.ToString("yyyy-MM-dd");
            //string UsrName=Session["User"].ToString();
            //string UsrPswd=Session["Pswd"].ToString();
            //int cstId=b.GetCustId(string UsrName,string usrPswd);
            //string psw = Session["Pswd"].ToString();
            int cstId = b.GetCustId(Session["User"].ToString());
            int stid=int.Parse(ddlStnName.SelectedItem.Value);
            if (b.AddBooking(bid,cstId,dateAsString,stid))
            {
                Label5.Text = "Booking Added Sucessfully.";
            }
            else
            {
                Label5.Text = "Error in Booking.";
            }
        }

        protected void ddlStnName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlStnName.SelectedIndex != 0)
            {
               ddlModel.Enabled = true;
               GetBikemodel();
            }
        }

        
    }
}