using System;
using System.Threading;

namespace реакция
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тест на реакцию");
            Console.WriteLine("Вам надо будет ввести букву которую вы увидете на экране");
            Console.WriteLine("Жми Enter ");
            Console.ReadLine();
            Random randomizZnak = new Random();
            char[] Znak = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            Thread.Sleep(randomizZnak.Next(1000, 5000));
            DateTime time = DateTime.Now;
            char znakRandom = Znak[randomizZnak.Next(0, Znak.Length)];
            Console.WriteLine(znakRandom);
            while ((char)Console.ReadKey().KeyChar != znakRandom)
            {
            }
            Console.WriteLine();
            TimeSpan timeCansel = DateTime.Now - time;
            Console.WriteLine($"Время реакции {timeCansel.TotalSeconds} сек");
            Console.WriteLine();
        }
    }
}
