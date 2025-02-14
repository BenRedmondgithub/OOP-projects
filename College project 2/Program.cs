using System;
using System.Globalization;

namespace ShapePro
{

    public class Shape 
    
    {
        protected String Name;

        public Shape (string Name) 
        {
            this.Name = Name;
        }

    public virtual void DrawShape() 
    {
        Console.WriteLine($"Drawing a {Name}...");
    }

    public virtual double CalculateArea() 
    {
        Console.WriteLine("Calculating area...");
        return 0;
    }

    public class Triangle : Shape 
    {
        protected double SideA, SideB, SideC;

        public Triangle (string name, double sideA, double sideB, double sideC) : base (name)
        
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
        }
 
            public override void DrawShape()
        {
            Console.WriteLine($" Drawing {Name} with side{SideA}, {SideB}, {SideC} ... ");
        }

        }

    public class RightAngledTriangle : Triangle 
        {
            public RightAngledTriangle(Double sideA, double SideB) : base ("Right Angled Triangle",double sideA, double SideB)
            {}
        }

    public class EqiulateralTriangle : Triangle 
        {

        }



    }

    class Mainprogram 
    {

        public static void Main(string[] args)
        {
            
        }

    }
}
