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
        public short? WinNum { get; set; }
        public short? DrawNum { get; set; }
        public short? LoseNum { get; set; }
        public string? HieuSo { get; set; }
        public string? MaGiaiDau { get; set; }
        public string? MaDoiThiDau { get; set; }

        public virtual DoiThiDau? MaDoiThiDauNavigation { get; set; }
        public virtual GiaiDau? MaGiaiDauNavigation { get; set; }
    }
}
