global using rbl_tracker.Data;
global using rbl_tracker.Models;
global using Microsoft.EntityFrameworkCore;
using rbl_tracker.Services.RblServices;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

switch (builder.Configuration["DatabaseProvider"])
{
    case DbProviderType.MsSql:
        builder.Services.AddDbContext<DataContext, MsSqlDbContext>();
        builder.Services.AddHealthChecks().AddDbContextCheck<MsSqlDbContext>();
        break;

    case DbProviderType.PostgreSql:
        builder.Services.AddDbContext<DataContext, PostgreDbContext>();
        builder.Services.AddHealthChecks().AddDbContextCheck<PostgreDbContext>();
        break;

    case DbProviderType.Sqlite:
        builder.Services.AddDbContext<DataContext, SqliteDbContext>();
        builder.Services.AddHealthChecks().AddDbContextCheck<SqliteDbContext>();
        break;

    case DbProviderType.MySql:
        builder.Services.AddDbContext<DataContext, MySqlDbContext>();
        builder.Services.AddHealthChecks().AddDbContextCheck<MySqlDbContext>();
        break;
}

builder.Services.AddControllers();
builder.Services.AddHealthChecks();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "RBL Tracker API",
        Description = "An API for checking the presence of ip addresses/domains on blacklists",
        Contact = new OpenApiContact
        {
            Name = "GitLab Repository",
            Url = new Uri("https://gitlab.com/herd-panel/rbl-tracker")
        },
        License = new OpenApiLicense
        {
            Name = "MIT License",
            Url = new Uri("https://mit-license.org/")
        }
    });
});
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddScoped<IRblService, RblService>();

// generate lowercase URLs
builder.Services.Configure<RouteOptions>(options =>
{
    options.LowercaseUrls = true;
});

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Migrate latest database changes during startup
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider
        .GetRequiredService<DataContext>();

    // Here is the migration executed
    dbContext.Database.Migrate();
}

app.MapHealthChecks("/healthz", new HealthCheckOptions
{
    AllowCachingResponses = false
});


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
