using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AAS_Core.Utility
{
    public class ApiRequest
    {
        public static string Address { get; set; } = "http://159.138.83.111:68/api/logon";

        public static T Send<T>(object value)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create($"{Address}");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var json = JsonConvert.SerializeObject(value, Formatting.Indented);
                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var reply = streamReader.ReadToEnd();
                var parsedJson = JToken.Parse(reply);
                return JsonConvert.DeserializeObject<T>(reply);
            }
        }

        private static void Log(string url, string json, string type)
        {
            using (StreamWriter sw = File.AppendText("Api_log.json"))
            {
                sw.WriteLine("==============================================");
                sw.WriteLine($"DateTime: {DateTime.Now:G}");
                sw.WriteLine($"Address: {url}");
                sw.WriteLine($"Type: {type}");
                sw.WriteLine(json);
            }
        }
    }
}
