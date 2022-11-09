using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace D3vz_API.Models {
    public partial class TInteress {
        public TInteress() {
            TAluno_TInteressNavigation = new HashSet<TAluno_TInteress>();
        }

        public long IdInteresses { get; set; }
        public string DsInteresse { get; set; } = null!;

        [JsonIgnore]
        public virtual ICollection<TAluno_TInteress> TAluno_TInteressNavigation { get; set; }
    }
}
