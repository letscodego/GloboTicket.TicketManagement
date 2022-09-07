using GloboTicket.TicketManagement.Api.Middlewares;
using GloboTicket.TicketManagement.Api.Services;
using GloboTicket.TicketManagement.Api.Utility;
using GloboTicket.TicketManagement.Application;
using GloboTicket.TicketManagement.Application.Contracts;
using GloboTicket.TicketManagement.Identity;
using GloboTicket.TicketManagement.Identity.Models;
using GloboTicket.TicketManagement.Infrastructure;
using GloboTicket.TicketManagement.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.OpenApi.Models;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", true)
    .Build();

Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(configuration)
    .WriteTo.Console()
    .WriteTo.File("Logs/log-.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

Log.Information("Hello, world!");

// Add services to the container.
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices(configuration);
builder.Services.AddPersistenceServices(configuration);
builder.Services.AddIdentityServices(configuration);
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<ILoggedInUserService, LoggedInUserService>();

builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddPolicy("Open", builder => builder.AllowAnyOrigin()
    .AllowAnyHeader().AllowAnyMethod());
});

builder.Services.AddSwaggerGen(c => 
{
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n 
                      Enter 'Bearer' [space] and then your token in the text input below.
                      \r\n\r\nExample: 'Bearer 12345abcdef'",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                },
                Scheme = "oauth2",
                Name = "Bearer",
                In = ParameterLocation.Header,

            },
            new List<string>()
        }
    });

    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Version = "v1",
        Title = "GloboTicket Ticket Management API",
    });

    c.OperationFilter<FileResultContentTypeOperationFilter>();
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();

        await GloboTicket.TicketManagement.Identity.Seed.UserCreator.SeedAsync(userManager);
        Log.Information("Application Starting");
    }
    catch (Exception ex)
    {
        Log.Warning(ex, "An error occured while starting the application");
    }
}

// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthentication();
app.UseCors("Open");

app.UseSwagger();
app.UseSwaggerUI(c => 
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "GloboTicket Ticket Management API");
});

app.UseCustomExceptionHandler();
app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});
app.Run();

public partial class Program { } // to reference it from tests

