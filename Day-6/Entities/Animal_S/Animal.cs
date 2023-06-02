using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6.Entities.Animal_S
{
    public abstract class Animal
    {
        public bool Cinsiyet { get; set; }
        public DateTime Yas { get; set; }

        public string Beslen()
        {
            return "";
        }
    }

    public interface ISudaYuzen
    {
        public string Yuz();
    }

    public interface IKaradaGiden
    {
        public string Yuru();
    }

    public class Aslan : Animal, IKaradaGiden
    {
        public string Yuru()
        {
            return "Yürüyorum";
        }
        public override string ToString()
        {
            return "Tostring deneme";
        }
    }
    public class KopekBaligisi : Animal, ISudaYuzen
    {
        public string Yuz()
        {
            return "Yüzüyorum";
        }
    }
    public class Timsah : Animal, ISudaYuzen, IKaradaGiden
    {
        public string Yuru()
        {
            return "Ben Timsah Yürüyorum";

        }

        public string Yuz()
        {
            return "Ben Timsah Yüzüyorum";

        }
    }
}
