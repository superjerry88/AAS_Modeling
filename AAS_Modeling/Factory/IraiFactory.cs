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

        public List<AssetDimension> AssetDimensions { get; set; }
        public List<AssetOwner> AssetOwners { get; set; }
        public List<AssetSubdivision> AssetSubdivisions { get; set; }

        private IraiFactory()
        {
            AssetDimensions = AssetDimensionFactory.GenerateDimensions();
            AssetOwners = AssetOwnerFactory.GenerateAssetOwners();
            AssetSubdivisions = AssetSubdivisionFactory.GenerAssetSubdivisions();
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

        public AssetSubdivision GetAssetSubdivision(string code)
        {
            var value = AssetSubdivisions.FirstOrDefault(a => a.IraiCode == "code");
            if (value != null) return value;

            throw new Exception("Asset Dimension cannot be found");
        }
    }
}
