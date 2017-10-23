using System.Collections.Generic;
using System.Linq;

namespace GameOfLife.Logic
{
    internal class Universe
    {

        public List<List<Cell>> CreateWorld()
        {
            var world = new List<List<Cell>>();
            for (var i = 0; i < 10; i++)
                world.Add(Enumerable.Repeat(new Cell(), 10).ToList());
            return world;
        }


    }
}