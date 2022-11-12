namespace D3vzDbLibrary {
    public class TUser_TInterQuali {

        public long IdTUser_TInterQuali_Id { get; set; }
        public long IdUser { get; set; }
        public long IdInterQuali { get; set; }

        public virtual TUser TUser_Navigation { get; set; } = null!;
        public virtual TInterQuali TInterQuali_Navigation { get; set; } = null!;

    }
}
