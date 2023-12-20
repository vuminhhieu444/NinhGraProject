using System;
using System.Collections.Generic;

namespace GraduateSolution.Models
{
    public partial class NguoiDung
    {
        public string Manguoidung { get; set; } = null!;
        public string? Tennguoidung { get; set; }
        public string? Maadmin { get; set; }
        public string? Tieude { get; set; }
        public string? Noidung { get; set; }
        public bool? Trangthai { get; set; }

        //public virtual Admin? MaadminNavigation { get; set; }
    }
}
