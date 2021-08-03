using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    //LSP by having a generic base class for both Rectangle and Circle.
    public abstract class Shape
        {

            public abstract double Area();
        }

        public class Rectangle : Shape
        {
        public double Width = 10;
        public double Height = 10;
            public override double Area()
            {
                return Width * Height;
            }
        }

        public class Circle : Rectangle
        {
        public double Radius = 10;
            public override double Area()
            {
                return Radius * Radius * Math.PI;
            }
        }
    
}
