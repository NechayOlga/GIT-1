using System;

namespace DetermineTriangleType
{
    class EntryPoint
    {
        const string FORMAT_EXCEPTION = "Please, enter only numbers. Try again";
        const string CONTINUE_OR_EXIT = "Press OK to continue, bottom ENTER to exit";
        static void Main(string[] args)
        {
            bool continueProgram = true;
            while (continueProgram)
            {
                try
                {
                    DeterminationOfType determinationOfType = new DeterminationOfType();
                    InputSides inputSide = new InputSides();
                    determinationOfType.firstSide = inputSide.Input();
                    determinationOfType.secondSide = inputSide.Input();
                    determinationOfType.thirdSide = inputSide.Input();
                    Console.WriteLine(determinationOfType.DetermineType());
                    Console.WriteLine(CONTINUE_OR_EXIT);
                    if (Console.ReadLine().Equals("OK"))
                    {
                        continue;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine(FORMAT_EXCEPTION);
                    continue;
                }
                continueProgram = false;
            }
        }
    }
}
