using System;
class temperature
{
    public static void Main(string[] args)
    {

        string UserDecision;
        do
        {

            Console.WriteLine(" Enter today's temperature: ");
            int temperature;
            if (!int.TryParse(Console.ReadLine(), out temperature))
            {
                Console.WriteLine(" Input is invalid");
            }
            else
            {
                if (temperature < 0)
                {
                    Console.WriteLine(" Freezing weather ");
                }

                else if (temperature <= 10)
                {
                    Console.WriteLine(" Very cold weather ");
                }

                else if (temperature <= 20)
                {
                    Console.WriteLine(" Cold weather ");
                }

                else if (temperature <= 30)
                {
                    Console.WriteLine(" Normal in temperature  ");
                }

                else if (temperature <= 40)
                {
                    Console.WriteLine(" It's hot ");
                }

                else if (temperature >= 40)
                {
                    Console.WriteLine(" It's very hot  ");
                }Console.WriteLine();
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









