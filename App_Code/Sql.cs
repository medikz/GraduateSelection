using System;
using System.Collections.Generic;

using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public class Sql
    {
        public Sql()
        {

        }
      static string conn = @"Data Source=.\SQLEXPRESS;Initial Catalog=a0406133454;Integrated Security=True";
     //static string conn = @"data source=118.126.8.133,1433;User ID=a0406133454;pwd=82427409;Initial Catalog=a0406133454";
        SqlConnection myconn = new SqlConnection(conn);

        public DataTable Select(string strSQL)
        {
            myconn.Close();
            myconn.Open();
            SqlDataAdapter dpt = new SqlDataAdapter(strSQL,myconn);
            DataTable dt = new DataTable();
            //增加了对dt查询为空的时的判断，不然出错。
            DataSet ds = new DataSet();
            dpt.Fill(ds, "dt");
            //dpt.Fill(dt);
            dt = ds.Tables["dt"];
            myconn.Close();
            return dt;
            
        }

        public void Execute(string strSQL)
        {


            myconn.Close();
            myconn.Open();
            SqlCommand cmd = new SqlCommand(strSQL, myconn);
            cmd.ExecuteNonQuery();
            myconn.Close();

        }

    }
