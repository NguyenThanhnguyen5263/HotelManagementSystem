using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
   public class CHITIETPHIEUDATPHONG
    {
      public string MAPHIEUTHUE { get; set; }
      public string MAPHONG            { get; set; }
      public DateTime NGAYDANGKY       { get; set; }
      public DateTime NGAYCHECKIN      { get; set; }
      public DateTime NGAYCHECKOUT     { get; set; }
      public float DATCOC { get; set; }
    }
    
}
