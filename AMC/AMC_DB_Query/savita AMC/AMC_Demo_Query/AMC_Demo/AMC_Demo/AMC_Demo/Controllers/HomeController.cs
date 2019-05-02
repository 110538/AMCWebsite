using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AMC_Demo.Models;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Linq;
using System.Xml;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace AMC_Demo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult ErrorList()
        {
            ViewData["Message"] = "Your Error List page.";        
            ViewBag.ErrorMessage = "";
            DataSet ds = new DataSet();
            try
            {
                string conn = System.Configuration.ConfigurationManager.ConnectionStrings["AMC_DB_TestDB"].ConnectionString;
                SqlConnection cnn = new SqlConnection(conn);
                cnn.Open();
                SqlCommand dCmd = new SqlCommand("GetAmcErrorListSearchHistory", cnn);
                dCmd.CommandType = CommandType.StoredProcedure;               
                SqlDataAdapter da = new SqlDataAdapter(dCmd);
                ds.Clear();
                da.Fill(ds);
                cnn.Close();
                if (ds.Tables[0].Rows.Count == 0)
                {
                    ViewBag.ErrorMessage = "Search History Not Found";
                }
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "Search History Not Found";
                
            }          

            return View(ds);
        }
        [HttpPost]
        public IActionResult ErrorList(string Bid, string Biddate)
        {
            ViewData["Message"] = "Your Error List page.";
            ViewBag.ErrorMessage = "";
            DataSet ds = new DataSet();
            try
            {
                string conn = System.Configuration.ConfigurationManager.ConnectionStrings["AMC_DB_LIVE"].ConnectionString;
                SqlConnection cnn = new SqlConnection(conn);
               
                cnn.Open();               
                string Query = "with xmlnamespaces ('"+"http://schemahost.amcnetworks.com:8080/amcnesb/schemas"+ "' as NS1  )  SELECT top 5  x.*  FROM  (  VALUES   ('%FD083867%')  ) AS v (pattern)  CROSS APPLY  ( select  case when inner_query.Status2 = '' and len(inner_query.ErrorMessage) > 0 then 'Error' else inner_query.Status2 end as status,  inner_query.ErrorMessage,  inner_query.RecordedOn, inner_query.Bid, inner_query.Message,  inner_query.Event, inner_query.Source_System,inner_query.EventId,inner_query.ReqId  from  (  SELECT  case  when pref.value('(NS1:mssg/text())[1]', 'varchar(max)') = 'E' then 'Error'  else '' End as Status2, Logger.*,  cast(message.query('/NS1:root/NS1:body/error') as nvarchar(2000)) +  cast(message.query('/NS1:root/NS1:body/NS1:response/NS1:error') as nvarchar(2000)) +  replace(cast(message.query('/NS1:root/NS1:body/NS1:response/response/message') as nvarchar(max)),'<message>OK</message>','') ErrorMessage  from ESB_GENERAL.MessageLogger Logger  CROSS APPLY  Message.nodes('/NS1:root/NS1:body') AS Data(pref)    where (  (  CAST(Message as nvarchar(max)) LIKE  v.pattern  or  Bid LIKE  v.pattern  )                   )  and RecordedOn > '2018-10-09'  ) inner_query      ) AS x order by x.RecordedOn asc; ";
                string Query2 = "with xmlnamespaces ('" + "http://schemahost.amcnetworks.com:8080/amcnesb/schemas" + "' as NS1  )  SELECT  x.*  FROM  (  VALUES   ('%"+Bid+"%')  ) AS v (pattern)  CROSS APPLY  ( select  case when inner_query.Status2 = '' and len(inner_query.ErrorMessage) > 0 then 'Error' else inner_query.Status2 end as status,  inner_query.ErrorMessage,  inner_query.RecordedOn, inner_query.Bid, inner_query.Message,  inner_query.Event, inner_query.Source_System,inner_query.EventId,inner_query.ReqId  from  (  SELECT  case  when pref.value('(NS1:mssg/text())[1]', 'varchar(max)') = 'E' then 'Error'  else '' End as Status2, Logger.*,  cast(message.query('/NS1:root/NS1:body/error') as nvarchar(2000)) +  cast(message.query('/NS1:root/NS1:body/NS1:response/NS1:error') as nvarchar(2000)) +  replace(cast(message.query('/NS1:root/NS1:body/NS1:response/response/message') as nvarchar(max)),'<message>OK</message>','') ErrorMessage  from ESB_GENERAL.MessageLogger Logger  CROSS APPLY  Message.nodes('/NS1:root/NS1:body') AS Data(pref)    where (  (  CAST(Message as nvarchar(max)) LIKE  v.pattern  or  Bid LIKE  v.pattern  )                   )  and RecordedOn > '"+Biddate+"'  ) inner_query      ) AS x order by x.RecordedOn asc; ";

                SqlDataAdapter da = new SqlDataAdapter(Query2,cnn);
                da.SelectCommand.CommandTimeout = 0;
                ds.Clear();
                da.Fill(ds);
                cnn.Close();
                if (ds.Tables[0].Rows.Count == 0)
                {
                    ViewBag.ErrorMessage = "No Records Found";                   
                }
            }
            catch(Exception ex)
            {
                ViewBag.ErrorMessage = "No Records Found";
               
            }
            return View("ErrorListDisplay",ds);
        }

        
        public ActionResult MessageDetail(string filterName, string filterValue)
        {
            XDocument doc = XDocument.Parse(filterValue);
            return View("MessageDetailsPopUp", doc);
           
        }     

       
    }
}
