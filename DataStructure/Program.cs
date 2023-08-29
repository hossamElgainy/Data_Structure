using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
                       
            balancedParencess b = new balancedParencess();
            
            Console.Write("Enter An Expression:");
            string Expression = Console.ReadLine();
            if(b.AreBalanced(Expression))
                Console.WriteLine("Balanced");
            else
                Console.WriteLine("Not Balanced");
            

        }
    }
}
