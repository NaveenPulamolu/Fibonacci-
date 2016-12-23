using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, limit, num1 = 0, num2 = 1, result = 0;
            Console.Write("Enter the Limit : ");
            limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            for (i = 0; i <= limit; i++)
            {
                result = num1 + num2;
                Console.WriteLine(result);
                num1 = num2;
                num2 = result;
            }
            Console.ReadLine();
        }
    }
}
