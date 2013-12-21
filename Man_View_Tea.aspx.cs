using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Man_View_Tea : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string strSQL = "select Teacher.Tea_Id as 工号, Tea_Name as 姓名,Tea_QQ as QQ号,Tea_Email as Email,Tea_Tel as 电话,Tea_Psd as 密码,Tea_Role as 身份,Tea_Prof as 职称,Maj_Name as 专业 from  Teacher,Tea_Maj,Major where Teacher.Tea_Id = Tea_Maj.Tea_Id and Tea_Maj.Maj_No=Major.Maj_No";
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
        string Tea_Id = g.Cells[1].Text.ToString();
        string Tea_Name = g.Cells[2].Text.ToString();
        string Tea_QQ = g.Cells[3].Text.ToString();
        string Tea_Email = g.Cells[4].Text.ToString();
        string Tea_Tel = g.Cells[5].Text.ToString();
        string Tea_Psd = g.Cells[6].Text.ToString();
        string Tea_Role = g.Cells[7].Text.ToString();
        string Tea_Prof = g.Cells[8].Text.ToString();
        string Major_No = g.Cells[9].Text.ToString();

        Response.Redirect("Man_Add_Tea.aspx?Tea_Id=" + Tea_Id + "&Tea_Name=" + Tea_Name + "&Tea_QQ=" + Tea_QQ + "&Tea_Email=" + Tea_Email + "&Tea_Tel=" + Tea_Tel + "&Tea_Psd=" + Tea_Psd + "&Tea_Role=" + Tea_Role + "&Tea_Prof="+Tea_Prof+"&Maj_No="+Major_No+"");
    }
}