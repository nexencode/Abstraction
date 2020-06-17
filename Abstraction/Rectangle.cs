using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Rectangle : Shape
    {
        private int _length;

        private int _width;

        public Rectangle(int length, int width)
        {
            _length = length;
            _width = width;
        }

        public override double Area()
        {
            return _length * _width;
        }
        public override double Perimeter()
        {
            return 2* _length + 2 * _width;
        }
    }
}
