using System;
using System.Linq;

namespace TowersOfHanio
{
    class Program
    {
        static void Main(string[] args)
        {
            int level = 3;

            if(args.Length >= 2)
            {
                var arg1 = args[0];
                if(arg1 == "-l" || arg1 == "--level")
                {
                    if (int.TryParse(args[1], out int temp)) level = temp;
                }
            }


            Console.WriteLine($"Towers of Hanio, Level: {level}");

            var tower = new TowerOfHanio(level);
            var solution = tower.Solve();
            foreach (var s in solution)
                Console.WriteLine(s);

            Console.WriteLine($"Done. Total moves: {solution.Count()}");
        }
    }
}
