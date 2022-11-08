using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace D3vz_API.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "t_user",
                columns: table => new
                {
                    id_user = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    discriminacao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    nm_usuario = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    ds_email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ds_senha = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    nr_cpf = table.Column<int>(type: "int", nullable: false),
                    dt_nascimento = table.Column<DateTime>(type: "date", nullable: false)
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
                    ds_prof = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false)
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
                name: "t_interesses",
                columns: table => new
                {
                    id_interesses = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    t_aluno_t_user_id_user = table.Column<long>(type: "bigint", nullable: false),
                    ds_interesse = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("t_interesses_pk", x => x.id_interesses);
                    table.ForeignKey(
                        name: "FK_t_interesses_t_aluno_t_aluno_t_user_id_user",
                        column: x => x.t_aluno_t_user_id_user,
                        principalTable: "t_aluno",
                        principalColumn: "t_user_id_user",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_aula",
                columns: table => new
                {
                    id_aula = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    t_aluno_t_user_id_user = table.Column<long>(type: "bigint", nullable: false),
                    t_prof_t_user_id_user = table.Column<long>(type: "bigint", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "t_qualificacoes",
                columns: table => new
                {
                    id_qualificacoes = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    t_prof_t_user_id_user = table.Column<long>(type: "bigint", nullable: false),
                    ds_linguagem = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("t_qualificacoes_pk", x => x.id_qualificacoes);
                    table.ForeignKey(
                        name: "t_qualificacoes_t_prof_fk",
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
                name: "IX_t_interesses_t_aluno_t_user_id_user",
                table: "t_interesses",
                column: "t_aluno_t_user_id_user");

            migrationBuilder.CreateIndex(
                name: "IX_t_qualificacoes_t_prof_t_user_id_user",
                table: "t_qualificacoes",
                column: "t_prof_t_user_id_user");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "t_aula");

            migrationBuilder.DropTable(
                name: "t_interesses");

            migrationBuilder.DropTable(
                name: "t_qualificacoes");

            migrationBuilder.DropTable(
                name: "t_aluno");

            migrationBuilder.DropTable(
                name: "t_prof");

            migrationBuilder.DropTable(
                name: "t_user");
        }
    }
}
