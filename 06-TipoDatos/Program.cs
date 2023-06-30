using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_TipoDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            byte numero = 100;
            System.Byte numero11 = 100;
            Console.WriteLine("El valor de la variable numero {0}",numero);
            Console.WriteLine("El valor de la variable numero11 {0}", numero11);

            sbyte numero2 = 127;
            Console.WriteLine("El valor de la variable numero2 {0}", numero2);

            uint numero3 = 4294967295u;
            Console.WriteLine("El valor de la variable numero3 {0}", numero3);

            long numero4 = 1000L;
            Console.WriteLine("El valor de la variable numero4 {0}", numero4);

            DateTime fecha = new DateTime(2023, 06, 06, 09, 19, 18);
            Console.WriteLine("El valor de la variable fecha {0}", fecha); 

            //INICIALIZACION DE VARIABLES
            int i = default(int);
            Console.WriteLine("El valor de la variable i {0}", i);

            //COMVERSION IMPLICITA
            int j = 345;
            float f = 1;
            Console.WriteLine("El valor de la variable f {0}", f);
            Console.WriteLine("El valor de la variable j {0}", j);

            //CONVERSION IMPLICITA
            int h = 100;
            uint u = (uint)h;
            Console.WriteLine(u);

            Console.ReadLine();



        }
    }
}
