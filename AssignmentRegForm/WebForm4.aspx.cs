using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace AssignmentRegForm
{   
    
    public partial class WebForm4 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=DESKTOP-D5LISN2\SQLEXPRESS;database=aspcore;Integrated Security=True;");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindPage();
            }
           
        }
        protected void bindPage()
        {
            string str2 = "select id,Name from Table_4";
            SqlDataAdapter da = new SqlDataAdapter(str2, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DropDownList1.DataSource = ds;
            DropDownList1.DataTextField = "Name";
            DropDownList1.DataValueField = "id";
            DropDownList1.DataBind();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = DropDownList1.SelectedItem.Value;
            Label2.Text = DropDownList1.SelectedItem.Text;
        }

      
        protected void Button1_Click(object sender, EventArgs e)
        {
            string str2 = "select * from Table_4";
            SqlDataAdapter da = new SqlDataAdapter(str2, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string str2 = "select * from Table_4";
            SqlDataAdapter da = new SqlDataAdapter(str2, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataList1.DataSource = ds;
            DataList1.DataBind();
        }
    }
}