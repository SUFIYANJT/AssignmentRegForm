using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssignmentRegForm
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Label1.Text = TextBox1.Text;
            Label2.Text = TextBox2.Text;
            Label3.Text = TextBox8.Text;
            Label4.Text = TextBox3.Text;
            Label5.Text = TextBox4.Text;
            Label6.Text = RadioButtonList1.SelectedItem.Text;
            Label7.Text = DropDownList1.SelectedItem.Text;
           
            String c = "";
            for(int i = 0; i < CheckBoxList1.Items.Count; i++)
            {
                if (CheckBoxList1.Items[i].Selected)
                {
                    c = c + CheckBoxList1.Items[i].Text + ',';
                }
            }
            Label8.Text = c;
            string p= "~/Photos/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));
            Image1.ImageUrl = p;
            Label9.Text = TextBox5.Text;
            Label11.Text = TextBox7.Text;
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}