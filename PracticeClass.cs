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
            string str = "kunsan University" + " " + "is good";
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

            TrimEnd(sb6, '.');

            Console.WriteLine(sb6.ToString());

        }
        public static void TrimEnd(StringBuilder n, char a)
        {
            String i = n.ToString();
            int ac = 0;
            ac = n.Length - 1;
            //n.Remove(ac, 1);
            if (n.Length == 0) return;
            if (i.Contains('.'))
            {
                n.Length -= 1;
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

            //Tuple<String, double>[] areas =
            //{
            //    Tuple.Create("Sitka, Alaska", 2870.3),
            //    Tuple.Create("New York City", 302.6),
            //    Tuple.Create("Los Angeles", 468.7),
            //    Tuple.Create("Detroit", 138.8),
            //    Tuple.Create("Chicago", 227.1),
            //    Tuple.Create("San Diego", 325.2)
            //};
            //Console.WriteLine("{0, -18} {1,14:N1} {2,30}\n", "City", "Area (mi.)", "Equivalent to a square with:");
            //foreach (var area in areas)
            //{
            //    Console.WriteLine("{0,-18} {1,14:N1} {2,14:N2} miles per side", area.Item1, area.Item2, Math.Round(Math.Sqrt(area.Item2), 2));
            //}

            //Console.WriteLine(Math.Max(2,5));
            //Console.WriteLine(Math.Atan2(2.0,2.0));
        }
        public static void practice4()
        {
            //String name = null;
            //Console.Write("Enter Your Name : ");
            //name = Console.ReadLine();
            //Console.WriteLine("Hello, {0}",name);

            String id1 = "sumin", pw = "1234", password = null, id2 = null;
            Console.Write("Your id : ");
            id2 = Console.ReadLine();
            Console.WriteLine(" password : ");
            password = Console.ReadLine();
            if ((id1 != id2) || (pw != password))
            {
                if (id1 != id2) Console.WriteLine("아이디가 틀립니다.");
                if (pw != password) Console.WriteLine("비밀번호가 틀립니다.");
            }
            else
            {
                Console.WriteLine("인증되었습니다.");
            }
        }
        public static void practice5()
        {
            //한 학급에 5명의 학생이 있고, 각 학생당 국영수 세과목 점수가 배열에 저장되어 있을때,
            //각 학생별 국영수 합계 및 그 평균을 출력하는 프로그램을 작성하시오.

            //(점수 데이터)
            //90,80,90
            //85,85,85
            //95,70,75
            //80,80,90
            //90,75,80

            //(출력결과)
            //id : 0, 합계 : , 평균 : ....

            int[,] member = new int[,] { { 90,80,90},{ 85,85,85},{ 95,70,75},
            { 80,80,90},{ 90,75,80} };
            double[] add = new double[5];
            double[] avg = new double[5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    add[i] += member[i, j];
                }
                avg[i] = add[i] / 3;
                Console.WriteLine("id = {0}, 합계 = {1}, 평균 = {2:N2}", i, add[i], avg[i]);
            }
        }
        public static void practice6()
        {
            //한 문자열의 대문자는 소문자로, 소문자는 대문자로 변경하는 프로그램을 작성하시오.
            //Hello, World -> hELLO, wORLD
            //스트링을 배열로 인식해서 하나씩 해결

            string name = "Hello, World";
            char[] name2 = new char[name.Length];
            int na = 0;
            for (int i = 0; i < name.Length; i++)
            {
                name2[i] = name[i];

                if (('A' <= (int)name2[i]) && ((int)name2[i] <= 'Z'))
                {
                    na = (int)name2[i] + 32;
                }
                else if (('a' <= (int)name2[i]) && ((int)name2[i] <= 'z'))
                {
                    na = (int)name2[i] - 32;
                }

                name2[i] = (char)na;
                Console.Write(name2[i]);
            }

            ////강사 풀이
            //string s = "Hello, Worold";
            //string result = string.Empty;

            //for(int i = 0; i < s.Length; i++)
            //{
            //    char t = s[i];
            //    if(char.IsUpper(t))
            //    {
            //        t = char.ToLower(t);
            //    }
            //    else if(char.IsLower(t))
            //    {
            //        t = char.ToUpper(t);
            //    }
            //    result = result + t;
            //}
            //Console.WriteLine(result);
        }
        public static void practice7()
        {
            //"Hello World"를 시저의 암호화 기법을 사용하여 "Khoor Zruog"
            //으로 출력하는 프로그램을 작성하시오
            //[결과]
            //원문 : Hello World
            //암호 : Khoor Zruog

            string name = "Hello World";
            char[] name2 = new char[name.Length];
            int na = 0;

            Console.WriteLine("원문 : " + name);
            Console.Write("암호 : ");

            for (int i = 0; i < name.Length; i++)
            {
                name2[i] = name[i];

                if (('A' <= (int)name2[i]) && ((int)name2[i] <= 'Z'))
                {
                    na = (int)name2[i] + 3;
                }
                else if (('a' <= (int)name2[i]) && ((int)name2[i] <= 'z'))
                {
                    na = (int)name2[i] + 3;
                }
                else
                {
                    na = 32;
                }

                name2[i] = (char)na;
                Console.Write(name2[i]);
            }

            //강사 풀이
            //string plaintText = "Hello World";

            //StringBuilder sb = new StringBuilder();

            //foreach(char ch in plaintText)
            //{
            //    char newchar = ch;
            //    if((ch >='A' && ch<='Z')||(ch >= 'a' && ch<='z'))
            //    {
            //        newchar = (char)(ch + 3);
            //        if((Char.IsUpper(ch) && newchar>'Z')||(Char.IsLower(ch) && newchar>'z'))
            //        {
            //            newchar = (char)(newchar - 26);
            //        }
            //    }
            //    sb.Append(newchar);
            //}
            //Console.WriteLine(sb.ToString());
        }
        public static void practice8()
        {
            //임의의 정의 값들을 배열로 받아들여, 그 합계를 구하는
            //메서드(함수)를 작성하시오.

            //[결과화면]
            //A : 80,90,95,75,70
            //Sum(A) = 410

            //B : 90,85,85,85,80
            //Sum(B) = 425

            int[] number1 = new int[] { 80, 90, 95, 75, 70 };
            int[] number2 = new int[] { 90, 85, 85, 85, 80 };

            Console.WriteLine("A : {0}", string.Join<int>(",", number1)); // string.Join<int>(",",number1) -> number1의 수들을 ,을 이용하여 사이를 연결.
            Console.WriteLine("Sum(A) = {0}\n", Sum(number1));

            Console.Write("B : ");
            for (int i = 0; i < number2.Length; i++)
            {
                Console.Write(number2[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Sum(B) = {0}", Sum(number2));

        }
        public static int Sum(int[] number)
        {
            int sum = 0;
            for (int j = 0; j < number.Length; j++)
            {
                sum += number[j];
            }
            return sum;
        }
        public static void practice9()
        {
            //2개의 정수 값을 받아들여 덧셈, 뺄셈, 곱셈, 나눗셈을 각각 수행하는 4개의 메서드를 작성하시오.
            //이들 메서드를 사용하여 아래와 같은 계산식의 결과를 출력하시오
            //(3 + 5 - 2) x 2 / 3 = 4

            int number = Number_Add(3, 5);
            number = Number_Sub(number, 2);
            number = Number_Mul(number, 2);
            number = Number_Div(number, 3);
            Console.Write("(3 + 5 - 2) x 2 / 3 = ");
            Console.WriteLine(number);

        }
        public static int Number_Add(int a, int b) //덧셈
        {
            return a + b;
        }
        public static int Number_Sub(int a, int b) //뺄셈
        {
            return a - b;
        }
        public static int Number_Mul(int a, int b) //곱셈
        {
            return a * b;
        }
        public static int Number_Div(int a, int b) //나눗셈
        {
            return a / b;
        }
        public static void practice10()
        {
            //다음과 같은 조건을 갖는 삼각형(Triangle) 클래스를 작성하세요.
            //[조건]
            //삼각형은 세변의 길이를 가지고 있으며, 클래스로부터 객체를 생성할 때
            //세변의 길이가 주어져야 한다.
            //클래스는 삼각형의 주변 둘레를 알려줄 수 있다.
            //클래스는 삼각형을 그리는 기능을 갖는다. 여기서는 실제 삼각형을 그리기 보다는 "Draw(a,b,c)"라는 문자열을
            //출력하는 코드로 구현한다.(a,b,c는 각변의 길이)

            Triangle tri1 = new Triangle(3,4,5);
            Console.WriteLine("삼각형1 : A = {0}, B = {1}, C = {2}",tri1.A, tri1.B, tri1.C);
            Console.WriteLine("둘레길이 : {0}",tri1.Triangle_Sum(tri1.A, tri1.B, tri1.C));

            Triangle tri2 = new Triangle(3,3,3);
            Console.WriteLine("삼각형2 : A = {0}, B = {1}, C = {2}", tri2.A, tri2.B, tri2.C);
            Console.Write("Draw : ");
            tri2.Draw(tri2.A, tri2.B, tri2.C);
        }
    }
}

public class Triangle
{
    //필드
    private double number1 = 0;
    private double number2 = 0;
    private double number3 = 0;

    public Triangle(double a, double b, double c)
    {
        number1 = a;
        number2 = b;
        number3 = c;
    }
    public double A
    {
        get { return this.number1; }
    }
    public double B
    {
        get { return this.number2; }
    }
    public double C
    {
        get { return this.number3; }
    }

    public double Triangle_Sum(double a, double b, double c)
    {
        return a + b + c;
    }

    public void Draw(double a, double b, double c)
    {
        Console.WriteLine("Draw({0},{1},{2})", a, b, c);
    }
}