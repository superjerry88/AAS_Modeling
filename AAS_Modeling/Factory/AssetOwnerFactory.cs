using System;
using System.Collections.Generic;
using System.Text;
using AAS_Modeling.Model.Identifier;

namespace AAS_Modeling.Factory
{
    class AssetOwnerFactory
    {
        public List<AssetOwner> GenerateAssetOwners()
        {
            return new List<AssetOwner>
            {
                new AssetOwner
                {
                    IraiCode = "01",
                    OwnerDescription = "Production/Processing"
                },
                new AssetOwner
                {
                    IraiCode = "02",
                    OwnerDescription = "Quality Control"
                },
                new AssetOwner
                {
                    //todo add more...
                },
                new AssetOwner
                {
                    //todo add more...
                },

            };
        }
    }
}
