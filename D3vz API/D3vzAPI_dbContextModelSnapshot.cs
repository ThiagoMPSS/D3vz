﻿// <auto-generated />
using System;
using D3vz_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace D3vz_API.Migrations
{
    [DbContext(typeof(D3vzAPI_dbContext))]
    partial class D3vzAPI_dbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("D3vz_API.Models.TAluno", b =>
                {
                    b.Property<long>("TUserIdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("t_user_id_user");

                    b.HasKey("TUserIdUser")
                        .HasName("t_aluno_pk");

                    b.ToTable("t_aluno", (string)null);
                });

            modelBuilder.Entity("D3vz_API.Models.TAula", b =>
                {
                    b.Property<long>("IdAula")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id_aula");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("IdAula"), 1L, 1);

                    b.Property<DateTime>("DataHora")
                        .HasColumnType("datetime2");

                    b.Property<long>("TAlunoTUserIdUser")
                        .HasColumnType("bigint")
                        .HasColumnName("t_aluno_t_user_id_user");

                    b.Property<long>("TProfTUserIdUser")
                        .HasColumnType("bigint")
                        .HasColumnName("t_prof_t_user_id_user");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdAula")
                        .HasName("t_aula_pk");

                    b.HasIndex("TAlunoTUserIdUser");

                    b.HasIndex("TProfTUserIdUser");

                    b.ToTable("t_aula", (string)null);
                });

            modelBuilder.Entity("D3vz_API.Models.TInterQuali", b =>
                {
                    b.Property<long>("IdInterQuali")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id_interquali");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("IdInterQuali"), 1L, 1);

                    b.Property<string>("DsLinguagem")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("ds_linguagem");

                    b.HasKey("IdInterQuali")
                        .HasName("t_interquali_pk");

                    b.ToTable("t_interquali", (string)null);
                });

            modelBuilder.Entity("D3vz_API.Models.TProf", b =>
                {
                    b.Property<long>("TUserIdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("t_user_id_user");

                    b.Property<string>("DsProf")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("ds_prof");

                    b.HasKey("TUserIdUser")
                        .HasName("t_prof_pk");

                    b.ToTable("t_prof", (string)null);
                });

            modelBuilder.Entity("D3vz_API.Models.TUser", b =>
                {
                    b.Property<long>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id_user");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("IdUser"), 1L, 1);

                    b.Property<string>("Discriminacao")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("discriminacao");

                    b.Property<string>("DsEmail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("ds_email");

                    b.Property<string>("DsSenha")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("ds_senha");

                    b.Property<DateTime>("DtNascimento")
                        .HasColumnType("date")
                        .HasColumnName("dt_nascimento");

                    b.Property<string>("NmUsuario")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("nm_usuario");

                    b.Property<string>("NrCpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nr_cpf");

                    b.HasKey("IdUser")
                        .HasName("t_user_pk");

                    b.ToTable("t_user", (string)null);
                });

            modelBuilder.Entity("D3vz_API.Models.TUser_TInterQuali", b =>
                {
                    b.Property<long>("IdTUser_TInterQuali_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("IdTUser_TInterQuali_Id"), 1L, 1);

                    b.Property<long>("IdInterQuali")
                        .HasColumnType("bigint");

                    b.Property<long>("IdUser")
                        .HasColumnType("bigint");

                    b.HasKey("IdTUser_TInterQuali_Id");

                    b.HasIndex("IdInterQuali");

                    b.HasIndex("IdUser");

                    b.ToTable("TUser_TInterQuali");
                });

            modelBuilder.Entity("D3vz_API.Models.TAluno", b =>
                {
                    b.HasOne("D3vz_API.Models.TUser", "TUserIdUserNavigation")
                        .WithOne("TAluno")
                        .HasForeignKey("D3vz_API.Models.TAluno", "TUserIdUser")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired()
                        .HasConstraintName("t_aluno_t_user_fk");

                    b.Navigation("TUserIdUserNavigation");
                });

            modelBuilder.Entity("D3vz_API.Models.TAula", b =>
                {
                    b.HasOne("D3vz_API.Models.TAluno", "TAlunoTUserIdUserNavigation")
                        .WithMany("TAulas")
                        .HasForeignKey("TAlunoTUserIdUser")
                        .IsRequired()
                        .HasConstraintName("t_aula_t_aluno_fk");

                    b.HasOne("D3vz_API.Models.TProf", "TProfTUserIdUserNavigation")
                        .WithMany("TAulas")
                        .HasForeignKey("TProfTUserIdUser")
                        .IsRequired()
                        .HasConstraintName("t_aula_t_prof_fk");

                    b.Navigation("TAlunoTUserIdUserNavigation");

                    b.Navigation("TProfTUserIdUserNavigation");
                });

            modelBuilder.Entity("D3vz_API.Models.TProf", b =>
                {
                    b.HasOne("D3vz_API.Models.TUser", "TUserIdUserNavigation")
                        .WithOne("TProf")
                        .HasForeignKey("D3vz_API.Models.TProf", "TUserIdUser")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired()
                        .HasConstraintName("t_prof_t_user_fk");

                    b.Navigation("TUserIdUserNavigation");
                });

            modelBuilder.Entity("D3vz_API.Models.TUser_TInterQuali", b =>
                {
                    b.HasOne("D3vz_API.Models.TUser", "TUser_Navigation")
                        .WithMany("TUser_TInterQuali")
                        .HasForeignKey("IdInterQuali")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("TUserTInterQuali_TUser_FK");

                    b.HasOne("D3vz_API.Models.TInterQuali", "TInterQuali_Navigation")
                        .WithMany("TAluno_TInterQualiNavigation")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("TUserTInterQuali_TInterQuali_FK");

                    b.Navigation("TInterQuali_Navigation");

                    b.Navigation("TUser_Navigation");
                });

            modelBuilder.Entity("D3vz_API.Models.TAluno", b =>
                {
                    b.Navigation("TAulas");
                });

            modelBuilder.Entity("D3vz_API.Models.TInterQuali", b =>
                {
                    b.Navigation("TAluno_TInterQualiNavigation");
                });

            modelBuilder.Entity("D3vz_API.Models.TProf", b =>
                {
                    b.Navigation("TAulas");
                });

            modelBuilder.Entity("D3vz_API.Models.TUser", b =>
                {
                    b.Navigation("TAluno");

                    b.Navigation("TProf");

                    b.Navigation("TUser_TInterQuali");
                });
#pragma warning restore 612, 618
        }
    }
}
