using System.Collections.Generic;
using System.Linq;

namespace GameOfLife.Logic
{
    internal class Universe
    {

        private int height;
        private int width;


        public List<List<Cell>> CreateEmptyWorld(int width, int height)
        {
            var world = new List<List<Cell>>();
            for (var i = 0; i < 4; i++)
                world.Add(Enumerable.Repeat(new Cell(), 4).ToList());
            return world;
        }


    }
}