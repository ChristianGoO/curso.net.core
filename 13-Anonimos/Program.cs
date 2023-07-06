using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Anonimos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //TIPOS DE DATOS VS TIPOS ANONIMOS
            Estudiante estudiante1 = new Estudiante();
            var estudiante2 = new Estudiante();
            var estudiante3 = new { Id = 1, Nombre = "juan", ApellidoPaterno = "PEREZ"};
            Console.WriteLine(estudiante3.Id);
            Console.WriteLine(estudiante3.Nombre);
            Console.WriteLine(estudiante3.ApellidoPaterno);

            //LAS PORPIEDADES ANONIMAS SON SOLO DE LECTURA
            //estudiante3.id = 2;
            //estudiante3.nombre = "Steve";

            //TIPOS DE DATOS ANONIMOS ANIDADOS
            var estudiante4 = new 
            { 
                Id = 1,
                Nombre = "juan",
                ApellidoPaterno = "PEREZ",
                Direccion = new 
                { 
                    Id = 1,
                    ciudad = "Londres",
                    country = "UK"
                }
            };
            Console.WriteLine(estudiante4);

            //ARREGLO CON OBJETOS ANONIMOS
            var estudiantes = new[] 
            {
                new {Id = 1, Nombre = "JUAN", ApellidoPaterno = "Perez"},
                new {Id = 2, Nombre = "JUAN", ApellidoPaterno = "Perez"},
                new {Id = 3, Nombre = "JUAN", ApellidoPaterno = "Perez"}
            };
            Console.WriteLine(estudiantes);

            //LOS OBJETOS ANONIMOS APLICADOS EN CONSULTAS LINQ
            IList<Estudiante> ListaEstudiante = new List<Estudiante>() 
            { 
                new Estudiante(){estudianteId = 1, Nombre = "JUAN", edad = 23},
                new Estudiante(){estudianteId = 2, Nombre = "MARIA", edad = 23},
                new Estudiante(){estudianteId = 3, Nombre = "ISABEL", edad = 23},
                new Estudiante(){estudianteId = 4, Nombre = "PEDRO", edad = 23},
                new Estudiante(){estudianteId = 5, Nombre = "ALONSO", edad = 23},
            };

            var consultaStudiantes = from s in ListaEstudiante
                                     select new { id = 1, nombre = ""};

            foreach(var estudiante in  consultaStudiantes)
            {
                Console.WriteLine("id: " + estudiante.id, "Nombre: " + estudiante.nombre);
            }


            //OBTENER EL TIPO DE DATOS DE UN ANONIMO
            var estudiante5 = new { Id = 1, FirstName = "James", LastName = "Bond" };
            Console.WriteLine(estudiante5.GetType().ToString());


            Console.Read();
        }
    }

    class Estudiante 
    {
        public int estudianteId { get; set; }
        public string Nombre { get; set; }
        public int edad { get; set; }
    }

}
