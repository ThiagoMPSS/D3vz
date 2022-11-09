using System;
using System.Collections.Generic;

namespace D3vz_API.Models
{
    public partial class TProf
    {
        public TProf()
        {
            TAulas = new HashSet<TAula>();
            TProf_TQualificacao = new HashSet<TProf_TQualificacao>();
        }

        public long TUserIdUser { get; set; } = 0;
        public string DsProf { get; set; } = null!;

        public virtual TUser TUserIdUserNavigation { get; set; } = null!;
        public virtual ICollection<TAula> TAulas { get; set; }
        public virtual ICollection<TProf_TQualificacao> TProf_TQualificacao { get; set; }
    }
}
