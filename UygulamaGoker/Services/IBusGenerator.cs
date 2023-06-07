namespace UygulamaGoker.Services
{
    public interface IBusGenerator
    {
        Bus SetBus(Bus bus);

    }
    public enum BusType
    {
        otobus=1,
        metrobus=2,
    }
}
