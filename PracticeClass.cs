using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_test_1
{
    public static class PracticeClass
    {
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
        public static void practice1()
        {
            Console.WriteLine("Struct");
            Console.WriteLine("===================");

            Rectangle rect1;
            rect1.length = 100;
            rect1.width = 30;

            Console.WriteLine("rectangle length:{0}, whith:{1}", rect1.length, rect1.width);

            Rectangle rect2 = new Rectangle(200, 50);
            Console.WriteLine("rectangle length:{0}, whith:{1}, area:{2}", rect2.length, rect2.width, rect2.Area());


            Console.WriteLine(String.Empty);
            Console.WriteLine("Class Animals");
            Console.WriteLine("=================");

            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal("fox", "Reaww"));
            animals.Add(new Animal("cow", "moo"));
            animals.Add(new Animal("cat", "nyang"));

            //강사 풀이
            for (int i = 0; i < animals.Count; i++)
            {
                Animal thisAnimal = animals[i];
            }

            bool bFound = false;
            foreach (var animal in animals)
            {
                var animalName = animal.GetName();
                if (animalName == "pig")
                {
                    bFound = true;
                    break;
                }
            }

            if (bFound)
            {
                Console.WriteLine("pig found");
            }
            else
            {
                Console.WriteLine("pig not found");
            }
            ///////////////////////////////////////////

            foreach (var animal in animals)
            {
                //animal.MakcSound();
                var animalName = animal.GetName();
                if (animalName == "cat")
                {
                    Console.WriteLine("Found cat");
                    Console.WriteLine(">>");
                    animal.MakeSound();
                }
            }

            Animal myCat = animals.Find(item => item.GetName().Equals("cat"));
            Animal mpig = null;
            mpig = animals.Find(item => item.GetName().Equals("pig"));

            if (myCat != null)
            {
                Console.WriteLine("Foundt cat");
                Console.WriteLine(">>");
                myCat.MakeSound();
            }

            if (mpig != null)
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

            foreach (var item in dicAnimals.Values)
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
        public static void practice2()
        {
            string str = "kunsan University"+" "+"is good";
            //Console.WriteLine(str.ToLower()); //소문자로 출력

            //Console.WriteLine(str.ToUpper()); //대문자로 출력

            //Console.WriteLine(str.Contains("kunsan")); //kunsan이 있으면 true, 없으면 false

            //Console.WriteLine(str.Contains("Kunsan"));

            //Console.WriteLine(str[7]);

            //Console.WriteLine(str.IndexOf("University"));

            //Console.WriteLine(str.IndexOf('U'));

            //Console.WriteLine(str.Substring(0, 6)); //index값 0번부터 6개가 나옴

            //Console.WriteLine(str.Substring(str.IndexOf("University"))); //U~~ 끝까지 다 나옴

            //example 1
            /*StringBuilder sb = new StringBuilder();
            for (int i=0;i<10;i++)
            {
                sb.Append(i).Append(" ");
            }
            Console.WriteLine(sb.ToString());*/

            //example 2
            /*StringBuilder sb2 = new StringBuilder();
            sb2.Append("The list starts here : ");
            sb2.AppendLine(); // 새줄로 넘어감
            sb2.Append("1 cat").AppendLine();

            string str2 = sb2.ToString();
            Console.WriteLine(str2);*/

            //example 3
            /*StringBuilder sb3 = new StringBuilder("korea University");
            sb3.Replace("korea", "Kunsan"); // 앞문장을 뒷문장으로 교체
            Console.WriteLine(sb3);*/

            //example 4
            /*string[] items = { "Cat", "Dog", "Fox", "Pig" };

            StringBuilder sb4 = new StringBuilder("These animals are required : ").AppendLine();

            foreach(string item in items)
            {
                sb4.Append(item).AppendLine();
            }
            Console.WriteLine(sb4.ToString());*/

            //example 5
            /*StringBuilder sb5 = new StringBuilder("Kunsan is University");
            sb5.Remove(7, 3);
            Console.WriteLine(sb5);*/

            //example 6
            StringBuilder sb6 = new StringBuilder();
            sb6.Append("Kunsan University.");

            TrimEnd(sb6,'.');

            Console.WriteLine(sb6.ToString());
            
        }
        public static void TrimEnd(StringBuilder n,char a)
        {
            String i = n.ToString();
            int ac = 0;
            ac = n.Length - 1;
            //n.Remove(ac, 1);
            if(n.Length == 0) return;            
            if(i.Contains('.'))
            {
                n.Length -=1;
            }

            //강사
            /*if (n.Length == 0) return;

            if(n[n.Length-1] == a)
            {
                n.Length -= 1;
            }*/
            ///////////////////////
        }

        public static void practice3()
        {
            //Console.WriteLine(5 + 8);
            //Console.WriteLine(5 - 8);
            //Console.WriteLine(5 * 8);
            //Console.WriteLine(5 / 2);
            //Console.WriteLine(5 / 2.0);
            //Console.WriteLine(5 % 2);
            //Console.WriteLine(4 + 5 * 2);
            //Console.WriteLine(5.1 - 8.3);
            //Console.WriteLine(Math.Abs(-5)); // 절댓값
            //Console.WriteLine(Math.Pow(2, 3)); // 앞수를 뒷수만큼 거듭제곱
            //Console.WriteLine(Math.Ceiling(-10.2)); // 소숫점 올림 정수값으로 반환해줌
            //Console.WriteLine(Math.Floor(0.5m)); // 소숫점 내림 정수값으로 반환
            //Console.WriteLine(Math.Sqrt(4)); // 지정 숫자의 루트값으로 반환

            Tuple<String, double>[] areas =
            {
                Tuple.Create("Sitka, Alaska", 2870.3),
                Tuple.Create("New York City", 302.6),
                Tuple.Create("Los Angeles", 468.7),
                Tuple.Create("Detroit", 138.8),
                Tuple.Create("Chicago", 227.1),
                Tuple.Create("San Diego", 325.2)
            };
            Console.WriteLine("{0, -18} {1,14:N1} {2,30}\n", "City", "Area (mi.)", "Equivalent to a square with:");
            foreach (var area in areas)
            {
                Console.WriteLine("{0,-18} {1,14:N1} {2,14:N2} miles per side", area.Item1, area.Item2, Math.Round(Math.Sqrt(area.Item2), 2));
            }

            //Console.WriteLine(Math.Max(2,5));
            //Console.WriteLine(Math.Atan2(2.0,2.0));
        }
    }
}