using System;
using System.Collections.Generic;

namespace D3vz_API.Models
{
    public partial class TAula
    {
        public long IdAula { get; set; } = 0;
        public long TAlunoTUserIdUser { get; set; }
        public long TProfTUserIdUser { get; set; }

        public virtual TAluno TAlunoTUserIdUserNavigation { get; set; } = null!;
        public virtual TProf TProfTUserIdUserNavigation { get; set; } = null!;
    }
}
