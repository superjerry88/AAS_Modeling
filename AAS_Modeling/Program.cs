using System;
using System.Collections.Generic;
using System.IO;
using AAS_Modeling.Core;
using AAS_Testrunner;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AAS_Modeling
{
    class Program
    {
        static void Main(string[] args)
        {
            Crawler.Crawl();
           // MongoHelper.CreateSubdivisionInDb();
            Console.WriteLine("Done");
            Console.Read();
        }

        static void GenerateMetaFiles()
        {
            File.WriteAllText(@"Meta.json", JsonConvert.SerializeObject(Helper.CreateBaseAsset(), Formatting.Indented));

            File.WriteAllText(@"Table.json", JsonConvert.SerializeObject(Helper.CreateTableAsset(), Formatting.Indented));

            File.WriteAllText(@"Single.json", JsonConvert.SerializeObject(Helper.CreateSingleAsset(), Formatting.Indented));

            File.WriteAllText(@"File.json", JsonConvert.SerializeObject(Helper.CreateFileAsset(), Formatting.Indented));
        }
    }
}