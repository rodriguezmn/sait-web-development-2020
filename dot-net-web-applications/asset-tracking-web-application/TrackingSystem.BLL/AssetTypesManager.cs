using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrackingSystem.Data;
using TrackingSystem.Domain;

namespace TrackingSystem.BLL
{
    public class AssetTypesManager
    {
        
        public static IList GetAsKeyValuePairs()
        {
            var context = new AssetsContext();
            var assetTypes = context.AssetTypes.Select(a => new
            {
                Value = a.Id,
                Text = a.Name
            }).ToList();

            return assetTypes;
        }

        public static void Add(AssetType assetType)
        {
            var context = new AssetsContext();
            context.AssetTypes.Add(assetType);
            context.SaveChanges();
        }
    }
}
