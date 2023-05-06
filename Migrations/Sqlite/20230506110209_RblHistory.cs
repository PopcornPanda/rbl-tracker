using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace rbl_tracker.Migrations.Sqlite
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
                keyValue: new Guid("1189efdb-655f-4c22-9f86-f511ebbd0b7c"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("1ec69a97-8e89-474b-a3f4-70f8b1b0cf36"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("25363bd8-9ccd-4cca-9ca8-ee5c3292c10a"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("410d37b5-af93-4a55-950d-7b0ab7c9a509"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("4c851d31-79ed-4718-ad71-574db9b24dec"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("56619a78-7ca1-4a20-aae9-50b5fc609fed"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("5dc4fccf-4ac5-4765-9498-b42cc8562da5"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("61402f86-ce84-4420-8677-0d36869d937d"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("6e12df9a-4f9b-4161-85c5-7d76bc53f929"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("7e3a36da-805f-48a8-8258-6fc12063a69a"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("858b09da-10bf-4500-a492-d7a7466b68d5"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("894eada3-58c2-45fd-9547-c8a26f6ac602"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("8ff63fd1-6eb1-4dc6-b227-e1130f6513b2"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("9a22b604-02d3-42e5-a2ea-30f585cd2426"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("cbe198b7-ecba-4ad4-b46b-8d5aa4ac5792"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("ccd62597-015d-41f6-84d5-fc60bd47dd49"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("d3766e99-258d-418a-9f6a-61c8188e91b5"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("e55e68ce-d168-4758-bb81-cb142ca855f0"));

            migrationBuilder.CreateTable(
                name: "CheckRblHistory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Ip = table.Column<Guid>(type: "TEXT", nullable: true),
                    Domain = table.Column<Guid>(type: "TEXT", nullable: true),
                    Level = table.Column<int>(type: "INTEGER", nullable: true),
                    CheckTime = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckRblHistory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CheckRblHistoryRbl",
                columns: table => new
                {
                    DetectedHistoryId = table.Column<Guid>(type: "TEXT", nullable: false),
                    RblsId = table.Column<Guid>(type: "TEXT", nullable: false)
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
                });

            migrationBuilder.InsertData(
                table: "Rbls",
                columns: new[] { "Id", "Address", "CreateTime", "DelistUrl", "Level", "Name", "Type", "UpdateTime" },
                values: new object[,]
                {
                    { new Guid("0697d05e-c3aa-4a45-99a1-8594298926d6"), "zen.spamhaus.org", 1683370928L, "http://www.spamhaus.org/zen/", 2, "Spamhaus", 0, 1683370928L },
                    { new Guid("23df571e-b231-40be-9469-a662fec580bd"), "bl.spamcop.com", 1683370928L, "https://www.spamcop.net/bl.shtml", 1, "SpamCop", 0, 1683370928L },
                    { new Guid("39f067c1-ea2b-45d9-bc5a-c59d7a7bd645"), "cbl.abuseat.org", 1683370928L, "http://www.abuseat.org", 1, "Abuseeat", 0, 1683370928L },
                    { new Guid("401d080b-dcaa-4430-9574-f1fe933e3283"), "spam.spamrats.com", 1683370928L, "https://www.spamrats.com/lookup.php?ip=ADDRESS", 0, "Spam Rats", 0, 1683370928L },
                    { new Guid("4c3776bf-392f-49bd-8d29-863d23263c52"), "spam.dnsbl.sorbs.net", 1683370928L, "http://www.sorbs.net/lookup.shtml", 3, "Spam Sorbs", 0, 1683370928L },
                    { new Guid("4d01845e-3a78-4a55-8d3c-7c74e0fafc89"), "web.dnsbl.sorbs.net", 1683370928L, "http://www.sorbs.net/lookup.shtml", 3, "Web Sorbs", 1, 1683370928L },
                    { new Guid("6633d91e-a491-45e1-8132-1ee1b4747cc5"), "smtp.dnsbl.sorbs.net", 1683370928L, "http://www.sorbs.net/lookup.shtml", 3, "SMTP Relay Sorbs", 0, 1683370928L },
                    { new Guid("78d8deda-868d-4d76-9ebb-bdc2248278e9"), "psbl.surriel.com", 1683370928L, "https://psbl.org/listing?ip=ADDRESS", 1, "PSBL Surriel", 0, 1683370928L },
                    { new Guid("827b5f2c-f431-41c4-bb2c-b380b2490956"), "spam.dnsbl.anonmails.de", 1683370928L, "https://anonmails.de/dnsbl.php?ip=ADDRESS", 1, "Annonmails.de", 0, 1683370928L },
                    { new Guid("90e367c6-d4bb-4042-893e-22b385cf7f3d"), "ix.dnsbl.manitu.net", 1683370928L, "https://www.nixspam.net/lookup.php?language=en&value=ADDRESS", 1, "Manitu", 0, 1683370928L },
                    { new Guid("93a16c28-7797-411c-92ae-ed3c5552616c"), "b.barracudacentral.org", 1683370928L, "http://barracudacentral.org/rbl", 1, "Barracuda", 0, 1683370928L },
                    { new Guid("94ee4579-570f-4aee-b30a-f6f9f65282d5"), "bl.rspamd.com", 1683370928L, "https://bl.rspamd.com/", 1, "RBL Rspamd", 1, 1683370928L },
                    { new Guid("a46242bd-3d3a-4898-b007-a631fcc7dfd8"), "0spam.fusionzero.com", 1683370928L, "https://check.0spam.org/q/?ipaddr=ADDRESS", 1, "0 Spam", 0, 1683370928L },
                    { new Guid("bc2d1548-442c-4515-a9ff-fab29b4c69ad"), "combined.abuse.ch", 1683370928L, "https://abuse.ch/?p=532", 1, "Abuse.ch", 0, 1683370928L },
                    { new Guid("c14409d1-9347-4fa5-a879-7321f76ef9fd"), "ubl.lashback.com", 1683370928L, "https://blacklist.lashback.com/?ipAddress=ADDRESS", 3, "Lashback", 0, 1683370928L },
                    { new Guid("c4dffcb8-31dd-4d69-a429-083ae6734088"), "ips.backscatterer.org", 1683370928L, "http://www.backscatterer.org/?target=test", 2, "backscatterer", 0, 1683370928L },
                    { new Guid("cce63a65-4665-41a0-8eff-f4b7c1eaf7e9"), "z.mailspike.net", 1683370928L, "https://mailspike.org/iplookup.html", 1, "Mailspike", 0, 1683370928L },
                    { new Guid("f226a88f-c3ad-4282-b0af-3775104ca379"), "url.0spam.org", 1683370928L, "https://check.0spam.org/q/?ipaddr=ADDRESS", 1, "0 Spam", 1, 1683370928L }
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
                keyValue: new Guid("0697d05e-c3aa-4a45-99a1-8594298926d6"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("23df571e-b231-40be-9469-a662fec580bd"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("39f067c1-ea2b-45d9-bc5a-c59d7a7bd645"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("401d080b-dcaa-4430-9574-f1fe933e3283"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("4c3776bf-392f-49bd-8d29-863d23263c52"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("4d01845e-3a78-4a55-8d3c-7c74e0fafc89"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("6633d91e-a491-45e1-8132-1ee1b4747cc5"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("78d8deda-868d-4d76-9ebb-bdc2248278e9"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("827b5f2c-f431-41c4-bb2c-b380b2490956"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("90e367c6-d4bb-4042-893e-22b385cf7f3d"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("93a16c28-7797-411c-92ae-ed3c5552616c"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("94ee4579-570f-4aee-b30a-f6f9f65282d5"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("a46242bd-3d3a-4898-b007-a631fcc7dfd8"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("bc2d1548-442c-4515-a9ff-fab29b4c69ad"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("c14409d1-9347-4fa5-a879-7321f76ef9fd"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("c4dffcb8-31dd-4d69-a429-083ae6734088"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("cce63a65-4665-41a0-8eff-f4b7c1eaf7e9"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("f226a88f-c3ad-4282-b0af-3775104ca379"));

            migrationBuilder.InsertData(
                table: "Rbls",
                columns: new[] { "Id", "Address", "CreateTime", "DelistUrl", "Level", "Name", "Type", "UpdateTime" },
                values: new object[,]
                {
                    { new Guid("1189efdb-655f-4c22-9f86-f511ebbd0b7c"), "bl.rspamd.com", 1683057889L, "https://bl.rspamd.com/", 1, "RBL Rspamd", 1, 1683057889L },
                    { new Guid("1ec69a97-8e89-474b-a3f4-70f8b1b0cf36"), "ips.backscatterer.org", 1683057889L, "http://www.backscatterer.org/?target=test", 2, "backscatterer", 0, 1683057889L },
                    { new Guid("25363bd8-9ccd-4cca-9ca8-ee5c3292c10a"), "bl.spamcop.com", 1683057889L, "https://www.spamcop.net/bl.shtml", 1, "SpamCop", 0, 1683057889L },
                    { new Guid("410d37b5-af93-4a55-950d-7b0ab7c9a509"), "ix.dnsbl.manitu.net", 1683057889L, "https://www.nixspam.net/lookup.php?language=en&value=ADDRESS", 1, "Manitu", 0, 1683057889L },
                    { new Guid("4c851d31-79ed-4718-ad71-574db9b24dec"), "z.mailspike.net", 1683057889L, "https://mailspike.org/iplookup.html", 1, "Mailspike", 0, 1683057889L },
                    { new Guid("56619a78-7ca1-4a20-aae9-50b5fc609fed"), "psbl.surriel.com", 1683057889L, "https://psbl.org/listing?ip=ADDRESS", 1, "PSBL Surriel", 0, 1683057889L },
                    { new Guid("5dc4fccf-4ac5-4765-9498-b42cc8562da5"), "cbl.abuseat.org", 1683057889L, "http://www.abuseat.org", 1, "Abuseeat", 0, 1683057889L },
                    { new Guid("61402f86-ce84-4420-8677-0d36869d937d"), "combined.abuse.ch", 1683057889L, "https://abuse.ch/?p=532", 1, "Abuse.ch", 0, 1683057889L },
                    { new Guid("6e12df9a-4f9b-4161-85c5-7d76bc53f929"), "ubl.lashback.com", 1683057889L, "https://blacklist.lashback.com/?ipAddress=ADDRESS", 3, "Lashback", 0, 1683057889L },
                    { new Guid("7e3a36da-805f-48a8-8258-6fc12063a69a"), "0spam.fusionzero.com", 1683057889L, "https://check.0spam.org/q/?ipaddr=ADDRESS", 1, "0 Spam", 0, 1683057889L },
                    { new Guid("858b09da-10bf-4500-a492-d7a7466b68d5"), "smtp.dnsbl.sorbs.net", 1683057889L, "http://www.sorbs.net/lookup.shtml", 3, "SMTP Relay Sorbs", 0, 1683057889L },
                    { new Guid("894eada3-58c2-45fd-9547-c8a26f6ac602"), "web.dnsbl.sorbs.net", 1683057889L, "http://www.sorbs.net/lookup.shtml", 3, "Web Sorbs", 1, 1683057889L },
                    { new Guid("8ff63fd1-6eb1-4dc6-b227-e1130f6513b2"), "zen.spamhaus.org", 1683057889L, "http://www.spamhaus.org/zen/", 2, "Spamhaus", 0, 1683057889L },
                    { new Guid("9a22b604-02d3-42e5-a2ea-30f585cd2426"), "spam.dnsbl.sorbs.net", 1683057889L, "http://www.sorbs.net/lookup.shtml", 3, "Spam Sorbs", 0, 1683057889L },
                    { new Guid("cbe198b7-ecba-4ad4-b46b-8d5aa4ac5792"), "spam.spamrats.com", 1683057889L, "https://www.spamrats.com/lookup.php?ip=ADDRESS", 0, "Spam Rats", 0, 1683057889L },
                    { new Guid("ccd62597-015d-41f6-84d5-fc60bd47dd49"), "spam.dnsbl.anonmails.de", 1683057889L, "https://anonmails.de/dnsbl.php?ip=ADDRESS", 1, "Annonmails.de", 0, 1683057889L },
                    { new Guid("d3766e99-258d-418a-9f6a-61c8188e91b5"), "b.barracudacentral.org", 1683057889L, "http://barracudacentral.org/rbl", 1, "Barracuda", 0, 1683057889L },
                    { new Guid("e55e68ce-d168-4758-bb81-cb142ca855f0"), "url.0spam.org", 1683057889L, "https://check.0spam.org/q/?ipaddr=ADDRESS", 1, "0 Spam", 1, 1683057889L }
                });
        }
    }
}
