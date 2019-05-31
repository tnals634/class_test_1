using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_test_1
{
    class Animal
    {
        static int numOfAnimals = 0;

        public string name;
        public string sound;
        
        public Animal()
        {
            numOfAnimals++;
        }

        public Animal(string n, string s)
        {
            name = n;
            sound = s;
            numOfAnimals++;
        }

        public void MakeSound()
        {
            Console.WriteLine("name = {0},sound = {1}", name, sound);
        }

        public static int GetNumOfAnimals()
        {
            return numOfAnimals++;
        }
    }
}
