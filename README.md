# Абстрактные классы

Задача. Разработать абстрактный класс Animal, который описывает животное. Класс содержит следующие элементы:

— абстрактное свойство - название животного.

В классе Animal нужно определить следующие методы:

— конструктор, устанавливающий значение по умолчанию для названия;

— абстрактный метод Say(), который выводит звук, который издает животное;

— неабстрактный метод ShowInfo(), который выводит на консоль последовательно название, а затем звук (вызывая метод Say()).

Разработать классы Cat и Dog, которые реализуют абстрактный класс Animal. В классах реализовать следующие элементы:

— свойство – название животного;

— метод Say (), выводящий на экран «Мяу» либо «Гав» соответственно.

Создайте экземпляры классов Cat и Dog и проверьте их работоспособность.

Решение. 
> AnimalAbstract.cs
```
using Abstract_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_classes
{
    abstract class AnimalAbstract
    {
        public abstract string Name { get; set; }

        public AnimalAbstract(string name)
        {
            Name = name;
        }

        public abstract void Say();

        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Say();
        }
        }
    }

class Dog : AnimalAbstract
{
    private string name;
    public override string Name 
    { 
        get => name; 
        set => name = value; 
    }

    public Dog(string name)
        : base(name)
    {
    }

    public override void Say()
    {
        Console.WriteLine("Гав");
    }
}

class Cat : AnimalAbstract
{
    private string name;
    public override string Name
    {
        get => name;
        set => name = value;
    }

    public Cat(string name)
        : base(name)
    {
    }

    public override void Say()
    {
        Console.WriteLine("Мяу");
    }
}

```
___

> Program.cs
```
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

```
___
