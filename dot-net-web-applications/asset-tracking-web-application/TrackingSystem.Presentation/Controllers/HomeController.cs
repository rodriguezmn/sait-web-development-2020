using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using TrackingSystem.BLL;
using TrackingSystem.Presentation.Models;

namespace TrackingSystem.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // add asset types to ViewBag

            ViewBag.AssetTypes = GetAssetTypes();
            return View();

        }


        // call view component 

        public IActionResult GetAssetsByType(int id)
        {
            return ViewComponent("AssetsByType", id); 
        }


        protected IEnumerable GetAssetTypes()
        {
            // create asset types SelectListItem collection

            var types = AssetTypesManager.GetAsKeyValuePairs();
            var assetTypes = new SelectList(types, "Value", "Text");

            var list = assetTypes.ToList();

            // insert an elements to position 0 of list
            // value = 0 for html validation purposes

            list.Insert(0, new SelectListItem
            {
                Text = "All Asset Types",
                Value = "0"
            });
            return list;
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        

    }
}
