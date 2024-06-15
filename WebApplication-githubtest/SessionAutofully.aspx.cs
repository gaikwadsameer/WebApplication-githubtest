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
    public partial class SessionAutofully : System.Web.UI.Page
    {
        public OdbcConnection conn;
        public OdbcCommand cmd, cmd1;
        public OdbcDataReader dr, dr1;
        public String connstr, strSql;
        protected void Page_Load(object sender, EventArgs e)
        {

            connstr = ConfigurationManager.ConnectionStrings["connDB"].ToString();
            conn = new OdbcConnection(connstr);

            try
            {
                //using (OdbcConnection con = new OdbcConnection("Data Source=USER-PC;Initial Catalog=1GCAttendanceManagementSystem;Integrated Security=True"))
                {
                    DataTable dt = new DataTable();
                    conn.Open();
                    OdbcDataReader myReader = null;
                    using (OdbcCommand myCommand = new OdbcCommand("select * from Employee where EmpUsername='" + Session["id"] + "'", conn) { CommandType = CommandType.Text })
                    {
                        myReader = myCommand.ExecuteReader();
                        if (!myReader.HasRows)
                        {
                            // Do something if the reader doesn't have data. This could be an exception 
                            // or other indication to the user that something unexpected happened.
                        }
                        while (myReader.Read())
                        {
                            // The exception handler will trigger if the expected fields don't exist 
                            // in the returned row
                            txtCode.Text = (myReader["EmployeeId"].ToString());
                            //txtUsername.Text = (myReader["EmpUsername"].ToString());
                            //txtPass.Text = (myReader["EmpPassword"].ToString());
                            //txtEmail.Text = (myReader["EmpEmail"].ToString());
                            //txtFirstname.Text = (myReader["EmpFirstName"].ToString());
                            //txtLastname.Text = (myReader["EmpLastName"].ToString());
                            //txtGender.Text = (myReader["EmpGender"].ToString());
                            //txtContact.Text = (myReader["EmpContact"].ToString());
                            //txtAddress.Text = (myReader["EmpAddress"].ToString());
                            //txtDept.Text = (myReader["EmpDept"].ToString());
                        }
                    }
                }
                // Put a breakpoint on the following curly brace so you can establish that the 
                // code is working without problems (assuming your ducks are otherwise all in a row)
            }
            catch (Exception ex)
            {
                // do something appropriate to indicate whatever problem arises
                // if you're debugging, put a breakpoint on either of the curly braces to stup exceution
            }
        }
         
    }
}