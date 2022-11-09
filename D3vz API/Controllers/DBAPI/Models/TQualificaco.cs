using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace D3vz_API.Models {
    public partial class TQualificacao {
        public TQualificacao() {
            TProf_TQualificacaoNavigation = new HashSet<TProf_TQualificacao>();
        }

        public long IdQualificacoes { get; set; } = 0;
        public string DsLinguagem { get; set; } = null!;

        [JsonIgnore]
        public virtual ICollection<TProf_TQualificacao> TProf_TQualificacaoNavigation { get; set; } = null!;
    }
}
