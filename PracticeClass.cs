using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_test_1
{
    public static partial class PracticeClass
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

        public static void practice12() //삼각형 크래스
        {
            List<Triangle1> triangles = new List<Triangle1>();
            triangles.Add(new Triangle1(3, 4, 5));
            triangles.Add(new Triangle1(3, 3, 3));
            triangles.Add(new Triangle1(5, 4, 3));

            int index = 1;
            foreach(Triangle1 shape in triangles)
            {
                shape.Draw(index);
                index++;
            }
        }

        class Triangle1 // practice12
        {
            private int A, B, C;
            public Triangle1(int a, int b, int c)
            {
                A = a;
                B = b;
                C = c;
            }

            public int getA
            {
                get { return this.A; }
            }

            public int getB
            {
                get { return this.B; }
            }
            public int getC
            {
                get { return this.C; }
            }
            public int Triangle_add(int a, int b, int c)
            {
                return a + b + c;
            }

            public void Draw(int a)
            {
                Console.WriteLine("Draw({0},{1},{2})", getA, getB, getC);
                Console.WriteLine("둘레 길이 : {0}\n", Triangle_add(getA, getB, getC));
            }
        }

        public static void practice13_1()
        {
            //2개의 숫자 (int, double 형 각각)을 받아들여 덧셈, 뺄셈 곱셈, 나눗셈을
            //수행하는 메서드를 갖는 클래스를 작성하시오.
            /*Computation_int com = new Computation_int(20, 10);
            Console.WriteLine("a = {0}, b = {1}", com.A, com.B);
            Console.WriteLine("사칙연산 결과 : {0}, {1}, {2}, {3}\n", com.Add(com.A, com.B), com.Sub(com.A, com.B), com.Mul(com.A, com.B), com.Div(com.A, com.B));
            Computation_double com1 = new Computation_double(20.5, 10.5);
            Console.WriteLine("x = {0}, y = {1}", com1.A, com1.B);
            Console.WriteLine("사칙연산 결과 : {0}, {1}, {2}, {3:N6}\n", com1.Add(com1.A, com1.B), com1.Sub(com1.A, com1.B), com1.Mul(com1.A, com1.B), com1.Div(com1.A, com1.B));
            */
            List<Computation_int> com1 = new List<Computation_int>();
            com1.Add(new Computation_int(0, 10));
            List<Computation_double> com2 = new List<Computation_double>();
            com2.Add(new Computation_double(20.5, 10.5));

            int index1 = 1, index2 = 1;
            foreach (Computation_int shape in com1)
            {
                shape.Draw(index1);
                index1++;
            }
            foreach (Computation_double shape in com2)
            {
                shape.Draw(index2);
                index2++;
            }


        }

        class Computation_double // 사칙연산(double 형)
        {
            private double number1 = 0;
            private double number2 = 0;

            public Computation_double(double a, double b)
            {
                number1 = a;
                number2 = b;
            }
            public double A
            {
                get { return this.number1; }
            }
            public double B
            {
                get { return this.number2; }
            }

            public double Add(double a, double b) //덧셈
            {
                return a + b;
            }
            public double Sub(double a, double b) //뺄셈
            {
                return a - b;
            }
            public double Mul(double a, double b) //곱셈
            {
                return a * b;
            }
            public double Div(double a, double b) //나눗셈
            {
                double c = 0;
                if ((a != 0) || (b != 0))
                {
                    if (a > b)
                    {
                        c = a / b;
                    }
                    else
                    {
                        c = b / a;
                    }
                }
                return c;
            }
            public void Draw(double c)
            {
                Console.WriteLine("a = {0}, b = {1}", A, B);
                Console.WriteLine("사칙연산 결과 : {0}, {1}, {2}, {3:N6}", Add(A, B), Sub(A, B), Mul(A, B), Div(A, B));
            }
        }

        class Computation_int //사칙연산(int 형)
        {
            private int number1 = 0;
            private int number2 = 0;

            public Computation_int(int a, int b)
            {
                number1 = a;
                number2 = b;
            }
            public int A
            {
                get { return this.number1; }
            }
            public int B
            {
                get { return this.number2; }
            }

            public int Add(int a, int b) //덧셈
            {
                return a + b;
            }
            public int Sub(int a, int b) //뺄셈
            {
                return a - b;
            }
            public int Mul(int a, int b) //곱셈
            {
                return a * b;
            }
            public int Div(int a, int b) //나눗셈
            {
                int c = 0;
                if ((a != 0) || (b != 0))
                {
                    if (a > b)
                    {
                        c = a / b;
                    }
                    else
                    {
                        c = b / a;
                    }
                }
                return c;
            }
            public void Draw(int c)
            {
                Console.WriteLine("a = {0}, b = {1}", A, B);
                Console.WriteLine("사칙연산 결과 : {0}, {1}, {2}, {3}", Add(A, B), Sub(A, B), Mul(A, B), Div(A, B));
            }
        }

        public static void practice13_2()
        {
            List<Computation<int>> computations_int = new List<Computation<int>>();
            List<Computation<double>> computations_double = new List<Computation<double>>();
            computations_int.Add(new Computation<int>(20, 10));
            computations_double.Add(new Computation<double>(20.5, 10.5));
            int index = 1;
            foreach (Computation<int> shape in computations_int)
            {
                shape.Draw(index);
                index++;
            }
            foreach (Computation<double> shape in computations_double)
            {
                shape.Draw(index);
                index++;
            }
        }

        class Computation<T>
        {
            private T number1;
            private T number2;

            public Computation(T a, T b)
            {
                number1 = a;
                number2 = b;
            }

            public T A
            {
                get { return this.number1; }
            }
            public T B
            {
                get { return this.number2; }
            }
            //public static double? Add(T a, T b) //덧셈
            //{
            //    if (a is int)
            //        return ((a as int?) + (b as int?));
            //    else
            //        return ((a as double?) + (b as double?));
            //}
            //public static double? Sub(T a, T b) //뺄셈
            //{
            //    if (a is int)
            //        return ((a as int?) - (b as int?));
            //    else
            //        return ((a as double?) - (b as double?));
            //}
            //public static double? Mul(T a, T b) //곱셈
            //{
            //    if (a is int)
            //        return ((a as int?) * (b as int?));
            //    else
            //        return ((a as double?) * (b as double?));
            //}
            //public static double? Div(T a, T b) //나눗셈
            //{
            //    if ((a is int))
            //        return ((a as int?) / (b as int?));
            //    else
            //        return ((a as double?) / (b as double?));
            //}
            //public void Draw(int c)
            //{
            //    Console.WriteLine("a = {0}, b = {1}", A, B);
            //    Console.WriteLine("사칙연산 결과 : {0}, {1}, {2}, {3}", Add(A, B), Sub(A, B), Mul(A, B), Div(A, B));
            //}
            
            //강사 풀이
            public T Add(T a, T b)
            {
                dynamic da = a;
                dynamic db = b;

                dynamic sum = da + db;
                return sum;
            }
            public T Sub(T a, T b)
            {
                dynamic da = a;
                dynamic db = b;

                dynamic sub = da - db;
                return sub;
            }
            public T Mul(T a, T b)
            {
                dynamic da = a;
                dynamic db = b;

                dynamic mul = da * db;
                return mul;
            }
            public T Div(T a, T b)
            {
                dynamic da = a;
                dynamic db = b;

                dynamic div = 0;
                if((da!=0) ||(db!=0))
                {
                    if(da>db)
                    {
                        div = da / db;
                    }
                    else
                    {
                        div = db / da;
                    }
                }
                return div;
            }
            public void Draw(int c)
            {
                Console.WriteLine("a = {0}, b = {1}", A, B);
                Console.WriteLine("사칙연산 결과 : {0}, {1}, {2}, {3}", Add(A, B), Sub(A, B), Mul(A, B), Div(A, B));
            }
        }

        public static void practice14()
        {
            string name;
            string c = null;
            int check = 1;
            Console.Write("차이름 입력: ");
            name = Console.ReadLine();
            Car car = new Car(name);
            Console.WriteLine("Car Name : {0}",car.CarName);
            Console.WriteLine("'s' = 시작시 속도, 'u' = 액셀 속도 올리기, \n'd' = 정지 후 속도, 'b' = 시동 끈 후 속도, 'a' = 프로그램 종료");
            while (c != "a")
            {
                c = Console.ReadLine();
                if (c == "s")
                {
                    Console.WriteLine("시작시 속도: {0}",car.Start());
                }
                else if (c == "u")
                {
                    Console.WriteLine("액셀 {0}단계 속도: {1}", check, car.Accelerate(check));
                    check++;
                }
                else if (c == "d")
                {
                    check--;
                    Console.WriteLine("정지후 속도: {0}", car.Break(check));                    
                }
                else if(c == "b")
                {
                    Console.WriteLine("끄고난후 속도: {0}", car.Stop());
                }
            }
        }

        class Car
        {
            private string name;
            private int s;
            public Car(string n)
            {
                name = n;
            }
            public string CarName
            {
                get { return this.name; }
            }
            public int Start()
            {
                s = 1;
                return s;
            }
            public int Stop()
            {
                return 0;
            }
            public int Accelerate(int speed)
            {
                speed *= 10;
                speed += 1;
                return speed;
            }
            public int Break(int speed)
            {
                if (speed != 0)
                {
                    speed *= 10;
                    speed += 1;
                    speed -= 10;
                }
                else
                {
                    speed = 0;
                }
                return speed;
            }
        }

        public static void practice15()
        {
            MyPaint my = new MyPaint();

            Triangle_Draw t = new Triangle_Draw(3,4,5);
            my.DrawShape(t);
            Console.WriteLine();

            Rectangle_Draw r = new Rectangle_Draw(5, 10);
            my.DrawShape(r);
            Console.WriteLine();

            CustomShape_Draw c = new CustomShape_Draw(5, 10, 2, 2);
            my.DrawShape(c);
        }

        interface IDrawble
        {
            void Draw();
        }

        class MyPaint
        {
            List<IDrawble> drawbles = new List<IDrawble>();

            public MyPaint()
            {

            }

            public void DrawShape(IDrawble shape)
            {
                drawbles.Add(shape);
                foreach(IDrawble s in drawbles)
                {
                    s.Draw();
                }
            }
        }

        class Triangle_Draw : IDrawble
        {
            private int line1 = 0;
            private int line2 = 0;
            private int line3 = 0;

            public Triangle_Draw(int a, int b, int c)
            {
                this.line1 = a;
                this.line2 = b;
                this.line3 = c;
            }
            public void Draw()
            {
                Console.WriteLine($"Draw Triangle : ({line1},{line2},{line3})");
            }
        }

        class Rectangle_Draw : IDrawble
        {
            private int width = 0;
            private int height = 0;

            public Rectangle_Draw(int w, int h)
            {
                this.width = w;
                this.height = h;
            }

            public void Draw()
            {
                Console.WriteLine($"Draw Triangle : ({width},{height})");
            }
        }

        class CustomShape_Draw : IDrawble
        {
            private int width = 0;
            private int height = 0;
            private int x = 0;
            private int y = 0;

            public CustomShape_Draw(int w, int h, int x1, int y1)
            {
                this.width = w;
                this.height = h;
                this.x = x1;
                this.y = y1;
            }

            public void Draw()
            {

                Console.WriteLine($"Draw Triangle : ({width},{height},{x},{y})");
            }
        }

        public static void practice16()
        {
            Full_Time_Employee fte = new Full_Time_Employee("gaga", 01);
            fte.AnnalSalary = 30000;
            fte.AdiustSalary(-100);
            Console.WriteLine("{0}'s annual salary is {1}",fte.Name,fte.AnnalSalary);
            fte.SayName();
            Console.WriteLine();

            Part_Time_Employee pte = new Part_Time_Employee("nana", 02);
            pte.TimeSalary = 9800;
            pte.CalculatePay(5);
            Console.WriteLine("{0}'s work hour is {1}, total pay is {2}", pte.Name, pte.TimeSalary, pte.CalculatePay(5));
            pte.SayName();
        }

        public class Employee
        {
            public string Name { get; set; }
            public string Email { get; set; }

            public Employee(string name)
            {
                this.Name = name;
            }
            public virtual void SayName()
            {
                Console.WriteLine($"My name is {Name}");
            }
        }

        public class Full_Time_Employee : Employee
        {
            private int EmployeeNumber { get; set; }

            public Full_Time_Employee(string name, int number) : base(name)
            {
                EmployeeNumber = number;
            }
            public int AnnalSalary { get; set; }
            
            public void AdiustSalary(int anount)
            {
                this.AnnalSalary += anount;
            }
            public override void SayName()
            {
                //base.SayName();
                Console.WriteLine($"My number is {EmployeeNumber}, name is {Name}");
            }
        }

        public class Part_Time_Employee : Employee
        {
            private int EmployeeNumber { get; set; }
            public int TimeSalary { get; set; }

            public int CalculatePay(int time)
            {
                return TimeSalary * time;
            }

            public Part_Time_Employee(string name, int number) : base(name)
            {
                EmployeeNumber = number;
            }
            public override void SayName()
            {
                //base.SayName();
                Console.WriteLine($"My number is {EmployeeNumber}, name is {Name}");
            }
        }

        public static void practice17()
        {
            //Student_Score student = new Student_Score(1,85,92,88);
            //student.All_Sum();
            //student.All_Div();
            //student.Printing();

            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("number.txt"))
                {
                    string line;
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        public class Student
        {
            public int Number { get; set; }
            public int Korea_Number { get; set; }
            public int English_Number { get; set; }
            public int Math_Number { get; set; }
            public Student(int number,int knumber,int enumber,int mnumber)
            {
                this.Number = number;
                this.Korea_Number = knumber;
                this.English_Number = enumber;
                this.Math_Number = mnumber;
            }

        }

        public class Student_Score : Student
        {
            
            public Student_Score (int number,int knumber,int enumber,int mnumber) : base(number,knumber,enumber,mnumber)
            {
                
            }
            public int All_Sum()
            {
                return Korea_Number + English_Number + Math_Number;
                
            }
            
            public int All_Div()
            {
                return  (Korea_Number + English_Number + Math_Number) / 3;
            }
            
            public void Printing()
            {
                Console.WriteLine($"{Number},{Korea_Number},{English_Number},{Math_Number}///{All_Sum()},{All_Div()}");
            }
        }
    }
}

public class Triangle //practice10
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