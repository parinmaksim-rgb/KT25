using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace KT25
{
    class DefaultSettings : IInitializable
    {
        public string Theme { get; set; }
        public int Volume { get; set; }

        public DefaultSettings()
        {
            Theme = "Светлая";
            Volume = 50;
        }

        public void Initialize()
        {
            Console.Write("Введите тему (светлая/тёмная): ");
            Theme = Console.ReadLine() ?? "Светлая";

            int volume;

            Console.Write("Введите громкость от 0 до 100: ");
            while (!int.TryParse(Console.ReadLine(), out volume)
                   || volume < 0 || volume > 100)
            {
                Console.Write("Введите число от 0 до 100: ");
            }

            Volume = volume;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Тема: {Theme}, громкость: {Volume}");
        }
    }

}