using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Week_3_HW_SLN_2_Triangle
{
    class Program
    {

        // Function to  calculate for validity
        public static bool checkValidity(int a, int b, int c)

        {

            // check condition
            if (a + b <= c || a + c <= b || b + c <= a)
                return false;
            else
                return true;
        }


        //Driver Code
        static void Main()
        {
        

            Console.WriteLine("Enter the length for stick 1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Enter the length for stick 2: ");
            int b = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Enter the length for stick 3: ");
            int c = Convert.ToInt32(Console.ReadLine());
            

            // function calling and print out
            if ((checkValidity(a, b, c)) == true)
            {
                Console.WriteLine("True\n"); //int a = 7, b = 10, c = 5;
                return;
            }

            else
            {
                Console.WriteLine("False\n");
                return;
            }   
        }
    }
}