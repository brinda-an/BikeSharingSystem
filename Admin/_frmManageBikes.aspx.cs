using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
//using System.Drawing;

namespace BikeSharingSystem.Admin
{
    public partial class _frmManageBikes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label3.Text = "WELCOME " + Session["User"].ToString().ToUpper();
            if (!IsPostBack)
            {
                BindGridViewData();
                GetStname();
                //getCity();
                //ddlStnId.Visible = false;
            }
        }

        BLL b = new BLL();
        //static int bid = 0;

        //private void getCity()
        //{
        //    ddlCity.DataSource = b.GetCity();
        //    ddlCity.DataTextField = "City";
        //    ddlCity.DataValueField = "City_Id";
        //    ddlCity.DataBind();
        //    ListItem li = new ListItem("Select", "-1");
        //    ddlCity.Items.Insert(0, "Select");
        //}

        private void GetStname()
        {
            //int cty = int.Parse(ddlCity.SelectedItem.Value);
            ddlStnId.DataSource = b.GetStnName();
            ddlStnId.DataTextField = "Stn_Name";
            ddlStnId.DataValueField = "Stn_Id";
            ddlStnId.DataBind();
            ListItem lis = new ListItem("Select", "-1");
            ddlStnId.Items.Insert(0, "Select");
        }

        protected void LB_Edit_Click(object sender, EventArgs e)
        {
            GridViewRow row = (GridViewRow)((LinkButton)sender).Parent.Parent;
            bid = int.Parse(((LinkButton)sender).CommandArgument);
            Button1.Text = "Update";
            //osobid = row.Cells[0].Text;
            txtName.Text = row.Cells[1].Text;
            txtModel.Text = row.Cells[2].Text;
            txtCC.Text = row.Cells[3].Text;
            txtAmount.Text = row.Cells[4].Text;
            ListItem lst = new ListItem();
            lst.Text = row.Cells[6].Text;
            int index = ddlStnId.Items.IndexOf(lst);
            ddlStnId.SelectedIndex = index;
            Image imp = (Image)row.Cells[5].FindControl("Image1");
                string pat = imp.ImageUrl;
                //Label2.Text = row.Cells[5].Text;    
                //FileInfo file = new FileInfo(Server.MapPath(pat));
                //try
                //{
                //    file.Delete();
                //    Label1.Text = "File Deleted Sucessfully.";
                //    Label1.ForeColor = System.Drawing.Color.Green;
                //}
                //catch
                //{
                //    Label1.Text = "Error in File Deleting.";
                //    Label1.ForeColor = System.Drawing.Color.Red;
                //}
               
            BindGridViewData();
        }

        protected void LB_Delete_Click(object sender, EventArgs e)
        {
            GridViewRow row = (GridViewRow)((LinkButton)sender).Parent.Parent;
            bid = int.Parse(((LinkButton)sender).CommandArgument);
            if (b.DeleteBike(bid))
            {
                BindGridViewData();
                Label1.Text = "BikeRecord Deleted Sucessfully.";
                Label1.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                Label1.Text = "Error in Deleting.";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void BindGridViewData()
        {
            GridView1.DataSource = b.GetManageBikes5();
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string stId = ddlStnId.SelectedItem.Value;
            HttpPostedFile postedfile = FileUpload1.PostedFile;
            string filename = Path.GetExtension(postedfile.FileName);
            string fileextention = Path.GetExtension(filename);
            int filesize = postedfile.ContentLength;
            if (fileextention.ToLower() == ".jpg" || fileextention.ToLower() == ".bmp" ||
                 fileextention.ToLower() == ".png" || fileextention.ToLower() == ".gif")
            {
                Stream stream = postedfile.InputStream;
                BinaryReader br = new BinaryReader(stream);
                byte[] byt = br.ReadBytes((int)stream.Length);
                string path = "~/Admin/BikeImages/" + FileUpload1.FileName;
                FileUpload1.SaveAs(MapPath(path));
                if (Button1.Text == "ADD")
                {
                    if (b.AddBikes(txtName.Text, path, txtModel.Text, txtCC.Text, txtAmount.Text, stId))
                    {
                        BindGridViewData();
                        reset();
                        Label1.Text = "File Added sucessfully";
                        Label1.ForeColor = System.Drawing.Color.Green;

                    }
                    else
                    {
                        reset();
                        Label1.Text = "Error in updating";
                        Label1.ForeColor = System.Drawing.Color.Red;
                    }
                }
           
            
            else
                if (Button1.Text == "Update")
                {
                    if (b.UpdateBike(txtName.Text, path, txtModel.Text, txtCC.Text, txtAmount.Text, stId, bid))
                    {

                        BindGridViewData();
                        reset();
                        Button1.Text = "ADD";
                        Label1.Text = "Record Bike Updated Sucessfully.";
                        Label1.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        reset();
                        Button1.Text = "ADD";
                        Label1.Text = "Error in Updating.";
                        Label1.ForeColor = System.Drawing.Color.Red;
                    }
                }
            
            }
            else
            {
                Label1.Text = "Only Jpg/bmp/png/gif is Executeed";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            //BindGridViewData();
        }

        void reset()
        {
            txtName.Text = "";
            txtModel.Text = "";
            txtCC.Text = "";
            txtAmount.Text = "";
            ddlStnId.SelectedIndex = -1;
            //ddlCity.SelectedIndex = -1;
        }

        public static int bid { get; set; }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            FileUpload1.Enabled = false;
            RequiredFieldValidator4.Enabled = false;
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            BindGridViewData();
        }

        //protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (ddlCity.SelectedIndex != 0)
        //    {
        //        ddlStnId.Visible = true;
        //        GetStname();
        //    }
        //}
    }
}