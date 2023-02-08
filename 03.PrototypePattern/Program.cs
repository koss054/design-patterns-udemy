using System;

namespace Coding.Exercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var startPoint = new Point() { X = 0, Y = 0 };
            var endPoint = new Point() { X = 2, Y = 4 };

            var firstLine = new Line()
            {
                Start = startPoint,
                End = endPoint,
            };

            var secondLine = firstLine.DeepCopy();
            secondLine.Start.X = 1;

            Console.WriteLine("First Line");
            Console.WriteLine($"Start: {firstLine.Start.X} {firstLine.Start.Y}");
            Console.WriteLine($"End: {firstLine.End.X} {firstLine.End.Y}");

            Console.WriteLine("Second Line");
            Console.WriteLine($"Start: {secondLine.Start.X} {secondLine.Start.Y}");
            Console.WriteLine($"End: {secondLine.End.X} {secondLine.End.Y}");
        }
    }

    public class Point
    {
        public int X, Y;
    }

    public class Line
    {
        public Point Start, End;

        public Line DeepCopy()
        {
            var line = new Line()
            {
                Start = new Point()
                {
                    X = this.Start.X,
                    Y = this.Start.Y,
                },
                End = new Point()
                {
                    X = this.End.X,
                    Y = this.End.Y,
                }
            };

            return line;
        }
    }
}