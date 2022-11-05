using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace D3vz_API.Models
{
    public partial class TUser {
        public long IdUser { get; set; } = 0;
        public string Discriminacao { get; set; } = null!;
        public string NmUsuario { get; set; } = null!;
        public string DsEmail { get; set; } = null!;
        public string DsSenha { get; set; } = null!;
        public int NrCpf { get; set; }
        public DateTime DtNascimento { get; set; }

        public virtual TAluno? TAluno { get; set; }
        public virtual TProf? TProf { get; set; }
    }
}
