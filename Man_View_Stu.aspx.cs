using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

public partial class Man_View_Stu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string strSQL = "select Student.Stu_Id as 学号, Stu_Name as 姓名,Stu_QQ as QQ号,Stu_Email as Email,Stu_Tel as 电话,Stu_Psd as 密码,Stu_Sex as 性别,Maj_Name as 专业 from  Student,Stu_Maj,Major where Student.Stu_Id = Stu_Maj.Stu_Id and Stu_Maj.Maj_No=Major.Maj_No";
        Sql s = new Sql();
        s.Execute(strSQL);
        // Response.Write("显示所有学生情况");
        DataTable dt = s.Select(strSQL);
        GridView1.DataSource = dt.DefaultView;
        GridView1.DataBind();
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        Control c = (System.Web.UI.Control)e.CommandSource;
        GridViewRow g = (GridViewRow)c.NamingContainer;
        string Stu_Id = g.Cells[1].Text.ToString();
        string Stu_Name = g.Cells[2].Text.ToString();
        string Stu_QQ = g.Cells[3].Text.ToString();
        string Stu_Email = g.Cells[4].Text.ToString();
        string Stu_Tel = g.Cells[5].Text.ToString();
        string Stu_Psd = g.Cells[6].Text.ToString();
        string Stu_Sex = g.Cells[7].Text.ToString();
        string Major_No = g.Cells[8].Text.ToString();

        Response.Redirect("Man_Add_Stu.aspx?Stu_Id=" + Stu_Id + "&Stu_Name="+Stu_Name+"&Stu_QQ="+Stu_QQ+"&Stu_Email="+Stu_Email+"&Stu_Tel="+Stu_Tel+"&Stu_Psd="+Stu_Psd+"&Stu_Sex="+Stu_Sex+"&Maj_No="+Major_No+"");
    }
}
