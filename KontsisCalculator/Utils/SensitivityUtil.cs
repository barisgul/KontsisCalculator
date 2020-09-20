using System;
using System.Collections.Generic;
using System.Text;

namespace KontsisCalculator.Utils
{
    public static class SensitivityUtil
    {
        /// <summary>
        /// Virgülden sonra kaç sayı alınacağına dair duyarlılığı hesaplayarak döner
        /// </summary>
        /// <param name="value"></param>
        /// <param name="sensitivity"></param>
        /// <returns></returns>
        public static double Round(double value, int sensitivity)
        {
            return Math.Round(value, sensitivity);
        }
    }
}
