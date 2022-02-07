using ConsoleApp1.src.Entities;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 12, "Knight");
            Wizard wizard = new Wizard("Jenica", 23, "White Wizard");

            Console.WriteLine(arus.Atack());
            Console.WriteLine(wizard.Atack(1));
            Console.WriteLine(wizard.Atack(7));

        }

    }
}
