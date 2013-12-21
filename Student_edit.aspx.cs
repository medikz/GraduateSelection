using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Student_edit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Label1.Text =="")
        {
            Sql s = new Sql();
            string strtable = "select * from student where Stu_Id='" + Share.username + "'";
            DataTable dt = s.Select(strtable);
            Label1.Text = dt.Rows[0][0].ToString();
            Label2.Text = dt.Rows[0][1].ToString();
            TextBox1.Text = dt.Rows[0][2].ToString();
            TextBox2.Text = dt.Rows[0][3].ToString();
            TextBox3.Text = dt.Rows[0][4].ToString();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Sql s = new Sql();
        string strupd="update Student set Stu_QQ='"+TextBox1.Text+"',Stu_Email='"+TextBox2.Text+"' where Stu_Id='"+Share.username+"'";
        s.Execute(strupd);
        strupd="update Student set Stu_Tel='"+TextBox3.Text+"' where Stu_Id='"+Share.username+"'";
        s.Execute(strupd);
        Response.Redirect("Student.aspx", false);
    }
}