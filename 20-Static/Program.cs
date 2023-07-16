using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Static
{
    public class Program /*: programBase()*/
    {

        static int counter = 0;
        string name = "demo program";

        static void Main(string[] args)
        {

            //PRUEBA DE CONSTRUCTORES ESTATICOS 
            StopWatch sw00 = new StopWatch();
            StopWatch sw01 = new StopWatch();
            StopWatch.DisplayInfo();
            StopWatch.DisplayInfo();


            //USO DE LA CLASE ESTATICA
            var result = Calculator.Suma(10, 25);
            Calculator.store(result);

            var callType = Calculator.Type;
            Calculator.Type = "Cientifico";

            //var objCalculator = new Calculator(); //NO SE PUEDE CREAR U OBJETO DE UNA CLASE ESTATICA


            //USO DE LA CLASE NO ESTATICA Y CAMPOS NO ESTATICOS
            Console.WriteLine(StopWatch.NoOfInstances);

            StopWatch sw1 = new StopWatch();
            StopWatch sw2 = new StopWatch();
            Console.WriteLine(StopWatch.NoOfInstances);

            StopWatch sw3 = new StopWatch();
            StopWatch sw4 = new StopWatch();
            Console.WriteLine(StopWatch.NoOfInstances);

            //CADA OBJETO IMPRIMIR EL NUMERO DE INSTANCIA
            sw1.PrintNotInstances();
            sw2.PrintNotInstances();
            sw3.PrintNotInstances();
            sw4.PrintNotInstances();

            counter++;
            display("hello world");

            Program program = new Program();
            program.name = "nuevo programa demo";
            program.SetRootFolder("C:\\MyProperty");
            Console.WriteLine(Program.GetSaludo());



        }
 
        static void display(string text)
        {
            Console.WriteLine(text);
        }

        public void SetRootFolder(string path) 
        {
            GetSaludo("");
        }

        public static string GetSaludo()
        {
            //static string saludo = "hola Mundo"; no se puede definir esta variable estatica
            //return "Hola Mundo" + name; no se puede llamar a una variable no estatica (variable de instancia) por el metodo estatico
        
            Program program1 = new Program();
            program1.SetRootFolder("c://misdocumentos/");

            return "hola mundo";
        }

        public static string GetSaludo(string nombre)
        {
            return "Hola " + nombre;
        }

        public static string GetSaludo(string nombre, string apellido)
        {
            return "Hola " + nombre + " " + apellido;
        }

    }

    //public class programBase
    //{
    //    public static string getSaludo()
    //    {
    //        return "hola mundo";
    //    }
    //}

}
