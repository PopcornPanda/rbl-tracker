global using rbl_tracker.Data;
global using rbl_tracker.Models;
global using Microsoft.EntityFrameworkCore;
using rbl_tracker.Services.RblServices;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

switch (builder.Configuration["DatabaseProvider"])
{
    case DbProviderType.MsSql:
        builder.Services.AddDbContext<DataContext, MsSqlDbContext>();
        break;

    case DbProviderType.PostgreSql:
        builder.Services.AddDbContext<DataContext, PostgreDbContext>();
        break;

    case DbProviderType.Sqlite:
        builder.Services.AddDbContext<DataContext, SqliteDbContext>();
        break;

    case DbProviderType.MySql:
        builder.Services.AddDbContext<DataContext, MySqlDbContext>();
        break;
}

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
