using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace D3vz_API.Models {
    public partial class TInterQuali {
        public TInterQuali() {
            TAluno_TInterQualiNavigation = new HashSet<TUser_TInterQuali>();
        }

        public long IdInterQuali { get; set; }
        public string DsLinguagem { get; set; } = null!;

        [JsonIgnore]
        public virtual ICollection<TUser_TInterQuali> TAluno_TInterQualiNavigation { get; set; }
    }
}
