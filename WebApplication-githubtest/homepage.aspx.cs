using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

using System.Drawing;
using System.Data.Odbc;

namespace WebApplication_githubtest
{
    public partial class homepage : System.Web.UI.Page
    {
        public OdbcConnection conn;
        public OdbcCommand cmd, cmd1;
        public OdbcDataReader dr, dr1;
             

        public String connstr, strSql;
        protected void Page_Load(object sender, EventArgs e)
        {
            ////Label1.Text = Session["id"].ToString();

            connstr = ConfigurationManager.ConnectionStrings["connDB"].ToString();
            conn = new OdbcConnection(connstr);

            try
            {
                Session.LCID = 2057;
                //-------- Connection string-------------------------------------

                connstr = ConfigurationManager.ConnectionStrings["connDB"].ToString();
                conn = new OdbcConnection(connstr);

                HttpContext.Current.Session["empcode"] = "";
                HttpContext.Current.Session["deptcd"] = "";

            }
            catch (Exception ex)
            {
                lblErrMessage.Text = ex.Message.ToString();
            }

        }


        protected void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                HttpContext.Current.Session["empcode"] = txt_username.Text.Trim();
                //HttpContext.Current.Session["deptcd"] = "";
                if (txt_username.Text.Trim() == "")
                {
                    lblErrMessage.Text = "Please eneter user name and password.";
                    return;
                }
                ////else if (string.IsNullOrEmpty(cmdOrg.Text) || cmdOrg.Text.Trim() == "")
                ////{
                ////    lblErrMessage.Text = "Please select Organisation";
                ////     return;
                ////}
                //else
                //{

                strSql = "select A.USERID,B.DEPTCODE,B.EMPTITLE,B.DESGSHDESC from patoolslib.logpatient a inner join EMPLIB.EMPDTLSLF B ON A.USERID = B.EMPCODE where a.userid=? "; ////and a.USERPWD=?
                cmd = new OdbcCommand(strSql, conn);
                cmd.Parameters.AddWithValue("userid", txt_username.Text.Trim());
                ////cmd.Parameters.AddWithValue("USERPWD", txt_password.Text.Trim());

                conn.Open();
                dr = cmd.ExecuteReader();
                if (dr != null)
                {
                    if (dr.HasRows == true)
                    {
                        while (dr.Read())
                        {
                            //---- department select --------------------------------
                            HttpContext.Current.Session["empcode"] = dr.GetValue(0).ToString().Trim();
                            HttpContext.Current.Session["deptcd"] = dr.GetValue(1).ToString().Trim();
                            HttpContext.Current.Session["emptitle"] = dr.GetValue(2).ToString().Trim();
                            HttpContext.Current.Session["desg"] = dr.GetValue(3).ToString().Trim();

                            //if (dr.GetValue(2).ToString().Trim() == "PE")
                            //{

                            Response.Redirect("loginpage.aspx");
                            //}
                            //else
                            //{
                            //    lblErrMessage.Text = "Not Authorized...!!";
                            //}
                            //Response.Redirect("Frm_ReqAppraval.aspx");
                            //strSql = "select *  from pptoolslib.NRCLOGIN where userid='" + txt_username.Text.Trim() + "'";
                            //cmd = new OdbcCommand(strSql, conn);
                            //dr = cmd.ExecuteReader();
                            //if (dr.HasRows == true)
                            //{
                            //    Response.Redirect("Frm_ReqAppraval.aspx");
                            //}
                            //else
                            //{
                            //        Response.Redirect("Frm_UserReq.aspx");                         
                            //}


                        }
                    }
                    else
                    {
                        lblErrMessage.Text = "Wrong User ID / Password.";
                        return;
                    }

                }
                dr.Close();
                conn.Close();
                //}

                //files = System.IO.Directory.GetFiles(Server.MapPath("Attachment/"), "*.pdf");

                //foreach (string file in files)
                //{
                //    System.IO.File.Delete(file);
                //}

                //Response.Redirect("Frm_TendMast.aspx");


            }
            catch (Exception ex)
            {
                lblErrMessage.Text = ex.Message.ToString();
            }
            finally
            {

            }
        }




        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    ////Session.RemoveAll();
        //    ////Response.Redirect("Default.aspx");
        //}
    }
}
