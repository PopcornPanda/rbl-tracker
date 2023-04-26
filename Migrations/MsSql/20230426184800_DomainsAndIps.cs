using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rbl_tracker.Migrations.MsSql
{
    /// <inheritdoc />
    public partial class DomainsAndIps : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Domain_Users_OwnerId",
                table: "Domain");

            migrationBuilder.DropForeignKey(
                name: "FK_Ip_Users_OwnerId",
                table: "Ip");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ip",
                table: "Ip");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Domain",
                table: "Domain");

            migrationBuilder.RenameTable(
                name: "Ip",
                newName: "Ips");

            migrationBuilder.RenameTable(
                name: "Domain",
                newName: "Domains");

            migrationBuilder.RenameIndex(
                name: "IX_Ip_OwnerId",
                table: "Ips",
                newName: "IX_Ips_OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Domain_OwnerId",
                table: "Domains",
                newName: "IX_Domains_OwnerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ips",
                table: "Ips",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Domains",
                table: "Domains",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Domains_Users_OwnerId",
                table: "Domains",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ips_Users_OwnerId",
                table: "Ips",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Domains_Users_OwnerId",
                table: "Domains");

            migrationBuilder.DropForeignKey(
                name: "FK_Ips_Users_OwnerId",
                table: "Ips");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ips",
                table: "Ips");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Domains",
                table: "Domains");

            migrationBuilder.RenameTable(
                name: "Ips",
                newName: "Ip");

            migrationBuilder.RenameTable(
                name: "Domains",
                newName: "Domain");

            migrationBuilder.RenameIndex(
                name: "IX_Ips_OwnerId",
                table: "Ip",
                newName: "IX_Ip_OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Domains_OwnerId",
                table: "Domain",
                newName: "IX_Domain_OwnerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ip",
                table: "Ip",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Domain",
                table: "Domain",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Domain_Users_OwnerId",
                table: "Domain",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ip_Users_OwnerId",
                table: "Ip",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
