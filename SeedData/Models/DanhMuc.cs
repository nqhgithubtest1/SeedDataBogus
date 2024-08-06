using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeedData.Models
{
    public class DanhMuc
    {
        public Guid Id { get; set; }
        public string TenDanhMuc { get; set; }
        public string MoTa { get; set; }

        // n-n SanPham
        public ICollection<SanPham> SanPhams { get; set; }
    }
}
