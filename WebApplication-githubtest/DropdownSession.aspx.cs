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
    public partial class DropdownSession : System.Web.UI.Page
    {
        public OdbcConnection conn;
        public OdbcCommand cmd, cmd1;
        public OdbcDataReader dr, dr1;
        public String connstr, strSql;
        protected void Page_Load(object sender, EventArgs e)
        {

            connstr = ConfigurationManager.ConnectionStrings["connDB"].ToString();
            conn = new OdbcConnection(connstr);


            OdbcDataAdapter sda = new OdbcDataAdapter("select * from PFLIB.PNMDATA", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Repeater1.DataSource = dt;
            Repeater1.DataBind();

        }
    }
}