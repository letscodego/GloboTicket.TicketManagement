using GloboTicket.TicketManagement.Application;
using GloboTicket.TicketManagement.Infrastructure;
using GloboTicket.TicketManagement.Persistence;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices(configuration);
builder.Services.AddPersistenceServices(configuration);

builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddPolicy("Open", builder => builder.AllowAnyOrigin()
    .AllowAnyHeader().AllowAnyMethod());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseCors("Open");

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});
app.Run();
