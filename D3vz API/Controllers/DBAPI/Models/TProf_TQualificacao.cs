namespace D3vz_API.Models {
    public class TProf_TQualificacao {

        public long IdTProf_TQualificacao_Id { get; set; }
        public long IdUser { get; set; }
        public long IdQualificacao { get; set; }

        public virtual TProf TProf_Navigation { get; set; } = null!;
        public virtual TQualificacao TQualificacao_Navigation { get; set; } = null!;

    }
}
