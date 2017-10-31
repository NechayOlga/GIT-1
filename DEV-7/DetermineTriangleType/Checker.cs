using System;

namespace DetermineTriangleType
{
    public class Checker
    {
        bool checker = false;
        public bool ValidCheck(Sides sides)
        {                    
            if ((sides.sideA < 0)||(sides.sideB < 0)||(sides.sideC < 0))
            {              
                checker = true;
            }
            return checker;
        }
        public bool ExistanceCheck(Sides sides)
        {
            if ((Math.Abs(sides.sideA + sides.sideB) < sides.sideC) || (Math.Abs(sides.sideA + sides.sideC) < sides.sideB)
                                                                   || (Math.Abs(sides.sideB + sides.sideC) < sides.sideA))
            {               
                checker = true;
            }                   
            return checker;
        }
    }
}
