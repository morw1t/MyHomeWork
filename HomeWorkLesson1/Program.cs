using System;

namespace HomeWorkLesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как тебя зовут?");
            string UserName;
            UserName = Console.ReadLine();
            string currentDate = DateTime.Now.Date.ToString();
            Console.WriteLine("Привет, " + UserName + ", сегодня " + currentDate);
        }
    }
}
