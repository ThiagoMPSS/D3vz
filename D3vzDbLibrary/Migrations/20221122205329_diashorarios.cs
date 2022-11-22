using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace D3vzDbLibrary.Migrations
{
    public partial class diashorarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "t_interquali",
                columns: table => new
                {
                    id_interquali = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ds_linguagem = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("t_interquali_pk", x => x.id_interquali);
                });

            migrationBuilder.CreateTable(
                name: "t_user",
                columns: table => new
                {
                    id_user = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    discriminacao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    nm_usuario = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    descricao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    ds_email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ds_senha = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    nr_cpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dt_nascimento = table.Column<DateTime>(type: "date", nullable: false),
                    url_foto = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    googleauth = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("t_user_pk", x => x.id_user);
                });

            migrationBuilder.CreateTable(
                name: "t_aluno",
                columns: table => new
                {
                    t_user_id_user = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("t_aluno_pk", x => x.t_user_id_user);
                    table.ForeignKey(
                        name: "t_aluno_t_user_fk",
                        column: x => x.t_user_id_user,
                        principalTable: "t_user",
                        principalColumn: "id_user");
                });

            migrationBuilder.CreateTable(
                name: "t_prof",
                columns: table => new
                {
                    t_user_id_user = table.Column<long>(type: "bigint", nullable: false),
                    dias = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    horarios = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("t_prof_pk", x => x.t_user_id_user);
                    table.ForeignKey(
                        name: "t_prof_t_user_fk",
                        column: x => x.t_user_id_user,
                        principalTable: "t_user",
                        principalColumn: "id_user");
                });

            migrationBuilder.CreateTable(
                name: "TUser_TInterQuali",
                columns: table => new
                {
                    IdTUser_TInterQuali_Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUser = table.Column<long>(type: "bigint", nullable: false),
                    IdInterQuali = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TUser_TInterQuali", x => x.IdTUser_TInterQuali_Id);
                    table.ForeignKey(
                        name: "TUserTInterQuali_TInterQuali_FK",
                        column: x => x.IdUser,
                        principalTable: "t_interquali",
                        principalColumn: "id_interquali",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "TUserTInterQuali_TUser_FK",
                        column: x => x.IdInterQuali,
                        principalTable: "t_user",
                        principalColumn: "id_user",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_aula",
                columns: table => new
                {
                    id_aula = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    t_aluno_t_user_id_user = table.Column<long>(type: "bigint", nullable: false),
                    t_prof_t_user_id_user = table.Column<long>(type: "bigint", nullable: false),
                    data_hora = table.Column<DateTime>(type: "datetime2", unicode: false, nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aula_tempo = table.Column<int>(type: "int", unicode: false, nullable: false),
                    aula_aceita = table.Column<bool>(type: "bit", unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("t_aula_pk", x => x.id_aula);
                    table.ForeignKey(
                        name: "t_aula_t_aluno_fk",
                        column: x => x.t_aluno_t_user_id_user,
                        principalTable: "t_aluno",
                        principalColumn: "t_user_id_user");
                    table.ForeignKey(
                        name: "t_aula_t_prof_fk",
                        column: x => x.t_prof_t_user_id_user,
                        principalTable: "t_prof",
                        principalColumn: "t_user_id_user");
                });

            migrationBuilder.CreateIndex(
                name: "IX_t_aula_t_aluno_t_user_id_user",
                table: "t_aula",
                column: "t_aluno_t_user_id_user");

            migrationBuilder.CreateIndex(
                name: "IX_t_aula_t_prof_t_user_id_user",
                table: "t_aula",
                column: "t_prof_t_user_id_user");

            migrationBuilder.CreateIndex(
                name: "IX_TUser_TInterQuali_IdInterQuali",
                table: "TUser_TInterQuali",
                column: "IdInterQuali");

            migrationBuilder.CreateIndex(
                name: "IX_TUser_TInterQuali_IdUser",
                table: "TUser_TInterQuali",
                column: "IdUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "t_aula");

            migrationBuilder.DropTable(
                name: "TUser_TInterQuali");

            migrationBuilder.DropTable(
                name: "t_aluno");

            migrationBuilder.DropTable(
                name: "t_prof");

            migrationBuilder.DropTable(
                name: "t_interquali");

            migrationBuilder.DropTable(
                name: "t_user");
        }
    }
}
