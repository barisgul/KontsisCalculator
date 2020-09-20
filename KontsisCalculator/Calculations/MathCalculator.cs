using KontsisCalculator.Utils;
using System;

namespace KontsisCalculator.Helpers
{
    public class MathCalculator
    {
        public double Radius { get; set; }
        public double Area { get; set; }

        private readonly double customPi; 

        public MathCalculator(double angle, double heihgt, int sensitiviy)
        {
            customPi = SensitivityUtil.Round(Math.PI, sensitiviy);
            Radius = CalculateRadius(angle, heihgt,sensitiviy);
            Area = CalculateArea(Radius, sensitiviy);
        }

        private double CalculateArea(double radius,int sensitivity)
        {
            double area = customPi * radius * radius;
            return SensitivityUtil.Round(area, sensitivity);
        }

        private double CalculateRadius(double angle, double height, int sensitivity)
        {
            // convert to radian 
            var radianDegree = angle * (customPi / 180);
            var tangent = Math.Tan(SensitivityUtil.Round(radianDegree,sensitivity));

            double radius = SensitivityUtil.Round(tangent, sensitivity) * height;

            return SensitivityUtil.Round(radius, sensitivity);
        }

    }
}
