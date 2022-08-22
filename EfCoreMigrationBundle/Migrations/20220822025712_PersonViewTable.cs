using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreMigrationBundle.Migrations
{
    public partial class PersonViewTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE VIEW dbo.PersonView
            AS
            SELECT Id, Name FROM dbo.Persons
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP VIEW dbo.PersonView");
        }
    }
}
