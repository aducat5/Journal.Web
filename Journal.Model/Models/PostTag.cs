using System;
using System.Collections.Generic;

namespace Journal.Model.Models
{
    public partial class PostTag
    {
        public int PostId { get; set; }
        public int TagId { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Post Post { get; set; } = null!;
        public virtual Tag Tag { get; set; } = null!;
    }
}
