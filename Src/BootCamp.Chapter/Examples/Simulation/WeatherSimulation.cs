using System;

namespace BootCamp.Chapter.Examples.Simulation
{
    public class WeatherSimulator
    {
        private readonly IRandomiser _randomizer;
        private readonly int _probabilityOfRain;
        private readonly int _probabilityOfSun;

        public WeatherSimulator(int probabilityOfRain, int probabilityOfSun)
        {
            _randomizer = Randomizer.Instance;

            if (probabilityOfRain + probabilityOfSun > 100)
            {
                throw new InvalidWeatherSimulationException(probabilityOfRain, probabilityOfSun);
            }

            _probabilityOfRain = probabilityOfRain;
            _probabilityOfSun = probabilityOfSun;
        }

        public Weather GenerateWeather()
        {
            var value = _randomizer.Next(101);
            switch (value)
            {
                case int n when n >= 100 - _probabilityOfSun:
                    return Weather.Sunny;
                case int n when n >= 100 - _probabilityOfSun - _probabilityOfRain:
                    return Weather.Rainy;
                default:
                    return Weather.Cloudy;
            }
        }
    }

    public class InvalidWeatherSimulationException : Exception
    {
        public InvalidWeatherSimulationException(int probabilityOfRain, int probabilityOfSun) : base($"Sum of probabilities cannot exceed 100%. {probabilityOfRain} + {probabilityOfSun} = {probabilityOfRain + probabilityOfSun}")
        {
        }
    }

    public enum Weather
    {
        Sunny,
        Rainy,
        Cloudy
    }
}
