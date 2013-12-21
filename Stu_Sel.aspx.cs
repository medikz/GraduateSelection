using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


    public partial class Stu_Sel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Share.username == "")
            {
                Response.Write("<script>window.alert('请先登录');</script>");
                //MessageBox.Show("请先登录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Response.Redirect("Login.aspx");
            }
            //Response.Write(Request.QueryString["Sub_Name"]);
            
            TextBox1.Text = Request.QueryString["Sub_Name"];
            TextBox1.Text = Share.path;
            if (Request.QueryString["Sub_Role"]!=null)
            {
                DropDownList1.SelectedValue = Request.QueryString["Sub_Role"];
            }
            
            if (TextBox1.Text == "")
            {
            Response.Write("<script>window.alert('本志愿尚未选择，请返回上一级选定');</script>");
            Response.Redirect("Student.aspx");
            }
            
            Sql s = new Sql();
            string strSQL = "select Sub_Info from Subject where Sub_Name='" + TextBox1.Text + "'";
            DataTable dt = s.Select(strSQL);
            richTextBox1.Text = dt.Rows[0][0].ToString();
        }

        int role(string strsql)
        {
            Sql s = new Sql();
            DataTable dt = s.Select(strsql);
            return dt.Rows.Count;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //获取该课程的详细信息
                    Sql s = new Sql();
                    string strSelectSubSQL = "select Sub_Id,Tea_Id from Subject where Sub_Name='" + TextBox1.Text + "'";
                    DataTable dt = s.Select(strSelectSubSQL);
                    int Role = 100;

                    //查询该学生已经选了几个课题，第一志愿Sub_Role为1，第二志愿为2，超过两个拒绝添加
                    string strSelectSelSql = "select * from Selection where Stu_Id = '" + Share.username + "'";
                    switch (role(strSelectSelSql))
                    {
                        case 0:
                            Role = 1;
                            break;
                        case 1:
                            Role = 2;
                            break;
                        //case 2:
                           // Response.Write("<script>window.alert('您已经选了两个课题！');</script>");   
                      //  return;
                   }
                    Role = Convert.ToInt32(DropDownList1.SelectedValue);
                   //判断是否已经选了课，并清空
                    CheckOneChoice(Share.username, Role);
                    string strInsertSql = "insert into Selection values ('" + Share.username + "','" + dt.Rows[0][1].ToString() + "','" + dt.Rows[0][0].ToString() + "','" + Role + " ',' ', '0')";
                    s.Execute(strInsertSql);
                    Response.Write("<script>window.alert('选择成功！，您已选择《" + TextBox1.Text + "》作为您的毕业设计题目! ');</script>"); 
                    Response.Redirect("Student.aspx",false);
                    //return;
                
            }
            catch
            {
                Response.Write("<script>window.alert('执行失败，请联系管理员！ ');</script>"); 
            
               // MessageBox.Show("执行失败，请联系管理员！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        bool CheckOneChoice(string StuID, int SubRole)
        {
            Sql s = new Sql();
            string strSQL = "select Sub_Role from Selection where Stu_ID='"+StuID+"'";
            DataTable dt = s.Select(strSQL);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++ )
                {
                    strSQL = "delete from Selection where Stu_ID="+StuID+ " and Sub_Role='"+SubRole+"'";
                    s.Execute(strSQL);
                }
                return true;
            }
            else
                return false;

        }
    }
