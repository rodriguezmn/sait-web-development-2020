using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrackingSystem.BLL;
using TrackingSystem.Domain;

namespace TrackingSystem.Presentation.Controllers
{
    public class AssetTypesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(AssetType assetType)
        {
            
            try
            {
                AssetTypesManager.Add(assetType); 
                return RedirectToAction("Create", "Assets"); 

            }
            catch
            {
                return View();

            }
        }
    }
}