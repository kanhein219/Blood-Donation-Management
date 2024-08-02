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
    public partial class SEARCH1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                GetState();
                DropDownList3.Items.Insert(0, "--Select City--");
            }
        }

        void GetState()
        {
            //create connection with database by using sqlconnection class
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
            //pass store procedure to database by using SqlDataAdapter
            string q = "Proc_State";
            SqlDataAdapter da = new SqlDataAdapter(q, con);
            //create object for dataset 
            DataSet ds = new DataSet();
            //fill dataset
            da.Fill(ds);
            //provide link between DropDownList1 
            DropDownList2.DataSource = ds;
            DropDownList2.DataTextField = "sname";
            DropDownList2.DataValueField = "sid";
            //bind DropDownList1
            DropDownList2.DataBind();
            DropDownList2.Items.Insert(0, "--Select State--");

        }
        protected void Menu2_MenuItemClick(object sender, MenuEventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //create conection by using sqlconnection class
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
            //pass store procedure to database by using sqlcommand class
            string q = "Proc_searchblood";
            SqlCommand com = new SqlCommand(q, con);
            //inform that we are using store procedure 
            com.CommandType = CommandType.StoredProcedure;
            //add values to parameter
            com.Parameters.AddWithValue("@state", DropDownList2.SelectedItem.Text);
            com.Parameters.AddWithValue("@city", DropDownList3.SelectedItem.Text);
            com.Parameters.AddWithValue("@bgroup", DropDownList1.SelectedItem.Text);
            //excuite by using sqldataadapter
            SqlDataAdapter da = new SqlDataAdapter(com);
            //create object for dataset
            DataSet ds = new DataSet();
            //fill dataset
            da.Fill(ds);
            //provide link between gridview to datasource
            GridView1.DataSource = ds;
            //bind gridview
            GridView1.DataBind();
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //create connection by using sqlconnection class
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
            //pass store procedure to database by using SqlDataAdapter
            string q = "Proc_city";
            SqlCommand com = new SqlCommand(q, con);
            //inform that we are using StoreProcedure
            com.CommandType = CommandType.StoredProcedure;
            //add values to parameter
            com.Parameters.AddWithValue("@sid", DropDownList2.SelectedValue);
            SqlDataAdapter da = new SqlDataAdapter(com);
            //create object for dataset 
            DataSet ds = new DataSet();
            //fill dataset
            da.Fill(ds);
            //provide link between datasource to DropDounList2
            DropDownList3.DataSource = ds;
            DropDownList3.DataTextField = "cname";
            //bind DropDownList
            DropDownList3.DataBind();
        }
    }
}