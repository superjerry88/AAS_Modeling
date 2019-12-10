using System.Collections.Generic;
using System.Globalization;

namespace AAS_Modeling
{
    public class Helper
    {
        public static GeoLocation CreateGeoLocation(string countryCode, string city, string zip,string longtitude = "0.00",string latitude = "0.00")
        {
            var country = new RegionInfo(countryCode);
            var wZip = zip.Replace("-", "").Replace(" ","");
            wZip = wZip.PadLeft(8, '0');
            return new GeoLocation
            {
                City = city,
                CountryCode = country.TwoLetterISORegionName,
                CountryFullName = country.EnglishName,
                WorldZipCode = wZip,
                ZipCode = zip,
                Lontitude = longtitude,
                Latitude = latitude
            };
        }

        public static IRAI GenerateSampleIrai(string assetName, string code)
        {
            return new IRAI
            {
                GeoLocation = CreateGeoLocation("MY","Shah Alam", "40460 ", "3.008507", "101.520867"),
                Organization = new Organization
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
                Subdivision = new AssetSubdivision
                {
                    IraiCode = "C18",
                    Description = "Manufacture of metal works"
                },
                Dimension = new AssetDimension
                {
                    IraiCode = "SA",
                    Dimensions = "Shop Floor Automation",
                    Thrust = "Asset Automation",
                    ShiftFactor = "Technology"
                },
                Owner = new AssetOwner
                {
                    IraiCode = "05",
                    OwnerDescription = "Engineering/ Technology"
                },
                AssetCode = new AssetCode
                {
                    AssetDescription = assetName,
                    Site = "A1",
                    Area = "A2",
                    Process = "01",
                    Code = code
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
    }
}