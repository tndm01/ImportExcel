using System;
using System.Collections.Generic;
using System.ComponentModel;
using MyTeamApp.Controller;
using Excel = Microsoft.Office.Interop.Excel;

namespace MyTeamApp
{
    internal class MyExcel
    {
        public static string DB_PATH = @"";
        public static BindingList<Employee> EmpList = new BindingList<Employee>();
        private static Excel.Workbook MyBook = null;
        private static Excel.Application MyApp = null;
        private static Excel.Worksheet MySheet = null;
        private static int lastRow = 0;

        public static void InitializeExcel()
        {
            MyApp = new Excel.Application();
            MyApp.Visible = false;
            MyBook = MyApp.Workbooks.Open(DB_PATH);
            MySheet = (Excel.Worksheet)MyBook.Sheets[1]; // Explict cast is not required here
            lastRow = MySheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;
        }

        public static BindingList<Employee> ReadMyExcel()
        {
            EmpList.Clear();
            for (int index = 8; index <= lastRow - 5; index++)
            {
                System.Array MyValues = (System.Array)MySheet.get_Range("C" + index.ToString(), "J" + index.ToString()).Cells.Value;
                try
                {
                    EmpList.Add(new Employee
                    {
                        GiaVe = MyValues.GetValue(1, 1).ToString(),
                        NgayBan = MyValues.GetValue(1, 3).ToString(),
                        MaTaiKhoan = MyValues.GetValue(1,4).ToString(),
                        MaETag = MyValues.GetValue(1, 5).ToString(),
                        SoXe = FormatSoXe(MyValues.GetValue(1,6).ToString()),
                        NgayBatDau = MyValues.GetValue(1, 7).ToString(),
                        NgayKetThuc = MyValues.GetValue(1, 8).ToString(),
                    });
                }
                catch {}
            }

            foreach(var item in EmpList)
            {
                EtagThangController.InsertEtag(item);
            }

            return EmpList;
        }

        private static string FormatSoXe(string soXe)
        {
            soXe.Replace(",", "");
            soXe.Replace(".", "");
            soXe.Trim();
            string result = "";
            if(soXe.EndsWith("T") || soXe.EndsWith("X"))
            {
                result = soXe.Substring(0,soXe.Length - 1);
            }
            return result;
        }

        public static void WriteToExcel(Employee emp)
        {
            try
            {
                //lastRow += 1;
                //MySheet.Cells[lastRow, 1] = emp.Name;
                //MySheet.Cells[lastRow, 2] = emp.Employee_ID;
                //MySheet.Cells[lastRow, 3] = emp.Email_ID;
                //MySheet.Cells[lastRow, 4] = emp.Number;
                EmpList.Add(emp);
                MyBook.Save();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Employee> FilterEmpList(string searchValue, string searchExpr)
        {
            List<Employee> FilteredList = new List<Employee>();
            switch (searchValue.ToUpper())
            {
                //case "NAME":
                //    FilteredList = EmpList.ToList().FindAll(emp => emp.Name.ToLower().Contains(searchExpr));
                //    break;
                //case "MOBILE_NO":
                //    FilteredList = EmpList.ToList().FindAll(emp => emp.Number.ToLower().Contains(searchExpr));
                //    break;
                //case "EMPLOYEE_ID":
                //    FilteredList = EmpList.ToList().FindAll(emp => emp.Employee_ID.ToLower().Contains(searchExpr));
                //    break;
                //case "EMAIL_ID":
                //    FilteredList = EmpList.ToList().FindAll(emp => emp.Email_ID.ToLower().Contains(searchExpr));
                //    break;
                //default:
                //    break;
            }
            return FilteredList;
        }

        public static void CloseExcel()
        {
            MyBook.Saved = true;
            MyApp.Quit();
        }
    }
}