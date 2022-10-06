using System;

namespace HelloApp
{
    class Program
    {

        static void Main(string[] args)
        {
            string name = "Tom"; int age = 33; //присвоение переменных
            bool isEmployed = false; double weight = 78.65; //присвоение переменных 
            Console.WriteLine($"Имя: {name}"); Console.WriteLine($"Возраст: {age}"); //Вывод указанных данных
            Console.WriteLine($"Вес: {weight}"); Console.WriteLine($"Работает: {isEmployed}"); //Вывод указанных данных
        }
    }
}