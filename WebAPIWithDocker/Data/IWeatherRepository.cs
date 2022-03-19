using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPIWithDocker.Data
{
    public interface IWeatherRepository
    {
        Task<IEnumerable<Weather>> GetWeather();
    }
}