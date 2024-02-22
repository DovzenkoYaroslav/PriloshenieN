using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace povtoreniya_n_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите количевство повторений (n):");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сообщение для повторения:");
            string message = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}.{message} ");
            }
            Console.ReadKey();
        }
    }
}
