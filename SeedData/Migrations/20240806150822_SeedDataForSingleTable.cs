using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeedData.Migrations
{
    public partial class SeedDataForSingleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DanhMucSanPham_DanhMuc_DanhMucsId",
                table: "DanhMucSanPham");

            migrationBuilder.DropForeignKey(
                name: "FK_DonHang_KhachHang_KhachHangId",
                table: "DonHang");

            migrationBuilder.DropForeignKey(
                name: "FK_DonHangSanPham_DonHang_DonHangsId",
                table: "DonHangSanPham");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KhachHang",
                table: "KhachHang");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DonHang",
                table: "DonHang");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DanhMuc",
                table: "DanhMuc");

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("012b5786-7fb0-4009-b256-ad19944a12ae"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("01331617-e6e4-4e34-9222-6966c0bd1c05"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("0564c8f6-530d-4e5f-a9be-f59d6a833daf"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("0a1d68ee-a835-48c9-bb41-5ab40db852ea"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("0c1e4f9b-fafe-49a2-99e2-5b0377054301"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("0e220c8a-d980-4d28-b199-15da6a652797"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("12661273-4cae-4306-86fc-a4080327ca9e"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("144fcc77-1401-4349-abfd-5f4c68a85f2b"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("19efdf76-6f4e-4db4-8606-7c2ab982ac9b"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("1c492bad-6856-4d18-b5eb-0bc3fa2f4f0a"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("20828531-8f4a-46cc-a2c5-1a8d4b2a3bd8"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("2435dbd9-bf3c-48dd-836c-a2890efe374f"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("2460a04f-83b3-4652-8a52-67960ed6e009"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("25b067ba-6cfe-4a05-9234-ccb5d7aa5180"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("295f2c69-b92f-40c7-985e-22d07f0da374"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("29cb9ac0-c4d0-4fd8-801e-eec474f0fa19"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("2b867c98-c6ec-4c9a-99bf-a81c816e8ca5"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("2c0f2ffc-b8e9-4d7a-8337-6b404c78ccfe"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("2cf2bdd8-b35f-4dc0-8d68-a8a552ce0304"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("2d51acbe-7b4f-40fb-8c77-f0342a6564f9"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("2ea8a5d8-27df-4db7-b5e9-83cb15c1661c"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("2f95194b-2071-4621-b28c-5c8d9d49bf57"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("3047918d-f5e4-4cef-bc43-02382e061971"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("31c9d4b7-7b7c-4104-8f3c-8835c7bf1e46"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("3210566f-e7ea-4ca3-9bc9-bd6d4aa9b7a6"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("32aa78bd-0099-41a5-ae21-73e080e873ab"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("32fb4a9c-a549-4914-83f0-8cd3f96fd517"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("3ea9290c-142a-4e13-b9bf-a13e4e2935ac"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("426a5d46-102c-44aa-96c7-9fa40705919e"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("43cc6937-39b5-4c4c-ae0a-8acaf3b4d1db"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("449513e1-c8a7-479a-99ba-014b6e2c1007"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("4503b4ad-0c3d-44f6-8c94-20112538b85d"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("45745fd8-b10d-4f6f-b44d-665df44721f6"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("46368202-3e68-4846-8ef3-be3cca89883b"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("47995fea-c252-4932-840d-a6ec53609934"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("4add607e-e33f-41ce-a7dd-bf1fb05ae852"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("4ea9c069-ac5b-4286-9be7-7d6ddc7dde89"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("5523a41f-5cc4-4008-8258-d16f38cc2d23"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("5b6ccb53-c581-4a0a-a707-3da54af99e33"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("5eda2955-a8e0-42a3-84f0-1ba4f9276f12"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("657f23ed-6673-4277-9b09-9fbb7183666f"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("667fdd58-a921-45a9-95cc-59712aef753d"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("66ef17d3-a2a0-49dd-8fa3-cb22cef29ca8"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("6cc4bd10-6789-4134-ae85-36657a7a7a8e"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("6d9a56f8-68d5-44eb-92b6-2ed35d8b54aa"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("6e8c0758-76f1-43a5-b165-8f07b07110d3"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("6f5878ee-7a3d-4265-bc24-d7b152c3fcf9"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("7087b96d-3969-41fe-9f1c-9888d70bbef5"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("70f7984a-68aa-475d-9115-c876b3f38b6f"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("74a6ca73-d184-453f-961b-a7b42223bb62"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("763eca15-659e-44ce-927b-6aadf31c2dd8"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("77814752-d512-4aa7-a516-83cddc5c3b70"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("79ae7527-141c-4ae9-bba2-3ed255cf2e7b"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("7b06842f-cc3c-417f-b5b5-50916cf81689"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("7f814ea1-9aed-4d26-b55c-90666f82309d"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("8271b6ca-07ab-407c-bf25-a8f93665dc38"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("857b46d9-8f74-4ea8-adc3-edda84ad03df"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("85b362fc-89fa-42f5-b11a-efb80f7d9daf"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("884e9a8f-2bba-4897-8dc6-ca3d40163591"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("91f38fb1-89bd-475f-88ac-84ec805c6062"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("962c406f-d36b-4209-931a-a49b584be5a1"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("99c78f04-9d0c-4131-a122-72616c20f90c"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("99f20d0d-a0df-46b5-925b-e0b98dd21026"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("9b0bcd82-a47b-4cb9-a18e-4f40af65fd61"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("9d90bcfc-6891-40f4-92cb-876074fe847a"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("a0ce9c34-e191-4f88-b282-b2bd7d9fb75e"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("a31d4559-9079-48b3-8173-520c8c8af1bd"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("a3dc3a4d-6edc-4a17-a9e9-6ec030a177c7"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("a6cb1577-9603-4491-937e-99869ed62e1b"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("a835d51a-b29f-45d6-a035-7d5171aad78c"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("b5982e5d-48a4-4a08-9106-96a732d97eb2"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("b59859df-0fe3-423b-ad64-2920f577fc02"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("b83eddaa-f17d-4c62-b1a3-886385fa897d"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("bb602b54-637e-41b3-a07f-5da683e603be"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("bfee866c-e60e-4d91-bccf-b3c7ec9bd50b"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("c2c39541-7fed-4efd-a055-0dcf54a9b613"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("c94fbf04-0b7f-46db-8f2a-9428ddd6b44c"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("cada3c78-1f1e-4e1a-9b8c-ae9195ccc34d"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("cb1e8602-dbec-46fa-9c16-e213270d3293"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("d47c7060-59d0-4282-be26-8a10738dcb4f"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("d63745cc-c683-4b21-a26c-341829ae02fc"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("d7d2a933-f74d-4415-868c-9cb78c63bb40"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("d8737759-92c9-4966-a13d-343b941d8a00"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("dc07b6e4-eb92-4cd3-9270-46fc549c9004"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("dd29f7d4-f3d2-49b7-a8be-a85432dcaa1e"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("de73e9df-a484-479a-a2e1-921accd7c77b"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("e3362938-d1be-4a88-bfc8-b60fe8865c7f"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("e44307d7-886d-441f-9bfb-368ba3647095"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("e6301a2c-2276-4acc-a8ae-4b4138acd213"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("e872b304-ebc3-4494-a5a9-2859625ac9d1"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("e96c09b6-21db-4ef4-90b1-4dd39c8ba613"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("e9d16bdb-4a00-44cd-bec8-20557698c0b6"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("eaaf1e2f-3ec4-42af-a384-e7c9b6f24e5b"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("ef95f26a-ecd7-4909-b28a-792a040c8784"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("f090572c-966c-411e-b6d4-115e02962e05"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("f411948f-9a55-44a7-afcb-6973527cee7f"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("f46d4d2b-db80-44b7-9396-414e261f5e19"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("f85b5190-50c7-4d65-b0b2-05b44b3a3b01"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("f8f8f00a-94bf-4166-a613-df69b78519c7"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("fbc12cad-380f-4b69-9496-488430854fce"));

            migrationBuilder.RenameTable(
                name: "KhachHang",
                newName: "KhachHangs");

            migrationBuilder.RenameTable(
                name: "DonHang",
                newName: "DonHangs");

            migrationBuilder.RenameTable(
                name: "DanhMuc",
                newName: "DanhMucs");

            migrationBuilder.RenameIndex(
                name: "IX_DonHang_KhachHangId",
                table: "DonHangs",
                newName: "IX_DonHangs_KhachHangId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KhachHangs",
                table: "KhachHangs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DonHangs",
                table: "DonHangs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DanhMucs",
                table: "DanhMucs",
                column: "Id");

            migrationBuilder.InsertData(
                table: "DanhMucs",
                columns: new[] { "Id", "MoTa", "TenDanhMuc" },
                values: new object[,]
                {
                    { new Guid("149d55c1-1027-4a7b-9f7c-27d50557e199"), "Được vẽ giết lỗi bốn đá tôi kim.", "Shoes" },
                    { new Guid("1a0515c6-6cd7-4ba4-a2b2-a2217bd8a429"), "Ừ em áo.", "Movies" },
                    { new Guid("6bad827e-d128-473d-8369-b7ce6f0bc6fe"), "Vẽ bảy ác ngọt tám.", "Shoes" },
                    { new Guid("6d44c2ea-4772-409b-bd9a-cb7fdda1c5a0"), "Năm hết trời.", "Health" },
                    { new Guid("8e3b803e-0d4d-4863-b237-3e178a0b6d66"), "Mướn viết á được nón đang bảy bạn một thuê.", "Health" },
                    { new Guid("982681a8-5e92-40d0-a323-abbadea23773"), "Đang hóa đỏ gì thuê leo ác.", "Garden" },
                    { new Guid("9c873fc8-2b52-4657-a221-b3857d47082a"), "Vẽ leo vàng.", "Beauty" },
                    { new Guid("a2a221e2-9e50-4f75-b8c9-9d0004267fb6"), "Lầu đập không bốn được ba độc ờ ghế.", "Health" },
                    { new Guid("e22f142e-8f31-45f7-9ec5-484dccc0dafe"), "Là núi đã vá giày không leo hóa dép nón.", "Toys" },
                    { new Guid("f7a6080a-1314-4bd7-9b5b-3a9dabccf9dd"), "Vẽ chín ghét quần em giết bàn khoảng sáu.", "Movies" }
                });

            migrationBuilder.InsertData(
                table: "KhachHangs",
                columns: new[] { "Id", "DiaChi", "Email", "HoTen", "SoDienThoai" },
                values: new object[,]
                {
                    { new Guid("052538e6-f9b6-4bd1-98e0-6e7d6744fb4a"), "0704 Lê Knoll, Thái Bình, Latvia", "MinhKhai_Ho@gmail.com", "Uyên My Đỗ", "024 9595 1503" },
                    { new Guid("063fdb59-1945-4f6e-85e3-5f57321287f9"), "87828 Kim Thảo Knoll, Đồng Tháp, México", "VuongTrieu.Ngo@gmail.com", "Hiền Chung Hoàng", "029 5409 4721" },
                    { new Guid("0667960a-b942-408f-9aa5-8591f0e0599a"), "159 Vũ Pines, Điện Biên, Venezuela", "NhatQuoc36@hotmail.com", "Thái Thanh Hà", "023 1645 0090" },
                    { new Guid("0b23e0d1-fa5b-4022-92b8-ff158e6d60ed"), "7849 Phạm Islands, Hà Nam, Dominica", "NamDuong.Dang60@yahoo.com", "Hải Phong Mai", "026 5156 6972" },
                    { new Guid("0bd930d6-b736-4558-87c1-50bd97e08db0"), "441 Quỳnh Tiên Turnpike, Bình Phước, Haiti", "NgocLy.Hoang@hotmail.com", "Tâm Ðoan Hồ", "025 1203 3130" },
                    { new Guid("1248d1fb-1e80-4ded-926b-6b7f6d2249a5"), "78248 Mai Pass, Bình Định, Lào", "HongPhuong_Le@hotmail.com", "Vũ Hồng Đào", "022 8791 0962" },
                    { new Guid("15883dbe-e97e-4859-86f7-993bbc1173df"), "6597 Minh Danh Ridge, Kiên Giang, Tunisia", "MinhThac_Vu68@hotmail.com", "Minh Ân Lý", "020 7671 5609" },
                    { new Guid("17544f0d-9e01-4955-b49a-dcc4b6a770ee"), "6125 Trịnh Island, Long An, Zambia", "PhuocSon10@yahoo.com", "Ấu Lăng Hà", "028 2179 6719" },
                    { new Guid("17652753-332f-4654-89d0-bbca6d67670f"), "45632 Danh Văn Ranch, Đắk Lắk, Myanmar", "AnhThi_Le@gmail.com", "Phi Phượng Phan", "026 5338 2887" },
                    { new Guid("1c79d0c4-56b9-4b08-af15-2fddc2c1068e"), "11276 Bùi Route, Vĩnh Phúc, Uganda", "DucHanh.Dinh@hotmail.com", "Quế Phương Dương", "024 4521 1019" },
                    { new Guid("1cab312c-e326-4c44-ae00-5542888dfbc9"), "360 Uyên Thy Shore, Bình Thuận, Tunisia", "KieuGiang.Pham96@hotmail.com", "Hải Ðăng Tô", "023 0233 5332" },
                    { new Guid("1d71e542-620f-4161-9842-a2a145bd7013"), "8053 Sơn Ca Cliffs, Lào Cai, Afghanistan", "DieuNga_Do@yahoo.com", "Gia Khanh Trịnh", "024 4855 6145" },
                    { new Guid("1e3c140e-4cab-4065-aadd-2c1cfed5ce14"), "668 Quốc Thịnh Islands, Hải Phòng, Việt Nam", "DanTam_Le@hotmail.com", "Tuyết Hồng Hồ", "026 8935 4679" },
                    { new Guid("21d87d9e-43c6-46d1-bfee-644940fd9d64"), "17232 Huy Thông Expressway, Tuyên Quang, Thụy Điển", "ThuyNgoc35@gmail.com", "Minh Khai Lê", "021 5750 9524" },
                    { new Guid("22ebc934-105f-4b38-ab74-feae23d1ffc0"), "4653 Đào Trail, Bà Rịa-Vũng Tàu, Mauritanie", "KimAnh.Bui@gmail.com", "Thúy My Đinh", "020 7497 8342" },
                    { new Guid("232fdc99-53fe-4232-9c74-06ddfb2a13b8"), "4671 Thượng Nghị Corner, Tiền Giang, Brasil", "MinhPhuong69@hotmail.com", "Anh Chi Tăng", "021 9841 1968" },
                    { new Guid("24256d4c-7032-4437-8c1e-dd211c5bd713"), "59556 Nguyễn Run, Đắk Nông, Palau", "SonTrang_Ho17@yahoo.com", "Kim Yến Đinh", "029 6657 4732" },
                    { new Guid("2463d0a4-5008-43f5-97fd-bbd3d0048d8e"), "2827 Kiều Mai Way, Cần Thơ, Liechtenstein", "BichHai.Dao35@yahoo.com", "Phương Trâm Mai", "027 6485 7278" },
                    { new Guid("2528ff79-cf89-4261-a0de-428d26b20a72"), "6103 Quốc Trụ Light, Lâm Đồng, Nepal", "NamThong_Lam@yahoo.com", "Việt Anh Vương", "029 7660 1416" },
                    { new Guid("28d8da78-c6c4-4afe-9d92-22d52e3969b0"), "798 Gia Hoàng Port, Đắk Nông, Estonia", "QuangHuy.Mai96@gmail.com", "Diễm My Tăng", "021 5510 2407" },
                    { new Guid("28eaff52-a12b-4084-83b9-02a26ca7dfbc"), "3943 Liên Hương Loop, Đà Nẵng, Litva", "ThuanThanh_To49@yahoo.com", "Nguyệt Ánh Hồ", "028 2660 7198" },
                    { new Guid("297e58cc-55d1-4c96-81c1-edd1b4b0ffb7"), "6205 Đoàn Coves, Quảng Nam, Litva", "PhuongLong.Bui@yahoo.com", "Thanh Minh Trịnh", "027 4300 8660" },
                    { new Guid("2db3541e-b13b-4e4b-b634-f31e8982b5e1"), "6124 Đào Rest, Hà Nam, Albania", "DieuLinh.Phan16@yahoo.com", "Thanh Thủy Mai", "023 3166 1788" },
                    { new Guid("2f5efba5-6605-4ccc-9a86-918b9bd19b8b"), "572 Đặng Rapids, Vĩnh Phúc, Síp", "AnTuong13@yahoo.com", "Yên Bằng Lâm", "023 8919 6195" },
                    { new Guid("33caf896-8425-48e6-86b5-a47f32bb1850"), "4547 Lý Light, Tây Ninh, Liberia", "DuyThanh.Tang@hotmail.com", "Như Trân Vũ", "020 6141 8845" },
                    { new Guid("38ba8024-3b8d-4dd6-92b9-9d06da12ec6e"), "71631 Uy Vũ Port, Hải Dương, Đức", "KienVan_Bui@hotmail.com", "Công Giang Hà", "023 2012 4775" },
                    { new Guid("3cd8e5f4-df7e-4a22-84a3-04966bad5197"), "78343 Tâm Nhi Gardens, Cao Bằng, Belize", "HaBang.Dao29@hotmail.com", "Tuyết Lan Tăng", "020 8029 9429" },
                    { new Guid("3da3214c-bd0e-4377-a9dd-da000298cefd"), "740 Diệu Hương Creek, Hà Tĩnh, Bangladesh", "HoanChau76@hotmail.com", "Phương Triều Vũ", "029 4106 3454" },
                    { new Guid("3fd74fb4-2450-440d-8497-d9a630f57199"), "92178 Liên Hương Freeway, Bình Thuận, Cộng hòa Congo", "KhanhChi.Truong28@hotmail.com", "Mỹ Hường Đoàn", "021 6062 2835" },
                    { new Guid("427269be-9018-4cf4-9818-4fae14114ae4"), "7578 Đỗ Run, Long An, Ukraina", "YenMai.Tran90@hotmail.com", "Quang Hữu Vương", "026 5432 7726" },
                    { new Guid("44514479-669b-45b2-8af4-510b0786de9b"), "44305 Đặng Roads, TP. Hồ Chí Minh, Tây Ban Nha", "XuanBinh_Doan@yahoo.com", "Thanh Thiên Tô", "023 1845 4941" },
                    { new Guid("45859554-61d6-4f50-90eb-b40d19a17909"), "66430 Phùng Pine, Khánh Hoà, România", "MinhMinh23@gmail.com", "Khôi Vĩ Đặng", "023 1047 5986" }
                });

            migrationBuilder.InsertData(
                table: "KhachHangs",
                columns: new[] { "Id", "DiaChi", "Email", "HoTen", "SoDienThoai" },
                values: new object[,]
                {
                    { new Guid("46685f7f-ca60-41b6-8cfb-4124c89cd625"), "13849 Ngọc Thy Mountains, Quảng Ngãi, Solomon", "TamKhanh.Mai25@hotmail.com", "Lệ Huyền Phạm", "029 3969 7340" },
                    { new Guid("4ebf8ce2-efc1-4c0d-8c61-7159ede74521"), "082 Quỳnh Trang Flats, Bình Dương, Oman", "HieuHoc83@hotmail.com", "Khánh Giang Trần", "024 0400 7198" },
                    { new Guid("5611f5df-6d74-47b4-b24b-5863bd50f032"), "269 Nguyễn Isle, Bình Phước, Ireland", "TrungLuc.Ho6@gmail.com", "Nguyên Sử Mai", "023 0950 9073" },
                    { new Guid("590c7122-bbd8-408c-9571-b8d385d97b9e"), "081 Trần Keys, Quảng Trị, Albania", "YenDan_Mai0@hotmail.com", "Giao Hưởng Phùng", "020 1764 2695" },
                    { new Guid("5bc8e452-e383-427e-bc9b-c26642f1a642"), "183 Ngô Corners, Hòa Bình, Sierra Leone", "NgocHai64@hotmail.com", "Việt Hồng Đào", "028 3674 7273" },
                    { new Guid("5e4be06c-1976-4755-aeb0-28dae4b4298b"), "2407 Ánh Nguyệt Village, Quảng Trị, Maroc", "ManhTrinh33@hotmail.com", "Duy Mỹ Trần", "025 0049 8854" },
                    { new Guid("5ee23c83-8a7a-498c-96a6-f2bc6fdc8136"), "0673 Vương Keys, Cà Mau, Tây Ban Nha", "ThuanPhuong_Dinh@hotmail.com", "Xuân Hoa Vũ", "023 7988 6908" },
                    { new Guid("5f3cfe10-1a7a-45c2-8fcb-c7e90692dbc4"), "446 Hoàng Viaduct, Sơn La, Lào", "NhatHuy_Le65@hotmail.com", "Quế Thu Bùi", "023 1580 3587" },
                    { new Guid("6212ef8f-9777-42a2-ad28-a2ed1ebe90f8"), "866 Tô Island, Long An, Guinée", "ThucDinh51@yahoo.com", "Việt Anh Hồ", "024 6871 0795" },
                    { new Guid("63021a65-455d-454a-92ee-525601ead4df"), "931 Trúc Cương Drive, Bình Định, Solomon", "AnhNguyet_Tang@yahoo.com", "Hiền Minh Đặng", "026 3505 5988" },
                    { new Guid("648119d0-d486-40c5-bd23-69a5e42b2ba5"), "045 Mai Trafficway, Gia Lai, Trung Phi", "ThanhCong21@gmail.com", "Bảo Thúy Dương", "026 2641 1627" },
                    { new Guid("697709be-b252-4405-bb7e-8673c6b98467"), "80158 Phạm Grove, Sóc Trăng, Ukraina", "MinhHuong17@yahoo.com", "Việt Thắng Vương", "027 3587 9993" },
                    { new Guid("6b4bca52-0cf9-4a9e-98cf-0eb6e3c24da0"), "84213 Lý Street, Đắk Nông, Mông Cổ", "PhuongThuy.Pham27@hotmail.com", "Thục Nhi Hoàng", "027 2647 0282" },
                    { new Guid("6d1e80c0-f438-45cd-a63c-9bf2330160b6"), "34261 Việt Cương Lodge, Tiền Giang, Uganda", "ThanhTuan_Vuong@yahoo.com", "Thuận Phương Phùng", "024 9184 3376" },
                    { new Guid("6e20d02e-a4a6-4614-83ac-f23bb4548158"), "68625 Tô Fields, Quảng Ninh, Oman", "VanThuy.Bui91@hotmail.com", "Thanh Yến Lâm", "028 4400 6476" },
                    { new Guid("6f10d3da-6328-4453-bd18-d299e75dca49"), "7849 Hiếu Phong Canyon, Hà Nội, Saint Lucia", "HaTien.Pham96@hotmail.com", "Việt Ngọc Trần", "024 1775 2402" },
                    { new Guid("6f2bc11e-7dd7-4049-9e35-163927214820"), "386 Xuân Quân Highway, Đồng Nai, Hungary", "ThienDuc_Dang@hotmail.com", "Quỳnh Chi Phan", "022 5475 8815" },
                    { new Guid("6fdebd38-1ce1-416f-af92-047978b186a5"), "4119 Phan Forge, An Giang, Bangladesh", "ThucDoan81@hotmail.com", "Hữu Vượng Hồ", "021 6532 4382" },
                    { new Guid("7395222e-7744-4172-86d1-1b128230fabf"), "20560 Nguyễn Ranch, An Giang, Belarus", "BaoHue.Dang56@hotmail.com", "Ngọc Minh Hà", "027 8827 1518" },
                    { new Guid("75fe592b-5c1e-4814-a459-627bef01098f"), "602 Nhật Bảo Long Drive, Đồng Nai, Malta", "AnBinh20@hotmail.com", "Phúc Nguyên Mai", "026 8216 6790" },
                    { new Guid("7b94208a-340f-4ed0-ad44-07a96fbc7d7a"), "842 Trương Shore, Quảng Nam, Slovenia", "ThuyNgan95@hotmail.com", "Nguyên Phong Dương", "020 4072 3089" },
                    { new Guid("841db90c-5f81-482a-a955-f91fc637a7f7"), "04866 Vương Overpass, Nam Định, Latvia", "ThanhDanh_Doan@gmail.com", "Lan Chi Đoàn", "025 5538 7620" },
                    { new Guid("873734f8-2118-4bff-95ec-9e199770cefb"), "444 Phi Nhạn Mountains, Sóc Trăng, Trung Quốc", "KimMai_Ho@yahoo.com", "Như Quân Hồ", "021 0102 4452" },
                    { new Guid("88603d45-af2e-4381-b8d8-2c53ebbaccd2"), "807 Vũ Parks, Hà Giang, Na Uy", "KhacCong.Tran@gmail.com", "Minh Dân Vương", "020 5072 7746" },
                    { new Guid("886111c9-af92-447f-91bf-dad7b8a03eb5"), "5742 Lê Port, Hậu Giang, Haiti", "KimHoang21@hotmail.com", "Quý Khánh Đỗ", "026 5447 5038" },
                    { new Guid("88888a0c-f1ed-4613-9646-ee6509dc5db0"), "44406 Thái Thảo Rapid, Đà Nẵng, Brasil", "ThanhMai.Vu28@gmail.com", "Thành Doanh Nguyễn", "029 0021 0697" },
                    { new Guid("893b3fb0-9647-4958-b835-676e382779e7"), "50579 Minh Hào Land, Bình Thuận, Ethiopia", "BichHang85@yahoo.com", "Tuấn Kiệt Hồ", "024 7720 7656" },
                    { new Guid("8bc08888-8550-4e72-9b5e-71845b5b9567"), "263 Anh Vũ Fork, Trà Vinh, Fiji", "NamThanh7@gmail.com", "Ý Nhi Tô", "020 9143 3083" },
                    { new Guid("90ece793-c6f5-47e7-8aa0-7c08ff3548fb"), "180 Đặng Camp, An Giang, Afghanistan", "ThuyLinh.Hoang@yahoo.com", "Ngọc Trinh Hồ", "025 4120 1782" },
                    { new Guid("90fb9bfe-da70-4392-9904-4417fab257a7"), "18018 Lê Island, Thừa Thiên-Huế, Việt Nam", "XuanLieu62@yahoo.com", "Hoàng Lâm Tô", "027 4479 2046" },
                    { new Guid("920b6ceb-11fd-4534-8c78-0adccdc2cbf5"), "95601 Tăng Corner, Hà Nội, Bolivia", "BichQuyen.Nguyen@yahoo.com", "Nhật Nam Tô", "020 2090 3996" },
                    { new Guid("93fb1f32-f25c-41b4-91a2-c22a92a4ab83"), "786 Cát Uy Isle, Quảng Ninh, Barbados", "HongDang20@hotmail.com", "Mai Trinh Tăng", "028 8499 5845" },
                    { new Guid("952cbe13-c448-4063-910c-4a6b51e895ce"), "81581 Đỗ Track, Bắc Giang, Áo", "SyDan_Doan93@hotmail.com", "Tấn Trình Tô", "021 4943 6326" },
                    { new Guid("9865321a-433a-4caa-8050-884b34c7c8d8"), "023 Lâm Views, Trà Vinh, Triều Tiên", "CamYen65@gmail.com", "Thông Ðạt Tô", "029 0912 5811" },
                    { new Guid("99eb34d9-432d-450c-9c9f-1f90d43caf39"), "6731 Lê Turnpike, Cao Bằng, Trinidad và Tobago", "ThuNguyet.Tang31@yahoo.com", "Tiểu Quỳnh Lý", "026 1410 1832" },
                    { new Guid("9e65dc79-3d73-4629-8551-a5f2b9cfe2a4"), "45146 Lâm Vista, Hà Giang, Trung Quốc", "HieuLiem.Vu12@hotmail.com", "Ngọc Danh Đào", "020 6518 3079" },
                    { new Guid("9f2dcec6-cc02-45d6-95d0-fa0b53a5f953"), "353 Trọng Vinh Village, Bà Rịa-Vũng Tàu, Kyrgyzstan", "ThiThi.Vu@hotmail.com", "Khắc Kỷ Tô", "027 0680 1326" },
                    { new Guid("a2e054b5-4260-4454-a995-281c00600f11"), "9778 Hồ Circles, Bắc Kạn, Nepal", "ThanhTuyen.Hoang9@gmail.com", "Thanh Loan Vương", "022 8241 9002" },
                    { new Guid("a38bfc8c-feac-4053-b76e-84c4e66d74d6"), "5930 Hằng Anh Wells, Lào Cai, Antigua và Barbuda", "ThaoTrang_To@gmail.com", "Trường Liên Hồ", "027 5366 3175" },
                    { new Guid("a51f9433-2477-4445-8a69-d24c50d95afb"), "169 Lê Ramp, Bắc Ninh, Belarus", "BaoHue.Truong@gmail.com", "Ngọc Oanh Phùng", "024 0875 2800" },
                    { new Guid("a89b1694-3065-45be-9b67-fb5d87dc35f5"), "58272 Hồ Drive, Nam Định, Macedonia", "ThuVong4@gmail.com", "Kiều Loan Đặng", "026 1273 3772" },
                    { new Guid("a99891d8-254d-4ec7-8cae-cf3bcb8c10a1"), "1779 Tô Wells, Hà Tĩnh, Trinidad và Tobago", "HuuTam_Ly18@yahoo.com", "Nguyệt Nga Dương", "028 4796 7432" }
                });

            migrationBuilder.InsertData(
                table: "KhachHangs",
                columns: new[] { "Id", "DiaChi", "Email", "HoTen", "SoDienThoai" },
                values: new object[,]
                {
                    { new Guid("b0074e79-8782-48c2-b497-9ae7bd24e960"), "009 Mai Trinh Shoal, Cà Mau, Sierra Leone", "MaiChau.Dang@yahoo.com", "Lan Thương Trần", "022 1649 9022" },
                    { new Guid("b22bc921-a93c-4461-8bd3-df4b1e010bc1"), "88224 Bùi Brooks, Đắk Lắk, Nhật Bản", "CongPhung59@hotmail.com", "Thanh Nhã Ngô", "027 5468 8492" },
                    { new Guid("b41438f5-9380-4cd7-bc4d-59267b9b760c"), "5637 Lâm Lights, Đắk Nông, Djibouti", "TrongViet.Vu58@hotmail.com", "Thu Huyền Dương", "029 5719 0199" },
                    { new Guid("b4a06e76-1c1e-4cac-aaa1-572d7a607954"), "92465 Hàm Duyên Locks, Sóc Trăng, Ý", "HaiUyen.Vu85@gmail.com", "Tuấn Long Dương", "024 0093 7760" },
                    { new Guid("b78d1e60-56cf-4058-967c-7271f646af05"), "504 Công Phụng Parkway, Bình Dương, Solomon", "HoaiVy.Hoang86@gmail.com", "Ðức Tài Trịnh", "024 4994 0540" },
                    { new Guid("c06db99e-509c-4391-b257-6799307a8b3c"), "6299 Thu Huệ Haven, Khánh Hoà, Phần Lan", "KimHoang.Truong12@gmail.com", "Tích Thiện Bùi", "026 3145 2184" },
                    { new Guid("c0ebc03b-08bf-4b16-89e2-4c86dec71a59"), "732 Dương Crescent, Quảng Ngãi, Luxembourg", "PhuongDung_Phan@gmail.com", "Uyên Vi Trịnh", "025 7816 1100" },
                    { new Guid("c93b2790-efbb-4887-bc62-908698026478"), "840 Tăng Ways, Phú Thọ, Swaziland", "QuangVu.Vu55@hotmail.com", "Kiều Loan Đào", "022 6478 3126" },
                    { new Guid("cba2380d-ac66-4bca-9da1-3db07a53966f"), "54737 Hoàng Lâm Extensions, Kiên Giang, Tunisia", "TuyetVan.Pham@hotmail.com", "Xuân Khoa Vũ", "023 0701 1233" },
                    { new Guid("cce9a706-5e55-4052-a88e-26f4b6765bc9"), "9959 Ðông Trà Mountain, Bình Thuận, Panama", "QuocDien.Dang@gmail.com", "Trọng Kiên Đỗ", "027 3286 4242" },
                    { new Guid("ceeb839d-d443-4791-8018-561c89d6e7d9"), "45338 Đặng Knoll, Khánh Hoà, Kyrgyzstan", "NamNinh.Dao61@hotmail.com", "Thái Hà Đào", "028 3858 0858" },
                    { new Guid("d15c8331-36ed-417a-b1fa-5f377c4c9930"), "4025 Bình Ðạt Street, Vĩnh Long, Venezuela", "ThuLinh70@hotmail.com", "Thành An Tăng", "023 7912 3397" },
                    { new Guid("d43ed679-0d22-40c7-a14a-6d01fe86c193"), "634 Việt Hoàng Circle, Kon Tum, Mali", "ThanhNhan79@hotmail.com", "Linh Phương Phùng", "023 0967 2959" },
                    { new Guid("d5d71173-e817-45f8-9146-4b7ab7c7b686"), "1532 Trúc Phương Mountain, Nghệ An, Samoa", "TinhNhu36@hotmail.com", "Minh Thủy Lâm", "023 7766 9531" },
                    { new Guid("d6d20276-ac8b-44d6-9939-d642e6335c51"), "21106 Phan Roads, Sơn La, Oman", "NgocKhue13@hotmail.com", "Thiên Mỹ Hoàng", "028 3118 1778" },
                    { new Guid("d84600ec-9767-4cd9-8221-62d22397acaa"), "3938 Ngọc Diệp Locks, Quảng Ninh, Tanzania", "LamGiang_Ly@yahoo.com", "Bảo An Đặng", "028 3805 2017" },
                    { new Guid("e56e8c86-41ee-47fd-9d05-a94a167bed10"), "17462 Ðình Chương Springs, Hậu Giang, Armenia", "KhoiNguyen.Ly@hotmail.com", "Mộng Thu Phan", "022 2746 4490" },
                    { new Guid("e9d684aa-183f-423f-8741-1a53cfb8f2e3"), "4938 Lâm Heights, Đồng Tháp, Hà Lan", "ThanhNhan_Mai47@yahoo.com", "Hồng Nhung Phạm", "028 0446 4401" },
                    { new Guid("eb503b18-f1e1-4a47-8871-99a4746eb8c6"), "54772 Phùng Field, Gia Lai, Indonesia", "DinhNhan.Doan70@gmail.com", "Yến Ðan Nguyễn", "024 9224 4597" },
                    { new Guid("ec92935c-29c1-47d3-9ff2-3aed6a0974f2"), "10751 Hồ Greens, Hải Dương, Iceland", "PhungYen_Tang41@hotmail.com", "Hữu Minh Vũ", "020 6799 8364" },
                    { new Guid("f0f1e5c8-88d3-4268-9c48-f6a85560db57"), "445 Tô Ways, Cà Mau, Fiji", "BaoThach21@gmail.com", "Hiền Hòa Mai", "024 1378 5979" },
                    { new Guid("f4a61b17-322c-4071-bb9d-c0378e5c9669"), "035 Lý Light, Phú Thọ, São Tomé và Príncipe", "QuynhNgan_Le72@yahoo.com", "Khánh Linh Vũ", "021 7120 6990" },
                    { new Guid("f9a1bd2e-de1a-42b8-b894-7f7e0b5b38f1"), "199 Mai Harbors, Cần Thơ, Argentina", "PhiDiep52@hotmail.com", "Đông Trà Đào", "023 8849 9774" },
                    { new Guid("fa016e07-09ad-491e-a261-85cdebb45436"), "4683 Thanh Ngân Springs, Bình Dương, Saint Lucia", "HaiThuy86@yahoo.com", "Việt Phong Vương", "024 2828 0702" },
                    { new Guid("fafc2111-6b48-4585-8074-65bb860d42ae"), "518 Phương Dung Brook, Thái Nguyên, Papua New Guinea", "UyenNhi49@gmail.com", "Thiên An Lý", "025 4991 2084" },
                    { new Guid("fd9917bd-45e9-4bab-839f-7f5b5cbf03e7"), "549 Dương River, Bắc Kạn, Brasil", "HaiBinh.Do53@gmail.com", "Hải Anh Ngô", "026 4248 2304" }
                });

            migrationBuilder.InsertData(
                table: "SanPhams",
                columns: new[] { "Id", "GiaBan", "MoTa", "SoLuongTon", "TenSanPham" },
                values: new object[,]
                {
                    { new Guid("0129a943-1e72-4a87-a6ad-5474891cdfa1"), 129.99m, "Bàn trăng dép chết giày kim khâu ừ tủ chìm biết làm anh xanh tím con tàu quê khoan bốn bàn khâu sáu lầu trăng hết xanh bảy đập vẽ đã lỗi ba thế khâu giết đập trăng là nón thôi anh tàu ừ khoan khoan ruộng mượn đá một.", 579, "Rustic Rubber Bacon" },
                    { new Guid("01dbc7fe-cb57-4b01-b41f-b388e3ed6f5b"), 919.25m, "Bàn xe tàu nhà chín bảy đồng vẽ ghét hai đập đang leo tàu nhà chết lầu trăng bơi kim leo vàng đâu xe độc tui thuê độc mượn ờ chết khoảng vẽ gió mười yêu em nha trời núi em mua giết lầu cái tui trời chết chết nước.", 756, "Small Frozen Salad" },
                    { new Guid("0e11ed77-a966-4f24-9f20-433689ec3513"), 487.82m, "Mua làm đá mượn bè vẽ độc tàu trời con gì nhà hương trăng đâu phá khoảng độc mướn nghỉ bè đỏ tím thế tui lỗi leo tôi đồng không bảy tô tủ đâu ruộng độc gió áo trời em ruộng đã xe chết mười may kim hai gió một.", 975, "Incredible Cotton Chair" },
                    { new Guid("1179548e-0bfd-464c-bab8-1a8c58a827df"), 652.57m, "Đập tám bảy nghỉ ba á yêu hàng gió thuyền hết thuê dép không may ngọt hàng ruộng mượn đâu hai bơi gió núi hương gì quần đánh được ruộng áo trời hàng độc đập bốn trời bốn cái chín em bạn bạn tủ cửa chết biển phá gì á.", 360, "Awesome Cotton Chicken" },
                    { new Guid("118ee715-cd4c-4bdd-ad60-d2221336d27e"), 148.76m, "Cửa yêu bảy vá em tàu lỗi lỗi máy chỉ tôi dép thế chín biển làm năm ờ đỏ đã gió xuồng chết hàng mướn tui mười leo nhà hương yêu hương độc một thích hết được lỗi ờ cửa độc lỗi thuê dép phá yêu hương sáu áo bàn.", 877, "Fantastic Concrete Cheese" },
                    { new Guid("18b0122b-d6b9-400e-aa86-9b4f724ac4a8"), 325.11m, "Con đồng khoảng ruộng đồng bảy trời bè tàu việc bè vàng con không đồng tô chín biết bè mua tô giày lỗi một chỉ ờ thôi đạp ruộng bốn xanh xe hết nước đập bạn một chìm áo khoan mượn biển biển chết đập khoảng bảy thích lầu nha.", 786, "Fantastic Fresh Pants" },
                    { new Guid("1d507181-b2ea-46ec-a3f1-31f699e7d228"), 835.40m, "Quần vàng một độc ngọt thôi nhà lỗi cửa nhà nhà cái thì ba xe bè giày làm dép tím trăng ghế gió ruộng hóa thuyền ừ ghế ờ may chìm thuê bè đập chìm ghét khâu ờ khoan không giày hết đạp quê đang thế ờ hết trời lầu.", 927, "Awesome Cotton Ball" },
                    { new Guid("1d6d36c3-5760-48a1-8345-c79eaace0a6e"), 119.95m, "Xuồng leo thì nhà việc nha may thích đạp trăng đang xe việc yêu không bơi yêu tím chỉ biển yêu mua biển giết tui chỉ con anh quê bàn không hết hai con sáu bảy làm sáu đâu là ghét lỗi hết đã bè cái đạp trăng bạn chín.", 0, "Intelligent Fresh Chair" },
                    { new Guid("2244967b-1619-414d-864f-e5f4cb0d837b"), 54.00m, "Được làm máy đá hết mười quần con ngọt vàng tủ ghế leo mượn phá năm giày chỉ mây hết giết bảy không vẽ anh là xuồng bàn anh đá ghế cái khoan xuồng em khâu khoảng sáu máy biển em tui giày bốn chìm dép khoan hàng lỗi được.", 229, "Licensed Metal Pizza" },
                    { new Guid("25397315-0f41-4f9d-87c2-4a22c9503864"), 836.40m, "Khoan tàu áo may xanh được em việc tui nhà cửa lỗi hết bè gió bàn trăng ờ máy ghét thương trăng làm thích núi quê hết vẽ đồng khoảng đồng xuồng đỏ hương may ác biển tám tô nghỉ tám một tủ hết tui ruộng một ghế không trăng.", 339, "Generic Wooden Pizza" },
                    { new Guid("2758da5b-c157-4721-8f60-bed6af3f9528"), 656.16m, "Xanh xe ghế cái bảy đồng độc hai được may đã năm trăng đâu xuồng khâu giày đồng mua thương bốn con đang vá nón vẽ tôi lỗi thích hết mười mượn mướn ác mượn khoan bảy leo trăng quần chín dép lầu phá bạn hai vẽ tôi yêu trăng.", 290, "Licensed Frozen Sausages" },
                    { new Guid("28c9ba2d-f95a-400c-977c-ed1997ee8673"), 967.45m, "Đang đánh đá ờ được ba ác bốn trăng tám thích biết làm ruộng lầu đã mây ghế kim thuyền vẽ mượn ngọt máy kim bạn bốn biển việc cửa nón yêu chỉ chết viết nha chết gió hết thôi tôi mua tui tàu thương mượn thuê tôi viết biển.", 223, "Handcrafted Rubber Hat" },
                    { new Guid("28c9fd1c-dc75-4cde-9f57-aa8dce4aad59"), 994.66m, "Việc đánh hai ừ viết trời nhà xuồng hai ba một chỉ đạp hàng bốn ghế hóa trời nhà quê đánh nghỉ tím đã đâu gì đâu thuyền tàu nha kim máy vẽ phá ghế em bàn yêu tàu tủ vẽ may gì bè vàng ừ hàng bốn ngọt không.", 678, "Incredible Frozen Salad" },
                    { new Guid("2a101d21-6829-4243-b4af-24fa85325b87"), 570.66m, "Anh tủ nghỉ chỉ vàng thôi gió em gió được một em độc nón chín quê bảy đá thuê ghế đạp biết máy chết đang khâu bảy máy lỗi vàng tàu tôi làm tàu giày nón ừ phá bè nghỉ khâu khoảng làm tô nghỉ bơi đỏ đập phá núi.", 825, "Sleek Concrete Salad" },
                    { new Guid("2a4d9dbe-ea63-46ba-8101-a6903570ed9a"), 485.10m, "Nước con đâu hết khoan gì thuyền đạp lỗi giày nhà thuê hàng độc ghế mười cửa đang gió anh em con ghế tủ quần thế tôi con tàu quần mướn trăng ruộng được ghét ác nón tám biển chỉ xuồng tôi kim mười đồng nước trăng ừ lỗi được.", 862, "Rustic Wooden Shirt" },
                    { new Guid("2bca4fd1-5293-49f1-ae0f-f88a4c6c8b67"), 483.82m, "Nước hàng dép dép trời trăng làm chìm đang thích hàng xe quê ghế chết làm làm thế giày hai độc lầu đánh đánh núi năm yêu thì cửa leo đá thôi chết chìm giết chết dép đạp ờ mua cửa biển đồng mướn thích trăng cửa ừ giết mượn.", 624, "Small Granite Mouse" }
                });

            migrationBuilder.InsertData(
                table: "SanPhams",
                columns: new[] { "Id", "GiaBan", "MoTa", "SoLuongTon", "TenSanPham" },
                values: new object[,]
                {
                    { new Guid("2c25bcf8-5a63-407b-b629-91224df32ada"), 498.43m, "Tàu bè hết phá biết hương hương yêu đá tôi chín cửa nước mây núi xuồng việc tô nha may tôi núi gì quê tôi hết yêu thế thuê đã đồng tô viết thuê nghỉ chỉ chín sáu khâu tủ nước mua bốn lỗi lầu bảy chín hết mây thế.", 327, "Licensed Frozen Car" },
                    { new Guid("2d4f0df8-c030-4733-91a6-8d3ce856ae5d"), 839.98m, "Bè là xanh hết nón xanh ruộng ngọt giày áo bơi bốn gió máy em cửa khoan em xe tô sáu đang vẽ làm ghét biết bạn chỉ chết mua giày trời nghỉ thương thuyền gì năm gì á sáu viết biết ác trăng biển thuê lầu đá hương hết.", 11, "Unbranded Rubber Shirt" },
                    { new Guid("2f591aeb-03a2-42db-aa09-187c7789e7f1"), 166.81m, "Đỏ mười năm leo đồng khoan hương khoảng thương xe chín mười tô mây bảy đánh năm gì tím thích tủ mây chín con năm biết kim được mướn đã núi chết kim thì đập xanh thương bơi năm vá bạn thuyền ừ trời thuyền phá độc vẽ việc ghế.", 234, "Generic Steel Mouse" },
                    { new Guid("32f151e5-3b46-4f3f-988a-ca31ee142bdf"), 746.17m, "Ba lầu xuồng bốn biết đánh kim giày hết lầu biển mây tui tám chết mướn đạp quê ghế tủ đánh tôi ác áo ruộng khâu độc máy không giết em chìm giết dép lỗi áo trời đã ừ viết giết anh ác bạn ba xanh chết yêu đánh tủ.", 805, "Gorgeous Granite Shirt" },
                    { new Guid("3a27a94c-f4fb-4822-a329-c3fab5f92420"), 740.37m, "Chỉ viết giết gió núi con tủ độc xe mua trời quần mượn ừ cái chết tô tôi ác chỉ trăng mượn bàn quê em may dép bơi là gió hai thương ác dép đá ngọt vẽ đỏ mướn vá máy tủ vá nhà gió á chín giày tàu hết.", 990, "Generic Soft Cheese" },
                    { new Guid("3dc285fa-0383-44af-8946-6878da035714"), 270.69m, "Chìm giày khâu gió lầu nhà chìm xuồng tàu thôi thương tủ áo đánh bốn mua bảy thế thế nhà thích khoan viết may thôi xanh độc yêu việc ruộng việc kim chết đá xuồng ngọt việc tủ xe ác việc thích là em bốn được chỉ mây bạn mười.", 205, "Small Wooden Gloves" },
                    { new Guid("42148da0-a7ff-4dfd-bf09-7fb853e95ba0"), 823.72m, "Làm thích đạp tám khoan xuồng con tủ năm nước thì hết là thế tô khâu em em ba quần đỏ hóa cái việc thuê biển xe mua độc mượn đạp áo xanh mười bơi nghỉ hóa biển trời mười nha em tôi trời mười máy quần cửa chín được.", 578, "Refined Cotton Bike" },
                    { new Guid("434e8f32-af7f-4a50-9697-3b89f45b0624"), 508.36m, "Tủ cửa lầu quê nha lầu đánh hàng á là thuyền thôi tui vá hết tủ lỗi tui chỉ quần lỗi nón anh dép đã anh hương bàn thuê tui bơi đá quần anh trời thương độc ghét thôi em hết may em ừ thuyền cửa mây gió máy thương.", 392, "Refined Granite Hat" },
                    { new Guid("44a8a3d3-abd1-4604-96fd-bb95ce584327"), 224.92m, "Anh may tám bàn được ác giày vàng trời ờ mượn viết biết bốn bảy tui thì tàu dép đâu leo chìm đang tàu bạn mười ngọt ác khâu nha nha trời tôi biển đỏ khoan hàng bàn một tủ đồng hóa bạn nhà thế ác làm may đá hóa.", 79, "Refined Wooden Hat" },
                    { new Guid("44f1b674-024e-48f5-9c55-49b9dbd7198d"), 438.25m, "Không máy năm làm ba may chỉ chết đập sáu ruộng trăng hết đập tôi hàng hương xanh thương may thế tô đồng ghế máy con thôi máy hết đỏ khâu phá kim yêu con bàn ghế chín núi áo bè tủ viết thì thuyền ác ác tím thương ờ.", 539, "Unbranded Plastic Shirt" },
                    { new Guid("4ba47efc-332e-4807-aed3-d90fad8573d4"), 945.86m, "Mướn mây chín bơi việc thuyền quần đỏ quần xe đâu bốn sáu tui cái tui máy thôi mướn may xuồng ờ hết lầu hương bè bàn việc đã đang mướn nhà đâu mây xuồng sáu lỗi lỗi ghét sáu thương nha phá mười mướn đang ừ nha yêu chỉ.", 19, "Unbranded Granite Pants" },
                    { new Guid("4f504d69-8f86-428d-876f-a8fcb47c5adf"), 296.77m, "Gì viết ờ tủ máy thôi vẽ đâu xanh á độc việc hai hết á biển bảy chín khoan sáu phá năm mua mười may biển dép thuyền không xanh hết việc tui ba gì quần không biển bảy gì đã đỏ quê vẽ thương sáu thôi lầu mua cửa.", 304, "Unbranded Fresh Bike" },
                    { new Guid("50273962-681e-497f-b903-d95f2225c436"), 274.44m, "Nón mượn hết áo chỉ lầu nhà làm trăng thôi khoảng mua thương sáu á bốn ba là biết sáu may tủ chỉ đập mây không trời được trăng quê ngọt mướn anh tủ năm tôi bè ghế bảy cái chín mướn đồng áo quê bàn thuyền hàng hàng ghét.", 907, "Tasty Plastic Car" },
                    { new Guid("52097100-b52c-449c-82c3-a77df7a51f34"), 281.12m, "Ghế bảy quê năm biển thuê chết bơi may tui bè bạn chín gió biển tám bè chìm tủ giày vàng viết bè đã xe biết việc chỉ nghỉ núi cái phá việc đỏ gió ruộng bè biết việc hai chín anh áo đang đạp thương hàng đập hai thì.", 769, "Licensed Metal Car" },
                    { new Guid("5539524c-ccd0-431c-9107-7b33de1a7120"), 952.84m, "Đạp bè tàu đập chỉ con nghỉ vá không hàng không thương gió bơi giày lầu ngọt may thế đỏ quê tô thế mua đồng ba làm trời hàng vàng tui hương việc đã được tím đồng tủ mượn ba vá anh thì xuồng được thuê chỉ thương mua nón.", 84, "Gorgeous Steel Hat" },
                    { new Guid("568b98d4-04e4-49c2-b188-eecde7f5500e"), 669.89m, "Ác chết kim chết hương chìm được tím hết cái là một không bè ác thế ngọt ừ giết chìm chết mười phá chín đá mượn xuồng thì đập được hương thuyền nón khoảng xanh á tám lầu tui đỏ trời á dép khoan bơi bốn kim biết hai được.", 858, "Ergonomic Plastic Keyboard" },
                    { new Guid("56ad9dd8-daf8-4ae7-b4a3-588abd518299"), 393.49m, "Bơi bạn nhà gió vàng nhà á khâu xanh xuồng làm mây đã hết gió mây á thì cái đạp gì trời việc xuồng vẽ đã dép thương yêu chết lỗi anh khoan ghét độc đá ừ ờ gió vẽ quê khoảng không nghỉ thuyền tôi khoảng hóa viết em.", 844, "Intelligent Rubber Shoes" },
                    { new Guid("574af140-7277-4929-8765-4b4ef7d681ad"), 865.82m, "Mướn khoảng leo áo bè tím lầu đá đỏ bảy vẽ viết ờ sáu ghế ừ là kim vá dép ruộng anh ác bơi đỏ nước leo viết thuê hóa tàu tàu đập sáu nhà chín bè em nước tàu ngọt vá mua biết mượn lỗi mướn máy đánh hóa.", 596, "Awesome Metal Bacon" },
                    { new Guid("57e2a48f-92c2-4a68-9c32-58fcbb8159fb"), 429.04m, "Tủ đã làm ghét vẽ giết núi năm được độc không hết bốn chìm làm độc tím đá độc mượn năm mướn tui xanh nha cái trời hóa nước vá đá viết tôi hàng tàu lỗi may đập gió áo lỗi vá hết thế bàn gió anh ác mướn thì.", 498, "Licensed Granite Soap" },
                    { new Guid("57f4ce40-a774-4ecf-8a56-901f4ad943f6"), 773.06m, "Là cửa trời thuê làm ruộng thương tám tôi năm độc tủ may mười bạn đạp tui anh bè ghét dép hai khoan đánh đập thôi lỗi trăng sáu ác giết đập được xanh một một thuê ghét sáu thuê mua biển cái nhà nha mượn may thương ờ tui.", 936, "Practical Soft Chicken" },
                    { new Guid("59500e8d-8153-4d0f-bdb8-9f2dc7000359"), 405.19m, "Xanh máy ừ vẽ sáu nước vá hết được mua bạn anh thế hết thôi mây mây tủ được thôi quần một vá lầu là hóa núi vá đâu tủ kim xanh không thì bạn bè hai đã quần anh xanh gì leo giày trăng mười đánh mượn nhà viết.", 647, "Handmade Wooden Pizza" },
                    { new Guid("5dd01998-6489-4fea-8b95-6b4a2d80fee5"), 568.56m, "Hết ngọt dép gió leo đánh nhà mua giày bơi hết độc xe hết xuồng yêu nha một đồng tôi thuyền xe thích mười anh khoảng giết chết đập nhà nha quê trăng thích độc tàu anh máy khâu thế khoan thương đồng bàn ờ việc được vàng khoan chìm.", 316, "Tasty Fresh Chips" },
                    { new Guid("5f3cc969-9505-4dca-8055-7a41727cb5d6"), 29.53m, "Lầu sáu khoảng chỉ nghỉ nón đạp trời lỗi ờ ghế khoan vàng leo hai giết ghế quê khâu con sáu tô dép mua cửa chín vá khoảng dép việc tô ruộng thương một yêu xanh ghế giày giết đâu đỏ ờ mượn độc núi leo áo bạn cửa áo.", 998, "Incredible Granite Salad" },
                    { new Guid("6336c166-469a-4870-82b8-5262fbdc3bdc"), 995.46m, "Khâu bàn không á biển bơi hóa hết leo trời một đập hóa nón ruộng tô tám núi hóa máy áo nhà nước bàn đang sáu chín bè giết cái thương thì hàng tô núi độc chín á á độc mượn trời thì bảy vá cửa tôi mười hai em.", 601, "Sleek Rubber Keyboard" },
                    { new Guid("659a821e-343b-4a6d-a22d-dad4f90a3cf7"), 33.94m, "Nón con núi mây giết nước anh năm giết năm trời tím ngọt ừ lầu gió chín đồng bốn biển đá tàu mây hóa khoan biết bè ba không ừ biết việc bốn việc nghỉ năm kim thì xanh hương năm thương leo nước thuê mười quần viết sáu tím.", 777, "Unbranded Granite Towels" },
                    { new Guid("65da7257-4c75-4cf1-91bf-65ee8b5715b2"), 753.54m, "Thuê thế làm thương đập ác xanh hết là vàng thôi vá nón kim nghỉ việc núi năm tô mây ừ giết bạn bạn đập hóa năm ờ thuyền xanh mây thuyền chìm anh tủ khoan thuê áo ừ đâu xe vàng leo năm thuê thôi ghế quê ác vàng.", 41, "Unbranded Granite Chips" },
                    { new Guid("68f1e6f7-ecfc-465a-9449-d89f0cf081dc"), 575.63m, "Tám chỉ cửa vẽ may gió một ghế chết đỏ đánh ba biết mười chín đánh mười máy nón phá bơi không chín nón ngọt mượn yêu hàng bảy việc việc chìm nón cái khoan đâu lầu tàu tủ hàng áo ruộng độc sáu xuồng bốn đá đập phá mướn.", 295, "Sleek Frozen Keyboard" },
                    { new Guid("6c525608-af42-4646-937a-89c6bc3697ab"), 995.93m, "Biển nghỉ thế việc việc núi quê ghế phá ác đồng anh hết tôi hai xuồng yêu đánh bàn không biển trăng bốn thì sáu gió ghét may nghỉ thế mua phá núi vẽ gió bốn đá ghế mười bơi bảy biển mướn thế mua đỏ cái con đá nha.", 540, "Handcrafted Concrete Pants" },
                    { new Guid("79d4b53b-5c1b-4699-9ac9-cc8c02eeaa5a"), 58.75m, "Bốn nhà ờ thích chín máy thôi năm quê vàng cửa sáu ba gió tím tủ chỉ khoan chín hàng núi làm vẽ á chết leo á viết dép khoảng yêu quần thì thuyền thôi hóa làm thì một chìm giày vẽ hàng dép đập hương nha không đánh núi.", 49, "Licensed Concrete Chicken" },
                    { new Guid("79d7fb19-38c7-4a1c-b711-edfbf9925855"), 204.05m, "Biết gió gió cái may may biển yêu áo đỏ khoảng đánh núi ghét chết vẽ đạp gì giày cái đập thì đập đá cái đâu giày mười xe mười xe mây em việc trăng máy đồng trăng hàng kim thuê khoan năm bơi sáu trời bơi đỏ gì bàn.", 775, "Intelligent Plastic Pizza" },
                    { new Guid("7b396b50-4279-419f-9d90-44efffc70947"), 395.64m, "Không lầu lỗi biển tủ con xanh đâu nón nha lầu thuê chết vẽ mướn vẽ viết nón phá gió đập sáu chết ghét quần bàn ác á trời bạn thuê gì xuồng con leo bè không ngọt hết đồng ba chết một nón khoan nhà hết anh đánh việc.", 111, "Intelligent Rubber Table" },
                    { new Guid("7de3d092-53f5-41f5-b02c-f5050f188b75"), 739.48m, "Vẽ thì ờ trời khoảng giết năm bốn đỏ thuê đạp vàng biết hết hương được nha thì chết phá giày quần bàn thuê núi biển nước leo đỏ năm tủ thích tui bàn anh đập đang mây nhà ghét bảy tủ tám anh kim thương quần cái thuê phá.", 907, "Small Plastic Bacon" },
                    { new Guid("7fba4b04-81c0-4e90-a52d-8387456132f5"), 632.97m, "Kim ba hàng việc khoảng viết khoan chỉ giày làm sáu đập dép khoan viết việc hết giết nón thương chín viết xe đâu bàn quần quần độc bàn gió đang làm khoan yêu tủ trời ruộng ừ nghỉ yêu giết bảy lầu ngọt tô xe nước xuồng thuê khoan.", 9, "Fantastic Wooden Fish" },
                    { new Guid("8190cd66-8510-49ef-9f93-ba6002e076f1"), 250.61m, "Độc được đâu kim xanh ờ bàn thôi một trời hóa đâu lầu quần ruộng thôi độc đá đá áo nhà hết biết đá nước bốn là mười gió sáu thuyền áo năm hương tàu hóa mây cửa bè nón anh xanh khoan hương hương xuồng bàn kim gió vàng.", 457, "Generic Concrete Shoes" },
                    { new Guid("81e83fab-a650-4721-843a-7a4671c2b08b"), 927.38m, "Khâu nón hàng độc đánh yêu bơi đồng không nha hai mười nước áo máy con ghét mười là tàu ghế cái ghế vẽ năm thuê núi làm biển kim xe lỗi trăng năm khoảng khâu hết xuồng tàu ghét máy không chìm áo quần bốn dép thuê đã một.", 482, "Awesome Soft Table" },
                    { new Guid("83873ba8-0363-4ca6-a52f-b6854cce0ebe"), 376.11m, "Lầu vẽ tím làm hết núi hàng đánh thế mây sáu chỉ không thì mây thì xanh mười giết đồng bảy ác ờ lỗi con quần ghét là cái cửa đạp vá hai giày chỉ chín vẽ ừ đạp bơi đạp giết bạn hóa bàn chìm gì bạn thì mây.", 89, "Fantastic Granite Pizza" },
                    { new Guid("84c2296a-807e-46b7-be23-77b0623708b3"), 559.72m, "Đã chín thích nghỉ bè một đã leo đâu vàng tủ mượn ờ đá một trăng là năm khâu mây mượn lỗi biển chỉ kim đánh không mây anh thôi nước xanh á việc nhà đang tôi gì viết đã mướn mua núi xuồng tui ba bốn đang vàng biển.", 128, "Sleek Fresh Bike" },
                    { new Guid("8612f81f-5ed8-4c20-b287-36169a7d857e"), 346.59m, "Tám biển thích cửa dép đánh mướn cửa khâu ừ em con năm quần tủ nhà thì chín tô xanh thôi ừ chín hàng biển đập xanh nước xuồng xanh ba trời thương giày gì mượn đang mượn máy lầu vá bốn bạn đạp xanh thôi đánh giết tàu quần.", 918, "Generic Frozen Chicken" },
                    { new Guid("8f85663e-ace3-4072-ba70-41e12565f18b"), 451.28m, "Ghét xuồng ờ máy gió ác lầu hết việc phá thôi mua lầu thì biết bạn đập nước vàng đỏ chỉ đánh việc tui hai hàng hết phá khoảng xanh viết ghét em hết xanh lỗi may hai việc đạp thuê xanh biển đá thuê tôi trời tô thuê đang.", 890, "Awesome Metal Mouse" },
                    { new Guid("9076e39f-9576-4022-b22d-0a6b5430fa87"), 752.72m, "Trời kim nghỉ chỉ đồng chết năm nước hai bè á mướn quần kim bàn phá tôi hai xuồng cái gì chín làm thuê biết đang anh nha tôi thuê làm đánh chín vá đồng phá đá thương xanh mây dép một hết thuyền xe thuê ba chỉ tám quần.", 991, "Refined Rubber Shoes" },
                    { new Guid("9518b051-2af0-4fb4-8e37-c7fb9453c9f6"), 530.15m, "Ờ đang ác thì giày viết hóa bè khoảng dép anh giày đập một viết hóa khoảng nha chết hàng chìm em gió bốn gió tàu không được gió mua chết xanh hết khâu ruộng bàn nhà bơi nha hàng ừ biết áo một chìm đồng á nha á hai.", 576, "Sleek Rubber Car" },
                    { new Guid("9600815f-92ca-4e08-a75b-b2c80244f664"), 204.52m, "Vẽ đập bảy trời cửa xe á mướn cái tô núi anh trời cái máy ngọt bàn quần lầu đỏ ờ ruộng nón mướn mua ngọt hóa thôi bảy chỉ biết khâu tím bàn xuồng khoảng bè lầu xanh bơi khâu bốn là quê ghế hàng năm hóa xuồng con.", 996, "Gorgeous Granite Keyboard" }
                });

            migrationBuilder.InsertData(
                table: "SanPhams",
                columns: new[] { "Id", "GiaBan", "MoTa", "SoLuongTon", "TenSanPham" },
                values: new object[,]
                {
                    { new Guid("96c38b36-40eb-4ac9-9cee-7237b2c3d27d"), 950.00m, "Bàn tím đâu ừ biết giày ghế quê tô mượn đá nón một ghét ruộng mượn hết lỗi là may anh vá con chết ghét cái là khâu xanh máy anh bàn dép vá đang ghét gió xe thế đồng máy xe thương đá may là xuồng tủ ừ ghét.", 607, "Licensed Frozen Pants" },
                    { new Guid("9a5071bb-1cb6-4101-879d-b0cd8e427369"), 828.08m, "Cửa cửa hết nha anh bơi giày làm thế biết ác nhà gió đánh đạp bè hàng cửa nha quê bè nhà lầu quê không một dép thuê biết chỉ đồng anh hết con năm lỗi mướn bàn tàu ừ đỏ trời cái giày leo chỉ mượn thương gió ghét.", 196, "Ergonomic Granite Keyboard" },
                    { new Guid("9c0562b3-1f41-4526-aa0a-7f5e48f0e892"), 826.38m, "Em nước chỉ quần may gió nước hàng chết đá thương á may cửa hóa bàn khoảng bè lỗi xe đồng mượn thế không quần bàn ba may bàn ruộng vá lầu đã thuyền đồng đánh bè một ừ làm hết nước may bốn sáu xe việc quần sáu biết.", 215, "Small Metal Chips" },
                    { new Guid("9d2b5c75-3138-48e7-addf-87e9880483ac"), 131.69m, "Khoảng ruộng mười ác hàng hết gì nước xanh ruộng bơi chìm đang tủ mượn dép ba xuồng ác bảy tui tui được sáu thuyền con hàng tám độc ghế thương ngọt bàn mây bàn phá bàn bốn được làm được thích đồng anh đang làm mây núi đồng không.", 14, "Gorgeous Granite Pizza" },
                    { new Guid("9fa879c6-23dd-4f4f-a449-cedefbaa38a9"), 931.97m, "Đập phá năm hai mượn một hương là năm bạn giày máy tàu mượn xuồng tôi thì xe á nước kim phá viết tô không hương gió yêu biển được tám núi đang nha tủ mướn ghét thuê làm cửa chết nha là giày trời mướn bạn giết xanh thế.", 477, "Tasty Steel Table" },
                    { new Guid("a4c5bd72-bdc2-44b1-af41-0b725883d175"), 236.74m, "Tàu năm hương núi mua đang em tủ đánh cửa khoan anh á giết hàng biển hương xuồng đạp thôi giết ừ tôi anh đang chỉ nhà bảy tàu ruộng giết chìm hết đỏ hương nghỉ xuồng năm áo tàu biết nhà núi em may tôi hóa lầu tôi hàng.", 437, "Handmade Plastic Salad" },
                    { new Guid("a87a0901-c3e2-4318-bee2-4bd9e59882d1"), 869.30m, "Tôi chìm lỗi hàng kim đâu đỏ đỏ vàng á á vàng một là con lỗi quê nhà tám không kim đập ghét ờ gió thương chìm bốn chết em hết nhà vàng tím con biển chìm thuê núi ác may ba con thế gì nón hàng thôi trăng nước.", 901, "Handcrafted Plastic Chips" },
                    { new Guid("a89987f6-a10c-4b5b-9d0a-7a8226c38649"), 166.29m, "Áo chết năm vẽ gì ghế quần đánh khâu ừ khoảng sáu đã đâu áo yêu không con đã khoan đồng một năm hương ngọt chín ngọt đâu nghỉ dép giết hóa xuồng hết á anh biết vàng con giày bàn cái độc mướn đang hết lỗi ờ á con.", 826, "Rustic Soft Bacon" },
                    { new Guid("a93914cc-2b0f-4e4f-8150-928c26f25fc8"), 519.32m, "Độc áo lỗi mua bè quê xanh xe thôi năm đập gió khoan ghét kim mua mượn xanh thôi quần trời bè bảy ác trời tô bơi vá kim kim ác không nha thì quần ruộng ác tui tám ờ cái đập tím là hết nha tím thương ghét xanh.", 694, "Handmade Granite Chair" },
                    { new Guid("a9a5a3ad-daf5-4e57-bea2-be9e2b00c61e"), 917.03m, "Mây anh nước hàng hàng ba ừ thương một bảy lỗi nghỉ không núi gió nha xuồng xuồng viết hết núi không mười trời phá con ba tui kim tui thuê ba ruộng xanh con quần em chìm bè ờ trăng ừ hết chìm biển một ờ quê kim hai.", 653, "Handmade Concrete Chicken" },
                    { new Guid("b28c8bea-c5f1-47bc-8f87-a5eed1ba134b"), 240.81m, "Máy quần giết vá ba gì cửa đá mượn gió hóa đá quê tím phá áo được máy gió độc hóa thích kim trời viết đá ngọt nha thôi ruộng yêu gì đá việc vàng gì mây bảy yêu hàng mượn tàu khâu đá tàu biển làm ừ hương nước.", 919, "Small Fresh Pizza" },
                    { new Guid("b2dc7e53-593a-4b92-ad57-110eb167cc4a"), 438.96m, "Kim chết là đang tàu chết tủ chỉ dép tủ không trăng xuồng bạn bạn mười nón đánh thì trời hết anh bơi năm đã may xe tím độc khoan chết chín hàng bạn ghế giày may mây thôi khoan kim đạp tôi chỉ cái ghế đánh bè vá tui.", 625, "Ergonomic Rubber Gloves" },
                    { new Guid("bd6f6d2e-e214-4d9e-a9eb-9f77887e8610"), 501.54m, "Chỉ anh hai tủ lầu ruộng núi ruộng nha tàu may con tám thích năm chết thuê anh chín mười xe việc quê thôi con cửa nghỉ cửa nước chỉ tủ bàn khoảng nghỉ cái sáu ruộng tôi trời đập là quần thuyền mười khâu hóa thương biết tôi hai.", 908, "Intelligent Metal Ball" },
                    { new Guid("cdd81b11-08f8-42b6-ba05-cdda0c2a1d80"), 147.37m, "Đang bảy á nha một nhà ngọt lầu ác dép ruộng biển leo vàng em độc vá kim tui khoan trăng tám chỉ đã độc bơi trăng đỏ chín tui năm tôi khâu giày hết chỉ leo mười bơi nhà giết biển leo đang á áo một gió hương tám.", 182, "Small Rubber Sausages" },
                    { new Guid("ced81675-59aa-4650-b3ce-b1e2f5608dd6"), 732.98m, "Xanh tám bảy nghỉ ruộng lỗi bơi vẽ em nhà máy nha bảy tím cái bốn núi nghỉ ác thuê nón đạp con tui đồng gì bốn hàng bạn á hương mây xuồng gì tôi nha tô quê chỉ máy bơi thế quê đâu tô được bạn chìm tô quê.", 649, "Rustic Wooden Car" },
                    { new Guid("cf7eb913-3ae3-4c40-b8dc-d16be4ee82d1"), 833.25m, "Quê đồng một đánh ruộng nghỉ núi ngọt nhà xuồng ghế leo thích hàng viết tím mướn viết cửa yêu thuê ngọt viết hai đang tím thương mướn chết đỏ tô khoảng tàu đá bạn biển vàng mười tô độc đánh tui hai làm ác ờ hàng đỏ ngọt ghế.", 83, "Rustic Soft Car" },
                    { new Guid("cf899302-9b8d-442f-8071-cb6f4a2fd075"), 563.21m, "Khoan việc đạp tím thôi đỏ tủ gì chết lầu hàng được thì em thuyền lỗi bơi mướn năm thích đạp hai nha nghỉ đồng ghế quê xanh đồng núi hàng xuồng tàu việc vẽ hàng nghỉ kim khoan tô hai ghét thôi đã được gì đập năm cái á.", 345, "Small Rubber Bacon" },
                    { new Guid("d309f396-cb57-4a37-a511-9303c2e644b3"), 494.21m, "Không anh mượn vẽ lỗi thôi sáu mua đạp tám bè ờ bốn không nón núi hết ghét thì vẽ lỗi trời thuyền mướn hết làm ruộng tui làm biển hai độc đã mượn đồng biết ghế áo cái vẽ con ờ thuyền bàn kim năm viết bạn hương áo.", 743, "Small Metal Bike" },
                    { new Guid("d9bbe402-9a0c-417b-b213-8dc958fb5388"), 324.49m, "Hai leo biển là ghế thuyền bạn hết vàng bơi khâu chết nghỉ tám con nha chỉ xe ngọt chìm một mười thương thì thì việc thôi thế thuyền đồng á em quê chết mượn bàn đánh bảy đâu đập mây khâu nước nón giày tám may khoảng ngọt ngọt.", 164, "Licensed Frozen Pants" },
                    { new Guid("dab311e8-18bc-47de-8ee6-46f37ad45bd4"), 839.71m, "Mướn ba ghét chìm ừ giết là vẽ cái làm hết đồng mua ghế làm thì xuồng tím vàng quần thuê mua tôi ừ ác ác tàu tím khoảng là giày á trời đã tui đã tô biết trời đỏ ừ quần ghế bốn tui nước khoan đâu thuê chết.", 899, "Gorgeous Steel Pizza" },
                    { new Guid("daba0dc3-d236-4617-a88b-06f9f6e089f6"), 490.49m, "Đập chỉ cửa ngọt khoảng đang vẽ giết được nha khâu giết đã chết nhà ờ vá khoảng biển anh độc đâu đỏ bạn ờ yêu vàng bạn đã con chín chết mây thế bơi thôi đang bơi nhà độc ờ ba thôi may đang thôi bốn ờ ghế làm.", 345, "Awesome Wooden Soap" },
                    { new Guid("dcc0c8b5-1997-4040-bd18-615643fe0e49"), 958.21m, "Gió ba đã là phá xuồng tô hết hết đâu nhà làm trăng kim vàng sáu yêu tám nón đồng chìm chín hết phá cái bốn gì ờ hóa độc sáu đá con máy ruộng lỗi đồng bè ghét yêu áo ba tôi đang nước quần mây ngọt năm tôi.", 542, "Incredible Concrete Mouse" },
                    { new Guid("dd8050e3-6901-4566-839b-447d54457e59"), 567.78m, "Ba hết tím mua vàng leo thích chết mười ruộng kim mây hai ba đã trời tám mượn đâu tím hết bè máy đập thương nha hết vàng ngọt mượn thuyền giày hết bàn cửa ba ngọt một khâu xuồng đồng đá độc tui yêu khoảng đâu chín mười anh.", 233, "Generic Frozen Sausages" },
                    { new Guid("dfd94873-4e05-49ca-a019-4ed8017036ec"), 976.20m, "Trời xuồng trăng một mượn kim bơi dép được tím trời trời khoảng được bảy thế lỗi ghế quê ba thuyền chín xuồng lầu đang hương khâu nhà bơi nghỉ con cái bè nước á áo trời bơi tím khoan gió cái thương thuê nhà làm thì mướn vàng áo.", 496, "Intelligent Rubber Fish" },
                    { new Guid("e11d035f-a509-4c3f-965a-9bddf8a6e8df"), 69.91m, "Tôi em quê ờ hai viết khoan ờ gì tui được tám chết đồng thuyền bè mười thế xanh xanh dép khoảng áo nha đá đang lầu mười thì hàng ngọt đá hóa tủ đạp được nghỉ vá hai á quần nghỉ đã thuê khoan độc nước kim mây trăng.", 573, "Refined Frozen Tuna" },
                    { new Guid("e3471773-cd13-4e09-bddf-237317f9d30e"), 302.24m, "Leo tám bốn mua nước mượn khoảng thuyền một cửa ngọt đỏ mướn việc bè mua xe núi leo vàng một bè vàng mây bạn nha thôi chết ác chết ờ ờ mướn giày đập đánh hết tôi đạp mười áo trăng cái hóa mây một vẽ chín bảy đang.", 740, "Tasty Metal Bike" },
                    { new Guid("e3d74f22-3bf2-4e4a-aa14-17e6df30c4a5"), 230.26m, "Gió bốn phá khoảng anh thích xe nước nước leo trăng đã gió tui bè thuyền xanh không ruộng biển khoảng ghét mây núi em ruộng cái thì thuyền trời hai cửa bàn đâu ba không mượn hai giày đỏ chỉ vá trăng thương đỏ đồng năm không nghỉ chín.", 117, "Ergonomic Metal Gloves" },
                    { new Guid("e49ef9f7-0df3-4e25-b9c5-16643f15dfa7"), 208.21m, "Vẽ bơi là cửa cái năm con tui trăng bảy gì ờ tím yêu mượn dép bốn viết giày lỗi bảy bảy lầu khoảng tám tàu đâu biển hàng bốn hóa đâu mướn hàng mây trăng xe việc không kim gì bàn máy hết leo tui yêu em thích thế.", 158, "Incredible Cotton Fish" },
                    { new Guid("e5d5f829-20d0-4f91-84c0-0b335ba95a39"), 83.37m, "Tô giết mây mây trăng quê xanh phá hương mua việc em ừ ghế trăng thì áo vá thì bảy là khoan tôi hàng tô khoan bàn mua bảy thì đánh biển anh em ác mướn một lầu mười xe khoan dép tím tủ hết viết là núi con nhà.", 584, "Unbranded Granite Computer" },
                    { new Guid("e81bd9bb-3f49-47bf-85dd-033f6995164c"), 642.11m, "Trời tím viết vẽ giày ruộng không đã đồng mướn thì xe việc sáu quê mua đập ruộng bạn biết chìm mười em đạp đỏ con thuê bốn yêu khoảng núi hóa xe quê ác anh tàu đánh nón khoan là chết xe tím bảy vàng bốn thì con viết.", 793, "Ergonomic Granite Ball" },
                    { new Guid("e8e56df5-3ba5-40fe-8ecd-6970275d69d5"), 379.71m, "Quần được nha nha ừ tủ nón đánh vẽ thuê xanh hóa anh dép á cửa đạp viết ghế ba xanh mướn núi kim con may hóa khoảng thế mướn tàu ghét đỏ cửa tô em hai thuê em núi thuê khoảng nhà đỏ đập áo hàng núi khoảng phá.", 3, "Handmade Concrete Chips" },
                    { new Guid("ea9f433c-0b23-4f5f-8136-bf39a688d8eb"), 673.71m, "Cửa mượn nghỉ tui xanh nón thế núi đập ghế bơi tàu nước mười tôi hết biết viết ruộng thuyền xuồng nghỉ tui ác tàu bè chín vá mây leo hết trăng gió bảy mây tám mua được yêu yêu đã quê leo ờ con nha đồng mua bốn ác.", 319, "Incredible Plastic Shirt" },
                    { new Guid("ecfdf8bb-7f1a-423e-b051-b106322e0559"), 540.92m, "Thuê bàn bè hóa mua á đã chín trời vá hai ba cửa mua hóa ba nghỉ đã thì năm nha khoảng ghét chìm con thích cửa bốn nhà độc đang bảy anh giày giết gió bảy nha bơi bạn đá nghỉ cửa ác không giày tô quần độc giày.", 234, "Unbranded Cotton Pants" },
                    { new Guid("f000a1f4-c4af-4db1-b858-d888ff0b2692"), 404.89m, "Trời chín đã không ừ hương năm được biết chìm ruộng trời trời gió may hàng phá hàng ghế xanh chỉ chỉ đỏ lầu xanh chết tám phá cái nhà kim chết làm ác hết khâu núi hương phá chết bạn gió xuồng mua vẽ mượn tô thuyền là con.", 19, "Awesome Wooden Mouse" },
                    { new Guid("f2dabbe6-4db1-4189-bc2b-68f9603f7b0e"), 989.86m, "Ừ sáu tôi mượn năm trời đã leo máy bảy xuồng là tám bàn không giày hết biển chết áo mây thế thuyền bốn leo ờ quần lầu ngọt thì kim máy trăng được thế ờ đánh ác mướn trời xe mướn cửa quê nước đá mướn phá giết tám.", 717, "Practical Wooden Sausages" },
                    { new Guid("f61a46dd-1d65-404c-89e6-9c2d2a648ddf"), 141.37m, "Con đánh á nón giày thương mua xanh em khoan gì hai máy may đá chỉ ghét khâu kim chết đá thích hai hết xuồng mây tím á con là tôi nhà mượn thuyền bạn mười ác dép gió hết không hàng leo chín máy ghế trời vàng quần hết.", 98, "Small Cotton Chips" },
                    { new Guid("f8f47ea3-b5d1-4b75-acf4-9d547b87ee1f"), 278.65m, "Máy ác đỏ máy khoan thì hóa vá biển hết thế thì đồng hai chìm việc ghế tôi anh tàu giết thuyền tui leo mượn vẽ hương năm tàu mười ghét mua hàng ừ may chìm gió biết yêu hàng kim đánh thuyền chỉ thích bè ác khoảng khoảng trời.", 956, "Handcrafted Concrete Table" },
                    { new Guid("fae336df-6b91-4cf9-9556-fe8221ac567c"), 942.02m, "Ghét áo đồng may ghét không kim áo đá á bè đập đang đỏ chỉ thế thôi kim chìm tui máy may núi leo sáu là là nón việc ghét chìm biển ác gió cửa nha hết ghế ngọt được mây nghỉ em chín trăng giết nón bơi mây bàn.", 634, "Handcrafted Cotton Tuna" },
                    { new Guid("fb79e8e9-a08b-4f9b-957c-f19b0651a0ca"), 35.99m, "Ờ ngọt yêu quê hết đỏ đã biết chìm bốn khoảng đánh thuyền ác núi vá đã vẽ may ừ thì thích nón tám bảy gì mười em không vẽ máy thích tui mua cái vá cửa giày chỉ chỉ á bạn thế anh biết mượn thuê thôi bốn thuyền.", 477, "Generic Metal Bacon" },
                    { new Guid("fbbb4e15-6e66-42b8-a342-afece72cba9b"), 87.90m, "Hóa máy chỉ máy hai cửa khâu chỉ biết đạp gió tôi vá nước sáu thuê thế cái đồng giày quần ba hương hóa làm ác ngọt ngọt mướn vá khâu sáu khoan bè thì hết cái ba nhà được nước đang bạn hai tám tím bảy nước giết máy.", 838, "Awesome Plastic Sausages" },
                    { new Guid("fc6c427e-2049-4d2a-8fe8-e4632aa29c6d"), 934.08m, "Lầu đập thế leo lầu thế khoảng trăng kim tàu khâu chín gió áo leo đang anh biển leo tím khâu nước yêu cửa mượn thương thuyền khoan con ruộng hai thương chìm yêu áo chìm là trời hai á leo hai viết ghét ác thôi không trăng khoan núi.", 409, "Handmade Metal Salad" },
                    { new Guid("ff4bf443-65f4-4dfe-b83a-031195b93162"), 813.89m, "Thì bè thuê con dép thuyền một ờ việc mượn thế xanh chỉ quê quần anh đạp may nha khoan biển đồng con đang hóa tàu em tui đang lầu máy lỗi bốn giày đạp viết thôi đang chìm gì giết quê ghế hương khoan viết hàng đá khâu tủ.", 476, "Small Rubber Chair" }
                });

            migrationBuilder.InsertData(
                table: "DonHangs",
                columns: new[] { "Id", "KhachHangId", "NgayDatHang", "NgayGiaoHang", "TongTien" },
                values: new object[,]
                {
                    { new Guid("0042f890-95fb-494d-b0ee-a6a1de4b997a"), new Guid("24256d4c-7032-4437-8c1e-dd211c5bd713"), new DateTime(2024, 7, 4, 12, 31, 7, 879, DateTimeKind.Local).AddTicks(3052), new DateTime(2024, 8, 7, 15, 46, 47, 299, DateTimeKind.Local).AddTicks(3556), 2130.25m },
                    { new Guid("0073a083-66c6-47c7-bf3b-a51d795115af"), new Guid("46685f7f-ca60-41b6-8cfb-4124c89cd625"), new DateTime(2024, 3, 28, 10, 23, 17, 312, DateTimeKind.Local).AddTicks(5579), new DateTime(2024, 8, 7, 14, 51, 24, 750, DateTimeKind.Local).AddTicks(5294), 1137.81m },
                    { new Guid("00946e58-10c2-4bbe-a09c-df6b78a464ec"), new Guid("952cbe13-c448-4063-910c-4a6b51e895ce"), new DateTime(2024, 1, 15, 13, 9, 51, 71, DateTimeKind.Local).AddTicks(525), new DateTime(2024, 8, 7, 21, 31, 40, 653, DateTimeKind.Local).AddTicks(9231), 3276.26m },
                    { new Guid("00c907fe-344c-4a7e-9c7f-4e222baf7c6e"), new Guid("1e3c140e-4cab-4065-aadd-2c1cfed5ce14"), new DateTime(2023, 8, 24, 19, 23, 11, 116, DateTimeKind.Local).AddTicks(494), new DateTime(2024, 8, 8, 6, 46, 34, 119, DateTimeKind.Local).AddTicks(1466), 3456.04m },
                    { new Guid("00edbf6a-cabc-4945-b3f7-213b825528bd"), new Guid("33caf896-8425-48e6-86b5-a47f32bb1850"), new DateTime(2024, 2, 27, 8, 15, 48, 527, DateTimeKind.Local).AddTicks(4657), new DateTime(2024, 8, 9, 11, 13, 54, 342, DateTimeKind.Local).AddTicks(7730), 2747.17m },
                    { new Guid("00fde52c-fbaf-445c-bc0f-20d30e8c5dc3"), new Guid("28d8da78-c6c4-4afe-9d92-22d52e3969b0"), new DateTime(2024, 4, 22, 19, 51, 56, 34, DateTimeKind.Local).AddTicks(7726), new DateTime(2024, 8, 8, 1, 16, 52, 131, DateTimeKind.Local).AddTicks(5228), 956.82m },
                    { new Guid("0114410b-e7f5-45f2-b853-7b0e1d785620"), new Guid("15883dbe-e97e-4859-86f7-993bbc1173df"), new DateTime(2024, 5, 9, 23, 58, 42, 731, DateTimeKind.Local).AddTicks(1632), new DateTime(2024, 8, 8, 14, 6, 14, 167, DateTimeKind.Local).AddTicks(3110), 3480.92m },
                    { new Guid("0117b8f4-9858-4bd7-a0da-864cf01e00be"), new Guid("63021a65-455d-454a-92ee-525601ead4df"), new DateTime(2023, 11, 26, 8, 16, 41, 800, DateTimeKind.Local).AddTicks(4853), new DateTime(2024, 8, 8, 3, 30, 33, 584, DateTimeKind.Local).AddTicks(8665), 4027.17m },
                    { new Guid("0150812d-7f29-4dde-88ea-501b36966325"), new Guid("38ba8024-3b8d-4dd6-92b9-9d06da12ec6e"), new DateTime(2023, 8, 28, 9, 39, 37, 463, DateTimeKind.Local).AddTicks(6389), new DateTime(2024, 8, 7, 12, 56, 59, 436, DateTimeKind.Local).AddTicks(674), 4708.64m },
                    { new Guid("01586d29-ad66-411f-812f-c7a502092f36"), new Guid("17652753-332f-4654-89d0-bbca6d67670f"), new DateTime(2024, 4, 13, 14, 57, 25, 569, DateTimeKind.Local).AddTicks(437), new DateTime(2024, 8, 7, 7, 21, 46, 292, DateTimeKind.Local).AddTicks(8788), 3597.16m },
                    { new Guid("0200b950-471c-48c9-97dc-e451450abe89"), new Guid("b78d1e60-56cf-4058-967c-7271f646af05"), new DateTime(2024, 2, 25, 16, 22, 49, 337, DateTimeKind.Local).AddTicks(5218), new DateTime(2024, 8, 8, 12, 35, 24, 471, DateTimeKind.Local).AddTicks(3198), 1019.78m },
                    { new Guid("025ceea4-de85-416c-ad60-e0b5f11ee9b0"), new Guid("9e65dc79-3d73-4629-8551-a5f2b9cfe2a4"), new DateTime(2024, 1, 13, 2, 57, 8, 691, DateTimeKind.Local).AddTicks(729), new DateTime(2024, 8, 7, 15, 54, 50, 457, DateTimeKind.Local).AddTicks(1073), 4537.39m },
                    { new Guid("029aa3f9-768c-4cda-964b-c52048e90b47"), new Guid("4ebf8ce2-efc1-4c0d-8c61-7159ede74521"), new DateTime(2023, 12, 2, 6, 34, 42, 523, DateTimeKind.Local).AddTicks(4360), new DateTime(2024, 8, 6, 23, 12, 26, 765, DateTimeKind.Local).AddTicks(3573), 1417.77m },
                    { new Guid("02fbf791-7c68-4d44-ad57-95a5bb85a020"), new Guid("1248d1fb-1e80-4ded-926b-6b7f6d2249a5"), new DateTime(2024, 6, 30, 1, 36, 24, 310, DateTimeKind.Local).AddTicks(4658), new DateTime(2024, 8, 8, 7, 53, 5, 330, DateTimeKind.Local).AddTicks(3674), 1376.03m },
                    { new Guid("030f13f6-6acf-41ac-ac46-3ab00c4df123"), new Guid("232fdc99-53fe-4232-9c74-06ddfb2a13b8"), new DateTime(2024, 6, 5, 13, 32, 55, 348, DateTimeKind.Local).AddTicks(2810), new DateTime(2024, 8, 9, 12, 13, 4, 877, DateTimeKind.Local).AddTicks(2878), 612.41m },
                    { new Guid("0311ac79-f709-4a48-9c91-f791fa30fc10"), new Guid("b0074e79-8782-48c2-b497-9ae7bd24e960"), new DateTime(2024, 7, 21, 6, 17, 15, 723, DateTimeKind.Local).AddTicks(8402), new DateTime(2024, 8, 7, 11, 19, 42, 861, DateTimeKind.Local).AddTicks(7265), 2292.22m },
                    { new Guid("03391dcb-070b-4cd3-aeb6-924760c02166"), new Guid("6f2bc11e-7dd7-4049-9e35-163927214820"), new DateTime(2024, 6, 4, 1, 8, 3, 793, DateTimeKind.Local).AddTicks(9969), new DateTime(2024, 8, 8, 1, 58, 22, 904, DateTimeKind.Local).AddTicks(3808), 970.59m },
                    { new Guid("03613a55-641a-41b4-ac62-d8c697080d89"), new Guid("90fb9bfe-da70-4392-9904-4417fab257a7"), new DateTime(2024, 3, 23, 11, 26, 48, 396, DateTimeKind.Local).AddTicks(8175), new DateTime(2024, 8, 7, 5, 39, 54, 26, DateTimeKind.Local).AddTicks(2578), 3754.33m },
                    { new Guid("03cda593-f217-4f7b-81e1-e6ad69f64c0f"), new Guid("22ebc934-105f-4b38-ab74-feae23d1ffc0"), new DateTime(2024, 6, 13, 9, 8, 12, 815, DateTimeKind.Local).AddTicks(6487), new DateTime(2024, 8, 9, 6, 43, 22, 913, DateTimeKind.Local).AddTicks(7350), 4271.78m },
                    { new Guid("0466f063-b5a6-4d15-9cbe-9b1ca60d7e46"), new Guid("d43ed679-0d22-40c7-a14a-6d01fe86c193"), new DateTime(2023, 8, 24, 20, 37, 58, 76, DateTimeKind.Local).AddTicks(6517), new DateTime(2024, 8, 9, 14, 32, 0, 184, DateTimeKind.Local).AddTicks(1245), 2532.12m },
                    { new Guid("04c5ac9d-8a9b-46d1-b4cc-acc59746e56e"), new Guid("232fdc99-53fe-4232-9c74-06ddfb2a13b8"), new DateTime(2023, 9, 25, 2, 53, 9, 936, DateTimeKind.Local).AddTicks(253), new DateTime(2024, 8, 9, 12, 42, 2, 794, DateTimeKind.Local).AddTicks(6808), 2825.67m },
                    { new Guid("04d33e34-6865-4d4f-b9ce-be08b4c8ac8a"), new Guid("93fb1f32-f25c-41b4-91a2-c22a92a4ab83"), new DateTime(2024, 3, 12, 18, 32, 51, 494, DateTimeKind.Local).AddTicks(5651), new DateTime(2024, 8, 7, 10, 4, 25, 527, DateTimeKind.Local).AddTicks(3728), 1606.59m },
                    { new Guid("05668079-ad5e-40eb-a763-709545da2759"), new Guid("b0074e79-8782-48c2-b497-9ae7bd24e960"), new DateTime(2023, 9, 13, 10, 56, 40, 914, DateTimeKind.Local).AddTicks(3259), new DateTime(2024, 8, 9, 3, 32, 2, 457, DateTimeKind.Local).AddTicks(7207), 1579.49m },
                    { new Guid("05dcea8a-eb68-440f-a208-9ef3d17fc487"), new Guid("15883dbe-e97e-4859-86f7-993bbc1173df"), new DateTime(2023, 11, 19, 13, 9, 29, 515, DateTimeKind.Local).AddTicks(4129), new DateTime(2024, 8, 8, 22, 31, 48, 157, DateTimeKind.Local).AddTicks(4012), 2103.73m },
                    { new Guid("064d0d0f-09d9-4123-b801-4e32d4683249"), new Guid("2db3541e-b13b-4e4b-b634-f31e8982b5e1"), new DateTime(2024, 6, 7, 20, 53, 31, 744, DateTimeKind.Local).AddTicks(3474), new DateTime(2024, 8, 8, 23, 41, 25, 588, DateTimeKind.Local).AddTicks(1580), 885.83m },
                    { new Guid("064f5c45-5712-42bc-a008-4f2e534f4f8a"), new Guid("4ebf8ce2-efc1-4c0d-8c61-7159ede74521"), new DateTime(2023, 12, 10, 20, 41, 14, 346, DateTimeKind.Local).AddTicks(2904), new DateTime(2024, 8, 8, 6, 46, 52, 204, DateTimeKind.Local).AddTicks(8203), 1237.80m },
                    { new Guid("06857aab-92f6-4230-a595-d42304ce9056"), new Guid("9865321a-433a-4caa-8050-884b34c7c8d8"), new DateTime(2023, 11, 6, 14, 34, 56, 860, DateTimeKind.Local).AddTicks(1263), new DateTime(2024, 8, 9, 11, 5, 2, 401, DateTimeKind.Local).AddTicks(8074), 4326.75m },
                    { new Guid("068bb170-f243-499f-b4a2-9681efd66caa"), new Guid("d15c8331-36ed-417a-b1fa-5f377c4c9930"), new DateTime(2024, 2, 18, 9, 43, 25, 327, DateTimeKind.Local).AddTicks(7110), new DateTime(2024, 8, 9, 13, 1, 4, 48, DateTimeKind.Local).AddTicks(7255), 129.27m },
                    { new Guid("06bab8ed-dd70-4741-bc31-c2b140269faa"), new Guid("a38bfc8c-feac-4053-b76e-84c4e66d74d6"), new DateTime(2024, 4, 23, 16, 25, 2, 512, DateTimeKind.Local).AddTicks(568), new DateTime(2024, 8, 8, 4, 46, 58, 706, DateTimeKind.Local).AddTicks(5181), 4697.80m },
                    { new Guid("06ccee86-78b9-4623-a592-ff844f3d0f8f"), new Guid("052538e6-f9b6-4bd1-98e0-6e7d6744fb4a"), new DateTime(2023, 11, 5, 20, 54, 53, 477, DateTimeKind.Local).AddTicks(5073), new DateTime(2024, 8, 8, 14, 25, 56, 276, DateTimeKind.Local).AddTicks(4871), 363.99m },
                    { new Guid("06dd256f-32bf-4359-a8ad-f14f8b0b6080"), new Guid("052538e6-f9b6-4bd1-98e0-6e7d6744fb4a"), new DateTime(2024, 7, 23, 14, 17, 4, 211, DateTimeKind.Local).AddTicks(8131), new DateTime(2024, 8, 8, 2, 35, 58, 823, DateTimeKind.Local).AddTicks(3160), 2600.18m },
                    { new Guid("073d247a-fba7-4cea-9e3e-1f65e8f3a9c9"), new Guid("9865321a-433a-4caa-8050-884b34c7c8d8"), new DateTime(2024, 5, 19, 0, 25, 55, 961, DateTimeKind.Local).AddTicks(3734), new DateTime(2024, 8, 8, 13, 38, 6, 553, DateTimeKind.Local).AddTicks(8257), 1838.83m },
                    { new Guid("0761b300-3e9e-46a8-9f81-b437b99a9312"), new Guid("88888a0c-f1ed-4613-9646-ee6509dc5db0"), new DateTime(2023, 9, 3, 23, 8, 17, 766, DateTimeKind.Local).AddTicks(6024), new DateTime(2024, 8, 9, 8, 48, 5, 266, DateTimeKind.Local).AddTicks(3987), 2738.51m },
                    { new Guid("07631f0f-a2dd-416d-a202-ed3aeabd0867"), new Guid("841db90c-5f81-482a-a955-f91fc637a7f7"), new DateTime(2023, 8, 7, 15, 23, 26, 370, DateTimeKind.Local).AddTicks(1611), new DateTime(2024, 8, 8, 19, 12, 30, 978, DateTimeKind.Local).AddTicks(1308), 4597.05m },
                    { new Guid("07cf5868-6e0e-40c1-8817-07272bc1558e"), new Guid("33caf896-8425-48e6-86b5-a47f32bb1850"), new DateTime(2023, 11, 30, 10, 56, 35, 198, DateTimeKind.Local).AddTicks(41), new DateTime(2024, 8, 7, 17, 12, 52, 751, DateTimeKind.Local).AddTicks(2166), 924.99m },
                    { new Guid("08f9ce50-d979-43a6-a832-980e77e9bc58"), new Guid("648119d0-d486-40c5-bd23-69a5e42b2ba5"), new DateTime(2024, 1, 10, 17, 46, 59, 503, DateTimeKind.Local).AddTicks(569), new DateTime(2024, 8, 9, 1, 26, 9, 311, DateTimeKind.Local).AddTicks(6633), 499.20m },
                    { new Guid("09098bbc-ca5b-4860-b5ca-60ba21f4209b"), new Guid("f9a1bd2e-de1a-42b8-b894-7f7e0b5b38f1"), new DateTime(2023, 12, 23, 12, 3, 46, 858, DateTimeKind.Local).AddTicks(7794), new DateTime(2024, 8, 8, 4, 17, 53, 74, DateTimeKind.Local).AddTicks(2486), 785.70m },
                    { new Guid("094276d5-17a0-440e-872a-614c4f90c2bb"), new Guid("1248d1fb-1e80-4ded-926b-6b7f6d2249a5"), new DateTime(2024, 7, 11, 6, 50, 18, 59, DateTimeKind.Local).AddTicks(75), new DateTime(2024, 8, 7, 13, 55, 5, 736, DateTimeKind.Local).AddTicks(5928), 1683.99m },
                    { new Guid("094b32dc-e299-495e-8840-c8e581b8f544"), new Guid("0b23e0d1-fa5b-4022-92b8-ff158e6d60ed"), new DateTime(2024, 1, 10, 1, 51, 4, 516, DateTimeKind.Local).AddTicks(9433), new DateTime(2024, 8, 9, 18, 46, 20, 300, DateTimeKind.Local).AddTicks(8654), 4456.98m },
                    { new Guid("09b5a6bd-3717-4fe9-8930-9d8860bbdb05"), new Guid("0667960a-b942-408f-9aa5-8591f0e0599a"), new DateTime(2024, 7, 30, 22, 33, 45, 634, DateTimeKind.Local).AddTicks(3310), new DateTime(2024, 8, 7, 13, 36, 51, 658, DateTimeKind.Local).AddTicks(3695), 4720.55m },
                    { new Guid("09da8ef8-14e9-4c56-942c-bc21edf0ffcc"), new Guid("c93b2790-efbb-4887-bc62-908698026478"), new DateTime(2024, 3, 19, 12, 14, 17, 282, DateTimeKind.Local).AddTicks(4697), new DateTime(2024, 8, 8, 4, 24, 18, 487, DateTimeKind.Local).AddTicks(236), 190.19m },
                    { new Guid("0a786f0b-a24b-4b44-bd1b-22b9514a824d"), new Guid("fd9917bd-45e9-4bab-839f-7f5b5cbf03e7"), new DateTime(2023, 11, 22, 23, 5, 36, 903, DateTimeKind.Local).AddTicks(5928), new DateTime(2024, 8, 8, 17, 0, 16, 295, DateTimeKind.Local).AddTicks(7445), 3790.47m }
                });

            migrationBuilder.InsertData(
                table: "DonHangs",
                columns: new[] { "Id", "KhachHangId", "NgayDatHang", "NgayGiaoHang", "TongTien" },
                values: new object[,]
                {
                    { new Guid("0ab047d5-3bf4-402d-8647-5aeb43b35f40"), new Guid("d5d71173-e817-45f8-9146-4b7ab7c7b686"), new DateTime(2023, 9, 4, 18, 18, 39, 229, DateTimeKind.Local).AddTicks(6940), new DateTime(2024, 8, 7, 1, 3, 27, 143, DateTimeKind.Local).AddTicks(5137), 2437.73m },
                    { new Guid("0b2b2409-ca9d-45f3-bad8-843a01240191"), new Guid("b78d1e60-56cf-4058-967c-7271f646af05"), new DateTime(2024, 7, 26, 1, 45, 24, 823, DateTimeKind.Local).AddTicks(2816), new DateTime(2024, 8, 8, 0, 50, 43, 555, DateTimeKind.Local).AddTicks(3759), 4727.46m },
                    { new Guid("0b3e73b5-c722-4738-8a2f-14cb4b557c2a"), new Guid("46685f7f-ca60-41b6-8cfb-4124c89cd625"), new DateTime(2024, 6, 17, 18, 31, 5, 390, DateTimeKind.Local).AddTicks(2708), new DateTime(2024, 8, 9, 5, 41, 55, 226, DateTimeKind.Local).AddTicks(3721), 131.56m },
                    { new Guid("0b7a12b1-cb08-4376-beba-32800eff7842"), new Guid("c0ebc03b-08bf-4b16-89e2-4c86dec71a59"), new DateTime(2023, 9, 24, 13, 1, 38, 647, DateTimeKind.Local).AddTicks(1284), new DateTime(2024, 8, 8, 2, 49, 26, 436, DateTimeKind.Local).AddTicks(8783), 382.78m },
                    { new Guid("0b9ddf11-71b5-4873-8360-695e44aecd30"), new Guid("17544f0d-9e01-4955-b49a-dcc4b6a770ee"), new DateTime(2023, 12, 30, 21, 52, 31, 480, DateTimeKind.Local).AddTicks(5795), new DateTime(2024, 8, 9, 10, 7, 51, 709, DateTimeKind.Local).AddTicks(2859), 421.41m },
                    { new Guid("0bc11e28-ba2e-435f-9444-99f2cad25c69"), new Guid("88888a0c-f1ed-4613-9646-ee6509dc5db0"), new DateTime(2023, 11, 3, 8, 42, 58, 49, DateTimeKind.Local).AddTicks(5909), new DateTime(2024, 8, 8, 12, 12, 40, 317, DateTimeKind.Local).AddTicks(9048), 86.88m },
                    { new Guid("0c6acda0-2df7-425f-88fa-a3f99b24e577"), new Guid("893b3fb0-9647-4958-b835-676e382779e7"), new DateTime(2024, 1, 18, 0, 22, 27, 151, DateTimeKind.Local).AddTicks(388), new DateTime(2024, 8, 7, 10, 1, 16, 578, DateTimeKind.Local).AddTicks(3315), 1244.08m },
                    { new Guid("0ce24b03-98ea-411b-8414-808bab255994"), new Guid("2db3541e-b13b-4e4b-b634-f31e8982b5e1"), new DateTime(2023, 10, 9, 13, 55, 46, 17, DateTimeKind.Local).AddTicks(9607), new DateTime(2024, 8, 7, 0, 6, 2, 304, DateTimeKind.Local).AddTicks(698), 553.15m },
                    { new Guid("0d2e7108-7497-48e9-b868-8f87501bf4bb"), new Guid("697709be-b252-4405-bb7e-8673c6b98467"), new DateTime(2023, 11, 8, 9, 55, 49, 606, DateTimeKind.Local).AddTicks(4384), new DateTime(2024, 8, 8, 1, 32, 56, 198, DateTimeKind.Local).AddTicks(9874), 4712.56m },
                    { new Guid("0d5c7266-5f54-4e12-bef2-e941f4624c96"), new Guid("d5d71173-e817-45f8-9146-4b7ab7c7b686"), new DateTime(2024, 4, 5, 10, 33, 33, 149, DateTimeKind.Local).AddTicks(8052), new DateTime(2024, 8, 7, 11, 57, 24, 291, DateTimeKind.Local).AddTicks(5098), 3072.16m },
                    { new Guid("0dc4b7a6-6f3f-4d61-9bb7-3e5f85e8f0cb"), new Guid("fd9917bd-45e9-4bab-839f-7f5b5cbf03e7"), new DateTime(2024, 6, 23, 18, 56, 52, 671, DateTimeKind.Local).AddTicks(7634), new DateTime(2024, 8, 7, 5, 54, 32, 756, DateTimeKind.Local).AddTicks(8392), 4524.11m },
                    { new Guid("0de66234-5f4e-4c5b-96e7-6dd9f055e93a"), new Guid("1e3c140e-4cab-4065-aadd-2c1cfed5ce14"), new DateTime(2024, 2, 2, 3, 24, 18, 799, DateTimeKind.Local).AddTicks(7309), new DateTime(2024, 8, 7, 7, 0, 41, 263, DateTimeKind.Local).AddTicks(2939), 3235.05m },
                    { new Guid("0e1ecd8a-bd9f-4584-bc49-1eed51829c88"), new Guid("697709be-b252-4405-bb7e-8673c6b98467"), new DateTime(2024, 6, 26, 22, 0, 14, 413, DateTimeKind.Local).AddTicks(3560), new DateTime(2024, 8, 8, 12, 15, 40, 343, DateTimeKind.Local).AddTicks(4016), 3141.39m },
                    { new Guid("0e70b9b4-b4a6-4db7-9088-b4c1c8f07191"), new Guid("9e65dc79-3d73-4629-8551-a5f2b9cfe2a4"), new DateTime(2023, 11, 1, 15, 54, 35, 365, DateTimeKind.Local).AddTicks(566), new DateTime(2024, 8, 7, 2, 48, 18, 41, DateTimeKind.Local).AddTicks(3683), 2033.51m },
                    { new Guid("0ebd31c4-db5f-41dd-8d45-651259f47182"), new Guid("b22bc921-a93c-4461-8bd3-df4b1e010bc1"), new DateTime(2024, 3, 29, 23, 20, 57, 9, DateTimeKind.Local).AddTicks(1984), new DateTime(2024, 8, 8, 14, 24, 29, 389, DateTimeKind.Local).AddTicks(7590), 449.69m },
                    { new Guid("0ecc2206-7c0c-4c5c-9f99-0d680e52cabf"), new Guid("eb503b18-f1e1-4a47-8871-99a4746eb8c6"), new DateTime(2024, 3, 6, 4, 51, 48, 935, DateTimeKind.Local).AddTicks(9897), new DateTime(2024, 8, 8, 15, 43, 1, 71, DateTimeKind.Local).AddTicks(7224), 2274.34m },
                    { new Guid("0f94aaa8-6dbd-4cb4-8878-24096b6ae1a8"), new Guid("9865321a-433a-4caa-8050-884b34c7c8d8"), new DateTime(2024, 6, 18, 23, 28, 12, 245, DateTimeKind.Local).AddTicks(1687), new DateTime(2024, 8, 7, 0, 54, 50, 25, DateTimeKind.Local).AddTicks(275), 4770.10m },
                    { new Guid("0fde66e4-3740-42b9-b877-6fa1d6dfe5c2"), new Guid("7b94208a-340f-4ed0-ad44-07a96fbc7d7a"), new DateTime(2024, 7, 10, 2, 55, 6, 942, DateTimeKind.Local).AddTicks(3731), new DateTime(2024, 8, 8, 14, 53, 20, 101, DateTimeKind.Local).AddTicks(5010), 1460.48m },
                    { new Guid("103eec76-8887-45c8-8b02-5b0686f6b72c"), new Guid("893b3fb0-9647-4958-b835-676e382779e7"), new DateTime(2024, 2, 1, 9, 54, 50, 820, DateTimeKind.Local).AddTicks(261), new DateTime(2024, 8, 8, 9, 38, 50, 926, DateTimeKind.Local).AddTicks(7190), 3057.10m },
                    { new Guid("10550c61-154e-432a-a791-a4aed3b9fcb1"), new Guid("24256d4c-7032-4437-8c1e-dd211c5bd713"), new DateTime(2024, 1, 26, 19, 31, 23, 138, DateTimeKind.Local).AddTicks(8223), new DateTime(2024, 8, 7, 8, 38, 33, 225, DateTimeKind.Local).AddTicks(3656), 2021.28m },
                    { new Guid("10719ab7-0210-49f7-b49b-48a29841c496"), new Guid("590c7122-bbd8-408c-9571-b8d385d97b9e"), new DateTime(2023, 11, 3, 23, 52, 59, 700, DateTimeKind.Local).AddTicks(5264), new DateTime(2024, 8, 7, 17, 1, 35, 989, DateTimeKind.Local).AddTicks(2537), 4587.71m },
                    { new Guid("1111b855-9f5e-419b-a108-00a8c6000076"), new Guid("d6d20276-ac8b-44d6-9939-d642e6335c51"), new DateTime(2023, 12, 27, 5, 51, 5, 796, DateTimeKind.Local).AddTicks(2451), new DateTime(2024, 8, 9, 9, 29, 48, 378, DateTimeKind.Local).AddTicks(2460), 1915.59m },
                    { new Guid("11253790-b438-43c6-bc47-98cc97f645a0"), new Guid("0bd930d6-b736-4558-87c1-50bd97e08db0"), new DateTime(2023, 8, 7, 0, 42, 7, 24, DateTimeKind.Local).AddTicks(98), new DateTime(2024, 8, 9, 11, 46, 8, 884, DateTimeKind.Local).AddTicks(4595), 133.63m },
                    { new Guid("129b4f74-492b-4bbd-9dc5-06b558ad6c6c"), new Guid("232fdc99-53fe-4232-9c74-06ddfb2a13b8"), new DateTime(2023, 8, 21, 13, 45, 26, 687, DateTimeKind.Local).AddTicks(3276), new DateTime(2024, 8, 9, 6, 17, 30, 520, DateTimeKind.Local).AddTicks(2031), 4383.79m },
                    { new Guid("12e05bb7-f787-4d12-bb03-52f77d685b59"), new Guid("d15c8331-36ed-417a-b1fa-5f377c4c9930"), new DateTime(2024, 4, 22, 10, 32, 3, 236, DateTimeKind.Local).AddTicks(2648), new DateTime(2024, 8, 9, 15, 12, 55, 519, DateTimeKind.Local).AddTicks(4417), 215.42m },
                    { new Guid("136c9d11-77d2-4772-b815-0c623eba229f"), new Guid("052538e6-f9b6-4bd1-98e0-6e7d6744fb4a"), new DateTime(2024, 3, 6, 14, 25, 9, 208, DateTimeKind.Local).AddTicks(7249), new DateTime(2024, 8, 7, 1, 56, 14, 492, DateTimeKind.Local).AddTicks(3588), 4409.98m },
                    { new Guid("136ffb69-8ad6-4cd8-baf5-ef69ab064579"), new Guid("75fe592b-5c1e-4814-a459-627bef01098f"), new DateTime(2024, 7, 19, 0, 34, 6, 581, DateTimeKind.Local).AddTicks(6455), new DateTime(2024, 8, 9, 12, 17, 51, 714, DateTimeKind.Local).AddTicks(3145), 1825.74m },
                    { new Guid("13cbf904-ce84-42f3-825d-0cd1710e0cd8"), new Guid("648119d0-d486-40c5-bd23-69a5e42b2ba5"), new DateTime(2023, 9, 1, 17, 13, 50, 904, DateTimeKind.Local).AddTicks(2658), new DateTime(2024, 8, 7, 17, 3, 59, 939, DateTimeKind.Local).AddTicks(1089), 1465.75m },
                    { new Guid("14246e12-d5c6-497b-a375-39a7e7c06102"), new Guid("9e65dc79-3d73-4629-8551-a5f2b9cfe2a4"), new DateTime(2024, 4, 22, 9, 2, 19, 213, DateTimeKind.Local).AddTicks(101), new DateTime(2024, 8, 7, 8, 18, 54, 76, DateTimeKind.Local).AddTicks(7028), 738.00m },
                    { new Guid("143ed09c-7438-4d10-9585-5ffbb801cd43"), new Guid("90fb9bfe-da70-4392-9904-4417fab257a7"), new DateTime(2024, 4, 19, 3, 54, 33, 66, DateTimeKind.Local).AddTicks(963), new DateTime(2024, 8, 7, 13, 19, 38, 877, DateTimeKind.Local).AddTicks(411), 398.38m },
                    { new Guid("14480085-3a7f-4121-b188-ca11bb99ddac"), new Guid("a2e054b5-4260-4454-a995-281c00600f11"), new DateTime(2024, 4, 3, 18, 9, 35, 824, DateTimeKind.Local).AddTicks(8013), new DateTime(2024, 8, 7, 21, 36, 37, 172, DateTimeKind.Local).AddTicks(9979), 4576.62m },
                    { new Guid("1476516e-7bfe-4393-877c-f009d07828d8"), new Guid("fa016e07-09ad-491e-a261-85cdebb45436"), new DateTime(2024, 1, 16, 14, 23, 1, 113, DateTimeKind.Local).AddTicks(2968), new DateTime(2024, 8, 7, 11, 10, 20, 213, DateTimeKind.Local).AddTicks(8469), 3073.48m },
                    { new Guid("14b9ea95-9eed-4cb5-95b2-709cd3eefefc"), new Guid("0b23e0d1-fa5b-4022-92b8-ff158e6d60ed"), new DateTime(2023, 9, 17, 9, 56, 33, 199, DateTimeKind.Local).AddTicks(6964), new DateTime(2024, 8, 7, 14, 22, 23, 491, DateTimeKind.Local).AddTicks(2568), 3333.42m },
                    { new Guid("14df59ec-a93a-4556-b892-2b3cf70e30e5"), new Guid("9865321a-433a-4caa-8050-884b34c7c8d8"), new DateTime(2024, 8, 1, 17, 50, 10, 431, DateTimeKind.Local).AddTicks(3240), new DateTime(2024, 8, 9, 20, 40, 21, 386, DateTimeKind.Local).AddTicks(4574), 4705.46m },
                    { new Guid("14e0251d-a28f-4e04-a275-d5930670fce2"), new Guid("44514479-669b-45b2-8af4-510b0786de9b"), new DateTime(2024, 6, 18, 23, 20, 42, 173, DateTimeKind.Local).AddTicks(4266), new DateTime(2024, 8, 9, 10, 59, 24, 744, DateTimeKind.Local).AddTicks(9182), 4182.98m },
                    { new Guid("150c6732-be90-47cb-921d-a06e69c2c3fa"), new Guid("9e65dc79-3d73-4629-8551-a5f2b9cfe2a4"), new DateTime(2023, 9, 2, 16, 47, 57, 16, DateTimeKind.Local).AddTicks(3431), new DateTime(2024, 8, 7, 7, 28, 41, 129, DateTimeKind.Local).AddTicks(1036), 51.58m },
                    { new Guid("1535626a-d75e-41a4-9053-c90c7033a363"), new Guid("427269be-9018-4cf4-9818-4fae14114ae4"), new DateTime(2024, 1, 9, 0, 33, 54, 551, DateTimeKind.Local).AddTicks(8560), new DateTime(2024, 8, 7, 16, 23, 10, 482, DateTimeKind.Local).AddTicks(5248), 202.94m },
                    { new Guid("1559d8da-6e5c-4e38-be2f-c996b374bc01"), new Guid("052538e6-f9b6-4bd1-98e0-6e7d6744fb4a"), new DateTime(2024, 6, 27, 21, 40, 15, 74, DateTimeKind.Local).AddTicks(2924), new DateTime(2024, 8, 9, 18, 56, 57, 927, DateTimeKind.Local).AddTicks(4085), 1621.59m },
                    { new Guid("158492e4-e615-4e0e-84b6-73244c9acdfe"), new Guid("1e3c140e-4cab-4065-aadd-2c1cfed5ce14"), new DateTime(2023, 11, 10, 0, 37, 57, 25, DateTimeKind.Local).AddTicks(3870), new DateTime(2024, 8, 9, 19, 24, 46, 110, DateTimeKind.Local).AddTicks(2064), 549.83m },
                    { new Guid("160b3b21-d4c0-4aec-b1cd-ab0db2af3883"), new Guid("648119d0-d486-40c5-bd23-69a5e42b2ba5"), new DateTime(2024, 1, 23, 11, 6, 39, 90, DateTimeKind.Local).AddTicks(6549), new DateTime(2024, 8, 8, 5, 33, 28, 905, DateTimeKind.Local).AddTicks(8305), 3085.21m },
                    { new Guid("165b81ea-88a5-4851-85c5-e055873d4b2d"), new Guid("427269be-9018-4cf4-9818-4fae14114ae4"), new DateTime(2024, 4, 18, 9, 29, 49, 406, DateTimeKind.Local).AddTicks(3171), new DateTime(2024, 8, 8, 9, 5, 30, 255, DateTimeKind.Local).AddTicks(2), 4969.94m },
                    { new Guid("16709304-821d-4cdd-87c9-6966c90c0ce5"), new Guid("9e65dc79-3d73-4629-8551-a5f2b9cfe2a4"), new DateTime(2023, 8, 28, 10, 47, 16, 180, DateTimeKind.Local).AddTicks(3183), new DateTime(2024, 8, 8, 0, 38, 23, 328, DateTimeKind.Local).AddTicks(7848), 2007.42m }
                });

            migrationBuilder.InsertData(
                table: "DonHangs",
                columns: new[] { "Id", "KhachHangId", "NgayDatHang", "NgayGiaoHang", "TongTien" },
                values: new object[,]
                {
                    { new Guid("1698f824-8fff-458c-ab39-a06c96578262"), new Guid("88888a0c-f1ed-4613-9646-ee6509dc5db0"), new DateTime(2024, 6, 3, 18, 59, 3, 825, DateTimeKind.Local).AddTicks(3251), new DateTime(2024, 8, 9, 5, 35, 50, 3, DateTimeKind.Local).AddTicks(318), 4926.78m },
                    { new Guid("16a0e250-44a1-48e3-940a-e03e13ae9bd9"), new Guid("2463d0a4-5008-43f5-97fd-bbd3d0048d8e"), new DateTime(2024, 6, 26, 20, 35, 36, 537, DateTimeKind.Local).AddTicks(7538), new DateTime(2024, 8, 7, 12, 33, 41, 633, DateTimeKind.Local).AddTicks(6637), 1344.93m },
                    { new Guid("16ba453e-634b-4969-8bb3-1fa4b59ecb6f"), new Guid("46685f7f-ca60-41b6-8cfb-4124c89cd625"), new DateTime(2024, 6, 4, 7, 43, 41, 460, DateTimeKind.Local).AddTicks(8188), new DateTime(2024, 8, 7, 1, 22, 17, 804, DateTimeKind.Local).AddTicks(1921), 85.44m },
                    { new Guid("172b5e29-5553-46b9-9b68-4e9be623e15c"), new Guid("3fd74fb4-2450-440d-8497-d9a630f57199"), new DateTime(2023, 11, 6, 3, 56, 32, 977, DateTimeKind.Local).AddTicks(7651), new DateTime(2024, 8, 8, 11, 19, 15, 678, DateTimeKind.Local).AddTicks(1950), 2173.78m },
                    { new Guid("1736ecc3-cc0a-4805-9bca-06625e48d16a"), new Guid("920b6ceb-11fd-4534-8c78-0adccdc2cbf5"), new DateTime(2023, 10, 3, 22, 55, 26, 274, DateTimeKind.Local).AddTicks(7276), new DateTime(2024, 8, 9, 21, 43, 55, 955, DateTimeKind.Local).AddTicks(6723), 3624.89m },
                    { new Guid("177a2dd4-cd4d-4d1c-ab16-2477e14ab9ce"), new Guid("75fe592b-5c1e-4814-a459-627bef01098f"), new DateTime(2024, 7, 20, 12, 33, 35, 117, DateTimeKind.Local).AddTicks(1811), new DateTime(2024, 8, 9, 9, 49, 29, 47, DateTimeKind.Local).AddTicks(2435), 1884.77m },
                    { new Guid("177d9c11-b448-4bdf-90b4-f4d276266426"), new Guid("9f2dcec6-cc02-45d6-95d0-fa0b53a5f953"), new DateTime(2024, 2, 3, 9, 41, 53, 813, DateTimeKind.Local).AddTicks(7833), new DateTime(2024, 8, 7, 5, 53, 15, 182, DateTimeKind.Local).AddTicks(1061), 4368.51m },
                    { new Guid("17a824a1-5062-45fa-9528-c488752a50e0"), new Guid("b0074e79-8782-48c2-b497-9ae7bd24e960"), new DateTime(2024, 3, 26, 5, 19, 15, 508, DateTimeKind.Local).AddTicks(8500), new DateTime(2024, 8, 8, 4, 7, 13, 503, DateTimeKind.Local).AddTicks(8429), 3956.00m },
                    { new Guid("17c8a64a-c1ae-4d71-813f-4f4ac4335110"), new Guid("a89b1694-3065-45be-9b67-fb5d87dc35f5"), new DateTime(2024, 2, 17, 10, 42, 29, 885, DateTimeKind.Local).AddTicks(5933), new DateTime(2024, 8, 8, 21, 42, 7, 752, DateTimeKind.Local).AddTicks(7064), 2524.79m },
                    { new Guid("1801eefa-7d51-48b5-af74-d13a6519c07e"), new Guid("4ebf8ce2-efc1-4c0d-8c61-7159ede74521"), new DateTime(2024, 5, 30, 17, 55, 3, 532, DateTimeKind.Local).AddTicks(9625), new DateTime(2024, 8, 7, 15, 42, 34, 161, DateTimeKind.Local).AddTicks(1164), 3008.23m },
                    { new Guid("18077e9f-bc07-487b-baa8-cbe3c0109b1d"), new Guid("cce9a706-5e55-4052-a88e-26f4b6765bc9"), new DateTime(2024, 3, 23, 3, 54, 9, 82, DateTimeKind.Local).AddTicks(8018), new DateTime(2024, 8, 9, 18, 45, 58, 127, DateTimeKind.Local).AddTicks(3625), 800.75m },
                    { new Guid("1822cab5-8e19-4965-97c7-6ad14c21bcd6"), new Guid("5bc8e452-e383-427e-bc9b-c26642f1a642"), new DateTime(2024, 4, 24, 1, 6, 25, 167, DateTimeKind.Local).AddTicks(7938), new DateTime(2024, 8, 7, 9, 11, 43, 935, DateTimeKind.Local).AddTicks(2964), 2856.77m },
                    { new Guid("188d170e-05b8-46ca-980a-7b94f29f1e94"), new Guid("fd9917bd-45e9-4bab-839f-7f5b5cbf03e7"), new DateTime(2024, 2, 25, 4, 42, 31, 743, DateTimeKind.Local).AddTicks(9307), new DateTime(2024, 8, 8, 17, 24, 32, 223, DateTimeKind.Local).AddTicks(9267), 1792.36m },
                    { new Guid("190c7fc4-dc17-4b16-8496-988256a2cab8"), new Guid("5e4be06c-1976-4755-aeb0-28dae4b4298b"), new DateTime(2024, 5, 5, 23, 52, 49, 6, DateTimeKind.Local).AddTicks(8947), new DateTime(2024, 8, 9, 10, 53, 34, 315, DateTimeKind.Local).AddTicks(7001), 904.05m },
                    { new Guid("196c4b51-d01a-4d70-809f-138cc6b87a4b"), new Guid("2db3541e-b13b-4e4b-b634-f31e8982b5e1"), new DateTime(2024, 6, 18, 16, 53, 26, 628, DateTimeKind.Local).AddTicks(9269), new DateTime(2024, 8, 6, 23, 31, 48, 645, DateTimeKind.Local).AddTicks(7531), 639.83m },
                    { new Guid("1a08eb78-21e9-48c9-9c1c-9174117fc17b"), new Guid("fafc2111-6b48-4585-8074-65bb860d42ae"), new DateTime(2023, 9, 19, 2, 32, 28, 134, DateTimeKind.Local).AddTicks(2473), new DateTime(2024, 8, 7, 1, 41, 52, 190, DateTimeKind.Local).AddTicks(687), 1017.80m },
                    { new Guid("1a118a23-649f-4457-a7ca-e6694baa4844"), new Guid("0b23e0d1-fa5b-4022-92b8-ff158e6d60ed"), new DateTime(2024, 1, 8, 22, 2, 11, 855, DateTimeKind.Local).AddTicks(5720), new DateTime(2024, 8, 8, 8, 35, 45, 418, DateTimeKind.Local).AddTicks(3288), 4513.12m },
                    { new Guid("1a2ba674-e94c-45ca-8739-5281323bf161"), new Guid("0667960a-b942-408f-9aa5-8591f0e0599a"), new DateTime(2024, 3, 23, 11, 16, 35, 757, DateTimeKind.Local).AddTicks(3419), new DateTime(2024, 8, 6, 23, 42, 30, 234, DateTimeKind.Local).AddTicks(7116), 4411.80m },
                    { new Guid("1a3f8a08-af46-4e9e-abe8-9ccf83539e87"), new Guid("b4a06e76-1c1e-4cac-aaa1-572d7a607954"), new DateTime(2024, 3, 21, 21, 14, 57, 71, DateTimeKind.Local).AddTicks(9727), new DateTime(2024, 8, 8, 16, 3, 25, 876, DateTimeKind.Local).AddTicks(8238), 2440.69m },
                    { new Guid("1a630e5f-6d48-45ba-acf6-a4927fa534c9"), new Guid("cce9a706-5e55-4052-a88e-26f4b6765bc9"), new DateTime(2024, 8, 6, 5, 20, 4, 644, DateTimeKind.Local).AddTicks(8504), new DateTime(2024, 8, 8, 16, 4, 2, 111, DateTimeKind.Local).AddTicks(6683), 3764.55m },
                    { new Guid("1abdcf82-67cf-45bc-adbc-de5eb57e86be"), new Guid("7395222e-7744-4172-86d1-1b128230fabf"), new DateTime(2023, 12, 1, 14, 32, 18, 697, DateTimeKind.Local).AddTicks(8414), new DateTime(2024, 8, 8, 7, 28, 12, 392, DateTimeKind.Local).AddTicks(331), 4273.71m },
                    { new Guid("1b0ea78a-cf4f-4c3a-9f64-2a55c511ad6b"), new Guid("873734f8-2118-4bff-95ec-9e199770cefb"), new DateTime(2024, 5, 14, 13, 41, 55, 969, DateTimeKind.Local).AddTicks(6171), new DateTime(2024, 8, 8, 16, 54, 51, 502, DateTimeKind.Local).AddTicks(4999), 813.02m },
                    { new Guid("1b18bb3f-d718-4f0a-a2b5-4138b5da8a6a"), new Guid("2db3541e-b13b-4e4b-b634-f31e8982b5e1"), new DateTime(2024, 7, 23, 6, 58, 49, 699, DateTimeKind.Local).AddTicks(5733), new DateTime(2024, 8, 7, 19, 58, 42, 702, DateTimeKind.Local).AddTicks(7543), 2031.76m },
                    { new Guid("1bcbbe42-6141-4b77-8775-76749ed82129"), new Guid("cce9a706-5e55-4052-a88e-26f4b6765bc9"), new DateTime(2024, 6, 9, 9, 51, 53, 70, DateTimeKind.Local).AddTicks(1082), new DateTime(2024, 8, 8, 13, 46, 53, 631, DateTimeKind.Local).AddTicks(8535), 1518.71m },
                    { new Guid("1c0efb4c-4a7d-449a-a29d-997c02141f4e"), new Guid("38ba8024-3b8d-4dd6-92b9-9d06da12ec6e"), new DateTime(2024, 3, 3, 6, 52, 10, 678, DateTimeKind.Local).AddTicks(7364), new DateTime(2024, 8, 8, 11, 51, 48, 127, DateTimeKind.Local).AddTicks(2470), 1999.68m },
                    { new Guid("1c45fc7c-f1e7-487b-b159-5e11a949d476"), new Guid("a99891d8-254d-4ec7-8cae-cf3bcb8c10a1"), new DateTime(2024, 3, 7, 5, 42, 9, 433, DateTimeKind.Local).AddTicks(1759), new DateTime(2024, 8, 9, 10, 54, 14, 750, DateTimeKind.Local).AddTicks(418), 1505.01m },
                    { new Guid("1c6f4b40-4cfb-4cbc-8dd5-9c7daaab1d19"), new Guid("63021a65-455d-454a-92ee-525601ead4df"), new DateTime(2024, 7, 13, 3, 57, 30, 950, DateTimeKind.Local).AddTicks(8499), new DateTime(2024, 8, 7, 0, 45, 30, 637, DateTimeKind.Local).AddTicks(931), 1393.38m },
                    { new Guid("1ca83c2e-a44f-4edc-8ea0-55931c19a4d7"), new Guid("3cd8e5f4-df7e-4a22-84a3-04966bad5197"), new DateTime(2023, 12, 24, 3, 11, 8, 530, DateTimeKind.Local).AddTicks(2515), new DateTime(2024, 8, 8, 12, 18, 47, 867, DateTimeKind.Local).AddTicks(8721), 1117.95m },
                    { new Guid("1cb62b17-9124-4fba-b518-e5e39cef8737"), new Guid("c06db99e-509c-4391-b257-6799307a8b3c"), new DateTime(2023, 8, 19, 15, 36, 45, 72, DateTimeKind.Local).AddTicks(7902), new DateTime(2024, 8, 7, 10, 55, 41, 929, DateTimeKind.Local).AddTicks(3208), 1339.90m },
                    { new Guid("1cd41097-c918-44bd-b6d2-f91ef5ab454a"), new Guid("873734f8-2118-4bff-95ec-9e199770cefb"), new DateTime(2023, 12, 31, 16, 3, 32, 920, DateTimeKind.Local).AddTicks(7645), new DateTime(2024, 8, 9, 11, 17, 9, 258, DateTimeKind.Local).AddTicks(6471), 1770.16m },
                    { new Guid("1d1af3c9-388a-4422-850b-3e3f1c2d94af"), new Guid("297e58cc-55d1-4c96-81c1-edd1b4b0ffb7"), new DateTime(2023, 10, 24, 4, 2, 3, 61, DateTimeKind.Local).AddTicks(2648), new DateTime(2024, 8, 9, 11, 52, 1, 772, DateTimeKind.Local).AddTicks(648), 768.36m },
                    { new Guid("1d7c432e-b091-4e8d-95c2-65b86cc2dad5"), new Guid("a38bfc8c-feac-4053-b76e-84c4e66d74d6"), new DateTime(2023, 12, 16, 21, 20, 51, 707, DateTimeKind.Local).AddTicks(1855), new DateTime(2024, 8, 9, 7, 17, 51, 234, DateTimeKind.Local).AddTicks(249), 3066.06m },
                    { new Guid("1e0c14c0-f694-4dbb-bdd6-d0e4fdd64590"), new Guid("9e65dc79-3d73-4629-8551-a5f2b9cfe2a4"), new DateTime(2024, 3, 16, 13, 59, 43, 379, DateTimeKind.Local).AddTicks(2491), new DateTime(2024, 8, 8, 4, 39, 28, 394, DateTimeKind.Local).AddTicks(4583), 2451.52m },
                    { new Guid("1e1f3ea7-b140-4ad4-ae60-5c9aecbea104"), new Guid("6b4bca52-0cf9-4a9e-98cf-0eb6e3c24da0"), new DateTime(2024, 4, 4, 8, 48, 21, 624, DateTimeKind.Local).AddTicks(5678), new DateTime(2024, 8, 7, 17, 54, 27, 889, DateTimeKind.Local).AddTicks(8929), 3467.80m },
                    { new Guid("1e4df49f-85e4-4798-a91a-2575b532f318"), new Guid("f9a1bd2e-de1a-42b8-b894-7f7e0b5b38f1"), new DateTime(2023, 11, 13, 17, 16, 48, 832, DateTimeKind.Local).AddTicks(4282), new DateTime(2024, 8, 8, 15, 19, 10, 518, DateTimeKind.Local).AddTicks(8830), 2082.62m },
                    { new Guid("1e925cd5-0ba1-4167-ab29-5b91c356fe51"), new Guid("b41438f5-9380-4cd7-bc4d-59267b9b760c"), new DateTime(2023, 12, 3, 17, 14, 58, 377, DateTimeKind.Local).AddTicks(2028), new DateTime(2024, 8, 9, 6, 5, 6, 372, DateTimeKind.Local).AddTicks(2686), 1057.99m },
                    { new Guid("1eb2ec13-da51-4f53-8f6e-4d09a78253a1"), new Guid("c93b2790-efbb-4887-bc62-908698026478"), new DateTime(2023, 9, 11, 13, 25, 10, 795, DateTimeKind.Local).AddTicks(9318), new DateTime(2024, 8, 8, 14, 6, 21, 964, DateTimeKind.Local).AddTicks(5865), 1068.07m },
                    { new Guid("1eb63a7b-9c35-4d2f-93c4-85874c9268f4"), new Guid("697709be-b252-4405-bb7e-8673c6b98467"), new DateTime(2023, 11, 5, 23, 2, 48, 42, DateTimeKind.Local).AddTicks(2408), new DateTime(2024, 8, 7, 21, 53, 20, 748, DateTimeKind.Local).AddTicks(2604), 3386.97m },
                    { new Guid("1ed98f17-de52-42a3-9c5e-1a4af64b104e"), new Guid("3cd8e5f4-df7e-4a22-84a3-04966bad5197"), new DateTime(2024, 1, 3, 0, 57, 53, 863, DateTimeKind.Local).AddTicks(5068), new DateTime(2024, 8, 7, 9, 23, 4, 878, DateTimeKind.Local).AddTicks(3948), 901.60m },
                    { new Guid("1ee9acb7-5ec2-48d2-b98a-ec6f900de50c"), new Guid("4ebf8ce2-efc1-4c0d-8c61-7159ede74521"), new DateTime(2023, 9, 24, 3, 42, 5, 593, DateTimeKind.Local).AddTicks(3586), new DateTime(2024, 8, 9, 18, 4, 26, 783, DateTimeKind.Local).AddTicks(8973), 4867.17m },
                    { new Guid("1f669399-3349-4ec5-9483-63dbcfd595ce"), new Guid("427269be-9018-4cf4-9818-4fae14114ae4"), new DateTime(2024, 3, 13, 20, 58, 33, 615, DateTimeKind.Local).AddTicks(9781), new DateTime(2024, 8, 7, 6, 26, 56, 569, DateTimeKind.Local).AddTicks(1825), 509.97m },
                    { new Guid("1f8eee8d-2644-4e5b-a4ad-f12b5014270e"), new Guid("e56e8c86-41ee-47fd-9d05-a94a167bed10"), new DateTime(2024, 3, 2, 19, 50, 49, 988, DateTimeKind.Local).AddTicks(8175), new DateTime(2024, 8, 8, 18, 56, 52, 471, DateTimeKind.Local).AddTicks(1210), 786.59m }
                });

            migrationBuilder.InsertData(
                table: "DonHangs",
                columns: new[] { "Id", "KhachHangId", "NgayDatHang", "NgayGiaoHang", "TongTien" },
                values: new object[,]
                {
                    { new Guid("1f927926-f6d3-405b-82a2-ea406cdde4b6"), new Guid("3da3214c-bd0e-4377-a9dd-da000298cefd"), new DateTime(2024, 3, 20, 3, 27, 6, 920, DateTimeKind.Local).AddTicks(845), new DateTime(2024, 8, 8, 22, 42, 52, 717, DateTimeKind.Local).AddTicks(7394), 1543.02m },
                    { new Guid("1ff5dc8a-4de7-4fec-9b3a-7bce9cfa6d6e"), new Guid("15883dbe-e97e-4859-86f7-993bbc1173df"), new DateTime(2023, 12, 30, 19, 15, 22, 580, DateTimeKind.Local).AddTicks(4986), new DateTime(2024, 8, 9, 4, 15, 51, 485, DateTimeKind.Local).AddTicks(9603), 3292.38m },
                    { new Guid("2027000f-91d3-496a-aa7c-f18fe98523fe"), new Guid("6212ef8f-9777-42a2-ad28-a2ed1ebe90f8"), new DateTime(2023, 12, 20, 4, 3, 55, 721, DateTimeKind.Local).AddTicks(9750), new DateTime(2024, 8, 8, 14, 17, 2, 352, DateTimeKind.Local).AddTicks(1215), 3644.93m },
                    { new Guid("202d6780-8e4e-425a-bc35-34fa2cdbc80e"), new Guid("6b4bca52-0cf9-4a9e-98cf-0eb6e3c24da0"), new DateTime(2024, 3, 20, 11, 51, 26, 609, DateTimeKind.Local).AddTicks(1174), new DateTime(2024, 8, 7, 16, 18, 5, 747, DateTimeKind.Local).AddTicks(6276), 2999.95m },
                    { new Guid("21832f54-781d-43fd-919b-0dac507f6954"), new Guid("5ee23c83-8a7a-498c-96a6-f2bc6fdc8136"), new DateTime(2024, 4, 2, 12, 6, 23, 216, DateTimeKind.Local).AddTicks(9180), new DateTime(2024, 8, 8, 14, 16, 33, 540, DateTimeKind.Local).AddTicks(2449), 4191.82m },
                    { new Guid("21c84d09-a3ac-47d8-b7ca-2b1b0aa588c9"), new Guid("5e4be06c-1976-4755-aeb0-28dae4b4298b"), new DateTime(2024, 4, 6, 4, 16, 1, 269, DateTimeKind.Local).AddTicks(1625), new DateTime(2024, 8, 7, 15, 19, 33, 177, DateTimeKind.Local).AddTicks(7128), 1665.04m },
                    { new Guid("21d24e56-2a0e-4c44-b7ab-6270534cbe2f"), new Guid("427269be-9018-4cf4-9818-4fae14114ae4"), new DateTime(2024, 5, 25, 11, 4, 25, 237, DateTimeKind.Local).AddTicks(1297), new DateTime(2024, 8, 9, 3, 20, 40, 914, DateTimeKind.Local).AddTicks(8343), 4635.34m },
                    { new Guid("222d9fe0-5b4e-4af5-bec1-02a3b0e70d29"), new Guid("0bd930d6-b736-4558-87c1-50bd97e08db0"), new DateTime(2024, 7, 9, 18, 50, 2, 527, DateTimeKind.Local).AddTicks(7667), new DateTime(2024, 8, 7, 18, 13, 35, 182, DateTimeKind.Local).AddTicks(8975), 4026.97m },
                    { new Guid("22cef5db-3369-43a3-a259-e25edc6c4cb6"), new Guid("d15c8331-36ed-417a-b1fa-5f377c4c9930"), new DateTime(2023, 12, 11, 22, 4, 22, 363, DateTimeKind.Local).AddTicks(2862), new DateTime(2024, 8, 8, 16, 54, 55, 252, DateTimeKind.Local).AddTicks(1978), 3745.04m },
                    { new Guid("23295f7c-a7ef-4bb4-9f6a-59137c8a56ca"), new Guid("88603d45-af2e-4381-b8d8-2c53ebbaccd2"), new DateTime(2024, 6, 29, 23, 18, 17, 720, DateTimeKind.Local).AddTicks(8219), new DateTime(2024, 8, 8, 10, 37, 21, 121, DateTimeKind.Local).AddTicks(9476), 224.54m },
                    { new Guid("23949674-0dc3-490c-8122-f2df2a6b6491"), new Guid("c93b2790-efbb-4887-bc62-908698026478"), new DateTime(2023, 12, 31, 10, 52, 36, 824, DateTimeKind.Local).AddTicks(8415), new DateTime(2024, 8, 7, 1, 27, 35, 817, DateTimeKind.Local).AddTicks(60), 3534.29m },
                    { new Guid("23dd459c-8e00-41e6-9538-a424db1c1be6"), new Guid("c93b2790-efbb-4887-bc62-908698026478"), new DateTime(2023, 12, 8, 1, 24, 14, 75, DateTimeKind.Local).AddTicks(467), new DateTime(2024, 8, 9, 16, 27, 3, 479, DateTimeKind.Local).AddTicks(7225), 1840.75m },
                    { new Guid("2402d5d3-01fe-403a-a07a-2b724ee346c2"), new Guid("7395222e-7744-4172-86d1-1b128230fabf"), new DateTime(2023, 10, 19, 11, 43, 24, 694, DateTimeKind.Local).AddTicks(7376), new DateTime(2024, 8, 9, 11, 42, 59, 314, DateTimeKind.Local).AddTicks(6120), 4684.20m },
                    { new Guid("24b9f3f1-96dc-4f11-826d-b0f2a36b2807"), new Guid("d43ed679-0d22-40c7-a14a-6d01fe86c193"), new DateTime(2023, 12, 22, 10, 55, 47, 99, DateTimeKind.Local).AddTicks(4489), new DateTime(2024, 8, 9, 12, 42, 49, 702, DateTimeKind.Local).AddTicks(5256), 2906.98m },
                    { new Guid("24cd1b0c-9230-483b-b8fd-25f4076e2423"), new Guid("46685f7f-ca60-41b6-8cfb-4124c89cd625"), new DateTime(2024, 6, 4, 15, 27, 11, 848, DateTimeKind.Local).AddTicks(3992), new DateTime(2024, 8, 7, 2, 19, 6, 34, DateTimeKind.Local).AddTicks(9867), 4821.00m },
                    { new Guid("24f37764-182b-43c8-8506-f4312770d23b"), new Guid("e56e8c86-41ee-47fd-9d05-a94a167bed10"), new DateTime(2023, 8, 24, 21, 35, 31, 259, DateTimeKind.Local).AddTicks(7825), new DateTime(2024, 8, 9, 14, 11, 23, 488, DateTimeKind.Local).AddTicks(2301), 4407.30m },
                    { new Guid("2505661f-f985-4398-93a2-539ea927ce8f"), new Guid("6f2bc11e-7dd7-4049-9e35-163927214820"), new DateTime(2024, 4, 17, 1, 29, 23, 706, DateTimeKind.Local).AddTicks(2160), new DateTime(2024, 8, 7, 12, 11, 32, 974, DateTimeKind.Local).AddTicks(8796), 1376.90m },
                    { new Guid("261fc8bb-024d-4d6e-af94-dae80f639056"), new Guid("a38bfc8c-feac-4053-b76e-84c4e66d74d6"), new DateTime(2024, 6, 10, 1, 16, 13, 233, DateTimeKind.Local).AddTicks(3365), new DateTime(2024, 8, 8, 3, 57, 28, 890, DateTimeKind.Local).AddTicks(5423), 4281.64m },
                    { new Guid("26289972-ac89-4113-9634-a10b20298fb1"), new Guid("920b6ceb-11fd-4534-8c78-0adccdc2cbf5"), new DateTime(2024, 7, 3, 16, 3, 25, 637, DateTimeKind.Local).AddTicks(4915), new DateTime(2024, 8, 8, 21, 1, 6, 19, DateTimeKind.Local).AddTicks(9052), 116.28m },
                    { new Guid("270673d4-72e4-4892-a07f-59d534d4170e"), new Guid("9e65dc79-3d73-4629-8551-a5f2b9cfe2a4"), new DateTime(2023, 12, 17, 6, 58, 36, 309, DateTimeKind.Local).AddTicks(4743), new DateTime(2024, 8, 8, 9, 12, 0, 692, DateTimeKind.Local).AddTicks(1726), 4697.36m },
                    { new Guid("281952b3-9e8a-492b-883d-0c3ba39d9ff7"), new Guid("a51f9433-2477-4445-8a69-d24c50d95afb"), new DateTime(2023, 8, 11, 3, 41, 48, 780, DateTimeKind.Local).AddTicks(2230), new DateTime(2024, 8, 9, 19, 24, 15, 400, DateTimeKind.Local).AddTicks(4129), 3691.32m },
                    { new Guid("28481c43-bdd8-4718-8cec-7ee3bb65e9f5"), new Guid("45859554-61d6-4f50-90eb-b40d19a17909"), new DateTime(2024, 6, 14, 2, 35, 24, 548, DateTimeKind.Local).AddTicks(4018), new DateTime(2024, 8, 9, 1, 53, 1, 831, DateTimeKind.Local).AddTicks(95), 3170.59m },
                    { new Guid("284c7bd0-73df-4967-87ec-60d52b7a0c2f"), new Guid("88603d45-af2e-4381-b8d8-2c53ebbaccd2"), new DateTime(2024, 5, 5, 2, 42, 31, 690, DateTimeKind.Local).AddTicks(6332), new DateTime(2024, 8, 7, 21, 38, 14, 569, DateTimeKind.Local).AddTicks(9242), 4277.48m },
                    { new Guid("28e2caaa-e460-4f60-8b88-096464a474df"), new Guid("9f2dcec6-cc02-45d6-95d0-fa0b53a5f953"), new DateTime(2023, 11, 25, 12, 27, 3, 320, DateTimeKind.Local).AddTicks(2790), new DateTime(2024, 8, 9, 0, 45, 40, 816, DateTimeKind.Local).AddTicks(8728), 2525.06m },
                    { new Guid("290c1e54-076a-4ea5-a687-d707838e87cc"), new Guid("90ece793-c6f5-47e7-8aa0-7c08ff3548fb"), new DateTime(2024, 2, 5, 22, 32, 1, 717, DateTimeKind.Local).AddTicks(3661), new DateTime(2024, 8, 8, 22, 42, 46, 814, DateTimeKind.Local).AddTicks(2689), 1792.66m },
                    { new Guid("29377659-b30f-4c29-871c-d263ec2bf2c4"), new Guid("fd9917bd-45e9-4bab-839f-7f5b5cbf03e7"), new DateTime(2023, 8, 13, 22, 23, 41, 905, DateTimeKind.Local).AddTicks(2640), new DateTime(2024, 8, 9, 12, 0, 44, 748, DateTimeKind.Local).AddTicks(119), 1408.99m },
                    { new Guid("297cfdf6-d3e5-491d-b73e-32a6056578f8"), new Guid("22ebc934-105f-4b38-ab74-feae23d1ffc0"), new DateTime(2023, 9, 28, 5, 39, 24, 173, DateTimeKind.Local).AddTicks(8651), new DateTime(2024, 8, 7, 19, 34, 46, 328, DateTimeKind.Local).AddTicks(3175), 4093.34m },
                    { new Guid("299f8abc-438e-4082-a288-c967ece78845"), new Guid("648119d0-d486-40c5-bd23-69a5e42b2ba5"), new DateTime(2024, 8, 5, 0, 6, 9, 356, DateTimeKind.Local).AddTicks(4496), new DateTime(2024, 8, 7, 17, 3, 51, 381, DateTimeKind.Local).AddTicks(6997), 3875.33m },
                    { new Guid("29ac8c04-69f8-48e5-af1c-9f5a8d4a4a4b"), new Guid("a89b1694-3065-45be-9b67-fb5d87dc35f5"), new DateTime(2023, 11, 11, 13, 30, 8, 383, DateTimeKind.Local).AddTicks(774), new DateTime(2024, 8, 8, 22, 20, 7, 535, DateTimeKind.Local).AddTicks(6739), 924.68m },
                    { new Guid("29b46534-e3aa-4895-82a3-b84522f8b815"), new Guid("eb503b18-f1e1-4a47-8871-99a4746eb8c6"), new DateTime(2023, 12, 31, 3, 1, 19, 572, DateTimeKind.Local).AddTicks(8577), new DateTime(2024, 8, 9, 11, 18, 32, 989, DateTimeKind.Local).AddTicks(529), 3217.82m },
                    { new Guid("29e83e50-73c5-425b-900d-2deef8480199"), new Guid("b0074e79-8782-48c2-b497-9ae7bd24e960"), new DateTime(2024, 6, 7, 5, 41, 12, 927, DateTimeKind.Local).AddTicks(2572), new DateTime(2024, 8, 8, 16, 28, 10, 892, DateTimeKind.Local).AddTicks(6926), 291.81m },
                    { new Guid("29f9ba60-7add-4eb8-b6eb-3ca571d60f94"), new Guid("fa016e07-09ad-491e-a261-85cdebb45436"), new DateTime(2024, 2, 27, 21, 16, 56, 149, DateTimeKind.Local).AddTicks(381), new DateTime(2024, 8, 7, 6, 4, 13, 401, DateTimeKind.Local).AddTicks(9572), 926.21m },
                    { new Guid("2a12bdc6-f8e3-4981-b1e7-51f0998600e6"), new Guid("cce9a706-5e55-4052-a88e-26f4b6765bc9"), new DateTime(2023, 12, 29, 20, 32, 38, 314, DateTimeKind.Local).AddTicks(8442), new DateTime(2024, 8, 9, 11, 28, 51, 723, DateTimeKind.Local).AddTicks(7577), 4825.46m },
                    { new Guid("2a5f9821-c9fa-4d08-987f-cd297031d4d2"), new Guid("232fdc99-53fe-4232-9c74-06ddfb2a13b8"), new DateTime(2024, 1, 19, 11, 33, 48, 543, DateTimeKind.Local).AddTicks(9793), new DateTime(2024, 8, 8, 0, 58, 0, 354, DateTimeKind.Local).AddTicks(5474), 1837.56m },
                    { new Guid("2a9426d1-37a6-47ae-a21e-b32c020b3c86"), new Guid("b22bc921-a93c-4461-8bd3-df4b1e010bc1"), new DateTime(2024, 2, 14, 10, 39, 18, 24, DateTimeKind.Local).AddTicks(6577), new DateTime(2024, 8, 8, 0, 32, 4, 818, DateTimeKind.Local).AddTicks(1827), 638.08m },
                    { new Guid("2ab0090d-3f3d-4a11-8893-0b474246f09a"), new Guid("90ece793-c6f5-47e7-8aa0-7c08ff3548fb"), new DateTime(2023, 11, 3, 20, 15, 35, 804, DateTimeKind.Local).AddTicks(1819), new DateTime(2024, 8, 9, 19, 56, 52, 685, DateTimeKind.Local).AddTicks(228), 4070.05m },
                    { new Guid("2afa2003-e7e3-4327-9b7a-33d2b4a7689d"), new Guid("5e4be06c-1976-4755-aeb0-28dae4b4298b"), new DateTime(2023, 9, 28, 15, 2, 13, 681, DateTimeKind.Local).AddTicks(5344), new DateTime(2024, 8, 8, 11, 30, 39, 943, DateTimeKind.Local).AddTicks(3812), 4504.85m },
                    { new Guid("2bc92d66-f4bd-4afe-b72a-c4b07b996811"), new Guid("6d1e80c0-f438-45cd-a63c-9bf2330160b6"), new DateTime(2023, 8, 30, 1, 35, 34, 174, DateTimeKind.Local).AddTicks(3171), new DateTime(2024, 8, 9, 5, 51, 19, 105, DateTimeKind.Local).AddTicks(6297), 2396.45m },
                    { new Guid("2cd6cfcc-9c5c-479f-b44c-ec4de0a3a633"), new Guid("63021a65-455d-454a-92ee-525601ead4df"), new DateTime(2024, 2, 21, 23, 59, 0, 793, DateTimeKind.Local).AddTicks(2180), new DateTime(2024, 8, 9, 14, 22, 5, 790, DateTimeKind.Local).AddTicks(6966), 2697.29m },
                    { new Guid("2d01fcef-c883-46b8-a5d7-51b387af3c8a"), new Guid("17544f0d-9e01-4955-b49a-dcc4b6a770ee"), new DateTime(2023, 11, 15, 19, 32, 34, 469, DateTimeKind.Local).AddTicks(4012), new DateTime(2024, 8, 9, 5, 39, 26, 969, DateTimeKind.Local).AddTicks(6670), 3183.04m },
                    { new Guid("2d134ba0-6b40-4c5b-a15e-22eb608d7aa3"), new Guid("28d8da78-c6c4-4afe-9d92-22d52e3969b0"), new DateTime(2023, 8, 17, 23, 8, 35, 752, DateTimeKind.Local).AddTicks(6011), new DateTime(2024, 8, 7, 11, 36, 11, 827, DateTimeKind.Local).AddTicks(2240), 3825.40m },
                    { new Guid("2d6c032e-3afe-4fe7-8c6d-270f5ade4c34"), new Guid("ceeb839d-d443-4791-8018-561c89d6e7d9"), new DateTime(2023, 11, 16, 16, 28, 7, 732, DateTimeKind.Local).AddTicks(2564), new DateTime(2024, 8, 9, 3, 26, 8, 89, DateTimeKind.Local).AddTicks(2343), 1198.13m }
                });

            migrationBuilder.InsertData(
                table: "DonHangs",
                columns: new[] { "Id", "KhachHangId", "NgayDatHang", "NgayGiaoHang", "TongTien" },
                values: new object[,]
                {
                    { new Guid("2d980f17-7037-4a68-9716-37213bb80164"), new Guid("17652753-332f-4654-89d0-bbca6d67670f"), new DateTime(2023, 11, 25, 10, 21, 40, 762, DateTimeKind.Local).AddTicks(6294), new DateTime(2024, 8, 8, 10, 28, 17, 66, DateTimeKind.Local).AddTicks(3553), 2708.01m },
                    { new Guid("2dd29083-560c-467c-8d6c-1d98a692aa17"), new Guid("893b3fb0-9647-4958-b835-676e382779e7"), new DateTime(2024, 5, 1, 12, 43, 32, 813, DateTimeKind.Local).AddTicks(2128), new DateTime(2024, 8, 9, 0, 48, 41, 853, DateTimeKind.Local).AddTicks(2345), 2926.61m },
                    { new Guid("2de32644-c4ba-46a6-a6f1-79dac85e6bc8"), new Guid("22ebc934-105f-4b38-ab74-feae23d1ffc0"), new DateTime(2023, 10, 26, 3, 52, 6, 774, DateTimeKind.Local).AddTicks(9133), new DateTime(2024, 8, 9, 13, 54, 49, 418, DateTimeKind.Local).AddTicks(9593), 3500.36m },
                    { new Guid("2e2418cb-b0c4-4a78-abaa-e8af5f1e9fb6"), new Guid("3cd8e5f4-df7e-4a22-84a3-04966bad5197"), new DateTime(2024, 3, 2, 4, 19, 47, 88, DateTimeKind.Local).AddTicks(3168), new DateTime(2024, 8, 7, 19, 27, 55, 813, DateTimeKind.Local).AddTicks(5309), 4215.76m },
                    { new Guid("2e98f59f-def3-463f-9701-46d996713702"), new Guid("5611f5df-6d74-47b4-b24b-5863bd50f032"), new DateTime(2024, 5, 17, 0, 25, 30, 831, DateTimeKind.Local).AddTicks(6602), new DateTime(2024, 8, 7, 10, 32, 49, 256, DateTimeKind.Local).AddTicks(7458), 1395.77m },
                    { new Guid("2ed78a45-bd54-47e0-8beb-9709542e210e"), new Guid("5e4be06c-1976-4755-aeb0-28dae4b4298b"), new DateTime(2023, 11, 9, 14, 17, 52, 109, DateTimeKind.Local).AddTicks(4141), new DateTime(2024, 8, 8, 0, 50, 45, 477, DateTimeKind.Local).AddTicks(1455), 1365.37m },
                    { new Guid("2edc70ca-acb8-4822-968a-5a9545ede626"), new Guid("8bc08888-8550-4e72-9b5e-71845b5b9567"), new DateTime(2024, 2, 23, 4, 10, 42, 506, DateTimeKind.Local).AddTicks(2621), new DateTime(2024, 8, 7, 17, 46, 54, 633, DateTimeKind.Local).AddTicks(1790), 1354.95m },
                    { new Guid("2f3139bb-0122-48a8-9d7f-38e9af7b13d8"), new Guid("2f5efba5-6605-4ccc-9a86-918b9bd19b8b"), new DateTime(2023, 11, 17, 20, 1, 3, 418, DateTimeKind.Local).AddTicks(9916), new DateTime(2024, 8, 9, 14, 3, 4, 726, DateTimeKind.Local).AddTicks(302), 824.68m },
                    { new Guid("2f38e0ac-4a21-4372-bfb7-c9683f7b3aeb"), new Guid("17652753-332f-4654-89d0-bbca6d67670f"), new DateTime(2023, 9, 13, 0, 4, 5, 808, DateTimeKind.Local).AddTicks(804), new DateTime(2024, 8, 8, 7, 15, 57, 689, DateTimeKind.Local).AddTicks(9829), 2692.68m },
                    { new Guid("2f51df91-0d48-40c6-bfea-a91aa2076ba5"), new Guid("33caf896-8425-48e6-86b5-a47f32bb1850"), new DateTime(2023, 11, 13, 19, 46, 24, 800, DateTimeKind.Local).AddTicks(6390), new DateTime(2024, 8, 8, 4, 50, 13, 476, DateTimeKind.Local).AddTicks(6815), 1661.84m },
                    { new Guid("2f556033-6914-4dc0-a14b-1a52de790f8f"), new Guid("ceeb839d-d443-4791-8018-561c89d6e7d9"), new DateTime(2024, 5, 30, 20, 23, 44, 180, DateTimeKind.Local).AddTicks(6500), new DateTime(2024, 8, 8, 21, 57, 56, 381, DateTimeKind.Local).AddTicks(1092), 2932.68m },
                    { new Guid("2f763a52-b693-4d0a-b60b-6b83b34b4cc1"), new Guid("052538e6-f9b6-4bd1-98e0-6e7d6744fb4a"), new DateTime(2024, 5, 26, 7, 19, 16, 571, DateTimeKind.Local).AddTicks(3099), new DateTime(2024, 8, 8, 16, 32, 15, 198, DateTimeKind.Local).AddTicks(6068), 503.25m },
                    { new Guid("303e03fd-5535-428e-9e27-7e118fdd0623"), new Guid("e9d684aa-183f-423f-8741-1a53cfb8f2e3"), new DateTime(2024, 5, 31, 13, 0, 9, 274, DateTimeKind.Local).AddTicks(8711), new DateTime(2024, 8, 9, 11, 3, 20, 124, DateTimeKind.Local).AddTicks(3717), 3661.57m },
                    { new Guid("307d9ac7-c15b-4e8f-a3ee-91f9d34141fe"), new Guid("15883dbe-e97e-4859-86f7-993bbc1173df"), new DateTime(2024, 6, 28, 12, 6, 6, 650, DateTimeKind.Local).AddTicks(2002), new DateTime(2024, 8, 7, 19, 55, 34, 108, DateTimeKind.Local).AddTicks(7190), 1969.73m },
                    { new Guid("30ce7fae-aad1-4c1b-9371-cb03be2381b5"), new Guid("1d71e542-620f-4161-9842-a2a145bd7013"), new DateTime(2023, 11, 26, 5, 11, 45, 401, DateTimeKind.Local).AddTicks(3626), new DateTime(2024, 8, 7, 22, 25, 25, 913, DateTimeKind.Local).AddTicks(4693), 3382.89m },
                    { new Guid("31884e0b-3904-4df7-a6a2-ee4670138e19"), new Guid("b41438f5-9380-4cd7-bc4d-59267b9b760c"), new DateTime(2023, 12, 11, 16, 53, 12, 328, DateTimeKind.Local).AddTicks(172), new DateTime(2024, 8, 8, 7, 32, 20, 438, DateTimeKind.Local).AddTicks(9223), 2250.46m },
                    { new Guid("319f4ddb-c1d0-4a65-ad8f-8c82947a33ea"), new Guid("22ebc934-105f-4b38-ab74-feae23d1ffc0"), new DateTime(2024, 2, 27, 19, 48, 13, 877, DateTimeKind.Local).AddTicks(6990), new DateTime(2024, 8, 7, 1, 35, 4, 919, DateTimeKind.Local).AddTicks(6936), 2871.35m },
                    { new Guid("31ab9716-dd0f-414d-a37c-506283a68db3"), new Guid("5611f5df-6d74-47b4-b24b-5863bd50f032"), new DateTime(2024, 3, 8, 6, 40, 46, 943, DateTimeKind.Local).AddTicks(2992), new DateTime(2024, 8, 8, 17, 59, 47, 228, DateTimeKind.Local).AddTicks(5853), 4307.79m },
                    { new Guid("3222b106-d507-4514-a4fc-462197af01bc"), new Guid("648119d0-d486-40c5-bd23-69a5e42b2ba5"), new DateTime(2024, 7, 1, 3, 39, 22, 534, DateTimeKind.Local).AddTicks(8601), new DateTime(2024, 8, 8, 11, 49, 52, 594, DateTimeKind.Local).AddTicks(1100), 3476.09m },
                    { new Guid("32e149b4-cc28-4dde-8950-199b2d5f5b05"), new Guid("90fb9bfe-da70-4392-9904-4417fab257a7"), new DateTime(2024, 7, 26, 9, 21, 21, 88, DateTimeKind.Local).AddTicks(5009), new DateTime(2024, 8, 7, 10, 58, 49, 915, DateTimeKind.Local).AddTicks(3351), 1715.16m },
                    { new Guid("32ee121d-c66f-4591-8ba4-b79ab7950a13"), new Guid("e9d684aa-183f-423f-8741-1a53cfb8f2e3"), new DateTime(2024, 4, 21, 12, 18, 56, 959, DateTimeKind.Local).AddTicks(7677), new DateTime(2024, 8, 9, 10, 45, 54, 539, DateTimeKind.Local).AddTicks(5210), 2949.95m },
                    { new Guid("33a3ebd6-a1c6-4ad4-ad7e-7d52a7f3c2d1"), new Guid("fd9917bd-45e9-4bab-839f-7f5b5cbf03e7"), new DateTime(2023, 12, 24, 13, 30, 26, 751, DateTimeKind.Local).AddTicks(4381), new DateTime(2024, 8, 8, 23, 2, 15, 584, DateTimeKind.Local).AddTicks(5657), 1521.85m },
                    { new Guid("33df948f-27d5-4cd5-8bea-64ba086e1610"), new Guid("c06db99e-509c-4391-b257-6799307a8b3c"), new DateTime(2024, 3, 10, 21, 50, 0, 613, DateTimeKind.Local).AddTicks(1040), new DateTime(2024, 8, 7, 13, 21, 2, 171, DateTimeKind.Local).AddTicks(7067), 472.70m },
                    { new Guid("33e12c95-14fc-44e8-816b-22b3a0a848fb"), new Guid("1cab312c-e326-4c44-ae00-5542888dfbc9"), new DateTime(2024, 4, 24, 2, 7, 51, 408, DateTimeKind.Local).AddTicks(9354), new DateTime(2024, 8, 9, 18, 45, 1, 615, DateTimeKind.Local).AddTicks(3381), 766.09m },
                    { new Guid("3408244b-3214-4cf2-b546-30ae8226348d"), new Guid("75fe592b-5c1e-4814-a459-627bef01098f"), new DateTime(2024, 8, 4, 14, 18, 47, 498, DateTimeKind.Local).AddTicks(5195), new DateTime(2024, 8, 7, 2, 14, 26, 171, DateTimeKind.Local).AddTicks(3869), 245.28m },
                    { new Guid("343d2ced-0e2f-41f1-a779-c09e537d9afa"), new Guid("17652753-332f-4654-89d0-bbca6d67670f"), new DateTime(2023, 8, 18, 23, 23, 18, 80, DateTimeKind.Local).AddTicks(831), new DateTime(2024, 8, 7, 3, 43, 14, 692, DateTimeKind.Local).AddTicks(3208), 1962.42m },
                    { new Guid("3463701d-0a98-43b9-b54b-8542bacbe5d0"), new Guid("952cbe13-c448-4063-910c-4a6b51e895ce"), new DateTime(2023, 9, 10, 0, 42, 9, 761, DateTimeKind.Local).AddTicks(4558), new DateTime(2024, 8, 9, 21, 18, 37, 80, DateTimeKind.Local).AddTicks(2615), 4634.50m },
                    { new Guid("349d6d82-7942-4aae-9451-5a4fdbabeda3"), new Guid("15883dbe-e97e-4859-86f7-993bbc1173df"), new DateTime(2024, 4, 20, 13, 12, 26, 608, DateTimeKind.Local).AddTicks(7816), new DateTime(2024, 8, 7, 15, 27, 55, 820, DateTimeKind.Local).AddTicks(2919), 3695.35m },
                    { new Guid("34fc8006-078d-4437-8cf7-b49b5682eacd"), new Guid("6f10d3da-6328-4453-bd18-d299e75dca49"), new DateTime(2023, 9, 11, 11, 37, 53, 473, DateTimeKind.Local).AddTicks(1749), new DateTime(2024, 8, 9, 14, 4, 5, 43, DateTimeKind.Local).AddTicks(1172), 4409.94m },
                    { new Guid("3500add5-d20e-4bea-b135-477700c573a3"), new Guid("1d71e542-620f-4161-9842-a2a145bd7013"), new DateTime(2024, 4, 27, 9, 36, 1, 88, DateTimeKind.Local).AddTicks(529), new DateTime(2024, 8, 8, 10, 57, 15, 401, DateTimeKind.Local).AddTicks(9217), 3385.20m },
                    { new Guid("352312f4-c0c0-48fb-9143-6acba97588b5"), new Guid("d84600ec-9767-4cd9-8221-62d22397acaa"), new DateTime(2023, 10, 26, 6, 37, 36, 830, DateTimeKind.Local).AddTicks(7133), new DateTime(2024, 8, 9, 9, 54, 30, 33, DateTimeKind.Local).AddTicks(3407), 3004.74m },
                    { new Guid("35670954-3216-46b5-8b1e-20e073416014"), new Guid("d5d71173-e817-45f8-9146-4b7ab7c7b686"), new DateTime(2024, 4, 21, 15, 46, 46, 236, DateTimeKind.Local).AddTicks(8380), new DateTime(2024, 8, 9, 10, 3, 31, 743, DateTimeKind.Local).AddTicks(6449), 4672.61m },
                    { new Guid("35869521-0bf7-46f5-8cfe-9ac6e8d6c1b0"), new Guid("1cab312c-e326-4c44-ae00-5542888dfbc9"), new DateTime(2024, 4, 4, 1, 40, 37, 816, DateTimeKind.Local).AddTicks(430), new DateTime(2024, 8, 8, 5, 58, 14, 466, DateTimeKind.Local).AddTicks(3647), 4322.42m },
                    { new Guid("358c7f44-9661-4045-b5cc-f4fd6fc0bf55"), new Guid("b41438f5-9380-4cd7-bc4d-59267b9b760c"), new DateTime(2024, 6, 23, 11, 3, 40, 398, DateTimeKind.Local).AddTicks(400), new DateTime(2024, 8, 7, 3, 43, 58, 925, DateTimeKind.Local).AddTicks(9327), 2358.04m },
                    { new Guid("3594f369-f75b-4feb-a871-514232a3e7f2"), new Guid("21d87d9e-43c6-46d1-bfee-644940fd9d64"), new DateTime(2023, 12, 13, 6, 52, 13, 101, DateTimeKind.Local).AddTicks(3424), new DateTime(2024, 8, 8, 17, 6, 13, 703, DateTimeKind.Local).AddTicks(7457), 1252.73m },
                    { new Guid("359ef38d-f8ff-444c-8d60-c41702220196"), new Guid("841db90c-5f81-482a-a955-f91fc637a7f7"), new DateTime(2024, 1, 13, 5, 1, 58, 329, DateTimeKind.Local).AddTicks(2359), new DateTime(2024, 8, 7, 15, 1, 58, 373, DateTimeKind.Local).AddTicks(5195), 3023.36m },
                    { new Guid("35a9c9ec-af89-4ffc-8716-b7bcfef4473a"), new Guid("88603d45-af2e-4381-b8d8-2c53ebbaccd2"), new DateTime(2023, 11, 18, 23, 54, 29, 619, DateTimeKind.Local).AddTicks(3386), new DateTime(2024, 8, 9, 3, 59, 29, 192, DateTimeKind.Local).AddTicks(9497), 4592.07m },
                    { new Guid("35bc8810-ac91-4f68-b896-d4fa297a7450"), new Guid("a2e054b5-4260-4454-a995-281c00600f11"), new DateTime(2024, 7, 19, 3, 47, 10, 652, DateTimeKind.Local).AddTicks(3239), new DateTime(2024, 8, 8, 7, 59, 2, 337, DateTimeKind.Local).AddTicks(5279), 2091.79m },
                    { new Guid("35e2a6e7-3efb-4ec3-adfd-53ed798ad337"), new Guid("45859554-61d6-4f50-90eb-b40d19a17909"), new DateTime(2024, 1, 12, 4, 58, 10, 650, DateTimeKind.Local).AddTicks(625), new DateTime(2024, 8, 9, 14, 16, 34, 656, DateTimeKind.Local).AddTicks(3047), 4046.02m },
                    { new Guid("36c9b849-6494-4acf-a8d2-15c31369d59e"), new Guid("22ebc934-105f-4b38-ab74-feae23d1ffc0"), new DateTime(2023, 11, 23, 8, 7, 23, 568, DateTimeKind.Local).AddTicks(8775), new DateTime(2024, 8, 9, 0, 37, 28, 857, DateTimeKind.Local).AddTicks(1201), 2528.80m },
                    { new Guid("36eb3c0e-e450-4a2f-ba10-012cd58387f4"), new Guid("f9a1bd2e-de1a-42b8-b894-7f7e0b5b38f1"), new DateTime(2024, 7, 21, 20, 15, 58, 252, DateTimeKind.Local).AddTicks(8531), new DateTime(2024, 8, 8, 3, 52, 5, 352, DateTimeKind.Local).AddTicks(3180), 3113.23m },
                    { new Guid("36ed8443-8b54-44dc-b04b-7708bfc26792"), new Guid("d6d20276-ac8b-44d6-9939-d642e6335c51"), new DateTime(2023, 10, 19, 1, 6, 53, 605, DateTimeKind.Local).AddTicks(4773), new DateTime(2024, 8, 8, 21, 41, 37, 20, DateTimeKind.Local).AddTicks(4369), 3128.44m }
                });

            migrationBuilder.InsertData(
                table: "DonHangs",
                columns: new[] { "Id", "KhachHangId", "NgayDatHang", "NgayGiaoHang", "TongTien" },
                values: new object[,]
                {
                    { new Guid("3793258d-0466-4f92-b131-e58d62254d50"), new Guid("b22bc921-a93c-4461-8bd3-df4b1e010bc1"), new DateTime(2024, 1, 31, 1, 52, 5, 795, DateTimeKind.Local).AddTicks(1824), new DateTime(2024, 8, 8, 1, 47, 38, 372, DateTimeKind.Local).AddTicks(6234), 426.30m },
                    { new Guid("37f76665-e6e5-44a2-8b32-484c1130fb80"), new Guid("b41438f5-9380-4cd7-bc4d-59267b9b760c"), new DateTime(2024, 2, 18, 2, 16, 21, 262, DateTimeKind.Local).AddTicks(7804), new DateTime(2024, 8, 9, 4, 44, 28, 964, DateTimeKind.Local).AddTicks(4413), 3040.77m },
                    { new Guid("383133ae-f965-4d90-a98a-c5e36d41fca1"), new Guid("232fdc99-53fe-4232-9c74-06ddfb2a13b8"), new DateTime(2023, 11, 26, 9, 0, 55, 51, DateTimeKind.Local).AddTicks(1185), new DateTime(2024, 8, 7, 11, 53, 56, 160, DateTimeKind.Local).AddTicks(63), 2849.57m },
                    { new Guid("38597a9b-72e0-478c-b743-8ae2bb81fe67"), new Guid("232fdc99-53fe-4232-9c74-06ddfb2a13b8"), new DateTime(2024, 4, 22, 9, 34, 23, 847, DateTimeKind.Local).AddTicks(1737), new DateTime(2024, 8, 6, 22, 51, 7, 807, DateTimeKind.Local).AddTicks(1128), 1598.52m },
                    { new Guid("38a29c22-dea7-4da4-a179-666d6ab2aab8"), new Guid("0667960a-b942-408f-9aa5-8591f0e0599a"), new DateTime(2024, 3, 26, 20, 4, 6, 183, DateTimeKind.Local).AddTicks(3681), new DateTime(2024, 8, 8, 20, 47, 6, 893, DateTimeKind.Local).AddTicks(8293), 2039.87m },
                    { new Guid("38c20d9c-b1b6-415c-ba4a-8508c8662639"), new Guid("697709be-b252-4405-bb7e-8673c6b98467"), new DateTime(2024, 3, 23, 10, 4, 33, 945, DateTimeKind.Local).AddTicks(1311), new DateTime(2024, 8, 7, 7, 3, 6, 681, DateTimeKind.Local).AddTicks(616), 2555.26m },
                    { new Guid("3927a994-4a6b-49a6-bb97-7fd98571fcaa"), new Guid("c93b2790-efbb-4887-bc62-908698026478"), new DateTime(2023, 11, 19, 16, 8, 13, 517, DateTimeKind.Local).AddTicks(7423), new DateTime(2024, 8, 7, 6, 14, 50, 799, DateTimeKind.Local).AddTicks(9821), 774.91m },
                    { new Guid("392edafc-e7bb-4935-9719-8ff4ce88be28"), new Guid("93fb1f32-f25c-41b4-91a2-c22a92a4ab83"), new DateTime(2023, 11, 20, 1, 44, 45, 747, DateTimeKind.Local).AddTicks(9508), new DateTime(2024, 8, 8, 15, 18, 49, 361, DateTimeKind.Local).AddTicks(9793), 4897.24m },
                    { new Guid("3931766d-d383-46bf-9d08-1b22fabe636f"), new Guid("f9a1bd2e-de1a-42b8-b894-7f7e0b5b38f1"), new DateTime(2024, 1, 26, 4, 7, 21, 977, DateTimeKind.Local).AddTicks(4631), new DateTime(2024, 8, 9, 5, 35, 34, 166, DateTimeKind.Local).AddTicks(19), 4902.38m },
                    { new Guid("399509cd-90d1-4713-b67a-3ce89599052d"), new Guid("920b6ceb-11fd-4534-8c78-0adccdc2cbf5"), new DateTime(2023, 10, 6, 5, 13, 5, 428, DateTimeKind.Local).AddTicks(9481), new DateTime(2024, 8, 9, 11, 50, 48, 183, DateTimeKind.Local).AddTicks(1758), 2215.49m },
                    { new Guid("39b76d3b-c9f1-425d-9888-a0243edf9b4d"), new Guid("590c7122-bbd8-408c-9571-b8d385d97b9e"), new DateTime(2024, 2, 15, 22, 41, 17, 567, DateTimeKind.Local).AddTicks(7195), new DateTime(2024, 8, 7, 16, 29, 48, 498, DateTimeKind.Local).AddTicks(3348), 3089.06m },
                    { new Guid("39d852d9-f69b-4205-80ba-6e27358b00ed"), new Guid("63021a65-455d-454a-92ee-525601ead4df"), new DateTime(2023, 12, 26, 7, 33, 51, 793, DateTimeKind.Local).AddTicks(9471), new DateTime(2024, 8, 7, 11, 29, 16, 213, DateTimeKind.Local).AddTicks(3587), 1618.50m },
                    { new Guid("3ab595af-8c5e-4466-aa67-3ccbf53923c0"), new Guid("7395222e-7744-4172-86d1-1b128230fabf"), new DateTime(2024, 1, 12, 9, 33, 27, 342, DateTimeKind.Local).AddTicks(4746), new DateTime(2024, 8, 7, 17, 29, 6, 294, DateTimeKind.Local).AddTicks(3543), 2321.89m },
                    { new Guid("3b448e0a-c3b3-44ac-93c2-755a275856ba"), new Guid("0b23e0d1-fa5b-4022-92b8-ff158e6d60ed"), new DateTime(2023, 11, 23, 0, 50, 22, 468, DateTimeKind.Local).AddTicks(353), new DateTime(2024, 8, 8, 5, 2, 26, 293, DateTimeKind.Local).AddTicks(6308), 3031.42m },
                    { new Guid("3b8f51f1-08a5-4f54-98a3-5db25330d9c5"), new Guid("b0074e79-8782-48c2-b497-9ae7bd24e960"), new DateTime(2024, 4, 12, 1, 12, 11, 601, DateTimeKind.Local).AddTicks(9332), new DateTime(2024, 8, 9, 10, 42, 39, 754, DateTimeKind.Local).AddTicks(6679), 606.41m },
                    { new Guid("3be73991-e0b9-4136-a610-77e1cc6aaa41"), new Guid("90fb9bfe-da70-4392-9904-4417fab257a7"), new DateTime(2024, 5, 17, 22, 4, 55, 488, DateTimeKind.Local).AddTicks(5220), new DateTime(2024, 8, 9, 11, 40, 4, 984, DateTimeKind.Local).AddTicks(1454), 1494.59m },
                    { new Guid("3bf66ced-624f-4cc5-bab6-72b667731b47"), new Guid("5ee23c83-8a7a-498c-96a6-f2bc6fdc8136"), new DateTime(2024, 5, 9, 3, 18, 34, 370, DateTimeKind.Local).AddTicks(6089), new DateTime(2024, 8, 9, 18, 36, 3, 160, DateTimeKind.Local).AddTicks(4008), 126.82m },
                    { new Guid("3d79ba65-a4e3-4a1c-9a0e-47ef215449b3"), new Guid("75fe592b-5c1e-4814-a459-627bef01098f"), new DateTime(2024, 7, 23, 17, 5, 45, 549, DateTimeKind.Local).AddTicks(1775), new DateTime(2024, 8, 7, 12, 38, 41, 43, DateTimeKind.Local).AddTicks(5240), 1528.70m },
                    { new Guid("3d7bb141-5309-4310-a3f7-29981867bba7"), new Guid("90ece793-c6f5-47e7-8aa0-7c08ff3548fb"), new DateTime(2024, 1, 28, 9, 2, 24, 315, DateTimeKind.Local).AddTicks(8534), new DateTime(2024, 8, 8, 11, 57, 7, 429, DateTimeKind.Local).AddTicks(9854), 918.17m },
                    { new Guid("3d8571c2-0d7d-4dc5-8f2b-97c6870aebe1"), new Guid("a99891d8-254d-4ec7-8cae-cf3bcb8c10a1"), new DateTime(2023, 10, 11, 10, 18, 26, 397, DateTimeKind.Local).AddTicks(6008), new DateTime(2024, 8, 8, 19, 58, 1, 255, DateTimeKind.Local).AddTicks(1305), 2628.57m },
                    { new Guid("3dbe2954-8bee-4fe6-b430-0c7a61398775"), new Guid("1248d1fb-1e80-4ded-926b-6b7f6d2249a5"), new DateTime(2024, 1, 14, 1, 50, 13, 457, DateTimeKind.Local).AddTicks(265), new DateTime(2024, 8, 7, 15, 56, 37, 23, DateTimeKind.Local).AddTicks(4746), 4362.95m },
                    { new Guid("3e9f4836-b133-43a6-8fe0-9ecf84cc4f09"), new Guid("28eaff52-a12b-4084-83b9-02a26ca7dfbc"), new DateTime(2023, 8, 9, 5, 3, 43, 452, DateTimeKind.Local).AddTicks(8074), new DateTime(2024, 8, 8, 20, 24, 53, 232, DateTimeKind.Local).AddTicks(3932), 867.84m },
                    { new Guid("3ecfc5aa-3b59-498a-bad4-b4690584302c"), new Guid("6f2bc11e-7dd7-4049-9e35-163927214820"), new DateTime(2024, 3, 30, 3, 39, 33, 563, DateTimeKind.Local).AddTicks(5312), new DateTime(2024, 8, 7, 5, 59, 49, 771, DateTimeKind.Local).AddTicks(5774), 3151.73m },
                    { new Guid("3eeae079-4ed6-44e4-a005-56d7d34d298d"), new Guid("5ee23c83-8a7a-498c-96a6-f2bc6fdc8136"), new DateTime(2023, 11, 23, 11, 23, 34, 327, DateTimeKind.Local).AddTicks(9157), new DateTime(2024, 8, 8, 5, 34, 54, 91, DateTimeKind.Local).AddTicks(8836), 3735.99m },
                    { new Guid("3f44adcc-4a62-47eb-aa28-ffcf6c6aa7c3"), new Guid("63021a65-455d-454a-92ee-525601ead4df"), new DateTime(2023, 11, 13, 6, 59, 41, 879, DateTimeKind.Local).AddTicks(6239), new DateTime(2024, 8, 8, 2, 58, 22, 882, DateTimeKind.Local).AddTicks(2771), 949.61m },
                    { new Guid("3f9c6d4c-c423-4134-b62f-3922637bc9b2"), new Guid("648119d0-d486-40c5-bd23-69a5e42b2ba5"), new DateTime(2024, 4, 13, 9, 50, 33, 109, DateTimeKind.Local).AddTicks(9207), new DateTime(2024, 8, 8, 17, 6, 47, 879, DateTimeKind.Local).AddTicks(579), 1099.80m },
                    { new Guid("3fb5e95e-8c61-41f7-8c57-a798893a0448"), new Guid("28d8da78-c6c4-4afe-9d92-22d52e3969b0"), new DateTime(2024, 6, 3, 20, 41, 52, 677, DateTimeKind.Local).AddTicks(9716), new DateTime(2024, 8, 8, 19, 37, 12, 664, DateTimeKind.Local).AddTicks(5246), 2203.83m },
                    { new Guid("4000624d-a02a-4e50-8f1d-0c3bae5df30f"), new Guid("7395222e-7744-4172-86d1-1b128230fabf"), new DateTime(2024, 7, 21, 22, 6, 31, 517, DateTimeKind.Local).AddTicks(9023), new DateTime(2024, 8, 8, 5, 16, 53, 88, DateTimeKind.Local).AddTicks(6273), 1306.51m },
                    { new Guid("40a2bf06-5906-452f-a98a-813af3df8fa4"), new Guid("5bc8e452-e383-427e-bc9b-c26642f1a642"), new DateTime(2024, 2, 22, 19, 40, 50, 982, DateTimeKind.Local).AddTicks(4070), new DateTime(2024, 8, 8, 16, 38, 44, 455, DateTimeKind.Local).AddTicks(1712), 1273.18m },
                    { new Guid("40ab4ab2-1fae-4052-bad0-8df251206d88"), new Guid("2528ff79-cf89-4261-a0de-428d26b20a72"), new DateTime(2024, 3, 28, 21, 16, 4, 87, DateTimeKind.Local).AddTicks(8562), new DateTime(2024, 8, 7, 13, 51, 14, 544, DateTimeKind.Local).AddTicks(3292), 4426.02m },
                    { new Guid("40db1a5a-a2fb-4ded-8d59-e3a3b6b2d743"), new Guid("d5d71173-e817-45f8-9146-4b7ab7c7b686"), new DateTime(2023, 12, 20, 0, 49, 16, 977, DateTimeKind.Local).AddTicks(2561), new DateTime(2024, 8, 8, 3, 15, 0, 980, DateTimeKind.Local).AddTicks(3747), 4758.03m },
                    { new Guid("4117ad5b-52aa-4f09-8843-3a55a9ba86e8"), new Guid("1cab312c-e326-4c44-ae00-5542888dfbc9"), new DateTime(2023, 8, 13, 2, 27, 24, 90, DateTimeKind.Local).AddTicks(4531), new DateTime(2024, 8, 8, 8, 10, 3, 337, DateTimeKind.Local).AddTicks(1153), 57.00m },
                    { new Guid("415f83d8-76a7-463f-a90f-e745bcd37699"), new Guid("6f2bc11e-7dd7-4049-9e35-163927214820"), new DateTime(2023, 12, 5, 10, 43, 23, 853, DateTimeKind.Local).AddTicks(2299), new DateTime(2024, 8, 7, 21, 59, 31, 44, DateTimeKind.Local).AddTicks(9173), 3684.92m },
                    { new Guid("419fe2e4-8d83-48e7-a08b-3423b0a60b86"), new Guid("1e3c140e-4cab-4065-aadd-2c1cfed5ce14"), new DateTime(2023, 11, 23, 22, 31, 26, 143, DateTimeKind.Local).AddTicks(6894), new DateTime(2024, 8, 7, 8, 29, 37, 646, DateTimeKind.Local).AddTicks(5409), 3825.79m },
                    { new Guid("420899fe-3402-495f-9d23-95077b8cff20"), new Guid("052538e6-f9b6-4bd1-98e0-6e7d6744fb4a"), new DateTime(2023, 12, 18, 23, 47, 7, 583, DateTimeKind.Local).AddTicks(5387), new DateTime(2024, 8, 8, 7, 8, 56, 881, DateTimeKind.Local).AddTicks(7662), 1588.49m },
                    { new Guid("4229b4c0-6059-499a-9f8f-dac1ad9696f4"), new Guid("28eaff52-a12b-4084-83b9-02a26ca7dfbc"), new DateTime(2024, 2, 10, 10, 43, 13, 814, DateTimeKind.Local).AddTicks(8355), new DateTime(2024, 8, 8, 23, 43, 59, 507, DateTimeKind.Local).AddTicks(5791), 3169.97m },
                    { new Guid("432dc5a7-3616-40a2-b2f9-0090f3bacbd8"), new Guid("2463d0a4-5008-43f5-97fd-bbd3d0048d8e"), new DateTime(2024, 4, 23, 2, 38, 51, 197, DateTimeKind.Local).AddTicks(9892), new DateTime(2024, 8, 8, 9, 11, 56, 172, DateTimeKind.Local).AddTicks(9739), 4877.62m },
                    { new Guid("437bb9d2-dce2-404b-95fc-6bacf2ff984b"), new Guid("9f2dcec6-cc02-45d6-95d0-fa0b53a5f953"), new DateTime(2024, 7, 9, 3, 7, 54, 602, DateTimeKind.Local).AddTicks(2238), new DateTime(2024, 8, 8, 22, 18, 24, 16, DateTimeKind.Local).AddTicks(2939), 3024.70m },
                    { new Guid("44090c18-d663-43a5-b403-6381904b8f96"), new Guid("2f5efba5-6605-4ccc-9a86-918b9bd19b8b"), new DateTime(2023, 9, 27, 18, 54, 2, 504, DateTimeKind.Local).AddTicks(7385), new DateTime(2024, 8, 9, 1, 35, 15, 461, DateTimeKind.Local).AddTicks(8379), 4167.72m },
                    { new Guid("444580cf-64cc-4809-9644-553ab7223ca3"), new Guid("5bc8e452-e383-427e-bc9b-c26642f1a642"), new DateTime(2024, 6, 1, 1, 22, 37, 743, DateTimeKind.Local).AddTicks(5010), new DateTime(2024, 8, 8, 20, 49, 2, 651, DateTimeKind.Local).AddTicks(4026), 2230.81m },
                    { new Guid("447db4b4-5490-4fbe-a326-99d1729be4a6"), new Guid("b78d1e60-56cf-4058-967c-7271f646af05"), new DateTime(2024, 7, 30, 14, 20, 20, 985, DateTimeKind.Local).AddTicks(6078), new DateTime(2024, 8, 9, 7, 36, 23, 318, DateTimeKind.Local).AddTicks(5675), 2418.87m },
                    { new Guid("44850087-3a3d-46df-b8d5-d57899c09add"), new Guid("6b4bca52-0cf9-4a9e-98cf-0eb6e3c24da0"), new DateTime(2024, 6, 25, 10, 48, 30, 325, DateTimeKind.Local).AddTicks(5606), new DateTime(2024, 8, 9, 16, 42, 12, 588, DateTimeKind.Local).AddTicks(2205), 4572.06m }
                });

            migrationBuilder.InsertData(
                table: "DonHangs",
                columns: new[] { "Id", "KhachHangId", "NgayDatHang", "NgayGiaoHang", "TongTien" },
                values: new object[,]
                {
                    { new Guid("44bd1cf8-4070-4840-9f80-0fa640089b05"), new Guid("9865321a-433a-4caa-8050-884b34c7c8d8"), new DateTime(2024, 3, 17, 17, 39, 17, 996, DateTimeKind.Local).AddTicks(8015), new DateTime(2024, 8, 7, 4, 38, 52, 342, DateTimeKind.Local).AddTicks(7824), 585.66m },
                    { new Guid("45530a63-8471-4cfe-96b9-b139e258766a"), new Guid("0b23e0d1-fa5b-4022-92b8-ff158e6d60ed"), new DateTime(2024, 1, 27, 16, 26, 31, 287, DateTimeKind.Local).AddTicks(7266), new DateTime(2024, 8, 8, 4, 26, 30, 904, DateTimeKind.Local).AddTicks(9815), 647.67m },
                    { new Guid("456c138f-40a2-4701-b760-3fc20be54b31"), new Guid("24256d4c-7032-4437-8c1e-dd211c5bd713"), new DateTime(2023, 11, 27, 17, 34, 44, 406, DateTimeKind.Local).AddTicks(2526), new DateTime(2024, 8, 9, 18, 52, 37, 961, DateTimeKind.Local).AddTicks(3704), 3842.73m },
                    { new Guid("4646966e-447a-41e6-b46f-d98bf90ba74c"), new Guid("46685f7f-ca60-41b6-8cfb-4124c89cd625"), new DateTime(2024, 3, 13, 20, 37, 23, 950, DateTimeKind.Local).AddTicks(4865), new DateTime(2024, 8, 7, 6, 16, 0, 263, DateTimeKind.Local).AddTicks(9272), 1779.23m },
                    { new Guid("464792ef-6bc1-4a49-88bf-0f755e31606d"), new Guid("c0ebc03b-08bf-4b16-89e2-4c86dec71a59"), new DateTime(2023, 12, 21, 6, 6, 18, 562, DateTimeKind.Local).AddTicks(9438), new DateTime(2024, 8, 8, 23, 28, 12, 448, DateTimeKind.Local).AddTicks(7797), 2711.83m },
                    { new Guid("467841ac-5152-4ec6-94a1-175b5e52ac4c"), new Guid("eb503b18-f1e1-4a47-8871-99a4746eb8c6"), new DateTime(2023, 9, 22, 9, 55, 41, 44, DateTimeKind.Local).AddTicks(5249), new DateTime(2024, 8, 9, 18, 19, 41, 768, DateTimeKind.Local).AddTicks(2026), 958.45m },
                    { new Guid("467f8fe7-fe72-431e-a6a3-45c325e69163"), new Guid("c06db99e-509c-4391-b257-6799307a8b3c"), new DateTime(2024, 1, 9, 9, 50, 49, 179, DateTimeKind.Local).AddTicks(7006), new DateTime(2024, 8, 7, 2, 40, 24, 492, DateTimeKind.Local).AddTicks(6670), 834.41m },
                    { new Guid("4736fac5-65a7-49ea-8911-2bb254d45add"), new Guid("b22bc921-a93c-4461-8bd3-df4b1e010bc1"), new DateTime(2023, 10, 20, 15, 33, 34, 15, DateTimeKind.Local).AddTicks(5870), new DateTime(2024, 8, 7, 5, 48, 58, 993, DateTimeKind.Local).AddTicks(634), 1940.11m },
                    { new Guid("47af4cd1-060a-4e0e-8ac9-c16a1f7d29a3"), new Guid("ec92935c-29c1-47d3-9ff2-3aed6a0974f2"), new DateTime(2023, 12, 24, 15, 34, 24, 710, DateTimeKind.Local).AddTicks(6608), new DateTime(2024, 8, 8, 13, 5, 37, 792, DateTimeKind.Local).AddTicks(3159), 3705.68m },
                    { new Guid("47da8454-ab32-49ad-a6d7-35882d9f9026"), new Guid("28eaff52-a12b-4084-83b9-02a26ca7dfbc"), new DateTime(2024, 4, 9, 16, 28, 18, 443, DateTimeKind.Local).AddTicks(5259), new DateTime(2024, 8, 8, 17, 34, 23, 13, DateTimeKind.Local).AddTicks(8205), 281.70m },
                    { new Guid("484759dc-7f33-4824-bc49-10047fdbe56c"), new Guid("7395222e-7744-4172-86d1-1b128230fabf"), new DateTime(2024, 6, 24, 6, 19, 5, 34, DateTimeKind.Local).AddTicks(9707), new DateTime(2024, 8, 7, 9, 56, 59, 239, DateTimeKind.Local).AddTicks(4501), 2386.03m },
                    { new Guid("489c76a3-2720-4b3f-bd27-91f999b38790"), new Guid("893b3fb0-9647-4958-b835-676e382779e7"), new DateTime(2024, 1, 26, 5, 20, 10, 875, DateTimeKind.Local).AddTicks(6859), new DateTime(2024, 8, 8, 19, 25, 25, 168, DateTimeKind.Local).AddTicks(5020), 3966.19m },
                    { new Guid("48a2aa52-40d6-4974-b65f-6f7664c996a5"), new Guid("46685f7f-ca60-41b6-8cfb-4124c89cd625"), new DateTime(2024, 6, 18, 23, 49, 44, 780, DateTimeKind.Local).AddTicks(778), new DateTime(2024, 8, 9, 8, 41, 22, 641, DateTimeKind.Local).AddTicks(69), 310.33m },
                    { new Guid("48e73c42-d3a1-4d80-ad63-e8ac2d79d1f8"), new Guid("2463d0a4-5008-43f5-97fd-bbd3d0048d8e"), new DateTime(2024, 2, 27, 14, 48, 13, 760, DateTimeKind.Local).AddTicks(3301), new DateTime(2024, 8, 7, 13, 55, 34, 692, DateTimeKind.Local).AddTicks(6311), 457.09m },
                    { new Guid("492a9c57-eaa3-4cff-adfa-f4d433e9ef8c"), new Guid("88603d45-af2e-4381-b8d8-2c53ebbaccd2"), new DateTime(2024, 2, 12, 7, 1, 28, 92, DateTimeKind.Local).AddTicks(2643), new DateTime(2024, 8, 7, 3, 10, 0, 691, DateTimeKind.Local).AddTicks(7765), 2605.10m },
                    { new Guid("49700d7b-1e50-419c-b3c8-f6544b3dacef"), new Guid("841db90c-5f81-482a-a955-f91fc637a7f7"), new DateTime(2024, 2, 25, 9, 34, 59, 627, DateTimeKind.Local).AddTicks(266), new DateTime(2024, 8, 9, 16, 15, 24, 196, DateTimeKind.Local).AddTicks(9415), 1295.72m },
                    { new Guid("497c21c9-0d97-47ad-ace5-ab23a47dc46a"), new Guid("893b3fb0-9647-4958-b835-676e382779e7"), new DateTime(2024, 7, 27, 7, 41, 56, 494, DateTimeKind.Local).AddTicks(8262), new DateTime(2024, 8, 9, 14, 52, 9, 175, DateTimeKind.Local).AddTicks(3764), 168.11m },
                    { new Guid("49b3687f-a834-442b-865c-6c174e5abda8"), new Guid("f0f1e5c8-88d3-4268-9c48-f6a85560db57"), new DateTime(2023, 9, 28, 15, 51, 48, 195, DateTimeKind.Local).AddTicks(7318), new DateTime(2024, 8, 8, 13, 8, 5, 846, DateTimeKind.Local).AddTicks(4157), 3887.10m },
                    { new Guid("4a23925a-bdb9-48f8-a460-d9f7257f61b3"), new Guid("e56e8c86-41ee-47fd-9d05-a94a167bed10"), new DateTime(2023, 10, 31, 18, 17, 50, 89, DateTimeKind.Local).AddTicks(2807), new DateTime(2024, 8, 9, 16, 14, 7, 672, DateTimeKind.Local).AddTicks(4771), 3399.30m },
                    { new Guid("4a485ace-cee0-465c-a053-fe72466b6f86"), new Guid("24256d4c-7032-4437-8c1e-dd211c5bd713"), new DateTime(2024, 4, 15, 18, 50, 25, 743, DateTimeKind.Local).AddTicks(4314), new DateTime(2024, 8, 7, 20, 19, 51, 617, DateTimeKind.Local).AddTicks(268), 4506.94m },
                    { new Guid("4a8f595e-c752-4668-858a-ec80cd7292fc"), new Guid("90ece793-c6f5-47e7-8aa0-7c08ff3548fb"), new DateTime(2024, 2, 24, 9, 58, 28, 828, DateTimeKind.Local).AddTicks(4275), new DateTime(2024, 8, 9, 5, 38, 54, 272, DateTimeKind.Local).AddTicks(6243), 1539.10m },
                    { new Guid("4a921c92-aaab-41e1-8ed0-be8fcd9cfcca"), new Guid("45859554-61d6-4f50-90eb-b40d19a17909"), new DateTime(2024, 3, 30, 5, 49, 31, 141, DateTimeKind.Local).AddTicks(9747), new DateTime(2024, 8, 8, 11, 45, 26, 727, DateTimeKind.Local).AddTicks(3946), 3379.35m },
                    { new Guid("4b000b8b-a6e7-4bf9-bde8-d38ad89e1f83"), new Guid("d6d20276-ac8b-44d6-9939-d642e6335c51"), new DateTime(2024, 8, 3, 15, 24, 30, 555, DateTimeKind.Local).AddTicks(8429), new DateTime(2024, 8, 8, 1, 9, 58, 872, DateTimeKind.Local).AddTicks(1997), 1186.15m },
                    { new Guid("4b9153a4-61ad-410c-b409-178a2b399cde"), new Guid("b4a06e76-1c1e-4cac-aaa1-572d7a607954"), new DateTime(2024, 1, 8, 1, 43, 57, 896, DateTimeKind.Local).AddTicks(8905), new DateTime(2024, 8, 9, 6, 28, 20, 941, DateTimeKind.Local).AddTicks(2870), 3979.57m },
                    { new Guid("4c2ad205-3a8f-41ef-963d-2c67ac2cfa29"), new Guid("873734f8-2118-4bff-95ec-9e199770cefb"), new DateTime(2023, 11, 12, 15, 40, 42, 219, DateTimeKind.Local).AddTicks(1011), new DateTime(2024, 8, 9, 11, 46, 17, 797, DateTimeKind.Local).AddTicks(8789), 2313.61m },
                    { new Guid("4c5702f4-6dd3-421e-82fd-e56e58caced0"), new Guid("886111c9-af92-447f-91bf-dad7b8a03eb5"), new DateTime(2023, 12, 25, 14, 21, 44, 345, DateTimeKind.Local).AddTicks(578), new DateTime(2024, 8, 8, 23, 20, 9, 953, DateTimeKind.Local).AddTicks(7832), 3278.46m },
                    { new Guid("4d948abd-95b6-43e0-9ca6-8ff7f5330596"), new Guid("90fb9bfe-da70-4392-9904-4417fab257a7"), new DateTime(2023, 9, 21, 18, 30, 2, 567, DateTimeKind.Local).AddTicks(7972), new DateTime(2024, 8, 9, 19, 18, 40, 444, DateTimeKind.Local).AddTicks(8609), 152.42m },
                    { new Guid("4da39e1f-3b73-4fcf-bc97-31d28953d246"), new Guid("9f2dcec6-cc02-45d6-95d0-fa0b53a5f953"), new DateTime(2023, 8, 14, 1, 55, 9, 589, DateTimeKind.Local).AddTicks(3702), new DateTime(2024, 8, 7, 19, 52, 0, 133, DateTimeKind.Local).AddTicks(9434), 126.01m },
                    { new Guid("4da7b70b-645b-4734-88fb-d2f6085ecf1c"), new Guid("17544f0d-9e01-4955-b49a-dcc4b6a770ee"), new DateTime(2024, 7, 27, 21, 18, 30, 294, DateTimeKind.Local).AddTicks(261), new DateTime(2024, 8, 7, 4, 18, 25, 47, DateTimeKind.Local).AddTicks(405), 4468.76m },
                    { new Guid("4df5432e-2219-4df4-8307-7cec2ed9e2c6"), new Guid("c06db99e-509c-4391-b257-6799307a8b3c"), new DateTime(2024, 5, 19, 11, 18, 15, 74, DateTimeKind.Local).AddTicks(7211), new DateTime(2024, 8, 9, 12, 12, 15, 145, DateTimeKind.Local).AddTicks(9244), 160.86m },
                    { new Guid("4e07c5b1-b317-4bb9-af31-4dbd4801a594"), new Guid("46685f7f-ca60-41b6-8cfb-4124c89cd625"), new DateTime(2024, 1, 2, 6, 31, 26, 580, DateTimeKind.Local).AddTicks(1548), new DateTime(2024, 8, 9, 20, 2, 4, 337, DateTimeKind.Local).AddTicks(5998), 1197.56m },
                    { new Guid("4e60266e-5b8f-421f-be60-27159841a9dd"), new Guid("6d1e80c0-f438-45cd-a63c-9bf2330160b6"), new DateTime(2024, 6, 12, 15, 15, 47, 363, DateTimeKind.Local).AddTicks(8919), new DateTime(2024, 8, 8, 4, 6, 21, 484, DateTimeKind.Local).AddTicks(2545), 3649.87m },
                    { new Guid("4e87e8ea-099b-46b3-a58b-f982110e8156"), new Guid("33caf896-8425-48e6-86b5-a47f32bb1850"), new DateTime(2023, 9, 15, 22, 37, 28, 533, DateTimeKind.Local).AddTicks(3350), new DateTime(2024, 8, 8, 5, 50, 7, 604, DateTimeKind.Local).AddTicks(5955), 3232.64m },
                    { new Guid("4ec9c4c7-d483-4afd-9676-c22649011427"), new Guid("88888a0c-f1ed-4613-9646-ee6509dc5db0"), new DateTime(2024, 2, 15, 15, 36, 40, 998, DateTimeKind.Local).AddTicks(2357), new DateTime(2024, 8, 9, 13, 57, 51, 251, DateTimeKind.Local).AddTicks(7115), 4367.28m },
                    { new Guid("4f10ee16-3898-4d55-8444-dfe1fa4bb332"), new Guid("f4a61b17-322c-4071-bb9d-c0378e5c9669"), new DateTime(2024, 5, 23, 1, 19, 35, 555, DateTimeKind.Local).AddTicks(9896), new DateTime(2024, 8, 9, 9, 31, 2, 311, DateTimeKind.Local).AddTicks(7961), 3540.93m },
                    { new Guid("4f284967-8917-4914-8168-1e39b84b0b06"), new Guid("fd9917bd-45e9-4bab-839f-7f5b5cbf03e7"), new DateTime(2024, 7, 30, 2, 11, 7, 874, DateTimeKind.Local).AddTicks(1727), new DateTime(2024, 8, 8, 10, 37, 53, 516, DateTimeKind.Local).AddTicks(5191), 1472.78m },
                    { new Guid("4f8b4e0d-0ea4-4f3c-8e04-557394e395d9"), new Guid("7b94208a-340f-4ed0-ad44-07a96fbc7d7a"), new DateTime(2024, 2, 20, 13, 50, 45, 966, DateTimeKind.Local).AddTicks(2576), new DateTime(2024, 8, 7, 14, 41, 13, 455, DateTimeKind.Local).AddTicks(8852), 3468.56m },
                    { new Guid("4ffeaeef-ddfd-4d42-a987-df0656728519"), new Guid("1e3c140e-4cab-4065-aadd-2c1cfed5ce14"), new DateTime(2024, 6, 9, 13, 32, 15, 543, DateTimeKind.Local).AddTicks(737), new DateTime(2024, 8, 7, 23, 55, 24, 403, DateTimeKind.Local).AddTicks(6852), 190.05m },
                    { new Guid("5039460d-c8ca-498d-a549-5729fad746b0"), new Guid("697709be-b252-4405-bb7e-8673c6b98467"), new DateTime(2023, 11, 17, 1, 50, 45, 367, DateTimeKind.Local).AddTicks(2275), new DateTime(2024, 8, 8, 1, 45, 7, 400, DateTimeKind.Local).AddTicks(6044), 2971.59m },
                    { new Guid("515ccaa9-53ee-4a65-acbb-e7b5c0db6252"), new Guid("21d87d9e-43c6-46d1-bfee-644940fd9d64"), new DateTime(2023, 11, 30, 19, 33, 0, 568, DateTimeKind.Local).AddTicks(4127), new DateTime(2024, 8, 7, 5, 52, 34, 675, DateTimeKind.Local).AddTicks(1122), 2078.28m },
                    { new Guid("5168b8fe-7e79-493c-8535-0e69b79d1a12"), new Guid("a2e054b5-4260-4454-a995-281c00600f11"), new DateTime(2024, 6, 29, 13, 52, 28, 760, DateTimeKind.Local).AddTicks(3003), new DateTime(2024, 8, 9, 16, 2, 24, 912, DateTimeKind.Local).AddTicks(8775), 395.41m },
                    { new Guid("51b201b0-c8df-458e-88b6-b949f7d6c63d"), new Guid("d84600ec-9767-4cd9-8221-62d22397acaa"), new DateTime(2024, 1, 2, 9, 35, 5, 163, DateTimeKind.Local).AddTicks(3029), new DateTime(2024, 8, 7, 19, 42, 43, 157, DateTimeKind.Local).AddTicks(689), 2286.01m }
                });

            migrationBuilder.InsertData(
                table: "DonHangs",
                columns: new[] { "Id", "KhachHangId", "NgayDatHang", "NgayGiaoHang", "TongTien" },
                values: new object[,]
                {
                    { new Guid("51b9b9ab-b11e-4bd8-9ae9-ca756aa9514e"), new Guid("841db90c-5f81-482a-a955-f91fc637a7f7"), new DateTime(2024, 1, 8, 10, 44, 4, 75, DateTimeKind.Local).AddTicks(2121), new DateTime(2024, 8, 9, 2, 15, 1, 291, DateTimeKind.Local).AddTicks(9827), 4898.24m },
                    { new Guid("521b1794-9430-452c-970c-881fc5fc377f"), new Guid("e56e8c86-41ee-47fd-9d05-a94a167bed10"), new DateTime(2023, 10, 3, 8, 24, 52, 719, DateTimeKind.Local).AddTicks(8568), new DateTime(2024, 8, 7, 5, 15, 26, 528, DateTimeKind.Local).AddTicks(5797), 190.54m },
                    { new Guid("5240d84e-773f-45bc-ae95-483639fe3c06"), new Guid("d5d71173-e817-45f8-9146-4b7ab7c7b686"), new DateTime(2024, 2, 24, 15, 26, 38, 109, DateTimeKind.Local).AddTicks(7377), new DateTime(2024, 8, 9, 4, 30, 29, 266, DateTimeKind.Local).AddTicks(9401), 3840.10m },
                    { new Guid("524309ef-9f00-44ad-86ad-38cb52c5dc06"), new Guid("15883dbe-e97e-4859-86f7-993bbc1173df"), new DateTime(2024, 6, 2, 9, 11, 7, 489, DateTimeKind.Local).AddTicks(6371), new DateTime(2024, 8, 9, 20, 38, 21, 545, DateTimeKind.Local).AddTicks(7962), 1114.43m },
                    { new Guid("528a907c-0d40-4e93-b494-f1be3595ff9c"), new Guid("9865321a-433a-4caa-8050-884b34c7c8d8"), new DateTime(2024, 3, 15, 22, 49, 24, 805, DateTimeKind.Local).AddTicks(9439), new DateTime(2024, 8, 9, 3, 16, 23, 986, DateTimeKind.Local).AddTicks(7183), 811.41m },
                    { new Guid("52f64b65-83f7-4614-9270-46dba95dfdcc"), new Guid("0bd930d6-b736-4558-87c1-50bd97e08db0"), new DateTime(2024, 1, 29, 23, 38, 16, 287, DateTimeKind.Local).AddTicks(1439), new DateTime(2024, 8, 7, 3, 33, 42, 334, DateTimeKind.Local).AddTicks(7785), 4294.59m },
                    { new Guid("5332280d-03ab-4975-b430-df4cd0370eef"), new Guid("28d8da78-c6c4-4afe-9d92-22d52e3969b0"), new DateTime(2023, 8, 12, 22, 48, 56, 464, DateTimeKind.Local).AddTicks(8684), new DateTime(2024, 8, 7, 23, 47, 9, 385, DateTimeKind.Local).AddTicks(4744), 84.16m },
                    { new Guid("5393445f-63f9-419f-97ad-76143bafab34"), new Guid("2528ff79-cf89-4261-a0de-428d26b20a72"), new DateTime(2023, 12, 6, 23, 12, 41, 798, DateTimeKind.Local).AddTicks(8497), new DateTime(2024, 8, 7, 5, 22, 32, 976, DateTimeKind.Local).AddTicks(8255), 595.99m },
                    { new Guid("5399f909-1a43-435d-af0c-a34bec6b274e"), new Guid("88888a0c-f1ed-4613-9646-ee6509dc5db0"), new DateTime(2024, 5, 23, 3, 5, 30, 242, DateTimeKind.Local).AddTicks(9768), new DateTime(2024, 8, 7, 20, 48, 3, 604, DateTimeKind.Local).AddTicks(3794), 4833.88m },
                    { new Guid("53d4d3ec-a87d-4796-9462-a087750b8626"), new Guid("a51f9433-2477-4445-8a69-d24c50d95afb"), new DateTime(2024, 2, 7, 1, 0, 6, 693, DateTimeKind.Local).AddTicks(2300), new DateTime(2024, 8, 8, 17, 36, 5, 81, DateTimeKind.Local).AddTicks(2639), 4434.25m },
                    { new Guid("53e3075e-952c-439a-ab68-310f461a3fac"), new Guid("952cbe13-c448-4063-910c-4a6b51e895ce"), new DateTime(2023, 10, 22, 10, 0, 49, 541, DateTimeKind.Local).AddTicks(2408), new DateTime(2024, 8, 8, 20, 17, 17, 825, DateTimeKind.Local).AddTicks(450), 241.52m },
                    { new Guid("542b6e41-5180-4000-b330-64a6cecb3e09"), new Guid("3cd8e5f4-df7e-4a22-84a3-04966bad5197"), new DateTime(2024, 5, 18, 12, 42, 12, 825, DateTimeKind.Local).AddTicks(255), new DateTime(2024, 8, 8, 5, 5, 44, 120, DateTimeKind.Local).AddTicks(1543), 4981.16m },
                    { new Guid("54325183-9e26-4be2-bf7c-1aa5f296991e"), new Guid("1248d1fb-1e80-4ded-926b-6b7f6d2249a5"), new DateTime(2024, 7, 11, 10, 11, 30, 185, DateTimeKind.Local).AddTicks(1813), new DateTime(2024, 8, 7, 7, 48, 7, 232, DateTimeKind.Local).AddTicks(556), 66.84m },
                    { new Guid("543b7b2e-bc65-4bd3-98fa-cb1236b6040e"), new Guid("b41438f5-9380-4cd7-bc4d-59267b9b760c"), new DateTime(2023, 9, 28, 16, 2, 39, 875, DateTimeKind.Local).AddTicks(1453), new DateTime(2024, 8, 9, 21, 8, 14, 264, DateTimeKind.Local).AddTicks(7157), 2534.85m },
                    { new Guid("545d636d-81f9-41d0-8854-9426b979a6cd"), new Guid("6d1e80c0-f438-45cd-a63c-9bf2330160b6"), new DateTime(2024, 1, 1, 7, 0, 54, 970, DateTimeKind.Local).AddTicks(1861), new DateTime(2024, 8, 7, 10, 51, 3, 132, DateTimeKind.Local).AddTicks(422), 4473.62m },
                    { new Guid("54d4107d-7cbc-4ced-bf13-fc8eb5445a32"), new Guid("6f2bc11e-7dd7-4049-9e35-163927214820"), new DateTime(2024, 1, 14, 14, 14, 22, 896, DateTimeKind.Local).AddTicks(453), new DateTime(2024, 8, 9, 14, 50, 28, 18, DateTimeKind.Local).AddTicks(4879), 1387.53m },
                    { new Guid("552d710a-8bb5-4c91-acc4-cca64762b176"), new Guid("fd9917bd-45e9-4bab-839f-7f5b5cbf03e7"), new DateTime(2023, 10, 21, 22, 51, 55, 809, DateTimeKind.Local).AddTicks(1397), new DateTime(2024, 8, 6, 23, 19, 43, 24, DateTimeKind.Local).AddTicks(8033), 3712.30m },
                    { new Guid("554d6274-8305-47d5-8f3d-4167144f5581"), new Guid("38ba8024-3b8d-4dd6-92b9-9d06da12ec6e"), new DateTime(2024, 4, 1, 11, 5, 20, 394, DateTimeKind.Local).AddTicks(6810), new DateTime(2024, 8, 9, 20, 53, 42, 508, DateTimeKind.Local).AddTicks(9631), 978.12m },
                    { new Guid("55902a51-891a-44ee-a783-2df120c0d490"), new Guid("6d1e80c0-f438-45cd-a63c-9bf2330160b6"), new DateTime(2024, 4, 13, 14, 2, 21, 710, DateTimeKind.Local).AddTicks(2631), new DateTime(2024, 8, 7, 9, 24, 38, 982, DateTimeKind.Local).AddTicks(4388), 198.66m },
                    { new Guid("56337bac-5bb5-4a2e-9280-9718d83b805b"), new Guid("3cd8e5f4-df7e-4a22-84a3-04966bad5197"), new DateTime(2024, 5, 27, 5, 23, 26, 8, DateTimeKind.Local).AddTicks(8923), new DateTime(2024, 8, 7, 0, 53, 22, 477, DateTimeKind.Local).AddTicks(5503), 1311.38m },
                    { new Guid("56d0f9f2-d4b6-405c-8128-32946710c723"), new Guid("63021a65-455d-454a-92ee-525601ead4df"), new DateTime(2023, 11, 24, 16, 29, 56, 362, DateTimeKind.Local).AddTicks(1032), new DateTime(2024, 8, 8, 19, 39, 48, 633, DateTimeKind.Local).AddTicks(7830), 2418.17m },
                    { new Guid("57125d69-5760-4f2b-8e68-4949bfc337af"), new Guid("6fdebd38-1ce1-416f-af92-047978b186a5"), new DateTime(2024, 3, 14, 5, 49, 27, 374, DateTimeKind.Local).AddTicks(1093), new DateTime(2024, 8, 8, 23, 42, 3, 310, DateTimeKind.Local).AddTicks(5575), 3937.28m },
                    { new Guid("57e2d976-8c82-41e2-997f-e3503169762c"), new Guid("99eb34d9-432d-450c-9c9f-1f90d43caf39"), new DateTime(2023, 11, 11, 0, 49, 37, 728, DateTimeKind.Local).AddTicks(9177), new DateTime(2024, 8, 8, 22, 47, 26, 264, DateTimeKind.Local).AddTicks(2594), 1537.55m },
                    { new Guid("583c961a-9c1c-4979-a9d5-0525a18a2446"), new Guid("9865321a-433a-4caa-8050-884b34c7c8d8"), new DateTime(2024, 7, 29, 8, 55, 0, 10, DateTimeKind.Local).AddTicks(5619), new DateTime(2024, 8, 9, 15, 21, 25, 320, DateTimeKind.Local).AddTicks(1943), 3331.44m },
                    { new Guid("58810824-1757-43f0-b216-d5a70322a124"), new Guid("6e20d02e-a4a6-4614-83ac-f23bb4548158"), new DateTime(2024, 1, 16, 6, 10, 20, 733, DateTimeKind.Local).AddTicks(78), new DateTime(2024, 8, 8, 5, 4, 6, 748, DateTimeKind.Local).AddTicks(6743), 359.07m },
                    { new Guid("58d2a1d5-b01a-4c38-a786-ffa8d6d06c20"), new Guid("6f10d3da-6328-4453-bd18-d299e75dca49"), new DateTime(2024, 2, 29, 17, 40, 48, 409, DateTimeKind.Local).AddTicks(8017), new DateTime(2024, 8, 9, 8, 31, 15, 83, DateTimeKind.Local).AddTicks(2969), 4949.88m },
                    { new Guid("58e60202-9846-4a64-9e6d-95e8aa3645dd"), new Guid("d15c8331-36ed-417a-b1fa-5f377c4c9930"), new DateTime(2024, 3, 11, 10, 20, 58, 971, DateTimeKind.Local).AddTicks(548), new DateTime(2024, 8, 8, 22, 46, 22, 951, DateTimeKind.Local).AddTicks(7894), 2513.98m },
                    { new Guid("59607d22-96ca-402a-85b1-b388f8d75526"), new Guid("90fb9bfe-da70-4392-9904-4417fab257a7"), new DateTime(2023, 9, 25, 1, 13, 46, 389, DateTimeKind.Local).AddTicks(7170), new DateTime(2024, 8, 8, 2, 57, 47, 370, DateTimeKind.Local).AddTicks(7342), 2578.44m },
                    { new Guid("5983039f-5b89-490f-bc6b-c0e89ad70898"), new Guid("b41438f5-9380-4cd7-bc4d-59267b9b760c"), new DateTime(2024, 6, 11, 12, 35, 6, 81, DateTimeKind.Local).AddTicks(1179), new DateTime(2024, 8, 7, 1, 12, 13, 860, DateTimeKind.Local).AddTicks(3218), 553.58m },
                    { new Guid("59c24d7f-26df-47cd-aaa8-f0bf5b243b1d"), new Guid("38ba8024-3b8d-4dd6-92b9-9d06da12ec6e"), new DateTime(2024, 3, 17, 5, 40, 6, 892, DateTimeKind.Local).AddTicks(2526), new DateTime(2024, 8, 8, 10, 50, 41, 275, DateTimeKind.Local).AddTicks(4609), 2426.93m },
                    { new Guid("59dd3fc6-82c3-4233-8d48-a5afdb6719b0"), new Guid("f4a61b17-322c-4071-bb9d-c0378e5c9669"), new DateTime(2024, 4, 12, 3, 19, 17, 107, DateTimeKind.Local).AddTicks(7084), new DateTime(2024, 8, 8, 5, 2, 38, 399, DateTimeKind.Local).AddTicks(2860), 4396.92m },
                    { new Guid("5a13dfc0-a797-4918-82a7-78d3a90ddd4d"), new Guid("6fdebd38-1ce1-416f-af92-047978b186a5"), new DateTime(2024, 2, 7, 15, 56, 23, 774, DateTimeKind.Local).AddTicks(2609), new DateTime(2024, 8, 8, 16, 28, 56, 581, DateTimeKind.Local).AddTicks(4386), 257.81m },
                    { new Guid("5aae2369-deae-441f-befa-73f0046f519f"), new Guid("88888a0c-f1ed-4613-9646-ee6509dc5db0"), new DateTime(2024, 4, 15, 17, 49, 22, 996, DateTimeKind.Local).AddTicks(4572), new DateTime(2024, 8, 9, 14, 12, 55, 530, DateTimeKind.Local).AddTicks(5507), 1644.02m },
                    { new Guid("5b325d17-9a24-4be8-b5e7-3557bae32429"), new Guid("17544f0d-9e01-4955-b49a-dcc4b6a770ee"), new DateTime(2024, 3, 22, 21, 4, 43, 203, DateTimeKind.Local).AddTicks(3896), new DateTime(2024, 8, 8, 17, 17, 48, 573, DateTimeKind.Local).AddTicks(1491), 1309.66m },
                    { new Guid("5b4bc578-8b41-44f1-ba85-a0e479ff7260"), new Guid("d84600ec-9767-4cd9-8221-62d22397acaa"), new DateTime(2023, 10, 5, 17, 8, 8, 153, DateTimeKind.Local).AddTicks(1561), new DateTime(2024, 8, 7, 12, 54, 10, 893, DateTimeKind.Local).AddTicks(983), 1298.35m },
                    { new Guid("5c12d635-6640-4fef-8226-7bf3a4a9fb90"), new Guid("3cd8e5f4-df7e-4a22-84a3-04966bad5197"), new DateTime(2023, 8, 21, 16, 15, 5, 375, DateTimeKind.Local).AddTicks(8853), new DateTime(2024, 8, 8, 12, 3, 29, 753, DateTimeKind.Local).AddTicks(6144), 2715.20m },
                    { new Guid("5c437cf7-0013-4ba5-a93f-647c7ad79893"), new Guid("8bc08888-8550-4e72-9b5e-71845b5b9567"), new DateTime(2023, 8, 27, 8, 25, 50, 15, DateTimeKind.Local).AddTicks(7948), new DateTime(2024, 8, 8, 23, 12, 24, 265, DateTimeKind.Local).AddTicks(3275), 4174.05m },
                    { new Guid("5c7854b4-bb3f-49f9-8c45-3ce75c9ff41d"), new Guid("d5d71173-e817-45f8-9146-4b7ab7c7b686"), new DateTime(2023, 8, 12, 4, 42, 2, 974, DateTimeKind.Local).AddTicks(8490), new DateTime(2024, 8, 7, 2, 37, 16, 72, DateTimeKind.Local).AddTicks(8708), 781.36m },
                    { new Guid("5c978d70-1d78-49a0-887b-e405876c5465"), new Guid("9e65dc79-3d73-4629-8551-a5f2b9cfe2a4"), new DateTime(2024, 1, 30, 15, 16, 0, 970, DateTimeKind.Local).AddTicks(5360), new DateTime(2024, 8, 7, 10, 9, 57, 847, DateTimeKind.Local).AddTicks(2845), 3337.92m },
                    { new Guid("5ca18d04-195a-436c-9ab8-16d8c4be39a6"), new Guid("952cbe13-c448-4063-910c-4a6b51e895ce"), new DateTime(2023, 11, 17, 21, 45, 47, 484, DateTimeKind.Local).AddTicks(7831), new DateTime(2024, 8, 7, 4, 34, 13, 955, DateTimeKind.Local).AddTicks(6699), 254.46m },
                    { new Guid("5ca8740e-7176-45b9-aca0-88a39ea0b6e5"), new Guid("88888a0c-f1ed-4613-9646-ee6509dc5db0"), new DateTime(2024, 6, 23, 19, 32, 15, 62, DateTimeKind.Local).AddTicks(6806), new DateTime(2024, 8, 9, 17, 37, 44, 940, DateTimeKind.Local).AddTicks(4730), 1451.44m },
                    { new Guid("5ccbcc3b-99e4-4349-b5bd-a4a3ff9a8a46"), new Guid("90ece793-c6f5-47e7-8aa0-7c08ff3548fb"), new DateTime(2024, 3, 18, 0, 32, 7, 559, DateTimeKind.Local).AddTicks(8431), new DateTime(2024, 8, 9, 19, 10, 14, 221, DateTimeKind.Local).AddTicks(1469), 2293.71m }
                });

            migrationBuilder.InsertData(
                table: "DonHangs",
                columns: new[] { "Id", "KhachHangId", "NgayDatHang", "NgayGiaoHang", "TongTien" },
                values: new object[,]
                {
                    { new Guid("5d259862-47dc-4648-9fde-a9182158679d"), new Guid("5bc8e452-e383-427e-bc9b-c26642f1a642"), new DateTime(2023, 10, 16, 0, 35, 16, 118, DateTimeKind.Local).AddTicks(1580), new DateTime(2024, 8, 9, 13, 43, 40, 516, DateTimeKind.Local).AddTicks(6658), 2077.56m },
                    { new Guid("5d293bec-e6d3-4d1b-8f81-afd4fc61f455"), new Guid("648119d0-d486-40c5-bd23-69a5e42b2ba5"), new DateTime(2024, 2, 21, 3, 50, 19, 802, DateTimeKind.Local).AddTicks(6700), new DateTime(2024, 8, 9, 1, 55, 27, 523, DateTimeKind.Local).AddTicks(4643), 2246.68m },
                    { new Guid("5d297c67-b345-45e2-9222-850c7197cfa4"), new Guid("d5d71173-e817-45f8-9146-4b7ab7c7b686"), new DateTime(2023, 9, 21, 6, 24, 14, 874, DateTimeKind.Local).AddTicks(2300), new DateTime(2024, 8, 7, 7, 2, 10, 47, DateTimeKind.Local).AddTicks(6642), 2635.47m },
                    { new Guid("5d2ea5f9-146e-4df9-a0db-5eb1b19429c6"), new Guid("6fdebd38-1ce1-416f-af92-047978b186a5"), new DateTime(2024, 7, 6, 7, 0, 8, 789, DateTimeKind.Local).AddTicks(3942), new DateTime(2024, 8, 8, 12, 0, 3, 120, DateTimeKind.Local).AddTicks(8360), 275.71m },
                    { new Guid("5d4a92e2-0464-4236-ab5b-e3fc0ecb0775"), new Guid("5e4be06c-1976-4755-aeb0-28dae4b4298b"), new DateTime(2023, 9, 11, 19, 50, 8, 216, DateTimeKind.Local).AddTicks(5006), new DateTime(2024, 8, 7, 6, 46, 42, 104, DateTimeKind.Local).AddTicks(734), 2324.39m },
                    { new Guid("5d573888-5986-4c8a-afd6-1323946c5e97"), new Guid("873734f8-2118-4bff-95ec-9e199770cefb"), new DateTime(2024, 6, 17, 8, 29, 10, 340, DateTimeKind.Local).AddTicks(8823), new DateTime(2024, 8, 9, 9, 14, 7, 299, DateTimeKind.Local).AddTicks(1204), 3696.02m },
                    { new Guid("5d5fc24c-1dbe-4d58-a126-8bf397344b5a"), new Guid("22ebc934-105f-4b38-ab74-feae23d1ffc0"), new DateTime(2023, 10, 6, 1, 2, 56, 353, DateTimeKind.Local).AddTicks(3998), new DateTime(2024, 8, 9, 5, 17, 15, 399, DateTimeKind.Local).AddTicks(7963), 4096.14m },
                    { new Guid("5d706aa0-2a61-4922-a4da-3b1441a95b81"), new Guid("232fdc99-53fe-4232-9c74-06ddfb2a13b8"), new DateTime(2024, 3, 15, 1, 47, 51, 380, DateTimeKind.Local).AddTicks(5709), new DateTime(2024, 8, 9, 11, 19, 2, 376, DateTimeKind.Local).AddTicks(4839), 3682.18m },
                    { new Guid("5dd1b5ad-1ecc-4b15-adfb-d504cedbc1f2"), new Guid("920b6ceb-11fd-4534-8c78-0adccdc2cbf5"), new DateTime(2023, 8, 19, 2, 55, 41, 663, DateTimeKind.Local).AddTicks(5694), new DateTime(2024, 8, 7, 5, 27, 54, 399, DateTimeKind.Local).AddTicks(1168), 988.91m },
                    { new Guid("5dfccb5d-1460-4f0e-bf52-7df2786f35db"), new Guid("3fd74fb4-2450-440d-8497-d9a630f57199"), new DateTime(2023, 9, 26, 5, 17, 7, 630, DateTimeKind.Local).AddTicks(3320), new DateTime(2024, 8, 8, 11, 54, 32, 355, DateTimeKind.Local).AddTicks(5790), 1404.45m },
                    { new Guid("5e4f9333-8737-4a31-bf90-24130196f491"), new Guid("2db3541e-b13b-4e4b-b634-f31e8982b5e1"), new DateTime(2024, 4, 13, 21, 38, 45, 440, DateTimeKind.Local).AddTicks(4881), new DateTime(2024, 8, 9, 1, 4, 39, 617, DateTimeKind.Local).AddTicks(2246), 2251.89m },
                    { new Guid("5e58750f-34c7-4059-a095-128df3366100"), new Guid("6b4bca52-0cf9-4a9e-98cf-0eb6e3c24da0"), new DateTime(2023, 11, 28, 4, 55, 47, 927, DateTimeKind.Local).AddTicks(2811), new DateTime(2024, 8, 8, 7, 58, 15, 535, DateTimeKind.Local).AddTicks(5330), 4981.76m },
                    { new Guid("5e66b080-c259-49db-93fa-1b3c22d806db"), new Guid("9865321a-433a-4caa-8050-884b34c7c8d8"), new DateTime(2023, 8, 29, 1, 36, 46, 416, DateTimeKind.Local).AddTicks(4576), new DateTime(2024, 8, 8, 9, 31, 51, 404, DateTimeKind.Local).AddTicks(9518), 4173.67m },
                    { new Guid("5f1d178e-edf1-4e34-a2d9-6d18bfb47df1"), new Guid("5bc8e452-e383-427e-bc9b-c26642f1a642"), new DateTime(2023, 11, 29, 13, 46, 26, 231, DateTimeKind.Local).AddTicks(3614), new DateTime(2024, 8, 9, 9, 0, 42, 370, DateTimeKind.Local).AddTicks(3250), 1759.98m },
                    { new Guid("5f655e82-4b00-4275-ab13-aa9b3c2443db"), new Guid("a2e054b5-4260-4454-a995-281c00600f11"), new DateTime(2024, 2, 29, 12, 32, 45, 202, DateTimeKind.Local).AddTicks(8994), new DateTime(2024, 8, 7, 5, 19, 13, 952, DateTimeKind.Local).AddTicks(8516), 2469.99m },
                    { new Guid("5fc94f23-4901-4d3f-8fcf-a5f089949019"), new Guid("44514479-669b-45b2-8af4-510b0786de9b"), new DateTime(2023, 8, 19, 4, 52, 33, 653, DateTimeKind.Local).AddTicks(8094), new DateTime(2024, 8, 8, 0, 26, 29, 369, DateTimeKind.Local).AddTicks(7437), 2089.45m },
                    { new Guid("5ffc8ee3-aa9b-44f5-8f3c-42488f671574"), new Guid("8bc08888-8550-4e72-9b5e-71845b5b9567"), new DateTime(2024, 1, 2, 1, 33, 52, 712, DateTimeKind.Local).AddTicks(5617), new DateTime(2024, 8, 7, 3, 56, 6, 303, DateTimeKind.Local).AddTicks(4930), 4243.41m },
                    { new Guid("607aa8af-a0cc-4f96-98ab-bcecf3927d12"), new Guid("d6d20276-ac8b-44d6-9939-d642e6335c51"), new DateTime(2024, 6, 15, 2, 24, 38, 611, DateTimeKind.Local).AddTicks(2183), new DateTime(2024, 8, 9, 0, 56, 57, 363, DateTimeKind.Local).AddTicks(8529), 4234.11m },
                    { new Guid("60d4f521-807e-4796-8754-c439f081e11b"), new Guid("0667960a-b942-408f-9aa5-8591f0e0599a"), new DateTime(2024, 7, 9, 21, 15, 17, 346, DateTimeKind.Local).AddTicks(6862), new DateTime(2024, 8, 7, 16, 41, 30, 885, DateTimeKind.Local).AddTicks(9334), 209.84m },
                    { new Guid("60f38592-6723-4cf3-adf1-1d062d6500c4"), new Guid("28eaff52-a12b-4084-83b9-02a26ca7dfbc"), new DateTime(2024, 4, 12, 21, 31, 36, 764, DateTimeKind.Local).AddTicks(9164), new DateTime(2024, 8, 7, 5, 9, 7, 602, DateTimeKind.Local).AddTicks(643), 4199.91m },
                    { new Guid("616989d8-9893-47e9-b811-8da09292a03c"), new Guid("cce9a706-5e55-4052-a88e-26f4b6765bc9"), new DateTime(2023, 12, 2, 21, 47, 50, 119, DateTimeKind.Local).AddTicks(6491), new DateTime(2024, 8, 7, 16, 18, 20, 5, DateTimeKind.Local).AddTicks(6511), 4167.57m },
                    { new Guid("6233cfe0-f818-40ba-b74e-82e5d8d2f81f"), new Guid("2528ff79-cf89-4261-a0de-428d26b20a72"), new DateTime(2023, 9, 2, 15, 9, 24, 583, DateTimeKind.Local).AddTicks(362), new DateTime(2024, 8, 7, 9, 5, 38, 998, DateTimeKind.Local).AddTicks(2940), 4664.55m },
                    { new Guid("6268db1f-d83f-4e1b-93c0-499e54c6f821"), new Guid("24256d4c-7032-4437-8c1e-dd211c5bd713"), new DateTime(2024, 3, 30, 1, 16, 9, 104, DateTimeKind.Local).AddTicks(6138), new DateTime(2024, 8, 8, 10, 10, 15, 751, DateTimeKind.Local).AddTicks(3981), 4101.04m },
                    { new Guid("629efab7-b701-4284-9455-734ede0de5ad"), new Guid("90ece793-c6f5-47e7-8aa0-7c08ff3548fb"), new DateTime(2024, 1, 5, 19, 22, 0, 55, DateTimeKind.Local).AddTicks(9975), new DateTime(2024, 8, 7, 21, 42, 59, 908, DateTimeKind.Local).AddTicks(5920), 1572.52m },
                    { new Guid("62b7e0d3-4fe7-4e93-ba34-572a11e7267f"), new Guid("5611f5df-6d74-47b4-b24b-5863bd50f032"), new DateTime(2024, 4, 15, 18, 59, 2, 739, DateTimeKind.Local).AddTicks(6120), new DateTime(2024, 8, 8, 11, 56, 22, 21, DateTimeKind.Local).AddTicks(6299), 4010.82m },
                    { new Guid("62e9f80a-3bac-4857-8854-5a3520a72934"), new Guid("21d87d9e-43c6-46d1-bfee-644940fd9d64"), new DateTime(2023, 12, 15, 10, 52, 51, 418, DateTimeKind.Local).AddTicks(1146), new DateTime(2024, 8, 8, 3, 41, 40, 912, DateTimeKind.Local).AddTicks(4787), 945.20m },
                    { new Guid("6349ef11-6831-44fa-80d3-2dec984c290d"), new Guid("b41438f5-9380-4cd7-bc4d-59267b9b760c"), new DateTime(2023, 11, 13, 6, 2, 44, 938, DateTimeKind.Local).AddTicks(3919), new DateTime(2024, 8, 9, 8, 7, 59, 34, DateTimeKind.Local).AddTicks(7535), 1317.54m },
                    { new Guid("634cdc4d-aa3b-4f60-afa7-351e47ed5fd9"), new Guid("fa016e07-09ad-491e-a261-85cdebb45436"), new DateTime(2024, 1, 10, 4, 2, 23, 296, DateTimeKind.Local).AddTicks(7618), new DateTime(2024, 8, 9, 8, 49, 42, 970, DateTimeKind.Local).AddTicks(9714), 4631.43m },
                    { new Guid("6370a06c-249d-4f57-a636-2e7ba58cf037"), new Guid("22ebc934-105f-4b38-ab74-feae23d1ffc0"), new DateTime(2024, 6, 11, 13, 15, 58, 511, DateTimeKind.Local).AddTicks(4507), new DateTime(2024, 8, 9, 2, 22, 47, 471, DateTimeKind.Local).AddTicks(9518), 1649.15m },
                    { new Guid("6391108f-955b-4785-8af0-e92d6cdb8896"), new Guid("0667960a-b942-408f-9aa5-8591f0e0599a"), new DateTime(2024, 2, 9, 13, 19, 40, 28, DateTimeKind.Local).AddTicks(3331), new DateTime(2024, 8, 7, 2, 30, 40, 403, DateTimeKind.Local).AddTicks(4152), 3056.17m },
                    { new Guid("639caf8d-c51e-4642-b7e8-188601b51250"), new Guid("a38bfc8c-feac-4053-b76e-84c4e66d74d6"), new DateTime(2024, 4, 10, 8, 2, 55, 499, DateTimeKind.Local).AddTicks(1567), new DateTime(2024, 8, 9, 14, 9, 58, 982, DateTimeKind.Local).AddTicks(2749), 1187.05m },
                    { new Guid("639cb443-b2ce-487d-9ea6-d8f8c85b65cc"), new Guid("17544f0d-9e01-4955-b49a-dcc4b6a770ee"), new DateTime(2024, 2, 22, 12, 0, 41, 687, DateTimeKind.Local).AddTicks(1684), new DateTime(2024, 8, 8, 22, 50, 0, 614, DateTimeKind.Local).AddTicks(9231), 3305.92m },
                    { new Guid("63f64787-aada-4720-b1a5-a3c8af196b5c"), new Guid("0667960a-b942-408f-9aa5-8591f0e0599a"), new DateTime(2023, 10, 8, 7, 40, 7, 91, DateTimeKind.Local).AddTicks(3809), new DateTime(2024, 8, 7, 13, 48, 48, 425, DateTimeKind.Local).AddTicks(7453), 4915.25m },
                    { new Guid("64363361-f4aa-4ca9-aca9-ace732c9a4c4"), new Guid("1c79d0c4-56b9-4b08-af15-2fddc2c1068e"), new DateTime(2024, 7, 24, 13, 10, 38, 831, DateTimeKind.Local).AddTicks(9364), new DateTime(2024, 8, 8, 0, 2, 42, 111, DateTimeKind.Local).AddTicks(9838), 1827.44m },
                    { new Guid("646bea58-6c8f-485c-bd17-aee9daa4e6a2"), new Guid("3fd74fb4-2450-440d-8497-d9a630f57199"), new DateTime(2024, 6, 4, 21, 31, 55, 6, DateTimeKind.Local).AddTicks(4047), new DateTime(2024, 8, 8, 4, 37, 54, 299, DateTimeKind.Local).AddTicks(5872), 1772.28m },
                    { new Guid("6496e8dc-ca4d-4200-a55a-d6de9e131e6e"), new Guid("5611f5df-6d74-47b4-b24b-5863bd50f032"), new DateTime(2024, 3, 9, 17, 47, 3, 949, DateTimeKind.Local).AddTicks(6910), new DateTime(2024, 8, 6, 23, 50, 9, 773, DateTimeKind.Local).AddTicks(7182), 4018.24m },
                    { new Guid("65235574-70e1-4804-a0bd-152110a9e828"), new Guid("c0ebc03b-08bf-4b16-89e2-4c86dec71a59"), new DateTime(2023, 9, 7, 0, 34, 35, 232, DateTimeKind.Local).AddTicks(245), new DateTime(2024, 8, 9, 3, 43, 55, 160, DateTimeKind.Local).AddTicks(2679), 4221.11m },
                    { new Guid("6530f92f-0efe-4530-8ceb-59bd847637ff"), new Guid("d6d20276-ac8b-44d6-9939-d642e6335c51"), new DateTime(2023, 8, 22, 7, 37, 53, 44, DateTimeKind.Local).AddTicks(933), new DateTime(2024, 8, 8, 9, 28, 2, 238, DateTimeKind.Local).AddTicks(4696), 3333.41m },
                    { new Guid("655ac27f-f45f-4886-8f7b-6f3f7e005a9b"), new Guid("0667960a-b942-408f-9aa5-8591f0e0599a"), new DateTime(2023, 12, 25, 10, 0, 33, 468, DateTimeKind.Local).AddTicks(8938), new DateTime(2024, 8, 7, 1, 24, 47, 115, DateTimeKind.Local).AddTicks(3953), 66.56m },
                    { new Guid("655ff793-0a02-495b-a1d6-684cd65ec494"), new Guid("17544f0d-9e01-4955-b49a-dcc4b6a770ee"), new DateTime(2024, 3, 26, 1, 27, 33, 453, DateTimeKind.Local).AddTicks(5145), new DateTime(2024, 8, 7, 13, 30, 34, 812, DateTimeKind.Local).AddTicks(8174), 656.27m },
                    { new Guid("65602d5d-de30-4d9e-9d33-7948020ccbe3"), new Guid("5e4be06c-1976-4755-aeb0-28dae4b4298b"), new DateTime(2023, 11, 30, 0, 1, 6, 29, DateTimeKind.Local).AddTicks(5800), new DateTime(2024, 8, 7, 21, 53, 50, 630, DateTimeKind.Local).AddTicks(662), 2594.23m },
                    { new Guid("65c13d55-cf8d-4195-bc47-4e5bf7c08987"), new Guid("1248d1fb-1e80-4ded-926b-6b7f6d2249a5"), new DateTime(2024, 7, 23, 18, 33, 35, 531, DateTimeKind.Local).AddTicks(2410), new DateTime(2024, 8, 6, 23, 59, 41, 156, DateTimeKind.Local).AddTicks(6109), 1209.33m }
                });

            migrationBuilder.InsertData(
                table: "DonHangs",
                columns: new[] { "Id", "KhachHangId", "NgayDatHang", "NgayGiaoHang", "TongTien" },
                values: new object[,]
                {
                    { new Guid("66606d8b-ff94-40bf-a720-1fff2bc291c4"), new Guid("886111c9-af92-447f-91bf-dad7b8a03eb5"), new DateTime(2023, 9, 8, 16, 43, 15, 600, DateTimeKind.Local).AddTicks(8352), new DateTime(2024, 8, 8, 6, 25, 35, 272, DateTimeKind.Local).AddTicks(7896), 2852.67m },
                    { new Guid("666b05ad-7aa5-4a39-bb16-b684a1751975"), new Guid("1e3c140e-4cab-4065-aadd-2c1cfed5ce14"), new DateTime(2024, 3, 8, 13, 38, 42, 866, DateTimeKind.Local).AddTicks(3071), new DateTime(2024, 8, 9, 1, 44, 4, 11, DateTimeKind.Local).AddTicks(6372), 4096.12m },
                    { new Guid("670f91ba-8142-441a-b5bd-9d131c4f54ec"), new Guid("052538e6-f9b6-4bd1-98e0-6e7d6744fb4a"), new DateTime(2024, 2, 5, 9, 24, 7, 264, DateTimeKind.Local).AddTicks(5962), new DateTime(2024, 8, 9, 0, 44, 44, 746, DateTimeKind.Local).AddTicks(1480), 833.88m },
                    { new Guid("673943ba-0ba0-44bd-93fb-4a0da09d19e4"), new Guid("7395222e-7744-4172-86d1-1b128230fabf"), new DateTime(2024, 6, 19, 14, 18, 39, 967, DateTimeKind.Local).AddTicks(8730), new DateTime(2024, 8, 9, 18, 0, 19, 439, DateTimeKind.Local).AddTicks(5832), 2840.17m },
                    { new Guid("675267ed-c56e-41e8-912a-c46665c5a320"), new Guid("63021a65-455d-454a-92ee-525601ead4df"), new DateTime(2023, 11, 5, 17, 57, 39, 977, DateTimeKind.Local).AddTicks(5942), new DateTime(2024, 8, 7, 18, 7, 22, 57, DateTimeKind.Local).AddTicks(3397), 1763.26m },
                    { new Guid("676b1d4f-cc4b-4f24-8311-357c62b07977"), new Guid("f9a1bd2e-de1a-42b8-b894-7f7e0b5b38f1"), new DateTime(2023, 8, 15, 4, 32, 33, 14, DateTimeKind.Local).AddTicks(1398), new DateTime(2024, 8, 8, 6, 51, 8, 993, DateTimeKind.Local).AddTicks(6275), 4208.14m },
                    { new Guid("6779cbba-0733-4e3c-ab6f-14f9b54835c3"), new Guid("5611f5df-6d74-47b4-b24b-5863bd50f032"), new DateTime(2024, 8, 2, 22, 59, 48, 710, DateTimeKind.Local).AddTicks(7678), new DateTime(2024, 8, 7, 12, 40, 14, 107, DateTimeKind.Local).AddTicks(2723), 870.64m },
                    { new Guid("67817553-cf07-469d-b42d-072fbb5eb226"), new Guid("d15c8331-36ed-417a-b1fa-5f377c4c9930"), new DateTime(2024, 1, 9, 15, 10, 10, 989, DateTimeKind.Local).AddTicks(1033), new DateTime(2024, 8, 8, 7, 51, 37, 136, DateTimeKind.Local).AddTicks(3775), 1856.79m },
                    { new Guid("67ad55f7-28ad-4a9f-9d99-76f9cb7e2224"), new Guid("7395222e-7744-4172-86d1-1b128230fabf"), new DateTime(2024, 4, 30, 5, 53, 52, 574, DateTimeKind.Local).AddTicks(3497), new DateTime(2024, 8, 8, 11, 19, 5, 53, DateTimeKind.Local).AddTicks(2232), 4798.33m },
                    { new Guid("68282e9c-a1b8-4184-8472-69d6d6994eb6"), new Guid("90ece793-c6f5-47e7-8aa0-7c08ff3548fb"), new DateTime(2023, 10, 10, 12, 52, 32, 702, DateTimeKind.Local).AddTicks(3010), new DateTime(2024, 8, 9, 17, 44, 32, 581, DateTimeKind.Local).AddTicks(7276), 4409.04m },
                    { new Guid("6897bd42-04b7-4fac-b1d7-5fe03ec4ef18"), new Guid("1c79d0c4-56b9-4b08-af15-2fddc2c1068e"), new DateTime(2024, 1, 22, 6, 29, 39, 846, DateTimeKind.Local).AddTicks(94), new DateTime(2024, 8, 7, 23, 7, 11, 410, DateTimeKind.Local).AddTicks(9772), 4330.10m },
                    { new Guid("68be47d3-9d86-466a-aebf-ddea5ab2b872"), new Guid("28d8da78-c6c4-4afe-9d92-22d52e3969b0"), new DateTime(2024, 2, 28, 18, 4, 52, 799, DateTimeKind.Local).AddTicks(2464), new DateTime(2024, 8, 9, 4, 57, 56, 823, DateTimeKind.Local).AddTicks(7638), 1395.52m },
                    { new Guid("68f805f5-2b72-4b77-a8e3-44d21cd585d8"), new Guid("063fdb59-1945-4f6e-85e3-5f57321287f9"), new DateTime(2024, 6, 30, 15, 1, 51, 759, DateTimeKind.Local).AddTicks(6281), new DateTime(2024, 8, 8, 15, 49, 34, 989, DateTimeKind.Local).AddTicks(8031), 250.09m },
                    { new Guid("6907357d-de66-4ef7-902f-5fed14218971"), new Guid("9e65dc79-3d73-4629-8551-a5f2b9cfe2a4"), new DateTime(2024, 1, 23, 5, 3, 14, 45, DateTimeKind.Local).AddTicks(943), new DateTime(2024, 8, 9, 5, 29, 36, 177, DateTimeKind.Local).AddTicks(2255), 663.23m },
                    { new Guid("699cee94-2697-4cfe-992a-d4f35763233d"), new Guid("38ba8024-3b8d-4dd6-92b9-9d06da12ec6e"), new DateTime(2024, 3, 31, 9, 49, 4, 123, DateTimeKind.Local).AddTicks(9196), new DateTime(2024, 8, 9, 9, 37, 14, 654, DateTimeKind.Local).AddTicks(5922), 3340.52m },
                    { new Guid("6a016a30-8d30-4956-be51-79ab2ccea823"), new Guid("28d8da78-c6c4-4afe-9d92-22d52e3969b0"), new DateTime(2023, 11, 25, 4, 54, 5, 542, DateTimeKind.Local).AddTicks(8833), new DateTime(2024, 8, 8, 15, 13, 14, 796, DateTimeKind.Local).AddTicks(1971), 3305.68m },
                    { new Guid("6ab009da-de7f-4f17-b333-cf2e206e517f"), new Guid("fa016e07-09ad-491e-a261-85cdebb45436"), new DateTime(2023, 9, 29, 1, 4, 36, 452, DateTimeKind.Local).AddTicks(2181), new DateTime(2024, 8, 7, 5, 20, 28, 235, DateTimeKind.Local).AddTicks(2551), 1947.18m },
                    { new Guid("6ab42591-45cd-43d5-a17a-ef195abf0d01"), new Guid("c06db99e-509c-4391-b257-6799307a8b3c"), new DateTime(2024, 5, 6, 14, 21, 30, 168, DateTimeKind.Local).AddTicks(237), new DateTime(2024, 8, 8, 3, 36, 32, 155, DateTimeKind.Local).AddTicks(8861), 742.04m },
                    { new Guid("6ac263b0-9c52-446c-9fa2-d381d62e399e"), new Guid("b0074e79-8782-48c2-b497-9ae7bd24e960"), new DateTime(2024, 3, 3, 6, 45, 41, 628, DateTimeKind.Local).AddTicks(8733), new DateTime(2024, 8, 9, 8, 52, 39, 144, DateTimeKind.Local).AddTicks(1907), 2948.86m },
                    { new Guid("6ad1960f-8692-4ecf-9889-f721a4be29d5"), new Guid("21d87d9e-43c6-46d1-bfee-644940fd9d64"), new DateTime(2024, 2, 26, 18, 37, 33, 868, DateTimeKind.Local).AddTicks(6834), new DateTime(2024, 8, 9, 18, 27, 18, 506, DateTimeKind.Local).AddTicks(1812), 1515.94m },
                    { new Guid("6afc1c97-a1bc-4a76-a0cc-ce272877a1f5"), new Guid("44514479-669b-45b2-8af4-510b0786de9b"), new DateTime(2023, 12, 1, 0, 48, 18, 71, DateTimeKind.Local).AddTicks(5312), new DateTime(2024, 8, 8, 12, 12, 33, 652, DateTimeKind.Local).AddTicks(9064), 4555.74m },
                    { new Guid("6b1c33a5-838a-45d9-bed1-f0a72bf75ee9"), new Guid("93fb1f32-f25c-41b4-91a2-c22a92a4ab83"), new DateTime(2024, 1, 16, 18, 26, 11, 287, DateTimeKind.Local).AddTicks(7104), new DateTime(2024, 8, 9, 12, 39, 53, 777, DateTimeKind.Local).AddTicks(6045), 4572.42m },
                    { new Guid("6b5d9fd9-aeb8-4541-a8a7-2c1cf7e6256e"), new Guid("c0ebc03b-08bf-4b16-89e2-4c86dec71a59"), new DateTime(2023, 8, 8, 17, 10, 39, 537, DateTimeKind.Local).AddTicks(3920), new DateTime(2024, 8, 7, 20, 26, 53, 588, DateTimeKind.Local).AddTicks(3617), 4932.97m },
                    { new Guid("6b7d9ddb-d5c5-46f2-bc91-29d0c9bb40b7"), new Guid("fafc2111-6b48-4585-8074-65bb860d42ae"), new DateTime(2024, 6, 29, 22, 36, 59, 994, DateTimeKind.Local).AddTicks(4400), new DateTime(2024, 8, 8, 22, 58, 8, 997, DateTimeKind.Local).AddTicks(2906), 3914.02m },
                    { new Guid("6bb6ba36-fcf1-4d69-96fd-8ecbfe61ac4e"), new Guid("5e4be06c-1976-4755-aeb0-28dae4b4298b"), new DateTime(2024, 6, 13, 12, 42, 17, 455, DateTimeKind.Local).AddTicks(9288), new DateTime(2024, 8, 7, 12, 59, 4, 198, DateTimeKind.Local).AddTicks(6092), 2255.57m },
                    { new Guid("6bf3ed17-1106-4acc-bb44-e1d4dc6cc5a3"), new Guid("e9d684aa-183f-423f-8741-1a53cfb8f2e3"), new DateTime(2024, 6, 26, 0, 44, 53, 430, DateTimeKind.Local).AddTicks(3347), new DateTime(2024, 8, 7, 2, 41, 49, 68, DateTimeKind.Local).AddTicks(5818), 3649.77m },
                    { new Guid("6c449417-b790-43ef-b5ed-e6bcd6c2ad9b"), new Guid("e56e8c86-41ee-47fd-9d05-a94a167bed10"), new DateTime(2023, 10, 30, 4, 32, 50, 378, DateTimeKind.Local).AddTicks(8815), new DateTime(2024, 8, 7, 23, 37, 48, 62, DateTimeKind.Local).AddTicks(1156), 1864.36m },
                    { new Guid("6cfc6dda-33bf-4cd2-913c-435becc1634d"), new Guid("6e20d02e-a4a6-4614-83ac-f23bb4548158"), new DateTime(2024, 4, 22, 15, 33, 17, 718, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 8, 8, 2, 54, 56, 917, DateTimeKind.Local).AddTicks(2189), 2865.96m },
                    { new Guid("6da1223c-bcd2-4df6-8eff-aaedd33abb24"), new Guid("e56e8c86-41ee-47fd-9d05-a94a167bed10"), new DateTime(2023, 10, 17, 14, 4, 47, 40, DateTimeKind.Local).AddTicks(956), new DateTime(2024, 8, 6, 23, 0, 48, 274, DateTimeKind.Local).AddTicks(5768), 724.62m },
                    { new Guid("6da8d16e-3aff-4c40-851a-948d62fda8ec"), new Guid("6212ef8f-9777-42a2-ad28-a2ed1ebe90f8"), new DateTime(2024, 5, 16, 8, 32, 45, 114, DateTimeKind.Local).AddTicks(8452), new DateTime(2024, 8, 7, 17, 9, 19, 403, DateTimeKind.Local).AddTicks(1191), 2772.87m },
                    { new Guid("6db57454-431b-4456-be51-8f83d1e0892e"), new Guid("c06db99e-509c-4391-b257-6799307a8b3c"), new DateTime(2024, 3, 30, 12, 40, 1, 691, DateTimeKind.Local).AddTicks(6817), new DateTime(2024, 8, 9, 15, 35, 13, 600, DateTimeKind.Local).AddTicks(980), 4622.14m },
                    { new Guid("6ebbe835-4d55-440a-9e5a-90ea78aa9ea7"), new Guid("17544f0d-9e01-4955-b49a-dcc4b6a770ee"), new DateTime(2024, 7, 20, 11, 0, 34, 230, DateTimeKind.Local).AddTicks(5106), new DateTime(2024, 8, 9, 5, 6, 46, 20, DateTimeKind.Local).AddTicks(9114), 1417.30m },
                    { new Guid("6ed24c37-1c5c-447b-aac7-528808f341e9"), new Guid("21d87d9e-43c6-46d1-bfee-644940fd9d64"), new DateTime(2024, 5, 13, 19, 52, 13, 807, DateTimeKind.Local).AddTicks(9845), new DateTime(2024, 8, 9, 11, 25, 40, 111, DateTimeKind.Local).AddTicks(3861), 3245.73m },
                    { new Guid("6eef378f-a36e-45cc-8565-19147c9547e8"), new Guid("6e20d02e-a4a6-4614-83ac-f23bb4548158"), new DateTime(2023, 10, 1, 7, 5, 26, 723, DateTimeKind.Local).AddTicks(4116), new DateTime(2024, 8, 8, 22, 52, 11, 567, DateTimeKind.Local).AddTicks(7501), 1457.67m },
                    { new Guid("6f0bc07e-696a-4821-b7fb-b4abd090e51b"), new Guid("75fe592b-5c1e-4814-a459-627bef01098f"), new DateTime(2024, 2, 2, 22, 4, 27, 521, DateTimeKind.Local).AddTicks(7586), new DateTime(2024, 8, 7, 21, 50, 42, 614, DateTimeKind.Local).AddTicks(6153), 2029.99m },
                    { new Guid("6f3927c2-f20d-4afa-a2bf-0fb621b6296e"), new Guid("90ece793-c6f5-47e7-8aa0-7c08ff3548fb"), new DateTime(2024, 4, 27, 7, 14, 25, 83, DateTimeKind.Local).AddTicks(3596), new DateTime(2024, 8, 6, 22, 37, 20, 97, DateTimeKind.Local).AddTicks(3864), 2196.01m },
                    { new Guid("6f5ebb4c-b19c-42ff-b9da-7b0f49ea6890"), new Guid("427269be-9018-4cf4-9818-4fae14114ae4"), new DateTime(2023, 10, 7, 8, 42, 21, 475, DateTimeKind.Local).AddTicks(1522), new DateTime(2024, 8, 7, 18, 59, 55, 759, DateTimeKind.Local).AddTicks(2602), 1266.05m },
                    { new Guid("6fb75147-c13f-4936-a399-3386237b2840"), new Guid("3fd74fb4-2450-440d-8497-d9a630f57199"), new DateTime(2024, 1, 18, 22, 35, 30, 996, DateTimeKind.Local).AddTicks(1411), new DateTime(2024, 8, 8, 4, 27, 26, 637, DateTimeKind.Local).AddTicks(3846), 1027.99m },
                    { new Guid("6fea9ea5-6fac-4c05-a7c1-bc81c453b882"), new Guid("232fdc99-53fe-4232-9c74-06ddfb2a13b8"), new DateTime(2023, 8, 26, 11, 38, 43, 737, DateTimeKind.Local).AddTicks(4541), new DateTime(2024, 8, 8, 16, 42, 10, 61, DateTimeKind.Local).AddTicks(9474), 2963.68m },
                    { new Guid("7051b6c8-ef46-4baf-9777-aa507c8a0f2f"), new Guid("9f2dcec6-cc02-45d6-95d0-fa0b53a5f953"), new DateTime(2023, 8, 31, 4, 15, 15, 397, DateTimeKind.Local).AddTicks(7011), new DateTime(2024, 8, 8, 0, 27, 47, 413, DateTimeKind.Local).AddTicks(2719), 449.34m },
                    { new Guid("70606370-6cdd-4faa-8659-3246a4c9d1a8"), new Guid("5e4be06c-1976-4755-aeb0-28dae4b4298b"), new DateTime(2024, 2, 9, 13, 6, 58, 215, DateTimeKind.Local).AddTicks(4306), new DateTime(2024, 8, 8, 0, 52, 16, 745, DateTimeKind.Local).AddTicks(9979), 3492.69m },
                    { new Guid("70a61763-1224-4b75-b7cd-b03e20331897"), new Guid("8bc08888-8550-4e72-9b5e-71845b5b9567"), new DateTime(2023, 9, 30, 16, 15, 3, 265, DateTimeKind.Local).AddTicks(7719), new DateTime(2024, 8, 7, 4, 5, 5, 2, DateTimeKind.Local).AddTicks(2256), 3161.02m }
                });

            migrationBuilder.InsertData(
                table: "DonHangs",
                columns: new[] { "Id", "KhachHangId", "NgayDatHang", "NgayGiaoHang", "TongTien" },
                values: new object[,]
                {
                    { new Guid("70b6b10b-270a-4c06-b619-9c06e748c5d0"), new Guid("297e58cc-55d1-4c96-81c1-edd1b4b0ffb7"), new DateTime(2023, 12, 7, 6, 7, 16, 269, DateTimeKind.Local).AddTicks(9055), new DateTime(2024, 8, 8, 8, 8, 56, 836, DateTimeKind.Local).AddTicks(440), 1330.60m },
                    { new Guid("728dc7cb-3fa6-4c06-907e-fae93c97365d"), new Guid("893b3fb0-9647-4958-b835-676e382779e7"), new DateTime(2023, 9, 26, 22, 42, 14, 556, DateTimeKind.Local).AddTicks(4965), new DateTime(2024, 8, 8, 1, 22, 50, 785, DateTimeKind.Local).AddTicks(4258), 95.66m },
                    { new Guid("7295b410-49af-4b73-8104-5a5579e224ac"), new Guid("93fb1f32-f25c-41b4-91a2-c22a92a4ab83"), new DateTime(2023, 8, 17, 7, 56, 12, 972, DateTimeKind.Local).AddTicks(5714), new DateTime(2024, 8, 8, 23, 11, 32, 639, DateTimeKind.Local).AddTicks(1936), 2358.03m },
                    { new Guid("72b1cfab-407b-44ec-a355-e520802e424e"), new Guid("427269be-9018-4cf4-9818-4fae14114ae4"), new DateTime(2024, 4, 10, 0, 59, 45, 508, DateTimeKind.Local).AddTicks(1791), new DateTime(2024, 8, 7, 17, 48, 55, 367, DateTimeKind.Local).AddTicks(1300), 827.84m },
                    { new Guid("72e45619-4b7e-43cb-8457-25c7532ded17"), new Guid("7395222e-7744-4172-86d1-1b128230fabf"), new DateTime(2024, 1, 28, 16, 24, 29, 131, DateTimeKind.Local).AddTicks(3647), new DateTime(2024, 8, 8, 19, 55, 20, 449, DateTimeKind.Local).AddTicks(3314), 1524.61m },
                    { new Guid("735c2cf6-cdfe-4043-b502-4b8a897bd3c0"), new Guid("a51f9433-2477-4445-8a69-d24c50d95afb"), new DateTime(2024, 5, 21, 18, 29, 4, 858, DateTimeKind.Local).AddTicks(2485), new DateTime(2024, 8, 8, 1, 4, 56, 645, DateTimeKind.Local).AddTicks(5882), 2208.58m },
                    { new Guid("7381293a-ed06-414d-a7d0-b902854b0bad"), new Guid("b78d1e60-56cf-4058-967c-7271f646af05"), new DateTime(2024, 3, 12, 11, 36, 28, 970, DateTimeKind.Local).AddTicks(4058), new DateTime(2024, 8, 8, 19, 48, 46, 499, DateTimeKind.Local).AddTicks(6755), 310.39m },
                    { new Guid("738633ca-cd98-4ab9-8bbc-e6690d24c7f7"), new Guid("5611f5df-6d74-47b4-b24b-5863bd50f032"), new DateTime(2023, 11, 23, 10, 4, 29, 846, DateTimeKind.Local).AddTicks(7182), new DateTime(2024, 8, 7, 19, 0, 37, 190, DateTimeKind.Local).AddTicks(818), 3911.55m },
                    { new Guid("739ebf00-2a89-4add-9670-fc962142352e"), new Guid("0bd930d6-b736-4558-87c1-50bd97e08db0"), new DateTime(2024, 7, 27, 3, 14, 13, 960, DateTimeKind.Local).AddTicks(4570), new DateTime(2024, 8, 9, 19, 49, 47, 219, DateTimeKind.Local).AddTicks(4305), 3530.41m },
                    { new Guid("74ccbab9-f5b2-4ae3-9083-78d342675750"), new Guid("063fdb59-1945-4f6e-85e3-5f57321287f9"), new DateTime(2023, 9, 24, 9, 1, 53, 438, DateTimeKind.Local).AddTicks(9265), new DateTime(2024, 8, 7, 4, 3, 57, 549, DateTimeKind.Local).AddTicks(9759), 3838.85m },
                    { new Guid("74f326e6-c64d-42dd-8b3f-5290618be842"), new Guid("90ece793-c6f5-47e7-8aa0-7c08ff3548fb"), new DateTime(2024, 4, 21, 0, 31, 59, 178, DateTimeKind.Local).AddTicks(5310), new DateTime(2024, 8, 7, 21, 43, 38, 245, DateTimeKind.Local).AddTicks(7633), 2668.55m },
                    { new Guid("7506078e-165b-4880-8e32-adadb8d0498e"), new Guid("c06db99e-509c-4391-b257-6799307a8b3c"), new DateTime(2023, 9, 15, 12, 26, 41, 381, DateTimeKind.Local).AddTicks(9907), new DateTime(2024, 8, 7, 18, 25, 1, 126, DateTimeKind.Local).AddTicks(687), 3310.78m },
                    { new Guid("75792d88-35f7-47db-a567-e58698ddc5d4"), new Guid("1d71e542-620f-4161-9842-a2a145bd7013"), new DateTime(2024, 7, 20, 21, 54, 17, 602, DateTimeKind.Local).AddTicks(476), new DateTime(2024, 8, 9, 15, 41, 6, 186, DateTimeKind.Local).AddTicks(1275), 1097.57m },
                    { new Guid("75b8a9ab-1bff-4368-8f32-1eda10954a39"), new Guid("28eaff52-a12b-4084-83b9-02a26ca7dfbc"), new DateTime(2024, 1, 4, 2, 51, 39, 790, DateTimeKind.Local).AddTicks(7366), new DateTime(2024, 8, 8, 14, 29, 32, 195, DateTimeKind.Local).AddTicks(3446), 1900.55m },
                    { new Guid("7601ffbb-534c-4e37-8a67-c9e2b3c6b4fa"), new Guid("9e65dc79-3d73-4629-8551-a5f2b9cfe2a4"), new DateTime(2023, 10, 6, 4, 11, 56, 167, DateTimeKind.Local).AddTicks(3464), new DateTime(2024, 8, 9, 16, 14, 5, 371, DateTimeKind.Local).AddTicks(5323), 3524.48m },
                    { new Guid("761bada5-0435-4590-b708-b465214b5ba2"), new Guid("6d1e80c0-f438-45cd-a63c-9bf2330160b6"), new DateTime(2024, 4, 20, 17, 39, 26, 590, DateTimeKind.Local).AddTicks(7868), new DateTime(2024, 8, 8, 3, 50, 19, 765, DateTimeKind.Local).AddTicks(8224), 2512.47m },
                    { new Guid("761c3a41-3385-48be-a30f-2cfd97f0d198"), new Guid("a38bfc8c-feac-4053-b76e-84c4e66d74d6"), new DateTime(2024, 6, 6, 3, 2, 20, 649, DateTimeKind.Local).AddTicks(2233), new DateTime(2024, 8, 7, 16, 22, 32, 459, DateTimeKind.Local).AddTicks(1366), 2499.03m },
                    { new Guid("761ca454-5e1f-42c3-803a-433881622446"), new Guid("93fb1f32-f25c-41b4-91a2-c22a92a4ab83"), new DateTime(2023, 9, 16, 12, 36, 5, 584, DateTimeKind.Local).AddTicks(74), new DateTime(2024, 8, 9, 15, 44, 37, 834, DateTimeKind.Local).AddTicks(8557), 4976.79m },
                    { new Guid("762b6d4a-a135-4f4b-9ef9-0d1c2f1de622"), new Guid("5bc8e452-e383-427e-bc9b-c26642f1a642"), new DateTime(2024, 5, 14, 10, 46, 22, 416, DateTimeKind.Local).AddTicks(2731), new DateTime(2024, 8, 8, 11, 59, 36, 386, DateTimeKind.Local).AddTicks(9675), 1017.42m },
                    { new Guid("765a28ba-0298-4478-8c73-5e180119563d"), new Guid("eb503b18-f1e1-4a47-8871-99a4746eb8c6"), new DateTime(2024, 2, 29, 5, 59, 25, 0, DateTimeKind.Local).AddTicks(5433), new DateTime(2024, 8, 8, 20, 29, 13, 243, DateTimeKind.Local).AddTicks(7210), 953.25m },
                    { new Guid("766156d6-2f43-42ce-9c39-e8cc82088431"), new Guid("7395222e-7744-4172-86d1-1b128230fabf"), new DateTime(2023, 8, 23, 3, 11, 52, 394, DateTimeKind.Local).AddTicks(9197), new DateTime(2024, 8, 7, 10, 8, 34, 77, DateTimeKind.Local).AddTicks(1884), 1598.98m },
                    { new Guid("7683b044-abd1-447b-b81a-25c60f5a648a"), new Guid("44514479-669b-45b2-8af4-510b0786de9b"), new DateTime(2023, 9, 4, 4, 3, 44, 970, DateTimeKind.Local).AddTicks(8799), new DateTime(2024, 8, 7, 23, 14, 30, 371, DateTimeKind.Local).AddTicks(1019), 3945.23m },
                    { new Guid("76f61ef4-375c-4f75-927b-98bb1ebef380"), new Guid("6fdebd38-1ce1-416f-af92-047978b186a5"), new DateTime(2023, 10, 19, 17, 19, 55, 860, DateTimeKind.Local).AddTicks(3106), new DateTime(2024, 8, 7, 0, 19, 35, 853, DateTimeKind.Local).AddTicks(6861), 3487.29m },
                    { new Guid("7789a906-046e-4164-94f5-6a155c366f30"), new Guid("6212ef8f-9777-42a2-ad28-a2ed1ebe90f8"), new DateTime(2024, 1, 29, 16, 39, 17, 343, DateTimeKind.Local).AddTicks(1424), new DateTime(2024, 8, 6, 22, 47, 7, 186, DateTimeKind.Local).AddTicks(786), 693.98m },
                    { new Guid("77d71e62-6587-458c-a822-306aef22db65"), new Guid("90fb9bfe-da70-4392-9904-4417fab257a7"), new DateTime(2024, 3, 6, 14, 21, 16, 939, DateTimeKind.Local).AddTicks(2782), new DateTime(2024, 8, 8, 9, 50, 11, 742, DateTimeKind.Local).AddTicks(206), 4446.83m },
                    { new Guid("78192791-08d6-4100-95d9-70ff788b1aba"), new Guid("a2e054b5-4260-4454-a995-281c00600f11"), new DateTime(2024, 2, 10, 15, 17, 52, 136, DateTimeKind.Local).AddTicks(5784), new DateTime(2024, 8, 8, 9, 26, 8, 620, DateTimeKind.Local).AddTicks(7583), 1638.91m },
                    { new Guid("78219b71-99d0-4cb1-96f8-8240d66a04b4"), new Guid("9e65dc79-3d73-4629-8551-a5f2b9cfe2a4"), new DateTime(2024, 4, 3, 20, 24, 26, 125, DateTimeKind.Local).AddTicks(6236), new DateTime(2024, 8, 7, 4, 49, 55, 887, DateTimeKind.Local).AddTicks(678), 2492.58m },
                    { new Guid("78269cf7-cfe2-45de-a8e0-e7036a8eacc5"), new Guid("2f5efba5-6605-4ccc-9a86-918b9bd19b8b"), new DateTime(2024, 2, 29, 15, 32, 19, 512, DateTimeKind.Local).AddTicks(9739), new DateTime(2024, 8, 9, 13, 21, 56, 946, DateTimeKind.Local).AddTicks(5573), 1735.63m },
                    { new Guid("78a88812-9133-4882-82db-a1dfd8fb3202"), new Guid("6e20d02e-a4a6-4614-83ac-f23bb4548158"), new DateTime(2024, 3, 14, 6, 49, 0, 999, DateTimeKind.Local).AddTicks(8615), new DateTime(2024, 8, 7, 5, 30, 51, 885, DateTimeKind.Local).AddTicks(586), 2941.11m },
                    { new Guid("78ae6724-9ef9-409d-870a-23a99fa46c52"), new Guid("17652753-332f-4654-89d0-bbca6d67670f"), new DateTime(2024, 4, 17, 11, 27, 48, 196, DateTimeKind.Local).AddTicks(418), new DateTime(2024, 8, 8, 11, 33, 7, 495, DateTimeKind.Local).AddTicks(7135), 1558.87m },
                    { new Guid("78d5f971-b9fc-4407-b361-43bc233d948e"), new Guid("1e3c140e-4cab-4065-aadd-2c1cfed5ce14"), new DateTime(2024, 1, 6, 9, 21, 36, 892, DateTimeKind.Local).AddTicks(110), new DateTime(2024, 8, 6, 22, 26, 41, 401, DateTimeKind.Local).AddTicks(3365), 60.31m },
                    { new Guid("790afa06-10f5-4cf7-b42d-b3a405b076e2"), new Guid("e56e8c86-41ee-47fd-9d05-a94a167bed10"), new DateTime(2024, 5, 5, 21, 7, 46, 977, DateTimeKind.Local).AddTicks(914), new DateTime(2024, 8, 6, 22, 53, 32, 721, DateTimeKind.Local).AddTicks(6250), 4503.00m },
                    { new Guid("791f45ef-4156-4a6d-b346-00aa90d3044a"), new Guid("f4a61b17-322c-4071-bb9d-c0378e5c9669"), new DateTime(2023, 10, 29, 17, 36, 3, 74, DateTimeKind.Local).AddTicks(1910), new DateTime(2024, 8, 7, 13, 55, 40, 378, DateTimeKind.Local).AddTicks(840), 2772.70m },
                    { new Guid("797828d3-c328-4c4d-94cc-d60037253ad1"), new Guid("6f10d3da-6328-4453-bd18-d299e75dca49"), new DateTime(2024, 8, 6, 8, 34, 0, 748, DateTimeKind.Local).AddTicks(4111), new DateTime(2024, 8, 8, 9, 51, 19, 250, DateTimeKind.Local).AddTicks(4607), 949.01m },
                    { new Guid("79f161ec-d37e-4db9-b9bf-d4349bbd9ace"), new Guid("8bc08888-8550-4e72-9b5e-71845b5b9567"), new DateTime(2023, 11, 1, 0, 58, 7, 857, DateTimeKind.Local).AddTicks(5819), new DateTime(2024, 8, 7, 12, 5, 32, 632, DateTimeKind.Local).AddTicks(9417), 4344.95m },
                    { new Guid("79f3b33f-a972-45eb-b6d3-35671a1cc160"), new Guid("a38bfc8c-feac-4053-b76e-84c4e66d74d6"), new DateTime(2024, 7, 5, 4, 7, 30, 960, DateTimeKind.Local).AddTicks(311), new DateTime(2024, 8, 6, 22, 21, 51, 136, DateTimeKind.Local).AddTicks(423), 2898.71m },
                    { new Guid("79f978ce-a6ef-463b-a19b-29564a262db4"), new Guid("d43ed679-0d22-40c7-a14a-6d01fe86c193"), new DateTime(2024, 2, 13, 10, 6, 12, 292, DateTimeKind.Local).AddTicks(6193), new DateTime(2024, 8, 8, 8, 46, 19, 740, DateTimeKind.Local).AddTicks(5331), 3293.49m },
                    { new Guid("7a122234-64b4-4f7a-b527-4a0582cefbdf"), new Guid("1c79d0c4-56b9-4b08-af15-2fddc2c1068e"), new DateTime(2023, 12, 2, 9, 35, 0, 565, DateTimeKind.Local).AddTicks(1218), new DateTime(2024, 8, 9, 10, 50, 29, 654, DateTimeKind.Local).AddTicks(6378), 3917.02m },
                    { new Guid("7a359c90-8b85-43fa-82f0-111de6c8ef2d"), new Guid("ec92935c-29c1-47d3-9ff2-3aed6a0974f2"), new DateTime(2023, 10, 15, 16, 30, 15, 728, DateTimeKind.Local).AddTicks(3651), new DateTime(2024, 8, 9, 8, 4, 48, 12, DateTimeKind.Local).AddTicks(4818), 3335.72m },
                    { new Guid("7a60c0db-2e8c-4bfc-8634-5f9812782ac4"), new Guid("b0074e79-8782-48c2-b497-9ae7bd24e960"), new DateTime(2023, 8, 17, 3, 6, 33, 611, DateTimeKind.Local).AddTicks(2938), new DateTime(2024, 8, 9, 22, 7, 28, 160, DateTimeKind.Local).AddTicks(9881), 4570.22m },
                    { new Guid("7a78c4b5-a122-405b-9b84-a72b429f5dee"), new Guid("893b3fb0-9647-4958-b835-676e382779e7"), new DateTime(2023, 12, 20, 5, 57, 8, 346, DateTimeKind.Local).AddTicks(5093), new DateTime(2024, 8, 9, 1, 49, 8, 297, DateTimeKind.Local).AddTicks(1218), 4442.45m },
                    { new Guid("7a7b11dc-5ad3-40c0-b47d-ffa1b22c743a"), new Guid("d5d71173-e817-45f8-9146-4b7ab7c7b686"), new DateTime(2023, 9, 18, 1, 24, 34, 196, DateTimeKind.Local).AddTicks(7034), new DateTime(2024, 8, 9, 12, 46, 24, 4, DateTimeKind.Local).AddTicks(691), 2630.95m }
                });

            migrationBuilder.InsertData(
                table: "DonHangs",
                columns: new[] { "Id", "KhachHangId", "NgayDatHang", "NgayGiaoHang", "TongTien" },
                values: new object[,]
                {
                    { new Guid("7a8f7779-ede6-4c16-820c-1f9c05e64612"), new Guid("90fb9bfe-da70-4392-9904-4417fab257a7"), new DateTime(2024, 1, 10, 14, 58, 30, 537, DateTimeKind.Local).AddTicks(4260), new DateTime(2024, 8, 8, 9, 48, 25, 967, DateTimeKind.Local).AddTicks(6330), 4407.41m },
                    { new Guid("7a9477ae-9473-43e7-a24f-933f18b412f5"), new Guid("38ba8024-3b8d-4dd6-92b9-9d06da12ec6e"), new DateTime(2024, 5, 10, 4, 22, 35, 823, DateTimeKind.Local).AddTicks(4151), new DateTime(2024, 8, 9, 13, 30, 14, 865, DateTimeKind.Local).AddTicks(4181), 4923.02m },
                    { new Guid("7addaafe-c869-411f-a4f4-9d8fc94cc716"), new Guid("d43ed679-0d22-40c7-a14a-6d01fe86c193"), new DateTime(2024, 3, 8, 7, 59, 20, 402, DateTimeKind.Local).AddTicks(1668), new DateTime(2024, 8, 8, 14, 42, 30, 406, DateTimeKind.Local).AddTicks(9279), 1849.68m },
                    { new Guid("7b00dee3-577d-47fc-99bd-afdda35e7c2c"), new Guid("38ba8024-3b8d-4dd6-92b9-9d06da12ec6e"), new DateTime(2023, 12, 9, 3, 29, 59, 727, DateTimeKind.Local).AddTicks(5539), new DateTime(2024, 8, 7, 14, 2, 49, 759, DateTimeKind.Local).AddTicks(5743), 2903.03m },
                    { new Guid("7b0c658d-f739-4489-ac4c-c6b4e9f90aa5"), new Guid("052538e6-f9b6-4bd1-98e0-6e7d6744fb4a"), new DateTime(2023, 9, 6, 17, 3, 17, 542, DateTimeKind.Local).AddTicks(2855), new DateTime(2024, 8, 8, 23, 52, 13, 751, DateTimeKind.Local).AddTicks(7446), 1730.28m },
                    { new Guid("7b5ac3fd-fb3f-40e9-a79a-3e6a2025f35e"), new Guid("063fdb59-1945-4f6e-85e3-5f57321287f9"), new DateTime(2023, 10, 31, 22, 8, 29, 220, DateTimeKind.Local).AddTicks(3248), new DateTime(2024, 8, 9, 7, 6, 33, 776, DateTimeKind.Local).AddTicks(5246), 2175.84m },
                    { new Guid("7bf68c1d-a1b5-48d7-ad3b-a1a51bcf26e4"), new Guid("44514479-669b-45b2-8af4-510b0786de9b"), new DateTime(2023, 10, 24, 16, 53, 39, 588, DateTimeKind.Local).AddTicks(5055), new DateTime(2024, 8, 9, 16, 5, 4, 438, DateTimeKind.Local).AddTicks(1265), 1507.57m },
                    { new Guid("7cf09bac-5059-4a6c-a231-b79a130530f3"), new Guid("c06db99e-509c-4391-b257-6799307a8b3c"), new DateTime(2024, 5, 14, 14, 36, 21, 566, DateTimeKind.Local).AddTicks(2983), new DateTime(2024, 8, 7, 19, 20, 47, 546, DateTimeKind.Local).AddTicks(1001), 2035.17m },
                    { new Guid("7d0c06be-e684-4cc5-a60b-de38122d116f"), new Guid("5ee23c83-8a7a-498c-96a6-f2bc6fdc8136"), new DateTime(2024, 4, 21, 8, 40, 21, 885, DateTimeKind.Local).AddTicks(311), new DateTime(2024, 8, 8, 20, 5, 16, 78, DateTimeKind.Local).AddTicks(3436), 4840.34m },
                    { new Guid("7d29e638-07d2-46de-a1b7-4499032d6eaa"), new Guid("ceeb839d-d443-4791-8018-561c89d6e7d9"), new DateTime(2023, 8, 11, 12, 0, 54, 598, DateTimeKind.Local).AddTicks(8801), new DateTime(2024, 8, 9, 6, 12, 3, 963, DateTimeKind.Local).AddTicks(4814), 3312.05m },
                    { new Guid("7de51ff8-4122-414a-95dc-a01896b1e569"), new Guid("920b6ceb-11fd-4534-8c78-0adccdc2cbf5"), new DateTime(2024, 6, 7, 3, 43, 45, 281, DateTimeKind.Local).AddTicks(5555), new DateTime(2024, 8, 8, 20, 58, 54, 155, DateTimeKind.Local).AddTicks(8195), 4886.19m },
                    { new Guid("7e56a150-c089-4cf2-b412-9bf4a9dfc973"), new Guid("4ebf8ce2-efc1-4c0d-8c61-7159ede74521"), new DateTime(2023, 8, 15, 19, 26, 1, 78, DateTimeKind.Local).AddTicks(1570), new DateTime(2024, 8, 7, 22, 22, 42, 824, DateTimeKind.Local).AddTicks(135), 3661.93m },
                    { new Guid("7e70be9a-4cc1-45e4-a949-55fe00303146"), new Guid("c93b2790-efbb-4887-bc62-908698026478"), new DateTime(2024, 4, 19, 9, 21, 20, 525, DateTimeKind.Local).AddTicks(9032), new DateTime(2024, 8, 8, 21, 15, 53, 371, DateTimeKind.Local).AddTicks(115), 4494.15m },
                    { new Guid("7e7b69a1-0bf6-4ddb-ab24-3058c547ac8e"), new Guid("15883dbe-e97e-4859-86f7-993bbc1173df"), new DateTime(2023, 11, 22, 1, 58, 24, 292, DateTimeKind.Local).AddTicks(2616), new DateTime(2024, 8, 9, 15, 11, 21, 53, DateTimeKind.Local).AddTicks(1147), 3753.74m },
                    { new Guid("7ed649a5-548e-41c5-8ecb-b366bbb58ae3"), new Guid("63021a65-455d-454a-92ee-525601ead4df"), new DateTime(2024, 4, 10, 6, 49, 10, 425, DateTimeKind.Local).AddTicks(2003), new DateTime(2024, 8, 8, 0, 15, 50, 786, DateTimeKind.Local).AddTicks(7298), 4575.69m },
                    { new Guid("7ef125d4-97ae-4ed4-a584-76e5d1ec7682"), new Guid("90ece793-c6f5-47e7-8aa0-7c08ff3548fb"), new DateTime(2023, 11, 26, 16, 48, 30, 680, DateTimeKind.Local).AddTicks(9935), new DateTime(2024, 8, 8, 19, 52, 46, 259, DateTimeKind.Local).AddTicks(1321), 2371.73m },
                    { new Guid("7efd0a1f-7fee-4895-9a93-9b58ff6dfaf8"), new Guid("fd9917bd-45e9-4bab-839f-7f5b5cbf03e7"), new DateTime(2023, 11, 22, 20, 58, 12, 240, DateTimeKind.Local).AddTicks(8234), new DateTime(2024, 8, 8, 5, 25, 20, 922, DateTimeKind.Local).AddTicks(9471), 995.24m },
                    { new Guid("7f03ed7c-064c-4bcc-924e-2cd550e195b7"), new Guid("75fe592b-5c1e-4814-a459-627bef01098f"), new DateTime(2023, 12, 21, 23, 18, 57, 415, DateTimeKind.Local).AddTicks(7148), new DateTime(2024, 8, 8, 7, 14, 27, 632, DateTimeKind.Local).AddTicks(6338), 2980.80m },
                    { new Guid("7f097584-aff8-4e35-b823-83ac20b6ce96"), new Guid("88888a0c-f1ed-4613-9646-ee6509dc5db0"), new DateTime(2023, 9, 2, 4, 15, 4, 690, DateTimeKind.Local).AddTicks(6777), new DateTime(2024, 8, 9, 17, 15, 39, 530, DateTimeKind.Local).AddTicks(6970), 4540.60m },
                    { new Guid("7f09a421-ca25-4a82-8b25-9006ec0c07ae"), new Guid("590c7122-bbd8-408c-9571-b8d385d97b9e"), new DateTime(2023, 11, 22, 8, 52, 50, 57, DateTimeKind.Local).AddTicks(5476), new DateTime(2024, 8, 7, 17, 23, 33, 803, DateTimeKind.Local).AddTicks(9526), 222.09m },
                    { new Guid("7f6ad61f-1a87-4cbe-8759-53a1a6d7b3c2"), new Guid("17652753-332f-4654-89d0-bbca6d67670f"), new DateTime(2024, 5, 25, 18, 4, 52, 705, DateTimeKind.Local).AddTicks(8260), new DateTime(2024, 8, 9, 15, 14, 50, 753, DateTimeKind.Local).AddTicks(815), 4431.28m },
                    { new Guid("80505423-0c43-4916-8c3f-5a5183396ce8"), new Guid("ceeb839d-d443-4791-8018-561c89d6e7d9"), new DateTime(2024, 7, 12, 17, 15, 6, 866, DateTimeKind.Local).AddTicks(4419), new DateTime(2024, 8, 8, 7, 40, 34, 967, DateTimeKind.Local).AddTicks(2936), 1349.90m },
                    { new Guid("805085cb-983d-44e9-8433-57ed5904954c"), new Guid("297e58cc-55d1-4c96-81c1-edd1b4b0ffb7"), new DateTime(2024, 3, 31, 2, 14, 49, 94, DateTimeKind.Local).AddTicks(151), new DateTime(2024, 8, 8, 17, 13, 15, 190, DateTimeKind.Local).AddTicks(9644), 2021.04m },
                    { new Guid("8062ed23-10bb-4a88-a0e3-991397cc4903"), new Guid("38ba8024-3b8d-4dd6-92b9-9d06da12ec6e"), new DateTime(2023, 8, 31, 4, 9, 15, 686, DateTimeKind.Local).AddTicks(5271), new DateTime(2024, 8, 7, 20, 59, 3, 922, DateTimeKind.Local).AddTicks(7427), 2165.46m },
                    { new Guid("8078bb2f-3909-4f75-b8d8-cb1319c42353"), new Guid("b4a06e76-1c1e-4cac-aaa1-572d7a607954"), new DateTime(2024, 6, 9, 2, 47, 7, 666, DateTimeKind.Local).AddTicks(594), new DateTime(2024, 8, 9, 3, 2, 35, 870, DateTimeKind.Local).AddTicks(6771), 3789.69m },
                    { new Guid("807a8484-6e1c-4c3e-8553-df92add765cd"), new Guid("93fb1f32-f25c-41b4-91a2-c22a92a4ab83"), new DateTime(2023, 8, 9, 11, 50, 35, 310, DateTimeKind.Local).AddTicks(8951), new DateTime(2024, 8, 9, 4, 20, 57, 772, DateTimeKind.Local).AddTicks(6481), 147.96m },
                    { new Guid("808bb87b-d497-4446-aee3-4bdb6421eaf1"), new Guid("1cab312c-e326-4c44-ae00-5542888dfbc9"), new DateTime(2023, 12, 1, 19, 25, 12, 569, DateTimeKind.Local).AddTicks(2235), new DateTime(2024, 8, 9, 3, 35, 11, 98, DateTimeKind.Local).AddTicks(5253), 4093.87m },
                    { new Guid("80be3385-d3f9-48bb-bfd9-4b82fd377c9f"), new Guid("886111c9-af92-447f-91bf-dad7b8a03eb5"), new DateTime(2023, 10, 26, 0, 55, 40, 332, DateTimeKind.Local).AddTicks(563), new DateTime(2024, 8, 7, 17, 5, 54, 559, DateTimeKind.Local).AddTicks(4429), 261.03m },
                    { new Guid("8100228e-7300-4afb-bd71-6b8c2ebb7a16"), new Guid("b78d1e60-56cf-4058-967c-7271f646af05"), new DateTime(2023, 9, 28, 19, 42, 17, 118, DateTimeKind.Local).AddTicks(4869), new DateTime(2024, 8, 7, 15, 25, 58, 860, DateTimeKind.Local).AddTicks(197), 574.23m },
                    { new Guid("81fa255d-b0b1-42ca-ba55-3219353682d0"), new Guid("f9a1bd2e-de1a-42b8-b894-7f7e0b5b38f1"), new DateTime(2024, 2, 6, 7, 15, 16, 115, DateTimeKind.Local).AddTicks(2700), new DateTime(2024, 8, 8, 7, 35, 46, 48, DateTimeKind.Local).AddTicks(8481), 1070.35m },
                    { new Guid("823645a9-d5b0-41ce-a2a9-8421366dfb78"), new Guid("2db3541e-b13b-4e4b-b634-f31e8982b5e1"), new DateTime(2023, 10, 1, 5, 44, 48, 451, DateTimeKind.Local).AddTicks(6929), new DateTime(2024, 8, 7, 3, 49, 19, 80, DateTimeKind.Local).AddTicks(3038), 2150.98m },
                    { new Guid("829856c1-9d5c-4a54-96ec-4f56c0c7824c"), new Guid("d5d71173-e817-45f8-9146-4b7ab7c7b686"), new DateTime(2024, 5, 5, 8, 42, 14, 716, DateTimeKind.Local).AddTicks(1182), new DateTime(2024, 8, 9, 11, 42, 49, 566, DateTimeKind.Local).AddTicks(1020), 2247.38m },
                    { new Guid("82a4544d-a2c1-4617-ba45-4e379e90bb47"), new Guid("6b4bca52-0cf9-4a9e-98cf-0eb6e3c24da0"), new DateTime(2023, 12, 2, 22, 37, 17, 854, DateTimeKind.Local).AddTicks(8156), new DateTime(2024, 8, 6, 22, 9, 42, 823, DateTimeKind.Local).AddTicks(6024), 1928.33m },
                    { new Guid("82b13db1-1d75-492a-b491-38b775435a55"), new Guid("2463d0a4-5008-43f5-97fd-bbd3d0048d8e"), new DateTime(2023, 8, 18, 0, 35, 21, 924, DateTimeKind.Local).AddTicks(6952), new DateTime(2024, 8, 8, 0, 41, 18, 43, DateTimeKind.Local).AddTicks(3804), 3993.76m },
                    { new Guid("82bc602a-fb94-4fb2-9bdb-a127bb82e8e5"), new Guid("6e20d02e-a4a6-4614-83ac-f23bb4548158"), new DateTime(2024, 5, 22, 16, 27, 52, 973, DateTimeKind.Local).AddTicks(9374), new DateTime(2024, 8, 7, 10, 31, 2, 393, DateTimeKind.Local).AddTicks(8163), 4951.70m },
                    { new Guid("82e8c42c-77d3-4d64-b009-9d3dc70f2e7b"), new Guid("75fe592b-5c1e-4814-a459-627bef01098f"), new DateTime(2023, 9, 15, 10, 30, 22, 808, DateTimeKind.Local).AddTicks(1505), new DateTime(2024, 8, 6, 23, 55, 21, 29, DateTimeKind.Local).AddTicks(5151), 4693.27m },
                    { new Guid("83a9e4c7-66fa-4244-8de7-491bc926d68c"), new Guid("893b3fb0-9647-4958-b835-676e382779e7"), new DateTime(2023, 9, 14, 3, 27, 43, 944, DateTimeKind.Local).AddTicks(9876), new DateTime(2024, 8, 9, 1, 54, 56, 960, DateTimeKind.Local).AddTicks(4941), 3084.03m },
                    { new Guid("845ef0f7-2f94-42c3-b9d7-a0c258456d3d"), new Guid("fafc2111-6b48-4585-8074-65bb860d42ae"), new DateTime(2024, 2, 4, 13, 27, 1, 517, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 8, 8, 20, 34, 39, 296, DateTimeKind.Local).AddTicks(92), 1473.54m },
                    { new Guid("84bf634c-03a2-4611-9bef-798d7d74cfda"), new Guid("4ebf8ce2-efc1-4c0d-8c61-7159ede74521"), new DateTime(2023, 10, 19, 17, 58, 37, 408, DateTimeKind.Local).AddTicks(2542), new DateTime(2024, 8, 9, 5, 12, 50, 275, DateTimeKind.Local).AddTicks(3009), 4865.13m },
                    { new Guid("84c34166-42bc-40f8-bcee-b42075355ffd"), new Guid("7395222e-7744-4172-86d1-1b128230fabf"), new DateTime(2024, 2, 18, 11, 16, 57, 401, DateTimeKind.Local).AddTicks(8234), new DateTime(2024, 8, 7, 6, 17, 39, 322, DateTimeKind.Local).AddTicks(4558), 1485.61m },
                    { new Guid("854d7c97-1bbe-4ece-b68c-bc0a2e6c616e"), new Guid("4ebf8ce2-efc1-4c0d-8c61-7159ede74521"), new DateTime(2024, 8, 3, 3, 24, 49, 671, DateTimeKind.Local).AddTicks(4529), new DateTime(2024, 8, 8, 18, 57, 29, 476, DateTimeKind.Local).AddTicks(5452), 394.40m },
                    { new Guid("855491b4-2e2c-4fc7-ba98-ba40ee0e1a3e"), new Guid("38ba8024-3b8d-4dd6-92b9-9d06da12ec6e"), new DateTime(2024, 5, 20, 3, 59, 44, 7, DateTimeKind.Local).AddTicks(3036), new DateTime(2024, 8, 9, 8, 49, 16, 949, DateTimeKind.Local).AddTicks(2751), 494.48m }
                });

            migrationBuilder.InsertData(
                table: "DonHangs",
                columns: new[] { "Id", "KhachHangId", "NgayDatHang", "NgayGiaoHang", "TongTien" },
                values: new object[,]
                {
                    { new Guid("8593ca4f-829b-471f-8c99-2d9b306b1e65"), new Guid("1248d1fb-1e80-4ded-926b-6b7f6d2249a5"), new DateTime(2024, 1, 29, 11, 45, 9, 430, DateTimeKind.Local).AddTicks(3527), new DateTime(2024, 8, 9, 13, 31, 53, 436, DateTimeKind.Local).AddTicks(3371), 4218.10m },
                    { new Guid("85ede508-438c-4424-8f73-ad9833d55f90"), new Guid("a38bfc8c-feac-4053-b76e-84c4e66d74d6"), new DateTime(2024, 4, 18, 7, 37, 19, 216, DateTimeKind.Local).AddTicks(2663), new DateTime(2024, 8, 9, 17, 15, 42, 961, DateTimeKind.Local).AddTicks(1081), 4803.52m },
                    { new Guid("865cb045-3fa7-45d0-a563-470f12799a3d"), new Guid("5bc8e452-e383-427e-bc9b-c26642f1a642"), new DateTime(2024, 3, 22, 7, 22, 22, 337, DateTimeKind.Local).AddTicks(1597), new DateTime(2024, 8, 9, 15, 17, 7, 299, DateTimeKind.Local).AddTicks(9245), 4482.58m },
                    { new Guid("867b140c-fa4f-4df7-bf32-6d166764fe74"), new Guid("7b94208a-340f-4ed0-ad44-07a96fbc7d7a"), new DateTime(2024, 6, 27, 7, 47, 46, 937, DateTimeKind.Local).AddTicks(6960), new DateTime(2024, 8, 8, 4, 17, 19, 504, DateTimeKind.Local).AddTicks(8041), 4423.83m },
                    { new Guid("869b3738-0318-4962-91c3-119efbb3c00e"), new Guid("f9a1bd2e-de1a-42b8-b894-7f7e0b5b38f1"), new DateTime(2023, 11, 8, 4, 26, 56, 973, DateTimeKind.Local).AddTicks(6880), new DateTime(2024, 8, 8, 10, 14, 31, 413, DateTimeKind.Local).AddTicks(7441), 2571.75m },
                    { new Guid("86ac90dc-8093-4d9e-95ca-d29bcd271441"), new Guid("9f2dcec6-cc02-45d6-95d0-fa0b53a5f953"), new DateTime(2024, 8, 2, 18, 15, 26, 793, DateTimeKind.Local).AddTicks(1425), new DateTime(2024, 8, 7, 7, 15, 30, 693, DateTimeKind.Local).AddTicks(6630), 1795.48m },
                    { new Guid("86b4615c-b308-4bfe-8f8d-c053722064f1"), new Guid("920b6ceb-11fd-4534-8c78-0adccdc2cbf5"), new DateTime(2023, 11, 1, 15, 52, 37, 929, DateTimeKind.Local).AddTicks(8426), new DateTime(2024, 8, 9, 14, 5, 5, 480, DateTimeKind.Local).AddTicks(5834), 1365.08m },
                    { new Guid("86c981fa-5d8f-4f14-b02a-d99bb5ff092f"), new Guid("5e4be06c-1976-4755-aeb0-28dae4b4298b"), new DateTime(2023, 9, 18, 23, 3, 11, 366, DateTimeKind.Local).AddTicks(7303), new DateTime(2024, 8, 8, 13, 41, 40, 302, DateTimeKind.Local).AddTicks(9755), 3486.77m },
                    { new Guid("86e22027-2775-40a9-afb5-2ddd99c479b5"), new Guid("427269be-9018-4cf4-9818-4fae14114ae4"), new DateTime(2023, 12, 12, 9, 40, 52, 107, DateTimeKind.Local).AddTicks(1461), new DateTime(2024, 8, 8, 11, 19, 47, 721, DateTimeKind.Local).AddTicks(8999), 3402.88m },
                    { new Guid("870a7125-c682-4c8c-a35a-ad73db267fba"), new Guid("2db3541e-b13b-4e4b-b634-f31e8982b5e1"), new DateTime(2023, 11, 22, 4, 16, 22, 589, DateTimeKind.Local).AddTicks(763), new DateTime(2024, 8, 8, 5, 31, 2, 938, DateTimeKind.Local).AddTicks(597), 1805.78m },
                    { new Guid("872df891-936f-4c2f-93d2-609bd02b199f"), new Guid("1e3c140e-4cab-4065-aadd-2c1cfed5ce14"), new DateTime(2024, 2, 18, 16, 8, 39, 724, DateTimeKind.Local).AddTicks(3268), new DateTime(2024, 8, 9, 3, 28, 4, 50, DateTimeKind.Local).AddTicks(9203), 369.06m },
                    { new Guid("879e3376-bc97-4b60-a6cd-e8d84b9a770e"), new Guid("e56e8c86-41ee-47fd-9d05-a94a167bed10"), new DateTime(2024, 1, 28, 7, 14, 4, 183, DateTimeKind.Local).AddTicks(4740), new DateTime(2024, 8, 9, 2, 43, 24, 582, DateTimeKind.Local).AddTicks(3886), 3578.39m },
                    { new Guid("87eeca18-2a63-4077-904f-a9509f7781d7"), new Guid("0b23e0d1-fa5b-4022-92b8-ff158e6d60ed"), new DateTime(2024, 1, 10, 15, 6, 12, 579, DateTimeKind.Local).AddTicks(9681), new DateTime(2024, 8, 9, 2, 43, 19, 226, DateTimeKind.Local).AddTicks(2165), 2675.64m },
                    { new Guid("882c0f80-6bf3-4774-9fa1-6290431fed9b"), new Guid("2463d0a4-5008-43f5-97fd-bbd3d0048d8e"), new DateTime(2023, 11, 4, 2, 17, 28, 199, DateTimeKind.Local).AddTicks(5731), new DateTime(2024, 8, 7, 6, 19, 23, 449, DateTimeKind.Local).AddTicks(7712), 928.72m },
                    { new Guid("8843e9d5-636d-464d-bede-44bf178ad5f9"), new Guid("eb503b18-f1e1-4a47-8871-99a4746eb8c6"), new DateTime(2023, 10, 27, 11, 23, 47, 347, DateTimeKind.Local).AddTicks(4883), new DateTime(2024, 8, 8, 10, 55, 11, 744, DateTimeKind.Local).AddTicks(6596), 4593.05m },
                    { new Guid("88e18de0-ec02-4605-abda-1fb6b3bddbbc"), new Guid("45859554-61d6-4f50-90eb-b40d19a17909"), new DateTime(2024, 7, 17, 7, 19, 49, 395, DateTimeKind.Local).AddTicks(9259), new DateTime(2024, 8, 7, 15, 57, 5, 128, DateTimeKind.Local).AddTicks(8597), 203.20m },
                    { new Guid("892720fa-a9c8-4dbf-877a-7da8a9bd1fd3"), new Guid("eb503b18-f1e1-4a47-8871-99a4746eb8c6"), new DateTime(2023, 12, 27, 5, 55, 33, 90, DateTimeKind.Local).AddTicks(7850), new DateTime(2024, 8, 9, 13, 33, 5, 762, DateTimeKind.Local).AddTicks(8690), 2162.16m },
                    { new Guid("89831e16-4bd6-4e31-9862-95b43979c821"), new Guid("920b6ceb-11fd-4534-8c78-0adccdc2cbf5"), new DateTime(2024, 5, 12, 0, 29, 35, 575, DateTimeKind.Local).AddTicks(2549), new DateTime(2024, 8, 8, 9, 23, 47, 978, DateTimeKind.Local).AddTicks(5991), 4774.40m },
                    { new Guid("89b0a759-b141-4891-b976-db784d0aa52a"), new Guid("920b6ceb-11fd-4534-8c78-0adccdc2cbf5"), new DateTime(2023, 11, 5, 16, 2, 37, 252, DateTimeKind.Local).AddTicks(8223), new DateTime(2024, 8, 7, 0, 36, 37, 922, DateTimeKind.Local).AddTicks(8017), 2382.07m },
                    { new Guid("89b7893f-c3fe-438a-b62f-8b12db7b90c9"), new Guid("22ebc934-105f-4b38-ab74-feae23d1ffc0"), new DateTime(2024, 6, 9, 15, 37, 1, 659, DateTimeKind.Local).AddTicks(1532), new DateTime(2024, 8, 7, 12, 57, 58, 696, DateTimeKind.Local).AddTicks(1722), 4326.33m },
                    { new Guid("89bc6b65-4403-4cc9-aa3d-06fe84b5d20e"), new Guid("9e65dc79-3d73-4629-8551-a5f2b9cfe2a4"), new DateTime(2024, 1, 13, 9, 3, 45, 90, DateTimeKind.Local).AddTicks(8484), new DateTime(2024, 8, 9, 6, 42, 45, 901, DateTimeKind.Local).AddTicks(1775), 4473.95m },
                    { new Guid("8a0af168-e9c0-4da3-a9b8-6606f69d788f"), new Guid("3fd74fb4-2450-440d-8497-d9a630f57199"), new DateTime(2024, 6, 18, 5, 21, 24, 591, DateTimeKind.Local).AddTicks(546), new DateTime(2024, 8, 8, 7, 30, 41, 499, DateTimeKind.Local).AddTicks(7579), 1602.79m },
                    { new Guid("8a310a6b-c269-4c86-9093-2728b981f0da"), new Guid("0b23e0d1-fa5b-4022-92b8-ff158e6d60ed"), new DateTime(2024, 5, 15, 3, 13, 23, 153, DateTimeKind.Local).AddTicks(8716), new DateTime(2024, 8, 7, 21, 17, 38, 313, DateTimeKind.Local).AddTicks(6011), 222.48m },
                    { new Guid("8a32cd9f-9c15-44f6-97ee-42ea21305227"), new Guid("8bc08888-8550-4e72-9b5e-71845b5b9567"), new DateTime(2024, 2, 23, 13, 37, 58, 589, DateTimeKind.Local).AddTicks(485), new DateTime(2024, 8, 8, 6, 15, 2, 897, DateTimeKind.Local).AddTicks(6304), 2257.41m },
                    { new Guid("8a5501b5-54c2-4c88-9899-6debf83c78cd"), new Guid("5bc8e452-e383-427e-bc9b-c26642f1a642"), new DateTime(2023, 9, 11, 0, 34, 36, 514, DateTimeKind.Local).AddTicks(4858), new DateTime(2024, 8, 9, 13, 37, 10, 537, DateTimeKind.Local).AddTicks(2750), 4151.33m },
                    { new Guid("8ad58a27-5105-4363-af5c-49ed75895a1e"), new Guid("1248d1fb-1e80-4ded-926b-6b7f6d2249a5"), new DateTime(2024, 7, 19, 15, 42, 7, 516, DateTimeKind.Local).AddTicks(8561), new DateTime(2024, 8, 8, 10, 32, 8, 930, DateTimeKind.Local).AddTicks(5823), 4923.89m },
                    { new Guid("8b3cf28f-f973-4224-9f40-36135ffa60cd"), new Guid("90fb9bfe-da70-4392-9904-4417fab257a7"), new DateTime(2024, 2, 7, 5, 21, 17, 381, DateTimeKind.Local).AddTicks(8736), new DateTime(2024, 8, 9, 1, 3, 3, 404, DateTimeKind.Local).AddTicks(9445), 418.33m },
                    { new Guid("8b61afe6-2461-4816-9441-51cff27275d3"), new Guid("873734f8-2118-4bff-95ec-9e199770cefb"), new DateTime(2024, 5, 21, 3, 25, 50, 582, DateTimeKind.Local).AddTicks(9175), new DateTime(2024, 8, 9, 6, 58, 16, 427, DateTimeKind.Local).AddTicks(1789), 3682.16m },
                    { new Guid("8b6b96c8-a4de-449d-894e-e15a0aaafc22"), new Guid("a99891d8-254d-4ec7-8cae-cf3bcb8c10a1"), new DateTime(2024, 3, 27, 18, 44, 36, 100, DateTimeKind.Local).AddTicks(5322), new DateTime(2024, 8, 8, 14, 0, 23, 95, DateTimeKind.Local).AddTicks(2963), 660.59m },
                    { new Guid("8bc7d59c-df3b-46f6-9258-43bc3e375a8b"), new Guid("9f2dcec6-cc02-45d6-95d0-fa0b53a5f953"), new DateTime(2024, 5, 18, 16, 41, 52, 262, DateTimeKind.Local).AddTicks(4172), new DateTime(2024, 8, 8, 6, 13, 23, 389, DateTimeKind.Local).AddTicks(7496), 791.19m },
                    { new Guid("8c4bcbfc-ffe2-429d-934d-54ae410a825a"), new Guid("3fd74fb4-2450-440d-8497-d9a630f57199"), new DateTime(2023, 8, 8, 23, 49, 14, 744, DateTimeKind.Local).AddTicks(1590), new DateTime(2024, 8, 8, 13, 14, 35, 86, DateTimeKind.Local).AddTicks(4924), 4441.76m },
                    { new Guid("8c5e5e10-db8e-4509-990f-1d6165e97eb9"), new Guid("6f2bc11e-7dd7-4049-9e35-163927214820"), new DateTime(2024, 4, 13, 13, 33, 54, 70, DateTimeKind.Local).AddTicks(9967), new DateTime(2024, 8, 9, 0, 8, 55, 116, DateTimeKind.Local).AddTicks(4421), 647.36m },
                    { new Guid("8c6bf3aa-355f-4ab8-94de-a48befe76387"), new Guid("648119d0-d486-40c5-bd23-69a5e42b2ba5"), new DateTime(2024, 1, 22, 5, 22, 56, 345, DateTimeKind.Local).AddTicks(4571), new DateTime(2024, 8, 9, 7, 12, 13, 657, DateTimeKind.Local).AddTicks(4336), 55.17m },
                    { new Guid("8c89dd3d-7e5b-4549-a590-b343a370c458"), new Guid("5bc8e452-e383-427e-bc9b-c26642f1a642"), new DateTime(2023, 12, 15, 19, 56, 1, 432, DateTimeKind.Local).AddTicks(9134), new DateTime(2024, 8, 8, 0, 8, 16, 667, DateTimeKind.Local).AddTicks(4425), 4986.40m },
                    { new Guid("8d100c2d-395d-4f43-9dc8-64519be93907"), new Guid("232fdc99-53fe-4232-9c74-06ddfb2a13b8"), new DateTime(2024, 3, 13, 22, 32, 20, 2, DateTimeKind.Local).AddTicks(5405), new DateTime(2024, 8, 9, 6, 53, 10, 740, DateTimeKind.Local).AddTicks(8322), 3642.38m },
                    { new Guid("8d8555a9-6447-4ef9-be06-0263d42aa2d4"), new Guid("cba2380d-ac66-4bca-9da1-3db07a53966f"), new DateTime(2023, 11, 12, 11, 53, 44, 267, DateTimeKind.Local).AddTicks(445), new DateTime(2024, 8, 8, 3, 17, 30, 673, DateTimeKind.Local).AddTicks(6361), 4114.81m },
                    { new Guid("8e1380cc-7404-4d54-a659-e961a2c72a83"), new Guid("9e65dc79-3d73-4629-8551-a5f2b9cfe2a4"), new DateTime(2023, 10, 27, 5, 9, 17, 305, DateTimeKind.Local).AddTicks(1377), new DateTime(2024, 8, 8, 0, 45, 51, 161, DateTimeKind.Local).AddTicks(2464), 3932.99m },
                    { new Guid("8eee5578-f9bc-4d4f-a950-6ecf648a22ba"), new Guid("6212ef8f-9777-42a2-ad28-a2ed1ebe90f8"), new DateTime(2024, 1, 23, 1, 42, 51, 21, DateTimeKind.Local).AddTicks(9027), new DateTime(2024, 8, 8, 12, 4, 37, 491, DateTimeKind.Local).AddTicks(2104), 1747.25m },
                    { new Guid("8ef3c230-24bb-4fe0-b37c-b149f3273982"), new Guid("6b4bca52-0cf9-4a9e-98cf-0eb6e3c24da0"), new DateTime(2024, 7, 22, 15, 10, 9, 161, DateTimeKind.Local).AddTicks(3241), new DateTime(2024, 8, 9, 2, 38, 52, 525, DateTimeKind.Local).AddTicks(2959), 3258.00m },
                    { new Guid("8f1bce3f-b827-4597-82fb-e72ed0a4ac40"), new Guid("46685f7f-ca60-41b6-8cfb-4124c89cd625"), new DateTime(2024, 1, 26, 13, 13, 57, 360, DateTimeKind.Local).AddTicks(8511), new DateTime(2024, 8, 7, 16, 16, 19, 940, DateTimeKind.Local).AddTicks(9472), 1399.53m },
                    { new Guid("8fddde56-6d1c-40d1-97fb-ddb3b3ea397a"), new Guid("5f3cfe10-1a7a-45c2-8fcb-c7e90692dbc4"), new DateTime(2024, 1, 29, 1, 8, 19, 86, DateTimeKind.Local).AddTicks(7994), new DateTime(2024, 8, 8, 0, 42, 37, 938, DateTimeKind.Local).AddTicks(6060), 334.64m },
                    { new Guid("8fffc6ff-5d5b-4bac-a4aa-be934c1eb021"), new Guid("1e3c140e-4cab-4065-aadd-2c1cfed5ce14"), new DateTime(2023, 12, 13, 4, 50, 49, 770, DateTimeKind.Local).AddTicks(2330), new DateTime(2024, 8, 7, 9, 25, 52, 933, DateTimeKind.Local).AddTicks(2429), 2875.77m }
                });

            migrationBuilder.InsertData(
                table: "DonHangs",
                columns: new[] { "Id", "KhachHangId", "NgayDatHang", "NgayGiaoHang", "TongTien" },
                values: new object[,]
                {
                    { new Guid("90083cb7-72bb-418f-b31b-2da263d6d476"), new Guid("9865321a-433a-4caa-8050-884b34c7c8d8"), new DateTime(2024, 2, 21, 3, 29, 6, 256, DateTimeKind.Local).AddTicks(253), new DateTime(2024, 8, 8, 19, 40, 7, 223, DateTimeKind.Local).AddTicks(7475), 382.62m },
                    { new Guid("901a5af4-1920-4e63-b332-6dd257ffce33"), new Guid("fd9917bd-45e9-4bab-839f-7f5b5cbf03e7"), new DateTime(2024, 3, 30, 20, 42, 27, 793, DateTimeKind.Local).AddTicks(6964), new DateTime(2024, 8, 9, 2, 35, 46, 41, DateTimeKind.Local).AddTicks(5054), 348.34m },
                    { new Guid("901ccfa0-60d5-4e34-9dad-40fcfc984dbc"), new Guid("fafc2111-6b48-4585-8074-65bb860d42ae"), new DateTime(2023, 9, 8, 15, 7, 40, 928, DateTimeKind.Local).AddTicks(3817), new DateTime(2024, 8, 8, 15, 25, 24, 754, DateTimeKind.Local).AddTicks(1137), 2853.22m },
                    { new Guid("9090efe6-7d1d-4bfa-9705-dd55211472e5"), new Guid("5e4be06c-1976-4755-aeb0-28dae4b4298b"), new DateTime(2024, 7, 29, 2, 44, 47, 648, DateTimeKind.Local).AddTicks(4294), new DateTime(2024, 8, 8, 7, 54, 3, 693, DateTimeKind.Local).AddTicks(4694), 3976.83m },
                    { new Guid("90e3f837-bc8b-4623-88b6-941d1f17a244"), new Guid("6e20d02e-a4a6-4614-83ac-f23bb4548158"), new DateTime(2024, 1, 17, 15, 33, 4, 263, DateTimeKind.Local).AddTicks(8315), new DateTime(2024, 8, 7, 7, 13, 17, 663, DateTimeKind.Local).AddTicks(1532), 798.55m },
                    { new Guid("91f3e551-d8ac-4093-8a64-3c5a47c42cb2"), new Guid("e9d684aa-183f-423f-8741-1a53cfb8f2e3"), new DateTime(2024, 4, 22, 7, 44, 50, 822, DateTimeKind.Local).AddTicks(6035), new DateTime(2024, 8, 7, 13, 31, 7, 325, DateTimeKind.Local).AddTicks(6467), 2976.52m },
                    { new Guid("9229b103-4c9f-40e3-88eb-b51873c861e8"), new Guid("88888a0c-f1ed-4613-9646-ee6509dc5db0"), new DateTime(2023, 9, 21, 15, 44, 24, 2, DateTimeKind.Local).AddTicks(5658), new DateTime(2024, 8, 7, 9, 40, 1, 397, DateTimeKind.Local).AddTicks(7972), 3714.22m },
                    { new Guid("9270fb2f-ec98-4096-9f0f-41f596bd096e"), new Guid("15883dbe-e97e-4859-86f7-993bbc1173df"), new DateTime(2024, 4, 1, 11, 35, 40, 567, DateTimeKind.Local).AddTicks(3473), new DateTime(2024, 8, 7, 11, 36, 49, 732, DateTimeKind.Local).AddTicks(5021), 1644.73m },
                    { new Guid("9273c380-bae8-4fae-ab90-f68d79fc2f72"), new Guid("d15c8331-36ed-417a-b1fa-5f377c4c9930"), new DateTime(2023, 9, 16, 17, 7, 37, 303, DateTimeKind.Local).AddTicks(8128), new DateTime(2024, 8, 7, 23, 7, 58, 319, DateTimeKind.Local).AddTicks(8096), 2207.32m },
                    { new Guid("927dd2dd-a04b-4c0f-b243-495158507c21"), new Guid("297e58cc-55d1-4c96-81c1-edd1b4b0ffb7"), new DateTime(2024, 5, 10, 15, 43, 42, 190, DateTimeKind.Local).AddTicks(5416), new DateTime(2024, 8, 8, 20, 16, 4, 408, DateTimeKind.Local).AddTicks(9192), 4545.40m },
                    { new Guid("929ce712-f883-4acb-8e00-78df84dc85b5"), new Guid("17652753-332f-4654-89d0-bbca6d67670f"), new DateTime(2023, 8, 12, 23, 34, 24, 45, DateTimeKind.Local).AddTicks(8607), new DateTime(2024, 8, 9, 7, 37, 27, 387, DateTimeKind.Local).AddTicks(9760), 3681.04m },
                    { new Guid("92d53f53-c809-4101-a912-faf47ae8039a"), new Guid("eb503b18-f1e1-4a47-8871-99a4746eb8c6"), new DateTime(2023, 11, 25, 0, 3, 36, 833, DateTimeKind.Local).AddTicks(3206), new DateTime(2024, 8, 9, 13, 6, 23, 898, DateTimeKind.Local).AddTicks(2443), 3260.49m },
                    { new Guid("92ec38b1-34a8-4a96-ad23-4891f48b9a37"), new Guid("93fb1f32-f25c-41b4-91a2-c22a92a4ab83"), new DateTime(2024, 2, 20, 10, 55, 11, 128, DateTimeKind.Local).AddTicks(1245), new DateTime(2024, 8, 7, 16, 9, 59, 244, DateTimeKind.Local).AddTicks(5632), 3210.91m },
                    { new Guid("935b6ea0-9441-42a8-afb8-231985b5ba16"), new Guid("46685f7f-ca60-41b6-8cfb-4124c89cd625"), new DateTime(2024, 3, 18, 18, 38, 37, 332, DateTimeKind.Local).AddTicks(3743), new DateTime(2024, 8, 7, 7, 31, 5, 330, DateTimeKind.Local).AddTicks(6462), 3292.57m },
                    { new Guid("9372fbe2-c633-423e-b7f0-9d9f2207b88d"), new Guid("90fb9bfe-da70-4392-9904-4417fab257a7"), new DateTime(2023, 11, 2, 9, 9, 14, 405, DateTimeKind.Local).AddTicks(4430), new DateTime(2024, 8, 8, 4, 15, 33, 450, DateTimeKind.Local).AddTicks(8140), 1530.46m },
                    { new Guid("938eaecb-8b77-48c8-8a2d-7765c556bdda"), new Guid("6b4bca52-0cf9-4a9e-98cf-0eb6e3c24da0"), new DateTime(2024, 3, 14, 14, 22, 40, 732, DateTimeKind.Local).AddTicks(2634), new DateTime(2024, 8, 9, 20, 41, 40, 821, DateTimeKind.Local).AddTicks(4908), 632.69m },
                    { new Guid("9442a6e4-0900-4cf2-a24a-723165602f7f"), new Guid("b41438f5-9380-4cd7-bc4d-59267b9b760c"), new DateTime(2024, 5, 1, 15, 30, 29, 972, DateTimeKind.Local).AddTicks(6357), new DateTime(2024, 8, 8, 18, 5, 40, 472, DateTimeKind.Local).AddTicks(8078), 346.79m },
                    { new Guid("9450caca-75a3-4656-8633-9b4a3ecb2f29"), new Guid("d6d20276-ac8b-44d6-9939-d642e6335c51"), new DateTime(2024, 4, 27, 9, 20, 23, 155, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 8, 7, 21, 14, 18, 72, DateTimeKind.Local).AddTicks(7589), 231.83m },
                    { new Guid("946fb935-b12a-4614-8d8b-6270f73f74eb"), new Guid("a38bfc8c-feac-4053-b76e-84c4e66d74d6"), new DateTime(2024, 5, 9, 18, 3, 26, 989, DateTimeKind.Local).AddTicks(1958), new DateTime(2024, 8, 7, 18, 57, 19, 994, DateTimeKind.Local).AddTicks(6900), 1242.21m },
                    { new Guid("9485a521-cf4f-42ba-b6aa-8600cfa4f408"), new Guid("b0074e79-8782-48c2-b497-9ae7bd24e960"), new DateTime(2024, 7, 14, 16, 6, 9, 400, DateTimeKind.Local).AddTicks(9494), new DateTime(2024, 8, 8, 21, 32, 29, 365, DateTimeKind.Local).AddTicks(5358), 4288.13m },
                    { new Guid("94928cf6-b449-454d-9923-28d0393bbc59"), new Guid("3cd8e5f4-df7e-4a22-84a3-04966bad5197"), new DateTime(2023, 11, 23, 16, 16, 3, 75, DateTimeKind.Local).AddTicks(9348), new DateTime(2024, 8, 9, 9, 49, 5, 81, DateTimeKind.Local).AddTicks(9722), 2567.10m },
                    { new Guid("94fc0658-19a8-4bf4-853d-fa0d95ded9a1"), new Guid("a99891d8-254d-4ec7-8cae-cf3bcb8c10a1"), new DateTime(2024, 5, 31, 15, 49, 52, 377, DateTimeKind.Local).AddTicks(9837), new DateTime(2024, 8, 7, 0, 20, 51, 216, DateTimeKind.Local).AddTicks(4759), 3748.20m },
                    { new Guid("950ed818-8a5e-4d8b-8c7f-f7099e52209d"), new Guid("4ebf8ce2-efc1-4c0d-8c61-7159ede74521"), new DateTime(2023, 9, 21, 14, 0, 28, 806, DateTimeKind.Local).AddTicks(6421), new DateTime(2024, 8, 8, 4, 55, 39, 762, DateTimeKind.Local).AddTicks(9199), 2292.66m },
                    { new Guid("957b57d0-9fdc-4056-be76-49cf6b4698cf"), new Guid("b4a06e76-1c1e-4cac-aaa1-572d7a607954"), new DateTime(2023, 11, 3, 23, 11, 28, 46, DateTimeKind.Local).AddTicks(1054), new DateTime(2024, 8, 8, 12, 2, 59, 222, DateTimeKind.Local).AddTicks(9480), 3385.91m },
                    { new Guid("961d145d-6f9b-40dc-8c4f-a72e59447f2c"), new Guid("ec92935c-29c1-47d3-9ff2-3aed6a0974f2"), new DateTime(2024, 4, 5, 1, 35, 13, 419, DateTimeKind.Local).AddTicks(6202), new DateTime(2024, 8, 8, 3, 9, 40, 457, DateTimeKind.Local).AddTicks(2905), 4494.18m },
                    { new Guid("9681acd1-572c-4614-8c65-ccf1baca6d66"), new Guid("75fe592b-5c1e-4814-a459-627bef01098f"), new DateTime(2024, 2, 29, 23, 54, 30, 856, DateTimeKind.Local).AddTicks(7092), new DateTime(2024, 8, 7, 16, 7, 19, 251, DateTimeKind.Local).AddTicks(994), 1756.55m },
                    { new Guid("96d88234-2bb8-4b06-b972-9c85b43f6c53"), new Guid("75fe592b-5c1e-4814-a459-627bef01098f"), new DateTime(2023, 12, 9, 0, 19, 16, 620, DateTimeKind.Local).AddTicks(3514), new DateTime(2024, 8, 7, 6, 17, 11, 928, DateTimeKind.Local).AddTicks(6737), 2878.75m },
                    { new Guid("96e81d37-a074-4d66-b241-e112f1b6b86b"), new Guid("232fdc99-53fe-4232-9c74-06ddfb2a13b8"), new DateTime(2024, 1, 5, 6, 16, 6, 180, DateTimeKind.Local).AddTicks(9391), new DateTime(2024, 8, 7, 15, 14, 47, 613, DateTimeKind.Local).AddTicks(7079), 655.17m },
                    { new Guid("9713ec79-8a51-4d1b-99e2-9b6105ca8d6c"), new Guid("648119d0-d486-40c5-bd23-69a5e42b2ba5"), new DateTime(2023, 11, 5, 11, 33, 23, 420, DateTimeKind.Local).AddTicks(8377), new DateTime(2024, 8, 9, 21, 7, 30, 256, DateTimeKind.Local).AddTicks(3513), 4523.39m },
                    { new Guid("971928bb-7fb6-4446-a06c-359869561371"), new Guid("841db90c-5f81-482a-a955-f91fc637a7f7"), new DateTime(2024, 5, 31, 11, 14, 24, 942, DateTimeKind.Local).AddTicks(469), new DateTime(2024, 8, 7, 14, 49, 21, 283, DateTimeKind.Local).AddTicks(9438), 3315.13m },
                    { new Guid("9744e1e6-fb09-42be-afe9-841dbe9f34bc"), new Guid("d15c8331-36ed-417a-b1fa-5f377c4c9930"), new DateTime(2024, 5, 4, 1, 34, 22, 265, DateTimeKind.Local).AddTicks(3033), new DateTime(2024, 8, 8, 3, 33, 38, 711, DateTimeKind.Local).AddTicks(940), 2186.53m },
                    { new Guid("974b57b7-cd20-4516-8871-6586d98d4bda"), new Guid("ec92935c-29c1-47d3-9ff2-3aed6a0974f2"), new DateTime(2024, 5, 7, 12, 32, 8, 80, DateTimeKind.Local).AddTicks(2795), new DateTime(2024, 8, 9, 11, 17, 31, 628, DateTimeKind.Local).AddTicks(7087), 1337.44m },
                    { new Guid("9750fdbd-63e4-4cdc-b2e7-3f3d6b8c06a0"), new Guid("e56e8c86-41ee-47fd-9d05-a94a167bed10"), new DateTime(2023, 8, 22, 13, 46, 1, 947, DateTimeKind.Local).AddTicks(5331), new DateTime(2024, 8, 9, 11, 13, 36, 414, DateTimeKind.Local).AddTicks(4433), 766.94m },
                    { new Guid("97639a8e-3246-43ea-af03-5df0a3ff4e10"), new Guid("6e20d02e-a4a6-4614-83ac-f23bb4548158"), new DateTime(2023, 9, 17, 9, 33, 55, 51, DateTimeKind.Local).AddTicks(3605), new DateTime(2024, 8, 8, 9, 38, 19, 938, DateTimeKind.Local).AddTicks(5527), 492.36m },
                    { new Guid("978bcf74-6346-4802-8fac-237ef79b5189"), new Guid("0bd930d6-b736-4558-87c1-50bd97e08db0"), new DateTime(2024, 5, 30, 12, 22, 39, 640, DateTimeKind.Local).AddTicks(5912), new DateTime(2024, 8, 6, 23, 12, 9, 18, DateTimeKind.Local).AddTicks(5717), 3121.63m },
                    { new Guid("97ba8a5b-5dbd-447f-bdc5-67050be12732"), new Guid("6f10d3da-6328-4453-bd18-d299e75dca49"), new DateTime(2023, 10, 28, 4, 55, 13, 611, DateTimeKind.Local).AddTicks(7383), new DateTime(2024, 8, 8, 11, 24, 12, 462, DateTimeKind.Local).AddTicks(8662), 4740.04m },
                    { new Guid("97d34b93-8f8c-4a9f-a0fb-757bea571159"), new Guid("45859554-61d6-4f50-90eb-b40d19a17909"), new DateTime(2023, 9, 5, 11, 28, 46, 218, DateTimeKind.Local).AddTicks(6267), new DateTime(2024, 8, 8, 2, 34, 40, 51, DateTimeKind.Local).AddTicks(2550), 1282.34m },
                    { new Guid("97e064c8-f863-462e-9ff0-c4369ab89097"), new Guid("2528ff79-cf89-4261-a0de-428d26b20a72"), new DateTime(2023, 12, 11, 16, 41, 29, 732, DateTimeKind.Local).AddTicks(3281), new DateTime(2024, 8, 9, 5, 34, 46, 349, DateTimeKind.Local).AddTicks(7470), 3186.49m },
                    { new Guid("97e8f72a-fcc9-4b0d-b83f-1a65742d175f"), new Guid("fa016e07-09ad-491e-a261-85cdebb45436"), new DateTime(2023, 9, 16, 20, 28, 34, 971, DateTimeKind.Local).AddTicks(7616), new DateTime(2024, 8, 7, 21, 45, 14, 607, DateTimeKind.Local).AddTicks(6497), 3694.81m },
                    { new Guid("97efaf75-4dee-4e0f-9848-f29d77648ad1"), new Guid("0667960a-b942-408f-9aa5-8591f0e0599a"), new DateTime(2024, 3, 31, 7, 25, 21, 225, DateTimeKind.Local).AddTicks(64), new DateTime(2024, 8, 7, 20, 33, 38, 787, DateTimeKind.Local).AddTicks(1504), 271.61m },
                    { new Guid("9805d779-11a9-4443-9fd6-b9f8d4c793b9"), new Guid("697709be-b252-4405-bb7e-8673c6b98467"), new DateTime(2023, 11, 1, 22, 3, 22, 835, DateTimeKind.Local).AddTicks(4135), new DateTime(2024, 8, 8, 4, 6, 28, 940, DateTimeKind.Local).AddTicks(6900), 3590.64m },
                    { new Guid("98213489-4942-4a70-824d-3188d5770717"), new Guid("e56e8c86-41ee-47fd-9d05-a94a167bed10"), new DateTime(2023, 9, 3, 10, 54, 5, 869, DateTimeKind.Local).AddTicks(1911), new DateTime(2024, 8, 6, 23, 21, 17, 399, DateTimeKind.Local).AddTicks(4485), 2398.10m }
                });

            migrationBuilder.InsertData(
                table: "DonHangs",
                columns: new[] { "Id", "KhachHangId", "NgayDatHang", "NgayGiaoHang", "TongTien" },
                values: new object[,]
                {
                    { new Guid("9827204f-f0e3-430f-872f-6bb82c38b1d6"), new Guid("17544f0d-9e01-4955-b49a-dcc4b6a770ee"), new DateTime(2024, 1, 5, 0, 42, 38, 490, DateTimeKind.Local).AddTicks(831), new DateTime(2024, 8, 8, 9, 18, 2, 177, DateTimeKind.Local).AddTicks(9190), 948.75m },
                    { new Guid("983df22c-f9b5-4a77-b08e-6f9b98b7a346"), new Guid("697709be-b252-4405-bb7e-8673c6b98467"), new DateTime(2024, 6, 19, 14, 28, 51, 598, DateTimeKind.Local).AddTicks(30), new DateTime(2024, 8, 7, 17, 55, 59, 290, DateTimeKind.Local).AddTicks(6057), 2664.26m },
                    { new Guid("985880a4-4211-412c-8305-27265de6ef66"), new Guid("b78d1e60-56cf-4058-967c-7271f646af05"), new DateTime(2024, 2, 27, 3, 24, 40, 329, DateTimeKind.Local).AddTicks(1147), new DateTime(2024, 8, 8, 15, 22, 5, 225, DateTimeKind.Local).AddTicks(6339), 1975.02m },
                    { new Guid("985f7b07-1aee-4984-93ae-e52239e51eef"), new Guid("28d8da78-c6c4-4afe-9d92-22d52e3969b0"), new DateTime(2024, 3, 19, 4, 15, 8, 204, DateTimeKind.Local).AddTicks(1784), new DateTime(2024, 8, 8, 2, 31, 52, 718, DateTimeKind.Local).AddTicks(5908), 563.70m },
                    { new Guid("98a1801c-5be7-4fd2-bade-8cb846c35ef7"), new Guid("b4a06e76-1c1e-4cac-aaa1-572d7a607954"), new DateTime(2024, 2, 25, 9, 4, 22, 287, DateTimeKind.Local).AddTicks(8146), new DateTime(2024, 8, 8, 17, 8, 54, 479, DateTimeKind.Local).AddTicks(8939), 4621.56m },
                    { new Guid("98a1afba-1172-498f-8f42-10decf86313b"), new Guid("ceeb839d-d443-4791-8018-561c89d6e7d9"), new DateTime(2024, 7, 12, 13, 27, 47, 721, DateTimeKind.Local).AddTicks(9734), new DateTime(2024, 8, 7, 16, 35, 8, 535, DateTimeKind.Local).AddTicks(8314), 3255.29m },
                    { new Guid("99245caf-5e9e-4cef-b806-571b97176dfa"), new Guid("893b3fb0-9647-4958-b835-676e382779e7"), new DateTime(2024, 3, 19, 11, 37, 17, 535, DateTimeKind.Local).AddTicks(2784), new DateTime(2024, 8, 7, 16, 1, 35, 980, DateTimeKind.Local).AddTicks(2277), 2803.83m },
                    { new Guid("99553f43-e664-4735-8903-d81b70f41c69"), new Guid("6b4bca52-0cf9-4a9e-98cf-0eb6e3c24da0"), new DateTime(2023, 12, 24, 5, 8, 2, 855, DateTimeKind.Local).AddTicks(1786), new DateTime(2024, 8, 9, 8, 9, 38, 196, DateTimeKind.Local).AddTicks(1296), 2818.69m },
                    { new Guid("99721087-a98b-4842-8cb5-4466585b255a"), new Guid("1e3c140e-4cab-4065-aadd-2c1cfed5ce14"), new DateTime(2024, 7, 22, 3, 41, 18, 224, DateTimeKind.Local).AddTicks(4339), new DateTime(2024, 8, 7, 14, 14, 4, 540, DateTimeKind.Local).AddTicks(69), 4224.72m },
                    { new Guid("99cd3a6a-8e98-45df-a017-4320912d641e"), new Guid("5f3cfe10-1a7a-45c2-8fcb-c7e90692dbc4"), new DateTime(2024, 1, 30, 23, 43, 30, 381, DateTimeKind.Local).AddTicks(1409), new DateTime(2024, 8, 9, 13, 38, 29, 924, DateTimeKind.Local).AddTicks(1720), 3009.87m },
                    { new Guid("99dac0e5-e003-437f-8088-a500572d36d9"), new Guid("f0f1e5c8-88d3-4268-9c48-f6a85560db57"), new DateTime(2024, 4, 19, 13, 55, 2, 532, DateTimeKind.Local).AddTicks(864), new DateTime(2024, 8, 8, 14, 59, 1, 124, DateTimeKind.Local).AddTicks(9639), 4404.56m },
                    { new Guid("99f47fab-362c-4d74-9355-310973746023"), new Guid("e56e8c86-41ee-47fd-9d05-a94a167bed10"), new DateTime(2024, 6, 12, 19, 22, 38, 923, DateTimeKind.Local).AddTicks(8893), new DateTime(2024, 8, 7, 19, 25, 9, 843, DateTimeKind.Local).AddTicks(3065), 3606.54m },
                    { new Guid("9a13a67b-44c8-43d9-828b-c8dc38479817"), new Guid("5f3cfe10-1a7a-45c2-8fcb-c7e90692dbc4"), new DateTime(2024, 7, 21, 19, 38, 49, 693, DateTimeKind.Local).AddTicks(5115), new DateTime(2024, 8, 8, 20, 11, 24, 747, DateTimeKind.Local).AddTicks(3681), 4206.18m },
                    { new Guid("9a45a8f9-4902-4f2b-854a-62fa07421828"), new Guid("6d1e80c0-f438-45cd-a63c-9bf2330160b6"), new DateTime(2024, 6, 6, 21, 22, 15, 699, DateTimeKind.Local).AddTicks(4173), new DateTime(2024, 8, 9, 5, 2, 35, 92, DateTimeKind.Local).AddTicks(8550), 981.13m },
                    { new Guid("9a4ee26e-d727-4048-93c0-03ffb155c7fc"), new Guid("a51f9433-2477-4445-8a69-d24c50d95afb"), new DateTime(2024, 4, 22, 22, 2, 6, 768, DateTimeKind.Local).AddTicks(8987), new DateTime(2024, 8, 7, 7, 37, 27, 30, DateTimeKind.Local).AddTicks(1588), 1617.99m },
                    { new Guid("9b2458ba-a9fe-4e21-9e83-58b55cbd1304"), new Guid("b22bc921-a93c-4461-8bd3-df4b1e010bc1"), new DateTime(2024, 5, 20, 6, 52, 58, 566, DateTimeKind.Local).AddTicks(6396), new DateTime(2024, 8, 8, 12, 9, 1, 803, DateTimeKind.Local).AddTicks(5459), 4023.68m },
                    { new Guid("9b47e2ae-8c74-4143-bebb-97e8c43c5625"), new Guid("38ba8024-3b8d-4dd6-92b9-9d06da12ec6e"), new DateTime(2024, 4, 11, 19, 51, 20, 965, DateTimeKind.Local).AddTicks(5683), new DateTime(2024, 8, 7, 12, 23, 22, 19, DateTimeKind.Local).AddTicks(5109), 3599.94m },
                    { new Guid("9b727d64-606a-4051-992b-999d5b6121c4"), new Guid("4ebf8ce2-efc1-4c0d-8c61-7159ede74521"), new DateTime(2023, 10, 11, 1, 57, 25, 748, DateTimeKind.Local).AddTicks(8762), new DateTime(2024, 8, 9, 13, 5, 40, 571, DateTimeKind.Local).AddTicks(9997), 4112.73m },
                    { new Guid("9bb52b64-0b5d-4ee8-9552-6bb3d777d5c6"), new Guid("3da3214c-bd0e-4377-a9dd-da000298cefd"), new DateTime(2023, 11, 22, 4, 1, 41, 44, DateTimeKind.Local).AddTicks(8094), new DateTime(2024, 8, 9, 2, 49, 51, 19, DateTimeKind.Local).AddTicks(9718), 2450.98m },
                    { new Guid("9bdb182a-b8b7-4a57-ae4b-ce4f922d2097"), new Guid("1e3c140e-4cab-4065-aadd-2c1cfed5ce14"), new DateTime(2024, 4, 25, 10, 48, 34, 402, DateTimeKind.Local).AddTicks(9312), new DateTime(2024, 8, 9, 10, 55, 17, 825, DateTimeKind.Local).AddTicks(9357), 3449.26m },
                    { new Guid("9cc1cef1-5595-4d09-b620-3decfc0eb295"), new Guid("a99891d8-254d-4ec7-8cae-cf3bcb8c10a1"), new DateTime(2024, 3, 16, 4, 20, 16, 251, DateTimeKind.Local).AddTicks(9306), new DateTime(2024, 8, 7, 0, 25, 25, 163, DateTimeKind.Local).AddTicks(4968), 2929.24m },
                    { new Guid("9d172960-a46c-49a6-b8fa-a53c3843735b"), new Guid("6f10d3da-6328-4453-bd18-d299e75dca49"), new DateTime(2024, 2, 6, 21, 54, 0, 3, DateTimeKind.Local).AddTicks(2878), new DateTime(2024, 8, 7, 9, 1, 15, 941, DateTimeKind.Local).AddTicks(3794), 1270.23m },
                    { new Guid("9d4e64f8-d2da-43f9-905c-73077722abfd"), new Guid("38ba8024-3b8d-4dd6-92b9-9d06da12ec6e"), new DateTime(2023, 8, 29, 19, 15, 45, 580, DateTimeKind.Local).AddTicks(6035), new DateTime(2024, 8, 7, 5, 48, 57, 707, DateTimeKind.Local).AddTicks(3957), 4362.15m },
                    { new Guid("9d53a772-138b-4615-b58b-8854985819f4"), new Guid("17544f0d-9e01-4955-b49a-dcc4b6a770ee"), new DateTime(2024, 8, 2, 14, 16, 0, 117, DateTimeKind.Local).AddTicks(7284), new DateTime(2024, 8, 9, 14, 58, 50, 679, DateTimeKind.Local).AddTicks(2403), 1119.90m },
                    { new Guid("9d8f95b7-14f8-4563-96f4-621ab661cbfb"), new Guid("5611f5df-6d74-47b4-b24b-5863bd50f032"), new DateTime(2024, 2, 3, 14, 8, 43, 278, DateTimeKind.Local).AddTicks(6547), new DateTime(2024, 8, 7, 14, 53, 1, 404, DateTimeKind.Local).AddTicks(6634), 4824.69m },
                    { new Guid("9dd48335-4d82-4b57-9d75-155952443737"), new Guid("b78d1e60-56cf-4058-967c-7271f646af05"), new DateTime(2023, 9, 2, 10, 5, 52, 147, DateTimeKind.Local).AddTicks(5049), new DateTime(2024, 8, 7, 16, 29, 47, 285, DateTimeKind.Local).AddTicks(1874), 3509.86m },
                    { new Guid("9df2d089-6323-44bb-bae9-4fd6f0e98adc"), new Guid("3fd74fb4-2450-440d-8497-d9a630f57199"), new DateTime(2024, 1, 12, 1, 2, 24, 614, DateTimeKind.Local).AddTicks(1630), new DateTime(2024, 8, 8, 20, 20, 42, 922, DateTimeKind.Local).AddTicks(2382), 3082.49m },
                    { new Guid("9e06a8fe-e9ca-4096-8896-32cd6675df79"), new Guid("0bd930d6-b736-4558-87c1-50bd97e08db0"), new DateTime(2023, 11, 12, 3, 36, 24, 291, DateTimeKind.Local).AddTicks(1815), new DateTime(2024, 8, 8, 11, 45, 40, 995, DateTimeKind.Local).AddTicks(156), 4813.92m },
                    { new Guid("9e2d2aca-a6e8-4c9c-b0f5-9f8d6fe168d4"), new Guid("1cab312c-e326-4c44-ae00-5542888dfbc9"), new DateTime(2024, 3, 18, 7, 28, 35, 568, DateTimeKind.Local).AddTicks(3277), new DateTime(2024, 8, 7, 9, 29, 18, 84, DateTimeKind.Local).AddTicks(7193), 4654.14m },
                    { new Guid("9e2ebb56-1d08-42c8-9ab2-2edb450d0db2"), new Guid("648119d0-d486-40c5-bd23-69a5e42b2ba5"), new DateTime(2024, 3, 26, 15, 7, 21, 347, DateTimeKind.Local).AddTicks(3190), new DateTime(2024, 8, 7, 7, 45, 38, 549, DateTimeKind.Local).AddTicks(218), 2680.38m },
                    { new Guid("9ec07b92-ce9c-4a7d-b844-87a5cb5a955e"), new Guid("24256d4c-7032-4437-8c1e-dd211c5bd713"), new DateTime(2023, 9, 25, 3, 26, 36, 785, DateTimeKind.Local).AddTicks(7099), new DateTime(2024, 8, 8, 10, 45, 34, 40, DateTimeKind.Local).AddTicks(5253), 246.62m },
                    { new Guid("9f62abca-3116-401b-a632-0a3268c0aede"), new Guid("75fe592b-5c1e-4814-a459-627bef01098f"), new DateTime(2024, 8, 4, 22, 8, 19, 317, DateTimeKind.Local).AddTicks(8425), new DateTime(2024, 8, 8, 16, 56, 23, 926, DateTimeKind.Local).AddTicks(7520), 560.19m },
                    { new Guid("9fdf2090-f921-41ab-b87d-ba6e632a6403"), new Guid("a99891d8-254d-4ec7-8cae-cf3bcb8c10a1"), new DateTime(2023, 8, 13, 20, 31, 20, 930, DateTimeKind.Local).AddTicks(8189), new DateTime(2024, 8, 7, 2, 34, 52, 15, DateTimeKind.Local).AddTicks(6760), 2712.67m },
                    { new Guid("a09d0172-6177-4408-ad10-d5573867aa28"), new Guid("22ebc934-105f-4b38-ab74-feae23d1ffc0"), new DateTime(2023, 10, 13, 1, 30, 53, 924, DateTimeKind.Local).AddTicks(9227), new DateTime(2024, 8, 7, 6, 15, 38, 268, DateTimeKind.Local).AddTicks(8802), 1551.35m },
                    { new Guid("a1051770-4c3c-42d8-a357-b63dbd5779c9"), new Guid("5611f5df-6d74-47b4-b24b-5863bd50f032"), new DateTime(2024, 4, 8, 3, 58, 42, 119, DateTimeKind.Local).AddTicks(9422), new DateTime(2024, 8, 9, 20, 27, 59, 879, DateTimeKind.Local).AddTicks(7219), 1584.79m },
                    { new Guid("a10b298a-4f57-4b7d-adfa-a017a27d72ed"), new Guid("6f10d3da-6328-4453-bd18-d299e75dca49"), new DateTime(2023, 9, 6, 2, 2, 3, 277, DateTimeKind.Local).AddTicks(7443), new DateTime(2024, 8, 9, 10, 40, 43, 498, DateTimeKind.Local).AddTicks(704), 2987.00m },
                    { new Guid("a12d1dc1-e9db-42ac-8c69-4ae401b62e6b"), new Guid("5f3cfe10-1a7a-45c2-8fcb-c7e90692dbc4"), new DateTime(2024, 2, 12, 10, 20, 55, 460, DateTimeKind.Local).AddTicks(9261), new DateTime(2024, 8, 8, 6, 8, 59, 299, DateTimeKind.Local).AddTicks(5470), 678.49m },
                    { new Guid("a14712f8-14f4-4111-81de-14f98860e18e"), new Guid("3da3214c-bd0e-4377-a9dd-da000298cefd"), new DateTime(2024, 5, 13, 10, 33, 45, 687, DateTimeKind.Local).AddTicks(8087), new DateTime(2024, 8, 7, 10, 35, 6, 923, DateTimeKind.Local).AddTicks(6612), 4033.74m },
                    { new Guid("a166f023-ac7d-4791-a6ed-8371fc0cd700"), new Guid("5f3cfe10-1a7a-45c2-8fcb-c7e90692dbc4"), new DateTime(2024, 5, 17, 12, 48, 16, 336, DateTimeKind.Local).AddTicks(3934), new DateTime(2024, 8, 7, 2, 54, 19, 557, DateTimeKind.Local).AddTicks(8736), 3659.47m },
                    { new Guid("a16e7559-56b3-4e46-b276-a35615d4bc60"), new Guid("873734f8-2118-4bff-95ec-9e199770cefb"), new DateTime(2024, 2, 12, 9, 50, 35, 952, DateTimeKind.Local).AddTicks(2102), new DateTime(2024, 8, 8, 9, 11, 46, 657, DateTimeKind.Local).AddTicks(7548), 4770.23m },
                    { new Guid("a18d7d81-884d-4cf3-8578-1e85d90f9b4f"), new Guid("15883dbe-e97e-4859-86f7-993bbc1173df"), new DateTime(2023, 12, 28, 15, 53, 17, 891, DateTimeKind.Local).AddTicks(9607), new DateTime(2024, 8, 9, 16, 18, 44, 222, DateTimeKind.Local).AddTicks(2665), 241.25m },
                    { new Guid("a1a35a42-e096-47b7-971f-80ed96a890d2"), new Guid("d43ed679-0d22-40c7-a14a-6d01fe86c193"), new DateTime(2024, 6, 6, 21, 28, 3, 270, DateTimeKind.Local).AddTicks(8639), new DateTime(2024, 8, 7, 7, 47, 24, 504, DateTimeKind.Local).AddTicks(2816), 4963.85m }
                });

            migrationBuilder.InsertData(
                table: "DonHangs",
                columns: new[] { "Id", "KhachHangId", "NgayDatHang", "NgayGiaoHang", "TongTien" },
                values: new object[,]
                {
                    { new Guid("a1abdf3f-535c-446f-a2e3-c5134895af44"), new Guid("ec92935c-29c1-47d3-9ff2-3aed6a0974f2"), new DateTime(2023, 10, 27, 16, 59, 30, 527, DateTimeKind.Local).AddTicks(8223), new DateTime(2024, 8, 8, 17, 10, 49, 738, DateTimeKind.Local).AddTicks(1853), 624.99m },
                    { new Guid("a219d2d2-8faa-4c78-9e82-886497a561d0"), new Guid("cce9a706-5e55-4052-a88e-26f4b6765bc9"), new DateTime(2024, 3, 23, 17, 52, 4, 173, DateTimeKind.Local).AddTicks(4140), new DateTime(2024, 8, 8, 1, 19, 10, 307, DateTimeKind.Local).AddTicks(7048), 553.34m },
                    { new Guid("a250e423-a2b1-439a-8fc8-018931321fc6"), new Guid("063fdb59-1945-4f6e-85e3-5f57321287f9"), new DateTime(2023, 12, 17, 10, 39, 30, 858, DateTimeKind.Local).AddTicks(7400), new DateTime(2024, 8, 7, 16, 34, 0, 206, DateTimeKind.Local).AddTicks(6925), 3152.07m },
                    { new Guid("a28b0668-1a63-4749-afaf-dc921fc5579d"), new Guid("88888a0c-f1ed-4613-9646-ee6509dc5db0"), new DateTime(2023, 8, 14, 9, 43, 10, 508, DateTimeKind.Local).AddTicks(5526), new DateTime(2024, 8, 7, 7, 30, 31, 173, DateTimeKind.Local).AddTicks(1318), 4392.63m },
                    { new Guid("a298ff6a-6a22-405a-8eec-700ca24962c8"), new Guid("5ee23c83-8a7a-498c-96a6-f2bc6fdc8136"), new DateTime(2024, 6, 16, 0, 35, 37, 300, DateTimeKind.Local).AddTicks(9207), new DateTime(2024, 8, 8, 21, 51, 12, 897, DateTimeKind.Local).AddTicks(373), 1189.99m },
                    { new Guid("a2ce3204-4f6f-41d8-a06d-fc42b9ef9fc3"), new Guid("d6d20276-ac8b-44d6-9939-d642e6335c51"), new DateTime(2023, 10, 3, 3, 2, 29, 921, DateTimeKind.Local).AddTicks(9856), new DateTime(2024, 8, 9, 0, 24, 55, 177, DateTimeKind.Local).AddTicks(6643), 2228.35m },
                    { new Guid("a3413860-71ba-47b2-8230-616a68a43f6e"), new Guid("f0f1e5c8-88d3-4268-9c48-f6a85560db57"), new DateTime(2023, 8, 18, 22, 28, 47, 7, DateTimeKind.Local).AddTicks(4387), new DateTime(2024, 8, 7, 11, 19, 20, 750, DateTimeKind.Local).AddTicks(7387), 4661.58m },
                    { new Guid("a34f4b78-e4ba-49e7-8596-9e3e3ebc8b8f"), new Guid("6f2bc11e-7dd7-4049-9e35-163927214820"), new DateTime(2024, 8, 1, 20, 11, 6, 304, DateTimeKind.Local).AddTicks(9888), new DateTime(2024, 8, 7, 23, 35, 23, 778, DateTimeKind.Local).AddTicks(4914), 4915.69m },
                    { new Guid("a39ea3d5-65f4-4032-a767-5519f667c8f1"), new Guid("648119d0-d486-40c5-bd23-69a5e42b2ba5"), new DateTime(2023, 10, 20, 11, 51, 10, 838, DateTimeKind.Local).AddTicks(6490), new DateTime(2024, 8, 7, 10, 54, 26, 526, DateTimeKind.Local).AddTicks(3586), 477.54m },
                    { new Guid("a3efa913-6144-4e48-be66-b8b36508f6f9"), new Guid("33caf896-8425-48e6-86b5-a47f32bb1850"), new DateTime(2023, 12, 29, 20, 17, 3, 270, DateTimeKind.Local).AddTicks(7304), new DateTime(2024, 8, 9, 7, 34, 54, 280, DateTimeKind.Local).AddTicks(1428), 2947.04m },
                    { new Guid("a3f3b88a-ab6e-4022-a33e-424d2ad0b654"), new Guid("d15c8331-36ed-417a-b1fa-5f377c4c9930"), new DateTime(2023, 8, 22, 13, 26, 10, 348, DateTimeKind.Local).AddTicks(8131), new DateTime(2024, 8, 8, 20, 42, 20, 681, DateTimeKind.Local).AddTicks(4900), 153.96m },
                    { new Guid("a48b7512-e924-4f10-9335-b490fadd2e0d"), new Guid("44514479-669b-45b2-8af4-510b0786de9b"), new DateTime(2024, 6, 26, 18, 11, 51, 243, DateTimeKind.Local).AddTicks(3520), new DateTime(2024, 8, 8, 3, 35, 28, 245, DateTimeKind.Local).AddTicks(7486), 4115.67m },
                    { new Guid("a4d6949f-2e68-40c2-89b9-34e4ac61f6f9"), new Guid("b41438f5-9380-4cd7-bc4d-59267b9b760c"), new DateTime(2024, 2, 13, 10, 43, 39, 832, DateTimeKind.Local).AddTicks(1755), new DateTime(2024, 8, 8, 1, 11, 6, 818, DateTimeKind.Local).AddTicks(444), 3021.15m },
                    { new Guid("a4e06baa-a5d8-40d3-9d05-89a7ac5288ed"), new Guid("ec92935c-29c1-47d3-9ff2-3aed6a0974f2"), new DateTime(2023, 12, 25, 22, 39, 31, 92, DateTimeKind.Local).AddTicks(4190), new DateTime(2024, 8, 9, 17, 42, 30, 249, DateTimeKind.Local).AddTicks(2984), 4122.47m },
                    { new Guid("a501ea1e-ebd8-416d-a102-b8e80370f863"), new Guid("5ee23c83-8a7a-498c-96a6-f2bc6fdc8136"), new DateTime(2023, 8, 7, 14, 48, 17, 790, DateTimeKind.Local).AddTicks(4301), new DateTime(2024, 8, 7, 3, 11, 49, 286, DateTimeKind.Local).AddTicks(3856), 2407.82m },
                    { new Guid("a5a47e31-13cf-4a0e-922e-bc336083703a"), new Guid("2f5efba5-6605-4ccc-9a86-918b9bd19b8b"), new DateTime(2023, 10, 2, 3, 6, 56, 460, DateTimeKind.Local).AddTicks(190), new DateTime(2024, 8, 9, 9, 15, 41, 716, DateTimeKind.Local).AddTicks(1429), 2661.09m },
                    { new Guid("a5d3834a-cba1-49aa-9824-47f648abd924"), new Guid("38ba8024-3b8d-4dd6-92b9-9d06da12ec6e"), new DateTime(2023, 12, 3, 18, 43, 38, 996, DateTimeKind.Local).AddTicks(3396), new DateTime(2024, 8, 9, 20, 59, 51, 254, DateTimeKind.Local).AddTicks(2037), 1429.10m },
                    { new Guid("a5d5b874-d425-42d7-82e6-e981363d2e36"), new Guid("1d71e542-620f-4161-9842-a2a145bd7013"), new DateTime(2024, 4, 10, 13, 10, 5, 371, DateTimeKind.Local).AddTicks(1320), new DateTime(2024, 8, 9, 8, 4, 46, 851, DateTimeKind.Local).AddTicks(4195), 268.72m },
                    { new Guid("a637d875-2a68-468b-9f4a-9d7ebeb2b7d7"), new Guid("a51f9433-2477-4445-8a69-d24c50d95afb"), new DateTime(2024, 2, 16, 15, 32, 45, 591, DateTimeKind.Local).AddTicks(3999), new DateTime(2024, 8, 7, 4, 24, 18, 998, DateTimeKind.Local).AddTicks(8074), 501.82m },
                    { new Guid("a668420a-688a-4599-9a72-974a559bb3a6"), new Guid("d5d71173-e817-45f8-9146-4b7ab7c7b686"), new DateTime(2024, 5, 18, 13, 23, 29, 606, DateTimeKind.Local).AddTicks(9932), new DateTime(2024, 8, 7, 10, 42, 5, 148, DateTimeKind.Local).AddTicks(1669), 2012.28m },
                    { new Guid("a672e648-3253-44a2-a105-8926f0609eec"), new Guid("5f3cfe10-1a7a-45c2-8fcb-c7e90692dbc4"), new DateTime(2024, 1, 5, 14, 32, 30, 331, DateTimeKind.Local).AddTicks(7921), new DateTime(2024, 8, 9, 14, 27, 21, 723, DateTimeKind.Local).AddTicks(3844), 4946.39m },
                    { new Guid("a682f574-3392-4c2a-82ad-3f43f0821530"), new Guid("e9d684aa-183f-423f-8741-1a53cfb8f2e3"), new DateTime(2024, 3, 7, 11, 0, 12, 526, DateTimeKind.Local).AddTicks(1400), new DateTime(2024, 8, 7, 10, 36, 17, 720, DateTimeKind.Local).AddTicks(7859), 4921.59m },
                    { new Guid("a69734d6-a98a-408d-b46b-b5ed97e18c58"), new Guid("3fd74fb4-2450-440d-8497-d9a630f57199"), new DateTime(2024, 1, 21, 5, 9, 25, 677, DateTimeKind.Local).AddTicks(1690), new DateTime(2024, 8, 7, 17, 16, 23, 123, DateTimeKind.Local).AddTicks(6888), 4139.09m },
                    { new Guid("a69993b6-8957-4953-8a86-5b8935e1112b"), new Guid("9f2dcec6-cc02-45d6-95d0-fa0b53a5f953"), new DateTime(2023, 10, 18, 23, 39, 31, 130, DateTimeKind.Local).AddTicks(723), new DateTime(2024, 8, 7, 18, 8, 24, 310, DateTimeKind.Local).AddTicks(4689), 219.86m },
                    { new Guid("a6c1bfef-f2fe-4305-b547-46df97f7f81b"), new Guid("5ee23c83-8a7a-498c-96a6-f2bc6fdc8136"), new DateTime(2024, 3, 4, 5, 1, 57, 637, DateTimeKind.Local).AddTicks(2266), new DateTime(2024, 8, 9, 5, 42, 20, 191, DateTimeKind.Local).AddTicks(9580), 1108.52m },
                    { new Guid("a6c5af6d-be85-4624-bcd9-f88b2b3ce49f"), new Guid("841db90c-5f81-482a-a955-f91fc637a7f7"), new DateTime(2023, 9, 27, 9, 57, 34, 30, DateTimeKind.Local).AddTicks(2435), new DateTime(2024, 8, 7, 9, 27, 39, 370, DateTimeKind.Local).AddTicks(7470), 4760.31m },
                    { new Guid("a6d5bf29-4c85-4f04-99b5-12cc012682b5"), new Guid("6212ef8f-9777-42a2-ad28-a2ed1ebe90f8"), new DateTime(2024, 2, 14, 17, 49, 38, 241, DateTimeKind.Local).AddTicks(3235), new DateTime(2024, 8, 9, 20, 40, 28, 579, DateTimeKind.Local).AddTicks(2453), 306.49m },
                    { new Guid("a7499901-f888-4ce3-832a-dc1881cba1e3"), new Guid("f9a1bd2e-de1a-42b8-b894-7f7e0b5b38f1"), new DateTime(2024, 8, 2, 7, 12, 24, 465, DateTimeKind.Local).AddTicks(8945), new DateTime(2024, 8, 8, 19, 47, 16, 545, DateTimeKind.Local).AddTicks(1834), 2721.72m },
                    { new Guid("a76a029a-d7a1-4b00-9709-f3a6cbfd830b"), new Guid("893b3fb0-9647-4958-b835-676e382779e7"), new DateTime(2024, 3, 10, 14, 56, 35, 541, DateTimeKind.Local).AddTicks(3472), new DateTime(2024, 8, 8, 6, 2, 21, 646, DateTimeKind.Local).AddTicks(7929), 2120.33m },
                    { new Guid("a824d5b9-a011-4930-8c56-48cf8f2834a8"), new Guid("2463d0a4-5008-43f5-97fd-bbd3d0048d8e"), new DateTime(2023, 8, 31, 22, 21, 57, 485, DateTimeKind.Local).AddTicks(9771), new DateTime(2024, 8, 8, 0, 49, 47, 701, DateTimeKind.Local).AddTicks(7593), 3489.70m },
                    { new Guid("a869adaf-d528-4e5b-bb05-ed6de726e76a"), new Guid("a89b1694-3065-45be-9b67-fb5d87dc35f5"), new DateTime(2024, 2, 28, 18, 26, 29, 550, DateTimeKind.Local).AddTicks(4940), new DateTime(2024, 8, 8, 23, 32, 3, 422, DateTimeKind.Local).AddTicks(8796), 4666.51m },
                    { new Guid("a8a67a07-bd50-48ee-9393-3bfb53b860f1"), new Guid("f9a1bd2e-de1a-42b8-b894-7f7e0b5b38f1"), new DateTime(2023, 9, 1, 16, 10, 53, 886, DateTimeKind.Local).AddTicks(9025), new DateTime(2024, 8, 7, 5, 27, 28, 301, DateTimeKind.Local).AddTicks(790), 1395.06m },
                    { new Guid("a8e22050-5d68-45b5-966a-ef468d83066a"), new Guid("2463d0a4-5008-43f5-97fd-bbd3d0048d8e"), new DateTime(2024, 3, 15, 15, 29, 8, 599, DateTimeKind.Local).AddTicks(2608), new DateTime(2024, 8, 9, 11, 41, 37, 202, DateTimeKind.Local).AddTicks(7188), 2086.41m },
                    { new Guid("a9121329-aec1-4cb2-9683-73b69b632816"), new Guid("d15c8331-36ed-417a-b1fa-5f377c4c9930"), new DateTime(2023, 8, 9, 4, 19, 37, 721, DateTimeKind.Local).AddTicks(7454), new DateTime(2024, 8, 7, 15, 27, 0, 133, DateTimeKind.Local).AddTicks(8861), 301.08m },
                    { new Guid("a9697767-8d08-491e-bb35-203297e8f658"), new Guid("6f2bc11e-7dd7-4049-9e35-163927214820"), new DateTime(2024, 3, 14, 1, 2, 14, 357, DateTimeKind.Local).AddTicks(8562), new DateTime(2024, 8, 9, 17, 16, 25, 538, DateTimeKind.Local).AddTicks(7120), 3789.52m },
                    { new Guid("a97da830-82b9-4a54-9149-f3b616a66a84"), new Guid("fa016e07-09ad-491e-a261-85cdebb45436"), new DateTime(2023, 8, 16, 21, 34, 9, 368, DateTimeKind.Local).AddTicks(9609), new DateTime(2024, 8, 9, 4, 41, 6, 129, DateTimeKind.Local).AddTicks(2152), 95.76m },
                    { new Guid("a9a08656-ffcb-4ef0-8530-f020050e8c6e"), new Guid("2463d0a4-5008-43f5-97fd-bbd3d0048d8e"), new DateTime(2023, 8, 15, 0, 16, 47, 578, DateTimeKind.Local).AddTicks(834), new DateTime(2024, 8, 9, 15, 1, 23, 800, DateTimeKind.Local).AddTicks(3924), 821.09m },
                    { new Guid("a9d672a5-9c87-4d36-8ef8-76b8bcd2cf07"), new Guid("297e58cc-55d1-4c96-81c1-edd1b4b0ffb7"), new DateTime(2023, 9, 13, 10, 24, 17, 370, DateTimeKind.Local).AddTicks(8868), new DateTime(2024, 8, 7, 16, 28, 51, 245, DateTimeKind.Local).AddTicks(6915), 4844.17m },
                    { new Guid("aa812ea0-19c1-4c6b-8092-3ca8197ecd75"), new Guid("886111c9-af92-447f-91bf-dad7b8a03eb5"), new DateTime(2024, 4, 18, 23, 36, 28, 836, DateTimeKind.Local).AddTicks(3639), new DateTime(2024, 8, 8, 20, 43, 44, 436, DateTimeKind.Local).AddTicks(8727), 1732.80m },
                    { new Guid("aaa897b4-95f4-49a0-b677-3c9eeef3186f"), new Guid("fa016e07-09ad-491e-a261-85cdebb45436"), new DateTime(2023, 12, 1, 14, 4, 49, 295, DateTimeKind.Local).AddTicks(6751), new DateTime(2024, 8, 7, 18, 50, 25, 303, DateTimeKind.Local).AddTicks(2581), 3442.79m },
                    { new Guid("aab56acf-0e09-4ac0-ae39-655d95b7ec36"), new Guid("1248d1fb-1e80-4ded-926b-6b7f6d2249a5"), new DateTime(2023, 12, 26, 12, 38, 52, 195, DateTimeKind.Local).AddTicks(9129), new DateTime(2024, 8, 6, 23, 13, 50, 661, DateTimeKind.Local).AddTicks(5534), 2231.91m },
                    { new Guid("aacc7543-99c8-4798-9310-d44c8d297368"), new Guid("17652753-332f-4654-89d0-bbca6d67670f"), new DateTime(2024, 7, 31, 9, 38, 1, 373, DateTimeKind.Local).AddTicks(3575), new DateTime(2024, 8, 8, 12, 14, 56, 744, DateTimeKind.Local).AddTicks(3036), 3153.39m }
                });

            migrationBuilder.InsertData(
                table: "DonHangs",
                columns: new[] { "Id", "KhachHangId", "NgayDatHang", "NgayGiaoHang", "TongTien" },
                values: new object[,]
                {
                    { new Guid("ab07c285-d887-4eea-ac9a-5b34ddb9b57f"), new Guid("a99891d8-254d-4ec7-8cae-cf3bcb8c10a1"), new DateTime(2024, 7, 14, 8, 49, 59, 126, DateTimeKind.Local).AddTicks(612), new DateTime(2024, 8, 8, 8, 6, 2, 449, DateTimeKind.Local).AddTicks(4777), 568.28m },
                    { new Guid("ab5b210a-e0ce-4756-b369-926554b88ebf"), new Guid("893b3fb0-9647-4958-b835-676e382779e7"), new DateTime(2024, 4, 21, 0, 55, 20, 958, DateTimeKind.Local).AddTicks(9992), new DateTime(2024, 8, 9, 6, 4, 25, 618, DateTimeKind.Local).AddTicks(1188), 3827.08m },
                    { new Guid("ab6f8a00-453b-4896-b545-56a4aed16fb0"), new Guid("6212ef8f-9777-42a2-ad28-a2ed1ebe90f8"), new DateTime(2023, 8, 8, 3, 32, 10, 141, DateTimeKind.Local).AddTicks(4723), new DateTime(2024, 8, 9, 6, 14, 57, 112, DateTimeKind.Local).AddTicks(1505), 3735.46m },
                    { new Guid("ab7be0a2-f3bb-45b2-b0d7-181773317794"), new Guid("2f5efba5-6605-4ccc-9a86-918b9bd19b8b"), new DateTime(2023, 9, 22, 8, 9, 14, 150, DateTimeKind.Local).AddTicks(7297), new DateTime(2024, 8, 8, 16, 27, 59, 627, DateTimeKind.Local).AddTicks(7734), 1806.10m },
                    { new Guid("abf02abe-5d97-401e-9cb6-69a189c912ae"), new Guid("920b6ceb-11fd-4534-8c78-0adccdc2cbf5"), new DateTime(2023, 8, 8, 22, 7, 37, 83, DateTimeKind.Local).AddTicks(9551), new DateTime(2024, 8, 8, 8, 49, 32, 119, DateTimeKind.Local).AddTicks(3372), 3421.46m },
                    { new Guid("abf2c283-ea0e-4949-9a9e-fb3912477f57"), new Guid("99eb34d9-432d-450c-9c9f-1f90d43caf39"), new DateTime(2023, 10, 15, 6, 32, 47, 19, DateTimeKind.Local).AddTicks(5197), new DateTime(2024, 8, 8, 8, 15, 9, 836, DateTimeKind.Local).AddTicks(3121), 1475.39m },
                    { new Guid("acd09271-1a19-496c-9352-94f22efd1fda"), new Guid("590c7122-bbd8-408c-9571-b8d385d97b9e"), new DateTime(2024, 1, 12, 8, 58, 55, 328, DateTimeKind.Local).AddTicks(4013), new DateTime(2024, 8, 8, 8, 5, 47, 729, DateTimeKind.Local).AddTicks(240), 1697.59m },
                    { new Guid("ad01ee97-8063-46d7-b111-bd5c87c14e86"), new Guid("38ba8024-3b8d-4dd6-92b9-9d06da12ec6e"), new DateTime(2023, 12, 19, 19, 35, 30, 665, DateTimeKind.Local).AddTicks(4909), new DateTime(2024, 8, 8, 3, 37, 37, 665, DateTimeKind.Local).AddTicks(6547), 1365.58m },
                    { new Guid("ad3d9290-0c1c-42fc-a69f-690d19b1bed0"), new Guid("0b23e0d1-fa5b-4022-92b8-ff158e6d60ed"), new DateTime(2024, 3, 11, 23, 24, 54, 884, DateTimeKind.Local).AddTicks(2732), new DateTime(2024, 8, 9, 1, 9, 1, 628, DateTimeKind.Local).AddTicks(6248), 4897.32m },
                    { new Guid("ad637b1b-eb63-4c9c-a297-50bd4c06cf0a"), new Guid("e9d684aa-183f-423f-8741-1a53cfb8f2e3"), new DateTime(2024, 5, 4, 21, 35, 25, 856, DateTimeKind.Local).AddTicks(1129), new DateTime(2024, 8, 7, 9, 1, 7, 224, DateTimeKind.Local).AddTicks(5772), 1300.24m },
                    { new Guid("ada7df00-ef2a-4e1d-9538-c163e03d564f"), new Guid("3da3214c-bd0e-4377-a9dd-da000298cefd"), new DateTime(2024, 3, 17, 15, 44, 29, 605, DateTimeKind.Local).AddTicks(9511), new DateTime(2024, 8, 8, 13, 41, 14, 270, DateTimeKind.Local).AddTicks(8708), 4602.18m },
                    { new Guid("adc716e0-62e8-4082-8825-8cc565a46ce7"), new Guid("f9a1bd2e-de1a-42b8-b894-7f7e0b5b38f1"), new DateTime(2024, 4, 9, 7, 30, 24, 713, DateTimeKind.Local).AddTicks(8845), new DateTime(2024, 8, 7, 3, 7, 55, 50, DateTimeKind.Local).AddTicks(5560), 2072.10m },
                    { new Guid("ae572960-a575-4fff-82f6-8ec0d0435d22"), new Guid("1c79d0c4-56b9-4b08-af15-2fddc2c1068e"), new DateTime(2024, 7, 31, 12, 25, 28, 776, DateTimeKind.Local).AddTicks(3557), new DateTime(2024, 8, 9, 14, 11, 57, 419, DateTimeKind.Local).AddTicks(2337), 4671.55m },
                    { new Guid("aec6abe8-22c9-46e7-a96e-82ec1fb8b60f"), new Guid("45859554-61d6-4f50-90eb-b40d19a17909"), new DateTime(2024, 4, 9, 20, 4, 3, 233, DateTimeKind.Local).AddTicks(1103), new DateTime(2024, 8, 7, 21, 2, 29, 729, DateTimeKind.Local).AddTicks(3665), 2062.52m },
                    { new Guid("af7a3176-4550-4218-8e02-b48c05415259"), new Guid("fafc2111-6b48-4585-8074-65bb860d42ae"), new DateTime(2023, 11, 2, 7, 6, 45, 560, DateTimeKind.Local).AddTicks(8478), new DateTime(2024, 8, 9, 3, 19, 51, 644, DateTimeKind.Local).AddTicks(3741), 1181.23m },
                    { new Guid("af884855-c75b-4fb8-93f8-0d83a2db2374"), new Guid("0667960a-b942-408f-9aa5-8591f0e0599a"), new DateTime(2023, 12, 10, 1, 42, 7, 137, DateTimeKind.Local).AddTicks(3398), new DateTime(2024, 8, 9, 21, 10, 58, 721, DateTimeKind.Local).AddTicks(9153), 2187.32m },
                    { new Guid("afdc5483-d26f-4c1f-85cc-b861ed5cf819"), new Guid("1248d1fb-1e80-4ded-926b-6b7f6d2249a5"), new DateTime(2023, 8, 30, 1, 47, 50, 815, DateTimeKind.Local).AddTicks(4042), new DateTime(2024, 8, 8, 19, 52, 10, 905, DateTimeKind.Local).AddTicks(3758), 3179.12m },
                    { new Guid("afe9d5e8-2598-4892-8bd9-23601db564c1"), new Guid("d43ed679-0d22-40c7-a14a-6d01fe86c193"), new DateTime(2023, 12, 3, 8, 54, 56, 115, DateTimeKind.Local).AddTicks(4269), new DateTime(2024, 8, 9, 20, 7, 28, 33, DateTimeKind.Local).AddTicks(3338), 915.63m },
                    { new Guid("b04103ad-9445-4755-a9b0-167b0f87d31b"), new Guid("8bc08888-8550-4e72-9b5e-71845b5b9567"), new DateTime(2024, 2, 29, 13, 1, 32, 634, DateTimeKind.Local).AddTicks(2544), new DateTime(2024, 8, 8, 2, 5, 48, 774, DateTimeKind.Local).AddTicks(4096), 2458.18m },
                    { new Guid("b05b357e-3e86-440d-b794-9f12872e15a8"), new Guid("44514479-669b-45b2-8af4-510b0786de9b"), new DateTime(2024, 6, 13, 23, 24, 0, 255, DateTimeKind.Local).AddTicks(3875), new DateTime(2024, 8, 8, 13, 50, 11, 604, DateTimeKind.Local).AddTicks(3012), 2355.92m },
                    { new Guid("b0832d6a-9dff-409d-9bc7-d6f635a143c8"), new Guid("c0ebc03b-08bf-4b16-89e2-4c86dec71a59"), new DateTime(2024, 1, 31, 23, 18, 59, 902, DateTimeKind.Local).AddTicks(4815), new DateTime(2024, 8, 9, 11, 38, 28, 554, DateTimeKind.Local).AddTicks(5065), 2295.00m },
                    { new Guid("b0be0825-4786-47fc-bdfc-18fca103e47d"), new Guid("0b23e0d1-fa5b-4022-92b8-ff158e6d60ed"), new DateTime(2024, 2, 19, 17, 32, 40, 133, DateTimeKind.Local).AddTicks(1075), new DateTime(2024, 8, 8, 10, 46, 34, 714, DateTimeKind.Local).AddTicks(2167), 3478.74m },
                    { new Guid("b0c3cae5-4d0d-45fa-8d6c-7624ca65832c"), new Guid("952cbe13-c448-4063-910c-4a6b51e895ce"), new DateTime(2024, 6, 15, 5, 19, 48, 371, DateTimeKind.Local).AddTicks(719), new DateTime(2024, 8, 9, 14, 37, 35, 93, DateTimeKind.Local).AddTicks(3669), 2296.76m },
                    { new Guid("b0d6ad50-047e-4827-9a5d-c6e7c0fcc794"), new Guid("88888a0c-f1ed-4613-9646-ee6509dc5db0"), new DateTime(2024, 6, 15, 6, 41, 24, 866, DateTimeKind.Local).AddTicks(4541), new DateTime(2024, 8, 6, 23, 36, 1, 989, DateTimeKind.Local).AddTicks(4302), 96.82m },
                    { new Guid("b0e32fb2-f15e-41b3-af67-fe9d960d4d80"), new Guid("1c79d0c4-56b9-4b08-af15-2fddc2c1068e"), new DateTime(2023, 10, 11, 15, 17, 41, 703, DateTimeKind.Local).AddTicks(2773), new DateTime(2024, 8, 8, 7, 2, 29, 632, DateTimeKind.Local).AddTicks(2737), 352.91m },
                    { new Guid("b0ee34ff-3c20-41f2-85e5-e3d85b31fd8e"), new Guid("90fb9bfe-da70-4392-9904-4417fab257a7"), new DateTime(2023, 8, 27, 23, 5, 37, 712, DateTimeKind.Local).AddTicks(7669), new DateTime(2024, 8, 9, 8, 51, 42, 922, DateTimeKind.Local).AddTicks(435), 4348.06m },
                    { new Guid("b16954f5-b41f-4686-95c9-a2f6a5cbe288"), new Guid("75fe592b-5c1e-4814-a459-627bef01098f"), new DateTime(2024, 6, 16, 1, 49, 36, 747, DateTimeKind.Local).AddTicks(4471), new DateTime(2024, 8, 7, 23, 5, 42, 279, DateTimeKind.Local).AddTicks(2362), 3313.67m },
                    { new Guid("b1e22e96-aff4-4e50-a06e-8d198f897833"), new Guid("427269be-9018-4cf4-9818-4fae14114ae4"), new DateTime(2024, 3, 9, 7, 36, 57, 796, DateTimeKind.Local).AddTicks(5193), new DateTime(2024, 8, 8, 8, 0, 17, 893, DateTimeKind.Local).AddTicks(898), 2803.46m },
                    { new Guid("b20df73b-16f4-416c-af8c-ee7a26fd118d"), new Guid("9f2dcec6-cc02-45d6-95d0-fa0b53a5f953"), new DateTime(2024, 8, 3, 12, 41, 19, 84, DateTimeKind.Local).AddTicks(7513), new DateTime(2024, 8, 7, 11, 57, 12, 795, DateTimeKind.Local).AddTicks(9536), 4978.45m },
                    { new Guid("b219068d-6e05-4750-b818-92c2409bf82b"), new Guid("f0f1e5c8-88d3-4268-9c48-f6a85560db57"), new DateTime(2023, 9, 20, 3, 29, 59, 564, DateTimeKind.Local).AddTicks(5428), new DateTime(2024, 8, 8, 10, 17, 3, 253, DateTimeKind.Local).AddTicks(5920), 4113.61m },
                    { new Guid("b2336991-8e7a-4381-943a-acbb53f60b39"), new Guid("44514479-669b-45b2-8af4-510b0786de9b"), new DateTime(2023, 9, 21, 18, 54, 54, 984, DateTimeKind.Local).AddTicks(4323), new DateTime(2024, 8, 9, 20, 22, 9, 8, DateTimeKind.Local).AddTicks(7273), 3980.58m },
                    { new Guid("b2760b4c-930f-49b1-aa4e-557a82f799aa"), new Guid("17652753-332f-4654-89d0-bbca6d67670f"), new DateTime(2024, 3, 23, 6, 55, 27, 951, DateTimeKind.Local).AddTicks(753), new DateTime(2024, 8, 8, 4, 28, 33, 799, DateTimeKind.Local).AddTicks(1895), 3359.31m },
                    { new Guid("b2b265a2-7fa0-4bdd-bcb9-1f41ca16b8f7"), new Guid("5611f5df-6d74-47b4-b24b-5863bd50f032"), new DateTime(2023, 10, 17, 1, 8, 43, 20, DateTimeKind.Local).AddTicks(6234), new DateTime(2024, 8, 9, 10, 33, 1, 972, DateTimeKind.Local).AddTicks(993), 1257.92m },
                    { new Guid("b2e80910-33df-4181-bdca-c33fb3322c7e"), new Guid("cba2380d-ac66-4bca-9da1-3db07a53966f"), new DateTime(2024, 3, 3, 9, 46, 48, 909, DateTimeKind.Local).AddTicks(2952), new DateTime(2024, 8, 7, 16, 0, 41, 656, DateTimeKind.Local).AddTicks(8992), 1283.42m },
                    { new Guid("b2ece2a4-4534-4e77-a608-ccb0bcc0cd35"), new Guid("a89b1694-3065-45be-9b67-fb5d87dc35f5"), new DateTime(2024, 6, 18, 1, 28, 6, 41, DateTimeKind.Local).AddTicks(3696), new DateTime(2024, 8, 9, 6, 36, 32, 193, DateTimeKind.Local).AddTicks(1041), 927.78m },
                    { new Guid("b37d633c-368e-4246-b24c-108d2c65fb55"), new Guid("590c7122-bbd8-408c-9571-b8d385d97b9e"), new DateTime(2024, 4, 14, 16, 51, 45, 783, DateTimeKind.Local).AddTicks(4059), new DateTime(2024, 8, 7, 11, 35, 39, 707, DateTimeKind.Local).AddTicks(8356), 3120.24m },
                    { new Guid("b4452e16-981f-4edc-9797-25946dbfdb14"), new Guid("063fdb59-1945-4f6e-85e3-5f57321287f9"), new DateTime(2024, 4, 18, 12, 22, 13, 928, DateTimeKind.Local).AddTicks(5965), new DateTime(2024, 8, 8, 23, 32, 15, 530, DateTimeKind.Local).AddTicks(3349), 2256.45m },
                    { new Guid("b49b5d39-555e-4e84-887f-f8ce6d2cb539"), new Guid("d6d20276-ac8b-44d6-9939-d642e6335c51"), new DateTime(2024, 3, 28, 3, 55, 59, 202, DateTimeKind.Local).AddTicks(479), new DateTime(2024, 8, 7, 20, 4, 59, 541, DateTimeKind.Local).AddTicks(1868), 1479.74m },
                    { new Guid("b50a3afe-0c24-4ad3-b4d0-e0d13ca6a3ae"), new Guid("a38bfc8c-feac-4053-b76e-84c4e66d74d6"), new DateTime(2024, 6, 1, 5, 25, 11, 999, DateTimeKind.Local).AddTicks(6020), new DateTime(2024, 8, 9, 7, 33, 18, 353, DateTimeKind.Local).AddTicks(849), 4592.54m },
                    { new Guid("b5165072-3bca-4d6d-8658-dbeb7dfec416"), new Guid("697709be-b252-4405-bb7e-8673c6b98467"), new DateTime(2023, 10, 28, 13, 19, 20, 237, DateTimeKind.Local).AddTicks(4148), new DateTime(2024, 8, 9, 3, 58, 36, 928, DateTimeKind.Local).AddTicks(6120), 2902.93m },
                    { new Guid("b5893e1c-8664-442a-8c80-90499dfe1ffb"), new Guid("17544f0d-9e01-4955-b49a-dcc4b6a770ee"), new DateTime(2024, 1, 20, 17, 46, 25, 702, DateTimeKind.Local).AddTicks(2930), new DateTime(2024, 8, 8, 1, 37, 25, 907, DateTimeKind.Local).AddTicks(8456), 3165.15m },
                    { new Guid("b5954cf3-9e01-44db-8815-26417c78aa25"), new Guid("7b94208a-340f-4ed0-ad44-07a96fbc7d7a"), new DateTime(2024, 5, 12, 3, 1, 19, 633, DateTimeKind.Local).AddTicks(3653), new DateTime(2024, 8, 8, 14, 36, 20, 352, DateTimeKind.Local).AddTicks(6230), 1100.07m }
                });

            migrationBuilder.InsertData(
                table: "DonHangs",
                columns: new[] { "Id", "KhachHangId", "NgayDatHang", "NgayGiaoHang", "TongTien" },
                values: new object[,]
                {
                    { new Guid("b5d7d3c1-56d1-4d39-a3f2-f6da2c100467"), new Guid("38ba8024-3b8d-4dd6-92b9-9d06da12ec6e"), new DateTime(2023, 8, 25, 23, 33, 18, 232, DateTimeKind.Local).AddTicks(868), new DateTime(2024, 8, 9, 4, 46, 41, 477, DateTimeKind.Local).AddTicks(1885), 3882.05m },
                    { new Guid("b5f10978-b5a2-4c3e-85e9-afeab01fe7ad"), new Guid("1c79d0c4-56b9-4b08-af15-2fddc2c1068e"), new DateTime(2024, 7, 14, 6, 17, 22, 574, DateTimeKind.Local).AddTicks(4062), new DateTime(2024, 8, 9, 8, 19, 21, 165, DateTimeKind.Local).AddTicks(7184), 3116.93m },
                    { new Guid("b5f42422-6715-41f4-8b47-218c8dbdfcab"), new Guid("873734f8-2118-4bff-95ec-9e199770cefb"), new DateTime(2023, 9, 21, 0, 49, 56, 796, DateTimeKind.Local).AddTicks(4463), new DateTime(2024, 8, 9, 4, 48, 48, 341, DateTimeKind.Local).AddTicks(1364), 741.60m },
                    { new Guid("b612c714-1db0-41a8-bb1f-6cda510fd680"), new Guid("0b23e0d1-fa5b-4022-92b8-ff158e6d60ed"), new DateTime(2024, 4, 30, 9, 55, 21, 976, DateTimeKind.Local).AddTicks(9373), new DateTime(2024, 8, 9, 2, 28, 37, 525, DateTimeKind.Local).AddTicks(6024), 2880.88m },
                    { new Guid("b6460a39-93f6-4bd9-80a7-cc9c992971f8"), new Guid("28d8da78-c6c4-4afe-9d92-22d52e3969b0"), new DateTime(2024, 6, 26, 6, 2, 37, 890, DateTimeKind.Local).AddTicks(3804), new DateTime(2024, 8, 7, 12, 49, 50, 433, DateTimeKind.Local).AddTicks(1520), 1364.03m },
                    { new Guid("b6579706-1bfa-487e-8889-624dfa1652aa"), new Guid("ceeb839d-d443-4791-8018-561c89d6e7d9"), new DateTime(2024, 7, 4, 11, 48, 48, 640, DateTimeKind.Local).AddTicks(8651), new DateTime(2024, 8, 9, 2, 53, 56, 694, DateTimeKind.Local).AddTicks(7096), 3648.01m },
                    { new Guid("b6fdd0d9-082a-48ab-b492-29bc03c87af4"), new Guid("38ba8024-3b8d-4dd6-92b9-9d06da12ec6e"), new DateTime(2023, 11, 22, 7, 52, 9, 12, DateTimeKind.Local).AddTicks(1840), new DateTime(2024, 8, 7, 5, 22, 44, 927, DateTimeKind.Local).AddTicks(551), 1403.63m },
                    { new Guid("b703995d-5354-4911-992e-1635425587d8"), new Guid("c0ebc03b-08bf-4b16-89e2-4c86dec71a59"), new DateTime(2023, 10, 12, 2, 43, 15, 157, DateTimeKind.Local).AddTicks(2389), new DateTime(2024, 8, 8, 12, 41, 18, 739, DateTimeKind.Local).AddTicks(1470), 4788.88m },
                    { new Guid("b77a10a8-4296-4da5-864e-8fc3978ffcf5"), new Guid("2528ff79-cf89-4261-a0de-428d26b20a72"), new DateTime(2023, 9, 30, 4, 27, 55, 328, DateTimeKind.Local).AddTicks(5583), new DateTime(2024, 8, 8, 8, 34, 26, 639, DateTimeKind.Local).AddTicks(8292), 4996.92m },
                    { new Guid("b7918382-3dc9-489a-ba05-5a37720875e9"), new Guid("697709be-b252-4405-bb7e-8673c6b98467"), new DateTime(2023, 10, 8, 16, 58, 30, 324, DateTimeKind.Local).AddTicks(8468), new DateTime(2024, 8, 8, 3, 31, 29, 246, DateTimeKind.Local).AddTicks(7666), 2967.97m },
                    { new Guid("b7d48808-2fd1-47b0-9daa-38305ad40c7c"), new Guid("063fdb59-1945-4f6e-85e3-5f57321287f9"), new DateTime(2024, 1, 6, 12, 55, 5, 440, DateTimeKind.Local).AddTicks(7248), new DateTime(2024, 8, 8, 7, 59, 46, 670, DateTimeKind.Local).AddTicks(4758), 280.64m },
                    { new Guid("b84a524f-ad93-4b0e-84a5-136106b69f37"), new Guid("fa016e07-09ad-491e-a261-85cdebb45436"), new DateTime(2024, 5, 13, 17, 54, 17, 866, DateTimeKind.Local).AddTicks(3226), new DateTime(2024, 8, 9, 2, 1, 13, 397, DateTimeKind.Local).AddTicks(4985), 4081.01m },
                    { new Guid("b86229f0-c5ef-4d45-b9a2-02627ac12530"), new Guid("920b6ceb-11fd-4534-8c78-0adccdc2cbf5"), new DateTime(2023, 9, 21, 20, 36, 6, 929, DateTimeKind.Local).AddTicks(1652), new DateTime(2024, 8, 8, 10, 44, 37, 143, DateTimeKind.Local).AddTicks(8299), 1776.43m },
                    { new Guid("b8aa591d-926c-4c87-8717-8cc224fa3d25"), new Guid("6f10d3da-6328-4453-bd18-d299e75dca49"), new DateTime(2023, 11, 10, 14, 40, 22, 683, DateTimeKind.Local).AddTicks(3935), new DateTime(2024, 8, 7, 18, 10, 5, 156, DateTimeKind.Local).AddTicks(2165), 1891.55m },
                    { new Guid("b8c54c5a-0ea2-40ee-8655-25b057c6cb93"), new Guid("952cbe13-c448-4063-910c-4a6b51e895ce"), new DateTime(2024, 7, 27, 14, 44, 2, 586, DateTimeKind.Local).AddTicks(2729), new DateTime(2024, 8, 9, 19, 8, 2, 592, DateTimeKind.Local).AddTicks(4434), 3046.97m },
                    { new Guid("b8dbaa11-e232-452d-9e59-9d1ce52b2ff6"), new Guid("648119d0-d486-40c5-bd23-69a5e42b2ba5"), new DateTime(2024, 1, 12, 14, 20, 11, 169, DateTimeKind.Local).AddTicks(8279), new DateTime(2024, 8, 8, 7, 58, 51, 528, DateTimeKind.Local).AddTicks(7481), 2729.59m },
                    { new Guid("b9683a6b-b1b3-45ce-b8ba-97010122dd27"), new Guid("1d71e542-620f-4161-9842-a2a145bd7013"), new DateTime(2023, 11, 21, 4, 28, 0, 247, DateTimeKind.Local).AddTicks(1556), new DateTime(2024, 8, 7, 23, 16, 32, 755, DateTimeKind.Local).AddTicks(8216), 4936.49m },
                    { new Guid("b9773296-b805-4fb7-bb86-31286b963737"), new Guid("6d1e80c0-f438-45cd-a63c-9bf2330160b6"), new DateTime(2024, 4, 3, 22, 7, 58, 702, DateTimeKind.Local).AddTicks(2209), new DateTime(2024, 8, 9, 20, 46, 50, 153, DateTimeKind.Local).AddTicks(2923), 3517.45m },
                    { new Guid("b9b258e4-7629-4e39-b9e1-3d537f3cad4b"), new Guid("ceeb839d-d443-4791-8018-561c89d6e7d9"), new DateTime(2024, 7, 9, 0, 29, 12, 857, DateTimeKind.Local).AddTicks(7662), new DateTime(2024, 8, 6, 22, 47, 38, 919, DateTimeKind.Local).AddTicks(3331), 4146.18m },
                    { new Guid("b9e77d29-91d5-49b8-85fb-de3bb49776a1"), new Guid("33caf896-8425-48e6-86b5-a47f32bb1850"), new DateTime(2023, 11, 19, 6, 15, 27, 832, DateTimeKind.Local).AddTicks(2610), new DateTime(2024, 8, 7, 20, 53, 41, 34, DateTimeKind.Local).AddTicks(7474), 4481.96m },
                    { new Guid("ba3e6714-cdaf-45d6-af44-a03bc1e979a2"), new Guid("cce9a706-5e55-4052-a88e-26f4b6765bc9"), new DateTime(2023, 11, 11, 17, 30, 56, 705, DateTimeKind.Local).AddTicks(4680), new DateTime(2024, 8, 8, 21, 20, 32, 838, DateTimeKind.Local).AddTicks(803), 310.37m },
                    { new Guid("bab187b9-b808-425b-be12-6ac79eba84ad"), new Guid("0b23e0d1-fa5b-4022-92b8-ff158e6d60ed"), new DateTime(2023, 11, 22, 17, 30, 58, 701, DateTimeKind.Local).AddTicks(9403), new DateTime(2024, 8, 8, 11, 25, 24, 190, DateTimeKind.Local).AddTicks(2152), 1168.26m },
                    { new Guid("bac28b68-417a-47ae-a898-4b1bbf7055dc"), new Guid("b41438f5-9380-4cd7-bc4d-59267b9b760c"), new DateTime(2023, 8, 31, 3, 31, 21, 789, DateTimeKind.Local).AddTicks(1724), new DateTime(2024, 8, 7, 13, 45, 16, 920, DateTimeKind.Local).AddTicks(6074), 3696.78m },
                    { new Guid("bae904d2-7c3e-42d3-ba17-4c4ae1453390"), new Guid("3cd8e5f4-df7e-4a22-84a3-04966bad5197"), new DateTime(2024, 2, 22, 9, 2, 15, 733, DateTimeKind.Local).AddTicks(3823), new DateTime(2024, 8, 9, 22, 1, 4, 317, DateTimeKind.Local).AddTicks(6557), 3342.11m },
                    { new Guid("baf70bc6-31f6-4d01-b9fb-106d5c3f174a"), new Guid("8bc08888-8550-4e72-9b5e-71845b5b9567"), new DateTime(2024, 5, 8, 5, 51, 0, 844, DateTimeKind.Local).AddTicks(7292), new DateTime(2024, 8, 8, 8, 51, 2, 881, DateTimeKind.Local).AddTicks(959), 969.57m },
                    { new Guid("bb5263db-a85f-40ae-b8b7-fc9974d18643"), new Guid("46685f7f-ca60-41b6-8cfb-4124c89cd625"), new DateTime(2024, 2, 16, 16, 59, 49, 171, DateTimeKind.Local).AddTicks(9220), new DateTime(2024, 8, 9, 1, 3, 1, 986, DateTimeKind.Local).AddTicks(6919), 2391.59m },
                    { new Guid("bba7e357-00c6-41ca-a517-1e8421abb05e"), new Guid("3fd74fb4-2450-440d-8497-d9a630f57199"), new DateTime(2023, 11, 5, 18, 22, 5, 646, DateTimeKind.Local).AddTicks(3138), new DateTime(2024, 8, 8, 12, 30, 49, 621, DateTimeKind.Local).AddTicks(8360), 4978.40m },
                    { new Guid("bbb36c1e-f9eb-4e3e-9bf6-98ef456a0180"), new Guid("44514479-669b-45b2-8af4-510b0786de9b"), new DateTime(2024, 7, 19, 19, 11, 51, 121, DateTimeKind.Local).AddTicks(5474), new DateTime(2024, 8, 7, 10, 59, 16, 681, DateTimeKind.Local).AddTicks(4133), 415.83m },
                    { new Guid("bc295259-4bea-4f7c-8aba-7627404e208d"), new Guid("24256d4c-7032-4437-8c1e-dd211c5bd713"), new DateTime(2024, 4, 5, 21, 32, 55, 930, DateTimeKind.Local).AddTicks(2108), new DateTime(2024, 8, 6, 23, 29, 53, 844, DateTimeKind.Local).AddTicks(8263), 1021.09m },
                    { new Guid("bc4cc268-5e5b-4e49-be0b-8e3d1c0d54e7"), new Guid("1c79d0c4-56b9-4b08-af15-2fddc2c1068e"), new DateTime(2023, 8, 13, 1, 44, 33, 417, DateTimeKind.Local).AddTicks(7791), new DateTime(2024, 8, 9, 10, 4, 27, 196, DateTimeKind.Local).AddTicks(6564), 1543.94m },
                    { new Guid("bccb365a-7c4c-443c-bce5-bb7956dbb7c5"), new Guid("28eaff52-a12b-4084-83b9-02a26ca7dfbc"), new DateTime(2024, 7, 6, 3, 26, 13, 449, DateTimeKind.Local).AddTicks(9920), new DateTime(2024, 8, 8, 11, 12, 37, 253, DateTimeKind.Local).AddTicks(4033), 4247.66m },
                    { new Guid("bce4c652-cf67-427c-bceb-bc98d1be026b"), new Guid("1d71e542-620f-4161-9842-a2a145bd7013"), new DateTime(2024, 4, 15, 1, 39, 41, 330, DateTimeKind.Local).AddTicks(9437), new DateTime(2024, 8, 8, 4, 42, 36, 679, DateTimeKind.Local).AddTicks(4748), 4974.56m },
                    { new Guid("bd149492-acb0-490d-91eb-78e98e05e8ab"), new Guid("b78d1e60-56cf-4058-967c-7271f646af05"), new DateTime(2023, 10, 25, 18, 23, 8, 46, DateTimeKind.Local).AddTicks(1360), new DateTime(2024, 8, 9, 4, 37, 30, 711, DateTimeKind.Local).AddTicks(5184), 2920.92m },
                    { new Guid("bd23b2be-04d1-41e4-9d5c-4a3ac2755f4c"), new Guid("0b23e0d1-fa5b-4022-92b8-ff158e6d60ed"), new DateTime(2023, 12, 29, 2, 35, 31, 600, DateTimeKind.Local).AddTicks(4669), new DateTime(2024, 8, 7, 21, 51, 34, 63, DateTimeKind.Local).AddTicks(7779), 3543.28m },
                    { new Guid("bd2cbe28-e0dc-4860-91c5-9022e5b3f538"), new Guid("6fdebd38-1ce1-416f-af92-047978b186a5"), new DateTime(2023, 10, 30, 4, 56, 42, 902, DateTimeKind.Local).AddTicks(5697), new DateTime(2024, 8, 8, 17, 55, 59, 899, DateTimeKind.Local).AddTicks(9012), 89.64m },
                    { new Guid("bd5dd5b3-0585-40b7-9d1d-6d2682f40492"), new Guid("f9a1bd2e-de1a-42b8-b894-7f7e0b5b38f1"), new DateTime(2023, 12, 8, 4, 14, 14, 335, DateTimeKind.Local).AddTicks(5131), new DateTime(2024, 8, 9, 7, 21, 28, 154, DateTimeKind.Local).AddTicks(5995), 270.97m },
                    { new Guid("bdd9bafd-6f23-4015-8b35-81c16a2520e4"), new Guid("c0ebc03b-08bf-4b16-89e2-4c86dec71a59"), new DateTime(2023, 9, 24, 23, 41, 10, 817, DateTimeKind.Local).AddTicks(2157), new DateTime(2024, 8, 8, 11, 53, 40, 7, DateTimeKind.Local).AddTicks(1044), 266.70m },
                    { new Guid("bdf0d7f6-83ad-4ec6-ae8c-4ca753bbe277"), new Guid("99eb34d9-432d-450c-9c9f-1f90d43caf39"), new DateTime(2024, 4, 6, 17, 57, 56, 335, DateTimeKind.Local).AddTicks(8044), new DateTime(2024, 8, 8, 4, 49, 25, 394, DateTimeKind.Local).AddTicks(9842), 2648.34m },
                    { new Guid("be1a6a0d-47ea-41e3-8e95-b2b49aa74078"), new Guid("297e58cc-55d1-4c96-81c1-edd1b4b0ffb7"), new DateTime(2024, 2, 25, 4, 30, 39, 599, DateTimeKind.Local).AddTicks(7767), new DateTime(2024, 8, 8, 8, 57, 29, 863, DateTimeKind.Local).AddTicks(21), 4422.74m },
                    { new Guid("be4f884c-b9d7-4598-a2ac-f6a33ae6ba43"), new Guid("9f2dcec6-cc02-45d6-95d0-fa0b53a5f953"), new DateTime(2023, 9, 30, 0, 58, 22, 777, DateTimeKind.Local).AddTicks(3758), new DateTime(2024, 8, 9, 19, 2, 24, 433, DateTimeKind.Local).AddTicks(2492), 2436.66m },
                    { new Guid("be8b8345-9102-4bf1-9686-a04cd3c91b1a"), new Guid("5bc8e452-e383-427e-bc9b-c26642f1a642"), new DateTime(2024, 7, 9, 8, 32, 40, 879, DateTimeKind.Local).AddTicks(985), new DateTime(2024, 8, 9, 18, 35, 37, 506, DateTimeKind.Local).AddTicks(1218), 672.76m },
                    { new Guid("bfb4cb0d-115f-4cdd-a6dd-2c8a99e9391f"), new Guid("9f2dcec6-cc02-45d6-95d0-fa0b53a5f953"), new DateTime(2023, 11, 14, 16, 3, 49, 741, DateTimeKind.Local).AddTicks(9820), new DateTime(2024, 8, 8, 11, 41, 52, 151, DateTimeKind.Local).AddTicks(2694), 4040.57m }
                });

            migrationBuilder.InsertData(
                table: "DonHangs",
                columns: new[] { "Id", "KhachHangId", "NgayDatHang", "NgayGiaoHang", "TongTien" },
                values: new object[,]
                {
                    { new Guid("c011c8c3-f68e-4d60-9337-a6c26c5a4cda"), new Guid("24256d4c-7032-4437-8c1e-dd211c5bd713"), new DateTime(2023, 9, 2, 7, 1, 6, 185, DateTimeKind.Local).AddTicks(4077), new DateTime(2024, 8, 8, 5, 41, 51, 48, DateTimeKind.Local).AddTicks(8921), 4156.09m },
                    { new Guid("c017a9ce-0f5e-4b29-a436-404c00fb272b"), new Guid("17652753-332f-4654-89d0-bbca6d67670f"), new DateTime(2023, 8, 24, 4, 44, 13, 510, DateTimeKind.Local).AddTicks(9582), new DateTime(2024, 8, 7, 7, 9, 59, 255, DateTimeKind.Local).AddTicks(6335), 391.00m },
                    { new Guid("c02415a2-c2b2-44d1-a055-989ecb0c8975"), new Guid("841db90c-5f81-482a-a955-f91fc637a7f7"), new DateTime(2024, 1, 19, 2, 38, 8, 913, DateTimeKind.Local).AddTicks(4247), new DateTime(2024, 8, 7, 7, 30, 19, 949, DateTimeKind.Local).AddTicks(949), 2302.24m },
                    { new Guid("c08a0172-a879-4e52-9bf7-0fa9028988df"), new Guid("6f2bc11e-7dd7-4049-9e35-163927214820"), new DateTime(2024, 6, 13, 10, 59, 42, 64, DateTimeKind.Local).AddTicks(8731), new DateTime(2024, 8, 7, 20, 59, 37, 823, DateTimeKind.Local).AddTicks(3172), 4548.86m },
                    { new Guid("c0986bfc-cc6c-4f2d-9a2d-2edded750dbb"), new Guid("9865321a-433a-4caa-8050-884b34c7c8d8"), new DateTime(2024, 6, 21, 9, 48, 36, 861, DateTimeKind.Local).AddTicks(4324), new DateTime(2024, 8, 9, 7, 6, 11, 755, DateTimeKind.Local).AddTicks(2552), 3177.21m },
                    { new Guid("c0bbae79-ec4e-4953-8e73-7a97c77ff828"), new Guid("1d71e542-620f-4161-9842-a2a145bd7013"), new DateTime(2023, 10, 11, 19, 44, 10, 919, DateTimeKind.Local).AddTicks(5700), new DateTime(2024, 8, 8, 19, 2, 14, 693, DateTimeKind.Local).AddTicks(4812), 3133.48m },
                    { new Guid("c100fb08-bdd5-463f-93a1-4abd14278fdb"), new Guid("1248d1fb-1e80-4ded-926b-6b7f6d2249a5"), new DateTime(2024, 2, 17, 14, 1, 38, 3, DateTimeKind.Local).AddTicks(7275), new DateTime(2024, 8, 9, 6, 26, 22, 349, DateTimeKind.Local).AddTicks(1026), 4320.65m },
                    { new Guid("c14a7c07-7d19-48f4-9c85-8cc0d1d3bafe"), new Guid("c93b2790-efbb-4887-bc62-908698026478"), new DateTime(2023, 12, 19, 16, 48, 26, 765, DateTimeKind.Local).AddTicks(1209), new DateTime(2024, 8, 9, 7, 19, 9, 152, DateTimeKind.Local).AddTicks(3906), 3989.74m },
                    { new Guid("c170d3aa-91e0-4f17-9f60-9282a8d885c2"), new Guid("5611f5df-6d74-47b4-b24b-5863bd50f032"), new DateTime(2023, 12, 30, 9, 25, 55, 529, DateTimeKind.Local).AddTicks(7042), new DateTime(2024, 8, 7, 23, 23, 13, 777, DateTimeKind.Local).AddTicks(5165), 3954.18m },
                    { new Guid("c197b292-c9cd-41eb-9dfc-208e7ba0166b"), new Guid("44514479-669b-45b2-8af4-510b0786de9b"), new DateTime(2024, 1, 26, 11, 41, 15, 972, DateTimeKind.Local).AddTicks(6108), new DateTime(2024, 8, 9, 9, 40, 44, 6, DateTimeKind.Local).AddTicks(3209), 867.58m },
                    { new Guid("c1b1f263-4c3e-4d74-bcd0-88fb6950c67e"), new Guid("0b23e0d1-fa5b-4022-92b8-ff158e6d60ed"), new DateTime(2024, 4, 20, 8, 23, 58, 778, DateTimeKind.Local).AddTicks(2619), new DateTime(2024, 8, 7, 15, 35, 3, 692, DateTimeKind.Local).AddTicks(7808), 3419.90m },
                    { new Guid("c1c37e38-2978-46db-93e3-bab923bbddbb"), new Guid("fa016e07-09ad-491e-a261-85cdebb45436"), new DateTime(2024, 2, 12, 19, 14, 6, 5, DateTimeKind.Local).AddTicks(1005), new DateTime(2024, 8, 7, 20, 36, 42, 762, DateTimeKind.Local).AddTicks(9024), 4363.13m },
                    { new Guid("c20dc5a3-27a8-470b-9726-ee1ade136b73"), new Guid("3fd74fb4-2450-440d-8497-d9a630f57199"), new DateTime(2023, 12, 27, 5, 7, 48, 715, DateTimeKind.Local).AddTicks(3207), new DateTime(2024, 8, 8, 19, 27, 12, 24, DateTimeKind.Local).AddTicks(9607), 2430.19m },
                    { new Guid("c24c4f42-ba2e-416c-80f0-dbbe2ea3d9f7"), new Guid("886111c9-af92-447f-91bf-dad7b8a03eb5"), new DateTime(2024, 3, 31, 14, 44, 54, 922, DateTimeKind.Local).AddTicks(3409), new DateTime(2024, 8, 8, 20, 59, 37, 714, DateTimeKind.Local).AddTicks(4302), 4828.63m },
                    { new Guid("c26f0594-5758-42f3-a0fe-adfc5d1216d2"), new Guid("75fe592b-5c1e-4814-a459-627bef01098f"), new DateTime(2024, 2, 10, 8, 57, 26, 414, DateTimeKind.Local).AddTicks(4214), new DateTime(2024, 8, 8, 12, 32, 23, 757, DateTimeKind.Local).AddTicks(3262), 3121.54m },
                    { new Guid("c339fcda-00b4-4943-a902-b2a21217a09b"), new Guid("45859554-61d6-4f50-90eb-b40d19a17909"), new DateTime(2023, 11, 24, 11, 26, 4, 200, DateTimeKind.Local).AddTicks(7689), new DateTime(2024, 8, 9, 15, 44, 13, 222, DateTimeKind.Local).AddTicks(1283), 3332.89m },
                    { new Guid("c39bae6c-510d-4321-9620-69b169b8c483"), new Guid("427269be-9018-4cf4-9818-4fae14114ae4"), new DateTime(2024, 5, 25, 22, 0, 29, 959, DateTimeKind.Local).AddTicks(8075), new DateTime(2024, 8, 7, 1, 53, 13, 233, DateTimeKind.Local).AddTicks(107), 4503.58m },
                    { new Guid("c40c938e-5e06-4ff4-8797-a67e82c413e2"), new Guid("886111c9-af92-447f-91bf-dad7b8a03eb5"), new DateTime(2024, 1, 12, 15, 15, 31, 262, DateTimeKind.Local).AddTicks(2930), new DateTime(2024, 8, 8, 2, 28, 52, 456, DateTimeKind.Local).AddTicks(1705), 1192.03m },
                    { new Guid("c4315694-5023-498c-a79c-0b77e642d806"), new Guid("15883dbe-e97e-4859-86f7-993bbc1173df"), new DateTime(2024, 7, 24, 0, 55, 16, 14, DateTimeKind.Local).AddTicks(1938), new DateTime(2024, 8, 9, 12, 55, 19, 635, DateTimeKind.Local).AddTicks(2158), 118.45m },
                    { new Guid("c471208c-1076-4d7e-a239-96e1db958250"), new Guid("232fdc99-53fe-4232-9c74-06ddfb2a13b8"), new DateTime(2024, 6, 6, 22, 49, 56, 730, DateTimeKind.Local).AddTicks(9972), new DateTime(2024, 8, 7, 16, 32, 42, 107, DateTimeKind.Local).AddTicks(5178), 2861.83m },
                    { new Guid("c51f9c0b-eb81-4d3b-9869-8099c5f1c4ed"), new Guid("3da3214c-bd0e-4377-a9dd-da000298cefd"), new DateTime(2023, 12, 28, 14, 18, 18, 914, DateTimeKind.Local).AddTicks(475), new DateTime(2024, 8, 6, 22, 31, 38, 249, DateTimeKind.Local).AddTicks(3867), 555.74m },
                    { new Guid("c54e745c-70d9-435b-9cca-e04a6b99a102"), new Guid("a2e054b5-4260-4454-a995-281c00600f11"), new DateTime(2024, 4, 14, 21, 16, 21, 167, DateTimeKind.Local).AddTicks(9456), new DateTime(2024, 8, 8, 17, 40, 40, 149, DateTimeKind.Local).AddTicks(6424), 1135.64m },
                    { new Guid("c59e7653-3c11-4824-9263-e7fb713a9b2d"), new Guid("1e3c140e-4cab-4065-aadd-2c1cfed5ce14"), new DateTime(2023, 8, 31, 18, 2, 22, 756, DateTimeKind.Local).AddTicks(5705), new DateTime(2024, 8, 8, 3, 38, 40, 674, DateTimeKind.Local).AddTicks(6885), 2008.91m },
                    { new Guid("c59f37d7-9545-4288-a8cb-4ab159fd157c"), new Guid("8bc08888-8550-4e72-9b5e-71845b5b9567"), new DateTime(2023, 11, 10, 22, 47, 56, 797, DateTimeKind.Local).AddTicks(1695), new DateTime(2024, 8, 8, 3, 13, 51, 142, DateTimeKind.Local).AddTicks(5856), 229.78m },
                    { new Guid("c627b95f-3e3f-4da1-b124-b10e4d079319"), new Guid("9f2dcec6-cc02-45d6-95d0-fa0b53a5f953"), new DateTime(2023, 10, 27, 11, 22, 40, 472, DateTimeKind.Local).AddTicks(6845), new DateTime(2024, 8, 8, 8, 22, 34, 35, DateTimeKind.Local).AddTicks(9827), 4415.89m },
                    { new Guid("c6a242fe-575f-4645-adb5-57a950eecfd8"), new Guid("6f10d3da-6328-4453-bd18-d299e75dca49"), new DateTime(2023, 9, 3, 9, 16, 1, 497, DateTimeKind.Local).AddTicks(7128), new DateTime(2024, 8, 7, 5, 49, 37, 957, DateTimeKind.Local).AddTicks(6548), 4082.28m },
                    { new Guid("c6db9131-f0f5-43a3-856f-d707525e6671"), new Guid("1cab312c-e326-4c44-ae00-5542888dfbc9"), new DateTime(2024, 5, 10, 23, 27, 13, 894, DateTimeKind.Local).AddTicks(7391), new DateTime(2024, 8, 7, 12, 48, 43, 631, DateTimeKind.Local).AddTicks(3924), 2521.55m },
                    { new Guid("c709c332-f178-4d95-8eab-65f5db308215"), new Guid("1c79d0c4-56b9-4b08-af15-2fddc2c1068e"), new DateTime(2024, 3, 5, 12, 7, 9, 642, DateTimeKind.Local).AddTicks(2013), new DateTime(2024, 8, 8, 3, 59, 21, 677, DateTimeKind.Local).AddTicks(7661), 4321.02m },
                    { new Guid("c790bad3-772e-4b61-a984-545d4f82a4f1"), new Guid("5e4be06c-1976-4755-aeb0-28dae4b4298b"), new DateTime(2024, 1, 29, 7, 15, 39, 561, DateTimeKind.Local).AddTicks(9045), new DateTime(2024, 8, 8, 17, 42, 4, 862, DateTimeKind.Local).AddTicks(2537), 4540.94m },
                    { new Guid("c7ebea32-2598-46eb-9c55-aa5e69a879c7"), new Guid("a99891d8-254d-4ec7-8cae-cf3bcb8c10a1"), new DateTime(2024, 2, 20, 8, 6, 26, 109, DateTimeKind.Local).AddTicks(7311), new DateTime(2024, 8, 8, 4, 3, 59, 135, DateTimeKind.Local).AddTicks(2148), 563.45m },
                    { new Guid("c837c45c-4739-4c4a-8719-74ba48574bd9"), new Guid("920b6ceb-11fd-4534-8c78-0adccdc2cbf5"), new DateTime(2024, 3, 5, 18, 25, 21, 605, DateTimeKind.Local).AddTicks(8644), new DateTime(2024, 8, 8, 8, 29, 32, 453, DateTimeKind.Local).AddTicks(4235), 4287.31m },
                    { new Guid("c8822db7-f9da-4066-bd4e-149604d30eeb"), new Guid("b41438f5-9380-4cd7-bc4d-59267b9b760c"), new DateTime(2024, 2, 3, 16, 45, 27, 659, DateTimeKind.Local).AddTicks(7543), new DateTime(2024, 8, 7, 13, 30, 2, 979, DateTimeKind.Local).AddTicks(9399), 2845.93m },
                    { new Guid("c88cc245-e8dc-4a34-bbec-24c492b290dc"), new Guid("f9a1bd2e-de1a-42b8-b894-7f7e0b5b38f1"), new DateTime(2023, 11, 17, 4, 55, 45, 492, DateTimeKind.Local).AddTicks(7126), new DateTime(2024, 8, 9, 0, 43, 10, 984, DateTimeKind.Local).AddTicks(6562), 443.33m },
                    { new Guid("c8a3bf39-8b77-4a62-983d-f1496d7e4004"), new Guid("c0ebc03b-08bf-4b16-89e2-4c86dec71a59"), new DateTime(2024, 2, 16, 20, 31, 59, 402, DateTimeKind.Local).AddTicks(2075), new DateTime(2024, 8, 7, 19, 5, 10, 834, DateTimeKind.Local).AddTicks(4042), 654.20m },
                    { new Guid("c8bb7f49-3a9e-4907-9d16-ab361c9d88a4"), new Guid("5ee23c83-8a7a-498c-96a6-f2bc6fdc8136"), new DateTime(2023, 9, 10, 19, 21, 48, 970, DateTimeKind.Local).AddTicks(1505), new DateTime(2024, 8, 9, 11, 7, 39, 315, DateTimeKind.Local).AddTicks(8017), 996.24m },
                    { new Guid("c8c3889f-849b-4449-aae4-263b558e20cb"), new Guid("28d8da78-c6c4-4afe-9d92-22d52e3969b0"), new DateTime(2023, 11, 15, 14, 14, 42, 674, DateTimeKind.Local).AddTicks(2207), new DateTime(2024, 8, 8, 11, 26, 16, 382, DateTimeKind.Local).AddTicks(7271), 2481.90m },
                    { new Guid("c8d90285-aaff-4d91-86b7-c1bd36951a14"), new Guid("232fdc99-53fe-4232-9c74-06ddfb2a13b8"), new DateTime(2023, 8, 16, 12, 54, 53, 729, DateTimeKind.Local).AddTicks(1263), new DateTime(2024, 8, 9, 16, 58, 51, 898, DateTimeKind.Local).AddTicks(4263), 1347.74m },
                    { new Guid("c978e902-1917-4dac-9ac5-13f3f1fe5a3d"), new Guid("5ee23c83-8a7a-498c-96a6-f2bc6fdc8136"), new DateTime(2024, 7, 7, 2, 38, 25, 477, DateTimeKind.Local).AddTicks(8136), new DateTime(2024, 8, 9, 0, 46, 28, 792, DateTimeKind.Local).AddTicks(1990), 1620.20m },
                    { new Guid("c9f0a790-f0a9-45e6-9118-f8714d346a5f"), new Guid("28eaff52-a12b-4084-83b9-02a26ca7dfbc"), new DateTime(2023, 8, 17, 2, 36, 57, 485, DateTimeKind.Local).AddTicks(8033), new DateTime(2024, 8, 7, 12, 41, 44, 743, DateTimeKind.Local).AddTicks(5007), 1538.06m },
                    { new Guid("c9fe61e4-dc32-48bb-9930-1cc61bb6e94b"), new Guid("cba2380d-ac66-4bca-9da1-3db07a53966f"), new DateTime(2023, 8, 7, 14, 20, 55, 449, DateTimeKind.Local).AddTicks(3982), new DateTime(2024, 8, 7, 10, 14, 54, 10, DateTimeKind.Local).AddTicks(9687), 4145.83m },
                    { new Guid("ca366ff6-3dde-41b4-b92c-971bc969b32b"), new Guid("b41438f5-9380-4cd7-bc4d-59267b9b760c"), new DateTime(2024, 3, 15, 19, 9, 43, 911, DateTimeKind.Local).AddTicks(9838), new DateTime(2024, 8, 9, 4, 39, 2, 154, DateTimeKind.Local).AddTicks(6659), 314.73m },
                    { new Guid("caa9c4b6-84e8-4952-838d-b09c6d9a54d2"), new Guid("063fdb59-1945-4f6e-85e3-5f57321287f9"), new DateTime(2024, 2, 25, 10, 18, 9, 700, DateTimeKind.Local).AddTicks(4025), new DateTime(2024, 8, 8, 8, 48, 28, 44, DateTimeKind.Local).AddTicks(4557), 1922.86m }
                });

            migrationBuilder.InsertData(
                table: "DonHangs",
                columns: new[] { "Id", "KhachHangId", "NgayDatHang", "NgayGiaoHang", "TongTien" },
                values: new object[,]
                {
                    { new Guid("cadf0807-ec08-48a1-b92b-e19ade7f99ae"), new Guid("1248d1fb-1e80-4ded-926b-6b7f6d2249a5"), new DateTime(2023, 12, 1, 10, 38, 40, 691, DateTimeKind.Local).AddTicks(898), new DateTime(2024, 8, 7, 9, 41, 17, 542, DateTimeKind.Local).AddTicks(2102), 4938.44m },
                    { new Guid("cbac5243-f7af-4237-9c17-e16c2e8ace79"), new Guid("b22bc921-a93c-4461-8bd3-df4b1e010bc1"), new DateTime(2024, 2, 16, 18, 18, 29, 141, DateTimeKind.Local).AddTicks(776), new DateTime(2024, 8, 9, 9, 54, 37, 975, DateTimeKind.Local).AddTicks(3849), 3864.66m },
                    { new Guid("cc0f554e-30a2-42ba-b49d-70ae7c352391"), new Guid("88603d45-af2e-4381-b8d8-2c53ebbaccd2"), new DateTime(2024, 3, 24, 11, 10, 58, 920, DateTimeKind.Local).AddTicks(5241), new DateTime(2024, 8, 9, 8, 52, 9, 442, DateTimeKind.Local).AddTicks(4392), 1386.32m },
                    { new Guid("cc61712f-18cd-4a2d-add7-f69a3e4863c3"), new Guid("297e58cc-55d1-4c96-81c1-edd1b4b0ffb7"), new DateTime(2023, 11, 9, 0, 9, 0, 163, DateTimeKind.Local).AddTicks(2950), new DateTime(2024, 8, 7, 2, 26, 44, 140, DateTimeKind.Local).AddTicks(4774), 1300.00m },
                    { new Guid("cc66453b-5b8b-4299-8f69-42c9bec3182d"), new Guid("3da3214c-bd0e-4377-a9dd-da000298cefd"), new DateTime(2024, 5, 2, 23, 36, 57, 646, DateTimeKind.Local).AddTicks(7984), new DateTime(2024, 8, 9, 13, 18, 36, 636, DateTimeKind.Local).AddTicks(1251), 1926.38m },
                    { new Guid("ccabfeb9-f53f-436f-9883-35d05586ca8e"), new Guid("d84600ec-9767-4cd9-8221-62d22397acaa"), new DateTime(2024, 6, 7, 8, 28, 37, 524, DateTimeKind.Local).AddTicks(5518), new DateTime(2024, 8, 8, 3, 8, 54, 941, DateTimeKind.Local).AddTicks(8820), 702.21m },
                    { new Guid("ccee8e4d-3421-4352-9ec9-e06a113fb982"), new Guid("a89b1694-3065-45be-9b67-fb5d87dc35f5"), new DateTime(2024, 1, 28, 2, 46, 8, 767, DateTimeKind.Local).AddTicks(5449), new DateTime(2024, 8, 7, 12, 28, 39, 885, DateTimeKind.Local).AddTicks(3865), 3934.02m },
                    { new Guid("cd45c8fe-78fa-49d3-af7d-34f847add27b"), new Guid("648119d0-d486-40c5-bd23-69a5e42b2ba5"), new DateTime(2023, 10, 27, 2, 6, 33, 279, DateTimeKind.Local).AddTicks(5067), new DateTime(2024, 8, 9, 9, 16, 44, 149, DateTimeKind.Local).AddTicks(371), 1269.25m },
                    { new Guid("cd4b970a-5688-4c71-b144-67f578e34780"), new Guid("93fb1f32-f25c-41b4-91a2-c22a92a4ab83"), new DateTime(2024, 4, 19, 3, 52, 6, 936, DateTimeKind.Local).AddTicks(807), new DateTime(2024, 8, 9, 13, 9, 15, 310, DateTimeKind.Local).AddTicks(5241), 3692.11m },
                    { new Guid("cd51de7c-98c5-42b0-a829-f6764fd073a7"), new Guid("33caf896-8425-48e6-86b5-a47f32bb1850"), new DateTime(2024, 2, 26, 3, 17, 10, 383, DateTimeKind.Local).AddTicks(4720), new DateTime(2024, 8, 9, 11, 21, 55, 298, DateTimeKind.Local).AddTicks(7612), 819.15m },
                    { new Guid("cd6f758d-3215-4e01-b3f6-fc990c9ba478"), new Guid("90fb9bfe-da70-4392-9904-4417fab257a7"), new DateTime(2023, 10, 25, 0, 36, 16, 934, DateTimeKind.Local).AddTicks(2723), new DateTime(2024, 8, 7, 2, 37, 45, 294, DateTimeKind.Local).AddTicks(8253), 544.66m },
                    { new Guid("ceaa4b83-3cbe-48ea-ae40-937b0d6c9ffe"), new Guid("a38bfc8c-feac-4053-b76e-84c4e66d74d6"), new DateTime(2024, 3, 16, 21, 29, 18, 726, DateTimeKind.Local).AddTicks(7397), new DateTime(2024, 8, 8, 22, 4, 16, 376, DateTimeKind.Local).AddTicks(8268), 1376.45m },
                    { new Guid("cf357925-75b7-411d-9dcc-fe2cf2dd3ea3"), new Guid("93fb1f32-f25c-41b4-91a2-c22a92a4ab83"), new DateTime(2024, 1, 19, 0, 52, 3, 54, DateTimeKind.Local).AddTicks(3940), new DateTime(2024, 8, 9, 13, 40, 39, 266, DateTimeKind.Local).AddTicks(485), 1372.33m },
                    { new Guid("d0c60e91-c22b-4673-a354-dbb6ad4d73be"), new Guid("2463d0a4-5008-43f5-97fd-bbd3d0048d8e"), new DateTime(2024, 1, 7, 2, 51, 17, 651, DateTimeKind.Local).AddTicks(1661), new DateTime(2024, 8, 8, 11, 22, 0, 616, DateTimeKind.Local).AddTicks(2466), 3412.88m },
                    { new Guid("d0cf2471-9597-4260-b0a3-cb8ce3d21aa7"), new Guid("4ebf8ce2-efc1-4c0d-8c61-7159ede74521"), new DateTime(2024, 6, 25, 11, 24, 25, 608, DateTimeKind.Local).AddTicks(8227), new DateTime(2024, 8, 7, 23, 34, 7, 771, DateTimeKind.Local).AddTicks(1241), 296.61m },
                    { new Guid("d12e54ab-78ae-4622-9099-465f6d4f0006"), new Guid("9865321a-433a-4caa-8050-884b34c7c8d8"), new DateTime(2024, 1, 18, 0, 24, 55, 448, DateTimeKind.Local).AddTicks(9164), new DateTime(2024, 8, 8, 7, 20, 54, 203, DateTimeKind.Local).AddTicks(3218), 3361.52m },
                    { new Guid("d23736f7-d9f8-40e6-9d70-ceff27bd0f44"), new Guid("33caf896-8425-48e6-86b5-a47f32bb1850"), new DateTime(2023, 9, 2, 16, 5, 39, 623, DateTimeKind.Local).AddTicks(9119), new DateTime(2024, 8, 7, 3, 52, 21, 264, DateTimeKind.Local).AddTicks(9300), 66.34m },
                    { new Guid("d2cb7b31-c304-4f58-bd50-a4d92b4488e5"), new Guid("d84600ec-9767-4cd9-8221-62d22397acaa"), new DateTime(2024, 2, 6, 0, 29, 0, 218, DateTimeKind.Local).AddTicks(2982), new DateTime(2024, 8, 9, 15, 15, 0, 99, DateTimeKind.Local).AddTicks(8989), 3764.45m },
                    { new Guid("d2e86d06-a997-466f-ba6d-85420d51f086"), new Guid("5bc8e452-e383-427e-bc9b-c26642f1a642"), new DateTime(2023, 12, 16, 15, 31, 16, 115, DateTimeKind.Local).AddTicks(2127), new DateTime(2024, 8, 8, 22, 44, 4, 764, DateTimeKind.Local).AddTicks(5605), 774.28m },
                    { new Guid("d341e770-4837-4ee4-8fc2-12a02da59390"), new Guid("a38bfc8c-feac-4053-b76e-84c4e66d74d6"), new DateTime(2024, 5, 1, 4, 48, 5, 598, DateTimeKind.Local).AddTicks(9199), new DateTime(2024, 8, 9, 18, 6, 9, 501, DateTimeKind.Local).AddTicks(7455), 4102.42m },
                    { new Guid("d3514f42-3dc9-48df-a2d5-5995281a706c"), new Guid("e56e8c86-41ee-47fd-9d05-a94a167bed10"), new DateTime(2024, 1, 18, 1, 49, 53, 976, DateTimeKind.Local).AddTicks(3636), new DateTime(2024, 8, 7, 14, 41, 28, 98, DateTimeKind.Local).AddTicks(6047), 1358.87m },
                    { new Guid("d38e9579-27a2-4366-94de-31ef6f164067"), new Guid("d43ed679-0d22-40c7-a14a-6d01fe86c193"), new DateTime(2024, 1, 23, 15, 21, 40, 913, DateTimeKind.Local).AddTicks(1326), new DateTime(2024, 8, 8, 0, 1, 4, 431, DateTimeKind.Local).AddTicks(7566), 616.62m },
                    { new Guid("d39de1c6-5336-4968-b458-483b536b8f9d"), new Guid("d5d71173-e817-45f8-9146-4b7ab7c7b686"), new DateTime(2023, 11, 9, 1, 4, 4, 748, DateTimeKind.Local).AddTicks(9402), new DateTime(2024, 8, 9, 7, 12, 26, 783, DateTimeKind.Local).AddTicks(1302), 3076.38m },
                    { new Guid("d3a61c4f-7549-46fb-aa29-07c4a97be99f"), new Guid("3fd74fb4-2450-440d-8497-d9a630f57199"), new DateTime(2024, 4, 20, 11, 18, 15, 15, DateTimeKind.Local).AddTicks(2051), new DateTime(2024, 8, 7, 3, 52, 9, 615, DateTimeKind.Local).AddTicks(9607), 1707.02m },
                    { new Guid("d3b026e1-799f-4009-90a8-06754d3ea335"), new Guid("7b94208a-340f-4ed0-ad44-07a96fbc7d7a"), new DateTime(2023, 10, 15, 16, 53, 9, 276, DateTimeKind.Local).AddTicks(798), new DateTime(2024, 8, 6, 23, 18, 53, 162, DateTimeKind.Local).AddTicks(4536), 4854.92m },
                    { new Guid("d3e4eff6-8250-483c-be1c-ce742c9e6a49"), new Guid("a2e054b5-4260-4454-a995-281c00600f11"), new DateTime(2023, 10, 18, 0, 58, 22, 112, DateTimeKind.Local).AddTicks(9260), new DateTime(2024, 8, 9, 5, 46, 0, 59, DateTimeKind.Local).AddTicks(1102), 4723.47m },
                    { new Guid("d432e27b-a51d-458c-8681-f3b1a5836eda"), new Guid("052538e6-f9b6-4bd1-98e0-6e7d6744fb4a"), new DateTime(2024, 7, 24, 22, 32, 21, 459, DateTimeKind.Local).AddTicks(4367), new DateTime(2024, 8, 8, 13, 19, 19, 221, DateTimeKind.Local).AddTicks(3680), 1208.11m },
                    { new Guid("d442b089-4f55-4f12-b2e9-b514151b546a"), new Guid("7395222e-7744-4172-86d1-1b128230fabf"), new DateTime(2023, 12, 5, 12, 17, 7, 177, DateTimeKind.Local).AddTicks(1329), new DateTime(2024, 8, 9, 18, 12, 15, 918, DateTimeKind.Local).AddTicks(718), 1992.66m },
                    { new Guid("d4a6e198-8067-4d5a-8779-b31dc15cd71e"), new Guid("3fd74fb4-2450-440d-8497-d9a630f57199"), new DateTime(2023, 9, 8, 12, 3, 0, 26, DateTimeKind.Local).AddTicks(895), new DateTime(2024, 8, 9, 2, 57, 55, 70, DateTimeKind.Local).AddTicks(6608), 914.63m },
                    { new Guid("d51df2b5-636f-4fcf-8e5e-632efb1f70b7"), new Guid("ec92935c-29c1-47d3-9ff2-3aed6a0974f2"), new DateTime(2024, 6, 4, 18, 22, 15, 920, DateTimeKind.Local).AddTicks(741), new DateTime(2024, 8, 7, 4, 18, 8, 389, DateTimeKind.Local).AddTicks(7817), 2616.05m },
                    { new Guid("d520d856-d130-4020-93c1-fcbacc44cf26"), new Guid("232fdc99-53fe-4232-9c74-06ddfb2a13b8"), new DateTime(2024, 5, 14, 5, 27, 50, 494, DateTimeKind.Local).AddTicks(6293), new DateTime(2024, 8, 8, 17, 49, 9, 560, DateTimeKind.Local).AddTicks(6038), 3892.02m },
                    { new Guid("d57d6f15-c980-4ac4-b843-9c03faccfda2"), new Guid("5e4be06c-1976-4755-aeb0-28dae4b4298b"), new DateTime(2024, 5, 29, 14, 25, 52, 282, DateTimeKind.Local).AddTicks(7420), new DateTime(2024, 8, 8, 15, 51, 13, 11, DateTimeKind.Local).AddTicks(187), 396.13m },
                    { new Guid("d59ce5fd-0d3c-4dc3-b033-cdd6b2e12fa7"), new Guid("9865321a-433a-4caa-8050-884b34c7c8d8"), new DateTime(2024, 2, 28, 18, 13, 18, 505, DateTimeKind.Local).AddTicks(7305), new DateTime(2024, 8, 7, 4, 40, 30, 509, DateTimeKind.Local).AddTicks(4603), 3859.55m },
                    { new Guid("d69e29cb-bf3e-4820-b876-3e598012c153"), new Guid("21d87d9e-43c6-46d1-bfee-644940fd9d64"), new DateTime(2024, 8, 1, 10, 26, 3, 269, DateTimeKind.Local).AddTicks(9617), new DateTime(2024, 8, 9, 21, 41, 32, 424, DateTimeKind.Local).AddTicks(7159), 2076.63m },
                    { new Guid("d6bba81b-0577-4e21-98c7-1468aade531e"), new Guid("2528ff79-cf89-4261-a0de-428d26b20a72"), new DateTime(2024, 7, 8, 0, 29, 23, 846, DateTimeKind.Local).AddTicks(2335), new DateTime(2024, 8, 7, 10, 43, 33, 827, DateTimeKind.Local).AddTicks(7980), 743.04m },
                    { new Guid("d6d387b0-1a7a-469b-83fb-12e49c6f97a9"), new Guid("0667960a-b942-408f-9aa5-8591f0e0599a"), new DateTime(2024, 6, 14, 11, 42, 1, 352, DateTimeKind.Local).AddTicks(7444), new DateTime(2024, 8, 9, 15, 46, 8, 589, DateTimeKind.Local).AddTicks(2999), 917.95m },
                    { new Guid("d6f50ee8-b79c-40d1-bfbb-9644af6b23c9"), new Guid("17652753-332f-4654-89d0-bbca6d67670f"), new DateTime(2024, 6, 4, 16, 26, 43, 779, DateTimeKind.Local).AddTicks(8865), new DateTime(2024, 8, 9, 20, 48, 29, 786, DateTimeKind.Local).AddTicks(9047), 4317.77m },
                    { new Guid("d7c376fb-1d99-4cbb-a06d-620889206625"), new Guid("a89b1694-3065-45be-9b67-fb5d87dc35f5"), new DateTime(2024, 7, 18, 4, 48, 13, 755, DateTimeKind.Local).AddTicks(6712), new DateTime(2024, 8, 9, 1, 39, 31, 846, DateTimeKind.Local).AddTicks(4052), 4652.58m },
                    { new Guid("d82dda52-2f32-41e1-b5cf-1fa2d417e958"), new Guid("1e3c140e-4cab-4065-aadd-2c1cfed5ce14"), new DateTime(2024, 6, 18, 3, 26, 26, 965, DateTimeKind.Local).AddTicks(4266), new DateTime(2024, 8, 8, 18, 48, 15, 463, DateTimeKind.Local).AddTicks(9452), 1050.18m },
                    { new Guid("d85cd894-9333-4d3e-a3ad-31a545c28e49"), new Guid("b0074e79-8782-48c2-b497-9ae7bd24e960"), new DateTime(2023, 12, 10, 6, 32, 3, 500, DateTimeKind.Local).AddTicks(714), new DateTime(2024, 8, 9, 6, 19, 40, 235, DateTimeKind.Local).AddTicks(2287), 877.60m },
                    { new Guid("d86914f7-be42-458a-8834-02ed02923c6c"), new Guid("2463d0a4-5008-43f5-97fd-bbd3d0048d8e"), new DateTime(2024, 2, 4, 21, 21, 47, 71, DateTimeKind.Local).AddTicks(9280), new DateTime(2024, 8, 8, 20, 4, 54, 143, DateTimeKind.Local).AddTicks(663), 912.82m },
                    { new Guid("d93e8d41-af55-4fca-a212-1a4fc27c4cdd"), new Guid("eb503b18-f1e1-4a47-8871-99a4746eb8c6"), new DateTime(2024, 5, 24, 22, 46, 14, 538, DateTimeKind.Local).AddTicks(4901), new DateTime(2024, 8, 8, 23, 11, 10, 711, DateTimeKind.Local).AddTicks(796), 1463.75m }
                });

            migrationBuilder.InsertData(
                table: "DonHangs",
                columns: new[] { "Id", "KhachHangId", "NgayDatHang", "NgayGiaoHang", "TongTien" },
                values: new object[,]
                {
                    { new Guid("d9676a5a-fa16-49f7-9de7-1eb31fed3fc9"), new Guid("0667960a-b942-408f-9aa5-8591f0e0599a"), new DateTime(2024, 3, 15, 22, 58, 5, 320, DateTimeKind.Local).AddTicks(3087), new DateTime(2024, 8, 9, 4, 49, 20, 524, DateTimeKind.Local).AddTicks(4349), 3207.66m },
                    { new Guid("d9ccdcc5-eef7-4da3-b921-ee17683205d5"), new Guid("28eaff52-a12b-4084-83b9-02a26ca7dfbc"), new DateTime(2024, 2, 5, 22, 34, 33, 935, DateTimeKind.Local).AddTicks(7373), new DateTime(2024, 8, 7, 13, 1, 24, 607, DateTimeKind.Local).AddTicks(7373), 3152.21m },
                    { new Guid("d9db161e-d442-4ca9-a975-2a77fb242ee2"), new Guid("1e3c140e-4cab-4065-aadd-2c1cfed5ce14"), new DateTime(2023, 11, 3, 4, 58, 2, 399, DateTimeKind.Local).AddTicks(7389), new DateTime(2024, 8, 8, 9, 16, 4, 94, DateTimeKind.Local).AddTicks(8703), 4842.21m },
                    { new Guid("da65f643-a8a5-4984-ab6b-cb8808dbd5d4"), new Guid("88603d45-af2e-4381-b8d8-2c53ebbaccd2"), new DateTime(2023, 9, 12, 0, 38, 18, 773, DateTimeKind.Local).AddTicks(8206), new DateTime(2024, 8, 7, 20, 52, 23, 512, DateTimeKind.Local).AddTicks(3125), 4504.38m },
                    { new Guid("da6de4a9-c99d-49aa-977d-de56969cbbd3"), new Guid("873734f8-2118-4bff-95ec-9e199770cefb"), new DateTime(2024, 4, 25, 1, 45, 7, 144, DateTimeKind.Local).AddTicks(8465), new DateTime(2024, 8, 7, 2, 52, 7, 915, DateTimeKind.Local).AddTicks(8437), 4007.25m },
                    { new Guid("da717af2-5f0d-453a-9aff-ba91d7347689"), new Guid("a89b1694-3065-45be-9b67-fb5d87dc35f5"), new DateTime(2023, 8, 29, 8, 57, 13, 957, DateTimeKind.Local).AddTicks(5078), new DateTime(2024, 8, 8, 12, 27, 52, 628, DateTimeKind.Local).AddTicks(7305), 4042.30m },
                    { new Guid("dac99f2e-5f53-4989-9ed7-bdf01061d44a"), new Guid("6b4bca52-0cf9-4a9e-98cf-0eb6e3c24da0"), new DateTime(2024, 3, 23, 12, 48, 12, 998, DateTimeKind.Local).AddTicks(492), new DateTime(2024, 8, 9, 11, 50, 55, 964, DateTimeKind.Local).AddTicks(2281), 3033.04m },
                    { new Guid("daf1cf53-5346-496e-9697-4c0c03f31475"), new Guid("90ece793-c6f5-47e7-8aa0-7c08ff3548fb"), new DateTime(2024, 4, 3, 2, 29, 39, 179, DateTimeKind.Local).AddTicks(5976), new DateTime(2024, 8, 8, 3, 10, 40, 203, DateTimeKind.Local).AddTicks(3594), 2439.18m },
                    { new Guid("daf75460-a6c6-4af0-b6bf-73ee9113293a"), new Guid("d84600ec-9767-4cd9-8221-62d22397acaa"), new DateTime(2024, 4, 1, 3, 11, 6, 223, DateTimeKind.Local).AddTicks(5169), new DateTime(2024, 8, 8, 3, 50, 49, 912, DateTimeKind.Local).AddTicks(2144), 583.10m },
                    { new Guid("db27045c-36d2-431e-9cde-29a138c57fd2"), new Guid("28eaff52-a12b-4084-83b9-02a26ca7dfbc"), new DateTime(2024, 1, 15, 22, 36, 31, 717, DateTimeKind.Local).AddTicks(527), new DateTime(2024, 8, 7, 17, 31, 15, 520, DateTimeKind.Local).AddTicks(2099), 785.27m },
                    { new Guid("dc2f05f8-e36b-4eaf-8f6d-c998470d18c3"), new Guid("cba2380d-ac66-4bca-9da1-3db07a53966f"), new DateTime(2024, 3, 8, 23, 49, 35, 458, DateTimeKind.Local).AddTicks(5545), new DateTime(2024, 8, 9, 21, 16, 9, 683, DateTimeKind.Local).AddTicks(9531), 542.49m },
                    { new Guid("dc9294d3-baeb-400d-b0bb-6516046b473b"), new Guid("e9d684aa-183f-423f-8741-1a53cfb8f2e3"), new DateTime(2023, 8, 22, 8, 23, 33, 247, DateTimeKind.Local).AddTicks(7108), new DateTime(2024, 8, 9, 16, 29, 12, 609, DateTimeKind.Local).AddTicks(5101), 3994.35m },
                    { new Guid("dc99b99d-c977-4d8f-9b46-b5e98bc93eae"), new Guid("6212ef8f-9777-42a2-ad28-a2ed1ebe90f8"), new DateTime(2023, 12, 12, 4, 37, 4, 968, DateTimeKind.Local).AddTicks(5618), new DateTime(2024, 8, 7, 6, 5, 35, 718, DateTimeKind.Local).AddTicks(85), 4123.72m },
                    { new Guid("dce6a741-56f3-420b-97ce-c08ec245c09b"), new Guid("28d8da78-c6c4-4afe-9d92-22d52e3969b0"), new DateTime(2024, 5, 11, 9, 14, 32, 413, DateTimeKind.Local).AddTicks(4324), new DateTime(2024, 8, 9, 2, 20, 36, 46, DateTimeKind.Local).AddTicks(8679), 604.99m },
                    { new Guid("dd2134ef-4d90-459e-b6a9-37c8e59c7751"), new Guid("88888a0c-f1ed-4613-9646-ee6509dc5db0"), new DateTime(2024, 3, 9, 9, 36, 37, 135, DateTimeKind.Local).AddTicks(8481), new DateTime(2024, 8, 8, 1, 55, 35, 911, DateTimeKind.Local).AddTicks(1715), 4078.37m },
                    { new Guid("dd4a6b8d-5669-4797-8010-449a21dfe5de"), new Guid("8bc08888-8550-4e72-9b5e-71845b5b9567"), new DateTime(2024, 1, 17, 15, 56, 43, 480, DateTimeKind.Local).AddTicks(4717), new DateTime(2024, 8, 9, 0, 33, 7, 989, DateTimeKind.Local).AddTicks(170), 1769.62m },
                    { new Guid("dd8c26bc-fb92-4c18-8204-6f1a7431e568"), new Guid("cba2380d-ac66-4bca-9da1-3db07a53966f"), new DateTime(2023, 10, 24, 15, 36, 35, 262, DateTimeKind.Local).AddTicks(6425), new DateTime(2024, 8, 7, 11, 47, 44, 213, DateTimeKind.Local).AddTicks(1965), 1042.91m },
                    { new Guid("ddab4cad-55f7-4ce5-82d1-196151ca00e5"), new Guid("17544f0d-9e01-4955-b49a-dcc4b6a770ee"), new DateTime(2023, 9, 25, 2, 57, 44, 842, DateTimeKind.Local).AddTicks(7669), new DateTime(2024, 8, 8, 23, 57, 45, 574, DateTimeKind.Local).AddTicks(3432), 632.20m },
                    { new Guid("ddd80560-4c9d-429b-983b-9774da534ee7"), new Guid("d15c8331-36ed-417a-b1fa-5f377c4c9930"), new DateTime(2023, 10, 20, 17, 59, 31, 230, DateTimeKind.Local).AddTicks(4638), new DateTime(2024, 8, 7, 19, 6, 24, 818, DateTimeKind.Local).AddTicks(6507), 2819.85m },
                    { new Guid("dddb4151-8322-4771-b3d1-ef462316e446"), new Guid("d5d71173-e817-45f8-9146-4b7ab7c7b686"), new DateTime(2024, 2, 16, 4, 27, 58, 576, DateTimeKind.Local).AddTicks(1978), new DateTime(2024, 8, 9, 11, 7, 29, 19, DateTimeKind.Local).AddTicks(9536), 477.44m },
                    { new Guid("de0a4f41-bef2-4f09-b438-e7a4aa7b0a87"), new Guid("232fdc99-53fe-4232-9c74-06ddfb2a13b8"), new DateTime(2024, 1, 1, 17, 59, 56, 169, DateTimeKind.Local).AddTicks(2566), new DateTime(2024, 8, 9, 6, 23, 23, 461, DateTimeKind.Local).AddTicks(5303), 4554.34m },
                    { new Guid("de1e1181-ef27-45ab-af06-d5c9cc5e1d17"), new Guid("1c79d0c4-56b9-4b08-af15-2fddc2c1068e"), new DateTime(2024, 6, 21, 17, 58, 26, 240, DateTimeKind.Local).AddTicks(5973), new DateTime(2024, 8, 9, 17, 28, 38, 174, DateTimeKind.Local).AddTicks(492), 3534.40m },
                    { new Guid("de883864-6f81-41a8-b05a-700f9ab09f58"), new Guid("a2e054b5-4260-4454-a995-281c00600f11"), new DateTime(2024, 1, 10, 17, 17, 38, 122, DateTimeKind.Local).AddTicks(449), new DateTime(2024, 8, 8, 11, 58, 2, 476, DateTimeKind.Local).AddTicks(8267), 512.88m },
                    { new Guid("df7cd1c7-2d04-42ec-b414-d38829d1852a"), new Guid("6f2bc11e-7dd7-4049-9e35-163927214820"), new DateTime(2024, 7, 29, 17, 41, 22, 736, DateTimeKind.Local).AddTicks(640), new DateTime(2024, 8, 9, 19, 10, 47, 802, DateTimeKind.Local).AddTicks(7322), 412.64m },
                    { new Guid("dfa939c2-811a-401b-9fd3-b76f5adf62e9"), new Guid("1c79d0c4-56b9-4b08-af15-2fddc2c1068e"), new DateTime(2024, 7, 23, 20, 41, 0, 521, DateTimeKind.Local).AddTicks(8681), new DateTime(2024, 8, 9, 2, 21, 59, 927, DateTimeKind.Local).AddTicks(5997), 466.07m },
                    { new Guid("dfb31eff-165d-45c1-94b6-1558864c7098"), new Guid("fa016e07-09ad-491e-a261-85cdebb45436"), new DateTime(2023, 12, 30, 1, 13, 19, 798, DateTimeKind.Local).AddTicks(3814), new DateTime(2024, 8, 7, 0, 30, 43, 109, DateTimeKind.Local).AddTicks(3399), 4897.95m },
                    { new Guid("e02735f1-505b-4a06-8820-efa91d1ad6cf"), new Guid("90ece793-c6f5-47e7-8aa0-7c08ff3548fb"), new DateTime(2023, 12, 14, 3, 17, 13, 997, DateTimeKind.Local).AddTicks(4827), new DateTime(2024, 8, 9, 11, 7, 7, 767, DateTimeKind.Local).AddTicks(698), 1282.52m },
                    { new Guid("e083851b-81c7-43ce-9272-085e3b46f150"), new Guid("ceeb839d-d443-4791-8018-561c89d6e7d9"), new DateTime(2024, 1, 4, 16, 25, 29, 325, DateTimeKind.Local).AddTicks(5815), new DateTime(2024, 8, 8, 19, 48, 38, 448, DateTimeKind.Local).AddTicks(3020), 4685.18m },
                    { new Guid("e0ae6ad2-465b-4f62-9f90-f178f8cb41c2"), new Guid("e9d684aa-183f-423f-8741-1a53cfb8f2e3"), new DateTime(2024, 4, 15, 11, 41, 0, 664, DateTimeKind.Local).AddTicks(1462), new DateTime(2024, 8, 8, 5, 9, 50, 613, DateTimeKind.Local).AddTicks(5132), 4538.33m },
                    { new Guid("e0d0cc3f-568c-4a11-b92d-2c437be0b51d"), new Guid("cce9a706-5e55-4052-a88e-26f4b6765bc9"), new DateTime(2024, 1, 5, 14, 23, 46, 333, DateTimeKind.Local).AddTicks(2465), new DateTime(2024, 8, 7, 22, 10, 2, 548, DateTimeKind.Local).AddTicks(3895), 3365.83m },
                    { new Guid("e107b7f4-63c2-4a35-9f68-2c840d848fc0"), new Guid("886111c9-af92-447f-91bf-dad7b8a03eb5"), new DateTime(2024, 8, 5, 19, 25, 52, 54, DateTimeKind.Local).AddTicks(184), new DateTime(2024, 8, 8, 11, 13, 37, 27, DateTimeKind.Local).AddTicks(7994), 371.42m },
                    { new Guid("e139b495-81de-4241-b791-86d4ce0aac66"), new Guid("052538e6-f9b6-4bd1-98e0-6e7d6744fb4a"), new DateTime(2024, 1, 1, 5, 13, 5, 162, DateTimeKind.Local).AddTicks(7149), new DateTime(2024, 8, 7, 21, 46, 36, 518, DateTimeKind.Local).AddTicks(814), 2867.11m },
                    { new Guid("e1562968-5c19-46c3-9fa5-980e6c470ce3"), new Guid("841db90c-5f81-482a-a955-f91fc637a7f7"), new DateTime(2023, 11, 18, 9, 46, 6, 510, DateTimeKind.Local).AddTicks(3737), new DateTime(2024, 8, 9, 1, 36, 54, 917, DateTimeKind.Local).AddTicks(262), 2410.51m },
                    { new Guid("e1a865f3-8348-424a-8dc1-3837846f9fa8"), new Guid("1d71e542-620f-4161-9842-a2a145bd7013"), new DateTime(2023, 11, 29, 9, 2, 55, 152, DateTimeKind.Local).AddTicks(8178), new DateTime(2024, 8, 9, 19, 37, 6, 553, DateTimeKind.Local).AddTicks(2737), 4355.62m },
                    { new Guid("e1a8f171-c6ad-4d77-af1b-6ce880b3903a"), new Guid("fa016e07-09ad-491e-a261-85cdebb45436"), new DateTime(2024, 5, 12, 8, 38, 42, 392, DateTimeKind.Local).AddTicks(3569), new DateTime(2024, 8, 9, 17, 23, 51, 869, DateTimeKind.Local).AddTicks(5782), 1292.93m },
                    { new Guid("e23c6972-26c1-4e93-9e2e-913007d1fb9d"), new Guid("33caf896-8425-48e6-86b5-a47f32bb1850"), new DateTime(2024, 1, 18, 10, 2, 38, 642, DateTimeKind.Local).AddTicks(7676), new DateTime(2024, 8, 8, 19, 35, 48, 312, DateTimeKind.Local).AddTicks(3816), 2643.29m },
                    { new Guid("e248d016-01c2-4c12-bda1-575fc39cd4e7"), new Guid("6f10d3da-6328-4453-bd18-d299e75dca49"), new DateTime(2024, 6, 10, 9, 26, 38, 256, DateTimeKind.Local).AddTicks(5454), new DateTime(2024, 8, 7, 13, 45, 37, 553, DateTimeKind.Local).AddTicks(2192), 4528.52m },
                    { new Guid("e24f50a4-bfa6-435c-a68d-66e7057b2bfb"), new Guid("d5d71173-e817-45f8-9146-4b7ab7c7b686"), new DateTime(2024, 8, 5, 1, 54, 11, 209, DateTimeKind.Local).AddTicks(5637), new DateTime(2024, 8, 8, 6, 42, 13, 821, DateTimeKind.Local).AddTicks(2106), 476.61m },
                    { new Guid("e2971b71-a2fe-4971-9b7b-be6c70430fae"), new Guid("d5d71173-e817-45f8-9146-4b7ab7c7b686"), new DateTime(2024, 2, 14, 22, 58, 31, 690, DateTimeKind.Local).AddTicks(408), new DateTime(2024, 8, 9, 20, 8, 33, 854, DateTimeKind.Local).AddTicks(2320), 2973.59m },
                    { new Guid("e2d59385-4eee-45f1-bb26-018465d8f886"), new Guid("6d1e80c0-f438-45cd-a63c-9bf2330160b6"), new DateTime(2023, 10, 29, 22, 8, 47, 674, DateTimeKind.Local).AddTicks(7346), new DateTime(2024, 8, 8, 15, 42, 27, 881, DateTimeKind.Local).AddTicks(9030), 3449.11m },
                    { new Guid("e343801d-b4a2-41ad-9095-56b49bdb550c"), new Guid("ceeb839d-d443-4791-8018-561c89d6e7d9"), new DateTime(2023, 9, 13, 21, 31, 51, 895, DateTimeKind.Local).AddTicks(5586), new DateTime(2024, 8, 7, 16, 30, 15, 592, DateTimeKind.Local).AddTicks(4408), 1432.91m },
                    { new Guid("e343af06-c626-4e31-a258-3badc258dbc3"), new Guid("5ee23c83-8a7a-498c-96a6-f2bc6fdc8136"), new DateTime(2024, 6, 22, 12, 56, 56, 727, DateTimeKind.Local).AddTicks(9301), new DateTime(2024, 8, 8, 0, 3, 3, 616, DateTimeKind.Local).AddTicks(2480), 3971.13m }
                });

            migrationBuilder.InsertData(
                table: "DonHangs",
                columns: new[] { "Id", "KhachHangId", "NgayDatHang", "NgayGiaoHang", "TongTien" },
                values: new object[,]
                {
                    { new Guid("e34c95f7-0656-436b-a022-39ee91fffa2d"), new Guid("46685f7f-ca60-41b6-8cfb-4124c89cd625"), new DateTime(2024, 6, 28, 14, 47, 31, 526, DateTimeKind.Local).AddTicks(3632), new DateTime(2024, 8, 9, 20, 36, 3, 380, DateTimeKind.Local).AddTicks(4437), 2210.57m },
                    { new Guid("e4875a5a-cf96-45a5-8b42-742cd4e40f4c"), new Guid("3cd8e5f4-df7e-4a22-84a3-04966bad5197"), new DateTime(2024, 5, 23, 15, 22, 24, 954, DateTimeKind.Local).AddTicks(7270), new DateTime(2024, 8, 9, 5, 12, 51, 784, DateTimeKind.Local).AddTicks(7647), 226.05m },
                    { new Guid("e494642d-eed8-4d92-bd3f-9f979df4c26f"), new Guid("eb503b18-f1e1-4a47-8871-99a4746eb8c6"), new DateTime(2024, 1, 27, 19, 38, 43, 24, DateTimeKind.Local).AddTicks(8897), new DateTime(2024, 8, 8, 16, 12, 57, 471, DateTimeKind.Local).AddTicks(3072), 4164.24m },
                    { new Guid("e4b87b7a-7cbf-4ede-be1a-d8236518ae68"), new Guid("6212ef8f-9777-42a2-ad28-a2ed1ebe90f8"), new DateTime(2024, 7, 29, 18, 17, 2, 76, DateTimeKind.Local).AddTicks(8520), new DateTime(2024, 8, 7, 6, 56, 37, 868, DateTimeKind.Local).AddTicks(7880), 943.41m },
                    { new Guid("e4ca13fc-7f1c-4e8b-afd0-3e9581361887"), new Guid("4ebf8ce2-efc1-4c0d-8c61-7159ede74521"), new DateTime(2024, 5, 13, 11, 12, 22, 147, DateTimeKind.Local).AddTicks(5329), new DateTime(2024, 8, 8, 20, 11, 2, 246, DateTimeKind.Local).AddTicks(3414), 2843.61m },
                    { new Guid("e512bbf3-1610-4c4d-b906-408797aaef53"), new Guid("ec92935c-29c1-47d3-9ff2-3aed6a0974f2"), new DateTime(2023, 11, 26, 3, 33, 45, 492, DateTimeKind.Local).AddTicks(2367), new DateTime(2024, 8, 9, 0, 52, 14, 774, DateTimeKind.Local).AddTicks(1766), 1923.15m },
                    { new Guid("e53c40f0-a656-4b65-943e-e718bcc8eb66"), new Guid("24256d4c-7032-4437-8c1e-dd211c5bd713"), new DateTime(2023, 9, 13, 14, 29, 59, 763, DateTimeKind.Local).AddTicks(4911), new DateTime(2024, 8, 9, 5, 45, 37, 366, DateTimeKind.Local).AddTicks(5920), 990.36m },
                    { new Guid("e590d390-86bc-4434-b67c-d9376ef00074"), new Guid("a51f9433-2477-4445-8a69-d24c50d95afb"), new DateTime(2023, 10, 5, 21, 20, 9, 156, DateTimeKind.Local).AddTicks(5639), new DateTime(2024, 8, 8, 11, 1, 20, 102, DateTimeKind.Local).AddTicks(2942), 1569.60m },
                    { new Guid("e5d7de5c-2e27-4ce3-90cc-aa0c5a23c250"), new Guid("952cbe13-c448-4063-910c-4a6b51e895ce"), new DateTime(2023, 12, 26, 14, 45, 43, 392, DateTimeKind.Local).AddTicks(4977), new DateTime(2024, 8, 9, 2, 43, 35, 295, DateTimeKind.Local).AddTicks(7972), 718.90m },
                    { new Guid("e5d95cb6-764e-4f88-95aa-32a505fdfe4f"), new Guid("93fb1f32-f25c-41b4-91a2-c22a92a4ab83"), new DateTime(2024, 4, 4, 10, 18, 1, 446, DateTimeKind.Local).AddTicks(9546), new DateTime(2024, 8, 9, 11, 38, 50, 259, DateTimeKind.Local).AddTicks(9328), 531.30m },
                    { new Guid("e627e217-8d63-40a7-8b0e-ab6c40f6acd7"), new Guid("c06db99e-509c-4391-b257-6799307a8b3c"), new DateTime(2024, 7, 13, 1, 6, 32, 553, DateTimeKind.Local).AddTicks(6325), new DateTime(2024, 8, 7, 13, 54, 3, 973, DateTimeKind.Local).AddTicks(6216), 1760.90m },
                    { new Guid("e627fd98-98c5-471e-aceb-d6d9791213bf"), new Guid("4ebf8ce2-efc1-4c0d-8c61-7159ede74521"), new DateTime(2024, 1, 26, 20, 56, 48, 655, DateTimeKind.Local).AddTicks(2431), new DateTime(2024, 8, 8, 1, 23, 44, 754, DateTimeKind.Local).AddTicks(9286), 3471.55m },
                    { new Guid("e6311cbb-826d-4d8c-8ebc-cf286d3a2b7b"), new Guid("920b6ceb-11fd-4534-8c78-0adccdc2cbf5"), new DateTime(2024, 4, 4, 4, 1, 55, 138, DateTimeKind.Local).AddTicks(4858), new DateTime(2024, 8, 7, 21, 16, 19, 795, DateTimeKind.Local).AddTicks(9958), 755.74m },
                    { new Guid("e640cf5f-607d-4f68-9fa4-be48f1a3c75a"), new Guid("c0ebc03b-08bf-4b16-89e2-4c86dec71a59"), new DateTime(2024, 1, 5, 5, 50, 53, 292, DateTimeKind.Local).AddTicks(2363), new DateTime(2024, 8, 8, 8, 37, 53, 145, DateTimeKind.Local).AddTicks(4487), 1800.43m },
                    { new Guid("e6500fcb-a493-4544-ac11-21d181a50d65"), new Guid("44514479-669b-45b2-8af4-510b0786de9b"), new DateTime(2024, 2, 21, 6, 48, 17, 816, DateTimeKind.Local).AddTicks(4325), new DateTime(2024, 8, 7, 16, 54, 34, 746, DateTimeKind.Local).AddTicks(2823), 1030.20m },
                    { new Guid("e6ba59b0-6697-45f0-86ca-e570ae707a1b"), new Guid("a2e054b5-4260-4454-a995-281c00600f11"), new DateTime(2024, 5, 14, 0, 22, 58, 559, DateTimeKind.Local).AddTicks(6825), new DateTime(2024, 8, 9, 19, 6, 57, 561, DateTimeKind.Local).AddTicks(2303), 824.65m },
                    { new Guid("e71a4c07-63c1-4099-9b57-8ec24dd3fadc"), new Guid("841db90c-5f81-482a-a955-f91fc637a7f7"), new DateTime(2023, 12, 26, 1, 51, 49, 310, DateTimeKind.Local).AddTicks(7440), new DateTime(2024, 8, 9, 4, 16, 47, 40, DateTimeKind.Local).AddTicks(9312), 3722.28m },
                    { new Guid("e72ad463-a4af-4cfd-b0eb-67e59ec411df"), new Guid("15883dbe-e97e-4859-86f7-993bbc1173df"), new DateTime(2024, 5, 30, 10, 50, 38, 987, DateTimeKind.Local).AddTicks(7671), new DateTime(2024, 8, 9, 9, 38, 7, 130, DateTimeKind.Local).AddTicks(8391), 104.93m },
                    { new Guid("e77bfdaf-2074-4134-ad90-19034d807198"), new Guid("0bd930d6-b736-4558-87c1-50bd97e08db0"), new DateTime(2023, 10, 2, 10, 52, 9, 549, DateTimeKind.Local).AddTicks(6999), new DateTime(2024, 8, 8, 2, 14, 51, 662, DateTimeKind.Local).AddTicks(2340), 4050.21m },
                    { new Guid("e7e30719-c92e-4c91-bc05-81add141bc85"), new Guid("873734f8-2118-4bff-95ec-9e199770cefb"), new DateTime(2023, 11, 25, 8, 22, 49, 181, DateTimeKind.Local).AddTicks(501), new DateTime(2024, 8, 7, 11, 36, 39, 732, DateTimeKind.Local).AddTicks(1326), 1226.14m },
                    { new Guid("e7e8aeae-e9b7-4f0a-a25c-2c4e5f167576"), new Guid("052538e6-f9b6-4bd1-98e0-6e7d6744fb4a"), new DateTime(2023, 10, 4, 20, 11, 47, 204, DateTimeKind.Local).AddTicks(607), new DateTime(2024, 8, 9, 4, 0, 47, 99, DateTimeKind.Local).AddTicks(1023), 3855.25m },
                    { new Guid("e875b61b-5b2e-4c46-b6b6-438c9c709a20"), new Guid("9865321a-433a-4caa-8050-884b34c7c8d8"), new DateTime(2023, 10, 19, 10, 48, 9, 331, DateTimeKind.Local).AddTicks(3613), new DateTime(2024, 8, 7, 11, 37, 51, 138, DateTimeKind.Local).AddTicks(7958), 1556.62m },
                    { new Guid("e8bf1631-8187-4f48-8207-b9e0b77ae2bd"), new Guid("5e4be06c-1976-4755-aeb0-28dae4b4298b"), new DateTime(2024, 2, 1, 2, 2, 58, 79, DateTimeKind.Local).AddTicks(2718), new DateTime(2024, 8, 7, 23, 53, 33, 72, DateTimeKind.Local).AddTicks(5987), 1461.97m },
                    { new Guid("e8bfe245-405e-4f61-9e45-2be06a1fd47e"), new Guid("a51f9433-2477-4445-8a69-d24c50d95afb"), new DateTime(2023, 8, 8, 17, 31, 4, 405, DateTimeKind.Local).AddTicks(8283), new DateTime(2024, 8, 7, 3, 37, 18, 87, DateTimeKind.Local).AddTicks(8453), 4330.16m },
                    { new Guid("e9223720-c105-4170-97b8-a959d8e7c3ab"), new Guid("052538e6-f9b6-4bd1-98e0-6e7d6744fb4a"), new DateTime(2023, 9, 1, 23, 16, 9, 204, DateTimeKind.Local).AddTicks(5797), new DateTime(2024, 8, 9, 6, 38, 43, 391, DateTimeKind.Local).AddTicks(4985), 2354.36m },
                    { new Guid("e92ef0c5-0665-45f2-a8d9-11280b18659d"), new Guid("f9a1bd2e-de1a-42b8-b894-7f7e0b5b38f1"), new DateTime(2023, 10, 20, 10, 47, 35, 192, DateTimeKind.Local).AddTicks(8524), new DateTime(2024, 8, 9, 8, 23, 53, 865, DateTimeKind.Local).AddTicks(5688), 4623.86m },
                    { new Guid("e9306d42-fe22-4b4f-b674-108a3ba898ba"), new Guid("d5d71173-e817-45f8-9146-4b7ab7c7b686"), new DateTime(2023, 11, 12, 20, 19, 39, 342, DateTimeKind.Local).AddTicks(1999), new DateTime(2024, 8, 9, 12, 33, 9, 402, DateTimeKind.Local).AddTicks(300), 2205.89m },
                    { new Guid("e9709acb-1257-427e-9fc8-8b7d4d310f04"), new Guid("75fe592b-5c1e-4814-a459-627bef01098f"), new DateTime(2024, 3, 30, 2, 43, 35, 159, DateTimeKind.Local).AddTicks(5774), new DateTime(2024, 8, 8, 2, 9, 25, 845, DateTimeKind.Local).AddTicks(2566), 797.56m },
                    { new Guid("ea02ad57-e75e-4e88-a034-4c67f6272e33"), new Guid("cce9a706-5e55-4052-a88e-26f4b6765bc9"), new DateTime(2023, 9, 8, 10, 20, 9, 821, DateTimeKind.Local).AddTicks(2873), new DateTime(2024, 8, 9, 16, 42, 39, 930, DateTimeKind.Local).AddTicks(2825), 979.86m },
                    { new Guid("ea076f3f-a720-4bec-a19f-686b95717d36"), new Guid("1248d1fb-1e80-4ded-926b-6b7f6d2249a5"), new DateTime(2023, 10, 25, 11, 27, 37, 491, DateTimeKind.Local).AddTicks(8990), new DateTime(2024, 8, 8, 10, 1, 47, 891, DateTimeKind.Local).AddTicks(6487), 1552.36m },
                    { new Guid("ea34281a-e051-4eb6-85bf-7dcc61ae5be1"), new Guid("886111c9-af92-447f-91bf-dad7b8a03eb5"), new DateTime(2023, 12, 26, 17, 20, 1, 645, DateTimeKind.Local).AddTicks(9255), new DateTime(2024, 8, 9, 14, 31, 11, 40, DateTimeKind.Local).AddTicks(8700), 591.52m },
                    { new Guid("ea35d7be-f4ed-49a4-b396-d01edbfb908f"), new Guid("38ba8024-3b8d-4dd6-92b9-9d06da12ec6e"), new DateTime(2024, 6, 30, 14, 6, 8, 498, DateTimeKind.Local).AddTicks(3706), new DateTime(2024, 8, 7, 20, 17, 46, 232, DateTimeKind.Local).AddTicks(790), 2076.99m },
                    { new Guid("eab674c1-3cf5-4316-913a-4ef20aade010"), new Guid("44514479-669b-45b2-8af4-510b0786de9b"), new DateTime(2024, 7, 23, 1, 35, 18, 793, DateTimeKind.Local).AddTicks(3060), new DateTime(2024, 8, 8, 9, 58, 33, 424, DateTimeKind.Local).AddTicks(2119), 4818.29m },
                    { new Guid("eabbb49f-c1d3-4c04-943d-71b584976f38"), new Guid("b4a06e76-1c1e-4cac-aaa1-572d7a607954"), new DateTime(2024, 6, 16, 22, 16, 5, 452, DateTimeKind.Local).AddTicks(9766), new DateTime(2024, 8, 7, 8, 41, 8, 313, DateTimeKind.Local).AddTicks(1321), 562.29m },
                    { new Guid("eacd3a57-d92e-4f51-84e4-ff68da9b7943"), new Guid("7b94208a-340f-4ed0-ad44-07a96fbc7d7a"), new DateTime(2023, 9, 25, 15, 7, 42, 690, DateTimeKind.Local).AddTicks(1474), new DateTime(2024, 8, 7, 19, 14, 47, 925, DateTimeKind.Local).AddTicks(4473), 2149.86m },
                    { new Guid("eae61e70-cf00-4fa9-ad29-f83e9d0f8bfb"), new Guid("fd9917bd-45e9-4bab-839f-7f5b5cbf03e7"), new DateTime(2024, 3, 1, 8, 42, 36, 508, DateTimeKind.Local).AddTicks(897), new DateTime(2024, 8, 7, 1, 21, 14, 289, DateTimeKind.Local).AddTicks(485), 190.15m },
                    { new Guid("eb0092b5-74fc-4f6c-9d4e-3ba89b6fb9a9"), new Guid("5e4be06c-1976-4755-aeb0-28dae4b4298b"), new DateTime(2024, 2, 29, 14, 51, 1, 244, DateTimeKind.Local).AddTicks(1625), new DateTime(2024, 8, 8, 7, 28, 21, 712, DateTimeKind.Local).AddTicks(9150), 4610.83m },
                    { new Guid("eb0ba3ad-c1a1-4c4c-800c-ffeafc9da719"), new Guid("b78d1e60-56cf-4058-967c-7271f646af05"), new DateTime(2023, 11, 11, 8, 49, 18, 332, DateTimeKind.Local).AddTicks(7311), new DateTime(2024, 8, 7, 10, 36, 10, 369, DateTimeKind.Local).AddTicks(8197), 2006.13m },
                    { new Guid("eb3392ec-c27b-4795-bf9c-7eb3b30eaace"), new Guid("7b94208a-340f-4ed0-ad44-07a96fbc7d7a"), new DateTime(2023, 8, 17, 17, 2, 39, 793, DateTimeKind.Local).AddTicks(3290), new DateTime(2024, 8, 9, 19, 25, 19, 126, DateTimeKind.Local).AddTicks(6138), 140.66m },
                    { new Guid("eb6910ab-fed2-4942-b2db-8c48804c20d7"), new Guid("4ebf8ce2-efc1-4c0d-8c61-7159ede74521"), new DateTime(2024, 3, 28, 10, 36, 33, 772, DateTimeKind.Local).AddTicks(5256), new DateTime(2024, 8, 8, 12, 46, 22, 402, DateTimeKind.Local).AddTicks(5461), 877.73m },
                    { new Guid("ebb2f78b-c285-473d-a20e-223f9263cb01"), new Guid("9f2dcec6-cc02-45d6-95d0-fa0b53a5f953"), new DateTime(2024, 6, 18, 2, 7, 56, 923, DateTimeKind.Local).AddTicks(5514), new DateTime(2024, 8, 7, 15, 48, 50, 534, DateTimeKind.Local).AddTicks(8412), 1184.96m },
                    { new Guid("ec1afccd-b878-482e-91dc-a55d58546b49"), new Guid("7b94208a-340f-4ed0-ad44-07a96fbc7d7a"), new DateTime(2024, 5, 1, 21, 13, 5, 215, DateTimeKind.Local).AddTicks(5782), new DateTime(2024, 8, 8, 9, 39, 19, 259, DateTimeKind.Local).AddTicks(1732), 2771.17m }
                });

            migrationBuilder.InsertData(
                table: "DonHangs",
                columns: new[] { "Id", "KhachHangId", "NgayDatHang", "NgayGiaoHang", "TongTien" },
                values: new object[,]
                {
                    { new Guid("ec1b42ab-8873-464a-bf21-d32f6f5386ef"), new Guid("232fdc99-53fe-4232-9c74-06ddfb2a13b8"), new DateTime(2024, 2, 6, 18, 0, 29, 668, DateTimeKind.Local).AddTicks(8072), new DateTime(2024, 8, 9, 11, 54, 5, 748, DateTimeKind.Local).AddTicks(1962), 230.86m },
                    { new Guid("ecaa1e12-7fc9-4455-b849-bdcb623dd1bf"), new Guid("5f3cfe10-1a7a-45c2-8fcb-c7e90692dbc4"), new DateTime(2024, 6, 13, 19, 13, 16, 611, DateTimeKind.Local).AddTicks(1987), new DateTime(2024, 8, 8, 1, 30, 59, 999, DateTimeKind.Local).AddTicks(434), 377.48m },
                    { new Guid("ed5facd1-f7e2-4af5-a654-39f6d3ac3371"), new Guid("1248d1fb-1e80-4ded-926b-6b7f6d2249a5"), new DateTime(2023, 12, 6, 7, 24, 57, 210, DateTimeKind.Local).AddTicks(6073), new DateTime(2024, 8, 8, 19, 43, 21, 704, DateTimeKind.Local).AddTicks(7889), 4208.81m },
                    { new Guid("ed72c251-cf40-4495-9237-3a11572b02df"), new Guid("1248d1fb-1e80-4ded-926b-6b7f6d2249a5"), new DateTime(2023, 12, 14, 10, 59, 12, 18, DateTimeKind.Local).AddTicks(7340), new DateTime(2024, 8, 7, 16, 7, 1, 329, DateTimeKind.Local).AddTicks(6414), 3707.76m },
                    { new Guid("eda2ce1a-6ed8-4ea9-bcf9-98285b98883f"), new Guid("1c79d0c4-56b9-4b08-af15-2fddc2c1068e"), new DateTime(2024, 3, 19, 10, 41, 23, 77, DateTimeKind.Local).AddTicks(7928), new DateTime(2024, 8, 8, 19, 8, 16, 68, DateTimeKind.Local).AddTicks(4398), 4841.50m },
                    { new Guid("ee40b055-47c7-453f-901c-33f5c5f4b4e5"), new Guid("1248d1fb-1e80-4ded-926b-6b7f6d2249a5"), new DateTime(2024, 1, 24, 9, 5, 46, 11, DateTimeKind.Local).AddTicks(4424), new DateTime(2024, 8, 9, 16, 29, 22, 954, DateTimeKind.Local).AddTicks(5940), 4982.22m },
                    { new Guid("ee61dc29-8d83-46f1-897f-7e56837f82ce"), new Guid("93fb1f32-f25c-41b4-91a2-c22a92a4ab83"), new DateTime(2024, 7, 7, 7, 7, 8, 918, DateTimeKind.Local).AddTicks(4838), new DateTime(2024, 8, 9, 19, 10, 13, 153, DateTimeKind.Local).AddTicks(5180), 4925.85m },
                    { new Guid("ee9c75a3-898a-42bc-b652-e3f557e1948d"), new Guid("e9d684aa-183f-423f-8741-1a53cfb8f2e3"), new DateTime(2024, 7, 24, 7, 3, 49, 940, DateTimeKind.Local).AddTicks(6450), new DateTime(2024, 8, 8, 18, 20, 9, 782, DateTimeKind.Local).AddTicks(6068), 2188.49m },
                    { new Guid("eeab1f0c-2000-452d-91e9-e5d0a2bb3dc8"), new Guid("24256d4c-7032-4437-8c1e-dd211c5bd713"), new DateTime(2024, 7, 8, 18, 0, 39, 39, DateTimeKind.Local).AddTicks(7720), new DateTime(2024, 8, 9, 12, 59, 10, 610, DateTimeKind.Local).AddTicks(156), 3210.47m },
                    { new Guid("eeac5285-dbd9-4e62-b182-47681b5a6da3"), new Guid("88603d45-af2e-4381-b8d8-2c53ebbaccd2"), new DateTime(2024, 7, 30, 5, 38, 4, 741, DateTimeKind.Local).AddTicks(2873), new DateTime(2024, 8, 9, 18, 50, 25, 248, DateTimeKind.Local).AddTicks(6773), 1082.79m },
                    { new Guid("eeb16642-23b1-4f93-88c7-e25273a676b1"), new Guid("3fd74fb4-2450-440d-8497-d9a630f57199"), new DateTime(2024, 7, 30, 2, 45, 38, 458, DateTimeKind.Local).AddTicks(85), new DateTime(2024, 8, 9, 19, 31, 0, 724, DateTimeKind.Local).AddTicks(5398), 303.88m },
                    { new Guid("eebaec2f-bb74-4770-9d8f-36c3574bb9bc"), new Guid("3fd74fb4-2450-440d-8497-d9a630f57199"), new DateTime(2023, 10, 2, 7, 55, 42, 467, DateTimeKind.Local).AddTicks(6016), new DateTime(2024, 8, 8, 4, 42, 30, 171, DateTimeKind.Local).AddTicks(2034), 2590.25m },
                    { new Guid("eee8f314-3a64-4b6a-a269-edd47f24df21"), new Guid("590c7122-bbd8-408c-9571-b8d385d97b9e"), new DateTime(2023, 12, 12, 14, 9, 16, 301, DateTimeKind.Local).AddTicks(5417), new DateTime(2024, 8, 9, 0, 57, 18, 525, DateTimeKind.Local).AddTicks(9677), 2277.80m },
                    { new Guid("eef7e50c-5ef9-4c7d-93ee-a6453b972fb4"), new Guid("17544f0d-9e01-4955-b49a-dcc4b6a770ee"), new DateTime(2023, 11, 18, 15, 18, 42, 778, DateTimeKind.Local).AddTicks(6443), new DateTime(2024, 8, 8, 15, 52, 21, 462, DateTimeKind.Local).AddTicks(2171), 643.35m },
                    { new Guid("eff0b9a5-002c-43be-81aa-3e3446d7ec3b"), new Guid("24256d4c-7032-4437-8c1e-dd211c5bd713"), new DateTime(2023, 9, 28, 8, 17, 57, 774, DateTimeKind.Local).AddTicks(6709), new DateTime(2024, 8, 8, 5, 25, 2, 80, DateTimeKind.Local).AddTicks(252), 1079.14m },
                    { new Guid("f0276d01-1236-435c-b1ab-5a2ccde518fc"), new Guid("fd9917bd-45e9-4bab-839f-7f5b5cbf03e7"), new DateTime(2024, 2, 6, 6, 1, 51, 408, DateTimeKind.Local).AddTicks(6364), new DateTime(2024, 8, 7, 16, 55, 42, 94, DateTimeKind.Local).AddTicks(5578), 2483.11m },
                    { new Guid("f027700d-feb9-4320-a6b4-2bb2f18568c0"), new Guid("6f2bc11e-7dd7-4049-9e35-163927214820"), new DateTime(2024, 4, 9, 14, 8, 32, 467, DateTimeKind.Local).AddTicks(6684), new DateTime(2024, 8, 7, 9, 30, 50, 39, DateTimeKind.Local).AddTicks(1136), 3891.76m },
                    { new Guid("f0a53eb7-8e15-4ae9-9b3b-1225bbd5d82c"), new Guid("2528ff79-cf89-4261-a0de-428d26b20a72"), new DateTime(2023, 12, 17, 7, 4, 39, 122, DateTimeKind.Local).AddTicks(3861), new DateTime(2024, 8, 7, 5, 10, 10, 742, DateTimeKind.Local).AddTicks(931), 238.63m },
                    { new Guid("f1b2a7a9-42e5-4004-849c-76c83ba6e5d4"), new Guid("a51f9433-2477-4445-8a69-d24c50d95afb"), new DateTime(2023, 9, 11, 20, 17, 2, 255, DateTimeKind.Local).AddTicks(6284), new DateTime(2024, 8, 7, 6, 56, 7, 569, DateTimeKind.Local).AddTicks(878), 1722.02m },
                    { new Guid("f1c6bb0f-0019-49b2-aabb-73363e3d832d"), new Guid("3da3214c-bd0e-4377-a9dd-da000298cefd"), new DateTime(2024, 3, 11, 20, 56, 7, 192, DateTimeKind.Local).AddTicks(4463), new DateTime(2024, 8, 8, 7, 5, 52, 539, DateTimeKind.Local).AddTicks(5496), 4560.91m },
                    { new Guid("f1c75421-6cad-49a5-bb51-e0873a98d550"), new Guid("cba2380d-ac66-4bca-9da1-3db07a53966f"), new DateTime(2023, 9, 26, 1, 54, 10, 945, DateTimeKind.Local).AddTicks(550), new DateTime(2024, 8, 9, 15, 17, 11, 913, DateTimeKind.Local).AddTicks(5359), 2877.91m },
                    { new Guid("f298462c-0976-4a7b-b5e2-96176bc22fda"), new Guid("6f10d3da-6328-4453-bd18-d299e75dca49"), new DateTime(2024, 4, 25, 10, 28, 31, 586, DateTimeKind.Local).AddTicks(4112), new DateTime(2024, 8, 7, 4, 22, 25, 729, DateTimeKind.Local).AddTicks(939), 395.82m },
                    { new Guid("f2cbe9a7-453e-4a46-ab01-b62c44c6725f"), new Guid("1248d1fb-1e80-4ded-926b-6b7f6d2249a5"), new DateTime(2024, 2, 26, 1, 28, 19, 237, DateTimeKind.Local).AddTicks(2106), new DateTime(2024, 8, 7, 19, 12, 8, 613, DateTimeKind.Local).AddTicks(3915), 3417.03m },
                    { new Guid("f2cedf0f-7ce0-4459-9ded-62be9612c814"), new Guid("fa016e07-09ad-491e-a261-85cdebb45436"), new DateTime(2024, 3, 14, 12, 1, 0, 635, DateTimeKind.Local).AddTicks(3548), new DateTime(2024, 8, 7, 4, 50, 31, 418, DateTimeKind.Local).AddTicks(5686), 3899.21m },
                    { new Guid("f356a846-8e8e-4db5-ac4f-21dc70dc2991"), new Guid("d15c8331-36ed-417a-b1fa-5f377c4c9930"), new DateTime(2024, 3, 29, 22, 12, 42, 721, DateTimeKind.Local).AddTicks(2277), new DateTime(2024, 8, 9, 18, 58, 38, 221, DateTimeKind.Local).AddTicks(823), 766.34m },
                    { new Guid("f3715b95-795b-4ae5-8302-0c943ad0a30e"), new Guid("3da3214c-bd0e-4377-a9dd-da000298cefd"), new DateTime(2023, 9, 30, 20, 50, 28, 251, DateTimeKind.Local).AddTicks(7277), new DateTime(2024, 8, 8, 16, 48, 43, 21, DateTimeKind.Local).AddTicks(2719), 2173.56m },
                    { new Guid("f3742c28-3adb-45bd-bf1c-0e1bcd7a0eda"), new Guid("d6d20276-ac8b-44d6-9939-d642e6335c51"), new DateTime(2024, 3, 8, 9, 37, 51, 709, DateTimeKind.Local).AddTicks(7596), new DateTime(2024, 8, 7, 7, 41, 11, 648, DateTimeKind.Local).AddTicks(1827), 3240.64m },
                    { new Guid("f38a0800-4f16-4022-8b7d-73135c7d2127"), new Guid("697709be-b252-4405-bb7e-8673c6b98467"), new DateTime(2023, 10, 20, 19, 46, 13, 637, DateTimeKind.Local).AddTicks(6287), new DateTime(2024, 8, 8, 23, 41, 10, 251, DateTimeKind.Local).AddTicks(7589), 3493.91m },
                    { new Guid("f3b08fd1-7bed-42e8-9484-79a3f45ee032"), new Guid("052538e6-f9b6-4bd1-98e0-6e7d6744fb4a"), new DateTime(2023, 9, 13, 19, 23, 5, 511, DateTimeKind.Local).AddTicks(7215), new DateTime(2024, 8, 9, 13, 7, 44, 394, DateTimeKind.Local).AddTicks(1073), 2347.16m },
                    { new Guid("f448a8e0-bd4b-4d70-a0f3-9a16a2addc7e"), new Guid("6d1e80c0-f438-45cd-a63c-9bf2330160b6"), new DateTime(2023, 10, 22, 4, 44, 51, 508, DateTimeKind.Local).AddTicks(4176), new DateTime(2024, 8, 8, 17, 9, 5, 90, DateTimeKind.Local).AddTicks(1592), 633.46m },
                    { new Guid("f524ddaf-15d0-4555-8e79-bb2194b8293d"), new Guid("893b3fb0-9647-4958-b835-676e382779e7"), new DateTime(2024, 6, 6, 7, 17, 10, 426, DateTimeKind.Local).AddTicks(8463), new DateTime(2024, 8, 9, 21, 34, 2, 749, DateTimeKind.Local).AddTicks(6151), 3527.59m },
                    { new Guid("f529a285-4a72-4e3d-ae68-fe4f4f3d856f"), new Guid("7b94208a-340f-4ed0-ad44-07a96fbc7d7a"), new DateTime(2024, 1, 26, 13, 51, 21, 311, DateTimeKind.Local).AddTicks(3614), new DateTime(2024, 8, 7, 16, 43, 42, 993, DateTimeKind.Local).AddTicks(9432), 1189.15m },
                    { new Guid("f5acf3ae-8da0-4825-9769-c00cc9bed444"), new Guid("24256d4c-7032-4437-8c1e-dd211c5bd713"), new DateTime(2024, 2, 2, 5, 3, 31, 894, DateTimeKind.Local).AddTicks(1073), new DateTime(2024, 8, 9, 17, 36, 9, 212, DateTimeKind.Local).AddTicks(4269), 2222.54m },
                    { new Guid("f5ca3d08-2109-4b4f-92c5-1c8bc48d11d0"), new Guid("3da3214c-bd0e-4377-a9dd-da000298cefd"), new DateTime(2023, 9, 26, 23, 43, 34, 799, DateTimeKind.Local).AddTicks(9430), new DateTime(2024, 8, 7, 5, 32, 47, 153, DateTimeKind.Local).AddTicks(8636), 1932.51m },
                    { new Guid("f5dad759-aa4b-4b68-92ad-6d3914d6c586"), new Guid("22ebc934-105f-4b38-ab74-feae23d1ffc0"), new DateTime(2023, 8, 30, 8, 50, 41, 651, DateTimeKind.Local).AddTicks(7160), new DateTime(2024, 8, 8, 17, 6, 1, 502, DateTimeKind.Local).AddTicks(1287), 2858.07m },
                    { new Guid("f5df8b86-2c18-475a-91f7-1eb821ae9415"), new Guid("d6d20276-ac8b-44d6-9939-d642e6335c51"), new DateTime(2024, 4, 12, 18, 27, 45, 181, DateTimeKind.Local).AddTicks(6883), new DateTime(2024, 8, 8, 13, 51, 12, 667, DateTimeKind.Local).AddTicks(6374), 1635.02m },
                    { new Guid("f5e63539-8523-4b05-b0e1-c6b20a2d6310"), new Guid("a51f9433-2477-4445-8a69-d24c50d95afb"), new DateTime(2024, 2, 14, 7, 45, 19, 995, DateTimeKind.Local).AddTicks(3184), new DateTime(2024, 8, 8, 12, 0, 54, 752, DateTimeKind.Local).AddTicks(9988), 2794.16m },
                    { new Guid("f6034989-e5f9-49a9-9e45-0bda7ab5e453"), new Guid("63021a65-455d-454a-92ee-525601ead4df"), new DateTime(2023, 9, 22, 14, 57, 53, 747, DateTimeKind.Local).AddTicks(7670), new DateTime(2024, 8, 8, 9, 46, 25, 703, DateTimeKind.Local).AddTicks(3443), 4779.62m },
                    { new Guid("f63e755c-c016-4f21-819f-848c9138d7a3"), new Guid("0667960a-b942-408f-9aa5-8591f0e0599a"), new DateTime(2024, 1, 17, 12, 45, 3, 504, DateTimeKind.Local).AddTicks(8628), new DateTime(2024, 8, 7, 4, 28, 56, 820, DateTimeKind.Local).AddTicks(3384), 1216.12m },
                    { new Guid("f65abde3-ffb1-48c4-b5c2-6c0d74a058ce"), new Guid("33caf896-8425-48e6-86b5-a47f32bb1850"), new DateTime(2024, 6, 27, 2, 49, 33, 392, DateTimeKind.Local).AddTicks(976), new DateTime(2024, 8, 9, 19, 21, 28, 535, DateTimeKind.Local).AddTicks(4466), 1871.03m },
                    { new Guid("f6dd41be-3a0d-4d17-829b-c52fbaa09782"), new Guid("b41438f5-9380-4cd7-bc4d-59267b9b760c"), new DateTime(2024, 8, 1, 18, 22, 59, 290, DateTimeKind.Local).AddTicks(4423), new DateTime(2024, 8, 9, 11, 22, 47, 592, DateTimeKind.Local).AddTicks(8980), 936.14m },
                    { new Guid("f6fc304b-d307-4efc-8d1c-75b8715c3861"), new Guid("d84600ec-9767-4cd9-8221-62d22397acaa"), new DateTime(2024, 1, 6, 22, 5, 6, 941, DateTimeKind.Local).AddTicks(2588), new DateTime(2024, 8, 7, 14, 5, 52, 331, DateTimeKind.Local).AddTicks(1018), 3863.79m }
                });

            migrationBuilder.InsertData(
                table: "DonHangs",
                columns: new[] { "Id", "KhachHangId", "NgayDatHang", "NgayGiaoHang", "TongTien" },
                values: new object[,]
                {
                    { new Guid("f6fd6937-1828-4f4e-82be-3857c140d3b1"), new Guid("e56e8c86-41ee-47fd-9d05-a94a167bed10"), new DateTime(2023, 12, 2, 17, 49, 54, 532, DateTimeKind.Local).AddTicks(9358), new DateTime(2024, 8, 8, 21, 20, 22, 425, DateTimeKind.Local).AddTicks(8700), 3358.63m },
                    { new Guid("f768c4ae-39bb-40b3-98e2-ee54eed10167"), new Guid("22ebc934-105f-4b38-ab74-feae23d1ffc0"), new DateTime(2023, 8, 29, 12, 42, 53, 910, DateTimeKind.Local).AddTicks(5578), new DateTime(2024, 8, 9, 10, 56, 42, 888, DateTimeKind.Local).AddTicks(5937), 3680.37m },
                    { new Guid("f775f23c-e267-4ebc-ba17-10fd466487bb"), new Guid("5611f5df-6d74-47b4-b24b-5863bd50f032"), new DateTime(2023, 12, 17, 6, 35, 17, 421, DateTimeKind.Local).AddTicks(9334), new DateTime(2024, 8, 7, 8, 51, 43, 910, DateTimeKind.Local).AddTicks(252), 1568.17m },
                    { new Guid("f7fa4f06-f051-4cb1-b214-96647525a688"), new Guid("1248d1fb-1e80-4ded-926b-6b7f6d2249a5"), new DateTime(2024, 4, 9, 11, 20, 56, 622, DateTimeKind.Local).AddTicks(7879), new DateTime(2024, 8, 9, 8, 21, 57, 469, DateTimeKind.Local).AddTicks(5418), 2530.97m },
                    { new Guid("f81669df-16de-4c48-86d3-19b7089984bf"), new Guid("6f2bc11e-7dd7-4049-9e35-163927214820"), new DateTime(2023, 10, 18, 6, 55, 46, 842, DateTimeKind.Local).AddTicks(4223), new DateTime(2024, 8, 9, 6, 26, 53, 696, DateTimeKind.Local).AddTicks(2906), 3832.79m },
                    { new Guid("f8a86ad7-a11a-4428-95ef-c36fb1615de9"), new Guid("5ee23c83-8a7a-498c-96a6-f2bc6fdc8136"), new DateTime(2023, 10, 21, 13, 20, 3, 44, DateTimeKind.Local).AddTicks(7340), new DateTime(2024, 8, 9, 22, 3, 57, 101, DateTimeKind.Local).AddTicks(7951), 602.69m },
                    { new Guid("f8e0bb4a-e9b0-488d-bd8d-c82bc9788fbb"), new Guid("427269be-9018-4cf4-9818-4fae14114ae4"), new DateTime(2024, 3, 10, 5, 32, 37, 158, DateTimeKind.Local).AddTicks(2683), new DateTime(2024, 8, 9, 21, 9, 34, 808, DateTimeKind.Local).AddTicks(105), 3897.86m },
                    { new Guid("f8f4d840-5fde-41ae-af93-f2be63b72939"), new Guid("c0ebc03b-08bf-4b16-89e2-4c86dec71a59"), new DateTime(2023, 8, 13, 0, 19, 42, 116, DateTimeKind.Local).AddTicks(1189), new DateTime(2024, 8, 8, 21, 52, 18, 993, DateTimeKind.Local).AddTicks(6900), 4024.01m },
                    { new Guid("f8fd640a-0858-452e-9e03-73407d34f37f"), new Guid("6f2bc11e-7dd7-4049-9e35-163927214820"), new DateTime(2023, 10, 1, 21, 20, 45, 776, DateTimeKind.Local).AddTicks(2676), new DateTime(2024, 8, 8, 6, 44, 43, 112, DateTimeKind.Local).AddTicks(4189), 2568.93m },
                    { new Guid("f953bb79-37bf-48a6-8054-79d115105f9c"), new Guid("232fdc99-53fe-4232-9c74-06ddfb2a13b8"), new DateTime(2023, 12, 2, 0, 59, 27, 925, DateTimeKind.Local).AddTicks(309), new DateTime(2024, 8, 7, 20, 39, 58, 290, DateTimeKind.Local).AddTicks(9573), 4503.07m },
                    { new Guid("f9586008-5907-4641-a945-9c58eda5c5df"), new Guid("c93b2790-efbb-4887-bc62-908698026478"), new DateTime(2023, 12, 6, 14, 0, 31, 88, DateTimeKind.Local).AddTicks(5652), new DateTime(2024, 8, 7, 8, 12, 46, 20, DateTimeKind.Local).AddTicks(3198), 4370.11m },
                    { new Guid("f959b1c3-3e78-49cd-b515-7c9d9f384382"), new Guid("d84600ec-9767-4cd9-8221-62d22397acaa"), new DateTime(2024, 6, 19, 13, 30, 53, 348, DateTimeKind.Local).AddTicks(2986), new DateTime(2024, 8, 9, 6, 7, 17, 672, DateTimeKind.Local).AddTicks(7177), 3874.18m },
                    { new Guid("f996e445-25cc-4cda-9e52-4a871fe8c2ed"), new Guid("f0f1e5c8-88d3-4268-9c48-f6a85560db57"), new DateTime(2023, 12, 8, 12, 58, 22, 441, DateTimeKind.Local).AddTicks(9596), new DateTime(2024, 8, 9, 3, 49, 17, 90, DateTimeKind.Local).AddTicks(6291), 3085.96m },
                    { new Guid("f9da1cba-37dc-42cc-80f1-8cba4289dc20"), new Guid("28d8da78-c6c4-4afe-9d92-22d52e3969b0"), new DateTime(2023, 10, 27, 0, 52, 18, 656, DateTimeKind.Local).AddTicks(8680), new DateTime(2024, 8, 8, 18, 4, 19, 933, DateTimeKind.Local).AddTicks(1997), 3456.88m },
                    { new Guid("fab8bc4a-04f9-4353-9327-0ff5622717f9"), new Guid("1d71e542-620f-4161-9842-a2a145bd7013"), new DateTime(2023, 12, 11, 10, 54, 16, 77, DateTimeKind.Local).AddTicks(3943), new DateTime(2024, 8, 8, 23, 14, 22, 973, DateTimeKind.Local).AddTicks(3330), 2492.85m },
                    { new Guid("facfae53-4ce7-4011-8f35-cd2ac63bcb79"), new Guid("24256d4c-7032-4437-8c1e-dd211c5bd713"), new DateTime(2024, 5, 3, 5, 54, 22, 536, DateTimeKind.Local).AddTicks(2004), new DateTime(2024, 8, 9, 8, 31, 40, 942, DateTimeKind.Local).AddTicks(8388), 1222.05m },
                    { new Guid("fad2bd04-7606-4b4d-996a-133e3fd657a2"), new Guid("6212ef8f-9777-42a2-ad28-a2ed1ebe90f8"), new DateTime(2024, 8, 5, 17, 19, 55, 385, DateTimeKind.Local).AddTicks(6192), new DateTime(2024, 8, 7, 8, 17, 30, 165, DateTimeKind.Local).AddTicks(2564), 4779.70m },
                    { new Guid("fad3cc6d-3cbd-4582-bb67-d00a9883f5a0"), new Guid("7b94208a-340f-4ed0-ad44-07a96fbc7d7a"), new DateTime(2023, 12, 7, 3, 21, 39, 576, DateTimeKind.Local).AddTicks(8399), new DateTime(2024, 8, 8, 11, 44, 41, 738, DateTimeKind.Local).AddTicks(6058), 356.35m },
                    { new Guid("fadd02f2-b0ad-483d-be10-f2c815117747"), new Guid("9e65dc79-3d73-4629-8551-a5f2b9cfe2a4"), new DateTime(2024, 2, 19, 23, 35, 8, 128, DateTimeKind.Local).AddTicks(3607), new DateTime(2024, 8, 9, 21, 37, 46, 599, DateTimeKind.Local).AddTicks(2707), 4836.23m },
                    { new Guid("fadf0829-82f9-47d2-aaf4-07298e273bb6"), new Guid("841db90c-5f81-482a-a955-f91fc637a7f7"), new DateTime(2024, 4, 18, 11, 17, 30, 939, DateTimeKind.Local).AddTicks(5004), new DateTime(2024, 8, 7, 11, 49, 19, 78, DateTimeKind.Local).AddTicks(70), 4563.98m },
                    { new Guid("fbfa59ac-7db9-413f-94d3-de116532412a"), new Guid("427269be-9018-4cf4-9818-4fae14114ae4"), new DateTime(2023, 12, 9, 7, 55, 25, 921, DateTimeKind.Local).AddTicks(6645), new DateTime(2024, 8, 6, 23, 23, 18, 404, DateTimeKind.Local).AddTicks(3128), 398.78m },
                    { new Guid("fc40e075-1bbc-4a6f-a122-d49cc2ac1e64"), new Guid("17544f0d-9e01-4955-b49a-dcc4b6a770ee"), new DateTime(2024, 4, 1, 6, 36, 15, 597, DateTimeKind.Local).AddTicks(9096), new DateTime(2024, 8, 9, 5, 24, 48, 637, DateTimeKind.Local).AddTicks(5563), 4821.40m },
                    { new Guid("fc60905f-7d69-4524-b0e9-9ed7d8d8b96d"), new Guid("22ebc934-105f-4b38-ab74-feae23d1ffc0"), new DateTime(2024, 4, 19, 19, 43, 35, 514, DateTimeKind.Local).AddTicks(386), new DateTime(2024, 8, 9, 8, 22, 36, 92, DateTimeKind.Local).AddTicks(9458), 4475.22m },
                    { new Guid("fc6c0b14-fbb2-4e87-afc3-bc50b71746c1"), new Guid("eb503b18-f1e1-4a47-8871-99a4746eb8c6"), new DateTime(2024, 5, 30, 2, 13, 54, 349, DateTimeKind.Local).AddTicks(4040), new DateTime(2024, 8, 7, 12, 24, 46, 114, DateTimeKind.Local).AddTicks(4752), 4434.62m },
                    { new Guid("fc75a74b-4f0c-426e-9f97-130dc2597e87"), new Guid("d84600ec-9767-4cd9-8221-62d22397acaa"), new DateTime(2024, 5, 18, 14, 28, 16, 919, DateTimeKind.Local).AddTicks(2923), new DateTime(2024, 8, 7, 9, 13, 35, 470, DateTimeKind.Local).AddTicks(2175), 4454.22m },
                    { new Guid("fd31cf0c-5a4b-44c3-9a99-e4183f02712d"), new Guid("38ba8024-3b8d-4dd6-92b9-9d06da12ec6e"), new DateTime(2024, 2, 15, 14, 24, 7, 1, DateTimeKind.Local).AddTicks(7206), new DateTime(2024, 8, 7, 6, 18, 36, 308, DateTimeKind.Local).AddTicks(7423), 2683.36m },
                    { new Guid("fd89d5ed-4060-4d08-a13d-e5b823474a42"), new Guid("44514479-669b-45b2-8af4-510b0786de9b"), new DateTime(2023, 10, 22, 20, 42, 43, 630, DateTimeKind.Local).AddTicks(8120), new DateTime(2024, 8, 7, 20, 17, 44, 56, DateTimeKind.Local).AddTicks(9680), 1157.73m },
                    { new Guid("fe5d48fc-25ba-4839-8814-2f0adb5bfd64"), new Guid("920b6ceb-11fd-4534-8c78-0adccdc2cbf5"), new DateTime(2023, 9, 4, 6, 47, 37, 742, DateTimeKind.Local).AddTicks(1404), new DateTime(2024, 8, 7, 16, 40, 23, 765, DateTimeKind.Local).AddTicks(8992), 3114.20m },
                    { new Guid("fec93a36-c41d-46d5-9fac-3cd4d83bf4f2"), new Guid("952cbe13-c448-4063-910c-4a6b51e895ce"), new DateTime(2023, 12, 2, 20, 43, 5, 838, DateTimeKind.Local).AddTicks(9292), new DateTime(2024, 8, 8, 6, 41, 7, 900, DateTimeKind.Local).AddTicks(1211), 2171.06m },
                    { new Guid("ff0cb57f-41c6-4ab3-8d11-f2efdc27e4e6"), new Guid("1e3c140e-4cab-4065-aadd-2c1cfed5ce14"), new DateTime(2024, 3, 30, 18, 40, 17, 30, DateTimeKind.Local).AddTicks(2440), new DateTime(2024, 8, 7, 3, 22, 28, 49, DateTimeKind.Local).AddTicks(7067), 3895.91m },
                    { new Guid("ff514842-a253-41ae-9b01-365073fa45f2"), new Guid("5bc8e452-e383-427e-bc9b-c26642f1a642"), new DateTime(2023, 9, 5, 6, 0, 27, 108, DateTimeKind.Local).AddTicks(5037), new DateTime(2024, 8, 9, 20, 11, 2, 587, DateTimeKind.Local).AddTicks(2301), 2080.72m },
                    { new Guid("ff8a48e0-30fe-4250-b8a3-ac5716abd1de"), new Guid("232fdc99-53fe-4232-9c74-06ddfb2a13b8"), new DateTime(2024, 2, 7, 11, 55, 14, 560, DateTimeKind.Local).AddTicks(4695), new DateTime(2024, 8, 9, 4, 52, 18, 798, DateTimeKind.Local).AddTicks(5527), 2159.49m },
                    { new Guid("ff93d9b6-0cd6-4c55-a302-bcdfb5689d01"), new Guid("297e58cc-55d1-4c96-81c1-edd1b4b0ffb7"), new DateTime(2024, 3, 28, 22, 26, 48, 411, DateTimeKind.Local).AddTicks(4617), new DateTime(2024, 8, 9, 15, 13, 29, 74, DateTimeKind.Local).AddTicks(7020), 97.72m },
                    { new Guid("ffe275fb-28fc-4830-a8ac-cabcf7ca9198"), new Guid("24256d4c-7032-4437-8c1e-dd211c5bd713"), new DateTime(2023, 11, 30, 19, 49, 0, 5, DateTimeKind.Local).AddTicks(5669), new DateTime(2024, 8, 8, 6, 52, 41, 663, DateTimeKind.Local).AddTicks(9411), 455.10m }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_DanhMucSanPham_DanhMucs_DanhMucsId",
                table: "DanhMucSanPham",
                column: "DanhMucsId",
                principalTable: "DanhMucs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DonHangs_KhachHangs_KhachHangId",
                table: "DonHangs",
                column: "KhachHangId",
                principalTable: "KhachHangs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DonHangSanPham_DonHangs_DonHangsId",
                table: "DonHangSanPham",
                column: "DonHangsId",
                principalTable: "DonHangs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DanhMucSanPham_DanhMucs_DanhMucsId",
                table: "DanhMucSanPham");

            migrationBuilder.DropForeignKey(
                name: "FK_DonHangs_KhachHangs_KhachHangId",
                table: "DonHangs");

            migrationBuilder.DropForeignKey(
                name: "FK_DonHangSanPham_DonHangs_DonHangsId",
                table: "DonHangSanPham");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KhachHangs",
                table: "KhachHangs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DonHangs",
                table: "DonHangs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DanhMucs",
                table: "DanhMucs");

            migrationBuilder.DeleteData(
                table: "DanhMucs",
                keyColumn: "Id",
                keyValue: new Guid("149d55c1-1027-4a7b-9f7c-27d50557e199"));

            migrationBuilder.DeleteData(
                table: "DanhMucs",
                keyColumn: "Id",
                keyValue: new Guid("1a0515c6-6cd7-4ba4-a2b2-a2217bd8a429"));

            migrationBuilder.DeleteData(
                table: "DanhMucs",
                keyColumn: "Id",
                keyValue: new Guid("6bad827e-d128-473d-8369-b7ce6f0bc6fe"));

            migrationBuilder.DeleteData(
                table: "DanhMucs",
                keyColumn: "Id",
                keyValue: new Guid("6d44c2ea-4772-409b-bd9a-cb7fdda1c5a0"));

            migrationBuilder.DeleteData(
                table: "DanhMucs",
                keyColumn: "Id",
                keyValue: new Guid("8e3b803e-0d4d-4863-b237-3e178a0b6d66"));

            migrationBuilder.DeleteData(
                table: "DanhMucs",
                keyColumn: "Id",
                keyValue: new Guid("982681a8-5e92-40d0-a323-abbadea23773"));

            migrationBuilder.DeleteData(
                table: "DanhMucs",
                keyColumn: "Id",
                keyValue: new Guid("9c873fc8-2b52-4657-a221-b3857d47082a"));

            migrationBuilder.DeleteData(
                table: "DanhMucs",
                keyColumn: "Id",
                keyValue: new Guid("a2a221e2-9e50-4f75-b8c9-9d0004267fb6"));

            migrationBuilder.DeleteData(
                table: "DanhMucs",
                keyColumn: "Id",
                keyValue: new Guid("e22f142e-8f31-45f7-9ec5-484dccc0dafe"));

            migrationBuilder.DeleteData(
                table: "DanhMucs",
                keyColumn: "Id",
                keyValue: new Guid("f7a6080a-1314-4bd7-9b5b-3a9dabccf9dd"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("0042f890-95fb-494d-b0ee-a6a1de4b997a"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("0073a083-66c6-47c7-bf3b-a51d795115af"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("00946e58-10c2-4bbe-a09c-df6b78a464ec"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("00c907fe-344c-4a7e-9c7f-4e222baf7c6e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("00edbf6a-cabc-4945-b3f7-213b825528bd"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("00fde52c-fbaf-445c-bc0f-20d30e8c5dc3"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("0114410b-e7f5-45f2-b853-7b0e1d785620"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("0117b8f4-9858-4bd7-a0da-864cf01e00be"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("0150812d-7f29-4dde-88ea-501b36966325"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("01586d29-ad66-411f-812f-c7a502092f36"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("0200b950-471c-48c9-97dc-e451450abe89"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("025ceea4-de85-416c-ad60-e0b5f11ee9b0"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("029aa3f9-768c-4cda-964b-c52048e90b47"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("02fbf791-7c68-4d44-ad57-95a5bb85a020"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("030f13f6-6acf-41ac-ac46-3ab00c4df123"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("0311ac79-f709-4a48-9c91-f791fa30fc10"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("03391dcb-070b-4cd3-aeb6-924760c02166"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("03613a55-641a-41b4-ac62-d8c697080d89"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("03cda593-f217-4f7b-81e1-e6ad69f64c0f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("0466f063-b5a6-4d15-9cbe-9b1ca60d7e46"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("04c5ac9d-8a9b-46d1-b4cc-acc59746e56e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("04d33e34-6865-4d4f-b9ce-be08b4c8ac8a"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("05668079-ad5e-40eb-a763-709545da2759"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("05dcea8a-eb68-440f-a208-9ef3d17fc487"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("064d0d0f-09d9-4123-b801-4e32d4683249"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("064f5c45-5712-42bc-a008-4f2e534f4f8a"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("06857aab-92f6-4230-a595-d42304ce9056"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("068bb170-f243-499f-b4a2-9681efd66caa"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("06bab8ed-dd70-4741-bc31-c2b140269faa"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("06ccee86-78b9-4623-a592-ff844f3d0f8f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("06dd256f-32bf-4359-a8ad-f14f8b0b6080"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("073d247a-fba7-4cea-9e3e-1f65e8f3a9c9"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("0761b300-3e9e-46a8-9f81-b437b99a9312"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("07631f0f-a2dd-416d-a202-ed3aeabd0867"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("07cf5868-6e0e-40c1-8817-07272bc1558e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("08f9ce50-d979-43a6-a832-980e77e9bc58"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("09098bbc-ca5b-4860-b5ca-60ba21f4209b"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("094276d5-17a0-440e-872a-614c4f90c2bb"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("094b32dc-e299-495e-8840-c8e581b8f544"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("09b5a6bd-3717-4fe9-8930-9d8860bbdb05"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("09da8ef8-14e9-4c56-942c-bc21edf0ffcc"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("0a786f0b-a24b-4b44-bd1b-22b9514a824d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("0ab047d5-3bf4-402d-8647-5aeb43b35f40"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("0b2b2409-ca9d-45f3-bad8-843a01240191"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("0b3e73b5-c722-4738-8a2f-14cb4b557c2a"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("0b7a12b1-cb08-4376-beba-32800eff7842"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("0b9ddf11-71b5-4873-8360-695e44aecd30"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("0bc11e28-ba2e-435f-9444-99f2cad25c69"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("0c6acda0-2df7-425f-88fa-a3f99b24e577"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("0ce24b03-98ea-411b-8414-808bab255994"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("0d2e7108-7497-48e9-b868-8f87501bf4bb"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("0d5c7266-5f54-4e12-bef2-e941f4624c96"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("0dc4b7a6-6f3f-4d61-9bb7-3e5f85e8f0cb"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("0de66234-5f4e-4c5b-96e7-6dd9f055e93a"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("0e1ecd8a-bd9f-4584-bc49-1eed51829c88"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("0e70b9b4-b4a6-4db7-9088-b4c1c8f07191"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("0ebd31c4-db5f-41dd-8d45-651259f47182"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("0ecc2206-7c0c-4c5c-9f99-0d680e52cabf"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("0f94aaa8-6dbd-4cb4-8878-24096b6ae1a8"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("0fde66e4-3740-42b9-b877-6fa1d6dfe5c2"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("103eec76-8887-45c8-8b02-5b0686f6b72c"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("10550c61-154e-432a-a791-a4aed3b9fcb1"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("10719ab7-0210-49f7-b49b-48a29841c496"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("1111b855-9f5e-419b-a108-00a8c6000076"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("11253790-b438-43c6-bc47-98cc97f645a0"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("129b4f74-492b-4bbd-9dc5-06b558ad6c6c"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("12e05bb7-f787-4d12-bb03-52f77d685b59"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("136c9d11-77d2-4772-b815-0c623eba229f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("136ffb69-8ad6-4cd8-baf5-ef69ab064579"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("13cbf904-ce84-42f3-825d-0cd1710e0cd8"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("14246e12-d5c6-497b-a375-39a7e7c06102"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("143ed09c-7438-4d10-9585-5ffbb801cd43"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("14480085-3a7f-4121-b188-ca11bb99ddac"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("1476516e-7bfe-4393-877c-f009d07828d8"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("14b9ea95-9eed-4cb5-95b2-709cd3eefefc"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("14df59ec-a93a-4556-b892-2b3cf70e30e5"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("14e0251d-a28f-4e04-a275-d5930670fce2"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("150c6732-be90-47cb-921d-a06e69c2c3fa"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("1535626a-d75e-41a4-9053-c90c7033a363"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("1559d8da-6e5c-4e38-be2f-c996b374bc01"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("158492e4-e615-4e0e-84b6-73244c9acdfe"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("160b3b21-d4c0-4aec-b1cd-ab0db2af3883"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("165b81ea-88a5-4851-85c5-e055873d4b2d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("16709304-821d-4cdd-87c9-6966c90c0ce5"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("1698f824-8fff-458c-ab39-a06c96578262"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("16a0e250-44a1-48e3-940a-e03e13ae9bd9"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("16ba453e-634b-4969-8bb3-1fa4b59ecb6f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("172b5e29-5553-46b9-9b68-4e9be623e15c"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("1736ecc3-cc0a-4805-9bca-06625e48d16a"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("177a2dd4-cd4d-4d1c-ab16-2477e14ab9ce"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("177d9c11-b448-4bdf-90b4-f4d276266426"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("17a824a1-5062-45fa-9528-c488752a50e0"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("17c8a64a-c1ae-4d71-813f-4f4ac4335110"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("1801eefa-7d51-48b5-af74-d13a6519c07e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("18077e9f-bc07-487b-baa8-cbe3c0109b1d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("1822cab5-8e19-4965-97c7-6ad14c21bcd6"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("188d170e-05b8-46ca-980a-7b94f29f1e94"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("190c7fc4-dc17-4b16-8496-988256a2cab8"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("196c4b51-d01a-4d70-809f-138cc6b87a4b"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("1a08eb78-21e9-48c9-9c1c-9174117fc17b"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("1a118a23-649f-4457-a7ca-e6694baa4844"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("1a2ba674-e94c-45ca-8739-5281323bf161"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("1a3f8a08-af46-4e9e-abe8-9ccf83539e87"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("1a630e5f-6d48-45ba-acf6-a4927fa534c9"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("1abdcf82-67cf-45bc-adbc-de5eb57e86be"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("1b0ea78a-cf4f-4c3a-9f64-2a55c511ad6b"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("1b18bb3f-d718-4f0a-a2b5-4138b5da8a6a"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("1bcbbe42-6141-4b77-8775-76749ed82129"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("1c0efb4c-4a7d-449a-a29d-997c02141f4e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("1c45fc7c-f1e7-487b-b159-5e11a949d476"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("1c6f4b40-4cfb-4cbc-8dd5-9c7daaab1d19"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("1ca83c2e-a44f-4edc-8ea0-55931c19a4d7"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("1cb62b17-9124-4fba-b518-e5e39cef8737"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("1cd41097-c918-44bd-b6d2-f91ef5ab454a"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("1d1af3c9-388a-4422-850b-3e3f1c2d94af"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("1d7c432e-b091-4e8d-95c2-65b86cc2dad5"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("1e0c14c0-f694-4dbb-bdd6-d0e4fdd64590"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("1e1f3ea7-b140-4ad4-ae60-5c9aecbea104"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("1e4df49f-85e4-4798-a91a-2575b532f318"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("1e925cd5-0ba1-4167-ab29-5b91c356fe51"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("1eb2ec13-da51-4f53-8f6e-4d09a78253a1"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("1eb63a7b-9c35-4d2f-93c4-85874c9268f4"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("1ed98f17-de52-42a3-9c5e-1a4af64b104e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("1ee9acb7-5ec2-48d2-b98a-ec6f900de50c"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("1f669399-3349-4ec5-9483-63dbcfd595ce"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("1f8eee8d-2644-4e5b-a4ad-f12b5014270e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("1f927926-f6d3-405b-82a2-ea406cdde4b6"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("1ff5dc8a-4de7-4fec-9b3a-7bce9cfa6d6e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("2027000f-91d3-496a-aa7c-f18fe98523fe"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("202d6780-8e4e-425a-bc35-34fa2cdbc80e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("21832f54-781d-43fd-919b-0dac507f6954"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("21c84d09-a3ac-47d8-b7ca-2b1b0aa588c9"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("21d24e56-2a0e-4c44-b7ab-6270534cbe2f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("222d9fe0-5b4e-4af5-bec1-02a3b0e70d29"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("22cef5db-3369-43a3-a259-e25edc6c4cb6"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("23295f7c-a7ef-4bb4-9f6a-59137c8a56ca"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("23949674-0dc3-490c-8122-f2df2a6b6491"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("23dd459c-8e00-41e6-9538-a424db1c1be6"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("2402d5d3-01fe-403a-a07a-2b724ee346c2"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("24b9f3f1-96dc-4f11-826d-b0f2a36b2807"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("24cd1b0c-9230-483b-b8fd-25f4076e2423"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("24f37764-182b-43c8-8506-f4312770d23b"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("2505661f-f985-4398-93a2-539ea927ce8f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("261fc8bb-024d-4d6e-af94-dae80f639056"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("26289972-ac89-4113-9634-a10b20298fb1"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("270673d4-72e4-4892-a07f-59d534d4170e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("281952b3-9e8a-492b-883d-0c3ba39d9ff7"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("28481c43-bdd8-4718-8cec-7ee3bb65e9f5"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("284c7bd0-73df-4967-87ec-60d52b7a0c2f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("28e2caaa-e460-4f60-8b88-096464a474df"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("290c1e54-076a-4ea5-a687-d707838e87cc"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("29377659-b30f-4c29-871c-d263ec2bf2c4"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("297cfdf6-d3e5-491d-b73e-32a6056578f8"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("299f8abc-438e-4082-a288-c967ece78845"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("29ac8c04-69f8-48e5-af1c-9f5a8d4a4a4b"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("29b46534-e3aa-4895-82a3-b84522f8b815"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("29e83e50-73c5-425b-900d-2deef8480199"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("29f9ba60-7add-4eb8-b6eb-3ca571d60f94"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("2a12bdc6-f8e3-4981-b1e7-51f0998600e6"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("2a5f9821-c9fa-4d08-987f-cd297031d4d2"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("2a9426d1-37a6-47ae-a21e-b32c020b3c86"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("2ab0090d-3f3d-4a11-8893-0b474246f09a"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("2afa2003-e7e3-4327-9b7a-33d2b4a7689d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("2bc92d66-f4bd-4afe-b72a-c4b07b996811"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("2cd6cfcc-9c5c-479f-b44c-ec4de0a3a633"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("2d01fcef-c883-46b8-a5d7-51b387af3c8a"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("2d134ba0-6b40-4c5b-a15e-22eb608d7aa3"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("2d6c032e-3afe-4fe7-8c6d-270f5ade4c34"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("2d980f17-7037-4a68-9716-37213bb80164"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("2dd29083-560c-467c-8d6c-1d98a692aa17"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("2de32644-c4ba-46a6-a6f1-79dac85e6bc8"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("2e2418cb-b0c4-4a78-abaa-e8af5f1e9fb6"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("2e98f59f-def3-463f-9701-46d996713702"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("2ed78a45-bd54-47e0-8beb-9709542e210e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("2edc70ca-acb8-4822-968a-5a9545ede626"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("2f3139bb-0122-48a8-9d7f-38e9af7b13d8"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("2f38e0ac-4a21-4372-bfb7-c9683f7b3aeb"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("2f51df91-0d48-40c6-bfea-a91aa2076ba5"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("2f556033-6914-4dc0-a14b-1a52de790f8f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("2f763a52-b693-4d0a-b60b-6b83b34b4cc1"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("303e03fd-5535-428e-9e27-7e118fdd0623"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("307d9ac7-c15b-4e8f-a3ee-91f9d34141fe"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("30ce7fae-aad1-4c1b-9371-cb03be2381b5"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("31884e0b-3904-4df7-a6a2-ee4670138e19"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("319f4ddb-c1d0-4a65-ad8f-8c82947a33ea"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("31ab9716-dd0f-414d-a37c-506283a68db3"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("3222b106-d507-4514-a4fc-462197af01bc"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("32e149b4-cc28-4dde-8950-199b2d5f5b05"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("32ee121d-c66f-4591-8ba4-b79ab7950a13"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("33a3ebd6-a1c6-4ad4-ad7e-7d52a7f3c2d1"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("33df948f-27d5-4cd5-8bea-64ba086e1610"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("33e12c95-14fc-44e8-816b-22b3a0a848fb"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("3408244b-3214-4cf2-b546-30ae8226348d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("343d2ced-0e2f-41f1-a779-c09e537d9afa"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("3463701d-0a98-43b9-b54b-8542bacbe5d0"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("349d6d82-7942-4aae-9451-5a4fdbabeda3"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("34fc8006-078d-4437-8cf7-b49b5682eacd"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("3500add5-d20e-4bea-b135-477700c573a3"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("352312f4-c0c0-48fb-9143-6acba97588b5"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("35670954-3216-46b5-8b1e-20e073416014"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("35869521-0bf7-46f5-8cfe-9ac6e8d6c1b0"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("358c7f44-9661-4045-b5cc-f4fd6fc0bf55"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("3594f369-f75b-4feb-a871-514232a3e7f2"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("359ef38d-f8ff-444c-8d60-c41702220196"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("35a9c9ec-af89-4ffc-8716-b7bcfef4473a"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("35bc8810-ac91-4f68-b896-d4fa297a7450"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("35e2a6e7-3efb-4ec3-adfd-53ed798ad337"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("36c9b849-6494-4acf-a8d2-15c31369d59e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("36eb3c0e-e450-4a2f-ba10-012cd58387f4"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("36ed8443-8b54-44dc-b04b-7708bfc26792"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("3793258d-0466-4f92-b131-e58d62254d50"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("37f76665-e6e5-44a2-8b32-484c1130fb80"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("383133ae-f965-4d90-a98a-c5e36d41fca1"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("38597a9b-72e0-478c-b743-8ae2bb81fe67"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("38a29c22-dea7-4da4-a179-666d6ab2aab8"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("38c20d9c-b1b6-415c-ba4a-8508c8662639"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("3927a994-4a6b-49a6-bb97-7fd98571fcaa"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("392edafc-e7bb-4935-9719-8ff4ce88be28"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("3931766d-d383-46bf-9d08-1b22fabe636f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("399509cd-90d1-4713-b67a-3ce89599052d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("39b76d3b-c9f1-425d-9888-a0243edf9b4d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("39d852d9-f69b-4205-80ba-6e27358b00ed"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("3ab595af-8c5e-4466-aa67-3ccbf53923c0"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("3b448e0a-c3b3-44ac-93c2-755a275856ba"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("3b8f51f1-08a5-4f54-98a3-5db25330d9c5"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("3be73991-e0b9-4136-a610-77e1cc6aaa41"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("3bf66ced-624f-4cc5-bab6-72b667731b47"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("3d79ba65-a4e3-4a1c-9a0e-47ef215449b3"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("3d7bb141-5309-4310-a3f7-29981867bba7"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("3d8571c2-0d7d-4dc5-8f2b-97c6870aebe1"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("3dbe2954-8bee-4fe6-b430-0c7a61398775"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("3e9f4836-b133-43a6-8fe0-9ecf84cc4f09"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("3ecfc5aa-3b59-498a-bad4-b4690584302c"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("3eeae079-4ed6-44e4-a005-56d7d34d298d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("3f44adcc-4a62-47eb-aa28-ffcf6c6aa7c3"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("3f9c6d4c-c423-4134-b62f-3922637bc9b2"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("3fb5e95e-8c61-41f7-8c57-a798893a0448"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("4000624d-a02a-4e50-8f1d-0c3bae5df30f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("40a2bf06-5906-452f-a98a-813af3df8fa4"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("40ab4ab2-1fae-4052-bad0-8df251206d88"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("40db1a5a-a2fb-4ded-8d59-e3a3b6b2d743"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("4117ad5b-52aa-4f09-8843-3a55a9ba86e8"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("415f83d8-76a7-463f-a90f-e745bcd37699"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("419fe2e4-8d83-48e7-a08b-3423b0a60b86"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("420899fe-3402-495f-9d23-95077b8cff20"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("4229b4c0-6059-499a-9f8f-dac1ad9696f4"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("432dc5a7-3616-40a2-b2f9-0090f3bacbd8"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("437bb9d2-dce2-404b-95fc-6bacf2ff984b"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("44090c18-d663-43a5-b403-6381904b8f96"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("444580cf-64cc-4809-9644-553ab7223ca3"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("447db4b4-5490-4fbe-a326-99d1729be4a6"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("44850087-3a3d-46df-b8d5-d57899c09add"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("44bd1cf8-4070-4840-9f80-0fa640089b05"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("45530a63-8471-4cfe-96b9-b139e258766a"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("456c138f-40a2-4701-b760-3fc20be54b31"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("4646966e-447a-41e6-b46f-d98bf90ba74c"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("464792ef-6bc1-4a49-88bf-0f755e31606d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("467841ac-5152-4ec6-94a1-175b5e52ac4c"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("467f8fe7-fe72-431e-a6a3-45c325e69163"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("4736fac5-65a7-49ea-8911-2bb254d45add"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("47af4cd1-060a-4e0e-8ac9-c16a1f7d29a3"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("47da8454-ab32-49ad-a6d7-35882d9f9026"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("484759dc-7f33-4824-bc49-10047fdbe56c"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("489c76a3-2720-4b3f-bd27-91f999b38790"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("48a2aa52-40d6-4974-b65f-6f7664c996a5"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("48e73c42-d3a1-4d80-ad63-e8ac2d79d1f8"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("492a9c57-eaa3-4cff-adfa-f4d433e9ef8c"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("49700d7b-1e50-419c-b3c8-f6544b3dacef"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("497c21c9-0d97-47ad-ace5-ab23a47dc46a"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("49b3687f-a834-442b-865c-6c174e5abda8"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("4a23925a-bdb9-48f8-a460-d9f7257f61b3"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("4a485ace-cee0-465c-a053-fe72466b6f86"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("4a8f595e-c752-4668-858a-ec80cd7292fc"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("4a921c92-aaab-41e1-8ed0-be8fcd9cfcca"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("4b000b8b-a6e7-4bf9-bde8-d38ad89e1f83"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("4b9153a4-61ad-410c-b409-178a2b399cde"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("4c2ad205-3a8f-41ef-963d-2c67ac2cfa29"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("4c5702f4-6dd3-421e-82fd-e56e58caced0"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("4d948abd-95b6-43e0-9ca6-8ff7f5330596"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("4da39e1f-3b73-4fcf-bc97-31d28953d246"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("4da7b70b-645b-4734-88fb-d2f6085ecf1c"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("4df5432e-2219-4df4-8307-7cec2ed9e2c6"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("4e07c5b1-b317-4bb9-af31-4dbd4801a594"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("4e60266e-5b8f-421f-be60-27159841a9dd"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("4e87e8ea-099b-46b3-a58b-f982110e8156"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("4ec9c4c7-d483-4afd-9676-c22649011427"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("4f10ee16-3898-4d55-8444-dfe1fa4bb332"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("4f284967-8917-4914-8168-1e39b84b0b06"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("4f8b4e0d-0ea4-4f3c-8e04-557394e395d9"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("4ffeaeef-ddfd-4d42-a987-df0656728519"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("5039460d-c8ca-498d-a549-5729fad746b0"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("515ccaa9-53ee-4a65-acbb-e7b5c0db6252"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("5168b8fe-7e79-493c-8535-0e69b79d1a12"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("51b201b0-c8df-458e-88b6-b949f7d6c63d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("51b9b9ab-b11e-4bd8-9ae9-ca756aa9514e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("521b1794-9430-452c-970c-881fc5fc377f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("5240d84e-773f-45bc-ae95-483639fe3c06"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("524309ef-9f00-44ad-86ad-38cb52c5dc06"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("528a907c-0d40-4e93-b494-f1be3595ff9c"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("52f64b65-83f7-4614-9270-46dba95dfdcc"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("5332280d-03ab-4975-b430-df4cd0370eef"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("5393445f-63f9-419f-97ad-76143bafab34"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("5399f909-1a43-435d-af0c-a34bec6b274e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("53d4d3ec-a87d-4796-9462-a087750b8626"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("53e3075e-952c-439a-ab68-310f461a3fac"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("542b6e41-5180-4000-b330-64a6cecb3e09"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("54325183-9e26-4be2-bf7c-1aa5f296991e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("543b7b2e-bc65-4bd3-98fa-cb1236b6040e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("545d636d-81f9-41d0-8854-9426b979a6cd"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("54d4107d-7cbc-4ced-bf13-fc8eb5445a32"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("552d710a-8bb5-4c91-acc4-cca64762b176"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("554d6274-8305-47d5-8f3d-4167144f5581"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("55902a51-891a-44ee-a783-2df120c0d490"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("56337bac-5bb5-4a2e-9280-9718d83b805b"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("56d0f9f2-d4b6-405c-8128-32946710c723"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("57125d69-5760-4f2b-8e68-4949bfc337af"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("57e2d976-8c82-41e2-997f-e3503169762c"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("583c961a-9c1c-4979-a9d5-0525a18a2446"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("58810824-1757-43f0-b216-d5a70322a124"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("58d2a1d5-b01a-4c38-a786-ffa8d6d06c20"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("58e60202-9846-4a64-9e6d-95e8aa3645dd"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("59607d22-96ca-402a-85b1-b388f8d75526"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("5983039f-5b89-490f-bc6b-c0e89ad70898"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("59c24d7f-26df-47cd-aaa8-f0bf5b243b1d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("59dd3fc6-82c3-4233-8d48-a5afdb6719b0"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("5a13dfc0-a797-4918-82a7-78d3a90ddd4d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("5aae2369-deae-441f-befa-73f0046f519f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("5b325d17-9a24-4be8-b5e7-3557bae32429"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("5b4bc578-8b41-44f1-ba85-a0e479ff7260"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("5c12d635-6640-4fef-8226-7bf3a4a9fb90"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("5c437cf7-0013-4ba5-a93f-647c7ad79893"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("5c7854b4-bb3f-49f9-8c45-3ce75c9ff41d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("5c978d70-1d78-49a0-887b-e405876c5465"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("5ca18d04-195a-436c-9ab8-16d8c4be39a6"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("5ca8740e-7176-45b9-aca0-88a39ea0b6e5"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("5ccbcc3b-99e4-4349-b5bd-a4a3ff9a8a46"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("5d259862-47dc-4648-9fde-a9182158679d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("5d293bec-e6d3-4d1b-8f81-afd4fc61f455"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("5d297c67-b345-45e2-9222-850c7197cfa4"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("5d2ea5f9-146e-4df9-a0db-5eb1b19429c6"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("5d4a92e2-0464-4236-ab5b-e3fc0ecb0775"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("5d573888-5986-4c8a-afd6-1323946c5e97"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("5d5fc24c-1dbe-4d58-a126-8bf397344b5a"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("5d706aa0-2a61-4922-a4da-3b1441a95b81"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("5dd1b5ad-1ecc-4b15-adfb-d504cedbc1f2"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("5dfccb5d-1460-4f0e-bf52-7df2786f35db"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("5e4f9333-8737-4a31-bf90-24130196f491"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("5e58750f-34c7-4059-a095-128df3366100"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("5e66b080-c259-49db-93fa-1b3c22d806db"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("5f1d178e-edf1-4e34-a2d9-6d18bfb47df1"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("5f655e82-4b00-4275-ab13-aa9b3c2443db"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("5fc94f23-4901-4d3f-8fcf-a5f089949019"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("5ffc8ee3-aa9b-44f5-8f3c-42488f671574"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("607aa8af-a0cc-4f96-98ab-bcecf3927d12"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("60d4f521-807e-4796-8754-c439f081e11b"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("60f38592-6723-4cf3-adf1-1d062d6500c4"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("616989d8-9893-47e9-b811-8da09292a03c"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("6233cfe0-f818-40ba-b74e-82e5d8d2f81f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("6268db1f-d83f-4e1b-93c0-499e54c6f821"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("629efab7-b701-4284-9455-734ede0de5ad"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("62b7e0d3-4fe7-4e93-ba34-572a11e7267f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("62e9f80a-3bac-4857-8854-5a3520a72934"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("6349ef11-6831-44fa-80d3-2dec984c290d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("634cdc4d-aa3b-4f60-afa7-351e47ed5fd9"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("6370a06c-249d-4f57-a636-2e7ba58cf037"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("6391108f-955b-4785-8af0-e92d6cdb8896"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("639caf8d-c51e-4642-b7e8-188601b51250"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("639cb443-b2ce-487d-9ea6-d8f8c85b65cc"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("63f64787-aada-4720-b1a5-a3c8af196b5c"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("64363361-f4aa-4ca9-aca9-ace732c9a4c4"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("646bea58-6c8f-485c-bd17-aee9daa4e6a2"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("6496e8dc-ca4d-4200-a55a-d6de9e131e6e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("65235574-70e1-4804-a0bd-152110a9e828"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("6530f92f-0efe-4530-8ceb-59bd847637ff"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("655ac27f-f45f-4886-8f7b-6f3f7e005a9b"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("655ff793-0a02-495b-a1d6-684cd65ec494"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("65602d5d-de30-4d9e-9d33-7948020ccbe3"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("65c13d55-cf8d-4195-bc47-4e5bf7c08987"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("66606d8b-ff94-40bf-a720-1fff2bc291c4"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("666b05ad-7aa5-4a39-bb16-b684a1751975"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("670f91ba-8142-441a-b5bd-9d131c4f54ec"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("673943ba-0ba0-44bd-93fb-4a0da09d19e4"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("675267ed-c56e-41e8-912a-c46665c5a320"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("676b1d4f-cc4b-4f24-8311-357c62b07977"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("6779cbba-0733-4e3c-ab6f-14f9b54835c3"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("67817553-cf07-469d-b42d-072fbb5eb226"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("67ad55f7-28ad-4a9f-9d99-76f9cb7e2224"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("68282e9c-a1b8-4184-8472-69d6d6994eb6"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("6897bd42-04b7-4fac-b1d7-5fe03ec4ef18"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("68be47d3-9d86-466a-aebf-ddea5ab2b872"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("68f805f5-2b72-4b77-a8e3-44d21cd585d8"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("6907357d-de66-4ef7-902f-5fed14218971"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("699cee94-2697-4cfe-992a-d4f35763233d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("6a016a30-8d30-4956-be51-79ab2ccea823"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("6ab009da-de7f-4f17-b333-cf2e206e517f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("6ab42591-45cd-43d5-a17a-ef195abf0d01"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("6ac263b0-9c52-446c-9fa2-d381d62e399e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("6ad1960f-8692-4ecf-9889-f721a4be29d5"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("6afc1c97-a1bc-4a76-a0cc-ce272877a1f5"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("6b1c33a5-838a-45d9-bed1-f0a72bf75ee9"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("6b5d9fd9-aeb8-4541-a8a7-2c1cf7e6256e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("6b7d9ddb-d5c5-46f2-bc91-29d0c9bb40b7"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("6bb6ba36-fcf1-4d69-96fd-8ecbfe61ac4e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("6bf3ed17-1106-4acc-bb44-e1d4dc6cc5a3"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("6c449417-b790-43ef-b5ed-e6bcd6c2ad9b"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("6cfc6dda-33bf-4cd2-913c-435becc1634d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("6da1223c-bcd2-4df6-8eff-aaedd33abb24"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("6da8d16e-3aff-4c40-851a-948d62fda8ec"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("6db57454-431b-4456-be51-8f83d1e0892e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("6ebbe835-4d55-440a-9e5a-90ea78aa9ea7"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("6ed24c37-1c5c-447b-aac7-528808f341e9"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("6eef378f-a36e-45cc-8565-19147c9547e8"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("6f0bc07e-696a-4821-b7fb-b4abd090e51b"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("6f3927c2-f20d-4afa-a2bf-0fb621b6296e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("6f5ebb4c-b19c-42ff-b9da-7b0f49ea6890"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("6fb75147-c13f-4936-a399-3386237b2840"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("6fea9ea5-6fac-4c05-a7c1-bc81c453b882"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("7051b6c8-ef46-4baf-9777-aa507c8a0f2f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("70606370-6cdd-4faa-8659-3246a4c9d1a8"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("70a61763-1224-4b75-b7cd-b03e20331897"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("70b6b10b-270a-4c06-b619-9c06e748c5d0"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("728dc7cb-3fa6-4c06-907e-fae93c97365d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("7295b410-49af-4b73-8104-5a5579e224ac"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("72b1cfab-407b-44ec-a355-e520802e424e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("72e45619-4b7e-43cb-8457-25c7532ded17"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("735c2cf6-cdfe-4043-b502-4b8a897bd3c0"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("7381293a-ed06-414d-a7d0-b902854b0bad"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("738633ca-cd98-4ab9-8bbc-e6690d24c7f7"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("739ebf00-2a89-4add-9670-fc962142352e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("74ccbab9-f5b2-4ae3-9083-78d342675750"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("74f326e6-c64d-42dd-8b3f-5290618be842"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("7506078e-165b-4880-8e32-adadb8d0498e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("75792d88-35f7-47db-a567-e58698ddc5d4"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("75b8a9ab-1bff-4368-8f32-1eda10954a39"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("7601ffbb-534c-4e37-8a67-c9e2b3c6b4fa"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("761bada5-0435-4590-b708-b465214b5ba2"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("761c3a41-3385-48be-a30f-2cfd97f0d198"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("761ca454-5e1f-42c3-803a-433881622446"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("762b6d4a-a135-4f4b-9ef9-0d1c2f1de622"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("765a28ba-0298-4478-8c73-5e180119563d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("766156d6-2f43-42ce-9c39-e8cc82088431"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("7683b044-abd1-447b-b81a-25c60f5a648a"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("76f61ef4-375c-4f75-927b-98bb1ebef380"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("7789a906-046e-4164-94f5-6a155c366f30"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("77d71e62-6587-458c-a822-306aef22db65"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("78192791-08d6-4100-95d9-70ff788b1aba"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("78219b71-99d0-4cb1-96f8-8240d66a04b4"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("78269cf7-cfe2-45de-a8e0-e7036a8eacc5"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("78a88812-9133-4882-82db-a1dfd8fb3202"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("78ae6724-9ef9-409d-870a-23a99fa46c52"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("78d5f971-b9fc-4407-b361-43bc233d948e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("790afa06-10f5-4cf7-b42d-b3a405b076e2"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("791f45ef-4156-4a6d-b346-00aa90d3044a"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("797828d3-c328-4c4d-94cc-d60037253ad1"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("79f161ec-d37e-4db9-b9bf-d4349bbd9ace"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("79f3b33f-a972-45eb-b6d3-35671a1cc160"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("79f978ce-a6ef-463b-a19b-29564a262db4"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("7a122234-64b4-4f7a-b527-4a0582cefbdf"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("7a359c90-8b85-43fa-82f0-111de6c8ef2d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("7a60c0db-2e8c-4bfc-8634-5f9812782ac4"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("7a78c4b5-a122-405b-9b84-a72b429f5dee"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("7a7b11dc-5ad3-40c0-b47d-ffa1b22c743a"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("7a8f7779-ede6-4c16-820c-1f9c05e64612"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("7a9477ae-9473-43e7-a24f-933f18b412f5"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("7addaafe-c869-411f-a4f4-9d8fc94cc716"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("7b00dee3-577d-47fc-99bd-afdda35e7c2c"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("7b0c658d-f739-4489-ac4c-c6b4e9f90aa5"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("7b5ac3fd-fb3f-40e9-a79a-3e6a2025f35e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("7bf68c1d-a1b5-48d7-ad3b-a1a51bcf26e4"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("7cf09bac-5059-4a6c-a231-b79a130530f3"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("7d0c06be-e684-4cc5-a60b-de38122d116f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("7d29e638-07d2-46de-a1b7-4499032d6eaa"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("7de51ff8-4122-414a-95dc-a01896b1e569"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("7e56a150-c089-4cf2-b412-9bf4a9dfc973"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("7e70be9a-4cc1-45e4-a949-55fe00303146"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("7e7b69a1-0bf6-4ddb-ab24-3058c547ac8e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("7ed649a5-548e-41c5-8ecb-b366bbb58ae3"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("7ef125d4-97ae-4ed4-a584-76e5d1ec7682"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("7efd0a1f-7fee-4895-9a93-9b58ff6dfaf8"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("7f03ed7c-064c-4bcc-924e-2cd550e195b7"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("7f097584-aff8-4e35-b823-83ac20b6ce96"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("7f09a421-ca25-4a82-8b25-9006ec0c07ae"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("7f6ad61f-1a87-4cbe-8759-53a1a6d7b3c2"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("80505423-0c43-4916-8c3f-5a5183396ce8"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("805085cb-983d-44e9-8433-57ed5904954c"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("8062ed23-10bb-4a88-a0e3-991397cc4903"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("8078bb2f-3909-4f75-b8d8-cb1319c42353"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("807a8484-6e1c-4c3e-8553-df92add765cd"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("808bb87b-d497-4446-aee3-4bdb6421eaf1"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("80be3385-d3f9-48bb-bfd9-4b82fd377c9f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("8100228e-7300-4afb-bd71-6b8c2ebb7a16"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("81fa255d-b0b1-42ca-ba55-3219353682d0"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("823645a9-d5b0-41ce-a2a9-8421366dfb78"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("829856c1-9d5c-4a54-96ec-4f56c0c7824c"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("82a4544d-a2c1-4617-ba45-4e379e90bb47"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("82b13db1-1d75-492a-b491-38b775435a55"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("82bc602a-fb94-4fb2-9bdb-a127bb82e8e5"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("82e8c42c-77d3-4d64-b009-9d3dc70f2e7b"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("83a9e4c7-66fa-4244-8de7-491bc926d68c"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("845ef0f7-2f94-42c3-b9d7-a0c258456d3d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("84bf634c-03a2-4611-9bef-798d7d74cfda"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("84c34166-42bc-40f8-bcee-b42075355ffd"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("854d7c97-1bbe-4ece-b68c-bc0a2e6c616e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("855491b4-2e2c-4fc7-ba98-ba40ee0e1a3e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("8593ca4f-829b-471f-8c99-2d9b306b1e65"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("85ede508-438c-4424-8f73-ad9833d55f90"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("865cb045-3fa7-45d0-a563-470f12799a3d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("867b140c-fa4f-4df7-bf32-6d166764fe74"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("869b3738-0318-4962-91c3-119efbb3c00e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("86ac90dc-8093-4d9e-95ca-d29bcd271441"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("86b4615c-b308-4bfe-8f8d-c053722064f1"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("86c981fa-5d8f-4f14-b02a-d99bb5ff092f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("86e22027-2775-40a9-afb5-2ddd99c479b5"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("870a7125-c682-4c8c-a35a-ad73db267fba"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("872df891-936f-4c2f-93d2-609bd02b199f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("879e3376-bc97-4b60-a6cd-e8d84b9a770e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("87eeca18-2a63-4077-904f-a9509f7781d7"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("882c0f80-6bf3-4774-9fa1-6290431fed9b"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("8843e9d5-636d-464d-bede-44bf178ad5f9"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("88e18de0-ec02-4605-abda-1fb6b3bddbbc"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("892720fa-a9c8-4dbf-877a-7da8a9bd1fd3"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("89831e16-4bd6-4e31-9862-95b43979c821"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("89b0a759-b141-4891-b976-db784d0aa52a"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("89b7893f-c3fe-438a-b62f-8b12db7b90c9"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("89bc6b65-4403-4cc9-aa3d-06fe84b5d20e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("8a0af168-e9c0-4da3-a9b8-6606f69d788f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("8a310a6b-c269-4c86-9093-2728b981f0da"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("8a32cd9f-9c15-44f6-97ee-42ea21305227"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("8a5501b5-54c2-4c88-9899-6debf83c78cd"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("8ad58a27-5105-4363-af5c-49ed75895a1e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("8b3cf28f-f973-4224-9f40-36135ffa60cd"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("8b61afe6-2461-4816-9441-51cff27275d3"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("8b6b96c8-a4de-449d-894e-e15a0aaafc22"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("8bc7d59c-df3b-46f6-9258-43bc3e375a8b"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("8c4bcbfc-ffe2-429d-934d-54ae410a825a"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("8c5e5e10-db8e-4509-990f-1d6165e97eb9"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("8c6bf3aa-355f-4ab8-94de-a48befe76387"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("8c89dd3d-7e5b-4549-a590-b343a370c458"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("8d100c2d-395d-4f43-9dc8-64519be93907"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("8d8555a9-6447-4ef9-be06-0263d42aa2d4"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("8e1380cc-7404-4d54-a659-e961a2c72a83"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("8eee5578-f9bc-4d4f-a950-6ecf648a22ba"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("8ef3c230-24bb-4fe0-b37c-b149f3273982"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("8f1bce3f-b827-4597-82fb-e72ed0a4ac40"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("8fddde56-6d1c-40d1-97fb-ddb3b3ea397a"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("8fffc6ff-5d5b-4bac-a4aa-be934c1eb021"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("90083cb7-72bb-418f-b31b-2da263d6d476"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("901a5af4-1920-4e63-b332-6dd257ffce33"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("901ccfa0-60d5-4e34-9dad-40fcfc984dbc"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("9090efe6-7d1d-4bfa-9705-dd55211472e5"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("90e3f837-bc8b-4623-88b6-941d1f17a244"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("91f3e551-d8ac-4093-8a64-3c5a47c42cb2"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("9229b103-4c9f-40e3-88eb-b51873c861e8"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("9270fb2f-ec98-4096-9f0f-41f596bd096e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("9273c380-bae8-4fae-ab90-f68d79fc2f72"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("927dd2dd-a04b-4c0f-b243-495158507c21"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("929ce712-f883-4acb-8e00-78df84dc85b5"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("92d53f53-c809-4101-a912-faf47ae8039a"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("92ec38b1-34a8-4a96-ad23-4891f48b9a37"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("935b6ea0-9441-42a8-afb8-231985b5ba16"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("9372fbe2-c633-423e-b7f0-9d9f2207b88d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("938eaecb-8b77-48c8-8a2d-7765c556bdda"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("9442a6e4-0900-4cf2-a24a-723165602f7f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("9450caca-75a3-4656-8633-9b4a3ecb2f29"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("946fb935-b12a-4614-8d8b-6270f73f74eb"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("9485a521-cf4f-42ba-b6aa-8600cfa4f408"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("94928cf6-b449-454d-9923-28d0393bbc59"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("94fc0658-19a8-4bf4-853d-fa0d95ded9a1"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("950ed818-8a5e-4d8b-8c7f-f7099e52209d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("957b57d0-9fdc-4056-be76-49cf6b4698cf"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("961d145d-6f9b-40dc-8c4f-a72e59447f2c"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("9681acd1-572c-4614-8c65-ccf1baca6d66"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("96d88234-2bb8-4b06-b972-9c85b43f6c53"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("96e81d37-a074-4d66-b241-e112f1b6b86b"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("9713ec79-8a51-4d1b-99e2-9b6105ca8d6c"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("971928bb-7fb6-4446-a06c-359869561371"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("9744e1e6-fb09-42be-afe9-841dbe9f34bc"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("974b57b7-cd20-4516-8871-6586d98d4bda"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("9750fdbd-63e4-4cdc-b2e7-3f3d6b8c06a0"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("97639a8e-3246-43ea-af03-5df0a3ff4e10"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("978bcf74-6346-4802-8fac-237ef79b5189"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("97ba8a5b-5dbd-447f-bdc5-67050be12732"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("97d34b93-8f8c-4a9f-a0fb-757bea571159"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("97e064c8-f863-462e-9ff0-c4369ab89097"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("97e8f72a-fcc9-4b0d-b83f-1a65742d175f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("97efaf75-4dee-4e0f-9848-f29d77648ad1"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("9805d779-11a9-4443-9fd6-b9f8d4c793b9"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("98213489-4942-4a70-824d-3188d5770717"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("9827204f-f0e3-430f-872f-6bb82c38b1d6"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("983df22c-f9b5-4a77-b08e-6f9b98b7a346"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("985880a4-4211-412c-8305-27265de6ef66"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("985f7b07-1aee-4984-93ae-e52239e51eef"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("98a1801c-5be7-4fd2-bade-8cb846c35ef7"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("98a1afba-1172-498f-8f42-10decf86313b"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("99245caf-5e9e-4cef-b806-571b97176dfa"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("99553f43-e664-4735-8903-d81b70f41c69"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("99721087-a98b-4842-8cb5-4466585b255a"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("99cd3a6a-8e98-45df-a017-4320912d641e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("99dac0e5-e003-437f-8088-a500572d36d9"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("99f47fab-362c-4d74-9355-310973746023"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("9a13a67b-44c8-43d9-828b-c8dc38479817"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("9a45a8f9-4902-4f2b-854a-62fa07421828"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("9a4ee26e-d727-4048-93c0-03ffb155c7fc"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("9b2458ba-a9fe-4e21-9e83-58b55cbd1304"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("9b47e2ae-8c74-4143-bebb-97e8c43c5625"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("9b727d64-606a-4051-992b-999d5b6121c4"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("9bb52b64-0b5d-4ee8-9552-6bb3d777d5c6"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("9bdb182a-b8b7-4a57-ae4b-ce4f922d2097"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("9cc1cef1-5595-4d09-b620-3decfc0eb295"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("9d172960-a46c-49a6-b8fa-a53c3843735b"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("9d4e64f8-d2da-43f9-905c-73077722abfd"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("9d53a772-138b-4615-b58b-8854985819f4"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("9d8f95b7-14f8-4563-96f4-621ab661cbfb"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("9dd48335-4d82-4b57-9d75-155952443737"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("9df2d089-6323-44bb-bae9-4fd6f0e98adc"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("9e06a8fe-e9ca-4096-8896-32cd6675df79"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("9e2d2aca-a6e8-4c9c-b0f5-9f8d6fe168d4"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("9e2ebb56-1d08-42c8-9ab2-2edb450d0db2"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("9ec07b92-ce9c-4a7d-b844-87a5cb5a955e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("9f62abca-3116-401b-a632-0a3268c0aede"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("9fdf2090-f921-41ab-b87d-ba6e632a6403"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a09d0172-6177-4408-ad10-d5573867aa28"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a1051770-4c3c-42d8-a357-b63dbd5779c9"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a10b298a-4f57-4b7d-adfa-a017a27d72ed"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a12d1dc1-e9db-42ac-8c69-4ae401b62e6b"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a14712f8-14f4-4111-81de-14f98860e18e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a166f023-ac7d-4791-a6ed-8371fc0cd700"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a16e7559-56b3-4e46-b276-a35615d4bc60"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a18d7d81-884d-4cf3-8578-1e85d90f9b4f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a1a35a42-e096-47b7-971f-80ed96a890d2"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a1abdf3f-535c-446f-a2e3-c5134895af44"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a219d2d2-8faa-4c78-9e82-886497a561d0"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a250e423-a2b1-439a-8fc8-018931321fc6"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a28b0668-1a63-4749-afaf-dc921fc5579d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a298ff6a-6a22-405a-8eec-700ca24962c8"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a2ce3204-4f6f-41d8-a06d-fc42b9ef9fc3"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a3413860-71ba-47b2-8230-616a68a43f6e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a34f4b78-e4ba-49e7-8596-9e3e3ebc8b8f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a39ea3d5-65f4-4032-a767-5519f667c8f1"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a3efa913-6144-4e48-be66-b8b36508f6f9"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a3f3b88a-ab6e-4022-a33e-424d2ad0b654"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a48b7512-e924-4f10-9335-b490fadd2e0d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a4d6949f-2e68-40c2-89b9-34e4ac61f6f9"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a4e06baa-a5d8-40d3-9d05-89a7ac5288ed"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a501ea1e-ebd8-416d-a102-b8e80370f863"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a5a47e31-13cf-4a0e-922e-bc336083703a"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a5d3834a-cba1-49aa-9824-47f648abd924"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a5d5b874-d425-42d7-82e6-e981363d2e36"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a637d875-2a68-468b-9f4a-9d7ebeb2b7d7"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a668420a-688a-4599-9a72-974a559bb3a6"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a672e648-3253-44a2-a105-8926f0609eec"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a682f574-3392-4c2a-82ad-3f43f0821530"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a69734d6-a98a-408d-b46b-b5ed97e18c58"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a69993b6-8957-4953-8a86-5b8935e1112b"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a6c1bfef-f2fe-4305-b547-46df97f7f81b"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a6c5af6d-be85-4624-bcd9-f88b2b3ce49f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a6d5bf29-4c85-4f04-99b5-12cc012682b5"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a7499901-f888-4ce3-832a-dc1881cba1e3"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a76a029a-d7a1-4b00-9709-f3a6cbfd830b"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a824d5b9-a011-4930-8c56-48cf8f2834a8"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a869adaf-d528-4e5b-bb05-ed6de726e76a"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a8a67a07-bd50-48ee-9393-3bfb53b860f1"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a8e22050-5d68-45b5-966a-ef468d83066a"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a9121329-aec1-4cb2-9683-73b69b632816"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a9697767-8d08-491e-bb35-203297e8f658"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a97da830-82b9-4a54-9149-f3b616a66a84"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a9a08656-ffcb-4ef0-8530-f020050e8c6e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("a9d672a5-9c87-4d36-8ef8-76b8bcd2cf07"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("aa812ea0-19c1-4c6b-8092-3ca8197ecd75"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("aaa897b4-95f4-49a0-b677-3c9eeef3186f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("aab56acf-0e09-4ac0-ae39-655d95b7ec36"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("aacc7543-99c8-4798-9310-d44c8d297368"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("ab07c285-d887-4eea-ac9a-5b34ddb9b57f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("ab5b210a-e0ce-4756-b369-926554b88ebf"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("ab6f8a00-453b-4896-b545-56a4aed16fb0"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("ab7be0a2-f3bb-45b2-b0d7-181773317794"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("abf02abe-5d97-401e-9cb6-69a189c912ae"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("abf2c283-ea0e-4949-9a9e-fb3912477f57"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("acd09271-1a19-496c-9352-94f22efd1fda"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("ad01ee97-8063-46d7-b111-bd5c87c14e86"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("ad3d9290-0c1c-42fc-a69f-690d19b1bed0"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("ad637b1b-eb63-4c9c-a297-50bd4c06cf0a"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("ada7df00-ef2a-4e1d-9538-c163e03d564f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("adc716e0-62e8-4082-8825-8cc565a46ce7"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("ae572960-a575-4fff-82f6-8ec0d0435d22"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("aec6abe8-22c9-46e7-a96e-82ec1fb8b60f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("af7a3176-4550-4218-8e02-b48c05415259"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("af884855-c75b-4fb8-93f8-0d83a2db2374"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("afdc5483-d26f-4c1f-85cc-b861ed5cf819"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("afe9d5e8-2598-4892-8bd9-23601db564c1"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b04103ad-9445-4755-a9b0-167b0f87d31b"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b05b357e-3e86-440d-b794-9f12872e15a8"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b0832d6a-9dff-409d-9bc7-d6f635a143c8"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b0be0825-4786-47fc-bdfc-18fca103e47d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b0c3cae5-4d0d-45fa-8d6c-7624ca65832c"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b0d6ad50-047e-4827-9a5d-c6e7c0fcc794"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b0e32fb2-f15e-41b3-af67-fe9d960d4d80"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b0ee34ff-3c20-41f2-85e5-e3d85b31fd8e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b16954f5-b41f-4686-95c9-a2f6a5cbe288"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b1e22e96-aff4-4e50-a06e-8d198f897833"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b20df73b-16f4-416c-af8c-ee7a26fd118d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b219068d-6e05-4750-b818-92c2409bf82b"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b2336991-8e7a-4381-943a-acbb53f60b39"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b2760b4c-930f-49b1-aa4e-557a82f799aa"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b2b265a2-7fa0-4bdd-bcb9-1f41ca16b8f7"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b2e80910-33df-4181-bdca-c33fb3322c7e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b2ece2a4-4534-4e77-a608-ccb0bcc0cd35"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b37d633c-368e-4246-b24c-108d2c65fb55"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b4452e16-981f-4edc-9797-25946dbfdb14"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b49b5d39-555e-4e84-887f-f8ce6d2cb539"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b50a3afe-0c24-4ad3-b4d0-e0d13ca6a3ae"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b5165072-3bca-4d6d-8658-dbeb7dfec416"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b5893e1c-8664-442a-8c80-90499dfe1ffb"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b5954cf3-9e01-44db-8815-26417c78aa25"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b5d7d3c1-56d1-4d39-a3f2-f6da2c100467"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b5f10978-b5a2-4c3e-85e9-afeab01fe7ad"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b5f42422-6715-41f4-8b47-218c8dbdfcab"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b612c714-1db0-41a8-bb1f-6cda510fd680"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b6460a39-93f6-4bd9-80a7-cc9c992971f8"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b6579706-1bfa-487e-8889-624dfa1652aa"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b6fdd0d9-082a-48ab-b492-29bc03c87af4"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b703995d-5354-4911-992e-1635425587d8"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b77a10a8-4296-4da5-864e-8fc3978ffcf5"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b7918382-3dc9-489a-ba05-5a37720875e9"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b7d48808-2fd1-47b0-9daa-38305ad40c7c"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b84a524f-ad93-4b0e-84a5-136106b69f37"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b86229f0-c5ef-4d45-b9a2-02627ac12530"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b8aa591d-926c-4c87-8717-8cc224fa3d25"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b8c54c5a-0ea2-40ee-8655-25b057c6cb93"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b8dbaa11-e232-452d-9e59-9d1ce52b2ff6"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b9683a6b-b1b3-45ce-b8ba-97010122dd27"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b9773296-b805-4fb7-bb86-31286b963737"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b9b258e4-7629-4e39-b9e1-3d537f3cad4b"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("b9e77d29-91d5-49b8-85fb-de3bb49776a1"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("ba3e6714-cdaf-45d6-af44-a03bc1e979a2"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("bab187b9-b808-425b-be12-6ac79eba84ad"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("bac28b68-417a-47ae-a898-4b1bbf7055dc"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("bae904d2-7c3e-42d3-ba17-4c4ae1453390"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("baf70bc6-31f6-4d01-b9fb-106d5c3f174a"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("bb5263db-a85f-40ae-b8b7-fc9974d18643"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("bba7e357-00c6-41ca-a517-1e8421abb05e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("bbb36c1e-f9eb-4e3e-9bf6-98ef456a0180"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("bc295259-4bea-4f7c-8aba-7627404e208d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("bc4cc268-5e5b-4e49-be0b-8e3d1c0d54e7"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("bccb365a-7c4c-443c-bce5-bb7956dbb7c5"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("bce4c652-cf67-427c-bceb-bc98d1be026b"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("bd149492-acb0-490d-91eb-78e98e05e8ab"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("bd23b2be-04d1-41e4-9d5c-4a3ac2755f4c"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("bd2cbe28-e0dc-4860-91c5-9022e5b3f538"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("bd5dd5b3-0585-40b7-9d1d-6d2682f40492"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("bdd9bafd-6f23-4015-8b35-81c16a2520e4"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("bdf0d7f6-83ad-4ec6-ae8c-4ca753bbe277"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("be1a6a0d-47ea-41e3-8e95-b2b49aa74078"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("be4f884c-b9d7-4598-a2ac-f6a33ae6ba43"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("be8b8345-9102-4bf1-9686-a04cd3c91b1a"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("bfb4cb0d-115f-4cdd-a6dd-2c8a99e9391f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c011c8c3-f68e-4d60-9337-a6c26c5a4cda"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c017a9ce-0f5e-4b29-a436-404c00fb272b"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c02415a2-c2b2-44d1-a055-989ecb0c8975"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c08a0172-a879-4e52-9bf7-0fa9028988df"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c0986bfc-cc6c-4f2d-9a2d-2edded750dbb"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c0bbae79-ec4e-4953-8e73-7a97c77ff828"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c100fb08-bdd5-463f-93a1-4abd14278fdb"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c14a7c07-7d19-48f4-9c85-8cc0d1d3bafe"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c170d3aa-91e0-4f17-9f60-9282a8d885c2"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c197b292-c9cd-41eb-9dfc-208e7ba0166b"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c1b1f263-4c3e-4d74-bcd0-88fb6950c67e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c1c37e38-2978-46db-93e3-bab923bbddbb"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c20dc5a3-27a8-470b-9726-ee1ade136b73"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c24c4f42-ba2e-416c-80f0-dbbe2ea3d9f7"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c26f0594-5758-42f3-a0fe-adfc5d1216d2"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c339fcda-00b4-4943-a902-b2a21217a09b"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c39bae6c-510d-4321-9620-69b169b8c483"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c40c938e-5e06-4ff4-8797-a67e82c413e2"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c4315694-5023-498c-a79c-0b77e642d806"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c471208c-1076-4d7e-a239-96e1db958250"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c51f9c0b-eb81-4d3b-9869-8099c5f1c4ed"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c54e745c-70d9-435b-9cca-e04a6b99a102"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c59e7653-3c11-4824-9263-e7fb713a9b2d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c59f37d7-9545-4288-a8cb-4ab159fd157c"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c627b95f-3e3f-4da1-b124-b10e4d079319"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c6a242fe-575f-4645-adb5-57a950eecfd8"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c6db9131-f0f5-43a3-856f-d707525e6671"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c709c332-f178-4d95-8eab-65f5db308215"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c790bad3-772e-4b61-a984-545d4f82a4f1"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c7ebea32-2598-46eb-9c55-aa5e69a879c7"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c837c45c-4739-4c4a-8719-74ba48574bd9"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c8822db7-f9da-4066-bd4e-149604d30eeb"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c88cc245-e8dc-4a34-bbec-24c492b290dc"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c8a3bf39-8b77-4a62-983d-f1496d7e4004"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c8bb7f49-3a9e-4907-9d16-ab361c9d88a4"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c8c3889f-849b-4449-aae4-263b558e20cb"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c8d90285-aaff-4d91-86b7-c1bd36951a14"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c978e902-1917-4dac-9ac5-13f3f1fe5a3d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c9f0a790-f0a9-45e6-9118-f8714d346a5f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("c9fe61e4-dc32-48bb-9930-1cc61bb6e94b"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("ca366ff6-3dde-41b4-b92c-971bc969b32b"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("caa9c4b6-84e8-4952-838d-b09c6d9a54d2"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("cadf0807-ec08-48a1-b92b-e19ade7f99ae"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("cbac5243-f7af-4237-9c17-e16c2e8ace79"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("cc0f554e-30a2-42ba-b49d-70ae7c352391"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("cc61712f-18cd-4a2d-add7-f69a3e4863c3"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("cc66453b-5b8b-4299-8f69-42c9bec3182d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("ccabfeb9-f53f-436f-9883-35d05586ca8e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("ccee8e4d-3421-4352-9ec9-e06a113fb982"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("cd45c8fe-78fa-49d3-af7d-34f847add27b"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("cd4b970a-5688-4c71-b144-67f578e34780"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("cd51de7c-98c5-42b0-a829-f6764fd073a7"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("cd6f758d-3215-4e01-b3f6-fc990c9ba478"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("ceaa4b83-3cbe-48ea-ae40-937b0d6c9ffe"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("cf357925-75b7-411d-9dcc-fe2cf2dd3ea3"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("d0c60e91-c22b-4673-a354-dbb6ad4d73be"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("d0cf2471-9597-4260-b0a3-cb8ce3d21aa7"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("d12e54ab-78ae-4622-9099-465f6d4f0006"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("d23736f7-d9f8-40e6-9d70-ceff27bd0f44"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("d2cb7b31-c304-4f58-bd50-a4d92b4488e5"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("d2e86d06-a997-466f-ba6d-85420d51f086"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("d341e770-4837-4ee4-8fc2-12a02da59390"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("d3514f42-3dc9-48df-a2d5-5995281a706c"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("d38e9579-27a2-4366-94de-31ef6f164067"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("d39de1c6-5336-4968-b458-483b536b8f9d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("d3a61c4f-7549-46fb-aa29-07c4a97be99f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("d3b026e1-799f-4009-90a8-06754d3ea335"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("d3e4eff6-8250-483c-be1c-ce742c9e6a49"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("d432e27b-a51d-458c-8681-f3b1a5836eda"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("d442b089-4f55-4f12-b2e9-b514151b546a"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("d4a6e198-8067-4d5a-8779-b31dc15cd71e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("d51df2b5-636f-4fcf-8e5e-632efb1f70b7"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("d520d856-d130-4020-93c1-fcbacc44cf26"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("d57d6f15-c980-4ac4-b843-9c03faccfda2"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("d59ce5fd-0d3c-4dc3-b033-cdd6b2e12fa7"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("d69e29cb-bf3e-4820-b876-3e598012c153"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("d6bba81b-0577-4e21-98c7-1468aade531e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("d6d387b0-1a7a-469b-83fb-12e49c6f97a9"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("d6f50ee8-b79c-40d1-bfbb-9644af6b23c9"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("d7c376fb-1d99-4cbb-a06d-620889206625"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("d82dda52-2f32-41e1-b5cf-1fa2d417e958"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("d85cd894-9333-4d3e-a3ad-31a545c28e49"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("d86914f7-be42-458a-8834-02ed02923c6c"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("d93e8d41-af55-4fca-a212-1a4fc27c4cdd"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("d9676a5a-fa16-49f7-9de7-1eb31fed3fc9"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("d9ccdcc5-eef7-4da3-b921-ee17683205d5"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("d9db161e-d442-4ca9-a975-2a77fb242ee2"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("da65f643-a8a5-4984-ab6b-cb8808dbd5d4"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("da6de4a9-c99d-49aa-977d-de56969cbbd3"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("da717af2-5f0d-453a-9aff-ba91d7347689"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("dac99f2e-5f53-4989-9ed7-bdf01061d44a"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("daf1cf53-5346-496e-9697-4c0c03f31475"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("daf75460-a6c6-4af0-b6bf-73ee9113293a"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("db27045c-36d2-431e-9cde-29a138c57fd2"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("dc2f05f8-e36b-4eaf-8f6d-c998470d18c3"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("dc9294d3-baeb-400d-b0bb-6516046b473b"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("dc99b99d-c977-4d8f-9b46-b5e98bc93eae"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("dce6a741-56f3-420b-97ce-c08ec245c09b"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("dd2134ef-4d90-459e-b6a9-37c8e59c7751"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("dd4a6b8d-5669-4797-8010-449a21dfe5de"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("dd8c26bc-fb92-4c18-8204-6f1a7431e568"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("ddab4cad-55f7-4ce5-82d1-196151ca00e5"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("ddd80560-4c9d-429b-983b-9774da534ee7"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("dddb4151-8322-4771-b3d1-ef462316e446"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("de0a4f41-bef2-4f09-b438-e7a4aa7b0a87"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("de1e1181-ef27-45ab-af06-d5c9cc5e1d17"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("de883864-6f81-41a8-b05a-700f9ab09f58"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("df7cd1c7-2d04-42ec-b414-d38829d1852a"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("dfa939c2-811a-401b-9fd3-b76f5adf62e9"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("dfb31eff-165d-45c1-94b6-1558864c7098"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e02735f1-505b-4a06-8820-efa91d1ad6cf"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e083851b-81c7-43ce-9272-085e3b46f150"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e0ae6ad2-465b-4f62-9f90-f178f8cb41c2"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e0d0cc3f-568c-4a11-b92d-2c437be0b51d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e107b7f4-63c2-4a35-9f68-2c840d848fc0"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e139b495-81de-4241-b791-86d4ce0aac66"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e1562968-5c19-46c3-9fa5-980e6c470ce3"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e1a865f3-8348-424a-8dc1-3837846f9fa8"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e1a8f171-c6ad-4d77-af1b-6ce880b3903a"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e23c6972-26c1-4e93-9e2e-913007d1fb9d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e248d016-01c2-4c12-bda1-575fc39cd4e7"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e24f50a4-bfa6-435c-a68d-66e7057b2bfb"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e2971b71-a2fe-4971-9b7b-be6c70430fae"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e2d59385-4eee-45f1-bb26-018465d8f886"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e343801d-b4a2-41ad-9095-56b49bdb550c"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e343af06-c626-4e31-a258-3badc258dbc3"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e34c95f7-0656-436b-a022-39ee91fffa2d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e4875a5a-cf96-45a5-8b42-742cd4e40f4c"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e494642d-eed8-4d92-bd3f-9f979df4c26f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e4b87b7a-7cbf-4ede-be1a-d8236518ae68"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e4ca13fc-7f1c-4e8b-afd0-3e9581361887"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e512bbf3-1610-4c4d-b906-408797aaef53"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e53c40f0-a656-4b65-943e-e718bcc8eb66"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e590d390-86bc-4434-b67c-d9376ef00074"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e5d7de5c-2e27-4ce3-90cc-aa0c5a23c250"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e5d95cb6-764e-4f88-95aa-32a505fdfe4f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e627e217-8d63-40a7-8b0e-ab6c40f6acd7"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e627fd98-98c5-471e-aceb-d6d9791213bf"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e6311cbb-826d-4d8c-8ebc-cf286d3a2b7b"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e640cf5f-607d-4f68-9fa4-be48f1a3c75a"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e6500fcb-a493-4544-ac11-21d181a50d65"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e6ba59b0-6697-45f0-86ca-e570ae707a1b"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e71a4c07-63c1-4099-9b57-8ec24dd3fadc"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e72ad463-a4af-4cfd-b0eb-67e59ec411df"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e77bfdaf-2074-4134-ad90-19034d807198"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e7e30719-c92e-4c91-bc05-81add141bc85"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e7e8aeae-e9b7-4f0a-a25c-2c4e5f167576"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e875b61b-5b2e-4c46-b6b6-438c9c709a20"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e8bf1631-8187-4f48-8207-b9e0b77ae2bd"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e8bfe245-405e-4f61-9e45-2be06a1fd47e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e9223720-c105-4170-97b8-a959d8e7c3ab"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e92ef0c5-0665-45f2-a8d9-11280b18659d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e9306d42-fe22-4b4f-b674-108a3ba898ba"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("e9709acb-1257-427e-9fc8-8b7d4d310f04"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("ea02ad57-e75e-4e88-a034-4c67f6272e33"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("ea076f3f-a720-4bec-a19f-686b95717d36"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("ea34281a-e051-4eb6-85bf-7dcc61ae5be1"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("ea35d7be-f4ed-49a4-b396-d01edbfb908f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("eab674c1-3cf5-4316-913a-4ef20aade010"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("eabbb49f-c1d3-4c04-943d-71b584976f38"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("eacd3a57-d92e-4f51-84e4-ff68da9b7943"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("eae61e70-cf00-4fa9-ad29-f83e9d0f8bfb"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("eb0092b5-74fc-4f6c-9d4e-3ba89b6fb9a9"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("eb0ba3ad-c1a1-4c4c-800c-ffeafc9da719"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("eb3392ec-c27b-4795-bf9c-7eb3b30eaace"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("eb6910ab-fed2-4942-b2db-8c48804c20d7"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("ebb2f78b-c285-473d-a20e-223f9263cb01"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("ec1afccd-b878-482e-91dc-a55d58546b49"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("ec1b42ab-8873-464a-bf21-d32f6f5386ef"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("ecaa1e12-7fc9-4455-b849-bdcb623dd1bf"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("ed5facd1-f7e2-4af5-a654-39f6d3ac3371"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("ed72c251-cf40-4495-9237-3a11572b02df"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("eda2ce1a-6ed8-4ea9-bcf9-98285b98883f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("ee40b055-47c7-453f-901c-33f5c5f4b4e5"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("ee61dc29-8d83-46f1-897f-7e56837f82ce"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("ee9c75a3-898a-42bc-b652-e3f557e1948d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("eeab1f0c-2000-452d-91e9-e5d0a2bb3dc8"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("eeac5285-dbd9-4e62-b182-47681b5a6da3"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("eeb16642-23b1-4f93-88c7-e25273a676b1"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("eebaec2f-bb74-4770-9d8f-36c3574bb9bc"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("eee8f314-3a64-4b6a-a269-edd47f24df21"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("eef7e50c-5ef9-4c7d-93ee-a6453b972fb4"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("eff0b9a5-002c-43be-81aa-3e3446d7ec3b"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f0276d01-1236-435c-b1ab-5a2ccde518fc"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f027700d-feb9-4320-a6b4-2bb2f18568c0"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f0a53eb7-8e15-4ae9-9b3b-1225bbd5d82c"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f1b2a7a9-42e5-4004-849c-76c83ba6e5d4"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f1c6bb0f-0019-49b2-aabb-73363e3d832d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f1c75421-6cad-49a5-bb51-e0873a98d550"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f298462c-0976-4a7b-b5e2-96176bc22fda"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f2cbe9a7-453e-4a46-ab01-b62c44c6725f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f2cedf0f-7ce0-4459-9ded-62be9612c814"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f356a846-8e8e-4db5-ac4f-21dc70dc2991"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f3715b95-795b-4ae5-8302-0c943ad0a30e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f3742c28-3adb-45bd-bf1c-0e1bcd7a0eda"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f38a0800-4f16-4022-8b7d-73135c7d2127"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f3b08fd1-7bed-42e8-9484-79a3f45ee032"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f448a8e0-bd4b-4d70-a0f3-9a16a2addc7e"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f524ddaf-15d0-4555-8e79-bb2194b8293d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f529a285-4a72-4e3d-ae68-fe4f4f3d856f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f5acf3ae-8da0-4825-9769-c00cc9bed444"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f5ca3d08-2109-4b4f-92c5-1c8bc48d11d0"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f5dad759-aa4b-4b68-92ad-6d3914d6c586"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f5df8b86-2c18-475a-91f7-1eb821ae9415"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f5e63539-8523-4b05-b0e1-c6b20a2d6310"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f6034989-e5f9-49a9-9e45-0bda7ab5e453"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f63e755c-c016-4f21-819f-848c9138d7a3"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f65abde3-ffb1-48c4-b5c2-6c0d74a058ce"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f6dd41be-3a0d-4d17-829b-c52fbaa09782"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f6fc304b-d307-4efc-8d1c-75b8715c3861"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f6fd6937-1828-4f4e-82be-3857c140d3b1"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f768c4ae-39bb-40b3-98e2-ee54eed10167"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f775f23c-e267-4ebc-ba17-10fd466487bb"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f7fa4f06-f051-4cb1-b214-96647525a688"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f81669df-16de-4c48-86d3-19b7089984bf"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f8a86ad7-a11a-4428-95ef-c36fb1615de9"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f8e0bb4a-e9b0-488d-bd8d-c82bc9788fbb"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f8f4d840-5fde-41ae-af93-f2be63b72939"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f8fd640a-0858-452e-9e03-73407d34f37f"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f953bb79-37bf-48a6-8054-79d115105f9c"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f9586008-5907-4641-a945-9c58eda5c5df"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f959b1c3-3e78-49cd-b515-7c9d9f384382"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f996e445-25cc-4cda-9e52-4a871fe8c2ed"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("f9da1cba-37dc-42cc-80f1-8cba4289dc20"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("fab8bc4a-04f9-4353-9327-0ff5622717f9"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("facfae53-4ce7-4011-8f35-cd2ac63bcb79"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("fad2bd04-7606-4b4d-996a-133e3fd657a2"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("fad3cc6d-3cbd-4582-bb67-d00a9883f5a0"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("fadd02f2-b0ad-483d-be10-f2c815117747"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("fadf0829-82f9-47d2-aaf4-07298e273bb6"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("fbfa59ac-7db9-413f-94d3-de116532412a"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("fc40e075-1bbc-4a6f-a122-d49cc2ac1e64"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("fc60905f-7d69-4524-b0e9-9ed7d8d8b96d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("fc6c0b14-fbb2-4e87-afc3-bc50b71746c1"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("fc75a74b-4f0c-426e-9f97-130dc2597e87"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("fd31cf0c-5a4b-44c3-9a99-e4183f02712d"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("fd89d5ed-4060-4d08-a13d-e5b823474a42"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("fe5d48fc-25ba-4839-8814-2f0adb5bfd64"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("fec93a36-c41d-46d5-9fac-3cd4d83bf4f2"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("ff0cb57f-41c6-4ab3-8d11-f2efdc27e4e6"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("ff514842-a253-41ae-9b01-365073fa45f2"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("ff8a48e0-30fe-4250-b8a3-ac5716abd1de"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("ff93d9b6-0cd6-4c55-a302-bcdfb5689d01"));

            migrationBuilder.DeleteData(
                table: "DonHangs",
                keyColumn: "Id",
                keyValue: new Guid("ffe275fb-28fc-4830-a8ac-cabcf7ca9198"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("0129a943-1e72-4a87-a6ad-5474891cdfa1"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("01dbc7fe-cb57-4b01-b41f-b388e3ed6f5b"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("0e11ed77-a966-4f24-9f20-433689ec3513"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("1179548e-0bfd-464c-bab8-1a8c58a827df"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("118ee715-cd4c-4bdd-ad60-d2221336d27e"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("18b0122b-d6b9-400e-aa86-9b4f724ac4a8"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("1d507181-b2ea-46ec-a3f1-31f699e7d228"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("1d6d36c3-5760-48a1-8345-c79eaace0a6e"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("2244967b-1619-414d-864f-e5f4cb0d837b"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("25397315-0f41-4f9d-87c2-4a22c9503864"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("2758da5b-c157-4721-8f60-bed6af3f9528"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("28c9ba2d-f95a-400c-977c-ed1997ee8673"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("28c9fd1c-dc75-4cde-9f57-aa8dce4aad59"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("2a101d21-6829-4243-b4af-24fa85325b87"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("2a4d9dbe-ea63-46ba-8101-a6903570ed9a"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("2bca4fd1-5293-49f1-ae0f-f88a4c6c8b67"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("2c25bcf8-5a63-407b-b629-91224df32ada"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("2d4f0df8-c030-4733-91a6-8d3ce856ae5d"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("2f591aeb-03a2-42db-aa09-187c7789e7f1"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("32f151e5-3b46-4f3f-988a-ca31ee142bdf"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("3a27a94c-f4fb-4822-a329-c3fab5f92420"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("3dc285fa-0383-44af-8946-6878da035714"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("42148da0-a7ff-4dfd-bf09-7fb853e95ba0"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("434e8f32-af7f-4a50-9697-3b89f45b0624"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("44a8a3d3-abd1-4604-96fd-bb95ce584327"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("44f1b674-024e-48f5-9c55-49b9dbd7198d"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("4ba47efc-332e-4807-aed3-d90fad8573d4"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("4f504d69-8f86-428d-876f-a8fcb47c5adf"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("50273962-681e-497f-b903-d95f2225c436"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("52097100-b52c-449c-82c3-a77df7a51f34"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("5539524c-ccd0-431c-9107-7b33de1a7120"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("568b98d4-04e4-49c2-b188-eecde7f5500e"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("56ad9dd8-daf8-4ae7-b4a3-588abd518299"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("574af140-7277-4929-8765-4b4ef7d681ad"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("57e2a48f-92c2-4a68-9c32-58fcbb8159fb"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("57f4ce40-a774-4ecf-8a56-901f4ad943f6"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("59500e8d-8153-4d0f-bdb8-9f2dc7000359"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("5dd01998-6489-4fea-8b95-6b4a2d80fee5"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("5f3cc969-9505-4dca-8055-7a41727cb5d6"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("6336c166-469a-4870-82b8-5262fbdc3bdc"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("659a821e-343b-4a6d-a22d-dad4f90a3cf7"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("65da7257-4c75-4cf1-91bf-65ee8b5715b2"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("68f1e6f7-ecfc-465a-9449-d89f0cf081dc"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("6c525608-af42-4646-937a-89c6bc3697ab"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("79d4b53b-5c1b-4699-9ac9-cc8c02eeaa5a"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("79d7fb19-38c7-4a1c-b711-edfbf9925855"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("7b396b50-4279-419f-9d90-44efffc70947"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("7de3d092-53f5-41f5-b02c-f5050f188b75"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("7fba4b04-81c0-4e90-a52d-8387456132f5"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("8190cd66-8510-49ef-9f93-ba6002e076f1"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("81e83fab-a650-4721-843a-7a4671c2b08b"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("83873ba8-0363-4ca6-a52f-b6854cce0ebe"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("84c2296a-807e-46b7-be23-77b0623708b3"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("8612f81f-5ed8-4c20-b287-36169a7d857e"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("8f85663e-ace3-4072-ba70-41e12565f18b"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("9076e39f-9576-4022-b22d-0a6b5430fa87"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("9518b051-2af0-4fb4-8e37-c7fb9453c9f6"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("9600815f-92ca-4e08-a75b-b2c80244f664"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("96c38b36-40eb-4ac9-9cee-7237b2c3d27d"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("9a5071bb-1cb6-4101-879d-b0cd8e427369"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("9c0562b3-1f41-4526-aa0a-7f5e48f0e892"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("9d2b5c75-3138-48e7-addf-87e9880483ac"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("9fa879c6-23dd-4f4f-a449-cedefbaa38a9"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("a4c5bd72-bdc2-44b1-af41-0b725883d175"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("a87a0901-c3e2-4318-bee2-4bd9e59882d1"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("a89987f6-a10c-4b5b-9d0a-7a8226c38649"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("a93914cc-2b0f-4e4f-8150-928c26f25fc8"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("a9a5a3ad-daf5-4e57-bea2-be9e2b00c61e"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("b28c8bea-c5f1-47bc-8f87-a5eed1ba134b"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("b2dc7e53-593a-4b92-ad57-110eb167cc4a"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("bd6f6d2e-e214-4d9e-a9eb-9f77887e8610"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("cdd81b11-08f8-42b6-ba05-cdda0c2a1d80"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("ced81675-59aa-4650-b3ce-b1e2f5608dd6"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("cf7eb913-3ae3-4c40-b8dc-d16be4ee82d1"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("cf899302-9b8d-442f-8071-cb6f4a2fd075"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("d309f396-cb57-4a37-a511-9303c2e644b3"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("d9bbe402-9a0c-417b-b213-8dc958fb5388"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("dab311e8-18bc-47de-8ee6-46f37ad45bd4"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("daba0dc3-d236-4617-a88b-06f9f6e089f6"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("dcc0c8b5-1997-4040-bd18-615643fe0e49"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("dd8050e3-6901-4566-839b-447d54457e59"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("dfd94873-4e05-49ca-a019-4ed8017036ec"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("e11d035f-a509-4c3f-965a-9bddf8a6e8df"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("e3471773-cd13-4e09-bddf-237317f9d30e"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("e3d74f22-3bf2-4e4a-aa14-17e6df30c4a5"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("e49ef9f7-0df3-4e25-b9c5-16643f15dfa7"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("e5d5f829-20d0-4f91-84c0-0b335ba95a39"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("e81bd9bb-3f49-47bf-85dd-033f6995164c"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("e8e56df5-3ba5-40fe-8ecd-6970275d69d5"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("ea9f433c-0b23-4f5f-8136-bf39a688d8eb"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("ecfdf8bb-7f1a-423e-b051-b106322e0559"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("f000a1f4-c4af-4db1-b858-d888ff0b2692"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("f2dabbe6-4db1-4189-bc2b-68f9603f7b0e"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("f61a46dd-1d65-404c-89e6-9c2d2a648ddf"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("f8f47ea3-b5d1-4b75-acf4-9d547b87ee1f"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("fae336df-6b91-4cf9-9556-fe8221ac567c"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("fb79e8e9-a08b-4f9b-957c-f19b0651a0ca"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("fbbb4e15-6e66-42b8-a342-afece72cba9b"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("fc6c427e-2049-4d2a-8fe8-e4632aa29c6d"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("ff4bf443-65f4-4dfe-b83a-031195b93162"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("052538e6-f9b6-4bd1-98e0-6e7d6744fb4a"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("063fdb59-1945-4f6e-85e3-5f57321287f9"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("0667960a-b942-408f-9aa5-8591f0e0599a"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("0b23e0d1-fa5b-4022-92b8-ff158e6d60ed"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("0bd930d6-b736-4558-87c1-50bd97e08db0"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("1248d1fb-1e80-4ded-926b-6b7f6d2249a5"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("15883dbe-e97e-4859-86f7-993bbc1173df"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("17544f0d-9e01-4955-b49a-dcc4b6a770ee"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("17652753-332f-4654-89d0-bbca6d67670f"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("1c79d0c4-56b9-4b08-af15-2fddc2c1068e"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("1cab312c-e326-4c44-ae00-5542888dfbc9"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("1d71e542-620f-4161-9842-a2a145bd7013"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("1e3c140e-4cab-4065-aadd-2c1cfed5ce14"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("21d87d9e-43c6-46d1-bfee-644940fd9d64"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("22ebc934-105f-4b38-ab74-feae23d1ffc0"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("232fdc99-53fe-4232-9c74-06ddfb2a13b8"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("24256d4c-7032-4437-8c1e-dd211c5bd713"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("2463d0a4-5008-43f5-97fd-bbd3d0048d8e"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("2528ff79-cf89-4261-a0de-428d26b20a72"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("28d8da78-c6c4-4afe-9d92-22d52e3969b0"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("28eaff52-a12b-4084-83b9-02a26ca7dfbc"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("297e58cc-55d1-4c96-81c1-edd1b4b0ffb7"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("2db3541e-b13b-4e4b-b634-f31e8982b5e1"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("2f5efba5-6605-4ccc-9a86-918b9bd19b8b"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("33caf896-8425-48e6-86b5-a47f32bb1850"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("38ba8024-3b8d-4dd6-92b9-9d06da12ec6e"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("3cd8e5f4-df7e-4a22-84a3-04966bad5197"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("3da3214c-bd0e-4377-a9dd-da000298cefd"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("3fd74fb4-2450-440d-8497-d9a630f57199"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("427269be-9018-4cf4-9818-4fae14114ae4"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("44514479-669b-45b2-8af4-510b0786de9b"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("45859554-61d6-4f50-90eb-b40d19a17909"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("46685f7f-ca60-41b6-8cfb-4124c89cd625"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("4ebf8ce2-efc1-4c0d-8c61-7159ede74521"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("5611f5df-6d74-47b4-b24b-5863bd50f032"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("590c7122-bbd8-408c-9571-b8d385d97b9e"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("5bc8e452-e383-427e-bc9b-c26642f1a642"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("5e4be06c-1976-4755-aeb0-28dae4b4298b"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("5ee23c83-8a7a-498c-96a6-f2bc6fdc8136"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("5f3cfe10-1a7a-45c2-8fcb-c7e90692dbc4"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("6212ef8f-9777-42a2-ad28-a2ed1ebe90f8"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("63021a65-455d-454a-92ee-525601ead4df"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("648119d0-d486-40c5-bd23-69a5e42b2ba5"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("697709be-b252-4405-bb7e-8673c6b98467"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("6b4bca52-0cf9-4a9e-98cf-0eb6e3c24da0"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("6d1e80c0-f438-45cd-a63c-9bf2330160b6"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("6e20d02e-a4a6-4614-83ac-f23bb4548158"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("6f10d3da-6328-4453-bd18-d299e75dca49"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("6f2bc11e-7dd7-4049-9e35-163927214820"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("6fdebd38-1ce1-416f-af92-047978b186a5"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("7395222e-7744-4172-86d1-1b128230fabf"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("75fe592b-5c1e-4814-a459-627bef01098f"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("7b94208a-340f-4ed0-ad44-07a96fbc7d7a"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("841db90c-5f81-482a-a955-f91fc637a7f7"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("873734f8-2118-4bff-95ec-9e199770cefb"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("88603d45-af2e-4381-b8d8-2c53ebbaccd2"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("886111c9-af92-447f-91bf-dad7b8a03eb5"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("88888a0c-f1ed-4613-9646-ee6509dc5db0"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("893b3fb0-9647-4958-b835-676e382779e7"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("8bc08888-8550-4e72-9b5e-71845b5b9567"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("90ece793-c6f5-47e7-8aa0-7c08ff3548fb"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("90fb9bfe-da70-4392-9904-4417fab257a7"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("920b6ceb-11fd-4534-8c78-0adccdc2cbf5"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("93fb1f32-f25c-41b4-91a2-c22a92a4ab83"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("952cbe13-c448-4063-910c-4a6b51e895ce"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("9865321a-433a-4caa-8050-884b34c7c8d8"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("99eb34d9-432d-450c-9c9f-1f90d43caf39"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("9e65dc79-3d73-4629-8551-a5f2b9cfe2a4"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("9f2dcec6-cc02-45d6-95d0-fa0b53a5f953"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("a2e054b5-4260-4454-a995-281c00600f11"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("a38bfc8c-feac-4053-b76e-84c4e66d74d6"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("a51f9433-2477-4445-8a69-d24c50d95afb"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("a89b1694-3065-45be-9b67-fb5d87dc35f5"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("a99891d8-254d-4ec7-8cae-cf3bcb8c10a1"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("b0074e79-8782-48c2-b497-9ae7bd24e960"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("b22bc921-a93c-4461-8bd3-df4b1e010bc1"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("b41438f5-9380-4cd7-bc4d-59267b9b760c"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("b4a06e76-1c1e-4cac-aaa1-572d7a607954"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("b78d1e60-56cf-4058-967c-7271f646af05"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("c06db99e-509c-4391-b257-6799307a8b3c"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("c0ebc03b-08bf-4b16-89e2-4c86dec71a59"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("c93b2790-efbb-4887-bc62-908698026478"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("cba2380d-ac66-4bca-9da1-3db07a53966f"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("cce9a706-5e55-4052-a88e-26f4b6765bc9"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("ceeb839d-d443-4791-8018-561c89d6e7d9"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("d15c8331-36ed-417a-b1fa-5f377c4c9930"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("d43ed679-0d22-40c7-a14a-6d01fe86c193"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("d5d71173-e817-45f8-9146-4b7ab7c7b686"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("d6d20276-ac8b-44d6-9939-d642e6335c51"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("d84600ec-9767-4cd9-8221-62d22397acaa"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("e56e8c86-41ee-47fd-9d05-a94a167bed10"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("e9d684aa-183f-423f-8741-1a53cfb8f2e3"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("eb503b18-f1e1-4a47-8871-99a4746eb8c6"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("ec92935c-29c1-47d3-9ff2-3aed6a0974f2"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("f0f1e5c8-88d3-4268-9c48-f6a85560db57"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("f4a61b17-322c-4071-bb9d-c0378e5c9669"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("f9a1bd2e-de1a-42b8-b894-7f7e0b5b38f1"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("fa016e07-09ad-491e-a261-85cdebb45436"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("fafc2111-6b48-4585-8074-65bb860d42ae"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("fd9917bd-45e9-4bab-839f-7f5b5cbf03e7"));

            migrationBuilder.RenameTable(
                name: "KhachHangs",
                newName: "KhachHang");

            migrationBuilder.RenameTable(
                name: "DonHangs",
                newName: "DonHang");

            migrationBuilder.RenameTable(
                name: "DanhMucs",
                newName: "DanhMuc");

            migrationBuilder.RenameIndex(
                name: "IX_DonHangs_KhachHangId",
                table: "DonHang",
                newName: "IX_DonHang_KhachHangId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KhachHang",
                table: "KhachHang",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DonHang",
                table: "DonHang",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DanhMuc",
                table: "DanhMuc",
                column: "Id");

            migrationBuilder.InsertData(
                table: "SanPhams",
                columns: new[] { "Id", "GiaBan", "MoTa", "SoLuongTon", "TenSanPham" },
                values: new object[,]
                {
                    { new Guid("012b5786-7fb0-4009-b256-ad19944a12ae"), 0m, "ざぜん 窒息 十台 逆 はなじ 大丈夫 たいりく 誘惑 浅い 学院 色々 ぼくし ひきざん 難しい むく そあく 送る 雑音 ほうしゅう じょうき りょうど 日没 閉める かいぞく 誤用 廉価 殻 すいせん 先週 たいりく とりあえず 始まる 馬 むらさきいろ 黙る 窒息 ぶん 店 見当たる 報じる 号 いつ頃 量 れつあく せんりゅう じじょでん いう 馬 狂う 魔法.", 0, "Small Concrete Pants" },
                    { new Guid("01331617-e6e4-4e34-9222-6966c0bd1c05"), 0m, "きょうしつ 伝統 全日本 碁 廃墟 しきもう 春休み かわかす フランス人 右利き けしき つぎつぎ いつ頃 奴ら どうけつ みなもと 気持ちいい うえる ししょく 電源 しずむ きげんご けしき 堀川 九日 いう こくふくする かんじる ぶそう きょだい やさしい 下さい 伐採 一文字 はっぽう すいせん こはん 揺さぶる フランス語 馬鹿馬鹿しい シアトルし かいぞく はなぢ かぶしきしじょう ぞくご じじょでん 量 交錯 ちかく ゆるむ.", 0, "Handmade Soft Fish" },
                    { new Guid("0564c8f6-530d-4e5f-a9be-f59d6a833daf"), 0m, "運ぶ けいじばん 窒息 縛る 金 無駄 江戸 人性 品詞 とめる 不思議 味噌 境 あらそう たつ ふそく いちだい ちきゅう 牛乳 ほ 下着 殻 洋服 黒板 あびる きょうどう どうけつ ほ 問題 あう めいしょ 脱税 半額 人口 〜亭 この頃 かんりょうてき かんしん ひがい 血液 靖国神社 飽くまでも 無糖 ようい 始まる 奇襲 塾生 せっぷく 左手 間隔.", 0, "Awesome Soft Ball" },
                    { new Guid("0a1d68ee-a835-48c9-bb41-5ab40db852ea"), 0m, "終点 はりい しあとるし 遺失 むこう 下着 既に しえんする 靖国神社 むらさきいろ みなもと 廃墟 とうき 浅い たまご しゃっか 境 じぎする 体重 りゅうこうご 復旧 手作り とりあえず だいどころ しえんする 遺失 じっかん 全日本 いう 面積 どろ 果樹 馬 ふそく 血液 おんとう よわよわしい げいひんかん 果てる 地面 はちのす ひきさく 遮断 たいこうする 勇気 救急車 約する せいしん かちゅう ひかくする.", 0, "Gorgeous Wooden Fish" },
                    { new Guid("0c1e4f9b-fafe-49a2-99e2-5b0377054301"), 0m, "しゅしょう かんそく 廃墟 壊す ちかく さきまわり ちかく 店舗 誓い 靖国神社 しょくん 検査 ようい まつ 床 書き方 〜系 近視 減俸 全日本 ほうしゅう 超〜 ぞくご 電源 あらす 不健康 江戸 れつあく じじょでん はなはだ あしくび 閉じる 以下 丼 はんだんする やさい そあく 徳川 こはん しょうりゃく しえんする 擬装 かくじっけん 同僚 しゃこ みなと 魔術 あらあらしい 魔術 急騰.", 0, "Fantastic Frozen Ball" },
                    { new Guid("0e220c8a-d980-4d28-b199-15da6a652797"), 0m, "ひきさく くつじょく せいじょう 金星 復旧 ぼうず 量 先週 伝統 そだてる なんべい 奇襲 騎兵 たれる よぼう 遮断 雑音 きひん 旧姓 じっかん しずむ やさしい せんりゅう 誤用 ひきざん とりあえず 委員 あびる どろ 十台 評価 壊す きょうき 左手 哀れむ にんい 歯を磨く 間隔 きょだい 巡回 江戸 旧姓 きゅうりょう 人性 九日 勇気 休日 汚す かん こはん.", 0, "Awesome Soft Soap" },
                    { new Guid("12661273-4cae-4306-86fc-a4080327ca9e"), 0m, "しょうゆ 割り箸 薬 仕事 報じる 報じる 陳列室 先ず 味噌 送る すいせん 底 殺人者 きょうふ 活用 右翼 きひん むぜい かんじる めいし 弱虫 人性 液体 しょうりゃく うんがいい しょくん みなと しあとるし 歯を磨く はなじ いたずら かいぞく 大尉 窓 あびる 〜系 杏 ふくへい こはん 部首 金縛り 米兵 急騰 みなと 渦巻き この頃 やさい 差し上げる 学者 かいたく.", 0, "Ergonomic Granite Chips" },
                    { new Guid("144fcc77-1401-4349-abfd-5f4c68a85f2b"), 0m, "おりめ 以下 春休み じょうき がんばる しょうりゃく 貫く 大尉 げんめつ 絹糸 弱虫 おりめ じょうだん 高値 殺人者 伐採 近視 じきしょうそう はりい 手作り 以下 避ける むぼう さきまわり 縛る しきもう ぶん めいがら ひかくする 太る 廃墟 ひかくする かつ けいじばん たいりく みつ つうやく けいかん うえる 宜しく ふかさ むこう じゅうらい 安泰 ねばり しばふ 頂く たいりく 洋服 失う.", 0, "Unbranded Plastic Pizza" },
                    { new Guid("19efdf76-6f4e-4db4-8606-7c2ab982ac9b"), 0m, "にんい 洋服 ぐん ざぜん 評価 がいよう 馬 せっぷく がいよう ねんじゅう こうちょく 果てる 日欧 きゅうりょう 狂う とうき いく 遺失 復旧 かんぜん 不思議 全日本 さいほう 評価 つなひき 黒板 はちまき ぶそう こくみん じじょでん 日没 老齢 撃つ 閉じる 弱虫 きょうふ こうちょく 同僚 間隔 かい しょうがっこう ぼうず 抑制 減俸 ざんぴん 雑音 かんりょうてき 電話 貫く ことばつき.", 0, "Fantastic Cotton Cheese" },
                    { new Guid("1c492bad-6856-4d18-b5eb-0bc3fa2f4f0a"), 0m, "急騰 ちょさくけん 浸す 果樹 そんざい 合う 下着 迷路 味噌 江戸 かぜ 配慮 かん 誓い くつじょく ころす 零す 継承 はちまき じょうだん こくみん さきまわり いう 江戸 無駄 めいし はちまき 傑作 高値 浅い 量 おりめ うえる 間隔 交錯 軒 ちあん 縛る 新婚旅行 切迫 はなじ 奇襲 秘める むこう よくげつ 羊毛 とめる じぎする しあとるし たつ.", 0, "Ergonomic Plastic Towels" },
                    { new Guid("20828531-8f4a-46cc-a2c5-1a8d4b2a3bd8"), 0m, "仕方がない しょうじょう 不可欠 下着 掛ける ごじゅう じゅうらい きょうかい かくじっけん ぼきん 評価 〜亭 かたみち 渦巻き いじん 抑制 ぶき りょうど 面 機嫌 えきびょう おととい 封筒 なんべい 芸者 礎 太る 約する しずむ ふそく うんがいい ひがい ふくへい 誘惑 迷子 切迫 委員 減俸 あれる 勇気 誓い たらす たまご ちえん 出版 牛乳 かんそく 弱虫 かいじゅう 漂う.", 0, "Refined Metal Gloves" },
                    { new Guid("2435dbd9-bf3c-48dd-836c-a2890efe374f"), 0m, "こうせい 壊す 全日本 ねんじゅう 九日 俵 救急車 さくにゅう ほんらい ほ まほうつかい ハチのす 禍根 失う 高値 しょうじょう ふかさ しあとるし ごうけん 零す 馬 あらす 色盲 合う 合う いじん とちょう 揺さぶる 浮世絵 秘める めいしょ 仕事 無糖 提案する 下さい 宜しく 投資 終点 大尉 始まる 靖国神社 避ける そあく 芸者 黙る 果樹 げんめつ とくに 始まる かんぜん.", 0, "Refined Metal Fish" },
                    { new Guid("2460a04f-83b3-4652-8a52-67960ed6e009"), 0m, "不可欠 希望する おきゃくさん くつじょく もはん けしき 同僚 全日本 しゃこ さいほう あびる かいじゅう 十台 ねんじゅう まもる 原油 汚す 逆 済ます きもち たつ 犠牲 かっこう しずむ じきしょうそう 仕方がない けいけんしゃ 底 下着 恨み 壊す 奉仕 備える 誓い 掛ける 継承 いたずら 出かける かん 無駄 体重 靖国神社 ふん 桜色 こうぞく みさき ねんじゅう ひきざん 金 胃.", 0, "Tasty Metal Mouse" },
                    { new Guid("25b067ba-6cfe-4a05-9234-ccb5d7aa5180"), 0m, "先ず 禍根 ちえん じきしょうそう 金星 ごふく 気持ちいい 賢明 塾生 送る おどろく ねんじゅう 逆 休日 寮生 ふかさ そあく まつり 伐採 芸者 ぼきん 碁 徳川 哀れむ 仕事 防犯 はなじ いく しょうゆ けいかん ちきゅう 見当たる しゃこ せんじょうざい そだてる おんとう はだか まぎらす けいかん 部首 指紋 泳ぐ 一文字 おかね 終点 ちきゅう 退く 軒 かたみち 礎.", 0, "Ergonomic Soft Salad" },
                    { new Guid("295f2c69-b92f-40c7-985e-22d07f0da374"), 0m, "秘める シアトルし 総括 杏 ごうけん かつ とりあえず 貫く 原油 はっぽう どうけつ 米兵 縛る 米国 施行 運ぶ かたみち フランス人 俵 ころす しょうりゃく ころす ちあん ふさい 妥協する 安泰 軒 そだてる 金星 杏 牛乳 誘惑 色盲 十台 こうせい こいぬ のき しょうゆ 核実験 話 たいりく 凝固 閉める 閉じる たくす うえる つく つなひき 終点 にんい.", 0, "Handcrafted Plastic Gloves" },
                    { new Guid("29cb9ac0-c4d0-4fd8-801e-eec474f0fa19"), 0m, "よわよわしい 気持ちいい 十台 けいむしょ 原油 陳列室 味噌 誓い 品詞 擬装 ちらかす けいじばん はちまき 俵 まつり 誓い 病床 じょうじゅん かいぞく ぶん ぶき 提案する じゅうらい ないしょばなし 〜亭 鈍器 こくみん 誓い つうやく つばさ 零す しょうがっこう ちきゅう じっかん 壊す 殻 きひん れつあく 靖国神社 誘惑 掛ける すいせん かいぞく 傑作 〜亭 礎 こはん 飽くまでも 都合 抑制.", 0, "Sleek Plastic Keyboard" },
                    { new Guid("2b867c98-c6ec-4c9a-99bf-a81c816e8ca5"), 0m, "こはん 仕方がない はじめて 切迫 馬鹿馬鹿しい じきしょうそう 汚す 憂い この頃 靖国神社 液体 継承 やさい 軒 こうおつ こわす 大尉 右利き 双 仕事 無駄 弥生 めいし けしき 喜劇 救急車 面 憂い 核実験 寮生 徳川 ずいぶん しょうりゃく みなもと そあく ぶん 休日 いっさくじつ かん 超〜 悲しみ 魔術 れつあく 芸者 双 じぞう 大仏 たらす 委員 伝統.", 0, "Fantastic Concrete Cheese" },
                    { new Guid("2c0f2ffc-b8e9-4d7a-8337-6b404c78ccfe"), 0m, "寮生 せいかん けいむしょ なおさら 無糖 ぶそう むぜい 色盲 おきゃくさん げんめつ ハチのす 黒板 もはん たまご さくにゅう 始まる 学院 弥生 りゃくず 済ます いじん 近視 ざんぴん 希望する がんばる 喜劇 誓い 半額 漂う しょうゆ 恨み 下着 あらそう 戦没 杏 逆 えきびょう ひかくする こわす 封筒 ちょさくけん れつあく ごふく ひがい 提案する 学者 たれる 金縛り 始まる 推奨.", 0, "Gorgeous Wooden Gloves" },
                    { new Guid("2cf2bdd8-b35f-4dc0-8d68-a8a552ce0304"), 0m, "割り箸 大尉 春休み あおい ごじゅう ことばつき あつかい 牛乳 ころす 九日 屈む あう りゃくず 下着 面 揺さぶる 殻 施行 ちゅうもんする 狂う しゅしょう そんざい ようい むぼう 十台 しょうりゃく 丼 ひかくする 堀川 ほにゅうびん とりあえず 以下 しえんする 徳川 天井 しばふ 終点 旧姓 塾生 擬装 屈む じっかん 天井 かたみち しきもう しょうじょう むぼう かっこう 貫く きいろ.", 0, "Generic Soft Chicken" },
                    { new Guid("2d51acbe-7b4f-40fb-8c77-f0342a6564f9"), 0m, "かいたく 凝固 隆起 〜亭 ほ ほうせき 防犯 恨み 超音波 遮断 丼 総括 かくじっけん りゃくず 備える 総括 ざぜん 評価 不健康 日欧 じょうだん たいさ フランス語 塾生 日没 手作り ほうげん ちかく たつ がんばる かんじる 恨み あらあらしい あう 宜しく 合う ほ 暴力 かんそく けいじばん まつり げんめつ とうさん くつじょく むこう むぜい いつ頃 かいぞく 送る せっぷく.", 0, "Refined Concrete Shoes" },
                    { new Guid("2ea8a5d8-27df-4db7-b5e9-83cb15c1661c"), 0m, "ちがい とりあえず かおつき にんい みなと こはん かぶしきしじょう 〜系 あっとうする かんどうする じじょでん 揺さぶる けいじばん 切迫 いたずら 書き方 飽くまでも 秘める 泳ぐ とめる ひかくする 窓 誓い かいぞく 無糖 けいじばん 検査 とりあえず やさい 検査 ぼきん ふん ちあん 九日 核実験 かっこう あう ぶっきょう 出版 うえる 投資 休日 ねんじゅう 〜系 明治 だくりゅう 堀川 同僚 液体 大仏.", 0, "Generic Soft Keyboard" },
                    { new Guid("2f95194b-2071-4621-b28c-5c8d9d49bf57"), 0m, "かんしん あおい めいがら きもち 脱税 しょうがっこう 歯を磨く ざぜん 普及 とうき 救急車 勇気 いっさくじつ めいし しえんする 天井 人性 色々 にんい 譜面 店 下着 奴ら 賢明 いじん 電話 きんく あらす 床 りょうど ちらかす 不健康 憂い ふそく しょうゆ 魔術 かんそく 大丈夫 りゃくず むこう 自立 始まる かくじっけん 都合 先ず 零す かおつき りょうど 機嫌 狂う.", 0, "Tasty Rubber Chips" },
                    { new Guid("3047918d-f5e4-4cef-bc43-02382e061971"), 0m, "とふ 白菊 いく かおつき 運ぶ 見当たる たいこうする 気持ちいい だいどころ 委員 既に さくにゅう 鍋 はっぽう にんい 出かける たて 双 まほうつかい こくふくする 検査 うえる かぶしきしじょう 誘惑 しえんする 傑作 うえる すいせん ぐん 太る 継承 体重 抑制 斬殺 日欧 しばふ 仕方がない こうぞく ざんぴん 味噌 ひがい じょうじゅん 書き方 おりめ 自宅 せんじょうざい 差し上げる 防犯 けしき せんりゅう.", 0, "Rustic Wooden Chicken" },
                    { new Guid("31c9d4b7-7b7c-4104-8f3c-8835c7bf1e46"), 0m, "宜しく つうやく きゅうりょう 斬殺 ごじゅう 洋服 ぶそう いっさくじつ かわかす 自立 たいやく きもち 間隔 普及 はりい さいぼう きょうはんしゃ 防犯 いちだい あれる 部首 とちょう おんとう 仕方がない 飽くまでも ちがい ひがい 日没 さいぼう 哀れむ ちがい ふそく かたみち すいせん えきびょう 割り箸 ねばり 擬装 ごじゅう この頃 しゃこ おりめ 飽くまでも いたずら 喜劇 こうせい 乗せる 面積 体重 きひん.", 0, "Handmade Frozen Chicken" },
                    { new Guid("3210566f-e7ea-4ca3-9bc9-bd6d4aa9b7a6"), 0m, "かいたく はだか 号 九日 たいりく 体重 りゃくず こはん すんか しょうがっこう ごうけん めいしょ むく 入江 ようい 味噌 血液 迷路 犠牲 しきもう 戦没 仕事 原油 もはん 急騰 秘める 交錯 狂う やさい きょうかい きょうふ 合う あくれい 人性 桜色 狂う りゅうこうご 縛る 自宅 はだか しえんする きいろ しょうじょう 退く 遮断 恨み 境 ほうげん よくげつ 金.", 0, "Handcrafted Soft Fish" },
                    { new Guid("32aa78bd-0099-41a5-ae21-73e080e873ab"), 0m, "こいぬ じぞう あう つまる 誓い 雑音 ひきさく けいむしょ 消す 胃 店 十台 つまる 避ける かんどうする ちきゅう お盆 合う たれる かいたく あらす 病床 評価 あらす 零す こわす はだか せっぷく なおさら 禍根 そだてる 仕方がない 日欧 ぼうず あれる 半額 しょうじょう しょうかする しゅしょう にる しゅしょう 上手 つまる こはん 桜色 継承 かわかす よくげつ りゅうこうご つく.", 0, "Sleek Rubber Shoes" },
                    { new Guid("32fb4a9c-a549-4914-83f0-8cd3f96fd517"), 0m, "つうやく 安泰 遮断 浮世絵 評価 けいむしょ 避ける 機嫌 学者 ころす ぞくご きょうどう へいがい 床 はじめて 電話 杏 貫く ひんかく 乗せる じぶん 旧姓 しょうじょう 禍根 雇用 形 もうす 殺人者 ぶそう はなぢ 間隔 復旧 かいたく 済ます 無糖 せんじょうざい 春休み 左手 塾生 壮年 いじん たつ 検査 活用 施行 察知 馬 ほうせき たいこうする 薬.", 0, "Small Soft Table" },
                    { new Guid("3ea9290c-142a-4e13-b9bf-a13e4e2935ac"), 0m, "むく ずいぶん ないしょばなし しゃくや おんとう かいたく きげんご 助手 金星 白菊 終点 かいぞく 助手 しずむ シアトルし 床 だいどころ 軒 急騰 漂う しょうじょう 徳川 先ず ひきざん 防犯 没落 うえる ちあん めいしょ 下さい 普及 学院 かんじる いう 超〜 ふん 仕方がない 凝固 すんか 評価 しゃくや 悲しみ かいぞく 凝固 重い じょうき 人性 手作り うえる やさしい.", 0, "Handcrafted Rubber Hat" },
                    { new Guid("426a5d46-102c-44aa-96c7-9fa40705919e"), 0m, "ちえん 品詞 脱税 きょうしつ けいじばん いっさくじつ ぶき ふさい 壊す はっぽう 馬 かんじる 超音波 半額 奉仕 魔術 つうやく 出版 かい ぶっきょう 憂い かぜ ぞくご 平安 封筒 しゃっか 店舗 魅力 誘惑 警官 推奨 むく あびる たて かんしん 手作り 消す 丼 床 不可欠 薬 せんりゅう くつじょく 馬 掛ける 靖国神社 たくす 開閉 りょうど おかね.", 0, "Incredible Fresh Salad" },
                    { new Guid("43cc6937-39b5-4c4c-ae0a-8acaf3b4d1db"), 0m, "ぶん 品詞 自宅 老齢 禍根 親切 終点 ぶん せっぷく 仕方がない 大仏 たて こくふくする がいよう 狂う 陳列室 どうけつ めいし ほにゅうびん 救急車 鍋 明治 シアトルし いちだい 汚す 先週 無糖 独裁 ちきゅう 不可欠 大尉 防犯 かんそく さいぼう じっかん とうき 縛る はんそう じぎする こうぞく ぼくし 伝統 つうやく ふさい 投資 おきゃくさん せんたくする 黙る しえんする はなはだ.", 0, "Licensed Metal Pizza" },
                    { new Guid("449513e1-c8a7-479a-99ba-014b6e2c1007"), 0m, "長唄 おととい ふくへい きょだい きょうしつ さいぼう 隆起 ほうげん ごふく はなはだ 割り箸 輸出 めいしょ 絹糸 かわかす 脱税 ひんきゃく かっこう 防犯 むぼう みなと こうせい しえんする 形 巡回 病床 たいやく ぶそう 備える はりい 店 殻 活用 ねばり こうちょく きょだい 病床 悲しみ 俵 むく 魔法 頂く かおつき 泳ぐ 騎兵 間隔 きんく せいぞう 察知 不思議.", 0, "Gorgeous Frozen Chips" },
                    { new Guid("4503b4ad-0c3d-44f6-8c94-20112538b85d"), 0m, "みさき 地面 総括 じぎする うえる こわす 閉じる がいよう 提案する 斬殺 ほうげん かくじっけん じぶん 泳ぐ まもる そんざい おかね 無駄 面 大尉 こいぬ しえんする まほうつかい 先ず 先ず むく ことばつき しょうゆ 窓 おかね 入江 ひきざん たらす 出かける 活用 迷路 済ます 交錯 薬 ないしょばなし 号 狂う じょうじゅん ちきゅう 超〜 宜しく かんりょうてき ひかくする 話 たまご.", 0, "Rustic Cotton Gloves" },
                    { new Guid("45745fd8-b10d-4f6f-b44d-665df44721f6"), 0m, "自立 ぼくし 下さい 陳列室 ぼうず あつかい 歯を磨く せいしん しゅしょう フランス語 もはん せいじょう 妥協する じっかん シアトルし あつい あらあらしい たまご 大丈夫 がいよう 殻 のき 羊毛 ちかく 軒 活用 好き 警官 せんじょうざい たらす かんどうする 徳川 果樹 せんりゅう せいぞう きひん なんべい むらさきいろ 継承 はなはだ 雑音 めいしょ かちゅう つばさ 運ぶ 暇 たいやく きいろ ふん おんとう.", 0, "Rustic Granite Bacon" },
                    { new Guid("46368202-3e68-4846-8ef3-be3cca89883b"), 0m, "せいじょう ごじゅう 超音波 ちらかす 送る ごうけん 出かける まぎらす 奴ら 合う 羊毛 かつ きょうはんしゃ 果樹 ころす おかね 輸出 左手 こうせい 店 こうちょく かたみち はなぢ かくじっけん 電源 提案する しょうりゃく 掛ける はんそう 防犯 話 はなはだ のき 地面 じきしょうそう とちょう きょうしつ あびる すいせん むぜい もうす 人性 ちきゅう 親切 せいじょう 自立 さいぼう やさしい 学者 境.", 0, "Unbranded Concrete Salad" },
                    { new Guid("47995fea-c252-4932-840d-a6ec53609934"), 0m, "ゆるむ とうさん ねんじゅう 悲しみ しゅしょう めいがら 堀川 〜亭 遺失 きいろ 独裁 かっこう きょうかい ほうげん 窓 陳列室 閉める 悲しみ はんだんする いう 遺失 かくじっけん 原油 浸す 評価 せんりゅう 薬 かっこう 遺失 ずいぶん 金縛り 店 たいやく 話 安泰 十台 こくふくする ぼくし おんとう とくに 評価 警官 かい 暴力 丼 じぎする いつ頃 浅い 米兵 しあとるし.", 0, "Sleek Metal Mouse" },
                    { new Guid("4add607e-e33f-41ce-a7dd-bf1fb05ae852"), 0m, "不可欠 けいむしょ 交錯 ちかく 妥協する せっぷく 哀れむ 飽くまでも はなじ きょうはんしゃ 悲しみ 電話 しばふ 米兵 みさき きいろ 迷子 備える 傑作 誘惑 日没 没落 お盆 ちゅうもんする 仕方がない 体重 金縛り 俵 切迫 ごふく あれる かつ ぶん 貫く 全日本 縛る 堀川 量 ふかさ せいかん まつり シアトルし 間隔 まほうつかい 施行 ひがい ほにゅうびん つばさ いっさくじつ ぼうず.", 0, "Rustic Soft Bike" },
                    { new Guid("4ea9c069-ac5b-4286-9be7-7d6ddc7dde89"), 0m, "うえる どろ じぞう 号 しょうゆ しばふ 天井 間隔 馬 むく 超音波 出版 すんか 待合 切迫 復旧 やさしい 唄う おきゃくさん 入江 ぼきん 防犯 誓い がんばる 投資 山葵 こくみん 賢明 下さい 学院 右利き 疾走 窒息 碁 うえる 急騰 当て字 日没 せいぞう 量 しあとるし とうき 学院 体重 地面 普及 じぎする 入江 大仏 げいひんかん.", 0, "Ergonomic Granite Bacon" },
                    { new Guid("5523a41f-5cc4-4008-8258-d16f38cc2d23"), 0m, "母 施行 しえんする こうせい へいがい あらす まつり あっとうする 母 壊す りゅうこうご どうけつ 旧姓 評価 きひん 急騰 電話 むぼう げんめつ いっさくじつ 斬殺 済ます そんざい とりあえず のき 芸者 しょうゆ 検査 魔法 くつじょく 十台 閉める 先週 げいひんかん 旧姓 伝統 伐採 悲しみ とちょう よくげつ みつ じじょでん にる じぶん 泳ぐ ちえん 不可欠 しえんする はなぢ 迷路.", 0, "Gorgeous Steel Table" },
                    { new Guid("5b6ccb53-c581-4a0a-a707-3da54af99e33"), 0m, "陳列室 味噌 ぼきん うんがいい かん 鍋 とうさん ひんきゃく 底 あつかい 華やか じぎする 長唄 めいし 活用 大尉 あしくび おととい じぎする 母 まぎらす ちきゅう にんい あらそう もはん 浸す かんどうする しょうじょう たつ 悲しみ ぶっきょう 陳列室 しゃこ 検査 掛ける ちかく 察知 ひかくする 色々 かぜ もはん はっぽう 同僚 ちあん 迷路 桜色 じっかん 窒息 浮世絵 まもる.", 0, "Rustic Fresh Shoes" },
                    { new Guid("5eda2955-a8e0-42a3-84f0-1ba4f9276f12"), 0m, "機嫌 巡回 れつあく 手作り ふそく しょうがっこう 渦巻き じっかん 掛ける こわす 逆 あれる 開閉 助手 ぶき しょくん 仕事 狂う じきしょうそう やさしい ちきゅう 九日 ほんらい 十台 ざんぴん あくれい 殻 きょだい 終点 かわかす 大仏 電話 人口 めいし 輸出 色々 じぞう りょうど 母 母 当て字 けいじばん 検査 奴ら かつ 〜亭 ちゅうもんする 薬 たくす たまご.", 0, "Incredible Concrete Table" },
                    { new Guid("657f23ed-6673-4277-9b09-9fbb7183666f"), 0m, "あらあらしい しえんする 壊す ぼくし 一文字 見当たる 形 みなと みなもと もうす ほんらい じょうだん じじょでん せいしん ひきさく 禍根 はちまき のき 零す かいたく 自立 賢明 疾走 たつ どろ 電話 きょうしつ にんい みつ ぐん たいさ 軒 誘惑 窓 旧姓 喜劇 手作り 零す こうつう れつあく 電話 ちょさくけん ハチのす 牛乳 うんがいい 靖国神社 まもる 大丈夫 渦巻き しょうかする.", 0, "Unbranded Plastic Cheese" },
                    { new Guid("667fdd58-a921-45a9-95cc-59712aef753d"), 0m, "こうつう 間隔 あびる 消す ひきさく 天井 備える きょだい ふさい おきゃくさん 閉める 検査 しょくん とふ むらさきいろ 浮世絵 つなひき おととい 胃 送る きょだい 犠牲 かいたく おかね 果てる 恨み 終点 かちゅう りゅうこうご 休日 廃墟 しょうじょう つばさ かんぜん もうす 安泰 ごじゅう ぶっきょう ふさい この頃 かんじる くつじょく 飽くまでも ぶっきょう 渦巻き とちょう じゅうどう 黙る おどろく せいしん.", 0, "Handcrafted Cotton Car" }
                });

            migrationBuilder.InsertData(
                table: "SanPhams",
                columns: new[] { "Id", "GiaBan", "MoTa", "SoLuongTon", "TenSanPham" },
                values: new object[,]
                {
                    { new Guid("66ef17d3-a2a0-49dd-8fa3-cb22cef29ca8"), 0m, "おととい かんそく ひがい ひきざん よわよわしい かいじゅう 不健康 長唄 病床 かんそく 浸す めいしょ 金縛り きょうどう 牛乳 右利き まほうつかい 疾走 しょうりゃく 金星 しあとるし たいりく 母 おととい はりい とりあえず 新婚旅行 じょうだん かわかす 明治 じじょでん 伝統 ちらかす 失う いたずら 待合 悲しみ 悲しみ 約する 馬鹿馬鹿しい はなぢ 礎 あっとうする 急騰 しょうじょう 自宅 〜亭 恨み ぼきん じきしょうそう.", 0, "Intelligent Plastic Ball" },
                    { new Guid("6cc4bd10-6789-4134-ae85-36657a7a7a8e"), 0m, "ハチのす 暴力 へいがい 新婚旅行 ハチのす 量 きもち 暇 騎兵 量 しょうりゃく 交錯 秘める ようい 血液 じょうじゅん おかね ちゅうもんする ちゅうもんする せいかん あっとうする 機嫌 きいろ がんばる そあく かいぞく 恨み 味噌 母 洋服 靖国神社 おきゃくさん 開閉 助手 じっかん ぶそう はりい 出かける 迷子 同僚 寮生 かんじる かくじっけん とふ 奴ら 推奨 仕事 号 出版 誤用.", 0, "Gorgeous Wooden Ball" },
                    { new Guid("6d9a56f8-68d5-44eb-92b6-2ed35d8b54aa"), 0m, "金 ころす やさしい けいかん 輸出 きょうき 救急車 けしき 浮世絵 軒 みさき 送る ほんらい 伐採 しゃこ 双 境 以下 つぎつぎ 抑制 廉価 都合 とちょう 徳川 電源 屈む 擬装 あびる もはん 始まる きょうはんしゃ ねんじゅう 差し上げる おんとう 活用 評価 はだか ちきゅう 店舗 九日 先週 じょうじゅん 救急車 老齢 こくふくする 奴ら たいりく ずいぶん みなと そだてる.", 0, "Generic Concrete Chicken" },
                    { new Guid("6e8c0758-76f1-43a5-b165-8f07b07110d3"), 0m, "じぞう みつ 隆起 米国 魔術 施行 隆起 ひんきゃく 近視 ちらかす 休日 まぎらす たくす 評価 封筒 雑音 果樹 洋服 ちがい つまる いつ頃 都合 きゅうりょう ざぜん こわす よくげつ ひきざん 平安 機嫌 せんたくする 金縛り かちゅう ことばつき 抑制 ぐん 迷路 なおさら 九日 ころす 金星 ちょさくけん かつ 大尉 きょうはんしゃ はだか うえる ほにゅうびん あらす 果てる ことばつき.", 0, "Sleek Concrete Cheese" },
                    { new Guid("6f5878ee-7a3d-4265-bc24-d7b152c3fcf9"), 0m, "かおつき しゅしょう はんそう ほうしゅう へいがい 右利き 陳列室 かぶしきしじょう さきまわり 間隔 難しい 店舗 いじん 寮生 まほうつかい しょうりゃく 唄う さいぼう 店舗 伝統 どろ 仕事 ねんじゅう 品詞 店舗 ぶっきょう 傑作 鍋 さいばん 推奨 体重 ひきさく 境 きんく 希望する 切迫 こいぬ 不健康 出かける 交錯 果樹 はじめて 希望する 誘惑 そあく 休日 ほ 洋服 やさい たれる.", 0, "Intelligent Soft Shirt" },
                    { new Guid("7087b96d-3969-41fe-9f1c-9888d70bbef5"), 0m, "不可欠 ほ りょうど ぶん 底 果樹 魅力 馬 かんぜん たらす おきゃくさん 学院 たまご じぎする きょうどう かんしん がんばる たいさ 遮断 評価 斬殺 かおつき 戦没 フランス語 暇 めいがら けしき 推奨 秘める 禍根 まほうつかい 戦没 あしくび 無糖 太る きもち 無駄 下着 けいけんしゃ 賢明 こいぬ 米国 きょうき 好き 減俸 仕事 はなぢ きゅうりょう つなひき 右翼.", 0, "Intelligent Plastic Chicken" },
                    { new Guid("70f7984a-68aa-475d-9115-c876b3f38b6f"), 0m, "せいぞう 独裁 じぎする 壊す あつかい そだてる しゃっか 零す めいがら 地面 割り箸 はちのす 傑作 屈む 以下 じょうき 不可欠 きんく たいさ 零す 遮断 くつじょく 運ぶ 普及 こうせい 電源 あっとうする 号 ふん げんめつ 塾生 つぎつぎ 宜しく 推奨 地面 ちきゅう どろ 壊す いちだい かん しょうかする 右翼 ないしょばなし ふん たれる 〜系 あらす 見当たる つく 減俸.", 0, "Rustic Plastic Soap" },
                    { new Guid("74a6ca73-d184-453f-961b-a7b42223bb62"), 0m, "こはん ようい 華やか 廉価 きげんご いちだい 巡回 〜亭 誘惑 羊毛 しばふ 漂う おりめ おととい つく ひがい せっぷく 譜面 不思議 ちゅうもんする おりめ 出かける たまご はんそう 伐採 しょうかする 誤用 こいぬ ぶそう かんじる 約する 白菊 ごふく いく 雇用 ころす ざんぴん みさき そあく 殺人者 羊毛 長唄 みさき 形 先ず こうちょく 雇用 どろ たいりく おりめ.", 0, "Tasty Steel Bike" },
                    { new Guid("763eca15-659e-44ce-927b-6aadf31c2dd8"), 0m, "おどろく たいこうする 色盲 めいがら むく 勇気 ふくへい さくにゅう 救急車 活用 右利き お盆 閉める 不思議 不思議 全日本 やさしい つうやく ふん 消す はりい ずいぶん 白菊 あつい とりあえず ちらかす そんざい かぶしきしじょう 避ける にんい ぶき 安泰 みさき ちがい 喜劇 運ぶ 合う じぎする くつじょく ちきゅう 希望する 浮世絵 ぶき 復旧 おんとう 春休み たれる ざんぴん せっぷく そだてる.", 0, "Tasty Soft Chicken" },
                    { new Guid("77814752-d512-4aa7-a516-83cddc5c3b70"), 0m, "出版 きゅうりょう 学院 色盲 つなひき 投資 防犯 壊す 零す しあとるし 魅力 碁 不思議 こうせい かんそく 出版 送る 終点 なんべい 桜色 きょうどう めいがら 味噌 廃墟 先ず よわよわしい 窒息 壮年 かい 飽くまでも 同僚 ひんかく 助手 いじん 待合 こうおつ 特殊 仕方がない もはん しゃこ むらさきいろ 浅い 仕方がない ふかさ りょうど 魔術 ぶそう しょくん まつり せんじょうざい.", 0, "Intelligent Fresh Chicken" },
                    { new Guid("79ae7527-141c-4ae9-bba2-3ed255cf2e7b"), 0m, "遮断 あびる かつ とうさん はっぽう 普及 こうせい 窒息 以下 こくみん 暇 俵 寮生 独裁 けいけんしゃ ことばつき 提案する 配慮 こうぞく ごうけん 委員 じぞう 不思議 じぎする あう 伝統 差し上げる たれる 徳川 春休み ことばつき 山葵 とふ しえんする ちかく 歯を磨く 窓 失う かちゅう けいかん 雑音 せんりゅう たて さきまわり 芸者 難しい かんじる いう もはん 浅い.", 0, "Intelligent Fresh Bacon" },
                    { new Guid("7b06842f-cc3c-417f-b5b5-50916cf81689"), 0m, "おかね 屈む じぶん しゅしょう きょうしつ ちかく はなはだ ひきざん 漂う れつあく 不健康 哀れむ 送る さいぼう くつじょく 掛ける しょうじょう しょうゆ かん 原油 じじょでん 配慮 ちきゅう 左手 休日 学者 ころす いく たいさ 壊す あしくび ごうけん うえる 疾走 はっぽう 漂う 出版 やさい 電源 かいじゅう 評価 部首 暇 俵 終点 減俸 かん さくにゅう 約する つまる.", 0, "Handcrafted Granite Computer" },
                    { new Guid("7f814ea1-9aed-4d26-b55c-90666f82309d"), 0m, "疾走 渦巻き 縛る 俵 そんざい 華やか 手作り 大尉 上手 あっとうする 壊す 徳川 かぜ 無駄 没落 仕方がない こうせい 洋服 漂う 面 始まる うえる 退く 誓い しょうゆ きいろ 投資 みなもと じぶん 施行 果樹 靖国神社 きょうかい 独裁 徳川 窒息 きょうどう 禍根 しばふ 戦没 江戸 あっとうする 新婚旅行 ごふく じきしょうそう 漂う かんしん とりあえず 寮生 泳ぐ.", 0, "Generic Frozen Pants" },
                    { new Guid("8271b6ca-07ab-407c-bf25-a8f93665dc38"), 0m, "間隔 伝統 白菊 まぎらす 部首 鍋 遮断 雇用 隆起 金 こうつう ざぜん 割り箸 かんじる 堀川 いっさくじつ 暇 浸す 総括 無糖 防犯 丼 継承 のき 唄う ふかさ せっぷく 救急車 ようい 逆 けいむしょ この頃 店 ほうげん きょだい とくに 譜面 ひがい 浮世絵 おきゃくさん 雑音 譜面 ねばり ひかくする 左手 けしき 希望する 血液 俵 にる.", 0, "Licensed Frozen Bacon" },
                    { new Guid("857b46d9-8f74-4ea8-adc3-edda84ad03df"), 0m, "賢明 壊す 大丈夫 とうさん まつ かんりょうてき 出かける たいやく 窓 たいさ 終点 号 不可欠 人口 狂う 体重 救急車 こうつう 恨み 色盲 禍根 封筒 かいたく あっとうする 雑音 げんめつ この頃 こわす 窒息 送る ぶそう 凝固 伝統 かいたく 無糖 ほ 色々 封筒 つばさ しょうゆ 陳列室 学院 地面 活用 おきゃくさん やさしい 果てる つまる 誓い 逆.", 0, "Handcrafted Fresh Shoes" },
                    { new Guid("85b362fc-89fa-42f5-b11a-efb80f7d9daf"), 0m, "たれる なおさら かいじゅう かいじゅう やさしい 無駄 かおつき 人性 宜しく 洋服 学者 まつ あらす 体重 母 つまる やさしい 自立 減俸 明治 せいしん 手作り 施行 迷路 きょうしつ 華やか 超〜 希望する 塾生 手作り ようい 塾生 以下 縛る ひんきゃく しょうりゃく 遮断 黒板 下着 にんい 平安 輸出 おかね 大仏 面積 ざぜん 騎兵 差し上げる かくじっけん あらあらしい.", 0, "Licensed Concrete Tuna" },
                    { new Guid("884e9a8f-2bba-4897-8dc6-ca3d40163591"), 0m, "せいしん 妥協する 太る 漂う 上手 以下 ようい 伐採 すんか 母 渦巻き かいぞく フランス語 〜系 総括 まほうつかい 太る 徳川 ちきゅう 同僚 店 形 こくみん かんしん 不思議 ちきゅう こうちょく ぶそう 形 はちのす きょうかい 掛ける うえる ちかく まぎらす しょうじょう 半額 左手 たいさ 抑制 不健康 悲しみ あびる めいし 右利き 閉じる 俵 さくにゅう どうけつ かん.", 0, "Refined Wooden Chair" },
                    { new Guid("91f38fb1-89bd-475f-88ac-84ec805c6062"), 0m, "勇気 老齢 先ず りょうど かつ かんそく はだか 奴ら 底 ほんらい 碁 じょうき 出かける 学院 つばさ 馬 とめる じじょでん そあく 譜面 とめる ぼくし 桜色 きげんご 山葵 たいさ 不健康 あおい 母 九日 活用 しばふ 暇 えきびょう いちだい とめる しゃっか ひんかく 問題 戦没 不可欠 人性 暇 賢明 あおい かぜ 復旧 もはん 送る 誤用.", 0, "Awesome Plastic Tuna" },
                    { new Guid("962c406f-d36b-4209-931a-a49b584be5a1"), 0m, "縛る 切迫 たて 提案する ひきさく むく 左手 誤用 親切 江戸 かんじる おんとう あらあらしい 間隔 きひん 人口 馬 白菊 しきもう つぎつぎ 下さい 誤用 むぜい むぼう けいけんしゃ 不可欠 そあく こわす 活用 人口 避ける かぜ こくふくする 救急車 撃つ 避ける いう 長唄 底 せいじょう いたずら 窒息 面積 りゅうこうご さいばん 報じる 掛ける 品詞 かんそく きゅうりょう.", 0, "Gorgeous Cotton Cheese" },
                    { new Guid("99c78f04-9d0c-4131-a122-72616c20f90c"), 0m, "かぜ はっぽう たいこうする りゅうこうご 伐採 店 老齢 こうつう 委員 はなはだ しょうじょう 終点 上手 店 一文字 せいぞう 〜亭 きもち あしくび 送る 液体 きょうき ぼくし ころす つぎつぎ えきびょう むく 十台 封筒 あらあらしい 山葵 出版 はんそう 入江 そあく 寮生 白菊 はんそう 上手 味噌 かんじる 十台 けいじばん かたみち きょうかい かぜ そあく こうせい 汚す 普及.", 0, "Handmade Soft Soap" },
                    { new Guid("99f20d0d-a0df-46b5-925b-e0b98dd21026"), 0m, "鍋 復旧 はなはだ りゅうこうご ころす あらあらしい 軒 始まる 全日本 春休み 泳ぐ 米兵 歯を磨く 以下 書き方 しゃっか 魅力 廃墟 こうせい ちがい はちのす うえる 斬殺 よわよわしい たくす 地面 店舗 入江 既に げいひんかん きょうしつ あらあらしい 乗せる つばさ 大丈夫 あらあらしい 軒 金 閉める 果てる いく まつ せっぷく ほうしゅう とふ 誓い 米国 せんりゅう 暇 浮世絵.", 0, "Unbranded Frozen Mouse" },
                    { new Guid("9b0bcd82-a47b-4cb9-a18e-4f40af65fd61"), 0m, "金縛り 閉める 浸す 遺失 先週 継承 ひきざん 老齢 はちまき 減俸 品詞 推奨 徳川 はじめて めいがら じゅうどう 春休み 勇気 こはん むく きょうどう こうせい ししょく 乗せる あらす しゅしょう 店舗 以下 せいかん 独裁 あう ちきゅう 馬 春休み 超音波 しゃくや じじょでん りょうど たまご 浸す 無糖 つうやく ちがい みなと さいぼう 学者 むく 上手 助手 しょうじょう.", 0, "Gorgeous Fresh Bacon" },
                    { new Guid("9d90bcfc-6891-40f4-92cb-876074fe847a"), 0m, "憂い 黙る 杏 機嫌 ちかく しょくん 歯を磨く あくれい 日没 ねばり 人口 こうぞく かっこう 話 賢明 しょうゆ もうす ことばつき 避ける 普及 あれる 色盲 はんだんする かわかす 白菊 おどろく 上手 施行 電話 りゅうこうご 高値 じょうじゅん かぜ しょうりゃく 失う 凝固 復旧 かくじっけん しずむ 伝統 ねばり 疾走 芽 つく じぶん 察知 絹糸 乗せる こうぞく 委員.", 0, "Small Fresh Computer" },
                    { new Guid("a0ce9c34-e191-4f88-b282-b2bd7d9fb75e"), 0m, "入江 既に ずいぶん 重い 漂う 総括 無駄 けいかん じょうじゅん 希望する はっぽう やさい 喜劇 約する たて 問題 おりめ ぞくご 人口 手作り 殺人者 じょうき とりあえず さくにゅう 推奨 すんか 検査 杏 堀川 こわす じょうき 恨み げいひんかん ひんかく 老齢 いう ほうせき たいさ うんがいい かぜ しょくん はなじ 血液 もうす 伐採 しゃっか この頃 徳川 芸者 迷子.", 0, "Handcrafted Granite Cheese" },
                    { new Guid("a31d4559-9079-48b3-8173-520c8c8af1bd"), 0m, "じじょでん じぞう ちゅうもんする あらあらしい まほうつかい もはん 上手 せっぷく どうけつ きょうき みなもと 面積 伐採 配慮 屈む 傑作 ひんきゃく ふん 電源 けしき 戦没 超〜 しあとるし おととい 〜系 のき 復旧 戦没 特殊 継承 浸す まもる 頂く かいたく はなぢ かい ぼくし きげんご かんそく 魔法 斬殺 金星 つなひき 渦巻き 消す 形 えきびょう 品詞 新婚旅行 かいじゅう.", 0, "Practical Granite Car" },
                    { new Guid("a3dc3a4d-6edc-4a17-a9e9-6ec030a177c7"), 0m, "あくれい じじょでん こうぞく 約する じじょでん きんく 好き きょうき 傑作 そんざい 不可欠 電話 憂い 零す けいじばん 徳川 既に おどろく 難しい かぶしきしじょう いつ頃 長唄 超音波 大仏 同僚 さきまわり 軒 大尉 切迫 きょうはんしゃ しゃっか 芸者 れつあく 迷路 あらそう あしくび まつ 人口 春休み 号 とりあえず 奇襲 はなぢ 機嫌 めいがら 好き ごふく お盆 むぼう 閉じる.", 0, "Unbranded Cotton Chair" },
                    { new Guid("a6cb1577-9603-4491-937e-99869ed62e1b"), 0m, "よわよわしい 漂う 脱税 平安 上手 日没 十台 弥生 狂う かわかす 〜亭 奉仕 ねんじゅう 日欧 乗せる あつい とちょう いたずら 〜系 面積 しょうがっこう りゃくず こうせい 同僚 一文字 品詞 洋服 日没 恨み 抑制 ぶっきょう 長唄 投資 まつり つうやく 奴ら 明治 はちのす 陳列室 徳川 仕方がない 難しい こはん ほんらい 部首 とめる 遺失 店舗 安泰 こくふくする.", 0, "Generic Concrete Pants" },
                    { new Guid("a835d51a-b29f-45d6-a035-7d5171aad78c"), 0m, "羊毛 特殊 色盲 絹糸 秘める 擬装 けいむしょ ゆるむ あらあらしい 誓い ちがい 失う りゃくず 活用 迷路 よぼう せいしん 不可欠 施行 じょうじゅん とちょう 泳ぐ しあとるし かたみち 推奨 仕方がない 人性 きょうしつ 零す たいやく むく 約する かおつき 芸者 あつかい さいぼう 報じる 桜色 ふん 妥協する たいさ あしくび けいむしょ こうせい ぶん 暴力 ごふく ねばり はんだんする じょうき.", 0, "Handmade Frozen Ball" },
                    { new Guid("b5982e5d-48a4-4a08-9106-96a732d97eb2"), 0m, "ねんじゅう いちだい 電話 老齢 うえる ごじゅう 暇 液体 開閉 母 血液 堀川 せんじょうざい 病床 唄う ごじゅう 軒 この頃 勇気 逆 ようい しゃこ 警官 犠牲 じゅうどう あれる たいこうする しょうりゃく やさい ひきざん 底 なおさら とくに 合う あれる じきしょうそう 底 果てる 伝統 憂い 殻 救急車 じきしょうそう ほうせき きひん さいぼう いっさくじつ 掛ける しょうがっこう めいし.", 0, "Unbranded Plastic Chips" },
                    { new Guid("b59859df-0fe3-423b-ad64-2920f577fc02"), 0m, "掛ける 提案する 地面 上手 せんじょうざい 馬 みなと あおい 宜しく ほ 唄う じぞう ぶっきょう たいこうする ごうけん ひがい ふさい ざんぴん ちゅうもんする かたみち 提案する きげんご ふさい とめる 弱虫 むらさきいろ 重い 胃 乗せる めいがら 浮世絵 哀れむ 双 太る せんじょうざい ごふく ぼきん まつ 出かける 話 先ず ほ まほうつかい ししょく 手作り めいしょ はりい 機嫌 とうさん せっぷく.", 0, "Licensed Fresh Bacon" },
                    { new Guid("b83eddaa-f17d-4c62-b1a3-886385fa897d"), 0m, "はりい 面積 きょうかい はなはだ 入江 がいよう 安泰 りゃくず しずむ 漠然 この頃 汚す 戦没 委員 高値 だいどころ よぼう 大仏 よぼう かんりょうてき こくみん 奇襲 ころす はなぢ みなもと 漂う 委員 入江 さきまわり きゅうりょう むぼう たくす 無駄 学者 ひんきゃく こはん 誘惑 浸す 差し上げる ごふく 日欧 賢明 たくす せんりゅう 退く 都合 つばさ あらそう 奴ら 合う.", 0, "Licensed Wooden Bacon" },
                    { new Guid("bb602b54-637e-41b3-a07f-5da683e603be"), 0m, "復旧 金 指紋 活用 かん ひんかく だくりゅう 閉める つなひき うんがいい しばふ へいがい きいろ しょうじょう 貫く 果てる 果てる 渦巻き 底 いちだい たれる 色盲 長唄 大丈夫 雇用 壮年 奇襲 むらさきいろ 靖国神社 量 休日 斬殺 けいむしょ 部首 魅力 新婚旅行 ほうげん つうやく 弱虫 せんたくする 誓い 浅い はりい 全日本 電源 始まる 委員 けいかん 伐採 間隔.", 0, "Fantastic Granite Gloves" },
                    { new Guid("bfee866c-e60e-4d91-bccf-b3c7ec9bd50b"), 0m, "あれる 薬 こうちょく かんぜん めいし むこう 入江 丼 電話 しきもう つなひき さいほう 長唄 以下 かんしん じぎする 閉じる せいぞう まつり 秘める 一文字 店舗 遮断 雇用 切迫 以下 げんめつ おどろく ほうしゅう たいこうする 待合 ふかさ 床 天井 大丈夫 〜系 つばさ たいこうする 縛る 人口 施行 雑音 おととい 明治 ざんぴん せいじょう せっぷく 鍋 狂う きょうどう.", 0, "Handmade Concrete Hat" },
                    { new Guid("c2c39541-7fed-4efd-a055-0dcf54a9b613"), 0m, "つく 不健康 色盲 おかね 助手 脱税 とちょう かおつき 当て字 ふさい けいじばん だくりゅう 黒板 のき 仕方がない 魅力 済ます 大仏 みなもと 不可欠 かおつき 屈む 当て字 かいたく 芸者 かくじっけん おんとう 礎 はなじ あらあらしい 汚す さくにゅう むく 一文字 羊毛 壮年 あくれい しばふ 左手 零す 馬鹿馬鹿しい 救急車 ぼきん 避ける 遮断 誓い あらそう 哀れむ 部首 とめる.", 0, "Licensed Soft Mouse" },
                    { new Guid("c94fbf04-0b7f-46db-8f2a-9428ddd6b44c"), 0m, "せいしん ぶき うえる しょくん 無駄 りゃくず かんりょうてき まつり かん 量 斬殺 難しい せいぞう 好き 明治 隆起 はだか 騎兵 こくみん ふそく ぼくし ふん 〜系 じぶん 奴ら どろ ぐん 華やか せいかん ぶそう 差し上げる かっこう 重い 自宅 たれる 輸出 暇 備える くつじょく 運ぶ ごふく 超〜 ごうけん ぼきん 量 あらす ぼくし 提案する しゃっか きょだい.", 0, "Tasty Steel Tuna" },
                    { new Guid("cada3c78-1f1e-4e1a-9b8c-ae9195ccc34d"), 0m, "すいせん やさい 廉価 金縛り こいぬ 隆起 ふさい しゃっか にる あらす けいけんしゃ 活用 底 ししょく あしくび 運ぶ たくす 漂う 復旧 学院 きょうかい 明治 殻 ほうしゅう 形 とふ あしくび 備える つまる うえる 機嫌 弱虫 話 核実験 哀れむ おかね 掛ける 雑音 洋服 げいひんかん こうおつ 核実験 げいひんかん 待合 不健康 汚す けいじばん かおつき 恨み ころす.", 0, "Handcrafted Metal Soap" },
                    { new Guid("cb1e8602-dbec-46fa-9c16-e213270d3293"), 0m, "乗せる 問題 すんか 揺さぶる 地面 全日本 ゆるむ こうおつ みさき せんじょうざい だいどころ だくりゅう 普及 さきまわり 浸す よくげつ 〜亭 超音波 フランス語 まつ ざぜん おきゃくさん はちまき 面積 はんだんする 窒息 色盲 奇襲 たいりく さいぼう 九日 せんりゅう よぼう ほ 塾生 喜劇 かわかす まぎらす 秘める 旧姓 さいぼう 委員 明治 うえる 底 果樹 じきしょうそう 伝統 りょうど にんい.", 0, "Fantastic Fresh Tuna" },
                    { new Guid("d47c7060-59d0-4282-be26-8a10738dcb4f"), 0m, "どうけつ げいひんかん かんしん 浸す 液体 狂う きょうどう にんい 斬殺 にる あつい こいぬ 核実験 いく ごうけん ぶき 壮年 せんたくする 始まる 無糖 ぶき せっぷく とうさん 特殊 おどろく おどろく 九日 こうおつ あらあらしい ひんかく じぞう 迷路 雑音 機嫌 あう はりい 好き ひきざん ほうせき そんざい がいよう 約する 黒板 先ず 間隔 弥生 陳列室 既に 零す ざぜん.", 0, "Generic Soft Cheese" },
                    { new Guid("d63745cc-c683-4b21-a26c-341829ae02fc"), 0m, "せんじょうざい かくじっけん 出版 シアトルし 靖国神社 ようい じぶん かぜ 鍋 めいしょ 迷子 下さい シアトルし 金縛り がいよう こうせい 〜系 おりめ 無糖 つなひき ぐん 馬鹿馬鹿しい あらす せいぞう 床 出かける せんじょうざい こくふくする そだてる よくげつ めいがら 提案する 日欧 かおつき ぶん しゃっか 以下 さいばん 施行 絹糸 閉める しょうりゃく しょくん もはん 送る 色々 寮生 委員 はっぽう かいたく.", 0, "Licensed Plastic Ball" },
                    { new Guid("d7d2a933-f74d-4415-868c-9cb78c63bb40"), 0m, "せんじょうざい 俵 あらす 凝固 あう たいりく ざぜん あらあらしい はんだんする 浅い 全日本 味噌 たつ 入江 ごうけん めいがら 運ぶ じぶん 日欧 没落 せいじょう ふかさ けいじばん 明治 学院 ちらかす せんたくする じょうき ひきさく しゃくや ずいぶん 汚す かぜ 鈍器 かんしん けいけんしゃ 特殊 もうす 壮年 しょうじょう 学者 おんとう 待合 馬鹿馬鹿しい きょうしつ やさい 軒 うえる かいたく きょうどう.", 0, "Handcrafted Fresh Computer" },
                    { new Guid("d8737759-92c9-4966-a13d-343b941d8a00"), 0m, "壊す 配慮 九日 やしなう 黙る こうちょく 間隔 きゅうりょう かたみち かぜ 揺さぶる もうす 魔術 しゅしょう そあく 鍋 仕方がない 核実験 俵 見当たる 差し上げる くつじょく じぶん はなぢ けいけんしゃ 太る よわよわしい 泳ぐ しきもう 壊す まつり 話 窒息 核実験 普及 じょうじゅん うんがいい 歯を磨く こいぬ ちえん うえる 隆起 陳列室 みつ あらそう れつあく 運ぶ ねんじゅう やさしい なんべい.", 0, "Awesome Wooden Keyboard" },
                    { new Guid("dc07b6e4-eb92-4cd3-9270-46fc549c9004"), 0m, "ごじゅう 店舗 のき えきびょう 天井 宜しく せいじょう 禍根 輸出 不健康 江戸 底 超音波 ほうしゅう よくげつ 旧姓 誤用 活用 超〜 かたみち 退く 太る ぼくし いっさくじつ 学院 塾生 いっさくじつ ほんらい たくす 軒 むぜい 施行 零す はちのす ざぜん ふさい 施行 出かける しきもう 血液 さくにゅう たいさ たくす 漠然 みなもと 馬 あっとうする 号 きょうしつ 不可欠.", 0, "Handcrafted Rubber Pants" }
                });

            migrationBuilder.InsertData(
                table: "SanPhams",
                columns: new[] { "Id", "GiaBan", "MoTa", "SoLuongTon", "TenSanPham" },
                values: new object[,]
                {
                    { new Guid("dd29f7d4-f3d2-49b7-a8be-a85432dcaa1e"), 0m, "にる 伐採 縛る 馬鹿馬鹿しい 長唄 かっこう とくに 色々 たいさ 唄う とくに 総括 しえんする ちえん 一文字 〜亭 はなぢ 芽 丼 難しい 警官 めいがら 俵 じっかん 体重 魅力 かつ たいさ あくれい 親切 かんりょうてき 希望する 魅力 犠牲 自宅 ちえん 明治 長唄 日没 指紋 かくじっけん そだてる 難しい こうせい フランス人 げんめつ 犠牲 普及 核実験 屈む.", 0, "Handmade Cotton Chips" },
                    { new Guid("de73e9df-a484-479a-a2e1-921accd7c77b"), 0m, "さいばん きげんご つなひき 交錯 じぎする 割り箸 かっこう よわよわしい 隆起 ごふく 交錯 核実験 急騰 みさき じっかん ぼくし 浅い 退く 施行 じょうだん 先週 切迫 こはん 電話 継承 たいこうする きひん 貫く 壮年 果樹 しょうがっこう すんか 全日本 希望する よくげつ 天井 ほにゅうびん かんどうする ひがい 休日 牛乳 輸出 芸者 黙る 薬 馬鹿馬鹿しい 汚す 一文字 かんどうする 俵.", 0, "Gorgeous Fresh Pizza" },
                    { new Guid("e3362938-d1be-4a88-bfc8-b60fe8865c7f"), 0m, "米国 むぼう さいばん 牛乳 渦巻き むこう いく しえんする 撃つ 病床 ちかく ひがい げんめつ りゃくず ねばり 体重 かいじゅう しょうじょう どうけつ ちゅうもんする 先週 華やか 始まる かんどうする あしくび 投資 見当たる 差し上げる どろ ねばり 境 俵 きょうふ かいぞく きょうふ 旧姓 みなもと めいし 江戸 唄う 太る えきびょう 済ます 貫く 魔法 りゃくず のき 始まる ほうしゅう とめる.", 0, "Rustic Rubber Bike" },
                    { new Guid("e44307d7-886d-441f-9bfb-368ba3647095"), 0m, "ほうせき 恨み 魔法 掛ける 誤用 たらす 推奨 しょくん 秘める しょうかする 切迫 恨み きょうはんしゃ 羊毛 軒 始まる 日没 つく こうちょく ぼきん 号 賢明 華やか 面 一文字 ちょさくけん 報じる うえる どうけつ 避ける はりい 哀れむ 丼 都合 けいかん かん 話 無駄 先週 天井 斬殺 重い こくふくする 不思議 がんばる こうぞく 疾走 いじん あれる きょうふ.", 0, "Sleek Plastic Shirt" },
                    { new Guid("e6301a2c-2276-4acc-a8ae-4b4138acd213"), 0m, "防犯 きょうどう ひきざん けいむしょ こうせい しばふ にる 窓 きんく 鍋 しきもう 察知 碁 機嫌 さくにゅう ふん 形 こわす 普及 普及 渦巻き 遮断 ふん じゅうらい 擬装 遮断 みなもと 誓い どろ 米兵 せんじょうざい きょうふ 大丈夫 きょうき ちゅうもんする こくふくする こくふくする もうす 靖国神社 揺さぶる ふさい 奉仕 核実験 普及 さいほう おきゃくさん きいろ そだてる 老齢 差し上げる.", 0, "Fantastic Metal Hat" },
                    { new Guid("e872b304-ebc3-4494-a5a9-2859625ac9d1"), 0m, "逆 悲しみ つうやく けしき 大尉 ぶっきょう 液体 勇気 希望する 太る せいじょう 割り箸 あっとうする こうせい 重い 金縛り 歯を磨く せっぷく ちがい じじょでん 華やか 鈍器 壊す 血液 差し上げる 十台 隆起 平安 ごふく ひきざん 魅力 窓 難しい 金星 擬装 やさしい 大仏 暇 フランス語 じぶん 大尉 明治 体重 同僚 都合 けいかん 徳川 牛乳 超〜 問題.", 0, "Licensed Fresh Bike" },
                    { new Guid("e96c09b6-21db-4ef4-90b1-4dd39c8ba613"), 0m, "ぶっきょう みなと 殺人者 はっぽう ねんじゅう すんか じっかん えきびょう つなひき ぼうず さいほう むらさきいろ 〜系 はんそう ぶっきょう きょうはんしゃ 閉じる ふかさ きいろ 漠然 旧姓 フランス人 しょうゆ かい きょうき しえんする 暇 活用 つまる 平安 いちだい 学者 始まる 出版 店 米兵 助手 かん 鈍器 喜劇 たくす しゃっか 賢明 じょうじゅん 撃つ きひん 傑作 脱税 禍根 さいぼう.", 0, "Refined Cotton Bike" },
                    { new Guid("e9d16bdb-4a00-44cd-bec8-20557698c0b6"), 0m, "地面 黒板 たつ にんい 陳列室 軒 いう にんい ほんらい きょうふ 廃墟 はんそう かんどうする つなひき 奉仕 靖国神社 ふそく 約する ぼきん たて あらす かわかす こうつう ころす かぜ 零す 掛ける かんそく おどろく ことばつき 底 九日 撃つ いじん さくにゅう たくす 開閉 貫く 絹糸 右利き 推奨 きげんご きゅうりょう こうつう 〜系 ことばつき 漠然 傑作 壊す 日欧.", 0, "Awesome Concrete Computer" },
                    { new Guid("eaaf1e2f-3ec4-42af-a384-e7c9b6f24e5b"), 0m, "ないしょばなし げんめつ こうおつ しゃくや 金 遮断 送る せんたくする ごうけん 華やか ひんきゃく ぐん ぐん 日没 かんそく かつ 飽くまでも 親切 済ます 漂う はりい はだか ひんかく 馬鹿馬鹿しい 一文字 恨み いく 運ぶ 脱税 ひきざん 唄う 面積 江戸 華やか 暴力 かいじゅう 伝統 消す えきびょう 原油 いちだい 封筒 まもる かんどうする 屈む 量 みなもと 浮世絵 継承 電話.", 0, "Licensed Frozen Chips" },
                    { new Guid("ef95f26a-ecd7-4909-b28a-792a040c8784"), 0m, "塾生 とめる みつ 華やか 〜亭 ねんじゅう ぼうず 疾走 品詞 こうちょく みさき せいかん 超音波 じきしょうそう ほんらい 馬鹿馬鹿しい 殺人者 ふん 貫く 消す ころす ひかくする 入江 当て字 むこう こうつう あびる 無糖 こうつう 徳川 えきびょう めいし 羊毛 けいむしょ 誘惑 お盆 先ず きょだい 魔術 老齢 魔法 宜しく いう 下着 老齢 洋服 ふん ちきゅう ぞくご 塾生.", 0, "Sleek Frozen Computer" },
                    { new Guid("f090572c-966c-411e-b6d4-115e02962e05"), 0m, "高値 ぼくし 廃墟 牛乳 ゆるむ 防犯 あびる 店 たて 暇 左手 たて たいやく しょうかする 活用 独裁 安泰 ハチのす たいやく 報じる 減俸 おととい 十台 いつ頃 廉価 ぶそう こうせい きゅうりょう 投資 いじん 長唄 形 弱虫 自宅 江戸 封筒 ちゅうもんする こくふくする しきもう 馬鹿馬鹿しい いう むぜい ふくへい どうけつ 狂う りゅうこうご 塾生 戦没 せいかん 面積.", 0, "Licensed Steel Salad" },
                    { new Guid("f411948f-9a55-44a7-afcb-6973527cee7f"), 0m, "妥協する くつじょく 核実験 つく せんじょうざい ひきさく はなぢ 境 浮世絵 廉価 交錯 だくりゅう 漠然 無駄 報じる 助手 はりい しゅしょう 運ぶ 金星 せんじょうざい たまご いく 量 都合 じぶん 無糖 はっぽう 警官 あしくび 提案する 右翼 学者 暴力 のき つなひき 雑音 妥協する 掛ける 閉める 遺失 逆 掛ける あれる きょうき 機嫌 りょうど 乗せる ずいぶん 弱虫.", 0, "Awesome Cotton Car" },
                    { new Guid("f46d4d2b-db80-44b7-9396-414e261f5e19"), 0m, "廉価 継承 金星 ちあん よくげつ 避ける 上手 じょうだん 〜系 フランス語 迷路 こうちょく すんか きょだい しょうゆ 馬 ぶき 特殊 誤用 都合 廉価 ぶん 減俸 復旧 揺さぶる だくりゅう 斬殺 まもる おきゃくさん 喜劇 碁 品詞 哀れむ ゆるむ 推奨 お盆 撃つ 形 縛る とちょう みつ ごふく つく ほうせき そんざい まぎらす 急騰 やしなう 窓 とふ.", 0, "Awesome Wooden Fish" },
                    { new Guid("f85b5190-50c7-4d65-b0b2-05b44b3a3b01"), 0m, "面積 つまる はんだんする 上手 出版 品詞 じょうじゅん はんそう 九日 むく あらあらしい たれる 徳川 施行 くつじょく やさしい さいぼう 禍根 部首 桜色 たて ひがい ごうけん 差し上げる ししょく 問題 きゅうりょう ざんぴん 羊毛 杏 減俸 ないしょばなし 母 きげんご ざぜん きんく 地面 じっかん 指紋 ぼくし 自立 人性 退く 渦巻き 店 漂う 見当たる けいむしょ 見当たる じょうだん.", 0, "Incredible Plastic Cheese" },
                    { new Guid("f8f8f00a-94bf-4166-a613-df69b78519c7"), 0m, "宜しく なおさら とうさん 同僚 全日本 暴力 ちらかす きもち せんじょうざい 果樹 ぶき 無糖 あびる そんざい きょうはんしゃ 浅い いちだい 問題 ぞくご かっこう きょうふ あらあらしい とくに きひん 人性 唄う ちゅうもんする 休日 退く 天井 俵 量 しずむ ほんらい 無駄 迷路 さいほう はなじ 味噌 むぜい 終点 宜しく いちだい とくに 見当たる あしくび 殻 牛乳 ねんじゅう 秘める.", 0, "Generic Plastic Computer" },
                    { new Guid("fbc12cad-380f-4b69-9496-488430854fce"), 0m, "あう ぶそう 九日 みつ しょうりゃく ないしょばなし こうせい 指紋 きゅうりょう 休日 むく よぼう この頃 たいさ めいがら 施行 歯を磨く 騎兵 閉じる せんりゅう 色盲 洋服 委員 抑制 きょうはんしゃ まつり 自宅 はちまき ひんきゃく あらそう りょうど けいけんしゃ 色盲 いつ頃 おりめ あつかい 好き げいひんかん しょうがっこう じぶん 底 汚す 済ます かっこう 迷子 間隔 おかね 金 一文字 みなと.", 0, "Fantastic Granite Chicken" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_DanhMucSanPham_DanhMuc_DanhMucsId",
                table: "DanhMucSanPham",
                column: "DanhMucsId",
                principalTable: "DanhMuc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DonHang_KhachHang_KhachHangId",
                table: "DonHang",
                column: "KhachHangId",
                principalTable: "KhachHang",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DonHangSanPham_DonHang_DonHangsId",
                table: "DonHangSanPham",
                column: "DonHangsId",
                principalTable: "DonHang",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
