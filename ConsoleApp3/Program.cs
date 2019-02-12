using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = "3456734567";
            string num1 = "2152112";

            int sum=0;
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < num.Length; i++)
            {
                sum += Convert.ToInt32(num[i]);
                Console.WriteLine(num[i]);
            }
            Console.WriteLine(sum);

            for (int i = 0; i < num1.Length; i++)
            {
                sum1 += Convert.ToInt32(num1[i]);
            }

            sum2 = sum + sum1;

            Console.WriteLine(sum2);
        }
    }
}
