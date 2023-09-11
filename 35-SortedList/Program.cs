using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CREAR SORTED LIST Y AGREGAR ELEMENTOS
            SortedList<int, string> numberNames = new SortedList<int, string>();
            numberNames.Add(3, "tres");
            numberNames.Add(1, "uno");
            numberNames.Add(2, "dos");
            numberNames.Add(4, null);
            numberNames.Add(10, "diez");
            numberNames.Add(5, "cinco");

            //numberNames.Add("tres", 2); Error en un tiempo de compilacion
            //numberNames.Add(1, "uno"); Este arroja un error de ejecucion por que ya existe un elemento con la misma clase
            //numberNames.Add(null, "cinco");Esto es error en tiempo de compilacion

            //CREAMOS EL SORTED LIST CON LA SINTAXIS DE INICIALZADOR DE COLECCIONES
            SortedList<string, string> ciudades = new SortedList<string, string>()
            {
                { "london", "uk" },
                {"new york", "usa"},
                {"mumbai", "india"},
                {"johannesburgo", "sur africa" }
            };

            //ORDENACON DE LOS ELEMENTOS POR DEFECTO
            SortedList<int, string> numberNames2 = new SortedList<int, string>()
            {
                {3, "Three"},
                {5, "Five"},
                {1, "One"}
            };

            Console.WriteLine("---Clave valor---");
            foreach (KeyValuePair<int, string> kvp in numberNames2)
                Console.WriteLine("key: {0}, valor: {1}", kvp.Key, kvp.Value);

            numberNames2.Add(6, "seis");
            numberNames2.Add(2, "dos");
            numberNames2.Add(4, "cuatro");

            Console.WriteLine("-------Despues de agregar nuevas Clave-valor ---");
            foreach (var kvp in numberNames2)
                Console.WriteLine("key: {0}, valor {1}", kvp.Key, kvp.Value);

            //ACCESO DE VALORES DE UN SORTEDLIST
            SortedList<int, string> numberNames3 = new SortedList<int, string>()
            {
                {3, "tres" },
                {1, "uno" },
                {2, "dos" }
            };

            Console.WriteLine(numberNames3[1]);
            Console.WriteLine(numberNames3[2]);
            Console.WriteLine(numberNames3[3]);
            //Console.WriteLine(numberNames3[10]); Error a la hora de ejecucion por no encontrar la clave 10; Marca un error del tipo KeyNotFountException ya que no existe la clave 10

            numberNames3[2] = "doss";
            numberNames3[4] = "CUatro";

            Console.WriteLine(numberNames3[2]);
            Console.WriteLine(numberNames3[4]);

            //PROBANDO LOS METODOS CONTAINSKEY Y TRYGETVALUE
            SortedList<int, string> numberNames4 = new SortedList<int, string>()
                                    {
                                        {3, "tres"},
                                        {1, "uno"},
                                        {2, "dos"}
                                    };

            bool existe = numberNames4.ContainsKey(4);
            if (existe)
                numberNames4[4] = "four";

            string result;
            bool sConvirtio = numberNames4.TryGetValue(4, out result);
            if (sConvirtio)
                Console.WriteLine("key: {0}, value: {1}", 4, result);

            //TIRANDO UN SORTED LIST USANDO UN CICLO FOR 
            SortedList<int, string> numberNames5 = new SortedList<int, string>()
            {
                {3, "tres" },
                {1, "uno" },
                {2, "dos" }
            };

            for (int i = 0; i < numberNames5.Count; i++)
            {
                Console.WriteLine("Key: {0}, value: {1}", numberNames5.Keys[i], numberNames5.Values[i]);
            }

            //REMOVER ELEMENTOS DEL SORDET LIST 
            SortedList<int, string> numberNames6 = new SortedList<int, string>()
                                    {
                                        {3, "Three"},
                                        {1, "One"},
                                        {2, "Two"},
                                        {5, "Five"},
                                        {4, "Four"}
                                    };

            //bool seElimino = false;
            //seElimino = numberNames6.Remove(1);
            //seElimino = numberNames6.Remove(10);

            numberNames6.Remove(1);
            numberNames6.Remove(10);

            numberNames6.RemoveAt(0);
            //numberNames6.RemoveAt(10); Lanza un error en tiempo de ejecucion del tipo ArgumentOutOfRangeException

            foreach (var kvp in numberNames6)
            {
                Console.WriteLine("Key: {0}, Valor: {1}", kvp.Key, kvp.Value);
            }


            Console.Read();
        }
    }
}
