using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Привет мир"; //Присвоение переменной
            Console.WriteLine(hello); Console.WriteLine("Добро пожаловать в C#!"); //Вывод указанных данных
            Console.WriteLine("Пока мир..."); Console.WriteLine(24.5); //Вывод указанных данных
            Console.ReadKey(); //Закрытие прилодения при нажатии
        }
    }
}