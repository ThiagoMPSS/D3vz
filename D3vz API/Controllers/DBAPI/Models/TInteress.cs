using System;
using System.Collections.Generic;

namespace D3vz_API.Models
{
    public partial class TInteress
    {
        public long IdInteresses { get; set; } = 0;
        public long TAlunoTUserIdUser { get; set; }
        public string DsInteresse { get; set; } = null!;

        public virtual TAluno TAlunoTUserIdUserNavigation { get; set; } = null!;
    }
}
