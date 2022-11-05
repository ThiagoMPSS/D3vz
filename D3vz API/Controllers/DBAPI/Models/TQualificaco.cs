using System;
using System.Collections.Generic;

namespace D3vz_API.Models
{
    public partial class TQualificaco
    {
        public long IdQualificacoes { get; set; } = 0;
        public long TProfTUserIdUser { get; set; }
        public string DsLinguagem { get; set; } = null!;

        public virtual TProf TProfTUserIdUserNavigation { get; set; } = null!;
    }
}
