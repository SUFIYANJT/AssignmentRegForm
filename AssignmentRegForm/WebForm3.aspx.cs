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
    public partial class WebForm3 : System.Web.UI.Page
    {
        SqlConnection con=new SqlConnection(@"server=DESKTOP-D5LISN2\SQLEXPRESS;database=aspcore;Integrated Security=True;");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                string selstring = "Select Name,Age,Address,Phone,Email,Photo from Table_4 where id=" + Session["uid"] + "";
                SqlCommand cmd = new SqlCommand(selstring, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TextBox1.Text = dr["Name"].ToString();
                    TextBox2.Text = dr["Age"].ToString();
                    TextBox3.Text = dr["Address"].ToString();
                    TextBox4.Text = dr["Phone"].ToString();
                    TextBox5.Text = dr["Email"].ToString();
                    Image1.ImageUrl = dr["Photo"].ToString();

                }
                con.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string upda = "UPDATE Table_4 SET  Age=" + TextBox2.Text + ",Address='"+TextBox3.Text+"',Phone="+TextBox4.Text+",Email='"+TextBox5.Text+"' where id="+Session["uid"];
            SqlCommand cmd = new SqlCommand(upda, con);
            con.Open();
            int rowa = cmd.ExecuteNonQuery();
            con.Close();
            if (rowa == 1)
            {
                Label7.Text="Updated";
            }
        }
    }
}