using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace _05_Var
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var i = 10;
            Console.WriteLine("El tipo de dato de i es: {0}", i.GetType());

            var str = "Hello world";
            Console.WriteLine("El tipo de dato es {0}", str.GetType());

            var dbl = 100.50d;
            Console.WriteLine("El tipo de dato es {0}", dbl.GetType());

            var isValid = true;
            Console.WriteLine("Type of isValid is {0}", isValid.GetType());

            var ano = new { name = "Steve" };
            Console.WriteLine("Type of ano is {0}", ano.GetType());

            var arr = new[] { 1, 10, 20, 30 };
            Console.WriteLine("Type of arr is {0}", arr.GetType());

            var file = new FileInfo("MyFile");
            Console.WriteLine("Type of file is {0}", file.GetType());

            //ERRORES

            //var j;
            //j = 100;

            //var j = 100, k = 200, h = 300;

            var j = 100;
            var k = 200;
            var h = 300;
            Console.WriteLine(h);
            Console.WriteLine(k); 
            Console.WriteLine(j);

            //UTILIZANDO VAR EN UN CICLO FOR
            for (var l = 0; l < 10; l++)
            {
                Console.WriteLine(l);
            }

            //UTILIZANDO VAR EN UNA EXPRESION LINQ
            IList<string> stringList = new List<string>()
            {
                "c# tutorials",
                "vb.NET tutorials",
                "learn c++",
                "MVC tutorial",
                "Java"
            };
            

            var result = from elemento in stringList
                         where elemento.Contains("Tutorials")
                         select elemento;

            foreach(var elemento in  result)
            {
                Console.WriteLine(elemento);
            }

            Console.WriteLine();

        }

        //public void Display(var parametro)
        //{
        //    Console.Write(parametro);
        //}

    }
}
