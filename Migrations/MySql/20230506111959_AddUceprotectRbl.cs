using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace rbl_tracker.Migrations.MySql
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
                    { new Guid("213e0252-9e8d-48e4-99d0-6ad281f9830a"), "ips.backscatterer.org", 1683371998L, "http://www.backscatterer.org/?target=test", 2, "backscatterer", 0, 1683371998L },
                    { new Guid("22472271-8b1d-42e0-a3ef-9e8a8e132ca7"), "bl.spamcop.com", 1683371998L, "https://www.spamcop.net/bl.shtml", 1, "SpamCop", 0, 1683371998L },
                    { new Guid("24c9e2d1-75ce-41a3-a4af-2a414fdf02c6"), "smtp.dnsbl.sorbs.net", 1683371998L, "http://www.sorbs.net/lookup.shtml", 3, "SMTP Relay Sorbs", 0, 1683371998L },
                    { new Guid("28ab9302-0ece-4a48-97f4-644b407c3212"), "dnsbl-3.uceprotect.net", 1683371998L, "http://www.uceprotect.net/en/rblcheck.php?ipr=ADDRESS", 2, "UCEPROTECTL3", 0, 1683371998L },
                    { new Guid("3ae2da7d-8aaf-4e4d-a0e8-63a4534eab84"), "dnsbl-2.uceprotect.net", 1683371998L, "http://www.uceprotect.net/en/rblcheck.php?ipr=ADDRESS", 2, "UCEPROTECTL2", 0, 1683371998L },
                    { new Guid("4f9519d2-1012-410d-a296-1d2b302d8fb5"), "cbl.abuseat.org", 1683371998L, "http://www.abuseat.org", 1, "Abuseeat", 0, 1683371998L },
                    { new Guid("512f6c7d-40f0-4044-8df3-140b26f03b59"), "spam.spamrats.com", 1683371998L, "https://www.spamrats.com/lookup.php?ip=ADDRESS", 0, "Spam Rats", 0, 1683371998L },
                    { new Guid("6b30392e-b43e-4a64-975e-8c165345ca7c"), "0spam.fusionzero.com", 1683371998L, "https://check.0spam.org/q/?ipaddr=ADDRESS", 1, "0 Spam", 0, 1683371998L },
                    { new Guid("6e75d505-a54b-4da1-b867-893b95f1fa8e"), "ix.dnsbl.manitu.net", 1683371998L, "https://www.nixspam.net/lookup.php?language=en&value=ADDRESS", 1, "Manitu", 0, 1683371998L },
                    { new Guid("769e37a1-a6f2-4dba-8653-8f17be0f4607"), "dnsbl-1.uceprotect.net", 1683371998L, "http://www.uceprotect.net/en/rblcheck.php?ipr=ADDRESS", 2, "UCEPROTECTL1", 0, 1683371998L },
                    { new Guid("95aa5e31-15e3-401e-8a92-65fe37bc9a35"), "ubl.lashback.com", 1683371998L, "https://blacklist.lashback.com/?ipAddress=ADDRESS", 3, "Lashback", 0, 1683371998L },
                    { new Guid("9a301e0c-4b41-4292-9f08-877f5862ac63"), "url.0spam.org", 1683371998L, "https://check.0spam.org/q/?ipaddr=ADDRESS", 1, "0 Spam", 1, 1683371998L },
                    { new Guid("bbd4158d-7f90-4853-9a1e-407f46655d4a"), "psbl.surriel.com", 1683371998L, "https://psbl.org/listing?ip=ADDRESS", 1, "PSBL Surriel", 0, 1683371998L },
                    { new Guid("c6890068-b23e-4d51-9858-ce48a80ceb86"), "b.barracudacentral.org", 1683371998L, "http://barracudacentral.org/rbl", 1, "Barracuda", 0, 1683371998L },
                    { new Guid("ce718fa6-a357-4b43-89d2-09a9b1cbc420"), "bl.rspamd.com", 1683371998L, "https://bl.rspamd.com/", 1, "RBL Rspamd", 1, 1683371998L },
                    { new Guid("d7947e8b-0667-407b-8408-1b9eb690f569"), "web.dnsbl.sorbs.net", 1683371998L, "http://www.sorbs.net/lookup.shtml", 3, "Web Sorbs", 1, 1683371998L },
                    { new Guid("d91ea6ff-0284-48d2-93c7-80aa7c669be3"), "combined.abuse.ch", 1683371998L, "https://abuse.ch/?p=532", 1, "Abuse.ch", 0, 1683371998L },
                    { new Guid("e580051a-f21d-4460-ae52-df0c372eb696"), "spam.dnsbl.sorbs.net", 1683371998L, "http://www.sorbs.net/lookup.shtml", 3, "Spam Sorbs", 0, 1683371998L },
                    { new Guid("e9efb6ff-4e3a-4067-8aac-70f394619a8c"), "zen.spamhaus.org", 1683371998L, "http://www.spamhaus.org/zen/", 2, "Spamhaus", 0, 1683371998L },
                    { new Guid("effead25-60d8-4ec7-9b0a-e2c7b4d86b6f"), "spam.dnsbl.anonmails.de", 1683371998L, "https://anonmails.de/dnsbl.php?ip=ADDRESS", 1, "Annonmails.de", 0, 1683371998L },
                    { new Guid("fb512ee7-3982-4c8f-9a35-63a30b891c43"), "z.mailspike.net", 1683371998L, "https://mailspike.org/iplookup.html", 1, "Mailspike", 0, 1683371998L }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("213e0252-9e8d-48e4-99d0-6ad281f9830a"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("22472271-8b1d-42e0-a3ef-9e8a8e132ca7"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("24c9e2d1-75ce-41a3-a4af-2a414fdf02c6"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("28ab9302-0ece-4a48-97f4-644b407c3212"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("3ae2da7d-8aaf-4e4d-a0e8-63a4534eab84"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("4f9519d2-1012-410d-a296-1d2b302d8fb5"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("512f6c7d-40f0-4044-8df3-140b26f03b59"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("6b30392e-b43e-4a64-975e-8c165345ca7c"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("6e75d505-a54b-4da1-b867-893b95f1fa8e"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("769e37a1-a6f2-4dba-8653-8f17be0f4607"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("95aa5e31-15e3-401e-8a92-65fe37bc9a35"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("9a301e0c-4b41-4292-9f08-877f5862ac63"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("bbd4158d-7f90-4853-9a1e-407f46655d4a"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("c6890068-b23e-4d51-9858-ce48a80ceb86"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("ce718fa6-a357-4b43-89d2-09a9b1cbc420"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("d7947e8b-0667-407b-8408-1b9eb690f569"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("d91ea6ff-0284-48d2-93c7-80aa7c669be3"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("e580051a-f21d-4460-ae52-df0c372eb696"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("e9efb6ff-4e3a-4067-8aac-70f394619a8c"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("effead25-60d8-4ec7-9b0a-e2c7b4d86b6f"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("fb512ee7-3982-4c8f-9a35-63a30b891c43"));

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
        }
    }
}
