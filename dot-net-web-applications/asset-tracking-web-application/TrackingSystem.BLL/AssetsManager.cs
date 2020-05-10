using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TrackingSystem.Data;
using TrackingSystem.Domain;

namespace TrackingSystem.BLL
{
    public class AssetsManager
    {
        // get all assets

        public static List<Asset> GetAll()
        {
            var context = new AssetsContext();
            var assets = context.Assets.Include(a => a.AssetTypeNavProperty).ToList();


            // return assets collection
            
            return assets;
        }

        // get all assets by asset type

        public static List<Asset> GetAllByAssetType(int id)
        {
            var context = new AssetsContext();
            
            var assets = context.Assets.Where(a => a.AssetTypeId == id).Include(a => a.AssetTypeNavProperty).ToList();
            return assets;
        }


        // add asset object to context

        public static void Add(Asset asset)
        {
            var context = new AssetsContext();
            context.Assets.Add(asset);
            context.SaveChanges();
        }
    }
}
