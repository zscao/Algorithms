using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TowersOfHanio
{
    class TowerOfHanio
    {
        private string[] Pegs = { "A", "B", "C" };

        public int Level
        {
            get;
            private set;
        }



        public TowerOfHanio(int level)
        {
            if (level < 1) level = 1;
            this.Level = level;
        }

        public IEnumerable<string> Solve()
        {
            return Move(this.Level, "A", "C");
        }

        private IEnumerable<string> Move(int n, string from, string to)
        {
            var result = new List<string>();

            if (n == 1)
            {
                result.Add($"{n}: {from} -> {to}");
                return result;
            }

            var swap = Pegs.First(x => x != from && x != to);
            result.AddRange(Move(n - 1, from, swap));
            result.Add($"{n}: {from} -> {to}");
            result.AddRange(Move(n - 1, swap, to));

            return result;
        }
    }
}
