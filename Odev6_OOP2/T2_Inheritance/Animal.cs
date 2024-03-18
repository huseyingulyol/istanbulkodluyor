using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_Inheritance
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }

        public void Sleep()
        {
            Console.WriteLine("Eating...");
        }

    }
    public class Cat : Animal
    {
        public void Purr()
        {
            Console.WriteLine("Meow...");
        }
    }
    public class Fish : Animal
    {
        public void Swim()
        {
            Console.WriteLine("Swimming...");
        }
    }
}
