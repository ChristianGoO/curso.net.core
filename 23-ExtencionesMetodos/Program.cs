using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionsMethods1;

namespace _23_ExtencionesMetodos
{
    class Program{
        static void Main(string[] args)
        {
            int i = 10;
            bool result = i.IsGreaterThan(100);
            Console.WriteLine(result);
        } 
    }
}

