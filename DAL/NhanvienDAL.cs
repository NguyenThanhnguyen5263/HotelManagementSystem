using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
 public class NhanvienDAL: DatabaseAccess
    {
        public string getID(string username, string pass)
        {
            string id = "";
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from nhanvien where usernam = "+ username+"and pass = "+ pass;
            cmd.CommandType = CommandType.Text;


            return id;

       
        }
    }
}
