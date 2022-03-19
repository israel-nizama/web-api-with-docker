using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPIWithDocker.Data
{
    public class WeatherRepository : IWeatherRepository
    {
        private readonly WeatherContext _context;
        public WeatherRepository(WeatherContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Weather>> GetWeather()
        {
            return await _context.Set<Weather>().ToListAsync();
        }
    }
}
