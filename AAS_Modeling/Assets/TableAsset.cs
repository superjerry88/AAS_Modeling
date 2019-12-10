using System.Collections.Generic;

namespace AAS_Modeling
{
    public class TableAsset<T> : BaseAsset
    {
        public bool HasDataModel;
        public List<DataModel> DataModels;

        public List<T> Values;
    }
}