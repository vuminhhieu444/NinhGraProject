using System;
using System.Collections.Generic;

namespace GraduateSolution.Models
{
    public partial class DanhMucCon
    {
        public string Madmc { get; set; } = null!;
        public string? Madm { get; set; }
        public string? Tendmc { get; set; }
        public string? Mota { get; set; }

        public virtual DanhMuc? MadmNavigation { get; set; }
    }
}
