using System;

namespace ImplicitExplicit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a value in lbs");
            var lbsText = Console.ReadLine();
 
            var lbs = new Pounds(float.Parse(lbsText));
            Console.WriteLine($"\nYou entered {lbs}");
 
            Kilogram kg =  (Kilogram) lbs;
            Console.WriteLine($"\n{lbs} is {kg}");
 
            Console.WriteLine("\nPress enter to exit");
            Console.ReadLine();
        }
    }
    
}