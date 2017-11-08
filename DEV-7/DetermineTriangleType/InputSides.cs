using System;

namespace DetermineTriangleType
{
    public class InputSides
    {
        const string ENTER_SIDES = "Enter side of triangle: ";
        public double Input()
        {         
            Console.WriteLine(ENTER_SIDES);
            double side = 0;
            side = double.Parse(Console.ReadLine());
            return side;
        }
    }
}
