﻿namespace _06.FindViolations.Task3
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
