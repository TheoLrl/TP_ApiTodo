using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiTodo.Migrations
{
    /// <inheritdoc />
    public partial class NouveauModeleAgenda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AgendaId",
                table: "Todos",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Agendas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendas", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_AgendaId",
                table: "Todos",
                column: "AgendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Agendas_AgendaId",
                table: "Todos",
                column: "AgendaId",
                principalTable: "Agendas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Agendas_AgendaId",
                table: "Todos");

            migrationBuilder.DropTable(
                name: "Agendas");

            migrationBuilder.DropIndex(
                name: "IX_Todos_AgendaId",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "AgendaId",
                table: "Todos");
        }
    }
}
