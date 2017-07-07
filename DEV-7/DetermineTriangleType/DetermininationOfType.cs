using System;

namespace DetermineTriangleType
{
    class DeterminationOfType
    {
        const string NOT_EXIST = "Triangle with such sides doesn't exist. Try again";
        const string EQUILATERAL = "Thiangle is equilateral";
        const string ISOSCELES = "Triangle is isosceles";
        const string VERSALITE = "Triangle is versalite";
        double EPS = Double.Epsilon;
        public double firstSide
        { get; set; }
        public double secondSide
        { get; set; }
        public double thirdSide
        { get; set; }
        string type = String.Empty;

        public string DetermineType()
        {
            if ((firstSide + secondSide < thirdSide) || (secondSide + thirdSide < firstSide) ||
                                                      (thirdSide + firstSide < secondSide))
            {
                type = NOT_EXIST;
            }
            else if ((Math.Abs(firstSide - secondSide) < EPS) && (Math.Abs(firstSide - thirdSide) < EPS) &&
                                                    (Math.Abs(secondSide - thirdSide) < EPS))
            {
                type = EQUILATERAL;
            }
            else if ((Math.Abs(firstSide - secondSide) < EPS) || (Math.Abs(thirdSide - firstSide) < EPS) ||
                                                     (Math.Abs(secondSide - thirdSide) < EPS))
            {
                type = ISOSCELES;
            }
            else
            {
                type = VERSALITE;
            }
            return type;
        }
    }
}

