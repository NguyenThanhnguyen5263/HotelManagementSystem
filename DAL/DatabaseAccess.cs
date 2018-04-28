using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
   public class DatabaseAccess
    {
        string strConn = "Server =.\\SQLExpress;Database=QUANLYKHACHSAN;User Id = sa;pwd123456";
        protected SqlConnection conn = null;
        public void OpenConnection()
        {
            if (conn == null)
            {
                conn = new SqlConnection(strConn);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
           
        }
        public void CloseConection()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                    conn.Close();
            }
        }
    }
}
