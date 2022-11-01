using Xunit;
using demoapp.Controllers;

namespace demoapp.tests;

public class WeatherForecastController_Tests
{
    [Fact]
    public void Get_ShouldReturnStringResponse()
    {
        var sut = new WeatherForecastController();

        var response = sut.Get();

        Assert.Contains("Temperature", response);
    }
}