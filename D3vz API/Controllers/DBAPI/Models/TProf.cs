using System;
using System.Collections.Generic;

namespace D3vz_API.Models
{
    public partial class TProf
    {
        public TProf()
        {
            TAulas = new HashSet<TAula>();
            TQualificacos = new HashSet<TQualificaco>();
        }

        public long TUserIdUser { get; set; } = 0;
        public string DsProf { get; set; } = null!;

        public virtual TUser TUserIdUserNavigation { get; set; } = null!;
        public virtual ICollection<TAula> TAulas { get; set; }
        public virtual ICollection<TQualificaco> TQualificacos { get; set; }
    }
}
