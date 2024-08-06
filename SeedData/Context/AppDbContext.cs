using Bogus;
using Microsoft.EntityFrameworkCore;
using SeedData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeedData.Context
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=10.37.129.2;Database=SeedDataDB;User Id=SA;Password=Charles3009$;");
        }

        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<DanhMuc> DanhMucs { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // normal seed data
            //modelBuilder.Entity<SanPham>().HasData(
            //    new SanPham { Id = Guid.NewGuid(), TenSanPham = "San pham 1", MoTa = "SP1" },
            //    new SanPham { Id = Guid.NewGuid(), TenSanPham = "San pham 2", MoTa = "SP2" },
            //    new SanPham { Id = Guid.NewGuid(), TenSanPham = "San pham 3", MoTa = "SP3" },
            //    new SanPham { Id = Guid.NewGuid(), TenSanPham = "San pham 4", MoTa = "SP4" });

            // bogus seed data
            //var sanPhamFaker = new Faker<SanPham>("ja")
            //    .RuleFor(sp => sp.Id, f => Guid.NewGuid())
            //    .RuleFor(sp => sp.TenSanPham, f => f.Commerce.ProductName())
            //    .RuleFor(sp => sp.MoTa, f => f.Lorem.Sentence(50));
            //var sanPhams = sanPhamFaker.Generate(100);
            //modelBuilder.Entity<SanPham>().HasData(sanPhams);

            SeedDatas(modelBuilder);
        }

        protected void SeedDatas(ModelBuilder modelBuilder)
        {
            // seed KhachHang
            var khachHangFaker = new Faker<KhachHang>("vi")
                .RuleFor(kh => kh.Id, f => Guid.NewGuid())
                .RuleFor(kh => kh.HoTen, f => f.Name.FullName())
                .RuleFor(kh => kh.Email, f => f.Internet.Email())
                .RuleFor(kh => kh.SoDienThoai, f => f.Phone.PhoneNumberFormat())
                .RuleFor(kh => kh.DiaChi, f => f.Address.FullAddress());
            var khachHangs = khachHangFaker.Generate(100);
            modelBuilder.Entity<KhachHang>().HasData(khachHangs);

            // seed DanhMuc
            var danhMucFaker = new Faker<DanhMuc>("vi")
                .RuleFor(dm => dm.Id, f => Guid.NewGuid())
                .RuleFor(dm => dm.TenDanhMuc, f => f.Commerce.Categories(1)[0])
                .RuleFor(dm => dm.MoTa, f => f.Lorem.Sentence());
            var danhMucs = danhMucFaker.Generate(10);
            modelBuilder.Entity<DanhMuc>().HasData(danhMucs);

            // seed SanPham
            var sanPhamFaker = new Faker<SanPham>("vi")
                .RuleFor(sp => sp.Id, f => Guid.NewGuid())
                .RuleFor(sp => sp.TenSanPham, f => f.Commerce.ProductName())
                .RuleFor(sp => sp.MoTa, f => f.Lorem.Sentence(50))
                .RuleFor(sp => sp.GiaBan, f => decimal.Parse(f.Commerce.Price(10, 1000)))
                .RuleFor(sp => sp.SoLuongTon, f => f.Random.Int(0, 1000));
            var sanPhams = sanPhamFaker.Generate(100);
            modelBuilder.Entity<SanPham>().HasData(sanPhams);

            // seed DonHang
            var donHangFaker = new Faker<DonHang>("vi")
                .RuleFor(dh => dh.Id, f => Guid.NewGuid())
                .RuleFor(dh => dh.NgayDatHang, f => f.Date.Past(1))
                .RuleFor(dh => dh.NgayGiaoHang, f => f.Date.Soon(3))
                .RuleFor(dh => dh.TongTien, f => f.Finance.Amount(50, 5000))
                .RuleFor(dh => dh.KhachHangId, f => f.PickRandom(khachHangs).Id);
            var donHangs = donHangFaker.Generate(1000);
            modelBuilder.Entity<DonHang>().HasData(donHangs);

            // seed DonHangSanPham
            var random = new Random();
            var capKhoaChinhDHSP = new Dictionary<Guid, List<Guid>>();
            var donHangSanPhamList = new List<object>();
            foreach (var donHang in donHangs)
            {
                for (int i = 0; i < random.Next(1, 5); i++)
                {
                    var sanPham = sanPhams[random.Next(sanPhams.Count)];
                    if (!capKhoaChinhDHSP.ContainsKey(donHang.Id))
                    {
                        capKhoaChinhDHSP[donHang.Id] = new List<Guid>();
                    }
                    if (!capKhoaChinhDHSP[donHang.Id].Contains(sanPham.Id))
                    {
                        capKhoaChinhDHSP[donHang.Id].Add(sanPham.Id);
                        donHangSanPhamList.Add(new { DonHangsId = donHang.Id, SanPhamsId = sanPham.Id });
                    }
                }
            }
            modelBuilder.Entity<DonHang>()
                .HasMany(dh => dh.SanPhams)
                .WithMany(sp => sp.DonHangs)
                .UsingEntity(j => j.HasData(donHangSanPhamList));
        }
    }
}
