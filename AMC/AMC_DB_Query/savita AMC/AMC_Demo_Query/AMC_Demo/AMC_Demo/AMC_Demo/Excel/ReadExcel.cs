using AMC_Demo.Models;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AMC_Demo.APICalls;
using System.Configuration;

namespace AMC_Demo.Excel
{
    public class ReadExcel
    {
       
        public static void UpdateDBFromExcel()
        {
           
            FileInfo file = new FileInfo(ConfigurationManager.AppSettings["ExcelPath"]);
            using (ExcelPackage package = new ExcelPackage(file))
            {
                ExcelData excelData = GetDataFromExcel(package);
                for (int i = 1; i <= excelData.excelWorkbook.Worksheets.Count; i++)
                {
                    SheetData sheetData = GetExcelSheetData(i, excelData.excelWorkbook);
                    if (sheetData.excelSheetName == "RLAPI" || sheetData.excelSheetName == "MPAPI" || sheetData.excelSheetName == "WOPAPIMASTER")
                    {
                        List<SheetValue> sheetValues = ReadDataFromSheet(sheetData);
                        ApiCall.GetDataFromAPI(sheetData, sheetValues);
                    }
                }
            }
        }
        public static ExcelData GetDataFromExcel(ExcelPackage package)
        {
                ExcelData excelData = new ExcelData();
                excelData.excelWorkbook =  package.Workbook;
                return excelData;
        }

        public static SheetData GetExcelSheetData(int sheetNo, ExcelWorkbook excelWorkbook)
        {
            SheetData sheetData = new SheetData();
            sheetData.excelWorksheet = excelWorkbook.Worksheets[sheetNo];
            sheetData.excelSheetName = sheetData.excelWorksheet.Name;
            return sheetData;
        }

        public static List<SheetValue> ReadDataFromSheet(SheetData sheetData)
        {
            List<SheetValue> sheetValues = new List<SheetValue>();

            int rowCount = sheetData.excelWorksheet.Dimension.Rows;
            int ColCount = sheetData.excelWorksheet.Dimension.Columns;
            for (int row = 2; row <= rowCount; row++)
            {
                List<string> colValues = new List<string>();
                //var list =  sheetData.excelWorksheet.Cells.ToList();
                for (int col = 1; col <= ColCount; col++)
                {
                    // This is just for demo purposes
                    colValues.Add(sheetData.excelWorksheet.Cells[row, col].Value.ToString());
                }
                colValues.Add(string.Empty);
                sheetValues.Add(new SheetValue() {
                    excelSheetName = sheetData.excelSheetName,
                    rowNo = row,
                    cellValues = colValues
                });
            }

            return sheetValues;
        }
    }
}
