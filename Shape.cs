using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VecEd
{
    public class Shape
    {
        int borderSize = 2;
        Color borderColor = Color.Black;
        List<Point> vertex = new List<Point>();
        

        public Shape(Color _borderColor, int _borderSize) {
            borderColor = _borderColor;
            borderSize = _borderSize;
        }
    }


    public class Bezier : Shape
    {
        public Bezier(Color borderColor, int borderSize) : base(borderColor, borderSize) { }
    }
}
