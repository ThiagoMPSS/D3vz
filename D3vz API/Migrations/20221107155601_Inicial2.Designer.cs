﻿// <auto-generated />
using System;
using D3vz_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace D3vz_API.Migrations
{
    [DbContext(typeof(D3vzAPI_dbContext))]
    [Migration("20221107155601_Inicial2")]
    partial class Inicial2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<long>("TAlunoTUserIdUser")
                        .HasColumnType("bigint")
                        .HasColumnName("t_aluno_t_user_id_user");

                    b.Property<long>("TProfTUserIdUser")
                        .HasColumnType("bigint")
                        .HasColumnName("t_prof_t_user_id_user");

                    b.HasKey("IdAula")
                        .HasName("t_aula_pk");

                    b.HasIndex("TAlunoTUserIdUser");

                    b.HasIndex("TProfTUserIdUser");

                    b.ToTable("t_aula", (string)null);
                });

            modelBuilder.Entity("D3vz_API.Models.TInteress", b =>
                {
                    b.Property<long>("IdInteresses")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id_interesses");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("IdInteresses"), 1L, 1);

                    b.Property<string>("DsInteresse")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("ds_interesse");

                    b.Property<long>("TAlunoTUserIdUser")
                        .HasColumnType("bigint")
                        .HasColumnName("t_aluno_t_user_id_user");

                    b.HasKey("IdInteresses")
                        .HasName("t_interesses_pk");

                    b.HasIndex("TAlunoTUserIdUser");

                    b.ToTable("t_interesses", (string)null);
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

            modelBuilder.Entity("D3vz_API.Models.TQualificaco", b =>
                {
                    b.Property<long>("IdQualificacoes")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id_qualificacoes");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("IdQualificacoes"), 1L, 1);

                    b.Property<string>("DsLinguagem")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("ds_linguagem");

                    b.Property<long>("TProfTUserIdUser")
                        .HasColumnType("bigint")
                        .HasColumnName("t_prof_t_user_id_user");

                    b.HasKey("IdQualificacoes")
                        .HasName("t_qualificacoes_pk");

                    b.HasIndex("TProfTUserIdUser");

                    b.ToTable("t_qualificacoes", (string)null);
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

            modelBuilder.Entity("D3vz_API.Models.TAluno", b =>
                {
                    b.HasOne("D3vz_API.Models.TUser", "TUserIdUserNavigation")
                        .WithOne("TAluno")
                        .HasForeignKey("D3vz_API.Models.TAluno", "TUserIdUser")
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

            modelBuilder.Entity("D3vz_API.Models.TInteress", b =>
                {
                    b.HasOne("D3vz_API.Models.TAluno", "TAlunoTUserIdUserNavigation")
                        .WithMany("TInteresses")
                        .HasForeignKey("TAlunoTUserIdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TAlunoTUserIdUserNavigation");
                });

            modelBuilder.Entity("D3vz_API.Models.TProf", b =>
                {
                    b.HasOne("D3vz_API.Models.TUser", "TUserIdUserNavigation")
                        .WithOne("TProf")
                        .HasForeignKey("D3vz_API.Models.TProf", "TUserIdUser")
                        .IsRequired()
                        .HasConstraintName("t_prof_t_user_fk");

                    b.Navigation("TUserIdUserNavigation");
                });

            modelBuilder.Entity("D3vz_API.Models.TQualificaco", b =>
                {
                    b.HasOne("D3vz_API.Models.TProf", "TProfTUserIdUserNavigation")
                        .WithMany("TQualificacos")
                        .HasForeignKey("TProfTUserIdUser")
                        .IsRequired()
                        .HasConstraintName("t_qualificacoes_t_prof_fk");

                    b.Navigation("TProfTUserIdUserNavigation");
                });

            modelBuilder.Entity("D3vz_API.Models.TAluno", b =>
                {
                    b.Navigation("TAulas");

                    b.Navigation("TInteresses");
                });

            modelBuilder.Entity("D3vz_API.Models.TProf", b =>
                {
                    b.Navigation("TAulas");

                    b.Navigation("TQualificacos");
                });

            modelBuilder.Entity("D3vz_API.Models.TUser", b =>
                {
                    b.Navigation("TAluno");

                    b.Navigation("TProf");
                });
#pragma warning restore 612, 618
        }
    }
}
