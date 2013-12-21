using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Manager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Man_View_Stu.aspx");
            string strSQL = "select * from  Student";
            Sql s = new Sql();
            s.Execute(strSQL);
           // Response.Write("显示所有学生情况");
            DataTable dt = s.Select(strSQL);
            GridView1.DataSource = dt.DefaultView;
            GridView1.DataBind();

        }
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Man_View_Tea.aspx");

            string strSQL = "select * from  Teacher";
            Sql s = new Sql();
            s.Execute(strSQL);
           // Response.Write("显示所有教师情况");
            DataTable dt = s.Select(strSQL);
            GridView1.DataSource = dt.DefaultView;
            GridView1.DataBind();

        }
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            string strSQL = "select * from  Subject";
            Sql s = new Sql();
            s.Execute(strSQL);
            //Response.Write("显示所有课题情况");
            DataTable dt = s.Select(strSQL);
            GridView1.DataSource = dt.DefaultView;
            GridView1.DataBind();
        }
        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            string strSQL = "select * from  Selection";
            Sql s = new Sql();
            s.Execute(strSQL);
           // Response.Write("显示所有课题情况");
            DataTable dt = s.Select(strSQL);
            GridView1.DataSource = dt.DefaultView;
            GridView1.DataBind();

        }
        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
}
