using Bogus;
using Microsoft.EntityFrameworkCore;
using SeedData.Models;

namespace SeedData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // seed KhachHang
            var khachHangFaker = new Faker<KhachHang>("vi")
                .RuleFor(kh => kh.Id, f => Guid.NewGuid())
                .RuleFor(kh => kh.HoTen, f => f.Name.FullName())
                .RuleFor(kh => kh.Email, f => f.Internet.Email())
                .RuleFor(kh => kh.SoDienThoai, f => f.Phone.PhoneNumberFormat())
                .RuleFor(kh => kh.DiaChi, f => f.Address.FullAddress());
            var khachHangs = khachHangFaker.Generate(100);
            //modelBuilder.Entity<KhachHang>().HasData(khachHangs);

            // seed DanhMuc
            var danhMucFaker = new Faker<DanhMuc>("vi")
                .RuleFor(dm => dm.Id, f => Guid.NewGuid())
                .RuleFor(dm => dm.TenDanhMuc, f => f.Commerce.Categories(1)[0])
                .RuleFor(dm => dm.MoTa, f => f.Lorem.Sentence());
            var danhMucs = danhMucFaker.Generate(10);
            //modelBuilder.Entity<DanhMuc>().HasData(danhMucs);

            // seed SanPham
            var sanPhamFaker = new Faker<SanPham>("vi")
                .RuleFor(sp => sp.Id, f => Guid.NewGuid())
                .RuleFor(sp => sp.TenSanPham, f => f.Commerce.ProductName())
                .RuleFor(sp => sp.MoTa, f => f.Lorem.Sentence(50))
                .RuleFor(sp => sp.GiaBan, f => decimal.Parse(f.Commerce.Price(10, 1000)))
                .RuleFor(sp => sp.SoLuongTon, f => f.Random.Int(0, 1000));
            var sanPhams = sanPhamFaker.Generate(100);
            //modelBuilder.Entity<SanPham>().HasData(sanPhams);

            // seed DonHang
            var donHangFaker = new Faker<DonHang>("vi")
                .RuleFor(dh => dh.Id, f => Guid.NewGuid())
                .RuleFor(dh => dh.NgayDatHang, f => f.Date.Past(1))
                .RuleFor(dh => dh.NgayGiaoHang, f => f.Date.Soon(3))
                .RuleFor(dh => dh.TongTien, f => f.Finance.Amount(50, 5000))
                .RuleFor(dh => dh.KhachHangId, f => f.PickRandom(khachHangs).Id);
            var donHangs = donHangFaker.Generate(1000);
            //modelBuilder.Entity<DonHang>().HasData(donHangs);

            // seed DonHangSanPham
            var random = new Random();
            var capKhoaChinhDHSP = new Dictionary<Guid, List<Guid>>();
            foreach (var donHang in donHangs)
            {
                for (int i = 0; i < random.Next(1, 5); i++)
                {
                    var sanPham = sanPhams[random.Next(sanPhams.Count)];
                    if (!capKhoaChinhDHSP.ContainsKey(donHang.Id))
                    {
                        capKhoaChinhDHSP[donHang.Id] = new List<Guid>();
                    }
                }
            }
        }
    }
}
