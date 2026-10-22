using KT25;
using System;
using System.Collections.Generic;
using System.Text;

namespace KT25
{

    class DefaultUser : IInitializable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public DefaultUser()
        {
            Name = "Гость";
            Age = 18;
        }

        public void Initialize()
        {
            Console.Write("Введите имя пользователя: ");
            Name = Console.ReadLine() ?? "Гость";

            int age;

            Console.Write("Введите возраст: ");
            while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
            {
                Console.Write("Введите корректный возраст: ");
            }

            Age = age;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Имя: {Name}, возраст: {Age}");
        }
    }

}