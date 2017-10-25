using System.Collections.Generic;
using GameOfLife.Logic;

namespace GameOfLife.Tests
{
    internal class NeighbourFetcher
    {
        private List<List<Cell>> _world;
        private int _x;
        private int _y;


        public List<Cell> GetAllNeighbours(List<List<Cell>> world, Cell targetCell)
        {
            _world = world;
            _x = targetCell.X;
            _y = targetCell.Y;

            return new List<Cell>()
            {
                GetBottomLeftNeighbour(),
                GetBottomMidNeighbour(),
                GetBottomRightNeighbour(),
                GetMidLeftNeighbour(),
                GetMidRightNeighbour(),
                GetTopLeftNeighbour(),
                GetTopMidNeighbour(),
                GetTopRightNeighbour()
            };


        }

        private Cell GetTopLeftNeighbour()
        {
            return _world[_x - 1][_y - 1];
        }
        private Cell GetTopMidNeighbour()
        {
            return _world[_x][_y - 1];
        }
        private Cell GetTopRightNeighbour()
        {
            return _world[_x + 1][_y - 1];
        }
        private Cell GetMidLeftNeighbour()
        {
            return _world[_x - 1][_y];
        }
        private Cell GetMidRightNeighbour()
        {
            return _world[_x + 1][_y];
        }
        private Cell GetBottomLeftNeighbour()
        {
            return _world[_x - 1][_y + 1];
        }
        private Cell GetBottomMidNeighbour()
        {
            return _world[_x][_y + 1];
        }
        private Cell GetBottomRightNeighbour()
        {
            return _world[_x + 1][_y + 1];
        }
    }
}