using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopFor
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите Число N");
            int n = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            for (int i = 1; i <= n; i++)
            Console.WriteLine(i + ": " + i * i);
            Console.ReadKey();
        }
    }
}

