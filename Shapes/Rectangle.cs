using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Quadrilateral
    {
        // Refactor Rectangle to use Quad constructor
        // Constructors:
        public Rectangle() : base() { }
        public Rectangle(float top, float left) : base(top, left, top, left) { }
        
        // Methods:
        public override float Area()
        {
                return this.Top * this.Bottom;
        }

        public override float Perimeter()
        {
            return (this.Top * 2) + (this.Left * 2);
        }
    }
}
