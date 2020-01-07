using System.Collections.Generic;
using System.IO;
using AAS_Core.Model.Identifier;
using AAS_Resource;
using MongoDB.Bson;
using Newtonsoft.Json;

namespace AAS_Core.Factory
{
    public class AssetSubdivisionFactory
    {
        private static List<AssetSubdivision> assetSubdivisions = new List<AssetSubdivision>();
        private static string text = "";
        public static List<AssetSubdivision> GetAssetSubdivisions()
        {
            if (assetSubdivisions.Count == 0)
            {
                //text = Downloader.GetMISC();want
                text = File.ReadAllText("Data/Latest/MISC.json");
                assetSubdivisions = JsonConvert.DeserializeObject<List<AssetSubdivision>>(text);
            }
            return assetSubdivisions;
        }
        public static List<AssetSubdivision> GroupSubdivision()
        {
            return new List<AssetSubdivision>
            {
                // (A)  <<AGRICULTURE, FORESTRY AND FISHING>> 

                // (1) Crops and animal production, hunting and related service activities
                new AssetSubdivision
                {
                    SectionCode = "A",
                    Section = "Agriculture, Forestry and Fishing",
                    DivisionCode = "01",
                    DivisionDescription = "Crops and animal production, hunting and related service activities",
                    GroupCode = "011",
                    GroupDescription = "Growing of non-perennial crops"
                },
                new AssetSubdivision
                {
                    SectionCode = "A",
                    Section = "Agriculture, Forestry and Fishing",
                    DivisionCode = "01",
                    DivisionDescription = "Crops and animal production, hunting and related service activities",
                    GroupCode = "012",
                    GroupDescription = "Growing of perennial crops"
                },
                new AssetSubdivision
                {
                    SectionCode = "A",
                    Section = "Agriculture, Forestry and Fishing",
                    DivisionCode = "01",
                    DivisionDescription = "Crops and animal production, hunting and related service activities",
                    GroupCode = "013",
                    GroupDescription = "Plant propagation"
                },

                new AssetSubdivision
                {
                    SectionCode = "A",
                    Section = "Agriculture, Forestry and Fishing",
                    DivisionCode = "01",
                    DivisionDescription = "Crops and animal production, hunting and related service activities",
                    GroupCode = "014",
                    GroupDescription = "Animal production"
                },
                new AssetSubdivision
                {
                    SectionCode = "A",
                    Section = "Agriculture, Forestry and Fishing",
                    DivisionCode = "01",
                    DivisionDescription = "Crops and animal production, hunting and related service activities",
                    GroupCode = "015",
                    GroupDescription = "Mixed farming"
                },
                new AssetSubdivision
                {
                    SectionCode = "A",
                    Section = "Agriculture, Forestry and Fishing",
                    DivisionCode = "01",
                    DivisionDescription = "Crops and animal production, hunting and related service activities",
                    GroupCode = "016",
                    GroupDescription = "Support activities to agriculture and post-harvest crops activities"
                },
                new AssetSubdivision
                {
                    SectionCode = "A",
                    Section = "Agriculture, Forestry and Fishing",
                    DivisionCode = "01",
                    DivisionDescription = "Crops and animal production, hunting and related service activities",
                    GroupCode = "017",
                    GroupDescription = "Hunting, trapping and related service activities "
                },

                // (2) Forestry and logging
                new AssetSubdivision
                {
                    SectionCode = "A",
                    Section = "Agriculture, Forestry and Fishing",
                    DivisionCode = "02",
                    DivisionDescription = "Forestry and logging",
                    GroupCode = "021",
                    GroupDescription = "Silviculture and other forestry activities"

                },
                new AssetSubdivision
                {
                    SectionCode = "A",
                    Section = "Agriculture, Forestry and Fishing",
                    DivisionCode = "02",
                    DivisionDescription = "Forestry and logging",
                    GroupCode = "022",
                    GroupDescription = "Logging"

                },
                new AssetSubdivision
                {
                    SectionCode = "A",
                    Section = "Agriculture, Forestry and Fishing",
                    DivisionCode = "02",
                    DivisionDescription = "Forestry and logging",
                    GroupCode = "023",
                    GroupDescription = "Gathering of non-wood forest products"

                },
                new AssetSubdivision
                {
                    SectionCode = "A",
                    Section = "Agriculture, Forestry and Fishing",
                    DivisionCode = "02",
                    DivisionDescription = "Forestry and logging",
                    GroupCode = "024",
                    GroupDescription = "Support services to forestry"

                },

                // (3) Fishing and aquaculture 
                new AssetSubdivision
                {
                    SectionCode = "A",
                    Section = "Agriculture, Forestry and Fishing",
                    DivisionCode = "03",
                    DivisionDescription = "Fishing and aquaculture",
                    GroupCode = "031",
                    GroupDescription = "Fishing"
                },
                new AssetSubdivision
                {
                    SectionCode = "A",
                    Section = "Agriculture, Forestry and Fishing",
                    DivisionCode = "03",
                    DivisionDescription = "Fishing and aquaculture",
                    GroupCode = "032",
                    GroupDescription = "Aquaculture"
                },

                //  (B)  <<MINING AND QUARRYING>> 

                // (5) Mining of coal and lignite 
                new AssetSubdivision
                {
                    SectionCode = "B",
                    Section = "Mining and Quarrying",
                    DivisionCode = "05",
                    DivisionDescription = "Mining of coal and lignite",
                    GroupCode = "051",
                    GroupDescription = "Mining of hard coal"
                },
                new AssetSubdivision
                {
                    SectionCode = "B",
                    Section = "Mining and Quarrying",
                    DivisionCode = "05",
                    DivisionDescription = "Mining of coal and lignite",
                    GroupCode = "052",
                    GroupDescription = "Mining of lignite"
                },

                // (6) Extraction of crude petroleum and natural gas 
                new AssetSubdivision
                {
                    SectionCode = "B",
                    Section = "Mining and Quarrying",
                    DivisionCode = "06",
                    DivisionDescription = "Extraction of crude petroleum and natural gas",
                    GroupCode = "061",
                    GroupDescription = "Extraction of crude petroleum"
                },
                new AssetSubdivision
                {
                    SectionCode = "B",
                    Section = "Mining and Quarrying",
                    DivisionCode = "06",
                    DivisionDescription = "Extraction of crude petroleum and natural gas",
                    GroupCode = "062",
                    GroupDescription = "Extraction of natural gas"
                },

                // (7) Mining of metal ores
                new AssetSubdivision
                {
                    SectionCode = "B",
                    Section = "Mining and Quarrying",
                    DivisionCode = "07",
                    DivisionDescription = "Mining of metal ores",
                    GroupCode = "071",
                    GroupDescription = "Mining of iron ores"
                },
                new AssetSubdivision
                {
                    SectionCode = "B",
                    Section = "Mining and Quarrying",
                    DivisionCode = "07",
                    DivisionDescription = "Mining of metal ores",
                    GroupCode = "072",
                    GroupDescription = "Mining of non-ferrous metal ores"
                },

                // (8) Other mining and quarrying
                new AssetSubdivision
                {
                    SectionCode = "B",
                    Section = "Mining and Quarrying",
                    DivisionCode = "08",
                    DivisionDescription = "Other mining and quarrying",
                    GroupCode = "081",
                    GroupDescription = "Quarrying of stone, sand and clay"
                },
                new AssetSubdivision
                {
                    SectionCode = "B",
                    Section = "Mining and Quarrying",
                    DivisionCode = "08",
                    DivisionDescription = "Other mining and quarrying",
                    GroupCode = "089",
                    GroupDescription = "Mining and quarrying n.e.c."
                },
                
                // (9) Mining support service activities
                new AssetSubdivision
                {
                    SectionCode = "B",
                    Section = "Mining and Quarrying",
                    DivisionCode = "09",
                    DivisionDescription = "Mining support service activities",
                    GroupCode = "091",
                    GroupDescription = "Support activities for petroleum and natural gas extraction"
                },
                new AssetSubdivision
                {
                    SectionCode = "B",
                    Section = "Mining and Quarrying",
                    DivisionCode = "09",
                    DivisionDescription = "Mining support service activities",
                    GroupCode = "099",
                    GroupDescription = "Support activities for other mining and quarrying"
                },

                //  (C)  <<MANUFACTURING>>

                // (10) Manufacture of food products
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "10",
                    DivisionDescription = "Manufacture of food products",
                    GroupCode = "101",
                    GroupDescription = "Processing and preserving of meat"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "10",
                    DivisionDescription = "Manufacture of food products",
                    GroupCode = "102",
                    GroupDescription = "Processing and preserving of fish, crustaceans and molluscs"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "10",
                    DivisionDescription = "Manufacture of food products",
                    GroupCode = "103",
                    GroupDescription = "Processing and preserving of fruit and vegetables"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "10",
                    DivisionDescription = "Manufacture of food products",
                    GroupCode = "104",
                    GroupDescription = "Manufacture of vegetable and animal oils and fats"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "10",
                    DivisionDescription = "Manufacture of food products",
                    GroupCode = "105",
                    GroupDescription = "Manufacture of dairy products"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "10",
                    DivisionDescription = "Manufacture of food products",
                    GroupCode = "106",
                    GroupDescription = "Manufacture of grain mill products, starches and starch products"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "10",
                    DivisionDescription = "Manufacture of food products",
                    GroupCode = "107",
                    GroupDescription = "Manufacture of other food products"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "10",
                    DivisionDescription = "Manufacture of food products",
                    GroupCode = "108",
                    GroupDescription = "Manufacture of prepared animal feeds"
                },

                // (11) Manufacture of beverages
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "11",
                    DivisionDescription = "Manufacture of beverages",
                    GroupCode = "110",
                    GroupDescription = "Manufacture of beverages"
                },

