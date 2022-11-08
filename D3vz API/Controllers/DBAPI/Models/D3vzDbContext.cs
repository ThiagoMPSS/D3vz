//using System;
//using System.Collections.Generic;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata;

//namespace D3vz_API.Models {
//    public partial class D3vzDbContext : DbContext {

//        private static D3vzDbContext? _Instance;
//        public static D3vzDbContext Instance => _Instance ??= new D3vzDbContext();

//        private D3vzDbContext() { }

//        public virtual DbSet<TAluno> TAlunos { get; set; } = null!;
//        public virtual DbSet<TAula> TAulas { get; set; } = null!;
//        public virtual DbSet<TInteress> TInteresses { get; set; } = null!;
//        public virtual DbSet<TProf> TProfs { get; set; } = null!;
//        public virtual DbSet<TQualificaco> TQualificacoes { get; set; } = null!;
//        public virtual DbSet<TUser> TUsers { get; set; } = null!;

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
//            if (!optionsBuilder.IsConfigured) {
//                optionsBuilder.UseSqlServer("Server=tcp:d3vz-apidbserver.database.windows.net,1433;Initial Catalog=D3vz API_db;Persist Security Info=False;User ID=thiago;Password=Leuztf160412;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
//            }
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder) {

//            modelBuilder.Entity<TUser>(entity => {
//                entity.HasKey(e => e.IdUser);
//                entity.Property(e => e.IdUser)
//                    .ValueGeneratedOnAdd()
//                    .HasDefaultValue(0);

//                entity.ToTable("t_user");

//                entity.HasOne(e => e.TAluno).WithOne(e => e.TUserIdUserNavigation);
//                entity.HasOne(e => e.TProf).WithOne(e => e.TUserIdUserNavigation);
//            });

//            modelBuilder.Entity<TAluno>(entity => {
//                entity.HasNoKey();

//                entity.HasOne(e => e.TUserIdUserNavigation).WithOne(e => e.TAluno);
//                entity.HasMany(e => e.TAulas).WithOne(e => e.TAlunoTUserIdUserNavigation);
//                entity.HasMany(e => e.TInteresses).WithOne(e => e.TAlunoTUserIdUserNavigation);
//            });

//            modelBuilder.Entity<TProf>(entity => {
//                entity.HasNoKey();

//                entity.HasOne(e => e.TUserIdUserNavigation).WithOne(e => e.TProf);
//                entity.HasMany(e => e.TAulas).WithOne(e => e.TProfTUserIdUserNavigation);
//                entity.HasMany(e => e.TQualificacos).WithOne(e => e.TProfTUserIdUserNavigation);
//            });

//            modelBuilder.Entity<TAula>(entity => {
//                entity.HasKey(e => e.IdAula);

//                entity.HasOne(e => e.TAlunoTUserIdUserNavigation).WithMany(e => e.TAulas);
//                entity.HasOne(e => e.TProfTUserIdUserNavigation).WithMany(e => e.TAulas);
//            });


//            OnModelCreatingPartial(modelBuilder);
//        }

//        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//    }
//}
