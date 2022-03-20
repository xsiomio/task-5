using System;

namespace task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Азамат";
            string surname = "Тулендинов";

            Console.WriteLine(name +" "+ surname);
            (name, surname) = (surname, name);
            Console.WriteLine(name + " " + surname);
        }
    }
}
