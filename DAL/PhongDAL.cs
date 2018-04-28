using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DTO;

namespace DAL
{
   public class PhongDAL:DatabaseAccess
    {
        /// <summary>
        /// LẤY DANH SÁCH TẤT CẢ CÁC PHÒNG
        /// </summary>
        /// <returns></returns>
        public List<PHONG> Laydanhsachphong()
        {
            List<PHONG> dsphong = new List<PHONG>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "Select * from PHONG";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string IDPhong =reader.GetString(0);
                string Tenphong = reader.GetString(1);
                string IDLoaiphong = reader.GetString(2);
                string IDTinhtrangphong = reader.GetString(3);
                PHONG pHONG = new PHONG();
                pHONG.MAPHONG = IDPhong;
                pHONG.TENPHONG = Tenphong;
                pHONG.MALOAI = IDLoaiphong;
                pHONG.MATINHTRANG = IDTinhtrangphong;
                dsphong.Add(pHONG);
            }
            return dsphong;
        }
    }
}
