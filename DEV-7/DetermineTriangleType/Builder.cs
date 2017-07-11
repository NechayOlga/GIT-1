using System;
namespace DetermineTriangleType
{
    enum TriangleType
    {
        EQUILATERAL,
        ISOSCELES,
        VERSALITE
    }
    class Builder
    {
        
        const string EQUILATERAL = "Triangle is equilateral";
        const string ISOSCELES = "Triangle is isosceles";
        const string VERSALITE = "Triangle is versalite";
        double EPS = Double.Epsilon;
        public Builder(Sides sides)
        {
            double sideA = sides.sideA;
            double sideB = sides.sideB;
            double sideC = sides.sideC;
        }
        public Triangle Build(Sides sides)
        {
            TriangleType triangleType = DetermineType(sides);
            switch (triangleType)
            {
                case TriangleType.EQUILATERAL:
                    return new Equilateral(sides);
                case TriangleType.ISOSCELES:
                    return new Isosceles(sides);
                case TriangleType.VERSALITE:
                    return new Versalite(sides);
                default:
                    throw new InvalidOperationException();
            }
        }

        TriangleType DetermineType(Sides sides)
        {
            TriangleType triangleType = TriangleType.VERSALITE;
            if ((Math.Abs(sides.sideA - sides.sideB) < EPS) && (Math.Abs(sides.sideA - sides.sideC) < EPS) &&
                                                        (Math.Abs(sides.sideB - sides.sideC) < EPS))
            {
                triangleType = TriangleType.EQUILATERAL;
            }
            else if ((Math.Abs(sides.sideA - sides.sideB) < EPS) || (Math.Abs(sides.sideA - sides.sideC) < EPS) ||
                                                         (Math.Abs(sides.sideB - sides.sideC) < EPS))
            {
                triangleType = TriangleType.ISOSCELES;
            }
            return triangleType;
        }
    }
}


