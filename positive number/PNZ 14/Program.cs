
using System;
class positive
{
    public static void Main(string[] args)
    {

        string UserDecision;
        do
        {

            Console.WriteLine(" Pleasse enter value : ");
            int number;
            if (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine(" Input is invalid");
            }
            else
            {
                if (number < 0)
                {
                    Console.WriteLine(" value is negative. ");
                }
                else if (number == 0)
                {
                    Console.WriteLine(" value is 0. ");
                }
                else
                {
                    Console.WriteLine(" value is positive. ");
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









