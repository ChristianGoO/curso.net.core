using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Null
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //DECLARACION Y USO DEL NULLEABLE   
            Nullable<int> i = 100;

            if (i.HasValue)
            {
                Console.WriteLine(i.Value);
            }
            else
            { 
                Console.WriteLine("Nulo");
            }

            Console.WriteLine(i.GetValueOrDefault());

            //SINTAXIS ABREVIADA DEL NULEABLE
            int? j = null;
            double? d = null;
            Estudiante estudiante = null;

            int? k = null;
            //int h = k;
            int l = k ?? 0;

            //EJEMPLO DE UNA VARIABLE NULEABLE EN UNA CLASE (VARIABLE LOCAL)
            Estudiante estudiante1 = new Estudiante();
            Console.WriteLine(estudiante1.GetIdEstudiante());

            //OPERACIONES DE COMPARACION CON NULEABLE
            int? a = null;
            int b = 10;

            //ESTE NO SE PUDO COMPARAR
            if (a < b)
                Console.WriteLine("a<b");
            else if (a > 10)
                Console.WriteLine("a>b");
            else if (a == 10)
                Console.WriteLine("a == b");
            else
                Console.WriteLine("No se puede comparar");


            if (Nullable.Compare<int>(a, b) < 0)
                Console.WriteLine("a<b");
            else if (Nullable.Compare<int>(a, b) > 0)
                Console.WriteLine("a > b");
            else
                Console.WriteLine("a = b");

            //Nullable<Nullable<int>> l = null;

        }
    }
}
