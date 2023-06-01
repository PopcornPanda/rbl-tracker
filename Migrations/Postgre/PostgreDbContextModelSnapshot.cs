﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using rbl_tracker.Data;

#nullable disable

namespace rbl_tracker.Migrations.Postgre
{
    [DbContext(typeof(PostgreDbContext))]
    partial class PostgreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CheckRblHistoryRbl", b =>
                {
                    b.Property<Guid>("DetectedHistoryId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RblsId")
                        .HasColumnType("uuid");

                    b.HasKey("DetectedHistoryId", "RblsId");

                    b.HasIndex("RblsId");

                    b.ToTable("CheckRblHistoryRbl");
                });

            modelBuilder.Entity("rbl_tracker.Models.CheckRblHistory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<long>("CheckTime")
                        .HasColumnType("bigint");

                    b.Property<Guid?>("Host")
                        .HasColumnType("uuid");

                    b.Property<int?>("Level")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("CheckRblHistory");
                });

            modelBuilder.Entity("rbl_tracker.Models.Host", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("CreateTime")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("OwnerId")
                        .HasColumnType("uuid");

                    b.Property<long>("UpdateTime")
                        .HasColumnType("bigint");

                    b.Property<bool>("isDomain")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("Address")
                        .IsUnique();

                    b.HasIndex("OwnerId");

                    b.ToTable("Hosts");
                });

            modelBuilder.Entity("rbl_tracker.Models.Rbl", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("CreateTime")
                        .HasColumnType("bigint");

                    b.Property<string>("DelistUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Level")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<long>("UpdateTime")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Rbls");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ec25c85e-f74b-4c00-81ab-9ba104df65b0"),
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
                            Id = new Guid("f83a8965-9baa-4f1d-b046-8f8f7fda02b2"),
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
                            Id = new Guid("68279004-38ec-4a95-a478-f0dde1627f66"),
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
                            Id = new Guid("359b681e-cea9-4745-b371-781db51793d4"),
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
                            Id = new Guid("457913af-bb40-4edb-aca6-97029171acb3"),
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
                            Id = new Guid("533ebb64-91e3-4339-ae1c-170598cd0576"),
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
                            Id = new Guid("63758d1d-7526-4711-887c-2316573fe0c0"),
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
                            Id = new Guid("691a6283-45e3-418a-b343-b3db99099e56"),
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
                            Id = new Guid("8c8a2282-bd61-461f-8789-d72409bb2d54"),
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
                            Id = new Guid("93c0e753-ba32-421d-824f-8e053d345cf5"),
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
                            Id = new Guid("94b40f9f-3b23-475a-aa15-eaf2c490f2c7"),
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
                            Id = new Guid("b5282858-7a75-4352-9f1f-61a080a0bee9"),
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
                            Id = new Guid("b9ddf87e-7897-4942-8573-b52da489454f"),
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
                            Id = new Guid("bbdd363c-5e59-4800-8dd9-2bb7cf330a4e"),
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
                            Id = new Guid("c352113e-be6a-43d9-b40f-e1dc99b5a395"),
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
                            Id = new Guid("c5ac9dbf-3dcc-402b-a05d-841388b39bb4"),
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
                            Id = new Guid("cb1947de-5ada-4060-9f7b-77e98b507fe2"),
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
                            Id = new Guid("da3d6538-2142-458b-964b-7edf7205b1b3"),
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
                            Id = new Guid("e97a9339-2e40-46fa-bb71-d4a095639aba"),
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
                            Id = new Guid("f77e8059-5df3-4c79-80ed-4d6f45db8f91"),
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
                            Id = new Guid("f8f83421-1e5e-4deb-9898-f49588a19025"),
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
                        .HasColumnType("uuid");

                    b.Property<long>("CreateTime")
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("PaswordHash")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<byte[]>("PaswordSalt")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.Property<long>("UpdateTime")
                        .HasColumnType("bigint");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique();

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

            modelBuilder.Entity("rbl_tracker.Models.Host", b =>
                {
                    b.HasOne("rbl_tracker.Models.User", "Owner")
                        .WithMany("Hosts")
                        .HasForeignKey("OwnerId");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("rbl_tracker.Models.User", b =>
                {
                    b.Navigation("Hosts");
                });
#pragma warning restore 612, 618
        }
    }
}
