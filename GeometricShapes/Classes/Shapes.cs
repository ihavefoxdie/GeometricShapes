using GeometricShapes.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Shapes
{
    
    public class Triangle
    {

        public Int32[] Sides
        {
            get;
            private set;
        }
        public Triangle(Int32 a, Int32 b, Int32 c)
        {
            Sides = new int[] {a, b, c};
            if (!Check())
                throw new TriangleException("Triangle cannot be built with set side lengths.", Sides);
                
        }

        private bool Check()
        {
            if (((Sides[0] + Sides[1]) > Sides[2]) && ((Sides[0] + Sides[2]) > Sides[1])
                && ((Sides[1] + Sides[2]) > Sides[0]))
                return true;
            return false;
        }

    }

    public class Quadrangle
    {
        public Int32[] Sides
        {
            get;
            private set;
        }
        public Quadrangle(Int32 a, Int32 b, Int32 c, Int32 d)
        {
            Sides = new int[] { a, b, c, d};
            if (!Check())
                throw new QuadrangleException("Quadrangle cannot be built with set side lengths.", Sides);
        }

        private bool Check()
        {
            if (((Sides[0] + Sides[1] + Sides[2]) > Sides[3]) && ((Sides[0] + Sides[1] + Sides[3]) > Sides[2])
                && ((Sides[0] + Sides[2] + Sides[3]) > Sides[1]) && ((Sides[1] + Sides[2] + Sides[3]) > Sides[0]))
                return true;
            return false;
        }
    }

    public class Circle
    {
        public Int32 Radius
        {
            get;
            private set;
        }

        public Circle(Int32 a)
        {
            Radius = a;
            if (!Check())
                throw new CircleException("Circle cannot be built with set radius.", _ = new Int32[] { Radius });
        }

        private bool Check()
        {
            if (Radius <= 0)
                return false;
            return true;
        }
    }
}
