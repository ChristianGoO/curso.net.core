using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_MatricesIrregulares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CREAR ARRAGLOS QUE GUARDA ARREGLOS DE 1 DIMENSION Y DE 2 DIMENSIONES
            int[][] jarray1 = new int[2][];
            int[][,] jarray2 = new int[3][,];

            //ASIGNA ARREGLOS COMO VALOR AL ARREGLO
            jarray1[0] = new int[3] { 1, 2, 3 };
            jarray1[1] = new int[4] { 4, 5, 6, 7 };

            //DECLARAR ARREGLOS E INICIALIZAR ARREGLOS
            int[][] jArray3 = new int[2][]
            {
                new int [3] {1, 2, 3},
                new int [4] {4, 5, 6, 7}
            };

            //LEER ARREGLOS CON POSICIONES
            Console.WriteLine("jArray3[0][0]" + jArray3[0][0]);
            Console.WriteLine("jArray3[0][1]" + jArray3[0][1]);
            Console.WriteLine("jArray3[0][2]" + jArray3[0][2]);
            Console.WriteLine("jArray3[1][0]" + jArray3[1][0]);
            Console.WriteLine("jArray3[1][1]" + jArray3[1][1]);
            Console.WriteLine("jArray3[1][2]" + jArray3[1][2]);
            Console.WriteLine("jArray3[1][3]" + jArray3[1][3]);


            //-----------------------RECORRIENDO MATRICES IRREGULARES CON FOR V1------------------------------
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < jArray3.Length; i++)
            {
                int[] array = jArray3[i];
                for (int j = 0; j < array.Length; j++)
                {
                    int numero = array[j];
                    Console.Write(numero + ", ");
                }
                Console.WriteLine();
            }

            //----------------------RECORRIENDO MATRICES IRREGULARES CON FOR V2---------------------------------
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < jArray3.Length; i++)
            {
                for (int j = 0; j < jArray3[i].Length; j++)
                {
                    Console.WriteLine(jArray3[i][j] + ", ");
                }
            }

            //DECLARARR UN ARREGLO CON 2 ARRAGLOS DE 2 DIMENCIONES
            Console.WriteLine("-------------------------------------");
            int[][,] jArray4 = new int[2][,];
            jArray4[0] = new int[3, 2] {{ 1, 2 }, { 3, 4}, { 5, 6} };
            jArray4[1] = new int[2, 2] { { 7, 8}, { 9, 10} };

            Console.WriteLine(jArray4[0][1, 0]);//3
            Console.WriteLine(jArray4[0][2, 1]);//6
            Console.WriteLine(jArray4[1][0, 1]);//8
            Console.WriteLine(jArray4[1][1, 1]);//10

            //-----------------------RECORRIENDO MATRICES IRREGULARES CON FOR V1------------------------------
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < jArray4.Length; i++)
            {
                int[,] array = jArray4[i];
                for (int j = 0; j < array.Length; j++)
                {
                    
                }
                Console.WriteLine();
            }


            Console.Read();
        }
    }
}
