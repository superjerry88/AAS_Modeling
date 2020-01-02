using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AAS_Modeling.Model.Identifier;

namespace AAS_Modeling.Factory
{



    public  class IraiFactory
    {
        private static readonly Lazy<IraiFactory> PrivateInstance = new Lazy<IraiFactory>(() => new IraiFactory());
        public static IraiFactory Instance => PrivateInstance.Value;

        public List<AssetDimension> AssetDimensions { get; set; } = new List<AssetDimension>();
        public List<AssetOwner> AssetOwners { get; set; } = new List<AssetOwner>();
        public List<AssetSubdivision> AssetSubdivisions { get; set; } = new List<AssetSubdivision>();

        private IraiFactory()
        {
            AssetDimensions = AssetDimensionFactory.GenerateDimensions();
            AssetOwners = AssetOwnerFactory.GenerateAssetOwners();
            AssetSubdivisions = AssetSubdivisionFactory.GenerateAssetSubdivisionsWithoutItem();
        }

        public void LoadFromDatabase()
        {

        }

        public AssetDimension GetAssetDimension(string code)
        {
            var value = AssetDimensions.FirstOrDefault(a => a.IraiCode == "code");
            if (value != null) return value;
            
            throw new Exception("Asset Dimension cannot be found");
        }

        public AssetOwner GetAssetOwners(string code)
        {
            var value = AssetOwners.FirstOrDefault(a => a.IraiCode == "code");
            if (value != null) return value;

            throw new Exception("Asset Dimension cannot be found");
        }

        public AssetSubdivision GetAssetSubdivisionByCode(string code)
        {
            var value = AssetSubdivisions.FirstOrDefault(a => a.IraiCode == code);
            if (value != null) return value;

            throw new Exception("Asset Dimension cannot be found");
        }

        public AssetSubdivision GetAssetSubdivisionByDivision(string section)
        {
            var value = AssetSubdivisions.FirstOrDefault(a => a.DivisionCode == section);
            if (value != null) return value;

            throw new Exception("Asset Dimension cannot be found");
        }

        public List<AssetSubdivision> GetAssetSubdivisionBySection(string section)
        {
            return AssetSubdivisions.Where(c => c.Section == section || c.SectionCode == "").ToList();
        }
    }
}
