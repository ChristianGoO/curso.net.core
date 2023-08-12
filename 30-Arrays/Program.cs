using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARCION DE OBJETOS
            //int[] evenNums;
            //string[] cities;

            //DECLARACION E INICIALIZACION DE ARREGLOS
            //int[] evenNums = new int[5] { 2, 4, 6, 8, 10 };
            //string[] cities = new string[3] { "mumbai", "london", "new york" };

            //DECLARACION E INICIALIZACION DE ARREGLOS CON VAR
            //var evenNums = new int[] { 2, 4, 6, 8, 10 };
            //var cities = new string[] { "mumbai", "london", "new york" };

            //DECLARACION E INICIALIZACION DE ARREGLOS SIN NEW
            //int[] evenNums = { 2, 4, 6, 8, 10 };
            //string[] cities = { "mumbai", "london", "new york" };

            //DECLARACION E INICIALIZACION NO VALIDAS
            //int[] evenNums = new int[]; 
            //int[] evenNums = new int[5] { 2, 4};
            //var evenNums = { 2, 4, 6, 8, 10 };

            //INICIALIZACION TARDIA
            //int[] evenNums;
            //evenNums = new int[5];
            //ó
            //evenNums = new int[] {2,4,6,8,10};

            int[] eventNums = new int[5] { 10, 8, 6, 4, 2 };
            string[] cities = new string[] { "mumbai", "london", "new york" };

            //ACCEDIENDO VALORES DEL ARREGLO
            //eventNums[0] = 2;
            //eventNums[1] = 4;
            //eventNums[6] = 12; Este marca un error
            Console.WriteLine(eventNums[0]);
            Console.WriteLine(eventNums[1]);
            Console.WriteLine("--------------------");

            //ACCEDIENTO ARREGLO CON EL FOR
            for (int i = 0; i < eventNums.Length; i++)
                Console.WriteLine(eventNums[i]);

            for (int i = 0; i < eventNums.Length; i++)
                eventNums[i] = eventNums[i] + 10;


            //ACCEDIENDO ARREGLO CON EL FOREACH
            Console.WriteLine("--------------------");
            foreach (var item in eventNums)
                Console.WriteLine(item);

            foreach (var city in cities)
                Console.WriteLine(city);

            //METODOS LINQ
            Console.WriteLine("--------------------");
            int max = eventNums.Max();
            int min = eventNums.Min();
            int sum = eventNums.Sum();
            double avg = eventNums.Average();

            Console.WriteLine($"el maximo es: {max}");
            Console.WriteLine($"el minimo es: {min}");
            Console.WriteLine($"la suma es: {sum}");
            Console.WriteLine($"el promedio es: {avg}");

            //METODOS Array
            Console.WriteLine("--------------------");
            Array.Sort(eventNums);
            Array.ForEach(eventNums, item => Console.WriteLine(item + "; "));
            Console.WriteLine();
            //Array.Reverse(eventNums);
            Array.ForEach(eventNums, item => Console.WriteLine(item + ", "));
            int posicion = Array.BinarySearch(eventNums, 20);
            Console.WriteLine("el numero 20 esta en la posicion " + posicion);

            //PASO DE PARAMETRO DE UN ARREGLO 
            Console.WriteLine("--------------------");
            updateArray(eventNums);

            foreach (var item in eventNums)
                Console.WriteLine(item);

            //ALGORITMO DE EL VALOR  MAXIMO
            Console.WriteLine("-----------------------------");
            Maximo();

            Console.WriteLine("--------------numeroPrimo-----------------");
            NumerosPrimosSinArreglos();

            Console.WriteLine("--------------numeroPrimoConArreglos-----------------");
            NumerosPrimosConArreglos();


            Console.ReadLine();

        }

        public static void updateArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] + 10;
            }
        }

        public static void Maximo()
        {
            int[] numeros = { -44, -23, -60, -50, -40, -2, -8, -70, -55, 44, 23, 60, 50, 40, 2, 8, 70, 55, };

            int maximo = int.MinValue;

            for (int i = 0; i < numeros.Length; i++)
            {
                int elemento = numeros[i];
                if (elemento > maximo)
                {
                    maximo = elemento;
                }

            }

            Console.WriteLine("el maximo es " + maximo);

        }

        public static void NumerosPrimosSinArreglos()
        {
            int numero;
            Console.WriteLine("INTRODUCE EL NUMERO");
            string sNumero = Console.ReadLine();
            if (sNumero != null && sNumero != "")
                numero = int.Parse(sNumero);
            else
                throw new Exception("Se necesita un numero aqui");

            int i = 1;
            while (i <= numero)
            {
                bool esPrimo = EsPrimo(i);

                if (esPrimo == true)
                    Console.WriteLine($"el numero {i} es primo");
                else
                    Console.WriteLine($"El numero {i} no es primo");

                i++; 
            }

        }

        public static void NumerosPrimosConArreglos()
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, };

            int posicion = 0;
            while(posicion < numeros.Length)
            {
                int numero = numeros[posicion];

                bool esPrimo = EsPrimo(numero);

                if (esPrimo)
                    Console.WriteLine($"el numero {numero} es primo");
                else
                    Console.WriteLine($"el numero {numero} no es primo");
            }


        }

        public static bool EsPrimo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                int resto = numero % i;

                if (resto == 0)
                    return false;
            }

            return true;
        }

    }
}
