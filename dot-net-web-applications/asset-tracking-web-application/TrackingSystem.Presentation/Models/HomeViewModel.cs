using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrackingSystem.Presentation.Models
{
    public class HomeViewModel
    {
        // use annotation for dispaly purposes 

        [Display(Name = "Tag Number")]
        public string TagNumber { get; set; }

        [Display(Name = "Asset Type Id")]
        public string AssetTypeId { get; set; } 

        [Display(Name = "Asset Type Name")]
        public string AssetTypeName { get; set; }

        public string Description { get; set; }
            
        [Display(Name = "Serial Number")]
        public string SerialNumber { get; set; }
    }
}
