﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using rbl_tracker.Data;

#nullable disable

namespace rbl_tracker.Migrations.MySql
{
    [DbContext(typeof(MySqlDbContext))]
    [Migration("20230502200442_InitialRblSeeding")]
    partial class InitialRblSeeding
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("rbl_tracker.Models.Domain", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("CreateTime")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid?>("OwnerId")
                        .HasColumnType("char(36)");

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
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("CreateTime")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid?>("OwnerId")
                        .HasColumnType("char(36)");

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
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("CreateTime")
                        .HasColumnType("bigint");

                    b.Property<string>("DelistUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<long>("UpdateTime")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Rbls");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9a77c2df-294c-44d8-afc1-4cc10942684e"),
                            Address = "bl.spamcop.com",
                            CreateTime = 1683057882L,
                            DelistUrl = "https://www.spamcop.net/bl.shtml",
                            Level = 1,
                            Name = "SpamCop",
                            Type = 0,
                            UpdateTime = 1683057882L
                        },
                        new
                        {
                            Id = new Guid("66f2d01a-eeb8-41bd-9b92-091a0ad4c189"),
                            Address = "0spam.fusionzero.com",
                            CreateTime = 1683057882L,
                            DelistUrl = "https://check.0spam.org/q/?ipaddr=ADDRESS",
                            Level = 1,
                            Name = "0 Spam",
                            Type = 0,
                            UpdateTime = 1683057882L
                        },
                        new
                        {
                            Id = new Guid("908256b4-3d8b-4421-adf4-3c67fdcfc028"),
                            Address = "url.0spam.org",
                            CreateTime = 1683057882L,
                            DelistUrl = "https://check.0spam.org/q/?ipaddr=ADDRESS",
                            Level = 1,
                            Name = "0 Spam",
                            Type = 1,
                            UpdateTime = 1683057882L
                        },
                        new
                        {
                            Id = new Guid("22dc3782-c63c-4a07-9c7c-6152bc211c78"),
                            Address = "ips.backscatterer.org",
                            CreateTime = 1683057882L,
                            DelistUrl = "http://www.backscatterer.org/?target=test",
                            Level = 2,
                            Name = "backscatterer",
                            Type = 0,
                            UpdateTime = 1683057882L
                        },
                        new
                        {
                            Id = new Guid("c1b4811b-7169-498a-afe2-0f976e6179ae"),
                            Address = "combined.abuse.ch",
                            CreateTime = 1683057882L,
                            DelistUrl = "https://abuse.ch/?p=532",
                            Level = 1,
                            Name = "Abuse.ch",
                            Type = 0,
                            UpdateTime = 1683057882L
                        },
                        new
                        {
                            Id = new Guid("dacdfe20-f6f0-4977-8b39-c201ee393dd3"),
                            Address = "zen.spamhaus.org",
                            CreateTime = 1683057882L,
                            DelistUrl = "http://www.spamhaus.org/zen/",
                            Level = 2,
                            Name = "Spamhaus",
                            Type = 0,
                            UpdateTime = 1683057882L
                        },
                        new
                        {
                            Id = new Guid("1761879c-cf4a-4591-8811-454c9b3fcc44"),
                            Address = "spam.spamrats.com",
                            CreateTime = 1683057882L,
                            DelistUrl = "https://www.spamrats.com/lookup.php?ip=ADDRESS",
                            Level = 0,
                            Name = "Spam Rats",
                            Type = 0,
                            UpdateTime = 1683057882L
                        },
                        new
                        {
                            Id = new Guid("2a2c789c-917e-4bb0-af49-3383e0a37004"),
                            Address = "b.barracudacentral.org",
                            CreateTime = 1683057882L,
                            DelistUrl = "http://barracudacentral.org/rbl",
                            Level = 1,
                            Name = "Barracuda",
                            Type = 0,
                            UpdateTime = 1683057882L
                        },
                        new
                        {
                            Id = new Guid("86877c8f-d7af-46d1-937f-050c438b48c9"),
                            Address = "ix.dnsbl.manitu.net",
                            CreateTime = 1683057882L,
                            DelistUrl = "https://www.nixspam.net/lookup.php?language=en&value=ADDRESS",
                            Level = 1,
                            Name = "Manitu",
                            Type = 0,
                            UpdateTime = 1683057882L
                        },
                        new
                        {
                            Id = new Guid("00afda12-e95f-4eff-b737-be9a931d08d9"),
                            Address = "spam.dnsbl.sorbs.net",
                            CreateTime = 1683057882L,
                            DelistUrl = "http://www.sorbs.net/lookup.shtml",
                            Level = 3,
                            Name = "Spam Sorbs",
                            Type = 0,
                            UpdateTime = 1683057882L
                        },
                        new
                        {
                            Id = new Guid("bf997e1a-b64e-4c76-a112-cded9df67449"),
                            Address = "smtp.dnsbl.sorbs.net",
                            CreateTime = 1683057882L,
                            DelistUrl = "http://www.sorbs.net/lookup.shtml",
                            Level = 3,
                            Name = "SMTP Relay Sorbs",
                            Type = 0,
                            UpdateTime = 1683057882L
                        },
                        new
                        {
                            Id = new Guid("757bd216-e6dc-4017-acf0-8aec16bec089"),
                            Address = "web.dnsbl.sorbs.net",
                            CreateTime = 1683057882L,
                            DelistUrl = "http://www.sorbs.net/lookup.shtml",
                            Level = 3,
                            Name = "Web Sorbs",
                            Type = 1,
                            UpdateTime = 1683057882L
                        },
                        new
                        {
                            Id = new Guid("46517e9e-42a8-495b-9ca2-7d41e902dc31"),
                            Address = "spam.dnsbl.anonmails.de",
                            CreateTime = 1683057882L,
                            DelistUrl = "https://anonmails.de/dnsbl.php?ip=ADDRESS",
                            Level = 1,
                            Name = "Annonmails.de",
                            Type = 0,
                            UpdateTime = 1683057882L
                        },
                        new
                        {
                            Id = new Guid("5109a007-7372-4cc0-a8ef-0534c74557d0"),
                            Address = "ubl.lashback.com",
                            CreateTime = 1683057882L,
                            DelistUrl = "https://blacklist.lashback.com/?ipAddress=ADDRESS",
                            Level = 3,
                            Name = "Lashback",
                            Type = 0,
                            UpdateTime = 1683057882L
                        },
                        new
                        {
                            Id = new Guid("629df5cd-f77a-4dcb-a657-6508141ce4c8"),
                            Address = "z.mailspike.net",
                            CreateTime = 1683057882L,
                            DelistUrl = "https://mailspike.org/iplookup.html",
                            Level = 1,
                            Name = "Mailspike",
                            Type = 0,
                            UpdateTime = 1683057882L
                        },
                        new
                        {
                            Id = new Guid("ef7f721e-f3cf-4a45-9aa6-0286ad8ff02c"),
                            Address = "cbl.abuseat.org",
                            CreateTime = 1683057882L,
                            DelistUrl = "http://www.abuseat.org",
                            Level = 1,
                            Name = "Abuseeat",
                            Type = 0,
                            UpdateTime = 1683057882L
                        },
                        new
                        {
                            Id = new Guid("2cdf598f-be16-4217-83a2-59e7810db9d9"),
                            Address = "psbl.surriel.com",
                            CreateTime = 1683057882L,
                            DelistUrl = "https://psbl.org/listing?ip=ADDRESS",
                            Level = 1,
                            Name = "PSBL Surriel",
                            Type = 0,
                            UpdateTime = 1683057882L
                        },
                        new
                        {
                            Id = new Guid("603f0c3c-131a-40d8-9302-61f3a7f0e623"),
                            Address = "bl.rspamd.com",
                            CreateTime = 1683057882L,
                            DelistUrl = "https://bl.rspamd.com/",
                            Level = 1,
                            Name = "RBL Rspamd",
                            Type = 1,
                            UpdateTime = 1683057882L
                        });
                });

            modelBuilder.Entity("rbl_tracker.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<long>("CreateTime")
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<byte[]>("PaswordHash")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<byte[]>("PaswordSalt")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<long>("UpdateTime")
                        .HasColumnType("bigint");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

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