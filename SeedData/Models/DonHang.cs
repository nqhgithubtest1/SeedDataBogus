using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeedData.Models
{
    public class DonHang
    {
        public Guid Id { get; set; }
        public DateTime NgayDatHang { get; set; }
        public DateTime NgayGiaoHang { get; set; }
        public decimal TongTien { get; set; }

        // 1-n KhachHang
        public Guid KhachHangId { get; set; }
        public KhachHang KhachHang { get; set; }

        // n-n SanPham
        public ICollection<SanPham> SanPhams { get; set; }
    }
}
