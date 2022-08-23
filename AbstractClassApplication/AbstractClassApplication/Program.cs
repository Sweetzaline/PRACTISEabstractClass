//Entities: Rectangle, Circle, Triangle, Cone

//Rectangle: Width, Height
//Triangle: Width, Height
//Cone: Radius, Height, Pi
//Circle: Radius, Pi

//Common Attributes: Width, Height, Radius, Pi

//Find Area of each.// cant be defined in parent (can be declared though), since area formulae differs in each. This is where abstract method comes.

using System;

namespace AbstractClassApplication
{
    public abstract class Figures
    {
        public double Width, Height, Radius;
        public const float pi = 3.144f;

        public abstract double Area(); //Declaring here, method name & signature will be same.
    }

    public class Rectangle : Figures
    {
        public Rectangle(double Width, double Height) //Constructor
        {
            this.Width=Width;
            this.Height = Height;
        }
        public override double Area()
        {
            return Width * Height;
        }
    }

    public class Triangle : Figures
    {
        public Triangle(double Width, double Height)
        {
            this.Width = Width;
            this.Height = Height;
        }
        public override double Area()
        {
            return Width * Height;
        }
    }

    public class Circle : Figures
    {
        public Circle(double Radius) //pi is constant, so no need to pass
        {
            this.Radius = Radius;
        }
        public override double Area()
        {
            return Radius * pi;
        }
    }

    public class Cone : Figures
    {
        public Cone(double Radius, double Height)
        {
            this.Radius = Radius;
            this.Height = Height;
        }
        public override double Area()
        {
            return Radius * pi * (Radius + Math.Sqrt(Height * Height + Radius * Radius));
        }
    }



    public class Check
    {
        static void Main(string[] args) // this can be in child class too,  also can be in parent class, as child class instance is created to call the methods.
        {
            Console.WriteLine("Working on Abstract Classes!\n");
            Console.WriteLine("Areas:\n");
            Rectangle r = new Rectangle(12, 22.2);
            Console.WriteLine(r.Area());
            Triangle t = new Triangle(12, 22.2);
            Console.WriteLine(t.Area());
            Circle c = new Circle(12);
            Console.WriteLine(c.Area());
            Cone cn = new Cone(12, 22.2);
            Console.WriteLine(cn.Area());
        }
    }
}
