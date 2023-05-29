using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GokerDers
{
    internal class Odev
    {
        public static void Main()
        {
            byte[] bytes = Convert.FromBase64String("QUJDMTIz");
            Console.WriteLine("Byte Array is: " + String.Join(" ", bytes));

            string str = Convert.ToBase64String(bytes);
            Console.WriteLine("The String is: " + str);
        }


    }
}
