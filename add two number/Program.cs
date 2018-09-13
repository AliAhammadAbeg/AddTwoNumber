using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_two_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("result of addition :"+(firstNumber+secondNumber));
            

            Console.ReadKey();
        }
    }
}
