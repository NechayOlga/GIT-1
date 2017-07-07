using System;

namespace DetermineTriangleType
{
    class InputSides
    {
        const string INCORRECT = "Triangle with nonpositive sides is incorrect. Repeat input for this side, please.";
        const string ENTER_SIDES = "Enter side of triangle: ";
        public double Input()
        {           
            double side = 0;
            bool correctChecker = true;           
            while (correctChecker)
            {
                Console.WriteLine(ENTER_SIDES);
                side = double.Parse(Console.ReadLine());
                if (side <= 0)
                {
                    Console.WriteLine(INCORRECT);
                    continue;
                }
                correctChecker = false;
            }
            return side;
        }
    }
}
