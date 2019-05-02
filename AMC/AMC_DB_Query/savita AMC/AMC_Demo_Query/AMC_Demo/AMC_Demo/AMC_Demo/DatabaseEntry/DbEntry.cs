using AMC_Demo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMC_Demo.DatabaseEntry
{
    public class DbEntry
    {
        public static void UpdateDataBaseValues(ApiJsonResult apiJsonResult, SheetData sheetData)
        {
            var sheetName = sheetData.excelSheetName;
            using (var dbContext = new AMCDbContext())
            {
                if(dbContext.devOpsStatusTables.Any(dops => dops.UI == sheetName))
                {
                    var devOpsDetails = dbContext.devOpsStatusTables.Where(x => x.UI == sheetName).First();
                    devOpsDetails.Testing = apiJsonResult.Result;
                    dbContext.Entry(devOpsDetails).State = EntityState.Modified;
                    dbContext.SaveChanges();
                }
                else
                {
                    var devOpsDetails = new DevOpsStatusTable();
                    devOpsDetails.UI = sheetName;
                    devOpsDetails.Testing = apiJsonResult.Result;
                    dbContext.Entry(devOpsDetails).State = EntityState.Added;
                    dbContext.SaveChanges();
                }
            }
        }
    }
}
