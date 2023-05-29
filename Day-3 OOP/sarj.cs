using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_OOP
{
    internal class sarj
    {
        public abstract class Telefon
        {
            public string _marka;
            public int bataryaTur { get; set; }

            public int sebeke { get; set; }

            public decimal sarj { get; set; }

            public int cekim { get; set; }
        }

        public interface IOperator
        {
            int aramaGuc();

            decimal sarjTuket();

            void ara();

            void mesaj();
        }

        public class AkilliTelefon : Telefon, IOperator
        {
            public AkilliTelefon(string marka)
            {
                _marka = marka;
            }

            public void ara()
            {
                Console.WriteLine("Çekim Gücü : " + cekim + ", Alo!");
            }

            public int aramaGuc()
            {
                cekim = sebeke * 10;
                return cekim;
            }

            public void mesaj()
            {
                Console.WriteLine("Merhaba");
            }

            public decimal sarjTuket()
            {
                return (sarj - Convert.ToDecimal(bataryaTur / 5));
            }
        }
    }
}
