using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_13_zoo
{
    class Animal
    {
        protected string name;
        protected int age;
        protected string species;
        protected int numebroflegs;
        

        public string getspecies()
        {
            return species;
        }

        public string getname()
        {
            return name;
        }

        public int getage()
        {
            return age;
        }

        public virtual void speak()
        {

        }

    }
}
