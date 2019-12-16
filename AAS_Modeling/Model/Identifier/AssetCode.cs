namespace AAS_Modeling.Model.Identifier
{
    public class AssetCode //Company Specific
    {
        public string IraiCode => $"{Site}{Area}{Process}{Code}";
        public string AssetDescription { get; set; }
        public string Site { get; set; }
        public string Area { get; set; }
        public string Process { get; set; }
        public string Code { get; set; }
   
    }
}