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
    public partial class SingleSession : System.Web.UI.Page
    {
        public OdbcConnection conn;
        public OdbcCommand cmd, cmd1;
        public OdbcDataReader dr, dr1;
        public String connstr, strSql;
        protected void Page_Load(object sender, EventArgs e)
        {

            connstr = ConfigurationManager.ConnectionStrings["connDB"].ToString();
            conn = new OdbcConnection(connstr);

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
        }



        #region " [ Private Function ] "  
        private DataTable checkUserLogin(string userSession, string mode)
        {
            DataSet dsData = new DataSet();
            OdbcConnection sqlCon = null;
            OdbcDataAdapter sqlCmd = null;

            try
            {
                using (sqlCon = new OdbcConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString))
                {
                    sqlCmd = new OdbcDataAdapter("PFLIB.PNMDATA", sqlCon);
                    sqlCmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqlCmd.SelectCommand.Parameters.AddWithValue("@CCNO", txtLogin.Text.Trim());
                    sqlCmd.SelectCommand.Parameters.AddWithValue("@PPONO", txtPassword.Text.Trim());
                    sqlCmd.SelectCommand.Parameters.AddWithValue("@sessionID", userSession);
                    sqlCmd.SelectCommand.Parameters.AddWithValue("@mode", mode);

                    sqlCon.Open();
                    sqlCmd.Fill(dsData);
                    sqlCon.Close();
                }
            }
            catch
            {
                throw;
            }
            return dsData.Tables[0];
        }

    }
    #endregion
}