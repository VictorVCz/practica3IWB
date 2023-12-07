using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class _2stMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProfileId",
                table: "Hobbies",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProfileId",
                table: "Frameworks",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hobbies_ProfileId",
                table: "Hobbies",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Frameworks_ProfileId",
                table: "Frameworks",
                column: "ProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Frameworks_Profiles_ProfileId",
                table: "Frameworks",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Hobbies_Profiles_ProfileId",
                table: "Hobbies",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Frameworks_Profiles_ProfileId",
                table: "Frameworks");

            migrationBuilder.DropForeignKey(
                name: "FK_Hobbies_Profiles_ProfileId",
                table: "Hobbies");

            migrationBuilder.DropIndex(
                name: "IX_Hobbies_ProfileId",
                table: "Hobbies");

            migrationBuilder.DropIndex(
                name: "IX_Frameworks_ProfileId",
                table: "Frameworks");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "Hobbies");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "Frameworks");
        }
    }
}
