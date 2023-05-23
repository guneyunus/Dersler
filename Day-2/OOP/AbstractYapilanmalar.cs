using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2.OOP
{
    public abstract class Araba 
    {
        public DateTime _yili;
        public Araba(DateTime yili)
        {
            _yili = yili;
        }
    }

    public interface IAraba
    {
        string Name();
        int Durum();
        void CalKorna(int kornaSuresi);

    }

    public class Auid : Araba, IAraba
    {
        public int _id = 0;
        public Auid(DateTime yili) : base(yili)
        {
        }

        public void CalKorna(int kornaSuresi)
        {
            _id += kornaSuresi;
        }

        public int Durum()
        {
            return _yili.Year;
        }

        public string Name()
        {
            return _yili.ToString();
        }
    }

    public class Bmw : Araba, IAraba
    {
        public int _degisimAdedi = 10;
        public Bmw(DateTime yili) : base(yili)
        {
        }

        public void CalKorna(int kornaSuresi)
        {
            _degisimAdedi -= kornaSuresi;
        }

        public int Durum()
        {
            return 100;
        }

        public string Name()
        {
            return "Bmw on basar.";
        }
    }

}
