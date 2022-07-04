using System;
class clculator
{
    public static object Consoel { get; private set; }

    static void Main()
    {
        string UserChoice = string.Empty;
        do
        {
            bool incorrect = true;
            while (incorrect)
            {
                Console.WriteLine("Calculator");
                Console.WriteLine("Do you want to \n1. Add \n2. Substract \n3. Multiply \n4. Divide");
                Console.Write("\nEnter choice (1:4)= ");
                int input = int.Parse(Console.ReadLine());
                while (input >= 0 | input < 5 )
                {
                    incorrect = false;
                    Console.ReadLine();
                    {
                        Console.WriteLine("Invalid Option\n");
                        incorrect = true;
                    }break;
                    Console.Clear();
                Start1:
                    Console.Write("A: ");
                    int ValueA;
                    if (!int.TryParse(Console.ReadLine(), out ValueA))
                    {
                        Console.WriteLine("Invalid Input...!");
                        goto Start1;
                    }
                Start2:
                    Console.Write("B: ");
                    int ValueB;
                    if (!int.TryParse(Console.ReadLine(), out ValueB))
                    {
                        Console.WriteLine("Invalid Input...!");
                        goto Start2;
                    }

                    if (input == 1)
                    {
                        Console.WriteLine("\nA+B= " + (ValueA + ValueB));
                    }
                    else if (input == 2)
                    {
                        Console.WriteLine("\nA-B= " + (ValueA - ValueB));
                    }
                    else if (input == 3)
                    {
                        Console.WriteLine("\nAxB= " + (ValueA * ValueB));
                    }
                    else if (input == 4)
                    {
                        Console.WriteLine("\nA/B= " + (ValueA / ValueB));
                    }
                    else if (input > 4)
                    {
                        Console.WriteLine("Invalid input....!");
                    }
                    break;
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