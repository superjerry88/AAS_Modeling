namespace AAS_Modeling.Model.Identifier
{
    public class AssetSubdivision //global
    {
        public string IraiCode => $"{SectionCode}{DivisionCode}";
        public string Section { get; set; }
        public string SectionCode { get; set; }
        public string DivisionCode { get; set; }
        public string Description { get; set; }

    }
}