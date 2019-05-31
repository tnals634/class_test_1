using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_test_1
{
    class Animal
    {
        public string name;
        public string sound;
        
        public Animal()
        {

        }

        public Animal(string n, string s)
        {
            name = n;
            sound = s;
        }

        public void MakeSound()
        {
            Console.WriteLine("name = {0},sound = {1}", name, sound);
        }
    }
}
