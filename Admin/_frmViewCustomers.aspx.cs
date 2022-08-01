using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BikeSharingSystem.Admin
{
    public partial class _frmViewCustomers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Text = "WELCOME " + Session["User"].ToString().ToUpper();
            if (!IsPostBack)
            {
                //BindGridViewData();
                getAddress();
            }
        }

        BLL b = new BLL();

        private void getAddress()
        {
            ddlCity.DataSource = b.getAdrs();
            ddlCity.DataTextField = "Address";
            ddlCity.DataBind();
            ListItem li = new ListItem("Select","-1");
            ddlCity.Items.Insert(0,"Select");
        }

        private void BindGridViewData()
        {
            string cty = ddlCity.SelectedItem.Text;
            GridView1.DataSource = b.GetCustomerDetails1(cty);
            GridView1.DataBind();
            int c = GridView1.Rows.Count;
            if (c == 0)
            {
                Label1.Text = "No Records Found..";
            }
        }

        protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCity.SelectedIndex != 0)
            {
                BindGridViewData();
            }
        }
    }
}