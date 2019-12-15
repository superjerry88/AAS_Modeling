using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AAS_Modeling
{
    class Program
    {
        static void Main(string[] args)
        {
            CheapPostman.SendToLocalHost();
            Console.WriteLine("done");
            Console.Read();
//            System.IO.File.WriteAllText(@"Meta.json", JsonConvert.SerializeObject(Helper.CreateBaseAsset(), Formatting.Indented));
//
//            System.IO.File.WriteAllText(@"Table.json", JsonConvert.SerializeObject(Helper.CreateTableAsset(), Formatting.Indented));
//
//            System.IO.File.WriteAllText(@"Single.json", JsonConvert.SerializeObject(Helper.CreateSingleAsset(), Formatting.Indented));
//
//            System.IO.File.WriteAllText(@"File.json", JsonConvert.SerializeObject(Helper.CreateFileAsset(), Formatting.Indented));
        }
    }

    public class CheapPostman
    {
        public static void SendToLocalHost()
        {
            Console.WriteLine(Send("", Helper.CreateBaseAsset()));
        }

        public static string Send(string path, object value)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create($"https://localhost:44308/api/updatemetadata");
            // httpWebRequest.Proxy = new WebProxy("139.162.28.121:3128");
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
                return reply;

            }
        }
    }

    public class SensorData
    {
        public DateTime Time;
        public double Value;
    }

    public class Specification
    {
        public Property Width;
        public Property Length;
        public Property Weight;
        public Property Capacity;
        public Property PowerCapacity;
        public Property ManufacturingDate;
    }

    public class Property
    {
        public string Name;
        public string Description;
        public bool HasUnit;
        public string Unit;
        public bool HasNumericValue;
        public object Value;
    }
}