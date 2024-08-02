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
    public partial class register : System.Web.UI.Page
    {
      /*  void GetRegisterDate()
        {
            //create connection by using sql connection class
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
            //open connection
            con.Open();
            //pass store procedure to database by using sqlcommand
            string q = "Proc_getcurrentdate";
            SqlCommand com = new SqlCommand(q, con);
            //Excuite by using ExcuiteReader() method
            SqlDataReader dr = com.ExecuteReader();
            if(dr.HasRows)
            {
                dr.Read();
                TextBox6.Text = dr[0].ToString();
                    
            }
            //close connection
            con.Close();
        }
      */
       
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
            DropDownList1.DataSource = ds;
            DropDownList1.DataTextField = "sname";
            DropDownList1.DataValueField = "sid";
            //bind DropDownList1
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, "--Select State--");

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack==false)
            {
                GetState();
              //  GetRegisterDate();

                DropDownList2.Items.Insert(0, "--Select--");

                if (Convert.ToInt32(Session["upd"])==2)
                {
                  
                    TextBox1.Text = Session["uname"].ToString();
                    TextBox2.Text = Session["pass"].ToString();
                    if(Session["gen"].ToString()=="MALE")
                    {
                        RadioButton1.Checked = true;
                    }
                    else
                    {
                        RadioButton2.Checked = true;
                    }
                    string lang = Session["lang"].ToString();
                    string[] lang1 = lang.Split();
                    foreach(string i in lang1)
                    {
                        if(i=="MARATHI")
                        {
                            CheckBox1.Checked = true;
                        }
                        if(i=="HINDI")
                        {
                            CheckBox2.Checked = true;
                        }
                        if(i=="ENGLISH")
                        {
                            CheckBox3.Checked = true;
                        }
                    }
                    DropDownList1.SelectedItem.Text = Session["state"].ToString();
                    DropDownList2.SelectedItem.Text = Session["city"].ToString();
                    DropDownList3.SelectedItem.Text = Session["bgroup"].ToString();
                    TextBox4.Text = Session["phno"].ToString();
                    TextBox5.Text = Session["email"].ToString();
                    TextBox6.Text = Session["available"].ToString();

                    Button1.Text = "UPDATE";
                }
               
                DropDownList2.Items.Insert(0, "--Select City--");
            }
        }
     
        
            
            
        
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {  //create connection by using sqlconnection class
             SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
            //pass store procedure to database by using SqlDataAdapter
            string q = "Proc_city";
            SqlCommand com = new SqlCommand(q, con);
            //inform that we are using StoreProcedure
            com.CommandType = CommandType.StoredProcedure;
            //add values to parameter
            com.Parameters.AddWithValue("@sid", DropDownList1.SelectedValue);
            SqlDataAdapter da = new SqlDataAdapter(com);
            //create object for dataset 
            DataSet ds = new DataSet();
            //fill dataset
            da.Fill(ds,"city");
            //provide link between datasource to DropDounList2
            DropDownList2.DataSource = ds;
            DropDownList2.DataTextField = "cname";
            //bind DropDownList
            DropDownList2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string q = " ";
            if(Button1.Text=="REGISTER")
            {
                q = "PROC_REGISTER";

            }
            else if(Button1.Text=="UPDATE")
            {
                q = "Proc_detailsUserUpdate";
            }
            //create connection with database by using sqlconnetion class
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
            //open connection
            con.Open();
            //pass store procedure to database by using sqlcommand class
            SqlCommand com = new SqlCommand(q, con);
            //inform that we are using  store procedure
            com.CommandType = CommandType.StoredProcedure;
            //add values with parameter
            com.Parameters.AddWithValue("@uname", TextBox1.Text);
            com.Parameters.AddWithValue("@pass", TextBox2.Text);
            if (Button1.Text == "REGISTER")
            {
                string gen = "";
                if (RadioButton1.Checked == true)
                {
                    gen = RadioButton1.Text;
                }
                else
                {
                    gen = RadioButton2.Text;
                }
                com.Parameters.AddWithValue("@gen", gen);
                com.Parameters.AddWithValue("@bgroup", DropDownList3.SelectedItem.Text);
                com.Parameters.AddWithValue("@regdate",TextBox6.Text);
                com.Parameters.AddWithValue("@status", "Available");


            }
            if(Button1.Text!="REGISTER")
            {

                com.Parameters.AddWithValue("@uid", Session["uid"]);
            }
            string lang = "";
            if(CheckBox1.Checked==true)
            {
                lang = CheckBox1.Text;
            }
            if(CheckBox2.Checked==true)
            {
                lang = lang + " " + CheckBox2.Text;
            }
            if(CheckBox3.Checked==true)
            {
                lang = lang + " " + CheckBox3.Text;
            }
            com.Parameters.AddWithValue("@lang", lang);
            com.Parameters.AddWithValue("@state", DropDownList1.SelectedItem.Text);
            com.Parameters.AddWithValue("@city", DropDownList2.SelectedItem.Text);
            com.Parameters.AddWithValue("@phno", TextBox4.Text);
            com.Parameters.AddWithValue("@email", TextBox5.Text);
            //excuite store procedure by using ExcuiteNonQuery()
            int i = com.ExecuteNonQuery();
            if(i!=0)
            {
                Label1.Visible = true;
                Label1.ForeColor = System.Drawing.Color.Green;
                Label1.Text = "Recorded inserted Register";
                Clear();
            }
            else
            {

                Label1.Visible = true;
                Label1.ForeColor = System.Drawing.Color.Red;
                Label1.Text = "Not Register";
            }
            //close connection
            con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            TextBox1.Text = TextBox2.Text = TextBox3.Text = TextBox4.Text = TextBox5.Text = TextBox6.Text = "";
            RadioButton1.Checked = RadioButton2.Checked = CheckBox1.Checked = CheckBox2.Checked = CheckBox3.Checked = false;
            DropDownList1.SelectedIndex = 0;
            DropDownList2.SelectedIndex = 0; DropDownList3.SelectedIndex = 0;
        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}