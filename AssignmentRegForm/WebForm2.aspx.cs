using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace AssignmentRegForm
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=DESKTOP-D5LISN2\SQLEXPRESS;database=aspcore;Integrated Security=True;");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String str="Select COUNT(Id) from Table_4 where username='" + TextBox1.Text + "' AND password='"+TextBox2.Text+"'";
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            string cid = cmd.ExecuteScalar().ToString();
            con.Close();
            if (cid == "1")
            {
                string str1 = "select Id from Table_4 where username='" + TextBox1.Text + "'AND password='" + TextBox2.Text + "'";
                SqlCommand cmd1 = new SqlCommand(str1, con);
                con.Open();
                string cid1 = cmd.ExecuteScalar().ToString();
                con.Close();
                Session["uid"] = cid1;
                Response.Redirect("WebForm3.aspx");
            }
            else
            {
                Label3.Text = "Invalid Email or Password";
            }
        }
    }
}