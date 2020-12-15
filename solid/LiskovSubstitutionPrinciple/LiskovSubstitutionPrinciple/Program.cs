using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            //ICollection<String> x = new string[] { "abc" };
            //x.Add("def");

            var r1 = new Rectangle(4, 5);
            Console.WriteLine($"r1.area: {r1.Area()}");
            DoubleLength(r1);

            var r2 = new Square(5);
            Console.WriteLine($"r2.area: {r2.Area()}");
            DoubleLength(r2);

            Console.Read();
        }

        static void DoubleLength(Rectangle rectangle)
        {
            rectangle.setLength(rectangle.getLength() * 2);
            Console.WriteLine($"Area with double length: {rectangle.Area()}");
            Console.WriteLine($"Length after change: {rectangle.getLength()}");
            Console.WriteLine($"Height after change: {rectangle.getHeight()}");
        }

        class Rectangle
        {
            protected int length;
            protected int height;

            public int getLength()
            {
                return length;
            }

            public int getHeight()
            {
                return height;
            }

            public virtual void setLength(int value)
            {
                this.length = value;
            }

            public virtual void setHeight(int value)
            {
                this.height = value;
            }

            public Rectangle(int length, int height)
            {
                this.length = length;
                this.height = height;
            }

            public int Area()
            {
                return length * height;
            }
        }

        class Square : Rectangle
        {
            public override void setLength(int value)
            {
                this.length = value;
                this.height = this.length;
            }

            public override void setHeight(int value)
            {
                this.height = value;
                this.length = this.height;
            }

            public Square(int side) : base(side, side)
            {
                
            }
        }
    }
}
