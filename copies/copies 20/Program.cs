using System;
class FourCopyString
{
    public static void Main(string[] args)
    {

        string UserDecision;
        do
        {
            Console.WriteLine("Enter your string: ");
            string sample = Console.ReadLine();
            if (sample.Length < 2)
            {
                Console.WriteLine("Entered string's length is less than 2. So the output is: " + sample);
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    string result = sample.Substring(0, 2);
                    Console.Write(result);
                }

            }
            Console.ReadLine();
            Console.WriteLine(" Do you want to check another number - YES or NO ? ");
            UserDecision = Console.ReadLine().ToUpper();
            if (UserDecision == "NO")
            {
                Console.Clear();
            }
            else if (UserDecision == "YES")
            {
                Console.Clear();
            }
            else if (UserDecision != "YES" && UserDecision != "NO")
            {
                Console.WriteLine("Invalid decision made!");
            }
        }
        while (UserDecision == "YES");

    }
}
