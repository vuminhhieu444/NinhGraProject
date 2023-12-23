using System;
using System.Collections.Generic;

namespace GraduateSolution.Models
{
    public partial class DoiThiDau
    {
        public DoiThiDau()
        {
            //XepHangs = new HashSet<XepHang>();
        }

        public string Id { get; set; } = null!;
        public string? TenDoiThiDau { get; set; }
        public string? TenGiaiDau { get; set; }

        //public virtual ICollection<XepHang> XepHangs { get; set; }
    }
}
