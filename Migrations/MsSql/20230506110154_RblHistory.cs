using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace rbl_tracker.Migrations.MsSql
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
                keyValue: new Guid("31f8e2cf-5400-4405-b5d7-a6d3aa450123"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("3356179c-e410-4c1f-956b-d4e46f1086af"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("3cf250b2-5b9f-4683-b1b5-5d8998835061"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("43b31cc1-e403-437e-8fa1-cd090952133f"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("46f7816a-2e49-450c-8d3a-2dff162c0762"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("51267343-aed9-402d-b681-4a27dde2ee66"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("5b3acc3d-67e0-407a-b72b-a4c4776fe0dd"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("5be3db5d-79be-4b01-9c81-c8f52dd04c00"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("5f254a79-4b67-46e2-99ca-c666f9c99f6f"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("673193da-825f-462e-b482-9db35792abe6"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("6a94a473-2310-421e-b589-532e29ac3554"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("74f45960-6fed-4cb6-bfbd-58c2f77e246b"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("8a8de061-0c10-48f0-b0b1-28c52a219660"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("92cb356a-d4d4-48ae-a7a3-160f7aea9420"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("a1b99720-cb6f-4dbb-aecb-fd432791e81a"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("d20d3a61-f45d-4fd1-a21c-80576618f1f9"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("ebb62dbd-d162-45ca-bfa2-6ff732ac0961"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("ec499a62-9076-4a82-980c-b6da34410b94"));

            migrationBuilder.CreateTable(
                name: "CheckRblHistory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ip = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Domain = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Level = table.Column<int>(type: "int", nullable: true),
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
                    DetectedHistoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RblsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    { new Guid("359b681e-cea8-4745-b371-781db51793d4"), "spam.spamrats.com", 1683370914L, "https://www.spamrats.com/lookup.php?ip=ADDRESS", 0, "Spam Rats", 0, 1683370914L },
                    { new Guid("457913af-bb49-4edb-aca6-97029171acb3"), "ubl.lashback.com", 1683370914L, "https://blacklist.lashback.com/?ipAddress=ADDRESS", 3, "Lashback", 0, 1683370914L },
                    { new Guid("533ebb64-91ea-4339-ae1c-170598cd0576"), "web.dnsbl.sorbs.net", 1683370914L, "http://www.sorbs.net/lookup.shtml", 3, "Web Sorbs", 1, 1683370914L },
                    { new Guid("63758d1d-7529-4711-887c-2316573fe0c0"), "bl.rspamd.com", 1683370914L, "https://bl.rspamd.com/", 1, "RBL Rspamd", 1, 1683370914L },
                    { new Guid("691a6283-45e8-418a-b343-b3db99099e56"), "cbl.abuseat.org", 1683370914L, "http://www.abuseat.org", 1, "Abuseeat", 0, 1683370914L },
                    { new Guid("8c8a2282-bd6f-461f-8789-d72409bb2d54"), "b.barracudacentral.org", 1683370914L, "http://barracudacentral.org/rbl", 1, "Barracuda", 0, 1683370914L },
                    { new Guid("93c0e753-ba3f-421d-824f-8e053d345cf5"), "combined.abuse.ch", 1683370914L, "https://abuse.ch/?p=532", 1, "Abuse.ch", 0, 1683370914L },
                    { new Guid("94b40f9f-3b29-475a-aa15-eaf2c490f2c7"), "url.0spam.org", 1683370914L, "https://check.0spam.org/q/?ipaddr=ADDRESS", 1, "0 Spam", 1, 1683370914L },
                    { new Guid("b5282858-7a7a-4352-9f1f-61a080a0bee9"), "zen.spamhaus.org", 1683370914L, "http://www.spamhaus.org/zen/", 2, "Spamhaus", 0, 1683370914L },
                    { new Guid("b9ddf87e-7890-4942-8573-b52da489454f"), "ips.backscatterer.org", 1683370914L, "http://www.backscatterer.org/?target=test", 2, "backscatterer", 0, 1683370914L },
                    { new Guid("bbdd363c-5e5c-4800-8dd9-2bb7cf330a4e"), "spam.dnsbl.anonmails.de", 1683370914L, "https://anonmails.de/dnsbl.php?ip=ADDRESS", 1, "Annonmails.de", 0, 1683370914L },
                    { new Guid("c352113e-be6b-43d9-b40f-e1dc99b5a395"), "bl.spamcop.com", 1683370914L, "https://www.spamcop.net/bl.shtml", 1, "SpamCop", 0, 1683370914L },
                    { new Guid("c5ac9dbf-3dc4-402b-a05d-841388b39bb4"), "ix.dnsbl.manitu.net", 1683370914L, "https://www.nixspam.net/lookup.php?language=en&value=ADDRESS", 1, "Manitu", 0, 1683370914L },
                    { new Guid("cb1947de-5ad8-4060-9f7b-77e98b507fe2"), "0spam.fusionzero.com", 1683370914L, "https://check.0spam.org/q/?ipaddr=ADDRESS", 1, "0 Spam", 0, 1683370914L },
                    { new Guid("da3d6538-214f-458b-964b-7edf7205b1b3"), "z.mailspike.net", 1683370914L, "https://mailspike.org/iplookup.html", 1, "Mailspike", 0, 1683370914L },
                    { new Guid("e97a9339-2e46-46fa-bb71-d4a095639aba"), "spam.dnsbl.sorbs.net", 1683370914L, "http://www.sorbs.net/lookup.shtml", 3, "Spam Sorbs", 0, 1683370914L },
                    { new Guid("f77e8059-5df2-4c79-80ed-4d6f45db8f91"), "psbl.surriel.com", 1683370914L, "https://psbl.org/listing?ip=ADDRESS", 1, "PSBL Surriel", 0, 1683370914L },
                    { new Guid("f8f83421-1e5f-4deb-9898-f49588a19025"), "smtp.dnsbl.sorbs.net", 1683370914L, "http://www.sorbs.net/lookup.shtml", 3, "SMTP Relay Sorbs", 0, 1683370914L }
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
                keyValue: new Guid("359b681e-cea8-4745-b371-781db51793d4"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("457913af-bb49-4edb-aca6-97029171acb3"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("533ebb64-91ea-4339-ae1c-170598cd0576"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("63758d1d-7529-4711-887c-2316573fe0c0"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("691a6283-45e8-418a-b343-b3db99099e56"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("8c8a2282-bd6f-461f-8789-d72409bb2d54"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("93c0e753-ba3f-421d-824f-8e053d345cf5"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("94b40f9f-3b29-475a-aa15-eaf2c490f2c7"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("b5282858-7a7a-4352-9f1f-61a080a0bee9"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("b9ddf87e-7890-4942-8573-b52da489454f"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("bbdd363c-5e5c-4800-8dd9-2bb7cf330a4e"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("c352113e-be6b-43d9-b40f-e1dc99b5a395"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("c5ac9dbf-3dc4-402b-a05d-841388b39bb4"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("cb1947de-5ad8-4060-9f7b-77e98b507fe2"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("da3d6538-214f-458b-964b-7edf7205b1b3"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("e97a9339-2e46-46fa-bb71-d4a095639aba"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("f77e8059-5df2-4c79-80ed-4d6f45db8f91"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("f8f83421-1e5f-4deb-9898-f49588a19025"));

            migrationBuilder.InsertData(
                table: "Rbls",
                columns: new[] { "Id", "Address", "CreateTime", "DelistUrl", "Level", "Name", "Type", "UpdateTime" },
                values: new object[,]
                {
                    { new Guid("31f8e2cf-5400-4405-b5d7-a6d3aa450123"), "cbl.abuseat.org", 1683057879L, "http://www.abuseat.org", 1, "Abuseeat", 0, 1683057879L },
                    { new Guid("3356179c-e410-4c1f-956b-d4e46f1086af"), "spam.dnsbl.anonmails.de", 1683057879L, "https://anonmails.de/dnsbl.php?ip=ADDRESS", 1, "Annonmails.de", 0, 1683057879L },
                    { new Guid("3cf250b2-5b9f-4683-b1b5-5d8998835061"), "spam.dnsbl.sorbs.net", 1683057879L, "http://www.sorbs.net/lookup.shtml", 3, "Spam Sorbs", 0, 1683057879L },
                    { new Guid("43b31cc1-e403-437e-8fa1-cd090952133f"), "url.0spam.org", 1683057879L, "https://check.0spam.org/q/?ipaddr=ADDRESS", 1, "0 Spam", 1, 1683057879L },
                    { new Guid("46f7816a-2e49-450c-8d3a-2dff162c0762"), "ubl.lashback.com", 1683057879L, "https://blacklist.lashback.com/?ipAddress=ADDRESS", 3, "Lashback", 0, 1683057879L },
                    { new Guid("51267343-aed9-402d-b681-4a27dde2ee66"), "bl.rspamd.com", 1683057879L, "https://bl.rspamd.com/", 1, "RBL Rspamd", 1, 1683057879L },
                    { new Guid("5b3acc3d-67e0-407a-b72b-a4c4776fe0dd"), "smtp.dnsbl.sorbs.net", 1683057879L, "http://www.sorbs.net/lookup.shtml", 3, "SMTP Relay Sorbs", 0, 1683057879L },
                    { new Guid("5be3db5d-79be-4b01-9c81-c8f52dd04c00"), "web.dnsbl.sorbs.net", 1683057879L, "http://www.sorbs.net/lookup.shtml", 3, "Web Sorbs", 1, 1683057879L },
                    { new Guid("5f254a79-4b67-46e2-99ca-c666f9c99f6f"), "combined.abuse.ch", 1683057879L, "https://abuse.ch/?p=532", 1, "Abuse.ch", 0, 1683057879L },
                    { new Guid("673193da-825f-462e-b482-9db35792abe6"), "zen.spamhaus.org", 1683057879L, "http://www.spamhaus.org/zen/", 2, "Spamhaus", 0, 1683057879L },
                    { new Guid("6a94a473-2310-421e-b589-532e29ac3554"), "spam.spamrats.com", 1683057879L, "https://www.spamrats.com/lookup.php?ip=ADDRESS", 0, "Spam Rats", 0, 1683057879L },
                    { new Guid("74f45960-6fed-4cb6-bfbd-58c2f77e246b"), "z.mailspike.net", 1683057879L, "https://mailspike.org/iplookup.html", 1, "Mailspike", 0, 1683057879L },
                    { new Guid("8a8de061-0c10-48f0-b0b1-28c52a219660"), "ix.dnsbl.manitu.net", 1683057879L, "https://www.nixspam.net/lookup.php?language=en&value=ADDRESS", 1, "Manitu", 0, 1683057879L },
                    { new Guid("92cb356a-d4d4-48ae-a7a3-160f7aea9420"), "0spam.fusionzero.com", 1683057879L, "https://check.0spam.org/q/?ipaddr=ADDRESS", 1, "0 Spam", 0, 1683057879L },
                    { new Guid("a1b99720-cb6f-4dbb-aecb-fd432791e81a"), "ips.backscatterer.org", 1683057879L, "http://www.backscatterer.org/?target=test", 2, "backscatterer", 0, 1683057879L },
                    { new Guid("d20d3a61-f45d-4fd1-a21c-80576618f1f9"), "b.barracudacentral.org", 1683057879L, "http://barracudacentral.org/rbl", 1, "Barracuda", 0, 1683057879L },
                    { new Guid("ebb62dbd-d162-45ca-bfa2-6ff732ac0961"), "psbl.surriel.com", 1683057879L, "https://psbl.org/listing?ip=ADDRESS", 1, "PSBL Surriel", 0, 1683057879L },
                    { new Guid("ec499a62-9076-4a82-980c-b6da34410b94"), "bl.spamcop.com", 1683057879L, "https://www.spamcop.net/bl.shtml", 1, "SpamCop", 0, 1683057879L }
                });
        }
    }
}
