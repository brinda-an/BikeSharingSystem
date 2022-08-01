using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BikeSharingSystem.Admin
{
    public partial class _frmAddStationRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label3.Text = "WELCOME " + Session["User"].ToString().ToUpper();
            if (!IsPostBack)
            {
                BindGridViewData();
                GetCity();
                Button2.Visible = false;
            }
        }

        BLL b = new BLL();
        static int stid = 0;

        private void BindGridViewData()
        {
            GridView1.DataSource = b.GetStation();
            GridView1.DataBind();
        }

        private void GetCity()
        {
            ddlCityName.DataSource = b.GetCity();
            ddlCityName.DataTextField = "City";
            ddlCityName.DataValueField = "City_Id";
            ddlCityName.DataBind();
            ListItem licity = new ListItem("Select", "-1");
            ddlCityName.Items.Insert(0, "Select");
        }

        protected void LB_Edit_Click(object sender, EventArgs e)
        {
            GridViewRow row = (GridViewRow)((LinkButton)sender).Parent.Parent;
            stid=int.Parse(((LinkButton)sender).CommandArgument);
            //Button1.Text = "Update";
            Button1.Visible = false;
            Button2.Visible = true;
            osubid = row.Cells[0].Text;
            txtStnName.Text = row.Cells[1].Text;
            //txtStnName.Attributes.Add("readonly", "readonly");
            txtStnName.ReadOnly = true;
            txtAddress.Text = row.Cells[2].Text;
            txtContactNo.Text = row.Cells[3].Text;
            ListItem lst = new ListItem();
            lst.Text = row.Cells[4].Text;
            int index=ddlCityName.Items.IndexOf(lst);
            ddlCityName.SelectedIndex = index;
        }

        protected void LB_Delete_Click(object sender, EventArgs e)
        {
            GridViewRow row = (GridViewRow)((LinkButton)sender).Parent.Parent;
            stid = int.Parse(((LinkButton)sender).CommandArgument);
            if (b.DeleteStation(stid))
            {
                Label1.Text = "Station Deleted Sucessfully.";
                Label1.ForeColor = System.Drawing.Color.Green;
                BindGridViewData();
            }
            else
            {
                Label1.Text = "Error in Deleting.";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string city = ddlCityName.SelectedItem.Value;
            //if (Button1.Text == "ADD")
            //{
                if (b.checkStnName(txtStnName.Text))
                {
                    Label2.Visible = true;
                    Label2.Text = "Station Name Exist.";
                }
            //}
            else
                //if (Button1.Text == "ADD" || Button1.Text == "Update")
            {
                Label2.Visible = false;
                //if (Button1.Text == "ADD")
                {
                    if (b.AddStation(txtStnName.Text, txtAddress.Text, txtContactNo.Text, city))
                    {
                        BindGridViewData();
                        reset();
                        Label1.Text = "Station Added Sucessfully.";
                        Label1.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        reset();
                        Label1.Text = "Error in Station Adding.";
                        Label1.ForeColor = System.Drawing.Color.Red;
                    }
                }
                //else
                //    if (b.UpdateStation(osubid, txtAddress.Text, txtContactNo.Text, city))
                //    {
                //        BindGridViewData();
                //        reset();
                //        Label1.Text = "Station Updated Sucessfully.";
                //        Label1.ForeColor = System.Drawing.Color.Green;
                //        Button1.Text = "ADD";
                //    }
                //    else
                //    {
                //        reset();
                //        Label1.Text = "Error in Updating.";
                //        Label1.ForeColor = System.Drawing.Color.Red;
                //        Button1.Text = "ADD";
                //    }
            }
            BindGridViewData();
        }

        public static string osubid { get; set; }

        void reset()
        {
            txtStnName.Text = "";
            txtAddress.Text = "";
            txtContactNo.Text = "";
            ddlCityName.SelectedIndex = -1;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string city = ddlCityName.SelectedItem.Value;
            if (b.UpdateStation(osubid, txtAddress.Text, txtContactNo.Text, city))
            {
                BindGridViewData();
                reset();
                Label1.Text = "Station Updated Sucessfully.";
                Label1.ForeColor = System.Drawing.Color.Green;
                Button1.Text = "ADD";
            }
            else
            {
                reset();
                Label1.Text = "Error in Updating.";
                Label1.ForeColor = System.Drawing.Color.Red;
                Button1.Text = "ADD";
            }
            BindGridViewData();
            Button2.Visible = false;
            Button1.Visible = true;
            txtStnName.ReadOnly = false;
        }
    }
}