﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Rectangle rect1;
            rect1.length = 100;
            rect1.width = 30;

            Console.WriteLine("rectangle length:{0}, whith:{1}", rect1.length, rect1.width);

            Rectangle rect2 = new Rectangle(200, 50);
            Console.WriteLine("rectangle length:{0}, whith:{1}, area:{2}", rect2.length, rect2.width, rect2.Area());
            */

            Console.WriteLine(String.Empty);
            Console.WriteLine("Class Animals");
            Console.WriteLine("=================");

            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal("fox", "Reaww"));
            animals.Add(new Animal("cow", "moo"));
            animals.Add(new Animal("dog", "bowwow"));

            foreach(Animal animal in animals)
            {
                animal.MakeSound();
            }
            Console.WriteLine("number : {0}", Animal.GetNumOfAnimals());


            Console.WriteLine(String.Empty);
            Console.WriteLine("Class Angle");
            Console.WriteLine("==========================");

            Console.WriteLine("Area of Rectangle : {0}", ShapeMath.GetArea(enShape.Rectangle, 5, 6));

            Console.WriteLine("Area of Triangle : {0}", ShapeMath.GetArea(enShape.Triangle, 5, 6));

            Console.WriteLine("Area of Circle : {0}", ShapeMath.GetArea(enShape.Circle, 5, 6));

            Console.ReadLine();
        }

        struct Rectangle
        {
            public double length;
            public double width;

            public Rectangle(double l, double w)
            {
                length = l;
                width = w;
            }

            public double Area()
            {
                return length * width;
            }
        }
    }
}
