using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        //Находим квадрат целого числа.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число от 1 до N"); 
            int N2 = Convert.ToInt32(Console.ReadLine());
            int N = 0 ;
            for (int i = 1; i < (N2+1) ; i++)
            {               
                N = N + (2 * i- 1);
                Console.WriteLine("Квадрат числа {0} равен {1}", i, N);
            }
            Console.ReadKey();
        }
    }
}
