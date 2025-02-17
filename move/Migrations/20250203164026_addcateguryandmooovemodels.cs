using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace move.Migrations
{
    /// <inheritdoc />
    public partial class addcateguryandmooovemodels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categuries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    categuryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categuries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Moooves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    time = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<int>(type: "int", nullable: false),
                    categuryId = table.Column<int>(type: "int", nullable: false),
                    moooveId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moooves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Moooves_Moooves_moooveId",
                        column: x => x.moooveId,
                        principalTable: "Moooves",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Moooves_moooveId",
                table: "Moooves",
                column: "moooveId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "categuries");

            migrationBuilder.DropTable(
                name: "Moooves");
        }
    }
}
