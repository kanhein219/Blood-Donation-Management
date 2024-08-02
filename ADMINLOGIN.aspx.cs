using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace MAIM_PROJECT_BLOOD_MANAGEMENT
{
    public partial class ADMINLOGIN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //create by using sql connection class
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
            //open connectio
            con.Open();
            //pass store procedure to database by using sqlcommand class
            string q = "Proc_LoginAdmin";
            SqlCommand com = new SqlCommand(q, con);
            //inform that we are using sql store procedure
            com.CommandType = CommandType.StoredProcedure;
            //add values to parameter 
            com.Parameters.AddWithValue("@uid", TextBox1.Text);
            com.Parameters.AddWithValue("@pass", TextBox2.Text);
            //excuite by using ExcuiteScalar() method
            object p= com.ExecuteScalar();
            if((int)p!=0)
            {
                Server.Transfer("ADMINHOME.aspx");
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "User Id or Password is Wrong";
            }
            //close connection
            con.Close();
        }
    }
}