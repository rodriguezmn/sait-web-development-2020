using Microsoft.EntityFrameworkCore.Migrations;

namespace TrackingSystem.Data.Migrations
{
    public partial class CreateAssestsIT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssetType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Asset",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagNumber = table.Column<string>(nullable: false),
                    AssetTypeId = table.Column<int>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: false),
                    SerialNumber = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asset", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asset_AssetType_AssetTypeId",
                        column: x => x.AssetTypeId,
                        principalTable: "AssetType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AssetType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Desktop Computer" });

            migrationBuilder.InsertData(
                table: "AssetType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Computer Monitor" });

            migrationBuilder.InsertData(
                table: "AssetType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Phone" });

            migrationBuilder.InsertData(
                table: "Asset",
                columns: new[] { "Id", "AssetTypeId", "Description", "Manufacturer", "Model", "SerialNumber", "TagNumber" },
                values: new object[,]
                {
                    { 3, 1, "Intel® Core™ i7-9700T (2 GHz base frequency, up to 4.3 GHz with Intel® Turbo Boost Technology, 12 MB cache, 8 cores)", "HP", "33BC850-W", "D1000402", "1001001" },
                    { 1, 2, "37.5\" Class 21:9 UltraGear™ Nano IPS 1ms Curved Gaming Monitor w / G - Sync®", "LG", "38GL950G-B", "N1000401", "1002001" },
                    { 2, 2, "34\" 21:9 UltraWide® WQHD Nano IPS Monitor with Thunderbolt™ 3", "LG", "34WL850-W", "N1000402", "1002002" },
                    { 4, 3, "The Cisco IP Phone 8800 Series is a great fit for businesses of all sizes seeking secure, high-quality, full-featured VoIP.", "Cisco", "IPPhone-8800", "C1000402", "1003001" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asset_AssetTypeId",
                table: "Asset",
                column: "AssetTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asset");

            migrationBuilder.DropTable(
                name: "AssetType");
        }
    }
}
