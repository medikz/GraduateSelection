using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


    public partial class Teacher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Share.username == "")
            {
                Response.Write("<script>window.alert('请先登录');</script>");
                Response.Redirect("Login.aspx");
            }
            if (!Page.IsPostBack)
            {
            //获取教师自己的个人信息
            GetTeacherInfo();
            Sql s = new Sql();
            string strSQL = "select * from Subject where Tea_Id='" + Share.username + "'";
            DataTable dt = s.Select(strSQL);
            if (dt.Rows.Count != 0) 
            {
                GridView_Sub.DataSource = dt.DefaultView;
                GridView_Sub.DataBind();

            }
            string strSQLSelection = "select * from Selection where Tea_Id='" + Share.username + "'";
            DataTable dtsel = s.Select(strSQLSelection);
            if (dtsel.Rows.Count != 0)
            {
                GetSeletionStu();
            }

           }//非表单提交
        }

        void GetSeletionStu() 
        {

            Sql s = new Sql();
            string strSQL = "select Student.Stu_Id as 学号,Stu_Name as 学生姓名,Sub_Name as 课题名 from Selection,Student,Subject where Sub_State=0 and Selection.Tea_Id='" + Share.username + "' and Selection.Stu_Id = Student.Stu_Id and Selection.Sub_Id = Subject.Sub_Id and Sub_Role=1";
            DataTable dt = s.Select(strSQL);
            if (dt.Rows.Count != 0)
            {
                dataGridView1.DataSource = dt.DefaultView;
                dataGridView1.DataBind();

                for (int lines = 0; lines < dt.Rows.Count; lines++)
                {
                    DropDownList1.Items.Add(new ListItem(dt.Rows[lines]["学生姓名"].ToString()));
                }
            }

            string strSQL1 = "select Student.Stu_Id as 学号,Stu_Name as 学生姓名,Sub_Name as 课题名 from Selection,Student,Subject where Sub_State=0 and Selection.Tea_Id='" + Share.username + "' and Selection.Stu_Id = Student.Stu_Id and Selection.Sub_Id = Subject.Sub_Id and Sub_Role=2";
            DataTable dt1 = s.Select(strSQL1);
            if (dt1.Rows.Count != 0)
            {
                dataGridView2.DataSource = dt1.DefaultView;
                dataGridView2.DataBind();
                if (!Page.IsPostBack)
                {
                    for (int lines = 0; lines < dt1.Rows.Count; lines++)
                    {
                        DropDownList2.Items.Add(new ListItem(dt1.Rows[lines]["学生姓名"].ToString()));
                    }
                }
            }
        }
        protected void dataGridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            System.Web.UI.Control c = (System.Web.UI.Control)e.CommandSource;
            GridViewRow g = (GridViewRow)c.NamingContainer;
            Share.path = g.Cells[1].Text.ToString(); //学号
            Share.path1 = g.Cells[3].Text.ToString();//课题名
            Response.Redirect("Tea_Sel.aspx?Stu_Id=" + Share.path + "&Sub_Name=" + Share.path1 + "");
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {/*
           
          * */
        }
        protected void btnEditTea_Click(object sender, EventArgs e)
        {
            EditTeacherInfo();

        }
        void GetTeacherInfo()
        {
            string sqlstring = "select * from Teacher where Tea_Role!=0 and Teacher.Tea_Id='" + Share.username + "'";
            Sql s = new Sql();
            DataTable dt = s.Select(sqlstring);
            if (dt.Rows.Count != 0)
            {
                txtTeaNo.Text = dt.Rows[0]["Tea_Id"].ToString();
                txtPwd.Text = dt.Rows[0]["Tea_Psd"].ToString();
                txtPro.Text = dt.Rows[0]["Tea_Prof"].ToString();
                txtTel.Text = dt.Rows[0]["Tea_Tel"].ToString();
                txtEmail.Text = dt.Rows[0]["Tea_Email"].ToString();
            }

            sqlstring = "select * from Major,Tea_Maj where Tea_Maj.Maj_No = Major.Maj_No and Tea_Maj.Tea_Id='" + txtTeaNo.Text.ToString() + "'";
            s = new Sql();
            dt = s.Select(sqlstring);
            if (dt.Rows.Count != 0)
            {
                txtMajor.Text = dt.Rows[0]["Maj_Name"].ToString();

                sqlstring = "select * from Subject,Teacher where Subject.Tea_Id = Teacher.Tea_Id and Teacher.Tea_Id='" + txtTeaNo.Text.ToString() + "'";
                s = new Sql();
                dt = s.Select(sqlstring);
                txtSubNo.Text = dt.Rows[0]["Sub_Id"].ToString();
                txtSubName.Text = dt.Rows[0]["Sub_Name"].ToString();
                txtSubInfo.Text = dt.Rows[0]["Sub_Info"].ToString();
            }
        }

        void EditTeacherInfo()
        {
            string sqlstring = "select * from Teacher where Teacher.Tea_Id='" + Share.username + "'";
            Sql s = new Sql();
            DataTable dt = s.Select(sqlstring);
            if (dt.Rows.Count != 0)
            {
                string sqlUpdateTea = "UPDATE Teacher SET Teacher.Tea_Psd ='" + txtPwd.Text
                    + "',Teacher.Tea_Prof ='" + txtPro.Text + "',Teacher.Tea_Tel ='" + txtTel.Text + "',Teacher.Tea_Email='" + txtEmail.Text + "' where Teacher.Tea_Id='" + Share.username + "'";
                string sqlUpdateMaj = "update Tea_Maj set Maj_No = '" + txtMajor.Text + "'";

                s.Execute(sqlUpdateTea);
                s.Execute(sqlUpdateMaj);
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Sql s = new Sql();
            string strSQL = "insert into Subject values('" + txtSubNo.Text + "','" + txtSubName.Text + "','" + txtSubInfo.Text + "','" + txtTeaNo.Text + "')";
            s.Execute(strSQL);
            Response.Write("<script language=javascript>alert('记录添加成功'); </script>;");
            Response.Redirect("Teacher.aspx");
        }
}
