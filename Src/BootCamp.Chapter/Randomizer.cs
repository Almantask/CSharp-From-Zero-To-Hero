using System;

namespace BootCamp.Chapter.Examples
{
    public interface IRandomiser
    {
        int Next(int maxValue);
    }

    public class Randomizer : IRandomiser
    {
        private readonly Random _random;

        private static readonly Lazy<IRandomiser> 
            _instance = new Lazy<IRandomiser>
                (() => new Randomizer());

        public static IRandomiser Instance => _instance.Value;

        private Randomizer() => _random = new Random();

        public int Next(int maxValue) => _random.Next(maxValue);
    }
}
