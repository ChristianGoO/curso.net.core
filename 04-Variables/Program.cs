using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //DECLARANDO VARIABLES
            int num = 100;

            float rate = 10.2f;
            decimal amount = 100.50M;
            char code = 'C';
            bool isValid = true;
            string name = "Steve";

            Console.WriteLine(num);
            Console.WriteLine(rate);
            Console.WriteLine(amount);    
            Console.WriteLine(code);
            Console.WriteLine(name);
            Console.WriteLine(isValid);

            //ERRORES
            //int num = "Steve";

            //DECLARAR Y ASIGNAR DESPUES
            int num2;
            num2 = 100;
            Console.WriteLine(num2);

            //ASIGNACION NO VALIDA
            //int i;
            //int j = i;

            int num3 = 100;
            num3 = 200;
            Console.WriteLine(num3);

            //DECLARAR E INICIALIZAR MULTIPLES VARIABLES
            int i, j =10, k =10;
            i = 1;
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);

            //DECLARAR E INICIALIZA MULTIPLES VARIABLES EN MULTIPLES LINEAS
            int il = 1,
                jl = 10,
                kl = 100;

            Console.WriteLine(il);
            Console.WriteLine(jl);
            Console.WriteLine(kl);

            //ASIGNACION DE VARIABLES
            int i3 = 100;
            int j3 = i3;

            //VARIABLES Y EXPRECIONES
            int i4 = 100;
            int j4 = i4 + 20;

            i4 = 200;
            j4 = i4 + 20;

            i4 = 300;
            Console.WriteLine("j4 es igual a {0}, i4 = {1}", j4, i4);

            var i5 = 5;
            Console.WriteLine(i5);
                

        }
    }
}
