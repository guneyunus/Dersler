using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dersler.OOP
{
    public class Malzeme
    {
        public string Un { get; set; }

        public string Şeker { get; set; }

        public string Su { get; set; }

    }
    public class Ekmek : Malzeme, IPisenler
    {
        public int Durum()
        {
            return 0;
        }

        public string Name()
        {
            return "ekmek";
        }
    }

    public interface IPisenler
    {
        string Name();
        int Durum();
    }
    public class Poğaca : Malzeme, IPisenler
    {
        public int _üretimAdedi = 10;
        public int Durum()
        {
            return 1;
        }
        public string Name()
        {
            return "poğaca";
        }
    }





}