using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using AAS_Core.Factory;
using AAS_Core.Model.Identifier;
using HtmlAgilityPack;
using MoreLinq;
using Newtonsoft.Json;

namespace AAS_Testrunner
{
    class Crawler
    {
        private static readonly List<AssetSubdivision> Subdivisions = AssetSubdivisionFactory.GroupSubdivision();
        public static void Crawl()
        {
            var mainsw = Stopwatch.StartNew();
            var masterList = new List<AssetSubdivision>();
            var codes = Subdivisions
                .DistinctBy(c => c.GroupCode)
                .Select(c => c.GroupCode);

            foreach (var code in codes)
            {
                var sw = Stopwatch.StartNew();
                var result = GetDataFromList(code);
                masterList.AddRange(result);
                Console.WriteLine($"Scrapping [{code}] [{sw.ElapsedMilliseconds}ms] - {result.Count} results");
            }

            Console.WriteLine($"Before filter: {masterList.Count} items");
            masterList = masterList.DistinctBy(c => c.ItemCode).ToList();

            File.WriteAllText(@"MISC.json", JsonConvert.SerializeObject(masterList, Formatting.Indented));
            Console.WriteLine($"After filter: {masterList.Count} items");
            Console.WriteLine($"All complete, time taken - {mainsw.ElapsedMilliseconds} ms");
        }

        public static List<AssetSubdivision> GetDataFromList(string txt)
        { 
            var crawDatas = new List<AssetSubdivision>();
            var html = GetHtml(txt);
            var doc = new HtmlAgilityPack.HtmlDocument {OptionFixNestedTags = true};
            doc.LoadHtml(html);
            var data = doc.DocumentNode.SelectNodes("//*[@id='form1']/table[3]/tr/td/div[3]/table/tr");
            foreach (var row in data)
            {
                var i = row.SelectNodes("td");
                var sectionCode = i[0].InnerText;
                var fullCode = i[1].InnerText;
                var description = i[2].InnerText;

                var subdivision = Subdivisions.FirstOrDefault(s => s.SectionCode == sectionCode && fullCode.StartsWith(s.GroupCode));

                if (subdivision != null)
                {
                    crawDatas.Add(new AssetSubdivision
                    {
                        ItemCode = fullCode,
                        ItemCodeDescription = description,
                        Section = subdivision.Section,
                        SectionCode = subdivision.SectionCode,
                        DivisionCode = subdivision.DivisionCode,
                        DivisionDescription = subdivision.DivisionDescription,
                        GroupCode = subdivision.GroupCode,
                        GroupDescription = subdivision.GroupDescription
                    });
                }
               
            }
            return crawDatas;
        }

        private static string GetHtml(string text)
        {
            using var client = new WebClient();
            var values = new NameValueCollection();
            values["cariMSIC"] = text;
            values["submit2"] = "Search";
            var response = client.UploadValues("http://msic.stats.gov.my/bi/carianKod.php?validation_rule=", values);
            return Encoding.Default.GetString(response);
        }
    }

}
