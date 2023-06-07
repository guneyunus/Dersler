using WebApplication___Deniz.Model.Insan;
using WebApplication___Deniz.Services;

namespace WebApplication___Deniz.Model.Arac
{
    public class Metrobus : Bus
    {
        public Metrobus(int para, BusType busType)
        {
            asgariFiyat = para;
            type=busType;
        }
        public string hat { get; set; }

        public override void SetTarife(Adam adam)
        {
            tarife = adam.ucret * asgariFiyat;
        }
        
    }
}
