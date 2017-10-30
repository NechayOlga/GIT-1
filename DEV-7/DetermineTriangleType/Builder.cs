using System;
namespace DetermineTriangleType
{
    public enum TriangleType
    {
        EQUILATERAL,
        ISOSCELES,
        VERSATILE
    }
    public class Builder
    {
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
                case TriangleType.VERSATILE:
                    return new Versatile(sides);
                default:
                    throw new InvalidOperationException();
            }
        }

        public TriangleType DetermineType(Sides sides)
        {
            TriangleType triangleType = TriangleType.VERSATILE;
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


