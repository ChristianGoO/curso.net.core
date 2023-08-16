using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CICLO DO WHILE
            int i = 0;
            do
            {
                Console.WriteLine($"i = {i}");
                i++;
            } while (i < 5);

            //CICLO DO WHILE CON BREAK
            i = 0;
            do
            {
                Console.WriteLine("i = {0}", i);
                i++;
                if (i > 5)
                    break;

            } while (i < 10);

            doWhileReturn();

            //DO WHILE ANIDADO
            i = 0;
            do
            {
                Console.WriteLine("Valor de i es {0}", i);
                int j = i;
                i++;
                
                do
                {
                    Console.WriteLine("el valor de j es {0}", j);
                    j++;
                }while (j < 2);

            }while (i < 2);

            Console.Clear();

            int OPCION = 0;

            do
            {
                Console.WriteLine("BIENVENIDO A LA ADMINISTRACION DEL MENU");
                Console.WriteLine();
                Console.WriteLine("OPCIONES DEL MENU");
                Console.WriteLine("1. Alta del alumno");
                Console.WriteLine("3. Eliminar alumno");
                Console.WriteLine("4. Consulta del alumno");
                Console.WriteLine("5. Salir");
                Console.WriteLine("Seleccione una opcion");
                OPCION = int.Parse(Console.ReadLine());
                switch (OPCION)
                {
                    case 1:
                        AltaAlumno();
                        break;
                    case 2:
                        ActualizacionAlumno();
                        break;
                    case 3:
                        EliminarAlumno();
                        break;
                    case 4:
                        ConsultaDeAlumno();
                        break;
                    case 5:
                        Salir();
                        break;
                    default:
                        OpcionNoValida();
                        break;
                }
            } while (OPCION != 5);
        }

        public static void AltaAlumno()
        {
            Console.WriteLine("ALTA DE ALUMNO");
            Console.WriteLine("Da clic para continuar");
            Console.ReadLine();
        }

        public static void ActualizacionAlumno()
        {
            Console.WriteLine("ACTUALIZACION DE ALUMNO");
            Console.WriteLine("Da clic para continuar");
            Console.ReadLine();
        }

        public static void EliminarAlumno()
        {
            Console.WriteLine("ELIMINAR DE ALUMNO");
            Console.WriteLine("Da clic para continuar");
            Console.ReadLine();
        }

        public static void ConsultaDeAlumno()
        {
            Console.WriteLine("CONSULTA DE ALUMNO");
            Console.WriteLine("Da clic para continuar");
            Console.ReadLine();
        }

        public static void Salir()
        {
            Console.WriteLine("Salir");
            Console.WriteLine("Da clic para continuar");
            Console.ReadLine();
        }

        public static void OpcionNoValida()
        {
            Console.WriteLine("Opcion no valida");
            Console.WriteLine("Da clic para continuar");
            Console.ReadLine();
        }

        public static void doWhileReturn()
        {
            //CICLO DO WHILE CON RETURN
            int i = 0;
            do
            {
                Console.WriteLine("i = 0}", i);
                i++;
                if (i > 5)
                    return;
            }while (i < 10);
        }

    }
}
