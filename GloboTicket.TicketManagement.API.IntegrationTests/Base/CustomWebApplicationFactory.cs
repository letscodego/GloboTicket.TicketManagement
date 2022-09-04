using GloboTicket.TicketManagement.Persistence;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace GloboTicket.TicketManagement.API.IntegrationTests.Base
{
    public class CustomWebApplicationFactory<T>: WebApplicationFactory<T> where T : class
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                services.AddDbContext<GloboTicketDbContext>(options =>
                {
                    options.UseInMemoryDatabase("GloboTicketDbContextInMemoryTest");
                });

                var sp = services.BuildServiceProvider();
                using(var scop = sp.CreateScope())
                {
                    var scopedService = scop.ServiceProvider;
                    var context= scopedService.GetRequiredService<GloboTicketDbContext>();
                    var logger = scopedService.GetRequiredService<ILogger<CustomWebApplicationFactory<T>>>();

                    context.Database.EnsureCreated();
                    try
                    {
                        Utilities.InitializeDbForTests(context);
                    }
                    catch (Exception ex)
                    {
                        logger.LogError(ex, $"An error occurred seeding the database with test message. Error: {ex.Message}");
                    }
                }
            });
        }
        public HttpClient GetAnonymousClient()
        {
            return CreateClient();
        }
    }
}
