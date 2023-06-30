using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Structuras
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Coordinate point = new Coordinate();
            Console.WriteLine(point.x);

            point.x = 10;
            point.y = 20;
            Console.WriteLine(point.y);
            Console.WriteLine(point.x);

            Coordinate point2 = new Coordinate(10, 20);
            Console.WriteLine(point2.x);
            Console.WriteLine(point2.y);

            Coordinate point3 = new Coordinate( );
            point3.SetOrigin();
            Console.WriteLine(point3.x);
            Console.WriteLine(point3.y);

            Coordinate point4 = Coordinate.GetOrigin();
            Console.WriteLine(point4.x);
            Console.WriteLine(point4.y);

            Coordinate2 point5 = new Coordinate2();
            point5.CoordinateChange += notifica;
            point5.x = 10;
            point5.y = 20;

        }

        static void notifica(int point)
        { 

            Console.WriteLine("Coordenada cambiada a {0}", point);

        }

    }
}
