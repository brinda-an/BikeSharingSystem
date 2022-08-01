using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BikeSharingSystem.Admin
{
    public partial class _frmMngStationIncharge : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Text = "WELCOME " + Session["User"].ToString().ToUpper();
            if (!IsPostBack)
            {
                BindGridViewData();
                GetStnName();
                Button2.Visible = false;
                //getCity();
                //ddlstnName.Visible = false;
            }
        }

        BLL b = new BLL();
        static int msi = 0;

        private void BindGridViewData()
        {
            GridView1.DataSource = b.GetMngStnIncharge();
            GridView1.DataBind();
        }

        //private void getCity()
        //{
        //    ddlCity.DataSource = b.GetCity();
        //    ddlCity.DataTextField = "City";
        //    ddlCity.DataValueField = "City_Id";
        //    ddlCity.DataBind();
        //    ListItem li = new ListItem("Select","-1");
        //    ddlCity.Items.Insert(0,"Select");
        //}

        private void GetStnName()
        {
            //int cty = int.Parse(ddlCity.SelectedItem.Value);
            ddlstnName.DataSource = b.GetStnName();
            ddlstnName.DataTextField = "Stn_Name";
            ddlstnName.DataValueField = "Stn_Id";
            ddlstnName.DataBind();
            ListItem lst = new ListItem("Select", "-1");
            ddlstnName.Items.Insert(0, "Select");
        }

        protected void LB_Edit_Click(object sender, EventArgs e)
        {
            GridViewRow row = (GridViewRow)((LinkButton)sender).Parent.Parent;
            msi=int.Parse(((LinkButton)sender).CommandArgument);
            //Button1.Text = "Update";
            Button2.Visible = true;
            Button1.Visible = false;
            osubid = row.Cells[0].Text;
            txtName.Text = row.Cells[1].Text;
            //txtName.Attributes.Add("readonly", "readonly");
            txtName.ReadOnly = true;
            txtContactNo.Text = row.Cells[2].Text;
            txtAddress.Text = row.Cells[3].Text;
            txteMail.Text = row.Cells[4].Text;
            txtPassword.Text = row.Cells[5].Text;
            ListItem lst = new ListItem();
            lst.Text = row.Cells[6].Text;
            int index = ddlstnName.Items.IndexOf(lst);
            ddlstnName.SelectedIndex = index;
        }

        protected void LB_Delete_Click(object sender, EventArgs e)
        {
            GridViewRow row = (GridViewRow)((LinkButton)sender).Parent.Parent;
            msi = int.Parse(((LinkButton)sender).CommandArgument);
            if (b.DeleteMngStnIncharge(msi))
            {
                Label1.Text = "Managing Station Incharge Deleted Sucessfully.";
                Label1.ForeColor = System.Drawing.Color.Green;
                BindGridViewData();
            }
            else
            {
                Label1.Text = "Error in Deleting.";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
        }

        public static string osubid { get; set; }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string StName=ddlstnName.SelectedItem.Value;
            //if (Button1.Text == "ADD")
            //{
                if (b.StnInch(txtName.Text))
                {
                    Label3.Visible = true;
                    Label3.Text = "Name Exist.";
                }
            //}
            else
            {
                Label3.Visible = false;
                if (Button1.Text == "ADD")
                {
                    if (b.AddMngStnIncharge(txtName.Text, txtContactNo.Text, txtAddress.Text, txteMail.Text, txtPassword.Text, StName))
                    {
                        BindGridViewData();
                        reset();
                        Label1.Text = "Managing Station Incharge Added Sucessfully.";
                        Label1.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        reset();
                        Label1.Text = "Error in Adding.";
                        Label1.ForeColor = System.Drawing.Color.Red;
                    }
                }
                //else
                //    if (b.UpdateMngStnIncharge(osubid, txtContactNo.Text, txtAddress.Text, txteMail.Text, txtPassword.Text, StName))
                //    {
                //        BindGridViewData();
                //        reset();
                //        Label1.Text = "Managing Station Incharge Updated Sucessfully.";
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
        }

        void reset()
        {
            txtName.Text = "";
            txtContactNo.Text = "";
            txtAddress.Text = "";
            txteMail.Text = "";
            txtPassword.Text = "";
            ddlstnName.SelectedIndex = -1;
            //ddlCity.SelectedIndex = -1;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string StName = ddlstnName.SelectedItem.Value;
            if (b.UpdateMngStnIncharge(osubid, txtContactNo.Text, txtAddress.Text, txteMail.Text, txtPassword.Text, StName))
            {
                BindGridViewData();
                reset();
                Label1.Text = "Managing Station Incharge Updated Sucessfully.";
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
            Button1.Visible = true;
            Button2.Visible = false;
            txtName.ReadOnly = false;
        }

        //protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (ddlCity.SelectedIndex != 0)
        //    {
        //        ddlstnName.Visible = true;
        //        GetStnName();
        //    }
        //}
    }
}