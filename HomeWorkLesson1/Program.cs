using System;

namespace HomeWorkLesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как тебя зовут?");
            string userName;
            userName = Console.ReadLine();
            string currentDate = DateTime.Now.Date.ToString();
            Console.WriteLine("Привет, " + userName + ", сегодня " + currentDate);
        }
    }
}
