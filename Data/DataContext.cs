using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;



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
                new Rbl { Name = "SpamCop", Address = "bl.spamcop.com", Type = RblType.Rbl, Level = RblLevel.Normal, DelistUrl = "https://www.spamcop.net/bl.shtml"},
                new Rbl { Name = "0 Spam", Address = "0spam.fusionzero.com", Type = RblType.Rbl, Level = RblLevel.Normal, DelistUrl = "https://check.0spam.org/q/?ipaddr=ADDRESS"},
                new Rbl { Name = "0 Spam", Address = "url.0spam.org", Type = RblType.Surbl, Level = RblLevel.Normal, DelistUrl = "https://check.0spam.org/q/?ipaddr=ADDRESS"},
                new Rbl { Name = "backscatterer", Address = "ips.backscatterer.org", Type = RblType.Rbl, Level = RblLevel.High, DelistUrl = "http://www.backscatterer.org/?target=test"},
                new Rbl { Name = "Abuse.ch", Address = "combined.abuse.ch", Type = RblType.Rbl, Level = RblLevel.Normal, DelistUrl = "https://abuse.ch/?p=532"},
                new Rbl { Name = "Spamhaus", Address = "zen.spamhaus.org", Type = RblType.Rbl, Level = RblLevel.High, DelistUrl = "http://www.spamhaus.org/zen/"},
                new Rbl { Name = "Spam Rats", Address = "spam.spamrats.com", Type = RblType.Rbl, Level = RblLevel.Low, DelistUrl = "https://www.spamrats.com/lookup.php?ip=ADDRESS"},
                new Rbl { Name = "Barracuda", Address = "b.barracudacentral.org", Type = RblType.Rbl, Level = RblLevel.Normal, DelistUrl = "http://barracudacentral.org/rbl"},
                new Rbl { Name = "Manitu", Address = "ix.dnsbl.manitu.net", Type = RblType.Rbl, Level = RblLevel.Normal, DelistUrl = "https://www.nixspam.net/lookup.php?language=en&value=ADDRESS"},
                new Rbl { Name = "Spam Sorbs", Address = "spam.dnsbl.sorbs.net", Type = RblType.Rbl, Level = RblLevel.Critical, DelistUrl = "http://www.sorbs.net/lookup.shtml"},
                new Rbl { Name = "SMTP Relay Sorbs", Address = "smtp.dnsbl.sorbs.net", Type = RblType.Rbl, Level = RblLevel.Critical, DelistUrl = "http://www.sorbs.net/lookup.shtml"},
                new Rbl { Name = "Web Sorbs", Address = "web.dnsbl.sorbs.net", Type = RblType.Surbl, Level = RblLevel.Critical, DelistUrl = "http://www.sorbs.net/lookup.shtml"},
                new Rbl { Name = "Annonmails.de", Address = "spam.dnsbl.anonmails.de", Type = RblType.Rbl, Level = RblLevel.Normal, DelistUrl = "https://anonmails.de/dnsbl.php?ip=ADDRESS"},
                new Rbl { Name = "Lashback", Address = "ubl.lashback.com", Type = RblType.Rbl, Level = RblLevel.Critical, DelistUrl = "https://blacklist.lashback.com/?ipAddress=ADDRESS"},
                new Rbl { Name = "Mailspike", Address = "z.mailspike.net", Type = RblType.Rbl, Level = RblLevel.Normal, DelistUrl = "https://mailspike.org/iplookup.html"},
                new Rbl { Name = "Abuseeat", Address = "cbl.abuseat.org", Type = RblType.Rbl, Level = RblLevel.Normal, DelistUrl = "http://www.abuseat.org"},
                new Rbl { Name = "PSBL Surriel", Address = "psbl.surriel.com", Type = RblType.Rbl, Level = RblLevel.Normal, DelistUrl = "https://psbl.org/listing?ip=ADDRESS"},
                new Rbl { Name = "RBL Rspamd", Address = "bl.rspamd.com", Type = RblType.Surbl, Level = RblLevel.Normal, DelistUrl = "https://bl.rspamd.com/"}
            );
        }

        public DbSet<Rbl> Rbls => Set<Rbl>();
        public DbSet<Ip> Ips => Set<Ip>();
        public DbSet<Domain> Domains => Set<Domain>();
        public DbSet<User> Users => Set<User>();

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