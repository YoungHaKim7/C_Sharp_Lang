// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Int64 value range 
            Console.WriteLine("Int64 value capacity...");
            Console.WriteLine("Min: {0}, Max: {1}\n", Int64.MinValue, Int64.MaxValue);

            //UInt64 value range 
            Console.WriteLine("UInt64 value capacity...");
            Console.WriteLine("Min: {0}, Max: {1}\n", UInt64.MinValue, UInt64.MaxValue);

            //Int64 array
            Int64[] arr1 = { 	
				-9223372036854775808, 
				0, 
				1287822320009, 
				9223372036854700000, 
				9223372036854775807
			};
            Console.WriteLine("UInt64 array elements...");
            foreach (Int64 num in arr1)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            //UInt64 array
            UInt64[] arr2 = { 	
				0, 
				1239289300, 
				2399900900022, 
				18446744073709000000, 
				1844674407370955161 
			};
            Console.WriteLine("UInt64 array elements...");
            foreach (UInt64 num in arr2)
            {
                Console.WriteLine(num);
            }

            //hit ENTER to exit
            Console.ReadLine();
        }
    }
}

