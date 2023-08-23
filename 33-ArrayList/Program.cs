using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DIFERENCIAS MANERAS DE CREAR UN OBJETO ARRAYLIST
            ArrayList arrayListX = new ArrayList();
            var arlistZ = new ArrayList();

            //CREAR Y AGREGAR ELEMENTOS AL ARRAYS
            var arlist1 = new ArrayList();
            arlist1.Add(1);
            arlist1.Add("bill");
            arlist1.Add(" ");
            arlist1.Add(true);
            arlist1.Add(4.5);
            arlist1.Add(null);

            //CREAR E INICIALIZADOR EL ARRAY CON LAS SINTAXIS E INICIALIZADOR DE OBJETOS
            var arlist2 = new ArrayList() { 2, "steve", " ", true, 4.5, null };

            //AGREGAR ELEMENTOS A UN ARREGLO CON EL METODO addRange(ICollection c)
            var arlist3 = new ArrayList();

            var arlist4 = new ArrayList() { 1, "bill", " ", true, 4.5, null };

            int[] arr = { 100, 200, 300, 400 };

            Queue myQ = new Queue();
            myQ.Enqueue("hello");
            myQ.Enqueue("world");

            arlist3.AddRange(arlist4);
            arlist3.AddRange(arr);
            arlist3.AddRange(myQ);

            //ACCEDIENDO ELEMENTOS DE UN ARRAYLIST

            //Accediendo elementos con el index y con conversion explicita (cast)
            var arlist5 = new ArrayList() { 1, "Bill", 300, 4.5f };
            int? firstElement = (int?)arlist5[0];
            //string secondElement = (string)arlist5[1]; Este marca un error
            int? secondElementInt = (int?)arlist5[1];

            //Accediendo elementos con el index y con la palabra reservada var
            var vfirstElement = arlist5[0];
            var vsecondElement = arlist5[1];
            var vfifthElement = arlist5[5];

            //Actualizar los elementos
            arlist5[0] = "Steve";
            arlist5[1] = 100;
            //arlist5[5] = 500; System.ArgumentOutOfRangeException

            //ITERAR ARREGLOS
            ArrayList arlist6 = new ArrayList() { 1, "bill", 300, 4.5F };

            Console.WriteLine("Iterando en el foreach");
            foreach (var item in arlist6)
                Console.WriteLine(item + ", ");

            Console.WriteLine();
            Console.WriteLine("Iterando con un for e indices");
            for (int i = 0; i < arlist6.Count; i++)
            {
                Console.WriteLine(arlist6[i] + ", ");
            }

            //INSERTAR ELEMENTOS EN UN ARRAYLIST 
            Console.WriteLine();
            Console.WriteLine("Iterando elemento e iterandolo con un for e indices");
            ArrayList arlist7 = new ArrayList() { 1, "Bill", 300, 4.5f };
            arlist7.Insert(1, "Second Items");

            foreach(var elemento in arlist7)
                Console.WriteLine(elemento + ", ");

            //INSERTAR VARIOS ELEMENTOS
            Console.WriteLine();
            Console.WriteLine("Iterando con un for e indices");
            ArrayList arlist8 = new ArrayList(){ 100, 200, 600};
            ArrayList arlist9 = new ArrayList(){ 300, 400, 500};
            arlist8.InsertRange(2, arlist9);

            foreach (var elemento in arlist8)
                Console.WriteLine(elemento + ", ");

            //ELIMINAR ELEMENTOS
            Console.WriteLine();
            Console.WriteLine("Eliminando elementos e Iterando con un foreach");
            ArrayList arlist10 = new ArrayList() { 1, "Bill", 300, 4.5f, 300, null};
            arlist10.Remove(null);
            arlist10.Remove(4);
            arlist10.RemoveRange(0, 2);

            //VERIFICAR SI EXISTE UN ELEMENTO
            ArrayList arlist11 = new ArrayList() { 1, "Bill", 300, 4.5f };
            
            bool existe = arlist11.Contains(300);
            Console.WriteLine("el 300 si existe: " + arlist11.Contains(300));
            Console.WriteLine("el Bill si existe: " + arlist11.Contains("Bill"));
            Console.WriteLine("el 10 si existe: " + arlist11.Contains(10));
            Console.WriteLine("el Steve si existe: " + arlist11.Contains("Steve"));



            Console.ReadLine();
        }
    }
}
