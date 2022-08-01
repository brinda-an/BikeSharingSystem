using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace BikeSharingSystem
{
    public class BLL
    {
        SqlCommand cmd = null;
        SqlConnection con = null;

        public BLL()
        {
            con = new SqlConnection("server=LENOVO-PC\\SQLEXPRESS;database=BikeSharing;user=sa;password=unlock");
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
        }

        public bool IsValid(string type, string name, string passw)
        {
            if (type == "Admin")
            {
                string sql = string.Format("select count(*) from tblAdmin where Admin_Id='{0}' and password='{1}'", name, passw);
                SqlDataAdapter adp = new SqlDataAdapter(sql, con);
                DataTable tab = new DataTable();
                adp.Fill(tab);
                return int.Parse(tab.Rows[0][0].ToString()) == 0 ? false : true;
            }
            else
                if (type == "Station Incharge")
                {
                    string sql = string.Format("select count(*) from tblMngStnIncharge where Name='{0}' and Password='{1}'", name, passw);
                    SqlDataAdapter adap = new SqlDataAdapter(sql, con);
                    DataTable tab = new DataTable();
                    adap.Fill(tab);
                    return int.Parse(tab.Rows[0][0].ToString()) == 0 ? false : true;
                }
                else
                {
                    string sql = string.Format("select count(*) from tblCustRegistration where Name='{0}' and Password='{1}'", name, passw);
                    SqlDataAdapter adap = new SqlDataAdapter(sql, con);
                    DataTable tab = new DataTable();
                    adap.Fill(tab);
                    return int.Parse(tab.Rows[0][0].ToString()) == 0 ? false : true;
                }
        }

        public bool AddCity(string city)
        {
            try
            {
                string sql = string.Format("insert into tblCity(City) values('{0}')", city);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable GetCity()
        {
            string sql = string.Format("select * from tblCity");
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;
        }

        public bool UpdateCity(string city, string cid)
        {
            try
            {
                string sql = string.Format("update tblCity set City='{0}' where City_Id='{1}'", cid, city);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCity(int cid)
        {
            try
            {
                string sql = string.Format("delete tblCity where City_Id='{0}'", cid);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable GetStation()
        {
            string sql = string.Format("SELECT tblStnRegister.Stn_Id, tblStnRegister.Stn_Name, tblStnRegister.Address, tblStnRegister.Contact_No, tblCity.City FROM tblCity INNER JOIN tblStnRegister ON tblCity.City_Id = tblStnRegister.City_Id");
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;
        }

        public bool AddStation(string name, string addr, string contNo, string ctname)
        {
            try
            {
                string sql = string.Format("insert into tblStnRegister(Stn_Name,Address,Contact_No,City_Id) values('{0}','{1}','{2}','{3}')", name, addr, contNo, ctname);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateStation(string stid, string addr, string contNo, string city)
        {
            try
            {
                string sql = string.Format("update tblStnRegister set Address='{0}',Contact_No='{1}',City_Id='{2}' where Stn_Id='{3}'", addr, contNo, city,stid);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable GetMngStnIncharge()
        {
            string sql = string.Format("SELECT tblMngStnIncharge.Msi_Id, tblMngStnIncharge.Name, tblMngStnIncharge.Contact_No, tblMngStnIncharge.Address, tblMngStnIncharge.eMail, tblMngStnIncharge.Password, tblStnRegister.Stn_Name FROM tblMngStnIncharge INNER JOIN tblStnRegister ON tblMngStnIncharge.Stn_Id = tblStnRegister.Stn_Id");
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;
        }

        public DataTable GetStnName()
        {
            string sql = string.Format("select Stn_Id,Stn_Name from tblStnRegister");
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;
        }

        public bool DeleteStation(int Stid)
        {
            try
            {
                string sql = string.Format("delete tblStnRegister where Stn_Id='{0}'", Stid);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteMngStnIncharge(int msi)
        {
            try
            {
                string sql = string.Format("delete tblMngStnIncharge where Msi_Id='{0}'", msi);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool AddMngStnIncharge(string name, string contNo, string addr, string email, string passw, string stName)
        {
            try
            {
                string sql = string.Format("insert into tblMngStnIncharge(Name,Contact_No,Address,eMail,Password,Stn_Id) values('{0}','{1}','{2}','{3}','{4}','{5}')", name, contNo, addr, email, passw, stName);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateMngStnIncharge(string msid, string contNo, string addr, string email, string passw, string stName)
        {
            try
            {
                string sql = string.Format("update tblMngStnIncharge set Contact_No='{0}',Address='{1}',eMail='{2}',Password='{3}',Stn_Id='{4}' where Msi_Id='{5}'", contNo, addr, email, passw, stName, msid);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool AddBikes(string name, string path, string model, string cc, string amt,string stid)
        {
            try
            {
                string sql = string.Format("insert into tblManageBike(Bik_Name,Bik_Photo,Bik_Model,Bik_CC,Trip_Amount,Stn_Id) values('{0}','{1}','{2}','{3}','{4}','{5}')", name, path, model, cc, amt,stid);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable GetManageBikes1(int stid)
        {
            string sql=string.Format("select * from tblManageBike where Stn_Id='{0}'",stid);
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;
        }

        public DataTable GetManageBikes()
        {
            string sql = string.Format("select * from tblManageBike");
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;
        }

        public DataTable GetManageBikes5()
        {
            string sql = string.Format("SELECT tblManageBike.Bik_Id, tblManageBike.Bik_Name, tblManageBike.Bik_Photo, tblManageBike.Bik_Model, tblManageBike.Bik_CC, tblManageBike.Trip_Amount, tblStnRegister.Stn_Name FROM tblManageBike INNER JOIN tblStnRegister ON tblManageBike.Stn_Id = tblStnRegister.Stn_Id");
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;
        }

        public bool DeleteBike(int bid)
        {
            try
            {
                string sql = string.Format("delete tblManageBike where Bik_Id='{0}'", bid);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateBike(string name, string path, string model, string cc, string amt, string stid, int osb)
        {
            try
            {
                string sql = string.Format("update tblManageBike set Bik_Name='{0}',Bik_Photo='{1}',Bik_Model='{2}',Bik_CC='{3}',Trip_Amount='{4}',Stn_Id='{5}' where BIk_Id='{6}'", name, path, model, cc, amt, stid, osb);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool AddCustomers(string name, string gen, string addr, string cont, string email, string dl, string pass, string path)
        {
            try
            {
                string sql = string.Format("insert into tblCustRegistration(Name,Gender,Address,Contact_No,eMail,DL_Number,Password,Photo) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", name, gen, addr, cont, email, dl, pass, path);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch(SqlException)
            {
                return false;
            }
        }

        public DataTable GetCustomerDetails()
        {
            string sql = string.Format("select * from tblCustRegistration");
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;
        }

        public DataTable GetCustomerDetails1(string adrs)
        {
            string sql = string.Format("select * from tblCustRegistration where Address='{0}'",adrs);
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;
        }

        public DataTable getAdrs()
        {
            string sql = string.Format("select distinct Address from tblCustRegistration");
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;
        }

        public DataTable GetBikeModel(string sid)
        {
            string sql = string.Format("select distinct Bik_Model from tblManageBike where Stn_Id='{0}'",sid);
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;
        }

        public DataTable GetBikeName(string Mod)
        {
            string sql = string.Format("select Bik_Name from tblManageBike where Bik_Model='{0}'", Mod);
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;
        }

        public DataTable GetBikeCC(string mod, string name)
        {
            string sql = string.Format("select Bik_CC from tblManageBike where Bik_Model='{0}',Bik_Name='{1}'", mod, name);
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;
        }

        public DataTable GetBikeNamImgCc(string mod,string sid)
        {
            string sql = string.Format("select Bik_Id,Bik_Name,Bik_Photo,Trip_Amount,Bik_Model,Stn_Id from tblManageBike where Bik_Id not in (select Bik_Id from tblStnIncharge where Status='Accept' or Status='Running') and tblManageBike.Bik_Model='{0}' and tblManageBike.Stn_Id='{1}'", mod, sid);
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;
        }

        public int GetCustId(string usr)
        {
            string sql = string.Format("select Cus_Id from tblCustRegistration where Name='{0}'", usr);
            //SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            //DataTable tab = new DataTable();
            //adp.Fill(tab);
            cmd.CommandText = sql;
            //cmd.ExecuteNonQuery();
            //int  n = (int)cmd.Parameters["@RETURN_VALUE"].Value;
            int n = int.Parse(cmd.ExecuteScalar().ToString());
            return (n);
        }

        public bool AddBooking(int bid, int cid,string dt,int stid)
        {
            try
            {
                string sql = string.Format("insert into tblBooking(Bik_Id,Cus_Id,Date,Stan_Id) values('{0}','{1}','{2}','{3}')", bid, cid, dt,stid);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

       public bool AddBooking1(string bid, int cid,string dt,int stid)
        {
            try
            {
                string sql = string.Format("insert into tblStnIncharge(Bik_Id,Cus_Id,Date,Stn_Id,Status) values('{0}','{1}','{2}','{3}','Accept')", bid, cid, dt, stid);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable GetStName1(int id)
        {
            string sql = string.Format("select Stn_Name,Stn_Id from tblStnRegister where City_Id='{0}'",id);
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;
        }

        public DataTable GetStName()
        {
            string sql = string.Format("select Stn_Name,Stn_Id from tblStnRegister");
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;
        }

        public DataTable GetStName1(string id)
        {
            string sql = string.Format("select Stn_Name,Stn_Id from tblStnRegister where City_Id='{0}'",int.Parse(id));
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;
        }

        public DataTable GetBooking(int stid)
        {
            string sql = string.Format("select * from tblBooking where Stan_Id='{0}'",stid);
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;
        }

        public bool ManageBooking_Approve(string id)
        {
            try
            {
                string sql = string.Format("update tblBooking set Status='Approved' where Book_Id='{0}'", id);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool InchargeBooking(string tm,string dt,int bid, int cid, string st,int sid,int si)
        {
            try
            {
                string sql = string.Format("insert into tblStnIncharge(Departure,Date,Bik_Id,Cus_Id,Status,Msi_Id,Stn_Id) values('{0}','{1}',{2},{3},'{4}',{5},{6})", tm, dt, bid, cid, st, sid, si);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int GetIncId(string psw)
        {
            string sql = string.Format("select Msi_Id from tblMngStnIncharge where Password='{0}'", psw);
            cmd.CommandText = sql;
            int n = int.Parse(cmd.ExecuteScalar().ToString());
            return (n);
        }

        public int GetIncId1(string usr)
        {
            string sql = string.Format("select Stn_Id from tblMngStnIncharge where Name='{0}'", usr);
            cmd.CommandText = sql;
            int n = int.Parse(cmd.ExecuteScalar().ToString());
            return (n);
        }

        public int GetStId(int id)
        {
            string sql = string.Format("select Stn_Id from tblManageBike where Bik_Id='{0}'", id);
            cmd.CommandText = sql;
            int n = int.Parse(cmd.ExecuteScalar().ToString());
            return (n);
        }

        public DataTable GetStInBook(int stid)
        {
            string sql = string.Format("SELECT tblStnIncharge.StnInc_Id, tblStnIncharge.Departure, tblStnIncharge.Arrival, tblStnIncharge.Date, tblStnIncharge.Status, tblCustRegistration.Photo, tblManageBike.Bik_Id, tblManageBike.Bik_Name, tblStnIncharge.Msi_Id, tblStnIncharge.Stn_Id FROM tblStnIncharge INNER JOIN tblCustRegistration ON tblStnIncharge.Cus_Id = tblCustRegistration.Cus_Id INNER JOIN tblManageBike ON tblStnIncharge.Bik_Id = tblManageBike.Bik_Id where tblStnIncharge.Stn_Id='{0}'",stid);
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;
        }

        public bool InchargeBookSt(string ar, string st, int cid, int bid)
        {
            try
            {
                string sql = string.Format("update tblStnIncharge set Arrival='{0}',Status='{1}',Stn_Id='{2}' where Bik_Id='{3}'", ar, st, cid, bid);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int Get_UserId(string nam)
        {
            string sql = string.Format("select Cus_Id from tblCustRegistration where Name='{0}'", nam);
            cmd.CommandText = sql;
            int n = int.Parse(cmd.ExecuteScalar().ToString());
            return (n);
        }

        public DataTable View_FeedBack(int cid)
        {
            string sql = string.Format("select * from tblFeedbak where Cus_Id='{0}'", cid);
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;
        }

        public int GetBid(int cid)
        {
            string sql = string.Format("select Bik_Id from tblBooking where Cus_Id='{0}'", cid);
            cmd.CommandText = sql;
            int n = int.Parse(cmd.ExecuteScalar().ToString());
            return (n);
        }

        public bool Post_Feedback(string tx, DateTime dt, int cid)
        {
            try
            {
                string sql = string.Format("insert into tblFeedbak(FeedBak,Date,Cus_Id) values('{0}','{1}','{2}')", tx, dt, cid);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable GetFeedBack()
        {
            string sql = string.Format("SELECT tblFeedbak.FeedBak, tblFeedbak.Date, tblCustRegistration.Name FROM tblFeedbak INNER JOIN tblCustRegistration ON tblFeedbak.Cus_Id = tblCustRegistration.Cus_Id");
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;
        }

        public DataTable GetCustBookedDetails(int cid)
        {
            string sql = string.Format("SELECT tblCity.City, tblStnRegister.Stn_Name, tblManageBike.Bik_Name, tblStnIncharge.Date FROM tblStnIncharge INNER JOIN tblManageBike ON tblStnIncharge.Bik_Id = tblManageBike.Bik_Id INNER JOIN tblStnRegister ON tblManageBike.Stn_Id = tblStnRegister.Stn_Id INNER JOIN tblCity ON tblStnRegister.City_Id = tblCity.City_Id where tblStnIncharge.Cus_Id='{0}' and tblStnIncharge.Status='Received'", cid);
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;
        }

        //public DataTable GetBookDetails(int stid)
        //{
        //    string sql = string.Format("select * from tblBooking where Stan_Id='{0}'",stid);
        //    SqlDataAdapter adp = new SqlDataAdapter(sql, con);
        //    DataTable tab = new DataTable();
        //    adp.Fill(tab);
        //    return tab;
        //}

        public DataTable GetBookDetails(int stid)
        {
            string sql = string.Format("SELECT tblCustRegistration.Name, tblManageBike.Bik_Name, tblStnIncharge.Date, tblStnIncharge.Status, tblManageBike.Bik_Photo FROM tblStnIncharge INNER JOIN tblCustRegistration ON tblStnIncharge.Cus_Id = tblCustRegistration.Cus_Id INNER JOIN tblManageBike ON tblStnIncharge.Bik_Id = tblManageBike.Bik_Id where tblStnIncharge.Stn_Id='{0}' and (tblStnIncharge.Status='Accept' or tblStnIncharge.Status='Running')", stid);
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;
        }

        public int GetStnId(string name)
        {
            string sql = string.Format("select Stn_Id from tblMngStnIncharge where Name='{0}'", name);
            cmd.CommandText = sql;
            int n = int.Parse(cmd.ExecuteScalar().ToString());
            return (n);
        }

        public bool bookUpdate(string dt,string sts,int tbId)
        {
            try
            {
                string sql = string.Format("update tblStnIncharge set Departure='{0}',Status='{1}' where StnInc_Id='{2}'", dt,sts,tbId);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable getData(int id)
        {
            string sql = string.Format("select Bik_Id,Bik_Model,Bik_Name,Bik_Photo from tblManageBike where Bik_Id not in (select Bik_Id from tblStnIncharge where Status='Accept' or Status='Running') and tblManageBike.Stn_Id='{0}'",id);
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;
        }

        public DataTable getStnProfile(string usr)
        {
            string sql = string.Format("select Name,Contact_No,Address,eMail from tblMngStnIncharge where Name='{0}'", usr);
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;
        }

        public bool updateStnProfile(string nam,string ct,string adr,string em,string usr)
        {
            try
            {
                string sql = string.Format("update tblMngStnIncharge set Name='{0}',Contact_No='{1}',Address='{2}',eMail='{3}' where Name='{4}'", nam,ct,adr,em,usr);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int getOldPswd_Stn(string usr)
        {
            string sql = string.Format("select Password from tblMngStnIncharge where Name='{0}'", usr);
            cmd.CommandText = sql;
            int n = int.Parse(cmd.ExecuteScalar().ToString());
            return (n);
        }

        public bool updatePsw_Stn(string psw, string usr)
        {
            try
            {
                string sql = string.Format("update tblMngStnIncharge set Password='{0}' where Name='{1}'", psw,usr);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable getCustomerProfile(string usr)
        {
            string sql = string.Format("select Name,Address,Contact_No,eMail from tblCustRegistration where Name='{0}'", usr);
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;
        }

        public bool updateProfile_Customer(string nm, string adr, string cnt, string em,string usr)
        {
            try
            {
                string sql = string.Format("update tblCustRegistration set Name='{0}',Address='{1}',Contact_No='{2}',eMail='{3}' where Name='{4}'", nm, adr, cnt, em, usr);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int getOldPswd_Cust(string usr)
        {
            string sql = string.Format("select Password from tblCustRegistration where Name='{0}'", usr);
            cmd.CommandText = sql;
            int n = int.Parse(cmd.ExecuteScalar().ToString());
            return (n);
        }

        public bool updatePsw_Cust(string psw, string usr)
        {
            try
            {
                string sql = string.Format("update tblCustRegistration set Password='{0}' where Name='{1}'", psw, usr);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string get_Pick(string usr)
        {
            string sql = string.Format("select Photo from tblCustRegistration where Name='{0}'", usr);
            cmd.CommandText = sql;
            string n = cmd.ExecuteScalar().ToString();
            return (n);
        }

        public DataTable getList(int id)
        {
            string sql = string.Format("select * from tblManageBike where Stn_Id='{0}'", id);
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;
        }

        public bool bkCheck(int id)
        {
            string sql = string.Format("SELECT count(*) FROM tblStnIncharge WHERE StnInc_Id='{0}' and Departure LIKE '%[^0-9]%'", id);
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            DataTable tab = new DataTable();
            adap.Fill(tab);
            return int.Parse(tab.Rows[0][0].ToString()) == 0 ? false : true;
        }

        public bool bkRecived(int id)
        {
            string sql = string.Format("SELECT count(*) FROM tblStnIncharge WHERE StnInc_Id='{0}' and Arrival LIKE '%[^0-9]%'", id);
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            DataTable tab = new DataTable();
            adap.Fill(tab);
            return int.Parse(tab.Rows[0][0].ToString()) == 0 ? false : true;
        }

        public bool checkCity(string cty)
        {
            string sql = string.Format("SELECT count(*) FROM tblCity WHERE City='{0}'", cty);
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            DataTable tab = new DataTable();
            adap.Fill(tab);
            return int.Parse(tab.Rows[0][0].ToString()) == 0 ? false : true;
        }

        public bool checkStnName(string name)
        {
            string sql = string.Format("SELECT count(*) FROM tblStnRegister WHERE Stn_Name='{0}'", name);
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            DataTable tab = new DataTable();
            adap.Fill(tab);
            return int.Parse(tab.Rows[0][0].ToString()) == 0 ? false : true;
        }

        public bool checkUsrName(string name)
        {
            string sql = string.Format("SELECT count(*) FROM tblCustRegistration WHERE Name='{0}'", name);
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            DataTable tab = new DataTable();
            adap.Fill(tab);
            return int.Parse(tab.Rows[0][0].ToString()) == 0 ? false : true;
        }

        public DataTable GetStnName1(int id)
        {
            string sql = string.Format("select Stn_Name,Stn_Id from tblStnRegister where City_Id='{0}'", id);
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;
        }

        public bool StnInch(string name)
        {
            string sql = string.Format("SELECT count(*) FROM tblMngStnIncharge WHERE Name='{0}'", name);
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            DataTable tab = new DataTable();
            adap.Fill(tab);
            return int.Parse(tab.Rows[0][0].ToString()) == 0 ? false : true;
        }

        public bool checkFeebback(int name)
        {
            string sql = string.Format("select count(*) from tblFeedbak where Cus_Id='{0}'", name);
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            DataTable tab = new DataTable();
            adap.Fill(tab);
            return int.Parse(tab.Rows[0][0].ToString()) == 0 ? false : true;
        }

        public string getusrEm(string usr)
        {
            string sql = string.Format("select eMail from tblCustRegistration where Name='{0}'", usr);
            cmd.CommandText = sql;
            string n = cmd.ExecuteScalar().ToString();
            return (n);
        }

        public bool checkRunning(int id)
        {
            string sql = string.Format("select count(*) from tblStnIncharge where StnInc_Id='{0}' and Status='Running'", id);
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            DataTable tab = new DataTable();
            adap.Fill(tab);
            return int.Parse(tab.Rows[0][0].ToString()) == 0 ? false : true;
        }

        public string getPassword1(string usr, string dl)
        {
            try
            {
                string sql = string.Format("select Password from tblCustRegistration where Name='{0}' and DL_Number='{1}'", usr, dl);
                cmd.CommandText = sql;
                string n = cmd.ExecuteScalar().ToString();
                return (n);
            }
            catch(Exception e)
            {
                return "Error Name/DL.";
            }
        }

        public bool MngUpdateBike(int stid,int bkid)
        {
            try
            {
                string sql = string.Format("update tblManageBike set Stn_Id='{0}' where Bik_Id='{1}'", stid, bkid);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int getcityId(int stid)
        {
            string sql = string.Format("select City_Id from tblStnRegister where Stn_Id='{0}'", stid);
            cmd.CommandText = sql;
            int n = int.Parse(cmd.ExecuteScalar().ToString());
            return (n);
        }

        public DataTable getcityDet(int ctid)
        {
            string sql = string.Format("select City,City_Id from tblCity where City_Id='{0}'", ctid);
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;
        }
    }
}