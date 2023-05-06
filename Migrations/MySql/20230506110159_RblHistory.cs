using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace rbl_tracker.Migrations.MySql
{
    /// <inheritdoc />
    public partial class RblHistory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("00afda12-e95f-4eff-b737-be9a931d08d9"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("1761879c-cf4a-4591-8811-454c9b3fcc44"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("22dc3782-c63c-4a07-9c7c-6152bc211c78"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("2a2c789c-917e-4bb0-af49-3383e0a37004"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("2cdf598f-be16-4217-83a2-59e7810db9d9"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("46517e9e-42a8-495b-9ca2-7d41e902dc31"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("5109a007-7372-4cc0-a8ef-0534c74557d0"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("603f0c3c-131a-40d8-9302-61f3a7f0e623"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("629df5cd-f77a-4dcb-a657-6508141ce4c8"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("66f2d01a-eeb8-41bd-9b92-091a0ad4c189"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("757bd216-e6dc-4017-acf0-8aec16bec089"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("86877c8f-d7af-46d1-937f-050c438b48c9"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("908256b4-3d8b-4421-adf4-3c67fdcfc028"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("9a77c2df-294c-44d8-afc1-4cc10942684e"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("bf997e1a-b64e-4c76-a112-cded9df67449"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("c1b4811b-7169-498a-afe2-0f976e6179ae"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("dacdfe20-f6f0-4977-8b39-c201ee393dd3"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("ef7f721e-f3cf-4a45-9aa6-0286ad8ff02c"));

            migrationBuilder.CreateTable(
                name: "CheckRblHistory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Ip = table.Column<Guid>(type: "char(36)", nullable: true),
                    Domain = table.Column<Guid>(type: "char(36)", nullable: true),
                    Level = table.Column<int>(type: "int", nullable: true),
                    CheckTime = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckRblHistory", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CheckRblHistoryRbl",
                columns: table => new
                {
                    DetectedHistoryId = table.Column<Guid>(type: "char(36)", nullable: false),
                    RblsId = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckRblHistoryRbl", x => new { x.DetectedHistoryId, x.RblsId });
                    table.ForeignKey(
                        name: "FK_CheckRblHistoryRbl_CheckRblHistory_DetectedHistoryId",
                        column: x => x.DetectedHistoryId,
                        principalTable: "CheckRblHistory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CheckRblHistoryRbl_Rbls_RblsId",
                        column: x => x.RblsId,
                        principalTable: "Rbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Rbls",
                columns: new[] { "Id", "Address", "CreateTime", "DelistUrl", "Level", "Name", "Type", "UpdateTime" },
                values: new object[,]
                {
                    { new Guid("0b311b29-1410-4be3-a858-432e0987be5d"), "psbl.surriel.com", 1683370919L, "https://psbl.org/listing?ip=ADDRESS", 1, "PSBL Surriel", 0, 1683370919L },
                    { new Guid("17d5e2d0-145a-4cfe-a61d-fc7485e2b2f1"), "ips.backscatterer.org", 1683370919L, "http://www.backscatterer.org/?target=test", 2, "backscatterer", 0, 1683370919L },
                    { new Guid("1a0f4e35-4f0f-4bd8-8877-6574f790178c"), "combined.abuse.ch", 1683370919L, "https://abuse.ch/?p=532", 1, "Abuse.ch", 0, 1683370919L },
                    { new Guid("1d5bad32-989a-4118-82c1-23e147b120d1"), "ubl.lashback.com", 1683370919L, "https://blacklist.lashback.com/?ipAddress=ADDRESS", 3, "Lashback", 0, 1683370919L },
                    { new Guid("24bcd4bb-c8f4-4b37-9b63-dca04d93ea5b"), "url.0spam.org", 1683370919L, "https://check.0spam.org/q/?ipaddr=ADDRESS", 1, "0 Spam", 1, 1683370919L },
                    { new Guid("2cd817be-96f4-4c4e-a84f-7917bac860fa"), "b.barracudacentral.org", 1683370919L, "http://barracudacentral.org/rbl", 1, "Barracuda", 0, 1683370919L },
                    { new Guid("4983eb25-c6d1-4bb9-b6cb-943d67760f3b"), "ix.dnsbl.manitu.net", 1683370919L, "https://www.nixspam.net/lookup.php?language=en&value=ADDRESS", 1, "Manitu", 0, 1683370919L },
                    { new Guid("508dbc91-c323-4d0e-baab-338b1091baaa"), "cbl.abuseat.org", 1683370919L, "http://www.abuseat.org", 1, "Abuseeat", 0, 1683370919L },
                    { new Guid("72c5a937-ecb1-47ca-874e-4866a72a57c3"), "zen.spamhaus.org", 1683370919L, "http://www.spamhaus.org/zen/", 2, "Spamhaus", 0, 1683370919L },
                    { new Guid("731a7ff3-b219-401d-ba1a-778d1391680c"), "spam.dnsbl.sorbs.net", 1683370919L, "http://www.sorbs.net/lookup.shtml", 3, "Spam Sorbs", 0, 1683370919L },
                    { new Guid("7a101bba-52c3-4be5-95af-b507fd21db3e"), "bl.rspamd.com", 1683370919L, "https://bl.rspamd.com/", 1, "RBL Rspamd", 1, 1683370919L },
                    { new Guid("7b909ad2-a210-4c00-8e21-b08a3a14b313"), "web.dnsbl.sorbs.net", 1683370919L, "http://www.sorbs.net/lookup.shtml", 3, "Web Sorbs", 1, 1683370919L },
                    { new Guid("879d89d5-5597-49c9-96eb-ff5140580260"), "0spam.fusionzero.com", 1683370919L, "https://check.0spam.org/q/?ipaddr=ADDRESS", 1, "0 Spam", 0, 1683370919L },
                    { new Guid("a2f11101-d683-421f-b1ef-01cab9a709af"), "bl.spamcop.com", 1683370919L, "https://www.spamcop.net/bl.shtml", 1, "SpamCop", 0, 1683370919L },
                    { new Guid("bc8b957a-eb1c-43bb-81dd-dad9bdd20a54"), "spam.spamrats.com", 1683370919L, "https://www.spamrats.com/lookup.php?ip=ADDRESS", 0, "Spam Rats", 0, 1683370919L },
                    { new Guid("d3e2d986-d8d5-4ed8-a38c-9113142f05ed"), "smtp.dnsbl.sorbs.net", 1683370919L, "http://www.sorbs.net/lookup.shtml", 3, "SMTP Relay Sorbs", 0, 1683370919L },
                    { new Guid("d543bb1b-c40b-4876-bb2b-2d9fefd562e9"), "spam.dnsbl.anonmails.de", 1683370919L, "https://anonmails.de/dnsbl.php?ip=ADDRESS", 1, "Annonmails.de", 0, 1683370919L },
                    { new Guid("fd7c907c-4511-46d3-b2e4-193bace483ae"), "z.mailspike.net", 1683370919L, "https://mailspike.org/iplookup.html", 1, "Mailspike", 0, 1683370919L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CheckRblHistoryRbl_RblsId",
                table: "CheckRblHistoryRbl",
                column: "RblsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CheckRblHistoryRbl");

            migrationBuilder.DropTable(
                name: "CheckRblHistory");

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("0b311b29-1410-4be3-a858-432e0987be5d"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("17d5e2d0-145a-4cfe-a61d-fc7485e2b2f1"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("1a0f4e35-4f0f-4bd8-8877-6574f790178c"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("1d5bad32-989a-4118-82c1-23e147b120d1"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("24bcd4bb-c8f4-4b37-9b63-dca04d93ea5b"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("2cd817be-96f4-4c4e-a84f-7917bac860fa"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("4983eb25-c6d1-4bb9-b6cb-943d67760f3b"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("508dbc91-c323-4d0e-baab-338b1091baaa"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("72c5a937-ecb1-47ca-874e-4866a72a57c3"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("731a7ff3-b219-401d-ba1a-778d1391680c"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("7a101bba-52c3-4be5-95af-b507fd21db3e"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("7b909ad2-a210-4c00-8e21-b08a3a14b313"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("879d89d5-5597-49c9-96eb-ff5140580260"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("a2f11101-d683-421f-b1ef-01cab9a709af"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("bc8b957a-eb1c-43bb-81dd-dad9bdd20a54"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("d3e2d986-d8d5-4ed8-a38c-9113142f05ed"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("d543bb1b-c40b-4876-bb2b-2d9fefd562e9"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("fd7c907c-4511-46d3-b2e4-193bace483ae"));

            migrationBuilder.InsertData(
                table: "Rbls",
                columns: new[] { "Id", "Address", "CreateTime", "DelistUrl", "Level", "Name", "Type", "UpdateTime" },
                values: new object[,]
                {
                    { new Guid("00afda12-e95f-4eff-b737-be9a931d08d9"), "spam.dnsbl.sorbs.net", 1683057882L, "http://www.sorbs.net/lookup.shtml", 3, "Spam Sorbs", 0, 1683057882L },
                    { new Guid("1761879c-cf4a-4591-8811-454c9b3fcc44"), "spam.spamrats.com", 1683057882L, "https://www.spamrats.com/lookup.php?ip=ADDRESS", 0, "Spam Rats", 0, 1683057882L },
                    { new Guid("22dc3782-c63c-4a07-9c7c-6152bc211c78"), "ips.backscatterer.org", 1683057882L, "http://www.backscatterer.org/?target=test", 2, "backscatterer", 0, 1683057882L },
                    { new Guid("2a2c789c-917e-4bb0-af49-3383e0a37004"), "b.barracudacentral.org", 1683057882L, "http://barracudacentral.org/rbl", 1, "Barracuda", 0, 1683057882L },
                    { new Guid("2cdf598f-be16-4217-83a2-59e7810db9d9"), "psbl.surriel.com", 1683057882L, "https://psbl.org/listing?ip=ADDRESS", 1, "PSBL Surriel", 0, 1683057882L },
                    { new Guid("46517e9e-42a8-495b-9ca2-7d41e902dc31"), "spam.dnsbl.anonmails.de", 1683057882L, "https://anonmails.de/dnsbl.php?ip=ADDRESS", 1, "Annonmails.de", 0, 1683057882L },
                    { new Guid("5109a007-7372-4cc0-a8ef-0534c74557d0"), "ubl.lashback.com", 1683057882L, "https://blacklist.lashback.com/?ipAddress=ADDRESS", 3, "Lashback", 0, 1683057882L },
                    { new Guid("603f0c3c-131a-40d8-9302-61f3a7f0e623"), "bl.rspamd.com", 1683057882L, "https://bl.rspamd.com/", 1, "RBL Rspamd", 1, 1683057882L },
                    { new Guid("629df5cd-f77a-4dcb-a657-6508141ce4c8"), "z.mailspike.net", 1683057882L, "https://mailspike.org/iplookup.html", 1, "Mailspike", 0, 1683057882L },
                    { new Guid("66f2d01a-eeb8-41bd-9b92-091a0ad4c189"), "0spam.fusionzero.com", 1683057882L, "https://check.0spam.org/q/?ipaddr=ADDRESS", 1, "0 Spam", 0, 1683057882L },
                    { new Guid("757bd216-e6dc-4017-acf0-8aec16bec089"), "web.dnsbl.sorbs.net", 1683057882L, "http://www.sorbs.net/lookup.shtml", 3, "Web Sorbs", 1, 1683057882L },
                    { new Guid("86877c8f-d7af-46d1-937f-050c438b48c9"), "ix.dnsbl.manitu.net", 1683057882L, "https://www.nixspam.net/lookup.php?language=en&value=ADDRESS", 1, "Manitu", 0, 1683057882L },
                    { new Guid("908256b4-3d8b-4421-adf4-3c67fdcfc028"), "url.0spam.org", 1683057882L, "https://check.0spam.org/q/?ipaddr=ADDRESS", 1, "0 Spam", 1, 1683057882L },
                    { new Guid("9a77c2df-294c-44d8-afc1-4cc10942684e"), "bl.spamcop.com", 1683057882L, "https://www.spamcop.net/bl.shtml", 1, "SpamCop", 0, 1683057882L },
                    { new Guid("bf997e1a-b64e-4c76-a112-cded9df67449"), "smtp.dnsbl.sorbs.net", 1683057882L, "http://www.sorbs.net/lookup.shtml", 3, "SMTP Relay Sorbs", 0, 1683057882L },
                    { new Guid("c1b4811b-7169-498a-afe2-0f976e6179ae"), "combined.abuse.ch", 1683057882L, "https://abuse.ch/?p=532", 1, "Abuse.ch", 0, 1683057882L },
                    { new Guid("dacdfe20-f6f0-4977-8b39-c201ee393dd3"), "zen.spamhaus.org", 1683057882L, "http://www.spamhaus.org/zen/", 2, "Spamhaus", 0, 1683057882L },
                    { new Guid("ef7f721e-f3cf-4a45-9aa6-0286ad8ff02c"), "cbl.abuseat.org", 1683057882L, "http://www.abuseat.org", 1, "Abuseeat", 0, 1683057882L }
                });
        }
    }
}
