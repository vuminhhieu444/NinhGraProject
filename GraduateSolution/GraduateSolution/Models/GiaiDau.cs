using System;
using System.Collections.Generic;

namespace GraduateSolution.Models
{
    public partial class GiaiDau
    {
        public GiaiDau()
        {
            //XepHangs = new HashSet<XepHang>();
        }

        public string Id { get; set; } = null!;
        public string? TenGiaiDau { get; set; }

        //public virtual ICollection<XepHang> XepHangs { get; set; }
    }
}
