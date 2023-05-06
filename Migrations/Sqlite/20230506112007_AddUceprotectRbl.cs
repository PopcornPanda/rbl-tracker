using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace rbl_tracker.Migrations.Sqlite
{
    /// <inheritdoc />
    public partial class AddUceprotectRbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { new Guid("019b452c-0f85-4aca-90d3-6eb30cbd20b5"), "dnsbl-2.uceprotect.net", 1683372007L, "http://www.uceprotect.net/en/rblcheck.php?ipr=ADDRESS", 2, "UCEPROTECTL2", 0, 1683372007L },
                    { new Guid("07bd68df-729d-424a-9dcd-d4600702e442"), "cbl.abuseat.org", 1683372007L, "http://www.abuseat.org", 1, "Abuseeat", 0, 1683372007L },
                    { new Guid("0f8a1a71-a532-463c-bc06-e38b01b427cf"), "ix.dnsbl.manitu.net", 1683372007L, "https://www.nixspam.net/lookup.php?language=en&value=ADDRESS", 1, "Manitu", 0, 1683372007L },
                    { new Guid("1d5940f0-cfb9-4662-bf7f-3aa5c75b24fe"), "bl.spamcop.com", 1683372007L, "https://www.spamcop.net/bl.shtml", 1, "SpamCop", 0, 1683372007L },
                    { new Guid("2984624e-2c1c-44bc-9937-0a5e149e91ca"), "ips.backscatterer.org", 1683372007L, "http://www.backscatterer.org/?target=test", 2, "backscatterer", 0, 1683372007L },
                    { new Guid("387b3dcf-1e5a-4522-8d5b-7088b4145189"), "spam.dnsbl.anonmails.de", 1683372007L, "https://anonmails.de/dnsbl.php?ip=ADDRESS", 1, "Annonmails.de", 0, 1683372007L },
                    { new Guid("54c675b4-497e-407d-b83d-7786b1e9a695"), "spam.spamrats.com", 1683372007L, "https://www.spamrats.com/lookup.php?ip=ADDRESS", 0, "Spam Rats", 0, 1683372007L },
                    { new Guid("592ae338-4cfa-4b3c-8fc5-088d28733cdb"), "combined.abuse.ch", 1683372007L, "https://abuse.ch/?p=532", 1, "Abuse.ch", 0, 1683372007L },
                    { new Guid("60081dbe-f965-4771-bfba-9b82a945f9cf"), "web.dnsbl.sorbs.net", 1683372007L, "http://www.sorbs.net/lookup.shtml", 3, "Web Sorbs", 1, 1683372007L },
                    { new Guid("65c8dc74-6167-465c-8679-17255247dfb2"), "0spam.fusionzero.com", 1683372007L, "https://check.0spam.org/q/?ipaddr=ADDRESS", 1, "0 Spam", 0, 1683372007L },
                    { new Guid("700b81b1-9fbc-4ff2-b417-a9071be5eb42"), "b.barracudacentral.org", 1683372007L, "http://barracudacentral.org/rbl", 1, "Barracuda", 0, 1683372007L },
                    { new Guid("70abdde0-7a95-4870-9383-4892f6ccf4a2"), "zen.spamhaus.org", 1683372007L, "http://www.spamhaus.org/zen/", 2, "Spamhaus", 0, 1683372007L },
                    { new Guid("756d63cd-a844-4d09-a0ba-ca55797486af"), "url.0spam.org", 1683372007L, "https://check.0spam.org/q/?ipaddr=ADDRESS", 1, "0 Spam", 1, 1683372007L },
                    { new Guid("95bff823-97c6-4088-a657-a796425c430a"), "ubl.lashback.com", 1683372007L, "https://blacklist.lashback.com/?ipAddress=ADDRESS", 3, "Lashback", 0, 1683372007L },
                    { new Guid("a8a30524-569e-46b1-aee6-8a76dc372cd4"), "bl.rspamd.com", 1683372007L, "https://bl.rspamd.com/", 1, "RBL Rspamd", 1, 1683372007L },
                    { new Guid("a8e73374-c710-4d21-8691-e58216bfa541"), "z.mailspike.net", 1683372007L, "https://mailspike.org/iplookup.html", 1, "Mailspike", 0, 1683372007L },
                    { new Guid("c22ea400-d1db-4a1c-a4a6-b99c7f27ef32"), "dnsbl-1.uceprotect.net", 1683372007L, "http://www.uceprotect.net/en/rblcheck.php?ipr=ADDRESS", 2, "UCEPROTECTL1", 0, 1683372007L },
                    { new Guid("c539edf0-23e8-458b-bd3c-14af8dc03ef7"), "smtp.dnsbl.sorbs.net", 1683372007L, "http://www.sorbs.net/lookup.shtml", 3, "SMTP Relay Sorbs", 0, 1683372007L },
                    { new Guid("e4d31ba6-e0f3-4002-a0ee-12bafc8003a6"), "spam.dnsbl.sorbs.net", 1683372007L, "http://www.sorbs.net/lookup.shtml", 3, "Spam Sorbs", 0, 1683372007L },
                    { new Guid("e6f7fb71-352c-45cb-b2a6-3d638cf16cc5"), "psbl.surriel.com", 1683372007L, "https://psbl.org/listing?ip=ADDRESS", 1, "PSBL Surriel", 0, 1683372007L },
                    { new Guid("fddf43f1-4bc6-4c79-935e-fce82c8336c5"), "dnsbl-3.uceprotect.net", 1683372007L, "http://www.uceprotect.net/en/rblcheck.php?ipr=ADDRESS", 2, "UCEPROTECTL3", 0, 1683372007L }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("019b452c-0f85-4aca-90d3-6eb30cbd20b5"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("07bd68df-729d-424a-9dcd-d4600702e442"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("0f8a1a71-a532-463c-bc06-e38b01b427cf"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("1d5940f0-cfb9-4662-bf7f-3aa5c75b24fe"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("2984624e-2c1c-44bc-9937-0a5e149e91ca"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("387b3dcf-1e5a-4522-8d5b-7088b4145189"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("54c675b4-497e-407d-b83d-7786b1e9a695"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("592ae338-4cfa-4b3c-8fc5-088d28733cdb"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("60081dbe-f965-4771-bfba-9b82a945f9cf"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("65c8dc74-6167-465c-8679-17255247dfb2"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("700b81b1-9fbc-4ff2-b417-a9071be5eb42"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("70abdde0-7a95-4870-9383-4892f6ccf4a2"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("756d63cd-a844-4d09-a0ba-ca55797486af"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("95bff823-97c6-4088-a657-a796425c430a"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("a8a30524-569e-46b1-aee6-8a76dc372cd4"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("a8e73374-c710-4d21-8691-e58216bfa541"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("c22ea400-d1db-4a1c-a4a6-b99c7f27ef32"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("c539edf0-23e8-458b-bd3c-14af8dc03ef7"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("e4d31ba6-e0f3-4002-a0ee-12bafc8003a6"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("e6f7fb71-352c-45cb-b2a6-3d638cf16cc5"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("fddf43f1-4bc6-4c79-935e-fce82c8336c5"));

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
        }
    }
}
