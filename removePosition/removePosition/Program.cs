
using System;
class removePosition
{
    public static void Main(string[] args)
    {

        string UserDecision = string.Empty;

        do
        {

            Console.Write("Enter the word: ");
            String Word = Console.ReadLine();

            Console.Write("Enter the position of the letter you want to remove: ");
            int Number;
            if (!int.TryParse(Console.ReadLine(), out Number))
            {
                Console.WriteLine("Invalid Input...!");
            }
            else
            {
                String Result = "";

                Result = Word.Substring(0, Number) + Word.Substring(Number + 1);
                Console.WriteLine("Alphabet removed and the out put is= " + Result);
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
