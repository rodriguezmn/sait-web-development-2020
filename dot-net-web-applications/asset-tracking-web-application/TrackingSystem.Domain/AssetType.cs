using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrackingSystem.Domain
{
    [Table("AssetType")]
    public class AssetType
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Asset Type")]
        public string Name { get; set; }


        // navigation property
        // multiplicity of remote end is many (*):
        // an asset type can have many assets

        public ICollection<Asset> AssetsNavProperty { get; set; }

    }
}
