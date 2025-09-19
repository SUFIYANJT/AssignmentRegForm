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
    public partial class WebForm5 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=DESKTOP-D5LISN2\SQLEXPRESS;database=aspcore;Integrated Security=True;");
        protected void Page_Load(object sender, EventArgs e)
        {
            Bind_grid();
        }
        public void Bind_grid()
        {
            string str = "select * from Table_4";
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            int getid = Convert.ToInt32(e.CommandArgument);
            string del = "delete from Table_4 where id=" + getid+"";
            SqlCommand cmd = new SqlCommand(del, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i == 1)
            {
                Label1.Text = "Delected";
            }
            Bind_grid();
        }

    }
}