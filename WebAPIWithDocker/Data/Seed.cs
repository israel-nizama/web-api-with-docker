using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;

namespace WebAPIWithDocker.Data
{
    public static class Seed
    {
        public static IHost DataSeed(this IHost host)
        {
            using(var scope = host.Services.CreateScope())
            {
                using(var dbContext = scope.ServiceProvider.GetRequiredService<WeatherContext>())
                {
                    try
                    {
                        dbContext.Database.Migrate();
                    }
                    catch (Exception ex)
                    {
                        var logger = host.Services.GetRequiredService<ILogger<Program>>();
                        logger.LogError(ex, "Ocurrio un error con la carga inicial de data.");
                        throw;
                    }
                }
            }

            return host;
        }
    }
}
