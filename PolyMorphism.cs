using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Addition a1 = new Addition();
            a1.sum(4, 5);
            a1.sum(3.4, 2.4);
            Circle c1 = new Circle();
            c1.setRadius(5);
            c1.getArea();

            Console.ReadLine();
        }
    }

    // Static PolyMorphism --> Method Overloading
    class Addition
    {
        public void sum(int a,int b)
        {
            Console.WriteLine("Sum is :" + (a + b));
        }
        public void sum(double a,double b)
        {
            Console.WriteLine("Sum is :" + (a + b));
        }
    }

    //Dynamic PolyMorphism --> Method Overriding
    class Shape
    {
        public virtual void getArea()
        {
            Console.WriteLine("Area of Shape is Area");
        }
    }
    class Circle : Shape
    {
        int radius;
        public void setRadius(int radius)
        {
            this.radius = radius;
        }
        public override void  getArea()
        {
            base.getArea(); // call parent method
            Console.WriteLine("Area of Circle is :" + 3.14 * radius * radius);
        }
    }
}
