using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForecastLib
{
    public class Forecast
    {
        public int id { get; set; }
        public double? temp { get; set; }
        public double? humidity { get; set; }
        public DateTime date { get; set; }

        public override string ToString()
        {
            return $"id: {id}, temp: {temp}, humidity: {humidity}, date: {date}";
        }

        public void validate()
        {
            if (temp == null)
            {
                throw new Exception("temp is required");
            }
            if (humidity == null)
            {
                throw new Exception("humidity is required");
            }
            if (date == null)
            {
                throw new Exception("date is required");
            }
        }
    }
}
