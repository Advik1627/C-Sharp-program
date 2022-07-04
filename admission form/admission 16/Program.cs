

using System;
class admission
{
    public static void Main(string[] args)
    {

        string UserDecision;
        do
        {
            bool incorrect = true;
            while (incorrect)
            {
                Console.WriteLine(" please enter your mathematics marks : ");
                int mathematics;
                if (!int.TryParse(Console.ReadLine(), out mathematics))
                {
                    Console.WriteLine(" Input is invalid");
                }

                Console.WriteLine(" please enter your physics marks : ");
                int physics;
                if (!int.TryParse(Console.ReadLine(), out physics))
                {
                    Console.WriteLine(" Input is invalid");
                }

                Console.WriteLine(" please enter your chemistry marks : ");
                int chemistry;
                if (!int.TryParse(Console.ReadLine(), out chemistry))
                {
                    Console.WriteLine(" Input is invalid");
                }
                while (mathematics >= 101 | physics < 101 | chemistry >= 101)
                {
          
                        int totalmarks = mathematics + physics + chemistry;
                        int total = (mathematics + physics);
                        int total1 = (mathematics + chemistry);
                        if (mathematics > 100 || physics > 100 || chemistry > 100)
                        {
                            Console.WriteLine(" invalid score ");
                        }
                        else if (totalmarks >= 180)
                        {
                            Console.Write(" You are eligible for admission  ");
                        }
                        else if (total >= 140)
                        {
                            Console.Write(" You are eligible for admission ");
                        }
                        else if (total1 >= 140)
                        {
                            Console.Write(" You are eligible for admission ");
                        }
                        else
                        {
                            Console.WriteLine(" You are not eligible for admission ");
                        }
                        break;
                    }
                }

             Console.WriteLine();
                incorrect = false;

                  {
                    Console.WriteLine("Invalid Option\n");
                    incorrect = true;
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









