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
    public partial class ADMINHOME : System.Web.UI.Page
    {
        void GetData()
        {
            //create connection by using sqlconnetion class
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
            //pass store procedure to database by using sqldataadapter
            string q = "Proc_DisplayUsers";
            SqlDataAdapter da = new SqlDataAdapter(q, con);
            //create object for dataset
            DataSet ds = new DataSet();
            //fill dataset
            da.Fill(ds);
            //provide link between Gridview to dataset
            GridView1.DataSource = ds;
            //bind dataset
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                GetData();
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName=="cmdEdit")
            {
                //find button index
                int index = Convert.ToInt32(e.CommandArgument);
                //find row index
                GridViewRow row = GridView1.Rows[index];
                //assign name to controls
                Label l1 = (Label)row.FindControl("Label1");
                Label l2 = (Label)row.FindControl("Label2");
                Label l3 = (Label)row.FindControl("Label3");
                Label l4 = (Label)row.FindControl("Label4");
                Label l5 = (Label)row.FindControl("Label5");
                Label l6 = (Label)row.FindControl("Label6");
                Label l7 = (Label)row.FindControl("Label7");
                Label l8 = (Label)row.FindControl("Label8");
                Label l9 = (Label)row.FindControl("Label9");
                Label l10 = (Label)row.FindControl("Label10");
                Label l11 = (Label)row.FindControl("Label11");
                Label l12 = (Label)row.FindControl("Label12");
                Session["uid"] = l1.Text;
                Session["uname"] = l2.Text;
                Session["pass"] = l3.Text;
                Session["gen"] = l4.Text;
                Session["lang"] = l5.Text;
                Session["state"] = l6.Text;
                Session["city"] = l7.Text;
                Session["bgroup"] = l8.Text;
                Session["phno"] = l9.Text;
                Session["email"] = l10.Text;
                Session["status"] = l11.Text;
                Session["available"] = l12.Text;
                Session["upd"] = 2;
                Session["Label"] = "UPDATE";
                Server.Transfer("register.aspx");
             
            }
            else if(e.CommandName=="cmdDelete")
            {
                //find button index
                int index = Convert.ToInt32(e.CommandArgument);
                //find row index
                GridViewRow row = GridView1.Rows[index];
                //assign name to controls
                Label l1 = (Label)row.FindControl("Label1");
                //create connection by using sqlconnection class
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
                //open connection
                con.Open();
                //pass store procedure to database bu using sqlcommand class
                string q = "Proc_DeleteUsers";
                SqlCommand com = new SqlCommand(q, con);
                //inform that we are using store procedure
                com.CommandType = CommandType.StoredProcedure;
                //add value with parameter
                com.Parameters.AddWithValue("@a", l1.Text);
                //excuite store procedure by using ExcuiteNonQuery() method
                com.ExecuteNonQuery();
                //close connection
                con.Close();
                //call getdata
                GetData();
                

            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GetData();
        }
    }
}