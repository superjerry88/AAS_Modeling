using System;
using System.Collections.Generic;
using System.Text;
using AAS_Modeling.Model.Identifier;

namespace AAS_Modeling.Factory
{
    class AssetSubdivisionFactory
    {
        public static List<AssetSubdivision> GenerateAssetSubdivisions()
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
                    SectionCode = "A",
                    Section = "Agriculture, Forestry and Fishing",
                    DivisionCode = "03",
                    Description = "Fishing and aquaculture"
                },
                new AssetSubdivision
                {
                    SectionCode = "B",
                    Section = "Mining and Quarrying",
                    DivisionCode = "04",
                    Description = "Mining of coal and lignite"
                },
                new AssetSubdivision
                {
                    SectionCode = "B",
                    Section = "Mining and Quarrying",
                    DivisionCode = "05",
                    Description = "Extraction of crude petroleum and natural gas"
                },
                new AssetSubdivision
                {
                    SectionCode = "B",
                    Section = "Mining and Quarrying",
                    DivisionCode = "06",
                    Description = "Mining of metal ores"
                },
                new AssetSubdivision
                {
                    SectionCode = "B",
                    Section = "Mining and Quarrying",
                    DivisionCode = "07",
                    Description = "Other mining and quarrying"
                },
                new AssetSubdivision
                {
                    SectionCode = "B",
                    Section = "Mining and Quarrying",
                    DivisionCode = "08",
                    Description = "Mining support service activities"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "09",
                    Description = "Manufacture of food products"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "10",
                    Description = "Manufacture of beverages"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "11",
                    Description = "Manufacture of tobacco products"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "12",
                    Description = "Manufacture of textiles"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "13",
                    Description = "Manufacture of wearing apparel"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "14",
                    Description = "Manufacture of leather and related products"
                },
                new AssetSubdivision 
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "15",
                    Description = "Manufacture of wood and products of wood and cork, except furniture; manufacture of articles of straw and plaiting materials "
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "16",
                    Description = "Manufacture of paper and paper products"
                },
               
            };
        }
    }
}
