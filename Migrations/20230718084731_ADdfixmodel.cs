using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThucTapMVC.Migrations
{
    /// <inheritdoc />
    public partial class ADdfixmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CompanyPhone",
                table: "Contacts",
                newName: "CompanyName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "Contacts",
                newName: "CompanyPhone");
        }
    }
}
