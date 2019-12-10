using System.Collections.Generic;

namespace AAS_Modeling
{
    public class SingleAsset<T> : BaseAsset
    {
        public bool HasDataModel;
        public List<DataModel> DataModels;

        public bool HasKind;
        public AssetKind AssetKind;

        public bool HasSemantic;
        public string Sematic;

        public T Value;
    }
}