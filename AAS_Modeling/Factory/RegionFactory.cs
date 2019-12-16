using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using MoreLinq;

namespace AAS_Modeling.Factory
{
    class RegionFactory
    {
        public List<RegionInfo> GetAllRegionInfos()
        {
            // todo Note: There should be 191 country in the world but this only generate 138 + 3. Please find out why. 

            return CultureInfo.GetCultures(CultureTypes.AllCultures & ~CultureTypes.NeutralCultures)
                .Where(c => c.LCID != 127 & !c.IsNeutralCulture) // Remove Invariant Culture (127)
                .Select(cultureInfo => new RegionInfo(cultureInfo.LCID)) // Create Region Object based on LCID
                .Where(region => region.TwoLetterISORegionName.Length == 2)//remove weird code that are non 2 digit
                .DistinctBy(region => region.Name) // Remove repeated country
                .OrderBy(region => region.TwoLetterISORegionName)// Sort country
                .ToList();// convert to list

        }
    }
}
