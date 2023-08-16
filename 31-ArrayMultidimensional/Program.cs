using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace _31_ArrayMultidimensional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARACION DE ARRAYS MULTIDIMENSIONALES
            //int[,] arr2d;
            //int[,,] arr3d;
            //int[,,,] arr4d;
            //int[,,,,] arr5d;

            //INICIALIZACION DE ARRAY 2 DIMENSIONES
            int[,] arr2d_1 = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            int[,] arr2d_2 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            //LEER UN ARRAY BIDIMENSIONAL
            Console.WriteLine($"arr2d[0, 0] = {arr2d_1[0, 0]}");
            Console.WriteLine($"arr2d[0, 1] = {arr2d_1[0, 1]}");
            Console.WriteLine($"arr2d[1, 0] = {arr2d_1[1, 0]}");
            Console.WriteLine($"arr2d[1, 1] = {arr2d_1[1, 1]}");
            Console.WriteLine($"arr2d[2, 0] = {arr2d_1[2, 0]}");
            Console.WriteLine($"arr2d[2, 1] = {arr2d_1[2, 1]}");

            //LEER UN ARRAY BIDIMENSIONAL CON CICLOS
            int i = 0;
            int j = 0;
            while (i < 3)
            {
                while (j < 2)
                {
                    int numero = arr2d_1[i, j];
                    Console.WriteLine($"La fila {i} y columna{j} tiene un valor de {numero}");
                    j++;
                }
                i++;
                j = 0;
            }

            Console.WriteLine("-------MATRIZ ASTERISCOS-----");
            MatrizAsteriscos();

            Console.WriteLine("-------MATRIZ ASTERISCOS-----");
            trianguloAsteriscos();

            int[] arreglo = new int[100000000];

            Console.ReadLine();
        }

        public static void MatrizAsteriscos()
        {
            for (int j = 1; j <= 6; j++)
            {

                for (int i = 1; i <= 6; i++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public static void trianguloAsteriscos()
        {
            for (int j = 1; j <= 6; j++)
            {
                for (int i = 1; i < j; i++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
