using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6.Entities
{
    public abstract class Animal
    {
        public bool Cinsiyet { get; set; }

        public DateTime Yas { get; set; }

        public string Beslen() 
        { 
            return "";
        }

        public interface ISudaYuzen
        {
            string Yuz(); // metot bodysi olmamalı. Sadece imza yeterli
            
        }
        public interface IKaradaGiden
        {
            string Yuru();

        }

        public class kopekbalıgı : Animal, ISudaYuzen
        {
            public string Yuz()
            {
                return "yüzüyorum";
            }
        }
        public class Aslan : Animal, IKaradaGiden
        {
            public string Yuru()
            {
                return "yürüyorum";
            }
            public override string ToString()
            {
                return "deneme";
            }
        }
        public class Timsah : Animal, ISudaYuzen, IKaradaGiden
        {
            public string Yuru()
            {
                return "Timsah gözyaşı döküyorum";
            }

            public string Yuz()
            {
                return "Timsah yüzüşü yapıyorum";
            }
        }
    }
}
