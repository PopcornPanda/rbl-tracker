using System.Reflection;

namespace rbl_tracker.Data
{
    public abstract class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        protected DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rbl>().HasData(
                new Rbl { Id = new Guid("ec25c85e-f74b-4c00-81ab-9ba104df65b0"), Name = "SpamCop", Address = "bl.spamcop.com", Type = RblType.Rbl, Level = RblLevel.Normal, DelistUrl = "https://www.spamcop.net/bl.shtml", CreateTime = 1683371995L, UpdateTime = 1683371995L },
                new Rbl { Id = new Guid("f83a8965-9baa-4f1d-b046-8f8f7fda02b2"), Name = "0 Spam", Address = "0spam.fusionzero.com", Type = RblType.Rbl, Level = RblLevel.Normal, DelistUrl = "https://check.0spam.org/q/?ipaddr=ADDRESS", CreateTime = 1683371995L, UpdateTime = 1683371995L },
                new Rbl { Id = new Guid("68279004-38ec-4a95-a478-f0dde1627f66"), Name = "0 Spam", Address = "url.0spam.org", Type = RblType.Surbl, Level = RblLevel.Normal, DelistUrl = "https://check.0spam.org/q/?ipaddr=ADDRESS", CreateTime = 1683371995L, UpdateTime = 1683371995L },
                new Rbl { Id = new Guid("359b681e-cea9-4745-b371-781db51793d4"), Name = "backscatterer", Address = "ips.backscatterer.org", Type = RblType.Rbl, Level = RblLevel.High, DelistUrl = "http://www.backscatterer.org/?target=test", CreateTime = 1683371995L, UpdateTime = 1683371995L },
                new Rbl { Id = new Guid("457913af-bb40-4edb-aca6-97029171acb3"), Name = "Abuse.ch", Address = "combined.abuse.ch", Type = RblType.Rbl, Level = RblLevel.Normal, DelistUrl = "https://abuse.ch/?p=532", CreateTime = 1683371995L, UpdateTime = 1683371995L },
                new Rbl { Id = new Guid("533ebb64-91e3-4339-ae1c-170598cd0576"), Name = "Spamhaus", Address = "zen.spamhaus.org", Type = RblType.Rbl, Level = RblLevel.High, DelistUrl = "http://www.spamhaus.org/zen/", CreateTime = 1683371995L, UpdateTime = 1683371995L },
                new Rbl { Id = new Guid("63758d1d-7526-4711-887c-2316573fe0c0"), Name = "Spam Rats", Address = "spam.spamrats.com", Type = RblType.Rbl, Level = RblLevel.Low, DelistUrl = "https://www.spamrats.com/lookup.php?ip=ADDRESS", CreateTime = 1683371995L, UpdateTime = 1683371995L },
                new Rbl { Id = new Guid("691a6283-45e3-418a-b343-b3db99099e56"), Name = "Barracuda", Address = "b.barracudacentral.org", Type = RblType.Rbl, Level = RblLevel.Normal, DelistUrl = "http://barracudacentral.org/rbl", CreateTime = 1683371995L, UpdateTime = 1683371995L },
                new Rbl { Id = new Guid("8c8a2282-bd61-461f-8789-d72409bb2d54"), Name = "Manitu", Address = "ix.dnsbl.manitu.net", Type = RblType.Rbl, Level = RblLevel.Normal, DelistUrl = "https://www.nixspam.net/lookup.php?language=en&value=ADDRESS", CreateTime = 1683371995L, UpdateTime = 1683371995L },
                new Rbl { Id = new Guid("93c0e753-ba32-421d-824f-8e053d345cf5"), Name = "Spam Sorbs", Address = "spam.dnsbl.sorbs.net", Type = RblType.Rbl, Level = RblLevel.Critical, DelistUrl = "http://www.sorbs.net/lookup.shtml", CreateTime = 1683371995L, UpdateTime = 1683371995L },
                new Rbl { Id = new Guid("94b40f9f-3b23-475a-aa15-eaf2c490f2c7"), Name = "SMTP Relay Sorbs", Address = "smtp.dnsbl.sorbs.net", Type = RblType.Rbl, Level = RblLevel.Critical, DelistUrl = "http://www.sorbs.net/lookup.shtml", CreateTime = 1683371995L, UpdateTime = 1683371995L },
                new Rbl { Id = new Guid("b5282858-7a75-4352-9f1f-61a080a0bee9"), Name = "Web Sorbs", Address = "web.dnsbl.sorbs.net", Type = RblType.Surbl, Level = RblLevel.Critical, DelistUrl = "http://www.sorbs.net/lookup.shtml", CreateTime = 1683371995L, UpdateTime = 1683371995L },
                new Rbl { Id = new Guid("b9ddf87e-7897-4942-8573-b52da489454f"), Name = "Annonmails.de", Address = "spam.dnsbl.anonmails.de", Type = RblType.Rbl, Level = RblLevel.Normal, DelistUrl = "https://anonmails.de/dnsbl.php?ip=ADDRESS", CreateTime = 1683371995L, UpdateTime = 1683371995L },
                new Rbl { Id = new Guid("bbdd363c-5e59-4800-8dd9-2bb7cf330a4e"), Name = "Lashback", Address = "ubl.lashback.com", Type = RblType.Rbl, Level = RblLevel.Critical, DelistUrl = "https://blacklist.lashback.com/?ipAddress=ADDRESS", CreateTime = 1683371995L, UpdateTime = 1683371995L },
                new Rbl { Id = new Guid("c352113e-be6a-43d9-b40f-e1dc99b5a395"), Name = "Mailspike", Address = "z.mailspike.net", Type = RblType.Rbl, Level = RblLevel.Normal, DelistUrl = "https://mailspike.org/iplookup.html", CreateTime = 1683371995L, UpdateTime = 1683371995L },
                new Rbl { Id = new Guid("c5ac9dbf-3dcc-402b-a05d-841388b39bb4"), Name = "Abuseeat", Address = "cbl.abuseat.org", Type = RblType.Rbl, Level = RblLevel.Normal, DelistUrl = "http://www.abuseat.org", CreateTime = 1683371995L, UpdateTime = 1683371995L },
                new Rbl { Id = new Guid("cb1947de-5ada-4060-9f7b-77e98b507fe2"), Name = "PSBL Surriel", Address = "psbl.surriel.com", Type = RblType.Rbl, Level = RblLevel.Normal, DelistUrl = "https://psbl.org/listing?ip=ADDRESS", CreateTime = 1683371995L, UpdateTime = 1683371995L },
                new Rbl { Id = new Guid("da3d6538-2142-458b-964b-7edf7205b1b3"), Name = "RBL Rspamd", Address = "bl.rspamd.com", Type = RblType.Surbl, Level = RblLevel.Normal, DelistUrl = "https://bl.rspamd.com/", CreateTime = 1683371995L, UpdateTime = 1683371995L },
                new Rbl { Id = new Guid("e97a9339-2e40-46fa-bb71-d4a095639aba"), Name = "UCEPROTECTL1", Address = "dnsbl-1.uceprotect.net", Type = RblType.Rbl, Level = RblLevel.High, DelistUrl = "http://www.uceprotect.net/en/rblcheck.php?ipr=ADDRESS", CreateTime = 1683371995L, UpdateTime = 1683371995L },
                new Rbl { Id = new Guid("f77e8059-5df3-4c79-80ed-4d6f45db8f91"), Name = "UCEPROTECTL2", Address = "dnsbl-2.uceprotect.net", Type = RblType.Rbl, Level = RblLevel.High, DelistUrl = "http://www.uceprotect.net/en/rblcheck.php?ipr=ADDRESS", CreateTime = 1683371995L, UpdateTime = 1683371995L },
                new Rbl { Id = new Guid("f8f83421-1e5e-4deb-9898-f49588a19025"), Name = "UCEPROTECTL3", Address = "dnsbl-3.uceprotect.net", Type = RblType.Rbl, Level = RblLevel.High, DelistUrl = "http://www.uceprotect.net/en/rblcheck.php?ipr=ADDRESS", CreateTime = 1683371995L, UpdateTime = 1683371995L }
            );
            
