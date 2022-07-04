

using System;
class grade
{
    public static void Main(string[] args)
    {

        string UserDecision;
        do
        {
            
            Console.WriteLine("Enter your number: ");
            int score;
            if (!int.TryParse(Console.ReadLine(), out score ))
            {
                Console.WriteLine("Invalid Input");
            }
            else
            { 
                 if (score <= 49)
                {
                    Console.Write(" Your Grade is F ");
                }
                else if (score <= 59)
                {
                    Console.Write(" Your Grade is D ");
                }
                else if (score <= 69)
                {
                    Console.Write(" Your Grade is C");
                }
                else if (score <= 89)
                {
                    Console.Write(" Your Grade is B ");
                }
                else if (score <= 100)
                {
                    Console.Write(" Your Grade is A ");
                }
            } Console.WriteLine();
            
            do
            {
                Console.WriteLine(" Do you want to check another number - YES or NO ? ");
                UserDecision = Console.ReadLine().ToUpper();
                if (UserDecision != "YES" && UserDecision != "NO")
                {
                    Console.WriteLine("Invalid input. Please enter YES or NO.");
                }
                else if (UserDecision == "NO")
                {
                    Console.Clear();
                }
                else if (UserDecision == "YES")
                {
                    Console.Clear();
                }
            }
            while (UserDecision != "YES" && UserDecision != "NO");
        }
        while (UserDecision == "YES");
    }

}





