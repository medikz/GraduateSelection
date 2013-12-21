using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!IfEmptyOrNull())  //判断是否为空，为空返回
            {
                Sql s = new Sql();
                DataTable dt = s.Select(strSQL(Flag()));
                if (dt.Rows.Count == 0)
                {
                    Response.Write("<script>alert('用户名、密码或权限错误，请重新输入！')</script>");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox1.Focus();
                    return;
                }
                else
                {
                    switch (Flag())
                    {
                        case 0:                           //权限为0，视为管理员，进入管理员界面
                            Share.username = textBox1.Text;
                            Response.Redirect("Manager.aspx");
                            break;
                        case 1:                           //权限为1，视为教师，进入教师界面
                            Share.username = textBox1.Text;
                            Response.Redirect("Teacher.aspx?UserName="+textBox1.Text+"");
                            break;
                        case 2:                           //权限为2，视为学生，进入学生界面
                            Share.username = textBox1.Text;
                            Response.Redirect("Student.aspx?UserName="+textBox2.Text+"");
                            break;
                    }
                    //this.Hide();
                }
            }
            else Response.Write("<script>alert('请输入完整！')</script>");
            return;
        }

        bool IfEmptyOrNull()
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                return true;
            }
            else return false;
        }
        string strSQL(int flag)
        {
            string strsql = null;
            switch (flag)
            {
                //不同的身份进行不同的身份验证
                case 0:
                    strsql = "select * from Teacher where Tea_Id = '" + textBox1.Text + "' and Tea_Psd = '" + textBox2.Text + "' and Tea_Role =0";
                    break;
                case 1:
                    strsql = "select * from Teacher where Tea_Id = '" + textBox1.Text + "' and Tea_Psd = '" + textBox2.Text + "' and Tea_Role ='1'";
                    break;
                case 2:
                    strsql = "select * from Student where Stu_Id = '" + textBox1.Text + "' and Stu_Psd = '" + textBox2.Text + "'";
                    break;
            }
            return strsql;
        }
        int Flag()
        {
            //根据不同的选项确定不同的权限
            int flag = 20;
            if (radio_Stu.Checked)
            {
                flag = 2;
            }
            else if (radio_Tea.Checked)
            {
                flag = 1;
            }
            else flag = 0;
            return flag;
        }

        protected void radio_Tea_CheckedChanged(object sender, EventArgs e)
        {
            LabelID.Text = "工 号";
            textBox1.ToolTip = "教师密码询管理员zju_kxy@126.com";
            textBox2.ToolTip = "教师密码询管理员zju_kxy@126.com";
        }
        protected void radio_Stu_CheckedChanged(object sender, EventArgs e)
        {
            LabelID.Text = "学 号";
            textBox1.ToolTip = "密码:出生年月日YYYYMMDD";
            textBox2.ToolTip = "密码:出生年月日YYYYMMDD";

        }
        protected void radio_Man_CheckedChanged(object sender, EventArgs e)
        {
            LabelID.Text = "工 号";
            textBox1.ToolTip = "管理员每所一个询zju_kxy@126.com";
            textBox2.ToolTip = "管理员每所一个询zju_kxy@126.com";
        }
}