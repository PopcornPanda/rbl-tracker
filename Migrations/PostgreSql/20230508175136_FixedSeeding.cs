using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace rbl_tracker.Migrations.PostgreSql
{
    /// <inheritdoc />
    public partial class FixedSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("0c0341b4-9675-413c-b446-1462e4edbcb6"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("10a70f36-1a6b-40ea-a319-ecd692d8d1f1"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("16979cdc-27bc-404a-b575-d8d103d373d1"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("1851842f-1df1-4b26-9ddb-dc6509b383a9"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("3669ff55-25c8-450c-929d-e203b7b2db3a"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("3c651b67-f8d0-46e7-917d-1da5144addd6"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("55d423b2-8246-4b71-b281-9250d79bddde"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("56497e41-390a-4659-baa6-ee721908eb38"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("5aab08d8-34d4-431f-a6c9-f414e5d8b86b"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("66a54a5d-f265-4816-bd64-eb552b0d1427"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("798e72ca-b355-4acd-a8a0-09b85dfc00c0"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("89c9411d-c718-4a02-895a-ef4be06853e3"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("8b64b6ee-69c4-46c3-89af-0ebb9501f268"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("b37b3ab9-3e9d-4d09-b837-034b269082e7"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("c5425543-2ae2-4206-b7e2-031079c25a26"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("d0cf991c-c607-49dd-a86b-131f85e7e65b"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("e7c8d9c2-8ceb-49ec-9b2f-2a46f6a7f5f0"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("e8b449b9-7a58-49a2-b6ec-c083c624033d"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("eb76599b-606f-4685-8bf3-32a32b54acd2"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("ef09fe08-5128-42d5-8c23-769a31365132"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("f264bc2d-4192-433e-ae6c-ed62c9821ec7"));

            migrationBuilder.InsertData(
                table: "Rbls",
                columns: new[] { "Id", "Address", "CreateTime", "DelistUrl", "Level", "Name", "Type", "UpdateTime" },
                values: new object[,]
                {
                    { new Guid("359b681e-cea9-4745-b371-781db51793d4"), "ips.backscatterer.org", 1683371995L, "http://www.backscatterer.org/?target=test", 2, "backscatterer", 0, 1683371995L },
                    { new Guid("457913af-bb40-4edb-aca6-97029171acb3"), "combined.abuse.ch", 1683371995L, "https://abuse.ch/?p=532", 1, "Abuse.ch", 0, 1683371995L },
                    { new Guid("533ebb64-91e3-4339-ae1c-170598cd0576"), "zen.spamhaus.org", 1683371995L, "http://www.spamhaus.org/zen/", 2, "Spamhaus", 0, 1683371995L },
                    { new Guid("63758d1d-7526-4711-887c-2316573fe0c0"), "spam.spamrats.com", 1683371995L, "https://www.spamrats.com/lookup.php?ip=ADDRESS", 0, "Spam Rats", 0, 1683371995L },
                    { new Guid("68279004-38ec-4a95-a478-f0dde1627f66"), "url.0spam.org", 1683371995L, "https://check.0spam.org/q/?ipaddr=ADDRESS", 1, "0 Spam", 1, 1683371995L },
                    { new Guid("691a6283-45e3-418a-b343-b3db99099e56"), "b.barracudacentral.org", 1683371995L, "http://barracudacentral.org/rbl", 1, "Barracuda", 0, 1683371995L },
                    { new Guid("8c8a2282-bd61-461f-8789-d72409bb2d54"), "ix.dnsbl.manitu.net", 1683371995L, "https://www.nixspam.net/lookup.php?language=en&value=ADDRESS", 1, "Manitu", 0, 1683371995L },
                    { new Guid("93c0e753-ba32-421d-824f-8e053d345cf5"), "spam.dnsbl.sorbs.net", 1683371995L, "http://www.sorbs.net/lookup.shtml", 3, "Spam Sorbs", 0, 1683371995L },
                    { new Guid("94b40f9f-3b23-475a-aa15-eaf2c490f2c7"), "smtp.dnsbl.sorbs.net", 1683371995L, "http://www.sorbs.net/lookup.shtml", 3, "SMTP Relay Sorbs", 0, 1683371995L },
                    { new Guid("b5282858-7a75-4352-9f1f-61a080a0bee9"), "web.dnsbl.sorbs.net", 1683371995L, "http://www.sorbs.net/lookup.shtml", 3, "Web Sorbs", 1, 1683371995L },
                    { new Guid("b9ddf87e-7897-4942-8573-b52da489454f"), "spam.dnsbl.anonmails.de", 1683371995L, "https://anonmails.de/dnsbl.php?ip=ADDRESS", 1, "Annonmails.de", 0, 1683371995L },
                    { new Guid("bbdd363c-5e59-4800-8dd9-2bb7cf330a4e"), "ubl.lashback.com", 1683371995L, "https://blacklist.lashback.com/?ipAddress=ADDRESS", 3, "Lashback", 0, 1683371995L },
                    { new Guid("c352113e-be6a-43d9-b40f-e1dc99b5a395"), "z.mailspike.net", 1683371995L, "https://mailspike.org/iplookup.html", 1, "Mailspike", 0, 1683371995L },
                    { new Guid("c5ac9dbf-3dcc-402b-a05d-841388b39bb4"), "cbl.abuseat.org", 1683371995L, "http://www.abuseat.org", 1, "Abuseeat", 0, 1683371995L },
                    { new Guid("cb1947de-5ada-4060-9f7b-77e98b507fe2"), "psbl.surriel.com", 1683371995L, "https://psbl.org/listing?ip=ADDRESS", 1, "PSBL Surriel", 0, 1683371995L },
                    { new Guid("da3d6538-2142-458b-964b-7edf7205b1b3"), "bl.rspamd.com", 1683371995L, "https://bl.rspamd.com/", 1, "RBL Rspamd", 1, 1683371995L },
                    { new Guid("e97a9339-2e40-46fa-bb71-d4a095639aba"), "dnsbl-1.uceprotect.net", 1683371995L, "http://www.uceprotect.net/en/rblcheck.php?ipr=ADDRESS", 2, "UCEPROTECTL1", 0, 1683371995L },
                    { new Guid("ec25c85e-f74b-4c00-81ab-9ba104df65b0"), "bl.spamcop.com", 1683371995L, "https://www.spamcop.net/bl.shtml", 1, "SpamCop", 0, 1683371995L },
                    { new Guid("f77e8059-5df3-4c79-80ed-4d6f45db8f91"), "dnsbl-2.uceprotect.net", 1683371995L, "http://www.uceprotect.net/en/rblcheck.php?ipr=ADDRESS", 2, "UCEPROTECTL2", 0, 1683371995L },
                    { new Guid("f83a8965-9baa-4f1d-b046-8f8f7fda02b2"), "0spam.fusionzero.com", 1683371995L, "https://check.0spam.org/q/?ipaddr=ADDRESS", 1, "0 Spam", 0, 1683371995L },
                    { new Guid("f8f83421-1e5e-4deb-9898-f49588a19025"), "dnsbl-3.uceprotect.net", 1683371995L, "http://www.uceprotect.net/en/rblcheck.php?ipr=ADDRESS", 2, "UCEPROTECTL3", 0, 1683371995L }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("359b681e-cea9-4745-b371-781db51793d4"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("457913af-bb40-4edb-aca6-97029171acb3"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("533ebb64-91e3-4339-ae1c-170598cd0576"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("63758d1d-7526-4711-887c-2316573fe0c0"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("68279004-38ec-4a95-a478-f0dde1627f66"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("691a6283-45e3-418a-b343-b3db99099e56"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("8c8a2282-bd61-461f-8789-d72409bb2d54"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("93c0e753-ba32-421d-824f-8e053d345cf5"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("94b40f9f-3b23-475a-aa15-eaf2c490f2c7"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("b5282858-7a75-4352-9f1f-61a080a0bee9"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("b9ddf87e-7897-4942-8573-b52da489454f"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("bbdd363c-5e59-4800-8dd9-2bb7cf330a4e"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("c352113e-be6a-43d9-b40f-e1dc99b5a395"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("c5ac9dbf-3dcc-402b-a05d-841388b39bb4"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("cb1947de-5ada-4060-9f7b-77e98b507fe2"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("da3d6538-2142-458b-964b-7edf7205b1b3"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("e97a9339-2e40-46fa-bb71-d4a095639aba"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("ec25c85e-f74b-4c00-81ab-9ba104df65b0"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("f77e8059-5df3-4c79-80ed-4d6f45db8f91"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("f83a8965-9baa-4f1d-b046-8f8f7fda02b2"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("f8f83421-1e5e-4deb-9898-f49588a19025"));

            migrationBuilder.InsertData(
                table: "Rbls",
                columns: new[] { "Id", "Address", "CreateTime", "DelistUrl", "Level", "Name", "Type", "UpdateTime" },
                values: new object[,]
                {
                    { new Guid("0c0341b4-9675-413c-b446-1462e4edbcb6"), "cbl.abuseat.org", 1683372061L, "http://www.abuseat.org", 1, "Abuseeat", 0, 1683372061L },
                    { new Guid("10a70f36-1a6b-40ea-a319-ecd692d8d1f1"), "dnsbl-3.uceprotect.net", 1683372061L, "http://www.uceprotect.net/en/rblcheck.php?ipr=ADDRESS", 2, "UCEPROTECTL3", 0, 1683372061L },
                    { new Guid("16979cdc-27bc-404a-b575-d8d103d373d1"), "ubl.lashback.com", 1683372061L, "https://blacklist.lashback.com/?ipAddress=ADDRESS", 3, "Lashback", 0, 1683372061L },
                    { new Guid("1851842f-1df1-4b26-9ddb-dc6509b383a9"), "url.0spam.org", 1683372061L, "https://check.0spam.org/q/?ipaddr=ADDRESS", 1, "0 Spam", 1, 1683372061L },
                    { new Guid("3669ff55-25c8-450c-929d-e203b7b2db3a"), "web.dnsbl.sorbs.net", 1683372061L, "http://www.sorbs.net/lookup.shtml", 3, "Web Sorbs", 1, 1683372061L },
                    { new Guid("3c651b67-f8d0-46e7-917d-1da5144addd6"), "z.mailspike.net", 1683372061L, "https://mailspike.org/iplookup.html", 1, "Mailspike", 0, 1683372061L },
                    { new Guid("55d423b2-8246-4b71-b281-9250d79bddde"), "smtp.dnsbl.sorbs.net", 1683372061L, "http://www.sorbs.net/lookup.shtml", 3, "SMTP Relay Sorbs", 0, 1683372061L },
                    { new Guid("56497e41-390a-4659-baa6-ee721908eb38"), "zen.spamhaus.org", 1683372061L, "http://www.spamhaus.org/zen/", 2, "Spamhaus", 0, 1683372061L },
                    { new Guid("5aab08d8-34d4-431f-a6c9-f414e5d8b86b"), "0spam.fusionzero.com", 1683372061L, "https://check.0spam.org/q/?ipaddr=ADDRESS", 1, "0 Spam", 0, 1683372061L },
                    { new Guid("66a54a5d-f265-4816-bd64-eb552b0d1427"), "spam.dnsbl.anonmails.de", 1683372061L, "https://anonmails.de/dnsbl.php?ip=ADDRESS", 1, "Annonmails.de", 0, 1683372061L },
                    { new Guid("798e72ca-b355-4acd-a8a0-09b85dfc00c0"), "spam.dnsbl.sorbs.net", 1683372061L, "http://www.sorbs.net/lookup.shtml", 3, "Spam Sorbs", 0, 1683372061L },
                    { new Guid("89c9411d-c718-4a02-895a-ef4be06853e3"), "dnsbl-1.uceprotect.net", 1683372061L, "http://www.uceprotect.net/en/rblcheck.php?ipr=ADDRESS", 2, "UCEPROTECTL1", 0, 1683372061L },
                    { new Guid("8b64b6ee-69c4-46c3-89af-0ebb9501f268"), "bl.spamcop.com", 1683372061L, "https://www.spamcop.net/bl.shtml", 1, "SpamCop", 0, 1683372061L },
                    { new Guid("b37b3ab9-3e9d-4d09-b837-034b269082e7"), "dnsbl-2.uceprotect.net", 1683372061L, "http://www.uceprotect.net/en/rblcheck.php?ipr=ADDRESS", 2, "UCEPROTECTL2", 0, 1683372061L },
                    { new Guid("c5425543-2ae2-4206-b7e2-031079c25a26"), "ix.dnsbl.manitu.net", 1683372061L, "https://www.nixspam.net/lookup.php?language=en&value=ADDRESS", 1, "Manitu", 0, 1683372061L },
                    { new Guid("d0cf991c-c607-49dd-a86b-131f85e7e65b"), "combined.abuse.ch", 1683372061L, "https://abuse.ch/?p=532", 1, "Abuse.ch", 0, 1683372061L },
                    { new Guid("e7c8d9c2-8ceb-49ec-9b2f-2a46f6a7f5f0"), "psbl.surriel.com", 1683372061L, "https://psbl.org/listing?ip=ADDRESS", 1, "PSBL Surriel", 0, 1683372061L },
                    { new Guid("e8b449b9-7a58-49a2-b6ec-c083c624033d"), "spam.spamrats.com", 1683372061L, "https://www.spamrats.com/lookup.php?ip=ADDRESS", 0, "Spam Rats", 0, 1683372061L },
                    { new Guid("eb76599b-606f-4685-8bf3-32a32b54acd2"), "b.barracudacentral.org", 1683372061L, "http://barracudacentral.org/rbl", 1, "Barracuda", 0, 1683372061L },
                    { new Guid("ef09fe08-5128-42d5-8c23-769a31365132"), "ips.backscatterer.org", 1683372061L, "http://www.backscatterer.org/?target=test", 2, "backscatterer", 0, 1683372061L },
                    { new Guid("f264bc2d-4192-433e-ae6c-ed62c9821ec7"), "bl.rspamd.com", 1683372061L, "https://bl.rspamd.com/", 1, "RBL Rspamd", 1, 1683372061L }
                });
        }
    }
}
