using System.Collections.Generic;
using AAS_Core.Model.Enum;

namespace AAS_Core.Model.Assets
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