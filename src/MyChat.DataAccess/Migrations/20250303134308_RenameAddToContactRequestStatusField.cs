using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyChat.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RenameAddToContactRequestStatusField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AddToContactRequestStatus",
                table: "AddToContactRequests",
                newName: "Status");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "AddToContactRequests",
                newName: "AddToContactRequestStatus");
        }
    }
}
