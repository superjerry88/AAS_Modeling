using System.Collections.Generic;
using AAS_Core.Model.Identifier;

namespace AAS_Core.Factory
{
    class AssetDimensionFactory
    {
        public static List<AssetDimension> GetFulListDimensions()
        {
            return new List<AssetDimension>();
        }

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
                    IraiCode = "LS",
                    Dimensions = "Leadership",
                    Thrust = "Human Capital Development",
                    ShiftFactor = "People"
                },
                new AssetDimension
                {
                    IraiCode = "SG",
                    Dimensions = "Collaboration Structures and Governance",
                    Thrust = "Human Capital Development",
                    ShiftFactor = "People"
                },
                new AssetDimension
                {
                    IraiCode = "IS",
                    Dimensions = "Industry 4.0 Strategy",
                    Thrust = "Human Capital Development",
                    ShiftFactor = "People"
                },
                new AssetDimension
                {
                    IraiCode = "SA",
                    Dimensions = "Shop Floor Automation",
                    Thrust = "Asset Automation",
                    ShiftFactor = "Technology"
                },
                new AssetDimension
                {
                    IraiCode = "FA",
                    Dimensions = "Facilities Automation",
                    Thrust = "Asset Automation",
                    ShiftFactor = "Technology"
                },
                new AssetDimension
                {
                    IraiCode = "EA",
                    Dimensions = "Enterprise Automation",
                    Thrust = "Asset Automation",
                    ShiftFactor = "Technology"
                },
                new AssetDimension
                {
                    IraiCode = "SC",
                    Dimensions = "Shop Floor Connectivity",
                    Thrust = "Asset Connectivity",
                    ShiftFactor = "Technology"
                },
                new AssetDimension
                {
                    IraiCode = "FC",
                    Dimensions = "Facilities Connectivity",
                    Thrust = "Asset Connectivity",
                    ShiftFactor = "Technology"
                },
                new AssetDimension
                {
                    IraiCode = "EC",
                    Dimensions = "Enterprise Connectivity",
                    Thrust = "Asset Connectivity",
                    ShiftFactor = "Technology"
                },
                new AssetDimension
                {
                    IraiCode = "SI",
                    Dimensions = "Shop Floor Intelligence",
                    Thrust = "Asset Intelligence",
                    ShiftFactor = "Technology"
                },
                new AssetDimension
                {
                    IraiCode = "FI",
                    Dimensions = "Facilities Intelligence",
                    Thrust = "Asset Intelligence",
                    ShiftFactor = "Technology"
                },
                new AssetDimension
                {
                    IraiCode = "EI",
                    Dimensions = "Enterprise Intelligence",
                    Thrust = "Asset Intelligence",
                    ShiftFactor = "Technology"
                },
                new AssetDimension
                {
                    IraiCode = "PM",
                    Dimensions = "Product Management",
                    Thrust = "Operation Management",
                    ShiftFactor = "Process"
                },
                new AssetDimension
                {
                    IraiCode = "TM",
                    Dimensions = "Technology Management",
                    Thrust = "Operation Management",
                    ShiftFactor = "Process"
                },
                new AssetDimension
                {
                    IraiCode = "FM",
                    Dimensions = "Performance Management",
                    Thrust = "Operation Management",
                    ShiftFactor = "Process"
                },
                new AssetDimension
                {
                    IraiCode = "LC",
                    Dimensions = "Product Life Cycle Management",
                    Thrust = "Product Management",
                    ShiftFactor = "Process"
                },
                new AssetDimension
                {
                    IraiCode = "PI",
                    Dimensions = "Product Individualisation",
                    Thrust = "Product Management",
                    ShiftFactor = "Process"
                },
                new AssetDimension
                {
                    IraiCode = "HI",
                    Dimensions = "Horizontal Integration",
                    Thrust = "Supply Chain Management",
                    ShiftFactor = "Process"
                },
                new AssetDimension
                {
                    IraiCode = "CS",
                    Dimensions = "Cybersecurity",
                    Thrust = "Supply Chain Management",
                    ShiftFactor = "Process"
                },
            };



        }
    }
}
