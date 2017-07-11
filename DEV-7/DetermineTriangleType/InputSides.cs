using System;

namespace DetermineTriangleType
{
    class InputSides
    {
        const string ENTER_SIDES = "Enter side of triangle: ";
        public double Input()
        {         
            Console.WriteLine(ENTER_SIDES);
            double side = 0;
            side = double.Parse(Console.ReadLine());
           // sides.sideB = double.Parse(Console.ReadLine());
           // sides.sideC = double.Parse(Console.ReadLine());
            return side;
        }
    }
}
