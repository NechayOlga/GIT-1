namespace DetermineTriangleType
{ 
   abstract class Triangle
   {
        public Sides Sides
        { get; }
        public Triangle (Sides sides)
        {
            Sides = sides;
        }
        public abstract string GetTriangleType();        
   }
}
