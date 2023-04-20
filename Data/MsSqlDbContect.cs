namespace rbl_tracker.Data
{
    public class MsSqlDbContext : DataContext
    {
        public MsSqlDbContext(IConfiguration configuration) : base(configuration)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("MsSql"));
        }

    }
}