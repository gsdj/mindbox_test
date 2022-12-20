namespace FigureLibrary.Figures
{
    public class Triangle : Figure, IRectangular
   {
      public Triangle(double a, double b, double c)
      {
         if (a < 0 || b < 0 || c < 0)
            throw new ArgumentOutOfRangeException("Сторона не может быть отрицательным числом");

         A = a;
         B = b;
         C = c;
      }
      public double A { get; }
      public double B { get; }
      public double C { get; }

      public override double GetFigureArea()
      {
         double p = (A + B + C) / 2;
         return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
      }

      public bool IsRectangular()
      {
         double biggest = A;
         double min1 = B;
         double min2 = C;

         if (B > A)
         {
            biggest = B;
            min1 = A;
         }

         if (C > biggest)
         {
            min2 = biggest;
            biggest = C;
         }

         double result1 = Math.Pow(biggest, 2);
         double result2 = Math.Pow(min1, 2) + Math.Pow(min2, 2);

         return result1 == result2;
      }
   }
}
