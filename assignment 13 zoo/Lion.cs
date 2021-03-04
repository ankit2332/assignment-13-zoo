using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_13_zoo
{
    class Lion: Animal
    {
        public Lion(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void run()
        {
            Console.WriteLine("I can run!");
        }

    }
}
