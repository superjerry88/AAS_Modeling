using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace AAS_Resource
{
    class Downloader
    {
        public static string CheckNeedsUpdate()
        {
            using (var client = new WebClient())
            {
                return client.DownloadString("https://raw.githubusercontent.com/goaaats/universalis_act_plugin/master/version");

            }
        }
    }
}
