using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyTeamApp
{
    public class Employee
    { 
        public string MaETag { get; set; }
        public string GiaVe { get; set; }
        public string MaLoaiVe { get; set; }
        public string MaTaiKhoan { get; set; }
        public string SoXe { get; set; }
        public string NgayBatDau { get; set; }
        public string NgayKetThuc { set; get; }
        public string MaNhanVien { get; set; }
        public string NgayBan { get; set; }
    }

    class EmpConstants
    {
        private const string DOMAIN_NAME = "xyz.com";
    }
}
