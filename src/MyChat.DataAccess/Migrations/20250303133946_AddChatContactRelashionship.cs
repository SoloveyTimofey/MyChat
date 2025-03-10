using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyChat.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddChatContactRelashionship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ContactId",
                table: "Chats",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Chats_ContactId",
                table: "Chats",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_Contacts_ContactId",
                table: "Chats",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chats_Contacts_ContactId",
                table: "Chats");

            migrationBuilder.DropIndex(
                name: "IX_Chats_ContactId",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "Chats");
        }
    }
}
