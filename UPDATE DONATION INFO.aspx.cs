using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace MAIM_PROJECT_BLOOD_MANAGEMENT
{
    public partial class UPDATE_DONATION_INFO : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        public object Availabledate;
        void GetAvailableDate()
        {
            //create connnection by using sqlconnection class
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
            //open connection
            con.Open();
            //pass store procedure to database bu using sqlcommand class
            string q = "Proc_getcurrentdate";
            SqlCommand com = new SqlCommand(q,con);
            //excuite by using ExcuiteScalar() 
            Availabledate = com.ExecuteScalar();
            //close connection
            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GetAvailableDate();

            //create connnection by using sqlconnection class
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
            //open connection
            con.Open();
            //pass store procedure to database bu using sqlcommand class
            string q = "Proc_updateDonationinfo";
            SqlCommand com = new SqlCommand(q, con);
            //inform that we are using store procedure 
            com.CommandType = CommandType.StoredProcedure;
            //add valuse with parameter 
            com.Parameters.AddWithValue("@uname", Session["uname"]);
            com.Parameters.AddWithValue("@pass", Session["pass"]);
            com.Parameters.AddWithValue("@regdate", Availabledate);
            com.Parameters.AddWithValue("@status", "Unavailable");
            //excuite by using ExcuiteNonQuery() 
           int p= com.ExecuteNonQuery();
           if(p!=0)
            {
                Label1.Visible = true;
                Label1.ForeColor = System.Drawing.Color.Green;
                Label1.Text = "Donation date update successfull";
            }
           else
            {
                Label1.Visible = true;
                Label1.ForeColor = System.Drawing.Color.Red;
                Label1.Text = "Donation date not updated ";
            }
            //close connection
            con.Close();
            Server.Transfer("USERHOME.aspx");
        }
    }
}