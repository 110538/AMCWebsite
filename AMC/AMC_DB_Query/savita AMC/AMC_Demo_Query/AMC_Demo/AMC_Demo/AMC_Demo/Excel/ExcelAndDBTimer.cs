using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AMC_Demo.Excel
{
   

    public class ExcelAndDBTimer
    {
       public static async Task startTimerAsync()
        {
            bool DoProcessing = true;

            while (DoProcessing)
            {
                // Do work here
                //await ReadExcel.UpdateDBFromExcel();
                Thread.Sleep(1000);
            }
        }
    }
}
