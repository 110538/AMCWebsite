using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OfficeOpenXml;

namespace AMC_Demo.Models
{
    public class ExcelData
    {
        public ExcelWorkbook excelWorkbook { get; set; }
    }

    public class SheetData
    {
        public ExcelWorksheet excelWorksheet { get; set; }
        public string excelSheetName { get; set; }
    }

    public class SheetValue
    {
        public SheetValue()
        {
            cellValues = new List<string>();
        }
        public string excelSheetName { get; set; }
        public int rowNo { get; set; }
        public List<string> cellValues { get; set; } 
    }

}
