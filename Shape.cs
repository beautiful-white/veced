using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VecEd
{
    public class Shape
    {
        public int borderSize = 2;
        public Color borderColor = Color.Black;
        public Color backgroundColor = Color.White;
        public List<Point> vertex = new List<Point>();
        

        public Shape(Color _borderColor, Color _backgroundColor, int _borderSize) {
            borderColor = _borderColor;
            borderSize = _borderSize;
            backgroundColor = _backgroundColor;
        }
    }


    public class Bezier : Shape
    {
        public Bezier(Color borderColor, Color backgroundColor, int borderSize) : base(borderColor, backgroundColor, borderSize) { }
    }
    public class Straight : Shape
    {
        public Straight(Color borderColor, Color backgroundColor, int borderSize) : base(borderColor, backgroundColor, borderSize) { }
    }
    public class Broken : Shape
    {
        public Broken(Color borderColor, Color backgroundColor, int borderSize) : base(borderColor, backgroundColor, borderSize) { }
    }
    public class Ellipse : Shape
    {
        public Ellipse(Color borderColor, Color backgroundColor, int borderSize) : base(borderColor, backgroundColor, borderSize) { }
    }
    public class Polygon : Shape
    {
        public Polygon(Color borderColor, Color backgroundColor, int borderSize, int corners) : base(borderColor, backgroundColor, borderSize) { }
    }

    public class Square : Shape
    {
        public Square(Color borderColor, Color backgroundColor, int borderSize) : base(borderColor, backgroundColor, borderSize) { }
    }
    public class Triangle : Shape
    {
        public Triangle(Color borderColor, Color backgroundColor, int borderSize) : base(borderColor, backgroundColor, borderSize) { }
    }

}
