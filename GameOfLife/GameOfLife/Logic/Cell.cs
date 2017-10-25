using System;
using System.Collections.Generic;

namespace GameOfLife.Logic
{
    public class Cell
    {
        public bool State { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public override bool Equals(object obj)
        {
            var item = obj as Cell;

            if (item == null)
            {
                return false;
            }
            
            return X.Equals(item.X) && Y.Equals(item.Y);
        }

        public bool IsUnderPopulated(int liveNeighbours)
        {
            return liveNeighbours < 2;
        }

        public bool IsOverPopulated(int liveNeighbours)
        {
            return liveNeighbours > 3;
        }

        public bool CanReproduce(int liveNeighbours)
        {
            return liveNeighbours == 3;
        }

        public double GetAliveNeighbourCount(List<Cell> neighbours)
        {
            var count = 0;
            foreach (var neighbour in neighbours)
            {
                if (neighbour.State) count++;
            }
            return count;
        }
    }
}