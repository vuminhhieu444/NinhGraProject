using System;
using System.Collections.Generic;

namespace GraduateSolution.Models
{
    public partial class LogUser
    {
        public string Id { get; set; } = null!;
        public string? UserName { get; set; }
        public string? Pass { get; set; }
    }
}
