using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OfficeOpenXml;
using AMC_Demo.Excel;
using AMC_Demo.Models;
using System.IO;
using OpenJobScheduler;

namespace AMC_Demo.Controllers
{
    public class AMCDevOpsController : Controller
    {
        public IActionResult Index()
        {
            //ReadExcel.UpdateDBFromExcel();

            return View();
        }

        [HttpPost]
        public JsonResult getDevOpsStatus()
        {
            ReadExcel.UpdateDBFromExcel();
            using (var context = new AMCDbContext())
            {
                if (context.devOpsStatusTables.Count() > 0)
                {
                    return Json(new
                    {
                        Result = true,
                        Message = context.devOpsStatusTables.Select(x=> new { x.UI, x.Developement, x.Testing, x.Staging, x.Production}).ToList()
                    });
                }
                else
                {
                    return Json(new
                        {
                            Result = false,
                            Message = "No Values in Table"
                        });
                }
            }
        }
    }
}