using WebApplication___Deniz.Model.Insan;
using WebApplication___Deniz.Services;

namespace WebApplication___Deniz.Model.Arac
{
    public abstract class Bus
    {
        public int hiz;
        public BusType type { get; set; }
        public int asgariFiyat { get; set; }
        public int tarife { get; set; }
        public int yolcuSayisi { get; set; }

        public abstract void SetTarife(Adam adam);
       
        public int GetTarife()
        {
            return tarife;
        }

    }
}
