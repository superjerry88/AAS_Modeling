using System;
using System.Collections.Generic;
using System.Text;
using AAS_Modeling.Model.Identifier;

namespace AAS_Modeling.Factory
{
    class AssetDimensionFactory
    {
        public static List<AssetDimension> GenerateDimensions()
        {
            return new List<AssetDimension>
            {
                new AssetDimension
                {
                    IraiCode = "PC",
                    Dimensions = "Personal Industry 4.0 Competency",
                    Thrust = "Human Capital Development",
                    ShiftFactor = "People"
                },
                new AssetDimension
                {
                    IraiCode = "TS",
                    Dimensions = "Top Management Technology Savviness",
                    Thrust = "Human Capital Development",
                    ShiftFactor = "People"
                },
                new AssetDimension
                {
                    //todo add more ... 
                },
                new AssetDimension
                {
                    //todo add more ... 
                },
                new AssetDimension
                {
                    //todo add more ... 
                },

            };
        }
    }
}
