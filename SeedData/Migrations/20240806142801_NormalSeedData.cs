using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeedData.Migrations
{
    public partial class NormalSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SanPhams",
                columns: new[] { "Id", "MoTa", "TenSanPham" },
                values: new object[,]
                {
                    { new Guid("11772746-d676-4046-8f16-d51d420afe98"), "SP3", "San pham 3" },
                    { new Guid("4b23fa81-784b-4b03-be59-4285b9b2d949"), "SP2", "San pham 2" },
                    { new Guid("4c73d08d-2157-4b8d-b4f9-d52528e3c8d6"), "SP4", "San pham 4" },
                    { new Guid("65197395-6baf-463b-8952-862efc23d831"), "SP1", "San pham 1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("11772746-d676-4046-8f16-d51d420afe98"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("4b23fa81-784b-4b03-be59-4285b9b2d949"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("4c73d08d-2157-4b8d-b4f9-d52528e3c8d6"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("65197395-6baf-463b-8952-862efc23d831"));
        }
    }
}
