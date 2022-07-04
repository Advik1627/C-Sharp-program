


using System;
class minMax
{
    public static void Main(string[] args)
    {

        string UserDecision;
        do
        {

            Console.WriteLine("Enter first number :");
            int number1;
            if (!int.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine(" Input is invalid");
            }

            Console.WriteLine(" Enter second number : ");
            int number2;
            if (!int.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine(" Input is invalid");
            }
            else
            {
                if (number1 > number2)
                {
                    Console.WriteLine(" maximum number : " + number1);
                    Console.WriteLine(" minimum number : " + number2);
                }

                else
                {
                    Console.WriteLine(" maximum number : " + number2);
                    Console.WriteLine(" minimum number : " + number1);
                }
                Console.ReadLine();
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









