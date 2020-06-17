using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class Shape
    {

        public virtual double Area()
        {
            return default(double);
        }
        public virtual double Perimeter()
        {
            return default(double);
        }
    }
}
