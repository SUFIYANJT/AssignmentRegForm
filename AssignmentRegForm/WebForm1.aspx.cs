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
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=DESKTOP-D5LISN2\SQLEXPRESS;database=aspcore;Integrated Security=True;");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            String c = "";
            for (int i = 0; i < CheckBoxList1.Items.Count; i++)
            {
                if (CheckBoxList1.Items[i].Selected)
                {
                    c = c + CheckBoxList1.Items[i].Text + ',';
                }
            }
            string p = "~/Photos/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));
            string str = "INSERT INTO Table_4 VALUES ('"
                  + TextBox1.Text + "','"
                  + TextBox2.Text + "','"
                  + TextBox8.Text + "','"
                  + TextBox3.Text + "','" 
                  + TextBox4.Text + "','"
                  + RadioButtonList1.SelectedItem.Text + "','"
                  + DropDownList1.SelectedItem.Text + "','"
                  + c + "','"
                  + p + "','"
                  + TextBox5.Text + "','"
                  + TextBox7.Text + "')";

            SqlCommand cmd = new SqlCommand(str,con);
            con.Open();
            int t1 = cmd.ExecuteNonQuery();
            con.Close();
            if (t1==1)
            {
                Label1.Text = "Inserted";
            }



        }

     

        

        

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {
            String str1 = "select COUNT(Id) from Table_4 where Username='" + TextBox5.Text + "'";
            SqlCommand cmd = new SqlCommand(str1,con);
            con.Open();
            String cid = cmd.ExecuteScalar().ToString();

            con.Close();
            int id1 = Convert.ToInt32(cid);
            if (id1 >= 1)
            {
                Label12.Visible = true;
                Label12.Text = "Pls choose anthoer username";

            }
            else
            {
                Label1.Visible = false;
            }
        }
    }
}