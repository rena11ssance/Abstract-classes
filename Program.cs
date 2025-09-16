using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalAbstract dog = new Dog("Шарик");
            AnimalAbstract cat = new Cat("Мурка");

            dog.ShowInfo();
            cat.ShowInfo();

            Console.ReadKey();
        }
    }
}
