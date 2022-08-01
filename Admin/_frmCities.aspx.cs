using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BikeSharingSystem.Admin
{
    public partial class _frmCities : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label3.Text = "WELCOME " + Session["User"].ToString().ToUpper();
            if (!IsPostBack)
            {
                BindGridViewData();
                Button2.Visible = false;
            }
        }

        BLL b = new BLL();
        static int cid = 0;

        private void BindGridViewData()
        {
            GridView1.DataSource=b.GetCity();
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (b.checkCity(txtCity.Text))
            {
                Label2.Visible = true;
                Label2.Text = "City Exist.";
            }
            else
            {
                Label2.Visible = false;
                if (Button1.Text == "ADD")
                {
                    if (b.AddCity(txtCity.Text))
                    {
                        BindGridViewData();
                        txtCity.Text = "";
                        Label1.Text = "City Added Sucessfully.";
                        Label1.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        txtCity.Text = "";
                        Label1.Text = "Error in Adding City.";
                        Label1.ForeColor = System.Drawing.Color.Red;
                    }
                }
                //else
                //{
                //    if (b.UpdateCity(osubid, txtCity.Text))
                //    {
                //        BindGridViewData();
                //        txtCity.Text = "";
                //        Label1.Text = "City Updated Sucessfully.";
                //        Label1.ForeColor = System.Drawing.Color.Green;
                //        Button1.Text = "ADD";
                //    }
                //    else
                //    {
                //        txtCity.Text = "";
                //        Label1.Text = "Error in Updating.";
                //        Label1.ForeColor = System.Drawing.Color.Red;
                //        Button1.Text = "ADD";
                //    }
                //}
            }
        }

        protected void LB_Edit_Click(object sender, EventArgs e)
        {
            GridViewRow row = (GridViewRow)((LinkButton)sender).Parent.Parent;
            cid=int.Parse(((LinkButton)sender).CommandArgument);
            //Button1.Text = "Update";
            Button2.Visible = true;
            Button1.Visible = false;
            osubid = row.Cells[0].Text;
            txtCity.Text = row.Cells[1].Text;
        }

        protected void LB_Delete_Click(object sender, EventArgs e)
        {
            GridViewRow row = (GridViewRow)((LinkButton)sender).Parent.Parent;
            cid = int.Parse(((LinkButton)sender).CommandArgument);
            if (b.DeleteCity(cid))
            {
                Label1.Text = "City Deleted Sucessfully.";
                BindGridViewData();
            }
            else
            {
                Label1.Text = "Error in Deleting.";
            }
         }

        public static string osubid { get; set; }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            //GridView1.DataBind();
            BindGridViewData();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (b.UpdateCity(osubid, txtCity.Text))
            {
                BindGridViewData();
                txtCity.Text = "";
                Label1.Text = "City Updated Sucessfully.";
                Label1.ForeColor = System.Drawing.Color.Green;
                Button1.Text = "ADD";
            }
            else
            {
                txtCity.Text = "";
                Label1.Text = "Error in Updating.";
                Label1.ForeColor = System.Drawing.Color.Red;
                Button1.Text = "ADD";
            }
            Button2.Visible = false;
            Button1.Visible = true;
            Label2.Visible = false;
        }
    }
}