using System;

namespace AbstractClass
{
    abstract class AbsParent //Abstract Class
    {
        public static void Name()//Static method
        {
            Console.WriteLine("Static method is called.");
        }

        public void Add(int i, int b) //Non-Abstract method
        {
            Console.WriteLine(i+b);
        }
        public void Sub(int i, int b) //Non-Abstract method
        {
            Console.WriteLine(i-b);
        }
        public abstract void Mul(int i, int b); //Abstract method
        public abstract void Div(int i, int b); //Abstract method
        }

    class AbsChild: AbsParent
    {
        public override void Mul(int i, int b)//Mendatory to call the parent class Mul abstract method
        {
            Console.WriteLine(i*b);
        }
        public override void Div(int i, int b)//Mendatory to call the parent class Div abstract method
        {
            Console.WriteLine(i/b);
        }

        public void Roll()//Pure child class method
        {
            Console.WriteLine("Pure child class method is called.");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Let's learn about Abstract Class.");
            AbsParent.Name();

            AbsChild obj=new AbsChild();
            obj.Add(2, 3);
            obj.Sub(2, 3);
            
            obj.Mul(2, 3);
            obj.Div(2, 3);
            Console.ReadLine();

            AbsParent obj1 = obj; //we can take reference of the child class object(child-class instance), to create a parent class object(parent-class reference)
            obj1.Add(2, 3);
            obj1.Mul(4, 5);
            //obj1.Roll();   //Pure child class method can't be called by parent class reference, but overriden mmethods can be, as Add & Sub above.
            Console.ReadLine();
        }
    }
}
