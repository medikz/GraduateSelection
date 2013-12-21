using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Man_Add_Sub : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //comboBox1.Items.Clear();
            string strSQL = "select Tea_Name from Teacher where Tea_Id != 'FFFFF'";
            Sql s = new Sql();
            DataTable dt = s.Select(strSQL);
            if (comboBox1.Items.Count == 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    comboBox1.Items.Add(dt.Rows[i][0].ToString());
                }
            }
            string strSQL1 = "select Tea_Id from Teacher where Tea_Name = '" + comboBox1.Text + "'";
            DataTable dt1 = s.Select(strSQL1);
            Label1.Text = dt1.Rows[0][0].ToString();
        }

        protected void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strSQL = "select Tea_ID from Teacher where Tea_Name = '" + comboBox1.Text + "'";
            Sql s = new Sql();
            DataTable dt = s.Select(strSQL);
            Label1.Text = dt.Rows[0][0].ToString();
        }

        bool IfEmptyOrNull()
        {
            if (txt_Sub_Id.Text == "" || txt_Sub_Name.Text == "" || comboBox1.Text == "")
            {
                return true;
            }
            else return false;
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
                string strSQL = "insert into Subject values('" + txt_Sub_Id.Text + "','" + txt_Sub_Name.Text + "','" + rxt_Sub_Info.Text + "','" + comboBox1.Text + "')";
                s.Execute(strSQL);
                Response.Write("<script language=javascript>alert('记录添加成功'); </script>;");
                Response.Redirect("Manager.aspx");
            }
        }

        protected void comboBox1_TextChanged(object sender, EventArgs e)
        {
            //string strSQL = "select Tea_Name from Teacher where Tea_Id = '" + comboBox1.Text + "'";
            //Sql s = new Sql();
            //DataTable dt = s.Select(strSQL);
            //Label1.Text = dt.Rows[0][0].ToString();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {

        }
}