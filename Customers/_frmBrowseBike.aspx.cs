using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace BikeSharingSystem.Customers
{
    public partial class _frmBrowseBike : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            usr=Session["User"].ToString();
            if (!IsPostBack)
            {
                getCity();
                getPick();
                ddlModel.Enabled = false;
                DataList1.Enabled = false;
                Label4.Text = Session["User"].ToString();
            }
        }

        BLL b = new BLL();
        static string usr;

        private void getPick()
        {
            Image3.ImageUrl = b.get_Pick(usr);
        }

        private void getCity()
        {
            ddlCity.DataSource = b.GetCity();
            ddlCity.DataTextField = "City";
            ddlCity.DataValueField = "City_Id";
            ddlCity.DataBind();
            ListItem lis = new ListItem("Select", "-1");
            ddlCity.Items.Insert(0, "Select");
        }

        private void GetStansName()
        {
            string ctId = ddlCity.SelectedItem.Value;
            ddlStnName.DataSource = b.GetStName1(ctId);
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

        protected void Book_Click(object sender, EventArgs e)
        {
            //ImageButton btn = (ImageButton)sender;
            Button btn = (Button)sender;
            DataListItem item = (DataListItem)btn.NamingContainer;
            Label lbId = (Label)item.FindControl("Label3");
            string Id = lbId.Text;
            Label ibPr = (Label)item.FindControl("Label2");
            string lbp = ibPr.Text;
            Button bt = (Button)item.FindControl("Button1");
            var dateAsString = DateTime.Now.ToString("yyyy-MM-dd");
            //string psw = Session["Pswd"].ToString();
            int cstId = b.GetCustId(Session["User"].ToString());
            string em = b.getusrEm(Session["User"].ToString());
            int stid = int.Parse(ddlStnName.SelectedItem.Value);
            string stName = ddlStnName.SelectedItem.Text;
            string modName = ddlModel.SelectedItem.Text;
            if (bt.Text == "Book")
            {
                //Button tmpBtn = e.Item.FindControl("btnQuizVid") as Button;
                if (b.AddBooking1(Id, cstId, dateAsString, stid))
                {
                    try
                    {
                        Emails.MailSender.SendEmail("bcaproject48@gmail.com", "projectpassword", em, "Bike Booked Details", "Welcome to Online Based Bike Sharing System, Your Booked Bike Name-" + modName + " and Station Name-" + stName + " and Price-" + lbp + "   Thank You..", "");
                        //Response.Write("<script>alert('Mail send successfully.')</script>");
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('Mail sent successfully.')</script>");
                    }
                    catch
                    {
                        //Response.Write("<script>alert('Error in sending mail.')</script>");
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('Error in sending mail.')</script>");
                    }
                    Label6.Text = "Thank you for Booking..";
                    Label6.ForeColor = System.Drawing.Color.Green;
                    Response.Write("<script>alert('Booking Added Sucessfully.')</script>");
                    bt.Text = "Booked";
                }
                else
                {
                    Label6.Text = "Error in Booking.";
                    Response.Write("<script>alert('Error in Booking..')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('This Veikal already Booked..')</script>");
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

        protected void ddlModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string stId = ddlStnName.SelectedItem.Value;
            string mod = ddlModel.SelectedItem.Text;
            if (ddlModel.SelectedIndex != 0)
            {
                DataList1.Enabled = true;
                //string mod = ddlModel.SelectedItem.Text;
                DataTable tab = b.GetBikeNamImgCc(mod, stId);
                if (tab.Rows.Count > 0)
                {
                    DataList1.Visible = true;
                    DataList1.DataSource = tab;
                    DataList1.DataBind();
                    Label6.Visible = false;
                }
                else
                {
                    DataList1.Visible = false;
                    Label6.Visible = true;
                    Label6.Text = "This Bike is already Booked wait for sometime if you need the same Bike..";
                    Label6.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCity.SelectedIndex != 0)
            {
                GetStansName();
            }
        }
    }
}