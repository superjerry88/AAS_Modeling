using System;
using System.Collections.Generic;
using System.Text;
using AAS_Core;
using AAS_Core.Factory;
using AAS_Core.Model.Assets;
using AAS_Core.Model.Sample;

namespace AAS_Testrunner
{
    class PlcTester
    {
        public static void Test()
        {
            //defining new asset object
            TableAsset<SensorData> assetA = new TableAsset<SensorData>
            {
                Irai = Helper.GenerateSampleIrai("sample PLC asset", "001"),
                Description = "This is a demo asset",
                FullName = "Sample PLC asset",
            };

            //creating random asset value 
            var sensorDatas = new List<SensorData>();
            var rng = new Random();
            for (int i = 0; i < 99; i++)
            {
                sensorDatas.Add(new SensorData
                {
                    Value = rng.Next(100),
                    Time = DateTime.Now.AddMinutes(i)
                });
            }

            //add value to object
            assetA.Values.AddRange(sensorDatas);
           
            //add asset to DB
            AAS_Core.Core.MongoHelper.CreateAsset(assetA);
        }
    }
}
