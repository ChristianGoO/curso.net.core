using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Dinamicos
{
    class Program
    {
        static void Main(string[] args)
        {
            int miEntero = 0;
            dynamic myDynamic = 1;
            Console.WriteLine(miEntero.GetType());
            Console.WriteLine(myDynamic.GetType());

            dynamic myDynamicVar1 = 100;
            Console.WriteLine("Value: {0}, Type: {1}", myDynamicVar1, myDynamicVar1.GetType());

            myDynamicVar1 = "hello world";
            Console.WriteLine("Value: {0}, Type: {1}", myDynamicVar1, myDynamicVar1.GetType());

            myDynamicVar1 = true;
            Console.WriteLine("Value: {0}, Type: {1}", myDynamicVar1, myDynamicVar1.GetType());
            
            myDynamicVar1 = DateTime.Now;
            Console.WriteLine("Value: {0}, Type: {1}", myDynamicVar1, myDynamicVar1.GetType());

            dynamic d1 = 100;
            int i = d1;

            d1 = "hello";
            string greet = d1;

            d1 = DateTime.Now;
            DateTime dt = d1;


            dynamic studiante = new Estudiante();
            //studiante.DisplayStudentInfo(1, "Bill");
            //studiante.DisplayStudentInfo("1");
            //studiante.FakeMethod();
            studiante.DisplayStudentInfo(10);

            Console.ReadLine();

        }
    }
}
