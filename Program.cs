using System;

namespace Lesson0
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new(161, 50, DateTime.Parse("12.12.12"), "vanya", "vanin");
            person.ChangeHeight(166);
            Console.WriteLine(person);
        }
    }
}
