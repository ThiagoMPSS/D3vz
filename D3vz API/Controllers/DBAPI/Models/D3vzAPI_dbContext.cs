using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace D3vz_API.Models {
    public partial class D3vzAPI_dbContext : DbContext {

        //private static D3vzAPI_dbContext? _Instance;
        //public static D3vzAPI_dbContext Instance => _Instance ??= new D3vzAPI_dbContext();

        //private D3vzAPI_dbContext() { }


        //public D3vzAPI_dbContext(DbContextOptions<D3vzAPI_dbContext> options)
        //    : base(options) {
        //}

        public virtual DbSet<TAluno> TAlunos { get; set; } = null!;
        public virtual DbSet<TAula> TAulas { get; set; } = null!;
        public virtual DbSet<TInteress> TInteresses { get; set; } = null!;
        public virtual DbSet<TProf> TProfs { get; set; } = null!;
        public virtual DbSet<TQualificacao> TQualificacoes { get; set; } = null!;
        public virtual DbSet<TUser> TUsers { get; set; } = null!;
        public virtual DbSet<TAluno_TInteress> TAluno_TInteress { get; set; } = null!;
        public virtual DbSet<TProf_TQualificacao> TProf_TQualificacao { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:d3vz-apidbserver.database.windows.net,1433;Initial Catalog=D3vz API_db;Persist Security Info=False;User ID=thiago;Password=Leuztf160412;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<TAluno>(entity => {
                entity.HasKey(e => e.TUserIdUser)
                    .HasName("t_aluno_pk");

                entity.ToTable("t_aluno");

                entity.Property(e => e.TUserIdUser)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("t_user_id_user");

                entity.HasOne(d => d.TUserIdUserNavigation)
                    .WithOne(p => p.TAluno)
                    .HasForeignKey<TAluno>(d => d.TUserIdUser)
                    .OnDelete(DeleteBehavior.ClientCascade)
                    .HasConstraintName("t_aluno_t_user_fk");
            });

            modelBuilder.Entity<TAula>(entity => {
                entity.HasKey(e => e.IdAula)
                    .HasName("t_aula_pk");

                entity.ToTable("t_aula");

                entity.Property(e => e.IdAula)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_aula");

                entity.Property(e => e.TAlunoTUserIdUser).HasColumnName("t_aluno_t_user_id_user");

                entity.Property(e => e.TProfTUserIdUser).HasColumnName("t_prof_t_user_id_user");

                entity.HasOne(d => d.TAlunoTUserIdUserNavigation)
                    .WithMany(p => p.TAulas)
                    .HasForeignKey(d => d.TAlunoTUserIdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("t_aula_t_aluno_fk");

                entity.HasOne(d => d.TProfTUserIdUserNavigation)
                    .WithMany(p => p.TAulas)
                    .HasForeignKey(d => d.TProfTUserIdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("t_aula_t_prof_fk");
            });

            modelBuilder.Entity<TInteress>(entity => {
                entity.HasKey(e => e.IdInteresses)
                    .HasName("t_interesses_pk");

                entity.ToTable("t_interesses");

                entity.Property(e => e.IdInteresses)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_interesses");

                entity.Property(e => e.DsInteresse)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ds_interesse");
            });

            modelBuilder.Entity<TProf>(entity => {
                entity.HasKey(e => e.TUserIdUser)
                    .HasName("t_prof_pk");

                entity.ToTable("t_prof");

                entity.Property(e => e.TUserIdUser)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("t_user_id_user");

                entity.Property(e => e.DsProf)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ds_prof");

                entity.HasOne(d => d.TUserIdUserNavigation)
                    .WithOne(p => p.TProf)
                    .HasForeignKey<TProf>(d => d.TUserIdUser)
                    .OnDelete(DeleteBehavior.ClientCascade)
                    .HasConstraintName("t_prof_t_user_fk");
            });

            modelBuilder.Entity<TQualificacao>(entity => {
                entity.HasKey(e => e.IdQualificacoes)
                    .HasName("t_qualificacoes_pk");

                entity.ToTable("t_qualificacoes");

                entity.Property(e => e.IdQualificacoes)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_qualificacoes");

                entity.Property(e => e.DsLinguagem)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ds_linguagem");
            });

            modelBuilder.Entity<TUser>(entity => {
                entity.HasKey(e => e.IdUser)
                    .HasName("t_user_pk");

                entity.ToTable("t_user");

                entity.Property(e => e.IdUser)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_user");

                entity.Property(e => e.Discriminacao)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("discriminacao");

                entity.Property(e => e.DsEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ds_email");

                entity.Property(e => e.DsSenha)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ds_senha");

                entity.Property(e => e.DtNascimento)
                    .HasColumnType("date")
                    .HasColumnName("dt_nascimento");

                entity.Property(e => e.NmUsuario)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nm_usuario");

                entity.Property(e => e.NrCpf).HasColumnName("nr_cpf");
            });

            modelBuilder.Entity<TAluno_TInteress>(entity => {
                entity.HasKey(e => e.IdTAluno_TInteress_Id);
                entity.Property(e => e.IdTAluno_TInteress_Id)
                    .ValueGeneratedOnAdd();

                entity.HasOne(e => e.TAluno_Navigation).WithMany(e => e.TAluno_TInteresses)
                    .HasForeignKey(e => e.IdInteress)
                    .HasConstraintName("TAlunoTInteress_TAluno_FK");

                entity.HasOne(e => e.TInteress_Navigation).WithMany(e => e.TAluno_TInteressNavigation)
                    .HasForeignKey(e => e.IdUser)
                    .HasConstraintName("TAlunoTInteress_TInteress_FK");

            });

            modelBuilder.Entity<TProf_TQualificacao>(entity => {
                entity.HasKey(e => e.IdTProf_TQualificacao_Id);
                entity.Property(e => e.IdTProf_TQualificacao_Id)
                    .ValueGeneratedOnAdd();

                entity.HasOne(e => e.TProf_Navigation).WithMany(e => e.TProf_TQualificacao)
                    .HasForeignKey(e => e.IdQualificacao)
                    .HasConstraintName("TProfTQualificacao_TProf_FK");

                entity.HasOne(e => e.TQualificacao_Navigation).WithMany(e => e.TProf_TQualificacaoNavigation)
                    .HasForeignKey(e => e.IdUser)
                    .HasConstraintName("TProfTQualificacao_TQualificacao_FK");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
