using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Clases
{
    class Aritmetrica
    {

        //METODO
        public int suma(int num1, int num2)
        {
            var total = num1 + num2;

            return total;
        }

        public void saludo()
        {
            Console.WriteLine("Hola desde objeto aritmetica");

        }

    }
}