            modelBuilder.Entity<Models.Host>().HasIndex(h => h.Address).IsUnique();
            modelBuilder.Entity<Models.User>().HasIndex(h => h.Username).IsUnique();
            modelBuilder.Entity<Models.User>().HasIndex(h => h.Email).IsUnique();

        }

        public DbSet<Models.Rbl> Rbls => Set<Models.Rbl>();
        public DbSet<Models.Host> Hosts => Set<Models.Host>();
        public DbSet<Models.User> Users => Set<Models.User>();
        public DbSet<Models.CheckRblHistory> CheckRblHistory => Set<Models.CheckRblHistory>();

        protected void ApplyConfiguration(ModelBuilder modelBuilder, string[] namespaces)
        {
            var methodInfo = (typeof(ModelBuilder).GetMethods()).Single((e =>
                e.Name == "ApplyConfiguration" &&
                e.ContainsGenericParameters &&
                e.GetParameters().SingleOrDefault()?.ParameterType.GetGenericTypeDefinition() ==
                typeof(IEntityTypeConfiguration<>)));

            foreach (var configType in typeof(DataContext)
                        .GetTypeInfo().Assembly
                        .GetTypes()
                        .Where(t => t.Namespace != null &&
                                    namespaces.Any(n => n == t.Namespace) &&
                                    t.GetInterfaces().Any(i => i.IsGenericType &&
                                                                i.GetGenericTypeDefinition() ==
                                                                typeof(IEntityTypeConfiguration<>)
                                    )
                        )
                    )
            {
                var type = configType.GetInterfaces().First();
                methodInfo.MakeGenericMethod(type.GenericTypeArguments[0]).Invoke(modelBuilder, new[]
                {
                    Activator.CreateInstance(configType)
                });
            }
        }

    }

}