using System;
using System.Collections.Generic;

namespace GraduateSolution.Models
{
    public partial class XepHang
    {
        public string MaBangXepHang { get; set; } = null!;
        public string? TenGiaiDau { get; set; }
        public string? TenDoiThiDau { get; set; }
        public short? SoTranThiDau { get; set; }
        public bool? IsWin { get; set; }
        public bool? IsDraw { get; set; }
        public bool? IsLose { get; set; }
        public string? HieuSo { get; set; }
    }
}
