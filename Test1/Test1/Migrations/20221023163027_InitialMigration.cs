using Microsoft.EntityFrameworkCore.Migrations;

namespace Test1.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    customerId = table.Column<int>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    surName = table.Column<string>(nullable: true),
                    balance = table.Column<double>(nullable: false),
                    transactions = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
