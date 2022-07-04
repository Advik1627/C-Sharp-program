using System;
class Diagonal
{
    public static void Main(string[] args)
    {

        string UserDecision;
        do
        {
            Console.WriteLine("Enter your number: ");
            int number;
            if (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid Input");
            }
            else
            {
                int i = 2;
                int a = (int)number;
                if (number % i == 0)
                {
                    Console.WriteLine("not prime number");
                }

                else
                {
                    if (number % a == 0)
                    {
                        Console.WriteLine(" prime number");
                    }
                    Console.ReadLine();
                }
            }


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


