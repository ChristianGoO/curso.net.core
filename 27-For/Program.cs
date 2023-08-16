using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BUCLE FOR 
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"el valor de i es {i}");
            }

            //BUCLE FOR DE UNA SOLA SENTENCIA Y SIN LLAVES
            for (int i = 0; i < 10; i++)
                Console.WriteLine($"el valor de i es {i}");

            //BUCLE FOR INFINITA CON INICIALIZADOR, CONDICION, INCREMENTO Y ROMPIMIENTO FUERA DE LA ESTRUCTURA
            int j = 0;
            for (; ; )
            {
                if (j < 10)
                {
                    Console.WriteLine($"el valor de j es {j}");
                    j++;
                }
                else
                    break;
            }

            //bucle infinito 
            //for(; ; )
            //{
            //    console.writeline(1);
            //}

            //BUCLE CON DOUBLE
            for (double i = 1.01D; i < 10D; i += 0.01D)
            {
                Console.WriteLine($"El valor de i es {i}");
            }

            //BUCLE FINITO 
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine($"el valor de i es {i}");
            }

            //BUCLE FOR CON SENTENCIA BREAK PARA ROMPER EL CICLO FOR
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    break;

                Console.WriteLine($"el valor de i es {i}");
            }

            //BUCLE FOR  CON EXPRESIONES MULTIPLES
            for (int i = 0, k = 0; i + k < 5; i++, k++)
            {
                Console.WriteLine($"el valor de i es {i}, y de k es {k}");
            }

            //BUCLE FOR CON INSTRUCCIONES EN EL INICIALIZADOR  Y EN EL INCREMENTO
            int n = 5;
            int m = 0;
            for (Console.WriteLine($"el iniciador m: {m}, n: {n}"); m++ <= n--; Console.WriteLine($"el iterando m = {m}, n = {n}"))
            {
                Console.WriteLine($"el valor de m es {m}, y de n es {n}");
            }

            //BUCLE ANIDADO
            for (int i = 0; i < 2; i++)
            {
                for (int h = i; h < 4; h++)
                {
                    Console.WriteLine($"el valor de h es {h}, y de i es {i}");
                }
            }

            //EXTRA
            var acumulado = 0;
            for (int i = 0; i <= 100; i++)
            {
                //acumulado++;
                var resultado = i + acumulado;

                acumulado = resultado;

                Console.WriteLine("la vueta es " + i);
                Console.WriteLine("el valor de resultado es " + resultado);

            }

            //PINTAR ESTRELLAS
            EstrellasLineal();

            //PINTAR ESTRELLAS VERTICAL
            EstrellasVertical();

            //PINTAR UN TRIANGULO
            PintarUnTriangulo();

            Console.WriteLine("------------");

            PintarUnTrianguloInvertido();


            Console.ReadLine();

        }

        public static void EstrellasLineal()
        {
            int numEstrellas = 10;
            for (int i = 1; i <= numEstrellas; i++)
            {
                Console.Write("*");
            }
        }

        public static void EstrellasVertical()
        {
            int numEstrellas = 10;
            for (int i = 1; i <= numEstrellas; i++)
            {
                Console.WriteLine("*");
            }
        }

        public static void PintarUnTrianguloInvertido()
        {
            for (int j = 10; j >= 1; j--)
            {
                for (int i = 1; i <= j; i++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

        }

        public static void PintarUnTriangulo()
        {
            for (int j = 1; j <= 10; j++)
            {
                for (int i = 1; i <= j; i++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

        }
    }
}
