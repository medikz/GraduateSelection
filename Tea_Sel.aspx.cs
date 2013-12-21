using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


    public partial class Tea_Sel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Share.username == "")
            {
                Response.Write("<script>window.alert('请先登录！');</script>"); 
               // MessageBox.Show("请先登录！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Response.Redirect("Login.aspx");
            }
            Label2.Text = Request.QueryString["Stu_Id"];
            Label6.Text = Request.QueryString["Sub_Name"];
            Sql s = new Sql();
            string strSQL = "select Stu_Name from Student where Stu_Id = '" + Label2.Text + "'";
            DataTable dt = s.Select(strSQL);
            Label4.Text = dt.Rows[0][0].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
               // if (DialogResult.Yes == MessageBox.Show("您确定要选择" + Label4.Text + "同学的" + Label6.Text + "课题嘛？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
               // {
                    string strSQL = "update Selection set Sub_State = '1' where Stu_Id = '" + Label2.Text + "' and Sub_Id = (select Sub_Id from Subject where Sub_Name = '" + Label6.Text + "')";
                    Sql s = new Sql();
                    s.Execute(strSQL);
                String sms = Label4.Text + "同学的" + Label6.Text + "课题！";
                Response.Write("<script>window.alert('选定成功，您已经选择' " + sms.ToString() + ");</script>"); 
                    //MessageBox.Show("选定成功，您已经选择" + Label4.Text + "同学的" + Label6.Text + "课题！", "选定成功", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
               // }
            }
            catch
            {
                Response.Write("<script>window.alert('选定失败，请联系管理员！');</script>");
                //MessageBox.Show("选定失败，请联系管理员！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
