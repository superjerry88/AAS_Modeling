using System.Globalization;

namespace AAS_Core.Model.Identifier
{
    public class AssetGeoLocation
    {
        public string IraiCode => $"{CountryCode}{WorldZipCode}";
        public string CountryFullName { get; set; }
        public string CountryCode { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string WorldZipCode { get; set; }
        public string Lontitude { get; set; }
        public string Latitude { get; set; }

        public AssetGeoLocation(RegionInfo region)
        {
            CountryCode = region.TwoLetterISORegionName;
            CountryFullName = region.EnglishName;
        }

        public AssetGeoLocation(string country, string zip,  string cityName,string longtitude = "0.00", string latitude = "0.00")
        {
            var region = new RegionInfo(country);
            ZipCode = zip;
            WorldZipCode = zip.Replace("-", "").Replace(" ", "").PadLeft(8, '0');
            City = cityName;
            CountryCode = region.TwoLetterISORegionName;
            CountryFullName = region.EnglishName;
            Lontitude = longtitude;
            Latitude = latitude;
        }
    }
}