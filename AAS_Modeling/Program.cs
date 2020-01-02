using System;
using System.Collections.Generic;
using System.IO;
using AAS_Core;
using AAS_Core.Core;
using AAS_Core.Factory;
using AAS_Core.Model.Identifier;
using AAS_Resource;
using Newtonsoft.Json;

namespace AAS_Testrunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("       __            __        ________  \r\n     /\"\"\\          /\"\"\\      /\"       ) \r\n    /    \\        /    \\    (:   \\___/  \r\n   /' /\\  \\      /' /\\  \\    \\___  \\    \r\n  //  __'  \\    //  __'  \\    __/  \\\\   \r\n /   /  \\\\  \\  /   /  \\\\  \\  /\" \\   :)  \r\n(___/    \\___)(___/    \\___)(_______/   \r\n                                        ");
            Menu();
           Console.WriteLine("Done");
           Console.Read();
        }

        static void Menu()
        {
            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - Scrap from MISC website");
            Console.WriteLine("2 - Load Data from Github");
            Console.WriteLine("3 - Generate Meta Files");
            Console.WriteLine("4 - Add meta files to Mongodb");
            switch (Console.ReadLine())
            {
                case "0":
                    return;
                case "1":
                    CrawlMisc();
                    break;
                case "2":
                    LoadFromGithub();
                    break;
                case "3":
                    GenerateMetaFiles();
                    break;
                case "4":
                    CreateSampleInDB();
                    break;
                default:
                    Console.WriteLine("Unknown, please try again.");
                    break;
            }
            Menu();
        }

        static void CreateSampleInDB()
        {
            MongoHelper.CreateSubdivisionInDb();
        }

        static void LoadFromGithub()
        {
            var item = AssetSubdivisionFactory.GetAssetSubdivisions();
            foreach (var assetSubdivision in item)
            {
                Console.WriteLine(assetSubdivision.ItemCode);
            }
        }

        static void CrawlMisc()
        {
            Crawler.Crawl();
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