using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_CovarianzaContravarianza
{
    internal class Program
    {

        public delegate Small CovarDelegado(big mc);

        static void Main(string[] args)
        {
            
            Small small = new Small();
            small.id = 1;
            small.nombre = "juan";
            //small.tamaño = 2.30f

            big big = new big();
            big.id = 2;
            big.nombre = "maria";
            big.descripcion = "persona grande";
            //big.tamaño = 2.30f

            bigger bigger = new bigger();
            bigger.id = 3;
            bigger.nombre = "pedro";
            bigger.descripcion = "persona extragrande";
            bigger.tamaño = 2.30f;

            //CREACION DE OBJETOS Y ASIGNACION DE VARIABLES
            Small small1 = new Small();
            Small small2 = new big();
            Small small3 = new bigger();
            big big1 = new bigger();
            //big big2 = new Small();

            CovarDelegado del1 = Method1;
            Small sm1 = del1(new big());

            CovarDelegado del2 = Method2;
            Small sm2 = del2(new big());

            CovarDelegado del3 = Method3;
            Small sm3 = del3(new big());

            CovarDelegado del4 = Method2;
            //big sm4 = del4(new big());

            CovarDelegado del5 = Method4;
            Small sm5 = del5(new big());


            CovarDelegado del = Method1;
            del += Method2;
            del += Method3;
            del += Method4;

            Small small5 = del(new big());


            CovarDelegado del6 = Method5;
            Small sm6 = del6(new big());

        }


        public static big Method1(big bg)
        {
            Console.WriteLine("Method1");

            return new big();
        }
        public static Small Method2(big bg)
        {
            Console.WriteLine("Method2");

            return new Small();
        }

        public static bigger Method3(big bg)
        {
            Console.WriteLine("Method3x|");

            return new bigger();
        }

        public static Small Method4(Small sml)
        {
            Console.WriteLine("Method2");

            return new Small();
        }

        static big Method5(Small sml)
        {
            Console.WriteLine("Method3");

            return new big();
        }

    }


    public class Small
    {
        public int id { get; set; }

        public string nombre { get; set; }
    }

    public class big : Small
    {
        public string descripcion { get; set; }
    
    }

    public class bigger : big
    {
        public float tamaño { get; set; }
    }
}
