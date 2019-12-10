using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AAS_Modeling
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseAsset sample = new BaseAsset
            {
                IRAI = Helper.GenerateSampleIrai("Machine 32A - Pressure Plate Sensor", "001"),
                AssetCategory = AssetCategory.Files,
                Created = DateTime.Now,
                LastUpdated = DateTime.Now,
                FullName = "Machine 32A - Pressure Plate Sensor",
                Description =
                    @"The JP series pressure transducers are highly cost-effective and suitable low cost, high volume commercial and industrial applications. This series are all MEMS technologies, compensated with digital ASIC. EMI/RFI circuit is built incompact laser welded stainless steel case to supply highly accurate,reliable,and stable output for limit installation space.This product is geared to the OEM customer using medium to high volumes with optional pressure ports and electrical connections.The standard version is suitable for many, but applications the dedicated design team stands ready to provide a custom design where the volume and application warrants.",
                BrokerMeta = new BrokerMeta()
            };

            System.IO.File.WriteAllText(@"Meta.json", JsonConvert.SerializeObject(sample, Formatting.Indented));

            TableAsset<SensorData> sensorData = new TableAsset<SensorData>
            {
                IRAI = Helper.GenerateSampleIrai("Machine 32A - Pressure Plate Sensor", "001"),
                AssetCategory = AssetCategory.Files,
                Created = DateTime.Now,
                LastUpdated = DateTime.Now,
                FullName = "Machine 32A - Pressure Plate Sensor",
                Description =
                    @"The JP series pressure transducers are highly cost-effective and suitable low cost, high volume commercial and industrial applications. This series are all MEMS technologies, compensated with digital ASIC. EMI/RFI circuit is built incompact laser welded stainless steel case to supply highly accurate,reliable,and stable output for limit installation space.This product is geared to the OEM customer using medium to high volumes with optional pressure ports and electrical connections.The standard version is suitable for many, but applications the dedicated design team stands ready to provide a custom design where the volume and application warrants.",
                BrokerMeta = new BrokerMeta(),
                DataModels = GeneraDataModel(),
                HasDataModel = true,
                Values = GenerateFakeSensorData()
            };

            System.IO.File.WriteAllText(@"Table.json", JsonConvert.SerializeObject(sensorData, Formatting.Indented));
            SingleAsset<Specification> machineData = new SingleAsset<Specification>
            {
                IRAI = Helper.GenerateSampleIrai("Machine 32A - Pressure Plate Sensor", "001"),
                AssetCategory = AssetCategory.Files,
                Created = DateTime.Now,
                LastUpdated = DateTime.Now,
                FullName = "Machine 32A - Pressure Plate Sensor",
                Description =
                    @"The JP series pressure transducers are highly cost-effective and suitable low cost, high volume commercial and industrial applications. This series are all MEMS technologies, compensated with digital ASIC. EMI/RFI circuit is built incompact laser welded stainless steel case to supply highly accurate,reliable,and stable output for limit installation space.This product is geared to the OEM customer using medium to high volumes with optional pressure ports and electrical connections.The standard version is suitable for many, but applications the dedicated design team stands ready to provide a custom design where the volume and application warrants.",
                BrokerMeta = new BrokerMeta(),
                DataModels = GeneraDataModel(),
                HasDataModel = true,
                Value = new Specification
                {
                    Capacity = new Property
                    {
                        Value = 450000.0,
                        Unit = "ml",
                        Description = "Used to measure the maximum capacity of the oil tanker",
                        HasUnit = true,
                        HasValue = true,
                        Name = "Capacity"
                    },
                    Length = new Property
                    {
                        Value = 12.455,
                        Unit = "meter",
                        Description = "The total length of the machine",
                        HasUnit = true,
                        HasValue = true,
                        Name = "Length"
                    },
                    Width = new Property
                    {
                        Value = 4.455,
                        Unit = "meter",
                        Description = "The total Width of the machine",
                        HasUnit = true,
                        HasValue = true,
                        Name = "Width"
                    },
                    Weight = new Property
                    {
                        Value = 1245.36,
                        Unit = "Kg",
                        Description = "The total weight of the machine",
                        HasUnit = true,
                        HasValue = true,
                        Name = "Weight"
                    },
                    PowerCapacity =  new Property
                    {
                    Value = 1245.36,
                    Unit = "Kg",
                    Description = "The total weight of the machine",
                    HasUnit = true,
                    HasValue = true,
                    Name = "Weight"
                }
                }
            };

            System.IO.File.WriteAllText(@"Single.json", JsonConvert.SerializeObject(machineData, Formatting.Indented));
            Console.WriteLine("done");
        }

        public static List<SensorData> GenerateFakeSensorData()
        {
            var r = new Random();
            var sensor = new List<SensorData>();
            for (int i = 0; i < 20; i++)
            {
                sensor.Add(new SensorData
                {
                    Time = DateTime.Now.AddSeconds(i),
                    Value = r.NextDouble()
                });
            }

            return sensor;
        }

        public static List<DataModel> GeneraDataModel()
        {
            return new List<DataModel>
            {
                new DataModel
                {
                    Language = "C#",
                    Model = @"class SensorData
{
public DateTime Time;
public double Value;
}"
                },
                new DataModel
                {
                    Language = "c++",
                    Model = @"class SensorData
{
public:
string time;
double value;
}"
                }
            };
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
            public Property ManufacturingYear;

        }

        public class Property
        {
            public string Name;
            public string Description;
            public bool HasUnit;
            public string Unit;
            public bool HasValue;
            public double Value;
        }
    }
}