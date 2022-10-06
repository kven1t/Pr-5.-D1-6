using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Tom"; int age = 34; //Присвоение переменных
            double height = 1.7; //Присвоение переменной
            Console.WriteLine("Имя: {0} Возраст: {2} Рост: {1}м", name, height, age); //Вывод указанных данных
            Console.ReadKey(); //Завершение программы при нажатии
        }
    }
}