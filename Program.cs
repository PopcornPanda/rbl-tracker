global using rbl_tracker.Data;
global using rbl_tracker.Models;
global using Microsoft.EntityFrameworkCore;
using rbl_tracker.Services.RblServices;
using rbl_tracker.Services.IpServices;
using rbl_tracker.Services.DomainServices;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Filters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

switch (builder.Configuration["AppSettings:DatabaseProvider"])
{
    case DbProviderType.MsSql:
        builder.Services.AddDbContext<DataContext, MsSqlDbContext>();
        builder.Services.AddHealthChecks().AddDbContextCheck<MsSqlDbContext>();
        break;

    case DbProviderType.PostgreSql:
        builder.Services.AddDbContext<DataContext, PostgreDbContext>();
        builder.Services.AddHealthChecks().AddDbContextCheck<PostgreDbContext>();
        break;

    case DbProviderType.MySql:
        builder.Services.AddDbContext<DataContext, MySqlDbContext>();
        builder.Services.AddHealthChecks().AddDbContextCheck<MySqlDbContext>();
        break;
    
    case DbProviderType.Sqlite:
    default:
        builder.Services.AddDbContext<DataContext, SqliteDbContext>();
        builder.Services.AddHealthChecks().AddDbContextCheck<SqliteDbContext>();
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
    options.OperationFilter<SecurityRequirementsOperationFilter>();
    options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme {
        Description = """Standard Auth header: "bearer {token}" """,
        In = ParameterLocation.Header,
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });

});
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddScoped<IRblService, RblService>();
builder.Services.AddScoped<IIpService, IpService>();
builder.Services.AddScoped<IDomainService, DomainService>();
builder.Services.AddScoped<IAuth, Auth>();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options => 
    {
        options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8
                    .GetBytes(builder.Configuration.GetSection("AppSettings:Token").Value!)),
                ValidateIssuer = false,
                ValidateAudience = false
            };
    });

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

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
