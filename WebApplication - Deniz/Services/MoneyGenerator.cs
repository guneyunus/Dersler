using WebApplication___Deniz.Model.Arac;
using WebApplication___Deniz.Model.Insan;

namespace WebApplication___Deniz.Services
{
    public class MoneyGenerator : IMoneyGenerator
    {
        public void Calculate(Bus bus, Adam adam)
        {
            bus.SetTarife(adam);
        }
    }
}
