using System;
using System.Collections.Generic;
using System.Linq;
using AAS_Core.Factory;
using AAS_Core.Model.Assets;
using AAS_Core.Model.Enum;
using AAS_Core.Model.Identifier;
using AAS_Core.Model.Sample;

namespace AAS_Core
{
    public class Helper
    {
        public static BaseAsset CreateBaseAsset()
        {
            return new BaseAsset
            {
                Irai = Helper.GenerateSampleIrai("Machine 32A - Pressure Plate Sensor", "001"),
                AssetCategory = AssetCategory.Files,
                Created = DateTime.Now,
                LastUpdated = DateTime.Now,
                FullName = "Machine 32A - Pressure Plate Sensor",
                Description =
                    @"The JP series pressure transducers are highly cost-effective and suitable low cost, high volume commercial and industrial applications. This series are all MEMS technologies, compensated with digital ASIC. EMI/RFI circuit is built incompact laser welded stainless steel case to supply highly accurate,reliable,and stable output for limit installation space.This product is geared to the OEM customer using medium to high volumes with optional pressure ports and electrical connections.The standard version is suitable for many, but applications the dedicated design team stands ready to provide a custom design where the volume and application warrants.",
                BrokerMeta = new BrokerMeta()
            };
        }

        public static TableAsset<SensorData> CreateTableAsset()
        {
            var tableAsset = (TableAsset<SensorData>) CreateBaseAsset();
            tableAsset.DataModels = GeneraDataModel();
            tableAsset.HasDataModel = true;
            tableAsset.Values = GenerateFakeSensorData();

            return tableAsset;
        }

        public static SingleAsset<WaterTankGeneratorSpec> CreateSingleAsset()
        {
            return new SingleAsset<WaterTankGeneratorSpec>
            {
                Irai = Helper.GenerateSampleIrai("Machine 32A - Pressure Plate Sensor", "001"),
                AssetCategory = AssetCategory.Files,
                Created = DateTime.Now,
                LastUpdated = DateTime.Now,
                FullName = "Machine 32A - Pressure Plate Sensor",
                Description =
                    @"The JP series pressure transducers are highly cost-effective and suitable low cost, high volume commercial and industrial applications. This series are all MEMS technologies, compensated with digital ASIC. EMI/RFI circuit is built incompact laser welded stainless steel case to supply highly accurate,reliable,and stable output for limit installation space.This product is geared to the OEM customer using medium to high volumes with optional pressure ports and electrical connections.The standard version is suitable for many, but applications the dedicated design team stands ready to provide a custom design where the volume and application warrants.",
                BrokerMeta = new BrokerMeta(),
                DataModels = new List<DataModel>
                {
                    new DataModel
                    {
                        Language = "C#",
                        Model = @"    public class WaterTankGeneratorSpec
    {
        public AssetProperty Width;
        public AssetProperty Length;
        public AssetProperty Weight;
        public AssetProperty Capacity;
        public AssetProperty PowerCapacity;
        public AssetProperty ManufacturingDate;
    }

    public class AssetProperty
    {
        public string Name;
        public string DivisionDescription;
        public bool HasUnit;
        public string Unit;
        public bool HasNumericValue;
        public object Value;
    }"
                    }
                },
                HasDataModel = true,
                Value = new WaterTankGeneratorSpec
                {
                    Capacity = new AssetProperty
                    {
                        Value = 450000.0,
                        Unit = "ml",
                        Description = "Used to measure the maximum capacity of the oil tanker",
                        HasUnit = true,
                        HasNumericValue = true,
                        Name = "Capacity"
                    },
                    Length = new AssetProperty
                    {
                        Value = 12.455,
                        Unit = "meter",
                        Description = "The total length of the machine",
                        HasUnit = true,
                        HasNumericValue = true,
                        Name = "Length"
                    },
                    Width = new AssetProperty
                    {
                        Value = 4.455,
                        Unit = "meter",
                        Description = "The total Width of the machine",
                        HasUnit = true,
                        HasNumericValue = true,
                        Name = "Width"
                    },
                    Weight = new AssetProperty
                    {
                        Value = 1245.36,
                        Unit = "Kg",
                        Description = "The total weight of the machine",
                        HasUnit = true,
                        HasNumericValue = true,
                        Name = "Weight"
                    },
                    PowerCapacity = new AssetProperty
                    {
                        Value = 200,
                        Unit = "Kw/H",
                        Description = "The power consumption of the machine",
                        HasUnit = true,
                        HasNumericValue = true,
                        Name = "Power Capacity"
                    },
                    ManufacturingDate = new AssetProperty
                    {
                        Value = "2009-08-02",
                        Description = "The manufacturing date of the machine",
                        HasUnit = false,
                        HasNumericValue = false,
                        Name = "Manufacturing Date"
                    }
                }
            };
        }

        public static FileAsset CreateFileAsset()
        {
            return new FileAsset
            {
                Irai = Helper.GenerateSampleIrai("Machine 32A - Pressure Plate Sensor", "001"),
                AssetCategory = AssetCategory.Files,
                Created = DateTime.Now,
                LastUpdated = DateTime.Now,
                FullName = "Machine 32A - Pressure Plate Sensor",
                Description =
                    @"The JP series pressure transducers are highly cost-effective and suitable low cost, high volume commercial and industrial applications. This series are all MEMS technologies, compensated with digital ASIC. EMI/RFI circuit is built incompact laser welded stainless steel case to supply highly accurate,reliable,and stable output for limit installation space.This product is geared to the OEM customer using medium to high volumes with optional pressure ports and electrical connections.The standard version is suitable for many, but applications the dedicated design team stands ready to provide a custom design where the volume and application warrants.",
                BrokerMeta = new BrokerMeta(),
                Files = new List<FileMeta>
                {
                    new FileMeta("Meta.json","Meta Asset File","A sample file that display metadata in JSON format"),
                    new FileMeta("Single.json","Single Asset File", "A sample file that display metadata in Single Asset format" )
                }
            };
        }

        public static Irai GenerateSampleIrai(string assetName, string code)
        {
            return new Irai
            {
                AssetGeoLocation = new AssetGeoLocation("MY", "40460", "Shah Alam ", "3.008507", "101.520867"),
                AssetOrganization = new AssetOrganization
                {
                    
                    IraiCode = "0001",
                    Email = "User001@mail.com",
                    Handphone = "+60123456789",
                    Phone = "1300-88-2525",
                    Name = "Ajiya Roofing KK",
                    RegistrationNumber = "01-23456",
                    IndustryCode = "C",
                    Website = "tarc.edu.my"
                },
                Subdivision = IraiFactory.Instance.GetAssetSubdivisionByCode("C31"),
                Dimension = IraiFactory.Instance.AssetDimensions.First(),
                Owner = IraiFactory.Instance.AssetOwners.First(),
                AssetCode = new AssetCode
                {
                    AssetDescription = assetName,
                    SiteCode = "A1",
                    AreaCode = "A2",
                    ProcessCode = "01",
                    UniqueCode = code
                },
                Versions = new List<AssetVersion>
                {
                    new AssetVersion
                    {
                        IraiCode = "0001",
                        VersionDescription = "Initial Creation"
                    },
                    new AssetVersion
                    {
                        IraiCode = "0002",
                        VersionDescription = "Updated data X"
                    },
                    new AssetVersion
                    {
                        IraiCode = "0003",
                        VersionDescription = "Updated semantic Y"
                    },
                },
                LastestVersion = new AssetVersion
                {
                    IraiCode = "0003",
                    VersionDescription = "Updated semantic Y"
                }
            };
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
    }
}