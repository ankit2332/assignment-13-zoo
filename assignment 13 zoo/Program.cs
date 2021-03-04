using System;

namespace assignment_13_zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] zoo = new Animal[3];
            zoo[0] = new Lion("leo", 10, 4);
            zoo[1] = new Fish("Fred", 10, 0);
            zoo[2] = new Eagle("Eddy", 10, 2);
            Lion leo = (Lion)zoo[0];
            Fish Fred = (Fish)zoo[1];
            Eagle Eddy = (Eagle)zoo[2];

            for(int i = 0; i > zoo.Length; i++)
            {
                Console.WriteLine("{0} {1} {2}", zoo[i].getname(), zoo[i].getage());
                zoo[i].speak();
            }

        }
        
    }
}
