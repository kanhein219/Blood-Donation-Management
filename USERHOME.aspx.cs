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
    public partial class USERHOME : System.Web.UI.Page
    {
        void GetUserData()
        {
            //create connection by using sqlconnection class
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
            //pass store procedure to database by using SqlDataAdapter
            string q = "Proc_detailsUser";
            SqlCommand com = new SqlCommand(q, con);
            //inform that we are using store procedure
            com.CommandType = CommandType.StoredProcedure;
            //add values with parameter
            com.Parameters.AddWithValue("uname",Session["uname"]);
            com.Parameters.AddWithValue("pass",Session["pass"]);
            SqlDataAdapter da = new SqlDataAdapter(com);
            //create dataset object
            DataSet ds = new DataSet();
            //fill dataset
            da.Fill(ds);
            //provide link between gridview to datasource
            GridView1.DataSource = ds;
            //bind gridview
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                GetUserData();
            }
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            

        }

        protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
        {
//
        }

        protected void GridView2_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

         
        }

        protected void GridView2_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
          
        }

        protected void GridView1_RowEditing1(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GetUserData();
        }

        protected void GridView1_RowCancelingEdit1(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GetUserData();
        }
       

        protected void GridView1_RowUpdating1(object sender, GridViewUpdateEventArgs e)
        {
            //find row index 
            GridViewRow row = GridView1.Rows[e.RowIndex];
            //assign name to controls
            TextBox l1 = (TextBox)row.FindControl("TextBox1");
            TextBox l2 = (TextBox)row.FindControl("TextBox2");
            TextBox l3 = (TextBox)row.FindControl("TextBox3");
            TextBox l4 = (TextBox)row.FindControl("TextBox5");
            TextBox l5 = (TextBox)row.FindControl("TextBox6");
            TextBox l6 = (TextBox)row.FindControl("TextBox7");
            TextBox l7 = (TextBox)row.FindControl("TextBox9");
            TextBox l8 = (TextBox)row.FindControl("TextBox10");
            //create connection with database by using sqlconnection class
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
            //open connection
            con.Open();
            //pass store procedure to database by  using sqlcommand class
            string q = "Proc_detailsUserUpdate";
            SqlCommand com = new SqlCommand(q, con);
            //inform that we are using store procedure
            com.CommandType = CommandType.StoredProcedure;
            //add values with parameter
            com.Parameters.AddWithValue("@uid", l1.Text);
            com.Parameters.AddWithValue("@uname", l2.Text);
            com.Parameters.AddWithValue("@pass", l3.Text);
            com.Parameters.AddWithValue("@lang", l4.Text);
            com.Parameters.AddWithValue("@state", l5.Text);
            com.Parameters.AddWithValue("@city", l6.Text);
            com.Parameters.AddWithValue("@phno", l7.Text);
            com.Parameters.AddWithValue("@email",l8.Text);
            //excuite store procedure by using ExcuiteNonQueryMethod()
             com.ExecuteNonQuery();
            
          /*  if (p!=0)
            {
                Label12.Visible = true;
                Label12.ForeColor = System.Drawing.Color.Green;
                Label12.Text = "Details Update Successfully";
                GridView1.EditIndex = -1;
               

            }
            else
            {
                Label12.Visible = true;
                Label12.ForeColor = System.Drawing.Color.Red;
                Label12.Text = "Details Not Update ";

            }
           */
        }
    }
}