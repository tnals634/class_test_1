using System;
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
            animals.Add(new Animal("cat", "nyang"));

            //강사 풀이
            for (int i =0; i<animals.Count;i++)
            {
                Animal thisAnimal = animals[i];
            }

            bool bFound = false;
            foreach(var animal in animals)
            {
                var animalName = animal.GetName();
                if(animalName == "pig")
                {
                    bFound = true;
                    break;
                }
            }

            if(bFound)
            {
                Console.WriteLine("pig found");
            }
            else
            {
                Console.WriteLine("pig not found");
            }
            ///////////////////////////////////////////

            foreach(var animal in animals)
            {
                //animal.MakcSound();
                var animalName = animal.GetName();
                if(animalName == "cat")
                {
                    Console.WriteLine("Found cat");
                    Console.WriteLine(">>");
                    animal.MakeSound();
                }
            }

            Animal myCat = animals.Find(item => item.GetName().Equals("cat"));
            Animal mpig = null;
            mpig = animals.Find(item => item.GetName().Equals("pig"));

            if(myCat != null)
            {
                Console.WriteLine("Foundt cat");
                Console.WriteLine(">>");
                myCat.MakeSound();
            }

            if(mpig != null)
            {
                Console.WriteLine("Found pig");
                Console.Write(">>");
                mpig.MakeSound();
            }
            else
            {
                Console.WriteLine("..not found pig");
            }

            Dictionary<enAnimalType, Animal> dicAnimals = new Dictionary<enAnimalType, Animal>();
            
            dicAnimals.Add(enAnimalType.fox, new Animal("red", "Reaww"));
            dicAnimals.Add(enAnimalType.cow, new Animal("blue", "moow"));
            dicAnimals.Add(enAnimalType.dog, new Animal("green", "nyang"));

            var someanimal = dicAnimals[enAnimalType.cat];

            foreach (KeyValuePair<enAnimalType, Animal> item in dicAnimals)
            {
                var key = item.Key;
                var value = item.Value;

                value.MakeSound();
            }

            foreach(var item in dicAnimals.Values)
            {
                item.MakeSound();
            }

            Animal outAnimal;
            if (dicAnimals.TryGetValue(enAnimalType.fox, out outAnimal))//이 값이 있나 없나 찾아보고 있으면 내보내고 없으면 else로 빠진다
            {
                outAnimal.MakeSound();
            }
            else
            {
                Console.WriteLine("[E] fox not found");
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
