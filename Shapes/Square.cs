using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : Rectangle
    {
        //Taking stuff from Rectangle
        public Square(int side_length) : base(side_length, side_length)
        {

        }
    }
}
