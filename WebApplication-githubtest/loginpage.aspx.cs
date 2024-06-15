using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.Odbc;
using System.Data;


namespace WebApplication_githubtest
{
    public partial class loginpage : System.Web.UI.Page
    {
        public OdbcConnection conn;
        public OdbcCommand cmd, cmd1;
        public OdbcDataReader dr, dr1;
        public String connstr, strSql;
        protected void Page_Load(object sender, EventArgs e)
        {
            ////connstr = ConfigurationManager.ConnectionStrings["connDB"].ToString();
            ////conn = new OdbcConnection(connstr);

            lblname.Text = HttpContext.Current.Session["emptitle"].ToString();
            lbldesg.Text = HttpContext.Current.Session["desg"].ToString();


            //connstr = ConfigurationManager.ConnectionStrings["connDB"].ToString();
            //conn = new OdbcConnection(connstr);
            //if (Session["empcode"] == null || HttpContext.Current.Session["empcode"].ToString() == "")
            //{
            //    Response.Redirect("Frm_Login.aspx");
            //}
            //else
            //{
            //    //-------- Session variable --------------------------------------
            //    HttpContext.Current.Session["empcode"] = HttpContext.Current.Session["empcode"];
            //    //HttpContext.Current.Session["deptcd"] = HttpContext.Current.Session["deptcd"];
            //}
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //OdbcConnection con = new OdbcConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True");
            //OdbcCommand cmd = new OdbcCommand("select * from PFLIB.PNMDATA where CCNO=@CCNO and CCNO=@CCNO", conn);
            //cmd.Parameters.AddWithValue("CCNO", TextBox1.Text);
            //cmd.Parameters.AddWithValue("CCNO", TextBox2.Text);
            //OdbcDataAdapter sda = new OdbcDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //conn.Open();
            //int i = cmd.ExecuteNonQuery();
            //conn.Close();
            //if (dt.Rows.Count > 0)
            //{
            //    Session["id"] = TextBox1.Text;
            //    Response.Redirect("Redirectform.aspx");
            //    Session.RemoveAll();
            //}
            //else
            //{
            //    Label1.Text = "You're username and word is incorrect";
            //    Label1.ForeColor = System.Drawing.Color.Red;

            //}
        }
    }
}