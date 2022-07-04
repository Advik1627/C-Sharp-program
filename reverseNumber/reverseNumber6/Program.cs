using System;
class reverseNumber
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
                int reverse = 0;
                while (number > 0)
                {
                    int reminder = number % 10;
                    reverse = reminder;
                    number = number / 10;
                    Console.Write(reverse);
                }
            }Console.WriteLine();
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





