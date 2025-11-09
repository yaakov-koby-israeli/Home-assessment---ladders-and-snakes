using System;

namespace Ladders_and_snakes_game.Utilities
{
    internal static class RandomProvider
    {
        private static readonly Random _random = new Random();

        // Public property to access the single Random instance
        public static Random Instance => _random;
    }
}