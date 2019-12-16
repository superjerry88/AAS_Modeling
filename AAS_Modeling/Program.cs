using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AAS_Modeling
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText(@"Meta.json", JsonConvert.SerializeObject(Helper.CreateBaseAsset(), Formatting.Indented));

            File.WriteAllText(@"Table.json", JsonConvert.SerializeObject(Helper.CreateTableAsset(), Formatting.Indented));

            File.WriteAllText(@"Single.json", JsonConvert.SerializeObject(Helper.CreateSingleAsset(), Formatting.Indented));

            File.WriteAllText(@"File.json", JsonConvert.SerializeObject(Helper.CreateFileAsset(), Formatting.Indented));
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