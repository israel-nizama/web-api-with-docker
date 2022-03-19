using Microsoft.EntityFrameworkCore;
using System;

namespace WebAPIWithDocker.Data
{
    public class WeatherContext : DbContext
    {
        public WeatherContext(DbContextOptions<WeatherContext> options) : base(options)
        {
        }
        
        public DbSet<Weather> Weathers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Weather>().HasKey(x => x.Id);

            modelBuilder.Entity<Weather>().HasData(
                new Weather
                {
                    Id = 1,
                    Date = DateTime.Parse("2022-03-19T16:41:16.5435643+00:00"),
                    TemperatureC = 50,
                    Summary = "Chilly"
                },
                new Weather
                {
                    Id = 2,
                    Date = DateTime.Parse("2022-03-20T16:41:16.5436565+00:00"),
                    TemperatureC = 39,
                    Summary = "Sweltering"
                },
                new Weather
                {
                    Id = 3,
                    Date = DateTime.Parse("2022-03-21T16:41:16.5436574+00:00"),
                    TemperatureC = 34,
                    Summary = "Warm"
                },
                new Weather
                {
                    Id = 4,
                    Date = DateTime.Parse("2022-03-22T16:41:16.5436575+00:00"),
                    TemperatureC = 51,
                    Summary = "Scorching"
                },
                new Weather
                {
                    Id = 5,
                    Date = DateTime.Parse("2022-03-23T16:41:16.5436576+00:00"),
                    TemperatureC = 11,
                    Summary = "Balmy"
                }
            );
        }
    }
}
