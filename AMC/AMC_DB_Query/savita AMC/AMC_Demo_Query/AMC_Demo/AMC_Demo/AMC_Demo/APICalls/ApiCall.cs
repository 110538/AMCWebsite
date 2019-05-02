using AMC_Demo.DatabaseEntry;
using AMC_Demo.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Xml;

namespace AMC_Demo.APICalls
{
    public class ApiCall
    {

        public static ApiJsonResult MakeGetCall(string url, string contentType, string headers,string message, List<ApiJsonResult> apiJsonResults = null)
        {
            var list = GetKeyValuePairs(contentType, headers);
            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);

            foreach (var item in list)
            {
                if (item.Key == "Authorization")
                {
                    var json = ParseJsonString(apiJsonResults.FirstOrDefault().Message);
                    request.AddHeader(item.Key, item.Value + " "+json.access_token);
                }
                else if (item.Key == "auth2")
                {
                    var json = ParseJsonString(apiJsonResults.LastOrDefault().Message);
                    request.AddHeader(item.Key, item.Value + " " + json.token);
                }
                else
                {
                    request.AddHeader(item.Key, item.Value);
                }
            }
            //request.AddHeader("Cache-Control", "no-cache");
            //request.AddHeader(contentType, headers);
            IRestResponse response = client.Execute(request);
            if (response.ResponseStatus == ResponseStatus.Completed && response.StatusCode == HttpStatusCode.OK)
            {
                if(response.ContentType == "application/xml")
                {
                    return new ApiJsonResult { Result = true, Message = ConvertToJson(response.Content) };
                }
                    
                return new ApiJsonResult { Result = true, Message = response.Content };
            }
            else
            {
                return new ApiJsonResult { Result = false, Message = "Failed to get data from server" };
            }
        }


        public static ApiJsonResult MakePostCall(string url, string contentType, string headers, string message, ApiJsonResult jsonResult= null)
        {
            var list = GetKeyValuePairs(contentType, headers);
            var client = new RestClient(url);
            var request = new RestRequest(Method.POST);
            foreach (var item in list)
            {
                if (item.Key == "Authorization")
                {
                    var json = ParseJsonString(jsonResult.Message);
                    request.AddHeader(item.Key, item.Value + " " + json.access_token);
                }
                else
                {
                    request.AddHeader(item.Key, item.Value);
                }
            }
            //request.AddHeader("Cache-Control", "no-cache");
            //request.AddHeader(contentType, headers);
            request.AddParameter("undefined", message, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            if (response.ResponseStatus == ResponseStatus.Completed && response.StatusCode == HttpStatusCode.OK)
            {
                return new ApiJsonResult { Result = true, Message = response.Content };
            }
            else
            {
                return new ApiJsonResult { Result = false, Message = "Failed to get data from server" };
            }
        }
        
        private static TokenResult ParseJsonString(string jsonString)
        {
            return JsonConvert.DeserializeObject<TokenResult>(jsonString);
        }

        private static string ConvertToJson (string xmlData)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlData);
            return JsonConvert.SerializeXmlNode(doc);
        }

        private static Dictionary<string,string> GetKeyValuePairs (string contentType, string headers)
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            string[] contentTypeArray = contentType.Split(',');
            string[] headersArray = headers.Split(',');
            if(contentTypeArray.Count() == headersArray.Count())
            {
                for (int i = 0; i < contentTypeArray.Count(); i++)
                {
                    keyValuePairs.Add(contentTypeArray[i], headersArray[i]);
                }
            }
            else
            {
                keyValuePairs = null;
            }
            return keyValuePairs;
        }

        public static void GetDataFromAPI(SheetData sheetData, List<SheetValue> sheetValues)
        {
            Dictionary<string, ApiJsonResult> apiJsonResults = new Dictionary<string, ApiJsonResult>();
            foreach (var item in sheetValues)
            {
                if(item.cellValues[5]== "access_token" )
                {
                    if(item.cellValues[1] == "POST")
                    {
                        apiJsonResults.Add(item.cellValues[5], MakePostCall(item.cellValues[0], item.cellValues[2], item.cellValues[3], item.cellValues[4]));
                    }
                }
                else if(item.cellValues[5] == "token")
                {
                    if (item.cellValues[1] == "POST")
                    {
                        apiJsonResults.Add(item.cellValues[5],MakePostCall(item.cellValues[0], item.cellValues[2], item.cellValues[3], item.cellValues[4], apiJsonResults.Where(ajr => ajr.Key == "access_token").FirstOrDefault().Value));
                    }
                }
                else
                {
                   
                        var valuesList = apiJsonResults.Values.ToList();
                        var response =  MakeGetCall(item.cellValues[0], item.cellValues[2], item.cellValues[3], item.cellValues[4], valuesList);
                        DbEntry.UpdateDataBaseValues(response, sheetData);
                    
                }
                
            }
        }
    }
}
