using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _20_Static
{
    public class StopWatch
    {
        public static int NoOfInstances = 0;

        static StopWatch()
        {
            NoOfInstances = 10;
            Console.WriteLine("Llamando  al constructor estatico");
            
            StopWatch obj = new StopWatch();
            obj.Start();
        }

        //public StopWatch()
        //{
        //    Console.WriteLine("Llamando  al constructor de instancia ");
        //}

        public StopWatch()
        {
            StopWatch.NoOfInstances++;
            Console.WriteLine("Llamando  al constructor de instancia ");
        }

        // static method
        public static void DisplayInfo()
        {
            Console.WriteLine("DisplayInfo called");
        }

        // instance method
        public void Start() { }

        // instance method
        public void Stop() { }

        public void PrintNotInstances()
        {
            Console.WriteLine(StopWatch.NoOfInstances);
        }

        public static void Metodo1()
        {

        }

        public static void Metodo2()
        {

        }

    }
}
