using System;
using BootCamp.Chapter.Examples.InvoiceIssuer;
using BootCamp.Chapter.Examples.Simulation;
using Moq;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class WeatherGeneratorTests
    {
        [Theory]
        [InlineData(100, 0, Weather.Rainy)]
        [InlineData(0, 100, Weather.Sunny)]
        [InlineData(0, 0, Weather.Cloudy)]
        public void GenerateWeather_Given_Chance_Returns_Expected_Weather(int probabilityOfRain, int probabilityOfSun, Weather expectedWeather)
        {
            var simulator = new WeatherSimulator(probabilityOfRain, probabilityOfSun);

            var weather = simulator.GenerateWeather();

            Assert.Equal(expectedWeather, weather);
        }

        [Fact]
        public void New_When_PosibiliiesOfWeather_Exceed_100_Throws_InvalidWeatherSimulationException()
        {
            Action action = () => new WeatherSimulator(100, 1);
            void Create() => new WeatherSimulator(100, 1);

            Assert.Throws<InvalidWeatherSimulationException>(Create);
        }
    }
}
