using System.Collections.Generic;
using System.Net;

namespace AAS_Resource
{
    public class Downloader
    {
        public static string GetMISC()
        {
            using (var client = new WebClient())
            {
                return client.DownloadString("https://raw.githubusercontent.com/superjerry88/AAS_Modeling/master/AAS_Resource/Data/Latest/MISC.json");

            }
        }
    }
}