                // (12) Manufacture of tobacco products 
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "12",
                    DivisionDescription = "Manufacture of tobacco products",
                    GroupCode = "120",
                    GroupDescription = "Manufacture of tobacco products"
                },

                // (13) Manufacture of textiles
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "13",
                    DivisionDescription = "Manufacture of textiles",
                    GroupCode = "131",
                    GroupDescription = "Spinning, weaving and finishing of textiles"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "13",
                    DivisionDescription = "Manufacture of textiles",
                    GroupCode = "139",
                    GroupDescription = "Manufacture of other textiles"
                },

                // (14) Manufacture of wearing apparel
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "14",
                    DivisionDescription = "Manufacture of wearing apparel",
                    GroupCode = "141",
                    GroupDescription = "Manufacture of wearing apparel, except fur apparel"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "14",
                    DivisionDescription = "Manufacture of wearing apparel",
                    GroupCode = "142",
                    GroupDescription = "Manufacture of articles of fur"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "14",
                    DivisionDescription = "Manufacture of wearing apparel",
                    GroupCode = "143",
                    GroupDescription = "Manufacture of knitted and crocheted apparel"
                },

                // (15) Manufacture of leather and related products
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "15",
                    DivisionDescription = "Manufacture of leather and related products",
                    GroupCode = "151",
                    GroupDescription = "Tanning and dressing of leather; manufacture of luggage,handbags, saddlery and harness; dressing and dyeing of fur"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "15",
                    DivisionDescription = "Manufacture of leather and related products",
                    GroupCode = "152",
                    GroupDescription = "Manufacture of footwear"
                },

                // (16) Manufacture of wood and products of wood and cork,except furniture; manufacture of articles of straw and plaiting materials 
                new AssetSubdivision 
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "16",
                    DivisionDescription = "Manufacture of wood and products of wood and cork, except furniture; manufacture of articles of straw and plaiting materials ",
                    GroupCode = "161",
                    GroupDescription = "Sawmilling and planing of wood"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "16",
                    DivisionDescription = "Manufacture of wood and products of wood and cork, except furniture; manufacture of articles of straw and plaiting materials ",
                    GroupCode = "162",
                    GroupDescription = "Manufacture of products of wood, cork, straw and plaiting materials"
                },

                // (17) Manufacture of paper and paper products 
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "17",
                    DivisionDescription = "Manufacture of paper and paper products",
                    GroupCode = "170",
                    GroupDescription = "Manufacture of paper and paper products"
                },

                // (18) Printing and reproduction of recorded media
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "18",
                    DivisionDescription = "Printing and reproduction of recorded media",
                    GroupCode = "181",
                    GroupDescription = "Printing and service activities related to printing"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "18",
                    DivisionDescription = "Printing and reproduction of recorded media",
                    GroupCode = "182",
                    GroupDescription = "Reproduction of recorded media"
                },

                // (19) Manufacture of coke and refined petroleum products
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "19",
                    DivisionDescription = "Manufacture of coke and refined petroleum products",
                    GroupCode = "191",
                    GroupDescription = "Manufacture of coke oven products"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "19",
                    DivisionDescription = "Manufacture of coke and refined petroleum products",
                    GroupCode = "192",
                    GroupDescription = "Manufacture of refined petroleum products"
                },

                // (20) Manufacture of chemicals and chemical products 
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "20",
                    DivisionDescription = "Manufacture of chemicals and chemical products",
                    GroupCode = "201",
                    GroupDescription = "Manufacture of basic chemicals, fertilizers and nitrogen compounds, plastics and synthetic rubber in primary forms"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "20",
                    DivisionDescription = "Manufacture of chemicals and chemical products",
                    GroupCode = "202",
                    GroupDescription = "Manufacture of other chemical products"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "20",
                    DivisionDescription = "Manufacture of chemicals and chemical products",
                    GroupCode = "203",
                    GroupDescription = "Manufacture of man-made fibres"
                },

                // (21) Manufacture of basic pharmaceutical products and pharmaceutical preparations 
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "21",
                    DivisionDescription = "Manufacture of basic pharmaceutical products and pharmaceutical preparations",
                    GroupCode = "210",
                    GroupDescription = "Manufacture of pharmaceuticals, medicinal chemical and botanical products"
                },

                // (22) Manufacture of rubber and plastics products
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "22",
                    DivisionDescription = "Manufacture of rubber and plastics products",
                    GroupCode = "221",
                    GroupDescription = "Manufacture of rubber products"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "22",
                    DivisionDescription = "Manufacture of rubber and plastics products",
                    GroupCode = "222",
                    GroupDescription = "Manufacture of plastics products"
                },

                // (23) Manufacture of other non-metallic mineral products
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "23",
                    DivisionDescription = "Manufacture of other non-metallic mineral products",
                    GroupCode = "231",
                    GroupDescription = "Manufacture of glass and glass products"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "23",
                    DivisionDescription = "Manufacture of other non-metallic mineral products",
                    GroupCode = "239",
                    GroupDescription = "Manufacture of non-metallic mineral products n.e.c."
                },

                // (24) Manufacture of basic metals 
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "24",
                    DivisionDescription = "Manufacture of basic metals",
                    GroupCode = "241",
                    GroupDescription = "Manufacture of basic iron and steel"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "24",
                    DivisionDescription = "Manufacture of basic metals",
                    GroupCode = "242",
                    GroupDescription = "Manufacture of basic precious and other non-ferrous metals"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "24",
                    DivisionDescription = "Manufacture of basic metals",
                    GroupCode = "243",
                    GroupDescription = "Casting of metals"
                },

                // (25) Manufacture of fabricated metal products, except machinery and equipment
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "25",
                    DivisionDescription = "Manufacture of fabricated metal products, except machinery and equipment",
                    GroupCode = "251",
                    GroupDescription = "Manufacture of structural metal products, tanks, reservoirs and steam generators"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "25",
                    DivisionDescription = "Manufacture of fabricated metal products, except machinery and equipment",
                    GroupCode = "252",
                    GroupDescription = "Manufacture of weapons and ammunition"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "25",
                    DivisionDescription = "Manufacture of fabricated metal products, except machinery and equipment",
                    GroupCode = "259",
                    GroupDescription = "Manufacture of other fabricated metal products; metalworking service activities"
                },

                // (26) Manufacture of computer, electronic and optical products
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "26",
                    DivisionDescription = "Manufacture of computer, electronic and optical products",
                    GroupCode = "261",
                    GroupDescription = "Manufacture of electronic components and boards"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "26",
                    DivisionDescription = "Manufacture of computer, electronic and optical products",
                    GroupCode = "262",
                    GroupDescription = "Manufacture of computers and peripheral equipment"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "26",
                    DivisionDescription = "Manufacture of computer, electronic and optical products",
                    GroupCode = "263",
                    GroupDescription = "Manufacture of communication equipment"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "26",
                    DivisionDescription = "Manufacture of computer, electronic and optical products",
                    GroupCode = "264",
                    GroupDescription = "Manufacture of consumer electronics"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "26",
                    DivisionDescription = "Manufacture of computer, electronic and optical products",
                    GroupCode = "265",
                    GroupDescription = "Manufacture of measuring, testing, navigating and control equipment; watches and clocks"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "26",
                    DivisionDescription = "Manufacture of computer, electronic and optical products",
                    GroupCode = "266",
                    GroupDescription = "Manufacture of irradiation, electromedical and electrotherapeutic equipment"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "26",
                    DivisionDescription = "Manufacture of computer, electronic and optical products",
                    GroupCode = "267",
                    GroupDescription = "Manufacture of optical instruments and photographic equipment"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "26",
                    DivisionDescription = "Manufacture of computer, electronic and optical products",
                    GroupCode = "268",
                    GroupDescription = "Manufacture of magnetic and optical media"
                },


                // (27) Manufacture of electrical equipment
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "27",
                    DivisionDescription = "Manufacture of electrical equipment",
                    GroupCode = "271",
                    GroupDescription = "Manufacture of electric motors, generators, transformers and electricity distribution and control apparatus"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "27",
                    DivisionDescription = "Manufacture of electrical equipment",
                    GroupCode = "272",
                    GroupDescription = "Manufacture of batteries and accumulators"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "27",
                    DivisionDescription = "Manufacture of electrical equipment",
                    GroupCode = "273",
                    GroupDescription = "Manufacture of wiring and wiring devices"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "27",
                    DivisionDescription = "Manufacture of electrical equipment",
                    GroupCode = "274",
                    GroupDescription = "Manufacture of electric lighting equipment"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "27",
                    DivisionDescription = "Manufacture of electrical equipment",
                    GroupCode = "275",
                    GroupDescription = "Manufacture of domestic appliances"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "27",
                    DivisionDescription = "Manufacture of electrical equipment",
                    GroupCode = "279",
                    GroupDescription = "Manufacture of other electrical equipment"
                },
                

                // (28) Manufacture of machinery and equipment n.e.c. 
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "28",
                    DivisionDescription = "Manufacture of machinery and equipment n.e.c.",
                    GroupCode = "281",
                    GroupDescription = "Manufacture of general-purpose machinery"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "28",
                    DivisionDescription = "Manufacture of machinery and equipment n.e.c.",
                    GroupCode = "282",
                    GroupDescription = "Manufacture of special-purpose machinery"
                },

                // (29) Manufacture of motor vehicles, trailers and semitrailers
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "29",
                    DivisionDescription = "Manufacture of motor vehicles, trailers and semitrailers",
                    GroupCode = "291",
                    GroupDescription = "Manufacture of motor vehicles"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "29",
                    DivisionDescription = "Manufacture of motor vehicles, trailers and semitrailers",
                    GroupCode = "292",
                    GroupDescription = "Manufacture of bodies (coachwork) for motor vehicles; manufacture of trailers and semi-trailers"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "29",
                    DivisionDescription = "Manufacture of motor vehicles, trailers and semitrailers",
                    GroupCode = "293",
                    GroupDescription = "Manufacture of parts and accessories for motor vehicles"
                },

                // (30) Manufacture of other transport equipment
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "30",
                    DivisionDescription = "Manufacture of other transport equipment",
                    GroupCode = "301",
                    GroupDescription = "Building of ships and boats"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "30",
                    DivisionDescription = "Manufacture of other transport equipment",
                    GroupCode = "302",
                    GroupDescription = "Manufacture of railway locomotives and rolling stock"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "30",
                    DivisionDescription = "Manufacture of other transport equipment",
                    GroupCode = "303",
                    GroupDescription = "Manufacture of air and spacecraft and related machinery"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "30",
                    DivisionDescription = "Manufacture of other transport equipment",
                    GroupCode = "304",
                    GroupDescription = "Manufacture of military fighting vehicles"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "30",
                    DivisionDescription = "Manufacture of other transport equipment",
                    GroupCode = "309",
                    GroupDescription = "Manufacture of transport equipment n.e.c."
                },

                // (31) Manufacture of furniture
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "31",
                    DivisionDescription = "Manufacture of furniture",
                    GroupCode = "310",
                    GroupDescription = "Manufacture of furniture"
                },

                // (32) Other manufacturing
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "32",
                    DivisionDescription = "Other manufacturing",
                    GroupCode = "321",
                    GroupDescription = "Manufacture of jewellery, bijouterie and related articles"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "32",
                    DivisionDescription = "Other manufacturing",
                    GroupCode = "322",
                    GroupDescription = "Manufacture of musical instruments"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "32",
                    DivisionDescription = "Other manufacturing",
                    GroupCode = "323",
                    GroupDescription = "Manufacture of sports goods"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "32",
                    DivisionDescription = "Other manufacturing",
                    GroupCode = "324",
                    GroupDescription = "Manufacture of games and toys"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "32",
                    DivisionDescription = "Other manufacturing",
                    GroupCode = "325",
                    GroupDescription = "Manufacture of medical and dental instruments and supplies"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "32",
                    DivisionDescription = "Other manufacturing",
                    GroupCode = "329",
                    GroupDescription = "Other manufacturing n.e.c."
                },

                // (33) Repair and installation of machinery and equipment
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "33",
                    DivisionDescription = "Repair and installation of machinery and equipment",
                    GroupCode = "331",
                    GroupDescription = "Repair of fabricated metal products, machinery and equipment"
                },
                new AssetSubdivision
                {
                    SectionCode = "C",
                    Section = "Manufacturing",
                    DivisionCode = "33",
                    DivisionDescription = "Repair and installation of machinery and equipment",
                    GroupCode = "332",
                    GroupDescription = "Installation of industrial machinery and equipment"
                },


                // (D) <<ELECTRICITY, GAS, STEAM AND AIR CONDITIONING SUPPLY>>

                // (35) Electricity, gas, steam and air conditioning supply 
                new AssetSubdivision
                {
                    SectionCode = "D",
                    Section = "Electricity, Gas, Steam and Air conditioning supply",
                    DivisionCode = "35",
                    DivisionDescription = "Electricity, gas, steam and air conditioning supply",
                    GroupCode = "351",
                    GroupDescription = "Electric power generation, transmission and distribution"
                },
                new AssetSubdivision
                {
                    SectionCode = "D",
                    Section = "Electricity, Gas, Steam and Air conditioning supply",
                    DivisionCode = "35",
                    DivisionDescription = "Electricity, gas, steam and air conditioning supply",
                    GroupCode = "352",
                    GroupDescription = "Manufacture of gas; distribution of gaseous fuels through mains"
                },
                new AssetSubdivision
                {
                    SectionCode = "D",
                    Section = "Electricity, Gas, Steam and Air conditioning supply",
                    DivisionCode = "35",
                    DivisionDescription = "Electricity, gas, steam and air conditioning supply",
                    GroupCode = "353",
                    GroupDescription = "Steam and air conditioning supply "
                },

                // (E) <<WATER SUPPLY; SEWERAGE, WASTE MANAGEMENT AND REMEDIATION ACTIVITIES>>

                // (36) Water collection, treatment and supply 
                new AssetSubdivision
                {
                    SectionCode = "E",
                    Section = "Water Supply; Sewerage, Waste Management And Remediation Activities",
                    DivisionCode = "36",
                    DivisionDescription = "Water collection, treatment and supply",
                    GroupCode = "351",
                    GroupDescription = "Water collection, treatment and supply"
                },

                // (37) Sewerage 
                new AssetSubdivision
                {
                    SectionCode = "E",
                    Section = "Water Supply; Sewerage, Waste Management And Remediation Activities",
                    DivisionCode = "37",
                    DivisionDescription = "Sewerage",
                    GroupCode = "370",
                    GroupDescription = "Sewerage"
                },

                // (38) Waste collection, treatment and disposal activities; materials recovery
                new AssetSubdivision
                {
                    SectionCode = "E",
                    Section = "Water Supply; Sewerage, Waste Management And Remediation Activities",
                    DivisionCode = "38",
                    DivisionDescription = "Waste collection, treatment and disposal activities; materials recovery",
                    GroupCode = "381",
                    GroupDescription = "Waste collection"
                },
                new AssetSubdivision
                {
                    SectionCode = "E",
                    Section = "Water Supply; Sewerage, Waste Management And Remediation Activities",
                    DivisionCode = "38",
                    DivisionDescription = "Waste collection, treatment and disposal activities; materials recovery",
                    GroupCode = "382",
                    GroupDescription = "Waste treatment and disposal"
                },
                new AssetSubdivision
                {
                    SectionCode = "E",
                    Section = "Water Supply; Sewerage, Waste Management And Remediation Activities",
                    DivisionCode = "38",
                    DivisionDescription = "Waste collection, treatment and disposal activities; materials recovery",
                    GroupCode = "383",
                    GroupDescription = "Materials recovery"
                },

                // (39) Remediation activities and other waste management services 
                new AssetSubdivision
                {
                    SectionCode = "E",
                    Section = "Water Supply; Sewerage, Waste Management And Remediation Activities",
                    DivisionCode = "39",
                    DivisionDescription = "Remediation activities and other waste management services",
                    GroupCode = "390",
                    GroupDescription = "Remediation activities and other waste management services"
                },

                // (F) <<CONSTRUCTION>>
                
                // (41) Construction of buildings 
                new AssetSubdivision
                {
                    SectionCode = "F",
                    Section = "Construction",
                    DivisionCode = "41",
                    DivisionDescription = "Construction of buildings",
                    GroupCode = "410",
                    GroupDescription = "Construction of buildings"
                },

                // (42) Civil engineering
                new AssetSubdivision
                {
                    SectionCode = "F",
                    Section = "Construction",
                    DivisionCode = "42",
                    DivisionDescription = "Civil engineering",
                    GroupCode = "421",
                    GroupDescription = "Construction of roads and railways"
                },
                new AssetSubdivision
                {
                    SectionCode = "F",
                    Section = "Construction",
                    DivisionCode = "42",
                    DivisionDescription = "Civil engineering",
                    GroupCode = "422",
                    GroupDescription = "Construction of utility projects"
                },
                new AssetSubdivision
                {
                    SectionCode = "F",
                    Section = "Construction",
                    DivisionCode = "42",
                    DivisionDescription = "Civil engineering",
                    GroupCode = "429",
                    GroupDescription = "Construction of other civil engineering projects"
                },

                // (43) Specialized construction activities
                new AssetSubdivision
                {
                    SectionCode = "F",
                    Section = "Construction",
                    DivisionCode = "43",
                    DivisionDescription = "Specialized construction activities",
                    GroupCode = "431",
                    GroupDescription = "Demolition and site preparation"
                },
                new AssetSubdivision
                {
                    SectionCode = "F",
                    Section = "Construction",
                    DivisionCode = "43",
                    DivisionDescription = "Specialized construction activities",
                    GroupCode = "432",
                    GroupDescription = "Electrical, plumbing and other construction installation activities"
                },
                new AssetSubdivision
                {
                    SectionCode = "F",
                    Section = "Construction",
                    DivisionCode = "43",
                    DivisionDescription = "Specialized construction activities",
                    GroupCode = "433",
                    GroupDescription = "Building completion and finishing"
                },
                new AssetSubdivision
                {
                    SectionCode = "F",
                    Section = "Construction",
                    DivisionCode = "43",
                    DivisionDescription = "Specialized construction activities",
                    GroupCode = "439",
                    GroupDescription = "Other specialized construction activities"
                },

                // (G) <<WHOLESALE AND RETAIL TRADE; REPAIR OF MOTOR VEHICLES AND MOTORCYCLES>>

                // (45) Wholesale and retail trade and repair of motor vehicles and motorcycles
                new AssetSubdivision
                {
                    SectionCode = "G",
                    Section = "Wholesale And Retail Trade; Repair Of Motor Vehicles And Motorcycles",
                    DivisionCode = "45",
                    DivisionDescription = "Wholesale and retail trade and repair of motor vehicles and motorcycles",
                    GroupCode = "451",
                    GroupDescription = "Sale of motor vehicles"
                },
                new AssetSubdivision
                {
                    SectionCode = "G",
                    Section = "Wholesale And Retail Trade; Repair Of Motor Vehicles And Motorcycles",
                    DivisionCode = "45",
                    DivisionDescription = "Wholesale and retail trade and repair of motor vehicles and motorcycles",
                    GroupCode = "452",
                    GroupDescription = "Maintenance and repair of motor vehicles"
                },
                new AssetSubdivision
                {
                    SectionCode = "G",
                    Section = "Wholesale And Retail Trade; Repair Of Motor Vehicles And Motorcycles",
                    DivisionCode = "45",
                    DivisionDescription = "Wholesale and retail trade and repair of motor vehicles and motorcycles",
                    GroupCode = "453",
                    GroupDescription = "Sale of motor vehicle parts and accessories"
                },
                new AssetSubdivision
                {
                    SectionCode = "G",
                    Section = "Wholesale And Retail Trade; Repair Of Motor Vehicles And Motorcycles",
                    DivisionCode = "45",
                    DivisionDescription = "Wholesale and retail trade and repair of motor vehicles and motorcycles",
                    GroupCode = "454",
                    GroupDescription = "Sale, maintenance and repair of motorcycles and related parts and accessories"
                },

                // (46) Wholesale trade, except of motor vehicles and motorcycles
                new AssetSubdivision
                {
                    SectionCode = "G",
                    Section = "Wholesale And Retail Trade; Repair Of Motor Vehicles And Motorcycles",
                    DivisionCode = "46",
                    DivisionDescription = "Wholesale trade, except of motor vehicles and motorcycles",
                    GroupCode = "461",
                    GroupDescription = "Wholesale on a fee or contract basis"
                },
                new AssetSubdivision
                {
                    SectionCode = "G",
                    Section = "Wholesale And Retail Trade; Repair Of Motor Vehicles And Motorcycles",
                    DivisionCode = "46",
                    DivisionDescription = "Wholesale trade, except of motor vehicles and motorcycles",
                    GroupCode = "462",
                    GroupDescription = "Wholesale of agricultural raw materials and live animals"
                },
                new AssetSubdivision
                {
                    SectionCode = "G",
                    Section = "Wholesale And Retail Trade; Repair Of Motor Vehicles And Motorcycles",
                    DivisionCode = "46",
                    DivisionDescription = "Wholesale trade, except of motor vehicles and motorcycles",
                    GroupCode = "463",
                    GroupDescription = "Wholesale of food, beverages and tobacco"
                },
                new AssetSubdivision
                {
                    SectionCode = "G",
                    Section = "Wholesale And Retail Trade; Repair Of Motor Vehicles And Motorcycles",
                    DivisionCode = "46",
                    DivisionDescription = "Wholesale trade, except of motor vehicles and motorcycles",
                    GroupCode = "464",
                    GroupDescription = "Wholesale of household goods"
                },
                new AssetSubdivision
                {
                    SectionCode = "G",
                    Section = "Wholesale And Retail Trade; Repair Of Motor Vehicles And Motorcycles",
                    DivisionCode = "46",
                    DivisionDescription = "Wholesale trade, except of motor vehicles and motorcycles",
                    GroupCode = "465",
                    GroupDescription = "Wholesale of machinery, equipment and supplies"
                },
                new AssetSubdivision
                {
                    SectionCode = "G",
                    Section = "Wholesale And Retail Trade; Repair Of Motor Vehicles And Motorcycles",
                    DivisionCode = "46",
                    DivisionDescription = "Wholesale trade, except of motor vehicles and motorcycles",
                    GroupCode = "466",
                    GroupDescription = "Other specialized wholesale"
                },
                new AssetSubdivision
                {
                    SectionCode = "G",
                    Section = "Wholesale And Retail Trade; Repair Of Motor Vehicles And Motorcycles",
                    DivisionCode = "46",
                    DivisionDescription = "Wholesale trade, except of motor vehicles and motorcycles",
                    GroupCode = "469",
                    GroupDescription = "Non-specialized wholesale trade"
                },

                // (47) Retail trade, except of motor vehicles and motorcycles
                new AssetSubdivision
                {
                    SectionCode = "G",
                    Section = "Wholesale And Retail Trade; Repair Of Motor Vehicles And Motorcycles",
                    DivisionCode = "47",
                    DivisionDescription = "Retail trade, except of motor vehicles and motorcycles",
                    GroupCode = "471",
                    GroupDescription = "Retail sale in non-specialized stores"
                },
                new AssetSubdivision
                {
                    SectionCode = "G",
                    Section = "Wholesale And Retail Trade; Repair Of Motor Vehicles And Motorcycles",
                    DivisionCode = "47",
                    DivisionDescription = "Retail trade, except of motor vehicles and motorcycles",
                    GroupCode = "472",
                    GroupDescription = "Retail sale of food, beverages and tobacco in specialized stores"
                },
                new AssetSubdivision
                {
                    SectionCode = "G",
                    Section = "Wholesale And Retail Trade; Repair Of Motor Vehicles And Motorcycles",
                    DivisionCode = "47",
                    DivisionDescription = "Retail trade, except of motor vehicles and motorcycles",
                    GroupCode = "473",
                    GroupDescription = "Retail sale of automotive fuel in specialized stores"
                },
                new AssetSubdivision
                {
                    SectionCode = "G",
                    Section = "Wholesale And Retail Trade; Repair Of Motor Vehicles And Motorcycles",
                    DivisionCode = "47",
                    DivisionDescription = "Retail trade, except of motor vehicles and motorcycles",
                    GroupCode = "474",
                    GroupDescription = "Retail sale of information and communications equipment in specialized stores"
                },
                new AssetSubdivision
                {
                    SectionCode = "G",
                    Section = "Wholesale And Retail Trade; Repair Of Motor Vehicles And Motorcycles",
                    DivisionCode = "47",
                    DivisionDescription = "Retail trade, except of motor vehicles and motorcycles",
                    GroupCode = "475",
                    GroupDescription = "Retail sale of other household equipment in specialized stores"
                },
                new AssetSubdivision
                {
                    SectionCode = "G",
                    Section = "Wholesale And Retail Trade; Repair Of Motor Vehicles And Motorcycles",
                    DivisionCode = "47",
                    DivisionDescription = "Retail trade, except of motor vehicles and motorcycles",
                    GroupCode = "476",
                    GroupDescription = "Retail sale of cultural and recreation goods in specialized stores"
                },
                new AssetSubdivision
                {
                    SectionCode = "G",
                    Section = "Wholesale And Retail Trade; Repair Of Motor Vehicles And Motorcycles",
                    DivisionCode = "47",
                    DivisionDescription = "Retail trade, except of motor vehicles and motorcycles",
                    GroupCode = "477",
                    GroupDescription = "Retail sale of other goods in specialized stores"
                },
                new AssetSubdivision
                {
                    SectionCode = "G",
                    Section = "Wholesale And Retail Trade; Repair Of Motor Vehicles And Motorcycles",
                    DivisionCode = "47",
                    DivisionDescription = "Retail trade, except of motor vehicles and motorcycles",
                    GroupCode = "478",
                    GroupDescription = "Retail sale via stalls and markets"
                },
                new AssetSubdivision
                {
                    SectionCode = "G",
                    Section = "Wholesale And Retail Trade; Repair Of Motor Vehicles And Motorcycles",
                    DivisionCode = "47",
                    DivisionDescription = "Retail trade, except of motor vehicles and motorcycles",
                    GroupCode = "479",
                    GroupDescription = "Retail trade not in stores, stalls or markets"
                },


                // (H) <<TRANSPORTATION AND STORAGE>> 

                // (49) Land transport and transport via pipelines
                new AssetSubdivision
                {
                    SectionCode = "H",
                    Section = "Transportation And Storage",
                    DivisionCode = "49",
                    DivisionDescription = "Land transport and transport via pipelines",
                    GroupCode = "491",
                    GroupDescription = "Transport via railways"
                },
                new AssetSubdivision
                {
                    SectionCode = "H",
                    Section = "Transportation And Storage",
                    DivisionCode = "49",
                    DivisionDescription = "Land transport and transport via pipelines",
                    GroupCode = "492",
                    GroupDescription = "Other land transport"
                },
                new AssetSubdivision
                {
                    SectionCode = "H",
                    Section = "Transportation And Storage",
                    DivisionCode = "49",
                    DivisionDescription = "Land transport and transport via pipelines",
                    GroupCode = "493",
                    GroupDescription = "Transport via pipeline"
                },

                // (50) Water transport 
                new AssetSubdivision
                {
                    SectionCode = "H",
                    Section = "Transportation And Storage",
                    DivisionCode = "50",
                    DivisionDescription = "Water transport",
                    GroupCode = "501",
                    GroupDescription = "Sea and coastal water transport"
                },
                new AssetSubdivision
                {
                    SectionCode = "H",
                    Section = "Transportation And Storage",
                    DivisionCode = "50",
                    DivisionDescription = "Water transport",
                    GroupCode = "502",
                    GroupDescription = "Inland water transport"
                },

                // (51) Air transport
                new AssetSubdivision
                {
                    SectionCode = "H",
                    Section = "Transportation And Storage",
                    DivisionCode = "51",
                    DivisionDescription = "Air transport",
                    GroupCode = "511",
                    GroupDescription = "Passenger air transport"
                },
                new AssetSubdivision
                {
                    SectionCode = "H",
                    Section = "Transportation And Storage",
                    DivisionCode = "51",
                    DivisionDescription = "Air transport",
                    GroupCode = "512",
                    GroupDescription = "Freight air transport"
                },

                // (52) Warehousing and support activities for transportation
                new AssetSubdivision
                {
                    SectionCode = "H",
                    Section = "Transportation And Storage",
                    DivisionCode = "52",
                    DivisionDescription = "Warehousing and support activities for transportation",
                    GroupCode = "521",
                    GroupDescription = "Warehousing and storage"
                },
                new AssetSubdivision
                {
                    SectionCode = "H",
                    Section = "Transportation And Storage",
                    DivisionCode = "52",
                    DivisionDescription = "Warehousing and support activities for transportation",
                    GroupCode = "522",
                    GroupDescription = "Support activities for transportation"
                },

                // (53) Postal and courier activities 
                new AssetSubdivision
                {
                    SectionCode = "H",
                    Section = "Transportation And Storage",
                    DivisionCode = "53",
                    DivisionDescription = "Postal and courier activities",
                    GroupCode = "531",
                    GroupDescription = "Postal activities"
                },
                new AssetSubdivision
                {
                    SectionCode = "H",
                    Section = "Transportation And Storage",
                    DivisionCode = "53",
                    DivisionDescription = "Postal and courier activities",
                    GroupCode = "532",
                    GroupDescription = "Courier activities"
                },

                // (I) ACCOMMODATION AND FOOD SERVICE ACTIVITIES 

                // (55) Accommodation 
                new AssetSubdivision
                {
                    SectionCode = "I",
                    Section = "Accommodation And Food Service Activities",
                    DivisionCode = "55",
                    DivisionDescription = "Accommodation",
                    GroupCode = "551",
                    GroupDescription = "Short term accommodation activities"
                },
                new AssetSubdivision
                {
                    SectionCode = "I",
                    Section = "Accommodation And Food Service Activities",
                    DivisionCode = "55",
                    DivisionDescription = "Accommodation",
                    GroupCode = "552",
                    GroupDescription = "Camping grounds, recreational vehicle parks and trailer parks"
                },
                new AssetSubdivision
                {
                    SectionCode = "I",
                    Section = "Accommodation And Food Service Activities",
                    DivisionCode = "55",
                    DivisionDescription = "Accommodation",
                    GroupCode = "559",
                    GroupDescription = "Other accommodation"
                },

                // (56) Food and beverage service activities
                new AssetSubdivision
                {
                    SectionCode = "I",
                    Section = "Accommodation And Food Service Activities",
                    DivisionCode = "56",
                    DivisionDescription = "Food and beverage service activities",
                    GroupCode = "561",
                    GroupDescription = "Restaurants and mobile food service activities"
                },
                new AssetSubdivision
                {
                    SectionCode = "I",
                    Section = "Accommodation And Food Service Activities",
                    DivisionCode = "56",
                    DivisionDescription = "Food and beverage service activities",
                    GroupCode = "562",
                    GroupDescription = "Event catering and other food service activities"
                },
                new AssetSubdivision
                {
                    SectionCode = "I",
                    Section = "Accommodation And Food Service Activities",
                    DivisionCode = "56",
                    DivisionDescription = "Food and beverage service activities",
                    GroupCode = "563",
                    GroupDescription = "Beverage serving activities"
                },

                // (J) <<INFORMATION AND COMMUNICATION >>

                // (58) Publishing activities 
                new AssetSubdivision
                {
                    SectionCode = "J",
                    Section = "Information And Communication",
                    DivisionCode = "58",
                    DivisionDescription = "Publishing activities",
                    GroupCode = "581",
                    GroupDescription = "Publishing of books, periodicals and other publishing activities"
                },
                new AssetSubdivision
                {
                    SectionCode = "J",
                    Section = "Information And Communication",
                    DivisionCode = "58",
                    DivisionDescription = "Publishing activities",
                    GroupCode = "582",
                    GroupDescription = "Software publishing"
                },

                // (59) Motion picture, video and television programme production, sound recording and music publishing activities
                new AssetSubdivision
                {
                    SectionCode = "J",
                    Section = "Information And Communication",
                    DivisionCode = "59",
                    DivisionDescription = "Motion picture, video and television programme production, sound recording and music publishing activities",
                    GroupCode = "591",
                    GroupDescription = "Motion picture, video and television programme activities"
                },
                new AssetSubdivision
                {
                    SectionCode = "J",
                    Section = "Information And Communication",
                    DivisionCode = "59",
                    DivisionDescription = "Motion picture, video and television programme production, sound recording and music publishing activities",
                    GroupCode = "592",
                    GroupDescription = "Sound recording and music publishing activities"
                },

                // (60) Programming and broadcasting activities 
                new AssetSubdivision
                {
                    SectionCode = "J",
                    Section = "Information And Communication",
                    DivisionCode = "60",
                    DivisionDescription = "Programming and broadcasting activities",
                    GroupCode = "601",
                    GroupDescription = "Radio broadcasting"
                },
                new AssetSubdivision
                {
                    SectionCode = "J",
                    Section = "Information And Communication",
                    DivisionCode = "60",
                    DivisionDescription = "Programming and broadcasting activities",
                    GroupCode = "602",
                    GroupDescription = "Television programming and broadcasting activities"
                },

                // (61) Telecommunications 
                new AssetSubdivision
                {
                    SectionCode = "J",
                    Section = "Information And Communication",
                    DivisionCode = "61",
                    DivisionDescription = "Telecommunications",
                    GroupCode = "611",
                    GroupDescription = "Wired telecommunications activities"
                },
                new AssetSubdivision
                {
                    SectionCode = "J",
                    Section = "Information And Communication",
                    DivisionCode = "61",
                    DivisionDescription = "Telecommunications",
                    GroupCode = "612",
                    GroupDescription = "Wireless telecommunications activities"
                },
                new AssetSubdivision
                {
                    SectionCode = "J",
                    Section = "Information And Communication",
                    DivisionCode = "61",
                    DivisionDescription = "Telecommunications",
                    GroupCode = "613",
                    GroupDescription = "Satellite telecommunications activities"
                },
                new AssetSubdivision
                {
                    SectionCode = "J",
                    Section = "Information And Communication",
                    DivisionCode = "61",
                    DivisionDescription = "Telecommunications",
                    GroupCode = "619",
                    GroupDescription = "Other telecommunications activities"
                },

                // (62) Computer programming, consultancy and related activities 
                new AssetSubdivision
                {
                    SectionCode = "J",
                    Section = "Information And Communication",
                    DivisionCode = "62",
                    DivisionDescription = "Computer programming, consultancy and related activities",
                    GroupCode = "620",
                    GroupDescription = "Computer programming, consultancy and related activities"
                },

                // (63) Information service activities 
                new AssetSubdivision
                {
                    SectionCode = "J",
                    Section = "Information And Communication",
                    DivisionCode = "63",
                    DivisionDescription = "Information service activities",
                    GroupCode = "631",
                    GroupDescription = "Data processing, hosting and related activities; web portals"
                },
                new AssetSubdivision
                {
                    SectionCode = "J",
                    Section = "Information And Communication",
                    DivisionCode = "63",
                    DivisionDescription = "Information service activities",
                    GroupCode = "639",
                    GroupDescription = "Other information service activities"
                },


                // (K) FINANCIAL AND INSURANCE/TAKAFUL ACTIVITIES 

                // (64) Financial service activities, except insurance/takaful and pension funding
                new AssetSubdivision
                {
                    SectionCode = "K",
                    Section = "Financial And Insurance /Takaful Activities",
                    DivisionCode = "64",
                    DivisionDescription = "Financial Service Activities, Except Insurance/ Takaful And Pension Funding",
                    GroupCode = "641",
                    GroupDescription = "Monetary intermediation"
                },
                new AssetSubdivision
                {
                    SectionCode = "K",
                    Section = "Financial And Insurance /Takaful Activities",
                    DivisionCode = "64",
                    DivisionDescription = "Financial Service Activities, Except Insurance/ Takaful And Pension Funding",
                    GroupCode = "642",
                    GroupDescription = "Activities of holding companies"
                },
                new AssetSubdivision
                {
                    SectionCode = "K",
                    Section = "Financial And Insurance /Takaful Activities",
                    DivisionCode = "64",
                    DivisionDescription = "Financial Service Activities, Except Insurance/ Takaful And Pension Funding",
                    GroupCode = "643",
                    GroupDescription = "Trusts, funds and similar financial entities"
                },
                new AssetSubdivision
                {
                    SectionCode = "K",
                    Section = "Financial And Insurance /Takaful Activities",
                    DivisionCode = "64",
                    DivisionDescription = "Financial Service Activities, Except Insurance/ Takaful And Pension Funding",
                    GroupCode = "649",
                    GroupDescription = "Other financial service activities, except insurance/takaful and pension funding activities"
                },

                // (65) Insurance/takaful, reinsurance/retakaful and pension funding, except compulsory social security
                new AssetSubdivision
                {
                    SectionCode = "K",
                    Section = "Financial And Insurance /Takaful Activities",
                    DivisionCode = "65",
                    DivisionDescription = "Insurance/takaful, reinsurance/retakaful and pension funding, except compulsory social security",
                    GroupCode = "652",
                    GroupDescription = "Insurance/takaful"
                },
                new AssetSubdivision
                {
                    SectionCode = "K",
                    Section = "Financial And Insurance /Takaful Activities",
                    DivisionCode = "65",
                    DivisionDescription = "Insurance/takaful, reinsurance/retakaful and pension funding, except compulsory social security",
                    GroupCode = "651",
                    GroupDescription = "Reinsurance/retakaful"
                },
                new AssetSubdivision
                {
                    SectionCode = "K",
                    Section = "Financial And Insurance /Takaful Activities",
                    DivisionCode = "65",
                    DivisionDescription = "Insurance/takaful, reinsurance/retakaful and pension funding, except compulsory social security",
                    GroupCode = "653",
                    GroupDescription = "Pension funding"
                },

                // (66) Activities auxiliary to financial service and insurance/ takaful activities
                new AssetSubdivision
                {
                    SectionCode = "K",
                    Section = "Financial And Insurance /Takaful Activities",
                    DivisionCode = "66",
                    DivisionDescription = "Activities auxiliary to financial service and insurance/ takaful activities",
                    GroupCode = "661",
                    GroupDescription = "Activities auxiliary to financial service activities, except insurance/takaful and pension funding"
                },
                new AssetSubdivision
                {
                    SectionCode = "K",
                    Section = "Financial And Insurance /Takaful Activities",
                    DivisionCode = "66",
                    DivisionDescription = "Activities auxiliary to financial service and insurance/ takaful activities",
                    GroupCode = "662",
                    GroupDescription = "Activities auxiliary to insurance/takaful and pension funding"
                },
                new AssetSubdivision
                {
                    SectionCode = "K",
                    Section = "Financial And Insurance /Takaful Activities",
                    DivisionCode = "66",
                    DivisionDescription = "Activities auxiliary to financial service and insurance/ takaful activities",
                    GroupCode = "663",
                    GroupDescription = "Fund management activities"
                },

                // (L) REAL ESTATE ACTIVITIES 

                // (68) Real estate activities
                new AssetSubdivision
                {
                    SectionCode = "L",
                    Section = "Real Estate Activities",
                    DivisionCode = "68",
                    DivisionDescription = "Real estate activities",
                    GroupCode = "681",
                    GroupDescription = "Real estate activities with own or leased property"
                },
                new AssetSubdivision
                {
                    SectionCode = "L",
                    Section = "Real Estate Activities",
                    DivisionCode = "68",
                    DivisionDescription = "Real estate activities",
                    GroupCode = "682",
                    GroupDescription = "Real estate activities on a fee or contract basis"
                },

                // (M) PROFESSIONAL, SCIENTIFIC AND TECHNICAL ACTIVITIES

                // (69) Legal and accounting activities   
                new AssetSubdivision
                {
                    SectionCode = "M",
                    Section = "Professional, Scientific And Technical Activities",
                    DivisionCode = "69",
                    DivisionDescription = "Legal and accounting activities",
                    GroupCode = "691",
                    GroupDescription = "Legal activities"
                },
                new AssetSubdivision
                {
                    SectionCode = "M",
                    Section = "Professional, Scientific And Technical Activities",
                    DivisionCode = "69",
                    DivisionDescription = "Legal and accounting activities",
                    GroupCode = "692",
                    GroupDescription = "Accounting, bookkeeping and auditing activities; tax consultancy"
                },

                // (70) Activities of head offices; management consultancy activities
                new AssetSubdivision
                {
                    SectionCode = "M",
                    Section = "Professional, Scientific And Technical Activities",
                    DivisionCode = "70",
                    DivisionDescription = "Activities of head offices; management consultancy activities",
                    GroupCode = "701",
                    GroupDescription = "Activities of head offices"
                },
                new AssetSubdivision
                {
                    SectionCode = "M",
                    Section = "Professional, Scientific And Technical Activities",
                    DivisionCode = "70",
                    DivisionDescription = "Activities of head offices; management consultancy activities",
                    GroupCode = "702",
                    GroupDescription = "Management consultancy activities"
                },

                // (71) Architectural and engineering activities; technical testing and analysis
                new AssetSubdivision
                {
                    SectionCode = "M",
                    Section = "Professional, Scientific And Technical Activities",
                    DivisionCode = "71",
                    DivisionDescription = "Architectural and engineering activities; technical testing and analysis",
                    GroupCode = "711",
                    GroupDescription = "Architectural and engineering activities and related technical consultancy"
                },
                new AssetSubdivision
                {
                    SectionCode = "M",
                    Section = "Professional, Scientific And Technical Activities",
                    DivisionCode = "71",
                    DivisionDescription = "Architectural and engineering activities; technical testing and analysis",
                    GroupCode = "712",
                    GroupDescription = "Technical testing and analysis"
                },

                // (72) Scientific research and development 
                new AssetSubdivision
                {
                    SectionCode = "M",
                    Section = "Professional, Scientific And Technical Activities",
                    DivisionCode = "72",
                    DivisionDescription = "Scientific research and development",
                    GroupCode = "721",
                    GroupDescription = "Research and experimental development on natural sciences and engineering"
                },
                new AssetSubdivision
                {
                    SectionCode = "M",
                    Section = "Professional, Scientific And Technical Activities",
                    DivisionCode = "72",
                    DivisionDescription = "Scientific research and development",
                    GroupCode = "722",
                    GroupDescription = "Research and experimental development on social sciences and humanities"
                },

                // (73) Advertising and market research 
                new AssetSubdivision
                {
                    SectionCode = "M",
                    Section = "Professional, Scientific And Technical Activities",
                    DivisionCode = "73",
                    DivisionDescription = "Advertising and market research",
                    GroupCode = "731",
                    GroupDescription = "Advertising"
                },
                new AssetSubdivision
                {
                    SectionCode = "M",
                    Section = "Professional, Scientific And Technical Activities",
                    DivisionCode = "73",
                    DivisionDescription = "Advertising and market research",
                    GroupCode = "732",
                    GroupDescription = "Market research and public opinion polling"
                },

                // (74) Other professional, scientific and technical activities   
                new AssetSubdivision
                {
                    SectionCode = "M",
                    Section = "Professional, Scientific And Technical Activities",
                    DivisionCode = "74",
                    DivisionDescription = "Other professional, scientific and technical activities",
                    GroupCode = "741",
                    GroupDescription = "Specialized design activities"
                },
                new AssetSubdivision
                {
                    SectionCode = "M",
                    Section = "Professional, Scientific And Technical Activities",
                    DivisionCode = "74",
                    DivisionDescription = "Other professional, scientific and technical activities",
                    GroupCode = "742",
                    GroupDescription = "Photographic activities"
                },
                new AssetSubdivision
                {
                    SectionCode = "M",
                    Section = "Professional, Scientific And Technical Activities",
                    DivisionCode = "74",
                    DivisionDescription = "Other professional, scientific and technical activities",
                    GroupCode = "749",
                    GroupDescription = "Other professional, scientific and technical activities n.e.c."
                },

                // (75) Veterinary activities
                new AssetSubdivision
                {
                    SectionCode = "M",
                    Section = "Professional, Scientific And Technical Activities",
                    DivisionCode = "75",
                    DivisionDescription = "Veterinary activities",
                    GroupCode = "750",
                    GroupDescription = "Veterinary activities"
                },

                // (N) ADMINISTRATIVE AND SUPPORT SERVICE ACTIVITIES 

                // (77) Rental and leasing activities
                new AssetSubdivision
                {
                    SectionCode = "N",
                    Section = "Administrative And Support Service Activities",
                    DivisionCode = "77",
                    DivisionDescription = "Rental and leasing activities",
                    GroupCode = "771",
                    GroupDescription = "Renting and leasing of motor vehicles"
                },
                new AssetSubdivision
                {
                    SectionCode = "N",
                    Section = "Administrative And Support Service Activities",
                    DivisionCode = "77",
                    DivisionDescription = "Rental and leasing activities",
                    GroupCode = "772",
                    GroupDescription = "Renting and leasing of personal and household goods"
                },
                new AssetSubdivision
                {
                    SectionCode = "N",
                    Section = "Administrative And Support Service Activities",
                    DivisionCode = "77",
                    DivisionDescription = "Rental and leasing activities",
                    GroupCode = "773",
                    GroupDescription = "Renting and leasing of other machinery, equipment and tangible goods"
                },
                new AssetSubdivision
                {
                    SectionCode = "N",
                    Section = "Administrative And Support Service Activities",
                    DivisionCode = "77",
                    DivisionDescription = "Rental and leasing activities",
                    GroupCode = "774",
                    GroupDescription = "Leasing of intellectual property and similar products, except copyrighted works"
                },

                // (78) Employment activities 
                new AssetSubdivision
                {
                    SectionCode = "N",
                    Section = "Administrative And Support Service Activities",
                    DivisionCode = "78",
                    DivisionDescription = "Employment activities",
                    GroupCode = "781",
                    GroupDescription = "Activities of employment placement agencies"
                },
                new AssetSubdivision
                {
                    SectionCode = "N",
                    Section = "Administrative And Support Service Activities",
                    DivisionCode = "78",
                    DivisionDescription = "Employment activities",
                    GroupCode = "782",
                    GroupDescription = "Temporary employment agency activities"
                },
                new AssetSubdivision
                {
                    SectionCode = "N",
                    Section = "Administrative And Support Service Activities",
                    DivisionCode = "78",
                    DivisionDescription = "Employment activities",
                    GroupCode = "783",
                    GroupDescription = "Other human resources provision"
                },

                // (79) Travel agency, tour operator, reservation service and related activities
                new AssetSubdivision
                {
                    SectionCode = "N",
                    Section = "Administrative And Support Service Activities",
                    DivisionCode = "79",
                    DivisionDescription = "Travel agency, tour operator, reservation service and related activities",
                    GroupCode = "791",
                    GroupDescription = "Travel agency and tour operator activities"
                },
                new AssetSubdivision
                {
                    SectionCode = "N",
                    Section = "Administrative And Support Service Activities",
                    DivisionCode = "79",
                    DivisionDescription = "Travel agency, tour operator, reservation service and related activities",
                    GroupCode = "799",
                    GroupDescription = "Other reservation service and related activities"
                },

                // (80) Security and investigation activities 
                new AssetSubdivision
                {
                    SectionCode = "N",
                    Section = "Administrative And Support Service Activities",
                    DivisionCode = "80",
                    DivisionDescription = "Security and investigation activities",
                    GroupCode = "801",
                    GroupDescription = "Private security activities"
                },
                new AssetSubdivision
                {
                    SectionCode = "N",
                    Section = "Administrative And Support Service Activities",
                    DivisionCode = "80",
                    DivisionDescription = "Security and investigation activities",
                    GroupCode = "802",
                    GroupDescription = "Security systems service activities"
                },
                new AssetSubdivision
                {
                    SectionCode = "N",
                    Section = "Administrative And Support Service Activities",
                    DivisionCode = "80",
                    DivisionDescription = "Security and investigation activities",
                    GroupCode = "803",
                    GroupDescription = "Investigation activities"
                },

                // (81) Services to buildings and landscape activities 
                new AssetSubdivision
                {
                    SectionCode = "N",
                    Section = "Administrative And Support Service Activities",
                    DivisionCode = "81",
                    DivisionDescription = "Services to buildings and landscape activities",
                    GroupCode = "811",
                    GroupDescription = "Combined facilities support activities"
                },
                new AssetSubdivision
                {
                    SectionCode = "N",
                    Section = "Administrative And Support Service Activities",
                    DivisionCode = "81",
                    DivisionDescription = "Services to buildings and landscape activities",
                    GroupCode = "812",
                    GroupDescription = "Cleaning activities"
                },
                new AssetSubdivision
                {
                    SectionCode = "N",
                    Section = "Administrative And Support Service Activities",
                    DivisionCode = "81",
                    DivisionDescription = "Services to buildings and landscape activities",
                    GroupCode = "813",
                    GroupDescription = "Landscape care and maintenance service activities"
                },


                // (82) Office administrative, office support and other business support activities
                new AssetSubdivision
                {
                    SectionCode = "N",
                    Section = "Administrative And Support Service Activities",
                    DivisionCode = "82",
                    DivisionDescription = "Office administrative, office support and other business support activities",
                    GroupCode = "821",
                    GroupDescription = "Office administrative and support activities"
                },
                new AssetSubdivision
                {
                    SectionCode = "N",
                    Section = "Administrative And Support Service Activities",
                    DivisionCode = "82",
                    DivisionDescription = "Office administrative, office support and other business support activities",
                    GroupCode = "822",
                    GroupDescription = "Activities of call centres"
                },
                new AssetSubdivision
                {
                    SectionCode = "N",
                    Section = "Administrative And Support Service Activities",
                    DivisionCode = "82",
                    DivisionDescription = "Office administrative, office support and other business support activities",
                    GroupCode = "823",
                    GroupDescription = "Organization of conventions and trade shows"
                },
                new AssetSubdivision
                {
                    SectionCode = "N",
                    Section = "Administrative And Support Service Activities",
                    DivisionCode = "82",
                    DivisionDescription = "Office administrative, office support and other business support activities",
                    GroupCode = "829",
                    GroupDescription = "Business support service activities n.e.c."
                },


                // (O) <<PUBLIC ADMINISTRATION AND DEFENCE; COMPULSORY SOCIAL SECURITY>>

                // (84) Public administration and defence; compulsory social security
                new AssetSubdivision
                {
                    SectionCode = "O",
                    Section = "Public Administration And Defence; Compulsory Social Security",
                    DivisionCode = "84",
                    DivisionDescription = "Public administration and defence; compulsory social security",
                    GroupCode = "841",
                    GroupDescription = "Administration of the State and the economic and social policy of the community"
                },
                new AssetSubdivision
                {
                    SectionCode = "O",
                    Section = "Public Administration And Defence; Compulsory Social Security",
                    DivisionCode = "84",
                    DivisionDescription = "Public administration and defence; compulsory social security",
                    GroupCode = "842",
                    GroupDescription = "Provision of services to the community as a whole"
                },
                new AssetSubdivision
                {
                    SectionCode = "O",
                    Section = "Public Administration And Defence; Compulsory Social Security",
                    DivisionCode = "84",
                    DivisionDescription = "Public administration and defence; compulsory social security",
                    GroupCode = "843",
                    GroupDescription = "Compulsory social security activities"
                },

                // (P) <<EDUCATION>>

                // (85) Education
                new AssetSubdivision
                {
                    SectionCode = "P",
                    Section = "Education",
                    DivisionCode = "85",
                    DivisionDescription = "Education",
                    GroupCode = "851",
                    GroupDescription = "Pre-primary and primary education"
                },
                new AssetSubdivision
                {
                    SectionCode = "P",
                    Section = "Education",
                    DivisionCode = "85",
                    DivisionDescription = "Education",
                    GroupCode = "852",
                    GroupDescription = "Secondary education"
                },
                new AssetSubdivision
                {
                    SectionCode = "P",
                    Section = "Education",
                    DivisionCode = "85",
                    DivisionDescription = "Education",
                    GroupCode = "853",
                    GroupDescription = "Higher education"
                },
                new AssetSubdivision
                {
                    SectionCode = "P",
                    Section = "Education",
                    DivisionCode = "85",
                    DivisionDescription = "Education",
                    GroupCode = "854",
                    GroupDescription = "Other education"
                },
                new AssetSubdivision
                {
                    SectionCode = "P",
                    Section = "Education",
                    DivisionCode = "85",
                    DivisionDescription = "Education",
                    GroupCode = "855",
                    GroupDescription = "Educational support activities"
                },

                // (Q) <<HUMAN HEALTH AND SOCIAL WORK ACTIVITIES>>

                // (86) Human health activities
                new AssetSubdivision
                {
                    SectionCode = "Q",
                    Section = "Human Health And Social Work Activities",
                    DivisionCode = "86",
                    DivisionDescription = "Human health activities",
                    GroupCode = "861",
                    GroupDescription = "Hospital activities"
                },
                new AssetSubdivision
                {
                    SectionCode = "Q",
                    Section = "Human Health And Social Work Activities",
                    DivisionCode = "86",
                    DivisionDescription = "Human health activities",
                    GroupCode = "862",
                    GroupDescription = "Medical and dental practice activities"
                },
                new AssetSubdivision
                {
                    SectionCode = "Q",
                    Section = "Human Health And Social Work Activities",
                    DivisionCode = "86",
                    DivisionDescription = "Human health activities",
                    GroupCode = "869",
                    GroupDescription = "Other human health activities"
                },

                // (87) Residential care activities 
                new AssetSubdivision
                {
                    SectionCode = "Q",
                    Section = "Human Health And Social Work Activities",
                    DivisionCode = "87",
                    DivisionDescription = "Residential care activities",
                    GroupCode = "871",
                    GroupDescription = "Residential nursing care facilities"
                },
                new AssetSubdivision
                {
                    SectionCode = "Q",
                    Section = "Human Health And Social Work Activities",
                    DivisionCode = "87",
                    DivisionDescription = "Residential care activities",
                    GroupCode = "872",
                    GroupDescription = "Residential care activities for mental retardation, mental health and substance abuse"
                },
                new AssetSubdivision
                {
                    SectionCode = "Q",
                    Section = "Human Health And Social Work Activities",
                    DivisionCode = "87",
                    DivisionDescription = "Residential care activities",
                    GroupCode = "873",
                    GroupDescription = "Residential care activities for the elderly and disabled"
                },
                new AssetSubdivision
                {
                    SectionCode = "Q",
                    Section = "Human Health And Social Work Activities",
                    DivisionCode = "87",
                    DivisionDescription = "Residential care activities",
                    GroupCode = "879",
                    GroupDescription = "Other residential care activities"
                },

                // (88) Social work activities without accommodation 
                new AssetSubdivision
                {
                    SectionCode = "Q",
                    Section = "Human Health And Social Work Activities",
                    DivisionCode = "88",
                    DivisionDescription = "Social work activities without accommodation",
                    GroupCode = "881",
                    GroupDescription = "Social work activities without accommodation for the elderly and disabled"
                },
                new AssetSubdivision
                {
                    SectionCode = "Q",
                    Section = "Human Health And Social Work Activities",
                    DivisionCode = "88",
                    DivisionDescription = "Social work activities without accommodation",
                    GroupCode = "889",
                    GroupDescription = "Other social work activities without accommodation n.e.c."
                },

                // (R) ARTS, ENTERTAINMENT AND RECREATION 

                // (90) Creative, arts and entertainment activities
                new AssetSubdivision
                {
                    SectionCode = "R",
                    Section = "Arts, Entertainment And Recreation",
                    DivisionCode = "90",
                    DivisionDescription = "Creative, arts and entertainment activities",
                    GroupCode = "900",
                    GroupDescription = "Creative, arts and entertainment activities"
                },


                // (91) Libraries, archives, museums and other cultural activities
                new AssetSubdivision
                {
                    SectionCode = "R",
                    Section = "Arts, Entertainment And Recreation",
                    DivisionCode = "91",
                    DivisionDescription = "Creative, arts and entertainment activities",
                    GroupCode = "910",
                    GroupDescription = "Libraries, archives, museums and other cultural activities"
                },

                // (92) Gambling and betting activities 
                new AssetSubdivision
                {
                    SectionCode = "R",
                    Section = "Arts, Entertainment And Recreation",
                    DivisionCode = "92",
                    DivisionDescription = "Gambling and betting activities",
                    GroupCode = "920",
                    GroupDescription = "Gambling and betting activities"
                },

                // (93) Sports activities and amusement and recreation activities
                new AssetSubdivision
                {
                    SectionCode = "R",
                    Section = "Arts, Entertainment And Recreation",
                    DivisionCode = "93",
                    DivisionDescription = "Sports activities and amusement and recreation activities",
                    GroupCode = "931",
                    GroupDescription = "Sports activities"
                },
                new AssetSubdivision
                {
                    SectionCode = "R",
                    Section = "Arts, Entertainment And Recreation",
                    DivisionCode = "93",
                    DivisionDescription = "Sports activities and amusement and recreation activities",
                    GroupCode = "932",
                    GroupDescription = "Other amusement and recreation activities"
                },


                // (S) <<OTHER SERVICE ACTIVITIES>>

                // (94) Activities of membership organizations
                new AssetSubdivision
                {
                    SectionCode = "S",
                    Section = "Other Service Activities",
                    DivisionCode = "94",
                    DivisionDescription = "Activities of membership organizations",
                    GroupCode = "941",
                    GroupDescription = "Activities of business, employers and professional membership organizations"
                },
                new AssetSubdivision
                {
                    SectionCode = "S",
                    Section = "Other Service Activities",
                    DivisionCode = "94",
                    DivisionDescription = "Activities of membership organizations",
                    GroupCode = "942",
                    GroupDescription = "Activities of trade unions"
                },
                new AssetSubdivision
                {
                    SectionCode = "S",
                    Section = "Other Service Activities",
                    DivisionCode = "94",
                    DivisionDescription = "Activities of membership organizations",
                    GroupCode = "949",
                    GroupDescription = "Activities of other membership organizations"
                },

                // (95) Repair of computers and personal and household goods
                new AssetSubdivision
                {
                    SectionCode = "S",
                    Section = "Other Service Activities",
                    DivisionCode = "95",
                    DivisionDescription = "Repair of computers and personal and household goods",
                    GroupCode = "951",
                    GroupDescription = "Repair of computers and communication equipment"
                },
                new AssetSubdivision
                {
                    SectionCode = "S",
                    Section = "Other Service Activities",
                    DivisionCode = "95",
                    DivisionDescription = "Repair of computers and personal and household goods",
                    GroupCode = "952",
                    GroupDescription = "Repair of personal and household goods"
                },

                // (96) Other personal service activities 
                new AssetSubdivision
                {
                    SectionCode = "S",
                    Section = "Other Service Activities",
                    DivisionCode = "96",
                    DivisionDescription = "Other personal service activities",
                    GroupCode = "960",
                    GroupDescription = "Other personal service activities"
                },


                // (T) ACTIVITIES OF HOUSEHOLDS AS EMPLOYERS; UNDIFFERENTIATED GOODS AND SERVICES PRODUCING ACTIVITIES OF HOUSEHOLDS FOR OWN USE

                // (97) Activities of households as employers of domestic personnel
                new AssetSubdivision
                {
                    SectionCode = "T",
                    Section = "Activities of Households As Employers; Undifferentiated Goods And Services Producing Activities Of Households For Own use",
                    DivisionCode = "97",
                    DivisionDescription = "Activities of households as employers of domestic personnel",
                    GroupCode = "970",
                    GroupDescription = "Activities of households as employers of domestic personnel"
                },

                // (98) Undifferentiated goods and services producing activities of private households for own use
                new AssetSubdivision
                {
                    SectionCode = "T",
                    Section = "Activities of Households As Employers; Undifferentiated Goods And Services Producing Activities Of Households For Own use",
                    DivisionCode = "98",
                    DivisionDescription = "Undifferentiated goods and services producing activities of private households for own use",
                    GroupCode = "981",
                    GroupDescription = "Undifferentiated goods-producing activities of private households for own use"
                },
                new AssetSubdivision
                {
                    SectionCode = "T",
                    Section = "Activities of Households As Employers; Undifferentiated Goods And Services Producing Activities Of Households For Own use",
                    DivisionCode = "98",
                    DivisionDescription = "Undifferentiated goods and services producing activities of private households for own use",
                    GroupCode = "982",
                    GroupDescription = "Undifferentiated service-producing activities of private households for own use"
                },


                // (U) ACTIVITIES OF EXTRATERRITORIAL ORGANIZATIONS AND BODIES

                // (99) Activities of extraterritorial organizations and bodies 
                new AssetSubdivision
                {
                    SectionCode = "U",
                    Section = "Activities Of Extraterrotorial Organizations And Bodies",
                    DivisionCode = "99",
                    DivisionDescription = "Activities of extraterritorial organizations and bodies",
                    GroupCode = "990",
                    GroupDescription = "Activities of extraterritorial organizations and bodies"
                },
            };
        }
    }
}
