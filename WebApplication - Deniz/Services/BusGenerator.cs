using WebApplication___Deniz.Model.Arac;

namespace WebApplication___Deniz.Services
{
    public class BusGenerator : IBusGenerator
    {
        public Bus SetBus(BusType type)
        {
            return type == BusType.otobus ? new Otobus(10,type) : new Metrobus(5,type);
        }
    }
}
