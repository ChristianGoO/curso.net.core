using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> miPila = new Stack<int>();
            miPila.Push(1);
            miPila.Push(2);
            miPila.Push(3);
            miPila.Push(4);
            miPila.Push(5);

            foreach (var elemento in miPila)
                Console.Write(elemento + ", ");

            Stack<Estudiante> miPilaEstudiantes = new Stack<Estudiante>();
            miPilaEstudiantes.Push(new Estudiante() { Id = 1, Nombre = "juan", ApellidoPaterno = "perez" });
            miPilaEstudiantes.Push(new Estudiante() { Id = 2, Nombre = "pedro", ApellidoPaterno = "sanchez" });
            miPilaEstudiantes.Push(new Estudiante() { Id = 3, Nombre = "fernando", ApellidoPaterno = "lopez" });
            miPilaEstudiantes.Push(new Estudiante() { Id = 4, Nombre = "lucia", ApellidoPaterno = "sanchez" });

            foreach (Estudiante estudiante in miPilaEstudiantes)
                Console.Write(estudiante.Id + ", " + estudiante.Nombre + ", " + estudiante.ApellidoPaterno);

            List<int> miLista = new List<int>() { 1, 2, 3, 4, 5, 6 };
            Stack<int> miPila2 = new Stack<int>(miLista);
            foreach (var elemento in miPila2)
                Console.Write(elemento + ", ");

            Stack<int> miPila3 = new Stack<int>();
            miPila3.Push(1);
            miPila3.Push(2);
            miPila3.Push(3);
            miPila3.Push(4);
            miPila3.Push(5);

            Console.WriteLine("El numero de elementos en la pila es: {0}", miPila3.Count);

            while (miPila3.Count > 0)
                Console.WriteLine(miPila3.Pop() + ", ");

            Console.WriteLine();
            Console.WriteLine("El numero de elementos en la pila es: {0}", miPila3.Count);

            Stack<int> miPila4 = new Stack<int>();
            miPila4.Push(1);
            miPila4.Push(2);
            miPila4.Push(3);
            miPila4.Push(4);
            miPila4.Push(5);

            Console.WriteLine("El numero de elementos en la pila es: {0}", miPila4.Count);

            if (miPila4.Count > 0)
            {
                Console.Write(miPila4.Peek() + ", ");
                Console.Write(miPila4.Peek() + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("El numero de elementos en la pila es: {0}", miPila4.Count);

            Stack<int> miPila5 = new Stack<int>();
            miPila5.Push(1);
            miPila5.Push(2);
            miPila5.Push(3);
            miPila5.Push(4);
            miPila5.Push(5);

            Console.WriteLine(miPila5.Contains(2));
            Console.WriteLine(miPila5.Contains(10));

            Console.Read();
        }
    }

    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
    }

}
