using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _37_HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CREAR Y AGREGAR ELEMENTOS
            Hashtable numbernames = new Hashtable();
            numbernames.Add(1, "one");
            numbernames.Add(2, "two");
            numbernames.Add(3, "three");
            numbernames.Add("3", "three");
            numbernames.Add(false, false);
            numbernames.Add("1", new Estudiante());
            numbernames.Add("1", new Estudiante());

            //numbernames.Add(3, "three"); Este te marcaa error ya que existe uno con esas propiedades

            foreach (DictionaryEntry entry in numbernames)
                Console.WriteLine("key:{0}, value:{1}", entry.Key, entry.Value);

            //CREAR UN HASTABLE UTILIZANDO LAS SINTAXIS DE COLECCION DE COLECCIONES
            var cities = new Hashtable()
            {
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };

            foreach (DictionaryEntry entry in cities)
                Console.WriteLine("key{0}, value{1}", entry.Key, entry.Value);

            //CREAR UN HASTABLE A PARTIR DE UN DICCIONERIO
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "uno");
            dict.Add(2, "dos");
            dict.Add(3, "tres");

            Hashtable ht = new Hashtable(dict);

            //ACTUSLIZAR UN HASTABLE 
            var cities2 = new Hashtable()
            {
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"},
                {1, 1},
                {false, false}
            };

            string citieOFUK = (string)cities2["UK"];
            string citieOFUSA = (string)cities2["USA"];
            object valor = cities2[1];

            Console.WriteLine(citieOFUK);
            Console.WriteLine(citieOFUSA);

            int numero;
            bool boleano;
            if (valor is System.Int32)
                numero = (int)valor;
            if (valor is System.Boolean)
                boleano = (bool)valor;

            cities2["UK"] = "Liverpool, Bristol";
            cities2["USA"] = "Los angeles, Boston";
            //cities2["FRance"] = "PAris";

            if (!cities2.ContainsKey("France"))
                cities2["France"] = "paris";

            //ELIMINAR Y LIMPIAR UN HASTTABLE 
            var cities3 = new Hashtable()
            {
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };

            cities3.Remove("UK");
            cities3.Remove("France"); //no existe y por eso no me marca un error

            if (!cities3.ContainsKey("France"))
                cities3.Remove("France");

            cities3.Clear();


            Console.WriteLine(citieOFUK);
            Console.WriteLine(citieOFUSA);

            Console.ReadLine();
        }

    }

    public class Estudiante
    {
        public int Nombre { get; set; }

    }

}
