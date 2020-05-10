
// Course       ----------------- CPRG 214 - .NET web applications
// Assignment 2 ----------------- MVC Core
// Author       ----------------- Marlon Rodriguez
// Date         ----------------- May 5, 2020
// Instructor   ----------------- Tim Francis


// Project      ----------------- Create an MVC Core solution for a company Asset Tracking System
//                                Three pages are required for the application, a Home page 
//                                where all assets are shown in a table with the possibility
//                                of filtering by asset type, an Add Asset page with a form to
//                                add new assets to a data base and a Create Asset Type page 
//                                where new asset types can be created.

using Microsoft.EntityFrameworkCore;
using System;
using TrackingSystem.Domain;

namespace TrackingSystem.Data
{
    public class AssetsContext : DbContext
    {
        // AssetsContext() constructor referencing the base class constructor

        public AssetsContext() : base() {}

        // DbSet collection properties for the domain entities

        public DbSet<Asset> Assets { get; set; }

        public DbSet<AssetType> AssetTypes { get; set; }


        // set connection to sql server instance
        // set database name
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = .\sqlexpress;
                                          Database=ITAssets;
                                          Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // seed lookup table

            modelBuilder.Entity<AssetType>().HasData(

                new AssetType { Id = 1, Name = "Desktop Computer" },
                new AssetType { Id = 2, Name = "Computer Monitor" },
                new AssetType { Id = 3, Name = "Phone" }

                );


            // add test data

            modelBuilder.Entity<Asset>().HasData(
                new Asset
                {
                    Id = 1,
                    TagNumber = "1002001",
                    AssetTypeId = 2,
                    Manufacturer = "LG",
                    Model = "38GL950G-B",
                    Description = "37.5\" Class 21:9 UltraGear™ Nano IPS 1ms Curved Gaming Monitor w / G - Sync®",
                    SerialNumber = "N1000401",
                },

                new Asset
                {
                    Id = 2,
                    TagNumber = "1002002",
                    AssetTypeId = 2,
                    Manufacturer = "LG",
                    Model = "34WL850-W",
                    Description = "34\" 21:9 UltraWide® WQHD Nano IPS Monitor with Thunderbolt™ 3",
                    SerialNumber = "N1000402",
                },

                new Asset
                {
                    Id = 3,
                    TagNumber = "1001001",
                    AssetTypeId = 1,
                    Manufacturer = "HP",
                    Model = "33BC850-W",
                    Description = "Intel® Core™ i7-9700T (2 GHz base frequency, up to 4.3 GHz with Intel® Turbo Boost Technology, 12 MB cache, 8 cores)",
                    SerialNumber = "D1000402",
                },
                new Asset
                {
                    Id = 4,
                    TagNumber = "1003001",
                    AssetTypeId = 3,
                    Manufacturer = "Cisco",
                    Model = "IPPhone-8800",
                    Description = "The Cisco IP Phone 8800 Series is a great fit for businesses of all sizes seeking secure, high-quality, full-featured VoIP.",
                    SerialNumber = "C1000402",
                });
        }


    }
}
