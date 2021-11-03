using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopWhile
{
    class Program
    {

        static void Main(string[] args)
        {
            int MyValue = 0;
            List<int> myList = new List<int>();
            do
            {
                MyValue = Convert.ToInt16(Console.ReadLine());

                if (MyValue < 0) myList.Add(MyValue);
            } while (MyValue != 0);

            if (myList.Count < 2)
                Console.WriteLine("Последовательность содержит меньше 2 отрицательных элементов");
            else
                Console.WriteLine("Предпоследний отрицательный элемент = {0}", myList[myList.Count - 2]);

            Console.ReadKey();

        }
    }

}