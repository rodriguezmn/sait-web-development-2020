using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrackingSystem.Domain
{
    [Table("Asset")]
    public class Asset
    {
        public int Id { get; set; }

        [Required] 
        public string TagNumber { get; set; }

        // Foreing key

        public int AssetTypeId { get; set; }

        [Required]
        public string Manufacturer { get; set; }

        public string Model { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string SerialNumber { get; set; }

        // navigation property
        // multiplicity of remote end is (1):
        // an asset can only be of one asset type

        public AssetType AssetTypeNavProperty { get; set; }

    }
}