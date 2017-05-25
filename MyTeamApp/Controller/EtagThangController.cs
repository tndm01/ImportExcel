using System;
using System.Globalization;
using System.Windows.Forms;
using MyTeamApp.EntityFramework;

namespace MyTeamApp.Controller
{
    public static class EtagThangController
    {
        public static void InsertEtag(Employee emp)
        {
            try
            {
                DateTime ngayBan = DateTime.Parse(emp.NgayBan, CultureInfo.CreateSpecificCulture("fr-FR"));
                DateTime ngayBatDau = DateTime.Parse(emp.NgayBatDau, CultureInfo.CreateSpecificCulture("fr-FR"));
                DateTime ngayKetThuc = DateTime.Parse(emp.NgayKetThuc, CultureInfo.CreateSpecificCulture("fr-FR"));
                using (var entity = new ImportEntities())
                {
                    var rs = entity.sp_SUP_InsertEtagThang(emp.MaETag,
                        emp.GiaVe,
                        emp.MaLoaiVe = "2",
                        emp.SoXe,
                        ngayBatDau,
                        ngayKetThuc,
                        emp.MaNhanVien = "",
                        ngayBan);
                }
            }
            catch(Exception ex) {
                throw ex;
            }
        }

        public static void ExportEtagThang()
        {

        }
    }
}