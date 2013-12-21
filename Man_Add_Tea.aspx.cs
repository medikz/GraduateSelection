using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

    public partial class Man_Add_Tea : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cmb_Tea_Role.Items.Add("一般");
            cmb_Tea_Role.Items.Add("管理员");
            cmb_Tea_Role.Text = "一般";
            if (cmb_Tea_Prof.Items.Count == 0)
            {
                cmb_Tea_Prof.Items.Add("讲师");
                cmb_Tea_Prof.Items.Add("副教授");
                cmb_Tea_Prof.Items.Add("教授");
                cmb_Tea_Prof.Items.Add("高级工程师");
                cmb_Tea_Prof.Items.Add("助教");
                cmb_Tea_Prof.Items.Add("研究员");
                cmb_Tea_Prof.Text = "讲师";
            }
            Sql s = new Sql();
            string strSQLSelectMaj_No = "select * from Major";
            DataTable dt = s.Select(strSQLSelectMaj_No);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmb_Tea_Maj.Items.Add(dt.Rows[i][1].ToString());
            }
            if (txt_Tea_Id.Text == "")
            {
                txt_Tea_Id.Text = Request.QueryString["Tea_Id"];
                txt_Tea_Name.Text = Request.QueryString["Tea_Name"];
                txt_Tea_QQ.Text = Request.QueryString["Tea_QQ"];
                txt_Tea_Email.Text = Request.QueryString["Tea_Email"];
                txt_Tea_Tel.Text = Request.QueryString["Tea_Tel"];
                txt_Tea_Psd.Text = Request.QueryString["Tea_Psd"];
                //cmb_Tea_Role.Text = Request.QueryString["Tea_Role"];
                cmb_Tea_Prof.Text = Request.QueryString["Tea_Prof"];
                cmb_Tea_Maj.Text = Request.QueryString["Maj_No"];
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
                string strSQLSelectMaj_Name = "select Maj_No from Major where Maj_Name = '" + cmb_Tea_Maj.Text + "'";
                DataTable dt = s.Select(strSQLSelectMaj_Name);

                string strSQLSelectStu_Id = "select * from Tea_Maj where Tea_Id = '" + txt_Tea_Id.Text + "'";
                DataTable dts = s.Select(strSQLSelectStu_Id);
                if (dts.Rows.Count != 0)
                {
                    string strsql1 = "update Teacher set Tea_Name='" + txt_Tea_Name.Text + "',Tea_QQ='" + txt_Tea_QQ.Text + "',Tea_Email='" + txt_Tea_Email.Text + "',Tea_Psd='" + txt_Tea_Psd.Text + "',Tea_Tel='" + txt_Tea_Tel.Text + "',Tea_Role='" + Tea_role(cmb_Tea_Role.Text) + "',Tea_Prof='" + cmb_Tea_Prof.SelectedItem.ToString() + "' where Tea_Id = '" + txt_Tea_Id.Text + "'";
                    string strsql2 = "update Tea_Maj set Maj_No='" + dt.Rows[0][0].ToString() + "' where Tea_Id = " + txt_Tea_Id.Text + "";
                    s.Execute(strsql1);
                    s.Execute(strsql2);
                }
                else
                {
                    string strSQLInsertTeacher = "insert into Teacher values ('" + txt_Tea_Id.Text + "','" + txt_Tea_Name.Text + "','" + txt_Tea_QQ.Text + "','" + txt_Tea_Email.Text + "','" + txt_Tea_Tel.Text + "','" + cmb_Tea_Prof.Text + "','" + Tea_role(cmb_Tea_Role.Text) + "','" + txt_Tea_Psd.Text + "')";
                    string strSQLInsertTea_Maj = "insert into Tea_Maj values ('" + txt_Tea_Id.Text + "','" + dt.Rows[0][0].ToString() + "')";

                    s.Execute(strSQLInsertTeacher);
                    s.Execute(strSQLInsertTea_Maj);
                    Response.Write("<script language=javascript>alert('记录添加成功'); </script>;");
                }
                Response.Redirect("Manager.aspx");
            }
        }

        bool IfEmptyOrNull()
        {
            if (txt_Tea_Id.Text == "" || txt_Tea_Name.Text == "" || txt_Tea_Psd.Text == "")
            {
                return true;
            }
            else return false;
        }

        int Tea_role(string path)
        {
            int flag = 3;
            switch (path)
            {
                case "一般":
                    flag = 1;
                    break;
                case "管理员":
                    flag = 0;
                    break;
            }
            return flag;
        }
    }