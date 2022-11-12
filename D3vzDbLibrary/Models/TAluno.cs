using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace D3vzDbLibrary {
    public partial class TAluno {
        public TAluno() {
            TAulas = new HashSet<TAula>();
        }

        public long TUserIdUser { get; set; } = 0;
        public virtual TUser TUserIdUserNavigation { get; set; } = null!;
        public virtual ICollection<TAula> TAulas { get; set; }
    }
}
