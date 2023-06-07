using WebApplication___Deniz.Model.Arac;

namespace WebApplication___Deniz.Services
{
    public interface IBusGenerator
    {
        Bus SetBus(BusType type);
    }

    public enum BusType
    {
        otobus=1,
        metrobus=2,
    }
}
