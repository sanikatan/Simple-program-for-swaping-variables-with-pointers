using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySecond__pointer__V2
{
    unsafe class Program
    {
        public static void Switch_val(int* ref1,int* ref2) {
            int HV = *ref1;
            *ref1 = *ref2;
            *ref2 = HV;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("First Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int* p1 = &num1;

            Console.WriteLine("Second Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int* p2 = &num2;

            Console.WriteLine("First number is: " + num1);
            Console.WriteLine("Second number is: " + num2);

            Switch_val(p1,p2);

            Console.WriteLine("First number after the swap is: " + num1);
            Console.WriteLine("Second number after the swap is: " + num2);

            Console.ReadLine();
        }
    }
}
