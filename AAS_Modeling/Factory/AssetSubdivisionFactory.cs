using System;
using System.Collections.Generic;
using System.Text;
using AAS_Modeling.Model.Identifier;

namespace AAS_Modeling.Factory
{
    class AssetSubdivisionFactory
    {
        public List<AssetSubdivision> GenerAssetSubdivisions()
        {
            return new List<AssetSubdivision>
            {
                new AssetSubdivision
                {
                    SectionCode = "A",
                    Section = "Agriculture, Forestry and Fishing",
                    DivisionCode = "01",
                    Description = "Crops and animal production, hunting and related service activities"
                },
                new AssetSubdivision
                {
                    SectionCode = "A",
                    Section = "Agriculture, Forestry and Fishing",
                    DivisionCode = "02",
                    Description = "Forestry and logging"
                },
                new AssetSubdivision
                {
                    //todo add more ...
                },
                new AssetSubdivision
                {
                    //todo add more ...
                },
                new AssetSubdivision
                {
                    //todo add more ...
                },
            };
        }
    }
}
