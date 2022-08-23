using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's learn about Abstract Class vs Overriding. \n");
            Class2 obj1 = new Class2();
            obj1.Show();
            Class4 obj2 = new Class4();
            obj2.Test2();
        }
    }

    //Override Class
    class Class1
    {
        public virtual void Show()
        {
            Console.WriteLine("Parent Class Show method.");

        }
    }
    class Class2 : Class1
    {
        public override void Show() //Optional Re-implementation //Overriding
        {
            Console.WriteLine("Re-implementation of Parent Class Show Method.");
        }
    }

    //Abstract Class
    abstract class Class3
    {
        public void Test1(int i, int b)//Parent Class Test1 method
        {
            Console.WriteLine("Parent Class Test1 method.");

        }

        public abstract void Test2(); //Parent Class Test2 method
    }
    class Class4 : Class3
    {
        public override void Test2() //Mendatory Implementation //Overriding
        {
            Console.WriteLine("Implementation of Parent Class Test2 Method.");
        }
    }

}
