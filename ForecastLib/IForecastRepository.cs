
namespace ForecastLib
{
    public interface IForecastRepository
    {
        Forecast Add(Forecast forecast);
        Forecast deleteOldest();
        IEnumerable<Forecast> GetAll();
    }
}