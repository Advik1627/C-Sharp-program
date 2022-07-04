
using System;
class alphabeTriangle
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
                        char character = 'A';
                        for (int i = 0; i < number; i++)
                        {
                            for (int a = 0; a <= number - i; a++)
                            {
                                Console.Write(" ");
                            }
                            for (int b = 0; b <= i; b++)
                            {
                                Console.Write(character++);
                            }
                            character--;

                            for (int c = i - 1; c >= 0; c--)
                            {
                                Console.Write(--character);
                            }
                            Console.WriteLine();
                        }
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





