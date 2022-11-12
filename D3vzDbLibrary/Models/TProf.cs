using System;
using System.Collections.Generic;

namespace D3vzDbLibrary {
    public partial class TProf {
        public TProf() {
            TAulas = new HashSet<TAula>();
        }

        public long TUserIdUser { get; set; } = 0;
        public string DsProf { get; set; } = null!;

        public virtual TUser TUserIdUserNavigation { get; set; } = null!;
        public virtual ICollection<TAula> TAulas { get; set; }
    }
}
