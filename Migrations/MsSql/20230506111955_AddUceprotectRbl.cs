using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace rbl_tracker.Migrations.MsSql
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
                    { new Guid("087e7d80-b1d5-4a23-bdeb-7744df023236"), "smtp.dnsbl.sorbs.net", 1683371995L, "http://www.sorbs.net/lookup.shtml", 3, "SMTP Relay Sorbs", 0, 1683371995L },
                    { new Guid("26527291-7b48-41f4-bca7-0918885b5751"), "bl.rspamd.com", 1683371995L, "https://bl.rspamd.com/", 1, "RBL Rspamd", 1, 1683371995L },
                    { new Guid("28e71050-6c15-41d0-a70e-250cb85d1d6c"), "ubl.lashback.com", 1683371995L, "https://blacklist.lashback.com/?ipAddress=ADDRESS", 3, "Lashback", 0, 1683371995L },
                    { new Guid("34bd864f-b957-4057-8e3d-6d5dc6cf090c"), "spam.spamrats.com", 1683371995L, "https://www.spamrats.com/lookup.php?ip=ADDRESS", 0, "Spam Rats", 0, 1683371995L },
                    { new Guid("4c652f69-fc96-4461-92de-bd77026b49d4"), "dnsbl-2.uceprotect.net", 1683371995L, "http://www.uceprotect.net/en/rblcheck.php?ipr=ADDRESS", 2, "UCEPROTECTL2", 0, 1683371995L },
                    { new Guid("553cd051-b9a2-4510-98d9-5618bd57fe95"), "web.dnsbl.sorbs.net", 1683371995L, "http://www.sorbs.net/lookup.shtml", 3, "Web Sorbs", 1, 1683371995L },
                    { new Guid("5aa9d6b5-4f89-49ad-a358-024495447364"), "psbl.surriel.com", 1683371995L, "https://psbl.org/listing?ip=ADDRESS", 1, "PSBL Surriel", 0, 1683371995L },
                    { new Guid("5d51ea27-f920-4411-a9c5-b4b1f45c687c"), "combined.abuse.ch", 1683371995L, "https://abuse.ch/?p=532", 1, "Abuse.ch", 0, 1683371995L },
                    { new Guid("5fe10854-f921-4058-a089-de736e01b1b6"), "b.barracudacentral.org", 1683371995L, "http://barracudacentral.org/rbl", 1, "Barracuda", 0, 1683371995L },
                    { new Guid("68279004-38e3-4a95-a478-f0dde1627f66"), "bl.spamcop.com", 1683371995L, "https://www.spamcop.net/bl.shtml", 1, "SpamCop", 0, 1683371995L },
                    { new Guid("89c62bc7-b0a9-4531-ab47-e1c0a231ef27"), "spam.dnsbl.sorbs.net", 1683371995L, "http://www.sorbs.net/lookup.shtml", 3, "Spam Sorbs", 0, 1683371995L },
                    { new Guid("90dbfb97-0cae-4238-8d05-990a4c53b7bf"), "spam.dnsbl.anonmails.de", 1683371995L, "https://anonmails.de/dnsbl.php?ip=ADDRESS", 1, "Annonmails.de", 0, 1683371995L },
                    { new Guid("be14be2f-73c0-4068-aaae-44fee8ec509c"), "url.0spam.org", 1683371995L, "https://check.0spam.org/q/?ipaddr=ADDRESS", 1, "0 Spam", 1, 1683371995L },
                    { new Guid("c3bbbbb6-5d5c-4689-ab6a-e6421e00db2a"), "ips.backscatterer.org", 1683371995L, "http://www.backscatterer.org/?target=test", 2, "backscatterer", 0, 1683371995L },
                    { new Guid("cd5a0c31-9ade-4717-9368-0ca70c1f26ef"), "ix.dnsbl.manitu.net", 1683371995L, "https://www.nixspam.net/lookup.php?language=en&value=ADDRESS", 1, "Manitu", 0, 1683371995L },
                    { new Guid("d4d15947-810d-45a2-803c-9457960d2f76"), "zen.spamhaus.org", 1683371995L, "http://www.spamhaus.org/zen/", 2, "Spamhaus", 0, 1683371995L },
                    { new Guid("da3b133e-fa12-4c27-9e31-37b3edb28f03"), "dnsbl-1.uceprotect.net", 1683371995L, "http://www.uceprotect.net/en/rblcheck.php?ipr=ADDRESS", 2, "UCEPROTECTL1", 0, 1683371995L },
                    { new Guid("dd5aa44f-5e5e-4091-8688-41a5cf14763a"), "0spam.fusionzero.com", 1683371995L, "https://check.0spam.org/q/?ipaddr=ADDRESS", 1, "0 Spam", 0, 1683371995L },
                    { new Guid("e803862b-e0f1-4668-ad59-e1006dd99808"), "dnsbl-3.uceprotect.net", 1683371995L, "http://www.uceprotect.net/en/rblcheck.php?ipr=ADDRESS", 2, "UCEPROTECTL3", 0, 1683371995L },
                    { new Guid("ec25c85e-274b-4c00-81ab-9ba104df65b0"), "z.mailspike.net", 1683371995L, "https://mailspike.org/iplookup.html", 1, "Mailspike", 0, 1683371995L },
                    { new Guid("f83a8965-9bda-4f1d-b046-8f8f7fda02b2"), "cbl.abuseat.org", 1683371995L, "http://www.abuseat.org", 1, "Abuseeat", 0, 1683371995L }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("087e7d80-b1d5-4a23-bdeb-7744df023236"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("26527291-7b48-41f4-bca7-0918885b5751"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("28e71050-6c15-41d0-a70e-250cb85d1d6c"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("34bd864f-b957-4057-8e3d-6d5dc6cf090c"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("4c652f69-fc96-4461-92de-bd77026b49d4"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("553cd051-b9a2-4510-98d9-5618bd57fe95"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("5aa9d6b5-4f89-49ad-a358-024495447364"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("5d51ea27-f920-4411-a9c5-b4b1f45c687c"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("5fe10854-f921-4058-a089-de736e01b1b6"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("68279004-38e3-4a95-a478-f0dde1627f66"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("89c62bc7-b0a9-4531-ab47-e1c0a231ef27"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("90dbfb97-0cae-4238-8d05-990a4c53b7bf"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("be14be2f-73c0-4068-aaae-44fee8ec509c"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("c3bbbbb6-5d5c-4689-ab6a-e6421e00db2a"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("cd5a0c31-9ade-4717-9368-0ca70c1f26ef"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("d4d15947-810d-45a2-803c-9457960d2f76"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("da3b133e-fa12-4c27-9e31-37b3edb28f03"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("dd5aa44f-5e5e-4091-8688-41a5cf14763a"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("e803862b-e0f1-4668-ad59-e1006dd99808"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("ec25c85e-274b-4c00-81ab-9ba104df65b0"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("f83a8965-9bda-4f1d-b046-8f8f7fda02b2"));

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
        }
    }
}
