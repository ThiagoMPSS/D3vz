using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace D3vzDbLibrary {
    public partial class TUser {

        public TUser() {
            //IdUser = D3vzAPI_dbContext.Instance.TUsers.Count();
            TUser_TInterQuali = new HashSet<TUser_TInterQuali>();
        }

        public long IdUser { get; set; } = 0;
        public string Discriminacao { get; set; } = null!;
        public string NmUsuario { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public string DsEmail { get; set; } = null!;
        public string DsSenha { get; set; } = "";
        public string NrCpf { get; set; } = "";
        public DateTime DtNascimento { get; set; }
        public string? UrlFoto { get; set; } = null;
        public string? GoogleAuth { get; set; } = null;

        [JsonIgnore]
        public virtual TAluno? TAluno { get; set; }
        [JsonIgnore]
        public virtual TProf? TProf { get; set; }

        public virtual ICollection<TUser_TInterQuali> TUser_TInterQuali { get; set; }

    }
}
