using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свое имя: "); //Вывод текста
            string name = Console.ReadLine(); //Присвоение переменной, которая будет считана с верхней строки
            Console.WriteLine($"Привет {name}"); //Вывод казанных данных
            Console.ReadKey(); //Завершение программы при нажатии
        }
    }
}