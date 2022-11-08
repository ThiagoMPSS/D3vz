using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace D3vz_API.Migrations
{
    public partial class Inicial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_t_interesses_t_aluno_t_aluno_t_user_id_user",
                table: "t_interesses");

            migrationBuilder.DropIndex(
                name: "IX_t_interesses_t_aluno_t_user_id_user",
                table: "t_interesses");

            migrationBuilder.DropColumn(
                name: "t_aluno_t_user_id_user",
                table: "t_interesses");

            migrationBuilder.CreateTable(
                name: "TAlunoTInteress",
                columns: table => new
                {
                    TAlunoTUserIdUserNavigationTUserIdUser = table.Column<long>(type: "bigint", nullable: false),
                    TInteressesIdInteresses = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TAlunoTInteress", x => new { x.TAlunoTUserIdUserNavigationTUserIdUser, x.TInteressesIdInteresses });
                    table.ForeignKey(
                        name: "FK_TAlunoTInteress_t_aluno_TAlunoTUserIdUserNavigationTUserIdUser",
                        column: x => x.TAlunoTUserIdUserNavigationTUserIdUser,
                        principalTable: "t_aluno",
                        principalColumn: "t_user_id_user",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TAlunoTInteress_t_interesses_TInteressesIdInteresses",
                        column: x => x.TInteressesIdInteresses,
                        principalTable: "t_interesses",
                        principalColumn: "id_interesses",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TAlunoTInteress_TInteressesIdInteresses",
                table: "TAlunoTInteress",
                column: "TInteressesIdInteresses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TAlunoTInteress");

            migrationBuilder.AddColumn<long>(
                name: "t_aluno_t_user_id_user",
                table: "t_interesses",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_t_interesses_t_aluno_t_user_id_user",
                table: "t_interesses",
                column: "t_aluno_t_user_id_user");

            migrationBuilder.AddForeignKey(
                name: "FK_t_interesses_t_aluno_t_aluno_t_user_id_user",
                table: "t_interesses",
                column: "t_aluno_t_user_id_user",
                principalTable: "t_aluno",
                principalColumn: "t_user_id_user",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
