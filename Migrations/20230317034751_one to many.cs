using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMSApp.Migrations
{
    /// <inheritdoc />
    public partial class onetomany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TodoId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Todos",
                columns: table => new
                {
                    TodoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todos", x => x.TodoId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_TodoId",
                table: "Students",
                column: "TodoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Todos_TodoId",
                table: "Students",
                column: "TodoId",
                principalTable: "Todos",
                principalColumn: "TodoId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Todos_TodoId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "Todos");

            migrationBuilder.DropIndex(
                name: "IX_Students_TodoId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "TodoId",
                table: "Students");
        }
    }
}
