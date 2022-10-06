using System;
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: "); //Вывод теста
            string name = Console.ReadLine(); //Присвоение переменной, которая будет считана с верхней строки
            Console.Write("Введите возраст: "); //Вывод теста
            int age = Convert.ToInt32(Console.ReadLine()); //Присвоение переменной, которая будет считана с верхней строки
            Console.Write("Введите рост: "); //Вывод теста
            double height = Convert.ToDouble(Console.ReadLine()); //Присвоение переменной, которая будет считана с верхней строки
            Console.Write("Введите размер зарплаты: "); //Вывод теста
            decimal salary = Convert.ToDecimal(Console.ReadLine()); //Присвоение переменной, которая будет считана с верхней строки
            Console.WriteLine($"Имя: {name} Возраст: {age} Рост: {height} м Зарплата: {salary}$"); //Вывлд указанных данных
            Console.ReadKey(); //Завершение программы при нажатии
        }
    }
}