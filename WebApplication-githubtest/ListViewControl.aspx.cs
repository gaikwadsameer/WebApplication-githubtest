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
    public partial class ListViewControl : System.Web.UI.Page
    {
        public OdbcConnection conn;
        public OdbcCommand cmd, cmd1;
        public OdbcDataReader dr, dr1;
        public String connstr, strSql;

        protected void Page_Load(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["connDB"].ConnectionString;

            OdbcConnection con = new OdbcConnection(constr);
            OdbcCommand cmd = new OdbcCommand("select DESCRIPTON from payrolllib.prmitsectn", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            OdbcDataAdapter sda = new OdbcDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();

        }



        //using (OdbcConnection con = new OdbcConnection(constr))

        //{
        //    using (OdbcCommand cmd = new OdbcCommand("select SUBSECTION,DESCRIPTON from payrolllib.prmitsectn where itsection='80-C' and subsection not in('MFUND','PPF','NSC','RTF','80CCF','LIC','HBA')"))
        //    {
        //        cmd.CommandType = CommandType.Text;
        //        cmd.Connection = con;
        //        con.Open();
        //        DropDownList1.DataSource = cmd.ExecuteReader();
        //        ////DropDownList1.DataTextField = "DESCRIPTON";
        //        DropDownList1.DataValueField = "DESCRIPTON";
        //        DropDownList1.DataBind();
        //        con.Close();

        //        if (!IsPostBack)
        //            display();
        //    }

        //}
    }

        //private void display()
        //{
        //    dataTable = new DataTable();
        //    cmd.Connection = conn;
        //    cmd.CommandText = "select DESCRIPTON from payrolllib.prmitsectn";
        //    sda = new OdbcDataAdapter(cmd);
        //    sda.Fill(dataTable);
        //    GridView1.DataSource = dataTable;
        //    GridView1.DataBind();
        //}
    }
    
