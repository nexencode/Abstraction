using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Circle : Shape
    {
        private const double _pi = 3.14;
        private int _radius;

        public Circle(int radius)
        {
            this._radius = radius;
        }

        public override double Area()
        {
            return _radius * _radius * _pi;
        }
        public override double Perimeter()
        {
            return 2 * _radius * _pi;
        }
    }
}
