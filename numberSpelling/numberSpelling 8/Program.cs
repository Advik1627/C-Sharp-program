using System;
class numberSpelling
{
    public static void Main(string[] args)
    {

        string UserDecision;
        do
        {
            int number, sum = 0, remainder;
            Console.WriteLine("Enter your number: ");
            
            if (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid Input");
            }
            else
            {
                while (number > 0)
                {
                    remainder = number % 10;
                    sum = (sum * 10) + remainder;
                    number = number / 10;
                }
                number = sum;
                while (number > 0)
                {
                    remainder = number % 10;
                    switch (remainder)
                    {
                        case 1:
                            Console.Write(" One ");
                            break;

                        case 2:
                            Console.Write(" Two ");
                            break;

                        case 3:
                            Console.Write(" Three ");
                            break;

                        case 4:
                            Console.Write(" Four ");
                            break;

                        case 5:
                            Console.Write(" Five ");
                            break;

                        case 6:
                            Console.Write(" Six ");
                            break;

                        case 7:
                            Console.Write(" Seven ");
                            break;

                        case 8:
                            Console.Write(" Eight ");
                            break;

                        case 9:
                            Console.Write(" Nine ");
                            break;

                        case 10:
                            Console.Write(" Zero ");
                            break;

                        default:
                            Console.WriteLine(" ");
                            break;
                    }
                    number = number / 10;
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





