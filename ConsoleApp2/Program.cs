using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int b;
            Random rnd = new Random();
            int a = rnd.Next(1, 10);
            Console.WriteLine ("угадай число от 1 до 10");
            b = int.Parse(Console.ReadLine());

            while (true)
            {
                if (a > b)
                {
                    Console.WriteLine("Слишком мало, попробуй ещё раз");
                    b = int.Parse(Console.ReadLine());
                    
                }
                else if (a < b)
                {
                    Console.WriteLine("Слишком много, попробуй ещё раз");
                    b = int.Parse(Console.ReadLine());
                    
                }
                else
                {
                    Console.WriteLine("Верно!");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
