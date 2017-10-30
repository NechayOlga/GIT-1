using System;

namespace DetermineTriangleType
{
    class Checker
    {
        const string INVALID_RESULT = "Triangle with unpositive sides is invalid";
        const string NOT_EXIST = "Triangle with such sides doesn't exist";
        string resultCheck = String.Empty;
        bool checker = false;
        public bool ValidChecker(Sides sides)
        {                    
            if ((sides.sideA < 0)||(sides.sideB < 0)||(sides.sideC < 0))
            {              
                checker = true;
            }
            return checker;
        }
        public bool ExistanceChecker(Sides sides)
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
