using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Quadrilateral
    {
        public override float Area()
        {
            return Side1 * Side2;
        }

        /*
        public override float Perimeter()
        {
            return (2 * (Side1 + Side2));
        }
        */

        //Constructor
        public Rectangle(int height, int width)
        {
            this.Side1 = height;
            this.Side2 = width;
            this.Side3 = height;
            this.Side4 = width;
        }
    }
}
