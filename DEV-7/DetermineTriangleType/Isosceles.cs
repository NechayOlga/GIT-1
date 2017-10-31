namespace DetermineTriangleType
{
    public class Isosceles:Triangle
    {
        const string ISOSCELES = "Triangle is isosceles";
        public Isosceles(Sides sides) : base(sides) { }
        public override string GetTriangleType()
        {
            return ISOSCELES;
        }
    }
}
