using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAL;

namespace BLL
{
   public class PHONGBLL
    {
        PhongDAL phongDAL = new PhongDAL();
        public List<PHONG> Laydanhsachphong()
        {
            return phongDAL.Laydanhsachphong();               
        }
        
    }
}
