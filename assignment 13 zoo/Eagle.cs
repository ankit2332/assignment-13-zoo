using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_13_zoo
{
    class Eagle: Animal
    {
        public Eagle(string name, int age)
        {
            this.name = name;
            this.age = age;
       
        }
 
        public void fly()
        {
            Console.WriteLine("I can fly!");
        }
    }
}
