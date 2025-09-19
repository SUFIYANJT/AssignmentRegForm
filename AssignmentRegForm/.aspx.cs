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
    public partial class WebForm7 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=DESKTOP-D5LISN2\SQLEXPRESS;database=aspcore;Integrated Security=True;");
        protected void Page_Load(object sender, EventArgs e)
        {
            get_grid();
        }
        public void get_grid()
        {
            string str = "select * from Table_4";
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewRow rw = GridView1.Rows[GridView1.SelectedIndex];
            Label2.Text = rw.Cells[2].Text;
            Label2.Text = rw.Cells[3].Text;
        }
    }
}