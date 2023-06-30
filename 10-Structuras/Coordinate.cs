using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace _10_Structuras
{
    internal struct Coordinate
    {
        public int x { get; set; }
        public int y { get; set; }

        public Coordinate(int x, int y)
        {

            this.x = x;
            this.y = y;

        }

        public void SetOrigin ()
        {

            this.x = 1;
            this.y = 1;

        }

        public static Coordinate GetOrigin()
        {

            Coordinate newPoint = new Coordinate();
            return newPoint;

        }

    }
}
