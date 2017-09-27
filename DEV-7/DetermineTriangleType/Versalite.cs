namespace DetermineTriangleType
{
    class Versalite:Triangle
    {
        const string VERSALITE = "Triangle is versalite";
        public Versalite(Sides sides) : base(sides) { }
        public override string GetTriangleType()
        {
            return VERSALITE;
        }
    }
}
