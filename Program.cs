using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 0; //размерность матрицы
            bool ok = false;
            Random rnd = new Random();

            while (!ok)
            {
                try
                {
                    Console.WriteLine("Введите размерность матрицы");
                    n = Convert.ToInt32(Console.ReadLine());
                    ok = true;
                }
                catch
                {
                    Console.WriteLine("Число введено неверно, повторите ввод");
                    ok = false;
                }

                if (n < 0)
                {

                    Console.WriteLine("Число не может быть отрицательным");
                    ok = false;
                }
                if (n == 0)
                {
                    Console.WriteLine("Матрица пуста");
                    ok = false;
                }
            }
        
            int j = 0;
            int[,] arr = new int[n, n];


            for (int i = 0; i < n; i++)
            {
                for (j = 0; i < n; i++)
                {
                    arr[i, j] = rnd.Next(0, 2);
                }
            }
            
            int c = 0;
            for (int i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }


            int a=0;

            for (int i = 0; i < n; i++)
            {

                j = 0;
                while (j != n-1)
                {
                    if (arr[i, j] == arr[i, j + 1])
                    {
                        a++;
                        
                    }
                    j++;
                }
                if (a == n)
                {
                    Console.WriteLine(i+1);
                }
                a = 0;

            }
            Console.ReadKey();
        }
    }
}
