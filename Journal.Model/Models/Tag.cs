using System;
using System.Collections.Generic;

namespace Journal.Model.Models
{
    public partial class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool IsDeleted { get; set; }
    }
}
