using System;
using System.Collections.Generic;

namespace GraduateSolution.Models
{
    public partial class BinhLuan
    {
        public string MaBinhLuan { get; set; } = null!;
        public string? MaTinBai { get; set; }
        public string? MaUser { get; set; }
        public DateTime? ThoiGian { get; set; }
    }
}
