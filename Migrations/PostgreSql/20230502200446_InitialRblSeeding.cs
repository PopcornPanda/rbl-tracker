using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace rbl_tracker.Migrations.PostgreSql
{
    /// <inheritdoc />
    public partial class InitialRblSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
