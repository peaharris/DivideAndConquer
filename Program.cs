using System;

namespace Demo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool shouldIWorryAboutDivideByZero = true;

            try
            {
                Console.Write("Enter A Number: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter Another Number: ");
                int num2 = int.Parse(Console.ReadLine());

                int num3 = num1 / num2;
                Console.Write($"{num1} / {num2} = {num3}");

                int remainder = num1 % num2;
                Console.WriteLine($" Remainder {remainder}");

                Console.WriteLine("All Done");
            }
            catch (DivideByZeroException dbze) when (shouldIWorryAboutDivideByZero)
            {
                Console.WriteLine("You tried to divid by zero.");
                Console.WriteLine(dbze.Message);
                Console.WriteLine(dbze.ToString());
            }

            catch (FormatException fe)
            {
                Console.WriteLine("That's not a number");
            }

            catch (SystemException se)
            {
                Console.WriteLine("Some system exception just happened");
            }

            catch (Exception e)
            {
                Console.WriteLine("Something bad just happened");
            }

            finally// finally is ALWAYS executed
            {
                Console.WriteLine("Whew! ! ! That Was Treacherous");
            }

            Console.WriteLine("All All done");
        }
    }
}
