using System;

namespace SF3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name!");
            var name = Console.ReadLine();
            Console.WriteLine("Enter your age!");
            var age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your name is {0}!! But your age is {1}!!!", name, age);

            //Console.WriteLine("Сообщи день недели!");
            //var myday = (DaysOfWeek) int.Parse(Console.ReadLine());
            //Console.WriteLine("День недели - {0}", myday);

            Console.WriteLine("Сообщи дату рождения!");
            var birthdate = Console.ReadLine();
            Console.WriteLine("День рождения - {0}, якобы.", birthdate);

            Console.ReadKey();
        }
    }
    enum DaysOfWeek : byte
    {
        Понедельник = 1,
        Вторник,
        Среда,
        Четверг,
        Пятница,
        Суббота,
        Воскресенье
    }
}
