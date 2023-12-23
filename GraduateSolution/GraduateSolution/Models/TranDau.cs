using System;
using System.Collections.Generic;

namespace GraduateSolution.Models
{
    public partial class TranDau
    {
        public string Id { get; set; } = null!;
        public string? TenGiaiDau { get; set; }
        public string? TenDoiDau1 { get; set; }
        public short? SoBanThangGhiDoiDau1 { get; set; }
        public string? TenDoiDau2 { get; set; }
        public short? SoBanThangGhiDoiDau2 { get; set; }
        public string? MaDoiDau1 { get; set; }
        public string? MaDoiDau2 { get; set; }
    }
}
