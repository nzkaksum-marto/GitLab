using System;
using System.Runtime.CompilerServices;

namespace GitExercise
{
    public class Startup
    {
        public static void Main()
        {
<<<<<<< HEAD
            bool isAuthorized = CheckCreditentials();
            if (!isAuthorized)
            {
                Console.WriteLine("Access denied.");
                Console.ReadKey(true);
                return;
            }
            
            Console.WriteLine("Console Calculator App");
=======
            while (true)
            {
                Console.WriteLine("Console Calculator App");
>>>>>>> Dev-B
            Console.WriteLine(new string('-', 15));

            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            Console.WriteLine("Choose one from the listed options:");
            foreach (string option in OptionsManager.OptionsList)
            {
                Console.WriteLine($"\t{option}");
            }

            Console.Write("Option: ");
            string choice = Console.ReadLine();

<<<<<<< HEAD
            switch (choice)
            {
                case "a":
                    OptionsManager.Add(a, b);
                    break;
                case "s":
                    OptionsManager.Subtract(a, b);
                    break;
                case "m":
                    OptionsManager.Multiply(a, b);
                    break;
                case "d":
                    OptionsManager.Divide(a, b);
                    break;
                case "sabs":
                    OptionsManager.SubtractAbs(a, b);
                    break;
=======
                switch (choice)
                {
                    case "a":
                        OptionsManager.Add(a, b);
                        break;
                    case "s":
                        OptionsManager.Subtract(a, b);
                        break;
                    case "m":
                        OptionsManager.Multiply(a, b);
                        break;
                    case "dr":
                        OptionsManager.DivideRemainder(a, b);
                        break;
                    case "ex":
                        Console.Clear();
                        Console.WriteLine("Goodbye");
                        Console.ReadKey(true);
                        return;
                            

                }      
                        
                    
>>>>>>> Dev-B
            }

            Console.WriteLine("Pres any key to continue...");
            Console.ReadKey(true);
            
        }
        private static bool CheckCreditentials()
        {
            Console.Write("Enter password to gain accsses: ");
            string password = Console.ReadLine();
            Console.Clear();
            return password == Password;
        }
        private const string Password = "abcd1234";
    }
}
