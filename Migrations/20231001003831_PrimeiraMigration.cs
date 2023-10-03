using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstudoCRUDAPI.Migrations
{
    /// <inheritdoc />
    public partial class PrimeiraMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ECVs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ECVs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vistorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OS = table.Column<int>(type: "int", nullable: false),
                    nomeVistoriador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    statusVistoria = table.Column<int>(type: "int", nullable: false),
                    ECVId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vistorias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vistorias_ECVs_ECVId",
                        column: x => x.ECVId,
                        principalTable: "ECVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vistorias_ECVId",
                table: "Vistorias",
                column: "ECVId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vistorias");

            migrationBuilder.DropTable(
                name: "ECVs");
        }
    }
}
