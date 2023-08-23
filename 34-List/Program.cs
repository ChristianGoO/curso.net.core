using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AGREGANDO ELEMENTOD CON EL METODO ADD PARA ENTEROS
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(1);
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);

            //AGREGANDO  METODOS CON EL METODO ADD PARA CADENAS
            var cities = new List<string>();
            cities.Add("new york");
            cities.Add("london");
            cities.Add("mumbai");
            cities.Add("chicago");
            cities.Add(null);

            var students1 = new List<Estudiante>();
            students1.Add(new Estudiante() { Id = 1, Nommbre = "bill" });
            students1.Add(new Estudiante() { Id = 1, Nommbre = "steve" });
            students1.Add(new Estudiante() { Id = 1, Nommbre = "raw" });
            students1.Add(new Estudiante() { Id = 1, Nommbre = "abdul" });

            //CREANDO E INICIALIZANDO CON LA SINTAXIS DE INICIALIZANDO DE ELEMENTOS DE UNA LISTA
            var bigCities = new List<string>() { "New York", "London", "Mumbai", "Chicago" };

            var students2 = new List<Estudiante>() {
                new Estudiante() {Id = 1, Nommbre = "bill"},
                new Estudiante() {Id = 1, Nommbre = "steve"},
                new Estudiante() {Id = 1, Nommbre = "raw"},
                new Estudiante() {Id = 1, Nommbre = "abdul"}
            };

            Persona persona = new Persona() { Nombre = "maria", Apellido = "martinez", Domicillio = "calle 5" };
            Estudiante estudiante = new Estudiante()
            {
                Id = 1,
                Nombre = "pedro",
                Apellido = "gonzalez",
                Colegio = "bachiller 5",
                Domicillio = "calle 10",
                Grado = "1ro de secundaria",
                NombreProfesor = "juan perez"
            };
            Trabajador trabajador = new Trabajador()
            {
                Nombre = "juan jose",
                Apellido = "perez",
                Domicillio = "calle 30",
                Empresa = "bimbo",
                tipoTrabajo = "operador"
            };

            Auto auto = new Auto() { Modelo = 2019, Marca = "audi" };

            ImprimePersona(persona);
            ImprimePersona(estudiante);
            ImprimePersona(trabajador);
            //ImprimePersona(auto); marca error ya que no esta en la misma jerarquia de clases

            //AGREGANDO ARREGLOS IN UNA LISTA CON EL METODO ADD-RANGE 
            string[] cities2 = new string[3] { "mumbai", "london", "new york" };

            var popularCities = new List<string>();
            popularCities.AddRange(cities2);

            var favoriteCities = new List<string>();
            favoriteCities.AddRange(popularCities);
            //favoriteCities.AddRange(auto); Marca error ya que no esta en la misma jerarquia de clases

            //ACEDIENDO A UNA LISTA
            List<int> numbers = new List<int>() { 1, 2, 5, 7, 8, 10 };
            Console.WriteLine("------ IMPRIMIENDO CON EL INDICE--------- ");

            //Accediendo a los elementos de la lista con indices
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);

            Console.WriteLine("------ IMPRIMIENDO CON EL FOREACH--------- ");
            //Accediendolos elementos de la lista (iterando) con el foreach
            foreach (int numero in numbers)
                Console.WriteLine(numero);

            Console.WriteLine("------ IMPRIMIENDO CON EL FOREACH DE LA LISTA--------- ");
            //Accediendo los elementos de la lista (iterrando) con el foreach de la clase lista
            numbers.ForEach(numero => Console.WriteLine(numero));
            numbers.ForEach(numero => ImprimirNumero(numero));
            numbers.ForEach(numero => {
                Console.WriteLine(numero);
            });

            Console.WriteLine("------ IMPRIMIENDO CON EL FOR--------- ");
            //Accediendo los elementos de la lista con indices e iterando con el for
            for (int i = 0; i < numbers.Count; i++)
                Console.WriteLine(numbers[i]);

            //UTILIZANDO LINQ EN UNA LISTA 
            List<Estudiante> students = new List<Estudiante>() { 
                new Estudiante() {Id = 1, Nombre = "bill"},
                new Estudiante() {Id = 1, Nombre = "steve"},
                new Estudiante() {Id = 1, Nombre = "ram"},
                new Estudiante() {Id = 1, Nombre = "bill"}
            };

            //Obtiene todos los estudiantes cuyo nombre es bill
            var result1 = from s in students
                          where s.Nombre == "bill"
                          select s;

            var result2 = from s in students
                          where s.Nombre == "steve"
                          select s;

            foreach(var student in result1)
                Console.WriteLine($"el estudiante id: {student.Id}, nombre: {student.Nombre}");

            //INSERTAR ELEMENTO DE UNA LISTA
            Console.WriteLine("------ INSERTANDO ELEMENTOS--------- ");
            var numbers2 = new List<int>() { 10, 20, 30, 40 };
            numbers2.Insert(1, 11);

            foreach (var num in numbers2)
                Console.Write(num);

            //REMOVER ELEMENTOS DE UNA LISTA
            Console.WriteLine("--------REMOVER ELEMENTOS--------- ");
            var numbers3 = new List<int>() { 10, 20, 30, 40, 50, 10, 50, 50, 50, 50, 50};
            numbers3.Remove(10);
            numbers3.Remove(2);
            numbers3.RemoveRange(0, 3);
            numbers3.RemoveAll(numero => numero == 50);

            foreach (var num in numbers3)
                Console.Write(num);

            //VERIFICACION ELEMENTOS DE UNA LISTA
            Console.WriteLine("------VERIFICA ELEMENTOS EN UNA LISTA--------- ");
            var number4 = new List<int>() { 10, 20, 30, 40 };
            Console.WriteLine(number4.Contains(10));
            Console.WriteLine(number4.Contains(11));
            Console.WriteLine(number4.Contains(20));

            Console.ReadLine();
        }

        public static void ImprimePersona(Persona persona)
        {
            Console.WriteLine($"nombre completo es: {persona.Nombre} {persona.Apellido} ");
        }

        public static void ImprimirNumero(int numero)
        {
            Console.WriteLine(numero);
        }

    }
}
