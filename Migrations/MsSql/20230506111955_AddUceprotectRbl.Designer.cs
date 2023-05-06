﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using rbl_tracker.Data;

#nullable disable

namespace rbl_tracker.Migrations.MsSql
{
    [DbContext(typeof(MsSqlDbContext))]
    [Migration("20230506111955_AddUceprotectRbl")]
    partial class AddUceprotectRbl
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CheckRblHistoryRbl", b =>
                {
                    b.Property<Guid>("DetectedHistoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RblsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("DetectedHistoryId", "RblsId");

                    b.HasIndex("RblsId");

                    b.ToTable("CheckRblHistoryRbl");
                });

            modelBuilder.Entity("rbl_tracker.Models.CheckRblHistory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("CheckTime")
                        .HasColumnType("bigint");

                    b.Property<Guid?>("Domain")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Ip")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Level")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CheckRblHistory");
                });

            modelBuilder.Entity("rbl_tracker.Models.Domain", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CreateTime")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("OwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("UpdateTime")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Domains");
                });

            modelBuilder.Entity("rbl_tracker.Models.Ip", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CreateTime")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("OwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("UpdateTime")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Ips");
                });

            modelBuilder.Entity("rbl_tracker.Models.Rbl", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CreateTime")
                        .HasColumnType("bigint");

                    b.Property<string>("DelistUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<long>("UpdateTime")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Rbls");

                    b.HasData(
                        new
                        {
                            Id = new Guid("68279004-38e3-4a95-a478-f0dde1627f66"),
                            Address = "bl.spamcop.com",
                            CreateTime = 1683371995L,
                            DelistUrl = "https://www.spamcop.net/bl.shtml",
                            Level = 1,
                            Name = "SpamCop",
                            Type = 0,
                            UpdateTime = 1683371995L
                        },
                        new
                        {
                            Id = new Guid("dd5aa44f-5e5e-4091-8688-41a5cf14763a"),
                            Address = "0spam.fusionzero.com",
                            CreateTime = 1683371995L,
                            DelistUrl = "https://check.0spam.org/q/?ipaddr=ADDRESS",
                            Level = 1,
                            Name = "0 Spam",
                            Type = 0,
                            UpdateTime = 1683371995L
                        },
                        new
                        {
                            Id = new Guid("be14be2f-73c0-4068-aaae-44fee8ec509c"),
                            Address = "url.0spam.org",
                            CreateTime = 1683371995L,
                            DelistUrl = "https://check.0spam.org/q/?ipaddr=ADDRESS",
                            Level = 1,
                            Name = "0 Spam",
                            Type = 1,
                            UpdateTime = 1683371995L
                        },
                        new
                        {
                            Id = new Guid("c3bbbbb6-5d5c-4689-ab6a-e6421e00db2a"),
                            Address = "ips.backscatterer.org",
                            CreateTime = 1683371995L,
                            DelistUrl = "http://www.backscatterer.org/?target=test",
                            Level = 2,
                            Name = "backscatterer",
                            Type = 0,
                            UpdateTime = 1683371995L
                        },
                        new
                        {
                            Id = new Guid("5d51ea27-f920-4411-a9c5-b4b1f45c687c"),
                            Address = "combined.abuse.ch",
                            CreateTime = 1683371995L,
                            DelistUrl = "https://abuse.ch/?p=532",
                            Level = 1,
                            Name = "Abuse.ch",
                            Type = 0,
                            UpdateTime = 1683371995L
                        },
                        new
                        {
                            Id = new Guid("d4d15947-810d-45a2-803c-9457960d2f76"),
                            Address = "zen.spamhaus.org",
                            CreateTime = 1683371995L,
                            DelistUrl = "http://www.spamhaus.org/zen/",
                            Level = 2,
                            Name = "Spamhaus",
                            Type = 0,
                            UpdateTime = 1683371995L
                        },
                        new
                        {
                            Id = new Guid("34bd864f-b957-4057-8e3d-6d5dc6cf090c"),
                            Address = "spam.spamrats.com",
                            CreateTime = 1683371995L,
                            DelistUrl = "https://www.spamrats.com/lookup.php?ip=ADDRESS",
                            Level = 0,
                            Name = "Spam Rats",
                            Type = 0,
                            UpdateTime = 1683371995L
                        },
                        new
                        {
                            Id = new Guid("5fe10854-f921-4058-a089-de736e01b1b6"),
                            Address = "b.barracudacentral.org",
                            CreateTime = 1683371995L,
                            DelistUrl = "http://barracudacentral.org/rbl",
                            Level = 1,
                            Name = "Barracuda",
                            Type = 0,
                            UpdateTime = 1683371995L
                        },
                        new
                        {
                            Id = new Guid("cd5a0c31-9ade-4717-9368-0ca70c1f26ef"),
                            Address = "ix.dnsbl.manitu.net",
                            CreateTime = 1683371995L,
                            DelistUrl = "https://www.nixspam.net/lookup.php?language=en&value=ADDRESS",
                            Level = 1,
                            Name = "Manitu",
                            Type = 0,
                            UpdateTime = 1683371995L
                        },
                        new
                        {
                            Id = new Guid("89c62bc7-b0a9-4531-ab47-e1c0a231ef27"),
                            Address = "spam.dnsbl.sorbs.net",
                            CreateTime = 1683371995L,
                            DelistUrl = "http://www.sorbs.net/lookup.shtml",
                            Level = 3,
                            Name = "Spam Sorbs",
                            Type = 0,
                            UpdateTime = 1683371995L
                        },
                        new
                        {
                            Id = new Guid("087e7d80-b1d5-4a23-bdeb-7744df023236"),
                            Address = "smtp.dnsbl.sorbs.net",
                            CreateTime = 1683371995L,
                            DelistUrl = "http://www.sorbs.net/lookup.shtml",
                            Level = 3,
                            Name = "SMTP Relay Sorbs",
                            Type = 0,
                            UpdateTime = 1683371995L
                        },
                        new
                        {
                            Id = new Guid("553cd051-b9a2-4510-98d9-5618bd57fe95"),
                            Address = "web.dnsbl.sorbs.net",
                            CreateTime = 1683371995L,
                            DelistUrl = "http://www.sorbs.net/lookup.shtml",
                            Level = 3,
                            Name = "Web Sorbs",
                            Type = 1,
                            UpdateTime = 1683371995L
                        },
                        new
                        {
                            Id = new Guid("90dbfb97-0cae-4238-8d05-990a4c53b7bf"),
                            Address = "spam.dnsbl.anonmails.de",
                            CreateTime = 1683371995L,
                            DelistUrl = "https://anonmails.de/dnsbl.php?ip=ADDRESS",
                            Level = 1,
                            Name = "Annonmails.de",
                            Type = 0,
                            UpdateTime = 1683371995L
                        },
                        new
                        {
                            Id = new Guid("28e71050-6c15-41d0-a70e-250cb85d1d6c"),
                            Address = "ubl.lashback.com",
                            CreateTime = 1683371995L,
                            DelistUrl = "https://blacklist.lashback.com/?ipAddress=ADDRESS",
                            Level = 3,
                            Name = "Lashback",
                            Type = 0,
                            UpdateTime = 1683371995L
                        },
                        new
                        {
                            Id = new Guid("ec25c85e-274b-4c00-81ab-9ba104df65b0"),
                            Address = "z.mailspike.net",
                            CreateTime = 1683371995L,
                            DelistUrl = "https://mailspike.org/iplookup.html",
                            Level = 1,
                            Name = "Mailspike",
                            Type = 0,
                            UpdateTime = 1683371995L
                        },
                        new
                        {
                            Id = new Guid("f83a8965-9bda-4f1d-b046-8f8f7fda02b2"),
                            Address = "cbl.abuseat.org",
                            CreateTime = 1683371995L,
                            DelistUrl = "http://www.abuseat.org",
                            Level = 1,
                            Name = "Abuseeat",
                            Type = 0,
                            UpdateTime = 1683371995L
                        },
                        new
                        {
                            Id = new Guid("5aa9d6b5-4f89-49ad-a358-024495447364"),
                            Address = "psbl.surriel.com",
                            CreateTime = 1683371995L,
                            DelistUrl = "https://psbl.org/listing?ip=ADDRESS",
                            Level = 1,
                            Name = "PSBL Surriel",
                            Type = 0,
                            UpdateTime = 1683371995L
                        },
                        new
                        {
                            Id = new Guid("26527291-7b48-41f4-bca7-0918885b5751"),
                            Address = "bl.rspamd.com",
                            CreateTime = 1683371995L,
                            DelistUrl = "https://bl.rspamd.com/",
                            Level = 1,
                            Name = "RBL Rspamd",
                            Type = 1,
                            UpdateTime = 1683371995L
                        },
                        new
                        {
                            Id = new Guid("da3b133e-fa12-4c27-9e31-37b3edb28f03"),
                            Address = "dnsbl-1.uceprotect.net",
                            CreateTime = 1683371995L,
                            DelistUrl = "http://www.uceprotect.net/en/rblcheck.php?ipr=ADDRESS",
                            Level = 2,
                            Name = "UCEPROTECTL1",
                            Type = 0,
                            UpdateTime = 1683371995L
                        },
                        new
                        {
                            Id = new Guid("4c652f69-fc96-4461-92de-bd77026b49d4"),
                            Address = "dnsbl-2.uceprotect.net",
                            CreateTime = 1683371995L,
                            DelistUrl = "http://www.uceprotect.net/en/rblcheck.php?ipr=ADDRESS",
                            Level = 2,
                            Name = "UCEPROTECTL2",
                            Type = 0,
                            UpdateTime = 1683371995L
                        },
                        new
                        {
                            Id = new Guid("e803862b-e0f1-4668-ad59-e1006dd99808"),
                            Address = "dnsbl-3.uceprotect.net",
                            CreateTime = 1683371995L,
                            DelistUrl = "http://www.uceprotect.net/en/rblcheck.php?ipr=ADDRESS",
                            Level = 2,
                            Name = "UCEPROTECTL3",
                            Type = 0,
                            UpdateTime = 1683371995L
                        });
                });

            modelBuilder.Entity("rbl_tracker.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("CreateTime")
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PaswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PaswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<long>("UpdateTime")
                        .HasColumnType("bigint");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CheckRblHistoryRbl", b =>
                {
                    b.HasOne("rbl_tracker.Models.CheckRblHistory", null)
                        .WithMany()
                        .HasForeignKey("DetectedHistoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("rbl_tracker.Models.Rbl", null)
                        .WithMany()
                        .HasForeignKey("RblsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("rbl_tracker.Models.Domain", b =>
                {
                    b.HasOne("rbl_tracker.Models.User", "Owner")
                        .WithMany("Domains")
                        .HasForeignKey("OwnerId");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("rbl_tracker.Models.Ip", b =>
                {
                    b.HasOne("rbl_tracker.Models.User", "Owner")
                        .WithMany("Ips")
                        .HasForeignKey("OwnerId");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("rbl_tracker.Models.User", b =>
                {
                    b.Navigation("Domains");

                    b.Navigation("Ips");
                });
#pragma warning restore 612, 618
        }
    }
}