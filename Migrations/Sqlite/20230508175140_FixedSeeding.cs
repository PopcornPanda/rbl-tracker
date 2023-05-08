using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace rbl_tracker.Migrations.Sqlite
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
                keyValue: new Guid("066ac7f9-e882-475f-bbfd-8f190e615616"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("1815dd31-d5c5-4738-a6b5-0b133fef008a"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("2636439a-b0ae-4477-a6bd-c9feb1975528"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("2aea4ee4-f75e-4361-8e3e-f99e2b91aef7"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("35ae8fb7-e6a6-4793-a81a-ec894d05f3e6"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("3f270240-6ffd-4aeb-9edf-2968ebfcb39e"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("414f8369-4fe5-4b2c-acc4-9a7219ff5013"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("553614b0-48d7-4529-a0a4-f95e1b049b79"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("687c2277-f520-485e-9525-17add86c3264"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("68c91dcc-31ed-49a6-b3f6-0cb62c92c443"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("721b66aa-6534-4119-859f-b9862957393a"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("7491c680-a071-4972-82f9-b7d13e523113"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("919bfb97-0db7-4f43-9b57-6bf57e1bb658"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("9ca9a5a6-e4cb-4ada-b9bd-81ba9b163027"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("b48850b5-c05c-4bc6-b97d-cc0f1ae91488"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("bd9ee37a-02d5-4e67-a4bc-6a70dcbac356"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("c43ce0ec-d77d-4330-8172-a1ba18a52c02"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("d6327ed8-5ca5-4998-8e98-b4ce0e99a85f"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("e4c55859-c661-4ee2-81ee-99b6e2677c3d"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("e6095edc-d03c-4671-88c7-e9486a586642"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("ffbff040-d126-45ac-bbb5-2a5161f82f93"));

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
                    { new Guid("066ac7f9-e882-475f-bbfd-8f190e615616"), "combined.abuse.ch", 1683372065L, "https://abuse.ch/?p=532", 1, "Abuse.ch", 0, 1683372065L },
                    { new Guid("1815dd31-d5c5-4738-a6b5-0b133fef008a"), "spam.dnsbl.anonmails.de", 1683372065L, "https://anonmails.de/dnsbl.php?ip=ADDRESS", 1, "Annonmails.de", 0, 1683372065L },
                    { new Guid("2636439a-b0ae-4477-a6bd-c9feb1975528"), "url.0spam.org", 1683372065L, "https://check.0spam.org/q/?ipaddr=ADDRESS", 1, "0 Spam", 1, 1683372065L },
                    { new Guid("2aea4ee4-f75e-4361-8e3e-f99e2b91aef7"), "cbl.abuseat.org", 1683372065L, "http://www.abuseat.org", 1, "Abuseeat", 0, 1683372065L },
                    { new Guid("35ae8fb7-e6a6-4793-a81a-ec894d05f3e6"), "web.dnsbl.sorbs.net", 1683372065L, "http://www.sorbs.net/lookup.shtml", 3, "Web Sorbs", 1, 1683372065L },
                    { new Guid("3f270240-6ffd-4aeb-9edf-2968ebfcb39e"), "b.barracudacentral.org", 1683372065L, "http://barracudacentral.org/rbl", 1, "Barracuda", 0, 1683372065L },
                    { new Guid("414f8369-4fe5-4b2c-acc4-9a7219ff5013"), "bl.spamcop.com", 1683372065L, "https://www.spamcop.net/bl.shtml", 1, "SpamCop", 0, 1683372065L },
                    { new Guid("553614b0-48d7-4529-a0a4-f95e1b049b79"), "zen.spamhaus.org", 1683372065L, "http://www.spamhaus.org/zen/", 2, "Spamhaus", 0, 1683372065L },
                    { new Guid("687c2277-f520-485e-9525-17add86c3264"), "dnsbl-3.uceprotect.net", 1683372065L, "http://www.uceprotect.net/en/rblcheck.php?ipr=ADDRESS", 2, "UCEPROTECTL3", 0, 1683372065L },
                    { new Guid("68c91dcc-31ed-49a6-b3f6-0cb62c92c443"), "ix.dnsbl.manitu.net", 1683372065L, "https://www.nixspam.net/lookup.php?language=en&value=ADDRESS", 1, "Manitu", 0, 1683372065L },
                    { new Guid("721b66aa-6534-4119-859f-b9862957393a"), "spam.spamrats.com", 1683372065L, "https://www.spamrats.com/lookup.php?ip=ADDRESS", 0, "Spam Rats", 0, 1683372065L },
                    { new Guid("7491c680-a071-4972-82f9-b7d13e523113"), "spam.dnsbl.sorbs.net", 1683372065L, "http://www.sorbs.net/lookup.shtml", 3, "Spam Sorbs", 0, 1683372065L },
                    { new Guid("919bfb97-0db7-4f43-9b57-6bf57e1bb658"), "ips.backscatterer.org", 1683372065L, "http://www.backscatterer.org/?target=test", 2, "backscatterer", 0, 1683372065L },
                    { new Guid("9ca9a5a6-e4cb-4ada-b9bd-81ba9b163027"), "smtp.dnsbl.sorbs.net", 1683372065L, "http://www.sorbs.net/lookup.shtml", 3, "SMTP Relay Sorbs", 0, 1683372065L },
                    { new Guid("b48850b5-c05c-4bc6-b97d-cc0f1ae91488"), "z.mailspike.net", 1683372065L, "https://mailspike.org/iplookup.html", 1, "Mailspike", 0, 1683372065L },
                    { new Guid("bd9ee37a-02d5-4e67-a4bc-6a70dcbac356"), "ubl.lashback.com", 1683372065L, "https://blacklist.lashback.com/?ipAddress=ADDRESS", 3, "Lashback", 0, 1683372065L },
                    { new Guid("c43ce0ec-d77d-4330-8172-a1ba18a52c02"), "bl.rspamd.com", 1683372065L, "https://bl.rspamd.com/", 1, "RBL Rspamd", 1, 1683372065L },
                    { new Guid("d6327ed8-5ca5-4998-8e98-b4ce0e99a85f"), "psbl.surriel.com", 1683372065L, "https://psbl.org/listing?ip=ADDRESS", 1, "PSBL Surriel", 0, 1683372065L },
                    { new Guid("e4c55859-c661-4ee2-81ee-99b6e2677c3d"), "0spam.fusionzero.com", 1683372065L, "https://check.0spam.org/q/?ipaddr=ADDRESS", 1, "0 Spam", 0, 1683372065L },
                    { new Guid("e6095edc-d03c-4671-88c7-e9486a586642"), "dnsbl-1.uceprotect.net", 1683372065L, "http://www.uceprotect.net/en/rblcheck.php?ipr=ADDRESS", 2, "UCEPROTECTL1", 0, 1683372065L },
                    { new Guid("ffbff040-d126-45ac-bbb5-2a5161f82f93"), "dnsbl-2.uceprotect.net", 1683372065L, "http://www.uceprotect.net/en/rblcheck.php?ipr=ADDRESS", 2, "UCEPROTECTL2", 0, 1683372065L }
                });
        }
    }
}
