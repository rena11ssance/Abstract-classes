using System;

namespace Abstract_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Демонстрация работы:");

            AnimalAbstract dog = new Dog("Шарик");
            AnimalAbstract cat = new Cat("Мурка");

            dog.ShowInfo();
            cat.ShowInfo();
            Console.WriteLine();

            Console.WriteLine("Отдельный вызов метода Say():");
            Console.Write("Собака говорит: ");
            dog.Say();
            Console.Write("Кот говорит: ");
            cat.Say();

            Console.ReadKey();
        }
    }
}