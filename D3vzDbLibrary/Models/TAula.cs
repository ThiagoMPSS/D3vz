using System;
using System.Collections.Generic;

namespace D3vzDbLibrary {
    public partial class TAula {
        public long IdAula { get; set; } = 0;
        public long TAlunoTUserIdUser { get; set; }
        public long TProfTUserIdUser { get; set; }
        public DateTime DataHora { get; set; }
        public string URL { get; set; } = "";
        public int TempoMinutos { get; set; } = 60;
        public bool Aceito { get; set; } = false;

        public virtual TAluno TAlunoTUserIdUserNavigation { get; set; } = null!;
        public virtual TProf TProfTUserIdUserNavigation { get; set; } = null!;
    }
}
