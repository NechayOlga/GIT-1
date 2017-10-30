using System;

namespace DetermineTriangleType
{
    class Entrypoint
    {
        const string FORMAT_EXCEPTION = "Please, enter only numbers. Try again";
        const string CONTINUE_OR_EXIT = "Press OK to continue, press any key and ENTER to exit";
        const string INVALID_RESULT = "Triangle with unpositive sides is invalid";
        const string NOT_EXIST = "Triangle with such sides doesn't exist";
        static void Main(string[] args)
        {
            bool continueProgram = true;
            while (continueProgram)
            {
                try
                {
                    InputSides inputSides = new InputSides();
                    Sides sides;
                    sides.sideA = inputSides.Input();
                    sides.sideB = inputSides.Input();
                    sides.sideC = inputSides.Input();
                    Checker checker = new Checker();
                    if (checker.ValidChecker(sides))
                    {
                        Console.WriteLine(INVALID_RESULT);
                        continue;
                    }
                    if (checker.ExistanceChecker(sides))
                    {
                        Console.WriteLine(NOT_EXIST);
                        continue;
                    }
                    Builder builder = new Builder(sides);
                    Triangle triangle = builder.Build(sides);
                    Console.WriteLine(triangle.GetTriangleType());
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
