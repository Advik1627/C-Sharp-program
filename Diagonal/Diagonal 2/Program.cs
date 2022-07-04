using System;
class NumberTriangle
{
    public static void Main(string[] args)
    {

        string UserChoice = string.Empty;

        do
        {
            bool incorrect = true;
            while (incorrect)
            {
                Console.Write("Please Enter a Number = ");
                string Usernumber = Console.ReadLine();

                if (int.TryParse(Usernumber, out int a))
                {
                    int number = int.Parse(Usernumber);

                    while (number > 0 & number < 15)
                    {
                        for (int i = 1; i <= number; i++)
                        {
                            for (int b = 1; b <= number - i; b++)
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
                            for (int b = number - i; b < number; b++)
                            {
                                Console.Write(" ");
                            }
                            for (int b = 1; b <= number - i; b++)
                            {
                                Console.Write(" " + b);
                            }
                            break;
                            Console.WriteLine();
                        }
                    }
                    incorrect = false;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    incorrect = true;
                }
            }

            do
            {
                Console.WriteLine("Do you want to continue - YES or NO?");

                UserChoice = Console.ReadLine().ToUpper();

                if (UserChoice != "YES" && UserChoice != "NO")
                {
                    Console.WriteLine("Invalid choice, please say Yes or No");
                }

            } while (UserChoice != "YES" && UserChoice != "NO");

            Console.Clear();

        } while (UserChoice == "YES");

        Console.ReadLine();
    }
}
