using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_OOP
{
    public abstract class Malzeme
    {
        public string _tur;

        public int kalite { get; set; }
    }

    public interface ISaldiri
    {
        int guc();
    }

    public interface IHeal
    {
        bool isAlive();
    }

    public class Cekic : Malzeme, ISaldiri
    {
        public Cekic(string tur)
        {
            _tur = tur;
        }

        public int guc()
        {
            return kalite * 10;
        }
    }

    public class YaraBandi : Malzeme, IHeal
    {
        public YaraBandi(string tur)
        {
            _tur = tur;
        }

        public bool isAlive()
        {
            return kalite > 5 ? true : false;
        }
    }

    public class Civi : Malzeme, ISaldiri
    {
        public Civi(string tur)
        {
            _tur = tur;
        }

        public int guc()
        {
            return kalite;
        }
    }
}
