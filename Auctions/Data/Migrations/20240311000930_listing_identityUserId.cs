using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Auctions.Data.Migrations
{
    /// <inheritdoc />
    public partial class listing_identityUserId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Listings_AspNetUsers_IdentityUser",
                table: "Listings");

            migrationBuilder.DropIndex(
                name: "IX_Listings_IdentityUser",
                table: "Listings");

            migrationBuilder.DropColumn(
                name: "IdentityUser",
                table: "Listings");

            migrationBuilder.AlterColumn<string>(
                name: "IdentityUserId",
                table: "Listings",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Listings_IdentityUserId",
                table: "Listings",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Listings_AspNetUsers_IdentityUserId",
                table: "Listings",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Listings_AspNetUsers_IdentityUserId",
                table: "Listings");

            migrationBuilder.DropIndex(
                name: "IX_Listings_IdentityUserId",
                table: "Listings");

            migrationBuilder.AlterColumn<string>(
                name: "IdentityUserId",
                table: "Listings",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "IdentityUser",
                table: "Listings",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Listings_IdentityUser",
                table: "Listings",
                column: "IdentityUser");

            migrationBuilder.AddForeignKey(
                name: "FK_Listings_AspNetUsers_IdentityUser",
                table: "Listings",
                column: "IdentityUser",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
