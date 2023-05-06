using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace rbl_tracker.Migrations.PostgreSql
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
                keyValue: new Guid("00872c29-f6dc-44e5-911d-b577224cafcb"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("16e976bd-3685-4a77-8c7e-65848fe88b96"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("1bee07c1-4823-40a7-aa7c-42a0add5a459"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("2878c8ec-231e-4222-98fb-551cd2036392"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("35a05f7e-ff72-4a5b-a1be-6266f3dac968"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("3b180774-bc85-4b4f-b2c9-3283a92d7552"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("43531f76-b08d-4c91-8f2e-835254d8aacf"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("4537a36c-9a2c-4d04-837b-47683e265bee"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("4e505ee8-8e71-446e-8e4f-bf86c1e6aa20"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("73661c5c-5ce0-4906-a55b-b40baf17244b"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("9156cb7e-fad2-443b-80d3-fd56b39783e1"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("9aed00c2-bb77-40eb-ab4f-68a44bde02a0"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("a4061957-f454-41b4-83a2-e0efe0fc6a1e"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("b1e9323f-96e8-4551-ab2d-cf428d6146ce"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("b2e7a88f-b654-4e56-9f10-4502b26112cf"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("bdcce912-0759-4ef9-a3fe-68f30295e424"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("e022aa9f-4ef1-44ae-bd79-96df797c491d"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("ed2ca11e-379b-465c-af77-c27af459e4e8"));

            migrationBuilder.CreateTable(
                name: "CheckRblHistory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Ip = table.Column<Guid>(type: "uuid", nullable: true),
                    Domain = table.Column<Guid>(type: "uuid", nullable: true),
                    Level = table.Column<int>(type: "integer", nullable: true),
                    CheckTime = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckRblHistory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CheckRblHistoryRbl",
                columns: table => new
                {
                    DetectedHistoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    RblsId = table.Column<Guid>(type: "uuid", nullable: false)
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
                    { new Guid("0025b7f4-f8be-44dc-b8c1-3f270caa6301"), "ubl.lashback.com", 1683370924L, "https://blacklist.lashback.com/?ipAddress=ADDRESS", 3, "Lashback", 0, 1683370924L },
                    { new Guid("087041b0-a036-4c99-8511-dcfdcd3de307"), "ips.backscatterer.org", 1683370924L, "http://www.backscatterer.org/?target=test", 2, "backscatterer", 0, 1683370924L },
                    { new Guid("0f0377ad-639c-46d0-ad58-2f3bb3a570fc"), "bl.rspamd.com", 1683370924L, "https://bl.rspamd.com/", 1, "RBL Rspamd", 1, 1683370924L },
                    { new Guid("19b52b52-a9f1-4923-91fb-6f27e2a220dd"), "cbl.abuseat.org", 1683370924L, "http://www.abuseat.org", 1, "Abuseeat", 0, 1683370924L },
                    { new Guid("23efd8bf-a102-448d-930a-ff72c15db2ce"), "zen.spamhaus.org", 1683370924L, "http://www.spamhaus.org/zen/", 2, "Spamhaus", 0, 1683370924L },
                    { new Guid("36e6472f-70c6-4dbb-87d1-c455a7c72618"), "0spam.fusionzero.com", 1683370924L, "https://check.0spam.org/q/?ipaddr=ADDRESS", 1, "0 Spam", 0, 1683370924L },
                    { new Guid("43acd940-f3d2-468b-a64d-26594a84d9b2"), "z.mailspike.net", 1683370924L, "https://mailspike.org/iplookup.html", 1, "Mailspike", 0, 1683370924L },
                    { new Guid("5955fd9b-3061-4f30-a664-094b5bbf08f8"), "web.dnsbl.sorbs.net", 1683370924L, "http://www.sorbs.net/lookup.shtml", 3, "Web Sorbs", 1, 1683370924L },
                    { new Guid("62797da9-23b7-4312-a3af-5bc227f1083f"), "spam.dnsbl.sorbs.net", 1683370924L, "http://www.sorbs.net/lookup.shtml", 3, "Spam Sorbs", 0, 1683370924L },
                    { new Guid("68c00cc7-4f2d-4ab3-bf44-6c47001cb90e"), "url.0spam.org", 1683370924L, "https://check.0spam.org/q/?ipaddr=ADDRESS", 1, "0 Spam", 1, 1683370924L },
                    { new Guid("8aa9306d-999d-45d4-b6a2-1d967fd4e0eb"), "b.barracudacentral.org", 1683370924L, "http://barracudacentral.org/rbl", 1, "Barracuda", 0, 1683370924L },
                    { new Guid("8e92e3aa-190f-461b-9dae-9e213a1cc589"), "bl.spamcop.com", 1683370924L, "https://www.spamcop.net/bl.shtml", 1, "SpamCop", 0, 1683370924L },
                    { new Guid("b641f297-69f7-42e1-8a10-9858b1a620fe"), "spam.dnsbl.anonmails.de", 1683370924L, "https://anonmails.de/dnsbl.php?ip=ADDRESS", 1, "Annonmails.de", 0, 1683370924L },
                    { new Guid("b75a1abc-e861-4df5-b415-bfd38afe6a60"), "smtp.dnsbl.sorbs.net", 1683370924L, "http://www.sorbs.net/lookup.shtml", 3, "SMTP Relay Sorbs", 0, 1683370924L },
                    { new Guid("cc1ac331-bb09-4aab-96ba-7ff34bb31337"), "psbl.surriel.com", 1683370924L, "https://psbl.org/listing?ip=ADDRESS", 1, "PSBL Surriel", 0, 1683370924L },
                    { new Guid("e466ba96-f9bb-455f-b43b-be7284df9487"), "combined.abuse.ch", 1683370924L, "https://abuse.ch/?p=532", 1, "Abuse.ch", 0, 1683370924L },
                    { new Guid("fa77c3f3-473c-43f7-a08d-8f346390acdb"), "ix.dnsbl.manitu.net", 1683370924L, "https://www.nixspam.net/lookup.php?language=en&value=ADDRESS", 1, "Manitu", 0, 1683370924L },
                    { new Guid("fd266871-a755-4f2e-85ea-6b6793c01470"), "spam.spamrats.com", 1683370924L, "https://www.spamrats.com/lookup.php?ip=ADDRESS", 0, "Spam Rats", 0, 1683370924L }
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
                keyValue: new Guid("0025b7f4-f8be-44dc-b8c1-3f270caa6301"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("087041b0-a036-4c99-8511-dcfdcd3de307"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("0f0377ad-639c-46d0-ad58-2f3bb3a570fc"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("19b52b52-a9f1-4923-91fb-6f27e2a220dd"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("23efd8bf-a102-448d-930a-ff72c15db2ce"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("36e6472f-70c6-4dbb-87d1-c455a7c72618"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("43acd940-f3d2-468b-a64d-26594a84d9b2"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("5955fd9b-3061-4f30-a664-094b5bbf08f8"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("62797da9-23b7-4312-a3af-5bc227f1083f"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("68c00cc7-4f2d-4ab3-bf44-6c47001cb90e"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("8aa9306d-999d-45d4-b6a2-1d967fd4e0eb"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("8e92e3aa-190f-461b-9dae-9e213a1cc589"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("b641f297-69f7-42e1-8a10-9858b1a620fe"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("b75a1abc-e861-4df5-b415-bfd38afe6a60"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("cc1ac331-bb09-4aab-96ba-7ff34bb31337"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("e466ba96-f9bb-455f-b43b-be7284df9487"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("fa77c3f3-473c-43f7-a08d-8f346390acdb"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("fd266871-a755-4f2e-85ea-6b6793c01470"));

            migrationBuilder.InsertData(
                table: "Rbls",
                columns: new[] { "Id", "Address", "CreateTime", "DelistUrl", "Level", "Name", "Type", "UpdateTime" },
                values: new object[,]
                {
                    { new Guid("00872c29-f6dc-44e5-911d-b577224cafcb"), "ips.backscatterer.org", 1683057886L, "http://www.backscatterer.org/?target=test", 2, "backscatterer", 0, 1683057886L },
                    { new Guid("16e976bd-3685-4a77-8c7e-65848fe88b96"), "ix.dnsbl.manitu.net", 1683057886L, "https://www.nixspam.net/lookup.php?language=en&value=ADDRESS", 1, "Manitu", 0, 1683057886L },
                    { new Guid("1bee07c1-4823-40a7-aa7c-42a0add5a459"), "web.dnsbl.sorbs.net", 1683057886L, "http://www.sorbs.net/lookup.shtml", 3, "Web Sorbs", 1, 1683057886L },
                    { new Guid("2878c8ec-231e-4222-98fb-551cd2036392"), "ubl.lashback.com", 1683057886L, "https://blacklist.lashback.com/?ipAddress=ADDRESS", 3, "Lashback", 0, 1683057886L },
                    { new Guid("35a05f7e-ff72-4a5b-a1be-6266f3dac968"), "spam.dnsbl.sorbs.net", 1683057886L, "http://www.sorbs.net/lookup.shtml", 3, "Spam Sorbs", 0, 1683057886L },
                    { new Guid("3b180774-bc85-4b4f-b2c9-3283a92d7552"), "spam.dnsbl.anonmails.de", 1683057886L, "https://anonmails.de/dnsbl.php?ip=ADDRESS", 1, "Annonmails.de", 0, 1683057886L },
                    { new Guid("43531f76-b08d-4c91-8f2e-835254d8aacf"), "b.barracudacentral.org", 1683057886L, "http://barracudacentral.org/rbl", 1, "Barracuda", 0, 1683057886L },
                    { new Guid("4537a36c-9a2c-4d04-837b-47683e265bee"), "zen.spamhaus.org", 1683057886L, "http://www.spamhaus.org/zen/", 2, "Spamhaus", 0, 1683057886L },
                    { new Guid("4e505ee8-8e71-446e-8e4f-bf86c1e6aa20"), "0spam.fusionzero.com", 1683057886L, "https://check.0spam.org/q/?ipaddr=ADDRESS", 1, "0 Spam", 0, 1683057886L },
                    { new Guid("73661c5c-5ce0-4906-a55b-b40baf17244b"), "bl.spamcop.com", 1683057886L, "https://www.spamcop.net/bl.shtml", 1, "SpamCop", 0, 1683057886L },
                    { new Guid("9156cb7e-fad2-443b-80d3-fd56b39783e1"), "smtp.dnsbl.sorbs.net", 1683057886L, "http://www.sorbs.net/lookup.shtml", 3, "SMTP Relay Sorbs", 0, 1683057886L },
                    { new Guid("9aed00c2-bb77-40eb-ab4f-68a44bde02a0"), "url.0spam.org", 1683057886L, "https://check.0spam.org/q/?ipaddr=ADDRESS", 1, "0 Spam", 1, 1683057886L },
                    { new Guid("a4061957-f454-41b4-83a2-e0efe0fc6a1e"), "psbl.surriel.com", 1683057886L, "https://psbl.org/listing?ip=ADDRESS", 1, "PSBL Surriel", 0, 1683057886L },
                    { new Guid("b1e9323f-96e8-4551-ab2d-cf428d6146ce"), "z.mailspike.net", 1683057886L, "https://mailspike.org/iplookup.html", 1, "Mailspike", 0, 1683057886L },
                    { new Guid("b2e7a88f-b654-4e56-9f10-4502b26112cf"), "spam.spamrats.com", 1683057886L, "https://www.spamrats.com/lookup.php?ip=ADDRESS", 0, "Spam Rats", 0, 1683057886L },
                    { new Guid("bdcce912-0759-4ef9-a3fe-68f30295e424"), "cbl.abuseat.org", 1683057886L, "http://www.abuseat.org", 1, "Abuseeat", 0, 1683057886L },
                    { new Guid("e022aa9f-4ef1-44ae-bd79-96df797c491d"), "combined.abuse.ch", 1683057886L, "https://abuse.ch/?p=532", 1, "Abuse.ch", 0, 1683057886L },
                    { new Guid("ed2ca11e-379b-465c-af77-c27af459e4e8"), "bl.rspamd.com", 1683057886L, "https://bl.rspamd.com/", 1, "RBL Rspamd", 1, 1683057886L }
                });
        }
    }
}
