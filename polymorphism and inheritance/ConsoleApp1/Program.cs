using System;

namespace ConsoleApp1
{
    class Shape
    {
        protected double width, height;
       

        public Shape(){}
        public Shape(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public void input()
        {
            Console.WriteLine("input of width: ");
            width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("input of height: ");
            height = Convert.ToDouble(Console.ReadLine());
        }

    }
    public interface Square
    {
       void Min();
    }
    class Restangle : Shape,Square
    {
        public Restangle() : base() { }
        public Restangle(double width, double height) : base(width, height) { }
        public double getArea()
        {
            return width * height;
        }
        public void Min()
        {
            Console.WriteLine("The maximum area of restangle is square");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Restangle reg = new Restangle(10,8);
           /* reg.input();*/
            Console.WriteLine("the output of program is: " + reg.getArea());
            reg.Min();
        }
    }
}
