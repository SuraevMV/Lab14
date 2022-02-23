using System;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Кошка", "Короткая");
            cat.ShowInfo();

            Dog dog = new Dog("Собака", "Длинная");
            dog.ShowInfo();

            Console.ReadKey();
        }
    }
}
