using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GameOfLife
{
    internal class Universe
    {
        public IEnumerable CreateWorld()
        {
            var world = new List<List<Cell>>();
            for (var i = 0; i < 10; i++)
                world.Add(Enumerable.Repeat(new Cell(), 10).ToList());
            return world;
        }
    }
}