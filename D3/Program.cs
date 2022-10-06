using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Tom"; int age = 34; //Присвоение переменных  
            double height = 1.7; //Присвоение переменной 
            Console.WriteLine($"Имя: {name} Возраст: {age} Рост: {height}м"); //ВЫвод указанных данных
            Console.ReadKey(); //Завершение программы при нажатии
        }
    }
}