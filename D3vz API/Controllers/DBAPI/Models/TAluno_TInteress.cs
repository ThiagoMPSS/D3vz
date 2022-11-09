namespace D3vz_API.Models {
    public class TAluno_TInteress {

        public long IdTAluno_TInteress_Id { get; set; }
        public long IdUser { get; set; }
        public long IdInteress { get; set; }

        public virtual TAluno TAluno_Navigation { get; set; } = null!;
        public virtual TInteress TInteress_Navigation { get; set; } = null!;

    }
}
