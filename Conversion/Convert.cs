// Written by Rogan Helm
using System;using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    public static class Convert
    {
        // Private variables aren't needed here
        public static double GetFahrenheitFromCelcius(double degreesC)
        {
            double degreesF = 0.0;
            if(degreesC >= -273.15)
            {
                degreesF = degreesC * 9.0 / 5.0 + 32.0;
            }
            else
            {
                return double.MaxValue;
            }
            return degreesF;
        }
        public static double GetCelciusFromFahrenheit(double degreesF)
        {
            double degreesC = 0.0;
            if (degreesF >= -459.67)
            {
                degreesC = (degreesF - 32.0) * 5.0 / 9.0;
            }
            else
            {
                return double.MaxValue;
            }
            return degreesC;
        }
    }
}
