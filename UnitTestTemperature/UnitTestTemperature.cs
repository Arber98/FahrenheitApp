using Microsoft.VisualStudio.TestTools.UnitTesting;
using FahrenheitApp.Models;

namespace UnitTestTemperature
{
    [TestClass]
    public class UnitTestTemperature
    {
        [TestMethod]
        public void TestFahrenheitConversion() // Test Case Passed
        {
            double temperatureCelcius = 22;
            double temperatureFahrenheitActual;
            double temperatureFahrenheitExpected = 71.6;

            temperatureFahrenheitActual = Temperature.CelciusToFahrenheit(temperatureCelcius);

            Assert.AreEqual(temperatureFahrenheitExpected, temperatureFahrenheitActual, 0.001, "Temperature conversion not corretly");

        }
        //    [TestMethod]
        //    public void TestFahrenheitConversion1() // Test Case Failed
        //    {
        //        double temperatureCelcius = 22;
        //        double temperatureFahrenheitActual;
        //        double temperatureFahrenheitExpected = 71.6;

        //        temperatureFahrenheitActual = Temperature.CelciusToFahrenheit(temperatureCelcius);

        //        Assert.AreEqual(temperatureFahrenheitExpected, temperatureFahrenheitActual, 0.001, "Temperature conversion not corretly");


        //    }
        //}
    }
}