using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace rbl_tracker.Migrations.PostgreSql
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
                    { new Guid("0d8a0b7f-73de-4262-a977-76e4d7a438c9"), "ubl.lashback.com", 1683372003L, "https://blacklist.lashback.com/?ipAddress=ADDRESS", 3, "Lashback", 0, 1683372003L },
                    { new Guid("16d7e8d6-404c-463f-9676-d4fc61c3267e"), "dnsbl-2.uceprotect.net", 1683372003L, "http://www.uceprotect.net/en/rblcheck.php?ipr=ADDRESS", 2, "UCEPROTECTL2", 0, 1683372003L },
                    { new Guid("1b69991c-a0d3-4a54-a166-84a32685a729"), "web.dnsbl.sorbs.net", 1683372003L, "http://www.sorbs.net/lookup.shtml", 3, "Web Sorbs", 1, 1683372003L },
                    { new Guid("52baa3fc-e564-4505-9250-87103275029c"), "dnsbl-3.uceprotect.net", 1683372003L, "http://www.uceprotect.net/en/rblcheck.php?ipr=ADDRESS", 2, "UCEPROTECTL3", 0, 1683372003L },
                    { new Guid("77eda4a6-f1f3-4c32-9e4a-d638e810b508"), "psbl.surriel.com", 1683372003L, "https://psbl.org/listing?ip=ADDRESS", 1, "PSBL Surriel", 0, 1683372003L },
                    { new Guid("84c10c13-e1fe-401e-977e-faeda00c5258"), "spam.spamrats.com", 1683372003L, "https://www.spamrats.com/lookup.php?ip=ADDRESS", 0, "Spam Rats", 0, 1683372003L },
                    { new Guid("8b7c1f9a-d7db-4735-932c-659866f0ee7c"), "combined.abuse.ch", 1683372003L, "https://abuse.ch/?p=532", 1, "Abuse.ch", 0, 1683372003L },
                    { new Guid("aa4df5c1-df04-41e8-8aca-92685bbd32c9"), "spam.dnsbl.anonmails.de", 1683372003L, "https://anonmails.de/dnsbl.php?ip=ADDRESS", 1, "Annonmails.de", 0, 1683372003L },
                    { new Guid("aaf313a2-57be-446c-9256-483d786ff9c9"), "ix.dnsbl.manitu.net", 1683372003L, "https://www.nixspam.net/lookup.php?language=en&value=ADDRESS", 1, "Manitu", 0, 1683372003L },
                    { new Guid("ace00027-b40a-4655-8fe7-eb1bd59e1571"), "smtp.dnsbl.sorbs.net", 1683372003L, "http://www.sorbs.net/lookup.shtml", 3, "SMTP Relay Sorbs", 0, 1683372003L },
                    { new Guid("b2cc497c-1aac-417f-83a8-0b6820bf1f07"), "bl.spamcop.com", 1683372003L, "https://www.spamcop.net/bl.shtml", 1, "SpamCop", 0, 1683372003L },
                    { new Guid("b9cfe76a-7186-4d03-9f64-ba71a1e87922"), "z.mailspike.net", 1683372003L, "https://mailspike.org/iplookup.html", 1, "Mailspike", 0, 1683372003L },
                    { new Guid("c87eba8e-806a-49b0-a633-152be8cce664"), "url.0spam.org", 1683372003L, "https://check.0spam.org/q/?ipaddr=ADDRESS", 1, "0 Spam", 1, 1683372003L },
                    { new Guid("d1bfbf63-3a05-4955-b48c-89d8c96fc18d"), "bl.rspamd.com", 1683372003L, "https://bl.rspamd.com/", 1, "RBL Rspamd", 1, 1683372003L },
                    { new Guid("d663ffe6-458e-4ece-82c1-9ed409877067"), "zen.spamhaus.org", 1683372003L, "http://www.spamhaus.org/zen/", 2, "Spamhaus", 0, 1683372003L },
                    { new Guid("e0df668f-5a22-494e-b411-12d3dc7777d9"), "cbl.abuseat.org", 1683372003L, "http://www.abuseat.org", 1, "Abuseeat", 0, 1683372003L },
                    { new Guid("e2051923-9c05-4c3b-bc5c-97350e0ec450"), "dnsbl-1.uceprotect.net", 1683372003L, "http://www.uceprotect.net/en/rblcheck.php?ipr=ADDRESS", 2, "UCEPROTECTL1", 0, 1683372003L },
                    { new Guid("e2b24854-fa7d-41a1-9eed-8bedd3631833"), "spam.dnsbl.sorbs.net", 1683372003L, "http://www.sorbs.net/lookup.shtml", 3, "Spam Sorbs", 0, 1683372003L },
                    { new Guid("e440e4f6-b6bc-48a3-931d-157f9cb9b1b3"), "b.barracudacentral.org", 1683372003L, "http://barracudacentral.org/rbl", 1, "Barracuda", 0, 1683372003L },
                    { new Guid("fd0f6dd3-1751-48e3-bca1-205828c1560b"), "ips.backscatterer.org", 1683372003L, "http://www.backscatterer.org/?target=test", 2, "backscatterer", 0, 1683372003L },
                    { new Guid("ff8006f0-84c1-4e89-9d81-5b46bc89edca"), "0spam.fusionzero.com", 1683372003L, "https://check.0spam.org/q/?ipaddr=ADDRESS", 1, "0 Spam", 0, 1683372003L }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("0d8a0b7f-73de-4262-a977-76e4d7a438c9"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("16d7e8d6-404c-463f-9676-d4fc61c3267e"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("1b69991c-a0d3-4a54-a166-84a32685a729"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("52baa3fc-e564-4505-9250-87103275029c"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("77eda4a6-f1f3-4c32-9e4a-d638e810b508"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("84c10c13-e1fe-401e-977e-faeda00c5258"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("8b7c1f9a-d7db-4735-932c-659866f0ee7c"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("aa4df5c1-df04-41e8-8aca-92685bbd32c9"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("aaf313a2-57be-446c-9256-483d786ff9c9"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("ace00027-b40a-4655-8fe7-eb1bd59e1571"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("b2cc497c-1aac-417f-83a8-0b6820bf1f07"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("b9cfe76a-7186-4d03-9f64-ba71a1e87922"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("c87eba8e-806a-49b0-a633-152be8cce664"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("d1bfbf63-3a05-4955-b48c-89d8c96fc18d"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("d663ffe6-458e-4ece-82c1-9ed409877067"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("e0df668f-5a22-494e-b411-12d3dc7777d9"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("e2051923-9c05-4c3b-bc5c-97350e0ec450"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("e2b24854-fa7d-41a1-9eed-8bedd3631833"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("e440e4f6-b6bc-48a3-931d-157f9cb9b1b3"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("fd0f6dd3-1751-48e3-bca1-205828c1560b"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("ff8006f0-84c1-4e89-9d81-5b46bc89edca"));

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
        }
    }
}
