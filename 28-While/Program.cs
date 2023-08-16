using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BUCLE EWHILE CON CONDICION
            int i = 0;
            while (i < 10) 
            {
                Console.WriteLine($"i = {i}");
            
                i++;
            }

            //BUCLE WHILE CONTROLADO POR UN BREAK
            i = 0;
            while (true)
            {
                Console.WriteLine($"i = {i}");

                i++;

                if (i > 10)
                    break;
            }

            //WHILE INFINITO
            //short j = 1;
            //while(j > 0)
            //{
            //    Console.WriteLine("j = {0}", i);

            //    j++;
            //}

            //j = 0;
            //while (true)
            //{
            //    Console.WriteLine($"j = {j}");

            //    j++;
            //}

            //WHILE ANIDADOS 
            i = 0; 
            int j = 0 ;

            while(i < 2 )
            {
                Console.WriteLine($"i = {i}");

                i++ ;

                while (j < 2) 
                {
                    Console.WriteLine($"j = {j}");
                    j++ ;
                }

            }

            Console.WriteLine("---------------");
            SumaNumeros();

        }
        
        public static void SumaNumeros()
        {
            Console.WriteLine("Introduzca el numero que deseas leer: ");
            int NUMERO = int.Parse( Console.ReadLine() );
            int CONTADOR = 1, ACUMULADOR = 0;
            while(CONTADOR <= NUMERO)
            {
                Console.WriteLine($"Introduzca el numero {CONTADOR}: ");
                int NUMERO_LEIDO = int.Parse(Console.ReadLine() );
                ACUMULADOR = ACUMULADOR + NUMERO_LEIDO;
                CONTADOR++; 
            }

            Console.WriteLine($"La suma total es: {ACUMULADOR}");
        }
    
    }
}
