using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
   public class NHANVIEN
    {
      public string  MANV                {get;set;}
      public string  TEN                 {get;set;}
      public string  USERNAME            {get;set;}
      public string  PASSWORD            {get;set;}
      public string  NGAYSINH            {get;set;}
      public Boolean  GIOITINH           {get;set;}
      public string  DIACHI              {get;set;}
      public string  SDT                 {get;set;}
      public DateTime  NGAYVAOLAM        {get;set;}
      public string  HINH                {get;set;}
      public int MAQUYEN { get; set; }
    }
}
