using Microsoft.EntityFrameworkCore.Migrations;

namespace API_Employment_Project.Migrations
{
    public partial class Database_obj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employment",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Employer_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address_of_employer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Job_role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Job_salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Job_type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employment", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employment");
        }
    }
}
