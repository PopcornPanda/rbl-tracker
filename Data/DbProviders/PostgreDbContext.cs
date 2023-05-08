namespace rbl_tracker.Data
{
    public class PostgreDbContext : DataContext
    {
        public PostgreDbContext(IConfiguration configuration)
            : base(configuration)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(Configuration.GetConnectionString("PostgreSqlConnection"));
        }

    }
}