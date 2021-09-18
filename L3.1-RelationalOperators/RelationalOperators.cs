using System;

namespace L3._1_RelationalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;
            int c = 10;
            
            Console.WriteLine("> Greater Than");
            Console.WriteLine("The expression " + a + " > " + b + " evaluates to " + (a > b));
            Console.WriteLine("The expression " + b + " > " + a + " evaluates to " + (b > a));	
            Console.WriteLine("The expression " + a + " > " + c + " evaluates to " + (a > c));
            
            Console.WriteLine("< Less Than");
            Console.WriteLine("The expression " + a + " < " + b + " evaluates to " + (a < b));
            Console.WriteLine("The expression " + b + " < " + a + " evaluates to " + (b < a));	
            Console.WriteLine("The expression " + a + " < " + c + " evaluates to " + (a < c));
            
            Console.WriteLine(">= Greater Than or Equal To");
            Console.WriteLine("The expression " + a + " >= " + b + " evaluates to " + (a >= b));
            Console.WriteLine("The expression " + b + " >= " + a + " evaluates to " + (b >= a));	
            Console.WriteLine("The expression " + a + " >= " + c + " evaluates to " + (a >= c));
            
            Console.WriteLine("<= Less Than or Equal To");
            Console.WriteLine("The expression " + a + " <= " + b + " evaluates to " + (a <= b));
            Console.WriteLine("The expression " + b + " <= " + a + " evaluates to " + (b <= a));	
            Console.WriteLine("The expression " + a + " <= " + c + " evaluates to " + (a <= c));

            Console.WriteLine("== Equal To");
            Console.WriteLine("The expression " + a + " == " + b + " evaluates to " + (a == b));
            Console.WriteLine("The expression " + b + " == " + a + " evaluates to " + (b == a));	
            Console.WriteLine("The expression " + a + " == " + c + " evaluates to " + (a == c));

            Console.WriteLine("!= Not Equal To");
            Console.WriteLine("The expression " + a + " != " + b + " evaluates to " + (a != b));
            Console.WriteLine("The expression " + b + " != " + a + " evaluates to " + (b != a));	
            Console.WriteLine("The expression " + a + " != " + c + " evaluates to " + (a != c));		
        }
    }
}
