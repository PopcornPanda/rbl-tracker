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
    [Migration("20230502200439_InitialRblSeeding")]
    partial class InitialRblSeeding
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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
                            Id = new Guid("ec499a62-9076-4a82-980c-b6da34410b94"),
                            Address = "bl.spamcop.com",
                            CreateTime = 1683057879L,
                            DelistUrl = "https://www.spamcop.net/bl.shtml",
                            Level = 1,
                            Name = "SpamCop",
                            Type = 0,
                            UpdateTime = 1683057879L
                        },
                        new
                        {
                            Id = new Guid("92cb356a-d4d4-48ae-a7a3-160f7aea9420"),
                            Address = "0spam.fusionzero.com",
                            CreateTime = 1683057879L,
                            DelistUrl = "https://check.0spam.org/q/?ipaddr=ADDRESS",
                            Level = 1,
                            Name = "0 Spam",
                            Type = 0,
                            UpdateTime = 1683057879L
                        },
                        new
                        {
                            Id = new Guid("43b31cc1-e403-437e-8fa1-cd090952133f"),
                            Address = "url.0spam.org",
                            CreateTime = 1683057879L,
                            DelistUrl = "https://check.0spam.org/q/?ipaddr=ADDRESS",
                            Level = 1,
                            Name = "0 Spam",
                            Type = 1,
                            UpdateTime = 1683057879L
                        },
                        new
                        {
                            Id = new Guid("a1b99720-cb6f-4dbb-aecb-fd432791e81a"),
                            Address = "ips.backscatterer.org",
                            CreateTime = 1683057879L,
                            DelistUrl = "http://www.backscatterer.org/?target=test",
                            Level = 2,
                            Name = "backscatterer",
                            Type = 0,
                            UpdateTime = 1683057879L
                        },
                        new
                        {
                            Id = new Guid("5f254a79-4b67-46e2-99ca-c666f9c99f6f"),
                            Address = "combined.abuse.ch",
                            CreateTime = 1683057879L,
                            DelistUrl = "https://abuse.ch/?p=532",
                            Level = 1,
                            Name = "Abuse.ch",
                            Type = 0,
                            UpdateTime = 1683057879L
                        },
                        new
                        {
                            Id = new Guid("673193da-825f-462e-b482-9db35792abe6"),
                            Address = "zen.spamhaus.org",
                            CreateTime = 1683057879L,
                            DelistUrl = "http://www.spamhaus.org/zen/",
                            Level = 2,
                            Name = "Spamhaus",
                            Type = 0,
                            UpdateTime = 1683057879L
                        },
                        new
                        {
                            Id = new Guid("6a94a473-2310-421e-b589-532e29ac3554"),
                            Address = "spam.spamrats.com",
                            CreateTime = 1683057879L,
                            DelistUrl = "https://www.spamrats.com/lookup.php?ip=ADDRESS",
                            Level = 0,
                            Name = "Spam Rats",
                            Type = 0,
                            UpdateTime = 1683057879L
                        },
                        new
                        {
                            Id = new Guid("d20d3a61-f45d-4fd1-a21c-80576618f1f9"),
                            Address = "b.barracudacentral.org",
                            CreateTime = 1683057879L,
                            DelistUrl = "http://barracudacentral.org/rbl",
                            Level = 1,
                            Name = "Barracuda",
                            Type = 0,
                            UpdateTime = 1683057879L
                        },
                        new
                        {
                            Id = new Guid("8a8de061-0c10-48f0-b0b1-28c52a219660"),
                            Address = "ix.dnsbl.manitu.net",
                            CreateTime = 1683057879L,
                            DelistUrl = "https://www.nixspam.net/lookup.php?language=en&value=ADDRESS",
                            Level = 1,
                            Name = "Manitu",
                            Type = 0,
                            UpdateTime = 1683057879L
                        },
                        new
                        {
                            Id = new Guid("3cf250b2-5b9f-4683-b1b5-5d8998835061"),
                            Address = "spam.dnsbl.sorbs.net",
                            CreateTime = 1683057879L,
                            DelistUrl = "http://www.sorbs.net/lookup.shtml",
                            Level = 3,
                            Name = "Spam Sorbs",
                            Type = 0,
                            UpdateTime = 1683057879L
                        },
                        new
                        {
                            Id = new Guid("5b3acc3d-67e0-407a-b72b-a4c4776fe0dd"),
                            Address = "smtp.dnsbl.sorbs.net",
                            CreateTime = 1683057879L,
                            DelistUrl = "http://www.sorbs.net/lookup.shtml",
                            Level = 3,
                            Name = "SMTP Relay Sorbs",
                            Type = 0,
                            UpdateTime = 1683057879L
                        },
                        new
                        {
                            Id = new Guid("5be3db5d-79be-4b01-9c81-c8f52dd04c00"),
                            Address = "web.dnsbl.sorbs.net",
                            CreateTime = 1683057879L,
                            DelistUrl = "http://www.sorbs.net/lookup.shtml",
                            Level = 3,
                            Name = "Web Sorbs",
                            Type = 1,
                            UpdateTime = 1683057879L
                        },
                        new
                        {
                            Id = new Guid("3356179c-e410-4c1f-956b-d4e46f1086af"),
                            Address = "spam.dnsbl.anonmails.de",
                            CreateTime = 1683057879L,
                            DelistUrl = "https://anonmails.de/dnsbl.php?ip=ADDRESS",
                            Level = 1,
                            Name = "Annonmails.de",
                            Type = 0,
                            UpdateTime = 1683057879L
                        },
                        new
                        {
                            Id = new Guid("46f7816a-2e49-450c-8d3a-2dff162c0762"),
                            Address = "ubl.lashback.com",
                            CreateTime = 1683057879L,
                            DelistUrl = "https://blacklist.lashback.com/?ipAddress=ADDRESS",
                            Level = 3,
                            Name = "Lashback",
                            Type = 0,
                            UpdateTime = 1683057879L
                        },
                        new
                        {
                            Id = new Guid("74f45960-6fed-4cb6-bfbd-58c2f77e246b"),
                            Address = "z.mailspike.net",
                            CreateTime = 1683057879L,
                            DelistUrl = "https://mailspike.org/iplookup.html",
                            Level = 1,
                            Name = "Mailspike",
                            Type = 0,
                            UpdateTime = 1683057879L
                        },
                        new
                        {
                            Id = new Guid("31f8e2cf-5400-4405-b5d7-a6d3aa450123"),
                            Address = "cbl.abuseat.org",
                            CreateTime = 1683057879L,
                            DelistUrl = "http://www.abuseat.org",
                            Level = 1,
                            Name = "Abuseeat",
                            Type = 0,
                            UpdateTime = 1683057879L
                        },
                        new
                        {
                            Id = new Guid("ebb62dbd-d162-45ca-bfa2-6ff732ac0961"),
                            Address = "psbl.surriel.com",
                            CreateTime = 1683057879L,
                            DelistUrl = "https://psbl.org/listing?ip=ADDRESS",
                            Level = 1,
                            Name = "PSBL Surriel",
                            Type = 0,
                            UpdateTime = 1683057879L
                        },
                        new
                        {
                            Id = new Guid("51267343-aed9-402d-b681-4a27dde2ee66"),
                            Address = "bl.rspamd.com",
                            CreateTime = 1683057879L,
                            DelistUrl = "https://bl.rspamd.com/",
                            Level = 1,
                            Name = "RBL Rspamd",
                            Type = 1,
                            UpdateTime = 1683057879L
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
