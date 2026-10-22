using System;

namespace KT25
{
    class Program
    {
        static T CreateAndInitialize<T>()
            where T : IInitializable, new()
        {
            T obj = new T();
            obj.Initialize();
            return obj;
        }

        static void Main()
        {
            Console.WriteLine("Создание пользователя");

            DefaultUser user =
                CreateAndInitialize<DefaultUser>();

            user.ShowInfo();

            Console.WriteLine();

            Console.WriteLine("Создание настроек");

            DefaultSettings settings =
                CreateAndInitialize<DefaultSettings>();

            settings.ShowInfo();

            Console.ReadLine();
        }
    }
}