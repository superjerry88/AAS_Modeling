using MongoDB.Bson.Serialization.Attributes;

namespace AAS_Modeling.Model.Identifier
{
    public class AssetSubdivision //global
    {
        [BsonElement]
        public string IraiCode => ItemCode;
        public string Section { get; set; }
        public string SectionCode { get; set; }
        public string DivisionCode { get; set; }
        public string DivisionDescription { get; set; }
        public string GroupCode { get; set; }
        public string GroupDescription { get; set; }
        public string ItemCode { get; set; }
        public string ItemCodeDescription { get; set; }
    }
}