using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace D3vz_API.Models
{
    public partial class TQualificaco
    {
        public long IdQualificacoes { get; set; } = 0;
        [JsonIgnore]
        public long TProfTUserIdUser { get; set; }
        public string DsLinguagem { get; set; } = null!;

        [JsonIgnore]
        public virtual TProf TProfTUserIdUserNavigation { get; set; } = null!;
    }
}
