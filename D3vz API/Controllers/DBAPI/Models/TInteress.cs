using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace D3vz_API.Models
{
    public partial class TInteress
    {
        public long IdInteresses { get; set; } = 0;
        //[JsonIgnore]
        //public long TAlunoTUserIdUser { get; set; }
        public string DsInteresse { get; set; } = null!;

        [JsonIgnore]
        public virtual TAluno[] TAlunoTUserIdUserNavigation { get; set; } = null!;
    }
}
