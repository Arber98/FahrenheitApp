using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FahrenheitApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FahrenheitApp.Models;

namespace FahrenheitApp.Pages
{
    public class TemperatureModel : PageModel
    {

        public double temperatureCelsius;
        public double temperatureFahrenheit;
        public void OnGet()
        {
        }
        public void OnPost()
        {
            temperatureCelsius = Convert.ToDouble(Request.Form["TemperatureCelsius"]);

            temperatureFahrenheit = Temperature.CelciusToFahrenheit(temperatureCelsius);

        }
    }
}
