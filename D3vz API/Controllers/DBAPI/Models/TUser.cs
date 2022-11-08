using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace D3vz_API.Models {
    public partial class TUser {

        public TUser() {
            //IdUser = D3vzAPI_dbContext.Instance.TUsers.Count();
        }

        public long IdUser { get; set; } = 0;
        public string Discriminacao { get; set; } = null!;
        public string NmUsuario { get; set; } = null!;
        public string DsEmail { get; set; } = null!;
        public string DsSenha { get; set; } = null!;
        public string NrCpf { get; set; }
        public DateTime DtNascimento { get; set; }

        [JsonIgnore]
        public virtual TAluno? TAluno { get; set; }
        [JsonIgnore]
        public virtual TProf? TProf { get; set; }

    }
}
