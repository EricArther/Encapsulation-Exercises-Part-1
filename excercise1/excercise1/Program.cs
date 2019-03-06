using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card();

            Console.WriteLine("enter your card information");

            Console.WriteLine();
            Console.Write("name: ");
            card.Name = Console.ReadLine();
            Console.Write("number: ");
            card.Number = Console.ReadLine();
            Console.Write("code: ");
            card.Code = Console.ReadLine();
            Console.Write("date: ");
            card.Date = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"name: {card.Name}");
            Console.WriteLine($"date: {card.Date}");

            Console.ReadKey();
        }

        class Card
        {
            string name;
            string number;
            string code;
            int date;

            public string Name { get { return name; } set { name = value; } }
            public string Number { private get { return number; } set { number = value; } }
            public string Code { private get { return code; } set { code = value; } }
            public int Date { get { return date; } set { date = value; } }
        }
    }
}
