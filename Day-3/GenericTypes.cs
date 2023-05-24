using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    // GENERİC TYPES

    // T => type
    // TSession
    // TKey
    //TValues

    //OBJEYİ NEWLEDİĞİMDE YANİ YENİ BİR İNSTANCE OLUŞTURKEN TİP KULLANACGIM.

    //DataObject<int> dataObject = new();

    public interface IDeneme
    {

    }

    public class GenericTypes
    {
        int _sayi;
        string _name;
        int _getNum;

        public DataObject<int> FirstProp { get; set; } = new DataObject<int>();
        public PaperObject<string> SecProp { get; set; } = new PaperObject<string>();
        public DataObject<Malzeme> MalzemeProp { get; set; } = new DataObject<Malzeme>();
        public GenericTypes()
        {
            _sayi = FirstProp.DataLayer;
            _name = SecProp.Value;
            MalzemeProp.DataLayer = new();
            _getNum = MalzemeProp.DataLayer.GetNum;

            for (int i = 0; i < 100000; i++)
            {
                MyProperty.Add(i);
            }
        }
        public List<int> MyProperty { get; set; } = new List<int>(); // null referans exception newlemez isem 
        public List<string> MyProperty2 { get; set; }
        public List<Malzeme> MyProperty3 { get; set; }
    }
    public class DataObject<T>
    {
        public T DataLayer { get; set; } 
    }

    public class PaperObject<T> where T : class
    {
        public int Number { get; set; }
        public T Value  { get; set; } 
    }

    public class Malzeme
    {
        string _name;
        int _durum;
        public int GetNum { get; set; } 
    }

    class KeyValeu<TKey, TValue>
    {

    }




}
