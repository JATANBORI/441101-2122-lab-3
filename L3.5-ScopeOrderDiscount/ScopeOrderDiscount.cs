using System;

namespace L3._5_ScopeOrderDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the order value.");
            string inputString = Console.ReadLine();
            int value = int.Parse(inputString);
            
            if(value >= 50)
            {
                int discount = 5;
            }
            else
            {
                int discount = 0;
            }
            
            Console.WriteLine("Total cost is " + (value - discount));
        }
    }
}
