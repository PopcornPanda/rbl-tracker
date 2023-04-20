namespace rbl_tracker.Data
{
    public class SqliteDbContext : DataContext
    {
        public SqliteDbContext(IConfiguration configuration) : base(configuration)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(Configuration.GetConnectionString("Sqlite"));
        }

    }
}