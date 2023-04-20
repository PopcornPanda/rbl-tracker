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

        public DbSet<Rbl> Rbls => Set<Rbl>();

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