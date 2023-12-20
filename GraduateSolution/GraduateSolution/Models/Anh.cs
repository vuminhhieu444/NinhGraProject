using System;
using System.Collections.Generic;

namespace GraduateSolution.Models
{
    public partial class Anh
    {
        public string Maanh { get; set; } = null!;
        public string? Tenanh { get; set; }
        public string? Maadm { get; set; }
        public string? Hinhanh { get; set; }
        public string? Noidung { get; set; }
        public string? Matinbai { get; set; }
        public bool? Trangthai { get; set; }
    }
}
