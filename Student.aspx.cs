using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


public partial class Student : System.Web.UI.Page
{
    void GetTeacher() 
    {
       
    }

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Share.username == "")
            {
               Response.Write("<script>window.alert('请先登录');</script>");
               // MessageBox.Show("请先登录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Response.Redirect("Login.aspx");
            }
            //dataGridView1.ReadOnly = true;
            Sql s = new Sql();
            string strSQL_selection1 = "select Selection.Sub_Id as 课题号,Subject.Sub_Name as 课题名,Teacher.Tea_name as 指导教师 from Selection,Subject,Teacher where Selection.Stu_ID ="
                + Share.username + " and Selection.Sub_Role = 1 and Selection.Sub_Id = Subject.Sub_ID and Selection.Tea_ID=Teacher.Tea_ID";
            DataTable dt_selection1 = s.Select(strSQL_selection1);
            GridView1.DataSource = dt_selection1.DefaultView;
            GridView1.DataBind();

            string strSQL_selection2 = "select Selection.Sub_Id as 课题号,Subject.Sub_Name as 课题名,Teacher.Tea_name as 指导教师 from Selection,Subject,Teacher where Selection.Stu_ID ="
                + Share.username + " and Selection.Sub_Role = 2 and Selection.Sub_Id = Subject.Sub_ID and Selection.Tea_ID=Teacher.Tea_ID" ;
            DataTable dt_selection2 = s.Select(strSQL_selection2);
            GridView2.DataSource = dt_selection2.DefaultView;
            GridView2.DataBind();


            string strSQL = "select Subject.Sub_Id as 课题号,Subject.Sub_Name as 课题名,Teacher.Tea_name as 指导教师 from Subject,Teacher where Subject.Tea_ID=Teacher.Tea_ID";
            DataTable dt = s.Select(strSQL);
            dataGridView1.DataSource = dt.DefaultView;
            dataGridView1.DataBind();

            if (!Page.IsPostBack)
            {
             Sql s_Tea = new Sql();
            string strSQL_Tea = "select * from Teacher";
            DataTable dt_Tea = s_Tea.Select(strSQL_Tea);
            DropDownList1.Controls.Clear();
            for (int lines = 0; lines < dt_Tea.Rows.Count; lines++)
            {
                //dataGridView1.DataSource = dt.DefaultView;
                //dataGridView1.DataBind();
                DropDownList1.Items.Add(new ListItem(dt_Tea.Rows[lines]["Tea_Name"].ToString(), dt_Tea.Rows[lines]["Tea_ID"].ToString()));
            }
            }
           
        }

        protected void dataGridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
             //int  i = Convert.ToInt32();
           // Share.path = dataGridView1.Rows[i].Cells[2].Text.ToString();
           // Stu_Sel frm = new Stu_Sel();
          //  Response.Redirect("Stu_Sel.aspx?Sub_Name="+Share.path+"");
        }

        protected void dataGridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            System.Web.UI.Control c = (System.Web.UI.Control)e.CommandSource;
            GridViewRow g = (GridViewRow)c.NamingContainer;
            Share.path = g.Cells[2].Text.ToString();
            Response.Redirect("Stu_Sel.aspx?Sub_Name=" + Share.path + "");
        }

        protected void dataGridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
           
        }
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            //string subname = GridView1.Rows[0].Cells[1].Text.ToString();
            //Response.Redirect("Stu_Sel.aspx?Sub_Role=1&Sub_Name="+subname);
        }
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
           // string subname = GridView2.Rows[0].Cells[1].Text.ToString();
           // string url = "Stu_Sel.aspx?Sub_Role=2&Sub_Name=" + subname;
           // Response.Redirect(url);
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sql s = new Sql();
            //string strSQL = "select Sub_Id as 课题号,Sub_Name as 课题名 from Subject where Tea_Id ="+DropDownList1.SelectedValue;
            string strSQL;
            if (DropDownList1.SelectedValue !="0")
            {
                strSQL = "select Subject.Sub_Id as 课题号,Subject.Sub_Name as 课题名,Teacher.Tea_name as 指导教师 from Subject,Teacher where Subject.Tea_ID=Teacher.Tea_ID and Subject.Tea_Id ='" + DropDownList1.SelectedValue + "'";
                
            }
            else
            {
                strSQL = "select Subject.Sub_Id as 课题号,Subject.Sub_Name as 课题名,Teacher.Tea_name as 指导教师 from Subject,Teacher where Subject.Tea_ID=Teacher.Tea_ID";
            }
            
            DataTable dt = s.Select(strSQL);
            dataGridView1.DataSource = dt.DefaultView;
            dataGridView1.DataBind();
        }
}
