using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_13_zoo
{
    class Fish: Animal
    {
       
        public Fish(string name, int age)
        {
            this.name = name;
            this.age = age;

        }

        
        public void swim()
        {
            Console.WriteLine("I can swim!");
        }
    }
}
