using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CONSTRUCTORES DE STRINGBUILDERS
            StringBuilder sb = new StringBuilder();
            StringBuilder sb1 = new StringBuilder("Hello world!");
            StringBuilder sb2 = new StringBuilder(50);
            StringBuilder sb3 = new StringBuilder("Hello world!", 50);
            StringBuilder sb4 = new StringBuilder("Hello world!", 0, 10, 50);


            //ITRAR UN STRING BUILDER
            for(int pos = 0; pos <= sb1.Length; pos++)
            {
                Console.WriteLine(sb1[pos]);
            }


            //OBTENER LA CADENA DE STRINGBUILDER
            string saludo = sb1.ToString();


            //ADD / AGREGAR UNA NUEVA LINEA DE STRINGBUILDER
            StringBuilder sb5 = new StringBuilder();
            sb5.Append("Hello");
            sb5.AppendLine(" world");
            sb5.AppendLine("Hello C#");
            Console.WriteLine(sb5);


            //AGREGAR CADENAS CON FORMATO
            StringBuilder sbCantidad = new StringBuilder("Tu cantidad total es: ");
            sbCantidad.AppendFormat("{0;C}", 25);
            Console.WriteLine(sbCantidad);

            //INSERTAR CADENAS
            StringBuilder sb6 = new StringBuilder("Hello world");
            sb6.Insert(5, "C#");
            Console.WriteLine(sb6);

            //ELIMINAR CADENA STRINGBUILDER
            StringBuilder sb7 = new StringBuilder("Hello world! Hello world! Hello world!", 50);
            sb7.Remove(6, 7);
            Console.WriteLine(sb7);

            //REPLACE DE CADENAS
            StringBuilder sb8 = new StringBuilder("Hello world!");
            sb8.Replace("world", "C#");
            Console.WriteLine(sb8);

            Console.Read();
        }
    }
}
