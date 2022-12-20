namespace FigureLibrary.Figures
{
    public class Circle : Figure
    {
      public Circle(double r)
      {
         if (r < 0)
            throw new ArgumentOutOfRangeException("Радиус не может быть отрицательным числом");

         Radius = r;
      }
      public double Radius { get; }

      public override double GetFigureArea()
      {
         return Math.PI * Math.Pow(Radius, 2);
      }
   }
}
