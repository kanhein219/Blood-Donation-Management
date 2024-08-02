using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MAIM_PROJECT_BLOOD_MANAGEMENT
{
    public partial class USERLOGIN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //create connection by using sql connection class
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
            //open connection
            con.Open();
            //pass store procedure to database by using sqlcommand class
            string q = "Proc_LoginUser";
            SqlCommand com = new SqlCommand(q, con);
            //inform that we are using store procedure 
            com.CommandType = CommandType.StoredProcedure;
            //add values with parameters
            Session["uname"] = TextBox1.Text;
            Session["pass"] = TextBox2.Text;
            com.Parameters.AddWithValue("@uname", TextBox1.Text);
            com.Parameters.AddWithValue("@pass", TextBox2.Text);
            //excuite store procedure by using ExcuiteScalar() method
            object p = com.ExecuteScalar();
            if((int)p!=0)
            {
                Server.Transfer("USERHOME.aspx");
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "USER NAME OR PASSSWORD IS INCORRECT";
            }
        }
    }
}