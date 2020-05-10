using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackingSystem.BLL;
using TrackingSystem.Domain;
using TrackingSystem.Presentation.Models;

namespace TrackingSystem.Presentation.ViewComponents
{
    public class AssetsByTypeViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int id) 
        {
            // test id value and get all assets or assets by asset type

            List<Asset> assets = null; 

            if (id == 0) 
            {
                assets = AssetsManager.GetAll();
            }
            else
            {
                assets = AssetsManager.GetAllByAssetType(id);
            }


            var assetsHomeViewModel = assets.Select(a => new HomeViewModel
            {
                TagNumber = a.TagNumber,
                AssetTypeId = a.AssetTypeId.ToString(),
                AssetTypeName = a.AssetTypeNavProperty.Name,
                Description = a.Description,
                SerialNumber = a.SerialNumber
            }).ToList();


            // pass the view model to the view

            return View(assetsHomeViewModel);
        }
    }
}
