using System;

namespace LiskovSubstitutionPrinciple
{
    //LSP states that the derived classes should be perfectly substitutable for their base classes.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementaion of LiskovSubstitutionPrinciple");
            Shape shape = new Rectangle();
            Console.WriteLine(shape.Area());
            shape = new Circle();
            Console.WriteLine(shape.Area());
        }
    }
}
