using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ForecastLib
{
    public class ForecastRepository : IForecastRepository
    {
        public int _nextId = 1;
        public List<Forecast> _forecasts = new();


        public ForecastRepository()
        {
            _forecasts.Add(new Forecast { id = 1, temp = 10, humidity = 20, date = DateTime.Now });
        }

        public Forecast Add(Forecast forecast)
        {
            forecast.id = _nextId++;
            forecast.validate();
            _forecasts.Add(forecast);
            return forecast;
        }

        public IEnumerable<Forecast> GetAll()
        {
            return _forecasts;
        }
        // not sure if this functions..
        public Forecast deleteOldest()
        {
            var oldest = _forecasts.OrderBy(f => f.date).First();
            _forecasts.Remove(oldest);
            return oldest;
        }
    }
}
