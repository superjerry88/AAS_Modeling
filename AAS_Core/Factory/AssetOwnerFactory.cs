using System.Collections.Generic;
using AAS_Core.Model.Identifier;

namespace AAS_Core.Factory
{
    class AssetOwnerFactory
    {
        public static List<AssetOwner> GenerateAssetOwners()
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
                    IraiCode = "03",
                    OwnerDescription = "Maintenance/Services"
                },
                new AssetOwner
                {
                    IraiCode = "04",
                    OwnerDescription = "Inventory/Warehouse/Store"
                },
                new AssetOwner
                {
                    IraiCode = "05",
                    OwnerDescription = "Engineering/Technology"
                },
                new AssetOwner
                {
                    IraiCode = "06",
                    OwnerDescription = "Research & Development"
                },
                new AssetOwner
                {
                    IraiCode = "07",
                    OwnerDescription = "Sales & Marketing"
                },
                new AssetOwner
                {
                    IraiCode = "08",
                    OwnerDescription = "Logistic/Transport"
                },
                new AssetOwner
                {
                    IraiCode = "09",
                    OwnerDescription = "Human Resource/Training"
                },
                new AssetOwner
                {
                    IraiCode = "10",
                    OwnerDescription = "Finance & Account"
                },
                new AssetOwner
                {
                    IraiCode = "11",
                    OwnerDescription = "IT & Communication"
                },
                new AssetOwner
                {
                    IraiCode = "12",
                    OwnerDescription = "Customer Services"
                },
                new AssetOwner
                {
                    IraiCode = "13",
                    OwnerDescription = "Board of Director"
                },

            };
        }
    }
}
