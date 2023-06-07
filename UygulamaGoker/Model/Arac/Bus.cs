namespace UygulamaGoker.Model
{
    public abstract class Bus
    {
        public int Id { get; set; }

        public int Capasity { get; set; }

        public string LineName { get; set; }

        public int BasePrice { get; set; }

        public int GetBasePrice(Insan Insan)
        {
            return Insan.Price*BasePrice;
        }


    }
}
