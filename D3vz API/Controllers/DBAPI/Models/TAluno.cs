using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace D3vz_API.Models
{
    public partial class TAluno
    {
        public TAluno()
        {
            TAulas = new HashSet<TAula>();
            TInteresses = new HashSet<TInteress>();
        }

        public long TUserIdUser { get; set; } = 0;
        public virtual TUser TUserIdUserNavigation { get; set; } = null!;
        public virtual ICollection<TAula> TAulas { get; set; }
        public virtual ICollection<TInteress> TInteresses { get; set; }
    }
}
