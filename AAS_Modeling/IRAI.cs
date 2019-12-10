using System;
using System.Collections.Generic;
using System.Text;

namespace AAS_Modeling
{
    public class IRAI
    {
        public string FullCode =>
            $"0990-{GeoLocation.IraiCode}{Subdivision.IraiCode}{Organization.IraiCode}-{Owner.IraiCode}#{Dimension.IraiCode}-{AssetCode.IraiCode}#{LastestVersion.IraiCode}";
        public GeoLocation GeoLocation { get; set; }
        public AssetSubdivision Subdivision { get; set; }
        public Organization Organization { get; set; }
        public AssetOwner Owner { get; set; }
        public AssetDimension Dimension { get; set; }
        public AssetCode AssetCode { get; set; }
        public AssetVersion LastestVersion { get; set; }
        public List<AssetVersion> Versions { get; set; }
    }

    public class GeoLocation
    {
        public string IraiCode => $"{CountryCode}{WorldZipCode}";
        public string CountryFullName { get; set; }
        public string CountryCode { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string WorldZipCode { get; set; }
        public string Lontitude { get; set; }
        public string Latitude { get; set; }
    }

    public class Organization
    {
        public string IraiCode { get; set; } //Organization Code
        public string Name { get; set; }
        public string RegistrationNumber { get; set; }
        public string IndustryCode { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Handphone { get; set; }
        public string Website { get; set; }
    }

    public class AssetSubdivision //global
    {
        public string IraiCode { get; set; }
        public string Description { get; set; }
    }

    public class AssetDimension //global
    {
        public string IraiCode { get; set; }
        public string ShiftFactor { get; set; }
        public string Thrust { get; set; }
        public string Dimensions { get; set; }
    }

    public class AssetOwner //global
    {
        public string IraiCode { get; set; }
        public string OwnerDescription { get; set; }
    }

    public class AssetCode //Company Specific
    {
        public string IraiCode => $"{Site}{Area}{Process}{Code}";
        public string AssetDescription { get; set; }
        public string Site { get; set; }
        public string Area { get; set; }
        public string Process { get; set; }
        public string Code { get; set; }
   
    }

    public class AssetVersion //Asset Specific
    {
        public string IraiCode { get; set; }
        public string VersionDescription { get; set; }
       
    }
}
