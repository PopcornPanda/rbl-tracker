namespace rbl_tracker.Data
{
    public class MySqlDbContext : DataContext
    {
        public MySqlDbContext(IConfiguration configuration) : base(configuration)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySQL(Configuration.GetConnectionString("MySql")!);
        }

    }
}