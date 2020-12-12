using System;
using System.Linq;

namespace PredatorPrey
{
    public class Utils
    {
        public static int GridSize = 20;
        public static int NoTurns = 1000;
        public static int NoSheep = 25;
        public static int NoGrass = 100;
        public static int NoWolves =25;
        public static bool Verbose = false;
        public static Random Rand = new Random();
        public static int DelayBetweenTurns = 5;
        /*        public static int NoTurnsUntilSheepBreeds = 5;
                public static int NoTurnsUntilSheepStarves = 9;
                public static int NoTurnsUntilGrassBreeds = 6;
                public static int NoTurnsUntilWolfBreeds = 5;
                public static int NoTurnsUntilWolfStarves = 4;*/

        public static int NoTurnsUntilSheepBreeds = 2;
        public static int NoTurnsUntilSheepStarves = 3;
        public static int NoTurnsUntilGrassBreeds = 2;
        //   public static int NoTurnsUntilGrassDecays = 5;
        public static int NoTurnsUntilWolfBreeds = 4;
        public static int NoTurnsUntilWolfStarves = 4;

        public static int[] RandomPermutation(int n)
        {
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
                numbers[i] = i;
            int[] randPerm = numbers.OrderBy(x => Rand.Next()).ToArray();
            return randPerm;
        }
    }
}