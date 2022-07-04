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
                for (int i = 1; i <= number; i++)
                {
                    for (int a = 1; a <= number - i; a++)
                    {
                        Console.Write(" ");
                    }
                    for (int b = 1; b <= i; b++)
                    {
                        Console.Write(" " + b);
                    }
                    Console.WriteLine();
                }
                for (int i = 1; i <= number; i++)
                {
                    for (int a = number - i; a < number; a++)
                    {
                        Console.Write(" ");
                    }
                    for (int b = 1; b <= number - i; b++)
                    {
                        Console.Write(" " + b);
                    }
                    Console.WriteLine();
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
