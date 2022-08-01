using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BikeSharingSystem.StationInchargers
{
    public partial class _frmManageBikes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //ViewGridView();
                getcity();
                //getStation();
                ViewGridView2();
                Label4.Text ="WECOME "+ Session["User"].ToString().ToUpper();
                Label4.ForeColor = System.Drawing.Color.Brown;
                ddlStation.Enabled = false;
            }
        }

        BLL b = new BLL();

        private void getcity()
        {
            string name = Session["User"].ToString();
            int StId = b.GetStnId(name);
            int ctid = b.getcityId(StId);
            ddlCity.DataSource = b.getcityDet(ctid);
            ddlCity.DataTextField = "City";
            ddlCity.DataValueField = "City_Id";
            ddlCity.DataBind();
            ListItem li = new ListItem("Select","-1");
            ddlCity.Items.Insert(0,"Select");
        }

        private void getStation()
        {
            int ctyid = int.Parse(ddlCity.SelectedItem.Value);
            ddlStation.DataSource = b.GetStName1(ctyid);
            ddlStation.DataTextField = "Stn_Name";
            ddlStation.DataValueField = "Stn_Id";
            ddlStation.DataBind();
            ListItem li = new ListItem("Select","-1");
            ddlStation.Items.Insert(0,"Select");
        }

        //private void ViewGridView()
        //{
        //    string name = Session["User"].ToString();
        //    string psw = Session["Pswd"].ToString();
        //    int StId = b.GetStnId(name, psw);
        //    GridView1.DataSource = b.GetBooking(StId);
        //    GridView1.DataBind();
        //}

        private void ViewGridView2()
        {
            string name = Session["User"].ToString();
            //string psw = Session["Pswd"].ToString();
            int StId = b.GetStnId(name);
            GridView2.DataSource = b.GetStInBook(StId);
            GridView2.DataBind();
        }

        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    for (int i = 0; i < GridView1.Rows.Count; i++)
        //    {
        //        CheckBox chkUpdate = (CheckBox)GridView1.Rows[i].Cells[0].FindControl("CheckBox1");
        //        if (chkUpdate.Checked)
        //        {
        //            string Tm=DateTime.Now.ToString();
        //            Label lbi = (Label)GridView1.Rows[i].Cells[1].FindControl("Label1");
        //            int BkId = int.Parse(lbi.Text);
        //            Label lbi1 = (Label)GridView1.Rows[i].Cells[2].FindControl("Label2");
        //            int BId = int.Parse(lbi1.Text);
        //            Label lbi2 = (Label)GridView1.Rows[i].Cells[3].FindControl("Label3");
        //            int CId = int.Parse(lbi2.Text);
        //            Label lbi3 = (Label)GridView1.Rows[i].Cells[4].FindControl("Label4");
        //            string dt = lbi3.Text;
        //            string sta = "Running";
        //            string psw = Session["Pswd"].ToString();
        //            int cstId = b.GetIncId(psw);
        //            int stId = b.GetStId(BId);
        //            if (b.InchargeBooking(Tm, dt, BId, CId, sta, cstId, stId))
        //            {
        //                Label1.Text = "Added Sucessfully.";
        //                Label1.ForeColor = System.Drawing.Color.Green;
        //            }
        //            else
        //            {
        //                Label1.Text = "Error in Adding.";
        //                Label1.ForeColor = System.Drawing.Color.Red;
        //            }
        //            //string BkID = chkUpdate.Text;
                    
        //            //if (b.ManageBooking_Approve(BkID))
        //            //{
        //            //    Label1.Text = "Approved successfully";

        //            //}
        //            //else
        //            //{
        //            //    Label1.Text = "ERROR";
        //            //}
        //            //ViewGridView();
        //        }
        //     }
        //    ViewGridView2();
        //}

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            GridViewRow row = (GridViewRow)((CheckBox)sender).Parent.Parent;
            CheckBox chkUpdate = (CheckBox)row.FindControl("CheckBox1");
            if (chkUpdate.Checked)
            {
                chkUpdate.Checked = true;
            }
            else
                chkUpdate.Checked = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GridView2.Rows.Count; i++)
            {
                CheckBox chkUpdate = (CheckBox)GridView2.Rows[i].Cells[0].FindControl("CheckBox3");
                if (chkUpdate.Checked)
                {
                    string depT = DateTime.Now.ToString();
                    string usr = Session["User"].ToString();
                    int cstId = b.GetIncId1(usr);
                    Label lbi = (Label)GridView2.Rows[i].Cells[1].FindControl("Label2");
                    int stnId = int.Parse(lbi.Text);
                    string sts="Running";
                    if (b.bkCheck(stnId) == false)
                    {
                        if (b.bookUpdate(depT, sts, stnId))
                        {
                            Label1.Text = "Added Sucessfully.";
                            Label1.ForeColor = System.Drawing.Color.Green;
                        }
                        else
                        {
                            Label1.Text = "Error in Adding.";
                            Label1.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                    else
                    {
                        Label1.Text = "Already Booked..";
                    }
                }
            }
            ViewGridView2();
        }

        protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            GridViewRow row = (GridViewRow)((CheckBox)sender).Parent.Parent;
            CheckBox chkUpdates = (CheckBox)row.FindControl("CheckBox3");
            if (chkUpdates.Checked)
            {
                chkUpdates.Checked = true;
            }
            else
                chkUpdates.Checked = false;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GridView2.Rows.Count; i++)
            {
                CheckBox chkUpdates = (CheckBox)GridView2.Rows[i].Cells[0].FindControl("CheckBox3");
                if (chkUpdates.Checked)
                {
                    string Tm1 = DateTime.Now.ToString();
                    string stat = "Received";
                    string usr = Session["User"].ToString();
                    int cstId = b.GetIncId1(usr);
                    Label lbi = (Label)GridView2.Rows[i].Cells[5].FindControl("Label1");
                    int BkId = int.Parse(lbi.Text);
                    Label lbi1 = (Label)GridView2.Rows[i].Cells[1].FindControl("Label2");
                    int stnId = int.Parse(lbi1.Text);
                    if (b.bkRecived(stnId) == false)
                    {
                        if (b.checkRunning(stnId))
                        {
                            if (b.InchargeBookSt(Tm1, stat, cstId, BkId))
                            {
                                if (b.MngUpdateBike(cstId, BkId))
                                {
                                    Label5.Text = "Bike Updated.";
                                    Label5.ForeColor = System.Drawing.Color.Green;
                                }
                                Label1.Text = "Vehicle Recived.";
                                Label1.ForeColor = System.Drawing.Color.Green;
                            }
                            else
                            {
                                Label1.Text = "Error in Reciving.";
                                Label1.ForeColor = System.Drawing.Color.Red;
                            }
                        }
                        else
                        {
                            Label1.Text = "Check Vehicle is not Running..";
                        }
                    }
                    else
                    {
                        Label1.Text = "Already Recived..";
                    }
                }
            }
            ViewGridView2();
        }

        protected void ddlStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlStation.SelectedIndex != 0)
            {
                int id = int.Parse(ddlStation.SelectedItem.Value);
                GridView2.DataSource = b.GetStInBook(id);
                GridView2.DataBind();
            }
        }

        private void ViewGV()
        {
            if (ddlStation.SelectedIndex != 0)
            {
                int stId = int.Parse(ddlStation.SelectedItem.Value);
                GridView2.DataSource = b.GetStInBook(stId);
                GridView2.DataBind();
            }
        }

        protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCity.SelectedIndex != 0)
            {
                ddlStation.Enabled = true;
                getStation();
            }
        }
    }
}