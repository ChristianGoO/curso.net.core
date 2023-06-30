using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Structuras
{
    internal class Coordinate2
    {

        private int _x, _y;
        public event Action<int> CoordinateChange;

        public int x
        {

            get
            {
            
                return this._x;
            
            }

            set
            {

                this._x = value;
                CoordinateChange(this._x);

            }

        }

        public int y
        {

            get
            {

                return this._y;

            }

            set
            {

                this._y = value;
                CoordinateChange(this._y);

            }

        }

    }
}
