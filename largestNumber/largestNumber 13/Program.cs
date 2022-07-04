
using System;
class largestNumber
{
    public static void Main(string[] args)
    {

        string UserDecision;
        do
        {
            Console.WriteLine("Enter first number : ");
            int number1;
            if (!int.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine(" Input is invalid");
            }

            Console.WriteLine("Enter second number: ");
            int number2;
            if (!int.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine(" Input is invalid");
            }

            Console.WriteLine("Enter third number: ");
            int number3;
            if (!int.TryParse(Console.ReadLine(), out number3))
            {
                Console.WriteLine(" Input is invalid");
            }
            else
            {
                if (number1 > number2)
                {
                    if (number1 > number3)
                    {
                        Console.WriteLine(number1 + " is the greatest number.");
                    }
                }
                else if (number2 > number1)
                {
                    if (number2 > number3)
                    {
                        Console.WriteLine(number2 + " is the greatest number.");
                    }

                }
                else
                {
                    Console.WriteLine(number3 + " is the greatest number. ");
                }
                Console.ReadLine();
            }
            Console.WriteLine();

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





