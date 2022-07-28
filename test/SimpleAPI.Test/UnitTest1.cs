using SimpleAPI.Controllers;
using Moq;
using Microsoft.Extensions.Logging;

namespace SimpleAPI.Test;

public class UnitTest1
{
    private readonly Mock<ILogger<WeatherForecastController>> loggerMock = new Mock<ILogger<WeatherForecastController>>();

    [Fact]
    public void Get_WeatherForecast_Works()
    {
        WeatherForecastController weatherForecastController = new WeatherForecastController(loggerMock.Object);

        var returnValue = weatherForecastController.Get();

        Assert.Equal(5, returnValue.Count());

    }

    [Fact]
    public void Test1()
    {

    }
}