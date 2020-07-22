using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FahrenheitApp.Models
{
    public class Temperature
    {
        public static double CelciusToFahrenheit(double Tc)
        {

            double Tf;

            Tf = Tc * 9 / 5 + 32; //Formula ne rregull -- Test Case Passed

            //Tf = 9 / 5 * Tc + 32; // Formula e gabuar -- Test Case Failed

            return Tf;
        }
    }
}
