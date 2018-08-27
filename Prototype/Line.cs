using System;

namespace DesignPatterns.Prototype
{
    public class Point
    {
      public int X, Y;
    }

    public class Line
    {
      public Point Start, End;

      //Not the best approach but fulfills what asked in the exercise
      public Line DeepCopy()
      {
        return new Line()
        {
            Start = new Point()
            {
                X = this.Start.X,
                Y = this.Start.Y
            },
            End = new Point()
            {
                X = this.End.X,
                Y = this.End.Y
            }
        };
      }

      public override string ToString()
      {
        return $"The Line Starts at point({Start.X},{Start.Y}) and Ends at point({End.X},{End.Y})";
      }
    } 
}