using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TrackingSystem.BLL;
using TrackingSystem.Domain;

namespace TrackingSystem.Presentation.Controllers
{
    public class AssetsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            var assets = AssetTypesManager.GetAsKeyValuePairs();
            var assetTypes = new SelectList(assets, "Value", "Text");
            var list = assetTypes.ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "Select an Asset Type",
                Value = ""
            });

            ViewBag.AssetType = list;
            return View();
        }


        // create overloaded method to pass asset object 
        // to asset manager

        [HttpPost] 
        public IActionResult Create(Asset asset)
        {
            try
            {
                AssetsManager.Add(asset); 
                return RedirectToAction("Index", "Home"); 

            }
            catch
            {
                return View();
                
            }
        }
    }
}