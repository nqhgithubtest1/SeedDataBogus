using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeedData.Models
{
    public class SanPham
    {
        public Guid Id { get; set; }
        public string TenSanPham { get; set; }
        public string MoTa { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuongTon { get; set; }

        // n-n DonHang, DanhMuc
        public ICollection<DonHang> DonHangs { get; set; }
        public ICollection<DanhMuc> DanhMucs { get; set; }
    }
}
