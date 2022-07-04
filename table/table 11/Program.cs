using System;
class table
{
    public static void Main(string[] args)
    {

        string UserDecision;
        do
        {
            int multiplier;
            Console.WriteLine("Please Enter Your number");
            int number;
            if (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine(" Input is invalid");
            }
            else
            {

                for (multiplier = 1; multiplier <= 10; multiplier++)
                {
                    Console.WriteLine("{0} * {1} = {2} ", number, multiplier, (number * multiplier));
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





