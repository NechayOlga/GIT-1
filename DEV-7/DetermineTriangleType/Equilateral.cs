namespace DetermineTriangleType
{
    public class Equilateral:Triangle
    {
        const string EQUILATERAL = "Triangle is equilateral";
        public Equilateral(Sides sides) : base(sides) { }
        public override string GetTriangleType()
        {
            return EQUILATERAL;
        }
    }
}
