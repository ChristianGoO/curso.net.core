using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Cadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string ch = "S";
            string word = "String";
            string text = "This is a string.";

            string str1 = "Hello"; // uses string keyword
            String str2 = "Hello";

            //------------------------------------------------------------------------------------------------------------------------
            char[] chars = { 'h', 'o', 'l', 'a'};
            
            string str3 = new string(chars);
            string str4 = new string(chars);

            foreach (var elementoArreglo in str3)
            {
            
                Console.WriteLine((int)elementoArreglo);
            
            }

            //------------------------------------------------------------------------------------------------------------------------
            string text1 = "This is a \"string\" in C#.";
            string str = "xyzdef\\rabc";

            Console.WriteLine(str);

            //------------------------------------------------------------------------------------------------------------------------
            string str5 = @"xyzdef\rabc";
            string path = @"\mypc\shared\project";
            string email = @"test@test.com";

            Console.WriteLine(str5);
            Console.WriteLine(path);
            Console.WriteLine(email);

            //------------------------------------------------------------------------------------------------------------------------
            string str6 = "this is a \n" +
                          "multi line \n" +
                          "string";

            // Verbatim string
            string str7 = @"this is a 
                          multi line 
                          string";

            Console.WriteLine(str6);
            Console.WriteLine(str7);

            //------------------------------------------------------------------------------------------------------------------------
                string text2 = "This is a \"string\" in C#."; // valid
            //string text3 = @"This is a "string." in C#."; // error
            //string text4 = @"This is a \"string\" in C#."; // error
            string text5 = @"This is a ""string"" in C#."; // valid

            Console.WriteLine(text5);

            //------------------------------------------------------------------------------------------------------------------------
            string name = "Mr." + "James " + "Bond" + ", Code: 007";

            string firstName = "James";
            string lastName = "Bond";
            string code = "007";

            string agent = "Mr." + firstName + " " + lastName + ", Code: " + code;

            //------------------------------------------------------------------------------------------------------------------------
            string firstname = "JAMES";
            string lastname = "BOND";
            string code1 = "007";

            string fullName = $"Mr. {firstname} {lastname}, Code: {code1}";
            Console.WriteLine($"Mr. {firstname} {lastname}, Code: {code1}");


        }
    }
}
