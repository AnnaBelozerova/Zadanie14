using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();
            cat.Name = "Мурка";
            cat.ShowInfo();
            dog.Name = "Шарик";
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        public abstract string Name { get; set; }
        
        public Animal(string Name = "Вася")
        {
            this.Name = Name;
        }
        public abstract string Say();
        public void ShowInfo()
        {
            Console.WriteLine("Меня зовут {0}. Я говорю {1}.",Name,Say());
        }

    }
    class Cat : Animal
    {
        string name;
        public string say { get; set; }
        public override string Name
        {
            get 
            {
                return name;
            }
            set 
            {
                name = value;
            }
        }

        public override string Say()
        {
            return "Мяу";
        }
        
    }
    class Dog : Animal
    {
        string name;
        public string say { get; set; }
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public override string Say()
        {
            return "Гав";
        }
    }

}
