using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace rbl_tracker.Migrations.MsSql
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
                keyValue: new Guid("01d41189-6050-48ea-9af5-203c52da15a1"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("04511b8a-2729-4392-a585-80358a2327ca"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("048f6376-4aa3-4c39-8989-ebea5017cb57"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("090db1de-7a5a-4388-b6b8-40a284ecf952"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("11ab5993-06b2-4e9d-8080-6afae0ccf5bc"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("1d65a9a3-95dc-4dad-a0cf-aaa4daef925e"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("1eadeafe-55f9-43a6-a618-4b56d6ab33ea"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("29dedb3d-c5d4-4233-a572-0dc99576113f"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("3353a27e-6820-48c5-9a9d-3e8711c96886"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("36a80951-c2e7-4e21-bbea-88a632cd7764"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("49bf3990-4987-43d0-be4b-39645ba7c54d"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("52a41120-c069-4d1f-b5e4-93fad075c654"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("545d2ff3-6ed2-40e6-8ea2-a644bc3d6760"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("5eaa38aa-53c4-4197-8647-70ab0ac711cf"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("6534311c-8b48-4e7b-928f-aaf3e6dd2307"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("7f0dbeb0-b402-4dcf-a637-f5529c40be70"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("86d14c5a-8a22-4c8c-997a-42606bc738b0"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("8dd7a1e4-4f35-424b-891d-48cf96a68105"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("c3c59884-c303-4360-9010-e4ea630de680"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("c669983c-d7b1-40b2-9438-02942c188890"));

            migrationBuilder.DeleteData(
                table: "Rbls",
                keyColumn: "Id",
                keyValue: new Guid("cb4bc95c-b1c0-499f-973f-bfbf6c58ac37"));

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
                    { new Guid("01d41189-6050-48ea-9af5-203c52da15a1"), "combined.abuse.ch", 1683372053L, "https://abuse.ch/?p=532", 1, "Abuse.ch", 0, 1683372053L },
                    { new Guid("04511b8a-2729-4392-a585-80358a2327ca"), "spam.spamrats.com", 1683372053L, "https://www.spamrats.com/lookup.php?ip=ADDRESS", 0, "Spam Rats", 0, 1683372053L },
                    { new Guid("048f6376-4aa3-4c39-8989-ebea5017cb57"), "bl.spamcop.com", 1683372053L, "https://www.spamcop.net/bl.shtml", 1, "SpamCop", 0, 1683372053L },
                    { new Guid("090db1de-7a5a-4388-b6b8-40a284ecf952"), "zen.spamhaus.org", 1683372053L, "http://www.spamhaus.org/zen/", 2, "Spamhaus", 0, 1683372053L },
                    { new Guid("11ab5993-06b2-4e9d-8080-6afae0ccf5bc"), "psbl.surriel.com", 1683372053L, "https://psbl.org/listing?ip=ADDRESS", 1, "PSBL Surriel", 0, 1683372053L },
                    { new Guid("1d65a9a3-95dc-4dad-a0cf-aaa4daef925e"), "bl.rspamd.com", 1683372053L, "https://bl.rspamd.com/", 1, "RBL Rspamd", 1, 1683372053L },
                    { new Guid("1eadeafe-55f9-43a6-a618-4b56d6ab33ea"), "dnsbl-2.uceprotect.net", 1683372053L, "http://www.uceprotect.net/en/rblcheck.php?ipr=ADDRESS", 2, "UCEPROTECTL2", 0, 1683372053L },
                    { new Guid("29dedb3d-c5d4-4233-a572-0dc99576113f"), "dnsbl-1.uceprotect.net", 1683372053L, "http://www.uceprotect.net/en/rblcheck.php?ipr=ADDRESS", 2, "UCEPROTECTL1", 0, 1683372053L },
                    { new Guid("3353a27e-6820-48c5-9a9d-3e8711c96886"), "url.0spam.org", 1683372053L, "https://check.0spam.org/q/?ipaddr=ADDRESS", 1, "0 Spam", 1, 1683372053L },
                    { new Guid("36a80951-c2e7-4e21-bbea-88a632cd7764"), "smtp.dnsbl.sorbs.net", 1683372053L, "http://www.sorbs.net/lookup.shtml", 3, "SMTP Relay Sorbs", 0, 1683372053L },
                    { new Guid("49bf3990-4987-43d0-be4b-39645ba7c54d"), "ubl.lashback.com", 1683372053L, "https://blacklist.lashback.com/?ipAddress=ADDRESS", 3, "Lashback", 0, 1683372053L },
                    { new Guid("52a41120-c069-4d1f-b5e4-93fad075c654"), "dnsbl-3.uceprotect.net", 1683372053L, "http://www.uceprotect.net/en/rblcheck.php?ipr=ADDRESS", 2, "UCEPROTECTL3", 0, 1683372053L },
                    { new Guid("545d2ff3-6ed2-40e6-8ea2-a644bc3d6760"), "b.barracudacentral.org", 1683372053L, "http://barracudacentral.org/rbl", 1, "Barracuda", 0, 1683372053L },
                    { new Guid("5eaa38aa-53c4-4197-8647-70ab0ac711cf"), "spam.dnsbl.anonmails.de", 1683372053L, "https://anonmails.de/dnsbl.php?ip=ADDRESS", 1, "Annonmails.de", 0, 1683372053L },
                    { new Guid("6534311c-8b48-4e7b-928f-aaf3e6dd2307"), "z.mailspike.net", 1683372053L, "https://mailspike.org/iplookup.html", 1, "Mailspike", 0, 1683372053L },
                    { new Guid("7f0dbeb0-b402-4dcf-a637-f5529c40be70"), "ips.backscatterer.org", 1683372053L, "http://www.backscatterer.org/?target=test", 2, "backscatterer", 0, 1683372053L },
                    { new Guid("86d14c5a-8a22-4c8c-997a-42606bc738b0"), "spam.dnsbl.sorbs.net", 1683372053L, "http://www.sorbs.net/lookup.shtml", 3, "Spam Sorbs", 0, 1683372053L },
                    { new Guid("8dd7a1e4-4f35-424b-891d-48cf96a68105"), "ix.dnsbl.manitu.net", 1683372053L, "https://www.nixspam.net/lookup.php?language=en&value=ADDRESS", 1, "Manitu", 0, 1683372053L },
                    { new Guid("c3c59884-c303-4360-9010-e4ea630de680"), "web.dnsbl.sorbs.net", 1683372053L, "http://www.sorbs.net/lookup.shtml", 3, "Web Sorbs", 1, 1683372053L },
                    { new Guid("c669983c-d7b1-40b2-9438-02942c188890"), "cbl.abuseat.org", 1683372053L, "http://www.abuseat.org", 1, "Abuseeat", 0, 1683372053L },
                    { new Guid("cb4bc95c-b1c0-499f-973f-bfbf6c58ac37"), "0spam.fusionzero.com", 1683372053L, "https://check.0spam.org/q/?ipaddr=ADDRESS", 1, "0 Spam", 0, 1683372053L }
                });
        }
    }
}
