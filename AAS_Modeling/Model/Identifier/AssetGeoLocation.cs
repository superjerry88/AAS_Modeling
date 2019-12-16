using System.Globalization;

namespace AAS_Modeling.Model.Identifier
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
    }
}