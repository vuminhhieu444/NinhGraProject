using System;
using System.Collections.Generic;

namespace GraduateSolution.Models
{
    public partial class Admin
    {
        public Admin()
        {
            //NguoiDungs = new HashSet<NguoiDung>();
        }

        public string Maadmin { get; set; } = null!;
        public string Tenadmin { get; set; } = null!;
        public string? Ghichu { get; set; }

        //public virtual ICollection<NguoiDung> NguoiDungs { get; set; }
    }
}
