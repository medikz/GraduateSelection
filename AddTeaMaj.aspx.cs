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

public partial class AddTeaMaj : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAddMaj_Click(object sender, EventArgs e)
    {
        Sql s = new Sql();
        string strSQLSelectTea_No = "select * from Teacher";
        DataTable dt = s.Select(strSQLSelectTea_No);
        for (int i = 0; i < dt.Rows.Count; i++)
        {

            string strSQLInsertTeaMaj = "insert into Tea_Maj(Tea_Id,	Maj_No) values ('"+ dt.Rows[i][0].ToString()+ "','0')";
            s.Execute(strSQLInsertTeaMaj); 
        }

    }
}
