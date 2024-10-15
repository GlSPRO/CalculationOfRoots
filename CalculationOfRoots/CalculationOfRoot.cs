using System;
using System.Collections.Generic;

public class CalculationOfRoot
{
    public List<double> FindRoots(double a, double b, double c)
    {
        double discriminant = b * b - 4 * a * c;
        List<double> roots = new List<double>();

        if (discriminant > 0)
        {
            roots.Add((-b + Math.Sqrt(discriminant)) / (2 * a));
            roots.Add((-b - Math.Sqrt(discriminant)) / (2 * a));
        }
        else if (discriminant == 0)
        {
            roots.Add(-b / (2 * a));
        }
        else
        {
            return null;
        }

        return roots;
    }
       
        public double CalculatePercentage(double number, double percentage)
        {
            return (number * percentage) / 100;
        }
}
