using System;
using System.Collections.Generic;
using System.IO;
using AAS_Core;
using AAS_Core.Model.Identifier;
using AAS_Resource;
using Newtonsoft.Json;

namespace AAS_Testrunner
{
    class Program
    {
        static void Main(string[] args)
        {
           // Crawler.Crawl();
           // MongoHelper.CreateSubdivisionInDb();

           var item = Newtonsoft.Json.JsonConvert.DeserializeObject<List<AssetSubdivision>>(Downloader.GetMISC());
           foreach (var assetSubdivision in item)
           {
               Console.WriteLine(assetSubdivision.ItemCode);
           }
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