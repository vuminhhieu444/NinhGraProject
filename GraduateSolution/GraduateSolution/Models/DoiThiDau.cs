﻿using System;
using System.Collections.Generic;

namespace GraduateSolution.Models
{
    public partial class DoiThiDau
    {
        public string Id { get; set; } = null!;
        public string? TenDoiThiDau { get; set; }
        public string? TenGiaiDau { get; set; }
        public string? MaGiaiDau { get; set; }
    }
}
