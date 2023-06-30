using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime dt1 = new DateTime();
            Console.WriteLine("El valor de dt1 es {0}", dt1);

            DateTime dt2 = new DateTime(2015, 12, 31);
            Console.WriteLine("El valor de dt2 es {0}", dt2);

            DateTime dt3 = new DateTime(2015, 12, 31, 5, 10, 20);
            Console.WriteLine("El valor de dt3 es {0}", dt3);

            DateTime dt4 = new DateTime(2015, 12, 31, 5, 10, 20, DateTimeKind.Utc);
            Console.WriteLine("El valor de dt4 es {0}", dt4.ToLocalTime());

            try
            {
                DateTime dt5 = new DateTime(2015, 12, 32);
                Console.WriteLine("El valor de dt5 es {0}", dt5);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Hubo un error de conversion: {0}", ex);
            }

            DateTime dt6 = new DateTime(636370000000000000);
            Console.WriteLine("El valor de dt6 es {0}", dt6);

            Console.WriteLine("La fecha minima es {0}", DateTime.MinValue);
            Console.WriteLine("El ticks de la fecha minima es {0}", DateTime.MinValue.Ticks);

            Console.WriteLine("La fecha maxima es {0}", DateTime.MaxValue);
            Console.WriteLine("El ticks de la fecha maxima es {0}", DateTime.MinValue.Ticks);

            //CAMPOS ESTATICOS
            DateTime fechaHoraActual = DateTime.Now;
            Console.WriteLine("El valor de la fechaHoraActual es {0}", fechaHoraActual);

            DateTime fechaActual = DateTime.Today;
            Console.WriteLine("El valor de la fechaActual es {0}", fechaActual);

            DateTime fechaHoraActualUTC = DateTime.UtcNow;
            Console.WriteLine("El valor de la fechaHoraActualUTC es {0}", fechaHoraActualUTC);

            DateTime fechaHoraMin = DateTime.MinValue;
            Console.WriteLine("El valor de la fechaHoraMin es {0}", fechaHoraMin);

            DateTime fechaHoraMax = DateTime.MaxValue;
            Console.WriteLine("El valor de la fechaHoraMax es {0}", fechaHoraMax);

            //ESPACIO TIEMPO
            DateTime dt7 = new DateTime(2015, 12, 31);
            TimeSpan ts = new TimeSpan(25, 20, 55);
            DateTime nuevaFechaHora = dt7.Add(ts);
            Console.WriteLine("El valor de la nuevaFechaHora es {0}", nuevaFechaHora);

            //RESTA
            DateTime dt8 = new DateTime(2015, 12, 31);
            DateTime dt9 = new DateTime(2016, 2, 2);
            TimeSpan ts2 = dt9.Subtract(dt8);
            Console.WriteLine("El valor de ts2 es {0}", ts2);

            DateTime fechaHoraActual1 = DateTime.Now;
            DateTime fechaNacimiento = new DateTime(2000, 03, 01, 8, 0, 0);
            TimeSpan ts3 = fechaActual.Subtract(fechaNacimiento);
            Console.WriteLine("El valor de ts3 es {0}", ts3);

            //OPERADORES
            DateTime dt10 = new DateTime(2015, 12, 20);
            DateTime dt11 = new DateTime(2016, 12, 31, 5, 10, 20);
            TimeSpan time = new TimeSpan(10, 5, 25, 50);

            Console.WriteLine(dt11 + time); // 1/10/2017 10:36:10 AM
            Console.WriteLine(dt11 - dt10); //377.05:10:20
            Console.WriteLine(dt10 == dt11); //False
            Console.WriteLine(dt10 != dt11); //True
            Console.WriteLine(dt10 > dt11); //False
            Console.WriteLine(dt10 < dt11); //True
            Console.WriteLine(dt10 >= dt11); //False
            Console.WriteLine(dt10 <= dt11);

            // CONVERSION DE FECHA DE CADENA A FECHA Y HORA
            string str = "5/12/2020";
            DateTime dt;

            bool fechaEsValida = DateTime.TryParse(str, out dt);

            if (fechaEsValida)
                Console.WriteLine("La fecha convertida es {0}", dt);
            else
                Console.WriteLine($"{str} no es una fecha valida");

            //CONVERSION POR
            try
            {
                DateTime dt12 = DateTime.Parse(str);
                Console.WriteLine("La fecha es convertida es {0}", dt12);
            }
            catch(Exception) 
            {

                Console.WriteLine($"{str} no es una fecha valida");
            
            }



        }
    }
}
