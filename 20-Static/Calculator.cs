using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Static
{
    public class Calculator
    {
        private static int _resultStorage = 0;

        public static string Type = "Aritmetic";

        public static int MyProperty { get; set; }

        static Calculator()
        {

        }

        public static int Suma(int num1, int num2)
        {
            return num1 + num2;
        }

        public static void store(int result)
        {
            _resultStorage = result;
        }



    }
}
