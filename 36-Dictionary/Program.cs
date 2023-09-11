using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CREAR DICCIONARIO Y AGREGAR ELEMENTOS
            IDictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "uno");
            numberNames.Add(2, "dos");
            numberNames.Add(3, "tres");

            //El siguiente lanza una exception System.ArgumentException por que la clave 3 ya ha sido agregada
            //numberNames.Add(3, "tres");

            foreach (KeyValuePair<int, string> kvp in numberNames)
                Console.WriteLine("key: {0} y value {1}", kvp.Key, kvp.Value);

            //Creando un diccionario usando la sintaxis de inicializador de colecciones
            var cities = new Dictionary<string, string>()
            {
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };

            foreach (var kvp in cities)
                Console.WriteLine("key: {0} y value {1}", kvp.Key, kvp.Value);

            //ACCEDER ELEMENTOS AL DICCIONARIO
            IDictionary<string, string> cities2 = new Dictionary<string, string>()
            {
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };

            Console.WriteLine(cities2["UK"]);
            Console.WriteLine(cities2["USA"]);
            //Este marca una excepcion del tipo KeyNotFoundException por que no existe la clave en el diccionario
            //Console.WriteLine(cities2["France"]);

            //Para verificar una clave desconocida utilice el metodo ContainsKey
            if (cities2.ContainsKey("France"))
                Console.WriteLine(cities2["France"]);

            //Use el metodo TryGetValue para obtener el valor de una clave desconocida
            string result;
            if (cities2.TryGetValue("France", out result))
            {
                Console.WriteLine(result);
            }

            //int result;
            //if(citiesTryGetValue("France", out result))
            //{
            //    Console.WriteLine(result);
            //}

            //Uso del elemento elemnetAt para obtener el par clave-valor por medio del indice
            for (int i = 0; i < cities2.Count; i++)
            {
                Console.WriteLine("key: {0} value: {1}", cities2.ElementAt(i).Key, cities2.ElementAt(i).Value);
            }

            //ACTUALIZAR EL VALOR DE UN DICCIONARIO
            var cities3 = new Dictionary<string, string>()
            {
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };

            cities3["UK"] = "Liverpool, Bristol";
            cities3["USA"] = "Los Angeles, Boston";
            cities3["France"] = "paris";

            if(cities3.ContainsKey("France"))
            {
                cities3["France"] = "Paris";
            }

            //ELIMINA RLOS ELEMENTOS Y LIMPIAR EL DICCIONARIO
            var cities4 = new Dictionary<string, string>()
            {
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };

            cities4.Remove("UK");
            bool seElimino = cities4.Remove("France");
            if (seElimino)
                Console.WriteLine("El elemento se elimino correctamente");
            else
                Console.WriteLine("El elemento no se elimino por que no existe");

            if (cities4.ContainsKey("France"))
                cities4.Remove("France");

            cities4.Clear();



            Console.WriteLine("Termina el programa con exito");
            Console.ReadLine();
        }

        //public static bool citiesTryGetValue(string key, out string value)
        //{
        //    if (cities2.ContainsKey(key))
        //    {
        //        value = cities2[key];
        //        return true;
        //    }

        //    value = null;
        //    return false;
        //}


    }
}
