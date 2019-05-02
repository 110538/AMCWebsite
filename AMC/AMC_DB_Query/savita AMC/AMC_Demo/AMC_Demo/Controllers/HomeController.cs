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
using Microsoft.AspNetCore;
using static System.Net.WebRequestMethods;
using Microsoft.AspNetCore.Http;
using System.Text;
using Microsoft.AspNetCore.Hosting;

namespace AMC_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public HomeController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
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
            DataTable dt = new DataTable();
            dt = ReadHistoricalFileData();
            ds.Tables.Add(dt);
         //   ds.Tables.Add();
            ////////try
            ////////{
              
            ////////    string conn = System.Configuration.ConfigurationManager.ConnectionStrings["AMC_DB_Local"].ConnectionString;
            ////////    SqlConnection cnn = new SqlConnection(conn);
            ////////    cnn.Open();
            ////////    DataTable table = new DataTable();
            ////////    DataColumn column;
            ////////    DataRow row;
            ////////    DataView view;
                
            ////////    SqlCommand dCmd = new SqlCommand(@"SELECT  top 15 [Bid],[RecordedOn]
            ////////    from[MessageLoggerSearchHistory] group by EnteredDate, [Bid],RecordedOn  order by EnteredDate desc", cnn);

            ////////    dCmd.CommandType = CommandType.Text;
            ////////    SqlDataAdapter da = new SqlDataAdapter(dCmd);
            ////////    ds.Clear();
            ////////    da.Fill(ds);
            ////////    cnn.Close();
            ////////}
            ////////catch (Exception ex)
            ////////{
            ////////    ViewBag.ErrorMessage = "Search History Not Found";
            ////////    return View();
            ////////}          

            return View(ds);
        }
        [HttpPost]
        public IActionResult ErrorList(string Bid, string Biddate)
        {

            string[] bidDate;
            if (Biddate.Contains('T'))
                bidDate = Biddate.Split('T');
            else
                bidDate = Biddate.Split(' ');

            string[] datepart = bidDate[0].Split('-');

            if (datepart[0].Length != 4)
            {
                bidDate[0] = datepart[2] + "-" + datepart[1] + "-" + datepart[0];
            }

            Biddate = bidDate[0] + " " + bidDate[1];

            ViewData["Message"] = "Your Error List page.";
            ViewBag.ErrorMessage = "";
            DataSet ds = new DataSet();
            try
            {
                string conn = System.Configuration.ConfigurationManager.ConnectionStrings["AMC_DB_TestDB"].ConnectionString;
                SqlConnection cnn = new SqlConnection(conn);
                cnn.Open();
              //  string query = QueryString();
                string query = QueryString(Bid, Biddate);
                //SqlCommand dCmd = new SqlCommand("GetAmcErrorList", cnn);
                SqlCommand dCmd = new SqlCommand(query, cnn);
                dCmd.CommandType = CommandType.Text;
                //dCmd.Parameters.Add(new SqlParameter("@Bid", Bid));
                //dCmd.Parameters.Add(new SqlParameter("@Biddate", Biddate));
                SqlDataAdapter da = new SqlDataAdapter(dCmd);                          
                ds.Clear();
                da.Fill(ds);
                cnn.Close();
                //   Microsoft.AspNetCore.Session("Tissues", ds.Tables[0]);
                //     HttpContext.Session.SetString("xyzperson",ds.Tables[0]);
                System.IO.MemoryStream stream = new System.IO.MemoryStream();
                System.Runtime.Serialization.IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                formatter.Serialize(stream, ds); // dtUsers is a DataTable

                byte[] bytes = stream.GetBuffer();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    if (Convert.ToString(row[0]) == "Error")
                    { row[1]=ReadErrorMessages(row[4].ToString()); }
                 
                }

                if (ds.Tables.Count>0)
                {
                    SaveDataTemp(Bid, Biddate);
                 //   SaveHistory(Bid, Biddate);
                }
                HttpContext.Session.Set("xyzperson", bytes);
                //  HttpContext.Connection.Session[""] = "";
                //    Http.Connect.Current.session["xyzperson"] = p;
                // HttpContext.Session["xyzperson"] = "";
                //var tableList = new List<ErrorData>();
                //int numRows = ds.Tables[0].Rows.Count;
                //for (int i = 0; i < numRows; i++)
                //{
                //    string tblName = ds.Tables[0].Rows[i].Field<string>("TableName");
                //    tableList.Add(new ErrorData() { TableName = tblName };
                //}


                //var das = ds.Tables[0].AsEnumerable();
                // return ConvertToDictionary(ds.Tables[0]);
            }
            catch(Exception ex)
            {
                ViewBag.ErrorMessage = ex.ToString();
                return View();            }
            return View("ErrorListDisplay",ds);
        }

        private  void SaveDataTemp(string BID, string Biddate)
        {
            //string path=HttpContext.Request.("~/Example.txt");
            foreach (DataRow row in ReadHistoricalFileData().Rows)
            {
                if (row[0].ToString() == BID && row[1].ToString() == Biddate)
                    return;
            }
            string webRootPath = _hostingEnvironment.WebRootPath;
            string filepath = _hostingEnvironment.ContentRootPath+ @"\CSVData\HistorySave.csv";
            var csv = new StringBuilder();

            //in your loop
            var first = BID;
            var second = Biddate;
            //Suggestion made by KyleMit
            var newLine = string.Format("{0},{1}", first, second);
            csv.AppendLine(newLine);

            //after your loop
           // System.IO.File.WriteAllText(filepath, csv.ToString());
            System.IO.File.AppendAllLines(filepath,new[] { newLine });
           
        }

        private DataTable ReadHistoricalFileData()
        {
            //string path=HttpContext.Request.("~/Example.txt");

            string webRootPath = _hostingEnvironment.WebRootPath;
            string filepath = _hostingEnvironment.ContentRootPath + @"\CSVData\HistorySave.csv";
            var csv = new StringBuilder();

            DataTable dt = new DataTable();
            using (StreamReader sr = new StreamReader(filepath))
            {
                string[] headers = sr.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    dt.Columns.Add(header);
                }
                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(',');
                    if (rows.Length == 2)
                    {
                        DataRow dr = dt.NewRow();
                        for (int i = 0; i < headers.Length; i++)
                        {
                            dr[i] = rows[i];
                        }

                        dt.Rows.Add(dr);
                    }
                }

            }
            return dt;
        }

        private void SaveHistory(string BID,string Biddate)
        {
         string insertquery=   string.Format("insert into [MessageLoggerSearchHistory](Bid,RecordedOn,EnteredDate) values('{0}','{1}',getdate())", BID, Biddate);
         string selectquery = string.Format("select count(1) from  [MessageLoggerSearchHistory] where Bid='{0}' and RecordedOn='{1}'", BID, Biddate);


            string conn = System.Configuration.ConfigurationManager.ConnectionStrings["AMC_DB_Local"].ConnectionString;
            SqlConnection cnn = new SqlConnection(conn);
            cnn.Open();
            SqlCommand sCmd = new SqlCommand(selectquery, cnn);
            SqlCommand iCmd = new SqlCommand(insertquery, cnn);
            sCmd.CommandType = CommandType.Text;
            iCmd.CommandType = CommandType.Text;

            if (sCmd.ExecuteScalar().ToString()=="0")
            { iCmd.ExecuteNonQuery(); }

        }

        public string ReadErrorMessages(string filterName)
        {  string errorMessage = string.Empty;
            string message = string.Empty;
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(filterName);
                XmlNodeList errortags = doc.DocumentElement.GetElementsByTagName("error");
                for (int i = 0; i < errortags.Count; i++)
                {
                    message = errortags[i].InnerXml;
                    errorMessage += message.Substring(0, message.IndexOf("'.")<2?(message.Length>50?50:message.Length) : message.IndexOf("'."));
                }
            }
            catch { }
            errorMessage += readErrorMessage(filterName);
            return errorMessage;

        }

        private string readErrorMessage(string filterName)
        {
            string errorMessage = string.Empty;
            string message = string.Empty;
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(filterName);
                XmlNodeList errortags = doc.DocumentElement.GetElementsByTagName("message");
                for (int i = 0; i < errortags.Count; i++)
                {
                    if (i>0 && errortags[0].InnerXml.ToLower() == "error")
                    {
                        errorMessage += errortags[i].InnerXml +",";
                    }
                  //  errorMessage += message.Substring(0, message.IndexOf("'.") < 2 ? (message.Length > 50 ? 50 : message.Length) : message.IndexOf("'."));
                }
            }
            catch { }
            return errorMessage;

        }

        public ActionResult MessageDetail(string filterName, string filterValue)
        {
            var re = HttpContext.Session.Get("xyzperson");
            //DataTable dt=new DataTable( HttpContext.Session.Get("xyzperson").ToString());
           // filterValue = filterValue.ToString("dd");

            System.IO.MemoryStream stream = new System.IO.MemoryStream(re);
            System.Runtime.Serialization.IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

            DataSet ds = (DataSet)formatter.Deserialize(stream);          // var res=dt.Rows.Cast<DataRow>().Field<string>("RecordedOn").Where(x=> x.RecordedOn == filterValue)
            var filterValues = ds.Tables[0].Rows.OfType<dynamic>().Where(x => x[9].ToString() == filterValue).Select(x => x[4]).FirstOrDefault();
            //////var res = ds.Tables[0].Rows[0][9];
            //////var res6 = ds.Tables[0].Rows[1][4];
            //  var reer = res1.row.Field<int>("Item1");
            // int[] allItems = dt.AsEnumerable().Select(r => r.Field<int>("Item1")).ToArray();
            // res1.Select(x => x.itemarray);
            //  var res = dt.Rows.OfType<DataSet>().Where(x => x..ToStrring() == filterValue);

            XDocument doc = XDocument.Parse(filterValues.ToString());
            return View("MessageDetailsPopUp", doc);
           
        }

        public string QueryString()
        {
            string query = @" ; with xmlnamespaces('http://schemahost.amcnetworks.com:8080/amcnesb/schemas' as NS1)

 SELECT

  x.*

FROM

  (

    VALUES


('%361366779527%')

       ) AS v(pattern)

  CROSS APPLY

  (  --your query



             select

                     case when inner_query.Status2 = '' and len(inner_query.ErrorMessage) > 0 then 'Error' else inner_query.Status2 end as status,

                     inner_query.ErrorMessage,

                     inner_query.RecordedOn, inner_query.Bid, inner_query.Message,

                     inner_query.Event, inner_query.Source_System,inner_query.EventId,inner_query.ReqId

               from

              (

                     SELECT

                     case

                     when pref.value('(NS1:mssg/text())[1]', 'varchar(max)') = 'E' then 'Error'

                            else '' End as Status2, Logger.*,

                           cast(message.query('/NS1:root/NS1:body/error') as nvarchar(max)) +

                           cast(message.query('/NS1:root/NS1:body/NS1:response/NS1:error') as nvarchar(max)) +

                            replace(cast(message.query('/NS1:root/NS1:body/NS1:response/response/message') as nvarchar(max)), '<message>OK</message>', '') ErrorMessage

                     from ESB_GENERAL.MessageLogger Logger

                     CROSS APPLY  Message.nodes('/NS1:root/NS1:body') AS Data(pref)




                     where(

                            (

                                   CAST(Message as nvarchar(max)) LIKE  v.pattern

                                   or

                                   Bid LIKE  v.pattern

                            ))

            and RecordedOn > '2019-04-22 07:40:19.547'

              ) inner_query





  ) AS x";
            return query;
}

        public string QueryString(string Bid, string Biddate)
        {
            string query = string.Format(@";with xmlnamespaces ('http://schemahost.amcnetworks.com:8080/amcnesb/schemas' as NS1)

SELECT  

  x.*,ROW_NUMBER() OVER(ORDER BY RecordedOn ASC) AS RowNumber

FROM

  (

    VALUES


('%{0}%') 

       ) AS v (pattern)

  CROSS APPLY

  (  -- your query



              select

                     case when inner_query.Status2 = '' and len(inner_query.ErrorMessage) > 0 then 'Error' else inner_query.Status2 end as status,

                     inner_query.ErrorMessage,

                     inner_query.RecordedOn, inner_query.Bid, inner_query.Message,

                     inner_query.Event, inner_query.Source_System,inner_query.EventId,inner_query.ReqId

               from

              (

                     SELECT

                     case

                     when pref.value('(NS1:mssg/text())[1]', 'varchar(max)') = 'E' then 'Error'

                            else '' End as Status2, Logger.*,

                           cast(message.query('/NS1:root/NS1:body/error') as nvarchar(max)) +

                           cast(message.query('/NS1:root/NS1:body/NS1:response/NS1:error') as nvarchar(max
						   )) +

                            replace(cast(message.query('/NS1:root/NS1:body/NS1:response/response/message') as nvarchar(max)),'<message>OK</message>','') ErrorMessage

                     from ESB_GENERAL.MessageLogger Logger

                     CROSS APPLY  Message.nodes('/NS1:root/NS1:body') AS Data(pref)

               

                     where (

                            (

                                   CAST(Message as nvarchar(max)) LIKE  v.pattern

                                   or

                                   Bid LIKE  v.pattern

                            )                   )

            and RecordedOn >'{1}'

              ) inner_query





  ) AS x

",  Bid,  Biddate); 
            return query;
        }


       
        //////[HttpPost]
        //////public ActionResult MessageDetail()
        //////{
        //////    XDocument doc = XDocument.Parse(filterValue.ToString());
        //////    return View("MessageDetailsPopUp", doc);
        //////  // return View();
        //////}


        //public static class CommonMethod
        //{
        //    public static List<T> ConvertToList<T>(DataTable dt)
        //    {
        //        var columnNames = dt.Columns.Cast<DataColumn>().Select(c => c.ColumnName.ToLower()).ToList();
        //        var properties = typeof(T).GetProperties();
        //        return dt.AsEnumerable().Select(row => {
        //            var objT = Activator.CreateInstance<T>();
        //            foreach (var pro in properties)
        //            {
        //                if (columnNames.Contains(pro.Name.ToLower()))
        //                {
        //                    try
        //                    {
        //                        pro.SetValue(objT, row[pro.Name]);
        //                    }
        //                    catch (Exception ex) { }
        //                }
        //            }
        //            return objT;
        //        }).ToList();
        //    }
        //}
    }
}
