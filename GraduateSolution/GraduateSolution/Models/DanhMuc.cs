using System;
using System.Collections.Generic;

namespace GraduateSolution.Models
{
    public partial class DanhMuc
    {
        public DanhMuc()
        {
            //DanhMucCons = new HashSet<DanhMucCon>();
        }

        public string Madm { get; set; } = null!;
        public string? Tendm { get; set; }
        public string? Mota { get; set; }

        //public virtual ICollection<DanhMucCon> DanhMucCons { get; set; }
    }
}
