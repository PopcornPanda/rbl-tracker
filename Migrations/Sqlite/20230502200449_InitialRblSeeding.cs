using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace rbl_tracker.Migrations.Sqlite
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
