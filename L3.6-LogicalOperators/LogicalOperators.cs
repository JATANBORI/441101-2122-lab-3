using System;

namespace L3._6_LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;
            
            Console.WriteLine("&& and operator");
            Console.WriteLine("The expression " + a + " && " + b + " evaluates to " + (a && b));
            Console.WriteLine("The expression " + b + " && " + a + " evaluates to " + (b && a));	
            Console.WriteLine("The expression " + a + " && " + a + " evaluates to " + (a && a));
            Console.WriteLine("The expression " + b + " && " + b + " evaluates to " + (b && b));

            Console.WriteLine("|| and operator");
            Console.WriteLine("The expression " + a + " || " + b + " evaluates to " + (a || b));
            Console.WriteLine("The expression " + b + " || " + a + " evaluates to " + (b || a));	
            Console.WriteLine("The expression " + a + " || " + a + " evaluates to " + (a || a));
            Console.WriteLine("The expression " + b + " || " + b + " evaluates to " + (b || b));	

            Console.WriteLine("! not operator");
            Console.WriteLine("The expression !" + a + " evaluates to " + !a);
            Console.WriteLine("The expression !" + b + " evaluates to " + !b);	
        }
    }
}
