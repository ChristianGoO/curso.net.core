using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_ValueTypesAndReferenceType
{
    internal class Program
    {

        //REFERENCE TYPE
        static void ChangeValue(int x)
        {
            x = 200;
            Console.WriteLine(x);
        }

        //int i = 100;
        //Console.WriteLine(i);
        //    ChangeValue(i);
        //Console.WriteLine(i);
       
        static void Main(string[] args)
        {

            //REFERENCE TYPE
            Estudiante estudiante1 = new Estudiante();
            estudiante1.Id = 1;
            estudiante1.Nombre = "Juan";
            Console.WriteLine($"id: {estudiante1.Id}, Nombre: {estudiante1.Nombre}");
            ChangeValue2(estudiante1 );
            Console.WriteLine($"id: {estudiante1.Id}, Nombre: {estudiante1.Nombre}");
        
            
            Estudiante estudiante2 = new Estudiante();
            estudiante2.Id = 1;
            estudiante2.Nombre = "juan";

            Estudiante estudiante3 = new Estudiante();
            estudiante3.Id = 1;
            estudiante3.Nombre = "juan";

            if (estudiante2.Id == estudiante3.Id && estudiante2.Nombre == estudiante3.Nombre)
            {
                Console.WriteLine("Los objetos son iguales");
            }


        }

        static void ChangeValue2(Estudiante est)
        {
            //est = new Estudiante();
            est.Id = 2;
            est.Nombre = "Maria";
            Console.WriteLine($"id: {est.Id}, Nombre: {est.Nombre}" );
        }

    }

    class Estudiante
    {
        public string Nombre { get; set; }
        public int Id { get; set; }
    }
}
