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
            return Top * Bottom;
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
            this.Right = height;
            this.Top = width;
            this.Left = height;
            this.Bottom = width;
        }
    }
}
