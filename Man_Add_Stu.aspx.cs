using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

    public partial class Man_Add_Stu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count == 0)
            {
                comboBox1.Items.Add("男");
                comboBox1.Items.Add("女");
                comboBox1.Text = "男";
            }
            Sql s = new Sql();
            string strSQLSelectMaj_No = "select * from Major";
            DataTable dt = s.Select(strSQLSelectMaj_No);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox2.Items.Add(dt.Rows[i][1].ToString());
            }
            if (txt_Stu_Id.Text == "")
            {
                txt_Stu_Id.Text = Request.QueryString["Stu_Id"];
                txt_Stu_Name.Text = Request.QueryString["Stu_Name"];
                txt_Stu_QQ.Text = Request.QueryString["Stu_QQ"];
                txt_Stu_Email.Text = Request.QueryString["Stu_Email"];
                txt_Stu_Tel.Text = Request.QueryString["Stu_Tel"];
                txt_Stu_Psd.Text = Request.QueryString["Stu_Psd"];
                comboBox1.Text = Request.QueryString["Stu_Sex"];
                comboBox2.Text = Request.QueryString["Maj_No"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (IfEmptyOrNull())
            {
                Response.Write("<script>alert('请输入完整！')</script>");
                return;
            }
            else
            {
                Sql s = new Sql();
                string strsql = "select Maj_No from Major where Maj_Name='" + comboBox2.Text + "'";
                DataTable dt = s.Select(strsql);

                string strSQLSelectStu_Id = "select * from Stu_Maj where Stu_Id = '" + txt_Stu_Id.Text + "'";
                DataTable dts = s.Select(strSQLSelectStu_Id);
                if (dts.Rows.Count != 0)
                {
                    string strsql1 = "update Student set Stu_Name='" + txt_Stu_Name.Text + "',Stu_QQ='" + txt_Stu_QQ.Text + "',Stu_Email='" + txt_Stu_Email.Text + "',Stu_Psd='" + txt_Stu_Psd.Text + "',Stu_Tel='" + txt_Stu_Tel.Text + "',Stu_Sex='" + comboBox1.Text + "' where Stu_Id = " + txt_Stu_Id.Text + "";
                    string strsql2 = "update Stu_Maj set Maj_No='" + dt.Rows[0][0].ToString() + "' where Stu_Id = " + txt_Stu_Id.Text + "";
                    s.Execute(strsql1);
                    s.Execute(strsql2);
                }
                else
                {
                    string strSQLInsertStudent = "insert into Student values ('" + txt_Stu_Id.Text + "','" + txt_Stu_Name.Text + "','" + txt_Stu_QQ.Text + "','" + txt_Stu_Email.Text + "','" + txt_Stu_Tel.Text + "','" + txt_Stu_Psd.Text + "','" + comboBox1.Text + "')";
                    string strSQLInsertStu_Maj = "insert into Stu_Maj values('" + txt_Stu_Id.Text + "','" + dt.Rows[0][0].ToString() + "')";
                    s.Execute(strSQLInsertStudent);
                    s.Execute(strSQLInsertStu_Maj);
                    Response.Write("<script language=javascript>alert('记录添加成功'); </script>;");
                }
                Response.Redirect("Manager.aspx");
            }
        }

        bool IfEmptyOrNull()
        {
            if (txt_Stu_Id.Text == "" || txt_Stu_Name.Text == "" || txt_Stu_Psd.Text == "")
            {
                return true;
            }
            else return false;
        }
    }