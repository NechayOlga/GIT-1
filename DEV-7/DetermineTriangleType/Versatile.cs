namespace DetermineTriangleType
{
    class Versatile:Triangle
    {
        const string VERSALITE = "Triangle is versalite";
        public Versatile(Sides sides) : base(sides) { }
        public override string GetTriangleType()
        {
            return VERSALITE;
        }
    }
}
